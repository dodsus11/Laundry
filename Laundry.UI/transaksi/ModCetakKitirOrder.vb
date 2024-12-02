Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModCetakKitirOrder
    Private orderSvr As IOrderService
    Dim dv As New DataView
    Dim dt As New DataTable

    Private Sub ModCetakKitirOrder_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
        'orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        'dt = orderSvr.getOrderHeader(Date.Now)
        'dgvListOrder.DataSource = dt
        'dgvListOrder.AllowUserToAddRows = False
        'AddStyleToGrid(dgvListOrder)
        'FormatGrid()
    End Sub

    Private Sub Loaddata(ByVal dateFrom As Date, ByVal dateTo As Date)
        Try
            orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
            Dim dt As New DataTable

            dt = orderSvr.getOrderHeader(dateFrom, dateTo)
            dv.Table = dt
            dgvListOrder.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("No", 30))
            col.Add(GH.AddModelGridColumn("Id Order", 100))
            col.Add(GH.AddModelGridColumn("No Order", 100))
            col.Add(GH.AddModelGridColumn("Tgl Order", 100))
            col.Add(GH.AddModelGridColumn("Jam Order", 100))
            col.Add(GH.AddModelGridColumn("Ruang", 150))
            col.Add(GH.AddModelGridColumn("Instalasi", 150))
            col.Add(GH.AddModelGridColumn("Pengantar", 200))
            col.Add(GH.AddModelGridColumn("Petugas", 200))
            GH.FormatGrid(dgvListOrder, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(orderSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    'Public Sub AddStyleToGrid(ByVal dgv As DataGridView)

    '    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '    dgv.ReadOnly = True
    '    dgv.MultiSelect = False

    '    dgv.AllowUserToResizeRows = False
    '    dgv.AllowUserToAddRows = False
    '    dgv.EnableHeadersVisualStyles = False
    '    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
    '    dgv.ColumnHeadersHeight = 25

    '    With (dgv.ColumnHeadersDefaultCellStyle)
    '        .BackColor = Color.DimGray
    '        .ForeColor = Color.White
    '        .Font = New Font(dgv.Font, FontStyle.Bold)
    '    End With
    '    dgv.GridColor = Color.DarkGray
    '    dgv.DefaultCellStyle.SelectionBackColor = Color.Silver
    '    dgv.DefaultCellStyle.SelectionForeColor = Color.Black

    'End Sub

    'Private Sub FormatGrid()
    '    dgvListOrder.Columns("nomer").HeaderText = "No"
    '    dgvListOrder.Columns("nomer").Width = 30
    '    dgvListOrder.Columns("headerId").HeaderText = "Id Order"
    '    dgvListOrder.Columns("headerId").Width = 100
    '    dgvListOrder.Columns("nomerOrder").HeaderText = "No Order"
    '    dgvListOrder.Columns("nomerOrder").Width = 100
    '    dgvListOrder.Columns("tanggal").HeaderText = "Tgl Order"
    '    dgvListOrder.Columns("tanggal").Width = 100
    '    dgvListOrder.Columns("jam").HeaderText = "Jam Order"
    '    dgvListOrder.Columns("jam").Width = 100
    '    dgvListOrder.Columns("ruang").HeaderText = "Unit/Ruang"
    '    dgvListOrder.Columns("ruang").Width = 150
    '    dgvListOrder.Columns("subRuang").HeaderText = "Sub Ruang"
    '    dgvListOrder.Columns("subRuang").Width = 150
    '    dgvListOrder.Columns("namaPegawai").HeaderText = "Pengantar"
    '    dgvListOrder.Columns("namaPegawai").Width = 200
    '    dgvListOrder.Columns("pegawaiLaundry").HeaderText = "Petugas"
    '    dgvListOrder.Columns("pegawaiLaundry").Width = 200
    'End Sub    
    
    'Private Sub CetakKitir_Click(sender As System.Object, e As System.EventArgs)
    '    If dgvListOrder.SelectedRows.Count > 0 Then
    '        Dim kitir As New FormKitirOrder
    '        Dim objOrderHeader As New OrderHeader With {.headerId = dgvListOrder.SelectedCells(1).Value,
    '                                                    .orderNo = dgvListOrder.SelectedCells(2).Value,
    '                                                    .ruang = dgvListOrder.SelectedCells(5).Value,
    '                                                    .subRuang = dgvListOrder.SelectedCells(6).Value,
    '                                                    .namaPegawai = dgvListOrder.SelectedCells(7).Value,
    '                                                    .pegawaiLaundy = dgvListOrder.SelectedCells(8).Value,
    '                                                    .tanggalstr = dgvListOrder.SelectedCells(3).Value,
    '                                                    .jamstr = dgvListOrder.SelectedCells(4).Value}
    '        kitir.header = objOrderHeader
    '        kitir.ShowDialog(Me)
    '    Else
    '        MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub btnTampil_Click(sender As System.Object, e As System.EventArgs) Handles btnTampil.Click
        Me.Loaddata(dtpTanggalMulai.Value, dtpTanggalSelesai.Value)
    End Sub

    Private Sub CetakKitir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakKitir.Click
        If dgvListOrder.SelectedRows.Count > 0 Then
            Dim kitir As New FormKitirOrder
            Dim objOrderHeader As New OrderHeader With {.headerId = dgvListOrder.SelectedCells(1).Value,
                                                        .orderNo = dgvListOrder.SelectedCells(2).Value,
                                                        .ruang = dgvListOrder.SelectedCells(5).Value,
                                                        .subRuang = dgvListOrder.SelectedCells(6).Value,
                                                        .namaPegawai = dgvListOrder.SelectedCells(7).Value,
                                                        .pegawaiLaundy = dgvListOrder.SelectedCells(8).Value,
                                                        .tanggalstr = dgvListOrder.SelectedCells(3).Value,
                                                        .jamstr = dgvListOrder.SelectedCells(4).Value}
            kitir.header = objOrderHeader
            kitir.ShowDialog(Me)
        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
