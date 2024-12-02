Imports Ninject
Imports DbLibs
Imports SessionInfo

Public Class DlgChangePwd

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private loginDao As dao.LoginDao

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        loginDao = kernel.Get(Of dao.LoginDao)()

        loginDao.Db = db
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'validasi
        If txtOldPwd.Text.Trim() = "" Then
            MessageBox.Show("Password Lama Harus Diisi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtNewPwd.Text.Trim() = "" Or txtConfirmNewPwd.Text.Trim() = "" Then
            MessageBox.Show("Password Baru Harus Diisi !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        If txtNewPwd.Text.Trim() <> txtConfirmNewPwd.Text.Trim() Then
            MessageBox.Show("Password Baru Tidak Sama !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim user As New model.User
        user.un = SessionInfo.un
        user.pwd = CryptoUtil.EncryptTripleDES(txtOldPwd.Text)

        Me.Cursor = Cursors.WaitCursor

        'update password
        If Me.loginDao.ChangePwd(user, txtNewPwd.Text) Then

            Me.Cursor = Cursors.Default

            MsgBox("Password berhasil diganti", MsgBoxStyle.Information, "Pesan")

            Me.Close()

        Else
            Me.Cursor = Cursors.Default
            MsgBox("Password Lama Tidak Valid !", MsgBoxStyle.Exclamation, "Pesan")
        End If

    End Sub

End Class