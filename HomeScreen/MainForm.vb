Public Class MainForm
    Dim lockStatus As Boolean = True
    Dim timer As Timer
    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_MainScreen()
        Alert1.Visible = True
    End Sub

    Public Sub Show_Navigation()
        MainScreen1.Visible = False
        Navigation1.Visible = True
    End Sub

    Public Sub Show_Entertainment()
        MainScreen1.Visible = False
        Entertainment1.Visible = True
    End Sub

    Public Sub Show_Performance()
        MainScreen1.Visible = False
        PerformanceTrack1.Visible = True
    End Sub

    Public Sub Show_MainScreen()
        MainScreen1.Visible = True
    End Sub

    Public Sub Show_SecurityScreen()
        MainScreen1.Visible = False
        SecurityScreen1.Visible = True
    End Sub

    Public Sub Show_ClimateScreen()
        MainScreen1.Visible = False
        ClimateScreen1.Visible = True
    End Sub

    Public Sub Show_LocateCarScreen()
        MainScreen1.Visible = False
        LocateCarScreen1.Visible = True
    End Sub

    Public Sub Show_EmergencyScreen()
        MainScreen1.Visible = False
        Emergency1.Visible = True
    End Sub

    Public Sub Show_Notifications()
        MainScreen1.Visible = False
    End Sub

    Public Sub Show_Alert()
        Alert1.Visible = True
    End Sub

    Public Sub Show_Seats()
        SeatConf1.Visible = True
    End Sub

    Public Sub Show_SeatScreen(person As String)
        If (person = "Driver") Then
            SeatScreen1.Visible = True
        Else
            SeatScreen2.Visible = True
        End If

    End Sub

    Public Sub Show_SteeringWheel()
        SteeringWheel1.Visible = True
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click

        Navigation1.Visible = False
        SecurityScreen1.Visible = False
        ClimateScreen1.Visible = False
        Emergency1.Visible = False
        Alert1.resize1()
        LocateCarScreen1.Visible = False
        SeatConf1.Visible = False
        Entertainment1.Visible = False
        PerformanceTrack1.Visible = False

        If (SeatScreen1.Visible = True Or SeatScreen2.Visible = True Or SteeringWheel1.Visible = True) Then
            SeatScreen1.Visible = False
            SeatScreen2.Visible = False
            SteeringWheel1.Visible = False
            SeatConf1.Visible = True
        Else
            MainScreen1.Visible = True
        End If



    End Sub

End Class
