Public Class vid
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim play As New OpenFileDialog
        play.Filter = "All files|*.*|mp4|*.mp4|3gp|*.3gp|mepg|*.mpeg|wmv|*.wmv"
        If play.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = play.FileName
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            ListBox1.Items.Add(play.FileName)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        AxWindowsMediaPlayer1.URL = ListBox1.SelectedItem
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Height = 527
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Height = 712
    End Sub

    Private Sub vid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub vid_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class