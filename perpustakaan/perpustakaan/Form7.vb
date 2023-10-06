Public Class Form7
    Sub view()
        setdat()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = ds.Tables(0).ToString
    End Sub
    Sub clear()
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil("select * from peminjaman")
        view()
    End Sub
    Sub sisa()
        Dim DateTimePicker1 As Date
        Dim selisih As TimeSpan
        DateTimePicker1 = Me.DateTimePicker1.Value
        selisih = Now.Subtract(DateTimePicker1)
        Me.TextBox6.Text = (selisih.Days) - 7
        If (TextBox6.Text >= 1) Then
            iud("select * from denda")
            r = q.ExecuteReader()
            While r.Read
                TextBox7.Text = (r("denda")) * TextBox6.Text
            End While
        Else
            TextBox7.Text = 0
        End If
    End Sub

    Private Sub Form7_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        iud("select * from peminjaman where no_pinjam like '%" & TextBox1.Text & "%'")
        r = q.ExecuteReader()
        While r.Read
            DateTimePicker1.Text = (r("tanggal_kembali"))
            TextBox2.Text = (r("kode_buku"))
            TextBox3.Text = (r("kode_anggota"))
        End While
        sisa()
        tampil("select * from peminjaman where no_pinjam like '%" & TextBox1.Text & "%'")
        view()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        iud("select * from anggota where kode_anggota like '%" & TextBox3.Text & "%'")
        r = q.ExecuteReader()
        While r.Read
            TextBox4.Text = (r("nama"))
            TextBox5.Text = (r("alamat"))
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        iud("insert into pengembalian(no_pinjam,tanggal_harus_kembali,tanggal_kembali,terlambat,denda)" & "values (" & TextBox1.Text & ",'" & DateTimePicker1.Text & "','" & Now() & "'," & "'" & TextBox3.Text & "','" & TextBox6.Text & "')")
        iud("UPDATE peminjaman Set status ='kembali' where no_pinjam=" & TextBox1.Text & "")
        iud("UPDATE buku SET buku.stok = (buku.[stok])+1 where kode_buku = " & TextBox2.Text & "")
        view()
        clear()
    End Sub

End Class