Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Public Class ucDataUtilisasiMesinSetrika
    Dim rpt As New cr_LaporanRekapLinenKelauar()
    Dim dtReport As DataTable
    Public mesin As Mesin
    Dim dt As New DataTable

    Private LinenReportSvr As IReportLinenService
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

    Private Sub btnViewReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReport.Click
        utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
        dt = utilmesinSvr.DataUtilisasiMesinSetrika(fromDate.Value.Date, toDate.Value.Date)
        dgvTampilData.DataSource = dt
        'rename header
        With dgvTampilData
            .RowHeadersVisible = False
            For x As Integer = 0 To dgvTampilData.ColumnCount - 1
                .Columns(x).HeaderCell.Value = Replace(dgvTampilData.Columns(x).HeaderText, "_", " ")
            Next

        End With
        dgvTampilData.AllowUserToAddRows = False
        AddStyleToGrid(dgvTampilData)

        'FormatGrid()
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 7,
            kolom As Integer = 1,
            linen As Decimal = 0,
            lot As Integer = 0,
            jumlah As Integer = 0,
            rata As Integer = 0,
            totallinen As Integer = 0,
            totallot As Integer = 0
        ex.Workbooks.Add()


        ex.Cells(1, 1) = "Data Utilisasi Mesin Setrika"
        ex.Cells(2, 1) = "Instalasi Sterilisasi Sentral dan Binatu"
        ex.Cells(3, 1) = "Tanggal " & Format(fromDate.Value, "dd/MM/yyyy") & " s/d " & Format(toDate.Value, "dd/MM/yyyy")

        '===Mengisi Header===
        For j As Integer = 0 To dgvTampilData.ColumnCount - 1
            If dgvTampilData.Columns(j).Visible = True Then
                If j = 0 Then
                    ex.Cells(5, kolom) = Replace(dgvTampilData.Columns(j).HeaderText, "_", " ")
                    ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    kolom += 1
                Else
                    ex.Cells(5, kolom) = Replace(dgvTampilData.Columns(j).HeaderText, "-LOAD LINEN", "")
                    ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    j += 1
                    kolom += 2
                End If
                ex.Cells(6, kolom) = "Pemakaian (Load)"
                ex.Cells(6, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                ex.Cells(6, kolom + 1) = "Lembar/hari"
                ex.Cells(6, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
            End If
        Next
        ex.Cells(5, kolom) = "Jumlah"
        ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

        '===Mengisi Data===
        For i As Integer = 0 To dgvTampilData.RowCount - 1
            kolom = 1
            For j As Integer = 0 To dgvTampilData.ColumnCount - 1

                If dgvTampilData.Columns(j).Visible = True Then
                    ex.Cells(baris, kolom) = dgvTampilData.Rows(i).Cells(j).Value.ToString
                    ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    If (kolom > 1) And ((kolom Mod 2) <> 0) Then
                        linen = linen + CDec(dgvTampilData.Rows(i).Cells(j).Value)
                    ElseIf (kolom > 1) And ((kolom Mod 2) = 0) Then
                        lot = lot + dgvTampilData.Rows(i).Cells(j).Value
                    End If
                    kolom += 1
                End If
                ex.Cells(baris, kolom) = lot
                ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                ex.Cells(baris, kolom + 1) = linen
                ex.Cells(baris, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

            Next
            linen = 0
            lot = 0
            baris += 1
        Next

        ex.Visible = True
    End Sub
End Class
