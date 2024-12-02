Imports Ninject

Public Class PageUserRoles

    Private userDao As dao.UserDao

    Dim checkedNode As Integer = 0


    Public Sub New(ByVal userDao As dao.UserDao)

        Me.userDao = userDao

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim root As New TreeNode() With {.Text = "Admin", .Tag = 1}
        trv.Nodes.Add(root)

        Me.loadRoot(root)


    End Sub

    Private Sub PageUserRoles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        trv.ExpandAll()
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

    Private Sub resetAllCheckNode(ByVal parent As TreeNode)

        For Each node As TreeNode In parent.Nodes

            node.Checked = False

            Me.resetAllCheckNode(node)

        Next

    End Sub

    Private Sub CheckNode(ByVal parent As TreeNode)

        For Each node As TreeNode In parent.Nodes

            If node.Checked = True Then
                Me.checkedNode = node.Tag
                Return
            End If

            Me.CheckNode(node)

        Next

    End Sub

    Private Sub setCheckRole(ByVal parent As TreeNode, ByVal roleId As Integer)

        For Each node As TreeNode In parent.Nodes

            If CInt(node.Tag) = roleId Then
                node.Checked = True
                Return
            End If

            Me.setCheckRole(node, roleId)

        Next

    End Sub

    Public Sub setRoleId(ByVal roleId As Integer)
        setCheckRole(Me.trv.TopNode, roleId)
        'MsgBox(trv.TopNode.Text)
    End Sub

    Public Sub unCheckAllNode()
        Me.resetAllCheckNode(trv.TopNode)
    End Sub

    Public Function getCheckNode() As Integer

        Me.checkedNode = 0

        CheckNode(trv.TopNode)

        Return Me.checkedNode

    End Function

End Class
