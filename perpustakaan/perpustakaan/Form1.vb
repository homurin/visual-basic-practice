Imports System.Data.Odbc
Public Class Form1
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Show()

    End Sub

    Sub view()
        setdat()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = ds.Tables(0).ToString
        clear()
    End Sub
    Sub cb1()
        iud("select * from pengarang order by kode_pengarang asc")
        r = q.ExecuteReader()
        While r.Read
            ComboBox1.Items.Add(r("nama_pengarang"))
        End While
    End Sub

    Sub cb2()
        iud("select * from penerbit order by kode_penerbit asc")
        r = q.ExecuteReader()
        While r.Read
            ComboBox2.Items.Add(r("nama_penerbit"))
        End While
    End Sub

    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil("select * from buku")
        view()
        cb1()
        cb2()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iud("insert into buku values (" & TextBox1.Text & ",'" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "') ")
        view()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iud("update buku set judul='" & TextBox2.Text & "',pengarang='" & ComboBox1.Text & "',penerbit='" & ComboBox2.Text & "',stok=" & TextBox3.Text & " where kode_buku=" & TextBox1.Text & "")
        view()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        iud("delete from buku where kode_buku=" & TextBox1.Text & "")
        view()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        tampil("select * from buku where judul like '%" & TextBox4.Text & "%'")
        view()
    End Sub
End Class
