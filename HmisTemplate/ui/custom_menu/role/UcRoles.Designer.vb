<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcRoles
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
        Me.pnCenter = New System.Windows.Forms.Panel()
        Me.gv = New System.Windows.Forms.DataGridView()
        Me.FindCtr = New UILibs.FindControl()
        Me.seTemp = New UILibs.SetupTemplate()
        Me.pnCenter.SuspendLayout()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnCenter
        '
        Me.pnCenter.Controls.Add(Me.gv)
        Me.pnCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCenter.Location = New System.Drawing.Point(150, 38)
        Me.pnCenter.Name = "pnCenter"
        Me.pnCenter.Padding = New System.Windows.Forms.Padding(5)
        Me.pnCenter.Size = New System.Drawing.Size(439, 329)
        Me.pnCenter.TabIndex = 1
        '
        'gv
        '
        Me.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv.Location = New System.Drawing.Point(5, 5)
        Me.gv.Name = "gv"
        Me.gv.Size = New System.Drawing.Size(429, 319)
        Me.gv.TabIndex = 0
        '
        'FindCtr
        '
        Me.FindCtr.Dock = System.Windows.Forms.DockStyle.Left
        Me.FindCtr.Location = New System.Drawing.Point(0, 38)
        Me.FindCtr.Name = "FindCtr"
        Me.FindCtr.Size = New System.Drawing.Size(150, 329)
        Me.FindCtr.TabIndex = 4
        '
        'seTemp
        '
        Me.seTemp.Dock = System.Windows.Forms.DockStyle.Top
        Me.seTemp.Location = New System.Drawing.Point(0, 0)
        Me.seTemp.Name = "seTemp"
        Me.seTemp.Size = New System.Drawing.Size(589, 38)
        Me.seTemp.TabIndex = 3
        Me.seTemp.viewDelete = True
        Me.seTemp.viewEdit = True
        Me.seTemp.viewNew = True
        Me.seTemp.viewSave = False
        '
        'UcRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnCenter)
        Me.Controls.Add(Me.FindCtr)
        Me.Controls.Add(Me.seTemp)
        Me.Name = "UcRoles"
        Me.Size = New System.Drawing.Size(589, 367)
        Me.pnCenter.ResumeLayout(False)
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnCenter As System.Windows.Forms.Panel
    Friend WithEvents seTemp As UILibs.SetupTemplate
    Friend WithEvents FindCtr As UILibs.FindControl
    Friend WithEvents gv As System.Windows.Forms.DataGridView

End Class
