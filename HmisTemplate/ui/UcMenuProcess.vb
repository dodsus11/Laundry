Imports Ninject
Imports DbLibs
Imports System.Reflection
Imports SessionInfo

Public Class UcMenuProcess


    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private subMnDao As dao.SubMenuDao

    Friend processId As Integer = 0
    Dim dtMenu As DataTable
    Dim dtACL As DataTable      'act table to store acl security user

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()
        subMnDao = kernel.Get(Of dao.SubMenuDao)()
        subMnDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UcMenuProcess_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.subMenu.BackColor = Color.White
        'Me.subMenu.ForeColor = Color.White
        Me.dtMenu = Me.subMnDao.getProcessMenuById(Me.processId)


        'get permission list ACL by role Id
        Me.dtACL = Me.subMnDao.getMenuPermissionByRoleAndProcess(SessionInfo.ModSessi.roleId, Me.processId)

        'replace allow_view to True (Menu Statis Regulasi)
        ReplaceAllowViewMenuStatis()

        Dim mnItem As New ToolStripMenuItem() With {.Text = "Menu Item".ToUpper(),
                                                    .Tag = New DataMenu() With {.menuId = 0,
                                                                                .dllName = "",
                                                                                .ucName = ""}}
        subMenu.Items.AddRange(New ToolStripItem() {mnItem})

        generateSubMenu(mnItem)

    End Sub

    Sub ReplaceAllowViewMenuStatis()
        'Me.dtACL.Rows.Add(952, "REGULASI", True, False, False, False, False, False)
        For Each row As DataRow In Me.dtACL.Rows
            If row.Item("id") = 967 Then
                row.Item("allow_view") = True
            End If
        Next row
    End Sub

    Private Sub generateSubMenu(ByVal parentMenu As ToolStripMenuItem)

        'convert parent tag to DataMenu Object
        Dim dataMn As DataMenu = CType(parentMenu.Tag, DataMenu)

        Dim rows() As DataRow

        'If parentMenu.Tag = 0 Then
        If dataMn.menuId = 0 Then
            rows = dtMenu.Select("parent_menu IS NULL")
        Else
            'rows = dtMenu.Select("parent_menu =" & parentMenu.Tag)
            rows = dtMenu.Select("parent_menu =" & dataMn.menuId)
        End If

        For Each row In rows

            'get acl by menu process id in DtACL
            Dim aclRow() As DataRow = Me.dtACL.Select(String.Format("id = {0}", row("id")))

            'cek if can not view ACL
            If aclRow(0)("allow_view") = False Then
                Continue For
                For index = 1 To 10

                Next

            End If

            Dim currACL As New ACLUser() With {.allowView = aclRow(0)("allow_view"),
                                               .allowPrint = aclRow(0)("allow_print"),
                                               .allowSave = aclRow(0)("allow_save"),
                                               .allowEdit = aclRow(0)("allow_edit"),
                                               .allowDelete = aclRow(0)("allow_delete"),
                                               .allowUnlock = aclRow(0)("allow_unlock")}

            '.Image = Image.FromFile("images/" & row("icon_menu")),
            Dim itemMn As New ToolStripMenuItem() With {.Text = row("menu_caption").ToString(),
                                                        .Image = UILibs.MyResources.GetBitmap(row("icon_menu").ToString()),
                                                        .Tag = New DataMenu() With {.menuId = row("id"),
                                                                                    .dllName = row("dll_name").ToString(),
                                                                                    .ucName = row("uc_name").ToString(),
                                                                                    .iconName = row("icon_name").ToString(),
                                                                                    .acl = currACL}}

            AddHandler itemMn.Click, AddressOf Menu_Click

            parentMenu.DropDownItems.AddRange(New ToolStripItem() {itemMn})

            generateSubMenu(itemMn)

        Next


        'Dim subItem As New ToolStripMenuItem() With {.Text = "Kota", .Tag = 0}
        'itemMn.DropDownItems.AddRange(New ToolStripItem() {subItem})

    End Sub

    Private Sub Menu_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim dataMenu As DataMenu = CType(menuItem.Tag, DataMenu)

        If dataMenu.dllName.ToString().Trim = "" Then Return

        Dim obj As Object = Nothing
        Dim type As Type = Assembly.LoadFrom(dataMenu.dllName & ".dll"). _
                       GetType(dataMenu.dllName & "." & dataMenu.ucName)

        obj = Activator.CreateInstance(type)

        Dim uc As UserControl = DirectCast(obj, UserControl)


        'set ACL role in Uc Tag
        uc.Tag = dataMenu.acl

        'cek if exist control
        If Me.pnMain.Controls.Count > 0 Then
            Me.pnMain.Controls(0).Dispose()
        End If

        Me.pnMain.Controls.Clear()
        Me.pnMain.Controls.Add(uc)
        uc.Dock = DockStyle.Fill


    End Sub

End Class
