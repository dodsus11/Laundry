Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModInputLoadGudangNew
    'Private orderSvr As IOrderService
    Private loadSvr As ILoadGudangService
    Dim dv As New DataView

    Private Sub ModInputLoadGudangNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
    End Sub

    Private Sub Loaddata(ByVal dateFrom As Date, ByVal dateTo As Date)
        Try
            loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
            Dim dt As New DataTable

            dt = loadSvr.getLoadgudangHeader(dateFrom, dateTo)
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("NO", 30))
            col.Add(GH.AddModelGridColumn("ID", 100))
            col.Add(GH.AddModelGridColumn("TGL ORDER", 100))
            col.Add(GH.AddModelGridColumn("JAM ORDER", 100))
            col.Add(GH.AddModelGridColumn("JUMLAH JNS LINEN", 130))
            col.Add(GH.AddModelGridColumn("PETUGAS", 150))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(loadSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("namaPetugas LIKE '%{0}%'", str)
    End Sub

    Private Sub tsNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Dim uc As New UcInputLoadGudang
        Dim objHeaderOrder As New LoadGudangHeader With {.idHeaderLoadGudang = Nothing, .namaPetugas = "", .tanggal = Nothing, .jam = Nothing}
        uc.header = objHeaderOrder
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub tsEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim uc As New UcInputLoadGudang
        Dim objHeaderOrder As New LoadGudangHeader With {.idHeaderLoadGudang = dgv.SelectedRows(0).DataBoundItem(1),
                                                            .namaPetugas = dgv.SelectedRows(0).DataBoundItem(5),
                                                            .tanggalstr = dgv.SelectedRows(0).Cells(2).Value,
                                                            .jamstr = dgv.SelectedRows(0).Cells(3).Value.ToString}
        uc.header = objHeaderOrder

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub tsDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Anda ingin menghapus data  " & dgv.SelectedRows(0).DataBoundItem(1) & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim stoklinen As Integer
            loadSvr = InProcFactory.CreateChannel(Of LoadGudangService, ILoadGudangService)()
            stoklinen = loadSvr.cekStokLinenByIdLoadGudang(dgv.SelectedRows(0).DataBoundItem(1))
            If stoklinen > 0 Then
                MessageBox.Show("Stok gudang linen tidak mencukupi untuk dikurangi", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim tempData As String = dgv.SelectedRows(0).DataBoundItem(1)
                Try
                    loadSvr.penguranganStokLinenByIdLoadGudang(dgv.SelectedRows(0).DataBoundItem(1))  'mengurangi stok gudang/gudang_linen
                    loadSvr.deleteLoadgudangHeader(New LoadGudangHeader With {.idHeaderLoadGudang = dgv.SelectedRows(0).DataBoundItem(1), .flag = "0"}) 'update cancel loadgudangheader                        
                    loadSvr.editFlagCancelLoadGudangByIdLoadGudang(dgv.SelectedRows(0).DataBoundItem(1))  'update cancel loadgudangdetail
                    MsgBox("Data " & tempData & " berhasil dihapus")
                    Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            InProcFactory.CloseChannel(loadSvr)
        End If
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
    End Sub

End Class
