Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModUtilisasiMesinPengeringNew
    Private utilmesinpengeringSvr As IUtilmesinPengeringService
    Dim dv As New DataView

    Private Sub ModUtilisasiMesinPengeringNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Loaddata(dtpTanggal.Value)
    End Sub

    Private Sub Loaddata(ByVal dateFrom As Date)
        Try
            utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
            Dim dt As New DataTable

            dt = utilmesinpengeringSvr.getUtilMesinPengering(dateFrom)
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("Load", 80))
            col.Add(GH.AddModelGridColumn("Id", 30))
            col.Add(GH.AddModelGridColumn("Tanggal", 100))
            col.Add(GH.AddModelGridColumn("Id Mesin", 80))
            col.Add(GH.AddModelGridColumn("Nama Mesin", 100))
            col.Add(GH.AddModelGridColumn("Linen (Kg)", 100))
            col.Add(GH.AddModelGridColumn("Mulai", 60))
            col.Add(GH.AddModelGridColumn("Selesai", 60))
            col.Add(GH.AddModelGridColumn("Suhu", 50))
            col.Add(GH.AddModelGridColumn("Id Opr", 60))
            col.Add(GH.AddModelGridColumn("Operator", 100))
            col.Add(GH.AddModelGridColumn("Kapasitas Mesin", 0))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(utilmesinpengeringSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("nama_mesin LIKE '%{0}%' or nomer LIKE '%{0}%'or id LIKE '%{0}%'or id_mesin LIKE '%{0}%' or operator_mesin_id LIKE '%{0}%' or operator_mesin_nama LIKE '%{0}%' or suhu LIKE '%{0}%' or mulai LIKE '%{0}%' or selesai LIKE '%{0}%' or berat_linen LIKE '%{0}%'", str)
    End Sub

    Private Sub tsNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Dim uc As New UcUtilisasiMesinPengering
        Dim objUtilmesinPengering As New Util_Mesin_Pengering With {.utilisasi_mesin_pengering_id = Nothing, .nama_mesin = Nothing, .maxload_mesin = Nothing, .berat_linen = Nothing, .mulai = Nothing, .selesai = Nothing, .suhu = Nothing, .operator_mesin_nama = ""}
        uc.utilmesinpengering = objUtilmesinPengering
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub tsEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim uc As New UcUtilisasiMesinPengering
        Dim objUtilmesinpengering As New Util_Mesin_Pengering With {.utilisasi_mesin_pengering_id = dgv.SelectedRows(0).DataBoundItem(1),
                                                            .id_mesin = dgv.SelectedRows(0).DataBoundItem(3),
                                                            .nama_mesin = dgv.SelectedRows(0).DataBoundItem(4),
                                                            .berat_linen_str = dgv.SelectedRows(0).DataBoundItem(5),
                                                            .mulai = TimeSpan.Parse(dgv.SelectedRows(0).DataBoundItem(6)),
                                                            .selesai = TimeSpan.Parse(dgv.SelectedRows(0).DataBoundItem(7)),
                                                            .suhu = dgv.SelectedRows(0).DataBoundItem(8),
                                                            .operator_mesin = dgv.SelectedRows(0).DataBoundItem(9),
                                                            .operator_mesin_nama = dgv.SelectedRows(0).DataBoundItem(10),
                                                            .maxload_mesin = dgv.SelectedRows(0).DataBoundItem(11)}
        uc.utilmesinpengering = objUtilmesinpengering

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub tsDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Anda ingin menghapus data  " & dgv.SelectedRows(0).DataBoundItem(0) & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim tempData As String = dgv.SelectedRows(0).DataBoundItem(0)
            Try
                utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
                utilmesinpengeringSvr.deleteUtilMesinPengering(New Util_Mesin_Pengering With {.utilisasi_mesin_pengering_id = dgv.SelectedRows(0).DataBoundItem(1)})

                MsgBox("Data " & tempData & " berhasil dihapus")
                Me.Loaddata(dtpTanggal.Value)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            InProcFactory.CloseChannel(utilmesinpengeringSvr)
        End If
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(dtpTanggal.Value)
    End Sub

End Class
