Public Class dok
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim buka As New OpenFileDialog
        buka.Filter = "All Documents|*.*|text|*.text|txt|*.txt"
        buka.ShowDialog()
        Dim isi As String = My.Computer.FileSystem.ReadAllText(buka.FileName)
        RichTextBox1.Text = isi
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim simpan As New SaveFileDialog
        simpan.Filter = "Dokumen teks(*text)|*.text|Txt|*.txt"
        simpan.ShowDialog()
        My.Computer.FileSystem.WriteAllText(simpan.FileName, RichTextBox1.Text, False)
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub RegularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Regular)
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Italic)
    End Sub
End Class