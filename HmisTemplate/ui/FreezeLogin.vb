Public Class FreezeLogin

    Private Sub FreezeLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim frm As New FrmLogin()

        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim i As Integer = 0

            'Dim frmMenu As New HMISMenu()
            'frmMenu.Show()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Me.Hide()
            Me.Dispose()

            Return
        End If

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub


End Class