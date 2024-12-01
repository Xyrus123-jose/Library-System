Imports System.Data
Imports System.Data.OleDb
Public Class issue
    Dim con As OleDbConnection
    Public Sub RunQuery(ByVal query As String)

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@std", txtID.Text)
        cmd.Parameters.AddWithValue("@bk", bkID.Text)
        cmd.Parameters.AddWithValue("@issue", DTPI.Value)
        cmd.Parameters.AddWithValue("@return", DTPR.Value)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub clear()
        bkID.Clear()
        bkID.Focus()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "insert into issue  (student_id,book_id,issue_date,return_date) VALUES(@std,@bk,@issue,@return)"
        RunQuery(insertQuery)
        If MessageBox.Show("saved successfully") Then
            Me.Hide()
        Else
            MessageBox.Show("Insert Failed")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub
End Class