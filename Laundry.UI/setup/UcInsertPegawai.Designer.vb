<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcInsertPegawai
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
        Me.components = New System.ComponentModel.Container()
        Me.SaveEditTemp = New UILibs.SaveEditTemp()
        Me.txtNamaPegawai = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNip = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBagian = New C1.Win.C1Input.C1TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox_status_pegawai = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.Label()
        Me.Cachedcr_LaporanRekapLinenKelauar1 = New Laundry.UI.Cachedcr_LaporanRekapLinenKelauar()
        CType(Me.txtNamaPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBagian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveEditTemp
        '
        Me.SaveEditTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SaveEditTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveEditTemp.Location = New System.Drawing.Point(0, 0)
        Me.SaveEditTemp.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveEditTemp.Name = "SaveEditTemp"
        Me.SaveEditTemp.Size = New System.Drawing.Size(1000, 512)
        Me.SaveEditTemp.TabIndex = 0
        '
        'txtNamaPegawai
        '
        Me.txtNamaPegawai.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtNamaPegawai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPegawai.Location = New System.Drawing.Point(211, 148)
        Me.txtNamaPegawai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamaPegawai.Name = "txtNamaPegawai"
        Me.txtNamaPegawai.Size = New System.Drawing.Size(244, 20)
        Me.txtNamaPegawai.TabIndex = 2
        Me.txtNamaPegawai.Tag = Nothing
        Me.txtNamaPegawai.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtNamaPegawai.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(61, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Pegawai"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(61, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nip Pegawai"
        '
        'txtNip
        '
        Me.txtNip.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtNip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNip.Location = New System.Drawing.Point(211, 191)
        Me.txtNip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.Size = New System.Drawing.Size(244, 20)
        Me.txtNip.TabIndex = 5
        Me.txtNip.Tag = Nothing
        Me.txtNip.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtNip.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(61, 234)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bagian"
        '
        'txtBagian
        '
        Me.txtBagian.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtBagian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBagian.Location = New System.Drawing.Point(211, 234)
        Me.txtBagian.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBagian.Name = "txtBagian"
        Me.txtBagian.Size = New System.Drawing.Size(244, 20)
        Me.txtBagian.TabIndex = 7
        Me.txtBagian.Tag = Nothing
        Me.txtBagian.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtBagian.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label8.Location = New System.Drawing.Point(61, 279)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Status Pegawai"
        '
        'ComboBox_status_pegawai
        '
        Me.ComboBox_status_pegawai.FormattingEnabled = True
        Me.ComboBox_status_pegawai.Items.AddRange(New Object() {"PNS", "BLU", "OS"})
        Me.ComboBox_status_pegawai.Location = New System.Drawing.Point(211, 276)
        Me.ComboBox_status_pegawai.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_status_pegawai.Name = "ComboBox_status_pegawai"
        Me.ComboBox_status_pegawai.Size = New System.Drawing.Size(243, 24)
        Me.ComboBox_status_pegawai.TabIndex = 14
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtId.Location = New System.Drawing.Point(207, 70)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(0, 17)
        Me.txtId.TabIndex = 17
        Me.txtId.Visible = False
        '
        'UcInsertPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.ComboBox_status_pegawai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBagian)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaPegawai)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcInsertPegawai"
        Me.Size = New System.Drawing.Size(1000, 512)
        CType(Me.txtNamaPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBagian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents txtNamaPegawai As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBagian As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNip As C1.Win.C1Input.C1TextBox
    Friend WithEvents ComboBox_status_pegawai As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.Label
    Friend WithEvents Cachedcr_LaporanRekapLinenKelauar1 As Laundry.UI.Cachedcr_LaporanRekapLinenKelauar

End Class
