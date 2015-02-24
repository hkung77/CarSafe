<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigation
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
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.StartLabel = New System.Windows.Forms.Label()
        Me.Start_TextBox = New System.Windows.Forms.TextBox()
        Me.Destination_TextBox = New System.Windows.Forms.TextBox()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Ryerson = New System.Windows.Forms.PictureBox()
        Me.Map = New System.Windows.Forms.PictureBox()
        CType(Me.Ryerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Map, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DestinationLabel.Location = New System.Drawing.Point(48, 95)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(87, 17)
        Me.DestinationLabel.TabIndex = 0
        Me.DestinationLabel.Text = "Destination :"
        '
        'StartLabel
        '
        Me.StartLabel.AutoSize = True
        Me.StartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartLabel.Location = New System.Drawing.Point(48, 40)
        Me.StartLabel.Name = "StartLabel"
        Me.StartLabel.Size = New System.Drawing.Size(46, 17)
        Me.StartLabel.TabIndex = 1
        Me.StartLabel.Text = "Start :"
        '
        'Start_TextBox
        '
        Me.Start_TextBox.Location = New System.Drawing.Point(51, 60)
        Me.Start_TextBox.Name = "Start_TextBox"
        Me.Start_TextBox.Size = New System.Drawing.Size(260, 20)
        Me.Start_TextBox.TabIndex = 2
        '
        'Destination_TextBox
        '
        Me.Destination_TextBox.Location = New System.Drawing.Point(51, 115)
        Me.Destination_TextBox.Name = "Destination_TextBox"
        Me.Destination_TextBox.Size = New System.Drawing.Size(260, 20)
        Me.Destination_TextBox.TabIndex = 3
        '
        'OK_Button
        '
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(286, 557)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = True
        '
        'Ryerson
        '
        Me.Ryerson.BackgroundImage = Global.HomeScreen.My.Resources.Resources.Ryerson
        Me.Ryerson.Location = New System.Drawing.Point(0, 152)
        Me.Ryerson.Name = "Ryerson"
        Me.Ryerson.Size = New System.Drawing.Size(382, 377)
        Me.Ryerson.TabIndex = 7
        Me.Ryerson.TabStop = False
        '
        'Map
        '
        Me.Map.Image = Global.HomeScreen.My.Resources.Resources.Nav_Map
        Me.Map.Location = New System.Drawing.Point(0, 152)
        Me.Map.Name = "Map"
        Me.Map.Size = New System.Drawing.Size(385, 377)
        Me.Map.TabIndex = 6
        Me.Map.TabStop = False
        Me.Map.Visible = False
        '
        'Navigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Map)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Destination_TextBox)
        Me.Controls.Add(Me.Start_TextBox)
        Me.Controls.Add(Me.StartLabel)
        Me.Controls.Add(Me.DestinationLabel)
        Me.Controls.Add(Me.Ryerson)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Navigation"
        Me.Size = New System.Drawing.Size(382, 586)
        CType(Me.Ryerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Map, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DestinationLabel As System.Windows.Forms.Label
    Friend WithEvents StartLabel As System.Windows.Forms.Label
    Friend WithEvents Start_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Destination_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Map As System.Windows.Forms.PictureBox
    Friend WithEvents Ryerson As System.Windows.Forms.PictureBox

End Class
