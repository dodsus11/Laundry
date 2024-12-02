<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcUtilisasiMesinPengering
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
        Me.lblMesin = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnMesin = New System.Windows.Forms.Button()
        Me.btnOperator = New System.Windows.Forms.Button()
        Me.txtBeratLinen = New C1.Win.C1Input.C1TextBox()
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.txtMesin = New System.Windows.Forms.TextBox()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.txtSuhu = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBeratLinen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveEditTemp
        '
        Me.SaveEditTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SaveEditTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveEditTemp.Location = New System.Drawing.Point(0, 0)
        Me.SaveEditTemp.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveEditTemp.Name = "SaveEditTemp"
        Me.SaveEditTemp.Size = New System.Drawing.Size(1000, 512)
        Me.SaveEditTemp.TabIndex = 0
        '
        'lblMesin
        '
        Me.lblMesin.AutoSize = True
        Me.lblMesin.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblMesin.Location = New System.Drawing.Point(61, 98)
        Me.lblMesin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMesin.Name = "lblMesin"
        Me.lblMesin.Size = New System.Drawing.Size(114, 17)
        Me.lblMesin.TabIndex = 3
        Me.lblMesin.Text = "Mesin Pengering"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Location = New System.Drawing.Point(61, 143)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Berat Linen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(61, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Mulai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(61, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Selesai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(61, 273)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Suhu"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Location = New System.Drawing.Point(61, 318)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Operator"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label9.Location = New System.Drawing.Point(368, 143)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Kg"
        '
        'btnMesin
        '
        Me.btnMesin.Location = New System.Drawing.Point(568, 96)
        Me.btnMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMesin.Name = "btnMesin"
        Me.btnMesin.Size = New System.Drawing.Size(40, 25)
        Me.btnMesin.TabIndex = 27
        Me.btnMesin.Text = "..."
        Me.btnMesin.UseVisualStyleBackColor = True
        '
        'btnOperator
        '
        Me.btnOperator.Location = New System.Drawing.Point(568, 315)
        Me.btnOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(40, 25)
        Me.btnOperator.TabIndex = 29
        Me.btnOperator.Text = "..."
        Me.btnOperator.UseVisualStyleBackColor = True
        '
        'txtBeratLinen
        '
        Me.txtBeratLinen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBeratLinen.BorderColor = System.Drawing.Color.Gray
        Me.txtBeratLinen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBeratLinen.Location = New System.Drawing.Point(211, 143)
        Me.txtBeratLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBeratLinen.Name = "txtBeratLinen"
        Me.txtBeratLinen.Size = New System.Drawing.Size(149, 20)
        Me.txtBeratLinen.TabIndex = 30
        Me.txtBeratLinen.Tag = Nothing
        Me.txtBeratLinen.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'dtpMulai
        '
        Me.dtpMulai.CustomFormat = "HH:mm"
        Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMulai.Location = New System.Drawing.Point(211, 186)
        Me.dtpMulai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpMulai.Name = "dtpMulai"
        Me.dtpMulai.ShowUpDown = True
        Me.dtpMulai.Size = New System.Drawing.Size(148, 22)
        Me.dtpMulai.TabIndex = 34
        Me.dtpMulai.Value = New Date(2017, 11, 16, 8, 44, 11, 0)
        '
        'dtpSelesai
        '
        Me.dtpSelesai.CustomFormat = "HH:mm"
        Me.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSelesai.Location = New System.Drawing.Point(211, 226)
        Me.dtpSelesai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpSelesai.Name = "dtpSelesai"
        Me.dtpSelesai.ShowUpDown = True
        Me.dtpSelesai.Size = New System.Drawing.Size(148, 22)
        Me.dtpSelesai.TabIndex = 35
        '
        'txtMesin
        '
        Me.txtMesin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMesin.Enabled = False
        Me.txtMesin.Location = New System.Drawing.Point(211, 97)
        Me.txtMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMesin.Name = "txtMesin"
        Me.txtMesin.Size = New System.Drawing.Size(348, 22)
        Me.txtMesin.TabIndex = 42
        '
        'txtOperator
        '
        Me.txtOperator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOperator.Enabled = False
        Me.txtOperator.Location = New System.Drawing.Point(211, 316)
        Me.txtOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(348, 22)
        Me.txtOperator.TabIndex = 44
        '
        'txtSuhu
        '
        Me.txtSuhu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtSuhu.Location = New System.Drawing.Point(211, 271)
        Me.txtSuhu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSuhu.Name = "txtSuhu"
        Me.txtSuhu.Size = New System.Drawing.Size(148, 22)
        Me.txtSuhu.TabIndex = 45
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.LabelID.Location = New System.Drawing.Point(61, 68)
        Me.LabelID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(0, 17)
        Me.LabelID.TabIndex = 46
        Me.LabelID.Visible = False
        '
        'UcUtilisasiMesinPengering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.txtSuhu)
        Me.Controls.Add(Me.txtOperator)
        Me.Controls.Add(Me.txtMesin)
        Me.Controls.Add(Me.dtpSelesai)
        Me.Controls.Add(Me.dtpMulai)
        Me.Controls.Add(Me.txtBeratLinen)
        Me.Controls.Add(Me.btnOperator)
        Me.Controls.Add(Me.btnMesin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblMesin)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcUtilisasiMesinPengering"
        Me.Size = New System.Drawing.Size(1000, 512)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBeratLinen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents lblMesin As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnOperator As System.Windows.Forms.Button
    Friend WithEvents btnMesin As System.Windows.Forms.Button
    Friend WithEvents txtBeratLinen As C1.Win.C1Input.C1TextBox
    Friend WithEvents dtpSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents txtMesin As System.Windows.Forms.TextBox
    Friend WithEvents txtSuhu As System.Windows.Forms.TextBox
    Friend WithEvents LabelID As System.Windows.Forms.Label

End Class
