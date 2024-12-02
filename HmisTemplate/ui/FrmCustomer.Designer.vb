<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.gv = New System.Windows.Forms.DataGridView()
        Me.pnImage = New System.Windows.Forms.Panel()
        Me.NaviGroup1 = New Guifreaks.NavigationBar.NaviGroup(Me.components)
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaviGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gv
        '
        Me.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv.Location = New System.Drawing.Point(338, 215)
        Me.gv.Name = "gv"
        Me.gv.Size = New System.Drawing.Size(129, 80)
        Me.gv.TabIndex = 0
        '
        'pnImage
        '
        Me.pnImage.Location = New System.Drawing.Point(70, 32)
        Me.pnImage.Name = "pnImage"
        Me.pnImage.Size = New System.Drawing.Size(210, 153)
        Me.pnImage.TabIndex = 1
        '
        'NaviGroup1
        '
        Me.NaviGroup1.Caption = Nothing
        Me.NaviGroup1.ExpandedHeight = 68
        Me.NaviGroup1.HeaderContextMenuStrip = Nothing
        Me.NaviGroup1.Location = New System.Drawing.Point(287, 50)
        Me.NaviGroup1.Name = "NaviGroup1"
        Me.NaviGroup1.Padding = New System.Windows.Forms.Padding(1, 22, 1, 1)
        Me.NaviGroup1.Size = New System.Drawing.Size(134, 68)
        Me.NaviGroup1.TabIndex = 2
        Me.NaviGroup1.Text = "NaviGroup1"
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 307)
        Me.Controls.Add(Me.NaviGroup1)
        Me.Controls.Add(Me.pnImage)
        Me.Controls.Add(Me.gv)
        Me.Name = "FrmCustomer"
        Me.Text = "FrmCustomer"
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaviGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gv As System.Windows.Forms.DataGridView
    Friend WithEvents pnImage As System.Windows.Forms.Panel
    Friend WithEvents NaviGroup1 As Guifreaks.NavigationBar.NaviGroup
End Class
