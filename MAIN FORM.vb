Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Public Class HOMEPAGE
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb"
    Dim Myconnection As OleDbConnection
    Dim dbda As OleDbDataAdapter
    Dim dbds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource





    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        book.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        statistics.Show()

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        issue.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        return_book.Show()
    End Sub



    Private Sub HOMEPAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_dbDataSet2.book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.Student_dbDataSet2.book)
        'TODO: This line of code loads data into the 'Student_dbDataSet.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Student_dbDataSet.student)
        Label5.Text = DataGridView1.RowCount
        Label6.Text = DataGridView2.RowCount
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        student.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [book]", Myconnection)
        dbda.Fill(dbds, "book")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView2.DataSource = view

        DataGridView2.Columns(0).HeaderText = "BOOK ID"
        DataGridView2.Columns(1).HeaderText = "BOOK NAME"
        DataGridView2.Columns(2).HeaderText = "PUBLISHER"
        DataGridView2.Columns(3).HeaderText = "PRICE"
        DataGridView2.Columns(4).HeaderText = "PUBLISHED YEAR"

        DataGridView2.Refresh()
        Label5.Text = DataGridView2.RowCount

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [student]", Myconnection)
        dbda.Fill(dbds, "student")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view

        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "NAME"
        DataGridView1.Columns(2).HeaderText = "COURSE"
        DataGridView1.Columns(3).HeaderText = "SECTION"
        DataGridView1.Columns(4).HeaderText = "CAMPUS"

        DataGridView1.Refresh()
        Label6.Text = DataGridView1.RowCount
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [query1]", Myconnection)
        dbda.Fill(dbds, "query1")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView3.DataSource = view
        DataGridView3.Refresh()
        Label7.Text = DataGridView3.RowCount
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Myconnection = New OleDbConnection
        Myconnection.ConnectionString = connString
        dbds = New DataSet
        tables = dbds.Tables
        dbda = New OleDbDataAdapter("Select * from [query2]", Myconnection)
        dbda.Fill(dbds, "query2")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView4.DataSource = view
        DataGridView4.Refresh()
        Label8.Text = DataGridView4.RowCount
    End Sub
    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click
        loadchart()

    End Sub
    Public Sub loadchart()
        With Chart1
            .Series.Clear()
            .Series.Add("series1")


        End With
        Dim da As New OleDbDataAdapter("select st_COURSE, count (ID)AS TOTAL FROM Student group by st_COURSE", strcon)
        Dim ds As New DataSet

        da.Fill(ds, "st_COURSE")
        Chart1.DataSource = ds.Tables("st_COURSE")
        Dim series1 As Series = Chart1.Series("series1")
        series1.ChartType = SeriesChartType.Pie
        series1.Name = "st_COURSE"


        With Chart1

            .Series(0)("PieLabelStyle") = "outside"
            .Series(0).BorderWidth = 2
            .Series(0).BorderColor = System.Drawing.Color.Black
            .Series(series1.Name).XValueMember = "st_COURSE"
            .Series(series1.Name).YValueMembers = "total"
            .Series(0).LabelFormat = "{#,##0.00}%"
            .Series(0).IsValueShownAsLabel = True
            .Series(0).LegendText = "#VALX (#PERCENT)"
            .Series(0).Font = New Drawing.Font("Arial", 12)
            .Legends(0).Font = New Drawing.Font("Arial", 10)

        End With


    End Sub
End Class
