Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModInputLoadGudang

    Private loadSvr As ILoadGudangService
    Dim dv As New DataView

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        AddHandler BrowseTemp.getTextBox.TextChanged, AddressOf txtFind_TextChanged
        AddHandler BrowseTemp.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler BrowseTemp.getBtnEdit.Click, AddressOf btnEdit_Click
        AddHandler BrowseTemp.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler BrowseTemp.getGridView.MouseClick, AddressOf gv_click
    End Sub

    Private Sub ModLoadGudang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BrowseTemp.getTitle.Text = "Load Gudang"
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        BrowseTemp.getBtnNew.Enabled = acl.allowSave
        BrowseTemp.getBtnEdit.Enabled = acl.allowEdit
        BrowseTemp.getBtnDelete.Enabled = acl.allowDelete

        Me.generateTable()
    End Sub

    Private Sub generateTable()
        Dim tanggal As Date
        tanggal = Today
        'setup gridview supaya tidak dimainkan sembarangan
        BrowseTemp.getGridView.AllowAddNew = False
        BrowseTemp.getGridView.AllowDelete = False
        BrowseTemp.getGridView.AllowUpdate = False

        loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()

        Dim headers() As String = {"NO", "ID", "TGL ORDER", "JAM ORDER", "JUMLAH JNS LINEN", "PETUGAS"}
        Dim lebar() As Integer = {30, 100, 100, 100, 200, 200}

        dv.Table = loadSvr.getLoadgudangHeader(Date.Now, Date.Now)
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(loadSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("namaPetugas LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcInputLoadGudang
        'Dim header As New OrderHeader
        Dim objHeaderOrder As New LoadGudangHeader With {.idHeaderLoadGudang = Nothing, .namaPetugas = "", .tanggal = Nothing, .jam = Nothing}
        uc.header = objHeaderOrder
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UcInputLoadGudang
            Dim objHeaderOrder As New LoadGudangHeader With {.idHeaderLoadGudang = BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text,
                                                     .namaPetugas = BrowseTemp.getGridView.Columns("namaPetugas").Text,
                                                     .tanggal = BrowseTemp.getGridView.Columns("tanggal").Text,
                                                     .jam = TimeSpan.Parse(BrowseTemp.getGridView.Columns("jam").Text)}
            uc.header = objHeaderOrder

            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text = "" Then
            MsgBox("Anda belum memilih data")
        Else
            If MsgBox("Anda ingin menghapus data  " & BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Dim stoklinen As Integer
                loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
                stoklinen = loadSvr.cekStokLinenByIdLoadGudang(BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text)
                If stoklinen > 0 Then
                    MessageBox.Show("Stok gudang linen tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim tempData As String = BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text
                    Try
                        loadSvr.penguranganStokLinenByIdLoadGudang(BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text)  'mengurangi stok gudang/master linen
                        loadSvr.deleteLoadgudangHeader(New LoadGudangHeader With {.idHeaderLoadGudang = BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text, .flag = "0"}) 'update cancel loadgudangheader                        
                        loadSvr.editFlagCancelLoadGudangByIdLoadGudang(BrowseTemp.getGridView.Columns("idHeaderLoadGudang").Text)  'update cancel loadgudangdetail
                        MsgBox("Data " & tempData & " berhasil dihapus")
                        Me.generateTable()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If                
                InProcFactory.CloseChannel(loadSvr)
            End If
        End If
    End Sub

    Private Sub gv_click(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)
            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf btnEdit_Click)
            Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf btnDelete_Click)

            If BrowseTemp.getBtnEdit.Enabled Then
                mnu.Items.AddRange(New ToolStripItem() {mnuItem1})
            End If
            If BrowseTemp.getBtnDelete.Enabled Then
                mnu.Items.AddRange(New ToolStripItem() {mnuItem2})
            End If

            Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

            mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)
        End If
    End Sub

End Class
