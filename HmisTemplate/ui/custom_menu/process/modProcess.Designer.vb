<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modProcess
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
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Trv = New System.Windows.Forms.TreeView()
        Me.pnCenter = New System.Windows.Forms.Panel()
        Me.pnTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.SteelBlue
        Me.pnTop.Controls.Add(Me.Label1)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(814, 34)
        Me.pnTop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(29, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Process Manager"
        '
        'Trv
        '
        Me.Trv.BackColor = System.Drawing.SystemColors.Info
        Me.Trv.Dock = System.Windows.Forms.DockStyle.Left
        Me.Trv.Location = New System.Drawing.Point(0, 34)
        Me.Trv.Name = "Trv"
        Me.Trv.Size = New System.Drawing.Size(263, 444)
        Me.Trv.TabIndex = 1
        '
        'pnCenter
        '
        Me.pnCenter.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCenter.Location = New System.Drawing.Point(263, 34)
        Me.pnCenter.Name = "pnCenter"
        Me.pnCenter.Size = New System.Drawing.Size(551, 444)
        Me.pnCenter.TabIndex = 2
        '
        'modProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnCenter)
        Me.Controls.Add(Me.Trv)
        Me.Controls.Add(Me.pnTop)
        Me.Name = "modProcess"
        Me.Size = New System.Drawing.Size(814, 478)
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Trv As System.Windows.Forms.TreeView
    Friend WithEvents pnCenter As System.Windows.Forms.Panel

End Class
