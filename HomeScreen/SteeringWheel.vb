Public Class SteeringWheel

    
    Private Sub wheelHeight_Scroll(sender As Object, e As EventArgs) Handles wheelHeight.Scroll, backForth_wheel.Scroll
        ' frontBackLabel.Text = frontBackScroll.Value
        steeringHeight_Label.Text = wheelHeight.Value
        steering_Label.Text = backForth_wheel.Value
    End Sub

    Private Sub SteeringWheel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        steeringHeight_Label.Text = "5"
        steering_Label.Text = "5"
    End Sub
End Class
