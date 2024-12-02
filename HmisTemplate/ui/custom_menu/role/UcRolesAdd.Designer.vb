<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcRolesAdd
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
        Me.seTemp = New UILibs.SaveEditTemp()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRole = New C1.Win.C1Input.C1TextBox()
        Me.txtDesc = New C1.Win.C1Input.C1TextBox()
        Me.lblCopyRole = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        CType(Me.txtRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'seTemp
        '
        Me.seTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.seTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seTemp.Location = New System.Drawing.Point(0, 0)
        Me.seTemp.Name = "seTemp"
        Me.seTemp.Size = New System.Drawing.Size(525, 290)
        Me.seTemp.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Role"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Deskripsi"
        '
        'txtRole
        '
        Me.txtRole.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRole.Location = New System.Drawing.Point(132, 82)
        Me.txtRole.Multiline = True
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(218, 20)
        Me.txtRole.TabIndex = 0
        Me.txtRole.Tag = Nothing
        Me.txtRole.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtRole.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtDesc
        '
        Me.txtDesc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(132, 123)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(218, 20)
        Me.txtDesc.TabIndex = 2
        Me.txtDesc.Tag = Nothing
        Me.txtDesc.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtDesc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'lblCopyRole
        '
        Me.lblCopyRole.AutoSize = True
        Me.lblCopyRole.Location = New System.Drawing.Point(46, 167)
        Me.lblCopyRole.Name = "lblCopyRole"
        Me.lblCopyRole.Size = New System.Drawing.Size(77, 13)
        Me.lblCopyRole.TabIndex = 5
        Me.lblCopyRole.Text = "Salin Dari Role"
        Me.lblCopyRole.Visible = False
        '
        'cmbRole
        '
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(132, 164)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(218, 21)
        Me.cmbRole.TabIndex = 4
        Me.cmbRole.Visible = False
        '
        'UcRolesAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.lblCopyRole)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seTemp)
        Me.Name = "UcRolesAdd"
        Me.Size = New System.Drawing.Size(525, 290)
        CType(Me.txtRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents seTemp As UILibs.SaveEditTemp
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRole As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDesc As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblCopyRole As System.Windows.Forms.Label
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox

End Class
