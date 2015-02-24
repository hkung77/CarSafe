Public Class Alert
    Dim t As Timer = New Timer()
    Dim colorTracker As Boolean = True
    Private Sub notification_Click(sender As Object, e As EventArgs) Handles pnlAlertSmall.Click, alert_label.Click
        alert_label.Visible = False
        notification.Visible = True
        warning_pic.Visible = True
        MainForm.Alert1.Height = 613
        Me.BackColor = Color.Black
        

        t.Stop()
    End Sub

    Private Sub notification_Click_1(sender As Object, e As EventArgs) Handles notification.Click, warning_pic.Click
        MainForm.Show_SecurityScreen()
        MainForm.LocateCarScreen1.Visible = False
        ''Me.Visible = False
        Me.resize1()
        MainForm.Alert1.Enabled = False
    End Sub

    Public Sub flash()
        t.Interval = 100
        AddHandler t.Tick, AddressOf HandleTimerTick
        t.Start()
    End Sub

    Public Sub show_alert_label()
        alert_label.Visible = True
    End Sub
    Public Sub hide_alert_label()
        alert_label.Visible = False
    End Sub


    Private Sub HandleTimerTick()
        colorTracker = Not colorTracker
        If colorTracker Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Black
        End If

    End Sub

    Public Sub resize1()
        Me.Size = New Drawing.Size(New Drawing.Point(509, 37))
    End Sub


    Private Sub Alert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resize1()
    End Sub


End Class
