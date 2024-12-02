<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcUtilisasiMesin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbReject = New System.Windows.Forms.RadioButton()
        Me.rbNonInfeksius = New System.Windows.Forms.RadioButton()
        Me.rbInfeksius = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnMesin = New System.Windows.Forms.Button()
        Me.btnPembersih1 = New System.Windows.Forms.Button()
        Me.btnOperator = New System.Windows.Forms.Button()
        Me.dtpMulai = New System.Windows.Forms.DateTimePicker()
        Me.dtpSelesai = New System.Windows.Forms.DateTimePicker()
        Me.txtMesin = New System.Windows.Forms.TextBox()
        Me.txtPembersih1 = New System.Windows.Forms.TextBox()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.txtPembersih2 = New System.Windows.Forms.TextBox()
        Me.btnPembersih2 = New System.Windows.Forms.Button()
        Me.txtPembersih3 = New System.Windows.Forms.TextBox()
        Me.btnPembersih3 = New System.Windows.Forms.Button()
        Me.txtPembersih4 = New System.Windows.Forms.TextBox()
        Me.btnPembersih4 = New System.Windows.Forms.Button()
        Me.txtPembersih5 = New System.Windows.Forms.TextBox()
        Me.btnPembersih5 = New System.Windows.Forms.Button()
        Me.txtPembersih6 = New System.Windows.Forms.TextBox()
        Me.btnPembersih6 = New System.Windows.Forms.Button()
        Me.txtBeratLinen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPembersih7 = New System.Windows.Forms.TextBox()
        Me.btnPembersih7 = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.lblMesin.Location = New System.Drawing.Point(44, 70)
        Me.lblMesin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMesin.Name = "lblMesin"
        Me.lblMesin.Size = New System.Drawing.Size(76, 17)
        Me.lblMesin.TabIndex = 3
        Me.lblMesin.Text = "Mecin Cuci"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(44, 215)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pembersih"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Location = New System.Drawing.Point(43, 158)
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
        Me.Label3.Location = New System.Drawing.Point(44, 307)
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
        Me.Label4.Location = New System.Drawing.Point(44, 350)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Selesai"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(43, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Jenis Identifikasi Kotoran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Location = New System.Drawing.Point(44, 394)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Operator"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox1.Controls.Add(Me.rbReject)
        Me.GroupBox1.Controls.Add(Me.rbNonInfeksius)
        Me.GroupBox1.Controls.Add(Me.rbInfeksius)
        Me.GroupBox1.Location = New System.Drawing.Point(211, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(397, 36)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'rbReject
        '
        Me.rbReject.AutoSize = True
        Me.rbReject.Location = New System.Drawing.Point(264, 9)
        Me.rbReject.Margin = New System.Windows.Forms.Padding(4)
        Me.rbReject.Name = "rbReject"
        Me.rbReject.Size = New System.Drawing.Size(69, 21)
        Me.rbReject.TabIndex = 2
        Me.rbReject.TabStop = True
        Me.rbReject.Text = "Reject"
        Me.rbReject.UseVisualStyleBackColor = True
        '
        'rbNonInfeksius
        '
        Me.rbNonInfeksius.AutoSize = True
        Me.rbNonInfeksius.Location = New System.Drawing.Point(5, 9)
        Me.rbNonInfeksius.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNonInfeksius.Name = "rbNonInfeksius"
        Me.rbNonInfeksius.Size = New System.Drawing.Size(114, 21)
        Me.rbNonInfeksius.TabIndex = 1
        Me.rbNonInfeksius.TabStop = True
        Me.rbNonInfeksius.Text = "Non Infeksius"
        Me.rbNonInfeksius.UseVisualStyleBackColor = True
        '
        'rbInfeksius
        '
        Me.rbInfeksius.AutoSize = True
        Me.rbInfeksius.Location = New System.Drawing.Point(144, 9)
        Me.rbInfeksius.Margin = New System.Windows.Forms.Padding(4)
        Me.rbInfeksius.Name = "rbInfeksius"
        Me.rbInfeksius.Size = New System.Drawing.Size(84, 21)
        Me.rbInfeksius.TabIndex = 0
        Me.rbInfeksius.TabStop = True
        Me.rbInfeksius.Text = "Infeksius"
        Me.rbInfeksius.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label9.Location = New System.Drawing.Point(337, 158)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Kg"
        '
        'btnMesin
        '
        Me.btnMesin.Location = New System.Drawing.Point(568, 68)
        Me.btnMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMesin.Name = "btnMesin"
        Me.btnMesin.Size = New System.Drawing.Size(40, 25)
        Me.btnMesin.TabIndex = 27
        Me.btnMesin.Text = "..."
        Me.btnMesin.UseVisualStyleBackColor = True
        '
        'btnPembersih1
        '
        Me.btnPembersih1.Location = New System.Drawing.Point(336, 214)
        Me.btnPembersih1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPembersih1.Name = "btnPembersih1"
        Me.btnPembersih1.Size = New System.Drawing.Size(31, 25)
        Me.btnPembersih1.TabIndex = 28
        Me.btnPembersih1.Text = "..."
        Me.btnPembersih1.UseVisualStyleBackColor = True
        Me.btnPembersih1.Visible = False
        '
        'btnOperator
        '
        Me.btnOperator.Location = New System.Drawing.Point(568, 392)
        Me.btnOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(40, 25)
        Me.btnOperator.TabIndex = 29
        Me.btnOperator.Text = "..."
        Me.btnOperator.UseVisualStyleBackColor = True
        '
        'dtpMulai
        '
        Me.dtpMulai.CustomFormat = "HH:mm"
        Me.dtpMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMulai.Location = New System.Drawing.Point(211, 307)
        Me.dtpMulai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpMulai.Name = "dtpMulai"
        Me.dtpMulai.ShowUpDown = True
        Me.dtpMulai.Size = New System.Drawing.Size(148, 22)
        Me.dtpMulai.TabIndex = 34
        Me.dtpMulai.Value = New Date(2018, 1, 18, 11, 6, 59, 0)
        '
        'dtpSelesai
        '
        Me.dtpSelesai.CustomFormat = "HH:mm"
        Me.dtpSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSelesai.Location = New System.Drawing.Point(211, 347)
        Me.dtpSelesai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpSelesai.Name = "dtpSelesai"
        Me.dtpSelesai.ShowUpDown = True
        Me.dtpSelesai.Size = New System.Drawing.Size(148, 22)
        Me.dtpSelesai.TabIndex = 35
        Me.dtpSelesai.Value = New Date(2018, 1, 18, 11, 7, 16, 0)
        '
        'txtMesin
        '
        Me.txtMesin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMesin.Location = New System.Drawing.Point(211, 69)
        Me.txtMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMesin.Name = "txtMesin"
        Me.txtMesin.ReadOnly = True
        Me.txtMesin.Size = New System.Drawing.Size(348, 22)
        Me.txtMesin.TabIndex = 42
        '
        'txtPembersih1
        '
        Me.txtPembersih1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPembersih1.Location = New System.Drawing.Point(211, 214)
        Me.txtPembersih1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPembersih1.Name = "txtPembersih1"
        Me.txtPembersih1.ReadOnly = True
        Me.txtPembersih1.Size = New System.Drawing.Size(119, 22)
        Me.txtPembersih1.TabIndex = 43
        Me.txtPembersih1.Text = "Alkaline (ml)"
        '
        'txtOperator
        '
        Me.txtOperator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOperator.Location = New System.Drawing.Point(211, 393)
        Me.txtOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.ReadOnly = True
        Me.txtOperator.Size = New System.Drawing.Size(348, 22)
        Me.txtOperator.TabIndex = 44
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.LabelID.Location = New System.Drawing.Point(63, 64)
        Me.LabelID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(0, 17)
        Me.LabelID.TabIndex = 45
        Me.LabelID.Visible = False
        '
        'txtPembersih2
        '
        Me.txtPembersih2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPembersih2.Location = New System.Drawing.Point(379, 214)
        Me.txtPembersih2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPembersih2.Name = "txtPembersih2"
        Me.txtPembersih2.ReadOnly = True
        Me.txtPembersih2.Size = New System.Drawing.Size(119, 22)
        Me.txtPembersih2.TabIndex = 47
        Me.txtPembersih2.Text = "Detergen (ml)"
        '
        'btnPembersih2
        '
        Me.btnPembersih2.Location = New System.Drawing.Point(504, 214)
        Me.btnPembersih2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPembersih2.Name = "btnPembersih2"
        Me.btnPembersih2.Size = New System.Drawing.Size(31, 25)
        Me.btnPembersih2.TabIndex = 46
        Me.btnPembersih2.Text = "..."
        Me.btnPembersih2.UseVisualStyleBackColor = True
        Me.btnPembersih2.Visible = False
        '
        'txtPembersih3
        '
        Me.txtPembersih3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPembersih3.Location = New System.Drawing.Point(547, 214)
        Me.txtPembersih3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPembersih3.Name = "txtPembersih3"
        Me.txtPembersih3.ReadOnly = True
        Me.txtPembersih3.Size = New System.Drawing.Size(119, 22)
        Me.txtPembersih3.TabIndex = 49
        Me.txtPembersih3.Text = "Oxygenbleach (ml)"
        '
        'btnPembersih3
        '
        Me.btnPembersih3.Location = New System.Drawing.Point(672, 214)
        Me.btnPembersih3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPembersih3.Name = "btnPembersih3"
        Me.btnPembersih3.Size = New System.Drawing.Size(31, 25)
        Me.btnPembersih3.TabIndex = 48
        Me.btnPembersih3.Text = "..."
        Me.btnPembersih3.UseVisualStyleBackColor = True
        Me.btnPembersih3.Visible = False
        '
        'txtPembersih4
        '
        Me.txtPembersih4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPembersih4.Enabled = False
        Me.txtPembersih4.Location = New System.Drawing.Point(547, 268)
        Me.txtPembersih4.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPembersih4.Name = "txtPembersih4"
        Me.txtPembersih4.ReadOnly = True
        Me.txtPembersih4.Size = New System.Drawing.Size(119, 22)
        Me.txtPembersih4.TabIndex = 51
        Me.txtPembersih4.Text = "Emulsifier (ml)"
        Me.txtPembersih4.Visible = False
        '
        'btnPembersih4
        '
        Me.btnPembersih4.Location = New System.Drawing.Point(672, 268)
        Me.btnPembersih4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPembersih4.Name = "btnPembersih4"
        Me.btnPembersih4.Size = New System.Drawing.Size(31, 25)
        Me.btnPembersih4.TabIndex = 50
        Me.btnPembersih4.Text = "..."
        Me.btnPembersih4.UseVisualStyleBackColor = True
        Me.btnPembersih4.Visible = False
        '
        'txtPembersih5
        '
        Me.txtPembersih5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPembersih5.Location = New System.Drawing.Point(211, 268)
        Me.txtPembersih5.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPembersih5.Name = "txtPembersih5"
        Me.txtPembersih5.ReadOnly = True
        Me.txtPembersih5.Size = New System.Drawing.Size(119, 22)
        Me.txtPembersih5.TabIndex = 53
        Me.txtPembersih5.Text = "Softener (ml)"
        '
        'btnPembersih5
        '
        Me.btnPembersih5.Location = New System.Drawing.Point(336, 268)
        Me.btnPembersih5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPembersih5.Name = "btnPembersih5"
        Me.btnPembersih5.Size = New System.Drawing.Size(31, 25)
        Me.btnPembersih5.TabIndex = 52
        Me.btnPembersih5.Text = "..."
        Me.btnPembersih5.UseVisualStyleBackColor = True
        Me.btnPembersih5.Visible = False
        '
        'txtPembersih6
        '
        Me.txtPembersih6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPembersih6.Enabled = False
        Me.txtPembersih6.Location = New System.Drawing.Point(716, 268)
        Me.txtPembersih6.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPembersih6.Name = "txtPembersih6"
        Me.txtPembersih6.ReadOnly = True
        Me.txtPembersih6.Size = New System.Drawing.Size(119, 22)
        Me.txtPembersih6.TabIndex = 55
        Me.txtPembersih6.Text = "Sour (ml)"
        Me.txtPembersih6.Visible = False
        '
        'btnPembersih6
        '
        Me.btnPembersih6.Location = New System.Drawing.Point(841, 268)
        Me.btnPembersih6.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPembersih6.Name = "btnPembersih6"
        Me.btnPembersih6.Size = New System.Drawing.Size(31, 25)
        Me.btnPembersih6.TabIndex = 54
        Me.btnPembersih6.Text = "..."
        Me.btnPembersih6.UseVisualStyleBackColor = True
        Me.btnPembersih6.Visible = False
        '
        'txtBeratLinen
        '
        Me.txtBeratLinen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBeratLinen.Location = New System.Drawing.Point(211, 155)
        Me.txtBeratLinen.Name = "txtBeratLinen"
        Me.txtBeratLinen.Size = New System.Drawing.Size(119, 22)
        Me.txtBeratLinen.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(208, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Alkaline (ml) :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.Location = New System.Drawing.Point(376, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 17)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Detergen (ml) :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.Location = New System.Drawing.Point(544, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 17)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Oxygenbleach (ml) :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label12.Location = New System.Drawing.Point(544, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 17)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Emulsifier (ml) :"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label13.Location = New System.Drawing.Point(208, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 17)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Softener (ml) :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label14.Location = New System.Drawing.Point(713, 246)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 17)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Sour (ml) :"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label15.Location = New System.Drawing.Point(376, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 17)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Penetral (ml) :"
        '
        'txtPembersih7
        '
        Me.txtPembersih7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPembersih7.Location = New System.Drawing.Point(379, 268)
        Me.txtPembersih7.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPembersih7.Name = "txtPembersih7"
        Me.txtPembersih7.ReadOnly = True
        Me.txtPembersih7.Size = New System.Drawing.Size(119, 22)
        Me.txtPembersih7.TabIndex = 64
        Me.txtPembersih7.Text = "Penetral (ml)"
        '
        'btnPembersih7
        '
        Me.btnPembersih7.Location = New System.Drawing.Point(504, 268)
        Me.btnPembersih7.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPembersih7.Name = "btnPembersih7"
        Me.btnPembersih7.Size = New System.Drawing.Size(31, 25)
        Me.btnPembersih7.TabIndex = 63
        Me.btnPembersih7.Text = "..."
        Me.btnPembersih7.UseVisualStyleBackColor = True
        Me.btnPembersih7.Visible = False
        '
        'UcUtilisasiMesin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPembersih7)
        Me.Controls.Add(Me.btnPembersih7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBeratLinen)
        Me.Controls.Add(Me.txtPembersih6)
        Me.Controls.Add(Me.btnPembersih6)
        Me.Controls.Add(Me.txtPembersih5)
        Me.Controls.Add(Me.btnPembersih5)
        Me.Controls.Add(Me.txtPembersih4)
        Me.Controls.Add(Me.btnPembersih4)
        Me.Controls.Add(Me.txtPembersih3)
        Me.Controls.Add(Me.btnPembersih3)
        Me.Controls.Add(Me.txtPembersih2)
        Me.Controls.Add(Me.btnPembersih2)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.txtOperator)
        Me.Controls.Add(Me.txtPembersih1)
        Me.Controls.Add(Me.txtMesin)
        Me.Controls.Add(Me.dtpSelesai)
        Me.Controls.Add(Me.dtpMulai)
        Me.Controls.Add(Me.btnOperator)
        Me.Controls.Add(Me.btnPembersih1)
        Me.Controls.Add(Me.btnMesin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMesin)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcUtilisasiMesin"
        Me.Size = New System.Drawing.Size(1000, 512)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents lblMesin As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbNonInfeksius As System.Windows.Forms.RadioButton
    Friend WithEvents rbInfeksius As System.Windows.Forms.RadioButton
    Friend WithEvents btnOperator As System.Windows.Forms.Button
    Friend WithEvents btnPembersih1 As System.Windows.Forms.Button
    Friend WithEvents btnMesin As System.Windows.Forms.Button
    Friend WithEvents dtpSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents txtPembersih1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMesin As System.Windows.Forms.TextBox
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents txtPembersih4 As System.Windows.Forms.TextBox
    Friend WithEvents btnPembersih4 As System.Windows.Forms.Button
    Friend WithEvents txtPembersih3 As System.Windows.Forms.TextBox
    Friend WithEvents btnPembersih3 As System.Windows.Forms.Button
    Friend WithEvents txtPembersih2 As System.Windows.Forms.TextBox
    Friend WithEvents btnPembersih2 As System.Windows.Forms.Button
    Friend WithEvents txtPembersih6 As System.Windows.Forms.TextBox
    Friend WithEvents btnPembersih6 As System.Windows.Forms.Button
    Friend WithEvents txtPembersih5 As System.Windows.Forms.TextBox
    Friend WithEvents btnPembersih5 As System.Windows.Forms.Button
    Friend WithEvents txtBeratLinen As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbReject As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPembersih7 As System.Windows.Forms.TextBox
    Friend WithEvents btnPembersih7 As System.Windows.Forms.Button

End Class
