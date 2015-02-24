Public Class SeatScreen
    Dim tiltValue As String

    Private Sub scrollBars(sender As Object, e As EventArgs) Handles frontBackScroll.Scroll, heightScroll.Scroll, tiltScroll.Scroll
        frontBackLabel.Text = frontBackScroll.Value
        heightLabel.Text = heightScroll.Value
        tiltValue = tiltScroll.Value * 4
        tiltLabel.Text = tiltValue + "º"
    End Sub

    Private Sub SeatScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frontBackLabel.Text = "5"
        heightLabel.Text = "5"
        tiltValue = tiltScroll.Value * 4
        tiltLabel.Text = tiltValue + "º"
    End Sub
End Class
