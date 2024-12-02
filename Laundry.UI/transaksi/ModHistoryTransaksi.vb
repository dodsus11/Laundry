Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ModHistoryTransaksi
    Private orderSvr As IOrderService
    Dim dv As New DataView
    Dim dt As New DataTable

    Private Sub ModHistoryTransaksi_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        CheckBoxSemua.Checked = True
        txtInst.Enabled = False
        btnPilih.Enabled = False
        Dim ruang As Integer
        ruang = 0
        orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        dt = orderSvr.getHistoryOrderHeader(dtpTgl.Value, ruang)
        dgvListOrder.DataSource = dt
        dgvListOrder.AllowUserToAddRows = False
        AddStyleToGrid(dgvListOrder)
        FormatGrid()
    End Sub

    Public Sub AddStyleToGrid(ByVal dgv As DataGridView)

        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.ReadOnly = True
        dgv.MultiSelect = False

        dgv.AllowUserToResizeRows = False
        dgv.AllowUserToAddRows = False
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgv.ColumnHeadersHeight = 25

        With (dgv.ColumnHeadersDefaultCellStyle)
            .BackColor = Color.DimGray
            .ForeColor = Color.White
            .Font = New Font(dgv.Font, FontStyle.Bold)
        End With
        dgv.GridColor = Color.DarkGray
        dgv.DefaultCellStyle.SelectionBackColor = Color.Silver
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black

    End Sub

    Private Sub FormatGrid()
        dgvListOrder.Columns("nomer").HeaderText = "No"
        dgvListOrder.Columns("nomer").Width = 30
        dgvListOrder.Columns("headerId").HeaderText = "Id Order"
        dgvListOrder.Columns("headerId").Width = 100
        dgvListOrder.Columns("nomerOrder").HeaderText = "No Order"
        dgvListOrder.Columns("nomerOrder").Width = 100
        dgvListOrder.Columns("tanggal").HeaderText = "Tgl Order"
        dgvListOrder.Columns("tanggal").Width = 100
        dgvListOrder.Columns("jam").HeaderText = "Jam Order"
        dgvListOrder.Columns("jam").Width = 100
        dgvListOrder.Columns("ruang").HeaderText = "Unit/Bagian"
        dgvListOrder.Columns("ruang").Width = 150
        dgvListOrder.Columns("namaPegawai").HeaderText = "Pengantar"
        dgvListOrder.Columns("namaPegawai").Width = 200
        dgvListOrder.Columns("pegawaiLaundry").HeaderText = "Petugas"
        dgvListOrder.Columns("pegawaiLaundry").Width = 200
    End Sub
  
    Private Sub CheckBoxSemua_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBoxSemua.CheckedChanged
        If CheckBoxSemua.Checked = True Then
            txtInst.Enabled = False
            btnPilih.Enabled = False
            txtInst.Text = ""
            txtInst.Tag = 0
        Else
            txtInst.Enabled = True
            btnPilih.Enabled = True
        End If
    End Sub

    Private Sub btnReport_Click(sender As System.Object, e As System.EventArgs) Handles btnReport.Click
        Dim ruang As Integer
        orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        If CheckBoxSemua.Checked = True Then
            ruang = 0
            dt = orderSvr.getHistoryOrderHeader(dtpTgl.Value, ruang)
            dgvListOrder.DataSource = dt
            dgvListOrder.AllowUserToAddRows = False
            AddStyleToGrid(dgvListOrder)
            FormatGrid()
            InProcFactory.CloseChannel(Me.orderSvr)
        Else
            If txtInst.Text = "" Then
                MessageBox.Show("Silahkan pilih bagian/ruang", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ruang = CInt(txtInst.Tag)
                dt = orderSvr.getHistoryOrderHeader(dtpTgl.Value, ruang)
                dgvListOrder.DataSource = dt
                dgvListOrder.AllowUserToAddRows = False
                AddStyleToGrid(dgvListOrder)
                FormatGrid()
                InProcFactory.CloseChannel(Me.orderSvr)
            End If
        End If

    End Sub

    Private Sub btnPilih_Click(sender As System.Object, e As System.EventArgs) Handles btnPilih.Click
        'Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        'Dim frmLookUp As New UILibs.DlgLookUp()
        ''frmLookUp.fidArray = {{"poly_code", "Kode", 80},
        ''                      {"poly_name", "Nama Ruang", 200},
        ''                      {"room_descr", "Unit", 250}}
        'frmLookUp.fidArray = {{"deptid", "Id Dept", 80},
        '                      {"deptname", "Nama Dept", 200}}

        'frmLookUp.keyField = "deptid"
        'frmLookUp.fields = {"deptname"}

        'frmLookUp.dt = Me.orderSvr.roomLookUp()

        'If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    txtInst.Text = frmLookUp.returnRow("deptname").ToString
        '    txtInst.Tag = frmLookUp.returnRow("deptid").ToString
        'End If
        'InProcFactory.CloseChannel(Me.orderSvr)
        Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"kode_ruang", "Kode Ruang", 80},
                              {"nama_ruang", "Nama Ruang", 250},
                              {"nama_instalasi", "Nama Instalasi", 250}}

        frmLookUp.keyField = "kode_ruang"
        frmLookUp.fields = {"nama_ruang"}


        frmLookUp.dt = Me.orderSvr.roomLookUp()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'txtRuangan.Text = frmLookUp.returnRow("nama_ruang").ToString
            txtInst.Tag = frmLookUp.returnRow("kode_ruang").ToString
            txtInst.Text = frmLookUp.returnRow("nama_instalasi").ToString
        End If
        InProcFactory.CloseChannel(Me.orderSvr)
    End Sub

    Private Sub Detail_Click_1(sender As System.Object, e As System.EventArgs) Handles Detail.Click
        If dgvListOrder.SelectedRows.Count > 0 Then
            Dim uc As New UCHistoryTransaksi
            Dim objOrderHeader As New OrderHeader With {.headerId = dgvListOrder.SelectedCells(1).Value,
                                                        .orderNo = dgvListOrder.SelectedCells(2).Value,
                                                        .ruang = dgvListOrder.SelectedCells(5).Value,
                                                        .namaPegawai = dgvListOrder.SelectedCells(6).Value,
                                                        .pegawaiLaundy = dgvListOrder.SelectedCells(7).Value,
                                                        .tanggalstr = dgvListOrder.SelectedCells(3).Value,
                                                        .jamstr = dgvListOrder.SelectedCells(4).Value.ToString}
            uc.header = objOrderHeader
            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        Else
            MessageBox.Show("Silahkan pilih data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
