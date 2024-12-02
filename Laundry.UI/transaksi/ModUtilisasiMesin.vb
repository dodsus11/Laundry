Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModUtilisasiMesin

    Private utilmesinSvr As IUtilmesinService
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
        BrowseTemp.getTitle.Text = "Utilisasi Mesin Cuci"
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
        BrowseTemp.getGridView().Dock = DockStyle.Fill
        BrowseTemp.getGridView.AllowAddNew = False
        BrowseTemp.getGridView.AllowDelete = False
        BrowseTemp.getGridView.AllowUpdate = False

        utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()

        Dim headers() As String = {"Id Mesin", "Nama Mesin", "Kapasitas Mesin", "Load mesin", "Id Utilisasi", "Tanggal", "Linen (Kg)", "Alkalin (ml)", "Detergen (ml)", "Oxygenbleach (ml)", "Softener (ml)", "Penetral (ml)", "Mulai", "Selesai", "Jenis Linen", "Id Opr", "Operator"}
        Dim lebar() As Integer = {60, 100, 0, 80, 80, 70, 80, 80, 90, 130, 90, 90, 70, 60, 60, 90, 0, 100}

        dv.Table = utilmesinSvr.getUtilMesin(tanggal)
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(utilmesinSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("nama_mesin LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcUtilisasiMesin
        Dim objUtilmesin As New Util_Mesin With {.utilisasi_mesin_cuci_id = Nothing, .nama_mesin = Nothing, .berat_linen = Nothing, .pembersih1 = "", .pembersih2 = "", .pembersih3 = "", .pembersih4 = "", .pembersih5 = "", .pembersih6 = "", .mulai = Nothing, .selesai = Nothing, .jenis_linen = "", .operator_mesin_nama = ""}
        uc.utilmesin = objUtilmesin
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id").Text = "" Then
            MsgBox("Anda belum memilih data / data masih kosong")
        Else
            Dim uc As New UcUtilisasiMesin
            Dim objUtilmesin As New Util_Mesin With {.utilisasi_mesin_cuci_id = BrowseTemp.getGridView.Columns("id").Text,
                                                     .id_mesin = BrowseTemp.getGridView.Columns("id_mesin").Text,
                                                     .nama_mesin = BrowseTemp.getGridView.Columns("nama_mesin").Text,
                                                     .kapasitas_mesin = BrowseTemp.getGridView.Columns("kapasitas_mesin").Text,
                                                     .berat_linen_str = BrowseTemp.getGridView.Columns("berat_linen").Text,
                                                     .pembersih1 = BrowseTemp.getGridView.Columns("pembersih1").Text,
                                                     .pembersih2 = BrowseTemp.getGridView.Columns("pembersih2").Text,
                                                     .pembersih3 = BrowseTemp.getGridView.Columns("pembersih3").Text,
                                                     .pembersih5 = BrowseTemp.getGridView.Columns("pembersih5").Text,
                                                     .pembersih7 = BrowseTemp.getGridView.Columns("pembersih7").Text,
                                                     .mulai = TimeSpan.Parse(BrowseTemp.getGridView.Columns("mulai").Text),
                                                     .selesai = TimeSpan.Parse(BrowseTemp.getGridView.Columns("selesai").Text),
                                                     .jenis_linen = BrowseTemp.getGridView.Columns("jenis_linen").Text,
                                                     .operator_mesin = BrowseTemp.getGridView.Columns("operator_mesin_id").Text,
                                                     .operator_mesin_nama = BrowseTemp.getGridView.Columns("operator_mesin_nama").Text}
            uc.utilmesin = objUtilmesin

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
                    utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
                    utilmesinSvr.deleteUtilMesin(New Util_Mesin With {.utilisasi_mesin_cuci_id = BrowseTemp.getGridView.Columns("id").Text})

                    MsgBox("Data " & tempData & " berhasil dihapus")
                    Me.generateTable()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(utilmesinSvr)
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
