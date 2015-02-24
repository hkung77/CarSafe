Public Class SecurityScreen

    Private Sub InteriorButton_Click(sender As Object, e As EventArgs) Handles InteriorButton.Click
        CameraImage.Image = My.Resources.scaryblackman
        CameraText.Text = "Interior Camera"
    End Sub

    Private Sub FrontButton_Click(sender As Object, e As EventArgs) Handles FrontButton.Click
        CameraImage.Image = My.Resources.front_camera
        CameraText.Text = "Front Camera"
    End Sub

    Private Sub RearButton_Click(sender As Object, e As EventArgs) Handles RearButton.Click
        CameraImage.Image = My.Resources.back_camera
        CameraText.Text = "Rear Camera"
    End Sub

    Private Sub ContactRespondersButton_Click(sender As Object, e As EventArgs) Handles ContactRespondersButton.Click
        MainForm.Show_EmergencyScreen()
        Me.Visible = False
        My.Computer.Audio.Play(My.Resources.phoneCalling1, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
