Imports System.IO
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cmb_Drive.Items.AddRange(IO.DriveInfo.GetDrives)
    End Sub

    Private Sub Cmb_Drive_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Drive.SelectedIndexChanged
        LstInfo.Items.Clear()
        LstInfo.Items.Add("Nama Drive : " & Dir("" & _Cmb_Drive.Text & "", FileAttribute.Volume) & "")
        LstInfo.Items.Add("System :" & Dir("" & Cmb_Drive.Text & "", FileAttribute.System) & "")
        Dim dvr As New DriveInfo(Cmb_Drive.Text)
        Dim kapasitas = CStr(dvr.TotalSize / 1000000) & " MB"
        Dim sisa = CStr(dvr.TotalFreeSpace / 1000000) & " MB"
        Dim terpakai = CStr(Val(kapasitas) - Val(sisa)) & " MB"
        LstInfo.Items.Add("Kapasitas : " & kapasitas)
        LstInfo.Items.Add("Terpakai : " & terpakai)
        LstInfo.Items.Add("Sisa     : " & sisa)
    End Sub
End Class
