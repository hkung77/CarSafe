<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatScreen
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
        Me.seatTilt = New System.Windows.Forms.PictureBox()
        Me.seatHeight = New System.Windows.Forms.PictureBox()
        Me.backForth = New System.Windows.Forms.PictureBox()
        Me.frontBackScroll = New System.Windows.Forms.TrackBar()
        Me.tiltScroll = New System.Windows.Forms.TrackBar()
        Me.heightScroll = New System.Windows.Forms.TrackBar()
        Me.frontBackLabel = New System.Windows.Forms.Label()
        Me.heightLabel = New System.Windows.Forms.Label()
        Me.tiltLabel = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Use = New System.Windows.Forms.Button()
        CType(Me.seatTilt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seatHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backForth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frontBackScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tiltScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.heightScroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'seatTilt
        '
        Me.seatTilt.Image = Global.HomeScreen.My.Resources.Resources.SeatTilt
        Me.seatTilt.Location = New System.Drawing.Point(100, 395)
        Me.seatTilt.Name = "seatTilt"
        Me.seatTilt.Size = New System.Drawing.Size(152, 133)
        Me.seatTilt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.seatTilt.TabIndex = 2
        Me.seatTilt.TabStop = False
        '
        'seatHeight
        '
        Me.seatHeight.Image = Global.HomeScreen.My.Resources.Resources.SeatHeight
        Me.seatHeight.Location = New System.Drawing.Point(100, 214)
        Me.seatHeight.Name = "seatHeight"
        Me.seatHeight.Size = New System.Drawing.Size(152, 133)
        Me.seatHeight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.seatHeight.TabIndex = 1
        Me.seatHeight.TabStop = False
        '
        'backForth
        '
        Me.backForth.Image = Global.HomeScreen.My.Resources.Resources.seatForwardBack__2_
        Me.backForth.Location = New System.Drawing.Point(100, 36)
        Me.backForth.Name = "backForth"
        Me.backForth.Size = New System.Drawing.Size(152, 133)
        Me.backForth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.backForth.TabIndex = 0
        Me.backForth.TabStop = False
        '
        'frontBackScroll
        '
        Me.frontBackScroll.Location = New System.Drawing.Point(18, 175)
        Me.frontBackScroll.Name = "frontBackScroll"
        Me.frontBackScroll.Size = New System.Drawing.Size(338, 45)
        Me.frontBackScroll.TabIndex = 3
        Me.frontBackScroll.Value = 5
        '
        'tiltScroll
        '
        Me.tiltScroll.Location = New System.Drawing.Point(18, 521)
        Me.tiltScroll.Maximum = 45
        Me.tiltScroll.Name = "tiltScroll"
        Me.tiltScroll.Size = New System.Drawing.Size(338, 45)
        Me.tiltScroll.TabIndex = 4
        Me.tiltScroll.TickFrequency = 2
        Me.tiltScroll.Value = 23
        '
        'heightScroll
        '
        Me.heightScroll.Location = New System.Drawing.Point(18, 344)
        Me.heightScroll.Name = "heightScroll"
        Me.heightScroll.Size = New System.Drawing.Size(338, 45)
        Me.heightScroll.TabIndex = 5
        Me.heightScroll.Value = 5
        '
        'frontBackLabel
        '
        Me.frontBackLabel.AutoSize = True
        Me.frontBackLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frontBackLabel.Location = New System.Drawing.Point(270, 138)
        Me.frontBackLabel.Name = "frontBackLabel"
        Me.frontBackLabel.Size = New System.Drawing.Size(0, 31)
        Me.frontBackLabel.TabIndex = 6
        '
        'heightLabel
        '
        Me.heightLabel.AutoSize = True
        Me.heightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightLabel.Location = New System.Drawing.Point(270, 310)
        Me.heightLabel.Name = "heightLabel"
        Me.heightLabel.Size = New System.Drawing.Size(0, 31)
        Me.heightLabel.TabIndex = 7
        '
        'tiltLabel
        '
        Me.tiltLabel.AutoSize = True
        Me.tiltLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiltLabel.Location = New System.Drawing.Point(270, 487)
        Me.tiltLabel.Name = "tiltLabel"
        Me.tiltLabel.Size = New System.Drawing.Size(0, 31)
        Me.tiltLabel.TabIndex = 8
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(31, 17)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 9
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Use
        '
        Me.Use.Location = New System.Drawing.Point(276, 17)
        Me.Use.Name = "Use"
        Me.Use.Size = New System.Drawing.Size(75, 23)
        Me.Use.TabIndex = 10
        Me.Use.Text = "Use"
        Me.Use.UseVisualStyleBackColor = True
        '
        'SeatScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Use)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.tiltLabel)
        Me.Controls.Add(Me.heightLabel)
        Me.Controls.Add(Me.frontBackLabel)
        Me.Controls.Add(Me.heightScroll)
        Me.Controls.Add(Me.tiltScroll)
        Me.Controls.Add(Me.frontBackScroll)
        Me.Controls.Add(Me.seatTilt)
        Me.Controls.Add(Me.seatHeight)
        Me.Controls.Add(Me.backForth)
        Me.Name = "SeatScreen"
        Me.Size = New System.Drawing.Size(382, 569)
        CType(Me.seatTilt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seatHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backForth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frontBackScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tiltScroll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.heightScroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backForth As System.Windows.Forms.PictureBox
    Friend WithEvents seatHeight As System.Windows.Forms.PictureBox
    Friend WithEvents seatTilt As System.Windows.Forms.PictureBox
    Friend WithEvents frontBackScroll As System.Windows.Forms.TrackBar
    Friend WithEvents tiltScroll As System.Windows.Forms.TrackBar
    Friend WithEvents heightScroll As System.Windows.Forms.TrackBar
    Friend WithEvents frontBackLabel As System.Windows.Forms.Label
    Friend WithEvents heightLabel As System.Windows.Forms.Label
    Friend WithEvents tiltLabel As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Use As System.Windows.Forms.Button

End Class
