<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahLoadGudang
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
        Me.rbMaterialLinenWarna = New System.Windows.Forms.RadioButton()
        Me.rbMaterialLinenPutih = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbMaterial = New System.Windows.Forms.GroupBox()
        Me.txtKodeLinen = New System.Windows.Forms.TextBox()
        Me.txtQtyLinen = New C1.Win.C1Input.C1TextBox()
        Me.txtNamaLinen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbMaterial.SuspendLayout()
        CType(Me.txtQtyLinen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 43)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAHKAN LINEN"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 260)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 43)
        Me.Panel2.TabIndex = 1
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(448, 9)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(101, 25)
        Me.btnSimpan.TabIndex = 127
        Me.btnSimpan.Text = "Tambah"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnLookUpLinen
        '
        Me.btnLookUpLinen.Location = New System.Drawing.Point(405, 83)
        Me.btnLookUpLinen.Name = "btnLookUpLinen"
        Me.btnLookUpLinen.Size = New System.Drawing.Size(27, 19)
        Me.btnLookUpLinen.TabIndex = 28
        Me.btnLookUpLinen.Text = "..."
        Me.btnLookUpLinen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLookUpLinen.UseVisualStyleBackColor = True
        '
        'rbMaterialLinenWarna
        '
        Me.rbMaterialLinenWarna.AutoSize = True
        Me.rbMaterialLinenWarna.BackColor = System.Drawing.SystemColors.Control
        Me.rbMaterialLinenWarna.Location = New System.Drawing.Point(106, 12)
        Me.rbMaterialLinenWarna.Name = "rbMaterialLinenWarna"
        Me.rbMaterialLinenWarna.Size = New System.Drawing.Size(57, 17)
        Me.rbMaterialLinenWarna.TabIndex = 27
        Me.rbMaterialLinenWarna.TabStop = True
        Me.rbMaterialLinenWarna.Text = "Warna"
        Me.rbMaterialLinenWarna.UseVisualStyleBackColor = False
        '
        'rbMaterialLinenPutih
        '
        Me.rbMaterialLinenPutih.AutoSize = True
        Me.rbMaterialLinenPutih.BackColor = System.Drawing.SystemColors.Control
        Me.rbMaterialLinenPutih.Location = New System.Drawing.Point(4, 12)
        Me.rbMaterialLinenPutih.Name = "rbMaterialLinenPutih"
        Me.rbMaterialLinenPutih.Size = New System.Drawing.Size(49, 17)
        Me.rbMaterialLinenPutih.TabIndex = 26
        Me.rbMaterialLinenPutih.TabStop = True
        Me.rbMaterialLinenPutih.Text = "Putih"
        Me.rbMaterialLinenPutih.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(93, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(93, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(93, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Kode Linen"
        '
        'gbMaterial
        '
        Me.gbMaterial.Controls.Add(Me.rbMaterialLinenWarna)
        Me.gbMaterial.Controls.Add(Me.rbMaterialLinenPutih)
        Me.gbMaterial.Location = New System.Drawing.Point(171, 142)
        Me.gbMaterial.Name = "gbMaterial"
        Me.gbMaterial.Size = New System.Drawing.Size(183, 39)
        Me.gbMaterial.TabIndex = 30
        Me.gbMaterial.TabStop = False
        '
        'txtKodeLinen
        '
        Me.txtKodeLinen.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtKodeLinen.Enabled = False
        Me.txtKodeLinen.Location = New System.Drawing.Point(171, 83)
        Me.txtKodeLinen.Name = "txtKodeLinen"
        Me.txtKodeLinen.Size = New System.Drawing.Size(230, 20)
        Me.txtKodeLinen.TabIndex = 31
        '
        'txtQtyLinen
        '
        Me.txtQtyLinen.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtQtyLinen.BorderColor = System.Drawing.Color.Gray
        Me.txtQtyLinen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQtyLinen.Location = New System.Drawing.Point(171, 189)
        Me.txtQtyLinen.Name = "txtQtyLinen"
        Me.txtQtyLinen.Size = New System.Drawing.Size(230, 18)
        Me.txtQtyLinen.TabIndex = 33
        Me.txtQtyLinen.Tag = Nothing
        Me.txtQtyLinen.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtNamaLinen
        '
        Me.txtNamaLinen.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNamaLinen.Enabled = False
        Me.txtNamaLinen.Location = New System.Drawing.Point(171, 116)
        Me.txtNamaLinen.Name = "txtNamaLinen"
        Me.txtNamaLinen.Size = New System.Drawing.Size(230, 20)
        Me.txtNamaLinen.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(93, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Nama Linen"
        '
        'FormTambahLoadGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 303)
        Me.Controls.Add(Me.txtNamaLinen)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQtyLinen)
        Me.Controls.Add(Me.txtKodeLinen)
        Me.Controls.Add(Me.gbMaterial)
        Me.Controls.Add(Me.btnLookUpLinen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormTambahLoadGudang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormTambahLinen"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.gbMaterial.ResumeLayout(False)
        Me.gbMaterial.PerformLayout()
        CType(Me.txtQtyLinen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As C1.Win.C1Input.C1Button
    Friend WithEvents btnLookUpLinen As System.Windows.Forms.Button
    Friend WithEvents rbMaterialLinenWarna As System.Windows.Forms.RadioButton
    Friend WithEvents rbMaterialLinenPutih As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents txtKodeLinen As System.Windows.Forms.TextBox
    Friend WithEvents txtQtyLinen As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNamaLinen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
