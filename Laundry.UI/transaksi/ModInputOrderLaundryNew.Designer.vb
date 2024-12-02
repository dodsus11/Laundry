<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModInputOrderLaundryNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModInputOrderLaundryNew))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpTanggalSelesai = New System.Windows.Forms.DateTimePicker()
        Me.dtpTanggalMulai = New System.Windows.Forms.DateTimePicker()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabelFind = New System.Windows.Forms.ToolStripLabel()
        Me.tsTxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 62)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order Binatu"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.dtpTanggalSelesai)
        Me.Panel4.Controls.Add(Me.dtpTanggalMulai)
        Me.Panel4.Controls.Add(Me.btnTampil)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 62)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1050, 47)
        Me.Panel4.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "s/d"
        '
        'dtpTanggalSelesai
        '
        Me.dtpTanggalSelesai.CustomFormat = "dd/MM/yyyy"
        Me.dtpTanggalSelesai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalSelesai.Location = New System.Drawing.Point(192, 11)
        Me.dtpTanggalSelesai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTanggalSelesai.Name = "dtpTanggalSelesai"
        Me.dtpTanggalSelesai.Size = New System.Drawing.Size(135, 22)
        Me.dtpTanggalSelesai.TabIndex = 8
        '
        'dtpTanggalMulai
        '
        Me.dtpTanggalMulai.CustomFormat = "dd/MM/yyyy"
        Me.dtpTanggalMulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalMulai.Location = New System.Drawing.Point(17, 11)
        Me.dtpTanggalMulai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTanggalMulai.Name = "dtpTanggalMulai"
        Me.dtpTanggalMulai.Size = New System.Drawing.Size(135, 22)
        Me.dtpTanggalMulai.TabIndex = 7
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(351, 7)
        Me.btnTampil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(136, 28)
        Me.btnTampil.TabIndex = 3
        Me.btnTampil.Text = "Tampilkan"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.ToolStripSeparator5, Me.tsEdit, Me.ToolStripSeparator1, Me.tsDelete, Me.ToolStripSeparator3, Me.ToolStripLabelFind, Me.tsTxtSearch})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 109)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1050, 27)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsNew
        '
        Me.tsNew.Image = CType(resources.GetObject("tsNew.Image"), System.Drawing.Image)
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(59, 24)
        Me.tsNew.Text = "New"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'tsEdit
        '
        Me.tsEdit.Image = Global.Laundry.UI.My.Resources.Resources.klipper_dock
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(55, 24)
        Me.tsEdit.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsDelete
        '
        Me.tsDelete.Image = CType(resources.GetObject("tsDelete.Image"), System.Drawing.Image)
        Me.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDelete.Name = "tsDelete"
        Me.tsDelete.Size = New System.Drawing.Size(73, 24)
        Me.tsDelete.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripLabelFind
        '
        Me.ToolStripLabelFind.Name = "ToolStripLabelFind"
        Me.ToolStripLabelFind.Size = New System.Drawing.Size(42, 24)
        Me.ToolStripLabelFind.Text = "Cari :"
        '
        'tsTxtSearch
        '
        Me.tsTxtSearch.Name = "tsTxtSearch"
        Me.tsTxtSearch.Size = New System.Drawing.Size(265, 27)
        Me.tsTxtSearch.ToolTipText = "Cari Kata"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 136)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(1050, 343)
        Me.dgv.TabIndex = 7
        '
        'ModInputOrderLaundryNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ModInputOrderLaundryNew"
        Me.Size = New System.Drawing.Size(1050, 479)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtpTanggalMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabelFind As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsTxtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents dtpTanggalSelesai As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
