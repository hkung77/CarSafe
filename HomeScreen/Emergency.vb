Public Class Emergency

    Private Sub end_call_Click(sender As Object, e As EventArgs) Handles end_call.Click
        Me.Visible = False
        My.Computer.Audio.Stop()
        MainForm.Show_MainScreen()
    End Sub

End Class
