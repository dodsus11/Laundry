<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgMenuAdd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.seTemp = New UILibs.SaveEditTemp()
        Me.txtMenuName = New C1.Win.C1Input.C1TextBox()
        Me.txtIconName = New C1.Win.C1Input.C1TextBox()
        Me.btnBrowse = New C1.Win.C1Input.C1Button()
        CType(Me.txtMenuName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIconName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Menu Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Icon :"
        '
        'Ofd
        '
        Me.Ofd.FileName = "File Icon"
        '
        'seTemp
        '
        Me.seTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.seTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seTemp.Location = New System.Drawing.Point(0, 0)
        Me.seTemp.Name = "seTemp"
        Me.seTemp.Size = New System.Drawing.Size(356, 241)
        Me.seTemp.TabIndex = 0
        '
        'txtMenuName
        '
        Me.txtMenuName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtMenuName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMenuName.Location = New System.Drawing.Point(102, 53)
        Me.txtMenuName.Multiline = True
        Me.txtMenuName.Name = "txtMenuName"
        Me.txtMenuName.Size = New System.Drawing.Size(191, 20)
        Me.txtMenuName.TabIndex = 6
        Me.txtMenuName.Tag = Nothing
        Me.txtMenuName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMenuName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtIconName
        '
        Me.txtIconName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtIconName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIconName.Location = New System.Drawing.Point(102, 79)
        Me.txtIconName.Multiline = True
        Me.txtIconName.Name = "txtIconName"
        Me.txtIconName.Size = New System.Drawing.Size(191, 20)
        Me.txtIconName.TabIndex = 7
        Me.txtIconName.Tag = Nothing
        Me.txtIconName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtIconName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(300, 79)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(44, 23)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        Me.btnBrowse.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnBrowse.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'DlgMenuAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 241)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtIconName)
        Me.Controls.Add(Me.txtMenuName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seTemp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DlgMenuAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Child Menu"
        CType(Me.txtMenuName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIconName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents seTemp As UILibs.SaveEditTemp
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtMenuName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtIconName As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnBrowse As C1.Win.C1Input.C1Button
End Class
