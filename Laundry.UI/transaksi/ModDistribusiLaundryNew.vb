Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModDistribusiLaundryNew
    Private distrSvr As IDistribusiService
    Dim dv As New DataView
    'Dim model As New Utility.Distribusi
    
    Private Sub ModDistribusiLaundryNew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)


    End Sub

    Public Sub Loaddata(ByVal dateFrom As Date, ByVal dateTo As Date)
        Try
            distrSvr = InProcFactory.CreateChannel(Of DistribusiService, IDistribusiService)()
            Dim dt As New DataTable

            dt = distrSvr.getOrderHeaderRange(dateFrom, dateTo)
            dv.Table = dt
            dgv.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("No", 30))
            col.Add(GH.AddModelGridColumn("Id Order", 100))
            col.Add(GH.AddModelGridColumn("No Order", 100))
            col.Add(GH.AddModelGridColumn("Tgl Order", 100))
            col.Add(GH.AddModelGridColumn("Ruang", 100))
            col.Add(GH.AddModelGridColumn("Instalasi", 150))
            col.Add(GH.AddModelGridColumn("Status Order", 150))
            GH.FormatGrid(dgv, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(distrSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("ruang LIKE '%{0}%' or subRuang LIKE '%{0}%' or nomerOrder LIKE '%{0}%' or tanggal LIKE '%{0}%' or statusOrder LIKE '%{0}%' or idOrder LIKE '%{0}%'", str)
    End Sub

    Private Sub tsProses_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsProses.Click
        
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong")
            Exit Sub
        End If

        If dgv.SelectedRows(0).DataBoundItem("statusOrder") = "Terdistribusi" Then
            MsgBox("Order sudah terdistribusi semua, pilih yang lain.")
        Else
            Dim uc As New UcDistribusiLondry
            Dim objHeaderOrder As New OrderHeader With {.headerId = dgv.SelectedRows(0).DataBoundItem(1),
                                                        .orderNo = dgv.SelectedRows(0).DataBoundItem(2),
                                                        .ruang = dgv.SelectedRows(0).DataBoundItem(4),
                                                        .subRuang = dgv.SelectedRows(0).DataBoundItem(5),
                                                        .flag = 1,
                                                        .tglAwal = dtpTanggalMulai.Value,
                                                        .tglAkhir = dtpTanggalSelesai.Value}


            uc.header = objHeaderOrder
            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub tsHistori_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsHistori.Click
        If dgv.SelectedRows.Count = 0 Then
            MsgBox("Anda belum memilih data / Data masih kosong", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If dgv.SelectedRows(0).DataBoundItem("statusOrder") = "Belum didistribusikan" Then
            MsgBox("Order belum pernah didistribusikan, pilih yang lain.")
        Else
            Dim uc As New UcDistribusiLondry
            Dim objHeaderOrder As New OrderHeader With {.headerId = dgv.SelectedRows(0).DataBoundItem("idOrder"),
                                                        .orderNo = dgv.SelectedRows(0).DataBoundItem("nomerOrder"),
                                                        .ruang = dgv.SelectedRows(0).DataBoundItem("ruang"),
                                                        .subRuang = dgv.SelectedRows(0).DataBoundItem("subRuang"),
                                                        .flag = Nothing,
                                                        .tglAwal = dtpTanggalMulai.Value,
                                                        .tglAkhir = dtpTanggalSelesai.Value}


            uc.header = objHeaderOrder

            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub btnTampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
    End Sub

    
End Class
