Imports Ninject

Public Class FrmRoleList

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As DbLibs.ClsDbase
    Private userDao As dao.UserDao

    Public Sub New()
        db = kernel.Get(Of DbLibs.ClsDbase)()
        userDao = kernel.Get(Of dao.UserDao)()
        userDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub FrmRoleList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim root As New TreeNode() With {.Text = "Admin", .Tag = 1}
        trv.Nodes.Add(root)

        loadRoot(root)
    End Sub

    Private Sub loadRoot(ByVal parent As TreeNode)
        Try
            Dim dt As DataTable = userDao.getChildRolesById(parent.Tag)


            For Each row As DataRow In dt.Rows
                Dim node As New TreeNode()
                node.Text = row("RoleName").ToString()
                node.Tag = row("id")
                parent.Nodes.Add(node)

                loadRoot(node)

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnPilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPilih.Click
        MsgBox(trv.SelectedNode.Tag)
    End Sub

End Class