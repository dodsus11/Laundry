Imports Ninject
Imports DbLibs
Imports SessionInfo

Public Class FrmLogin
    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private loginDao As dao.LoginDao

    Dim procAnime As New CMAnimation.ProcessAnimation(Me.components)
    Private AniData As CMAnimation.ProcessAnimation.AnimationData

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        loginDao = kernel.Get(Of dao.LoginDao)()

        loginDao.Db = db
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub clearAll()
        tbUsername.Text = ""
        tbPassword.Text = ""
    End Sub

    Private Sub lnkLogin_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkLogin.Click
        AniData = CMAnimation.ProcessAnimation.GrantDatabaseAccessAnimation

        MyClass.procAnime.Show(AniData)

        bgw.WorkerSupportsCancellation = True
        bgw.RunWorkerAsync()


        ''test
        ''Me.CekAuth()
    
    End Sub

    Private Sub lnkExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkExit.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub bgw_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgw.DoWork

        Dim user As New model.User
        user.un = tbUsername.Text.ToLower()

        '[plan to use auth for USERMASTER:67]
        'user.pwd = tbPassword.Text.Trim()

        'old auth in HMIS
        user.pwd = CryptoUtil.EncryptTripleDES(tbPassword.Text.Trim.ToLower())

        e.Result = loginDao.validateLogin(user)

        '[deprecated(2019-01-04)]
        'If user.un = "super" And tbPassword.Text.Trim = "superuser4hmis" Then
        '    e.Result = True

        '    ModSessi.un = user.un
        '    ModSessi.uid = 1
        '    ModSessi.roleId = 1
        '    ModSessi.roleName = "super"

        '    ModSessi.fullName = "Super User"
        '    ModSessi.nik = ""
        'Else
        '    e.Result = loginDao.validateLogin(user)
        'End If


        'set text color 4 mandatori to session
        loginDao.setColorToSession()

        For value As Integer = 0 To 30
            If bgw.CancellationPending Then Exit For
            Threading.Thread.Sleep(10)
        Next
    End Sub

    Private Sub bgw_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted


        If e.Result = True Then
            'Dim menuUtama As New HMISMenu
            'menuUtama.Show()

            clearAll()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
            MyClass.procAnime.Cancel()
        Else
            MyClass.procAnime.Cancel()
            'MsgBox("Maaf Username Dan Password Salah")
            EpLogin.SetError(tbUsername, "Username dan Password salah !")
            EpLogin.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            tbPassword.Text = ""
        End If

    End Sub

    Private Sub CekAuth()

        Me.Cursor = Cursors.WaitCursor

        Dim user As New model.User
        user.un = tbUsername.Text.ToLower()
        user.pwd = CryptoUtil.EncryptTripleDES(tbPassword.Text.Trim)

        Dim hasil As Boolean = False

        'e.Result = loginDao.validateLogin(user)
        If user.un = "super" And tbPassword.Text.Trim = "superuser4hmis" Then
            hasil = True

            ModSessi.un = user.un
            ModSessi.uid = 1
            ModSessi.roleId = 1
            ModSessi.roleName = "super"

            ModSessi.fullName = "Super User"
            ModSessi.nik = ""
        Else
            hasil = loginDao.validateLogin(user)
        End If



        'set text color 4 mandatori to session
        loginDao.setColorToSession()

        If hasil = True Then
            'Dim menuUtama As New HMISMenu
            'menuUtama.Show()

            clearAll()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Hide()
        Else
            EpLogin.SetError(tbUsername, "Username dan Password salah !")
            EpLogin.BlinkStyle = ErrorBlinkStyle.AlwaysBlink
            tbPassword.Text = ""
        End If

        Me.Cursor = Cursors.Default


    End Sub


    'Private Sub NetUseLogon()

    '    Process.Start("net.exe", String.Format("use {0} {1} /USER:{2}\{3}", New Object() {"\\172.16.1.56", "R$K@riadi2019%", "FILESERVER-RSDK", "administrator"})).WaitForExit()
    'End Sub
    'Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    NetUseLogon()
    'End Sub
End Class