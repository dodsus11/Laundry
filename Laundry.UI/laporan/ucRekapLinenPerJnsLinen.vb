Imports Laundry.Service.service
Imports ClientLibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ucRekapLinenPerJnsLinen

    Dim dtReport As DataTable
    Private orderSvr As IOrderService
    Private LinenReportSvr As IReportLinenService

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
        dgvLinenKotor.Columns("kodelinen").HeaderText = "Kode Linen"
        dgvLinenKotor.Columns("kodelinen").Width = 100
        dgvLinenKotor.Columns("namalinen").HeaderText = "Nama Linen"
        dgvLinenKotor.Columns("namalinen").Width = 100
        dgvLinenKotor.Columns("jml_inf").HeaderText = "Jml Infeksius"
        dgvLinenKotor.Columns("jml_inf").Width = 160
        dgvLinenKotor.Columns("jml_noninf").HeaderText = "Jml Non Infeksius"
        dgvLinenKotor.Columns("jml_noninf").Width = 160
        dgvLinenKotor.Columns("beratLinen").HeaderText = "Berat Linen"
        dgvLinenKotor.Columns("beratLinen").Width = 130

    End Sub

    Private Sub btnExportExcel_Click(sender As System.Object, e As System.EventArgs) Handles btnExportExcel.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 5, kolom As Integer = 2
        ex.Workbooks.Add()


        ex.Cells(1, 1) = "Laporan Rekap Linen Kotor Masuk dari Ruang " & txtRuang.Text
        ex.Cells(2, 1) = "Tanggal " & Format(dtpFromDate.Value, "dd/MM/yyyy")

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
        tampil()
    End Sub

    Public Sub tampil()
        Dim brtlinentotal As Decimal = 0
        Dim jmlInfTot As Decimal = 0
        Dim jmlNonInfTot As Decimal = 0
        Dim ruang As Integer
        If cbAllRoom.Checked = True Then
            ruang = 0
        Else
            ruang = txtRuang.Tag
        End If
        LinenReportSvr = InProcFactory.CreateChannel(Of ReportLinenService, IReportLinenService)()
        dtReport = LinenReportSvr.getLinenPerJnsLinen(dtpFromDate.Text, dtpToDate.Text, ruang)
        dgvLinenKotor.DataSource = dtReport
        dgvLinenKotor.AllowUserToAddRows = False
        AddStyleToGrid(dgvLinenKotor)
        FormatGrid()
        'menghitung berat total linen
        Dim i As Integer = dgvLinenKotor.RowCount()
        For x As Integer = 0 To i - 1
            brtlinentotal = brtlinentotal + Convert.ToDecimal(dgvLinenKotor.Rows(x).Cells(4).Value)
            jmlInfTot = jmlInfTot + dgvLinenKotor.Rows(x).Cells(2).Value
            jmlNonInfTot = jmlNonInfTot + dgvLinenKotor.Rows(x).Cells(3).Value
        Next
        txtbertLinen.Text = brtlinentotal
        txtJmlInf.Text = jmlInfTot
        txtJmlNonInf.Text = jmlNonInfTot
    End Sub

    Private Sub btnRuang_Click(sender As System.Object, e As System.EventArgs) Handles btnRuang.Click
        'Me.orderSvr = InProcFactory.CreateChannel(Of OrderService, IOrderService)()
        'Dim frmLookUp As New UILibs.DlgLookUp()
        'frmLookUp.fidArray = {{"deptid", "Id Dept", 80},
        '                      {"deptname", "Nama Dept", 200}}

        'frmLookUp.keyField = "deptid"
        'frmLookUp.fields = {"deptname"}

        'frmLookUp.dt = Me.orderSvr.roomLookUp()

        'If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    txtRuang.Text = frmLookUp.returnRow("deptname").ToString
        '    txtRuang.Tag = frmLookUp.returnRow("deptid").ToString
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
            txtRuang.Tag = frmLookUp.returnRow("kode_ruang").ToString
            txtRuang.Text = frmLookUp.returnRow("nama_instalasi").ToString
        End If
        InProcFactory.CloseChannel(Me.orderSvr)
    End Sub

    Private Sub cbAllRoom_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAllRoom.CheckedChanged
        If cbAllRoom.Checked = True Then
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
