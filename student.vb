Imports System.Data
Imports System.Data.OleDb
Public Class student
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb;"
    Dim con As OleDbConnection
    Public Sub RunQuery(ByVal query As String)

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@name", txtNAME.Text)
        cmd.Parameters.AddWithValue("@course", cb2.Text)
        cmd.Parameters.AddWithValue("@section", txtSECTION.Text)
        cmd.Parameters.AddWithValue("@campus", cb1.Text)
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertQuery As String = "insert into student (st_Name,st_Course,st_Section,st_Campus) VALUES(@name,@course,@section,@campus)"
        RunQuery(insertQuery)
        If MessageBox.Show("saved successfully") Then
            Me.Hide()
        Else
            MessageBox.Show("Insert Failed")
        End If


    End Sub

    Sub clear()
        txtID.Clear()
        txtSECTION.Clear()
        txtNAME.Clear()
        txtID.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
    End Sub



    Private Sub lb1_Click(sender As Object, e As EventArgs) Handles lb1.Click
        Dim oleDbConnection As OleDbConnection = New OleDbConnection(connectionString)
        oleDbConnection.Open()

        Dim sqlCommand As OleDbCommand = New OleDbCommand("SELECT MAX(ID) FROM student", oleDbConnection)
        Dim lastId As Integer = Convert.ToInt32(sqlCommand.ExecuteScalar())


        txtID.Text = lastId.ToString() + 1
        oleDbConnection.Close()
    End Sub
End Class
