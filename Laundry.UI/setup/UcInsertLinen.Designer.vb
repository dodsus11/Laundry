<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcInsertLinen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.Label()
        Me.txtKodeLinen = New System.Windows.Forms.TextBox()
        Me.txtNamaLinen = New System.Windows.Forms.TextBox()
        Me.txtBeratLinen = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(63, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Linen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(61, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Linen"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(63, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Berat Linen Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(377, 197)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "kg"
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtId.Location = New System.Drawing.Point(207, 76)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(0, 17)
        Me.txtId.TabIndex = 15
        Me.txtId.Visible = False
        '
        'txtKodeLinen
        '
        Me.txtKodeLinen.Location = New System.Drawing.Point(210, 106)
        Me.txtKodeLinen.Name = "txtKodeLinen"
        Me.txtKodeLinen.Size = New System.Drawing.Size(368, 22)
        Me.txtKodeLinen.TabIndex = 16
        '
        'txtNamaLinen
        '
        Me.txtNamaLinen.Location = New System.Drawing.Point(211, 153)
        Me.txtNamaLinen.Name = "txtNamaLinen"
        Me.txtNamaLinen.Size = New System.Drawing.Size(367, 22)
        Me.txtNamaLinen.TabIndex = 17
        '
        'txtBeratLinen
        '
        Me.txtBeratLinen.Location = New System.Drawing.Point(211, 197)
        Me.txtBeratLinen.Name = "txtBeratLinen"
        Me.txtBeratLinen.Size = New System.Drawing.Size(159, 22)
        Me.txtBeratLinen.TabIndex = 18
        '
        'UcInsertLinen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtBeratLinen)
        Me.Controls.Add(Me.txtNamaLinen)
        Me.Controls.Add(Me.txtKodeLinen)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcInsertLinen"
        Me.Size = New System.Drawing.Size(1000, 512)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.Label
    Friend WithEvents txtKodeLinen As System.Windows.Forms.TextBox
    Friend WithEvents txtBeratLinen As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaLinen As System.Windows.Forms.TextBox

End Class
