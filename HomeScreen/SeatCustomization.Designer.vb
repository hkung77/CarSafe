<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatCustomization
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
        Me.Driver_label = New System.Windows.Forms.Label()
        Me.Passenger_label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Driver_label
        '
        Me.Driver_label.AutoSize = True
        Me.Driver_label.Location = New System.Drawing.Point(54, 183)
        Me.Driver_label.Name = "Driver_label"
        Me.Driver_label.Size = New System.Drawing.Size(35, 13)
        Me.Driver_label.TabIndex = 0
        Me.Driver_label.Text = "Driver"
        '
        'Passenger_label
        '
        Me.Passenger_label.AutoSize = True
        Me.Passenger_label.Location = New System.Drawing.Point(54, 332)
        Me.Passenger_label.Name = "Passenger_label"
        Me.Passenger_label.Size = New System.Drawing.Size(57, 13)
        Me.Passenger_label.TabIndex = 1
        Me.Passenger_label.Text = "Passenger"
        '
        'SeatCustomization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Passenger_label)
        Me.Controls.Add(Me.Driver_label)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SeatCustomization"
        Me.Size = New System.Drawing.Size(382, 569)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Driver_label As System.Windows.Forms.Label
    Friend WithEvents Passenger_label As System.Windows.Forms.Label

End Class
