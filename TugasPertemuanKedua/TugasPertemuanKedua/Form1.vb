Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c = Val(TextBox1.Text) + Val(TextBox2.Text)
        Label2.Text = c

        If c >= 20 Then
            MsgBox("Menang Level 2!!")
        ElseIf c >= 10 Then
            MsgBox("Menang Level 1!!")
        Else
            Label1.Text = "Kalah!!"
            Label1.Font = New Font("Arial", 20)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case Is = 1
                MsgBox("Apel")
            Case Is = 2
                MsgBox("Jeruk")
            Case Is = 3
                MsgBox("Pisang")
            Case Else
                MsgBox("Semangka")
        End Select

        If ComboBox1.Text = "1" Then
            MsgBox("One")
        ElseIf ComboBox1.Text = "2" Then
            MsgBox("Two")
        ElseIf ComboBox1.Text = "3" Then
            MsgBox("Three")
        Else
            MsgBox("Tidak diantara 1,2,3")
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox2.Items.Add("Apel")
        ComboBox2.Items.Add("Bengkuang")
        ComboBox2.Items.Add("Pisang")
        ComboBox2.Items.Add("Semangka")

        ComboBox3.Items.Add("Alpro 1")
        ComboBox3.Items.Add("Basis Data")
        ComboBox3.Items.Add("Pbo")
        ComboBox3.Items.Add("Visual")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        MsgBox("Buah yang dipilih " + ComboBox2.Text)

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Select Case ComboBox3.Text
            Case Is = "Alpro 1"
                RichTextBox1.Text = "Alpro adalah mata kuliah yang mempelajari dasar pemerograman dan logika dasar"
            Case Is = "Basis Data"
                RichTextBox1.Text = "Basis data 1 adalah mata kuliah yang mempelajari desain struktur database relasional"
            Case Is = "Pbo"
                RichTextBox1.Text = "Pbo adalah mata kuliah yang mempelajari dasar pemerograman beroerientasi objek"
            Case Is = "Visual"
                RichTextBox1.Text = "Pemerograman Visual adalah mata kuliah yang mempelajari desain Interface program dan mengimplentasikan algoritma pemerograman"
        End Select
    End Sub
End Class
