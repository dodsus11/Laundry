<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRekapLinen
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
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New C1.Win.C1Input.C1Button()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelTitle.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelTitle.Controls.Add(Me.LabelJudul)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1034, 50)
        Me.PanelTitle.TabIndex = 0
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.Color.White
        Me.LabelJudul.Location = New System.Drawing.Point(16, 15)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(227, 18)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "LAPORAN LINEN BERSIH"
        '
        'PanelControl
        '
        Me.PanelControl.Controls.Add(Me.btnExportExcel)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl.Location = New System.Drawing.Point(0, 50)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(1034, 75)
        Me.PanelControl.TabIndex = 1
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(19, 22)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(100, 27)
        Me.btnExportExcel.TabIndex = 163
        Me.btnExportExcel.Text = "Export to Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        Me.btnExportExcel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnExportExcel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 125)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1034, 484)
        Me.crv.TabIndex = 4
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ucRekapLinen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.PanelControl)
        Me.Controls.Add(Me.PanelTitle)
        Me.Name = "ucRekapLinen"
        Me.Size = New System.Drawing.Size(1034, 609)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents PanelControl As System.Windows.Forms.Panel
    Friend WithEvents btnExportExcel As C1.Win.C1Input.C1Button
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
