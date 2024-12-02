<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsers))
        Me.MultiColumnComboBox1 = New MultiColumnComboBoxDemo.MultiColumnComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TbControl = New UILibs.CustomTabControl()
        Me.ToolBtn = New UILibs.SetupTemplate()
        Me.SuspendLayout()
        '
        'MultiColumnComboBox1
        '
        Me.MultiColumnComboBox1.AutoComplete = False
        Me.MultiColumnComboBox1.AutoDropdown = False
        Me.MultiColumnComboBox1.BackColorEven = System.Drawing.Color.White
        Me.MultiColumnComboBox1.BackColorOdd = System.Drawing.Color.White
        Me.MultiColumnComboBox1.ColumnNames = ""
        Me.MultiColumnComboBox1.ColumnWidthDefault = 75
        Me.MultiColumnComboBox1.ColumnWidths = ""
        Me.MultiColumnComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.MultiColumnComboBox1.FormattingEnabled = True
        Me.MultiColumnComboBox1.LinkedColumnIndex = 0
        Me.MultiColumnComboBox1.LinkedTextBox = Nothing
        Me.MultiColumnComboBox1.Location = New System.Drawing.Point(58, 97)
        Me.MultiColumnComboBox1.Name = "MultiColumnComboBox1"
        Me.MultiColumnComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.MultiColumnComboBox1.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close_x.gif")
        '
        'TbControl
        '
        Me.TbControl.ImageList = Me.ImageList1
        Me.TbControl.ItemSize = New System.Drawing.Size(0, 15)
        Me.TbControl.Location = New System.Drawing.Point(225, 62)
        Me.TbControl.Name = "TbControl"
        Me.TbControl.Padding = New System.Drawing.Point(9, 0)
        Me.TbControl.SelectedIndex = 0
        Me.TbControl.Size = New System.Drawing.Size(333, 248)
        Me.TbControl.TabIndex = 2
        '
        'ToolBtn
        '
        Me.ToolBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ToolBtn.Location = New System.Drawing.Point(0, 0)
        Me.ToolBtn.Name = "ToolBtn"
        Me.ToolBtn.Size = New System.Drawing.Size(586, 56)
        Me.ToolBtn.TabIndex = 0
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 348)
        Me.Controls.Add(Me.TbControl)
        Me.Controls.Add(Me.MultiColumnComboBox1)
        Me.Controls.Add(Me.ToolBtn)
        Me.Name = "FrmUsers"
        Me.Text = "FrmUsers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolBtn As UILibs.SetupTemplate
    Friend WithEvents MultiColumnComboBox1 As MultiColumnComboBoxDemo.MultiColumnComboBox
    Friend WithEvents TbControl As UILibs.CustomTabControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
