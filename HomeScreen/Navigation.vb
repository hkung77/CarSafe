Public Class Navigation

    Private Sub Start_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Start_TextBox.TextChanged
        If Not Destination_TextBox.Text.Equals("") Then
            OK_Button.Enabled = True
        End If
    End Sub

    Private Sub Destination_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Destination_TextBox.TextChanged
        If Not Start_TextBox.Text.Equals("") Then
            OK_Button.Enabled = True
        End If
    End Sub

    Public Sub Reset()
        Destination_TextBox.Text = ""
        OK_Button.Enabled = False
        Map.Visible = False
        Ryerson.Visible = True
    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Map.Show()
        Ryerson.Visible = False
    End Sub

    Private Sub Navigation_Load(sender As Object, e As EventArgs) Handles Me.Load
        Start_TextBox.Text = "Home"
    End Sub

End Class
