Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcInsertPembersih

    'objek mesin
    Public pembersih As Pembersih

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
        If pembersih.id_bahan_pembersih <> Nothing Then                      'untuk edit
            Dim brt_inf As String = Replace(pembersih.linen_infeksius_str, ".", ",")
            Dim brt_noninf As String = Replace(pembersih.linen_noninfeksius_str, ".", ",")
            txtIdPembersih.Text = pembersih.id_bahan_pembersih
            txtKdPembersih.Text = pembersih.kode_bahan_pembersih
            txtNamaPembersih.Text = pembersih.nama_bahan_pembersih
            txtVol.Text = pembersih.vol
            txtLinenInfeksius.Text = brt_inf
            txtLinenNoninfeksius.Text = brt_noninf
            SaveEditTemp.btnSaveAndNew.Visible = False
            'txtKdPembersih.Enabled = False
            Me.SaveEditTemp.setTitle("Edit Bahan Pembersih")
        Else
            'txtKdPembersih.Enabled = False                      'untuk new
            Me.SaveEditTemp.setTitle("Insert Bahan Pembersih")
        End If
    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            If pembersih.id_bahan_pembersih = Nothing Then
                If MsgBox("Anda akan menyimpan data " & txtNamaPembersih.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                        pembersihSvr.insertPembersih(New Pembersih With {.kode_bahan_pembersih = txtKdPembersih.Text, .nama_bahan_pembersih = txtNamaPembersih.Text, .vol = txtVol.Text, .linen_infeksius = txtLinenInfeksius.Text, .linen_noninfeksius = txtLinenNoninfeksius.Text})
                        MsgBox("Data pembersih " & txtNamaPembersih.Text & " telah berhasil disimpan")

                        Dim uc As New ModMasterPembersih
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(pembersihSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data " & txtNamaPembersih.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                        pembersihSvr.updatePembersih(New Pembersih With {.id_bahan_pembersih = txtIdPembersih.Text, .kode_bahan_pembersih = txtKdPembersih.Text, .nama_bahan_pembersih = txtNamaPembersih.Text, .vol = txtVol.Text, .linen_infeksius = txtLinenInfeksius.Text, .linen_noninfeksius = txtLinenNoninfeksius.Text})
                        MsgBox("Data pembersih " & txtNamaPembersih.Text & " telah berhasil diubah")

                        Dim uc As New ModMasterPembersih
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
        Dim uc As New ModMasterPembersih
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtKdPembersih.Text = ""
        txtNamaPembersih.Text = ""
        txtVol.Text = ""
        txtLinenInfeksius.Text = ""
        txtLinenNoninfeksius.Text = ""
        'cbYa.Checked = False
        ErrorProvider.Clear()
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            If MsgBox("Anda akan menyimpan data " & txtNamaPembersih.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                    pembersihSvr.insertPembersih(New Pembersih With {.kode_bahan_pembersih = txtKdPembersih.Text, .nama_bahan_pembersih = txtNamaPembersih.Text, .vol = txtVol.Text, .linen_infeksius = txtLinenInfeksius.Text, .linen_noninfeksius = txtLinenNoninfeksius.Text})
                    MsgBox("Data pembersih " & txtNamaPembersih.Text & " telah berhasil disimpan")
                    txtKdPembersih.Text = ""
                    txtNamaPembersih.Text = ""
                    txtVol.Text = ""
                    txtLinenInfeksius.Text = ""
                    txtLinenNoninfeksius.Text = ""
                   
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
        If txtKdPembersih.Text.Trim = "" Then
            ErrorProvider.SetError(txtKdPembersih, "Kode Chemical Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtKdPembersih, "")
        End If
        If txtNamaPembersih.Text.Trim = "" Then
            ErrorProvider.SetError(txtNamaPembersih, "Nama Chemical Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtNamaPembersih, "")
        End If
        If txtVol.Text.Trim = "" Then
            ErrorProvider.SetError(txtVol, "Vol Chemical Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtVol, "")
        End If
        If txtLinenInfeksius.Text.Trim = "" Then
            ErrorProvider.SetError(txtLinenInfeksius, "Berat Linen Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtLinenInfeksius, "")
        End If

        If Me.pembersih.id_bahan_pembersih = Nothing Then
            Try
                pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
                If pembersihSvr.isExistPembersih(New Pembersih With {.nama_bahan_pembersih = txtNamaPembersih.Text}) Then
                    ErrorProvider.SetError(txtNamaPembersih, "Pembersih sudah ada")
                    result = False
                End If
                InProcFactory.CloseChannel(pembersihSvr)
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
        Return result
    End Function

    Private Sub txtLinenInfeksius_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenInfeksius.KeyPress
        'JIKA YG DITEKAN ADALAH HURUF PEMISAH RIBUAN ATAU DESIMAL
        If e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator OrElse _
        e.KeyChar = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator Then
            'UBAH HURUF TERSEBUT MENJADI HURUF PEMISAH DESIMAL
            e.KeyChar = CChar(System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            'NB : NUMBERGROUPSEPARATOR ADALAH PEMISAH RIBUAN PADA PENULISAN ANGKA
            'NB : NUMBERDECIMALSEPARATOR ADALAH PEMISAH DESIMAL PADA PENULISAN ANGKA
        End If
    End Sub

    Private Sub txtLinenNoninfeksius_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenNoninfeksius.KeyPress
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
