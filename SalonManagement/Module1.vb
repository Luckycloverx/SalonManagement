Imports System.Data.OleDb
Module Module1
    Public mycon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\employeedatabase.mdb"
    Public conn As New OleDbConnection(mycon)

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function

End Module
