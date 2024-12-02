Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcInsertPegawai

    'objek pegawai
    Public pegawai As Pegawai

    Private pegawaiSvr As IPegawailaundryService

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click
    End Sub


    Private Sub UcInsertPegawai_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If pegawai.id_pegawai <> Nothing Then
            'untuk edit
            txtId.Text = pegawai.id_pegawai
            txtNamaPegawai.Text = pegawai.nama_pegawai
            txtNip.Text = pegawai.nip_pegawai
            txtBagian.Text = pegawai.bagian
            ComboBox_status_pegawai.Text = pegawai.status_pegawai
            SaveEditTemp.btnSaveAndNew.Visible = False
            Me.SaveEditTemp.setTitle("Edit Pegawai")
        Else
            'untuk new
            Me.SaveEditTemp.setTitle("Insert Pegawai")
        End If

    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then            
            Dim statuspegawai As Integer
            If ComboBox_status_pegawai.Text = "PNS" Then
                statuspegawai = 1
            ElseIf ComboBox_status_pegawai.Text = "BLU" Then
                statuspegawai = 2
            Else
                statuspegawai = 3
            End If
            
            If pegawai.id_pegawai = Nothing Then
                If MsgBox("Anda akan menyimpan data " & txtNamaPegawai.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        pegawaiSvr = InProcFactory.CreateChannel(Of PegawailaundryService, IPegawailaundryService)()
                        pegawaiSvr.insertPegawai(New Pegawai With {.nama_pegawai = txtNamaPegawai.Text, .nip_pegawai = txtNip.Text, .bagian = txtBagian.Text, .status_pegawai = statuspegawai})

                        MsgBox("Data " & txtNamaPegawai.Text & " telah berhasil disimpan")

                        Dim uc As New ModPegawaiLaundry
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(pegawaiSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        pegawaiSvr = InProcFactory.CreateChannel(Of PegawailaundryService, IPegawailaundryService)()
                        pegawaiSvr.updatePegawai(New Pegawai With {.id_pegawai = txtId.Text, .nama_pegawai = txtNamaPegawai.Text, .nip_pegawai = txtNip.Text, .bagian = txtBagian.Text, .status_pegawai = statuspegawai})

                        MsgBox("Data " & txtNamaPegawai.Text & " telah berhasil diubah")

                        Dim uc As New ModPegawaiLaundry
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(pegawaiSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModPegawaiLaundry
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)        
        txtNamaPegawai.Text = ""
        txtNip.Text = ""
        txtBagian.Text = ""
        ComboBox_status_pegawai.Text = ""        
        ErrorProvider.Clear()
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then            
            Dim statuspegawai As Integer
            If ComboBox_status_pegawai.Text = "PNS" Then
                statuspegawai = 1
            ElseIf ComboBox_status_pegawai.Text = "BLU" Then
                statuspegawai = 2
            Else
                statuspegawai = 3
            End If
            
            If MsgBox("Anda akan menyimpan data " & txtNamaPegawai.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    pegawaiSvr = InProcFactory.CreateChannel(Of PegawailaundryService, IPegawailaundryService)()
                    pegawaiSvr.insertPegawai(New Pegawai With {.nama_pegawai = txtNamaPegawai.Text, .nip_pegawai = txtNip.Text, .bagian = txtBagian.Text, .status_pegawai = statuspegawai})
                    
                    MsgBox("Data " & txtNamaPegawai.Text & " telah berhasil disimpan")                    
                    txtNamaPegawai.Text = ""
                    txtNip.Text = ""
                    txtBagian.Text = ""
                    ComboBox_status_pegawai.Text = ""

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(pegawaiSvr)
            End If
        End If
    End Sub

    'untuk error handling
    Private Function validateForm() As Boolean
        Dim result As Boolean = True
        If txtNamaPegawai.Text.Trim = "" Then
            ErrorProvider.SetError(txtNamaPegawai, "Nama Pegawai Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtNamaPegawai, "")
        End If

        If Me.pegawai.id_pegawai = Nothing Then
            Try
                pegawaiSvr = InProcFactory.CreateChannel(Of PegawailaundryService, IPegawailaundryService)()
                If pegawaiSvr.isExistPegawai(New Pegawai With {.nama_pegawai = txtNamaPegawai.Text}) Then
                    ErrorProvider.SetError(txtNamaPegawai, "Nama Pegawai sudah ada")
                    result = False
                End If
                InProcFactory.CloseChannel(pegawaiSvr)
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
        Return result
    End Function

End Class
