<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.BackButton = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Alert1 = New HomeScreen.Alert()
        Me.MainScreen1 = New HomeScreen.MainScreen()
        Me.ClimateScreen1 = New HomeScreen.ClimateScreen()
        Me.SecurityScreen1 = New HomeScreen.SecurityScreen()
        Me.LocateCarScreen1 = New HomeScreen.LocateCarScreen()
        Me.Navigation1 = New HomeScreen.Navigation()
        Me.Emergency1 = New HomeScreen.Emergency()
        Me.Entertainment1 = New HomeScreen.Entertainment()
        Me.PerformanceTrack1 = New HomeScreen.PerformanceTrack()
        Me.SeatConf1 = New HomeScreen.SeatConf()
        Me.SteeringWheel1 = New HomeScreen.SteeringWheel()
        Me.SeatScreen2 = New HomeScreen.SeatScreen()
        Me.SeatScreen1 = New HomeScreen.SeatScreen()
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Transparent
        Me.BackButton.Location = New System.Drawing.Point(297, 687)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(80, 50)
        Me.BackButton.TabIndex = 4
        Me.BackButton.TabStop = False
        '
        'Alert1
        '
        Me.Alert1.BackColor = System.Drawing.Color.Black
        Me.Alert1.Enabled = False
        Me.Alert1.Location = New System.Drawing.Point(18, 69)
        Me.Alert1.MaximumSize = New System.Drawing.Size(382, 613)
        Me.Alert1.MinimumSize = New System.Drawing.Size(382, 27)
        Me.Alert1.Name = "Alert1"
        Me.Alert1.Size = New System.Drawing.Size(382, 37)
        Me.Alert1.TabIndex = 6
        Me.Alert1.Visible = False
        '
        'MainScreen1
        '
        Me.MainScreen1.Location = New System.Drawing.Point(18, 69)
        Me.MainScreen1.Margin = New System.Windows.Forms.Padding(2)
        Me.MainScreen1.Name = "MainScreen1"
        Me.MainScreen1.Size = New System.Drawing.Size(382, 613)
        Me.MainScreen1.TabIndex = 0
        '
        'ClimateScreen1
        '
        Me.ClimateScreen1.Location = New System.Drawing.Point(18, 103)
        Me.ClimateScreen1.Margin = New System.Windows.Forms.Padding(2)
        Me.ClimateScreen1.Name = "ClimateScreen1"
        Me.ClimateScreen1.Size = New System.Drawing.Size(382, 579)
        Me.ClimateScreen1.TabIndex = 3
        Me.ClimateScreen1.Visible = False
        '
        'SecurityScreen1
        '
        Me.SecurityScreen1.Location = New System.Drawing.Point(18, 69)
        Me.SecurityScreen1.Margin = New System.Windows.Forms.Padding(4)
        Me.SecurityScreen1.Name = "SecurityScreen1"
        Me.SecurityScreen1.Size = New System.Drawing.Size(382, 613)
        Me.SecurityScreen1.TabIndex = 2
        Me.SecurityScreen1.Visible = False
        '
        'LocateCarScreen1
        '
        Me.LocateCarScreen1.Location = New System.Drawing.Point(18, 96)
        Me.LocateCarScreen1.Margin = New System.Windows.Forms.Padding(2)
        Me.LocateCarScreen1.Name = "LocateCarScreen1"
        Me.LocateCarScreen1.Size = New System.Drawing.Size(382, 586)
        Me.LocateCarScreen1.TabIndex = 8
        Me.LocateCarScreen1.Visible = False
        '
        'Navigation1
        '
        Me.Navigation1.Location = New System.Drawing.Point(18, 69)
        Me.Navigation1.Margin = New System.Windows.Forms.Padding(2)
        Me.Navigation1.Name = "Navigation1"
        Me.Navigation1.Size = New System.Drawing.Size(382, 603)
        Me.Navigation1.TabIndex = 1
        Me.Navigation1.Visible = False
        '
        'Emergency1
        '
        Me.Emergency1.Location = New System.Drawing.Point(18, 103)
        Me.Emergency1.Name = "Emergency1"
        Me.Emergency1.Size = New System.Drawing.Size(382, 569)
        Me.Emergency1.TabIndex = 7
        Me.Emergency1.Visible = False
        '
        'Entertainment1
        '
        Me.Entertainment1.Location = New System.Drawing.Point(18, 103)
        Me.Entertainment1.Margin = New System.Windows.Forms.Padding(2)
        Me.Entertainment1.Name = "Entertainment1"
        Me.Entertainment1.Size = New System.Drawing.Size(382, 579)
        Me.Entertainment1.TabIndex = 9
        Me.Entertainment1.Visible = False
        '
        'PerformanceTrack1
        '
        Me.PerformanceTrack1.Location = New System.Drawing.Point(18, 69)
        Me.PerformanceTrack1.Margin = New System.Windows.Forms.Padding(2)
        Me.PerformanceTrack1.Name = "PerformanceTrack1"
        Me.PerformanceTrack1.Size = New System.Drawing.Size(382, 613)
        Me.PerformanceTrack1.TabIndex = 10
        Me.PerformanceTrack1.Visible = False
        '
        'SeatConf1
        '
        Me.SeatConf1.Location = New System.Drawing.Point(18, 69)
        Me.SeatConf1.Name = "SeatConf1"
        Me.SeatConf1.Size = New System.Drawing.Size(382, 613)
        Me.SeatConf1.TabIndex = 10
        '
        'SteeringWheel1
        '
        Me.SteeringWheel1.Location = New System.Drawing.Point(18, 103)
        Me.SteeringWheel1.Name = "SteeringWheel1"
        Me.SteeringWheel1.Size = New System.Drawing.Size(382, 569)
        Me.SteeringWheel1.TabIndex = 13
        Me.SteeringWheel1.Visible = False
        '
        'SeatScreen2
        '
        Me.SeatScreen2.Location = New System.Drawing.Point(18, 103)
        Me.SeatScreen2.Name = "SeatScreen2"
        Me.SeatScreen2.Size = New System.Drawing.Size(382, 569)
        Me.SeatScreen2.TabIndex = 12
        Me.SeatScreen2.Visible = False
        '
        'SeatScreen1
        '
        Me.SeatScreen1.Location = New System.Drawing.Point(18, 103)
        Me.SeatScreen1.Name = "SeatScreen1"
        Me.SeatScreen1.Size = New System.Drawing.Size(382, 569)
        Me.SeatScreen1.TabIndex = 11
        Me.SeatScreen1.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HomeScreen.My.Resources.Resources.s5Template1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 749)
        Me.Controls.Add(Me.Alert1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.MainScreen1)
        Me.Controls.Add(Me.ClimateScreen1)
        Me.Controls.Add(Me.SecurityScreen1)
        Me.Controls.Add(Me.LocateCarScreen1)
        Me.Controls.Add(Me.Navigation1)
        Me.Controls.Add(Me.Emergency1)
        Me.Controls.Add(Me.Entertainment1)
        Me.Controls.Add(Me.PerformanceTrack1)
        Me.Controls.Add(Me.SeatConf1)
        Me.Controls.Add(Me.SteeringWheel1)
        Me.Controls.Add(Me.SeatScreen2)
        Me.Controls.Add(Me.SeatScreen1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(446, 794)
        Me.MinimumSize = New System.Drawing.Size(446, 766)
        Me.Name = "MainForm"
        Me.Text = "CarSafe"
        CType(Me.BackButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainScreen1 As HomeScreen.MainScreen
    Friend WithEvents Navigation1 As HomeScreen.Navigation
    Friend WithEvents SecurityScreen1 As HomeScreen.SecurityScreen
    Friend WithEvents ClimateScreen1 As HomeScreen.ClimateScreen
    Friend WithEvents BackButton As System.Windows.Forms.PictureBox
    Friend WithEvents Emergency1 As HomeScreen.Emergency
    Friend WithEvents Alert1 As HomeScreen.Alert
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LocateCarScreen1 As HomeScreen.LocateCarScreen
    Friend WithEvents Entertainment1 As HomeScreen.Entertainment
    Friend WithEvents PerformanceTrack1 As HomeScreen.PerformanceTrack
    Friend WithEvents SeatConf1 As HomeScreen.SeatConf
    Friend WithEvents SeatScreen1 As HomeScreen.SeatScreen
    Friend WithEvents SeatScreen2 As HomeScreen.SeatScreen
    Friend WithEvents SteeringWheel1 As HomeScreen.SteeringWheel
    'Friend WithEvents MainScreen1 As HomeScreen.MainScreen
    'Friend WithEvents Navigation1 As HomeScreen.Navigation
    'Friend WithEvents SecurityScreen1 As HomeScreen.SecurityScreen

End Class
