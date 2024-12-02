<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProcessAdd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBrowseIcon = New System.Windows.Forms.Button()
        Me.Ofd = New System.Windows.Forms.OpenFileDialog()
        Me.seTemp = New UILibs.SaveEditTemp()
        Me.PicIcon = New System.Windows.Forms.PictureBox()
        Me.txtProcessName = New C1.Win.C1Input.C1TextBox()
        Me.txtImage = New C1.Win.C1Input.C1TextBox()
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Process Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Image Icon :"
        '
        'btnBrowseIcon
        '
        Me.btnBrowseIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseIcon.Image = UtilsLibs.My.Resources.MyFolder._Next   'Global.HmisTemplate.My.Resources.Resources._Next
        Me.btnBrowseIcon.Location = New System.Drawing.Point(402, 80)
        Me.btnBrowseIcon.Name = "btnBrowseIcon"
        Me.btnBrowseIcon.Size = New System.Drawing.Size(31, 23)
        Me.btnBrowseIcon.TabIndex = 5
        Me.btnBrowseIcon.UseVisualStyleBackColor = True
        '
        'Ofd
        '
        Me.Ofd.FileName = "File"
        Me.Ofd.InitialDirectory = "/images"
        '
        'seTemp
        '
        Me.seTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.seTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seTemp.Location = New System.Drawing.Point(0, 0)
        Me.seTemp.Name = "seTemp"
        Me.seTemp.Size = New System.Drawing.Size(719, 344)
        Me.seTemp.TabIndex = 0
        '
        'PicIcon
        '
        Me.PicIcon.Location = New System.Drawing.Point(148, 110)
        Me.PicIcon.Name = "PicIcon"
        Me.PicIcon.Size = New System.Drawing.Size(82, 73)
        Me.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicIcon.TabIndex = 6
        Me.PicIcon.TabStop = False
        '
        'txtProcessName
        '
        Me.txtProcessName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtProcessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessName.Location = New System.Drawing.Point(147, 54)
        Me.txtProcessName.Multiline = True
        Me.txtProcessName.Name = "txtProcessName"
        Me.txtProcessName.Size = New System.Drawing.Size(248, 20)
        Me.txtProcessName.TabIndex = 7
        Me.txtProcessName.Tag = Nothing
        Me.txtProcessName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtProcessName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtImage
        '
        Me.txtImage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImage.Location = New System.Drawing.Point(147, 80)
        Me.txtImage.Multiline = True
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(248, 20)
        Me.txtImage.TabIndex = 8
        Me.txtImage.Tag = Nothing
        Me.txtImage.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtImage.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ucProcessAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtImage)
        Me.Controls.Add(Me.txtProcessName)
        Me.Controls.Add(Me.PicIcon)
        Me.Controls.Add(Me.btnBrowseIcon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seTemp)
        Me.Name = "ucProcessAdd"
        Me.Size = New System.Drawing.Size(719, 344)
        CType(Me.PicIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents seTemp As UILibs.SaveEditTemp
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseIcon As System.Windows.Forms.Button
    Friend WithEvents Ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PicIcon As System.Windows.Forms.PictureBox
    Friend WithEvents txtProcessName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtImage As C1.Win.C1Input.C1TextBox

End Class
