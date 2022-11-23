<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookARidePage
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
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.ScheduleNowButton = New System.Windows.Forms.RadioButton()
        Me.ScheduleLaterButton = New System.Windows.Forms.RadioButton()
        Me.FromAddressInput = New System.Windows.Forms.TextBox()
        Me.DestinationAddressInput = New System.Windows.Forms.TextBox()
        Me.DatePickerInput = New System.Windows.Forms.DateTimePicker()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FromLabel.Location = New System.Drawing.Point(12, 77)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(50, 20)
        Me.FromLabel.TabIndex = 0
        Me.FromLabel.Text = "From:"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DestinationLabel.Location = New System.Drawing.Point(12, 107)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(94, 20)
        Me.DestinationLabel.TabIndex = 1
        Me.DestinationLabel.Text = "Destination:"
        '
        'ScheduleNowButton
        '
        Me.ScheduleNowButton.AutoSize = True
        Me.ScheduleNowButton.Location = New System.Drawing.Point(62, 16)
        Me.ScheduleNowButton.Name = "ScheduleNowButton"
        Me.ScheduleNowButton.Size = New System.Drawing.Size(101, 19)
        Me.ScheduleNowButton.TabIndex = 2
        Me.ScheduleNowButton.Text = "Schedule Now"
        Me.ScheduleNowButton.UseVisualStyleBackColor = True
        '
        'ScheduleLaterButton
        '
        Me.ScheduleLaterButton.AutoSize = True
        Me.ScheduleLaterButton.Location = New System.Drawing.Point(200, 16)
        Me.ScheduleLaterButton.Name = "ScheduleLaterButton"
        Me.ScheduleLaterButton.Size = New System.Drawing.Size(102, 19)
        Me.ScheduleLaterButton.TabIndex = 3
        Me.ScheduleLaterButton.Text = "Schedule Later"
        Me.ScheduleLaterButton.UseVisualStyleBackColor = True
        '
        'FromAddressInput
        '
        Me.FromAddressInput.Location = New System.Drawing.Point(68, 75)
        Me.FromAddressInput.Name = "FromAddressInput"
        Me.FromAddressInput.Size = New System.Drawing.Size(281, 23)
        Me.FromAddressInput.TabIndex = 4
        '
        'DestinationAddressInput
        '
        Me.DestinationAddressInput.Location = New System.Drawing.Point(111, 107)
        Me.DestinationAddressInput.Name = "DestinationAddressInput"
        Me.DestinationAddressInput.Size = New System.Drawing.Size(237, 23)
        Me.DestinationAddressInput.TabIndex = 5
        '
        'DatePickerInput
        '
        Me.DatePickerInput.Location = New System.Drawing.Point(15, 151)
        Me.DatePickerInput.Name = "DatePickerInput"
        Me.DatePickerInput.Size = New System.Drawing.Size(336, 23)
        Me.DatePickerInput.TabIndex = 6
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ConfirmButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ConfirmButton.Location = New System.Drawing.Point(187, 196)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(166, 45)
        Me.ConfirmButton.TabIndex = 7
        Me.ConfirmButton.Text = "Confirm Ride"
        Me.ConfirmButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelButton.Location = New System.Drawing.Point(15, 196)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(166, 45)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel "
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'BookARidePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.DatePickerInput)
        Me.Controls.Add(Me.DestinationAddressInput)
        Me.Controls.Add(Me.FromAddressInput)
        Me.Controls.Add(Me.ScheduleLaterButton)
        Me.Controls.Add(Me.ScheduleNowButton)
        Me.Controls.Add(Me.DestinationLabel)
        Me.Controls.Add(Me.FromLabel)
        Me.Name = "BookARidePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookARidePage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FromLabel As Label
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents ScheduleNowButton As RadioButton
    Friend WithEvents ScheduleLaterButton As RadioButton
    Friend WithEvents FromAddressInput As TextBox
    Friend WithEvents DestinationAddressInput As TextBox
    Friend WithEvents DatePickerInput As DateTimePicker
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CancelButton As Button
End Class
