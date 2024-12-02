<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModHistoryTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModHistoryTransaksi))
        Me.PanelJudul = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.CheckBoxSemua = New System.Windows.Forms.CheckBox()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.txtInst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Detail = New System.Windows.Forms.ToolStripButton()
        Me.dgvListOrder = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.PanelJudul.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvListOrder, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelJudul.Size = New System.Drawing.Size(992, 49)
        Me.PanelJudul.TabIndex = 1
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelJudul.Location = New System.Drawing.Point(21, 11)
        Me.LabelJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(219, 25)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "History Order/Transaksi"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dtpTgl)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnReport)
        Me.Panel1.Controls.Add(Me.CheckBoxSemua)
        Me.Panel1.Controls.Add(Me.btnPilih)
        Me.Panel1.Controls.Add(Me.txtInst)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 59)
        Me.Panel1.TabIndex = 5
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.Location = New System.Drawing.Point(861, 13)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(111, 27)
        Me.btnReport.TabIndex = 4
        Me.btnReport.Text = "view report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'CheckBoxSemua
        '
        Me.CheckBoxSemua.AutoSize = True
        Me.CheckBoxSemua.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxSemua.Location = New System.Drawing.Point(764, 18)
        Me.CheckBoxSemua.Name = "CheckBoxSemua"
        Me.CheckBoxSemua.Size = New System.Drawing.Size(75, 22)
        Me.CheckBoxSemua.TabIndex = 3
        Me.CheckBoxSemua.Text = "semua"
        Me.CheckBoxSemua.UseVisualStyleBackColor = True
        '
        'btnPilih
        '
        Me.btnPilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.Location = New System.Drawing.Point(705, 15)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(53, 25)
        Me.btnPilih.TabIndex = 2
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = True
        '
        'txtInst
        '
        Me.txtInst.Enabled = False
        Me.txtInst.Location = New System.Drawing.Point(389, 16)
        Me.txtInst.Name = "txtInst"
        Me.txtInst.Size = New System.Drawing.Size(310, 22)
        Me.txtInst.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Instalasi/Bagian :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Detail})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 108)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(992, 27)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Detail
        '
        Me.Detail.Image = CType(resources.GetObject("Detail.Image"), System.Drawing.Image)
        Me.Detail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(69, 24)
        Me.Detail.Text = "Detail"
        '
        'dgvListOrder
        '
        Me.dgvListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListOrder.Location = New System.Drawing.Point(0, 135)
        Me.dgvListOrder.Name = "dgvListOrder"
        Me.dgvListOrder.RowTemplate.Height = 24
        Me.dgvListOrder.Size = New System.Drawing.Size(992, 325)
        Me.dgvListOrder.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tanggal :"
        '
        'dtpTgl
        '
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTgl.Location = New System.Drawing.Point(85, 17)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(145, 22)
        Me.dtpTgl.TabIndex = 6
        '
        'ModHistoryTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvListOrder)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelJudul)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModHistoryTransaksi"
        Me.Size = New System.Drawing.Size(992, 460)
        Me.PanelJudul.ResumeLayout(False)
        Me.PanelJudul.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvListOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelJudul As System.Windows.Forms.Panel
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Detail As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSemua As System.Windows.Forms.CheckBox
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents txtInst As System.Windows.Forms.TextBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents dgvListOrder As System.Windows.Forms.DataGridView
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
