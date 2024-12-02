<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcInsertPembersih2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJmlAlkaline = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJmlDetergent = New C1.Win.C1Input.C1TextBox()
        Me.txtJmlOxybleach = New C1.Win.C1Input.C1TextBox()
        Me.SaveEditTemp = New UILibs.SaveEditTemp()
        Me.txtBeratLinen = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_jns_ident_kotoran = New System.Windows.Forms.ComboBox()
        Me.txtJmlPenetral = New C1.Win.C1Input.C1TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJmlSoftener = New C1.Win.C1Input.C1TextBox()
        Me.txtIdDosis = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlAlkaline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlDetergent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlOxybleach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBeratLinen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlPenetral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJmlSoftener, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(61, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Jenis Identifikasi Kotoran"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(61, 188)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jumlah Alkaline (ml)"
        '
        'txtJmlAlkaline
        '
        Me.txtJmlAlkaline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtJmlAlkaline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlAlkaline.Location = New System.Drawing.Point(239, 188)
        Me.txtJmlAlkaline.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlAlkaline.Name = "txtJmlAlkaline"
        Me.txtJmlAlkaline.Size = New System.Drawing.Size(119, 20)
        Me.txtJmlAlkaline.TabIndex = 6
        Me.txtJmlAlkaline.Tag = Nothing
        Me.txtJmlAlkaline.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtJmlAlkaline.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label5.Location = New System.Drawing.Point(61, 288)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Jumlah Oxybleach (ml)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(60, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jumlah Detergent (ml)"
        '
        'txtJmlDetergent
        '
        Me.txtJmlDetergent.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtJmlDetergent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlDetergent.Location = New System.Drawing.Point(239, 238)
        Me.txtJmlDetergent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlDetergent.Name = "txtJmlDetergent"
        Me.txtJmlDetergent.Size = New System.Drawing.Size(119, 20)
        Me.txtJmlDetergent.TabIndex = 9
        Me.txtJmlDetergent.Tag = Nothing
        Me.txtJmlDetergent.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtJmlDetergent.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtJmlOxybleach
        '
        Me.txtJmlOxybleach.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtJmlOxybleach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlOxybleach.Location = New System.Drawing.Point(239, 288)
        Me.txtJmlOxybleach.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlOxybleach.Name = "txtJmlOxybleach"
        Me.txtJmlOxybleach.Size = New System.Drawing.Size(119, 20)
        Me.txtJmlOxybleach.TabIndex = 12
        Me.txtJmlOxybleach.Tag = Nothing
        Me.txtJmlOxybleach.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtJmlOxybleach.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'SaveEditTemp
        '
        Me.SaveEditTemp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SaveEditTemp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaveEditTemp.Location = New System.Drawing.Point(0, 0)
        Me.SaveEditTemp.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveEditTemp.Name = "SaveEditTemp"
        Me.SaveEditTemp.Size = New System.Drawing.Size(1000, 512)
        Me.SaveEditTemp.TabIndex = 0
        '
        'txtBeratLinen
        '
        Me.txtBeratLinen.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtBeratLinen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBeratLinen.Location = New System.Drawing.Point(239, 138)
        Me.txtBeratLinen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBeratLinen.Name = "txtBeratLinen"
        Me.txtBeratLinen.Size = New System.Drawing.Size(119, 20)
        Me.txtBeratLinen.TabIndex = 2
        Me.txtBeratLinen.Tag = Nothing
        Me.txtBeratLinen.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtBeratLinen.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(61, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Berat Linen (kg)"
        '
        'cmb_jns_ident_kotoran
        '
        Me.cmb_jns_ident_kotoran.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmb_jns_ident_kotoran.FormattingEnabled = True
        Me.cmb_jns_ident_kotoran.Items.AddRange(New Object() {"Non Infeksius", "Infeksius", "Reject"})
        Me.cmb_jns_ident_kotoran.Location = New System.Drawing.Point(239, 88)
        Me.cmb_jns_ident_kotoran.Name = "cmb_jns_ident_kotoran"
        Me.cmb_jns_ident_kotoran.Size = New System.Drawing.Size(205, 24)
        Me.cmb_jns_ident_kotoran.TabIndex = 16
        '
        'txtJmlPenetral
        '
        Me.txtJmlPenetral.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtJmlPenetral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlPenetral.Location = New System.Drawing.Point(239, 388)
        Me.txtJmlPenetral.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlPenetral.Name = "txtJmlPenetral"
        Me.txtJmlPenetral.Size = New System.Drawing.Size(119, 20)
        Me.txtJmlPenetral.TabIndex = 20
        Me.txtJmlPenetral.Tag = Nothing
        Me.txtJmlPenetral.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtJmlPenetral.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(61, 388)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Jumlah Penetral (ml)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label7.Location = New System.Drawing.Point(60, 338)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Jumlah Softener (ml)"
        '
        'txtJmlSoftener
        '
        Me.txtJmlSoftener.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtJmlSoftener.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJmlSoftener.Location = New System.Drawing.Point(239, 338)
        Me.txtJmlSoftener.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJmlSoftener.Name = "txtJmlSoftener"
        Me.txtJmlSoftener.Size = New System.Drawing.Size(119, 20)
        Me.txtJmlSoftener.TabIndex = 17
        Me.txtJmlSoftener.Tag = Nothing
        Me.txtJmlSoftener.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtJmlSoftener.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtIdDosis
        '
        Me.txtIdDosis.Location = New System.Drawing.Point(64, 59)
        Me.txtIdDosis.Name = "txtIdDosis"
        Me.txtIdDosis.Size = New System.Drawing.Size(100, 22)
        Me.txtIdDosis.TabIndex = 22
        Me.txtIdDosis.Visible = False
        '
        'UcInsertPembersih2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtIdDosis)
        Me.Controls.Add(Me.txtJmlPenetral)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtJmlSoftener)
        Me.Controls.Add(Me.cmb_jns_ident_kotoran)
        Me.Controls.Add(Me.txtJmlOxybleach)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJmlDetergent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJmlAlkaline)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBeratLinen)
        Me.Controls.Add(Me.SaveEditTemp)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcInsertPembersih2"
        Me.Size = New System.Drawing.Size(1000, 512)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlAlkaline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlDetergent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlOxybleach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBeratLinen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlPenetral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJmlSoftener, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtJmlDetergent As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJmlAlkaline As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtJmlOxybleach As C1.Win.C1Input.C1TextBox
    Friend WithEvents cmb_jns_ident_kotoran As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBeratLinen As C1.Win.C1Input.C1TextBox
    Friend WithEvents SaveEditTemp As UILibs.SaveEditTemp
    Friend WithEvents txtJmlPenetral As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJmlSoftener As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtIdDosis As System.Windows.Forms.TextBox

End Class
