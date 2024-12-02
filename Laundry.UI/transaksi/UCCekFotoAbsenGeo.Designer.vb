<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCekFotoAbsenGeo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelNamaPeg = New System.Windows.Forms.Panel()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.PanelDgv = New System.Windows.Forms.Panel()
        Me.PanelDisplayGeo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelJudulFotoGeo = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelDisplaySimpeg = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelJudulFotoSimpeg = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelNamaPeg.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDgv.SuspendLayout()
        Me.PanelDisplayGeo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelJudulFotoGeo.SuspendLayout()
        Me.PanelDisplaySimpeg.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelJudulFotoSimpeg.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1189, 62)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CEK FOTO ABSENSI GEOTAGGING"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightBlue
        Me.Panel4.Controls.Add(Me.PanelNamaPeg)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtNip)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.dtpTanggal)
        Me.Panel4.Controls.Add(Me.btnTampil)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 62)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1189, 47)
        Me.Panel4.TabIndex = 5
        '
        'PanelNamaPeg
        '
        Me.PanelNamaPeg.Controls.Add(Me.LabelNama)
        Me.PanelNamaPeg.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelNamaPeg.Location = New System.Drawing.Point(647, 0)
        Me.PanelNamaPeg.Name = "PanelNamaPeg"
        Me.PanelNamaPeg.Size = New System.Drawing.Size(542, 47)
        Me.PanelNamaPeg.TabIndex = 11
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNama.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelNama.Location = New System.Drawing.Point(13, 12)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(0, 25)
        Me.LabelNama.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tanggal"
        '
        'txtNip
        '
        Me.txtNip.Location = New System.Drawing.Point(50, 14)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.Size = New System.Drawing.Size(227, 22)
        Me.txtNip.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "NIP"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.CustomFormat = "dd/MM/yyyy"
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(373, 14)
        Me.dtpTanggal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(135, 22)
        Me.dtpTanggal.TabIndex = 7
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(529, 11)
        Me.btnTampil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(111, 28)
        Me.btnTampil.TabIndex = 3
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(336, 550)
        Me.dgv.TabIndex = 7
        '
        'PanelDgv
        '
        Me.PanelDgv.Controls.Add(Me.dgv)
        Me.PanelDgv.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDgv.Location = New System.Drawing.Point(0, 109)
        Me.PanelDgv.Name = "PanelDgv"
        Me.PanelDgv.Size = New System.Drawing.Size(336, 550)
        Me.PanelDgv.TabIndex = 8
        '
        'PanelDisplayGeo
        '
        Me.PanelDisplayGeo.Controls.Add(Me.PictureBox1)
        Me.PanelDisplayGeo.Controls.Add(Me.PanelJudulFotoGeo)
        Me.PanelDisplayGeo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelDisplayGeo.Location = New System.Drawing.Point(336, 109)
        Me.PanelDisplayGeo.Name = "PanelDisplayGeo"
        Me.PanelDisplayGeo.Size = New System.Drawing.Size(835, 550)
        Me.PanelDisplayGeo.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(835, 519)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelJudulFotoGeo
        '
        Me.PanelJudulFotoGeo.BackColor = System.Drawing.Color.LightCyan
        Me.PanelJudulFotoGeo.Controls.Add(Me.Label4)
        Me.PanelJudulFotoGeo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelJudulFotoGeo.Location = New System.Drawing.Point(0, 0)
        Me.PanelJudulFotoGeo.Name = "PanelJudulFotoGeo"
        Me.PanelJudulFotoGeo.Size = New System.Drawing.Size(835, 31)
        Me.PanelJudulFotoGeo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Foto Geotagging"
        '
        'PanelDisplaySimpeg
        '
        Me.PanelDisplaySimpeg.Controls.Add(Me.PictureBox2)
        Me.PanelDisplaySimpeg.Controls.Add(Me.PanelJudulFotoSimpeg)
        Me.PanelDisplaySimpeg.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelDisplaySimpeg.Location = New System.Drawing.Point(386, 109)
        Me.PanelDisplaySimpeg.Name = "PanelDisplaySimpeg"
        Me.PanelDisplaySimpeg.Size = New System.Drawing.Size(803, 550)
        Me.PanelDisplaySimpeg.TabIndex = 10
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(803, 519)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PanelJudulFotoSimpeg
        '
        Me.PanelJudulFotoSimpeg.BackColor = System.Drawing.Color.LightCyan
        Me.PanelJudulFotoSimpeg.Controls.Add(Me.Label5)
        Me.PanelJudulFotoSimpeg.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelJudulFotoSimpeg.Location = New System.Drawing.Point(0, 0)
        Me.PanelJudulFotoSimpeg.Name = "PanelJudulFotoSimpeg"
        Me.PanelJudulFotoSimpeg.Size = New System.Drawing.Size(803, 31)
        Me.PanelJudulFotoSimpeg.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Foto Simpeg"
        '
        'UCCekFotoAbsenGeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelDisplaySimpeg)
        Me.Controls.Add(Me.PanelDisplayGeo)
        Me.Controls.Add(Me.PanelDgv)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UCCekFotoAbsenGeo"
        Me.Size = New System.Drawing.Size(1189, 659)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelNamaPeg.ResumeLayout(False)
        Me.PanelNamaPeg.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDgv.ResumeLayout(False)
        Me.PanelDisplayGeo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelJudulFotoGeo.ResumeLayout(False)
        Me.PanelJudulFotoGeo.PerformLayout()
        Me.PanelDisplaySimpeg.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelJudulFotoSimpeg.ResumeLayout(False)
        Me.PanelJudulFotoSimpeg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PanelDgv As System.Windows.Forms.Panel
    Friend WithEvents PanelDisplayGeo As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelJudulFotoGeo As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelDisplaySimpeg As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelJudulFotoSimpeg As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PanelNamaPeg As System.Windows.Forms.Panel
    Friend WithEvents LabelNama As System.Windows.Forms.Label

End Class
