<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransCode))
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.gv = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.pnTop.SuspendLayout()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.SystemColors.Info
        Me.pnTop.Controls.Add(Me.txtFilter)
        Me.pnTop.Controls.Add(Me.Label1)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(546, 46)
        Me.pnTop.TabIndex = 0
        '
        'gv
        '
        Me.gv.CaptionHeight = 17
        Me.gv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gv.Images.Add(CType(resources.GetObject("gv.Images"), System.Drawing.Image))
        Me.gv.Location = New System.Drawing.Point(0, 46)
        Me.gv.Name = "gv"
        Me.gv.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gv.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gv.PreviewInfo.ZoomFactor = 75.0R
        Me.gv.PrintInfo.PageSettings = CType(resources.GetObject("gv.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gv.RowHeight = 15
        Me.gv.Size = New System.Drawing.Size(546, 272)
        Me.gv.TabIndex = 1
        Me.gv.Text = "C1TrueDBGrid1"
        Me.gv.PropBag = resources.GetString("gv.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter :"
        '
        'txtFilter
        '
        Me.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(55, 13)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(223, 23)
        Me.txtFilter.TabIndex = 1
        '
        'FrmTransCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 318)
        Me.Controls.Add(Me.gv)
        Me.Controls.Add(Me.pnTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "FrmTransCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "T-Code Manual"
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents gv As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
