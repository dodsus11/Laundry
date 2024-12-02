<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucDataUtilisasiMesinPengering
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.fromDate = New System.Windows.Forms.DateTimePicker()
        Me.btnViewReport = New C1.Win.C1Input.C1Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvTampilData = New System.Windows.Forms.DataGridView()
        Me.PanelTitle.SuspendLayout()
        Me.PanelControl.SuspendLayout()
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
        Me.LabelJudul.Size = New System.Drawing.Size(354, 25)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "Data Utilisasi Mesin Pengering"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.Button1)
        Me.PanelControl.Controls.Add(Me.toDate)
        Me.PanelControl.Controls.Add(Me.Label1)
        Me.PanelControl.Controls.Add(Me.C1Button1)
        Me.PanelControl.Controls.Add(Me.fromDate)
        Me.PanelControl.Controls.Add(Me.btnViewReport)
        Me.PanelControl.Controls.Add(Me.Label3)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl.Location = New System.Drawing.Point(0, 62)
        Me.PanelControl.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(1379, 100)
        Me.PanelControl.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(813, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 168
        Me.Button1.Text = "Export Excl Old"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'toDate
        '
        Me.toDate.CustomFormat = "yyyy/M/dd"
        Me.toDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDate.Location = New System.Drawing.Point(304, 31)
        Me.toDate.Margin = New System.Windows.Forms.Padding(4)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(155, 26)
        Me.toDate.TabIndex = 167
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "s/d :"
        '
        'C1Button1
        '
        Me.C1Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.C1Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1Button1.Location = New System.Drawing.Point(673, 27)
        Me.C1Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(133, 33)
        Me.C1Button1.TabIndex = 165
        Me.C1Button1.Text = "Export Excel"
        Me.C1Button1.UseVisualStyleBackColor = False
        Me.C1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'fromDate
        '
        Me.fromDate.CustomFormat = "yyyy/M/dd"
        Me.fromDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDate.Location = New System.Drawing.Point(102, 31)
        Me.fromDate.Margin = New System.Windows.Forms.Padding(4)
        Me.fromDate.Name = "fromDate"
        Me.fromDate.Size = New System.Drawing.Size(155, 26)
        Me.fromDate.TabIndex = 164
        '
        'btnViewReport
        '
        Me.btnViewReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReport.Location = New System.Drawing.Point(532, 27)
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
        Me.Label3.Location = New System.Drawing.Point(25, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tanggal :"
        '
        'dgvTampilData
        '
        Me.dgvTampilData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTampilData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTampilData.Location = New System.Drawing.Point(0, 162)
        Me.dgvTampilData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTampilData.Name = "dgvTampilData"
        Me.dgvTampilData.Size = New System.Drawing.Size(1379, 588)
        Me.dgvTampilData.TabIndex = 2
        '
        'ucDataUtilisasiMesinPengering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvTampilData)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanelTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucDataUtilisasiMesinPengering"
        Me.Size = New System.Drawing.Size(1379, 750)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        CType(Me.dgvTampilData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnViewReport As C1.Win.C1Input.C1Button
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents fromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvTampilData As System.Windows.Forms.DataGridView
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
