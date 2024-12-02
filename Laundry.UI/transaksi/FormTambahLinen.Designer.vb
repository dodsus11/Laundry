<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahLinen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New C1.Win.C1Input.C1Button()
        Me.btnLookUpLinen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaLinen = New System.Windows.Forms.TextBox()
        Me.txt_jmlNonInfeksius = New System.Windows.Forms.TextBox()
        Me.txt_jmlInfeksius = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_beratlinen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 53)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(21, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAH ITEM"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 320)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 53)
        Me.Panel2.TabIndex = 1
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(579, 9)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(135, 31)
        Me.btnSimpan.TabIndex = 127
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnLookUpLinen
        '
        Me.btnLookUpLinen.Location = New System.Drawing.Point(535, 102)
        Me.btnLookUpLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLookUpLinen.Name = "btnLookUpLinen"
        Me.btnLookUpLinen.Size = New System.Drawing.Size(36, 23)
        Me.btnLookUpLinen.TabIndex = 28
        Me.btnLookUpLinen.Text = "..."
        Me.btnLookUpLinen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLookUpLinen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(95, 196)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Jumlah Non Infeksius"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(95, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama Linen"
        '
        'txtNamaLinen
        '
        Me.txtNamaLinen.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNamaLinen.Location = New System.Drawing.Point(267, 102)
        Me.txtNamaLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaLinen.Name = "txtNamaLinen"
        Me.txtNamaLinen.ReadOnly = True
        Me.txtNamaLinen.Size = New System.Drawing.Size(251, 22)
        Me.txtNamaLinen.TabIndex = 31
        '
        'txt_jmlNonInfeksius
        '
        Me.txt_jmlNonInfeksius.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_jmlNonInfeksius.Location = New System.Drawing.Point(267, 196)
        Me.txt_jmlNonInfeksius.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_jmlNonInfeksius.Name = "txt_jmlNonInfeksius"
        Me.txt_jmlNonInfeksius.Size = New System.Drawing.Size(129, 22)
        Me.txt_jmlNonInfeksius.TabIndex = 32
        '
        'txt_jmlInfeksius
        '
        Me.txt_jmlInfeksius.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_jmlInfeksius.Location = New System.Drawing.Point(267, 233)
        Me.txt_jmlInfeksius.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_jmlInfeksius.Name = "txt_jmlInfeksius"
        Me.txt_jmlInfeksius.Size = New System.Drawing.Size(129, 22)
        Me.txt_jmlInfeksius.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(95, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Jumlah Infeksius"
        '
        'txt_beratlinen
        '
        Me.txt_beratlinen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txt_beratlinen.Location = New System.Drawing.Point(267, 273)
        Me.txt_beratlinen.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_beratlinen.Name = "txt_beratlinen"
        Me.txt_beratlinen.ReadOnly = True
        Me.txt_beratlinen.Size = New System.Drawing.Size(129, 22)
        Me.txt_beratlinen.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(95, 276)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Total Berat Linen (Kg)"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(267, 151)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(129, 22)
        Me.TextBox1.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(95, 156)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Berat per Linen (Kg)"
        '
        'C1Button1
        '
        Me.C1Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.C1Button1.Location = New System.Drawing.Point(638, 271)
        Me.C1Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.C1Button1.Size = New System.Drawing.Size(76, 22)
        Me.C1Button1.TabIndex = 128
        Me.C1Button1.Text = "Hitung"
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.Visible = False
        Me.C1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'FormTambahLinen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 373)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_beratlinen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_jmlInfeksius)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_jmlNonInfeksius)
        Me.Controls.Add(Me.txtNamaLinen)
        Me.Controls.Add(Me.btnLookUpLinen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormTambahLinen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormTambahLinen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As C1.Win.C1Input.C1Button
    Friend WithEvents btnLookUpLinen As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNamaLinen As System.Windows.Forms.TextBox
    Friend WithEvents txt_jmlNonInfeksius As System.Windows.Forms.TextBox
    Friend WithEvents txt_jmlInfeksius As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_beratlinen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
End Class
