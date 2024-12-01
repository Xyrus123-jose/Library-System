
Imports System.Data.OleDb
Module ChartConnection
    Public Function strconnection() As OleDbConnection
        Return New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xyrus\Desktop\database\student_db.accdb")


    End Function
    Public strcon As OleDbConnection = strconnection()

End Module
