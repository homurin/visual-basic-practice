Public Class dok
    Private Sub DokumenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DokumenToolStripMenuItem.Click
        Dim openfile As New OpenFileDialog
        openfile.Filter = "text|*.text"
        openfile.ShowDialog()

        Dim teks As String = My.Computer.FileSystem.ReadAllText(openfile.FileName)
        RichTextBox1.Text = teks
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        save.Filter = "Dokumen teks(*.txt)|*.txt"
        save.ShowDialog()
        My.Computer.FileSystem.WriteAllText(save.FileName, RichTextBox1.Text, False)
    End Sub

    Private Sub BoldToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoldToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItalicToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Italic)
    End Sub

    Private Sub RegulerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegulerToolStripMenuItem.Click
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, FontStyle.Regular)
    End Sub

    Private Sub dok_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class