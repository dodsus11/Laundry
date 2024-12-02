Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ucDataUtilisasiMesinCuci
    Dim rpt As New cr_LaporanRekapLinenKelauar()
    Dim dtReport As DataTable
    Public mesin As Mesin
    Dim dt As New DataTable
    Dim dt2 As New DataTable

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
        If ComboBox1.SelectedItem Is Nothing Then
            MsgBox("Silahkan Pilih Jenis Linen ")
            Exit Sub
        End If
        Dim jns_linen As String
        If ComboBox1.SelectedItem.ToString = "NON INFEKSIUS" Then
            jns_linen = "1"
            dt2 = utilmesinSvr.DataUtilisasiMesinCucibyLinen(fromDate.Value.Date, toDate.Value.Date, jns_linen)
            dgvTampilData.DataSource = dt2
        ElseIf ComboBox1.SelectedItem.ToString = "INFEKSIUS" Then
            jns_linen = "0"
            dt2 = utilmesinSvr.DataUtilisasiMesinCucibyLinen(fromDate.Value.Date, toDate.Value.Date, jns_linen)
            dgvTampilData.DataSource = dt2
        ElseIf ComboBox1.SelectedItem.ToString = "REJECT" Then
            jns_linen = "2"
            dt2 = utilmesinSvr.DataUtilisasiMesinCucibyLinen(fromDate.Value.Date, toDate.Value.Date, jns_linen)
            dgvTampilData.DataSource = dt2

        Else
            dt = utilmesinSvr.DataUtilisasiMesinCuci(fromDate.Value.Date, toDate.Value.Date)
            dgvTampilData.DataSource = dt
        End If
        'utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
        'dt = utilmesinSvr.DataUtilisasiMesinCuci(fromDate.Value.Date, toDate.Value.Date)
      
        'dgvTampilData.DataSource = dt
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

    Private Sub C1Button1_Click(sender As System.Object, e As System.EventArgs) Handles C1Button1.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 8,
            kolom As Integer = 1,
            linen As Decimal = 0,
            lot As Integer = 0,
            jumlah As Integer = 0,
            totallinen As Integer = 0,
            totallot As Integer = 0
        ex.Workbooks.Add()


        ex.Cells(1, 1) = "Data Utilisasi Mesin Cuci"
        ex.Cells(2, 1) = "Instalasi Sterilisasi Sentral dan Binatu"
        ex.Cells(3, 1) = "Tanggal " & Format(fromDate.Value, "dd/MM/yyyy") & " s/d " & Format(toDate.Value, "dd/MM/yyyy")
        ex.Cells(4, 1) = "Jenis Linen :" & " " & ComboBox1.SelectedItem.ToString

        '===Mengisi Header===
        For j As Integer = 0 To dgvTampilData.ColumnCount - 1
            If dgvTampilData.Columns(j).Visible = True Then
                If j = 0 Then
                    ex.Cells(6, kolom) = Replace(dgvTampilData.Columns(j).HeaderText, "_", " ")
                    ex.Cells(6, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    kolom += 1
                Else
                    ex.Cells(6, kolom) = Replace(dgvTampilData.Columns(j).HeaderText, "-LOAD LINEN", " ")
                    ex.Cells(6, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    j += 1
                    kolom += 2
                End If
                ex.Cells(7, kolom) = "Pemakaian (Load)"
                ex.Cells(7, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                ex.Cells(7, kolom + 1) = "Kg/hari"
                ex.Cells(7, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
            End If
        Next
        ex.Cells(7, kolom) = "Jumlah"
        ex.Cells(7, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

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
                    ex.Cells(baris, kolom) = lot
                    ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    ex.Cells(baris, kolom + 1) = linen
                    ex.Cells(baris, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                End If
            Next
            linen = 0
            lot = 0
            baris += 1
        Next

        ex.Visible = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 6,
            kolom As Integer = 1,
            linen As Integer = 0,
            lot As Integer = 0,
            jumlah As Integer = 0,
            rata As Integer = 0,
            totallinen As Integer = 0,
            totallot As Integer = 0
        ex.Workbooks.Add()


        ex.Cells(1, 1) = "Data Utilisasi Mesin Cuci"
        ex.Cells(2, 1) = "Instalasi Sterilisasi Sentral dan Binatu"
        ex.Cells(3, 1) = "Tanggal " & Format(fromDate.Value, "dd/MM/yyyy") & " s/d " & Format(toDate.Value, "dd/MM/yyyy")

        'ex.Cells(5, 1) = "No"
        'ex.Cells(5, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        '===Mengisi Header===
        For j As Integer = 0 To dgvTampilData.ColumnCount - 1
            If dgvTampilData.Columns(j).Visible = True Then
                ex.Cells(5, kolom) = Replace(dgvTampilData.Columns(j).HeaderText, "_", " ")
                ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

                kolom += 1
            End If
        Next
        ex.Cells(5, kolom) = "Pemakaian (Load)"
        ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(5, kolom + 1) = "Kg/hari"
        ex.Cells(5, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

        '===Mengisi Data===
        For i As Integer = 0 To dgvTampilData.RowCount - 1
            kolom = 2
            For j As Integer = 0 To dgvTampilData.ColumnCount - 1

                ex.Cells(baris, 1) = i + 1
                ex.Cells(baris, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                If dgvTampilData.Columns(j).Visible = True Then
                    ex.Cells(baris, kolom) = dgvTampilData.Rows(i).Cells(j).Value.ToString
                    ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    If (kolom > 2) And ((kolom Mod 2) <> 0) Then
                        linen = linen + dgvTampilData.Rows(i).Cells(j).Value
                    ElseIf (kolom > 2) And ((kolom Mod 2) = 0) Then
                        lot = lot + dgvTampilData.Rows(i).Cells(j).Value
                    End If
                    kolom += 1
                End If
                ex.Cells(baris, kolom) = linen
                ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                ex.Cells(baris, kolom + 1) = lot
                ex.Cells(baris, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

            Next
            linen = 0
            lot = 0
            baris += 1
        Next

        '===Mengisi Jumlah dan Rata-rata===
        kolom = 2
        For j As Integer = 0 To dgvTampilData.ColumnCount - 1

            baris = 6
            For i As Integer = 0 To dgvTampilData.RowCount - 1
                If dgvTampilData.Columns(j).Visible = True Then
                    If kolom > 2 Then
                        jumlah = jumlah + dgvTampilData.Rows(i).Cells(j).Value
                    End If
                End If
                baris += 1
            Next
            If kolom = 2 Then
                ex.Cells(baris, kolom) = "Jumlah"
                ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                ex.Cells(baris + 1, kolom) = "Rata-rata"
                ex.Cells(baris + 1, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
            Else
                ex.Cells(baris, kolom) = jumlah
                ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                ex.Cells(baris + 1, kolom) = (jumlah / dgvTampilData.RowCount)
                ex.Cells(baris + 1, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                If (kolom Mod 2) = 0 Then
                    totallot = totallot + jumlah
                Else
                    totallinen = totallinen + jumlah
                End If
            End If
            jumlah = 0
            kolom += 1
        Next

        '===Mengisi Total Linen dan Total Lot beserta Rata-rata nya===
        ex.Cells(baris, kolom) = totallinen
        ex.Cells(baris, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(baris, kolom + 1) = totallot
        ex.Cells(baris, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

        ex.Cells(baris + 1, kolom) = (totallinen / dgvTampilData.RowCount)
        ex.Cells(baris + 1, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(baris + 1, kolom + 1) = (totallot / dgvTampilData.RowCount)
        ex.Cells(baris + 1, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Visible = True
    End Sub

   
    
End Class
