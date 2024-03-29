﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.UserIcon = New System.Windows.Forms.PictureBox()
        Me.CarPicture = New System.Windows.Forms.PictureBox()
        Me.ScheduleButton = New System.Windows.Forms.Button()
        Me.TripHistoryButton = New System.Windows.Forms.Button()
        Me.BatteryLabel = New System.Windows.Forms.Label()
        Me.BatteryIcon = New System.Windows.Forms.PictureBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.CurrLocationLabel = New System.Windows.Forms.Label()
        Me.CalendarIcon = New System.Windows.Forms.PictureBox()
        Me.HistoryIcon = New System.Windows.Forms.PictureBox()
        Me.SwapIcon = New System.Windows.Forms.PictureBox()
        Me.RiderLabel = New System.Windows.Forms.Label()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.IntrusionAlertPopUp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TripStatusButton = New System.Windows.Forms.Button()
        Me.TripStatusCarPicture = New System.Windows.Forms.PictureBox()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalendarIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntrusionAlertPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TripStatusCarPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIcon
        '
        Me.UserIcon.Image = Global.ECarApp.My.Resources.Resources.settingUser
        Me.UserIcon.Location = New System.Drawing.Point(9, 8)
        Me.UserIcon.Margin = New System.Windows.Forms.Padding(6)
        Me.UserIcon.Name = "UserIcon"
        Me.UserIcon.Size = New System.Drawing.Size(46, 46)
        Me.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserIcon.TabIndex = 0
        Me.UserIcon.TabStop = False
        '
        'CarPicture
        '
        Me.CarPicture.Image = Global.ECarApp.My.Resources.Resources.Car
        Me.CarPicture.Location = New System.Drawing.Point(27, 134)
        Me.CarPicture.Margin = New System.Windows.Forms.Padding(6)
        Me.CarPicture.Name = "CarPicture"
        Me.CarPicture.Size = New System.Drawing.Size(322, 211)
        Me.CarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarPicture.TabIndex = 1
        Me.CarPicture.TabStop = False
        '
        'ScheduleButton
        '
        Me.ScheduleButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScheduleButton.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ScheduleButton.Location = New System.Drawing.Point(27, 454)
        Me.ScheduleButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ScheduleButton.Name = "ScheduleButton"
        Me.ScheduleButton.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.ScheduleButton.Size = New System.Drawing.Size(325, 88)
        Me.ScheduleButton.TabIndex = 2
        Me.ScheduleButton.Text = "Schedule"
        Me.ScheduleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ScheduleButton.UseVisualStyleBackColor = False
        '
        'TripHistoryButton
        '
        Me.TripHistoryButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TripHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TripHistoryButton.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TripHistoryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TripHistoryButton.Location = New System.Drawing.Point(27, 554)
        Me.TripHistoryButton.Margin = New System.Windows.Forms.Padding(6)
        Me.TripHistoryButton.Name = "TripHistoryButton"
        Me.TripHistoryButton.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.TripHistoryButton.Size = New System.Drawing.Size(325, 88)
        Me.TripHistoryButton.TabIndex = 3
        Me.TripHistoryButton.Text = "Trip History"
        Me.TripHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TripHistoryButton.UseVisualStyleBackColor = False
        '
        'BatteryLabel
        '
        Me.BatteryLabel.AutoSize = True
        Me.BatteryLabel.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BatteryLabel.Location = New System.Drawing.Point(79, 76)
        Me.BatteryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BatteryLabel.Name = "BatteryLabel"
        Me.BatteryLabel.Size = New System.Drawing.Size(71, 32)
        Me.BatteryLabel.TabIndex = 6
        Me.BatteryLabel.Text = "78%"
        '
        'BatteryIcon
        '
        Me.BatteryIcon.Image = Global.ECarApp.My.Resources.Resources.BatteryIcon
        Me.BatteryIcon.Location = New System.Drawing.Point(36, 71)
        Me.BatteryIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.BatteryIcon.Name = "BatteryIcon"
        Me.BatteryIcon.Size = New System.Drawing.Size(51, 42)
        Me.BatteryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BatteryIcon.TabIndex = 7
        Me.BatteryIcon.TabStop = False
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusLabel.Location = New System.Drawing.Point(209, 76)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(131, 32)
        Me.StatusLabel.TabIndex = 8
        Me.StatusLabel.Text = "Available"
        '
        'CurrLocationLabel
        '
        Me.CurrLocationLabel.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CurrLocationLabel.Location = New System.Drawing.Point(12, 368)
        Me.CurrLocationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CurrLocationLabel.Name = "CurrLocationLabel"
        Me.CurrLocationLabel.Size = New System.Drawing.Size(356, 80)
        Me.CurrLocationLabel.TabIndex = 9
        Me.CurrLocationLabel.Text = "Near 250 Bremner Blvd Toronto, ON"
        Me.CurrLocationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CalendarIcon
        '
        Me.CalendarIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CalendarIcon.Image = CType(resources.GetObject("CalendarIcon.Image"), System.Drawing.Image)
        Me.CalendarIcon.Location = New System.Drawing.Point(251, 469)
        Me.CalendarIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.CalendarIcon.Name = "CalendarIcon"
        Me.CalendarIcon.Size = New System.Drawing.Size(54, 54)
        Me.CalendarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CalendarIcon.TabIndex = 10
        Me.CalendarIcon.TabStop = False
        '
        'HistoryIcon
        '
        Me.HistoryIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.HistoryIcon.Image = CType(resources.GetObject("HistoryIcon.Image"), System.Drawing.Image)
        Me.HistoryIcon.Location = New System.Drawing.Point(251, 572)
        Me.HistoryIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.HistoryIcon.Name = "HistoryIcon"
        Me.HistoryIcon.Size = New System.Drawing.Size(54, 54)
        Me.HistoryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HistoryIcon.TabIndex = 11
        Me.HistoryIcon.TabStop = False
        '
        'SwapIcon
        '
        Me.SwapIcon.Image = Global.ECarApp.My.Resources.Resources.SwapIcon
        Me.SwapIcon.Location = New System.Drawing.Point(179, 17)
        Me.SwapIcon.Name = "SwapIcon"
        Me.SwapIcon.Size = New System.Drawing.Size(34, 31)
        Me.SwapIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SwapIcon.TabIndex = 15
        Me.SwapIcon.TabStop = False
        '
        'RiderLabel
        '
        Me.RiderLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RiderLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RiderLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RiderLabel.Location = New System.Drawing.Point(224, 18)
        Me.RiderLabel.Name = "RiderLabel"
        Me.RiderLabel.Size = New System.Drawing.Size(86, 27)
        Me.RiderLabel.TabIndex = 14
        Me.RiderLabel.Text = "Rider"
        Me.RiderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OwnerLabel
        '
        Me.OwnerLabel.AutoSize = True
        Me.OwnerLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.OwnerLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OwnerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OwnerLabel.Location = New System.Drawing.Point(81, 18)
        Me.OwnerLabel.Name = "OwnerLabel"
        Me.OwnerLabel.Size = New System.Drawing.Size(86, 27)
        Me.OwnerLabel.TabIndex = 13
        Me.OwnerLabel.Text = "Owner"
        '
        'IntrusionAlertPopUp
        '
        Me.IntrusionAlertPopUp.ContainerControl = Me
        '
        'TripStatusButton
        '
        Me.TripStatusButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TripStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TripStatusButton.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TripStatusButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TripStatusButton.Location = New System.Drawing.Point(27, 354)
        Me.TripStatusButton.Margin = New System.Windows.Forms.Padding(6)
        Me.TripStatusButton.Name = "TripStatusButton"
        Me.TripStatusButton.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.TripStatusButton.Size = New System.Drawing.Size(325, 88)
        Me.TripStatusButton.TabIndex = 16
        Me.TripStatusButton.Text = "Trip Status"
        Me.TripStatusButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TripStatusButton.UseVisualStyleBackColor = False
        '
        'TripStatusCarPicture
        '
        Me.TripStatusCarPicture.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TripStatusCarPicture.Image = Global.ECarApp.My.Resources.Resources.bookCarIcon
        Me.TripStatusCarPicture.Location = New System.Drawing.Point(251, 368)
        Me.TripStatusCarPicture.Name = "TripStatusCarPicture"
        Me.TripStatusCarPicture.Size = New System.Drawing.Size(60, 61)
        Me.TripStatusCarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TripStatusCarPicture.TabIndex = 17
        Me.TripStatusCarPicture.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.TripStatusCarPicture)
        Me.Controls.Add(Me.TripStatusButton)
        Me.Controls.Add(Me.SwapIcon)
        Me.Controls.Add(Me.RiderLabel)
        Me.Controls.Add(Me.OwnerLabel)
        Me.Controls.Add(Me.HistoryIcon)
        Me.Controls.Add(Me.CalendarIcon)
        Me.Controls.Add(Me.CurrLocationLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.BatteryIcon)
        Me.Controls.Add(Me.BatteryLabel)
        Me.Controls.Add(Me.TripHistoryButton)
        Me.Controls.Add(Me.ScheduleButton)
        Me.Controls.Add(Me.CarPicture)
        Me.Controls.Add(Me.UserIcon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Location"
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalendarIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntrusionAlertPopUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TripStatusCarPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserIcon As PictureBox
    Friend WithEvents CarPicture As PictureBox
    Friend WithEvents ScheduleButton As Button
    Friend WithEvents TripHistoryButton As Button
    Friend WithEvents BatteryLabel As Label
    Friend WithEvents BatteryIcon As PictureBox
    Friend WithEvents StatusLabel As Label
    Friend WithEvents CurrLocationLabel As Label
    Friend WithEvents CalendarIcon As PictureBox
    Friend WithEvents HistoryIcon As PictureBox
    Friend WithEvents SwapIcon As PictureBox
    Friend WithEvents RiderLabel As Label
    Friend WithEvents OwnerLabel As Label
    Friend WithEvents IntrusionAlertPopUp As ErrorProvider
    Friend WithEvents TripStatusCarPicture As PictureBox
    Friend WithEvents TripStatusButton As Button
End Class
