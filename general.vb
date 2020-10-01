Imports System.Data.OleDb
Module general
    Public con As New OleDbConnection
    Public cmd As New OleDbCommand
    Public ds As New DataSet
    Public adapter As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public sqlconn, sqldb, sqluser, sqlpass, connectionString As String
    Public gen, qry, uname, attr, server, database, user, passward, utype As String
    Public i As Integer
    Public Sub connectiondb() 'connects to server
        connectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Smrt Sharu\exm\RedCross\redcross.accdb")
        con = New OleDbConnection(connectionString)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox("Cannot Open Connection !", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub connection_close() 'closing the connection
        cmd.Dispose()
        con.Close()
    End Sub
End Module

