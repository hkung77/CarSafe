<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alert
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.alert_label = New System.Windows.Forms.Label()
        Me.notification = New System.Windows.Forms.Label()
        Me.warning_pic = New System.Windows.Forms.PictureBox()
        Me.pnlAlertSmall = New System.Windows.Forms.Panel()
        CType(Me.warning_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAlertSmall.SuspendLayout()
        Me.SuspendLayout()
        '
        'alert_label
        '
        Me.alert_label.AutoSize = True
        Me.alert_label.BackColor = System.Drawing.Color.Transparent
        Me.alert_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alert_label.ForeColor = System.Drawing.SystemColors.Control
        Me.alert_label.Location = New System.Drawing.Point(3, 9)
        Me.alert_label.Name = "alert_label"
        Me.alert_label.Size = New System.Drawing.Size(132, 16)
        Me.alert_label.TabIndex = 0
        Me.alert_label.Text = "! INTRUDER ALERT"
        Me.alert_label.Visible = False
        '
        'notification
        '
        Me.notification.AutoSize = True
        Me.notification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notification.ForeColor = System.Drawing.Color.White
        Me.notification.Location = New System.Drawing.Point(63, 39)
        Me.notification.Name = "notification"
        Me.notification.Size = New System.Drawing.Size(318, 32)
        Me.notification.TabIndex = 2
        Me.notification.Text = "INTRUDER ALERT: Someone is trying to break into " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your car!!"
        Me.notification.Visible = False
        '
        'warning_pic
        '
        Me.warning_pic.Image = Global.HomeScreen.My.Resources.Resources.warning
        Me.warning_pic.Location = New System.Drawing.Point(3, 28)
        Me.warning_pic.Name = "warning_pic"
        Me.warning_pic.Size = New System.Drawing.Size(54, 50)
        Me.warning_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.warning_pic.TabIndex = 3
        Me.warning_pic.TabStop = False
        Me.warning_pic.Visible = False
        '
        'pnlAlertSmall
        '
        Me.pnlAlertSmall.Controls.Add(Me.alert_label)
        Me.pnlAlertSmall.Controls.Add(Me.notification)
        Me.pnlAlertSmall.Controls.Add(Me.warning_pic)
        Me.pnlAlertSmall.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlAlertSmall.Location = New System.Drawing.Point(0, 0)
        Me.pnlAlertSmall.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlAlertSmall.Name = "pnlAlertSmall"
        Me.pnlAlertSmall.Size = New System.Drawing.Size(382, 109)
        Me.pnlAlertSmall.TabIndex = 4
        '
        'Alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.pnlAlertSmall)
        Me.Name = "Alert"
        Me.Size = New System.Drawing.Size(382, 110)
        CType(Me.warning_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAlertSmall.ResumeLayout(False)
        Me.pnlAlertSmall.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents alert_label As System.Windows.Forms.Label
    Friend WithEvents warning_pic As System.Windows.Forms.PictureBox
    Friend WithEvents notification As System.Windows.Forms.Label
    Friend WithEvents pnlAlertSmall As System.Windows.Forms.Panel

End Class
