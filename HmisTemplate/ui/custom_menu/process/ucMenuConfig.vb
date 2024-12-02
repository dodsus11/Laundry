Imports Ninject
Imports DbLibs

Public Class ucMenuConfig
    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private procDao As dao.ProcessDao
    Private subMnDao As dao.SubMenuDao
    Private mnControlDao As dao.MenuControlDao

    Public myNode As MyNode

    Dim dtMenu As DataTable
    Dim imgList As New ImageList()

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        procDao = kernel.Get(Of dao.ProcessDao)()
        subMnDao = kernel.Get(Of dao.SubMenuDao)()
        mnControlDao = kernel.Get(Of dao.MenuControlDao)()
        procDao.db = db
        subMnDao.db = db
        mnControlDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ucMenuConfig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'set footer title
            Me.setFooterTitle("", "", "")

            'set image list
            'imgList.Images.Add("ok", Image.FromFile("images/Play.png"))
            'imgList.Images.Add("cancel", Image.FromFile("images/Problem.png"))
            imgList.Images.Add("ok", UILibs.MyResources.GetBitmap("Play.png"))
            imgList.Images.Add("cancel", UILibs.MyResources.GetBitmap("Problem.png"))
            TrvMenu.ImageList = imgList

            'set title
            lblTitle.Text = "Menu Config >> " & myNode.caption

            Me.dtMenu = Me.subMnDao.getProcessMenuById(Me.myNode.id)

            'clear treeView
            TrvMenu.Nodes.Clear()

            Dim rootNode As New TreeNode() With {.Text = "Main Menu",
                                                 .Tag = New DataMenu() With {.menuId = 0,
                                                                                .dllName = "",
                                                                                .ucName = ""}}
            TrvMenu.Nodes.Add(rootNode)

            GenMenuNode(rootNode)

            TrvMenu.ExpandAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub GenMenuNode(ByVal parentNode As TreeNode)
        Try

            'convert parent tag to DataMenu Object
            Dim dataMn As DataMenu = CType(parentNode.Tag, DataMenu)

            Dim rows() As DataRow

            'If parentMenu.Tag = 0 Then
            If dataMn.menuId = 0 Then
                rows = dtMenu.Select("parent_menu IS NULL")
            Else
                'rows = dtMenu.Select("parent_menu =" & parentMenu.Tag)
                rows = dtMenu.Select("parent_menu =" & dataMn.menuId)
            End If

            Dim i As Integer = 1
            '. = Image.FromFile("images/" & row("icon_menu")),
            For Each row In rows
                Dim newNode As New TreeNode() With {.Text = row("menu_caption").ToString(),
                                                   .Tag = New DataMenu() With {.menuId = row("id"),
                                                                                  .dllName = row("dll_name").ToString(),
                                                                                  .ucName = row("uc_name").ToString(),
                                                                                  .iconName = row("icon_name").ToString()}}


                If row("dll_name").ToString() = "" Then
                    newNode.ImageKey = "cancel"
                Else
                    newNode.ImageKey = "ok"
                End If




                parentNode.Nodes.Add(newNode)

                i += 1

                GenMenuNode(newNode)

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub TrvMenu_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TrvMenu.AfterSelect
        e.Node.SelectedImageKey = e.Node.ImageKey
    End Sub

    Sub setFooterTitle(ByVal caption As String, ByVal dll As String, ByVal ucx As String)
        'set footer title
        lblCaption.Text = caption
        lblDLL.Text = dll
        lblUcx.Text = ucx
    End Sub

    Private Sub TrvMenu_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TrvMenu.NodeMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            TrvMenu.SelectedNode = e.Node

            Dim mnu As New ContextMenuStrip()
            'Dim mnuAddChild As New ToolStripMenuItem("Add Child", Image.FromFile("images/Add.gif"), AddressOf mnuAddChild_Click)
            'Dim mnuRemove As New ToolStripMenuItem("Remove Menu", Image.FromFile("images/Delete.gif"), AddressOf mnuRemove_Click)
            'Dim mnuAssignControl As New ToolStripMenuItem("Assign Control", Image.FromFile("images/Import.gif"), AddressOf mnuAssignControl_Click)
            'Dim mnuRemoveControl As New ToolStripMenuItem("Remove Control", Image.FromFile("images/Cancel.gif"), AddressOf mnuRemoveControl_Click)
            Dim mnuAddChild As New ToolStripMenuItem("Add Child", UILibs.MyResources.GetBitmap("Add.gif"), AddressOf mnuAddChild_Click)
            Dim mnuRemove As New ToolStripMenuItem("Remove Menu", UILibs.MyResources.GetBitmap("Delete.gif"), AddressOf mnuRemove_Click)
            Dim mnuAssignControl As New ToolStripMenuItem("Assign Control", UILibs.MyResources.GetBitmap("Import.gif"), AddressOf mnuAssignControl_Click)
            Dim mnuRemoveControl As New ToolStripMenuItem("Remove Control", UILibs.MyResources.GetBitmap("Cancel.gif"), AddressOf mnuRemoveControl_Click)

            mnu.Items.AddRange(New ToolStripMenuItem() {mnuAddChild, mnuRemove, mnuAssignControl, mnuRemoveControl})
            Dim myPoint As Point = TrvMenu.PointToClient(Control.MousePosition)
            mnu.Show(TrvMenu, myPoint.X, myPoint.Y)
        End If

        Dim dtMn As DataMenu = CType(e.Node.Tag, DataMenu)
        Me.setFooterTitle(e.Node.Text, dtMn.dllName, dtMn.ucName)

    End Sub

    Private Sub mnuAddChild_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim dlg As New DlgMenuAdd()
        dlg.subMnDao = Me.subMnDao
        dlg.processId = myNode.id

        Dim node As TreeNode = TrvMenu.SelectedNode()
        Dim dataMn As DataMenu = CType(node.Tag, DataMenu)
        dlg.parentId = dataMn.menuId

        If dlg.ShowDialog() = DialogResult.OK Then
            'refresh tree view
            ucMenuConfig_Load(sender, e)
        End If

    End Sub

    Private Sub mnuAssignControl_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim frmLookup As New UILibs.FrmLookUp()
        frmLookup.dt = Me.mnControlDao.getAllControlMenu()
        frmLookup.lebar = {0, 120, 100, 100, 100, 100}
        frmLookup.headers = {"ID", "Caption", "DLL Name", "User Control", "Icon", "Descr"}
        frmLookup.fields = {"caption", "dll_name", "uc_name"}
        frmLookup.lebarFrm = 700
        frmLookup.getBtnSearch().Visible = False

        If frmLookup.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim dataMn As DataMenu = CType(TrvMenu.SelectedNode.Tag, DataMenu)

            Me.subMnDao.assignControlToMenu(dataMn.menuId, CInt(frmLookup.results(0)))

            'reload treeView
            ucMenuConfig_Load(sender, e)

            'MsgBox(frmLookup.results(0))
        End If


    End Sub

    Private Sub mnuRemove_Click(ByVal sender As Object, ByVal e As EventArgs)

        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        'validasi => nothing 



        Try
            Dim node As TreeNode = TrvMenu.SelectedNode()
            Dim dataMn As DataMenu = CType(node.Tag, DataMenu)

            Dim returnVal As Integer
            Me.subMnDao.removeProcMenu(dataMn.menuId, returnVal)

            If returnVal > 0 Then
                MsgBox("Menu tidak bisa dihapus !", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Data berhasil dihapus", MsgBoxStyle.Information)
            End If


            'reload treeview
            ucMenuConfig_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuRemoveControl_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        Dim dataMn As DataMenu = CType(TrvMenu.SelectedNode.Tag, DataMenu)

        Me.subMnDao.assignControlToMenu(dataMn.menuId, 0)

        'reload treeView
        ucMenuConfig_Load(sender, e)
    End Sub

End Class
