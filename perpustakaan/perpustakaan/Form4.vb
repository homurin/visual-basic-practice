Public Class Form4
    Sub view()
        setdat()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = ds.Tables(0).ToString
        clear()
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil("select * from pengarang")
        view()
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iud("insert into pengarang values (" & TextBox1.Text & ",'" & TextBox2.Text & "') ")
        view()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iud("update pengarang set nama_pengarang='" & TextBox2.Text & "' where kode_pengarang=" & TextBox1.Text & "")
        view()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        iud("delete from pengarang where kode_pengarang=" & TextBox1.Text & "")
        view()
    End Sub
End Class