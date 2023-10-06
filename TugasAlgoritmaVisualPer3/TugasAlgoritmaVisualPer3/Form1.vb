Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        Do
            i = i + 1
            ComboBox1.Items.Add(i)
        Loop Until i >= 10
    End Sub
End Class
