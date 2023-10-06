Public Class frm1Eelsef

    Private Sub btnKonversi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKonversi.Click
        If (txtNilai.Text >= 0) And (txtNilai.Text <= 50) Then
            txtGrade.Text = "D"
        ElseIf (txtNilai.Text > 50) And (txtNilai.Text <= 75) Then
            txtGrade.Text = "C"
        ElseIf (txtNilai.Text > 75) And (txtNilai.Text <= 80) Then
            txtGrade.Text = "B"
        ElseIf (txtNilai.Text > 80) And (txtNilai.Text <= 100) Then
            txtGrade.Text = "A"
        Else
            txtGrade.Text = "T"
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class