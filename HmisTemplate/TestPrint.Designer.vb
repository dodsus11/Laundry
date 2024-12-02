<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestPrint
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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(56, 114)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(492, 290)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'C1Button1
        '
        Me.C1Button1.Location = New System.Drawing.Point(74, 424)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(75, 23)
        Me.C1Button1.TabIndex = 1
        Me.C1Button1.Text = "C1Button1"
        Me.C1Button1.UseVisualStyleBackColor = True
        '
        'C1TextBox1
        '
        Me.C1TextBox1.Location = New System.Drawing.Point(168, 421)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(95, 26)
        Me.C1TextBox1.TabIndex = 2
        Me.C1TextBox1.Tag = Nothing
        '
        'TestPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 695)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TestPrint"
        Me.Text = "TestPrint"
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
End Class
