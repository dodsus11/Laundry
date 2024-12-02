<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucUserAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUserAdd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLookUp = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtUn = New C1.Win.C1Input.C1TextBox()
        Me.txtRole = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLUPegawai = New System.Windows.Forms.Button()
        Me.btnHapusKaryawan = New System.Windows.Forms.Button()
        Me.txtPoli = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLUPoli = New C1.Win.C1Input.C1Button()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.seTemp = New UILibs.SaveEditTemp()
        Me.txtNamaLengkap = New C1.Win.C1Input.C1TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPasswd1 = New System.Windows.Forms.TextBox()
        Me.txtPasswd2 = New System.Windows.Forms.TextBox()
        Me.btnLookPeg = New System.Windows.Forms.Button()
        Me.txtBagian = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtJenisPeg = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNamaPegawai = New System.Windows.Forms.TextBox()
        Me.txtNip = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.txtUn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaLengkap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Role :"
        '
        'btnLookUp
        '
        Me.btnLookUp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLookUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLookUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnLookUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLookUp.ImageIndex = 3
        Me.btnLookUp.ImageList = Me.ImageList1
        Me.btnLookUp.Location = New System.Drawing.Point(476, 271)
        Me.btnLookUp.Name = "btnLookUp"
        Me.btnLookUp.Size = New System.Drawing.Size(40, 22)
        Me.btnLookUp.TabIndex = 14
        Me.btnLookUp.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Search.gif")
        Me.ImageList1.Images.SetKeyName(1, "search.ico")
        Me.ImageList1.Images.SetKeyName(2, "Search.png")
        Me.ImageList1.Images.SetKeyName(3, "Right.png")
        '
        'txtUn
        '
        Me.txtUn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtUn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUn.Location = New System.Drawing.Point(160, 66)
        Me.txtUn.Multiline = True
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(305, 20)
        Me.txtUn.TabIndex = 0
        Me.txtUn.Tag = Nothing
        Me.txtUn.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtUn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtRole
        '
        Me.txtRole.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.Location = New System.Drawing.Point(160, 273)
        Me.txtRole.Multiline = True
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(305, 20)
        Me.txtRole.TabIndex = 5
        Me.txtRole.Tag = Nothing
        Me.txtRole.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtRole.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Pegawai :"
        Me.Label5.Visible = False
        '
        'btnLUPegawai
        '
        Me.btnLUPegawai.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLUPegawai.Location = New System.Drawing.Point(476, 360)
        Me.btnLUPegawai.Name = "btnLUPegawai"
        Me.btnLUPegawai.Size = New System.Drawing.Size(40, 22)
        Me.btnLUPegawai.TabIndex = 13
        Me.btnLUPegawai.Text = "..."
        Me.btnLUPegawai.UseVisualStyleBackColor = False
        Me.btnLUPegawai.Visible = False
        '
        'btnHapusKaryawan
        '
        Me.btnHapusKaryawan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHapusKaryawan.Location = New System.Drawing.Point(519, 360)
        Me.btnHapusKaryawan.Name = "btnHapusKaryawan"
        Me.btnHapusKaryawan.Size = New System.Drawing.Size(40, 22)
        Me.btnHapusKaryawan.TabIndex = 16
        Me.btnHapusKaryawan.Text = "X"
        Me.btnHapusKaryawan.UseVisualStyleBackColor = False
        Me.btnHapusKaryawan.Visible = False
        '
        'txtPoli
        '
        Me.txtPoli.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtPoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoli.Location = New System.Drawing.Point(160, 299)
        Me.txtPoli.Name = "txtPoli"
        Me.txtPoli.Size = New System.Drawing.Size(305, 19)
        Me.txtPoli.TabIndex = 6
        Me.txtPoli.Tag = Nothing
        Me.txtPoli.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtPoli.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Poli :"
        '
        'btnLUPoli
        '
        Me.btnLUPoli.Location = New System.Drawing.Point(476, 297)
        Me.btnLUPoli.Name = "btnLUPoli"
        Me.btnLUPoli.Size = New System.Drawing.Size(31, 23)
        Me.btnLUPoli.TabIndex = 19
        Me.btnLUPoli.Text = "..."
        Me.btnLUPoli.UseVisualStyleBackColor = True
        Me.btnLUPoli.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.btnLUPoli.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(514, 297)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(31, 23)
        Me.C1Button1.TabIndex = 20
        Me.C1Button1.Text = "X"
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'seTemp
        '
        Me.seTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.seTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seTemp.Location = New System.Drawing.Point(0, 0)
        Me.seTemp.Name = "seTemp"
        Me.seTemp.Size = New System.Drawing.Size(892, 450)
        Me.seTemp.TabIndex = 7
        '
        'txtNamaLengkap
        '
        Me.txtNamaLengkap.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtNamaLengkap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaLengkap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNamaLengkap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaLengkap.Location = New System.Drawing.Point(160, 92)
        Me.txtNamaLengkap.Multiline = True
        Me.txtNamaLengkap.Name = "txtNamaLengkap"
        Me.txtNamaLengkap.Size = New System.Drawing.Size(305, 20)
        Me.txtNamaLengkap.TabIndex = 1
        Me.txtNamaLengkap.Tag = Nothing
        Me.txtNamaLengkap.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtNamaLengkap.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Nama Lengkap :"
        '
        'txtPasswd1
        '
        Me.txtPasswd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswd1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswd1.Location = New System.Drawing.Point(160, 119)
        Me.txtPasswd1.Name = "txtPasswd1"
        Me.txtPasswd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd1.Size = New System.Drawing.Size(305, 21)
        Me.txtPasswd1.TabIndex = 2
        '
        'txtPasswd2
        '
        Me.txtPasswd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswd2.Location = New System.Drawing.Point(160, 144)
        Me.txtPasswd2.Name = "txtPasswd2"
        Me.txtPasswd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswd2.Size = New System.Drawing.Size(305, 21)
        Me.txtPasswd2.TabIndex = 3
        '
        'btnLookPeg
        '
        Me.btnLookPeg.Location = New System.Drawing.Point(470, 90)
        Me.btnLookPeg.Name = "btnLookPeg"
        Me.btnLookPeg.Size = New System.Drawing.Size(36, 23)
        Me.btnLookPeg.TabIndex = 22
        Me.btnLookPeg.Text = "..."
        Me.btnLookPeg.UseVisualStyleBackColor = True
        '
        'txtBagian
        '
        Me.txtBagian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBagian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBagian.Location = New System.Drawing.Point(160, 200)
        Me.txtBagian.Name = "txtBagian"
        Me.txtBagian.ReadOnly = True
        Me.txtBagian.Size = New System.Drawing.Size(305, 21)
        Me.txtBagian.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Bagian/Ruang :"
        '
        'txtJenisPeg
        '
        Me.txtJenisPeg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJenisPeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenisPeg.Location = New System.Drawing.Point(160, 227)
        Me.txtJenisPeg.Name = "txtJenisPeg"
        Me.txtJenisPeg.ReadOnly = True
        Me.txtJenisPeg.Size = New System.Drawing.Size(148, 21)
        Me.txtJenisPeg.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Jenis Pegawai :"
        '
        'txtNamaPegawai
        '
        Me.txtNamaPegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaPegawai.Location = New System.Drawing.Point(165, 360)
        Me.txtNamaPegawai.Name = "txtNamaPegawai"
        Me.txtNamaPegawai.ReadOnly = True
        Me.txtNamaPegawai.Size = New System.Drawing.Size(305, 21)
        Me.txtNamaPegawai.TabIndex = 27
        Me.txtNamaPegawai.Visible = False
        '
        'txtNip
        '
        Me.txtNip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNip.Location = New System.Drawing.Point(160, 173)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.ReadOnly = True
        Me.txtNip.Size = New System.Drawing.Size(305, 21)
        Me.txtNip.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 15)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Nip :"
        '
        'ucUserAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtNip)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNamaPegawai)
        Me.Controls.Add(Me.txtJenisPeg)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBagian)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnLookPeg)
        Me.Controls.Add(Me.txtPasswd2)
        Me.Controls.Add(Me.txtPasswd1)
        Me.Controls.Add(Me.txtNamaLengkap)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.btnLUPoli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPoli)
        Me.Controls.Add(Me.btnHapusKaryawan)
        Me.Controls.Add(Me.btnLUPegawai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.txtUn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLookUp)
        Me.Controls.Add(Me.seTemp)
        Me.Name = "ucUserAdd"
        Me.Size = New System.Drawing.Size(892, 450)
        CType(Me.txtUn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaLengkap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents seTemp As UILibs.SaveEditTemp
    Friend WithEvents btnLookUp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtUn As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtRole As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnLUPegawai As System.Windows.Forms.Button
    Friend WithEvents btnHapusKaryawan As System.Windows.Forms.Button
    Friend WithEvents txtPoli As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLUPoli As C1.Win.C1Input.C1Button
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents txtNamaLengkap As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPasswd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPasswd2 As System.Windows.Forms.TextBox
    Friend WithEvents btnLookPeg As System.Windows.Forms.Button
    Friend WithEvents txtBagian As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJenisPeg As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNamaPegawai As System.Windows.Forms.TextBox
    Friend WithEvents txtNip As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
