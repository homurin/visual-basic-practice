Public Class Form1

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim openfile As New OpenFileDialog
        openfile.Filter = "ALL files|*.*|jpg|*.jpg|png|*.png"

        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openfile.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            ListBox1.Items.Add(openfile.FileName)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        PictureBox1.Image = Image.FromFile(ListBox1.SelectedItem)
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim openfile As New OpenFileDialog
        openfile.Filter = "ALL files|*.*|mpg|*.mpg|wmv|*.wmv"
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = openfile.FileName
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            ListBox2.Items.Add(openfile.FileName)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = ListBox2.SelectedItem
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
End Class
