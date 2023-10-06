Public Class foto
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Width = 351
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Width = 671
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = Image.FromFile(ListBox1.SelectedItem)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim buka As New OpenFileDialog
        buka.Filter = "All Files |*.*|jpg|*.jpg|png|*.png"
        If buka.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(buka.FileName)
            ListBox1.Items.Add(buka.FileName)
        End If
    End Sub
    Private Sub foto_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class