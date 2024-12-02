<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcControlAdd
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.seTemp = New UILibs.SaveEditTemp()
        Me.txtCaption = New C1.Win.C1Input.C1TextBox()
        Me.txtDll = New C1.Win.C1Input.C1TextBox()
        Me.txtUcName = New C1.Win.C1Input.C1TextBox()
        Me.txtIcon = New C1.Win.C1Input.C1TextBox()
        Me.txtDesc = New C1.Win.C1Input.C1TextBox()
        Me.searchDll = New C1.Win.C1Input.C1Button()
        Me.btnUc = New C1.Win.C1Input.C1Button()
        Me.btnIcon = New C1.Win.C1Input.C1Button()
        CType(Me.txtCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUcName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Caption"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Dll"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "User Control"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Icon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Description"
        '
        'seTemp
        '
        Me.seTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.seTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.seTemp.Location = New System.Drawing.Point(0, 0)
        Me.seTemp.Name = "seTemp"
        Me.seTemp.Size = New System.Drawing.Size(639, 405)
        Me.seTemp.TabIndex = 0
        '
        'txtCaption
        '
        Me.txtCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaption.Location = New System.Drawing.Point(140, 64)
        Me.txtCaption.Multiline = True
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(283, 18)
        Me.txtCaption.TabIndex = 14
        Me.txtCaption.Tag = Nothing
        Me.txtCaption.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtCaption.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtDll
        '
        Me.txtDll.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtDll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDll.Location = New System.Drawing.Point(140, 101)
        Me.txtDll.Multiline = True
        Me.txtDll.Name = "txtDll"
        Me.txtDll.Size = New System.Drawing.Size(241, 20)
        Me.txtDll.TabIndex = 15
        Me.txtDll.Tag = Nothing
        Me.txtDll.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtDll.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtUcName
        '
        Me.txtUcName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtUcName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUcName.Location = New System.Drawing.Point(140, 138)
        Me.txtUcName.Multiline = True
        Me.txtUcName.Name = "txtUcName"
        Me.txtUcName.Size = New System.Drawing.Size(241, 20)
        Me.txtUcName.TabIndex = 16
        Me.txtUcName.Tag = Nothing
        Me.txtUcName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtUcName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtIcon
        '
        Me.txtIcon.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIcon.Location = New System.Drawing.Point(140, 174)
        Me.txtIcon.Multiline = True
        Me.txtIcon.Name = "txtIcon"
        Me.txtIcon.Size = New System.Drawing.Size(241, 20)
        Me.txtIcon.TabIndex = 17
        Me.txtIcon.Tag = Nothing
        Me.txtIcon.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtIcon.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'txtDesc
        '
        Me.txtDesc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(140, 213)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(283, 95)
        Me.txtDesc.TabIndex = 0
        Me.txtDesc.Tag = Nothing
        Me.txtDesc.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.txtDesc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'searchDll
        '
        Me.searchDll.Location = New System.Drawing.Point(388, 99)
        Me.searchDll.Name = "searchDll"
        Me.searchDll.Size = New System.Drawing.Size(35, 23)
        Me.searchDll.TabIndex = 0
        Me.searchDll.Text = "..."
        Me.searchDll.UseVisualStyleBackColor = True
        Me.searchDll.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.searchDll.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnUc
        '
        Me.btnUc.Location = New System.Drawing.Point(388, 138)
        Me.btnUc.Name = "btnUc"
        Me.btnUc.Size = New System.Drawing.Size(35, 23)
        Me.btnUc.TabIndex = 18
        Me.btnUc.Text = "..."
        Me.btnUc.UseVisualStyleBackColor = True
        Me.btnUc.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnUc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnIcon
        '
        Me.btnIcon.Location = New System.Drawing.Point(388, 174)
        Me.btnIcon.Name = "btnIcon"
        Me.btnIcon.Size = New System.Drawing.Size(35, 23)
        Me.btnIcon.TabIndex = 19
        Me.btnIcon.Text = "..."
        Me.btnIcon.UseVisualStyleBackColor = True
        Me.btnIcon.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnIcon.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'UcControlAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnIcon)
        Me.Controls.Add(Me.btnUc)
        Me.Controls.Add(Me.searchDll)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtIcon)
        Me.Controls.Add(Me.txtUcName)
        Me.Controls.Add(Me.txtDll)
        Me.Controls.Add(Me.txtCaption)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seTemp)
        Me.Name = "UcControlAdd"
        Me.Size = New System.Drawing.Size(639, 405)
        CType(Me.txtCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUcName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents seTemp As UILibs.SaveEditTemp
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCaption As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDll As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtUcName As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtIcon As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDesc As C1.Win.C1Input.C1TextBox
    Friend WithEvents searchDll As C1.Win.C1Input.C1Button
    Friend WithEvents btnUc As C1.Win.C1Input.C1Button
    Friend WithEvents btnIcon As C1.Win.C1Input.C1Button

End Class
