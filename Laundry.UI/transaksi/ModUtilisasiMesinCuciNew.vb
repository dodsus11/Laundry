Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModUtilisasiMesinCuciNew
    Private utilmesinSvr As IUtilmesinService
    Dim dv As New DataView

    Private Sub ModUtilisasiMesinCuciNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Loaddata(dtpTanggal.Value)
    End Sub

    Private Sub Loaddata(ByVal dateFrom As Date)
        Try
            utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
            Dim dt As New DataTable

            dt = utilmesinSvr.getUtilMesin(dateFrom)
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("Id Mesin", 80))
            col.Add(GH.AddModelGridColumn("Nama Mesin", 100))
            col.Add(GH.AddModelGridColumn("Kapasitas Mesin", 0))
            col.Add(GH.AddModelGridColumn("Load mesin", 100))
            col.Add(GH.AddModelGridColumn("Id Utilisasi", 80))
            col.Add(GH.AddModelGridColumn("Tanggal", 70))
            col.Add(GH.AddModelGridColumn("Linen (Kg)", 80))
            col.Add(GH.AddModelGridColumn("Alkalin (ml)", 100))
            col.Add(GH.AddModelGridColumn("Detergen (ml)", 100))
            col.Add(GH.AddModelGridColumn("Oxygenbleach (ml)", 130))
            col.Add(GH.AddModelGridColumn("Softener (ml)", 100))
            col.Add(GH.AddModelGridColumn("Penetral (ml)", 100))
            col.Add(GH.AddModelGridColumn("Mulai", 60))
            col.Add(GH.AddModelGridColumn("Selesai", 60))
            col.Add(GH.AddModelGridColumn("Jenis Linen", 80))
            col.Add(GH.AddModelGridColumn("Id Opr", 0))
            col.Add(GH.AddModelGridColumn("Operator", 100))
            col.Add(GH.AddModelGridColumn("Keterangan", 150))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(utilmesinSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("nama_mesin LIKE '%{0}%' or id_mesin LIKE '%{0}%' or nomer LIKE '%{0}%' or id LIKE '%{0}%' or operator_mesin_nama LIKE '%{0}%' or jenis_linen LIKE '%{0}%'", str)
    End Sub

    Private Sub tsNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Dim uc As New UcUtilisasiMesin2
        Dim objUtilmesin As New Util_Mesin With {.utilisasi_mesin_cuci_id = Nothing, .nama_mesin = Nothing, .berat_linen = Nothing, .pembersih1 = "", .pembersih2 = "", .pembersih3 = "", .pembersih4 = "", .pembersih5 = "", .pembersih6 = "", .mulai = Nothing, .selesai = Nothing, .jenis_linen = "", .operator_mesin_nama = "", .keterangan = ""}
        uc.utilmesin = objUtilmesin
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub tsEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim uc As New UcUtilisasiMesin2
        Dim objUtilmesin As New Util_Mesin With {.utilisasi_mesin_cuci_id = dgv.SelectedRows(0).DataBoundItem(4),
                                                 .id_mesin = dgv.SelectedRows(0).DataBoundItem(0),
                                                 .nama_mesin = dgv.SelectedRows(0).DataBoundItem(1),
                                                 .kapasitas_mesin = dgv.SelectedRows(0).DataBoundItem(2),
                                                 .berat_linen_str = dgv.SelectedRows(0).DataBoundItem(6),
                                                 .pembersih1 = dgv.SelectedRows(0).DataBoundItem(7),
                                                 .pembersih2 = dgv.SelectedRows(0).DataBoundItem(8),
                                                 .pembersih3 = dgv.SelectedRows(0).DataBoundItem(9),
                                                 .pembersih5 = dgv.SelectedRows(0).DataBoundItem(10),
                                                 .pembersih7 = dgv.SelectedRows(0).DataBoundItem(11),
                                                 .mulai = TimeSpan.Parse(dgv.SelectedRows(0).DataBoundItem(12)),
                                                 .selesai = TimeSpan.Parse(dgv.SelectedRows(0).DataBoundItem(13)),
                                                 .jenis_linen = dgv.SelectedRows(0).DataBoundItem(14),
                                                 .operator_mesin = dgv.SelectedRows(0).DataBoundItem(15),
                                                 .operator_mesin_nama = dgv.SelectedRows(0).DataBoundItem(16),
                                                 .keterangan = dgv.SelectedRows(0).DataBoundItem(17)}
        uc.utilmesin = objUtilmesin

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub tsDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Anda ingin menghapus data  " & dgv.SelectedRows(0).DataBoundItem(4) & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim tempData As String = dgv.SelectedRows(0).DataBoundItem(4)
            Try
                utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
                utilmesinSvr.deleteUtilMesin(New Util_Mesin With {.utilisasi_mesin_cuci_id = dgv.SelectedRows(0).DataBoundItem(4)})

                MsgBox("Data " & tempData & " berhasil dihapus")
                Me.Loaddata(dtpTanggal.Value)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            InProcFactory.CloseChannel(utilmesinSvr)
        End If
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(dtpTanggal.Value)
    End Sub

    
End Class
