Public Class SeatConf

    Private Sub Driver_Click(sender As Object, e As EventArgs) Handles Driver.Click, Passenger.Click
        Dim person As PictureBox = DirectCast(sender, PictureBox)
        Me.Visible = False
        MainForm.Show_SeatScreen(person.Name)
    End Sub

    Private Sub steeringWheel_Click(sender As Object, e As EventArgs) Handles steeringWheel.Click
        MainForm.Show_SteeringWheel()
    End Sub
End Class
