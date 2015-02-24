<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entertainment
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
        Me.Radio = New System.Windows.Forms.RadioButton()
        Me.AUX = New System.Windows.Forms.RadioButton()
        Me.BlueTooth = New System.Windows.Forms.RadioButton()
        Me.Search_Label = New System.Windows.Forms.Label()
        Me.Volume = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Volume_Label = New System.Windows.Forms.Label()
        Me.player = New System.Windows.Forms.PictureBox()
        Me.Channel_Label = New System.Windows.Forms.Label()
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Radio
        '
        Me.Radio.AutoSize = True
        Me.Radio.Location = New System.Drawing.Point(52, 31)
        Me.Radio.Name = "Radio"
        Me.Radio.Size = New System.Drawing.Size(53, 17)
        Me.Radio.TabIndex = 0
        Me.Radio.TabStop = True
        Me.Radio.Text = "Radio"
        Me.Radio.UseVisualStyleBackColor = True
        '
        'AUX
        '
        Me.AUX.AutoSize = True
        Me.AUX.Location = New System.Drawing.Point(161, 31)
        Me.AUX.Name = "AUX"
        Me.AUX.Size = New System.Drawing.Size(47, 17)
        Me.AUX.TabIndex = 1
        Me.AUX.TabStop = True
        Me.AUX.Text = "AUX"
        Me.AUX.UseVisualStyleBackColor = True
        '
        'BlueTooth
        '
        Me.BlueTooth.AutoSize = True
        Me.BlueTooth.Location = New System.Drawing.Point(266, 31)
        Me.BlueTooth.Name = "BlueTooth"
        Me.BlueTooth.Size = New System.Drawing.Size(74, 17)
        Me.BlueTooth.TabIndex = 2
        Me.BlueTooth.TabStop = True
        Me.BlueTooth.Text = "BlueTooth"
        Me.BlueTooth.UseVisualStyleBackColor = True
        '
        'Search_Label
        '
        Me.Search_Label.AutoSize = True
        Me.Search_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Label.Location = New System.Drawing.Point(129, 453)
        Me.Search_Label.Name = "Search_Label"
        Me.Search_Label.Size = New System.Drawing.Size(134, 26)
        Me.Search_Label.TabIndex = 4
        Me.Search_Label.Text = "Searching ..."
        Me.Search_Label.Visible = False
        '
        'Volume
        '
        Me.Volume.BackgroundImage = Global.HomeScreen.My.Resources.Resources.vol75
        Me.Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Volume.Location = New System.Drawing.Point(89, 263)
        Me.Volume.Name = "Volume"
        Me.Volume.Size = New System.Drawing.Size(214, 159)
        Me.Volume.TabIndex = 5
        Me.Volume.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.HomeScreen.My.Resources.Resources.EQ
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(252, 497)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 50)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Volume_Label
        '
        Me.Volume_Label.AutoSize = True
        Me.Volume_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Volume_Label.Location = New System.Drawing.Point(86, 279)
        Me.Volume_Label.Name = "Volume_Label"
        Me.Volume_Label.Size = New System.Drawing.Size(55, 17)
        Me.Volume_Label.TabIndex = 6
        Me.Volume_Label.Text = "Volume"
        '
        'player
        '
        Me.player.BackgroundImage = Global.HomeScreen.My.Resources.Resources.mediaplayer
        Me.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.player.Location = New System.Drawing.Point(38, 428)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(302, 63)
        Me.player.TabIndex = 7
        Me.player.TabStop = False
        Me.player.Visible = False
        '
        'Channel_Label
        '
        Me.Channel_Label.AutoSize = True
        Me.Channel_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Channel_Label.Location = New System.Drawing.Point(154, 126)
        Me.Channel_Label.Name = "Channel_Label"
        Me.Channel_Label.Size = New System.Drawing.Size(80, 37)
        Me.Channel_Label.TabIndex = 8
        Me.Channel_Label.Text = "99.9"
        Me.Channel_Label.Visible = False
        '
        'Entertainment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Channel_Label)
        Me.Controls.Add(Me.Volume_Label)
        Me.Controls.Add(Me.Volume)
        Me.Controls.Add(Me.Search_Label)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BlueTooth)
        Me.Controls.Add(Me.AUX)
        Me.Controls.Add(Me.Radio)
        Me.Controls.Add(Me.player)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Entertainment"
        Me.Size = New System.Drawing.Size(382, 569)
        CType(Me.Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Radio As System.Windows.Forms.RadioButton
    Friend WithEvents AUX As System.Windows.Forms.RadioButton
    Friend WithEvents BlueTooth As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Search_Label As System.Windows.Forms.Label
    Friend WithEvents Volume As System.Windows.Forms.PictureBox
    Friend WithEvents Volume_Label As System.Windows.Forms.Label
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents Channel_Label As System.Windows.Forms.Label

End Class
