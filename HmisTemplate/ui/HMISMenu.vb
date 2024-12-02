Imports Ninject
Imports DbLibs
Imports System.Reflection
Imports UILibs
Imports UtilsLibs


Public Class HMISMenu
    Implements TCPClient.IEvent

    Private kernel As IKernel = KernelEngine.ClsKernel.createKernel()
    Dim db As ClsDbase

    Dim tcList As List(Of model.TCode)

    Dim menuDao As dao.MenuDao
    Dim tCodeDao As dao.TransCodeDao

    Dim tCode As New TransCode()
    Dim isFoundTCode As Boolean = False

    Dim CommunicationObject As TCPClient.TCPHelper
    Dim Endpoint As String = String.Empty

    'run text
    Dim kiri As Integer = 0
    Dim panjangText As Integer = 0
    Dim strText As String = String.Empty
    Dim strCek As String = String.Empty
    Dim g As Graphics

    Public Sub New()
        db = kernel.Get(Of ClsDbase)()

        Me.menuDao = kernel.Get(Of dao.MenuDao)()
        Me.menuDao.db = db

        Me.tCodeDao = kernel.Get(Of dao.TransCodeDao)()
        Me.tCodeDao.db = db

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'pnToolLeft.BackColor = Color.FromArgb(248, 248, 248)
        pnToolLeft.BackColor = Color.FromArgb(216, 239, 213)
        'pnToolLeft.BackColor = Color.FromArgb(24, 176, 125)
        toolMenuTop.BackColor = Color.FromArgb(131, 130, 161)

    End Sub

    Private Sub HMISMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'title version
        Me.Text = "HMIS v 4.3.278"
        'Me.Text = "HMIS v 4.3 TEST TRIAL-"

        toolAccount.ForeColor = Color.White
        toolExit.ForeColor = Color.White
        btnSearch.Image = UILibs.MyResources.GetBitmap("Search online.png")

        'load tcode data
        Me.tcList = Me.tCodeDao.TransCodeCollections()
        Me.tCode.SetAutoCompleteText(txtTransCode, Me.tcList, Me)
        txtTransCode.ToolTipText = "Press ctrl+T to see Transaction Code List"

        'makeBackgroundMainMenu(0)
        Dim pn As New Panel()
        pn.BackgroundImage = UILibs.MyResources.GetBitmap("rsdk.png")    'Image.FromFile("images/main menu.png")
        pn.BackgroundImageLayout = ImageLayout.Stretch
        Me.Controls.Add(pn)
        pn.Dock = DockStyle.Fill
        pn.BringToFront()
        pn.Controls.Add(TabKontrol)
        'AddHandler pn.MouseEnter, AddressOf PanelMenu_MouseEnter

        Dim frmFreez As New FreezeLogin()

        If frmFreez.ShowDialog() = Windows.Forms.DialogResult.OK Then

            'create proxy channel notif
            Me.InitChannel()

            'reset tab kontrol
            pn.BackgroundImage = UILibs.MyResources.GetBitmap("rsdk.png")  'Image.FromFile("images/main menu2.png")
            Me.TabKontrol.TabPages.Clear()

            'set menu
            Me.generateMenu()

            ToolStripStatusLabel1.Text = Format(Now, "MMM/dd/yyyy")
            'ToolStripStatusLabel1.Text = String.Format("{0} {1} {2}", Now.Date.ToString("yyyy"),
            '                                                          Now.Date.ToString("MMM"),
            '                                                          Now.Date.ToString("dd"))

            footerUser.Text = String.Format("USER : {0}", SessionInfo.un.ToUpper())

            'MsgBox("role:" & SessionInfo.ModSessi.roleName)

            If SessionInfo.ModSessi.roleName = "super" Then
                toolCustomizeMenu.Visible = True
            Else
                toolCustomizeMenu.Visible = False
            End If

            txtTransCode.Focus()

            Dim aProp As PropertyInfo = GetType(PictureBox).GetProperty("DoubleBuffered", BindingFlags.NonPublic Or BindingFlags.Instance)
            aProp.SetValue(pBoxText, True, Nothing)

            'play run text
            Me.RunText()


            Return

        End If

        Application.Exit()


        'set login info

        'SessionInfo.ModSessi.uid = 1
        'SessionInfo.ModSessi.un = "dale"
        'SessionInfo.ModSessi.roleId = 1
        'SessionInfo.ModSessi.roleName = "admin"


    End Sub

    Private Sub HMISMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Z AndAlso e.Modifiers = Keys.Control Then
            txtTransCode.Focus()
        End If

        If e.KeyCode = Keys.T AndAlso e.Modifiers = Keys.Control Then
            Dim frm As New FrmTransCode()
            frm.ShowDialog()
        End If

    End Sub

    Sub generateMenu()

        'reset tool Modeule
        toolModule.Items.Clear()

        Dim dtModule As DataTable = Me.menuDao.getModuleSysByRoleId(SessionInfo.ModSessi.roleId)
        toolModule.Padding = New Padding(5, 0, 0, 0)

        For Each row As DataRow In dtModule.Rows
            Dim toolButton As New System.Windows.Forms.ToolStripButton()
            toolButton.Tag = row("id")
            'toolButton.Image = Image.FromFile("images/" & row("icon_name").ToString())
            toolButton.Image = UILibs.MyResources.GetBitmap(row("icon_name").ToString())
            toolButton.TextAlign = ContentAlignment.MiddleLeft
            toolButton.ImageAlign = ContentAlignment.MiddleLeft
            toolButton.Text = row("module_name").ToString()
            toolButton.Padding = New Padding(10, 10, 0, 0)
            AddHandler toolButton.Click, AddressOf Module_Click
            toolModule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {toolButton})
        Next
        'menambah tombol untuk regulasi rsdk, semua user bisa mengakses
        Dim _toolButton As New System.Windows.Forms.ToolStripButton()
        _toolButton.Tag = "0"
        _toolButton.Image = UILibs.MyResources.GetBitmap("New clip art.png")
        _toolButton.TextAlign = ContentAlignment.MiddleLeft
        _toolButton.ImageAlign = ContentAlignment.MiddleLeft
        _toolButton.Text = "REGULASI"
        _toolButton.Padding = New Padding(10, 10, 0, 0)
        AddHandler _toolButton.Click, AddressOf Skip_Module_Click
        toolModule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {_toolButton})
    End Sub

    Private Sub Module_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim toolbtn As ToolStripButton = CType(sender, ToolStripButton)

        Dim frm As New FrmProcess()

        frm.menuDao = Me.menuDao
        frm.moduleId = CInt(toolbtn.Tag)

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'MsgBox(frm.processId)
            Me.runUserControl(frm.processId, frm.processName)
        End If

    End Sub

    Private Sub Skip_Module_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.runUserControl(73, "REGULASI")
    End Sub

    Private Sub runUserControl(ByVal processId As Integer, ByVal procName As String)
        'Dim obj As Object = Nothing
        'Dim type As Type = Assembly.LoadFrom("PISModule.dll"). _
        '               GetType("PISModule.UcPatient")

        'obj = Activator.CreateInstance(type)

        'Dim uc As UserControl = DirectCast(obj, UserControl)

        Dim uc As New UcMenuProcess()
        uc.processId = processId

        Dim tabPage As New TabPage()
        tabPage.Text = procName.ToUpper() & "   "

        tabPage.ImageIndex = 0
        tabPage.Controls.Add(uc)
        uc.Dock = DockStyle.Fill

        TabKontrol.TabPages.Add(tabPage)
        TabKontrol.SelectedIndex = TabKontrol.TabCount - 1
    End Sub

    Private Sub TabKontrol_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Dim g As Graphics = e.Graphics()
        Dim font As Font = TabKontrol.Font
        Dim brush As New SolidBrush(Color.Beige)
        Dim itemRect As Rectangle = TabKontrol.GetTabRect(e.Index)
        Dim tabTextArea As RectangleF = RectangleF.op_Implicit(TabKontrol.GetTabRect(e.Index))

        If TabKontrol.SelectedIndex = e.Index Then
            font = New Font(font, FontStyle.Italic)
            brush = New SolidBrush(Color.Azure)
            g.FillRectangle(Brushes.Blue, itemRect)
        End If

        g.DrawString(TabKontrol.TabPages(e.Index).Text, font, brush, tabTextArea)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        'If TabKontrol.SelectedIndex = 0 Or TabKontrol.SelectedIndex = -1 Then
        If TabKontrol.SelectedIndex < 1 Then
            Return
        End If
        TabKontrol.SelectedIndex = TabKontrol.SelectedIndex - 1
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        TabKontrol.SelectedIndex = TabKontrol.SelectedIndex + 1
    End Sub

    Private Sub toolCustomizeMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolCustomizeMenu.Click
        Dim uc As New UcCustomMenu()


        Dim tabPage As New TabPage()
        tabPage.Text = "Control Panel   ".ToUpper()

        tabPage.ImageIndex = 0
        tabPage.Controls.Add(uc)
        uc.Dock = DockStyle.Fill

        TabKontrol.TabPages.Add(tabPage)
        TabKontrol.SelectedIndex = TabKontrol.TabCount - 1
    End Sub

    Private Sub toolLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolLogOut.Click

        TabKontrol.TabPages.Clear()

        HMISMenu_Load(sender, e)

        'Dim frm As New FreezeLogin()

        'frm.Show()
        ''    'FrmLogin.Visible = True
        'Me.Close()
    End Sub

    Private Sub HMISMenu_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim pathTempFolder As String = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\TEMP FILE\"
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(pathTempFolder)
                System.IO.File.Delete(foundFile)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub toolExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolExit.Click

        If MsgBox("Anda yakin akan keluar ?", MsgBoxStyle.OkCancel, "Konfirmasi") = MsgBoxResult.Cancel Then Return

        Application.Exit()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        TabKontrol.TabPages.Clear()

        HMISMenu_Load(sender, e)
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        Dim dlg As New DlgChangePwd()

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then

        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        'validasi
        If txtTransCode.Text.Trim = String.Empty Then Return

        Dim find = From p In Me.tcList
                   Where p.TransCode.Equals(txtTransCode.Text.Trim())
                   Select p

        If find.Count = 0 Then Return


        Me.runUserControl(find(0).ProcessId, find(0).ProcessName)

        'set control to page
        Dim tabPage As TabPage = TabKontrol.SelectedTab
        Dim subMenu As MenuStrip = tabPage.Controls("UcMenuProcess").Controls("subMenu")
        Dim pnMain As Panel = tabPage.Controls("UcMenuProcess").Controls("pnMain")

        Dim dm As New DataMenu()

        Me.isFoundTCode = False
        Me.AktifMenu(subMenu.Items, find(0).UcName, dm)

        'validasi ACL
        Dim acl As SessionInfo.ACLUser = dm.acl

        If acl.allowView = False Then

            TabKontrol.TabPages.Remove(tabPage)

            MessageBox.Show("Anda tidak mempunyai hak akses pada form ini !", "Pesan",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            txtTransCode.Clear()
            find = Nothing

            Return
        End If

        'create UI for this tCode
        Dim obj As Object = Nothing
        Dim type As Type = Assembly.LoadFrom(dm.dllName & ".dll"). _
                       GetType(dm.dllName & "." & dm.ucName)

        obj = Activator.CreateInstance(type)

        Dim uc As UserControl = DirectCast(obj, UserControl)


        'set ACL role in Uc Tag
        uc.Tag = dm.acl

        'cek if exist control
        If pnMain.Controls.Count > 0 Then
            pnMain.Controls(0).Dispose()
        End If

        pnMain.Controls.Clear()
        pnMain.Controls.Add(uc)
        uc.Dock = DockStyle.Fill


        txtTransCode.Clear()
        find = Nothing

    End Sub

    Private Sub txtTransCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(sender, e)
        End If

    End Sub

    Private Sub AktifMenu(ByVal items As ToolStripItemCollection, ByVal ucName As String, ByRef dm As DataMenu)

        Dim dmRecur As DataMenu

        For Each itm As ToolStripMenuItem In items

            dmRecur = CType(itm.Tag, DataMenu)

            If dmRecur.ucName = ucName Then

                dm = dmRecur
                Me.isFoundTCode = True
                Return

            End If

            If Me.isFoundTCode = False Then
                AktifMenu(itm.DropDown.Items, ucName, dm)
            Else
                Return
            End If

        Next

    End Sub

    Private Sub mnuWebAccount_Click(sender As System.Object, e As System.EventArgs) Handles mnuWebAccount.Click

        System.Diagnostics.Process.Start("iexplore.exe", Me.menuDao.GetLinkAddrWebDokter())

    End Sub

    Private Sub mnuVerifyAccount_Click(sender As System.Object, e As System.EventArgs) Handles mnuVerifyAccount.Click

        Dim dlg As New DlgVerifyAccount()

        dlg.ShowDialog()

        dlg = Nothing

    End Sub

    Private Sub mnuInformation_Click(sender As System.Object, e As System.EventArgs) Handles mnuInformation.Click
        Dim dlg As New DlgInfo()

        dlg.ShowDialog()

        dlg = Nothing

    End Sub

#Region "NOTIFIKASI APLIKASI--------------------------------------------------------------------------------"

    Sub InitChannel()
        Try
            Endpoint = System.Configuration.ConfigurationManager.AppSettings("EndpointAddress").ToString()

            CommunicationObject = New TCPClient.TCPHelper()
            CommunicationObject.MakeClient(Endpoint, Me)
            CommunicationObject.Subscribe()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub ShowNotifikasi(subject As String, bodyMsg As String)

        PopupNotifier1.TitleText = subject
        PopupNotifier1.ContentText = bodyMsg
        PopupNotifier1.ShowCloseButton = True
        PopupNotifier1.ShowOptionsButton = False
        'PopupNotifier1.ShowGrip = True
        PopupNotifier1.Delay = 3000
        PopupNotifier1.AnimationInterval = 10
        PopupNotifier1.AnimationDuration = 1000
        PopupNotifier1.TitlePadding = New Padding(5)
        PopupNotifier1.ContentPadding = New Padding(5)
        PopupNotifier1.ImagePadding = New Padding(5)
        PopupNotifier1.Scroll = True
        PopupNotifier1.Image = UILibs.MyResources.GetBitmap("Danger.png")
        PopupNotifier1.BodyColor = Color.FromArgb(128, 128, 255)
        Dim f As New Font("Verdana", 12)

        PopupNotifier1.TitleFont = New Font("Verdana", 12, FontStyle.Bold)

        PopupNotifier1.Popup()

    End Sub

    Public Sub OnEvent(e As AlertData) Implements TCPClient.IEvent.OnEvent
        If Not e Is Nothing Then

            Try
                Dim msg() As String = e.Description.Split("#")

                If SessionInfo.notif.Tag.ToString().ToUpper = msg(0).ToUpper() Then
                    Me.ShowNotifikasi(msg(1), msg(2))

                    'play sound
                    Me.PlaySystemSound()

                End If

            Catch ex As Exception
            End Try

        End If
    End Sub

    Sub PlaySystemSound()
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
    End Sub

#End Region

    Sub RunText()

        Me.kiri = Me.Width
        Me.panjangText = Me.genRunText().Length * 8.5
        Me.strText = Me.genRunText()

        Me.g = pBoxText.CreateGraphics()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)

        'tmr run text
        TmrRunText.Enabled = True
        TmrRunText.Interval = 100
        TmrRunText.Start()

        'tmr cek text change
        tmrCekStr.Enabled = True
        tmrCekStr.Interval = 180000
        tmrCekStr.Start()

    End Sub

    Function genRunText() As String
        Dim dt As DataTable
        Dim str As String = String.Empty

        Try
            dt = Me.menuDao.GetRunTextBody()

            If dt.Rows.Count > 0 Then
                str = dt.Rows(0)("body_text").ToString().Trim()
                TmrRunText.Interval = dt.Rows(0)("speed")
            End If

        Catch ex As Exception
        End Try

        dt = Nothing

        Dim sb As New System.Text.StringBuilder()

        For j = 1 To 2
            sb.Append(str)

            For i As Integer = 1 To 80
                sb.Append(" ")
            Next

        Next

        Return sb.ToString().ToUpper()
    End Function

    Private Sub TmrRunText_Tick(sender As System.Object, e As System.EventArgs) Handles TmrRunText.Tick
        pBoxText.Refresh()

        kiri -= 2

        g.DrawString(Me.strText, New Font("Courier New", 12, FontStyle.Bold), Brushes.WhiteSmoke, New PointF(Me.kiri, 5))

        'Me.Text = String.Format("{0} - {1}", Me.Width, Me.kiri)

        If Me.kiri <= -Me.panjangText Then
            Me.kiri = Me.Width
        End If
    End Sub

    Private Sub tmrCekStr_Tick(sender As Object, e As System.EventArgs) Handles tmrCekStr.Tick
        Me.strCek = Me.genRunText()

        If Me.strText <> Me.strCek Then
            Me.strText = Me.strCek
            Me.panjangText = Me.strText.Length * 8.5
        End If
    End Sub

    Private Sub MnuPhoneBook_Click(sender As System.Object, e As System.EventArgs) Handles MnuPhoneBook.Click
        Dim webAddress As String = "http://172.16.7.35:8080/phonebook/ext"
        Process.Start(webAddress)
    End Sub

End Class
