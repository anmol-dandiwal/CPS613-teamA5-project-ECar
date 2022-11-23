<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatePopUp
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.HourPicker1 = New System.Windows.Forms.ComboBox()
        Me.StartTimeLabel = New System.Windows.Forms.Label()
        Me.MinutePicker1 = New System.Windows.Forms.ComboBox()
        Me.ColonLabel = New System.Windows.Forms.Label()
        Me.AmPmPicker1 = New System.Windows.Forms.ComboBox()
        Me.RepeatLabel = New System.Windows.Forms.Label()
        Me.RepeatPicker = New System.Windows.Forms.ComboBox()
        Me.SetAvailButton = New System.Windows.Forms.Button()
        Me.AmPmPicker2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinutePicker2 = New System.Windows.Forms.ComboBox()
        Me.EndTimeLabel = New System.Windows.Forms.Label()
        Me.HourPicker2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'HourPicker1
        '
        Me.HourPicker1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.HourPicker1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HourPicker1.FormattingEnabled = True
        Me.HourPicker1.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.HourPicker1.Location = New System.Drawing.Point(17, 34)
        Me.HourPicker1.MaxDropDownItems = 4
        Me.HourPicker1.Name = "HourPicker1"
        Me.HourPicker1.Size = New System.Drawing.Size(52, 27)
        Me.HourPicker1.TabIndex = 1
        '
        'StartTimeLabel
        '
        Me.StartTimeLabel.AutoSize = True
        Me.StartTimeLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StartTimeLabel.Location = New System.Drawing.Point(13, 10)
        Me.StartTimeLabel.Name = "StartTimeLabel"
        Me.StartTimeLabel.Size = New System.Drawing.Size(42, 19)
        Me.StartTimeLabel.TabIndex = 2
        Me.StartTimeLabel.Text = "Start"
        '
        'MinutePicker1
        '
        Me.MinutePicker1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MinutePicker1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinutePicker1.FormattingEnabled = True
        Me.MinutePicker1.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.MinutePicker1.Location = New System.Drawing.Point(95, 34)
        Me.MinutePicker1.MaxDropDownItems = 4
        Me.MinutePicker1.Name = "MinutePicker1"
        Me.MinutePicker1.Size = New System.Drawing.Size(52, 27)
        Me.MinutePicker1.TabIndex = 3
        '
        'ColonLabel
        '
        Me.ColonLabel.AutoSize = True
        Me.ColonLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ColonLabel.Location = New System.Drawing.Point(75, 37)
        Me.ColonLabel.Name = "ColonLabel"
        Me.ColonLabel.Size = New System.Drawing.Size(13, 19)
        Me.ColonLabel.TabIndex = 4
        Me.ColonLabel.Text = ":"
        '
        'AmPmPicker1
        '
        Me.AmPmPicker1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AmPmPicker1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmPmPicker1.FormattingEnabled = True
        Me.AmPmPicker1.Items.AddRange(New Object() {"AM", "PM"})
        Me.AmPmPicker1.Location = New System.Drawing.Point(168, 34)
        Me.AmPmPicker1.MaxDropDownItems = 4
        Me.AmPmPicker1.Name = "AmPmPicker1"
        Me.AmPmPicker1.Size = New System.Drawing.Size(52, 27)
        Me.AmPmPicker1.TabIndex = 5
        '
        'RepeatLabel
        '
        Me.RepeatLabel.AutoSize = True
        Me.RepeatLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RepeatLabel.Location = New System.Drawing.Point(13, 131)
        Me.RepeatLabel.Name = "RepeatLabel"
        Me.RepeatLabel.Size = New System.Drawing.Size(59, 19)
        Me.RepeatLabel.TabIndex = 6
        Me.RepeatLabel.Text = "Repeat"
        '
        'RepeatPicker
        '
        Me.RepeatPicker.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RepeatPicker.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RepeatPicker.FormattingEnabled = True
        Me.RepeatPicker.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Never"})
        Me.RepeatPicker.Location = New System.Drawing.Point(17, 153)
        Me.RepeatPicker.MaxDropDownItems = 4
        Me.RepeatPicker.Name = "RepeatPicker"
        Me.RepeatPicker.Size = New System.Drawing.Size(130, 27)
        Me.RepeatPicker.TabIndex = 7
        '
        'SetAvailButton
        '
        Me.SetAvailButton.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SetAvailButton.Location = New System.Drawing.Point(95, 196)
        Me.SetAvailButton.Name = "SetAvailButton"
        Me.SetAvailButton.Size = New System.Drawing.Size(126, 34)
        Me.SetAvailButton.TabIndex = 8
        Me.SetAvailButton.Text = "Set Availability"
        Me.SetAvailButton.UseVisualStyleBackColor = True
        '
        'AmPmPicker2
        '
        Me.AmPmPicker2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AmPmPicker2.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmPmPicker2.FormattingEnabled = True
        Me.AmPmPicker2.Items.AddRange(New Object() {"AM", "PM"})
        Me.AmPmPicker2.Location = New System.Drawing.Point(168, 92)
        Me.AmPmPicker2.MaxDropDownItems = 4
        Me.AmPmPicker2.Name = "AmPmPicker2"
        Me.AmPmPicker2.Size = New System.Drawing.Size(52, 27)
        Me.AmPmPicker2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(75, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = ":"
        '
        'MinutePicker2
        '
        Me.MinutePicker2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MinutePicker2.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinutePicker2.FormattingEnabled = True
        Me.MinutePicker2.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.MinutePicker2.Location = New System.Drawing.Point(95, 92)
        Me.MinutePicker2.MaxDropDownItems = 4
        Me.MinutePicker2.Name = "MinutePicker2"
        Me.MinutePicker2.Size = New System.Drawing.Size(52, 27)
        Me.MinutePicker2.TabIndex = 12
        '
        'EndTimeLabel
        '
        Me.EndTimeLabel.AutoSize = True
        Me.EndTimeLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EndTimeLabel.Location = New System.Drawing.Point(13, 68)
        Me.EndTimeLabel.Name = "EndTimeLabel"
        Me.EndTimeLabel.Size = New System.Drawing.Size(38, 19)
        Me.EndTimeLabel.TabIndex = 11
        Me.EndTimeLabel.Text = "End"
        '
        'HourPicker2
        '
        Me.HourPicker2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.HourPicker2.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HourPicker2.FormattingEnabled = True
        Me.HourPicker2.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.HourPicker2.Location = New System.Drawing.Point(17, 92)
        Me.HourPicker2.MaxDropDownItems = 4
        Me.HourPicker2.Name = "HourPicker2"
        Me.HourPicker2.Size = New System.Drawing.Size(52, 27)
        Me.HourPicker2.TabIndex = 10
        '
        'DatePopUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 240)
        Me.Controls.Add(Me.AmPmPicker2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MinutePicker2)
        Me.Controls.Add(Me.EndTimeLabel)
        Me.Controls.Add(Me.HourPicker2)
        Me.Controls.Add(Me.SetAvailButton)
        Me.Controls.Add(Me.RepeatPicker)
        Me.Controls.Add(Me.RepeatLabel)
        Me.Controls.Add(Me.AmPmPicker1)
        Me.Controls.Add(Me.ColonLabel)
        Me.Controls.Add(Me.MinutePicker1)
        Me.Controls.Add(Me.StartTimeLabel)
        Me.Controls.Add(Me.HourPicker1)
        Me.Name = "DatePopUp"
        Me.Text = "Set Time and Repeat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HourPicker1 As ComboBox
    Friend WithEvents StartTimeLabel As Label
    Friend WithEvents MinutePicker1 As ComboBox
    Friend WithEvents ColonLabel As Label
    Friend WithEvents AmPmPicker1 As ComboBox
    Friend WithEvents RepeatLabel As Label
    Friend WithEvents RepeatPicker As ComboBox
    Friend WithEvents SetAvailButton As Button
    Friend WithEvents AmPmPicker2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MinutePicker2 As ComboBox
    Friend WithEvents EndTimeLabel As Label
    Friend WithEvents HourPicker2 As ComboBox
End Class
