<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahInv
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNamaLinen = New System.Windows.Forms.TextBox()
        Me.txtJmlSimpan = New System.Windows.Forms.TextBox()
        Me.txtJmlPakai = New System.Windows.Forms.TextBox()
        Me.txtJmlCuci = New System.Windows.Forms.TextBox()
        Me.txtJmlKotor = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnLookUpLinen = New System.Windows.Forms.Button()
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
        Me.Panel1.Size = New System.Drawing.Size(720, 60)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(24, 16)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 402)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 60)
        Me.Panel2.TabIndex = 2
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(504, 12)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(152, 35)
        Me.btnSimpan.TabIndex = 127
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Linen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(92, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jml Disimpan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Jml Dipakai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Jml Dicucikan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jml Kotor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(92, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Linen"
        '
        'txtNamaLinen
        '
        Me.txtNamaLinen.Location = New System.Drawing.Point(268, 84)
        Me.txtNamaLinen.Name = "txtNamaLinen"
        Me.txtNamaLinen.Size = New System.Drawing.Size(318, 26)
        Me.txtNamaLinen.TabIndex = 9
        '
        'txtJmlSimpan
        '
        Me.txtJmlSimpan.Location = New System.Drawing.Point(268, 138)
        Me.txtJmlSimpan.Name = "txtJmlSimpan"
        Me.txtJmlSimpan.Size = New System.Drawing.Size(165, 26)
        Me.txtJmlSimpan.TabIndex = 10
        '
        'txtJmlPakai
        '
        Me.txtJmlPakai.Location = New System.Drawing.Point(268, 188)
        Me.txtJmlPakai.Name = "txtJmlPakai"
        Me.txtJmlPakai.Size = New System.Drawing.Size(165, 26)
        Me.txtJmlPakai.TabIndex = 11
        '
        'txtJmlCuci
        '
        Me.txtJmlCuci.Location = New System.Drawing.Point(268, 234)
        Me.txtJmlCuci.Name = "txtJmlCuci"
        Me.txtJmlCuci.Size = New System.Drawing.Size(165, 26)
        Me.txtJmlCuci.TabIndex = 12
        '
        'txtJmlKotor
        '
        Me.txtJmlKotor.Location = New System.Drawing.Point(268, 282)
        Me.txtJmlKotor.Name = "txtJmlKotor"
        Me.txtJmlKotor.Size = New System.Drawing.Size(165, 26)
        Me.txtJmlKotor.TabIndex = 13
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(268, 333)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(165, 26)
        Me.txtTotal.TabIndex = 14
        '
        'btnLookUpLinen
        '
        Me.btnLookUpLinen.Location = New System.Drawing.Point(616, 86)
        Me.btnLookUpLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLookUpLinen.Name = "btnLookUpLinen"
        Me.btnLookUpLinen.Size = New System.Drawing.Size(40, 26)
        Me.btnLookUpLinen.TabIndex = 29
        Me.btnLookUpLinen.Text = "..."
        Me.btnLookUpLinen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLookUpLinen.UseVisualStyleBackColor = True
        '
        'FormTambahInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 462)
        Me.Controls.Add(Me.btnLookUpLinen)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtJmlKotor)
        Me.Controls.Add(Me.txtJmlCuci)
        Me.Controls.Add(Me.txtJmlPakai)
        Me.Controls.Add(Me.txtJmlSimpan)
        Me.Controls.Add(Me.txtNamaLinen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormTambahInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTambahInv"
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNamaLinen As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlSimpan As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlPakai As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlCuci As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlKotor As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnLookUpLinen As System.Windows.Forms.Button
End Class
