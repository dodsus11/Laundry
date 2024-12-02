Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcInsertMesin

    'objek mesin
    Public mesin As Mesin

    Private mesinSvr As IMesinService

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click
    End Sub


    Private Sub UcInsertMesin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If mesin.id_mesin <> Nothing Then                      'untuk edit
            txtId.Text = mesin.id_mesin
            txtKd.Text = mesin.kode_mesin
            txtNamaMesin.Text = mesin.nama_mesin
            If mesin.jenis_mesin = "Mesin Setrika" Then
                txtKapasitasMesin.Enabled = False
                txtKapasitasMesin.Text = ""
            Else
                txtKapasitasMesin.Enabled = True
                txtKapasitasMesin.Text = mesin.kapasitas_mesin
            End If
            txtLoad.Text = mesin.maxload_mesin
            ComboBox_jns_mesin.Text = mesin.jenis_mesin
            ComboBox_status_mesin.Text = mesin.flag_mesin
            SaveEditTemp.btnSaveAndNew.Visible = False
            'txtKd.Enabled = False
            Me.SaveEditTemp.setTitle("Edit Mesin")
        Else
            'txtKd.Enabled = False                              'untuk new
            Me.SaveEditTemp.setTitle("Insert Mesin")
        End If

    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            Dim jenismesin As Integer
            Dim statusmesin As Integer
            If ComboBox_jns_mesin.Text = "Mesin Cuci" Then
                jenismesin = 1
            ElseIf ComboBox_jns_mesin.Text = "Mesin Peras" Then
                jenismesin = 2
            ElseIf ComboBox_jns_mesin.Text = "Mesin Pengering" Then
                jenismesin = 3
            ElseIf ComboBox_jns_mesin.Text = "Mesin Setrika" Then
                jenismesin = 4
            End If
            If ComboBox_status_mesin.Text = "Aktif" Then
                statusmesin = 1
            ElseIf ComboBox_status_mesin.Text = "Rusak" Then
                statusmesin = 2
            Else
                statusmesin = 3
            End If
            If mesin.id_mesin = Nothing Then
                If MsgBox("Anda akan menyimpan data " & txtNamaMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()
                        Dim kpsmesin As Integer
                        If txtKapasitasMesin.Text = "" Then
                            kpsmesin = 0
                        Else
                            kpsmesin = txtKapasitasMesin.Text
                        End If
                        mesinSvr.insertMesin(New Mesin With {.kode_mesin = txtKd.Text, .nama_mesin = txtNamaMesin.Text, .kapasitas_mesin = kpsmesin, .maxload_mesin = txtLoad.Text, .jenis_mesin = jenismesin, .flag_mesin = statusmesin})

                        MsgBox("Data mesin " & txtNamaMesin.Text & " telah berhasil disimpan")

                        Dim uc As New ModMasterMesin
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(mesinSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data " & txtNamaMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()
                        Dim kpsmesin As Integer
                        If txtKapasitasMesin.Text = "" Then
                            kpsmesin = 0
                        Else
                            kpsmesin = txtKapasitasMesin.Text
                        End If
                        mesinSvr.updateMesin(New Mesin With {.id_mesin = txtId.Text, .kode_mesin = txtKd.Text, .nama_mesin = txtNamaMesin.Text, .kapasitas_mesin = kpsmesin, .maxload_mesin = txtLoad.Text, .jenis_mesin = jenismesin, .flag_mesin = statusmesin})

                        MsgBox("Data mesin " & txtNamaMesin.Text & " telah berhasil diubah")

                        Dim uc As New ModMasterMesin
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(mesinSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModMasterMesin
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        txtKd.Text = ""
        txtNamaMesin.Text = ""
        txtKapasitasMesin.Text = ""
        txtLoad.Text = ""
        ComboBox_jns_mesin.Text = ""
        ComboBox_status_mesin.Text = ""
        ErrorProvider.Clear()
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            Dim jenismesin As Integer
            Dim statusmesin As Integer
            If ComboBox_jns_mesin.Text = "Mesin Cuci" Then
                jenismesin = 1
            ElseIf ComboBox_jns_mesin.Text = "Mesin Peras" Then
                jenismesin = 2
            ElseIf ComboBox_jns_mesin.Text = "Mesin Pengering" Then
                jenismesin = 3
            Else
                jenismesin = 4
            End If
            If ComboBox_status_mesin.Text = "Aktif" Then
                statusmesin = 1
            ElseIf ComboBox_status_mesin.Text = "Rusak" Then
                statusmesin = 2
            Else
                statusmesin = 3
            End If
            If MsgBox("Anda akan menyimpan data " & txtNamaMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()
                    Dim kpsmesin As Integer
                    If txtKapasitasMesin.Text = "" Then
                        kpsmesin = 0
                    Else
                        kpsmesin = txtKapasitasMesin.Text
                    End If
                    mesinSvr.insertMesin(New Mesin With {.kode_mesin = txtKd.Text, .nama_mesin = txtNamaMesin.Text, .kapasitas_mesin = kpsmesin, .maxload_mesin = txtLoad.Text, .jenis_mesin = jenismesin, .flag_mesin = statusmesin})

                    MsgBox("Data mesin " & txtNamaMesin.Text & " telah berhasil disimpan")
                    txtKd.Text = ""
                    txtNamaMesin.Text = ""
                    txtKapasitasMesin.Text = ""
                    txtLoad.Text = ""
                    ComboBox_jns_mesin.Text = ""
                    ComboBox_status_mesin.Text = ""
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(mesinSvr)
            End If
        End If
    End Sub

    'untuk error handling
    Private Function validateForm() As Boolean
        Dim result As Boolean = True
        If txtNamaMesin.Text.Trim = "" Then
            ErrorProvider.SetError(txtNamaMesin, "Nama Mesin Kosong")
            result = False
        Else
            ErrorProvider.SetError(txtNamaMesin, "")
        End If

        If Me.mesin.id_mesin = Nothing Then
            Try
                mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()
                If mesinSvr.isExistMesin(New Mesin With {.nama_mesin = txtNamaMesin.Text}) Then
                    ErrorProvider.SetError(txtNamaMesin, "Nama Mesin sudah ada")
                    result = False
                End If
                InProcFactory.CloseChannel(mesinSvr)
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
        Return result
    End Function

    Private Sub ComboBox_jns_mesin_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles ComboBox_jns_mesin.SelectedValueChanged
        If ComboBox_jns_mesin.Text = "Mesin Setrika" Then
            txtKapasitasMesin.Enabled = False
        Else
            txtKapasitasMesin.Enabled = True
        End If
    End Sub

    Private Sub txtKapasitasMesin_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ",") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub

    Private Sub txtLoad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ",") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub
End Class
