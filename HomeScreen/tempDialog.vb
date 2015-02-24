Imports System.Windows.Forms

Public Class tempDialog
    Dim intake As String = "In"
    Dim dir As String = "Face"

    Dim fanSpeed As Integer = 0
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub trackBarTemp_Scroll(sender As Object, e As EventArgs) Handles trackBarTemp.Scroll
        txtDesiredTemp.Text = trackBarTemp.Value.ToString() + " ºC"
    End Sub

    Private Sub tempDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDesiredTemp.Text = "18" + " ºC"
    End Sub

    Private Sub btnFanSpeed_Click(sender As Object, e As EventArgs) Handles btnFanSpeed.Click
        If fanSpeed < 5 Then
            fanSpeed = fanSpeed + 1
            lblFanSpeed.Text = "Fan Speed: " + fanSpeed.ToString
        Else
            fanSpeed = 0
            lblFanSpeed.Text = "Fan Speed: 0"
        End If
    End Sub

    Private Sub btnIntakeIn_Click(sender As Object, e As EventArgs) Handles btnIntakeIn.Click
        If intake.Equals("Out") Then
            intake = "In"
            picBoxIntakeIn.BackColor = Color.LightGreen
            picBoxIntakeOut.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub btnIntakeOut_Click(sender As Object, e As EventArgs) Handles btnIntakeOut.Click
        If intake.Equals("In") Then
            intake = "Out"
            picBoxIntakeOut.BackColor = Color.LightGreen
            picBoxIntakeIn.BackColor = DefaultBackColor
        End If
    End Sub

    
    Private Sub btnDirFace_Click(sender As Object, e As EventArgs) Handles btnDirFace.Click
        If Not dir.Equals("Face") Then
            dir = "Face"
            picBoxDirFace.BackColor = Color.LightGreen
            picBoxDirFeet.BackColor = DefaultBackColor
            picBoxDirFaceFeet.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub btnDirFeet_Click(sender As Object, e As EventArgs) Handles btnDirFeet.Click
        If Not dir.Equals("Feet") Then
            dir = "Feet"
            picBoxDirFace.BackColor = DefaultBackColor
            picBoxDirFeet.BackColor = Color.LightGreen
            picBoxDirFaceFeet.BackColor = DefaultBackColor
        End If
    End Sub

    Private Sub btnDirFaceFeet_Click(sender As Object, e As EventArgs) Handles btnDirFaceFeet.Click
        If Not dir.Equals("FaceFeet") Then
            dir = "FaceFeet"
            picBoxDirFace.BackColor = DefaultBackColor
            picBoxDirFeet.BackColor = DefaultBackColor
            picBoxDirFaceFeet.BackColor = Color.LightGreen
        End If
    End Sub

End Class
