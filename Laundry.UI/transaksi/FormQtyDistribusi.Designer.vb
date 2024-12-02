<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQtyDistribusi
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKodeLinen = New System.Windows.Forms.TextBox()
        Me.txtNamaLinen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtyOrder = New System.Windows.Forms.TextBox()
        Me.txtQtyDistribusi = New System.Windows.Forms.TextBox()
        Me.txtTerdistribusi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBlmDistr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(93, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nama Linen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(93, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Qty Order"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(93, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Kode Linen"
        '
        'txtKodeLinen
        '
        Me.txtKodeLinen.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtKodeLinen.Enabled = False
        Me.txtKodeLinen.Location = New System.Drawing.Point(187, 52)
        Me.txtKodeLinen.Name = "txtKodeLinen"
        Me.txtKodeLinen.Size = New System.Drawing.Size(230, 20)
        Me.txtKodeLinen.TabIndex = 31
        '
        'txtNamaLinen
        '
        Me.txtNamaLinen.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNamaLinen.Enabled = False
        Me.txtNamaLinen.Location = New System.Drawing.Point(187, 88)
        Me.txtNamaLinen.Name = "txtNamaLinen"
        Me.txtNamaLinen.Size = New System.Drawing.Size(230, 20)
        Me.txtNamaLinen.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(93, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Akan Didistribusi"
        '
        'txtQtyOrder
        '
        Me.txtQtyOrder.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtQtyOrder.Enabled = False
        Me.txtQtyOrder.Location = New System.Drawing.Point(187, 124)
        Me.txtQtyOrder.Name = "txtQtyOrder"
        Me.txtQtyOrder.Size = New System.Drawing.Size(230, 20)
        Me.txtQtyOrder.TabIndex = 36
        '
        'txtQtyDistribusi
        '
        Me.txtQtyDistribusi.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtQtyDistribusi.Location = New System.Drawing.Point(187, 232)
        Me.txtQtyDistribusi.Name = "txtQtyDistribusi"
        Me.txtQtyDistribusi.Size = New System.Drawing.Size(230, 20)
        Me.txtQtyDistribusi.TabIndex = 37
        '
        'txtTerdistribusi
        '
        Me.txtTerdistribusi.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTerdistribusi.Enabled = False
        Me.txtTerdistribusi.Location = New System.Drawing.Point(187, 160)
        Me.txtTerdistribusi.Name = "txtTerdistribusi"
        Me.txtTerdistribusi.Size = New System.Drawing.Size(230, 20)
        Me.txtTerdistribusi.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(93, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Sudah Didistribusi"
        '
        'txtBlmDistr
        '
        Me.txtBlmDistr.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtBlmDistr.Enabled = False
        Me.txtBlmDistr.Location = New System.Drawing.Point(187, 196)
        Me.txtBlmDistr.Name = "txtBlmDistr"
        Me.txtBlmDistr.Size = New System.Drawing.Size(230, 20)
        Me.txtBlmDistr.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(93, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Belum Didistribusi"
        '
        'FormQtyDistribusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 303)
        Me.Controls.Add(Me.txtBlmDistr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTerdistribusi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQtyDistribusi)
        Me.Controls.Add(Me.txtQtyOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNamaLinen)
        Me.Controls.Add(Me.txtKodeLinen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormQtyDistribusi"
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKodeLinen As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaLinen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQtyOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtQtyDistribusi As System.Windows.Forms.TextBox
    Friend WithEvents txtTerdistribusi As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBlmDistr As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
