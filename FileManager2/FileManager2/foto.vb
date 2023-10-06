Public Class foto
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim openfile As New OpenFileDialog
        openfile.Filter = "ALL files|*.*|jpg|*.jpg|png|*.png"

        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openfile.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            ListBox1.Items.Add(openfile.FileName)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = Image.FromFile(ListBox1.SelectedItem)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Width = 671
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Width = 397
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub foto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub foto_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class