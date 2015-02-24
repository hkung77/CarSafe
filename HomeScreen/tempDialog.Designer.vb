<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tempDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.trackBarTemp = New System.Windows.Forms.TrackBar()
        Me.txtDesiredTemp = New System.Windows.Forms.TextBox()
        Me.lblFanSpeed = New System.Windows.Forms.Label()
        Me.btnDirFeet = New System.Windows.Forms.Button()
        Me.btnDirFaceFeet = New System.Windows.Forms.Button()
        Me.btnDirFace = New System.Windows.Forms.Button()
        Me.btnIntakeOut = New System.Windows.Forms.Button()
        Me.picBoxIntakeOut = New System.Windows.Forms.PictureBox()
        Me.picBoxDirFace = New System.Windows.Forms.PictureBox()
        Me.picBoxDirFaceFeet = New System.Windows.Forms.PictureBox()
        Me.picBoxDirFeet = New System.Windows.Forms.PictureBox()
        Me.btnFanSpeed = New System.Windows.Forms.Button()
        Me.btnIntakeIn = New System.Windows.Forms.Button()
        Me.picBoxIntakeIn = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.trackBarTemp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxIntakeOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDirFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDirFaceFeet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxDirFeet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxIntakeIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(97, 352)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'trackBarTemp
        '
        Me.trackBarTemp.Location = New System.Drawing.Point(3, 32)
        Me.trackBarTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.trackBarTemp.Maximum = 30
        Me.trackBarTemp.Name = "trackBarTemp"
        Me.trackBarTemp.Size = New System.Drawing.Size(330, 45)
        Me.trackBarTemp.TabIndex = 1
        Me.trackBarTemp.Tag = ""
        Me.trackBarTemp.Value = 18
        '
        'txtDesiredTemp
        '
        Me.txtDesiredTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesiredTemp.Location = New System.Drawing.Point(128, 67)
        Me.txtDesiredTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesiredTemp.Name = "txtDesiredTemp"
        Me.txtDesiredTemp.ReadOnly = True
        Me.txtDesiredTemp.Size = New System.Drawing.Size(95, 45)
        Me.txtDesiredTemp.TabIndex = 2
        Me.txtDesiredTemp.Text = "15 ºC"
        '
        'lblFanSpeed
        '
        Me.lblFanSpeed.AutoSize = True
        Me.lblFanSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFanSpeed.Location = New System.Drawing.Point(132, 330)
        Me.lblFanSpeed.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFanSpeed.Name = "lblFanSpeed"
        Me.lblFanSpeed.Size = New System.Drawing.Size(83, 13)
        Me.lblFanSpeed.TabIndex = 6
        Me.lblFanSpeed.Text = "Fan Speed: 0"
        '
        'btnDirFeet
        '
        Me.btnDirFeet.BackgroundImage = Global.HomeScreen.My.Resources.Resources.dirFeet
        Me.btnDirFeet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDirFeet.Location = New System.Drawing.Point(135, 195)
        Me.btnDirFeet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDirFeet.Name = "btnDirFeet"
        Me.btnDirFeet.Size = New System.Drawing.Size(90, 40)
        Me.btnDirFeet.TabIndex = 7
        Me.btnDirFeet.UseVisualStyleBackColor = True
        '
        'btnDirFaceFeet
        '
        Me.btnDirFaceFeet.BackgroundImage = Global.HomeScreen.My.Resources.Resources.dirFaceFeet
        Me.btnDirFaceFeet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDirFaceFeet.Location = New System.Drawing.Point(248, 195)
        Me.btnDirFaceFeet.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDirFaceFeet.Name = "btnDirFaceFeet"
        Me.btnDirFaceFeet.Size = New System.Drawing.Size(90, 40)
        Me.btnDirFaceFeet.TabIndex = 8
        Me.btnDirFaceFeet.UseVisualStyleBackColor = True
        '
        'btnDirFace
        '
        Me.btnDirFace.BackColor = System.Drawing.Color.LightGreen
        Me.btnDirFace.BackgroundImage = Global.HomeScreen.My.Resources.Resources.dirFace
        Me.btnDirFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDirFace.Location = New System.Drawing.Point(19, 196)
        Me.btnDirFace.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDirFace.Name = "btnDirFace"
        Me.btnDirFace.Size = New System.Drawing.Size(90, 40)
        Me.btnDirFace.TabIndex = 9
        Me.btnDirFace.UseVisualStyleBackColor = False
        '
        'btnIntakeOut
        '
        Me.btnIntakeOut.BackgroundImage = Global.HomeScreen.My.Resources.Resources.intakeOut
        Me.btnIntakeOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIntakeOut.Location = New System.Drawing.Point(195, 131)
        Me.btnIntakeOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIntakeOut.Name = "btnIntakeOut"
        Me.btnIntakeOut.Size = New System.Drawing.Size(92, 40)
        Me.btnIntakeOut.TabIndex = 4
        Me.btnIntakeOut.UseVisualStyleBackColor = True
        '
        'picBoxIntakeOut
        '
        Me.picBoxIntakeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxIntakeOut.Location = New System.Drawing.Point(187, 121)
        Me.picBoxIntakeOut.Margin = New System.Windows.Forms.Padding(2)
        Me.picBoxIntakeOut.Name = "picBoxIntakeOut"
        Me.picBoxIntakeOut.Size = New System.Drawing.Size(109, 56)
        Me.picBoxIntakeOut.TabIndex = 15
        Me.picBoxIntakeOut.TabStop = False
        '
        'picBoxDirFace
        '
        Me.picBoxDirFace.BackColor = System.Drawing.Color.LightGreen
        Me.picBoxDirFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxDirFace.Location = New System.Drawing.Point(9, 187)
        Me.picBoxDirFace.Margin = New System.Windows.Forms.Padding(2)
        Me.picBoxDirFace.Name = "picBoxDirFace"
        Me.picBoxDirFace.Size = New System.Drawing.Size(109, 56)
        Me.picBoxDirFace.TabIndex = 14
        Me.picBoxDirFace.TabStop = False
        '
        'picBoxDirFaceFeet
        '
        Me.picBoxDirFaceFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxDirFaceFeet.Location = New System.Drawing.Point(239, 187)
        Me.picBoxDirFaceFeet.Margin = New System.Windows.Forms.Padding(2)
        Me.picBoxDirFaceFeet.Name = "picBoxDirFaceFeet"
        Me.picBoxDirFaceFeet.Size = New System.Drawing.Size(109, 56)
        Me.picBoxDirFaceFeet.TabIndex = 13
        Me.picBoxDirFaceFeet.TabStop = False
        '
        'picBoxDirFeet
        '
        Me.picBoxDirFeet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxDirFeet.Location = New System.Drawing.Point(125, 187)
        Me.picBoxDirFeet.Margin = New System.Windows.Forms.Padding(2)
        Me.picBoxDirFeet.Name = "picBoxDirFeet"
        Me.picBoxDirFeet.Size = New System.Drawing.Size(109, 56)
        Me.picBoxDirFeet.TabIndex = 12
        Me.picBoxDirFeet.TabStop = False
        '
        'btnFanSpeed
        '
        Me.btnFanSpeed.BackgroundImage = Global.HomeScreen.My.Resources.Resources.fan2
        Me.btnFanSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFanSpeed.Location = New System.Drawing.Point(135, 252)
        Me.btnFanSpeed.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFanSpeed.Name = "btnFanSpeed"
        Me.btnFanSpeed.Size = New System.Drawing.Size(74, 67)
        Me.btnFanSpeed.TabIndex = 5
        Me.btnFanSpeed.Text = "Button1"
        Me.btnFanSpeed.UseVisualStyleBackColor = True
        '
        'btnIntakeIn
        '
        Me.btnIntakeIn.BackColor = System.Drawing.Color.LightGreen
        Me.btnIntakeIn.BackgroundImage = Global.HomeScreen.My.Resources.Resources.intakeIn
        Me.btnIntakeIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIntakeIn.Location = New System.Drawing.Point(74, 128)
        Me.btnIntakeIn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIntakeIn.Name = "btnIntakeIn"
        Me.btnIntakeIn.Size = New System.Drawing.Size(90, 40)
        Me.btnIntakeIn.TabIndex = 3
        Me.btnIntakeIn.UseVisualStyleBackColor = False
        '
        'picBoxIntakeIn
        '
        Me.picBoxIntakeIn.BackColor = System.Drawing.Color.LightGreen
        Me.picBoxIntakeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBoxIntakeIn.Location = New System.Drawing.Point(64, 121)
        Me.picBoxIntakeIn.Margin = New System.Windows.Forms.Padding(2)
        Me.picBoxIntakeIn.Name = "picBoxIntakeIn"
        Me.picBoxIntakeIn.Size = New System.Drawing.Size(109, 56)
        Me.picBoxIntakeIn.TabIndex = 10
        Me.picBoxIntakeIn.TabStop = False
        '
        'tempDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(357, 386)
        Me.Controls.Add(Me.btnDirFeet)
        Me.Controls.Add(Me.btnDirFaceFeet)
        Me.Controls.Add(Me.btnDirFace)
        Me.Controls.Add(Me.btnIntakeOut)
        Me.Controls.Add(Me.picBoxIntakeOut)
        Me.Controls.Add(Me.picBoxDirFace)
        Me.Controls.Add(Me.picBoxDirFaceFeet)
        Me.Controls.Add(Me.picBoxDirFeet)
        Me.Controls.Add(Me.lblFanSpeed)
        Me.Controls.Add(Me.btnFanSpeed)
        Me.Controls.Add(Me.btnIntakeIn)
        Me.Controls.Add(Me.txtDesiredTemp)
        Me.Controls.Add(Me.trackBarTemp)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.picBoxIntakeIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tempDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Set Desired Temp"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.trackBarTemp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxIntakeOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDirFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDirFaceFeet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxDirFeet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxIntakeIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents trackBarTemp As System.Windows.Forms.TrackBar
    Friend WithEvents txtDesiredTemp As System.Windows.Forms.TextBox
    Friend WithEvents btnIntakeIn As System.Windows.Forms.Button
    Friend WithEvents btnIntakeOut As System.Windows.Forms.Button
    Friend WithEvents btnFanSpeed As System.Windows.Forms.Button
    Friend WithEvents lblFanSpeed As System.Windows.Forms.Label
    Friend WithEvents btnDirFeet As System.Windows.Forms.Button
    Friend WithEvents btnDirFaceFeet As System.Windows.Forms.Button
    Friend WithEvents btnDirFace As System.Windows.Forms.Button
    Friend WithEvents picBoxIntakeIn As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxDirFeet As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxDirFaceFeet As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxDirFace As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxIntakeOut As System.Windows.Forms.PictureBox

End Class
