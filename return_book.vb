Imports System.Data
Imports System.Data.OleDb
Public Class return_book
    Dim con As OleDbConnection
    Public Sub RunQuery(ByVal query As String)

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@std", txtID.Text)
        cmd.Parameters.AddWithValue("@bk", bkID.Text)
        cmd.Parameters.AddWithValue("@issue", DTPI.Text)
        cmd.Parameters.AddWithValue("@due", DTPR.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb")

        Dim searchQuery As String = "select * from query1 where book.ID=@book.id"
        Dim cmd As New OleDbCommand(searchQuery, con)
        cmd.Parameters.AddWithValue("@book.id", bkID.Text)
        Dim da As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count > 0 Then
            txtID.Text = table.Rows(0)(2).ToString
            bkID.Text = table.Rows(0)(0).ToString
            DTPI.Text = table.Rows(0)(4).ToString
            DTPR.Text = table.Rows(0)(5).ToString
        End If
    End Sub
    Sub clear()
        txtID.Clear()


        txtID.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "insert into Return  (stid,bkid,issuedate,duedate) VALUES(@std,@bk,@issue,@due)"
        RunQuery(insertQuery)
        If MessageBox.Show("saved successfully") Then
            Dim deleteQuery As String = " DELETE FROM issue WHERE student_id = @std And book_id = @bk And issue_date = @issue And return_date = @return"
            RunQuery(deleteQuery)
        Else
            MessageBox.Show("Insert Failed")
        End If
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub
End Class