Public Class Entertainment
    Dim max As Boolean = False

    Private Sub BlueTooth_CheckedChanged(sender As Object, e As EventArgs) Handles BlueTooth.CheckedChanged
        If Search_Label.Visible.Equals(False) Then
            Search_Label.Visible = True
        Else
            Search_Label.Visible = False
        End If
    End Sub

    Private Sub AUX_CheckedChanged(sender As Object, e As EventArgs) Handles AUX.CheckedChanged
        If player.Visible.Equals(False) Then
            player.Visible = True
        Else
            player.Visible = False
        End If
    End Sub

    Private Sub Volume_Click(sender As Object, e As EventArgs) Handles Volume.Click
        If max.Equals(False) Then
            Volume.BackgroundImage = HomeScreen.My.Resources.vol100
            max = True
        Else
            Volume.BackgroundImage = HomeScreen.My.Resources.vol75
            max = False
        End If
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles Radio.CheckedChanged
        If Channel_Label.Visible.Equals(False) Then
            Channel_Label.Visible = True
        Else
            Channel_Label.Visible = False
        End If
    End Sub
End Class
