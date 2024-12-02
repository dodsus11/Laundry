<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcUtilisasiMesinSetrika
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMesin = New System.Windows.Forms.Button()
        Me.btnOperator = New System.Windows.Forms.Button()
        Me.txtMesin = New System.Windows.Forms.TextBox()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.txtLinenBersih = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTgl = New System.Windows.Forms.TextBox()
        Me.txtLoad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLinenRusak = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLinenReject = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnLinen = New System.Windows.Forms.Button()
        Me.txtLinen = New System.Windows.Forms.TextBox()
        Me.txtJmlLinen = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(61, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nama mesin"
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
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Linen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(61, 361)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Jumlah linen total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(61, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Jumlah linen bersih"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Location = New System.Drawing.Point(61, 184)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Operator"
        '
        'btnMesin
        '
        Me.btnMesin.Location = New System.Drawing.Point(568, 97)
        Me.btnMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMesin.Name = "btnMesin"
        Me.btnMesin.Size = New System.Drawing.Size(40, 25)
        Me.btnMesin.TabIndex = 27
        Me.btnMesin.Text = "..."
        Me.btnMesin.UseVisualStyleBackColor = True
        '
        'btnOperator
        '
        Me.btnOperator.Location = New System.Drawing.Point(568, 181)
        Me.btnOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(40, 25)
        Me.btnOperator.TabIndex = 29
        Me.btnOperator.Text = "..."
        Me.btnOperator.UseVisualStyleBackColor = True
        '
        'txtMesin
        '
        Me.txtMesin.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtMesin.Enabled = False
        Me.txtMesin.Location = New System.Drawing.Point(211, 97)
        Me.txtMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMesin.Name = "txtMesin"
        Me.txtMesin.Size = New System.Drawing.Size(348, 22)
        Me.txtMesin.TabIndex = 42
        '
        'txtOperator
        '
        Me.txtOperator.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtOperator.Enabled = False
        Me.txtOperator.Location = New System.Drawing.Point(211, 181)
        Me.txtOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(348, 22)
        Me.txtOperator.TabIndex = 44
        '
        'txtLinenBersih
        '
        Me.txtLinenBersih.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtLinenBersih.Location = New System.Drawing.Point(211, 229)
        Me.txtLinenBersih.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinenBersih.Name = "txtLinenBersih"
        Me.txtLinenBersih.Size = New System.Drawing.Size(148, 22)
        Me.txtLinenBersih.TabIndex = 45
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(61, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Tanggal"
        '
        'txtTgl
        '
        Me.txtTgl.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtTgl.Location = New System.Drawing.Point(211, 59)
        Me.txtTgl.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Size = New System.Drawing.Size(148, 22)
        Me.txtTgl.TabIndex = 48
        '
        'txtLoad
        '
        Me.txtLoad.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtLoad.Location = New System.Drawing.Point(501, 59)
        Me.txtLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.Size = New System.Drawing.Size(57, 22)
        Me.txtLoad.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(428, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Load ke"
        '
        'txtLinenRusak
        '
        Me.txtLinenRusak.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtLinenRusak.Location = New System.Drawing.Point(211, 272)
        Me.txtLinenRusak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinenRusak.Name = "txtLinenRusak"
        Me.txtLinenRusak.Size = New System.Drawing.Size(148, 22)
        Me.txtLinenRusak.TabIndex = 53
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.Location = New System.Drawing.Point(61, 275)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 17)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Jumlah linen rusak"
        '
        'txtLinenReject
        '
        Me.txtLinenReject.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtLinenReject.Location = New System.Drawing.Point(211, 315)
        Me.txtLinenReject.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinenReject.Name = "txtLinenReject"
        Me.txtLinenReject.Size = New System.Drawing.Size(148, 22)
        Me.txtLinenReject.TabIndex = 55
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label11.Location = New System.Drawing.Point(61, 318)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 17)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Jumlah linen reject"
        '
        'btnLinen
        '
        Me.btnLinen.Location = New System.Drawing.Point(368, 139)
        Me.btnLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLinen.Name = "btnLinen"
        Me.btnLinen.Size = New System.Drawing.Size(40, 25)
        Me.btnLinen.TabIndex = 56
        Me.btnLinen.Text = "..."
        Me.btnLinen.UseVisualStyleBackColor = True
        '
        'txtLinen
        '
        Me.txtLinen.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtLinen.Location = New System.Drawing.Point(211, 139)
        Me.txtLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinen.Name = "txtLinen"
        Me.txtLinen.Size = New System.Drawing.Size(148, 22)
        Me.txtLinen.TabIndex = 57
        '
        'txtJmlLinen
        '
        Me.txtJmlLinen.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtJmlLinen.Enabled = False
        Me.txtJmlLinen.Location = New System.Drawing.Point(211, 358)
        Me.txtJmlLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlLinen.Name = "txtJmlLinen"
        Me.txtJmlLinen.Size = New System.Drawing.Size(148, 22)
        Me.txtJmlLinen.TabIndex = 59
        '
        'UcUtilisasiMesinSetrika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtJmlLinen)
        Me.Controls.Add(Me.txtLinen)
        Me.Controls.Add(Me.btnLinen)
        Me.Controls.Add(Me.txtLinenReject)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtLinenRusak)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLoad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTgl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.txtLinenBersih)
        Me.Controls.Add(Me.txtOperator)
        Me.Controls.Add(Me.txtMesin)
        Me.Controls.Add(Me.btnOperator)
        Me.Controls.Add(Me.btnMesin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcUtilisasiMesinSetrika"
        Me.Size = New System.Drawing.Size(1000, 512)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOperator As System.Windows.Forms.Button
    Friend WithEvents btnMesin As System.Windows.Forms.Button
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents txtMesin As System.Windows.Forms.TextBox
    Friend WithEvents txtLinenBersih As System.Windows.Forms.TextBox
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents txtLoad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTgl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLinenReject As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLinenRusak As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnLinen As System.Windows.Forms.Button
    Friend WithEvents txtLinen As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlLinen As System.Windows.Forms.TextBox

End Class
