Public Class ClimateScreen

    Dim warmDriver As Boolean = False
    Dim warmPass As Boolean = False
    Dim ac As Boolean = False
    Dim heatSteering As Boolean = False

    Private Sub btnCurrentTemp_Click(sender As Object, e As EventArgs) Handles btnCurrentTenp.Click
        Dim tempDialog1 As tempDialog = New tempDialog()
        If tempDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            txtDesiredTemp.Text = tempDialog1.txtDesiredTemp.Text
        End If
    End Sub


    Private Sub btnHeatSteering_Click(sender As Object, e As EventArgs) Handles btnHeatSteering.Click
        heatSteering = Not heatSteering

        If heatSteering = True Then
            picBoxHeatSteering.BackColor = Color.LightGreen
        Else
            picBoxHeatSteering.BackColor = DefaultBackColor
        End If

    End Sub

    Private Sub btnSeatWarmer_Click(sender As Object, e As EventArgs) Handles btnSeatWarmerDriver.Click
        warmDriver = Not warmDriver
        If warmDriver = True Then
            btnSeatWarmerDriver.BackColor = Color.LightGreen
        Else
            btnSeatWarmerDriver.BackColor = DefaultBackColor
        End If


    End Sub

    Private Sub btnSeatWarmerPass_Click(sender As Object, e As EventArgs) Handles btnSeatWarmerPass.Click
        warmPass = Not warmPass
        If warmPass = True Then
            btnSeatWarmerPass.BackColor = Color.LightGreen
        Else
            btnSeatWarmerPass.BackColor = DefaultBackColor
        End If

    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        ac = Not ac
        If ac = True Then
            btnAC.BackColor = Color.LightGreen
        Else
            btnAC.BackColor = DefaultBackColor
        End If


    End Sub
End Class
