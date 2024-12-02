Imports Laundry.Service.service
Imports ClientLibs
Imports System.Windows.Forms
Imports System.Drawing
Imports SessionInfo
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Public Class ucRekapLinenTerdistribusi
    Dim rpt As New cr_LaporanRekapLinenKelauar()
    Dim dtReport As DataTable

    Private LinenReportSvr As IReportLinenService
    Private orderSvr As IOrderService

    Dim acl As SessionInfo.ACLUser

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
        dgvTampilData.Columns("ruang").HeaderText = "Instalasi/Bagian"
        dgvTampilData.Columns("ruang").Width = 200
        dgvTampilData.Columns("linen").HeaderText = "Nama Linen"
        dgvTampilData.Columns("linen").Width = 200
        dgvTampilData.Columns("jumlah").HeaderText = "Jumlah Linen"
        dgvTampilData.Columns("jumlah").Width = 200
        dgvTampilData.Columns("jumlah_distribusi").HeaderText = "Jumlah Distribusi"
        dgvTampilData.Columns("jumlah_distribusi").Width = 200
        dgvTampilData.Columns("tanggal_order").HeaderText = "Tanggal Order"
        dgvTampilData.Columns("tanggal_order").Width = 150
    End Sub

    Sub LoadData()
        Dim deptid As Integer
        If txtInstalasi.Tag = 0 Then
            deptid = 0
        Else
            deptid = txtInstalasi.Tag
        End If
        Me.LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()
        dtReport = Me.LinenReportSvr.rekapLinenTerdistribusi(dtpTanggalAwal.Text, dtpTanggalAkhir.Text, deptid)
        dgvTampilData.DataSource = dtReport
        dgvTampilData.AllowUserToAddRows = False
        AddStyleToGrid(dgvTampilData)
        FormatGrid()
        InProcFactory.CloseChannel(LinenReportSvr)
    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        'If Not rpt Is Nothing Then
        '    rpt.Close()
        '    rpt.Dispose()
        '    rpt = Nothing
        'End If

        'rpt = New cr_LaporanRekapLinenKelauar()
        'Dim obj As New ArrayList

        'Dim deptid As Integer
        'If txtInstalasi.Tag = "" Then
        '    deptid = 0
        'Else
        '    deptid = txtInstalasi.Tag
        'End If
        'Me.LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()
        'dtReport = Me.LinenReportSvr.rekapLinenTerdistribusi(dtpTanggalAwal.Text, dtpTanggalAkhir.Text, deptid)

        'For Each row As DataRow In dtReport.Rows
        '    obj.Add(New RekapLinenKeluar With {.Ruang = row.Item("ruang"),
        '                                       .NamaLinen = row.Item("linen"),
        '                                       .JumlahLinen = row.Item("jumlah"),
        '                                       .JumlahDistribusi = row.Item("jumlah_distribusi"),
        '                                       .TanggalOrder = row.Item("tanggal_order")})
        'Next
        'InProcFactory.CloseChannel(Me.LinenReportSvr)
        'Me.rpt.SetDataSource(obj)

        'crv.ReuseParameterValuesOnRefresh = False
        'crv.ReportSource = Me.rpt
        LoadData()
    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
        'If Me.dtReport Is Nothing Then
        '    MsgBox("Data masih kosong !", MsgBoxStyle.Exclamation, "Pesan")
        '    Return
        'End If

        'DirectPrint.Export2Excel(Me.dtReport)
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 5, kolom As Integer = 2
        ex.Workbooks.Add()


        ex.Cells(1, 1) = "Laporan Rekap Linen Terdistribusi per Tanggal per Instalasi"
        ex.Cells(2, 1) = "Tanggal " & Format(dtpTanggalAwal.Value, "dd/MM/yyyy") & " s/d " & Format(dtpTanggalAkhir.Value, "dd/MM/yyyy")
        If CheckBoxAll.Checked = True Then
            ex.Cells(3, 1) = "Instalasi/Bagian : Semua"
        Else
            ex.Cells(3, 1) = "Instalasi/Bagian : " & txtInstalasi.Text
        End If
        ex.Cells(4, 1) = "No"
        ex.Cells(4, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        For j As Integer = 0 To dgvTampilData.ColumnCount - 1
            If dgvTampilData.Columns(j).Visible = True Then
                ex.Cells(4, kolom) = dgvTampilData.Columns(j).HeaderText
                ex.Cells(4, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

                kolom += 1
            End If

        Next

        For i As Integer = 0 To dgvTampilData.RowCount - 1
            kolom = 2
            For j As Integer = 0 To dgvTampilData.ColumnCount - 1
                ex.Cells(baris, 1) = i + 1
                ex.Cells(baris, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                If dgvTampilData.Columns(j).Visible = True Then

                    ex.Cells(baris, kolom) = dgvTampilData.Rows(i).DataBoundItem(j).ToString
                    ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    kolom += 1
                End If

            Next
            baris += 1
        Next


        ex.Visible = True
    End Sub

    Private Sub btnInstalasi_Click(sender As System.Object, e As System.EventArgs) Handles btnInstalasi.Click
        'Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        'Dim frmLookUp As New UILibs.DlgLookUp()
        'frmLookUp.fidArray = {{"deptid", "Id Dept", 80},
        '                      {"deptname", "Nama Dept", 200}}

        'frmLookUp.keyField = "deptid"
        'frmLookUp.fields = {"deptname"}

        'frmLookUp.dt = Me.orderSvr.roomLookUp()

        'If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    txtInstalasi.Text = frmLookUp.returnRow("deptname").ToString
        '    txtInstalasi.Tag = frmLookUp.returnRow("deptid").ToString
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
            txtInstalasi.Tag = frmLookUp.returnRow("kode_ruang").ToString
            txtInstalasi.Text = frmLookUp.returnRow("nama_instalasi").ToString
        End If
        InProcFactory.CloseChannel(Me.orderSvr)
    End Sub

    Private Sub CheckBoxAll_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBoxAll.CheckedChanged
        If CheckBoxAll.Checked = True Then
            txtInstalasi.Enabled = False
            btnInstalasi.Enabled = False
            txtInstalasi.Text = ""
            txtInstalasi.Tag = 0
        Else
            txtInstalasi.Enabled = True
            btnInstalasi.Enabled = True
        End If
    End Sub

    Private Sub ucRekapLinenTerdistribusi_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.acl = CType(Me.Tag, SessionInfo.ACLUser)
        btnExportExcel.Visible = Me.acl.allowUnlock
        dtpTanggalAwal.Value = Now
        dtpTanggalAkhir.Value = Now
        CheckBoxAll.Checked = True
        LoadData()
    End Sub
End Class
