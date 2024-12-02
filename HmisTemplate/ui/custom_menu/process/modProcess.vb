Imports Ninject
Imports DbLibs

Public Class modProcess

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private menuDao As dao.MenuDao
    Private procDao As dao.ProcessDao
    Friend tempIdNode As Integer

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        menuDao = kernel.Get(Of dao.MenuDao)()
        procDao = kernel.Get(Of dao.ProcessDao)()
        menuDao.db = db
        procDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub modProcess_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.loadModule()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadModule()
        Try
            Dim dtMod As DataTable = Me.menuDao.getModuleSys()

            For Each row As DataRow In dtMod.Rows
                Dim node As New TreeNode()
                'node.NodeFont = New Font("Verdana", 8, FontStyle.Bold)
                node.Text = row("module_name").ToString()
                node.Tag = New MyNode() With {.id = row("id"),
                                              .level = 1,
                                              .caption = row("module_name")}

                'add process node to each module
                Me.addProcessToModule(node)

                Trv.Nodes.Add(node)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub addProcessToModule(ByVal Parent As TreeNode)
        Try
            Dim id As Integer = CType(Parent.Tag, MyNode).id

            Dim dtMod As DataTable = Me.procDao.getProcessByModID(id)

            For Each row As DataRow In dtMod.Rows
                Dim node As New TreeNode()
                'node.NodeFont = New Font("Verdana", 7, FontStyle.Regular)
                node.Text = row("process_name").ToString()
                node.Tag = New MyNode() With {.id = row("id"),
                                              .level = 2,
                                              .iconName = row("icon_name").ToString(),
                                              .caption = row("process_name")}

                Parent.Nodes.Add(node)

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Trv_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Trv.AfterSelect

        'make object for send 2 next control
        Dim myNode As MyNode = CType(e.Node.Tag, MyNode)

        If pnCenter.Controls.Count > 0 Then
            pnCenter.Controls.RemoveAt(0)
        End If

        If myNode.level = 1 Then
            Dim uc As New ucProcessAdd()
            uc.myNode = myNode
            uc.trv = Me.Trv
            pnCenter.Controls.Add(uc)
            uc.Dock = DockStyle.Fill
        Else
            Dim uc As New ucMenuConfig()
            uc.myNode = myNode
            pnCenter.Controls.Add(uc)
            uc.Dock = DockStyle.Fill
        End If

        'MsgBox(myNode.level)
    End Sub

    Private Sub Trv_RightClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles Trv.NodeMouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Trv.SelectedNode = e.Node

            Dim mnu As New ContextMenuStrip()
            Dim mnuAddChild As New ToolStripMenuItem("Edit", Nothing, AddressOf editProses_Click)
            Dim mnuRemove As New ToolStripMenuItem("Remove", Nothing, AddressOf deleteProses_Click)

            mnu.Items.AddRange(New ToolStripMenuItem() {mnuAddChild, mnuRemove}) ', mnuRemove
            Dim myPoint As Point = Trv.PointToClient(Control.MousePosition)
            mnu.Show(Trv, myPoint.X, myPoint.Y)
            Dim myNode As MyNode = CType(e.Node.Tag, MyNode)
        End If
    End Sub

    Private Sub editProses_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim node As TreeNode = Trv.SelectedNode()
        Dim myNode As MyNode = CType(node.Tag, MyNode)

        If myNode.level <> 1 Then
            If pnCenter.Controls.Count > 0 Then
                pnCenter.Controls.RemoveAt(0)
            End If

            Dim uc As New ucProcessAdd()
            uc.myNode = myNode


            'menampung id dan caption untuk edit
            uc.tempIdProses = myNode.id
            uc.txtProcessName.Text = myNode.caption.ToString
            uc.txtImage.Text = myNode.iconName.ToString

            uc.trv = Me.Trv
            pnCenter.Controls.Add(uc)
            uc.Dock = DockStyle.Fill
            'MsgBox(tempIdNode)
        End If


    End Sub

    Private Sub deleteProses_Click(ByVal sender As Object, ByVal e As EventArgs)

        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        Dim node As TreeNode = Trv.SelectedNode()
        Dim myNode As MyNode = CType(node.Tag, MyNode)

        If myNode.level = 2 Then

            db.beginTransaction()

            Try
                Dim retVal As Integer
                Me.procDao.removeProcessById(myNode.id, retVal)



                'cek retval
                If retVal = 0 Then
                    MsgBox(String.Format("Process {0} berhasil dihapus", myNode.caption), MsgBoxStyle.Information)

                    'reload trv
                    modProcess_Load(sender, e)

                ElseIf retVal = 1 Then
                    MsgBox(String.Format("Process {0} tidak bisa dihapus, {1} {0} masih terkait dengan role !", myNode.caption, vbNewLine), _
                           MsgBoxStyle.Exclamation)
                Else
                    MsgBox(String.Format("Process {0} tidak bisa dihapus, {1} {0} masih terkait dengan role permission!", myNode.caption, vbNewLine), _
                           MsgBoxStyle.Exclamation)

                End If



                db.commitTrans()

            Catch ex As Exception
                db.rollBackTrans()
                MsgBox(ex.Message)
                Return
            End Try

        Else
            MsgBox("Module Tidak bisa dihapus !", MsgBoxStyle.Exclamation)
        End If


    End Sub


End Class

Public Class MyNode
    Public id As Integer
    Public level As Integer
    Public caption As String
    Public iconName As String
End Class