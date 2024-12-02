Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModLinenTransIn

    Private linenSvr As ILinenService
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

    Private Sub ModInsertLinen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BrowseTemp.getTitle.Text = "Persediaan : Linen Masuk"
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        BrowseTemp.getBtnNew.Enabled = acl.allowSave
        BrowseTemp.getBtnEdit.Enabled = acl.allowEdit

        BrowseTemp.getBtnDelete.Enabled = acl.allowDelete
        Me.generateTable()
    End Sub

    Private Sub generateTable()

        'setup gridview supaya tidak dimainkan sembarangan
        BrowseTemp.getGridView.AllowAddNew = False
        BrowseTemp.getGridView.AllowDelete = False
        BrowseTemp.getGridView.AllowUpdate = False

        linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()

        Dim headers() As String = {"No Trans", "Tgl Transaksi", "Keterangan", "User"}
        Dim lebar() As Integer = {100, 200, 300, 200}

        dv.Table = linenSvr.getItemMasuk()
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(linenSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("entry_by LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UCLinenTransIn
        Dim objTransIn As New TransIn With {.idTransIn = Nothing, .tglTI = Nothing, .ketTI = "", .entryByTI = ""}
        uc.header = objTransIn
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("trans_in_id").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UCLinenTransIn
            Dim objHeaderTransIn As New TransIn With {.idTransIn = BrowseTemp.getGridView.Columns("trans_in_id").Text,
                                                     .tglTI = BrowseTemp.getGridView.Columns("trans_in_tgl").Text,
                                                     .ketTI = BrowseTemp.getGridView.Columns("ket").Text,
                                                     .entryByTI = BrowseTemp.getGridView.Columns("entry_by").Text
                                                     }
            uc.header = objHeaderTransIn
            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("trans_in_id").Text = "" Then
            MsgBox("Anda belum memilih data")
        Else
            Dim stoklinen As Integer            
            linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
            stoklinen = linenSvr.cekStokLinenByTransId(BrowseTemp.getGridView.Columns("trans_in_id").Text)
            If stoklinen > 0 Then
                MessageBox.Show("Stok gudang linen tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim FormCancel As New FormCancelTrans
                Dim objHeaderTransIn As New TransaksiDelete With {.idTransaksi = BrowseTemp.getGridView.Columns("trans_in_id").Text, .jenisTransaksi = 1}
                FormCancel.header = objHeaderTransIn
                FormCancel.ShowDialog(Me)
                Me.generateTable()
            End If
        End If
    End Sub

    Private Sub gv_click(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            BrowseTemp.getGridView().SetActiveCell(BrowseTemp.getGridView().RowContaining(e.Y), 0)
            Dim mnu As New ContextMenuStrip()
            Dim mnuItem1 As New ToolStripMenuItem("Edit", Nothing, AddressOf btnEdit_Click)
            'Dim mnuItem2 As New ToolStripMenuItem("Delete", Nothing, AddressOf btnDelete_Click)

            If BrowseTemp.getBtnEdit.Enabled Then
                mnu.Items.AddRange(New ToolStripItem() {mnuItem1})
            End If
            'If BrowseTemp.getBtnDelete.Enabled Then
            '    mnu.Items.AddRange(New ToolStripItem() {mnuItem2})
            'End If

            Dim mypoint As Point = BrowseTemp.getGridView().PointToClient(Control.MousePosition)

            mnu.Show(BrowseTemp.getGridView(), mypoint.X, mypoint.Y)
        End If
    End Sub


End Class
