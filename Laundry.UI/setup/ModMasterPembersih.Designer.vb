﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModMasterPembersih
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
        Me.BrowseTemp.Name = "BrowseTemp"
        Me.BrowseTemp.Size = New System.Drawing.Size(665, 433)
        Me.BrowseTemp.TabIndex = 0
        '
        'ModInsertLinen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BrowseTemp)
        Me.Name = "ModInsertLinen"
        Me.Size = New System.Drawing.Size(665, 433)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BrowseTemp As UILibs.BrowseTemp

End Class
