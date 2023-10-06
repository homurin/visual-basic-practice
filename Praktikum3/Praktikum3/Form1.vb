Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dtanggal.Format = DateTimePickerFormat.Custom
        Dtanggal.CustomFormat = "dddd,dd/MM/yyyy"
        Dtanggal.Value = Format(Now)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lbl12Jam.Text = Format(Now, "h:mm:ss tt")
        Lbl24jam.Text = Format(Now, "hh:mm:ss")
    End Sub
End Class
