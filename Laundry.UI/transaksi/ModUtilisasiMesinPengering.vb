Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModUtilisasiMesinPengering

    Private utilmesinpengeringSvr As IUtilmesinPengeringService
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

    Private Sub ModUtilisasiMesinPengering_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BrowseTemp.getTitle.Text = "Utilisasi Mesin Pengering"
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

        utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()

        Dim headers() As String = {"Load Ke", "Id", "Tanggal", "Id Mesin", "Nama Mesin", "Linen (Gram)", "Mulai", "Selesai", "Suhu", "Id Opr", "Operator"}
        Dim lebar() As Integer = {60, 20, 70, 60, 100, 100, 60, 60, 50, 60, 100}

        dv.Table = utilmesinpengeringSvr.getUtilMesinPengering(tanggal)
        BrowseTemp.getGridView.DataSource = dv
        BrowseTemp.getGridView().Splits(0).ExtendRightColumn = True
        UILibs.GridStyle.formatGrid(BrowseTemp.getGridView(), dv.Table, headers, lebar)

        InProcFactory.CloseChannel(utilmesinpengeringSvr)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim str As String = String.Format("nama_mesin LIKE '%{0}%'", Me.BrowseTemp.getTextBox().Text)
        dv.RowFilter = str
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New UcUtilisasiMesinPengering
        Dim objUtilmesinPengering As New Util_Mesin_Pengering With {.utilisasi_mesin_pengering_id = Nothing, .nama_mesin = Nothing, .berat_linen = Nothing, .mulai = Nothing, .selesai = Nothing, .suhu = Nothing, .operator_mesin_nama = ""}
        uc.utilmesinpengering = objUtilmesinPengering
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If BrowseTemp.getGridView.Columns("id").Text = "" Then
            MsgBox("Anda belum memilih data / Data masih kosong")
        Else
            Dim uc As New UcUtilisasiMesinPengering
            Dim objUtilmesinpengering As New Util_Mesin_Pengering With {.utilisasi_mesin_pengering_id = BrowseTemp.getGridView.Columns("id").Text,
                                                                .id_mesin = BrowseTemp.getGridView.Columns("id_mesin").Text,
                                                                .nama_mesin = BrowseTemp.getGridView.Columns("nama_mesin").Text,
                                                                .berat_linen_str = BrowseTemp.getGridView.Columns("berat_linen").Text,
                                                                .mulai = TimeSpan.Parse(BrowseTemp.getGridView.Columns("mulai").Text),
                                                                .selesai = TimeSpan.Parse(BrowseTemp.getGridView.Columns("selesai").Text),
                                                                .suhu = BrowseTemp.getGridView.Columns("suhu").Text,
                                                                .operator_mesin = BrowseTemp.getGridView.Columns("operator_mesin_id").Text,
                                                                .operator_mesin_nama = BrowseTemp.getGridView.Columns("operator_mesin_nama").Text}
            uc.utilmesinpengering = objUtilmesinpengering

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
                    utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
                    utilmesinpengeringSvr.deleteUtilMesinPengering(New Util_Mesin_Pengering With {.utilisasi_mesin_pengering_id = BrowseTemp.getGridView.Columns("id").Text})

                    MsgBox("Data " & tempData & " berhasil dihapus")
                    Me.generateTable()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(utilmesinpengeringSvr)
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
