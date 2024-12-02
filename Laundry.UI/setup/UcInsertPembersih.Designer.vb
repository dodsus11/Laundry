<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcInsertPembersih
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
        Me.components = New System.ComponentModel.Container()
        Me.SaveEditTemp = New UILibs.SaveEditTemp()
        Me.txtKdPembersih = New C1.Win.C1Input.C1TextBox()
        Me.txtNamaPembersih = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtIdPembersih = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVol = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLinenInfeksius = New C1.Win.C1Input.C1TextBox()
        Me.txtLinenNoninfeksius = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.txtKdPembersih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaPembersih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLinenInfeksius, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLinenNoninfeksius, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveEditTemp
        '
        Me.SaveEditTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SaveEditTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveEditTemp.Location = New System.Drawing.Point(0, 0)
        Me.SaveEditTemp.Name = "SaveEditTemp"
        Me.SaveEditTemp.Size = New System.Drawing.Size(750, 416)
        Me.SaveEditTemp.TabIndex = 0
        '
        'txtKdPembersih
        '
        Me.txtKdPembersih.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtKdPembersih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKdPembersih.Location = New System.Drawing.Point(179, 85)
        Me.txtKdPembersih.Name = "txtKdPembersih"
        Me.txtKdPembersih.Size = New System.Drawing.Size(322, 18)
        Me.txtKdPembersih.TabIndex = 1
        Me.txtKdPembersih.Tag = Nothing
        Me.txtKdPembersih.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtKdPembersih.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtNamaPembersih
        '
        Me.txtNamaPembersih.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtNamaPembersih.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPembersih.Location = New System.Drawing.Point(179, 122)
        Me.txtNamaPembersih.Name = "txtNamaPembersih"
        Me.txtNamaPembersih.Size = New System.Drawing.Size(322, 18)
        Me.txtNamaPembersih.TabIndex = 2
        Me.txtNamaPembersih.Tag = Nothing
        Me.txtNamaPembersih.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtNamaPembersih.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(46, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode pembersih"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(46, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama pembersih"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'txtIdPembersih
        '
        Me.txtIdPembersih.AutoSize = True
        Me.txtIdPembersih.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtIdPembersih.Location = New System.Drawing.Point(155, 58)
        Me.txtIdPembersih.Name = "txtIdPembersih"
        Me.txtIdPembersih.Size = New System.Drawing.Size(0, 13)
        Me.txtIdPembersih.TabIndex = 5
        Me.txtIdPembersih.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(46, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Vol pembersih"
        '
        'txtVol
        '
        Me.txtVol.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtVol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVol.Location = New System.Drawing.Point(179, 157)
        Me.txtVol.Name = "txtVol"
        Me.txtVol.Size = New System.Drawing.Size(89, 18)
        Me.txtVol.TabIndex = 6
        Me.txtVol.Tag = Nothing
        Me.txtVol.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtVol.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(46, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Untuk linen non infeksius"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(45, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Untuk linen infeksius"
        '
        'txtLinenInfeksius
        '
        Me.txtLinenInfeksius.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtLinenInfeksius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLinenInfeksius.Location = New System.Drawing.Point(179, 192)
        Me.txtLinenInfeksius.Name = "txtLinenInfeksius"
        Me.txtLinenInfeksius.Size = New System.Drawing.Size(89, 18)
        Me.txtLinenInfeksius.TabIndex = 9
        Me.txtLinenInfeksius.Tag = Nothing
        Me.txtLinenInfeksius.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtLinenInfeksius.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtLinenNoninfeksius
        '
        Me.txtLinenNoninfeksius.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtLinenNoninfeksius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLinenNoninfeksius.Location = New System.Drawing.Point(179, 226)
        Me.txtLinenNoninfeksius.Name = "txtLinenNoninfeksius"
        Me.txtLinenNoninfeksius.Size = New System.Drawing.Size(89, 18)
        Me.txtLinenNoninfeksius.TabIndex = 12
        Me.txtLinenNoninfeksius.Tag = Nothing
        Me.txtLinenNoninfeksius.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtLinenNoninfeksius.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(274, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "cc"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Location = New System.Drawing.Point(274, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "kg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Location = New System.Drawing.Point(274, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "kg"
        '
        'UcInsertPembersih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLinenNoninfeksius)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLinenInfeksius)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVol)
        Me.Controls.Add(Me.txtIdPembersih)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNamaPembersih)
        Me.Controls.Add(Me.txtKdPembersih)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Name = "UcInsertPembersih"
        Me.Size = New System.Drawing.Size(750, 416)
        CType(Me.txtKdPembersih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaPembersih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLinenInfeksius, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLinenNoninfeksius, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents txtKdPembersih As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNamaPembersih As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLinenInfeksius As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVol As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtIdPembersih As System.Windows.Forms.Label
    Friend WithEvents txtLinenNoninfeksius As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
