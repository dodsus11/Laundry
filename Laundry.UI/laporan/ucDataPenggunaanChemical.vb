Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ucDataPenggunaanChemical
    Dim rpt As New cr_LaporanRekapLinenKelauar()
    Dim dtReport As DataTable
    Public mesin As Mesin
    Dim dt As New DataTable

    Private utilmesinSvr As IUtilmesinService

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

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
        dt = utilmesinSvr.DataPenggunaanChemical(fromDate.Value.Date, toDate.Value.Date)
        dgvTampilData.DataSource = dt
        dgvTampilData.AllowUserToAddRows = False
        AddStyleToGrid(dgvTampilData)
        FormatGrid()
    End Sub

    Private Sub FormatGrid()
        dgvTampilData.Columns("nama_mesin").HeaderText = "Nama Mesin"
        dgvTampilData.Columns("nama_mesin").Width = 100
        dgvTampilData.Columns("alkali").HeaderText = "Alkali"
        dgvTampilData.Columns("alkali").Width = 100
        dgvTampilData.Columns("detergen").HeaderText = "Detergent"
        dgvTampilData.Columns("detergen").Width = 100
        dgvTampilData.Columns("oxybleach").HeaderText = "Oxygenbleach"
        dgvTampilData.Columns("oxybleach").Width = 100
        dgvTampilData.Columns("softener").HeaderText = "Softener"
        dgvTampilData.Columns("softener").Width = 100
        dgvTampilData.Columns("penetral").HeaderText = "Penetral"
        dgvTampilData.Columns("penetral").Width = 100
    End Sub

    Private Sub C1Button1_Click(sender As System.Object, e As System.EventArgs) Handles C1Button1.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 6,
            kolom As Integer = 2,
            linen As Integer = 0,
            lot As Integer = 0,
            jumlah As Integer = 0,
            rata As Integer = 0,
            totallinen As Integer = 0,
            totallot As Integer = 0
        ex.Workbooks.Add()


        ex.Cells(1, 1) = "Data Penggunaan Chemical"
        ex.Cells(2, 1) = "Instalasi Laundry & CSSD"
        ex.Cells(3, 1) = "Tanggal " & Format(FromDate.Value, "dd/MM/yyyy") & " s/d " & Format(ToDate.Value, "dd/MM/yyyy")

        ex.Cells(5, 1) = "No"
        ex.Cells(5, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        '===Mengisi Header===
        For j As Integer = 0 To dgvTampilData.ColumnCount - 1
            If dgvTampilData.Columns(j).Visible = True Then
                ex.Cells(5, kolom) = dgvTampilData.Columns(j).HeaderText
                ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                kolom += 1
            End If
        Next
       
        '===Mengisi Data===
        For i As Integer = 0 To dgvTampilData.RowCount - 1
            kolom = 2
            For j As Integer = 0 To dgvTampilData.ColumnCount - 1

                ex.Cells(baris, 1) = i + 1
                ex.Cells(baris, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                If dgvTampilData.Columns(j).Visible = True Then
                    ex.Cells(baris, kolom) = dgvTampilData.Rows(i).Cells(j).Value.ToString
                    ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    kolom += 1
                End If
              
            Next
            baris += 1
        Next
        ex.Visible = True
    End Sub
End Class
