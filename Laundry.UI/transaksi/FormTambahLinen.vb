Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class FormTambahLinen
    Public linen As Linen
    Private linenSvr As ILinenService
    Public Property idlinen As Integer
    Public Property namalinen As String = ""
    Public Property jmllinenNon As Integer
    Public Property jmllinenInf As Integer
    Public Property beratlinen As Decimal


    Private Function ValidateForm() As Boolean
        Dim result As Boolean = True
        If txtNamaLinen.Text = "" Then            
            MsgBox("Pemilihan Linen Masih Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txt_jmlNonInfeksius.Text) Then
            MsgBox("Jumlah Linen Non Infeksius Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        ElseIf String.IsNullOrEmpty(txt_jmlInfeksius.Text) Then
            MsgBox("Jenis Linen Infeksius Kosong", MsgBoxStyle.OkOnly, "Pesan")
            result = False
        End If
        Return result
    End Function

    Private Sub btnLookUpLinen_Click(sender As System.Object, e As System.EventArgs) Handles btnLookUpLinen.Click
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
            TextBox1.Text = frmLookUp.returnRow("berat_linen").ToString()
            
        End If
        
        InProcFactory.CloseChannel(Me.linenSvr)
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If Me.ValidateForm Then
            If MsgBox("Anda akan order Binatu " & txtNamaLinen.Text & " non infeksius sebanyak " & txt_jmlNonInfeksius.Text & ", infeksius sebanyak " & txt_jmlInfeksius.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    idlinen = txtNamaLinen.Tag
                    namalinen = txtNamaLinen.Text
                    jmllinenNon = CInt(txt_jmlNonInfeksius.Text)
                    jmllinenInf = CInt(txt_jmlInfeksius.Text)
                    beratlinen = CDec(txt_beratlinen.Text)

                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txt_jmlNonInfeksius_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_jmlNonInfeksius.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ",") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub


    Private Sub txt_jmlInfeksius_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_jmlInfeksius.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ",") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True

        End If
    End Sub

    Private Sub txt_beratlinen_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_beratlinen.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ".") Then
            MsgBox("hanya menerima inputan angka. Pemisah desimal menggunakan '. '.")
            e.Handled = True
        End If
        'JIKA YG DITEKAN ADALAH HURUF PEMISAH RIBUAN ATAU DESIMAL
        If e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator OrElse _
        e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator Then
            'UBAH HURUF TERSEBUT MENJADI HURUF PEMISAH DESIMAL
            e.KeyChar = CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            'NB : NUMBERGROUPSEPARATOR ADALAH PEMISAH RIBUAN PADA PENULISAN ANGKA
            'NB : NUMBERDECIMALSEPARATOR ADALAH PEMISAH DESIMAL PADA PENULISAN ANGKA
        End If
    End Sub

    Private Sub berat_linen()

        Dim berat_perLinen As Decimal = CDec(TextBox1.Text)
        Dim tot_LinenInf As Decimal
        Dim tot_LinenNonInf As Decimal

        'kondisi jika textbox jml infekisus kosong
        If txt_jmlInfeksius.Text = String.Empty Then
            tot_LinenInf = 0
        Else
            tot_LinenInf = berat_perLinen * CDec(txt_jmlInfeksius.Text)
        End If

        'kondisi jika txtbox jml non infekisus kosong
        If txt_jmlNonInfeksius.Text = String.Empty Then
            tot_LinenNonInf = 0
        Else
            tot_LinenNonInf = berat_perLinen * CDec(txt_jmlNonInfeksius.Text)
        End If

        Dim total_berat As Decimal = tot_LinenInf + tot_LinenNonInf
        txt_beratlinen.Text = total_berat.ToString

    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click, txt_jmlNonInfeksius.TextChanged, txt_jmlInfeksius.TextChanged
        Call berat_linen()
    End Sub

    
End Class