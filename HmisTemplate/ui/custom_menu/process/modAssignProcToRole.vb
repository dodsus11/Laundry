Imports Ninject
Imports DbLibs

Public Class modAssignProcToRole

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private procDao As dao.ProcessDao
    Private subMnDao As dao.SubMenuDao

    Public roleData As model.Role
    Dim processId As Integer = 0

    Dim header() As String = {"ID", "Menu", "View", "Print", "Save", "Edit", "Delete", "Unlock"}
    Dim lebar() As Integer = {0, 150, 100, 100, 100, 100, 100, 100}

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        procDao = kernel.Get(Of dao.ProcessDao)()
        subMnDao = kernel.Get(Of dao.SubMenuDao)()
        procDao.db = db
        subMnDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'AddHandler btnFooter.getBtnSaveAndClose().Click, AddressOf btnSave_Click

        AddHandler btnFooter.getBtnCancel.Click, AddressOf btnSave_Click

        Dim imgList As New ImageList()
        'imgList.Images.Add(Image.FromFile("images/Apply.gif"))
        imgList.Images.Add(UILibs.MyResources.GetBitmap("Apply.gif"))

        btnFooter.getBtnCancel().ImageList = imgList
        btnFooter.getBtnCancel().ImageIndex = 0
        btnFooter.getBtnCancel().Text = "Apply"
        btnFooter.getBtnSaveAndClose().Visible = False

        'btnAdd.BackColor = Color.FromArgb(67, 87, 123)
        'btnRemove.BackColor = Color.FromArgb(67, 87, 123)

    End Sub

    Private Sub modAssignProcToRole_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        'reset treeview
        Trv.Nodes.Clear()

        Dim rootNode As New TreeNode()
        rootNode.Text = "Process Menu : " & roleData.role_name
        rootNode.Tag = 0

        Trv.Nodes.Add(rootNode)

        Try
            loadModule(rootNode)

            Trv.TopNode.Expand()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub loadModule(ByVal parentNode As TreeNode)
        Try
            Dim dtProc As DataTable = Me.procDao.getAllProcessByRoleId(roleData.id)

            Dim dtDistinct As DataTable = dtProc.DefaultView.ToTable(True, "module_name")

            For Each row As DataRow In dtDistinct.Rows
                'Dim node As New TreeNode() With {
                '    .Text = String.Format("{0} => {1}", row("module_name").ToString(), row("process_name").ToString()),
                '    .Tag = row("id")}

                Dim node As New TreeNode() With {
                    .Text = String.Format("{0}", row("module_name").ToString()),
                    .Tag = 0}

                parentNode.Nodes.Add(node)

                'load process
                loadProcessByModule(node, dtProc, row("module_name").ToString())
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub loadProcessByModule(ByVal parentMod As TreeNode,
                            ByVal dtProc As DataTable,
                            ByVal moduleName As String)

        Dim rows() As DataRow = dtProc.Select(String.Format("module_name='{0}'", moduleName))

        For Each row As DataRow In rows
            Dim node As New TreeNode() With {
                   .Text = String.Format("{0}", row("process_name").ToString()),
                   .Tag = row("id")}

            parentMod.Nodes.Add(node)
        Next

    End Sub

    Sub loadDetailPermission(ByVal procId As Integer)
        Try
            Dim dtMenu As DataTable

            dtMenu = Me.subMnDao.getMenuPermissionByRoleAndProcess(Me.roleData.id, procId)


            gv.DataSource = dtMenu

            UILibs.GridStyle.formatGridFix(gv, dtMenu, header, lebar)

            'gv.Columns(0).ReadOnly = True
            'gv.Columns(1).ReadOnly = True

            'backup processr id
            Me.processId = procId



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Trv_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Trv.AfterSelect
        Try
            Dim procId As Integer = CInt(e.Node.Tag)

            Me.loadDetailPermission(procId)

            lblTitle.Text = "Assign Process >> " & Me.roleData.role_name

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        'validasi
        If Me.processId = 0 Then
            MsgBox("Pilih Proses Menu !", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim dtMenu As DataTable = CType(gv.DataSource, DataTable)
        If dtMenu.Rows.Count = 0 Then
            MsgBox("Data menu tidak ada !", MsgBoxStyle.Exclamation)
            Return
        End If


        Try

            Dim menuItems As New List(Of model.RolePermission)

            For Each row In dtMenu.Rows
                menuItems.Add(New model.RolePermission() With {.procMenuId = row("id"), _
                                                               .allowView = row("allow_view"), _
                                                               .allowPrint = row("allow_print"), _
                                                               .allowSave = row("allow_save"), _
                                                               .allowEdit = row("allow_edit"), _
                                                               .allowDelete = row("allow_delete"), _
                                                               .allowUnlock = row("allow_unlock")})
            Next


            Me.subMnDao.assignPermissionToMenu(Me.roleData.id, Me.processId, menuItems)

            MsgBox("Role Permission berhasil disimpan", MsgBoxStyle.Information)


            Me.loadDetailPermission(Me.processId)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim frmLookup As New UILibs.FrmLookUp()
            frmLookup.dt = Me.procDao.getAllProcess()
            frmLookup.lebar = {0, 120, 0, 0, 100, 0}
            frmLookup.headers = {"ID", "Process Name", "ModuleID", "IconName", "Module Name", "ModuleIcon"}
            frmLookup.fields = {"process_name", "module_name"}
            'frmLookup.lebarFrm = 700
            frmLookup.getBtnSearch().Visible = False

            If frmLookup.ShowDialog() = Windows.Forms.DialogResult.OK Then


                Dim retVal As Integer = 0

                Me.procDao.assignProcessToRole(Me.roleData.id, CInt(frmLookup.results(0)), retVal)

                'cek validasi
                If retVal = 0 Then
                    MsgBox("Process berhasil disimpan", MsgBoxStyle.Information)
                    'reload treeView
                    modAssignProcToRole_Load(sender, e)
                Else
                    MsgBox("Process sudah ada !", MsgBoxStyle.Exclamation)
                End If

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRemove_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        If MsgBox("Anda Yakin ?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.No Then Return

        db.beginTransaction()

        Try

            Dim procId As Integer = CInt(Trv.SelectedNode.Tag)

            procDao.removeProcessFromRole(roleData.id, procId)

            db.commitTrans()

            MsgBox(String.Format("Process {0} berhasil dihapus", Trv.SelectedNode.Text), MsgBoxStyle.Information)

            'reload
            modAssignProcToRole_Load(sender, e)

        Catch ex As Exception
            db.rollBackTrans()
        End Try
    End Sub

End Class
