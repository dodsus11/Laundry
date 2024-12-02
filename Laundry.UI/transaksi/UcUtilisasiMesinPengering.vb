Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcUtilisasiMesinPengering

    'objek mesin
    Public utilmesinpengering As Util_Mesin_Pengering
    Public mesin As Mesin

    Private utilmesinpengeringSvr As IUtilmesinPengeringService
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


    Private Sub UcUtilisasiMesinPengering_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtpMulai.MaxDate = Now.AddYears(+10)
        dtpSelesai.MaxDate = Now.AddYears(+10)
        If utilmesinpengering.utilisasi_mesin_pengering_id <> Nothing Then                      'untuk edit
            'Dim brt As String = Replace(utilmesinpengering.berat_linen_str, ".", ",")
            LabelID.Text = utilmesinpengering.utilisasi_mesin_pengering_id
            txtMesin.Tag = utilmesinpengering.id_mesin
            txtMesin.Text = utilmesinpengering.nama_mesin
            lblMesin.Tag = utilmesinpengering.maxload_mesin
            'txtBeratLinen.Text = brt
            txtBeratLinen.Text = utilmesinpengering.berat_linen_str
            dtpMulai.Text = utilmesinpengering.mulai.ToString
            dtpSelesai.Text = utilmesinpengering.selesai.ToString
            txtSuhu.Text = utilmesinpengering.suhu
            txtOperator.Tag = utilmesinpengering.operator_mesin
            txtOperator.Text = utilmesinpengering.operator_mesin_nama
            SaveEditTemp.btnSaveAndNew.Visible = False
            txtMesin.Enabled = False
            txtOperator.Enabled = False
            Me.SaveEditTemp.setTitle("Edit Utilisasi Mesin Pengering")
        Else
            '    txtMesin.Enabled = False                      'untuk new
            '    txtPembersih.Enabled = False
            '    txtOperator.Enabled = False
            Me.SaveEditTemp.setTitle("Add New Utilisasi Mesin Pengering")
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
        frmLookUp.dt = Me.mesinSvr.getMesinByJenis(New Mesin With {.jenis_mesin = "3"})

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMesin.Text = frmLookUp.returnRow("nama_mesin").ToString
            txtMesin.Tag = frmLookUp.returnRow("id_mesin")
            lblMesin.Tag = frmLookUp.returnRow("maxload_mesin")
        End If

        InProcFactory.CloseChannel(Me.mesinSvr)
    End Sub

    'lookup pegawai
    Private Sub btnOperator_Click(sender As System.Object, e As System.EventArgs) Handles btnOperator.Click
        Me.utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"id_pegawai", "ID Pegawai", 70},
                              {"nama_pegawai", "Nama", 100},
                              {"nip_pegawai", "Nip", 200},
                              {"bagian", "Bagian", 200},
                              {"status_pegawai", "Status", 100}}

        frmLookUp.keyField = "id_pegawai"
        frmLookUp.fields = {"nama_pegawai", "nip_pegawai", "bagian", "status_pegawai"}

        frmLookUp.dt = Me.utilmesinpengeringSvr.lookupPegawai()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOperator.Text = frmLookUp.returnRow("nama_pegawai").ToString
            txtOperator.Tag = frmLookUp.returnRow("id_pegawai").ToString
        End If

        InProcFactory.CloseChannel(Me.utilmesinpengeringSvr)
    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            
            If utilmesinpengering.utilisasi_mesin_pengering_id = Nothing Then
                If MsgBox("Anda akan menyimpan data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
                        utilmesinpengeringSvr.insertUtilMesinPengering(New Util_Mesin_Pengering With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                                                      .nama_mesin = txtMesin.Tag,
                                                                                                      .berat_linen = txtBeratLinen.Text,
                                                                                                      .mulai = dtpMulai.Value.TimeOfDay,
                                                                                                      .selesai = dtpSelesai.Value.TimeOfDay,
                                                                                                      .suhu = txtSuhu.Text,
                                                                                                      .operator_mesin = txtOperator.Tag,
                                                                                                      .operator_mesin_nama = txtOperator.Text})

                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")

                        Dim uc As New ModUtilisasiMesinPengeringNew
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinpengeringSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
                        utilmesinpengeringSvr.updateUtilMesinPengering(New Util_Mesin_Pengering With {.utilisasi_mesin_pengering_id = LabelID.Text,
                                                                                                      .tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                                                      .nama_mesin = txtMesin.Tag,
                                                                                                      .berat_linen = txtBeratLinen.Text,
                                                                                                      .mulai = dtpMulai.Value.TimeOfDay,
                                                                                                      .selesai = dtpSelesai.Value.TimeOfDay,
                                                                                                      .suhu = txtSuhu.Text,
                                                                                                      .operator_mesin = txtOperator.Tag,
                                                                                                      .operator_mesin_nama = txtOperator.Text})

                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil diubah")

                        Dim uc As New ModUtilisasiMesinPengeringNew
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinpengeringSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModUtilisasiMesinPengeringNew
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
        txtSuhu.Text = ""
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
                    utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
                    utilmesinpengeringSvr.insertUtilMesinPengering(New Util_Mesin_Pengering With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"), .nama_mesin = txtMesin.Tag, .berat_linen = txtBeratLinen.Text,
                                                                          .mulai = jammulai, .selesai = jamselesai, .suhu = txtSuhu.Text, .operator_mesin = txtOperator.Tag,
                                                                          .operator_mesin_nama = txtOperator.Text})

                    MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")
                    Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(utilmesinpengeringSvr)
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
        ElseIf CDec(txtBeratLinen.Text) > CDec(lblMesin.Tag) Then
            ErrorProvider.SetError(Label9, "Berat linen melampaui maxload mesin")
            result = False
        ElseIf txtOperator.Text.Trim = "" Then
            ErrorProvider.SetError(btnOperator, "Operator Mesin Kosong")
            result = False
        ElseIf txtSuhu.Text.Trim = "" Then
            ErrorProvider.SetError(txtSuhu, "Suhu Masih Kosong")
            result = False
        Else
            ErrorProvider.SetError(btnMesin, "")
        End If

        If Me.utilmesinpengering.utilisasi_mesin_pengering_id = Nothing Then
            Try
                utilmesinpengeringSvr = InProcFactory.CreateChannel(Of UtilmesinPengeringService, IUtilmesinPengeringService)()
                If utilmesinpengeringSvr.isExistUtilmesinPengering(New Util_Mesin_Pengering With {.nama_mesin = txtMesin.Tag, .mulai = dtpMulai.Value.TimeOfDay, .tanggal = Today}) Then
                    ErrorProvider.SetError(dtpMulai, "Mesin masih digunakan")
                    result = False
                End If
                InProcFactory.CloseChannel(utilmesinpengeringSvr)
            Catch ex As Exception
                Return ex.Message
            End Try
        End If
        Return result
    End Function

    Private Sub txtBeratLinen_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBeratLinen.KeyPress
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

    Private Sub txtSuhu_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSuhu.KeyPress
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
End Class
