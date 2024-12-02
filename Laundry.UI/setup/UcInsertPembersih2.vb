Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcInsertPembersih2

    'objek mesin
    Public pembersih As DosisPembersih

    Private pembersihSvr As IPembersihService

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click
    End Sub


    Private Sub UcInsertPembersih_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If pembersih.id <> Nothing Then                      'untuk edit            
            txtIdDosis.Text = pembersih.id
            cmb_jns_ident_kotoran.Text = pembersih.jenis_ident_kotoran
            txtBeratLinen.Text = pembersih.berat_linen
            txtJmlAlkaline.Text = pembersih.jml_alkaline
            txtJmlDetergent.Text = pembersih.jml_detergent
            txtJmlOxybleach.Text = pembersih.jml_oxybleach
            txtJmlSoftener.Text = pembersih.jml_softener
            txtJmlPenetral.Text = pembersih.jml_penetral
            SaveEditTemp.btnSaveAndNew.Visible = False
            'txtKdPembersih.Enabled = False
            Me.SaveEditTemp.setTitle("Edit Dosis Bahan Pembersih")
        Else
            'txtKdPembersih.Enabled = False                      'untuk new
            Me.SaveEditTemp.setTitle("Insert Dosis Bahan Pembersih")
        End If
    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            If pembersih.id = Nothing Then
                If MsgBox("Simpan data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                        pembersihSvr.insertDosisPembersih(New DosisPembersih With {.jenis_ident_kotoran = cmb_jns_ident_kotoran.Text, .berat_linen = txtBeratLinen.Text, .jml_alkaline = txtJmlAlkaline.Text, .jml_detergent = txtJmlDetergent.Text, .jml_oxybleach = txtJmlOxybleach.Text, .jml_softener = txtJmlSoftener.Text, .jml_penetral = txtJmlPenetral.Text})
                        MsgBox("Data dosis pembersih telah berhasil disimpan")

                        Dim uc As New ModMasterPembersih2
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(pembersihSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                        pembersihSvr.updateDosisPembersih(New DosisPembersih With {.id = txtIdDosis.Text, .jenis_ident_kotoran = cmb_jns_ident_kotoran.Text, .berat_linen = txtBeratLinen.Text, .jml_alkaline = txtJmlAlkaline.Text, .jml_detergent = txtJmlDetergent.Text, .jml_oxybleach = txtJmlOxybleach.Text, .jml_softener = txtJmlSoftener.Text, .jml_penetral = txtJmlPenetral.Text})
                        MsgBox("Data dosis pembersih telah berhasil diubah")

                        Dim uc As New ModMasterPembersih2
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(pembersihSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModMasterPembersih2
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)        
        txtBeratLinen.Text = ""
        txtJmlAlkaline.Text = ""
        txtJmlDetergent.Text = ""
        txtJmlOxybleach.Text = ""
        txtJmlSoftener.Text = ""
        txtJmlPenetral.Text = ""
        'cbYa.Checked = False
        ErrorProvider.Clear()
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            If MsgBox("Simpan data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                    pembersihSvr.insertDosisPembersih(New DosisPembersih With {.jenis_ident_kotoran = cmb_jns_ident_kotoran.Text, .berat_linen = txtBeratLinen.Text, .jml_alkaline = txtJmlAlkaline.Text, .jml_detergent = txtJmlDetergent.Text, .jml_oxybleach = txtJmlOxybleach.Text, .jml_softener = txtJmlSoftener.Text, .jml_penetral = txtJmlPenetral.Text})
                    MsgBox("Data dosis pembersih telah berhasil disimpan")
                    txtBeratLinen.Text = ""
                    txtJmlAlkaline.Text = ""
                    txtJmlDetergent.Text = ""
                    txtJmlOxybleach.Text = ""
                    txtJmlSoftener.Text = ""
                    txtJmlPenetral.Text = ""
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(pembersihSvr)
            End If
        End If
    End Sub

    'untuk error handling
    Private Function validateForm() As Boolean
        Dim result As Boolean = True
        If txtBeratLinen.Text.Trim = "" Then
            ErrorProvider.SetError(txtBeratLinen, "Berat Cucian Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtBeratLinen, "")
        End If        
        If txtJmlAlkaline.Text.Trim = "" Then
            ErrorProvider.SetError(txtJmlAlkaline, "Dosis Alkaline Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtJmlAlkaline, "")
        End If
        If txtJmlDetergent.Text.Trim = "" Then
            ErrorProvider.SetError(txtJmlDetergent, "Dosis Detergent Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtJmlDetergent, "")
        End If
        If txtJmlOxybleach.Text.Trim = "" Then
            ErrorProvider.SetError(txtJmlOxybleach, "Dosis Oxybleach Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtJmlOxybleach, "")
        End If
        If txtJmlSoftener.Text.Trim = "" Then
            ErrorProvider.SetError(txtJmlSoftener, "Dosis Softener Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtJmlSoftener, "")
        End If
        If txtJmlPenetral.Text.Trim = "" Then
            ErrorProvider.SetError(txtJmlPenetral, "Dosis Penetral Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtJmlPenetral, "")
        End If
        

        If Me.pembersih.id = Nothing Then
            Try
                pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                If pembersihSvr.isExistDosisPembersih(New DosisPembersih With {.jenis_ident_kotoran = cmb_jns_ident_kotoran.Text, .berat_linen = txtBeratLinen.Text}) Then
                    ErrorProvider.SetError(cmb_jns_ident_kotoran, "Dosis untuk pembersih linen " & cmb_jns_ident_kotoran.Text & " dengan berat " & txtBeratLinen.Text & " kg sudah ada.")
                    result = False
                End If
                InProcFactory.CloseChannel(pembersihSvr)
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
        Return result
    End Function

    Private Sub txtLinenInfeksius_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlDetergent.KeyPress
        'JIKA YG DITEKAN ADALAH HURUF PEMISAH RIBUAN ATAU DESIMAL
        If e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator OrElse _
        e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator Then
            'UBAH HURUF TERSEBUT MENJADI HURUF PEMISAH DESIMAL
            e.KeyChar = CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            'NB : NUMBERGROUPSEPARATOR ADALAH PEMISAH RIBUAN PADA PENULISAN ANGKA
            'NB : NUMBERDECIMALSEPARATOR ADALAH PEMISAH DESIMAL PADA PENULISAN ANGKA
        End If
    End Sub

    Private Sub txtLinenNoninfeksius_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlOxybleach.KeyPress
        'JIKA YG DITEKAN ADALAH HURUF PEMISAH RIBUAN ATAU DESIMAL
        If e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator OrElse _
        e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator Then
            'UBAH HURUF TERSEBUT MENJADI HURUF PEMISAH DESIMAL
            e.KeyChar = CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            'NB : NUMBERGROUPSEPARATOR ADALAH PEMISAH RIBUAN PADA PENULISAN ANGKA
            'NB : NUMBERDECIMALSEPARATOR ADALAH PEMISAH DESIMAL PADA PENULISAN ANGKA
        End If
    End Sub
End Class
