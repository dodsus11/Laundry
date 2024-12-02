Imports Ninject

Public Class FrmUserAdd

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As DbLibs.ClsDbase
    Private userDao As dao.UserDao

    Public pageIndex As Integer = 0
    Public currentActivePage As UserControl
    Public Pages As List(Of UserControl) = New List(Of UserControl)

    Dim pgUser As PageUserAdd
    Dim pgcRoles As PageUserRoles

    Friend userId As Integer = 0
    Private roleId As Integer = 0

    Public Sub New()
        Using block = kernel.BeginBlock()
            db = block.Get(Of DbLibs.ClsDbase)()
            userDao = block.Get(Of dao.UserDao)()
        End Using

        userDao.db = db



        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler btnSaveTemp.getBtnSaveAndNew().Click, AddressOf btnSaveNew_Click
        AddHandler btnSaveTemp.getBtnSaveAndClose().Click, AddressOf btnSaveClose_Click
        AddHandler btnSaveTemp.getBtnCancel().Click, AddressOf btnCancel_Click

        'page userControl
        pgUser = New PageUserAdd(Me.userDao)
        pgcRoles = New PageUserRoles(Me.userDao)
        Pages.Add(pgUser)
        Pages.Add(pgcRoles)

    End Sub

    Private Sub FrmUserAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        setActivePage(1)
        setActivePage(0)


        'jika mode edit
        If Me.userId > 0 Then
            loadData()
            btnSaveTemp.setVisibleButton(False, True, True)
        End If


    End Sub

    Private Sub loadData()
        Dim dt As DataTable = userDao.getUserById(Me.userId)

        If dt.Rows.Count > 0 Then
            With pgUser
                .txtUn.Text = dt.Rows(0)("UserName").ToString()
                'Me.roleId = dt.Rows(0)("RoleId")
                pgcRoles.setRoleId(dt.Rows(0)("RoleId"))
            End With

        End If

    End Sub

    Private Sub setActivePage(ByVal index As Integer)

        'validatePageIndex(index)

        Dim newPage As UserControl = Pages(index)

        If Not Me.CenterPanel.Contains(newPage) Then
            Me.CenterPanel.Controls.Add(newPage)
        End If

        newPage.Visible = True
        newPage.Dock = DockStyle.Fill


        Me.currentActivePage = newPage
        'Dim e As CancelEventArgs = New CancelEventArgs()

        For Each pg As UserControl In Pages
            If pg IsNot Me.currentActivePage Then
                pg.Visible = False
            End If
        Next


    End Sub

    Function validateForm() As String
        If pgcRoles.getCheckNode() = 0 Then
            Return "Pilih role !"
        End If

        If pgUser.txtUn.Text.Trim = "" Then
            Return "Username kosong !"
        End If

        If pgUser.txtPwd1.Text.Trim = "" Or pgUser.txtPwd2.Text.Trim = "" Then
            Return "Password kosong !"
        End If

        If pgUser.txtPwd1.Text.Trim <> pgUser.txtPwd2.Text.Trim Then
            Return "Password tidak sama !"
        End If

        If userDao.isExistUn(pgUser.txtUn.Text.Trim) Then
            Return "Username sudah ada !"
        End If

        If userDao.isExistRoleInUser(pgUser.txtUn.Text.Trim) Then
            Return "Username sudah mempunyai role !"
        End If

        Return ""

    End Function

    Sub simpanUserAndRole()
        'validasi
        '1. cek role <> 0
        '2. un tidak boleh kosong
        '3. pwd1 & pwd2 required
        '4. pwd1 & pwd2 must match
        '5. user name harus unik
        '6. userid pada table userRole harus unik

        Dim msg As String = Me.validateForm()

        If msg <> "" Then
            MsgBox(msg, MsgBoxStyle.Exclamation, "Pesan")
            Return
        End If

        db.beginTransaction()
        Try



            Dim us As New model.User() With {.un = pgUser.txtUn.Text.Trim, _
                                             .pwd = pgUser.txtPwd1.Text.Trim}

            'Me.userDao.saveUserAndRole(us, pgcRoles.getCheckNode())

            ' Throw New Exception("tes berhasil")

            db.commitTrans()


            MsgBox("Data user berhasil disimpan", MsgBoxStyle.Information)

            'reset all text in pageUser
            UtilsLibs.MainMod.resetText(pgUser)

            'reset all check trv roles
            pgcRoles.unCheckAllNode()


        Catch ex As Exception
            db.rollBackTrans()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSaveNew_Click(ByVal sender As Object, ByVal e As EventArgs)
        simpanUserAndRole()

        toolUsername_Click(sender, e)
    End Sub

    Private Sub btnSaveClose_Click(ByVal sender As Object, ByVal e As EventArgs)
        'jika model edit
        If Me.userId > 0 Then

            MsgBox("role:" & pgcRoles.getCheckNode())

            Return
        End If

        simpanUserAndRole()
        Me.db = Nothing
        Me.userDao = Nothing
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.db = Nothing
        Me.userDao = Nothing

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnLookRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New FrmRoleList()

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If


    End Sub

    Private Sub toolUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolUsername.Click
        setActivePage(0)
    End Sub

    Private Sub toolRole_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolRole.Click
        setActivePage(1)

        'If Me.roleId > 0 Then
        '    pgcRoles.setRoleId(Me.roleId)
        'End If

    End Sub


End Class