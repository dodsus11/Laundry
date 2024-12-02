<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcCustomMenu
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.subMenu = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoleListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoleProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnCenter = New System.Windows.Forms.Panel()
        Me.subMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'subMenu
        '
        Me.subMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.subMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ControlToolStripMenuItem})
        Me.subMenu.Location = New System.Drawing.Point(0, 0)
        Me.subMenu.Name = "subMenu"
        Me.subMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.subMenu.Size = New System.Drawing.Size(591, 24)
        Me.subMenu.TabIndex = 1
        Me.subMenu.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserListToolStripMenuItem, Me.RoleListToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.MenuToolStripMenuItem.Text = "User Role"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'RoleListToolStripMenuItem
        '
        Me.RoleListToolStripMenuItem.Name = "RoleListToolStripMenuItem"
        Me.RoleListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RoleListToolStripMenuItem.Text = "Role List"
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlListToolStripMenuItem, Me.ProcessToolStripMenuItem, Me.RoleProcessToolStripMenuItem})
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ControlToolStripMenuItem.Text = "Control"
        '
        'ControlListToolStripMenuItem
        '
        Me.ControlListToolStripMenuItem.Name = "ControlListToolStripMenuItem"
        Me.ControlListToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ControlListToolStripMenuItem.Text = "Control List"
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.ProcessToolStripMenuItem.Text = "Process"
        '
        'RoleProcessToolStripMenuItem
        '
        Me.RoleProcessToolStripMenuItem.Name = "RoleProcessToolStripMenuItem"
        Me.RoleProcessToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.RoleProcessToolStripMenuItem.Text = "Role Process"
        '
        'pnCenter
        '
        Me.pnCenter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCenter.Location = New System.Drawing.Point(0, 24)
        Me.pnCenter.Name = "pnCenter"
        Me.pnCenter.Size = New System.Drawing.Size(591, 327)
        Me.pnCenter.TabIndex = 2
        '
        'UcCustomMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.Controls.Add(Me.pnCenter)
        Me.Controls.Add(Me.subMenu)
        Me.Name = "UcCustomMenu"
        Me.Size = New System.Drawing.Size(591, 351)
        Me.subMenu.ResumeLayout(False)
        Me.subMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents subMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoleListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoleProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnCenter As System.Windows.Forms.Panel

End Class
