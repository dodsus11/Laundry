<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HMISMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HMISMenu))
        Me.pnCenter = New System.Windows.Forms.Panel()
        Me.TabKontrol = New UILibs.CustomTabControl()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.toolMenuTop = New System.Windows.Forms.ToolStrip()
        Me.txtTransCode = New System.Windows.Forms.ToolStripTextBox()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolExit = New System.Windows.Forms.ToolStripButton()
        Me.toolLogOut = New System.Windows.Forms.ToolStripButton()
        Me.toolCustomizeMenu = New System.Windows.Forms.ToolStripButton()
        Me.toolAccount = New System.Windows.Forms.ToolStripDropDownButton()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWebAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVerifyAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.footerUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.C1CommandDock1 = New C1.Win.C1Command.C1CommandDock()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.pnToolLeft = New System.Windows.Forms.Panel()
        Me.toolModule = New System.Windows.Forms.ToolStrip()
        Me.PopupNotifier1 = New NotificationWindow.PopupNotifier()
        Me.pBoxText = New System.Windows.Forms.PictureBox()
        Me.TmrRunText = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCekStr = New System.Windows.Forms.Timer(Me.components)
        Me.MnuPhoneBook = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnCenter.SuspendLayout()
        Me.toolMenuTop.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1CommandDock1.SuspendLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        Me.pnToolLeft.SuspendLayout()
        CType(Me.pBoxText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnCenter
        '
        Me.pnCenter.Controls.Add(Me.TabKontrol)
        Me.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCenter.Location = New System.Drawing.Point(464, 48)
        Me.pnCenter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnCenter.Name = "pnCenter"
        Me.pnCenter.Padding = New System.Windows.Forms.Padding(8)
        Me.pnCenter.Size = New System.Drawing.Size(868, 640)
        Me.pnCenter.TabIndex = 2
        '
        'TabKontrol
        '
        Me.TabKontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabKontrol.ImageList = Me.ImageList1
        Me.TabKontrol.ItemSize = New System.Drawing.Size(0, 21)
        Me.TabKontrol.Location = New System.Drawing.Point(8, 8)
        Me.TabKontrol.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabKontrol.Name = "TabKontrol"
        Me.TabKontrol.Padding = New System.Drawing.Point(9, 0)
        Me.TabKontrol.SelectedIndex = 0
        Me.TabKontrol.Size = New System.Drawing.Size(852, 624)
        Me.TabKontrol.TabIndex = 7
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close_x.gif")
        '
        'toolMenuTop
        '
        Me.toolMenuTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolMenuTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtTransCode, Me.btnSearch, Me.ToolStripButton1, Me.ToolStripButton2, Me.toolExit, Me.toolLogOut, Me.toolCustomizeMenu, Me.toolAccount})
        Me.toolMenuTop.Location = New System.Drawing.Point(0, 0)
        Me.toolMenuTop.Name = "toolMenuTop"
        Me.toolMenuTop.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.toolMenuTop.Size = New System.Drawing.Size(1332, 48)
        Me.toolMenuTop.TabIndex = 3
        Me.toolMenuTop.Text = "ToolStrip1"
        '
        'txtTransCode
        '
        Me.txtTransCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTransCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTransCode.Margin = New System.Windows.Forms.Padding(20, 0, 1, 0)
        Me.txtTransCode.Name = "txtTransCode"
        Me.txtTransCode.Size = New System.Drawing.Size(224, 48)
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 45)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(5, 1, 10, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 45)
        Me.ToolStripButton1.Tag = ""
        Me.ToolStripButton1.Text = "Prev"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolStripButton1.ToolTipText = "Back"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(68, 45)
        Me.ToolStripButton2.Text = "Next"
        Me.ToolStripButton2.ToolTipText = "Next"
        '
        'toolExit
        '
        Me.toolExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.toolExit.Image = CType(resources.GetObject("toolExit.Image"), System.Drawing.Image)
        Me.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolExit.Margin = New System.Windows.Forms.Padding(0, 1, 5, 2)
        Me.toolExit.Name = "toolExit"
        Me.toolExit.Size = New System.Drawing.Size(43, 45)
        Me.toolExit.Text = "&Exit"
        Me.toolExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolLogOut
        '
        Me.toolLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.toolLogOut.Image = CType(resources.GetObject("toolLogOut.Image"), System.Drawing.Image)
        Me.toolLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolLogOut.Margin = New System.Windows.Forms.Padding(10, 1, 10, 2)
        Me.toolLogOut.Name = "toolLogOut"
        Me.toolLogOut.Size = New System.Drawing.Size(69, 45)
        Me.toolLogOut.Text = "&Logoff"
        Me.toolLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.toolLogOut.ToolTipText = "Logoff"
        Me.toolLogOut.Visible = False
        '
        'toolCustomizeMenu
        '
        Me.toolCustomizeMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolCustomizeMenu.Image = CType(resources.GetObject("toolCustomizeMenu.Image"), System.Drawing.Image)
        Me.toolCustomizeMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCustomizeMenu.Name = "toolCustomizeMenu"
        Me.toolCustomizeMenu.Size = New System.Drawing.Size(23, 45)
        '
        'toolAccount
        '
        Me.toolAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.toolAccount.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem, Me.mnuWebAccount, Me.MnuPhoneBook, Me.mnuInformation, Me.mnuVerifyAccount, Me.LogOutToolStripMenuItem})
        Me.toolAccount.Image = CType(resources.GetObject("toolAccount.Image"), System.Drawing.Image)
        Me.toolAccount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolAccount.Name = "toolAccount"
        Me.toolAccount.Size = New System.Drawing.Size(90, 45)
        Me.toolAccount.Text = "Account"
        Me.toolAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'mnuWebAccount
        '
        Me.mnuWebAccount.Name = "mnuWebAccount"
        Me.mnuWebAccount.Size = New System.Drawing.Size(205, 30)
        Me.mnuWebAccount.Text = "Web Account"
        '
        'mnuInformation
        '
        Me.mnuInformation.Name = "mnuInformation"
        Me.mnuInformation.Size = New System.Drawing.Size(205, 30)
        Me.mnuInformation.Text = "Information"
        '
        'mnuVerifyAccount
        '
        Me.mnuVerifyAccount.Name = "mnuVerifyAccount"
        Me.mnuVerifyAccount.Size = New System.Drawing.Size(205, 30)
        Me.mnuVerifyAccount.Text = "Verify Account"
        Me.mnuVerifyAccount.Visible = False
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(205, 30)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.footerUser})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 723)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(21, 0, 2, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1332, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(4, 17)
        '
        'footerUser
        '
        Me.footerUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.footerUser.Name = "footerUser"
        Me.footerUser.Size = New System.Drawing.Size(4, 17)
        '
        'C1CommandDock1
        '
        Me.C1CommandDock1.Controls.Add(Me.C1DockingTab1)
        Me.C1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1CommandDock1.Id = 8
        Me.C1CommandDock1.Location = New System.Drawing.Point(0, 48)
        Me.C1CommandDock1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1CommandDock1.Name = "C1CommandDock1"
        Me.C1CommandDock1.Size = New System.Drawing.Size(464, 640)
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.AutoHiding = True
        Me.C1DockingTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.C1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1DockingTab1.CanAutoHide = True
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.ShowCaption = True
        Me.C1DockingTab1.ShowSingleTab = False
        Me.C1DockingTab1.Size = New System.Drawing.Size(464, 640)
        Me.C1DockingTab1.TabIndex = 1
        Me.C1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.C1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.C1DockingTab1.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.C1DockingTab1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.CaptionVisible = True
        Me.C1DockingTabPage1.Controls.Add(Me.pnToolLeft)
        Me.C1DockingTabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1DockingTabPage1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(0, 1)
        Me.C1DockingTabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(461, 639)
        Me.C1DockingTabPage1.TabForeColor = System.Drawing.Color.MidnightBlue
        Me.C1DockingTabPage1.TabForeColorSelected = System.Drawing.Color.MidnightBlue
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "Menu Utama"
        '
        'pnToolLeft
        '
        Me.pnToolLeft.Controls.Add(Me.toolModule)
        Me.pnToolLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnToolLeft.Location = New System.Drawing.Point(0, 34)
        Me.pnToolLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnToolLeft.Name = "pnToolLeft"
        Me.pnToolLeft.Size = New System.Drawing.Size(461, 605)
        Me.pnToolLeft.TabIndex = 0
        '
        'toolModule
        '
        Me.toolModule.BackColor = System.Drawing.Color.Transparent
        Me.toolModule.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolModule.Location = New System.Drawing.Point(0, 0)
        Me.toolModule.Name = "toolModule"
        Me.toolModule.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.toolModule.Size = New System.Drawing.Size(461, 111)
        Me.toolModule.TabIndex = 0
        Me.toolModule.Text = "ToolStrip1"
        '
        'PopupNotifier1
        '
        Me.PopupNotifier1.AnimationInterval = 20
        Me.PopupNotifier1.ContentFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.PopupNotifier1.ContentText = Nothing
        Me.PopupNotifier1.Image = Nothing
        Me.PopupNotifier1.OptionsMenu = Nothing
        Me.PopupNotifier1.Size = New System.Drawing.Size(400, 100)
        Me.PopupNotifier1.TitleColor = System.Drawing.Color.Red
        Me.PopupNotifier1.TitleFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PopupNotifier1.TitleText = Nothing
        '
        'pBoxText
        '
        Me.pBoxText.BackColor = System.Drawing.SystemColors.Highlight
        Me.pBoxText.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pBoxText.Location = New System.Drawing.Point(0, 688)
        Me.pBoxText.Name = "pBoxText"
        Me.pBoxText.Size = New System.Drawing.Size(1332, 35)
        Me.pBoxText.TabIndex = 4
        Me.pBoxText.TabStop = False
        '
        'TmrRunText
        '
        '
        'tmrCekStr
        '
        '
        'MnuPhoneBook
        '
        Me.MnuPhoneBook.Name = "MnuPhoneBook"
        Me.MnuPhoneBook.Size = New System.Drawing.Size(205, 30)
        Me.MnuPhoneBook.Text = "Phone Book"
        '
        'HMISMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1332, 745)
        Me.Controls.Add(Me.pnCenter)
        Me.Controls.Add(Me.C1CommandDock1)
        Me.Controls.Add(Me.toolMenuTop)
        Me.Controls.Add(Me.pBoxText)
        Me.Controls.Add(Me.StatusStrip1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "HMISMenu"
        Me.Text = "HMIS - v 1.02"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnCenter.ResumeLayout(False)
        Me.toolMenuTop.ResumeLayout(False)
        Me.toolMenuTop.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1CommandDock1.ResumeLayout(False)
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        Me.pnToolLeft.ResumeLayout(False)
        Me.pnToolLeft.PerformLayout()
        CType(Me.pBoxText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnCenter As System.Windows.Forms.Panel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents toolMenuTop As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents toolLogOut As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolCustomizeMenu As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabKontrol As UILibs.CustomTabControl
    Friend WithEvents C1CommandDock1 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents pnToolLeft As System.Windows.Forms.Panel
    Friend WithEvents toolModule As System.Windows.Forms.ToolStrip
    Friend WithEvents footerUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolAccount As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents GantiPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTransCode As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuWebAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVerifyAccount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInformation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PopupNotifier1 As NotificationWindow.PopupNotifier
    Friend WithEvents pBoxText As System.Windows.Forms.PictureBox
    Friend WithEvents TmrRunText As System.Windows.Forms.Timer
    Friend WithEvents tmrCekStr As System.Windows.Forms.Timer
    Friend WithEvents MnuPhoneBook As System.Windows.Forms.ToolStripMenuItem
End Class
