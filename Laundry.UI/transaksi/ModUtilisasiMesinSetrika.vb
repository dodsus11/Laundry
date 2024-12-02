Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModUtilisasiMesinSetrika

    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Dim dv As New DataView

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        AddHandler BrowseTemp.getTextBox.TextChanged, AddressOf txtFind_TextChanged
        AddHandler BrowseTemp.getBtnNew.Click, AddressOf btnNew_Click
        AddHandler BrowseTemp.getBtnEdit.Click, AddressOf btnEdit_Click
        'AddHandler BrowseTemp.getBtnDelete.Click, AddressOf btnDelete_Click
        AddHandler BrowseTemp.getGridView.MouseClick, AddressOf gv_click
    End Sub

    Private Sub ModUtilisasiMesinSetrika_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BrowseTemp.getTitle.Text = "Utilisasi Mesin Setrika"
        Dim acl As SessionInfo.ACLUser = CType(Me.Tag, SessionInfo.ACLUser)
        'BrowseTemp.getBtnNew.Enabled = acl.allowSave
        BrowseTemp.getBtnEdit.Enabled = acl.allowEdit
        BrowseTemp.getBtnDelete.Visible = False
        BrowseTemp.getBtnEdit.Text = "View"
        'BrowseTemp.getBtnDelete.Enabled = acl.allowDelete

        Me.generateTable()
    End Sub

    Private Sub generateTable()
        Dim tanggal As Date
        tanggal = Today
        'setup gridview supaya tidak dimainkan sembarangan
        BrowseTemp.getGridView.AllowAddNew = False
        BrowseTemp.getGridView.AllowDelete = False
        BrowseTemp.getGridView.AllowUpdate = False                

        utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()

        'Dim headers() As String = {"Id", "Tanggal", "Kode Mesin", "Nama Mesin", "Lot Ke", "Kode Linen", "Linen", "Bersih (lbr)", "Rusak (lbr)", "Reject (lbr)", "Jumlah (lbr)", "Operator"}
        'Dim lebar() As Integer = {50, 100, 100, 100, 80, 0, 100, 80, 80, 80, 80, 100}
        Dim headers() As String = {"Id", "Tanggal", "Kode Mesin", "Nama Mesin", "Lot Ke", "Operator"}
        Dim lebar() As Integer = {50, 100, 100, 100, 80, 100}

        dv.Table = utilmesinsetrikaSvr.getUtilMesinSetrika(tanggal)
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(utilmesinsetrikaSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("operatormesin LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcUtilisasiMesinSetrikaNew
        Dim objUtilmesinSetrika As New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = Nothing, .tanggal = Nothing, .kode_mesin = "", .nama_mesin = "", .load_ke = Nothing, .operator_mesin = ""}
        uc.utilmesinsetrika = objUtilmesinSetrika
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UcUtilisasiMesinSetrikaNew
            Dim objUtilmesinsetrika As New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = BrowseTemp.getGridView.Columns("id").Text,
                                                                    .tanggal = BrowseTemp.getGridView.Columns("tanggal").Text,
                                                                    .kode_mesin = BrowseTemp.getGridView.Columns("kodemesin").Text,
                                                                    .nama_mesin = BrowseTemp.getGridView.Columns("namamesin").Text,
                                                                    .load_ke = BrowseTemp.getGridView.Columns("loadke").Text,
                                                                    .operator_mesin = BrowseTemp.getGridView.Columns("operatormesin").Text}
            '.kodelinen = BrowseTemp.getGridView.Columns("kodelinen").Text,
            '.linen = BrowseTemp.getGridView.Columns("linen").Text,
            '.jumlah_linen = BrowseTemp.getGridView.Columns("jmllinen").Text,
            '.jumlah_linen_bersih = BrowseTemp.getGridView.Columns("linenbersih").Text,
            '.jumlah_linen_rusak = BrowseTemp.getGridView.Columns("linenrusak").Text,
            '.jumlah_linen_reject = BrowseTemp.getGridView.Columns("linenreject").Text,
            '.operator_mesin = BrowseTemp.getGridView.Columns("operatormesin").Text}
            uc.utilmesinsetrika = objUtilmesinsetrika

            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id").Text = "" Then
            MsgBox("Anda belum memilih data")
        Else
            If MsgBox("Anda ingin menghapus data  " & BrowseTemp.getGridView.Columns("id").Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Dim tempData As String = BrowseTemp.getGridView.Columns("id").Text
                Try
                    utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
                    utilmesinsetrikaSvr.deleteUtilMesinSetrika(New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = BrowseTemp.getGridView.Columns("id").Text})

                    MsgBox("Data " & tempData & " berhasil dihapus")
                    Me.generateTable()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(utilmesinsetrikaSvr)
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
