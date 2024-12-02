<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInputOrderLondry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCInputOrderLondry))
        Me.PanelJudul = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.txtNoOrder = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBrtLinenTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubRuang = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPetugasLaundry = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_headerid = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.dtpJam = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.btnRuang = New System.Windows.Forms.Button()
        Me.txtRuangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvInputLinen = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDelete = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBatal = New C1.Win.C1Input.C1Button()
        Me.btnSimpan = New C1.Win.C1Input.C1Button()
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
        Me.PanelJudul.Size = New System.Drawing.Size(1379, 54)
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
        Me.PanelHeader.Controls.Add(Me.txtNoOrder)
        Me.PanelHeader.Controls.Add(Me.Label10)
        Me.PanelHeader.Controls.Add(Me.Label9)
        Me.PanelHeader.Controls.Add(Me.txtBrtLinenTotal)
        Me.PanelHeader.Controls.Add(Me.Label8)
        Me.PanelHeader.Controls.Add(Me.txtSubRuang)
        Me.PanelHeader.Controls.Add(Me.Label7)
        Me.PanelHeader.Controls.Add(Me.txtPetugasLaundry)
        Me.PanelHeader.Controls.Add(Me.Label6)
        Me.PanelHeader.Controls.Add(Me.label_headerid)
        Me.PanelHeader.Controls.Add(Me.dtpTgl)
        Me.PanelHeader.Controls.Add(Me.dtpJam)
        Me.PanelHeader.Controls.Add(Me.Label5)
        Me.PanelHeader.Controls.Add(Me.Label4)
        Me.PanelHeader.Controls.Add(Me.Label3)
        Me.PanelHeader.Controls.Add(Me.txtPetugas)
        Me.PanelHeader.Controls.Add(Me.btnRuang)
        Me.PanelHeader.Controls.Add(Me.txtRuangan)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 54)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1379, 189)
        Me.PanelHeader.TabIndex = 1
        '
        'txtNoOrder
        '
        Me.txtNoOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNoOrder.Location = New System.Drawing.Point(206, 9)
        Me.txtNoOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoOrder.Name = "txtNoOrder"
        Me.txtNoOrder.ReadOnly = True
        Me.txtNoOrder.Size = New System.Drawing.Size(315, 22)
        Me.txtNoOrder.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(73, 13)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "No Order"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(951, 128)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Kg"
        '
        'txtBrtLinenTotal
        '
        Me.txtBrtLinenTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtBrtLinenTotal.Enabled = False
        Me.txtBrtLinenTotal.Location = New System.Drawing.Point(827, 128)
        Me.txtBrtLinenTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBrtLinenTotal.Name = "txtBrtLinenTotal"
        Me.txtBrtLinenTotal.Size = New System.Drawing.Size(116, 22)
        Me.txtBrtLinenTotal.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(692, 128)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Berat Linen Total"
        '
        'txtSubRuang
        '
        Me.txtSubRuang.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSubRuang.Location = New System.Drawing.Point(206, 71)
        Me.txtSubRuang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubRuang.Name = "txtSubRuang"
        Me.txtSubRuang.ReadOnly = True
        Me.txtSubRuang.Size = New System.Drawing.Size(315, 22)
        Me.txtSubRuang.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(73, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sub Ruang"
        Me.Label7.Visible = False
        '
        'txtPetugasLaundry
        '
        Me.txtPetugasLaundry.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPetugasLaundry.Enabled = False
        Me.txtPetugasLaundry.Location = New System.Drawing.Point(206, 150)
        Me.txtPetugasLaundry.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugasLaundry.Name = "txtPetugasLaundry"
        Me.txtPetugasLaundry.Size = New System.Drawing.Size(315, 22)
        Me.txtPetugasLaundry.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 153)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Petugas Binatu"
        '
        'label_headerid
        '
        Me.label_headerid.AutoSize = True
        Me.label_headerid.Location = New System.Drawing.Point(74, 39)
        Me.label_headerid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_headerid.Name = "label_headerid"
        Me.label_headerid.Size = New System.Drawing.Size(0, 17)
        Me.label_headerid.TabIndex = 12
        Me.label_headerid.Visible = False
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "dd/MM/yyyy"
        Me.dtpTgl.Enabled = False
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(827, 31)
        Me.dtpTgl.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTgl.MaxDate = New Date(2150, 12, 31, 0, 0, 0, 0)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(141, 22)
        Me.dtpTgl.TabIndex = 10
        Me.dtpTgl.Value = New Date(2023, 1, 31, 0, 0, 0, 0)
        '
        'dtpJam
        '
        Me.dtpJam.CustomFormat = "HH:mm:ss"
        Me.dtpJam.Enabled = False
        Me.dtpJam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJam.Location = New System.Drawing.Point(827, 79)
        Me.dtpJam.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpJam.MaxDate = New Date(2150, 12, 31, 0, 0, 0, 0)
        Me.dtpJam.Name = "dtpJam"
        Me.dtpJam.ShowUpDown = True
        Me.dtpJam.Size = New System.Drawing.Size(141, 22)
        Me.dtpJam.TabIndex = 11
        Me.dtpJam.Value = New Date(2023, 1, 31, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(692, 83)
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
        Me.Label3.Location = New System.Drawing.Point(73, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "(House Keeping)"
        '
        'txtPetugas
        '
        Me.txtPetugas.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPetugas.Location = New System.Drawing.Point(206, 102)
        Me.txtPetugas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.Size = New System.Drawing.Size(315, 22)
        Me.txtPetugas.TabIndex = 4
        '
        'btnRuang
        '
        Me.btnRuang.Location = New System.Drawing.Point(527, 39)
        Me.btnRuang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRuang.Name = "btnRuang"
        Me.btnRuang.Size = New System.Drawing.Size(32, 25)
        Me.btnRuang.TabIndex = 3
        Me.btnRuang.Text = "..."
        Me.btnRuang.UseVisualStyleBackColor = True
        '
        'txtRuangan
        '
        Me.txtRuangan.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtRuangan.Location = New System.Drawing.Point(206, 39)
        Me.txtRuangan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuangan.Name = "txtRuangan"
        Me.txtRuangan.ReadOnly = True
        Me.txtRuangan.Size = New System.Drawing.Size(315, 22)
        Me.txtRuangan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Petugas Pengantar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 42)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 243)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1379, 507)
        Me.Panel1.TabIndex = 2
        '
        'dgvInputLinen
        '
        Me.dgvInputLinen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInputLinen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInputLinen.Location = New System.Drawing.Point(0, 27)
        Me.dgvInputLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInputLinen.Name = "dgvInputLinen"
        Me.dgvInputLinen.Size = New System.Drawing.Size(1379, 480)
        Me.dgvInputLinen.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAdd, Me.ToolStripDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1379, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripAdd
        '
        Me.ToolStripAdd.Image = CType(resources.GetObject("ToolStripAdd.Image"), System.Drawing.Image)
        Me.ToolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripAdd.Name = "ToolStripAdd"
        Me.ToolStripAdd.Size = New System.Drawing.Size(57, 24)
        Me.ToolStripAdd.Text = "Add"
        '
        'ToolStripDelete
        '
        Me.ToolStripDelete.Image = CType(resources.GetObject("ToolStripDelete.Image"), System.Drawing.Image)
        Me.ToolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDelete.Name = "ToolStripDelete"
        Me.ToolStripDelete.Size = New System.Drawing.Size(73, 24)
        Me.ToolStripDelete.Text = "Delete"
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
        Me.Panel3.Controls.Add(Me.btnBatal)
        Me.Panel3.Controls.Add(Me.btnSimpan)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1044, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 55)
        Me.Panel3.TabIndex = 0
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(175, 14)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(135, 31)
        Me.btnSimpan.TabIndex = 126
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'UCInputOrderLondry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.PanelJudul)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCInputOrderLondry"
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
    Friend WithEvents btnRuang As System.Windows.Forms.Button
    Friend WithEvents txtRuangan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvInputLinen As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As C1.Win.C1Input.C1Button
    Friend WithEvents btnSimpan As C1.Win.C1Input.C1Button
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpJam As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_headerid As System.Windows.Forms.Label
    Friend WithEvents txtPetugasLaundry As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSubRuang As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBrtLinenTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
