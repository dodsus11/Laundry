<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageUserAdd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUn = New C1.Win.C1Input.C1TextBox()
        Me.txtPwd1 = New C1.Win.C1Input.C1TextBox()
        Me.txtPwd2 = New C1.Win.C1Input.C1TextBox()
        CType(Me.txtUn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPwd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPwd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Confirm Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password :"
        '
        'txtUn
        '
        Me.txtUn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtUn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUn.Location = New System.Drawing.Point(155, 33)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(247, 18)
        Me.txtUn.TabIndex = 16
        Me.txtUn.Tag = Nothing
        Me.txtUn.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtUn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtPwd1
        '
        Me.txtPwd1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtPwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd1.Location = New System.Drawing.Point(155, 60)
        Me.txtPwd1.Name = "txtPwd1"
        Me.txtPwd1.Size = New System.Drawing.Size(247, 18)
        Me.txtPwd1.TabIndex = 17
        Me.txtPwd1.Tag = Nothing
        Me.txtPwd1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtPwd1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtPwd2
        '
        Me.txtPwd2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtPwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPwd2.Location = New System.Drawing.Point(155, 87)
        Me.txtPwd2.Name = "txtPwd2"
        Me.txtPwd2.Size = New System.Drawing.Size(247, 18)
        Me.txtPwd2.TabIndex = 18
        Me.txtPwd2.Tag = Nothing
        Me.txtPwd2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtPwd2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'PageUserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtPwd2)
        Me.Controls.Add(Me.txtPwd1)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "PageUserAdd"
        Me.Size = New System.Drawing.Size(456, 193)
        CType(Me.txtUn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPwd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPwd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUn As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtPwd1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtPwd2 As C1.Win.C1Input.C1TextBox

End Class
