Imports Ninject
Imports DbLibs
Imports PISService
Imports UtilsLibs.MainMod

Public Class ucUserAdd
    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private userDao As dao.UserDao

    Public userId As Integer = 0
    Public party_id As Integer = 0
    Private kodePoli As String = String.Empty
    Private poliDao As PISService.dao.PisPolyDao

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        userDao = kernel.Get(Of dao.UserDao)()
        userDao.db = db

        poliDao = kernel.Get(Of PISService.dao.PisPolyDao)()
        poliDao.db = db
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        AddHandler seTemp.btnSaveAndNew.Click, AddressOf btnSaveNew_Click
        AddHandler seTemp.btnSaveAndClose.Click, AddressOf btnSaveClose_Click
        AddHandler seTemp.btnClear.Click, AddressOf btnClear_Click
        AddHandler seTemp.btnCancel.Click, AddressOf btnClose_Click


    End Sub

    Private Sub ucUserAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'seTemp.setWidthTitle(Me.Parent.Width)
        seTemp.setTitle("Add User")

        If Me.userId > 0 Then
            loadDetail()
        End If
    End Sub

    Private Sub loadDetail()
        Try
            Dim dt As DataTable = userDao.getUserById(Me.userId)


            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    txtUn.Text = .Item("username").ToString()
                    txtNamaLengkap.Text = .Item("fullname").ToString()
                    txtNamaLengkap.Tag = GetFieldNum(.Item("pegawai_id"))
                    'txtPwd1.Text = CryptoUtil.DecryptTripleDES(.Item("password").ToString())
                    'txtPwd2.Text = txtPwd1.Text

                    txtPasswd1.Text = CryptoUtil.DecryptTripleDES(.Item("password").ToString())
                    txtPasswd2.Text = txtPasswd1.Text

                    If Not IsDBNull(.Item("karyawan_party_id")) Then
                        txtNamaPegawai.Text = .Item("namaPegawai").ToString
                        party_id = .Item("karyawan_party_id")
                    End If
                    txtRole.Text = .Item("role_name").ToString()
                    txtRole.Tag = CInt(.Item("role_id"))
                    If Not IsDBNull(.Item("poliCode")) Then
                        kodePoli = .Item("poliCode")
                        UtilsLibs.MainMod.setTextValue(txtPoli, .Item("poly_name"))
                    End If

                    'get user data from USERMASTER(Server-67)
                    Dim dtUserMan As DataTable = db.execQuery("ScMan_UsersGetByUsername", New Object() {
                                                              .Item("username").ToString,
                                                              GetFieldNum(.Item("pegawai_id"))
                                                          })

                    If dtUserMan.Rows.Count > 0 Then
                        txtBagian.Text = dtUserMan.Rows(0)("Bagian").ToString
                        txtNip.Text = dtUserMan.Rows(0)("Nip").ToString
                        txtNamaPegawai.Text = dtUserMan.Rows(0)("Nama").ToString
                        txtJenisPeg.Text = dtUserMan.Rows(0)("jns_pegawai_nama").ToString
                    End If

                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function validateForm() As String

        If txtUn.Text.Trim = String.Empty Then
            Return "Username Kosong !"
        End If

        If txtNamaLengkap.Text.Trim = String.Empty Then
            Return "Nama User Kosong !"
        End If

        If txtPasswd1.Text.Trim = String.Empty Or txtPasswd2.Text.Trim = String.Empty Then
            Return "Password Kosong !"
        End If

        If txtPasswd1.Text.Trim <> txtPasswd2.Text.Trim() Then
            Return "Password tidak sama !"
        End If

        If txtRole.Text.Trim = String.Empty Then
            Return "Role Kosong !"
        End If

        If Me.userId = 0 Then
            If userDao.isExistUn(txtUn.Text.Trim) Then
                Return "Username sudah ada !"
            End If
        End If

        If Me.userId = 0 Then
            If userDao.isExistRoleInUser(txtUn.Text.Trim) Then
                Return "User sudah mempunyai role !"
            End If
        End If

        Return String.Empty

    End Function

    Sub saveUser(ByVal flag As Integer)
        If flag = 0 Then
            Try
                Dim usr As New model.User()
                usr.un = txtUn.Text.Trim().ToLower()
                usr.fullName = txtNamaLengkap.Text.Trim()
                usr.pwd = CryptoUtil.EncryptTripleDES(txtPasswd1.Text)
                usr.roleId = CInt(txtRole.Tag)
                usr.karyawan_party_id = party_id
                usr.kodePoli = kodePoli

                usr.PegawaiId = GetFieldNum(txtNamaLengkap.Tag)
                usr.Nip = txtNip.Text.Trim()
                usr.Bagian = txtBagian.Text.Trim()

                userDao.saveUserAndRole(usr)
            Catch ex As Exception
                Throw ex
            End Try
        Else
            Try
                Dim usr As New model.User()
                usr.un = txtUn.Text.Trim().ToLower()
                usr.fullName = txtNamaLengkap.Text.Trim()
                usr.pwd = CryptoUtil.EncryptTripleDES(txtPasswd1.Text)
                usr.roleId = txtRole.Tag
                usr.id = Me.userId
                usr.kodePoli = kodePoli
                usr.karyawan_party_id = party_id

                usr.PegawaiId = GetFieldNum(txtNamaLengkap.Tag)
                usr.Nip = txtNip.Text.Trim()
                usr.Bagian = txtBagian.Text.Trim()

                userDao.updateUser(usr)
            Catch ex As Exception
                Throw ex
            End Try
        End If    
    End Sub

    Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)

        If MessageBox.Show("Data Akan disimpan, Anda Yakin ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
            Return
        End If


        Dim result As String = Me.validateForm()
        If result <> "" Then
            MsgBox(result, MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If

        Me.Cursor = Cursors.AppStarting

        Try
            db.beginTransaction()
            saveUser(0)
            db.commitTrans()

            'save user to usermaster (172.16.1.67)
            Me.SaveOrUpdateUserMasterCenter()

            Me.Cursor = Cursors.Default
            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
            Me.clearForm()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            db.rollBackTrans()
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub btnSaveClose_Click(ByVal sender As Object, ByVal e As EventArgs)

        If MessageBox.Show("Data Akan disimpan, Anda Yakin ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
            Return
        End If

        Dim result As String = Me.validateForm()
        If result <> "" Then
            MsgBox(result, MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If

        Me.Cursor = Cursors.AppStarting

        If userId = 0 Then
            Try
                db.beginTransaction()
                saveUser(0)
                db.commitTrans()

                'save user to usermaster (172.16.1.67)
                Me.SaveOrUpdateUserMasterCenter()

                Me.Cursor = Cursors.Default

                MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
                UILibs.PageLink.goToPage(Me.Parent, New modUsers(), Me)
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                db.rollBackTrans()
                MsgBox(ex.Message)
            End Try
        Else
            db.beginTransaction()
            Try
                saveUser(1)
                db.commitTrans()

                'save user to usermaster (172.16.1.67)
                Me.SaveOrUpdateUserMasterCenter()

                Me.Cursor = Cursors.Default

                MsgBox("Data berhasil diubah", MsgBoxStyle.Information, "Pesan")
                UILibs.PageLink.goToPage(Me.Parent, New modUsers(), Me)
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                db.rollBackTrans()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SaveOrUpdateUserMasterCenter()

        db.execUpdate("ScMan_UsersAddUpdate", New Object() {txtUn.Text.Trim(),
                                                            txtPasswd1.Text.Trim(),
                                                            txtNip.Text.Trim(),
                                                            txtNamaLengkap.Text.Trim(),
                                                            txtBagian.Text.Trim()})

    End Sub

    Sub clearForm()
        Try
            txtUn.Clear()
            txtPasswd1.Clear()
            txtPasswd2.Clear()
            txtRole.Clear()
            txtPoli.Clear()
            kodePoli = Nothing
            txtRole.Tag = ""
            txtNamaPegawai.Clear()
            party_id = 0

            txtBagian.Clear()
            txtNip.Clear()
            txtNamaPegawai.Tag = Nothing
            txtNamaPegawai.Clear()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs)
        clearForm()
    End Sub

    Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        UILibs.PageLink.goToPage(Me.Parent, New modUsers(), Me)
    End Sub

    Private Sub btnLookUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUp.Click
        Dim frmLook As New UILibs.FrmLookUp()
        frmLook.dt = userDao.getAllRoles()
        frmLook.lebar = New Integer() {100, 100}
        frmLook.headers = New String() {"ID", "Role Name"}
        frmLook.fields = {"role_name"}
        frmLook.visibleButton = False

        If frmLook.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtRole.Tag = frmLook.results(0)
            txtRole.Text = frmLook.results(1).ToString()
        End If
    End Sub

    Private Sub btnLUPegawai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLUPegawai.Click
        Try
            Dim lookUp As New UILibs.FrmLookUp()
            lookUp.dt = userDao.getPegawai()
            lookUp.lebar = New Integer() {0, 100, 350}
            lookUp.headers = New String() {"id", "NIP", "Nama Lengkap"}
            lookUp.fields = {"[Nama Lengkap]"}
            lookUp.visibleButton = False

            If lookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
                party_id = lookUp.results(0)
                txtNamaPegawai.Text = lookUp.results(2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHapusKaryawan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapusKaryawan.Click
        Try
            txtNamaPegawai.Text = String.Empty
            party_id = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLUPoli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLUPoli.Click
        Try
            Dim lookUp As New UILibs.DlgLookUp()
            lookUp.dt = poliDao.getPolys()
            lookUp.fidArray = {{"poly_code", "Kode", 100},
                               {"poly_name", "Poliklinik", 250},
                               {"building_name", "Unit", 250}}

            lookUp.fields = {"poly_code", "poly_name"}
            lookUp.keyField = "poly_code"

            If lookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
                kodePoli = lookUp.returnRow("poly_code").ToString
                UtilsLibs.MainMod.setTextValue(txtPoli, lookUp.returnRow("poly_name").ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1Button1.Click
        Try
            kodePoli = String.Empty
            UtilsLibs.MainMod.setTextValue(txtPoli, String.Empty)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLookPeg_Click(sender As System.Object, e As System.EventArgs) Handles btnLookPeg.Click

        Dim frmLookUp As New UILibs.DlgLookUp()
        frmLookUp.fidArray = {{"pegawai_id", "Id", 0},
                              {"pegawai_id_str", "Id Peg", 0},
                              {"nip", "Nip", 135},
                              {"pegawai_nama", "Nama Pegawai", 200},
                              {"code_doctor", "Kode Dokter", 90},
                              {"dept_name", "Ruang/Bagian", 100},
                              {"jabatan_nama", "Jabatan", 100},
                              {"jns_pegawai_nama", "Jenis Pegawai", 70}}

        frmLookUp.keyField = "pegawai_id_str"
        frmLookUp.fields = {"pegawai_nama", "dept_name", "nip"}
        frmLookUp.dt = Me.userDao.getPegawai()

        If frmLookUp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtNamaLengkap.Tag = UtilsLibs.MainMod.GetFieldNum(frmLookUp.returnRow("pegawai_id"))
            txtNamaLengkap.Text = frmLookUp.returnRow("pegawai_nama").ToString()
            txtNamaPegawai.Text = frmLookUp.returnRow("pegawai_nama").ToString()
            txtBagian.Text = frmLookUp.returnRow("dept_name").ToString()
            txtJenisPeg.Text = frmLookUp.returnRow("jns_pegawai_nama").ToString()
            txtNip.Text = frmLookUp.returnRow("nip").ToString()
        Else
            txtNamaPegawai.Clear()
            txtNamaLengkap.Tag = Nothing
            txtNamaLengkap.Text = String.Empty
            txtBagian.Text = String.Empty
            txtJenisPeg.Text = String.Empty
            txtNip.Text = String.Empty
        End If

    End Sub

End Class
