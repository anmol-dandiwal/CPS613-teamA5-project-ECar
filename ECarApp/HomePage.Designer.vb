<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ScheduleButton = New System.Windows.Forms.Button()
        Me.pastTripButton = New System.Windows.Forms.Button()
        Me.MapButton = New System.Windows.Forms.Button()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.BatteryIcon = New System.Windows.Forms.PictureBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.CurrLocationLabel = New System.Windows.Forms.Label()
        Me.CalendarIcon = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECarApp.My.Resources.Resources.settingUser
        Me.PictureBox1.Location = New System.Drawing.Point(25, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ECarApp.My.Resources.Resources._2022_audi_e_tron_gt_premium_plus_4wd_sedan_angular_front
        Me.PictureBox2.Location = New System.Drawing.Point(46, 236)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(645, 422)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'ScheduleButton
        '
        Me.ScheduleButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ScheduleButton.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ScheduleButton.Location = New System.Drawing.Point(46, 840)
        Me.ScheduleButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ScheduleButton.Name = "ScheduleButton"
        Me.ScheduleButton.Padding = New System.Windows.Forms.Padding(75, 0, 0, 0)
        Me.ScheduleButton.Size = New System.Drawing.Size(650, 197)
        Me.ScheduleButton.TabIndex = 2
        Me.ScheduleButton.Text = "Schedule"
        Me.ScheduleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ScheduleButton.UseVisualStyleBackColor = False
        '
        'pastTripButton
        '
        Me.pastTripButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pastTripButton.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pastTripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pastTripButton.Location = New System.Drawing.Point(46, 1063)
        Me.pastTripButton.Margin = New System.Windows.Forms.Padding(6)
        Me.pastTripButton.Name = "pastTripButton"
        Me.pastTripButton.Padding = New System.Windows.Forms.Padding(75, 0, 0, 0)
        Me.pastTripButton.Size = New System.Drawing.Size(645, 197)
        Me.pastTripButton.TabIndex = 3
        Me.pastTripButton.Text = "Trip History"
        Me.pastTripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pastTripButton.UseVisualStyleBackColor = False
        '
        'MapButton
        '
        Me.MapButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MapButton.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MapButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MapButton.Location = New System.Drawing.Point(46, 1283)
        Me.MapButton.Margin = New System.Windows.Forms.Padding(6)
        Me.MapButton.Name = "MapButton"
        Me.MapButton.Padding = New System.Windows.Forms.Padding(75, 0, 0, 0)
        Me.MapButton.Size = New System.Drawing.Size(645, 197)
        Me.MapButton.TabIndex = 5
        Me.MapButton.Text = "Map"
        Me.MapButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MapButton.UseVisualStyleBackColor = False
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.Font = New System.Drawing.Font("Eras Medium ITC", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BatteryLabel.Location = New System.Drawing.Point(178, 144)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(144, 68)
        Me.BatteryLabel.TabIndex = 6
        Me.BatteryLabel.Text = "78%"
        '
        'BatteryIcon
        '
        Me.BatteryIcon.Image = Global.ECarApp.My.Resources.Resources.full_battery
        Me.BatteryIcon.Location = New System.Drawing.Point(90, 138)
        Me.BatteryIcon.Name = "BatteryIcon"
        Me.BatteryIcon.Size = New System.Drawing.Size(102, 84)
        Me.BatteryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BatteryIcon.TabIndex = 7
        Me.BatteryIcon.TabStop = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Eras Medium ITC", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusLabel.Location = New System.Drawing.Point(388, 144)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(266, 68)
        Me.StatusLabel.TabIndex = 8
        Me.StatusLabel.Text = "Available"
        '
        'CurrLocationLabel
        '
        Me.CurrLocationLabel.Font = New System.Drawing.Font("Eras Medium ITC", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CurrLocationLabel.Location = New System.Drawing.Point(12, 664)
        Me.CurrLocationLabel.Name = "CurrLocationLabel"
        Me.CurrLocationLabel.Size = New System.Drawing.Size(713, 136)
        Me.CurrLocationLabel.TabIndex = 9
        Me.CurrLocationLabel.Text = "Near 250 Bremner Blvd Toronto, ON"
        Me.CurrLocationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CalendarIcon
        '
        Me.CalendarIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalendarIcon.Image = CType(resources.GetObject("CalendarIcon.Image"), System.Drawing.Image)
        Me.CalendarIcon.Location = New System.Drawing.Point(473, 879)
        Me.CalendarIcon.Name = "CalendarIcon"
        Me.CalendarIcon.Size = New System.Drawing.Size(107, 110)
        Me.CalendarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CalendarIcon.TabIndex = 10
        Me.CalendarIcon.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(473, 1110)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(107, 110)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox5.Image = Global.ECarApp.My.Resources.Resources.map_command_comments_map_icon_11562897555gcydeuswdx
        Me.PictureBox5.Location = New System.Drawing.Point(473, 1330)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(108, 95)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(740, 1529)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.CalendarIcon)
        Me.Controls.Add(Me.CurrLocationLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.BatteryIcon)
        Me.Controls.Add(Me.BatteryLabel)
        Me.Controls.Add(Me.MapButton)
        Me.Controls.Add(Me.pastTripButton)
        Me.Controls.Add(Me.ScheduleButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ScheduleButton As Button
    Friend WithEvents pastTripButton As Button
    Friend WithEvents MapButton As Button
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents BatteryIcon As PictureBox
    Friend WithEvents StatusLabel As Label
    Friend WithEvents CurrLocationLabel As Label
    Friend WithEvents CalendarIcon As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
