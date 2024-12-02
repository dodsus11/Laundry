<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahLinenSetrika
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
        Me.txtLinenBersih = New System.Windows.Forms.TextBox()
        Me.txtLinenRusak = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLinenReject = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.btnSimpan.Location = New System.Drawing.Point(597, 11)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(135, 31)
        Me.btnSimpan.TabIndex = 127
        Me.btnSimpan.Text = "Tambah"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnLookUpLinen
        '
        Me.btnLookUpLinen.Location = New System.Drawing.Point(579, 102)
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
        Me.Label2.Location = New System.Drawing.Point(95, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Jumlah Linen Bersih"
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
        Me.txtNamaLinen.Size = New System.Drawing.Size(305, 22)
        Me.txtNamaLinen.TabIndex = 31
        '
        'txtLinenBersih
        '
        Me.txtLinenBersih.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLinenBersih.Location = New System.Drawing.Point(267, 148)
        Me.txtLinenBersih.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinenBersih.Name = "txtLinenBersih"
        Me.txtLinenBersih.Size = New System.Drawing.Size(305, 22)
        Me.txtLinenBersih.TabIndex = 32
        '
        'txtLinenRusak
        '
        Me.txtLinenRusak.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLinenRusak.Location = New System.Drawing.Point(267, 193)
        Me.txtLinenRusak.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinenRusak.Name = "txtLinenRusak"
        Me.txtLinenRusak.Size = New System.Drawing.Size(305, 22)
        Me.txtLinenRusak.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(95, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Jumlah Linen Rusak"
        '
        'txtLinenReject
        '
        Me.txtLinenReject.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtLinenReject.Location = New System.Drawing.Point(267, 239)
        Me.txtLinenReject.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLinenReject.Name = "txtLinenReject"
        Me.txtLinenReject.Size = New System.Drawing.Size(305, 22)
        Me.txtLinenReject.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(95, 242)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Jumlah Linen Reject"
        '
        'FormTambahLinenSetrika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 373)
        Me.Controls.Add(Me.txtLinenReject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLinenRusak)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLinenBersih)
        Me.Controls.Add(Me.txtNamaLinen)
        Me.Controls.Add(Me.btnLookUpLinen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormTambahLinenSetrika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormTambahLinenSetrika"
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
    Friend WithEvents txtLinenBersih As System.Windows.Forms.TextBox
    Friend WithEvents txtLinenRusak As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLinenReject As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
