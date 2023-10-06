Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = TextBox1.Text
        Dim b As Integer = TextBox2.Text
        Label1.Text = a + b
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
