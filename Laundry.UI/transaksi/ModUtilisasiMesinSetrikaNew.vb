Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModUtilisasiMesinSetrikaNew
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Dim dv As New DataView

    Private Sub ModUtilisasiMesinSetrikaNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Loaddata(dtpTanggal.Value)
    End Sub

    Private Sub Loaddata(ByVal dateFrom As Date)
        Try
            utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
            Dim dt As New DataTable

            dt = utilmesinsetrikaSvr.getUtilMesinSetrika(dateFrom)
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("Id", 30))
            col.Add(GH.AddModelGridColumn("Tanggal", 100))
            col.Add(GH.AddModelGridColumn("Kode Mesin", 100))
            col.Add(GH.AddModelGridColumn("Nama Mesin", 100))
            col.Add(GH.AddModelGridColumn("Load", 80))
            col.Add(GH.AddModelGridColumn("Operator", 100))
            col.Add(GH.AddModelGridColumn("IdOperator", 0))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(utilmesinsetrikaSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("operatormesin LIKE '%{0}%' or namamesin LIKE '%{0}%'or id LIKE '%{0}%' or loadke LIKE '%{0}%'or idoperator LIKE '%{0}%'or kodemesin LIKE '%{0}%'", str)
    End Sub

    Private Sub tsNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Dim uc As New UcUtilisasiMesinSetrikaNew
        Dim objUtilmesinSetrika As New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = Nothing, .tanggal = Nothing, .kode_mesin = "", .nama_mesin = "", .load_ke = Nothing, .operator_mesin = ""}
        uc.utilmesinsetrika = objUtilmesinSetrika
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub tsView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsView.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim uc As New UcUtilisasiMesinSetrikaNew
        Dim objUtilmesinsetrika As New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = dgv.SelectedRows(0).DataBoundItem(0),
                                                                    .tanggal = dgv.SelectedRows(0).DataBoundItem(1),
                                                                    .kode_mesin = dgv.SelectedRows(0).DataBoundItem(2),
                                                                    .nama_mesin = dgv.SelectedRows(0).DataBoundItem(3),
                                                                    .load_ke = dgv.SelectedRows(0).DataBoundItem(4),
                                                                    .operator_mesin = dgv.SelectedRows(0).DataBoundItem(5),
                                                                    .operator_id = dgv.SelectedRows(0).DataBoundItem(6)}
        uc.utilmesinsetrika = objUtilmesinsetrika

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(dtpTanggal.Value)
    End Sub

    '========UTIL MESIN SETRIKA TIDAK ADA DELETE========
    Private Sub tsDelete_Click(sender As System.Object, e As System.EventArgs) Handles tsDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If
        If MsgBox("Anda ingin menghapus data  " & dgv.SelectedRows(0).DataBoundItem(0).ToString & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim tempData As String = dgv.SelectedRows(0).DataBoundItem(0).ToString
            Try
                utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
                utilmesinsetrikaSvr.deleteUtilMesinSetrika(New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = dgv.SelectedRows(0).DataBoundItem(0)})

                MsgBox("Data " & tempData & " berhasil dihapus")
                Me.Loaddata(dtpTanggal.Value)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            InProcFactory.CloseChannel(utilmesinsetrikaSvr)
        End If

    End Sub
    '=====================================================
End Class
