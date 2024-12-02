Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcUtilisasiMesinPeras

    'objek mesin
    Public utilmesinperas As Util_Mesin_Peras
    Public mesin As Mesin

    Private utilmesinperasSvr As IUtilmesinPerasService
    Private mesinSvr As IMesinService
    'Dim TambahPembersih As FormTambahPembersih

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click
    End Sub


    Private Sub UcUtilisasiMesinPeras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If utilmesinperas.utilisasi_mesin_peras_id <> Nothing Then                      'untuk edit
            LabelID.Text = utilmesinperas.utilisasi_mesin_peras_id
            txtMesin.Tag = utilmesinperas.id_mesin
            txtMesin.Text = utilmesinperas.nama_mesin
            txtBeratLinen.Text = utilmesinperas.berat_linen
            dtpMulai.Text = utilmesinperas.mulai.ToString
            dtpSelesai.Text = utilmesinperas.selesai.ToString
            RichTextKeterangan.Text = utilmesinperas.keterangan
            txtOperator.Tag = utilmesinperas.operator_mesin
            txtOperator.Text = utilmesinperas.operator_mesin_nama
            SaveEditTemp.btnSaveAndNew.Visible = False
            txtMesin.Enabled = False
            txtOperator.Enabled = False
            Me.SaveEditTemp.setTitle("Edit Utilisasi Mesin Pemeras")
        Else
            '    txtMesin.Enabled = False                      'untuk new
            '    txtPembersih.Enabled = False
            '    txtOperator.Enabled = False
            Me.SaveEditTemp.setTitle("Add New Utilisasi Mesin Pemeras")
        End If


    End Sub

    'lookup mesin
    Private Sub btnMesin_Click(sender As System.Object, e As System.EventArgs) Handles btnMesin.Click
        Me.mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 50},
                              {"id_mesin", "ID Mesin", 80},
                              {"nama_mesin", "Nama Mesin", 200},
                              {"kapasitas_mesin", "Kapasitas (Gram)", 200},
                              {"maxload_mesin", "Maks Load", 100},
                              {"jenis_mesin", "Jenis Mesin", 150}}

        frmLookUp.keyField = "id_mesin"
        frmLookUp.fields = {"nama_mesin", "kapasitas_mesin", "maxload_mesin", "jenis_mesin"}
        frmLookUp.dt = Me.mesinSvr.getMesinByJenis(New Mesin With {.jenis_mesin = "2"})

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMesin.Text = frmLookUp.returnRow("nama_mesin").ToString
            txtMesin.Tag = frmLookUp.returnRow("id_mesin")
            txtMesin.TabIndex = frmLookUp.returnRow("maxload_mesin")
        End If

        InProcFactory.CloseChannel(Me.mesinSvr)
    End Sub

    'lookup pembersih
    'Private Sub btnPembersih_Click(sender As System.Object, e As System.EventArgs)
    '    TambahPembersih = New FormTambahPembersih
    '    TambahPembersih.ShowDialog(Me)
    '    txtPembersih.Text = TambahPembersih.bahanpembersih
    'End Sub

    'lookup pegawai
    Private Sub btnOperator_Click(sender As System.Object, e As System.EventArgs) Handles btnOperator.Click
        Me.utilmesinperasSvr = InProcFactory.CreateChannel(Of UtilmesinPerasService, IUtilmesinPerasService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"pegawai_id", "ID Pegawai", 50},
                              {"nip", "NIP", 100},
                              {"pegawai_nama", "Nama", 200},
                              {"dept_name", "Ruang Bagian", 200},
                              {"jabatan_nama", "Jabatan", 100},
                              {"jns_pegawai_nama", "Jenis Pegawai", 100}}

        frmLookUp.keyField = "pegawai_id"
        frmLookUp.fields = {"nip", "pegawai_nama", "dept_name", "jabatan_nama", "jns_pegawai_nama"}

        frmLookUp.dt = Me.utilmesinperasSvr.lookupPegawai()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOperator.Text = frmLookUp.returnRow("pegawai_nama").ToString
            txtOperator.Tag = frmLookUp.returnRow("pegawai_id").ToString
        End If

        InProcFactory.CloseChannel(Me.utilmesinperasSvr)
    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            
            If utilmesinperas.utilisasi_mesin_peras_id = Nothing Then
                If MsgBox("Anda akan menyimpan data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinperasSvr = InProcFactory.CreateChannel(Of UtilmesinPerasService, IUtilmesinPerasService)()
                        utilmesinperasSvr.insertUtilMesinPeras(New Util_Mesin_Peras With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                                          .nama_mesin = txtMesin.Tag,
                                                                                          .berat_linen = txtBeratLinen.Text,
                                                                                          .mulai = dtpMulai.Value.TimeOfDay,
                                                                                          .selesai = dtpSelesai.Value.TimeOfDay,
                                                                                          .keterangan = RichTextKeterangan.Text,
                                                                                          .operator_mesin = txtOperator.Tag,
                                                                                          .operator_mesin_nama = txtOperator.Text})

                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")

                        Dim uc As New ModUtilisasiMesinPeras
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinperasSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinperasSvr = InProcFactory.CreateChannel(Of UtilmesinPerasService, IUtilmesinPerasService)()
                        utilmesinperasSvr.updateUtilMesinPeras(New Util_Mesin_Peras With {.utilisasi_mesin_peras_id = LabelID.Text,
                                                                                          .tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                                          .nama_mesin = txtMesin.Tag,
                                                                                          .berat_linen = txtBeratLinen.Text,
                                                                                          .mulai = dtpMulai.Value.TimeOfDay,
                                                                                          .selesai = dtpSelesai.Value.TimeOfDay,
                                                                                          .keterangan = RichTextKeterangan.Text,
                                                                                          .operator_mesin = txtOperator.Tag,
                                                                                          .operator_mesin_nama = txtOperator.Text})

                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil diubah")

                        Dim uc As New ModUtilisasiMesinPeras
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinperasSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModUtilisasiMesinPeras
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        Clear()
        ErrorProvider.Clear()
    End Sub

    Private Sub Clear()
        txtMesin.Text = ""
        txtBeratLinen.Text = ""
        dtpMulai.Text = Now
        dtpSelesai.Text = Now
        RichTextKeterangan.Text = ""
        txtOperator.Text = ""
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            Dim jammulai As TimeSpan
            Dim jamselesai As TimeSpan
            jammulai = dtpMulai.Value.TimeOfDay
            jamselesai = dtpSelesai.Value.TimeOfDay
            If MsgBox("Anda akan menyimpan data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    utilmesinperasSvr = InProcFactory.CreateChannel(Of UtilmesinPerasService, IUtilmesinPerasService)()
                    utilmesinperasSvr.insertUtilMesinPeras(New Util_Mesin_Peras With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"), .nama_mesin = txtMesin.Tag, .berat_linen = txtBeratLinen.Text,
                                                                          .mulai = jammulai, .selesai = jamselesai, .keterangan = RichTextKeterangan.Text, .operator_mesin = txtOperator.Tag,
                                                                          .operator_mesin_nama = txtOperator.Text})

                    MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")
                    Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(utilmesinperasSvr)
            End If
        End If
    End Sub

    'untuk error handling
    Private Function validateForm() As Boolean
        Dim result As Boolean = True
        If txtMesin.Text.Trim = "" Then
            ErrorProvider.SetError(btnMesin, "Nama Mesin Kosong")
            result = False
        ElseIf txtBeratLinen.Text.Trim = "" Then
            ErrorProvider.SetError(Label9, "Berat Linen Mesin Kosong")
            result = False
        ElseIf txtBeratLinen.Text > txtMesin.TabIndex Then
            ErrorProvider.SetError(Label9, "Berat linen melampaui maxload mesin")
            result = False
        ElseIf txtOperator.Text.Trim = "" Then
            ErrorProvider.SetError(btnOperator, "Operator Mesin Kosong")
            result = False
        Else
            ErrorProvider.SetError(btnMesin, "")
        End If

        If Me.utilmesinperas.utilisasi_mesin_peras_id = Nothing Then
            Try
                utilmesinperasSvr = InProcFactory.CreateChannel(Of UtilmesinPerasService, IUtilmesinPerasService)()
                If utilmesinperasSvr.isExistUtilmesinPeras(New Util_Mesin_Peras With {.nama_mesin = txtMesin.Tag, .mulai = dtpMulai.Value.TimeOfDay, .tanggal = Today}) Then
                    ErrorProvider.SetError(dtpMulai, "Mesin masih digunakan")
                    result = False
                End If
                InProcFactory.CloseChannel(utilmesinperasSvr)
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
        Return result
    End Function

End Class
