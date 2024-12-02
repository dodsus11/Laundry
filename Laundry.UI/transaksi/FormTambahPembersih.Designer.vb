<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahPembersih
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
        Me.txtNamaPembersih = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtyPembersih = New System.Windows.Forms.TextBox()
        Me.beratlinen = New System.Windows.Forms.Label()
        Me.jenislinen = New System.Windows.Forms.Label()
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
        Me.Label1.Size = New System.Drawing.Size(286, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JENIS DAN KAPASITAS PEMBERSIH"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(93, 126)
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
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama Pembersih"
        '
        'txtNamaPembersih
        '
        Me.txtNamaPembersih.Enabled = False
        Me.txtNamaPembersih.Location = New System.Drawing.Point(186, 83)
        Me.txtNamaPembersih.Name = "txtNamaPembersih"
        Me.txtNamaPembersih.Size = New System.Drawing.Size(215, 20)
        Me.txtNamaPembersih.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(280, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Cc"
        '
        'txtQtyPembersih
        '
        Me.txtQtyPembersih.Enabled = False
        Me.txtQtyPembersih.Location = New System.Drawing.Point(186, 123)
        Me.txtQtyPembersih.Name = "txtQtyPembersih"
        Me.txtQtyPembersih.Size = New System.Drawing.Size(94, 20)
        Me.txtQtyPembersih.TabIndex = 33
        '
        'beratlinen
        '
        Me.beratlinen.AutoSize = True
        Me.beratlinen.BackColor = System.Drawing.SystemColors.Control
        Me.beratlinen.Location = New System.Drawing.Point(93, 55)
        Me.beratlinen.Name = "beratlinen"
        Me.beratlinen.Size = New System.Drawing.Size(0, 13)
        Me.beratlinen.TabIndex = 34
        Me.beratlinen.Visible = False
        '
        'jenislinen
        '
        Me.jenislinen.AutoSize = True
        Me.jenislinen.BackColor = System.Drawing.SystemColors.Control
        Me.jenislinen.Location = New System.Drawing.Point(183, 55)
        Me.jenislinen.Name = "jenislinen"
        Me.jenislinen.Size = New System.Drawing.Size(0, 13)
        Me.jenislinen.TabIndex = 35
        Me.jenislinen.Visible = False
        '
        'FormTambahPembersih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 303)
        Me.Controls.Add(Me.jenislinen)
        Me.Controls.Add(Me.beratlinen)
        Me.Controls.Add(Me.txtQtyPembersih)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNamaPembersih)
        Me.Controls.Add(Me.btnLookUpLinen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormTambahPembersih"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
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
    Friend WithEvents txtNamaPembersih As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQtyPembersih As System.Windows.Forms.TextBox
    Friend WithEvents beratlinen As System.Windows.Forms.Label
    Friend WithEvents jenislinen As System.Windows.Forms.Label
End Class
