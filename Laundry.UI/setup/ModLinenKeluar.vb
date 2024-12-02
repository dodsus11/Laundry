Imports Laundry.Service.service
Imports ClientLibs
Imports Laundry.Service.model
Imports UILibs
Imports System.Windows.Forms
Imports System.Drawing
Imports Laundry.UI.Utility

Public Class ModLinenKeluar
    Private linenSvr As ILinenService
    Dim dv As New DataView
    Dim tglfrom As Date
    Dim tglto As Date



    Private Sub Loaddata()
        tglfrom = DateTimePicker1.Value
        tglto = DateTimePicker2.Value
        Try
            linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
            Dim dt As New DataTable

            dt = linenSvr.LoadLinenKeluar(tglfrom, tglto)
            dv.Table = dt
            dgvLinenKeluar.DataSource = dv

            Dim col As New List(Of GridColumnModel)
            col.Add(GH.AddModelGridColumn("Tanggal Setrika", 150))
            col.Add(GH.AddModelGridColumn("Jumlah Rusak", 100))
            col.Add(GH.AddModelGridColumn("Jumlah Jahit", 100))
            col.Add(GH.AddModelGridColumn("Jumlah Afkir", 100))
            col.Add(GH.AddModelGridColumn("Keterangan", 300))
            col.Add(GH.AddModelGridColumn("Operator", 200))
            GH.FormatGrid(dgvLinenKeluar, dt, col, True, True, False, True)
            InProcFactory.CloseChannel(linenSvr)

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Loaddata()
    End Sub

    Private Sub tsNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew.Click
        
        If dgvLinenKeluar.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih data terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim uc As New UcDetailDataLinenRusak
            Dim tanggal As Date
            tanggal = dgvLinenKeluar.SelectedRows.Item(0).DataBoundItem("tanggal_setrika")
            Dim objTransOut As New TransOut With {.tgl = tanggal, .tgl_awal = DateTimePicker1.Value, .tgl_akhir = DateTimePicker2.Value}
            uc.header = objTransOut
            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If
    End Sub

    Private Sub tsNew2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsNew2.Click
        If dgvLinenKeluar.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih data terlebih dahulu!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim uc As New UcAddDetailDataPerolehanLinen
            Dim tanggal As Date
            Dim petugas As String
            tanggal = dgvLinenKeluar.SelectedRows.Item(0).DataBoundItem("tanggal_setrika")
            petugas = dgvLinenKeluar.SelectedRows.Item(0).DataBoundItem("operator")
            Dim objTransOut As New TransOut With {.tgl = tanggal, .entryByTO = petugas, .tgl_awal = DateTimePicker1.Value, .tgl_akhir = DateTimePicker2.Value}
            uc.header = objTransOut
            UILibs.PageLink.goToPage(Me.Parent, uc, Me)
        End If

    End Sub

    Private Sub tsTxtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsTxtSearch.TextChanged
        Dim str As String = CType(sender, ToolStripTextBox).Text
        dv.RowFilter = String.Format("tanggal_setrika LIKE '%{0}%' or keterangan LIKE '%{0}%' or operator LIKE '%{0}%'", str)
    End Sub

    Private Sub ModLinenKeluar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Loaddata()

    End Sub
End Class
