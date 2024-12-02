<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLapLinenPerMesinSetrika
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
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.btnLinen = New System.Windows.Forms.Button()
        Me.txtLinen = New System.Windows.Forms.TextBox()
        Me.LabelLinen = New System.Windows.Forms.Label()
        Me.btn_excel = New C1.Win.C1Input.C1Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.btnMesin = New System.Windows.Forms.Button()
        Me.txtMesin = New System.Windows.Forms.TextBox()
        Me.LabelMesin = New System.Windows.Forms.Label()
        Me.dtpTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.btnViewReport = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvLinen = New System.Windows.Forms.DataGridView()
        Me.PanelTitle.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        CType(Me.dgvLinen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelTitle.Controls.Add(Me.LabelJudul)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1551, 78)
        Me.PanelTitle.TabIndex = 0
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.Color.White
        Me.LabelJudul.Location = New System.Drawing.Point(24, 22)
        Me.LabelJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(551, 29)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "Laporan Jumlah Linen Per Mesin Setrika"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.btnLinen)
        Me.PanelControl.Controls.Add(Me.txtLinen)
        Me.PanelControl.Controls.Add(Me.LabelLinen)
        Me.PanelControl.Controls.Add(Me.btn_excel)
        Me.PanelControl.Controls.Add(Me.Label2)
        Me.PanelControl.Controls.Add(Me.dtpTglAkhir)
        Me.PanelControl.Controls.Add(Me.btnMesin)
        Me.PanelControl.Controls.Add(Me.txtMesin)
        Me.PanelControl.Controls.Add(Me.LabelMesin)
        Me.PanelControl.Controls.Add(Me.dtpTglAwal)
        Me.PanelControl.Controls.Add(Me.btnViewReport)
        Me.PanelControl.Controls.Add(Me.Label3)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl.Location = New System.Drawing.Point(0, 78)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(1551, 115)
        Me.PanelControl.TabIndex = 1
        '
        'btnLinen
        '
        Me.btnLinen.Location = New System.Drawing.Point(820, 63)
        Me.btnLinen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLinen.Name = "btnLinen"
        Me.btnLinen.Size = New System.Drawing.Size(51, 35)
        Me.btnLinen.TabIndex = 174
        Me.btnLinen.Text = "..."
        Me.btnLinen.UseVisualStyleBackColor = True
        '
        'txtLinen
        '
        Me.txtLinen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtLinen.Location = New System.Drawing.Point(618, 63)
        Me.txtLinen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLinen.Name = "txtLinen"
        Me.txtLinen.Size = New System.Drawing.Size(196, 26)
        Me.txtLinen.TabIndex = 173
        '
        'LabelLinen
        '
        Me.LabelLinen.AutoSize = True
        Me.LabelLinen.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLinen.Location = New System.Drawing.Point(544, 63)
        Me.LabelLinen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLinen.Name = "LabelLinen"
        Me.LabelLinen.Size = New System.Drawing.Size(58, 22)
        Me.LabelLinen.TabIndex = 172
        Me.LabelLinen.Text = "Linen"
        '
        'btn_excel
        '
        Me.btn_excel.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_excel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_excel.Location = New System.Drawing.Point(1089, 39)
        Me.btn_excel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.Size = New System.Drawing.Size(150, 39)
        Me.btn_excel.TabIndex = 171
        Me.btn_excel.Text = "Export Excel"
        Me.btn_excel.UseVisualStyleBackColor = False
        Me.btn_excel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btn_excel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 22)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "s/d"
        '
        'dtpTglAkhir
        '
        Me.dtpTglAkhir.CustomFormat = "yyyy/M/dd"
        Me.dtpTglAkhir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglAkhir.Location = New System.Drawing.Point(328, 39)
        Me.dtpTglAkhir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpTglAkhir.Name = "dtpTglAkhir"
        Me.dtpTglAkhir.Size = New System.Drawing.Size(174, 29)
        Me.dtpTglAkhir.TabIndex = 168
        '
        'btnMesin
        '
        Me.btnMesin.Location = New System.Drawing.Point(820, 21)
        Me.btnMesin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMesin.Name = "btnMesin"
        Me.btnMesin.Size = New System.Drawing.Size(51, 35)
        Me.btnMesin.TabIndex = 167
        Me.btnMesin.Text = "..."
        Me.btnMesin.UseVisualStyleBackColor = True
        '
        'txtMesin
        '
        Me.txtMesin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMesin.Location = New System.Drawing.Point(618, 21)
        Me.txtMesin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMesin.Name = "txtMesin"
        Me.txtMesin.Size = New System.Drawing.Size(196, 26)
        Me.txtMesin.TabIndex = 166
        '
        'LabelMesin
        '
        Me.LabelMesin.AutoSize = True
        Me.LabelMesin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMesin.Location = New System.Drawing.Point(544, 21)
        Me.LabelMesin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMesin.Name = "LabelMesin"
        Me.LabelMesin.Size = New System.Drawing.Size(61, 22)
        Me.LabelMesin.TabIndex = 165
        Me.LabelMesin.Text = "Mesin"
        '
        'dtpTglAwal
        '
        Me.dtpTglAwal.CustomFormat = "yyyy/M/dd"
        Me.dtpTglAwal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTglAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglAwal.Location = New System.Drawing.Point(102, 39)
        Me.dtpTglAwal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpTglAwal.Name = "dtpTglAwal"
        Me.dtpTglAwal.Size = New System.Drawing.Size(174, 29)
        Me.dtpTglAwal.TabIndex = 164
        '
        'btnViewReport
        '
        Me.btnViewReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReport.Location = New System.Drawing.Point(920, 39)
        Me.btnViewReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(150, 39)
        Me.btnViewReport.TabIndex = 162
        Me.btnViewReport.Text = "View Report"
        Me.btnViewReport.UseVisualStyleBackColor = True
        Me.btnViewReport.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnViewReport.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tanggal"
        '
        'dgvLinen
        '
        Me.dgvLinen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLinen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLinen.Location = New System.Drawing.Point(0, 193)
        Me.dgvLinen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvLinen.Name = "dgvLinen"
        Me.dgvLinen.Size = New System.Drawing.Size(1551, 745)
        Me.dgvLinen.TabIndex = 2
        '
        'ucLapLinenPerMesinSetrika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvLinen)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanelTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucLapLinenPerMesinSetrika"
        Me.Size = New System.Drawing.Size(1551, 938)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        CType(Me.dgvLinen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnViewReport As C1.Win.C1Input.C1Button
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents dtpTglAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelMesin As System.Windows.Forms.Label
    Friend WithEvents txtMesin As System.Windows.Forms.TextBox
    Friend WithEvents btnMesin As System.Windows.Forms.Button
    Friend WithEvents dgvLinen As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTglAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_excel As C1.Win.C1Input.C1Button
    Friend WithEvents btnLinen As System.Windows.Forms.Button
    Friend WithEvents txtLinen As System.Windows.Forms.TextBox
    Friend WithEvents LabelLinen As System.Windows.Forms.Label

End Class
