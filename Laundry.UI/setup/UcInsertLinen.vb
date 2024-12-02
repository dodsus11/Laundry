Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcInsertLinen

    'objek linen
    Public linen As Linen

    Private linenSvr As ILinenService

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click
    End Sub

    Private Sub UcInsertLinen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load        
        If linen.jns_linen_id <> Nothing Then            'untuk edit  
            Dim brt As String = Replace(linen.berat_linen_str, ".", ",")
            txtId.Text = linen.jns_linen_id
            txtKodeLinen.Text = linen.jns_linen_kode
            txtNamaLinen.Text = linen.jns_linen_nama
            txtBeratLinen.Text = brt
            SaveEditTemp.btnSaveAndNew.Visible = False
            Me.SaveEditTemp.setTitle("Edit Linen")
        Else
            'txtKodeLinen.Enabled = False                        'untuk new
            Me.SaveEditTemp.setTitle("Insert Linen")
        End If
    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            If linen.jns_linen_id = Nothing Then
                If MsgBox("Anda akan menyimpan data " & txtNamaLinen.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
                        linenSvr.insertLinen(New Linen With {.jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text})
                        'If dtpTglAktf.Enabled = True Then
                        '    linenSvr.insertLinen(New Linen With {.linen_flag = 1, .jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text, .jumlah_linen = txtJumlahLinen.Text, .actived_date = dtpTglAktf.Value})
                        'Else
                        '    linenSvr.insertLinen(New Linen With {.linen_flag = 0, .jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text, .jumlah_linen = txtJumlahLinen.Text, .actived_date = dtpTglAktf.Value})
                        'End If
                        MsgBox("Data linen " & txtNamaLinen.Text & " telah berhasil disimpan")

                        Dim uc As New ModInsertLinen
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(linenSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data " & txtNamaLinen.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
                        linenSvr.updateLinen(New Linen With {.jns_linen_id = txtId.Text, .jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text})
                        'If dtpTglAktf.Enabled = True Then
                        '    linenSvr.updateLinen(New Linen With {.linen_flag = 1, .jns_linen_id = txtId.Text, .jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text, .actived_date = dtpTglAktf.Value})
                        'Else
                        '    linenSvr.updateLinen(New Linen With {.linen_flag = 0, .jns_linen_id = txtId.Text, .jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text, .actived_date = dtpTglAktf.Value})
                        'End If

                        MsgBox("Data Linen " & txtNamaLinen.Text & " telah berhasil diubah")

                        Dim uc As New ModInsertLinen
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(linenSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModInsertLinen
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtNamaLinen.Text = ""
        ErrorProvider.Clear()
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            If MsgBox("Anda akan menyimpan data " & txtNamaLinen.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
                    linenSvr.insertLinen(New Linen With {.jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text})
                    'If dtpTglAktf.Enabled = True Then
                    '    linenSvr.insertLinen(New Linen With {.linen_flag = 1, .jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text, .jumlah_linen = txtJumlahLinen.Text, .actived_date = dtpTglAktf.Value})
                    'Else
                    '    linenSvr.insertLinen(New Linen With {.linen_flag = 0, .jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text, .berat_linen = txtBeratLinen.Text, .jumlah_linen = txtJumlahLinen.Text, .actived_date = dtpTglAktf.Value})
                    'End If
                    MsgBox("Data linen " & txtNamaLinen.Text & " telah berhasil disimpan")
                    txtKodeLinen.Text = ""
                    txtNamaLinen.Text = ""
                    txtBeratLinen.Text = ""

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(linenSvr)
            End If
        End If
    End Sub

    'untuk error handling
    Private Function validateForm() As Boolean
        Dim result As Boolean = True
        If txtNamaLinen.Text.Trim = "" Then
            ErrorProvider.SetError(txtNamaLinen, "Nama Linen Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtNamaLinen, "")
        End If

        If Me.linen.jns_linen_id = Nothing Then
            Try
                linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
                If linenSvr.isExistLinen(New Linen With {.jns_linen_kode = txtKodeLinen.Text, .jns_linen_nama = txtNamaLinen.Text}) Then
                    ErrorProvider.SetError(txtNamaLinen, "Kode dan atau Nama Linen sudah ada")
                    result = False
                End If
                InProcFactory.CloseChannel(linenSvr)
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
        Return result
    End Function

    Private Sub txtBeratLinen_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
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
