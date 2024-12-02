<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModUtilisasiMesin
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
        Me.BrowseTemp = New UILibs.BrowseTemp()
        Me.SuspendLayout()
        '
        'BrowseTemp
        '
        Me.BrowseTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BrowseTemp.Location = New System.Drawing.Point(0, 0)
        Me.BrowseTemp.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BrowseTemp.Name = "BrowseTemp"
        Me.BrowseTemp.Size = New System.Drawing.Size(887, 533)
        Me.BrowseTemp.TabIndex = 0
        '
        'ModUtilisasiMesin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BrowseTemp)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ModUtilisasiMesin"
        Me.Size = New System.Drawing.Size(887, 533)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BrowseTemp As UILibs.BrowseTemp

End Class
