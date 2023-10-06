Imports System.Data.Odbc
Module Module1
    Public con As OdbcConnection
    Public tb As OdbcDataAdapter
    Public ds As DataSet
    Public q As OdbcCommand
    Public r As OdbcDataReader

    Public Sub koneksi()
        con = New OdbcConnection("DSN=perpustakaan1")
        con.Open()
    End Sub

    Public Sub setdat()
        ds = New DataSet
        tb.Fill(ds)
    End Sub

    Public Sub tampil(ByRef a As String)
        koneksi()
        tb = New OdbcDataAdapter(a, con)
    End Sub

    Public Sub iud(ByRef i As String)
        q = New OdbcCommand
        q.Connection = con
        q.CommandText = (i)
        q.ExecuteNonQuery()
    End Sub

End Module
