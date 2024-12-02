Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model
Imports System.Windows.Forms

Public Class FormAddDataLinen
    Private linenSvr As ILinenService
    Public linen As PerolehanLinen
    Public kodelinen As String
    Public namaLinen As String
    Public petugas As String

    Private Sub FormAddDataLinen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        txtnama.Text = namaLinen

        For i = DateTime.Now.Year - 6 To DateTime.Now.Year + 1
            cbTahun.Items.Add(i)
            cbTahun.Text = DateTime.Now.Year
        Next

        
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If txtJml.Text = "" Then
            MessageBox.Show("Jumlah Linen Belum Di isi")
            Exit Sub
        Else

            Dim kdlinen As String = kodelinen
            Dim dtLinen As New PerolehanLinen
            Dim tgl As Date = DateTime.Now
            Try
                dtLinen.namaLinen = txtnama.Text
                dtLinen.tahunPerolehan = cbTahun.SelectedItem.ToString
                dtLinen.qty = CInt(txtJml.Text)
                dtLinen.keterangan = txtKet.Text
                dtLinen.kodeLinen = kdlinen
                dtLinen.entry_by = petugas
                dtLinen.entry_date = tgl

                linenSvr.insertPerolehanLinen(dtLinen)
            Catch ex As Exception


            End Try
        End If
        MessageBox.Show("Data Linen Berhasil diTambahkan")

        Me.Close()

    End Sub

    Private Sub txtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJml.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class