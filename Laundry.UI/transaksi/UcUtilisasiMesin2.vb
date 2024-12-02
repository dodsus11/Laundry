Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcUtilisasiMesin2

    'objek mesin
    Public utilmesin As Util_Mesin
    Public mesin As Mesin

    Private utilmesinSvr As IUtilmesinService
    Private mesinSvr As IMesinService
    Private pegawaiSvr As IPegawailaundryService
    Private pembersihSvr As IPembersihService
    Dim TambahPembersih As FormTambahPembersih
    Dim dv As New DataView
    Dim dt As New DataTable
    Dim identLinen As String

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
        dtpMulai.MaxDate = Now.AddYears(+10)
        dtpSelesai.MaxDate = Now.AddYears(+10)
        If utilmesin.utilisasi_mesin_cuci_id <> Nothing Then                      'untuk edit
            'Dim brt As String = Replace(utilmesin.berat_linen_str, ".", ",")
            LabelID.Text = utilmesin.utilisasi_mesin_cuci_id
            txtMesin.Tag = utilmesin.id_mesin
            txtMesin.Text = utilmesin.nama_mesin
            lblMesin.Tag = utilmesin.kapasitas_mesin
            txtPembersih1.Text = utilmesin.pembersih1
            txtPembersih2.Text = utilmesin.pembersih2
            txtPembersih3.Text = utilmesin.pembersih3
            txtPembersih5.Text = utilmesin.pembersih5
            txtPembersih7.Text = utilmesin.pembersih7
            'txtBeratLinen.Text = brt
            txtBeratLinen.Text = utilmesin.berat_linen_str
            dtpMulai.Text = utilmesin.mulai.ToString
            dtpSelesai.Text = utilmesin.selesai.ToString
            'txtTemp.Text = utilmesin.temp
            If utilmesin.jenis_linen = "Non Infeksius" Then
                rbNonInfeksius.Checked = True
            ElseIf utilmesin.jenis_linen = "Infeksius" Then
                rbInfeksius.Checked = True
            ElseIf utilmesin.jenis_linen = "Reject" Then
                rbReject.Checked = True
            End If
            txtOperator.Tag = utilmesin.operator_mesin
            txtOperator.Text = utilmesin.operator_mesin_nama
            txtKet.Text = utilmesin.keterangan
            SaveEditTemp.btnSaveAndNew.Visible = False

            Me.SaveEditTemp.setTitle("Edit Utilisasi Mesin Cuci")
        Else
            '    txtMesin.Enabled = False                      'untuk new
            '    txtPembersih.Enabled = False
            '    txtOperator.Enabled = False
            Me.SaveEditTemp.setTitle("Add New Utilisasi Mesin Cuci")
        End If


    End Sub

    'lookup mesin
    Private Sub btnMesin_Click(sender As System.Object, e As System.EventArgs) Handles btnMesin.Click
        Me.mesinSvr = InProcFactory.CreateChannel(Of MesinService, IMesinService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 50},
                              {"id_mesin", "ID Mesin", 80},
                              {"nama_mesin", "Nama Mesin", 200},
                              {"kapasitas_mesin", "Kapasitas (Kg)", 200},
                              {"maxload_mesin", "Maks Load/hari", 100},
                              {"jenis_mesin", "Jenis Mesin", 150}}

        frmLookUp.keyField = "id_mesin"
        frmLookUp.fields = {"nama_mesin", "kapasitas_mesin", "maxload_mesin", "jenis_mesin"}
        frmLookUp.dt = Me.mesinSvr.getMesinByJenis(New Mesin With {.jenis_mesin = "1"})

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMesin.Text = frmLookUp.returnRow("nama_mesin").ToString
            txtMesin.Tag = frmLookUp.returnRow("id_mesin")
            lblMesin.Tag = frmLookUp.returnRow("kapasitas_mesin")
        End If

        InProcFactory.CloseChannel(Me.mesinSvr)
    End Sub

    ''lookup pembersih1
    'Private Sub btnPembersih_Click(sender As System.Object, e As System.EventArgs) Handles btnPembersih1.Click

    '    If txtBeratLinen.Text.Trim = "" Or (rbNonInfeksius.Checked = False And rbInfeksius.Checked = False) Then
    '        MsgBox("Isilah terlebih dahulu berat linen dan jenis linen")
    '    Else
    '        Dim identLinen As Integer
    '        If rbNonInfeksius.Checked = True Then
    '            identLinen = 1
    '        ElseIf rbInfeksius.Checked = True Then
    '            identLinen = 0
    '        End If
    '        Dim frmtmbhpembersih As New FormTambahPembersih(txtBeratLinen.Text, identLinen)
    '        frmtmbhpembersih.ShowDialog()
    '        txtPembersih1.Text = frmtmbhpembersih.bahanpembersih
    '    End If

    'End Sub

    ''lookup pembersih2
    'Private Sub btnPembersih2_Click(sender As System.Object, e As System.EventArgs) Handles btnPembersih2.Click        
    '    If txtPembersih1.Text.Trim = "" Then
    '        MsgBox("Pembersih 1 harus diisi dahulu sebelum pembersih 2")            
    '    Else
    '        Dim identLinen As Integer
    '        If rbNonInfeksius.Checked = True Then
    '            identLinen = 1
    '        ElseIf rbInfeksius.Checked = True Then
    '            identLinen = 0
    '        End If
    '        Dim frmtmbhpembersih As New FormTambahPembersih(txtBeratLinen.Text, identLinen)
    '        frmtmbhpembersih.ShowDialog()
    '        txtPembersih2.Text = frmtmbhpembersih.bahanpembersih
    '    End If
    'End Sub

    ''lookup pembersih3
    'Private Sub btnPembersih3_Click(sender As System.Object, e As System.EventArgs) Handles btnPembersih3.Click
    '    If txtPembersih2.Text.Trim = "" Then
    '        MsgBox("Pembersih 2 harus diisi dahulu sebelum pembersih 3")
    '    Else
    '        Dim identLinen As Integer
    '        If rbNonInfeksius.Checked = True Then
    '            identLinen = 1
    '        ElseIf rbInfeksius.Checked = True Then
    '            identLinen = 0
    '        End If
    '        Dim frmtmbhpembersih As New FormTambahPembersih(txtBeratLinen.Text, identLinen)
    '        frmtmbhpembersih.ShowDialog()
    '        txtPembersih3.Text = frmtmbhpembersih.bahanpembersih
    '    End If
    'End Sub

    ''lookup pembersih4
    'Private Sub btnPembersih4_Click(sender As System.Object, e As System.EventArgs) Handles btnPembersih4.Click
    '    If txtPembersih3.Text.Trim = "" Then
    '        MsgBox("Pembersih 3 harus diisi dahulu sebelum pembersih 4")
    '    Else
    '        Dim identLinen As Integer
    '        If rbNonInfeksius.Checked = True Then
    '            identLinen = 1
    '        ElseIf rbInfeksius.Checked = True Then
    '            identLinen = 0
    '        End If
    '        Dim frmtmbhpembersih As New FormTambahPembersih(txtBeratLinen.Text, identLinen)
    '        frmtmbhpembersih.ShowDialog()
    '        txtPembersih4.Text = frmtmbhpembersih.bahanpembersih
    '    End If
    'End Sub

    ''lookup pembersih5
    'Private Sub btnPembersih5_Click(sender As System.Object, e As System.EventArgs) Handles btnPembersih5.Click
    '    If txtPembersih4.Text.Trim = "" Then
    '        MsgBox("Pembersih 4 harus diisi dahulu sebelum pembersih 5")
    '    Else
    '        Dim identLinen As Integer
    '        If rbNonInfeksius.Checked = True Then
    '            identLinen = 1
    '        ElseIf rbInfeksius.Checked = True Then
    '            identLinen = 0
    '        End If
    '        Dim frmtmbhpembersih As New FormTambahPembersih(txtBeratLinen.Text, identLinen)
    '        frmtmbhpembersih.ShowDialog()
    '        txtPembersih5.Text = frmtmbhpembersih.bahanpembersih
    '    End If
    'End Sub

    ''lookup pembersih6
    'Private Sub btnPembersih6_Click(sender As System.Object, e As System.EventArgs) Handles btnPembersih6.Click
    '    If txtPembersih5.Text.Trim = "" Then
    '        MsgBox("Pembersih 5 harus diisi dahulu sebelum pembersih 6")
    '    Else
    '        Dim identLinen As Integer
    '        If rbNonInfeksius.Checked = True Then
    '            identLinen = 1
    '        ElseIf rbInfeksius.Checked = True Then
    '            identLinen = 0
    '        End If
    '        Dim frmtmbhpembersih As New FormTambahPembersih(txtBeratLinen.Text, identLinen)
    '        frmtmbhpembersih.ShowDialog()
    '        txtPembersih6.Text = frmtmbhpembersih.bahanpembersih
    '    End If
    'End Sub

    'lookup pegawai
    Private Sub btnOperator_Click(sender As System.Object, e As System.EventArgs) Handles btnOperator.Click
        Me.utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
        Dim frmLookUpOp As New UILibs.DlgLookUp()
        frmLookUpOp.fidArray = {{"id_pegawai", "ID Pegawai", 70},
                              {"nama_pegawai", "Nama", 100},
                              {"nip_pegawai", "Nip", 200},
                              {"bagian", "Bagian", 200},
                              {"status_pegawai", "Status", 100}}

        frmLookUpOp.keyField = "id_pegawai"
        frmLookUpOp.fields = {"nama_pegawai", "nip_pegawai", "bagian", "status_pegawai"}

        frmLookUpOp.dt = Me.utilmesinSvr.lookupPegawai()

        If frmLookUpOp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOperator.Text = frmLookUpOp.returnRow("nama_pegawai").ToString
            txtOperator.Tag = frmLookUpOp.returnRow("id_pegawai").ToString
        End If

        InProcFactory.CloseChannel(Me.utilmesinSvr)
    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            Dim identLinen As Integer
            If rbInfeksius.Checked = True Then
                identLinen = 0
            ElseIf rbNonInfeksius.Checked = True Then
                identLinen = 1
            ElseIf rbReject.Checked = True Then
                identLinen = 2
            End If
            If utilmesin.utilisasi_mesin_cuci_id = Nothing Then
                If MsgBox("Anda akan menyimpan data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
                        utilmesinSvr.insertUtilMesin(New Util_Mesin With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                          .nama_mesin = txtMesin.Tag,
                                                                          .berat_linen = txtBeratLinen.Text,
                                                                          .pembersih1 = txtPembersih1.Text,
                                                                          .pembersih2 = txtPembersih2.Text,
                                                                          .pembersih3 = txtPembersih3.Text,
                                                                          .pembersih5 = txtPembersih5.Text,
                                                                          .pembersih7 = txtPembersih7.Text,
                                                                          .mulai = dtpMulai.Value.TimeOfDay,
                                                                          .selesai = dtpSelesai.Value.TimeOfDay,
                                                                          .jenis_linen = identLinen,
                                                                          .operator_mesin = txtOperator.Tag,
                                                                          .operator_mesin_nama = txtOperator.Text,
                                                                          .keterangan = txtKet.Text})


                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")

                        Dim uc As New ModUtilisasiMesinCuciNew
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinSvr)
                End If
            Else
                If MsgBox("Anda akan mengubah data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
                        utilmesinSvr.updateUtilMesin(New Util_Mesin With {.utilisasi_mesin_cuci_id = LabelID.Text,
                                                                          .tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                          .nama_mesin = txtMesin.Tag,
                                                                          .berat_linen = txtBeratLinen.Text,
                                                                          .pembersih1 = txtPembersih1.Text,
                                                                          .pembersih2 = txtPembersih2.Text,
                                                                          .pembersih3 = txtPembersih3.Text,
                                                                          .pembersih5 = txtPembersih5.Text,
                                                                          .pembersih7 = txtPembersih7.Text,
                                                                          .mulai = dtpMulai.Value.TimeOfDay,
                                                                          .selesai = dtpSelesai.Value.TimeOfDay,
                                                                          .jenis_linen = identLinen,
                                                                          .operator_mesin = txtOperator.Tag,
                                                                          .operator_mesin_nama = txtOperator.Text,
                                                                         .keterangan = txtKet.Text})

                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil diubah")

                        Dim uc As New ModUtilisasiMesinCuciNew
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModUtilisasiMesinCuciNew 
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        Clear()
        ErrorProvider.Clear()
    End Sub

    Private Sub Clear()
        txtMesin.Text = ""
        txtPembersih1.Text = ""
        txtPembersih2.Text = ""
        txtPembersih3.Text = ""
        txtPembersih4.Text = ""
        txtPembersih5.Text = ""
        txtPembersih6.Text = ""
        txtPembersih7.Text = ""
        txtBeratLinen.Text = ""
        dtpMulai.Text = Now
        dtpSelesai.Text = Now
        rbNonInfeksius.Checked = False
        rbInfeksius.Checked = False
        rbReject.Checked = False
        txtOperator.Text = ""
        txtKet.Text = ""
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then
            Dim identLinen As Integer
            Dim jammulai As TimeSpan
            Dim jamselesai As TimeSpan
            If rbInfeksius.Checked = True Then
                identLinen = 0
            ElseIf rbNonInfeksius.Checked = True Then
                identLinen = 1
            ElseIf rbReject.Checked = True Then
                identLinen = 2
            End If
            jammulai = dtpMulai.Value.TimeOfDay
            jamselesai = dtpSelesai.Value.TimeOfDay
            If MsgBox("Anda akan menyimpan data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                Try
                    utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
                    utilmesinSvr.insertUtilMesin(New Util_Mesin With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                      .nama_mesin = txtMesin.Tag,
                                                                      .berat_linen = txtBeratLinen.Text,
                                                                      .pembersih1 = txtPembersih1.Text,
                                                                      .pembersih2 = txtPembersih2.Text,
                                                                      .pembersih3 = txtPembersih3.Text,
                                                                      .pembersih5 = txtPembersih5.Text,
                                                                      .pembersih7 = txtPembersih7.Text,
                                                                      .mulai = jammulai,
                                                                      .selesai = jamselesai,
                                                                      .jenis_linen = identLinen,
                                                                      .operator_mesin = txtOperator.Tag,
                                                                      .operator_mesin_nama = txtOperator.Text,
                                                                      .keterangan = txtKet.Text})

                    MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")
                    Clear()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                InProcFactory.CloseChannel(utilmesinSvr)
            End If
        End If
    End Sub

    'untuk error handling
    Private Function validateForm() As Boolean
        Dim result As Boolean = True
        If txtMesin.Text.Trim = "" Then
            ErrorProvider.SetError(btnMesin, "Nama Mesin Kosong")
            result = False
        ElseIf txtPembersih1.Text.Trim = "" Then
            ErrorProvider.SetError(btnPembersih1, "Bahan Pembersih Minimal diisi satu pembersih")
            result = False
        ElseIf txtBeratLinen.Text.Trim = "" Then
            ErrorProvider.SetError(Label9, "Berat Linen Mesin Kosong")
            result = False
        ElseIf CDec(txtBeratLinen.Text) > CDec(lblMesin.Tag) Then
            ErrorProvider.SetError(Label9, "Berat linen melampaui kapasitas mesin")
            result = False
            'ElseIf txtTemp.Text.Trim = "" Then
            '    ErrorProvider.SetError(txtTemp, "Temp Mesin Kosong")
            '    result = False
        ElseIf rbNonInfeksius.Checked = False And rbInfeksius.Checked = False And rbReject.Checked = False Then
            ErrorProvider.SetError(GroupBox1, "Jenis Linen Belum Dipilih")
            result = False
        ElseIf txtOperator.Text.Trim = "" Then
            ErrorProvider.SetError(btnOperator, "Operator Mesin Kosong")
            result = False
        Else
            ErrorProvider.SetError(btnMesin, "")
        End If

        If Me.utilmesin.utilisasi_mesin_cuci_id = Nothing Then
            Try

                utilmesinSvr = InProcFactory.CreateChannel(Of UtilmesinService, IUtilmesinService)()
                If utilmesinSvr.isExistUtilmesin(New Util_Mesin With {.nama_mesin = txtMesin.Tag, .mulai = dtpMulai.Value.TimeOfDay, .tanggal = Today}) Then
                    ErrorProvider.SetError(dtpMulai, "Mesin masih digunakan")
                    result = False
                End If
                InProcFactory.CloseChannel(utilmesinSvr)
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
        txtPembersih1.Text = ""
        txtPembersih2.Text = ""
        txtPembersih3.Text = ""
        txtPembersih4.Text = ""
        txtPembersih5.Text = ""
        txtPembersih6.Text = ""
        txtPembersih7.Text = ""
    End Sub

    Private Sub txtBeratLinen_Leave(sender As Object, e As System.EventArgs) Handles txtBeratLinen.Leave
        If txtBeratLinen.Text.Trim = "" Then
            MsgBox("Berat linen harus diisi")
        ElseIf txtMesin.Text = "" Then
            MsgBox("Mesin belum diisi")
            txtBeratLinen.Text = ""
            Exit Sub
        ElseIf rbInfeksius.Checked = False And rbNonInfeksius.Checked = False And rbReject.Checked = False Then
            MsgBox("Jenis identifikasi linen belum dipilih")
            txtBeratLinen.Text = ""
        Else
            pembersihSvr = InProcFactory.CreateChannel(Of PembersihService, IPembersihService)()
            If rbInfeksius.Checked = True Then
                identLinen = "Infeksius"
            ElseIf rbNonInfeksius.Checked = True Then
                identLinen = "Non Infeksius"
            ElseIf rbReject.Checked = True Then
                identLinen = "Reject"
            End If

            dt = pembersihSvr.getDosisPembersih(New DosisPembersih With {.jenis_ident_kotoran = identLinen, .berat_linen = txtBeratLinen.Text})
            If dt.Rows.Count = 0 Then
                MsgBox("Data pembersih untuk jenis linen " & identLinen & " dengan berat linen " & txtBeratLinen.Text & " belum ada.")
                txtBeratLinen.Text = ""
            Else
                txtPembersih1.Text = dt.Rows(0).Item(3).ToString
                txtPembersih2.Text = dt.Rows(0).Item(4).ToString
                txtPembersih3.Text = dt.Rows(0).Item(5).ToString
                txtPembersih5.Text = dt.Rows(0).Item(6).ToString
                txtPembersih7.Text = dt.Rows(0).Item(7).ToString
            End If
            InProcFactory.CloseChannel(pembersihSvr)
            'If rbNonInfeksius.Checked = True Then
            '    If CDbl(txtBeratLinen.Text) <= 1 Then
            '        txtPembersih1.Text = 4                   'Alkaline
            '        txtPembersih2.Text = 4                   'Detergent
            '        txtPembersih3.Text = 4                   'Oxybleach
            '        txtPembersih5.Text = 10                  'Softener
            '        txtPembersih7.Text = 4                   'Penetral
            '    ElseIf CDbl(txtBeratLinen.Text) <= 90 Then
            '        txtPembersih1.Text = 360
            '        txtPembersih2.Text = 360
            '        txtPembersih3.Text = 360
            '        txtPembersih5.Text = 900
            '        txtPembersih7.Text = 360
            '    ElseIf CDbl(txtBeratLinen.Text) <= 105 Then
            '        txtPembersih1.Text = 420
            '        txtPembersih2.Text = 420
            '        txtPembersih3.Text = 420
            '        txtPembersih5.Text = 1050
            '        txtPembersih7.Text = 420
            '    End If

            'ElseIf rbInfeksius.Checked = True Then
            '    If CDbl(txtBeratLinen.Text) <= 1 Then
            '        txtPembersih1.Text = 6                   'Alkaline
            '        txtPembersih2.Text = 6                   'Detergent
            '        txtPembersih3.Text = 10                   'Oxybleach
            '        txtPembersih5.Text = 10                  'Softener
            '        txtPembersih7.Text = 4                   'Penetral
            '    ElseIf CDbl(txtBeratLinen.Text) <= 90 Then
            '        txtPembersih1.Text = 540
            '        txtPembersih2.Text = 540
            '        txtPembersih3.Text = 900
            '        txtPembersih5.Text = 900
            '        txtPembersih7.Text = 360
            '    ElseIf CDbl(txtBeratLinen.Text) <= 105 Then
            '        txtPembersih1.Text = 630
            '        txtPembersih2.Text = 630
            '        txtPembersih3.Text = 1050
            '        txtPembersih5.Text = 1050
            '        txtPembersih7.Text = 420
            '    End If

            'ElseIf rbReject.Checked = True Then
            '    If CDbl(txtBeratLinen.Text) <= 1 Then
            '        txtPembersih1.Text = 12
            '        txtPembersih2.Text = 12
            '        txtPembersih3.Text = 20
            '        txtPembersih5.Text = 10
            '        txtPembersih7.Text = 4
            '    ElseIf CDbl(txtBeratLinen.Text) <= 90 Then
            '        txtPembersih1.Text = 1080
            '        txtPembersih2.Text = 1080
            '        txtPembersih3.Text = 1800
            '        txtPembersih5.Text = 900
            '        txtPembersih7.Text = 360
            '    ElseIf CDbl(txtBeratLinen.Text) <= 105 Then
            '        txtPembersih1.Text = 1260
            '        txtPembersih2.Text = 1260
            '        txtPembersih3.Text = 2100
            '        txtPembersih5.Text = 1050
            '        txtPembersih7.Text = 420
            '    End If
            'End If
        End If
    End Sub

    Private Sub rbNonInfeksius_Click(sender As Object, e As System.EventArgs) Handles rbNonInfeksius.Click
        txtBeratLinen.Text = ""
        txtPembersih1.Text = ""
        txtPembersih2.Text = ""
        txtPembersih3.Text = ""
        txtPembersih5.Text = ""
        txtPembersih7.Text = ""
    End Sub

    Private Sub rbInfeksius_Click(sender As Object, e As System.EventArgs) Handles rbInfeksius.Click
        txtBeratLinen.Text = ""
        txtPembersih1.Text = ""
        txtPembersih2.Text = ""
        txtPembersih3.Text = ""
        txtPembersih5.Text = ""
        txtPembersih7.Text = ""
    End Sub

    Private Sub rbReject_Click(sender As Object, e As System.EventArgs) Handles rbReject.Click
        txtBeratLinen.Text = ""
        txtPembersih1.Text = ""
        txtPembersih2.Text = ""
        txtPembersih3.Text = ""
        txtPembersih5.Text = ""
        txtPembersih7.Text = ""
    End Sub

    
End Class
