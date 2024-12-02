Imports ClientLibs
Imports Laundry.Service.service
Imports Laundry.Service.model

Public Class UcUtilisasiMesinSetrika

    'objek mesin
    Public utilmesinsetrika As Util_Mesin_Setrika
    Public mesin As Mesin

    Private utilmesinsetrikaSvr As IUtilmesinSetrikaService
    Private mesinSvr As IMesinService
    Private linenSvr As ILinenService
    'Dim TambahPembersih As FormTambahPembersih
    Public jmlbersih As Integer
    Public jmlrusak As Integer
    Public jmlreject As Integer
    Public jmltot As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddHandler SaveEditTemp.btnSaveAndClose.Click, AddressOf saveClose
        AddHandler SaveEditTemp.btnCancel.Click, AddressOf btnCancel_Click
        'AddHandler SaveEditTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        AddHandler SaveEditTemp.btnClear.Click, AddressOf btnClear_Click
    End Sub


    Private Sub UcUtilisasiMesinSetrika_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If utilmesinsetrika.utilisasi_mesin_setrika_id <> Nothing Then
            'untuk edit
            Me.utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
            LabelID.Text = utilmesinsetrika.utilisasi_mesin_setrika_id
            txtTgl.Text = utilmesinsetrika.tanggal
            txtLoad.Text = utilmesinsetrika.load_ke
            txtMesin.Tag = utilmesinsetrika.kode_mesin
            txtMesin.Text = utilmesinsetrika.nama_mesin
            txtLinen.Tag = utilmesinsetrika.kodelinen
            txtLinen.Text = utilmesinsetrika.linen
            txtJmlLinen.Text = utilmesinsetrika.jumlah_linen
            txtLinenBersih.Text = utilmesinsetrika.jumlah_linen_bersih
            txtLinenBersih.Tag = utilmesinsetrika.jumlah_linen_bersih
            txtLinenRusak.Text = utilmesinsetrika.jumlah_linen_rusak
            txtLinenRusak.Tag = utilmesinsetrika.jumlah_linen_rusak
            txtLinenReject.Text = utilmesinsetrika.jumlah_linen_reject
            txtLinenReject.Tag = utilmesinsetrika.jumlah_linen_reject
            txtOperator.Text = utilmesinsetrika.operator_mesin
            txtOperator.Tag = Me.utilmesinsetrikaSvr.ambilIdPegawai(txtOperator.Text)
            SaveEditTemp.btnSaveAndNew.Visible = False
            txtTgl.Enabled = False
            txtLoad.Enabled = False
            txtMesin.Enabled = False
            txtLinen.Enabled = False
            txtOperator.Enabled = False
            btnMesin.Enabled = False
            btnLinen.Enabled = False
            Me.SaveEditTemp.setTitle("Edit Utilisasi Mesin Setrika")
            InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
        Else
            'untuk new
            SaveEditTemp.btnSaveAndNew.Visible = False
            txtTgl.Enabled = False
            txtLoad.Enabled = False
            txtMesin.Enabled = False
            txtLinen.Enabled = False                        
            txtOperator.Enabled = False
            Dim load As Integer
            Dim tanggal As Date
            tanggal = Today
            txtTgl.Text = tanggal
            
            jmltot = 0
            txtJmlLinen.Text = jmltot
            utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
            ''untuk nilai load
            'If utilmesinsetrikaSvr.cariTglSekarang(tanggal) Then
            '    load = utilmesinsetrikaSvr.ambilLoad(tanggal) + 1
            '    txtLoad.Text = load
            'Else
            '    load = 1
            '    txtLoad.Text = load
            'End If
            InProcFactory.CloseChannel(utilmesinsetrikaSvr)
            Me.SaveEditTemp.setTitle("Add New Utilisasi Mesin Setrika")
        End If


    End Sub

    'lookup mesin
    Private Sub btnMesin_Click(sender As System.Object, e As System.EventArgs) Handles btnMesin.Click
        Me.utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 50},
                              {"kode_mesin", "Kode Mesin", 100},
                              {"nama_mesin", "Nama Mesin", 200},
                              {"kapasitas_mesin", "Kapasitas (lembar)", 150},
                              {"maxload_mesin", "Maks Load/hari", 150},
                              {"jenis_mesin", "Jenis Mesin", 150}}

        frmLookUp.keyField = "kode_mesin"
        frmLookUp.fields = {"nama_mesin", "kapasitas_mesin", "maxload_mesin", "jenis_mesin"}
        frmLookUp.dt = Me.utilmesinsetrikaSvr.getMesinSetrika(New Mesin With {.jenis_mesin = "4"})

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtMesin.Text = frmLookUp.returnRow("nama_mesin").ToString
            txtMesin.Tag = frmLookUp.returnRow("kode_mesin").ToString
            txtMesin.TabIndex = frmLookUp.returnRow("kapasitas_mesin")
        End If

        InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
    End Sub

    'lookup pegawai
    Private Sub btnOperator_Click(sender As System.Object, e As System.EventArgs) Handles btnOperator.Click
        Me.utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"nomer", "No", 40},
                              {"id_pegawai", "ID Pegawai", 80},
                              {"nama_pegawai", "Nama", 100},
                              {"nip_pegawai", "Nip", 200},
                              {"bagian", "Bagian", 200},
                              {"status_pegawai", "Status", 100}}

        frmLookUp.keyField = "id_pegawai"
        frmLookUp.fields = {"nama_pegawai", "nip_pegawai", "bagian", "status_pegawai"}

        frmLookUp.dt = Me.utilmesinsetrikaSvr.lookupPegawai()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtOperator.Text = frmLookUp.returnRow("nama_pegawai").ToString
            txtOperator.Tag = frmLookUp.returnRow("id_pegawai").ToString
        End If

        InProcFactory.CloseChannel(Me.utilmesinsetrikaSvr)
    End Sub

    'untuk menyimpan dan kemudian kembali ke menu awal
    Private Sub saveClose(ByVal sender As Object, ByVal e As EventArgs)
        If Me.validateForm Then

            If utilmesinsetrika.utilisasi_mesin_setrika_id = Nothing Then   'save new
                If MsgBox("Anda akan menyimpan data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
                        utilmesinsetrikaSvr.insertUtilMesinSetrika(New Util_Mesin_Setrika With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
                                                                                                .load_ke = txtLoad.Text,
                                                                                                .nama_mesin = txtMesin.Tag,
                                                                                                .linen = txtLinen.Tag,
                                                                                                .operator_mesin = txtOperator.Tag,
                                                                                                .jumlah_linen_bersih = txtLinenBersih.Text,
                                                                                                .jumlah_linen_rusak = txtLinenRusak.Text,
                                                                                                .jumlah_linen_reject = txtLinenReject.Text,
                                                                                                .jumlah_linen = txtJmlLinen.Text})

                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")

                        Dim uc As New ModUtilisasiMesinSetrika
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinsetrikaSvr)
                End If
            Else             'save edit
                If MsgBox("Anda akan mengubah data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                    Try
                        utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
                        utilmesinsetrikaSvr.updateUtilMesinSetrika(New Util_Mesin_Setrika With {.utilisasi_mesin_setrika_id = LabelID.Text,
                                                                                                .jumlah_linen_bersih = txtLinenBersih.Text,
                                                                                                .jumlah_linen_rusak = txtLinenRusak.Text,
                                                                                                .jumlah_linen_reject = txtLinenReject.Text,
                                                                                                .jumlah_linen = txtJmlLinen.Text,
                                                                                                .operator_mesin = txtOperator.Tag,
                                                                                                .kodelinen = txtLinen.Tag,
                                                                                                .jumlah_linen_bersih_awal = txtLinenBersih.Tag,
                                                                                                .jumlah_linen_rusak_awal = txtLinenRusak.Tag,
                                                                                                .jumlah_linen_reject_awal = txtLinenReject.Tag})

                        MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil diubah")

                        Dim uc As New ModUtilisasiMesinSetrika
                        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    InProcFactory.CloseChannel(utilmesinsetrikaSvr)
                End If
            End If
        End If
    End Sub

    'untuk kembali ke menu awal 
    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim uc As New ModUtilisasiMesinSetrika
        UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub

    'untuk membersihkan fields beserta error handlingnya
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        Clear()
        ErrorProvider.Clear()
    End Sub

    Private Sub Clear()
        txtMesin.Text = ""
        txtLinen.Text = ""
        txtJmlLinen.Text = ""
        txtLinenBersih.Text = ""
        txtLinenRusak.Text = ""
        txtLinenReject.Text = ""
        txtOperator.Text = ""
    End Sub

    'untuk simpan dan lanjut pengisian data berikutnya
    'Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    If Me.validateForm Then

    '        If MsgBox("Anda akan menyimpan data " & txtMesin.Text & "?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
    '            Try
    '                utilmesinsetrikaSvr = InProcFactory.CreateChannel(Of UtilmesinSetrikaService, IUtilmesinSetrikaService)()
    '                utilmesinsetrikaSvr.insertUtilMesinSetrika(New Util_Mesin_Setrika With {.tanggal = DateTime.Parse(Today).ToString("yyyy/M/dd"),
    '                                                                                            .load_ke = txtLoad.Text,
    '                                                                                            .kode_mesin = txtMesin.Tag,
    '                                                                                            .linen = txtLinen.Tag,
    '                                                                                            .jumlah_linen = txtJmlLinen.Text,
    '                                                                                            .jumlah_linen_bersih = txtLinenBersih.Text,
    '                                                                                            .jumlah_linen_rusak = txtLinenRusak.Text,
    '                                                                                            .jumlah_linen_reject = txtLinenReject.Text,
    '                                                                                            .operator_mesin = txtOperator.Tag})

    '                MsgBox("Data Utilisasi Mesin " & txtMesin.Text & " telah berhasil disimpan")
    '                Clear().
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '            InProcFactory.CloseChannel(utilmesinsetrikaSvr)
    '        End If
    '    End If
    'End Sub

    'untuk error handling
    Private Function validateForm() As Boolean
        Dim result As Boolean = True
        If txtMesin.Text.Trim = "" Then
            ErrorProvider.SetError(btnMesin, "Nama Mesin Kosong")
            result = False
        ElseIf txtLinen.Text.Trim = "" Then
            ErrorProvider.SetError(btnLinen, "Linen Mesin Kosong")
            result = False        
        ElseIf txtOperator.Text.Trim = "" Then
            ErrorProvider.SetError(btnOperator, "Operator Mesin Kosong")
            result = False
        ElseIf txtLinenBersih.Text.Trim = "" Then
            ErrorProvider.SetError(txtLinenBersih, "Jumlah Line bersih kosong")
            result = False
        ElseIf txtLinenRusak.Text.Trim = "" Then
            ErrorProvider.SetError(txtLinenRusak, "Jumlah Line rusak kosong")
            result = False
        ElseIf txtLinenReject.Text.Trim = "" Then
            ErrorProvider.SetError(txtLinenReject, "Jumlah Line reject kosong")
            result = False            
            'ElseIf CInt(txtJmlLinen.Text) > txtMesin.TabIndex Then
            '    ErrorProvider.SetError(txtJmlLinen, "Jumlah linen melampaui kapasitas mesin")
            '    result = False
        Else
            ErrorProvider.SetError(btnMesin, "")
        End If
        Return result
    End Function

    Private Sub btnLinen_Click(sender As System.Object, e As System.EventArgs) Handles btnLinen.Click
        Me.linenSvr = InProcFactory.CreateChannel(Of LinenService, ILinenService)()
        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"jns_linen_kode", "Kode Linen", 80},
                              {"jns_linen_nama", "Nama Linen", 200}}

        frmLookUp.keyField = "jns_linen_kode"
        frmLookUp.fields = {"jns_linen_nama"}

        frmLookUp.dt = Me.linenSvr.tampilLinenAktif()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtLinen.Text = frmLookUp.returnRow("jns_linen_nama").ToString()
            txtLinen.Tag = frmLookUp.returnRow("jns_linen_kode").ToString()
        End If
        InProcFactory.CloseChannel(Me.linenSvr)
    End Sub

    Private Sub txtLinenBersih_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenBersih.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ",") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub
   
    Private Sub txtLinenBersih_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtLinenBersih.KeyUp
        If txtLinenBersih.Text = "" Then
            jmlbersih = 0
        Else
            jmlbersih = txtLinenBersih.Text
        End If
        If txtLinenRusak.Text = "" Then
            jmlrusak = 0
        Else
            jmlrusak = txtLinenRusak.Text
        End If
        If txtLinenReject.Text = "" Then
            jmlreject = 0
        Else
            jmlreject = txtLinenReject.Text
        End If
        jmltot = jmlbersih + jmlrusak + jmlreject
        txtJmlLinen.Text = jmltot
    End Sub

    Private Sub txtLinenRusak_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenRusak.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ",") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub

    Private Sub txtLinenRusak_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtLinenRusak.KeyUp
        If txtLinenBersih.Text = "" Then
            jmlbersih = 0
        Else
            jmlbersih = txtLinenBersih.Text
        End If
        If txtLinenRusak.Text = "" Then
            jmlrusak = 0
        Else
            jmlrusak = txtLinenRusak.Text
        End If
        If txtLinenReject.Text = "" Then
            jmlreject = 0
        Else
            jmlreject = txtLinenReject.Text
        End If
        jmltot = jmlbersih + jmlrusak + jmlreject
        txtJmlLinen.Text = jmltot
    End Sub

    Private Sub txtLinenReject_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtLinenReject.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = ",") Then
            MsgBox("hanya menerima inputan angka")
            e.Handled = True
        End If
    End Sub

    Private Sub txtLinenReject_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtLinenReject.KeyUp
        If txtLinenBersih.Text = "" Then
            jmlbersih = 0
        Else
            jmlbersih = txtLinenBersih.Text
        End If
        If txtLinenRusak.Text = "" Then
            jmlrusak = 0
        Else
            jmlrusak = txtLinenRusak.Text
        End If
        If txtLinenReject.Text = "" Then
            jmlreject = 0
        Else
            jmlreject = txtLinenReject.Text
        End If
        jmltot = jmlbersih + jmlrusak + jmlreject
        txtJmlLinen.Text = jmltot
    End Sub

   
End Class
