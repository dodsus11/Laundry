<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRekapLinenPerJnsLinen
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJmlInf = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbAllRoom = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbertLinen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRuang = New System.Windows.Forms.Button()
        Me.txtRuang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnView = New C1.Win.C1Input.C1Button()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExportExcel = New C1.Win.C1Input.C1Button()
        Me.dgvLinenKotor = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtJmlNonInf = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.LabelJudul.Size = New System.Drawing.Size(580, 29)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "LAPORAN LINEN MASUK PER JENIS LINEN"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.Label8)
        Me.PanelControl.Controls.Add(Me.txtJmlNonInf)
        Me.PanelControl.Controls.Add(Me.Label6)
        Me.PanelControl.Controls.Add(Me.txtJmlInf)
        Me.PanelControl.Controls.Add(Me.Label7)
        Me.PanelControl.Controls.Add(Me.cbAllRoom)
        Me.PanelControl.Controls.Add(Me.Label2)
        Me.PanelControl.Controls.Add(Me.dtpToDate)
        Me.PanelControl.Controls.Add(Me.Label5)
        Me.PanelControl.Controls.Add(Me.txtbertLinen)
        Me.PanelControl.Controls.Add(Me.Label4)
        Me.PanelControl.Controls.Add(Me.btnRuang)
        Me.PanelControl.Controls.Add(Me.txtRuang)
        Me.PanelControl.Controls.Add(Me.Label3)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(933, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Non Infeksius"
        '
        'txtJmlInf
        '
        Me.txtJmlInf.Enabled = False
        Me.txtJmlInf.Location = New System.Drawing.Point(842, 38)
        Me.txtJmlInf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJmlInf.Name = "txtJmlInf"
        Me.txtJmlInf.Size = New System.Drawing.Size(85, 26)
        Me.txtJmlInf.TabIndex = 179
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(694, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 20)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Jumlah Linen Total"
        '
        'cbAllRoom
        '
        Me.cbAllRoom.AutoSize = True
        Me.cbAllRoom.Location = New System.Drawing.Point(546, 72)
        Me.cbAllRoom.Name = "cbAllRoom"
        Me.cbAllRoom.Size = New System.Drawing.Size(83, 24)
        Me.cbAllRoom.TabIndex = 177
        Me.cbAllRoom.Text = "semua"
        Me.cbAllRoom.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "s/d"
        '
        'dtpToDate
        '
        Me.dtpToDate.CustomFormat = "yyyy/M/dd"
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToDate.Location = New System.Drawing.Point(362, 28)
        Me.dtpToDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(176, 26)
        Me.dtpToDate.TabIndex = 175
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(933, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 20)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Kg"
        '
        'txtbertLinen
        '
        Me.txtbertLinen.Enabled = False
        Me.txtbertLinen.Location = New System.Drawing.Point(842, 75)
        Me.txtbertLinen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbertLinen.Name = "txtbertLinen"
        Me.txtbertLinen.Size = New System.Drawing.Size(85, 26)
        Me.txtbertLinen.TabIndex = 173
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(706, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 20)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Berat Linen Total"
        '
        'btnRuang
        '
        Me.btnRuang.Location = New System.Drawing.Point(498, 70)
        Me.btnRuang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRuang.Name = "btnRuang"
        Me.btnRuang.Size = New System.Drawing.Size(42, 31)
        Me.btnRuang.TabIndex = 171
        Me.btnRuang.Text = "..."
        Me.btnRuang.UseVisualStyleBackColor = True
        '
        'txtRuang
        '
        Me.txtRuang.Location = New System.Drawing.Point(138, 70)
        Me.txtRuang.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRuang.Name = "txtRuang"
        Me.txtRuang.Size = New System.Drawing.Size(353, 26)
        Me.txtRuang.TabIndex = 170
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = "Ruang"
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.Location = New System.Drawing.Point(1176, 39)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(137, 35)
        Me.btnView.TabIndex = 166
        Me.btnView.Text = "View Report"
        Me.btnView.UseVisualStyleBackColor = True
        Me.btnView.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnView.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CustomFormat = "yyyy/M/dd"
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromDate.Location = New System.Drawing.Point(138, 28)
        Me.dtpFromDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(176, 26)
        Me.dtpFromDate.TabIndex = 165
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Tanggal "
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
        'txtJmlNonInf
        '
        Me.txtJmlNonInf.Enabled = False
        Me.txtJmlNonInf.Location = New System.Drawing.Point(1045, 38)
        Me.txtJmlNonInf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJmlNonInf.Name = "txtJmlNonInf"
        Me.txtJmlNonInf.Size = New System.Drawing.Size(85, 26)
        Me.txtJmlNonInf.TabIndex = 181
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(763, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 182
        Me.Label8.Text = "Infeksius"
        '
        'ucRekapLinenPerJnsLinen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvLinenKotor)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanelTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucRekapLinenPerJnsLinen"
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRuang As System.Windows.Forms.TextBox
    Friend WithEvents btnRuang As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtbertLinen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbAllRoom As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJmlInf As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtJmlNonInf As System.Windows.Forms.TextBox

End Class
