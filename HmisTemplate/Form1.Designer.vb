<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lv = New System.Windows.Forms.ListView()
        Me.picBox = New System.Windows.Forms.PictureBox()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtPlain = New System.Windows.Forms.TextBox()
        Me.txtEncrypt = New System.Windows.Forms.TextBox()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lv
        '
        Me.lv.FullRowSelect = True
        Me.lv.Location = New System.Drawing.Point(41, 73)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(102, 99)
        Me.lv.TabIndex = 1
        Me.lv.UseCompatibleStateImageBehavior = False
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(174, 29)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(117, 143)
        Me.picBox.TabIndex = 2
        Me.picBox.TabStop = False
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(297, 29)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(172, 150)
        Me.C1TrueDBGrid1.TabIndex = 3
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(41, 192)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(428, 124)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtEncrypt)
        Me.TabPage1.Controls.Add(Me.txtPlain)
        Me.TabPage1.Controls.Add(Me.btnEncrypt)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(420, 98)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(420, 98)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(326, 17)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncrypt.TabIndex = 0
        Me.btnEncrypt.Text = "Encrypth"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'txtPlain
        '
        Me.txtPlain.Location = New System.Drawing.Point(15, 17)
        Me.txtPlain.Name = "txtPlain"
        Me.txtPlain.Size = New System.Drawing.Size(305, 20)
        Me.txtPlain.TabIndex = 1
        '
        'txtEncrypt
        '
        Me.txtEncrypt.Location = New System.Drawing.Point(15, 53)
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.Size = New System.Drawing.Size(305, 20)
        Me.txtEncrypt.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 328)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lv As System.Windows.Forms.ListView
    Friend WithEvents picBox As System.Windows.Forms.PictureBox
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtPlain As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtEncrypt As System.Windows.Forms.TextBox

End Class
