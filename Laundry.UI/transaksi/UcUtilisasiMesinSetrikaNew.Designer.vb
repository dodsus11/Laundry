<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcUtilisasiMesinSetrikaNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcUtilisasiMesinSetrikaNew))
        Me.PanelJudul = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.btnOperator = New System.Windows.Forms.Button()
        Me.txtPemakaian = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOperator = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_headerid = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.btnMesin = New System.Windows.Forms.Button()
        Me.txtMesin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvInputLinen = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripEdit = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnBatal = New C1.Win.C1Input.C1Button()
        Me.btnSimpan = New C1.Win.C1Input.C1Button()
        Me.ToolStripDelete = New System.Windows.Forms.ToolStripButton()
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
        Me.PanelHeader.Controls.Add(Me.btnOperator)
        Me.PanelHeader.Controls.Add(Me.txtPemakaian)
        Me.PanelHeader.Controls.Add(Me.Label7)
        Me.PanelHeader.Controls.Add(Me.txtOperator)
        Me.PanelHeader.Controls.Add(Me.Label6)
        Me.PanelHeader.Controls.Add(Me.label_headerid)
        Me.PanelHeader.Controls.Add(Me.dtpTgl)
        Me.PanelHeader.Controls.Add(Me.btnMesin)
        Me.PanelHeader.Controls.Add(Me.txtMesin)
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Controls.Add(Me.Label1)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 62)
        Me.PanelHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1379, 162)
        Me.PanelHeader.TabIndex = 1
        '
        'btnOperator
        '
        Me.btnOperator.Location = New System.Drawing.Point(517, 109)
        Me.btnOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOperator.Name = "btnOperator"
        Me.btnOperator.Size = New System.Drawing.Size(32, 25)
        Me.btnOperator.TabIndex = 17
        Me.btnOperator.Text = "..."
        Me.btnOperator.UseVisualStyleBackColor = True
        '
        'txtPemakaian
        '
        Me.txtPemakaian.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPemakaian.Enabled = False
        Me.txtPemakaian.Location = New System.Drawing.Point(474, 31)
        Me.txtPemakaian.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPemakaian.Name = "txtPemakaian"
        Me.txtPemakaian.Size = New System.Drawing.Size(73, 22)
        Me.txtPemakaian.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(366, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Pemakaian ke"
        '
        'txtOperator
        '
        Me.txtOperator.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtOperator.Enabled = False
        Me.txtOperator.Location = New System.Drawing.Point(196, 109)
        Me.txtOperator.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOperator.Name = "txtOperator"
        Me.txtOperator.Size = New System.Drawing.Size(315, 22)
        Me.txtOperator.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 109)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Operator"
        '
        'label_headerid
        '
        Me.label_headerid.AutoSize = True
        Me.label_headerid.Location = New System.Drawing.Point(64, 29)
        Me.label_headerid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label_headerid.Name = "label_headerid"
        Me.label_headerid.Size = New System.Drawing.Size(0, 17)
        Me.label_headerid.TabIndex = 12
        Me.label_headerid.Visible = False
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "dd/M/yyyy"
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(196, 31)
        Me.dtpTgl.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTgl.MaxDate = New Date(2019, 11, 13, 8, 37, 25, 0)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(141, 22)
        Me.dtpTgl.TabIndex = 11
        Me.dtpTgl.Value = New Date(2019, 10, 10, 0, 0, 0, 0)
        '
        'btnMesin
        '
        Me.btnMesin.Location = New System.Drawing.Point(517, 70)
        Me.btnMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMesin.Name = "btnMesin"
        Me.btnMesin.Size = New System.Drawing.Size(32, 25)
        Me.btnMesin.TabIndex = 3
        Me.btnMesin.Text = "..."
        Me.btnMesin.UseVisualStyleBackColor = True
        '
        'txtMesin
        '
        Me.txtMesin.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtMesin.Enabled = False
        Me.txtMesin.Location = New System.Drawing.Point(196, 70)
        Me.txtMesin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMesin.Name = "txtMesin"
        Me.txtMesin.ReadOnly = True
        Me.txtMesin.Size = New System.Drawing.Size(315, 22)
        Me.txtMesin.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Mesin"
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
        Me.dgvInputLinen.Location = New System.Drawing.Point(0, 27)
        Me.dgvInputLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvInputLinen.Name = "dgvInputLinen"
        Me.dgvInputLinen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInputLinen.Size = New System.Drawing.Size(1379, 499)
        Me.dgvInputLinen.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAdd, Me.ToolStripEdit, Me.ToolStripDelete})
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
        'ToolStripEdit
        '
        Me.ToolStripEdit.Image = Global.Laundry.UI.My.Resources.Resources.klipper_dock
        Me.ToolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripEdit.Name = "ToolStripEdit"
        Me.ToolStripEdit.Size = New System.Drawing.Size(55, 24)
        Me.ToolStripEdit.Text = "Edit"
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
        'ToolStripDelete
        '
        Me.ToolStripDelete.Image = Global.Laundry.UI.My.Resources.Resources.close_window
        Me.ToolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDelete.Name = "ToolStripDelete"
        Me.ToolStripDelete.Size = New System.Drawing.Size(73, 24)
        Me.ToolStripDelete.Text = "Delete"
        '
        'UcUtilisasiMesinSetrikaNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.PanelJudul)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcUtilisasiMesinSetrikaNew"
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
    Friend WithEvents btnMesin As System.Windows.Forms.Button
    Friend WithEvents txtMesin As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvInputLinen As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnBatal As C1.Win.C1Input.C1Button
    Friend WithEvents btnSimpan As C1.Win.C1Input.C1Button
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_headerid As System.Windows.Forms.Label
    Friend WithEvents txtOperator As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPemakaian As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnOperator As System.Windows.Forms.Button
    Friend WithEvents ToolStripEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDelete As System.Windows.Forms.ToolStripButton

End Class
