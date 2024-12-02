<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKitirOrder
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
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.btnExportExcel = New C1.Win.C1Input.C1Button()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.LightSlateGray
        Me.PanelTitle.Controls.Add(Me.btnExportExcel)
        Me.PanelTitle.Controls.Add(Me.LabelJudul)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1115, 62)
        Me.PanelTitle.TabIndex = 1
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Location = New System.Drawing.Point(316, 15)
        Me.btnExportExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(133, 33)
        Me.btnExportExcel.TabIndex = 163
        Me.btnExportExcel.Text = "Export to Excel"
        Me.btnExportExcel.UseVisualStyleBackColor = True
        Me.btnExportExcel.Visible = False
        Me.btnExportExcel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnExportExcel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.Color.White
        Me.LabelJudul.Location = New System.Drawing.Point(21, 18)
        Me.LabelJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(220, 25)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "Bukti Order Binatu"
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 62)
        Me.crv.Margin = New System.Windows.Forms.Padding(4)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1115, 438)
        Me.crv.TabIndex = 5
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FormKitirOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 500)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.PanelTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormKitirOrder"
        Me.Text = "FormCetakOrder"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents LabelJudul As System.Windows.Forms.Label
    Friend WithEvents btnExportExcel As C1.Win.C1Input.C1Button
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
