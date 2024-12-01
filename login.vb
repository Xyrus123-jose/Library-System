Public Class login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "xyrus" And TextBox2.Text = "123" Then
            MsgBox("Welcome back" & " " & TextBox1.Text)
            Hide()
            HOMEPAGE.Show()
        End If
    End Sub
End Class