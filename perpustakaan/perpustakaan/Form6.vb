Public Class Form6
    Sub clear()
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
    End Sub
    Sub view()
        setdat()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = ds.Tables(0).ToString
        clear()
    End Sub
    Sub nomor()
        iud("select * from peminjaman order by no_pinjam desc")
        r = q.ExecuteReader
        If r.Read Then
            TextBox1.Text = (r("no_pinjam")) + 1
        Else
            TextBox1.Text = 1
        End If
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"

        DateTimePicker2.Text = DateAdd("d", 7, DateTimePicker1.Value)

        tampil("select * from peminjaman")
        view()
        nomor()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        iud("select * from buku where kode_buku like '" & TextBox2.Text & "'")
        r = q.ExecuteReader
        While r.Read
            TextBox4.Text = (r("judul")) & "/" & (r("pengarang")) & ("/") & (r("penerbit"))
        End While
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        iud("select * from anggota where kode_anggota like '" & TextBox3.Text & "'")
        r = q.ExecuteReader
        While r.Read
            TextBox5.Text = (r("nama"))
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iud("insert into peminjaman values(" & TextBox1.Text & ",'" & DateTimePicker1.Text & "','" & DateTimePicker2.Value & "','" & TextBox2.Text & "','" & TextBox3.Text & "','pinjam')")
        iud("update buku set buku.stok=(buku.[stok])-1 where kode_buku=" & TextBox2.Text & "")
        view()
        clear()
        nomor()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        iud("update peminjaman set kode_buku=" & TextBox2.Text & ",kode_anggota=" & TextBox3.Text & " where no_pinjam=" & TextBox1.Text & "")
        view()
        clear()
        nomor()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        iud("delete from peminjaman where no_pinjam =" & TextBox1.Text & "")
        iud("update buku set buku.stok=(buku.[stok])+1 where kode_buku=" & TextBox2.Text & "")
        view()
        clear()
        nomor()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        DateTimePicker1.Text = DataGridView1.Item(1, i).Value
        DateTimePicker2.Text = DataGridView1.Item(2, i).Value
        TextBox2.Text = DataGridView1.Item(3, i).Value
        TextBox3.Text = DataGridView1.Item(4, i).Value
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        tampil("select * from peminjaman where no_pinjam like '%" & TextBox6.Text & "%'")
        view()
    End Sub
    Private Sub Form6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Show()
    End Sub
End Class