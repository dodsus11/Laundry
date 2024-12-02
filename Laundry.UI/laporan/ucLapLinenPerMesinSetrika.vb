Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing

Public Class ucLapLinenPerMesinSetrika
    Dim rpt As New cr_LaporanRekapLinenKelauar()
    Dim dtReport As DataTable
    Public mesin As Mesin
    Dim dt As New DataTable
    Dim listOfProduct As List(Of String) = New List(Of String)
    Dim tt As ToolTip
    Private LinenReportSvr As IReportLinenService
    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Private linenSvr As ILinenService

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
        dgvLinen.Columns("tgl").HeaderText = "Tanggal"
        dgvLinen.Columns("tgl").Width = 100
        dgvLinen.Columns("namamesin").HeaderText = "Nama Mesin"
        dgvLinen.Columns("namamesin").Width = 100
        dgvLinen.Columns("namalinen").HeaderText = "Nama Linen"
        dgvLinen.Columns("namalinen").Width = 100
        dgvLinen.Columns("linenbersih").HeaderText = "Linen Bersih"
        dgvLinen.Columns("linenbersih").Width = 100
        dgvLinen.Columns("linenrusak").HeaderText = "Linen Rusak"
        dgvLinen.Columns("linenrusak").Width = 120
        dgvLinen.Columns("linenreject").HeaderText = "Linen Reject"
        dgvLinen.Columns("linenreject").Width = 100

    End Sub

    Private Sub btnViewReport_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReport.Click
        utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
        dt = utilmesinsetrikaSvr.getLinenTiapMesinSetrika(txtMesin.Tag, txtLinen.Tag, dtpTglAwal.Text, dtpTglAkhir.Text)
        dgvLinen.DataSource = dt
        dgvLinen.AllowUserToAddRows = False
        AddStyleToGrid(dgvLinen)
        FormatGrid()
    End Sub

    'lookup mesin
    Private Sub btnMesin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMesin.Click
        Me.utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 50},
                              {"kode_mesin", "Kode Mesin", 100},
                              {"nama_mesin", "Nama Mesin", 200},
                              {"kapasitas_mesin", "Kapasitas (lembar)", 150},
                              {"maxload_mesin", "Maks Load/hari", 150},
                              {"jenis_mesin", "Jenis Mesin", 150}}

        frmLookUp.keyField = "kode_mesin"
        frmLookUp.fields = {"nama_mesin", "kapasitas_mesin", "maxload_mesin", "jenis_mesin"}
        frmLookUp.dt = Me.utilmesinsetrikaSvr.getMesinSetrika(New Mesin With {.jenis_mesin = "4"})

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMesin.Text = frmLookUp.returnRow("nama_mesin").ToString
            txtMesin.Tag = frmLookUp.returnRow("kode_mesin").ToString
            txtMesin.TabIndex = frmLookUp.returnRow("kapasitas_mesin")
        End If

        InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
    End Sub

    Private Sub btn_excel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_excel.Click
        Dim ex As New Microsoft.Office.Interop.Excel.Application
        Dim baris As Integer = 6

        ex.Workbooks.Add()

        'cetak header
        ex.Cells(1, 1) = "Data Utilisasi Mesin Setrika"
        ex.Cells(2, 1) = "Instalasi Sterilisasi Sentral dan Binatu"
        ex.Cells(3, 1) = "Tanggal " & Format(dtpTglAwal.Value, "dd/MM/yyyy") & " s/d " & Format(dtpTglAkhir.Value, "dd/MM/yyyy")

        'cetak nama kolom
        ex.Cells(5, 1) = "Tanggal"
        ex.Cells(5, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(5, 2) = "Nama Mesin"
        ex.Cells(5, 2).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(5, 3) = "Nama Linen"
        ex.Cells(5, 3).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(5, 4) = "Linen Bersih"
        ex.Cells(5, 4).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(5, 5) = "Linen Rusak"
        ex.Cells(5, 5).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
        ex.Cells(5, 6) = "Linen Reject"
        ex.Cells(5, 6).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

        'cetak isian kolom
        For j As Integer = 0 To dgvLinen.RowCount - 1
            ex.Cells(baris + j, 1) = dgvLinen.Rows(j).Cells(0).Value
            ex.Cells(baris + j, 2) = dgvLinen.Rows(j).Cells(1).Value
            ex.Cells(baris + j, 3) = dgvLinen.Rows(j).Cells(2).Value
            ex.Cells(baris + j, 4) = dgvLinen.Rows(j).Cells(3).Value
            ex.Cells(baris + j, 5) = dgvLinen.Rows(j).Cells(4).Value
            ex.Cells(baris + j, 6) = dgvLinen.Rows(j).Cells(5).Value
        Next
        ex.Visible = True
    End Sub
    'Private Sub btn_excel_Click(sender As System.Object, e As System.EventArgs) Handles btn_excel.Click
    '    Dim ex As New Microsoft.Office.Interop.Excel.Application
    '    Dim baris As Integer = 7,
    '        kolom As Integer = 2,
    '        ts As Integer = 0,
    '        totbe As Integer = 0,
    '        totru As Integer = 0,
    '        totre As Integer = 0,
    '        jml_klm_msn As Integer = 0,
    '        klm_msn As Integer
    '    ex.Workbooks.Add()

    '    'cetak header
    '    ex.Cells(1, 1) = "Data Utilisasi Mesin Setrika"
    '    ex.Cells(2, 1) = "Instalasi Sterilisasi Sentral dan Binatu"
    '    ex.Cells(3, 1) = "Tanggal " & Format(dtpTglAwal.Value, "dd/MM/yyyy") & " s/d " & Format(dtpTglAkhir.Value, "dd/MM/yyyy")

    '    ex.Cells(5, 1) = "Tanggal"
    '    ex.Cells(5, 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

    '    'cetak nama kolom
    '    For j As Integer = 0 To dgvLinen.RowCount - 1
    '        ts = 0
    '        For i As Integer = 0 To j
    '            If j = 0 Then
    '                ex.Cells(5, kolom) = dgvLinen.Rows(j).Cells(1).Value.ToString()
    '                ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

    '                ex.Cells(6, kolom) = "Bersih"
    '                ex.Cells(6, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '                ex.Cells(6, kolom + 1) = "Rusak"
    '                ex.Cells(6, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '                ex.Cells(6, kolom + 2) = "Reject"
    '                ex.Cells(6, kolom + 2).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '                jml_klm_msn = jml_klm_msn + 1 'jumlah kolom mesin
    '                listOfProduct.Add(dgvLinen.Rows(j).Cells(1).Value.ToString())
    '            Else
    '                If dgvLinen.Rows(j).Cells(1).Value.ToString <> dgvLinen.Rows(i).Cells(1).Value.ToString Then
    '                    ts = ts + 1
    '                    If ts = j Then
    '                        kolom += 3
    '                        ex.Cells(5, kolom) = dgvLinen.Rows(j).Cells(1).Value.ToString()
    '                        ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

    '                        ex.Cells(6, kolom) = "Bersih"
    '                        ex.Cells(6, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '                        ex.Cells(6, kolom + 1) = "Rusak"
    '                        ex.Cells(6, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '                        ex.Cells(6, kolom + 2) = "Reject"
    '                        ex.Cells(6, kolom + 2).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '                        jml_klm_msn = jml_klm_msn + 1 'jumlah kolom mesin
    '                        listOfProduct.Add(dgvLinen.Rows(j).Cells(1).Value.ToString())
    '                    End If
    '                End If
    '            End If
    '        Next
    '    Next
    '    kolom += 3
    '    ex.Cells(5, kolom) = "Jumlah"
    '    ex.Cells(5, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '    ex.Cells(6, kolom) = "Bersih"
    '    ex.Cells(6, kolom).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '    ex.Cells(6, kolom + 1) = "Rusak"
    '    ex.Cells(6, kolom + 1).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)
    '    ex.Cells(6, kolom + 2) = "Reject"
    '    ex.Cells(6, kolom + 2).BorderAround(Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous, Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline, Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic)

    '    'cetak isian
    '    For j As Integer = 0 To dgvLinen.RowCount - 1
    '        If j = 0 Then
    '            ex.Cells(baris, 1) = dgvLinen.Rows(j).Cells(0).Value.ToString
    '            For k As Integer = 0 To listOfProduct.Count - 1
    '                Dim n As Integer = k + 1
    '                klm_msn = (2 * n) + (n - 1)
    '                If dgvLinen.Rows(j).Cells(1).Value.ToString = listOfProduct.Item(k).ToString Then
    '                    ex.Cells(baris, klm_msn) = dgvLinen.Rows(j).Cells(2).Value.ToString
    '                    ex.Cells(baris, klm_msn + 1) = dgvLinen.Rows(j).Cells(3).Value.ToString
    '                    ex.Cells(baris, klm_msn + 2) = dgvLinen.Rows(j).Cells(4).Value.ToString
    '                    'akumulasi jumlah total
    '                    totbe = totbe + dgvLinen.Rows(j).Cells(2).Value.ToString
    '                    totru = totru + dgvLinen.Rows(j).Cells(3).Value.ToString
    '                    totre = totre + dgvLinen.Rows(j).Cells(4).Value.ToString
    '                End If
    '            Next

    '        ElseIf j > 0 Then
    '            If dgvLinen.Rows(j).Cells(0).Value.ToString = dgvLinen.Rows(j - 1).Cells(0).Value.ToString Then
    '                For k As Integer = 0 To listOfProduct.Count - 1
    '                    Dim n As Integer = k + 1
    '                    klm_msn = (2 * n) + (n - 1)
    '                    If dgvLinen.Rows(j).Cells(1).Value.ToString = listOfProduct.Item(k).ToString Then
    '                        ex.Cells(baris, klm_msn) = dgvLinen.Rows(j).Cells(2).Value.ToString
    '                        ex.Cells(baris, klm_msn + 1) = dgvLinen.Rows(j).Cells(3).Value.ToString
    '                        ex.Cells(baris, klm_msn + 2) = dgvLinen.Rows(j).Cells(4).Value.ToString
    '                        'akumulasi jumlah total
    '                        totbe = totbe + dgvLinen.Rows(j).Cells(2).Value.ToString
    '                        totru = totru + dgvLinen.Rows(j).Cells(3).Value.ToString
    '                        totre = totre + dgvLinen.Rows(j).Cells(4).Value.ToString
    '                    End If
    '                Next

    '            Else
    '                'print jumlah total
    '                ex.Cells(baris, klm_msn + 3) = totbe
    '                ex.Cells(baris, klm_msn + 4) = totru
    '                ex.Cells(baris, klm_msn + 5) = totre
    '                totbe = 0
    '                totru = 0
    '                totre = 0
    '                baris += 1
    '                ex.Cells(baris, 1) = dgvLinen.Rows(j).Cells(0).Value.ToString
    '                For k As Integer = 0 To listOfProduct.Count - 1
    '                    Dim n As Integer = k + 1
    '                    klm_msn = (2 * n) + (n - 1)
    '                    If dgvLinen.Rows(j).Cells(1).Value.ToString = listOfProduct.Item(k).ToString Then
    '                        ex.Cells(baris, klm_msn) = dgvLinen.Rows(j).Cells(2).Value.ToString
    '                        ex.Cells(baris, klm_msn + 1) = dgvLinen.Rows(j).Cells(3).Value.ToString
    '                        ex.Cells(baris, klm_msn + 2) = dgvLinen.Rows(j).Cells(4).Value.ToString
    '                        'akumulasi jumlah total
    '                        totbe = totbe + dgvLinen.Rows(j).Cells(2).Value.ToString
    '                        totru = totru + dgvLinen.Rows(j).Cells(3).Value.ToString
    '                        totre = totre + dgvLinen.Rows(j).Cells(4).Value.ToString
    '                    End If
    '                Next

    '            End If
    '        End If
    '    Next
    '    'print jumlah total baris terahir
    '    ex.Cells(baris, klm_msn + 3) = totbe
    '    ex.Cells(baris, klm_msn + 4) = totru
    '    ex.Cells(baris, klm_msn + 5) = totre

    '    ex.Visible = True
    '    listOfProduct.Clear()
    'End Sub

    'lookup Linen
    Private Sub btnLinen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinen.Click
        Me.linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"jns_linen_kode", "Kode Linen", 80},
                              {"jns_linen_nama", "Nama Linen", 200}}

        frmLookUp.keyField = "jns_linen_kode"
        frmLookUp.fields = {"jns_linen_nama"}

        frmLookUp.dt = Me.linenSvr.tampilLinenAktif()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtLinen.Text = frmLookUp.returnRow("jns_linen_nama").ToString()
            txtLinen.Tag = frmLookUp.returnRow("jns_linen_kode").ToString()
        End If
        InProcFactory.CloseChannel(Me.linenSvr)
    End Sub

    Private Sub txtLinen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinen.KeyPress
        MsgBox("Free Text Off" & vbCrLf & "guakan tombol button", MsgBoxStyle.OkOnly, "Pesan")
        txtLinen.Text = ""
    End Sub

    Private Sub txtLinen_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtLinen.MouseClick
        txtLinen.Text = ""
        txtLinen.Tag = ""
    End Sub

    Private Sub txtLinen_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLinen.MouseHover
        tt = New ToolTip
        tt.SetToolTip(txtLinen, "klik reset")
    End Sub

    Private Sub txtMesin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMesin.KeyPress
        MsgBox("Free Text Off" & vbCrLf & "guakan tombol button", MsgBoxStyle.OkOnly, "Pesan")
        txtMesin.Text = ""
    End Sub

    Private Sub txtMesin_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtMesin.MouseClick
        txtMesin.Text = ""
        txtMesin.Tag = ""
    End Sub

    Private Sub txtMesin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMesin.MouseHover
        tt = New ToolTip
        tt.SetToolTip(txtMesin, "klik reset")
    End Sub
End Class
