<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRoleList
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
        Me.trv = New System.Windows.Forms.TreeView()
        Me.btnPilih = New Glass.GlassButton()
        Me.SuspendLayout()
        '
        'trv
        '
        Me.trv.Location = New System.Drawing.Point(12, 12)
        Me.trv.Name = "trv"
        Me.trv.Size = New System.Drawing.Size(409, 231)
        Me.trv.TabIndex = 0
        '
        'btnPilih
        '
        Me.btnPilih.Location = New System.Drawing.Point(346, 250)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(75, 23)
        Me.btnPilih.TabIndex = 1
        Me.btnPilih.Text = "Pilih"
        '
        'FrmRoleList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 277)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.trv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmRoleList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Role List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trv As System.Windows.Forms.TreeView
    Friend WithEvents btnPilih As Glass.GlassButton
End Class
