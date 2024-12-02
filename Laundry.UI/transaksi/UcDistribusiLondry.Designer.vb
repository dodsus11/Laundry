<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcDistribusiLondry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcDistribusiLondry))
        Me.PanelJudul = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.txtSubRuang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.label_noOrder = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.dtpJam = New System.Windows.Forms.DateTimePicker()
        Me.Label_jam = New System.Windows.Forms.Label()
        Me.Label_tanggal = New System.Windows.Forms.Label()
        Me.Label_petugas2 = New System.Windows.Forms.Label()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.txtRuangan = New System.Windows.Forms.TextBox()
        Me.Label_petugas1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgvInputLinen = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripEdit = New System.Windows.Forms.ToolStripButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBatal = New C1.Win.C1Input.C1Button()
        Me.btnSimpan = New C1.Win.C1Input.C1Button()
        Me.PanelJudul.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvInputLinen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelJudul
        '
        Me.PanelJudul.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelJudul.Controls.Add(Me.LabelJudul)
        Me.PanelJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelJudul.Location = New System.Drawing.Point(0, 0)
        Me.PanelJudul.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelJudul.Name = "PanelJudul"
        Me.PanelJudul.Size = New System.Drawing.Size(1379, 62)
        Me.PanelJudul.TabIndex = 0
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelJudul.Location = New System.Drawing.Point(21, 18)
        Me.LabelJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(0, 25)
        Me.LabelJudul.TabIndex = 0
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.txtSubRuang)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Controls.Add(Me.txtNoOrder)
        Me.PanelHeader.Controls.Add(Me.label_noOrder)
        Me.PanelHeader.Controls.Add(Me.dtpTgl)
        Me.PanelHeader.Controls.Add(Me.dtpJam)
        Me.PanelHeader.Controls.Add(Me.Label_jam)
        Me.PanelHeader.Controls.Add(Me.Label_tanggal)
        Me.PanelHeader.Controls.Add(Me.Label_petugas2)
        Me.PanelHeader.Controls.Add(Me.txtPetugas)
        Me.PanelHeader.Controls.Add(Me.txtRuangan)
        Me.PanelHeader.Controls.Add(Me.Label_petugas1)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 62)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1379, 162)
        Me.PanelHeader.TabIndex = 1
        '
        'txtSubRuang
        '
        Me.txtSubRuang.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSubRuang.Enabled = False
        Me.txtSubRuang.Location = New System.Drawing.Point(817, 53)
        Me.txtSubRuang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSubRuang.Name = "txtSubRuang"
        Me.txtSubRuang.Size = New System.Drawing.Size(264, 22)
        Me.txtSubRuang.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(695, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Sub Ruang"
        '
        'txtNoOrder
        '
        Me.txtNoOrder.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNoOrder.Enabled = False
        Me.txtNoOrder.Location = New System.Drawing.Point(191, 32)
        Me.txtNoOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.Size = New System.Drawing.Size(315, 22)
        Me.txtNoOrder.TabIndex = 13
        '
        'label_noOrder
        '
        Me.label_noOrder.AutoSize = True
        Me.label_noOrder.Location = New System.Drawing.Point(63, 36)
        Me.label_noOrder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_noOrder.Name = "label_noOrder"
        Me.label_noOrder.Size = New System.Drawing.Size(67, 17)
        Me.label_noOrder.TabIndex = 12
        Me.label_noOrder.Text = "No Order"
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "yyyy/M/dd"
        Me.dtpTgl.Enabled = False
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(817, 85)
        Me.dtpTgl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(141, 22)
        Me.dtpTgl.TabIndex = 11
        '
        'dtpJam
        '
        Me.dtpJam.CustomFormat = "HH:mm"
        Me.dtpJam.Enabled = False
        Me.dtpJam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJam.Location = New System.Drawing.Point(817, 117)
        Me.dtpJam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpJam.Name = "dtpJam"
        Me.dtpJam.ShowUpDown = True
        Me.dtpJam.Size = New System.Drawing.Size(141, 22)
        Me.dtpJam.TabIndex = 10
        '
        'Label_jam
        '
        Me.Label_jam.AutoSize = True
        Me.Label_jam.Location = New System.Drawing.Point(695, 121)
        Me.Label_jam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_jam.Name = "Label_jam"
        Me.Label_jam.Size = New System.Drawing.Size(94, 17)
        Me.Label_jam.TabIndex = 8
        Me.Label_jam.Text = "Jam distribusi"
        '
        'Label_tanggal
        '
        Me.Label_tanggal.AutoSize = True
        Me.Label_tanggal.Location = New System.Drawing.Point(692, 89)
        Me.Label_tanggal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_tanggal.Name = "Label_tanggal"
        Me.Label_tanggal.Size = New System.Drawing.Size(120, 17)
        Me.Label_tanggal.TabIndex = 6
        Me.Label_tanggal.Text = "Tanggal distribusi"
        '
        'Label_petugas2
        '
        Me.Label_petugas2.AutoSize = True
        Me.Label_petugas2.Location = New System.Drawing.Point(63, 102)
        Me.Label_petugas2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_petugas2.Name = "Label_petugas2"
        Me.Label_petugas2.Size = New System.Drawing.Size(115, 17)
        Me.Label_petugas2.TabIndex = 5
        Me.Label_petugas2.Text = "(House Keeping)"
        '
        'txtPetugas
        '
        Me.txtPetugas.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPetugas.Location = New System.Drawing.Point(191, 75)
        Me.txtPetugas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.Size = New System.Drawing.Size(315, 22)
        Me.txtPetugas.TabIndex = 4
        '
        'txtRuangan
        '
        Me.txtRuangan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtRuangan.Enabled = False
        Me.txtRuangan.Location = New System.Drawing.Point(817, 19)
        Me.txtRuangan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRuangan.Name = "txtRuangan"
        Me.txtRuangan.Size = New System.Drawing.Size(264, 22)
        Me.txtRuangan.TabIndex = 2
        '
        'Label_petugas1
        '
        Me.Label_petugas1.AutoSize = True
        Me.Label_petugas1.Location = New System.Drawing.Point(63, 79)
        Me.Label_petugas1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_petugas1.Name = "Label_petugas1"
        Me.Label_petugas1.Size = New System.Drawing.Size(123, 17)
        Me.Label_petugas1.TabIndex = 1
        Me.Label_petugas1.Text = "Petugas penerima"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(695, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruang"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 224)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1379, 526)
        Me.Panel1.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgvInputLinen)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 33)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1379, 436)
        Me.Panel6.TabIndex = 6
        '
        'dgvInputLinen
        '
        Me.dgvInputLinen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInputLinen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInputLinen.Location = New System.Drawing.Point(0, 0)
        Me.dgvInputLinen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvInputLinen.Name = "dgvInputLinen"
        Me.dgvInputLinen.Size = New System.Drawing.Size(1379, 436)
        Me.dgvInputLinen.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ToolStrip1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1379, 33)
        Me.Panel5.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1379, 33)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripEdit
        '
        Me.ToolStripEdit.Image = CType(resources.GetObject("ToolStripEdit.Image"), System.Drawing.Image)
        Me.ToolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEdit.Name = "ToolStripEdit"
        Me.ToolStripEdit.Size = New System.Drawing.Size(55, 30)
        Me.ToolStripEdit.Text = "Edit"
        Me.ToolStripEdit.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 469)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1379, 57)
        Me.Panel4.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1379, 57)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnBatal)
        Me.Panel3.Controls.Add(Me.btnSimpan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1044, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 57)
        Me.Panel3.TabIndex = 0
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(175, 14)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnBatal.Size = New System.Drawing.Size(135, 31)
        Me.btnBatal.TabIndex = 127
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        Me.btnBatal.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnBatal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(16, 14)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(135, 31)
        Me.btnSimpan.TabIndex = 126
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'UcDistribusiLondry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.PanelJudul)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UcDistribusiLondry"
        Me.Size = New System.Drawing.Size(1379, 750)
        Me.PanelJudul.ResumeLayout(False)
        Me.PanelJudul.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgvInputLinen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelJudul As System.Windows.Forms.Panel
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label_petugas1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRuangan As System.Windows.Forms.TextBox
    Friend WithEvents Label_jam As System.Windows.Forms.Label
    Friend WithEvents Label_tanggal As System.Windows.Forms.Label
    Friend WithEvents Label_petugas2 As System.Windows.Forms.Label
    Friend WithEvents txtPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvInputLinen As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As C1.Win.C1Input.C1Button
    Friend WithEvents btnSimpan As C1.Win.C1Input.C1Button
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpJam As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_noOrder As System.Windows.Forms.Label
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtSubRuang As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel

End Class
