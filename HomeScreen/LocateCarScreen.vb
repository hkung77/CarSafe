Public Class LocateCarScreen

    Dim recording As Boolean = False

    Dim t As Timer = New Timer()
    Private Sub LocateCarScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        t.Interval = 2000
        AddHandler t.Tick, AddressOf HandleTimerTick
        t.Start()
        MainForm.Alert1.Enabled = True
    End Sub

    Private Sub HandleTimerTick()
        MainForm.Alert1.flash()
        MainForm.Alert1.show_alert_label()
        t.Stop()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles record_box.Click
        If recording.Equals(False) Then
            record_box.BackgroundImage = My.Resources.pause
            recording = True
        Else
            record_box.BackgroundImage = My.Resources.record
            recording = False
        End If
    End Sub
End Class
