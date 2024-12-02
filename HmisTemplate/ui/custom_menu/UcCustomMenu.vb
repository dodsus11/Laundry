Imports Ninject

Public Class UcCustomMenu

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private userDao As dao.UserDao
    Private db As DbLibs.ClsDbase

    Public Sub New()
        'db = kernel.Get(Of DbLibs.ClsDbase)()
        'userDao = kernel.Get(Of dao.UserDao)()
        'userDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub UserListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserListToolStripMenuItem.Click
        Dim uc As New modUsers()

        Me.pnCenter.Controls.Clear()
        Me.pnCenter.Controls.Add(uc)
        uc.Dock = DockStyle.Fill

        'UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub


    Private Sub ProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessToolStripMenuItem.Click
        Dim uc As New modProcess()

        Me.pnCenter.Controls.Clear()
        Me.pnCenter.Controls.Add(uc)
        uc.Dock = DockStyle.Fill
    End Sub
  
    Private Sub RoleListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoleListToolStripMenuItem.Click
        Dim uc As New modRoles()

        Me.pnCenter.Controls.Clear()
        Me.pnCenter.Controls.Add(uc)
        uc.Dock = DockStyle.Fill

        'UILibs.PageLink.goToPage(Me.Parent, uc, Me)
    End Sub
  

    Private Sub ControlListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlListToolStripMenuItem.Click
        Dim uc As New ModControlList()

        Me.pnCenter.Controls.Clear()
        Me.pnCenter.Controls.Add(uc)
        uc.Dock = DockStyle.Fill
    End Sub

End Class
