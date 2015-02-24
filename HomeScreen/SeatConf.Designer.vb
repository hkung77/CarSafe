<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatConf
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
        Me.DriverLabel = New System.Windows.Forms.Label()
        Me.PassengerLabel = New System.Windows.Forms.Label()
        Me.steeringWheel = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Driver = New System.Windows.Forms.PictureBox()
        Me.Passenger = New System.Windows.Forms.PictureBox()
        CType(Me.steeringWheel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Driver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Passenger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DriverLabel
        '
        Me.DriverLabel.AutoSize = True
        Me.DriverLabel.Location = New System.Drawing.Point(77, 219)
        Me.DriverLabel.Name = "DriverLabel"
        Me.DriverLabel.Size = New System.Drawing.Size(35, 13)
        Me.DriverLabel.TabIndex = 2
        Me.DriverLabel.Text = "Driver"
        '
        'PassengerLabel
        '
        Me.PassengerLabel.AutoSize = True
        Me.PassengerLabel.Location = New System.Drawing.Point(243, 219)
        Me.PassengerLabel.Name = "PassengerLabel"
        Me.PassengerLabel.Size = New System.Drawing.Size(57, 13)
        Me.PassengerLabel.TabIndex = 3
        Me.PassengerLabel.Text = "Passenger"
        '
        'steeringWheel
        '
        Me.steeringWheel.Image = Global.HomeScreen.My.Resources.Resources.steering_wheel_512
        Me.steeringWheel.Location = New System.Drawing.Point(103, 250)
        Me.steeringWheel.Name = "steeringWheel"
        Me.steeringWheel.Size = New System.Drawing.Size(170, 140)
        Me.steeringWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.steeringWheel.TabIndex = 6
        Me.steeringWheel.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.HomeScreen.My.Resources.Resources.side_right
        Me.PictureBox2.Location = New System.Drawing.Point(214, 430)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(126, 103)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HomeScreen.My.Resources.Resources.side_left
        Me.PictureBox1.Location = New System.Drawing.Point(39, 430)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Driver
        '
        Me.Driver.Image = Global.HomeScreen.My.Resources.Resources.Seat
        Me.Driver.Location = New System.Drawing.Point(39, 75)
        Me.Driver.Name = "Driver"
        Me.Driver.Size = New System.Drawing.Size(126, 132)
        Me.Driver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Driver.TabIndex = 1
        Me.Driver.TabStop = False
        '
        'Passenger
        '
        Me.Passenger.Image = Global.HomeScreen.My.Resources.Resources.Seat
        Me.Passenger.Location = New System.Drawing.Point(214, 75)
        Me.Passenger.Name = "Passenger"
        Me.Passenger.Size = New System.Drawing.Size(126, 132)
        Me.Passenger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Passenger.TabIndex = 0
        Me.Passenger.TabStop = False
        '
        'SeatConf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.steeringWheel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PassengerLabel)
        Me.Controls.Add(Me.DriverLabel)
        Me.Controls.Add(Me.Driver)
        Me.Controls.Add(Me.Passenger)
        Me.Name = "SeatConf"
        Me.Size = New System.Drawing.Size(382, 569)
        CType(Me.steeringWheel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Driver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Passenger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Passenger As System.Windows.Forms.PictureBox
    Friend WithEvents Driver As System.Windows.Forms.PictureBox
    Friend WithEvents DriverLabel As System.Windows.Forms.Label
    Friend WithEvents PassengerLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents steeringWheel As System.Windows.Forms.PictureBox

End Class
