Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModInputOrderLaundryNew
    Private orderSvr As IOrderService
    Dim dv As New DataView

    Private Sub ModInputOrderLaundryNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
    End Sub

    Private Sub Loaddata(ByVal dateFrom As Date, ByVal dateTo As Date)
        Try
            orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
            Dim dt As New DataTable

            dt = orderSvr.getOrderHeader(dateFrom, dateTo)
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("No", 30))
            col.Add(GH.AddModelGridColumn("Id Order", 100))
            col.Add(GH.AddModelGridColumn("No Order", 100))
            col.Add(GH.AddModelGridColumn("Tgl Order", 100))
            col.Add(GH.AddModelGridColumn("Jam Order", 100))
            col.Add(GH.AddModelGridColumn("Ruang", 250))
            col.Add(GH.AddModelGridColumn("Instalasi", 250))
            col.Add(GH.AddModelGridColumn("Pengantar", 200))
            col.Add(GH.AddModelGridColumn("Petugas", 200))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(orderSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("namaPegawai LIKE '%{0}%' Or instalasi LIKE '%{0}%' Or subRuang LIKE '%{0}%' Or pegawaiLaundry LIKE '%{0}%'Or nomerOrder LIKE '%{0}%' Or headerId LIKE '%{0}%' Or tanggal LIKE '%{0}%' Or jam LIKE '%{0}%'", str)
        'dv.RowFilter = String.Format("namaPegawai LIKE '%{0}%'Or pegawaiLaundry LIKE '%{0}%'", str)
    End Sub

    Private Sub tsNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsNew.Click
        Dim uc As New UCInputOrderLondry
        Dim objHeaderOrder As New OrderHeader With {.headerId = Nothing, .orderNo = "", .ruang = "", .subRuang = "", .namaPegawai = "", .tanggal = Nothing, .jam = Nothing}
        uc.header = objHeaderOrder
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    Private Sub tsEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsEdit.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Dim uc As New UCInputOrderLondry
        Dim objOrderHeader As New OrderHeader With {.headerId = dgv.SelectedRows(0).Cells(1).Value.ToString,
                                                            .orderNo = dgv.SelectedRows(0).Cells(2).Value.ToString,
                                                            .ruang = dgv.SelectedRows(0).Cells(5).Value.ToString,
                                                            .subRuang = dgv.SelectedRows(0).Cells(6).Value.ToString,
                                                            .namaPegawai = dgv.SelectedRows(0).Cells(7).Value.ToString,
                                                            .tanggalstr = dgv.SelectedRows(0).Cells(3).Value,
                                                            .jamstr = dgv.SelectedRows(0).Cells(4).Value.ToString}
        uc.header = objOrderHeader

        UILibs.PageLink.goToPage(Me.Parent, uc, Me)

    End Sub

    Private Sub tsDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsDelete.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Anda ingin menghapus data  " & dgv.SelectedRows(0).DataBoundItem(2) & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            Dim tempData As String = dgv.SelectedRows(0).DataBoundItem(2)
            Try
                orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
                orderSvr.deleteOrderHeader(New OrderHeader With {.headerId = dgv.SelectedRows(0).DataBoundItem(1), .flag = "0"})

                MsgBox("Data " & tempData & " berhasil dihapus")
                Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            InProcFactory.CloseChannel(orderSvr)
        End If
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
    End Sub

End Class
