<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcess
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnIcon = New System.Windows.Forms.Panel()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.PnClose = New System.Windows.Forms.Panel()
        Me.LblClose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnTop.SuspendLayout()
        Me.PnClose.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.pnIcon)
        Me.Panel1.Controls.Add(Me.pnTop)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 460)
        Me.Panel1.TabIndex = 0
        '
        'pnIcon
        '
        Me.pnIcon.AutoScroll = True
        Me.pnIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnIcon.Location = New System.Drawing.Point(0, 25)
        Me.pnIcon.Name = "pnIcon"
        Me.pnIcon.Size = New System.Drawing.Size(456, 433)
        Me.pnIcon.TabIndex = 1
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnTop.Controls.Add(Me.PnClose)
        Me.pnTop.Controls.Add(Me.Label1)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(456, 25)
        Me.pnTop.TabIndex = 0
        '
        'PnClose
        '
        Me.PnClose.Controls.Add(Me.LblClose)
        Me.PnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnClose.Location = New System.Drawing.Point(430, 0)
        Me.PnClose.Name = "PnClose"
        Me.PnClose.Size = New System.Drawing.Size(26, 25)
        Me.PnClose.TabIndex = 2
        '
        'LblClose
        '
        Me.LblClose.AutoSize = True
        Me.LblClose.BackColor = System.Drawing.Color.Transparent
        Me.LblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClose.ForeColor = System.Drawing.Color.White
        Me.LblClose.Location = New System.Drawing.Point(5, 5)
        Me.LblClose.Name = "LblClose"
        Me.LblClose.Size = New System.Drawing.Size(16, 15)
        Me.LblClose.TabIndex = 1
        Me.LblClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(175, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List Menu"
        '
        'FrmProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 460)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Process"
        Me.Panel1.ResumeLayout(False)
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.PnClose.ResumeLayout(False)
        Me.PnClose.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents pnIcon As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblClose As System.Windows.Forms.Label
    Friend WithEvents PnClose As System.Windows.Forms.Panel
End Class
