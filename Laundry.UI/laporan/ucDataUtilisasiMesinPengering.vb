Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ucDataUtilisasiMesinPengering
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


    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
        dt = utilmesinSvr.DataUtilisasiMesinPengering(fromDate.Value.Date, toDate.Value.Date)
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

    'lookup mesin
    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
    '    Me.utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
    '    Dim frmLookUp As New UILibs.DlgLookUp()
    '    frmLookUp.fidArray = {{"nomer", "No", 50},
    '                          {"kode_mesin", "Kode Mesin", 100},
    '                          {"nama_mesin", "Nama Mesin", 200},
    '                          {"kapasitas_mesin", "Kapasitas (lembar)", 150},
    '                          {"maxload_mesin", "Maks Load/hari", 150},
    '                          {"jenis_mesin", "Jenis Mesin", 150}}

    '    frmLookUp.keyField = "kode_mesin"
    '    frmLookUp.fields = {"nama_mesin", "kapasitas_mesin", "maxload_mesin", "jenis_mesin"}
    '    frmLookUp.dt = Me.utilmesinsetrikaSvr.getMesinSetrika(New Mesin With {.jenis_mesin = "4"})

    '    If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        txtMesin.Text = frmLookUp.returnRow("nama_mesin").ToString
    '        txtMesin.Tag = frmLookUp.returnRow("kode_mesin").ToString
    '        txtMesin.TabIndex = frmLookUp.returnRow("kapasitas_mesin")
    '    End If

    '    InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
    'End Sub

    Private Sub C1Button1_Click(sender As System.Object, e As System.EventArgs) Handles C1Button1.Click
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


        ex.Cells(1, 1) = "Data Utilisasi Mesin Pengering"
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
                    ex.Cells(5, kolom) = Replace(dgvTampilData.Columns(j).HeaderText, "load linen ", "")
                    ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                    j += 1
                    kolom += 2
                End If
                ex.Cells(6, kolom) = "Pemakaian (Load)"
                ex.Cells(6, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
                ex.Cells(6, kolom + 1) = "Kg/hari"
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
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


        ex.Cells(1, 1) = "Data Utilisasi Mesin Pengering"
        ex.Cells(2, 1) = "Instalasi Laundry & CSSD"
        ex.Cells(3, 1) = "Tanggal " & Format(fromDate.Value, "dd/MM/yyyy") & " s/d " & Format(toDate.Value, "dd/MM/yyyy")

        ex.Cells(5, 1) = "No"
        ex.Cells(5, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        '===Mengisi Header===
        For j As Integer = 0 To dgvTampilData.ColumnCount - 1
            If dgvTampilData.Columns(j).Visible = True Then
                ex.Cells(5, kolom) = Replace(dgvTampilData.Columns(j).HeaderText, "_", " ")
                ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

                kolom += 1
            End If
        Next
        ex.Cells(5, kolom) = "Jumlah Linen"
        ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(5, kolom + 1) = "Jumlah LOT"
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
