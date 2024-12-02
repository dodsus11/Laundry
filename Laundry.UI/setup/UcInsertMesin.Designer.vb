<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcInsertMesin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox_jns_mesin = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_status_mesin = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.Label()
        Me.txtKd = New System.Windows.Forms.TextBox()
        Me.txtNamaMesin = New System.Windows.Forms.TextBox()
        Me.txtKapasitasMesin = New System.Windows.Forms.TextBox()
        Me.txtLoad = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(61, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Mesin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(61, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Mesin"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(61, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kapasitas Mesin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(61, 277)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Maks Load per hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(421, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Kg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Location = New System.Drawing.Point(61, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Pilih Jenis Mesin"
        '
        'ComboBox_jns_mesin
        '
        Me.ComboBox_jns_mesin.FormattingEnabled = True
        Me.ComboBox_jns_mesin.Items.AddRange(New Object() {"Mesin Cuci", "Mesin Peras", "Mesin Pengering", "Mesin Setrika"})
        Me.ComboBox_jns_mesin.Location = New System.Drawing.Point(211, 189)
        Me.ComboBox_jns_mesin.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_jns_mesin.Name = "ComboBox_jns_mesin"
        Me.ComboBox_jns_mesin.Size = New System.Drawing.Size(201, 24)
        Me.ComboBox_jns_mesin.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Location = New System.Drawing.Point(61, 321)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Status Mesin"
        '
        'ComboBox_status_mesin
        '
        Me.ComboBox_status_mesin.FormattingEnabled = True
        Me.ComboBox_status_mesin.Items.AddRange(New Object() {"Aktif", "Rusak", "Expired"})
        Me.ComboBox_status_mesin.Location = New System.Drawing.Point(211, 318)
        Me.ComboBox_status_mesin.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_status_mesin.Name = "ComboBox_status_mesin"
        Me.ComboBox_status_mesin.Size = New System.Drawing.Size(201, 24)
        Me.ComboBox_status_mesin.TabIndex = 16
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtId.Location = New System.Drawing.Point(207, 70)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(0, 17)
        Me.txtId.TabIndex = 17
        Me.txtId.Visible = False
        '
        'txtKd
        '
        Me.txtKd.Location = New System.Drawing.Point(211, 105)
        Me.txtKd.Name = "txtKd"
        Me.txtKd.Size = New System.Drawing.Size(359, 22)
        Me.txtKd.TabIndex = 18
        '
        'txtNamaMesin
        '
        Me.txtNamaMesin.Location = New System.Drawing.Point(211, 148)
        Me.txtNamaMesin.Name = "txtNamaMesin"
        Me.txtNamaMesin.Size = New System.Drawing.Size(359, 22)
        Me.txtNamaMesin.TabIndex = 19
        '
        'txtKapasitasMesin
        '
        Me.txtKapasitasMesin.Location = New System.Drawing.Point(211, 234)
        Me.txtKapasitasMesin.Name = "txtKapasitasMesin"
        Me.txtKapasitasMesin.Size = New System.Drawing.Size(203, 22)
        Me.txtKapasitasMesin.TabIndex = 20
        '
        'txtLoad
        '
        Me.txtLoad.Location = New System.Drawing.Point(211, 277)
        Me.txtLoad.Name = "txtLoad"
        Me.txtLoad.Size = New System.Drawing.Size(201, 22)
        Me.txtLoad.TabIndex = 21
        '
        'UcInsertMesin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtLoad)
        Me.Controls.Add(Me.txtKapasitasMesin)
        Me.Controls.Add(Me.txtNamaMesin)
        Me.Controls.Add(Me.txtKd)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.ComboBox_status_mesin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox_jns_mesin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcInsertMesin"
        Me.Size = New System.Drawing.Size(1000, 512)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_jns_mesin As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_status_mesin As System.Windows.Forms.ComboBox
    Friend WithEvents txtId As System.Windows.Forms.Label
    Friend WithEvents txtKd As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaMesin As System.Windows.Forms.TextBox
    Friend WithEvents txtKapasitasMesin As System.Windows.Forms.TextBox
    Friend WithEvents txtLoad As System.Windows.Forms.TextBox

End Class
