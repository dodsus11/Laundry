Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class FormTambahLinenSetrika
    Public linen As Linen
    Private linenSvr As ILinenService
    Public Property kodelinen As String
    Public Property namalinen As String = ""
    Public Property jmllinenbersih As Integer
    Public Property jmllinenrusak As Integer
    Public Property jmllinenreject As Integer

    Private Function ValidateForm() As Boolean
        Dim result As Boolean = True
        If txtNamaLinen.Text = "" Then
            MsgBox("Pemilihan Linen Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtLinenBersih.Text) Then
            MsgBox("Jumlah Linen Bersih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtLinenRusak.Text) Then
            MsgBox("Jenis Linen Rusak Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txtLinenReject.Text) Then
            MsgBox("Jenis Linen Reject Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub btnLookUpLinen_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUpLinen.Click
        Me.linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"jns_linen_kode", "Kode Linen", 80},
                              {"jns_linen_nama", "Nama Linen", 200}}

        frmLookUp.keyField = "jns_linen_kode"
        frmLookUp.fields = {"jns_linen_nama"}

        frmLookUp.dt = Me.linenSvr.tampilLinenAktif()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNamaLinen.Text = frmLookUp.returnRow("jns_linen_nama").ToString()
            txtNamaLinen.Tag = frmLookUp.returnRow("jns_linen_kode").ToString()
        End If
        InProcFactory.CloseChannel(Me.linenSvr)
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            If MsgBox("Utilisasi mesin setrika. Linen bersih : " & txtLinenBersih.Text & ", linen rusak : " & txtLinenRusak.Text & ", linen reject : " & txtLinenReject.Text, MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    kodelinen = txtNamaLinen.Tag
                    namalinen = txtNamaLinen.Text
                    jmllinenbersih = CInt(txtLinenBersih.Text)
                    jmllinenrusak = CInt(txtLinenRusak.Text)
                    jmllinenreject = CInt(txtLinenReject.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txtLinenBersih_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenBersih.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub

    Private Sub txtLinenRusak_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenRusak.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub

    Private Sub txtLinenReject_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenReject.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub
End Class