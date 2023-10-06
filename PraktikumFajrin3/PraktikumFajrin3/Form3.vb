Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim nilai_akhir As Double
        If Trim(TextBox2.Text) = "" And Trim(TextBox3.Text) = "" Then
            MsgBox("Inputkan dulu NIM dan Nama Mahasiswa OK!")
        ElseIf Trim(TextBox3.Text) = "" Or Trim(TextBox4.Text) = "" Then
            TextBox5.Text = "T"
        Else
            nilai_akhir = (Val(TextBox3.Text) + Val(TextBox4.Text)) / 2
            Select Case nilai_akhir
                Case 0 To 30
                    TextBox5.Text = "E"
                Case 31 To 40
                    TextBox5.Text = "D"
                Case 41 To 60
                    TextBox5.Text = "C"
                Case 61 To 80
                    TextBox5.Text = "B"
                Case 81 To 100
                    TextBox5.Text = "A"
                Case Else
                    TextBox5.Text = "T"
            End Select
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class