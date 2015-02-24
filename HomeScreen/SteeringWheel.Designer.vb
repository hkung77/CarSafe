<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SteeringWheel
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
        Me.steeringWheel_Adjust = New System.Windows.Forms.PictureBox()
        Me.backForth_wheel = New System.Windows.Forms.TrackBar()
        Me.wheelHeight = New System.Windows.Forms.TrackBar()
        Me.forward = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.steering_Label = New System.Windows.Forms.Label()
        Me.steeringHeight_Label = New System.Windows.Forms.Label()
        CType(Me.steeringWheel_Adjust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backForth_wheel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wheelHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'steeringWheel_Adjust
        '
        Me.steeringWheel_Adjust.Image = Global.HomeScreen.My.Resources.Resources.steering_wheel_512
        Me.steeringWheel_Adjust.Location = New System.Drawing.Point(45, 133)
        Me.steeringWheel_Adjust.Name = "steeringWheel_Adjust"
        Me.steeringWheel_Adjust.Size = New System.Drawing.Size(250, 287)
        Me.steeringWheel_Adjust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.steeringWheel_Adjust.TabIndex = 0
        Me.steeringWheel_Adjust.TabStop = False
        '
        'backForth_wheel
        '
        Me.backForth_wheel.LargeChange = 2
        Me.backForth_wheel.Location = New System.Drawing.Point(27, 434)
        Me.backForth_wheel.Name = "backForth_wheel"
        Me.backForth_wheel.Size = New System.Drawing.Size(295, 45)
        Me.backForth_wheel.TabIndex = 1
        Me.backForth_wheel.Value = 5
        '
        'wheelHeight
        '
        Me.wheelHeight.LargeChange = 2
        Me.wheelHeight.Location = New System.Drawing.Point(312, 133)
        Me.wheelHeight.Name = "wheelHeight"
        Me.wheelHeight.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.wheelHeight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.wheelHeight.Size = New System.Drawing.Size(45, 296)
        Me.wheelHeight.TabIndex = 2
        Me.wheelHeight.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.wheelHeight.Value = 5
        '
        'forward
        '
        Me.forward.AutoSize = True
        Me.forward.Location = New System.Drawing.Point(27, 466)
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(45, 13)
        Me.forward.TabIndex = 3
        Me.forward.Text = "Forward"
        '
        'back
        '
        Me.back.AutoSize = True
        Me.back.Location = New System.Drawing.Point(290, 466)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(32, 13)
        Me.back.TabIndex = 4
        Me.back.Text = "Back"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightLabel.Location = New System.Drawing.Point(309, 59)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(43, 15)
        Me.HeightLabel.TabIndex = 5
        Me.HeightLabel.Text = "Height"
        '
        'steering_Label
        '
        Me.steering_Label.AutoSize = True
        Me.steering_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.steering_Label.Location = New System.Drawing.Point(168, 482)
        Me.steering_Label.Name = "steering_Label"
        Me.steering_Label.Size = New System.Drawing.Size(0, 24)
        Me.steering_Label.TabIndex = 6
        '
        'steeringHeight_Label
        '
        Me.steeringHeight_Label.AutoSize = True
        Me.steeringHeight_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.steeringHeight_Label.Location = New System.Drawing.Point(322, 92)
        Me.steeringHeight_Label.Name = "steeringHeight_Label"
        Me.steeringHeight_Label.Size = New System.Drawing.Size(0, 24)
        Me.steeringHeight_Label.TabIndex = 7
        '
        'SteeringWheel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.steeringHeight_Label)
        Me.Controls.Add(Me.steering_Label)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.forward)
        Me.Controls.Add(Me.wheelHeight)
        Me.Controls.Add(Me.backForth_wheel)
        Me.Controls.Add(Me.steeringWheel_Adjust)
        Me.Name = "SteeringWheel"
        Me.Size = New System.Drawing.Size(382, 569)
        CType(Me.steeringWheel_Adjust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backForth_wheel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wheelHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents steeringWheel_Adjust As System.Windows.Forms.PictureBox
    Friend WithEvents backForth_wheel As System.Windows.Forms.TrackBar
    Friend WithEvents wheelHeight As System.Windows.Forms.TrackBar
    Friend WithEvents forward As System.Windows.Forms.Label
    Friend WithEvents back As System.Windows.Forms.Label
    Friend WithEvents HeightLabel As System.Windows.Forms.Label
    Friend WithEvents steering_Label As System.Windows.Forms.Label
    Friend WithEvents steeringHeight_Label As System.Windows.Forms.Label

End Class
