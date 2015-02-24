<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityScreen
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
        Me.InteriorButton = New System.Windows.Forms.Button()
        Me.FrontButton = New System.Windows.Forms.Button()
        Me.RearButton = New System.Windows.Forms.Button()
        Me.CameraText = New System.Windows.Forms.Label()
        Me.StatusText = New System.Windows.Forms.Label()
        Me.ContactRespondersButton = New System.Windows.Forms.Button()
        Me.CameraImage = New System.Windows.Forms.PictureBox()
        CType(Me.CameraImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InteriorButton
        '
        Me.InteriorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InteriorButton.Location = New System.Drawing.Point(25, 125)
        Me.InteriorButton.Name = "InteriorButton"
        Me.InteriorButton.Size = New System.Drawing.Size(106, 48)
        Me.InteriorButton.TabIndex = 0
        Me.InteriorButton.Text = "Interior"
        Me.InteriorButton.UseVisualStyleBackColor = True
        '
        'FrontButton
        '
        Me.FrontButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FrontButton.Location = New System.Drawing.Point(137, 125)
        Me.FrontButton.Name = "FrontButton"
        Me.FrontButton.Size = New System.Drawing.Size(106, 48)
        Me.FrontButton.TabIndex = 1
        Me.FrontButton.Text = "Front"
        Me.FrontButton.UseVisualStyleBackColor = True
        '
        'RearButton
        '
        Me.RearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RearButton.Location = New System.Drawing.Point(249, 125)
        Me.RearButton.Name = "RearButton"
        Me.RearButton.Size = New System.Drawing.Size(106, 48)
        Me.RearButton.TabIndex = 2
        Me.RearButton.Text = "Rear"
        Me.RearButton.UseVisualStyleBackColor = True
        '
        'CameraText
        '
        Me.CameraText.AutoSize = True
        Me.CameraText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CameraText.Location = New System.Drawing.Point(3, 218)
        Me.CameraText.Name = "CameraText"
        Me.CameraText.Size = New System.Drawing.Size(159, 25)
        Me.CameraText.TabIndex = 4
        Me.CameraText.Text = "Interior Camera"
        '
        'StatusText
        '
        Me.StatusText.AutoSize = True
        Me.StatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusText.ForeColor = System.Drawing.Color.Red
        Me.StatusText.Location = New System.Drawing.Point(27, 43)
        Me.StatusText.Name = "StatusText"
        Me.StatusText.Size = New System.Drawing.Size(326, 31)
        Me.StatusText.TabIndex = 5
        Me.StatusText.Text = "Status: Intruder Detected!"
        '
        'ContactRespondersButton
        '
        Me.ContactRespondersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactRespondersButton.ForeColor = System.Drawing.Color.Red
        Me.ContactRespondersButton.Location = New System.Drawing.Point(63, 537)
        Me.ContactRespondersButton.Name = "ContactRespondersButton"
        Me.ContactRespondersButton.Size = New System.Drawing.Size(257, 47)
        Me.ContactRespondersButton.TabIndex = 6
        Me.ContactRespondersButton.Text = "Contact Responders"
        Me.ContactRespondersButton.UseVisualStyleBackColor = True
        '
        'CameraImage
        '
        Me.CameraImage.Image = Global.HomeScreen.My.Resources.Resources.scaryblackman
        Me.CameraImage.Location = New System.Drawing.Point(0, 246)
        Me.CameraImage.Name = "CameraImage"
        Me.CameraImage.Size = New System.Drawing.Size(382, 237)
        Me.CameraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CameraImage.TabIndex = 3
        Me.CameraImage.TabStop = False
        '
        'SecurityScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ContactRespondersButton)
        Me.Controls.Add(Me.StatusText)
        Me.Controls.Add(Me.CameraText)
        Me.Controls.Add(Me.CameraImage)
        Me.Controls.Add(Me.RearButton)
        Me.Controls.Add(Me.FrontButton)
        Me.Controls.Add(Me.InteriorButton)
        Me.Name = "SecurityScreen"
        Me.Size = New System.Drawing.Size(382, 595)
        CType(Me.CameraImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InteriorButton As System.Windows.Forms.Button
    Friend WithEvents FrontButton As System.Windows.Forms.Button
    Friend WithEvents RearButton As System.Windows.Forms.Button
    Friend WithEvents CameraImage As System.Windows.Forms.PictureBox
    Friend WithEvents CameraText As System.Windows.Forms.Label
    Friend WithEvents StatusText As System.Windows.Forms.Label
    Friend WithEvents ContactRespondersButton As System.Windows.Forms.Button

End Class
