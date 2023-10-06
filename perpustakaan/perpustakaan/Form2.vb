Imports System.Data.Odbc
Public Class Form2
    Sub view()
        setdat()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = ds.Tables(0).ToString
        clear()
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil("select * from anggota")
        view()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iud("insert into anggota values (" & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "') ")
        view()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iud("update anggota set nama='" & TextBox2.Text & "',jenis_kelamin='" & TextBox3.Text & "',alamat='" & TextBox4.Text & "' where kode_anggota=" & TextBox1.Text & "")
        view()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        iud("delete from anggota where kode_anggota=" & TextBox1.Text & "")
        view()
    End Sub
End Class