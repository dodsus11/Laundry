<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcAddInventarisRuangan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcAddInventarisRuangan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelDGV = New System.Windows.Forms.Panel()
        Me.PanelBtnBwh = New System.Windows.Forms.Panel()
        Me.btnBatal = New C1.Win.C1Input.C1Button()
        Me.btnSimpan = New C1.Win.C1Input.C1Button()
        Me.dgvInventaris = New System.Windows.Forms.DataGridView()
        Me.PanelToolStrip = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripAdd = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDelete = New System.Windows.Forms.ToolStripButton()
        Me.PanelEntry = New System.Windows.Forms.Panel()
        Me.dtptanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbInventaris = New System.Windows.Forms.Label()
        Me.btnRuang = New System.Windows.Forms.Button()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbPetugas = New System.Windows.Forms.Label()
        Me.LbJmlKM = New System.Windows.Forms.Label()
        Me.LbJmlPAR = New System.Windows.Forms.Label()
        Me.lbJmlTT = New System.Windows.Forms.Label()
        Me.LbInst = New System.Windows.Forms.Label()
        Me.txtJmlKM = New System.Windows.Forms.TextBox()
        Me.txtJmlPAR = New System.Windows.Forms.TextBox()
        Me.txtJmlTT = New System.Windows.Forms.TextBox()
        Me.txtInstalasi = New System.Windows.Forms.TextBox()
        Me.txtRuang = New System.Windows.Forms.TextBox()
        Me.LblRuang = New System.Windows.Forms.Label()
        Me.PanelJudul = New System.Windows.Forms.Panel()
        Me.LbJudul = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelDGV.SuspendLayout()
        Me.PanelBtnBwh.SuspendLayout()
        CType(Me.dgvInventaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.PanelEntry.SuspendLayout()
        Me.PanelJudul.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelDGV)
        Me.Panel1.Controls.Add(Me.PanelToolStrip)
        Me.Panel1.Controls.Add(Me.PanelEntry)
        Me.Panel1.Controls.Add(Me.PanelJudul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1190, 707)
        Me.Panel1.TabIndex = 0
        '
        'PanelDGV
        '
        Me.PanelDGV.Controls.Add(Me.PanelBtnBwh)
        Me.PanelDGV.Controls.Add(Me.dgvInventaris)
        Me.PanelDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDGV.Location = New System.Drawing.Point(0, 306)
        Me.PanelDGV.Name = "PanelDGV"
        Me.PanelDGV.Size = New System.Drawing.Size(1190, 401)
        Me.PanelDGV.TabIndex = 3
        '
        'PanelBtnBwh
        '
        Me.PanelBtnBwh.Controls.Add(Me.btnBatal)
        Me.PanelBtnBwh.Controls.Add(Me.btnSimpan)
        Me.PanelBtnBwh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBtnBwh.Location = New System.Drawing.Point(0, 359)
        Me.PanelBtnBwh.Name = "PanelBtnBwh"
        Me.PanelBtnBwh.Size = New System.Drawing.Size(1190, 42)
        Me.PanelBtnBwh.TabIndex = 1
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatal.Location = New System.Drawing.Point(173, 7)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnBatal.Size = New System.Drawing.Size(135, 31)
        Me.btnBatal.TabIndex = 129
        Me.btnBatal.Text = "Cancel"
        Me.btnBatal.UseVisualStyleBackColor = True
        Me.btnBatal.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnBatal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(14, 7)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Padding = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.btnSimpan.Size = New System.Drawing.Size(135, 31)
        Me.btnSimpan.TabIndex = 128
        Me.btnSimpan.Text = "Save"
        Me.btnSimpan.UseVisualStyleBackColor = True
        Me.btnSimpan.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnSimpan.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'dgvInventaris
        '
        Me.dgvInventaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventaris.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInventaris.Location = New System.Drawing.Point(0, 0)
        Me.dgvInventaris.Name = "dgvInventaris"
        Me.dgvInventaris.RowTemplate.Height = 24
        Me.dgvInventaris.Size = New System.Drawing.Size(1190, 401)
        Me.dgvInventaris.TabIndex = 0
        '
        'PanelToolStrip
        '
        Me.PanelToolStrip.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelToolStrip.Controls.Add(Me.ToolStrip1)
        Me.PanelToolStrip.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelToolStrip.Location = New System.Drawing.Point(0, 279)
        Me.PanelToolStrip.Name = "PanelToolStrip"
        Me.PanelToolStrip.Size = New System.Drawing.Size(1190, 27)
        Me.PanelToolStrip.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripAdd, Me.ToolStripDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1190, 27)
        Me.ToolStrip1.TabIndex = 1
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
        'PanelEntry
        '
        Me.PanelEntry.Controls.Add(Me.dtptanggal)
        Me.PanelEntry.Controls.Add(Me.Label1)
        Me.PanelEntry.Controls.Add(Me.LbInventaris)
        Me.PanelEntry.Controls.Add(Me.btnRuang)
        Me.PanelEntry.Controls.Add(Me.txtPetugas)
        Me.PanelEntry.Controls.Add(Me.Label2)
        Me.PanelEntry.Controls.Add(Me.LbPetugas)
        Me.PanelEntry.Controls.Add(Me.LbJmlKM)
        Me.PanelEntry.Controls.Add(Me.LbJmlPAR)
        Me.PanelEntry.Controls.Add(Me.lbJmlTT)
        Me.PanelEntry.Controls.Add(Me.LbInst)
        Me.PanelEntry.Controls.Add(Me.txtJmlKM)
        Me.PanelEntry.Controls.Add(Me.txtJmlPAR)
        Me.PanelEntry.Controls.Add(Me.txtJmlTT)
        Me.PanelEntry.Controls.Add(Me.txtInstalasi)
        Me.PanelEntry.Controls.Add(Me.txtRuang)
        Me.PanelEntry.Controls.Add(Me.LblRuang)
        Me.PanelEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEntry.Location = New System.Drawing.Point(0, 40)
        Me.PanelEntry.Name = "PanelEntry"
        Me.PanelEntry.Size = New System.Drawing.Size(1190, 239)
        Me.PanelEntry.TabIndex = 1
        '
        'dtptanggal
        '
        Me.dtptanggal.CustomFormat = "dd/M/yyyy"
        Me.dtptanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptanggal.Location = New System.Drawing.Point(684, 70)
        Me.dtptanggal.Name = "dtptanggal"
        Me.dtptanggal.Size = New System.Drawing.Size(109, 22)
        Me.dtptanggal.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(751, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "No Inventaris "
        '
        'LbInventaris
        '
        Me.LbInventaris.AutoSize = True
        Me.LbInventaris.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInventaris.Location = New System.Drawing.Point(592, 113)
        Me.LbInventaris.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbInventaris.Name = "LbInventaris"
        Me.LbInventaris.Size = New System.Drawing.Size(139, 18)
        Me.LbInventaris.TabIndex = 37
        Me.LbInventaris.Text = "No Inventarisasi :"
        '
        'btnRuang
        '
        Me.btnRuang.Location = New System.Drawing.Point(502, 22)
        Me.btnRuang.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRuang.Name = "btnRuang"
        Me.btnRuang.Size = New System.Drawing.Size(32, 25)
        Me.btnRuang.TabIndex = 36
        Me.btnRuang.Text = "..."
        Me.btnRuang.UseVisualStyleBackColor = True
        '
        'txtPetugas
        '
        Me.txtPetugas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPetugas.Location = New System.Drawing.Point(684, 21)
        Me.txtPetugas.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.ReadOnly = True
        Me.txtPetugas.Size = New System.Drawing.Size(315, 22)
        Me.txtPetugas.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(592, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Tanggal"
        '
        'LbPetugas
        '
        Me.LbPetugas.AutoSize = True
        Me.LbPetugas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPetugas.Location = New System.Drawing.Point(592, 27)
        Me.LbPetugas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbPetugas.Name = "LbPetugas"
        Me.LbPetugas.Size = New System.Drawing.Size(67, 18)
        Me.LbPetugas.TabIndex = 32
        Me.LbPetugas.Text = "Petugas"
        '
        'LbJmlKM
        '
        Me.LbJmlKM.AutoSize = True
        Me.LbJmlKM.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJmlKM.Location = New System.Drawing.Point(24, 198)
        Me.LbJmlKM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbJmlKM.Name = "LbJmlKM"
        Me.LbJmlKM.Size = New System.Drawing.Size(61, 18)
        Me.LbJmlKM.TabIndex = 31
        Me.LbJmlKM.Text = "Jml KM"
        '
        'LbJmlPAR
        '
        Me.LbJmlPAR.AutoSize = True
        Me.LbJmlPAR.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJmlPAR.Location = New System.Drawing.Point(24, 158)
        Me.LbJmlPAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbJmlPAR.Name = "LbJmlPAR"
        Me.LbJmlPAR.Size = New System.Drawing.Size(67, 18)
        Me.LbJmlPAR.TabIndex = 30
        Me.LbJmlPAR.Text = "Jml PAR"
        '
        'lbJmlTT
        '
        Me.lbJmlTT.AutoSize = True
        Me.lbJmlTT.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJmlTT.Location = New System.Drawing.Point(24, 113)
        Me.lbJmlTT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbJmlTT.Name = "lbJmlTT"
        Me.lbJmlTT.Size = New System.Drawing.Size(55, 18)
        Me.lbJmlTT.TabIndex = 29
        Me.lbJmlTT.Text = "Jml TT"
        '
        'LbInst
        '
        Me.LbInst.AutoSize = True
        Me.LbInst.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbInst.Location = New System.Drawing.Point(24, 70)
        Me.LbInst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbInst.Name = "LbInst"
        Me.LbInst.Size = New System.Drawing.Size(68, 18)
        Me.LbInst.TabIndex = 28
        Me.LbInst.Text = "Instalasi"
        '
        'txtJmlKM
        '
        Me.txtJmlKM.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtJmlKM.Location = New System.Drawing.Point(157, 198)
        Me.txtJmlKM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlKM.Name = "txtJmlKM"
        Me.txtJmlKM.Size = New System.Drawing.Size(182, 22)
        Me.txtJmlKM.TabIndex = 27
        '
        'txtJmlPAR
        '
        Me.txtJmlPAR.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtJmlPAR.Location = New System.Drawing.Point(157, 153)
        Me.txtJmlPAR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlPAR.Name = "txtJmlPAR"
        Me.txtJmlPAR.Size = New System.Drawing.Size(182, 22)
        Me.txtJmlPAR.TabIndex = 26
        '
        'txtJmlTT
        '
        Me.txtJmlTT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtJmlTT.Location = New System.Drawing.Point(157, 108)
        Me.txtJmlTT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlTT.Name = "txtJmlTT"
        Me.txtJmlTT.Size = New System.Drawing.Size(182, 22)
        Me.txtJmlTT.TabIndex = 25
        '
        'txtInstalasi
        '
        Me.txtInstalasi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtInstalasi.Location = New System.Drawing.Point(157, 65)
        Me.txtInstalasi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInstalasi.Name = "txtInstalasi"
        Me.txtInstalasi.ReadOnly = True
        Me.txtInstalasi.Size = New System.Drawing.Size(315, 22)
        Me.txtInstalasi.TabIndex = 24
        '
        'txtRuang
        '
        Me.txtRuang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtRuang.Location = New System.Drawing.Point(157, 22)
        Me.txtRuang.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuang.Name = "txtRuang"
        Me.txtRuang.ReadOnly = True
        Me.txtRuang.Size = New System.Drawing.Size(315, 22)
        Me.txtRuang.TabIndex = 23
        '
        'LblRuang
        '
        Me.LblRuang.AutoSize = True
        Me.LblRuang.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRuang.Location = New System.Drawing.Point(24, 26)
        Me.LblRuang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRuang.Name = "LblRuang"
        Me.LblRuang.Size = New System.Drawing.Size(54, 18)
        Me.LblRuang.TabIndex = 22
        Me.LblRuang.Text = "Ruang"
        '
        'PanelJudul
        '
        Me.PanelJudul.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelJudul.Controls.Add(Me.LbJudul)
        Me.PanelJudul.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelJudul.Location = New System.Drawing.Point(0, 0)
        Me.PanelJudul.Name = "PanelJudul"
        Me.PanelJudul.Size = New System.Drawing.Size(1190, 40)
        Me.PanelJudul.TabIndex = 0
        '
        'LbJudul
        '
        Me.LbJudul.AutoSize = True
        Me.LbJudul.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJudul.Location = New System.Drawing.Point(24, 10)
        Me.LbJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbJudul.Name = "LbJudul"
        Me.LbJudul.Size = New System.Drawing.Size(0, 20)
        Me.LbJudul.TabIndex = 39
        '
        'UcAddInventarisRuangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UcAddInventarisRuangan"
        Me.Size = New System.Drawing.Size(1190, 707)
        Me.Panel1.ResumeLayout(False)
        Me.PanelDGV.ResumeLayout(False)
        Me.PanelBtnBwh.ResumeLayout(False)
        CType(Me.dgvInventaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolStrip.ResumeLayout(False)
        Me.PanelToolStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanelEntry.ResumeLayout(False)
        Me.PanelEntry.PerformLayout()
        Me.PanelJudul.ResumeLayout(False)
        Me.PanelJudul.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelDGV As System.Windows.Forms.Panel
    Friend WithEvents PanelBtnBwh As System.Windows.Forms.Panel
    Friend WithEvents dgvInventaris As System.Windows.Forms.DataGridView
    Friend WithEvents PanelToolStrip As System.Windows.Forms.Panel
    Friend WithEvents PanelEntry As System.Windows.Forms.Panel
    Friend WithEvents PanelJudul As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBatal As C1.Win.C1Input.C1Button
    Friend WithEvents btnSimpan As C1.Win.C1Input.C1Button
    Friend WithEvents LbJmlKM As System.Windows.Forms.Label
    Friend WithEvents LbJmlPAR As System.Windows.Forms.Label
    Friend WithEvents lbJmlTT As System.Windows.Forms.Label
    Friend WithEvents LbInst As System.Windows.Forms.Label
    Friend WithEvents txtJmlKM As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlPAR As System.Windows.Forms.TextBox
    Friend WithEvents txtJmlTT As System.Windows.Forms.TextBox
    Friend WithEvents txtInstalasi As System.Windows.Forms.TextBox
    Friend WithEvents txtRuang As System.Windows.Forms.TextBox
    Friend WithEvents LblRuang As System.Windows.Forms.Label
    Friend WithEvents txtPetugas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LbPetugas As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LbInventaris As System.Windows.Forms.Label
    Friend WithEvents btnRuang As System.Windows.Forms.Button
    Friend WithEvents LbJudul As System.Windows.Forms.Label
    Friend WithEvents dtptanggal As System.Windows.Forms.DateTimePicker

End Class
