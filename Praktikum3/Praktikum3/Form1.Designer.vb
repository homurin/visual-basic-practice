<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Dtanggal = New System.Windows.Forms.DateTimePicker()
        Me.Lbl24jam = New System.Windows.Forms.Label()
        Me.Lbl12Jam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Dtanggal
        '
        Me.Dtanggal.Location = New System.Drawing.Point(44, 163)
        Me.Dtanggal.Name = "Dtanggal"
        Me.Dtanggal.Size = New System.Drawing.Size(200, 20)
        Me.Dtanggal.TabIndex = 5
        '
        'Lbl24jam
        '
        Me.Lbl24jam.AutoSize = True
        Me.Lbl24jam.Location = New System.Drawing.Point(41, 122)
        Me.Lbl24jam.Name = "Lbl24jam"
        Me.Lbl24jam.Size = New System.Drawing.Size(39, 13)
        Me.Lbl24jam.TabIndex = 4
        Me.Lbl24jam.Text = "Label2"
        '
        'Lbl12Jam
        '
        Me.Lbl12Jam.AutoSize = True
        Me.Lbl12Jam.Location = New System.Drawing.Point(41, 80)
        Me.Lbl12Jam.Name = "Lbl12Jam"
        Me.Lbl12Jam.Size = New System.Drawing.Size(39, 13)
        Me.Lbl12Jam.TabIndex = 3
        Me.Lbl12Jam.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Dtanggal)
        Me.Controls.Add(Me.Lbl24jam)
        Me.Controls.Add(Me.Lbl12Jam)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dtanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl24jam As System.Windows.Forms.Label
    Friend WithEvents Lbl12Jam As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
