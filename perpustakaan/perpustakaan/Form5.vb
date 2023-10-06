Public Class Form5
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
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil("select * from penerbit")
        view()
    End Sub

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iud("insert into penerbit values (" & TextBox1.Text & ",'" & TextBox2.Text & "')")
        view()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iud("update penerbit set nama_penerbit='" & TextBox2.Text & "' where kode_penerbit=" & TextBox1.Text & "")
        view()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        iud("delete from penerbit where kode_penerbit=" & TextBox1.Text & "")
        view()
    End Sub
End Class