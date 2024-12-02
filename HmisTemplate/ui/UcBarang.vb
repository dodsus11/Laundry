Public Class UcBarang

    Private Sub UcBarang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Panel1.Location.X & "  " & _
                        Panel1.Width

        'MsgBox(Button1.Location.X & " " & Button1.Location.Y)

        Button1.Location = New Point(Panel1.Width - Button1.Width - 10, Button1.Location.Y)
        Button2.Location = New Point(Panel1.Width - (Button2.Width + Button1.Width) - 10, Button2.Location.Y)
    End Sub

    Private Sub UcBarang_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Button1.Location = New Point(Panel1.Width - Button1.Width - 10, Button1.Location.Y)
        Button2.Location = New Point(Panel1.Width - (Button2.Width + Button1.Width) - 10, Button2.Location.Y)
    End Sub
End Class
