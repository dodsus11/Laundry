<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRekapLinenTerdistribusi
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
        Me.CheckBoxAll = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInstalasi = New System.Windows.Forms.Button()
        Me.txtInstalasi = New System.Windows.Forms.TextBox()
        Me.dtpTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.btnViewReport = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExportExcel = New C1.Win.C1Input.C1Button()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvTampilData = New System.Windows.Forms.DataGridView()
        Me.PanelTitle.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTampilData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelTitle.Controls.Add(Me.LabelJudul)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1379, 62)
        Me.PanelTitle.TabIndex = 0
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.Color.White
        Me.LabelJudul.Location = New System.Drawing.Point(21, 18)
        Me.LabelJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(391, 25)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "LAPORAN LINEN TERDISTRIBUSI"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.CheckBoxAll)
        Me.PanelControl.Controls.Add(Me.Label2)
        Me.PanelControl.Controls.Add(Me.btnInstalasi)
        Me.PanelControl.Controls.Add(Me.txtInstalasi)
        Me.PanelControl.Controls.Add(Me.dtpTanggalAkhir)
        Me.PanelControl.Controls.Add(Me.Label1)
        Me.PanelControl.Controls.Add(Me.dtpTanggalAwal)
        Me.PanelControl.Controls.Add(Me.btnViewReport)
        Me.PanelControl.Controls.Add(Me.Label3)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl.Location = New System.Drawing.Point(0, 62)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(1379, 76)
        Me.PanelControl.TabIndex = 1
        '
        'CheckBoxAll
        '
        Me.CheckBoxAll.AutoSize = True
        Me.CheckBoxAll.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAll.Location = New System.Drawing.Point(1097, 27)
        Me.CheckBoxAll.Name = "CheckBoxAll"
        Me.CheckBoxAll.Size = New System.Drawing.Size(80, 22)
        Me.CheckBoxAll.TabIndex = 170
        Me.CheckBoxAll.Text = "semua"
        Me.CheckBoxAll.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Instalasi/Bagian :"
        '
        'btnInstalasi
        '
        Me.btnInstalasi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstalasi.Location = New System.Drawing.Point(1035, 24)
        Me.btnInstalasi.Name = "btnInstalasi"
        Me.btnInstalasi.Size = New System.Drawing.Size(56, 26)
        Me.btnInstalasi.TabIndex = 168
        Me.btnInstalasi.Text = "pilih"
        Me.btnInstalasi.UseVisualStyleBackColor = True
        '
        'txtInstalasi
        '
        Me.txtInstalasi.Enabled = False
        Me.txtInstalasi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstalasi.Location = New System.Drawing.Point(694, 24)
        Me.txtInstalasi.Name = "txtInstalasi"
        Me.txtInstalasi.Size = New System.Drawing.Size(335, 26)
        Me.txtInstalasi.TabIndex = 167
        '
        'dtpTanggalAkhir
        '
        Me.dtpTanggalAkhir.CustomFormat = "yyyy/M/dd"
        Me.dtpTanggalAkhir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAkhir.Location = New System.Drawing.Point(355, 24)
        Me.dtpTanggalAkhir.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTanggalAkhir.Name = "dtpTanggalAkhir"
        Me.dtpTanggalAkhir.Size = New System.Drawing.Size(155, 26)
        Me.dtpTanggalAkhir.TabIndex = 166
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 18)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "s/d"
        '
        'dtpTanggalAwal
        '
        Me.dtpTanggalAwal.CustomFormat = "yyyy/M/dd"
        Me.dtpTanggalAwal.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAwal.Location = New System.Drawing.Point(151, 24)
        Me.dtpTanggalAwal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTanggalAwal.Name = "dtpTanggalAwal"
        Me.dtpTanggalAwal.Size = New System.Drawing.Size(155, 26)
        Me.dtpTanggalAwal.TabIndex = 164
        '
        'btnViewReport
        '
        Me.btnViewReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReport.Location = New System.Drawing.Point(1195, 20)
        Me.btnViewReport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(133, 33)
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
        Me.Label3.Location = New System.Drawing.Point(31, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tanggal order :"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(61, 20)
        Me.btnExportExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(133, 33)
        Me.btnExportExcel.TabIndex = 163
        Me.btnExportExcel.Text = "Export to Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        Me.btnExportExcel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnExportExcel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'PanelFooter
        '
        Me.PanelFooter.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelFooter.Controls.Add(Me.Panel1)
        Me.PanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooter.Location = New System.Drawing.Point(0, 681)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(1379, 69)
        Me.PanelFooter.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExportExcel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1130, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 69)
        Me.Panel1.TabIndex = 0
        '
        'dgvTampilData
        '
        Me.dgvTampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTampilData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTampilData.Location = New System.Drawing.Point(0, 138)
        Me.dgvTampilData.Name = "dgvTampilData"
        Me.dgvTampilData.RowTemplate.Height = 24
        Me.dgvTampilData.Size = New System.Drawing.Size(1379, 543)
        Me.dgvTampilData.TabIndex = 3
        '
        'ucRekapLinenTerdistribusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvTampilData)
        Me.Controls.Add(Me.PanelFooter)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanelTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucRekapLinenTerdistribusi"
        Me.Size = New System.Drawing.Size(1379, 750)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        Me.PanelFooter.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvTampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExportExcel As C1.Win.C1Input.C1Button
    Friend WithEvents btnViewReport As C1.Win.C1Input.C1Button
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTanggalAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInstalasi As System.Windows.Forms.Button
    Friend WithEvents txtInstalasi As System.Windows.Forms.TextBox
    Friend WithEvents PanelFooter As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvTampilData As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
