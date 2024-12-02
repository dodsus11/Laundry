Public Class FrmUsers

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim tb1 As New TabPage()
        tb1.Text = "Setup Customer  "
        tb1.ImageIndex = 0

        'add to tabcontrol
        TbControl.TabPages.Add(tb1)

    End Sub

    Private Sub FrmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class