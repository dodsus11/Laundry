<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCHistoryTransaksi
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
        Me.PanelJudul = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.txtPetugasLaundry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_headerid = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.dtpJam = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.txtRuangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvInputLinen = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBack = New C1.Win.C1Input.C1Button()
        Me.PanelJudul.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvInputLinen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
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
        Me.PanelJudul.Margin = New System.Windows.Forms.Padding(4)
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
        Me.PanelHeader.Controls.Add(Me.txtPetugasLaundry)
        Me.PanelHeader.Controls.Add(Me.Label6)
        Me.PanelHeader.Controls.Add(Me.label_headerid)
        Me.PanelHeader.Controls.Add(Me.dtpTgl)
        Me.PanelHeader.Controls.Add(Me.dtpJam)
        Me.PanelHeader.Controls.Add(Me.Label5)
        Me.PanelHeader.Controls.Add(Me.Label4)
        Me.PanelHeader.Controls.Add(Me.Label3)
        Me.PanelHeader.Controls.Add(Me.txtPetugas)
        Me.PanelHeader.Controls.Add(Me.txtRuangan)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 62)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1379, 162)
        Me.PanelHeader.TabIndex = 1
        '
        'txtPetugasLaundry
        '
        Me.txtPetugasLaundry.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPetugasLaundry.Enabled = False
        Me.txtPetugasLaundry.Location = New System.Drawing.Point(196, 128)
        Me.txtPetugasLaundry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugasLaundry.Name = "txtPetugasLaundry"
        Me.txtPetugasLaundry.Size = New System.Drawing.Size(315, 22)
        Me.txtPetugasLaundry.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Petugas Binatu"
        '
        'label_headerid
        '
        Me.label_headerid.AutoSize = True
        Me.label_headerid.Location = New System.Drawing.Point(64, 17)
        Me.label_headerid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_headerid.Name = "label_headerid"
        Me.label_headerid.Size = New System.Drawing.Size(0, 17)
        Me.label_headerid.TabIndex = 12
        Me.label_headerid.Visible = False
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "yyyy/M/dd"
        Me.dtpTgl.Enabled = False
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(773, 31)
        Me.dtpTgl.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(141, 22)
        Me.dtpTgl.TabIndex = 11
        '
        'dtpJam
        '
        Me.dtpJam.CustomFormat = "HH:mm"
        Me.dtpJam.Enabled = False
        Me.dtpJam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJam.Location = New System.Drawing.Point(773, 75)
        Me.dtpJam.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpJam.Name = "dtpJam"
        Me.dtpJam.ShowUpDown = True
        Me.dtpJam.Size = New System.Drawing.Size(141, 22)
        Me.dtpJam.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(692, 79)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(692, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "(House Keeping)"
        '
        'txtPetugas
        '
        Me.txtPetugas.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPetugas.Enabled = False
        Me.txtPetugas.Location = New System.Drawing.Point(196, 75)
        Me.txtPetugas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.Size = New System.Drawing.Size(315, 22)
        Me.txtPetugas.TabIndex = 4
        '
        'txtRuangan
        '
        Me.txtRuangan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtRuangan.Enabled = False
        Me.txtRuangan.Location = New System.Drawing.Point(196, 31)
        Me.txtRuangan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuangan.Name = "txtRuangan"
        Me.txtRuangan.Size = New System.Drawing.Size(315, 22)
        Me.txtRuangan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Petugas Pengantar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ruang"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvInputLinen)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 224)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1379, 526)
        Me.Panel1.TabIndex = 2
        '
        'dgvInputLinen
        '
        Me.dgvInputLinen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInputLinen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInputLinen.Location = New System.Drawing.Point(0, 25)
        Me.dgvInputLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInputLinen.Name = "dgvInputLinen"
        Me.dgvInputLinen.Size = New System.Drawing.Size(1379, 501)
        Me.dgvInputLinen.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1379, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel1.Text = "Item Order"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 695)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1379, 55)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnBack)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1044, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 55)
        Me.Panel3.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(175, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnBack.Size = New System.Drawing.Size(135, 31)
        Me.btnBack.TabIndex = 127
        Me.btnBack.Text = "Kembali"
        Me.btnBack.UseVisualStyleBackColor = True
        Me.btnBack.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnBack.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'UCHistoryTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.PanelJudul)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCHistoryTransaksi"
        Me.Size = New System.Drawing.Size(1379, 750)
        Me.PanelJudul.ResumeLayout(False)
        Me.PanelJudul.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvInputLinen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelJudul As System.Windows.Forms.Panel
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents PanelHeader As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRuangan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvInputLinen As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As C1.Win.C1Input.C1Button
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpJam As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_headerid As System.Windows.Forms.Label
    Friend WithEvents txtPetugasLaundry As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel

End Class
