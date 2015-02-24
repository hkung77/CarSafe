Public Class MainScreen
    Dim lockStatus As Boolean = True
    Dim carOn As Boolean = False
    Dim lightOn As Boolean = False
    Private Sub PictureBoxLock_Click(sender As Object, e As EventArgs) Handles PictureBoxLock.Click
        lockStatus = Not lockStatus

        If lockStatus = True Then
            PictureBoxLock.Image = My.Resources.lock
        Else
            PictureBoxLock.Image = My.Resources.Unlock
        End If
    End Sub

    Private Sub MapImage_Click(sender As Object, e As EventArgs) Handles MapImage.Click
        Me.Visible = False
        MainForm.Show_Navigation()
    End Sub


    Private Sub SecurityImage_Click(sender As Object, e As EventArgs) Handles SecurityImage.Click
        Me.Visible = False
        MainForm.Show_SecurityScreen()
    End Sub


    Private Sub TemperatureImage_Click(sender As Object, e As EventArgs) Handles TemperatureImage.Click
        Me.Visible = False
        MainForm.Show_ClimateScreen()
    End Sub

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        If carOn Then
            PictureBox3.BackgroundImage = My.Resources.startButton
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        Else
            PictureBox3.BackgroundImage = My.Resources.startButtonOff
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Visible = False
        MainForm.Show_LocateCarScreen()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        carOn = Not carOn
        ''test
        If carOn Then
            PictureBox3.BackgroundImage = My.Resources.startButton
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        Else
            PictureBox3.BackgroundImage = My.Resources.startButtonOff
            PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        My.Computer.Audio.Play(My.Resources.auto_horn, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox4_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseUp
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Entertainment_Click(sender As Object, e As EventArgs) Handles Entertainment.Click
        Me.Visible = False
        MainForm.Show_Entertainment()
    End Sub

    Private Sub Performance_Click(sender As Object, e As EventArgs) Handles Performance.Click
        Me.Visible = False
        MainForm.Show_Performance()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Visible = False
        MainForm.Show_Seats()

    End Sub

    Private Sub light_box_Click(sender As Object, e As EventArgs) Handles light_box.Click
        If lightOn.Equals(False) Then
            light_box.BackgroundImage = My.Resources.light_on
            lightOn = True
        Else
            light_box.BackgroundImage = My.Resources.light_off
            lightOn = False
        End If
    End Sub
End Class
