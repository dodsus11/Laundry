<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modAssignProcToRole
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modAssignProcToRole))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Trv = New System.Windows.Forms.TreeView()
        Me.pnTop = New System.Windows.Forms.Panel()
        Me.pnLeft = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRemove = New C1.Win.C1Input.C1Button()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAdd = New C1.Win.C1Input.C1Button()
        Me.btnFooter = New UILibs.BtnSaveAndClose()
        Me.gv = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.pnTop.SuspendLayout()
        Me.pnLeft.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(29, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(130, 14)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Assign Process >>"
        '
        'Trv
        '
        Me.Trv.BackColor = System.Drawing.SystemColors.Info
        Me.Trv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Trv.Location = New System.Drawing.Point(0, 0)
        Me.Trv.Name = "Trv"
        Me.Trv.Size = New System.Drawing.Size(347, 354)
        Me.Trv.TabIndex = 4
        '
        'pnTop
        '
        Me.pnTop.BackColor = System.Drawing.Color.SteelBlue
        Me.pnTop.Controls.Add(Me.lblTitle)
        Me.pnTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTop.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnTop.Location = New System.Drawing.Point(0, 0)
        Me.pnTop.Name = "pnTop"
        Me.pnTop.Size = New System.Drawing.Size(839, 34)
        Me.pnTop.TabIndex = 3
        '
        'pnLeft
        '
        Me.pnLeft.Controls.Add(Me.Trv)
        Me.pnLeft.Controls.Add(Me.Panel2)
        Me.pnLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnLeft.Location = New System.Drawing.Point(0, 34)
        Me.pnLeft.Name = "pnLeft"
        Me.pnLeft.Size = New System.Drawing.Size(347, 403)
        Me.pnLeft.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnRemove)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 354)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(347, 49)
        Me.Panel2.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.ImageKey = "Erase.gif"
        Me.btnRemove.ImageList = Me.imgList
        Me.btnRemove.Location = New System.Drawing.Point(89, 10)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 31)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnRemove.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "Add.gif")
        Me.imgList.Images.SetKeyName(1, "Erase.gif")
        '
        'btnAdd
        '
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageKey = "Add.gif"
        Me.btnAdd.ImageList = Me.imgList
        Me.btnAdd.Location = New System.Drawing.Point(8, 10)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 31)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        Me.btnAdd.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black
        '
        'btnFooter
        '
        Me.btnFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnFooter.Location = New System.Drawing.Point(0, 437)
        Me.btnFooter.Name = "btnFooter"
        Me.btnFooter.Size = New System.Drawing.Size(839, 45)
        Me.btnFooter.TabIndex = 7
        '
        'gv
        '
        Me.gv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gv.Images.Add(CType(resources.GetObject("gv.Images"), System.Drawing.Image))
        Me.gv.Location = New System.Drawing.Point(347, 34)
        Me.gv.Name = "gv"
        Me.gv.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.gv.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.gv.PreviewInfo.ZoomFactor = 75.0R
        Me.gv.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.gv.Size = New System.Drawing.Size(492, 403)
        Me.gv.TabIndex = 8
        Me.gv.Text = "C1TrueDBGrid1"
        Me.gv.PropBag = resources.GetString("gv.PropBag")
        '
        'modAssignProcToRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.gv)
        Me.Controls.Add(Me.pnLeft)
        Me.Controls.Add(Me.btnFooter)
        Me.Controls.Add(Me.pnTop)
        Me.Name = "modAssignProcToRole"
        Me.Size = New System.Drawing.Size(839, 482)
        Me.pnTop.ResumeLayout(False)
        Me.pnTop.PerformLayout()
        Me.pnLeft.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Trv As System.Windows.Forms.TreeView
    Friend WithEvents pnTop As System.Windows.Forms.Panel
    Friend WithEvents pnLeft As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents btnFooter As UILibs.BtnSaveAndClose
    Friend WithEvents btnAdd As C1.Win.C1Input.C1Button
    Friend WithEvents btnRemove As C1.Win.C1Input.C1Button
    Friend WithEvents gv As C1.Win.C1TrueDBGrid.C1TrueDBGrid

End Class
