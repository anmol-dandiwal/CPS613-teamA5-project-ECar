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
        Me.FromLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FromLabel.Location = New System.Drawing.Point(10, 72)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(51, 19)
        Me.FromLabel.TabIndex = 0
        Me.FromLabel.Text = "From:"
        '
        'DestinationLabel
        '
        Me.DestinationLabel.AutoSize = True
        Me.DestinationLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DestinationLabel.Location = New System.Drawing.Point(10, 100)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(96, 19)
        Me.DestinationLabel.TabIndex = 1
        Me.DestinationLabel.Text = "Destination:"
        '
        'ScheduleNowButton
        '
        Me.ScheduleNowButton.AutoSize = True
        Me.ScheduleNowButton.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleNowButton.Location = New System.Drawing.Point(13, 21)
        Me.ScheduleNowButton.Name = "ScheduleNowButton"
        Me.ScheduleNowButton.Size = New System.Drawing.Size(133, 23)
        Me.ScheduleNowButton.TabIndex = 2
        Me.ScheduleNowButton.Text = "Schedule Now"
        Me.ScheduleNowButton.UseVisualStyleBackColor = True
        '
        'ScheduleLaterButton
        '
        Me.ScheduleLaterButton.AutoSize = True
        Me.ScheduleLaterButton.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleLaterButton.Location = New System.Drawing.Point(178, 21)
        Me.ScheduleLaterButton.Name = "ScheduleLaterButton"
        Me.ScheduleLaterButton.Size = New System.Drawing.Size(136, 23)
        Me.ScheduleLaterButton.TabIndex = 3
        Me.ScheduleLaterButton.Text = "Schedule Later"
        Me.ScheduleLaterButton.UseVisualStyleBackColor = True
        '
        'FromAddressInput
        '
        Me.FromAddressInput.Location = New System.Drawing.Point(59, 71)
        Me.FromAddressInput.Name = "FromAddressInput"
        Me.FromAddressInput.Size = New System.Drawing.Size(255, 20)
        Me.FromAddressInput.TabIndex = 4
        '
        'DestinationAddressInput
        '
        Me.DestinationAddressInput.Location = New System.Drawing.Point(103, 101)
        Me.DestinationAddressInput.Name = "DestinationAddressInput"
        Me.DestinationAddressInput.Size = New System.Drawing.Size(211, 20)
        Me.DestinationAddressInput.TabIndex = 5
        '
        'DatePickerInput
        '
        Me.DatePickerInput.Location = New System.Drawing.Point(13, 141)
        Me.DatePickerInput.Name = "DatePickerInput"
        Me.DatePickerInput.Size = New System.Drawing.Size(289, 20)
        Me.DatePickerInput.TabIndex = 6
        '
        'ConfirmButton
        '
        Me.ConfirmButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ConfirmButton.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ConfirmButton.Location = New System.Drawing.Point(160, 183)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(142, 42)
        Me.ConfirmButton.TabIndex = 7
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CancelButton.FlatAppearance.BorderSize = 0
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelButton.Location = New System.Drawing.Point(13, 183)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(142, 42)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel "
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'BookARidePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 619)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.DatePickerInput)
        Me.Controls.Add(Me.DestinationAddressInput)
        Me.Controls.Add(Me.FromAddressInput)
        Me.Controls.Add(Me.ScheduleLaterButton)
        Me.Controls.Add(Me.ScheduleNowButton)
        Me.Controls.Add(Me.DestinationLabel)
        Me.Controls.Add(Me.FromLabel)
        Me.Font = New System.Drawing.Font("Eras Medium ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
