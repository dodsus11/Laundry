<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserAdd))
        Me.btnSaveTemp = New UILibs.BtnSaveTemplate()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolUsername = New System.Windows.Forms.ToolStripLabel()
        Me.toolRole = New System.Windows.Forms.ToolStripLabel()
        Me.CenterPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSaveTemp
        '
        Me.btnSaveTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnSaveTemp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSaveTemp.Location = New System.Drawing.Point(0, 343)
        Me.btnSaveTemp.Name = "btnSaveTemp"
        Me.btnSaveTemp.Size = New System.Drawing.Size(619, 54)
        Me.btnSaveTemp.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 343)
        Me.Panel1.TabIndex = 9
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.toolUsername, Me.toolRole})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(5, 0, 1, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(152, 64)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Gray
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(145, 15)
        Me.ToolStripLabel1.Text = "Select Page "
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        'toolUsername
        '
        Me.toolUsername.Image = CType(resources.GetObject("toolUsername.Image"), System.Drawing.Image)
        Me.toolUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolUsername.IsLink = True
        Me.toolUsername.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.toolUsername.LinkColor = System.Drawing.Color.Black
        Me.toolUsername.Name = "toolUsername"
        Me.toolUsername.Size = New System.Drawing.Size(145, 16)
        Me.toolUsername.Text = "General"
        Me.toolUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'toolRole
        '
        Me.toolRole.Image = CType(resources.GetObject("toolRole.Image"), System.Drawing.Image)
        Me.toolRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolRole.IsLink = True
        Me.toolRole.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.toolRole.LinkColor = System.Drawing.Color.Black
        Me.toolRole.Name = "toolRole"
        Me.toolRole.Size = New System.Drawing.Size(145, 16)
        Me.toolRole.Text = "Roles"
        Me.toolRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CenterPanel
        '
        Me.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CenterPanel.Location = New System.Drawing.Point(154, 0)
        Me.CenterPanel.Name = "CenterPanel"
        Me.CenterPanel.Size = New System.Drawing.Size(465, 343)
        Me.CenterPanel.TabIndex = 10
        '
        'FrmUserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 397)
        Me.Controls.Add(Me.CenterPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSaveTemp)
        Me.MaximizeBox = False
        Me.Name = "FrmUserAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaveTemp As UILibs.BtnSaveTemplate
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolUsername As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CenterPanel As System.Windows.Forms.Panel
    Friend WithEvents toolRole As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
