Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model
Imports System.Windows.Forms

Public Class FormTambahInv
    Public linen As Linen
    Private linenSvr As ILinenService
    Private InvSvc As IInventarisService
    Public Property id As Integer
    'Public Property No_inventaris As String 
    Public Property idlinen As Integer
    Public Property namalinen As String = ""
    Public Property jmldisimpan As Integer
    Public Property jmldipakai As Integer
    Public Property jmldicuci As Integer
    Public Property jmlkotor As Integer
    Public Property totallinen As Integer
    Private dtlinen As New OrderInventaris
    Public no_inv As String
    Public id_linen As Integer

    Private Function ValidateForm() As Boolean
        InvSvc = InProcFactory.CreateChannel(Of InventarisService, IInventarisService)()
        idlinen = txtNamaLinen.Tag
        dtlinen.noInv = no_inv
        dtlinen.namaLinen = txtNamaLinen.Text
        Dim result As Boolean = True
        If txtNamaLinen.Text = "" Then
            MsgBox("Pemilihan Linen Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtJmlSimpan.Text) Then
            MsgBox("Jumlah Linen Disimpan Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtJmlCuci.Text) Then
            MsgBox("Jumlah Linen Dicuci Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtJmlKotor.Text) Then
            MsgBox("Jumlah Linen Kotor Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtJmlPakai.Text) Then
            MsgBox("Jumlah Linen Dipakai Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf InvSvc.isExistLinen(dtlinen) Then
            MsgBox("Nama Linen" & " " & txtNamaLinen.Text & " " & "Sudah Pernah Di Tambahkan")
            result = False
        End If

        InProcFactory.CloseChannel(InvSvc)

        Return result
    End Function

    Private Sub btnLookUpLinen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUpLinen.Click
        Me.linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"jns_linen_kode", "Kode Linen", 80},
                              {"jns_linen_nama", "Nama Linen", 200},
                              {"berat_linen", "Berat Linen (kg)", 100}}

        frmLookUp.keyField = "jns_linen_kode"
        frmLookUp.fields = {"jns_linen_nama"}

        frmLookUp.dt = Me.linenSvr.tampilLinenAktif()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNamaLinen.Text = frmLookUp.returnRow("jns_linen_nama").ToString()
            txtNamaLinen.Tag = frmLookUp.returnRow("jns_linen_kode").ToString()
        End If

        InProcFactory.CloseChannel(Me.linenSvr)

    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click

        If Me.ValidateForm Then
            If MsgBox("Anda akan menambahkan linen " & " " & txtNamaLinen.Text & " jml Disimpan " & " = " & txtJmlSimpan.Text & ", jml Dipakai " & " = " & txtJmlPakai.Text & "jml Dicuci" & " = " & txtJmlCuci.Text & "jml Kotor" & " = " & txtJmlKotor.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    id = 0
                    idlinen = txtNamaLinen.Tag
                    namalinen = txtNamaLinen.Text
                    jmldicuci = CInt(txtJmlCuci.Text)
                    jmldipakai = CInt(txtJmlPakai.Text)
                    jmldisimpan = CInt(txtJmlSimpan.Text)
                    jmlkotor = CInt(txtJmlKotor.Text)
                    totallinen = jmldicuci + jmldipakai + jmldisimpan + jmlkotor

                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub hitung_linen_total()
        If Integer.TryParse(txtJmlSimpan.Text, jmldisimpan) AndAlso _
           Integer.TryParse(txtJmlPakai.Text, jmldipakai) AndAlso _
           Integer.TryParse(txtJmlCuci.Text, jmldicuci) AndAlso _
           Integer.TryParse(txtJmlKotor.Text, jmlkotor) Then

            ' penjumlahan total
            totallinen = jmldicuci + jmldipakai + jmldisimpan + jmlkotor

            ' menampilkan hasil
            txtTotal.Text = totallinen.ToString()
        End If
    End Sub

    Private Sub txtJmlCuci_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJmlCuci.TextChanged
        hitung_linen_total()
    End Sub

    Private Sub txtJmlKotor_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJmlKotor.TextChanged
        hitung_linen_total()
    End Sub

    Private Sub txtJmlPakai_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJmlPakai.TextChanged
        hitung_linen_total()
    End Sub

    Private Sub txtJmlSimpan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJmlSimpan.TextChanged
        hitung_linen_total()
    End Sub
    'untuk validasi hanya inputan angka yg di ijinkan 
    Private Sub txtJmlCuci_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlCuci.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtJmlKotor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlKotor.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtJmlPakai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlPakai.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub txtJmlSimpan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlSimpan.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

End Class