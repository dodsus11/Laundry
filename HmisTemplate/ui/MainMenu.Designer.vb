<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.TopStrip = New System.Windows.Forms.ToolStrip()
        Me.pnLeft = New System.Windows.Forms.Panel()
        Me.ToolNavigate = New System.Windows.Forms.ToolStrip()
        Me.HeaderMenu = New System.Windows.Forms.MenuStrip()
        Me.UtilityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnRoles = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pnCenter = New System.Windows.Forms.Panel()
        Me.TabKontrol = New UILibs.CustomTabControl()
        Me.pnLeft.SuspendLayout()
        Me.HeaderMenu.SuspendLayout()
        Me.pnCenter.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopStrip
        '
        Me.TopStrip.AutoSize = False
        Me.TopStrip.BackColor = System.Drawing.Color.Transparent
        Me.TopStrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TopStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.TopStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopStrip.Name = "TopStrip"
        Me.TopStrip.Size = New System.Drawing.Size(180, 471)
        Me.TopStrip.TabIndex = 0
        Me.TopStrip.Text = "ToolStrip1"
        '
        'pnLeft
        '
        Me.pnLeft.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pnLeft.Controls.Add(Me.TopStrip)
        Me.pnLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnLeft.Name = "pnLeft"
        Me.pnLeft.Size = New System.Drawing.Size(180, 471)
        Me.pnLeft.TabIndex = 1
        '
        'ToolNavigate
        '
        Me.ToolNavigate.Location = New System.Drawing.Point(180, 24)
        Me.ToolNavigate.Name = "ToolNavigate"
        Me.ToolNavigate.Size = New System.Drawing.Size(565, 25)
        Me.ToolNavigate.TabIndex = 4
        Me.ToolNavigate.Text = "ToolStrip1"
        '
        'HeaderMenu
        '
        Me.HeaderMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilityToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.HeaderMenu.Location = New System.Drawing.Point(180, 0)
        Me.HeaderMenu.Name = "HeaderMenu"
        Me.HeaderMenu.Size = New System.Drawing.Size(565, 24)
        Me.HeaderMenu.TabIndex = 6
        '
        'UtilityToolStripMenuItem
        '
        Me.UtilityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnConfig, Me.MnUsers, Me.MnRoles})
        Me.UtilityToolStripMenuItem.Name = "UtilityToolStripMenuItem"
        Me.UtilityToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilityToolStripMenuItem.Text = "Utility"
        '
        'MnConfig
        '
        Me.MnConfig.Name = "MnConfig"
        Me.MnConfig.Size = New System.Drawing.Size(144, 22)
        Me.MnConfig.Text = "Menu Config"
        '
        'MnUsers
        '
        Me.MnUsers.Name = "MnUsers"
        Me.MnUsers.Size = New System.Drawing.Size(144, 22)
        Me.MnUsers.Text = "Users"
        '
        'MnRoles
        '
        Me.MnRoles.Name = "MnRoles"
        Me.MnRoles.Size = New System.Drawing.Size(144, 22)
        Me.MnRoles.Text = "Roles"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close_x.gif")
        '
        'pnCenter
        '
        Me.pnCenter.BackColor = System.Drawing.Color.Transparent
        Me.pnCenter.BackgroundImage = UtilsLibs.My.Resources.MyFolder.kariadi_Modifikasi    'Global.HmisTemplate.My.Resources.Resources.kariadi_Modifikasi
        Me.pnCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnCenter.Controls.Add(Me.TabKontrol)
        Me.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCenter.Location = New System.Drawing.Point(180, 49)
        Me.pnCenter.Name = "pnCenter"
        Me.pnCenter.Size = New System.Drawing.Size(565, 422)
        Me.pnCenter.TabIndex = 10
        '
        'TabKontrol
        '
        Me.TabKontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabKontrol.ImageList = Me.ImageList1
        Me.TabKontrol.ItemSize = New System.Drawing.Size(0, 15)
        Me.TabKontrol.Location = New System.Drawing.Point(0, 0)
        Me.TabKontrol.Name = "TabKontrol"
        Me.TabKontrol.Padding = New System.Drawing.Point(9, 0)
        Me.TabKontrol.SelectedIndex = 0
        Me.TabKontrol.Size = New System.Drawing.Size(565, 422)
        Me.TabKontrol.TabIndex = 8
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(745, 471)
        Me.Controls.Add(Me.pnCenter)
        Me.Controls.Add(Me.ToolNavigate)
        Me.Controls.Add(Me.HeaderMenu)
        Me.Controls.Add(Me.pnLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.HeaderMenu
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnLeft.ResumeLayout(False)
        Me.HeaderMenu.ResumeLayout(False)
        Me.HeaderMenu.PerformLayout()
        Me.pnCenter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TopStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents pnLeft As System.Windows.Forms.Panel
    Friend WithEvents ToolNavigate As System.Windows.Forms.ToolStrip
    Friend WithEvents HeaderMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents UtilityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnRoles As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabKontrol As UILibs.CustomTabControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents pnCenter As System.Windows.Forms.Panel
End Class
