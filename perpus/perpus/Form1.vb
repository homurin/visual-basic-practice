Imports System.Data.Odbc
Public Class Form1
    Dim cn As OdbcConnection
    Dim db As OdbcDataAdapter
    Dim ds As New DataSet

    Sub koneksi()
        cn = New OdbcConnection("DSN=perpustakaan1")
        cn.Open()
    End Sub
    Sub tampil()
        koneksi()
        db = New OdbcDataAdapter("select * from buku", cn)
        db.Fill(ds)
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = ds.Tables(0).ToString
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub
End Class
