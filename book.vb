Imports System.Data
Imports System.Data.OleDb
Public Class book
    Dim con As OleDbConnection
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb;"
    Public Sub RunQuery(ByVal query As String)

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@name", bkNAME.Text)
        cmd.Parameters.AddWithValue("@pub", bkPUBLISHER.Text)
        cmd.Parameters.AddWithValue("@prce", bkPRICE.Text)
        cmd.Parameters.AddWithValue("@puyear", bkPUBYEAR.Text)
        cmd.Parameters.AddWithValue("@id", bkID.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "insert into book (book_Name,publisher,price,pubyear) VALUES(@name,@pub,@prce,@puyear)"
        RunQuery(insertQuery)
        If MessageBox.Show("saved successfully") Then
            Me.Hide()
        Else
            MessageBox.Show("Insert Failed")
        End If


    End Sub




    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub
    Sub clear()
        bkID.Clear()
        bkNAME.Clear()
        bkPRICE.Clear()
        bkPUBLISHER.Clear()
        bkPUBYEAR.Clear()
        bkID.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()

    End Sub

    Private Sub lb1_Click(sender As Object, e As EventArgs) Handles lb1.Click
        Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
        oleDbConnection.Open()

        Dim sqlCommand As OleDbCommand = New OleDbCommand("SELECT MAX(ID) FROM book", oleDbConnection)
        Dim lastId As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar())


        bkID.Text = lastId.ToString() + 1
        oleDbConnection.Close()
    End Sub
End Class
