Imports Ninject
Imports DbLibs
Imports HmisTemplate.dao
Imports System.Reflection

Public Class MainMenu

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Private db As ClsDbase
    Private menuDao As MenuDao

    Public Sub New()

        db = kernel.Get(Of ClsDbase)()
        menuDao = kernel.Get(Of MenuDao)()
        menuDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MainMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub MainMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TopStrip.Renderer = New Renderers.WindowsVistaRenderer()
        TopStrip.BackColor = Color.Transparent
        pnLeft.BackColor = Color.FromArgb(227, 237, 250)
        'HeaderMenu.Renderer = New Renderers.WindowsVistaRenderer()
        generateMenu()

    End Sub

    Private Sub generateMenu()

        Dim dtMenu As DataTable = Me.menuDao.getModuleSys()

        For Each row As DataRow In dtMenu.Rows
            Dim toolButton As New System.Windows.Forms.ToolStripButton()
            toolButton.Tag = row("id")
            toolButton.Image = Image.FromFile("images/" & row("icon").ToString())
            toolButton.TextAlign = ContentAlignment.MiddleLeft
            toolButton.ImageAlign = ContentAlignment.MiddleLeft
            toolButton.Text = row("caption").ToString()
            AddHandler toolButton.Click, AddressOf MenuStrip_Click
            TopStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {toolButton})
        Next


    End Sub

    Private Sub MenuStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




        Dim tool As ToolStripItem

        If TypeOf sender Is ToolStripLabel Then
            tool = CType(sender, ToolStripLabel)
        ElseIf TypeOf sender Is ToolStripButton Then
            tool = CType(sender, ToolStripButton)
        End If

        'cek if exist userControl in db
        Dim dtCurrMenu As DataTable = menuDao.getMenuByID(CInt(tool.Tag))

        If dtCurrMenu.Rows.Count > 0 Then
            If Not IsDBNull(dtCurrMenu.Rows(0)("dll_name")) Then
                'hide submenu
                'Me.ToolSubMenu.Hide()

                Dim obj As Object = Nothing
                Dim type As Type = Assembly.LoadFrom(dtCurrMenu.Rows(0)("dll_name") & ".dll"). _
                               GetType(dtCurrMenu.Rows(0)("dll_name") & "." & dtCurrMenu.Rows(0)("form_name"))
                obj = Activator.CreateInstance(type)
                Dim uc As UserControl = DirectCast(obj, UserControl)

                Dim tabPage As New TabPage()
                tabPage.Text = dtCurrMenu.Rows(0)("caption").ToString() & " "
                tabPage.ImageIndex = 0
                tabPage.Controls.Add(uc)
                uc.Dock = DockStyle.Fill

                TabKontrol.TabPages.Add(tabPage)
                TabKontrol.SelectedIndex = TabKontrol.TabCount - 1


                'Dim frm As Form = CType(obj, Form)
                'frm.MdiParent = Me
                'frm.Show()
                Return
            End If

        End If



        'Dim tool As ToolStripButton = CType(sender, ToolStripButton)

        'clear toolSub Menu
        'Me.ToolSubMenu.Items.Clear()
        Me.TopStrip.Items.Clear()

        'Dim dtSubMenu As DataTable = Me.menuDao.getSubMenu(CInt(tool.Tag))
        Dim dtSubMenu As DataTable = Me.menuDao.getChildMenuByParentId(CInt(tool.Tag))

        For Each row As DataRow In dtSubMenu.Rows
            Dim toolLabel As New System.Windows.Forms.ToolStripButton()
            toolLabel.Tag = row("id")
            toolLabel.Font = New Font("Arial", 9)

            'toolLabel.LinkColor = Color.FromArgb(56, 174, 74)
            toolLabel.Margin = New Padding(10, 2, 0, 7)
            'toolLabel.IsLink = True
            toolLabel.Image = Image.FromFile("images/" & row("icon").ToString())
            toolLabel.TextAlign = ContentAlignment.MiddleLeft
            toolLabel.ImageAlign = ContentAlignment.MiddleLeft
            toolLabel.Text = row("caption").ToString()
            'AddHandler toolLabel.Click, AddressOf SubMenuStrip_Click
            'ToolSubMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {toolLabel})

            AddHandler toolLabel.Click, AddressOf MenuStrip_Click
            TopStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {toolLabel})
        Next

        'make path navigation
        Me.makePath(CInt(tool.Tag), tool.Text)

        'show toolSubMenu
        ' Me.ToolSubMenu.Show()
    End Sub

    'Private Sub SubMenuStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim tool As ToolStripLabel = CType(sender, ToolStripLabel)


    '    Dim dtCurrMenu As DataTable = menuDao.getMenuByID(CInt(tool.Tag))

    '    If Not IsDBNull(dtCurrMenu.Rows(0)("dll_name")) Then
    '        'hide submenu
    '        Me.ToolSubMenu.Hide()

    '        Dim obj As Object = Nothing
    '        Dim type As Type = Assembly.LoadFrom(dtCurrMenu.Rows(0)("dll_name") & ".dll"). _
    '                       GetType(dtCurrMenu.Rows(0)("dll_name") & "." & dtCurrMenu.Rows(0)("form_name"))
    '        obj = Activator.CreateInstance(type)
    '        Dim frm As Form = CType(obj, Form)
    '        frm.MdiParent = Me
    '        frm.Show()
    '        Return
    '    End If

    '    Dim dtSubMenu As DataTable = Me.menuDao.getChildMenuByParentId(CInt(tool.Tag))

    '    'clear toolSub Menu
    '    Me.ToolSubMenu.Items.Clear()

    '    For Each row As DataRow In dtSubMenu.Rows
    '        Dim toolLabel As New System.Windows.Forms.ToolStripLabel()
    '        toolLabel.Tag = row("id")
    '        toolLabel.Font = New Font("Arial", 9)
    '        toolLabel.Margin = New Padding(10, 2, 0, 7)
    '        toolLabel.LinkColor = Color.FromArgb(56, 174, 74)

    '        toolLabel.IsLink = True
    '        toolLabel.Image = Image.FromFile("images/" & row("icon").ToString())
    '        toolLabel.TextAlign = ContentAlignment.MiddleLeft
    '        toolLabel.ImageAlign = ContentAlignment.MiddleLeft
    '        toolLabel.Text = row("caption").ToString()
    '        AddHandler toolLabel.Click, AddressOf SubMenuStrip_Click
    '        ToolSubMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {toolLabel})
    '    Next

    '    'make path navigation
    '    Me.makePath(CInt(tool.Tag), tool.Text)

    'End Sub

    Private Sub makePath(ByVal menuId As Integer, ByVal menuText As String)
        Try


            ''clear path navigation
            Me.ToolNavigate.Items.Clear()

            If menuId <> 0 Then
                'make home label navigation
                Dim rootLabel As New ToolStripLabel()
                rootLabel.Text = "Home"
                rootLabel.IsLink = True
                rootLabel.Tag = 0
                Me.ToolNavigate.Items.AddRange(New ToolStripItem() {rootLabel})
                AddHandler rootLabel.Click, AddressOf PathNavigate_Click

                Dim toolSaparator1 As New ToolStripLabel()
                toolSaparator1.Text = ""
                'toolSaparator.Size = New System.Drawing.Size(6, 25)
                toolSaparator1.Image = Image.FromFile("images/Right_Arrow.png")
                Me.ToolNavigate.Items.AddRange(New ToolStripItem() {toolSaparator1})

            End If



            Dim path As New List(Of model.Menu)
            path = Me.menuDao.GetPathMenuById(menuId, menuText)

            If path.Count > 0 Then
                For i As Integer = path.Count - 1 To 0 Step -1
                    Dim toolLabel As New ToolStripLabel()
                    toolLabel.Text = path(i).menuText
                    toolLabel.IsLink = True
                    toolLabel.Tag = path(i).menuId
                    Me.ToolNavigate.Items.AddRange(New ToolStripItem() {toolLabel})
                    AddHandler toolLabel.Click, AddressOf PathNavigate_Click

                    If i > 0 Then
                        Dim toolSaparator As New ToolStripLabel()
                        toolSaparator.Text = ""
                        'toolSaparator.Size = New System.Drawing.Size(6, 25)
                        toolSaparator.Image = Image.FromFile("images/Right_Arrow.png")
                        Me.ToolNavigate.Items.AddRange(New ToolStripItem() {toolSaparator})

                    End If

                Next
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub PathNavigate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'show toolSubMenu
        'Me.ToolSubMenu.Show()
        ' SubMenuStrip_Click(sender, e)
        MenuStrip_Click(sender, e)
    End Sub

    Private Sub MnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnConfig.Click
        'Me.ToolSubMenu.Hide()

        Dim frm As New FrmMenuConfig()
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub MnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnUsers.Click
        'Dim uc As New UcUsers()

        'Dim tabPage As New TabPage()
        'tabPage.Text = "User List "
        'tabPage.ImageIndex = 0
        'tabPage.Controls.Add(uc)
        'uc.Dock = DockStyle.Fill


        'TabKontrol.TabPages.Add(tabPage)
        'TabKontrol.SelectedIndex = TabKontrol.TabCount - 1


    End Sub

  
End Class