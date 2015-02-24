<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerformanceTrack
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
        Me.dash_box = New System.Windows.Forms.PictureBox()
        Me.mileage = New System.Windows.Forms.Label()
        Me.acceleration_meter = New System.Windows.Forms.Label()
        Me.Total_distance = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dash_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dash_box
        '
        Me.dash_box.BackgroundImage = Global.HomeScreen.My.Resources.Resources.dashboard
        Me.dash_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dash_box.Location = New System.Drawing.Point(0, 0)
        Me.dash_box.Name = "dash_box"
        Me.dash_box.Size = New System.Drawing.Size(382, 400)
        Me.dash_box.TabIndex = 0
        Me.dash_box.TabStop = False
        '
        'mileage
        '
        Me.mileage.AutoSize = True
        Me.mileage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mileage.Location = New System.Drawing.Point(42, 386)
        Me.mileage.Name = "mileage"
        Me.mileage.Size = New System.Drawing.Size(172, 25)
        Me.mileage.TabIndex = 1
        Me.mileage.Text = "Mileage: 100 km/s"
        '
        'acceleration_meter
        '
        Me.acceleration_meter.AutoSize = True
        Me.acceleration_meter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acceleration_meter.Location = New System.Drawing.Point(42, 423)
        Me.acceleration_meter.Name = "acceleration_meter"
        Me.acceleration_meter.Size = New System.Drawing.Size(213, 25)
        Me.acceleration_meter.TabIndex = 2
        Me.acceleration_meter.Text = "Acceleration: 3000 rpm"
        '
        'Total_distance
        '
        Me.Total_distance.AutoSize = True
        Me.Total_distance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_distance.Location = New System.Drawing.Point(42, 458)
        Me.Total_distance.Name = "Total_distance"
        Me.Total_distance.Size = New System.Drawing.Size(234, 25)
        Me.Total_distance.TabIndex = 3
        Me.Total_distance.Text = "Total Distance: 18392 km"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 492)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tire Pressure: 34 psi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PerformanceTrack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Total_distance)
        Me.Controls.Add(Me.acceleration_meter)
        Me.Controls.Add(Me.mileage)
        Me.Controls.Add(Me.dash_box)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PerformanceTrack"
        Me.Size = New System.Drawing.Size(382, 629)
        CType(Me.dash_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dash_box As System.Windows.Forms.PictureBox
    Friend WithEvents mileage As System.Windows.Forms.Label
    Friend WithEvents acceleration_meter As System.Windows.Forms.Label
    Friend WithEvents Total_distance As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
