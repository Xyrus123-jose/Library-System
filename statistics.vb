Imports System.Data.OleDb
Public Class statistics
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb"
    Dim Myconnection As OleDbConnection
    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [query1]", Myconnection)
        dbda.Fill(dbds, "query1")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view

        DataGridView1.Columns(0).HeaderText = "BOOK ID"
        DataGridView1.Columns(1).HeaderText = "BOOK NAME"
        DataGridView1.Columns(2).HeaderText = "STUDENT ID"
        DataGridView1.Columns(3).HeaderText = "STUDENT NAME"
        DataGridView1.Columns(4).HeaderText = "ISSUE DATE"
        DataGridView1.Columns(5).HeaderText = "RETURN DATE"
        DataGridView1.Refresh()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [query2]", Myconnection)
        dbda.Fill(dbds, "query2")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView2.DataSource = view
        DataGridView2.Columns(0).HeaderText = "BOOK ID"
        DataGridView2.Columns(2).HeaderText = "BOOK NAME"
        DataGridView2.Columns(1).HeaderText = "STUDENT ID"
        DataGridView2.Columns(3).HeaderText = "STUDENT NAME"
        DataGridView2.Columns(4).HeaderText = "ISSUE DATE"
        DataGridView2.Columns(5).HeaderText = "RETURN DATE"

        DataGridView1.Refresh()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()

    End Sub


End Class