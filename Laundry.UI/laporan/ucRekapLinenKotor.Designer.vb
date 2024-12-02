<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRekapLinenKotor
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
        Me.btnRuang = New System.Windows.Forms.Button()
        Me.txtRuang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnView = New C1.Win.C1Input.C1Button()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExportExcel = New C1.Win.C1Input.C1Button()
        Me.dgvLinenKotor = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelTitle.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        CType(Me.dgvLinenKotor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.LabelJudul.Size = New System.Drawing.Size(744, 29)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "LAPORAN LINEN KOTOR YANG BELUM TERDISTRIBUSI"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.CheckBoxAll)
        Me.PanelControl.Controls.Add(Me.btnRuang)
        Me.PanelControl.Controls.Add(Me.txtRuang)
        Me.PanelControl.Controls.Add(Me.Label3)
        Me.PanelControl.Controls.Add(Me.dtpToDate)
        Me.PanelControl.Controls.Add(Me.Label2)
        Me.PanelControl.Controls.Add(Me.btnView)
        Me.PanelControl.Controls.Add(Me.dtpFromDate)
        Me.PanelControl.Controls.Add(Me.Label1)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl.Location = New System.Drawing.Point(0, 78)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(1551, 115)
        Me.PanelControl.TabIndex = 1
        '
        'CheckBoxAll
        '
        Me.CheckBoxAll.AutoSize = True
        Me.CheckBoxAll.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxAll.Location = New System.Drawing.Point(1234, 34)
        Me.CheckBoxAll.Name = "CheckBoxAll"
        Me.CheckBoxAll.Size = New System.Drawing.Size(96, 26)
        Me.CheckBoxAll.TabIndex = 172
        Me.CheckBoxAll.Text = "semua"
        Me.CheckBoxAll.UseVisualStyleBackColor = True
        '
        'btnRuang
        '
        Me.btnRuang.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRuang.Location = New System.Drawing.Point(1164, 30)
        Me.btnRuang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRuang.Name = "btnRuang"
        Me.btnRuang.Size = New System.Drawing.Size(63, 32)
        Me.btnRuang.TabIndex = 171
        Me.btnRuang.Text = "pilih"
        Me.btnRuang.UseVisualStyleBackColor = True
        '
        'txtRuang
        '
        Me.txtRuang.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuang.Location = New System.Drawing.Point(781, 30)
        Me.txtRuang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRuang.Name = "txtRuang"
        Me.txtRuang.Size = New System.Drawing.Size(376, 29)
        Me.txtRuang.TabIndex = 170
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(608, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 22)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Instalasi/Bagian :"
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "yyyy/M/dd"
        Me.dtpToDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(399, 30)
        Me.dtpToDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(176, 29)
        Me.dtpToDate.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 22)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "s/d"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(1344, 25)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(150, 41)
        Me.btnView.TabIndex = 166
        Me.btnView.Text = "View Report"
        Me.btnView.UseVisualStyleBackColor = True
        Me.btnView.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnView.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "yyyy/M/dd"
        Me.dtpFromDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(170, 30)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(176, 29)
        Me.dtpFromDate.TabIndex = 165
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 22)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Tanggal :"
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(69, 25)
        Me.btnExportExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(150, 41)
        Me.btnExportExcel.TabIndex = 163
        Me.btnExportExcel.Text = "Export to Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        Me.btnExportExcel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnExportExcel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'dgvLinenKotor
        '
        Me.dgvLinenKotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLinenKotor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLinenKotor.Location = New System.Drawing.Point(0, 193)
        Me.dgvLinenKotor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLinenKotor.Name = "dgvLinenKotor"
        Me.dgvLinenKotor.RowTemplate.Height = 24
        Me.dgvLinenKotor.Size = New System.Drawing.Size(1551, 745)
        Me.dgvLinenKotor.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 852)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1551, 86)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnExportExcel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1271, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 86)
        Me.Panel2.TabIndex = 0
        '
        'ucRekapLinenKotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvLinenKotor)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanelTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucRekapLinenKotor"
        Me.Size = New System.Drawing.Size(1551, 938)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        CType(Me.dgvLinenKotor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents btnExportExcel As C1.Win.C1Input.C1Button
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnView As C1.Win.C1Input.C1Button
    Friend WithEvents dgvLinenKotor As System.Windows.Forms.DataGridView
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRuang As System.Windows.Forms.TextBox
    Friend WithEvents btnRuang As System.Windows.Forms.Button
    Friend WithEvents CheckBoxAll As System.Windows.Forms.CheckBox

End Class
