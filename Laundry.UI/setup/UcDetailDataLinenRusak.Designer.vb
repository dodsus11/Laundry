<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcDetailDataLinenRusak
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpJam = New System.Windows.Forms.DateTimePicker()
        Me.btnPetugas = New System.Windows.Forms.Button()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.dgvDtLinenRusak = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvDtLinenRusak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 165)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADD DETAIL DATA LINEN RUSAK"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.dtpJam)
        Me.Panel2.Controls.Add(Me.btnPetugas)
        Me.Panel2.Controls.Add(Me.txtPetugas)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1134, 94)
        Me.Panel2.TabIndex = 7
        '
        'dtpJam
        '
        Me.dtpJam.Location = New System.Drawing.Point(1104, 61)
        Me.dtpJam.Name = "dtpJam"
        Me.dtpJam.Size = New System.Drawing.Size(17, 27)
        Me.dtpJam.TabIndex = 3
        Me.dtpJam.Visible = False
        '
        'btnPetugas
        '
        Me.btnPetugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPetugas.Location = New System.Drawing.Point(559, 26)
        Me.btnPetugas.Name = "btnPetugas"
        Me.btnPetugas.Size = New System.Drawing.Size(53, 28)
        Me.btnPetugas.TabIndex = 2
        Me.btnPetugas.Text = "..."
        Me.btnPetugas.UseVisualStyleBackColor = True
        '
        'txtPetugas
        '
        Me.txtPetugas.Location = New System.Drawing.Point(203, 24)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.Size = New System.Drawing.Size(327, 27)
        Me.txtPetugas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Pegawai"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.dgvDtLinenRusak)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 165)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1134, 444)
        Me.Panel3.TabIndex = 7
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 363)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1134, 81)
        Me.Panel4.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnSimpan)
        Me.Panel5.Controls.Add(Me.btnBatal)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(798, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(336, 81)
        Me.Panel5.TabIndex = 11
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(22, 22)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(128, 40)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(193, 22)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(117, 40)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'dgvDtLinenRusak
        '
        Me.dgvDtLinenRusak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDtLinenRusak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDtLinenRusak.Location = New System.Drawing.Point(0, 0)
        Me.dgvDtLinenRusak.Name = "dgvDtLinenRusak"
        Me.dgvDtLinenRusak.RowTemplate.Height = 24
        Me.dgvDtLinenRusak.Size = New System.Drawing.Size(1134, 444)
        Me.dgvDtLinenRusak.TabIndex = 8
        '
        'UcDetailDataLinenRusak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UcDetailDataLinenRusak"
        Me.Size = New System.Drawing.Size(1134, 609)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvDtLinenRusak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnPetugas As System.Windows.Forms.Button
    Friend WithEvents txtPetugas As System.Windows.Forms.TextBox
    Friend WithEvents dgvDtLinenRusak As System.Windows.Forms.DataGridView
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dtpJam As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel5 As System.Windows.Forms.Panel

End Class
