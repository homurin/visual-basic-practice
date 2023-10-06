Public Class Form1

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Lb1_Font.Font = New Font("Microsoft sans Serif", Lb1_Font.Font.Size, _Lb1_Font.Font.Style Xor FontStyle.Strikeout)
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Lb1_Font.Font = New Font("Microsoft sans Serif", Lb1_Font.Font.Size, Lb1_Font.Font.Style Xor FontStyle.Underline)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Lb1_Font.Font = New Font("Microsoft sans Serif", Lb1_Font.Font.Size, Lb1_Font.Font.Style Xor FontStyle.Regular)
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Lb1_Font.Font = New Font("Microsoft sans Serif", Lb1_Font.Font.Size, Lb1_Font.Font.Style Xor FontStyle.Italic)
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Lb1_Font.Font = New Font("Microsoft sans Serif", Lb1_Font.Font.Size, Lb1_Font.Font.Style Xor FontStyle.Bold)
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Lb1_Font.Font = New Font("Microsoft sans Serif", Lb1_Font.Font.Size, Lb1_Font.Font.Style Xor FontStyle.Bold Xor FontStyle.Italic)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub
End Class
