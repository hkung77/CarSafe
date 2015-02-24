<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClimateScreen
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
        Me.btnAC = New System.Windows.Forms.Button()
        Me.txtCurrentTemp = New System.Windows.Forms.TextBox()
        Me.lblCurrentTemp = New System.Windows.Forms.Label()
        Me.lblDesiredTemp = New System.Windows.Forms.Label()
        Me.txtDesiredTemp = New System.Windows.Forms.TextBox()
        Me.lblDriverSeat = New System.Windows.Forms.Label()
        Me.lblPassengerSeat = New System.Windows.Forms.Label()
        Me.labelExteriorTemp = New System.Windows.Forms.Label()
        Me.txtExteriorTemp = New System.Windows.Forms.TextBox()
        Me.btnSeatWarmerPass = New System.Windows.Forms.Button()
        Me.btnCurrentTenp = New System.Windows.Forms.Button()
        Me.btnSeatWarmerDriver = New System.Windows.Forms.Button()
        Me.btnHeatSteering = New System.Windows.Forms.Button()
        Me.picBoxHeatSteering = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxHeatSteering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAC
        '
        Me.btnAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAC.Location = New System.Drawing.Point(12, 475)
        Me.btnAC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAC.Name = "btnAC"
        Me.btnAC.Size = New System.Drawing.Size(87, 85)
        Me.btnAC.TabIndex = 17
        Me.btnAC.Text = "A/C"
        Me.btnAC.UseVisualStyleBackColor = True
        '
        'txtCurrentTemp
        '
        Me.txtCurrentTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentTemp.Location = New System.Drawing.Point(86, 385)
        Me.txtCurrentTemp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCurrentTemp.Name = "txtCurrentTemp"
        Me.txtCurrentTemp.ReadOnly = True
        Me.txtCurrentTemp.Size = New System.Drawing.Size(201, 83)
        Me.txtCurrentTemp.TabIndex = 20
        Me.txtCurrentTemp.Text = "-13 ºC"
        '
        'lblCurrentTemp
        '
        Me.lblCurrentTemp.AutoSize = True
        Me.lblCurrentTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentTemp.Location = New System.Drawing.Point(100, 344)
        Me.lblCurrentTemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrentTemp.Name = "lblCurrentTemp"
        Me.lblCurrentTemp.Size = New System.Drawing.Size(186, 20)
        Me.lblCurrentTemp.TabIndex = 21
        Me.lblCurrentTemp.Text = "Current Interior Temp:"
        '
        'lblDesiredTemp
        '
        Me.lblDesiredTemp.AutoSize = True
        Me.lblDesiredTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesiredTemp.Location = New System.Drawing.Point(99, 215)
        Me.lblDesiredTemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDesiredTemp.Name = "lblDesiredTemp"
        Me.lblDesiredTemp.Size = New System.Drawing.Size(188, 20)
        Me.lblDesiredTemp.TabIndex = 23
        Me.lblDesiredTemp.Text = "Desired Interior Temp:"
        '
        'txtDesiredTemp
        '
        Me.txtDesiredTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesiredTemp.Location = New System.Drawing.Point(139, 250)
        Me.txtDesiredTemp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDesiredTemp.Name = "txtDesiredTemp"
        Me.txtDesiredTemp.ReadOnly = True
        Me.txtDesiredTemp.Size = New System.Drawing.Size(91, 45)
        Me.txtDesiredTemp.TabIndex = 22
        Me.txtDesiredTemp.Text = "18 ºC"
        '
        'lblDriverSeat
        '
        Me.lblDriverSeat.AutoSize = True
        Me.lblDriverSeat.Location = New System.Drawing.Point(40, 54)
        Me.lblDriverSeat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDriverSeat.Name = "lblDriverSeat"
        Me.lblDriverSeat.Size = New System.Drawing.Size(35, 13)
        Me.lblDriverSeat.TabIndex = 25
        Me.lblDriverSeat.Text = "Driver"
        '
        'lblPassengerSeat
        '
        Me.lblPassengerSeat.AutoSize = True
        Me.lblPassengerSeat.Location = New System.Drawing.Point(290, 54)
        Me.lblPassengerSeat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassengerSeat.Name = "lblPassengerSeat"
        Me.lblPassengerSeat.Size = New System.Drawing.Size(57, 13)
        Me.lblPassengerSeat.TabIndex = 26
        Me.lblPassengerSeat.Text = "Passenger"
        '
        'labelExteriorTemp
        '
        Me.labelExteriorTemp.AutoSize = True
        Me.labelExteriorTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelExteriorTemp.Location = New System.Drawing.Point(80, 9)
        Me.labelExteriorTemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelExteriorTemp.Name = "labelExteriorTemp"
        Me.labelExteriorTemp.Size = New System.Drawing.Size(173, 17)
        Me.labelExteriorTemp.TabIndex = 28
        Me.labelExteriorTemp.Text = "Current Temp Outside:"
        '
        'txtExteriorTemp
        '
        Me.txtExteriorTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExteriorTemp.Location = New System.Drawing.Point(255, 6)
        Me.txtExteriorTemp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtExteriorTemp.Name = "txtExteriorTemp"
        Me.txtExteriorTemp.ReadOnly = True
        Me.txtExteriorTemp.Size = New System.Drawing.Size(91, 23)
        Me.txtExteriorTemp.TabIndex = 27
        Me.txtExteriorTemp.Text = "-15 ºC"
        '
        'btnSeatWarmerPass
        '
        Me.btnSeatWarmerPass.BackgroundImage = Global.HomeScreen.My.Resources.Resources.heater
        Me.btnSeatWarmerPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeatWarmerPass.Location = New System.Drawing.Point(284, 80)
        Me.btnSeatWarmerPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSeatWarmerPass.Name = "btnSeatWarmerPass"
        Me.btnSeatWarmerPass.Size = New System.Drawing.Size(72, 85)
        Me.btnSeatWarmerPass.TabIndex = 19
        Me.btnSeatWarmerPass.UseVisualStyleBackColor = True
        '
        'btnCurrentTenp
        '
        Me.btnCurrentTenp.BackgroundImage = Global.HomeScreen.My.Resources.Resources.temp
        Me.btnCurrentTenp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCurrentTenp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCurrentTenp.Location = New System.Drawing.Point(142, 82)
        Me.btnCurrentTenp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCurrentTenp.Name = "btnCurrentTenp"
        Me.btnCurrentTenp.Size = New System.Drawing.Size(86, 83)
        Me.btnCurrentTenp.TabIndex = 18
        Me.btnCurrentTenp.UseVisualStyleBackColor = True
        '
        'btnSeatWarmerDriver
        '
        Me.btnSeatWarmerDriver.BackgroundImage = Global.HomeScreen.My.Resources.Resources.heater
        Me.btnSeatWarmerDriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeatWarmerDriver.Location = New System.Drawing.Point(27, 80)
        Me.btnSeatWarmerDriver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSeatWarmerDriver.Name = "btnSeatWarmerDriver"
        Me.btnSeatWarmerDriver.Size = New System.Drawing.Size(72, 85)
        Me.btnSeatWarmerDriver.TabIndex = 16
        Me.btnSeatWarmerDriver.UseVisualStyleBackColor = True
        '
        'btnHeatSteering
        '
        Me.btnHeatSteering.BackgroundImage = Global.HomeScreen.My.Resources.Resources.heatSteering
        Me.btnHeatSteering.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHeatSteering.Location = New System.Drawing.Point(284, 484)
        Me.btnHeatSteering.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHeatSteering.Name = "btnHeatSteering"
        Me.btnHeatSteering.Size = New System.Drawing.Size(72, 62)
        Me.btnHeatSteering.TabIndex = 15
        Me.btnHeatSteering.UseVisualStyleBackColor = True
        '
        'picBoxHeatSteering
        '
        Me.picBoxHeatSteering.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxHeatSteering.Location = New System.Drawing.Point(275, 475)
        Me.picBoxHeatSteering.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picBoxHeatSteering.Name = "picBoxHeatSteering"
        Me.picBoxHeatSteering.Size = New System.Drawing.Size(88, 86)
        Me.picBoxHeatSteering.TabIndex = 24
        Me.picBoxHeatSteering.TabStop = False
        '
        'ClimateScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.labelExteriorTemp)
        Me.Controls.Add(Me.txtExteriorTemp)
        Me.Controls.Add(Me.lblPassengerSeat)
        Me.Controls.Add(Me.lblDriverSeat)
        Me.Controls.Add(Me.lblDesiredTemp)
        Me.Controls.Add(Me.txtDesiredTemp)
        Me.Controls.Add(Me.lblCurrentTemp)
        Me.Controls.Add(Me.txtCurrentTemp)
        Me.Controls.Add(Me.btnSeatWarmerPass)
        Me.Controls.Add(Me.btnCurrentTenp)
        Me.Controls.Add(Me.btnAC)
        Me.Controls.Add(Me.btnSeatWarmerDriver)
        Me.Controls.Add(Me.btnHeatSteering)
        Me.Controls.Add(Me.picBoxHeatSteering)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ClimateScreen"
        Me.Size = New System.Drawing.Size(382, 569)
        CType(Me.picBoxHeatSteering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHeatSteering As System.Windows.Forms.Button
    Friend WithEvents btnSeatWarmerDriver As System.Windows.Forms.Button
    Friend WithEvents btnAC As System.Windows.Forms.Button
    Friend WithEvents btnCurrentTenp As System.Windows.Forms.Button
    Friend WithEvents btnSeatWarmerPass As System.Windows.Forms.Button
    Friend WithEvents txtCurrentTemp As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentTemp As System.Windows.Forms.Label
    Friend WithEvents lblDesiredTemp As System.Windows.Forms.Label
    Friend WithEvents txtDesiredTemp As System.Windows.Forms.TextBox
    Friend WithEvents picBoxHeatSteering As System.Windows.Forms.PictureBox
    Friend WithEvents lblDriverSeat As System.Windows.Forms.Label
    Friend WithEvents lblPassengerSeat As System.Windows.Forms.Label
    Friend WithEvents labelExteriorTemp As System.Windows.Forms.Label
    Friend WithEvents txtExteriorTemp As System.Windows.Forms.TextBox

End Class
