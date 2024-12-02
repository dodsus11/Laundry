Imports Laundry.Service.service
Imports ClientLibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ucRekapLinenKotor

    Dim dtReport As DataTable
    Private orderSvr As IOrderService
    Private LinenReportSvr As IReportLinenService
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
        dgvLinenKotor.Columns("tanggal_order").HeaderText = "Tanggal Order"
        dgvLinenKotor.Columns("tanggal_order").Width = 150
        dgvLinenKotor.Columns("namalinen").HeaderText = "Nama Linen"
        dgvLinenKotor.Columns("namalinen").Width = 200
        dgvLinenKotor.Columns("jumlah").HeaderText = "Jumlah Linen Kotor"
        dgvLinenKotor.Columns("jumlah").Width = 160
        dgvLinenKotor.Columns("ruang").HeaderText = "Ruang"
        dgvLinenKotor.Columns("ruang").Width = 200
        dgvLinenKotor.Columns("nama_instalasi").HeaderText = " Nama Instalasi"
        dgvLinenKotor.Columns("nama_instalasi").Width = 300
        dgvLinenKotor.Columns("kode_ruang").HeaderText = " Kode Ruang"
        dgvLinenKotor.Columns("kode_ruang").Width = 300
        dgvLinenKotor.Columns("kode_ruang").Visible = False
        dgvLinenKotor.Columns("kode_instalasi").HeaderText = " Kode Ruang"
        dgvLinenKotor.Columns("kode_instalasi").Width = 300
        dgvLinenKotor.Columns("kode_instalasi").Visible = False

    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 5, kolom As Integer = 2
        ex.Workbooks.Add()

        If txtRuang.Text = "" Then
            ex.Cells(1, 1) = "Laporan Rekap Linen Kotor Yang Belum Terdistribusi Semua Instalasi"
        Else
            ex.Cells(1, 1) = "Laporan Rekap Linen Kotor Yang Belum Terdistribusi dari " & txtRuang.Text
        End If
        ex.Cells(2, 1) = "Tanggal " & Format(dtpFromDate.Value, "dd/MM/yyyy") & " s/d " & Format(dtpToDate.Value, "dd/MM/yyyy")

        ex.Cells(4, 1) = "No"
        ex.Cells(4, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        For j As Integer = 0 To dgvLinenKotor.ColumnCount - 1
            If dgvLinenKotor.Columns(j).Visible = True Then
                ex.Cells(4, kolom) = dgvLinenKotor.Columns(j).HeaderText
                ex.Cells(4, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

                kolom += 1
            End If

        Next

        For i As Integer = 0 To dgvLinenKotor.RowCount - 1
            kolom = 2
            For j As Integer = 0 To dgvLinenKotor.ColumnCount - 1
                ex.Cells(baris, 1) = i + 1
                ex.Cells(baris, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                If dgvLinenKotor.Columns(j).Visible = True Then

                    ex.Cells(baris, kolom) = dgvLinenKotor.Rows(i).DataBoundItem(j).ToString
                    ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    kolom += 1
                End If

            Next
            baris += 1
        Next
        ex.Visible = True
    End Sub

    Private Sub btnView_Click(sender As System.Object, e As System.EventArgs) Handles btnView.Click
        tampil()
    End Sub

    Private Sub ucRekapLinenKotor_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Me.acl = CType(Me.Tag, SessionInfo.ACLUser)
        'btnExportExcel.Visible = Me.acl.allowUnlock
        btnExportExcel.Visible = True
        dtpFromDate.Value = Now
        dtpToDate.Value = Now
        CheckBoxAll.Checked = True
        tampil()
    End Sub

    Public Sub tampil()
        LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()
        dtReport = LinenReportSvr.getLinenKotor(dtpFromDate.Text, dtpToDate.Text, txtRuang.Tag)
        dgvLinenKotor.DataSource = dtReport
        dgvLinenKotor.AllowUserToAddRows = False
        AddStyleToGrid(dgvLinenKotor)
        FormatGrid()
    End Sub

    Private Sub btnRuang_Click(sender As System.Object, e As System.EventArgs) Handles btnRuang.Click
        
        Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"kode_instalasi", "Kode Instalasi", 100},
                              {"nama_instalasi", "Nama Instalasi", 250}}

        frmLookUp.keyField = "kode_instalasi"
        frmLookUp.fields = {"nama_instalasi"}


        frmLookUp.dt = Me.orderSvr.InstalasiLookUp()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtRuang.Tag = frmLookUp.returnRow("kode_instalasi").ToString
            txtRuang.Text = frmLookUp.returnRow("nama_instalasi").ToString

        End If
        InProcFactory.CloseChannel(Me.orderSvr)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxAll.CheckedChanged
        If CheckBoxAll.Checked = True Then
            txtRuang.Enabled = False
            btnRuang.Enabled = False
            txtRuang.Text = ""
            txtRuang.Tag = 0
        Else
            txtRuang.Enabled = True
            btnRuang.Enabled = True
        End If
    End Sub
End Class
