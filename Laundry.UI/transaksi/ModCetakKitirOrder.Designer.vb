<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModCetakKitirOrder
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
        Me.PanelLoadData = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggalSelesai = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalMulai = New System.Windows.Forms.DateTimePicker()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CetakKitir = New System.Windows.Forms.ToolStripButton()
        Me.dgvListOrder = New System.Windows.Forms.DataGridView()
        Me.PanelJudul.SuspendLayout()
        Me.PanelLoadData.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        CType(Me.dgvListOrder, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelJudul.Size = New System.Drawing.Size(297, 25)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "CETAK BUKTI ORDER BINATU"
        '
        'PanelLoadData
        '
        Me.PanelLoadData.Controls.Add(Me.Label2)
        Me.PanelLoadData.Controls.Add(Me.dtpTanggalSelesai)
        Me.PanelLoadData.Controls.Add(Me.dtpTanggalMulai)
        Me.PanelLoadData.Controls.Add(Me.btnTampil)
        Me.PanelLoadData.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLoadData.Location = New System.Drawing.Point(0, 49)
        Me.PanelLoadData.Name = "PanelLoadData"
        Me.PanelLoadData.Size = New System.Drawing.Size(992, 47)
        Me.PanelLoadData.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "s/d"
        '
        'dtpTanggalSelesai
        '
        Me.dtpTanggalSelesai.CustomFormat = "dd/MM/yyyy"
        Me.dtpTanggalSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalSelesai.Location = New System.Drawing.Point(192, 11)
        Me.dtpTanggalSelesai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTanggalSelesai.Name = "dtpTanggalSelesai"
        Me.dtpTanggalSelesai.Size = New System.Drawing.Size(135, 22)
        Me.dtpTanggalSelesai.TabIndex = 12
        '
        'dtpTanggalMulai
        '
        Me.dtpTanggalMulai.CustomFormat = "dd/MM/yyyy"
        Me.dtpTanggalMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalMulai.Location = New System.Drawing.Point(17, 11)
        Me.dtpTanggalMulai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTanggalMulai.Name = "dtpTanggalMulai"
        Me.dtpTanggalMulai.Size = New System.Drawing.Size(135, 22)
        Me.dtpTanggalMulai.TabIndex = 11
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(351, 7)
        Me.btnTampil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(136, 28)
        Me.btnTampil.TabIndex = 10
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakKitir})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 96)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(992, 27)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'CetakKitir
        '
        Me.CetakKitir.Image = Global.Laundry.UI.My.Resources.Resources.klipper_dock
        Me.CetakKitir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CetakKitir.Name = "CetakKitir"
        Me.CetakKitir.Size = New System.Drawing.Size(145, 24)
        Me.CetakKitir.Text = "Cetak Bukti Order"
        '
        'dgvListOrder
        '
        Me.dgvListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListOrder.Location = New System.Drawing.Point(0, 123)
        Me.dgvListOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvListOrder.Name = "dgvListOrder"
        Me.dgvListOrder.Size = New System.Drawing.Size(992, 337)
        Me.dgvListOrder.TabIndex = 7
        '
        'ModCetakKitirOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvListOrder)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.PanelLoadData)
        Me.Controls.Add(Me.PanelJudul)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ModCetakKitirOrder"
        Me.Size = New System.Drawing.Size(992, 460)
        Me.PanelJudul.ResumeLayout(False)
        Me.PanelJudul.PerformLayout()
        Me.PanelLoadData.ResumeLayout(False)
        Me.PanelLoadData.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.dgvListOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelJudul As System.Windows.Forms.Panel
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents PanelLoadData As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CetakKitir As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvListOrder As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampil As System.Windows.Forms.Button

End Class
