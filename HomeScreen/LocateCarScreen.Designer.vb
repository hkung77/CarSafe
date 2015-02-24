<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocateCarScreen
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
        Me.pnlLabel = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlCarLocationMap = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.record_box = New System.Windows.Forms.PictureBox()
        Me.pnlLabel.SuspendLayout()
        Me.pnlCarLocationMap.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.record_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLabel
        '
        Me.pnlLabel.BackColor = System.Drawing.Color.Chartreuse
        Me.pnlLabel.Controls.Add(Me.lblTitle)
        Me.pnlLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLabel.Location = New System.Drawing.Point(0, 0)
        Me.pnlLabel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlLabel.Name = "pnlLabel"
        Me.pnlLabel.Size = New System.Drawing.Size(382, 81)
        Me.pnlLabel.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(81, 23)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Location of Car"
        '
        'pnlCarLocationMap
        '
        Me.pnlCarLocationMap.Controls.Add(Me.record_box)
        Me.pnlCarLocationMap.Controls.Add(Me.PictureBox1)
        Me.pnlCarLocationMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCarLocationMap.Location = New System.Drawing.Point(0, 81)
        Me.pnlCarLocationMap.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlCarLocationMap.Name = "pnlCarLocationMap"
        Me.pnlCarLocationMap.Size = New System.Drawing.Size(382, 488)
        Me.pnlCarLocationMap.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.HomeScreen.My.Resources.Resources.LocateCar
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 488)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'record_box
        '
        Me.record_box.BackgroundImage = Global.HomeScreen.My.Resources.Resources.record
        Me.record_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.record_box.Location = New System.Drawing.Point(147, 410)
        Me.record_box.Name = "record_box"
        Me.record_box.Size = New System.Drawing.Size(83, 75)
        Me.record_box.TabIndex = 1
        Me.record_box.TabStop = False
        '
        'LocateCarScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlCarLocationMap)
        Me.Controls.Add(Me.pnlLabel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LocateCarScreen"
        Me.Size = New System.Drawing.Size(382, 569)
        Me.pnlLabel.ResumeLayout(False)
        Me.pnlLabel.PerformLayout()
        Me.pnlCarLocationMap.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.record_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlLabel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlCarLocationMap As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents record_box As System.Windows.Forms.PictureBox

End Class
