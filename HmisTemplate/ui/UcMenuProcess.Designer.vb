<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcMenuProcess
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
        Me.pnMain = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'subMenu
        '
        Me.subMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.subMenu.Location = New System.Drawing.Point(0, 0)
        Me.subMenu.Name = "subMenu"
        Me.subMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.subMenu.Size = New System.Drawing.Size(559, 24)
        Me.subMenu.TabIndex = 0
        Me.subMenu.Text = "MenuStrip1"
        '
        'pnMain
        '
        Me.pnMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMain.Location = New System.Drawing.Point(0, 24)
        Me.pnMain.Name = "pnMain"
        Me.pnMain.Size = New System.Drawing.Size(559, 330)
        Me.pnMain.TabIndex = 1
        '
        'UcMenuProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnMain)
        Me.Controls.Add(Me.subMenu)
        Me.Name = "UcMenuProcess"
        Me.Size = New System.Drawing.Size(559, 354)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents subMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents pnMain As System.Windows.Forms.Panel

End Class
