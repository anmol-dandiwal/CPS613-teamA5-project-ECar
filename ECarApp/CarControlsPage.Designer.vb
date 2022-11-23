<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CarControlsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarControlsPage))
        Me.CarControlsLabel = New System.Windows.Forms.Label()
        Me.BackIcon = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.OutsideTempLabel = New System.Windows.Forms.Label()
        Me.IntakeTempLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WindowsLabel = New System.Windows.Forms.Label()
        Me.TrunkLabel = New System.Windows.Forms.Label()
        Me.Temp = New System.Windows.Forms.Label()
        Me.LowerTempIcon = New System.Windows.Forms.PictureBox()
        Me.IncreaseTempIcon = New System.Windows.Forms.PictureBox()
        Me.FanSpeedDown = New System.Windows.Forms.PictureBox()
        Me.FanSpeedUp = New System.Windows.Forms.PictureBox()
        Me.FanSpeed = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.windowsBtn = New System.Windows.Forms.Button()
        Me.TrunkBtn = New System.Windows.Forms.Button()
        Me.HeatedSeatsLabel = New System.Windows.Forms.Label()
        Me.HeatedSeatsBtn = New System.Windows.Forms.Button()
        Me.DefrostLabel = New System.Windows.Forms.Label()
        Me.DefrostBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LowerTempIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncreaseTempIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanSpeedDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FanSpeedUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarControlsLabel
        '
        Me.CarControlsLabel.AutoSize = True
        Me.CarControlsLabel.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CarControlsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CarControlsLabel.Location = New System.Drawing.Point(103, 26)
        Me.CarControlsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CarControlsLabel.Name = "CarControlsLabel"
        Me.CarControlsLabel.Size = New System.Drawing.Size(171, 32)
        Me.CarControlsLabel.TabIndex = 13
        Me.CarControlsLabel.Text = "Car Controls"
        '
        'BackIcon
        '
        Me.BackIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackIcon.Image = CType(resources.GetObject("BackIcon.Image"), System.Drawing.Image)
        Me.BackIcon.Location = New System.Drawing.Point(35, 25)
        Me.BackIcon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackIcon.Name = "BackIcon"
        Me.BackIcon.Size = New System.Drawing.Size(33, 35)
        Me.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackIcon.TabIndex = 11
        Me.BackIcon.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(27, 24)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(49, 38)
        Me.BackButton.TabIndex = 12
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'OutsideTempLabel
        '
        Me.OutsideTempLabel.AutoSize = True
        Me.OutsideTempLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OutsideTempLabel.Location = New System.Drawing.Point(27, 93)
        Me.OutsideTempLabel.Name = "OutsideTempLabel"
        Me.OutsideTempLabel.Size = New System.Drawing.Size(215, 19)
        Me.OutsideTempLabel.TabIndex = 14
        Me.OutsideTempLabel.Text = "Outside Temperature: 5 º"
        Me.OutsideTempLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IntakeTempLabel
        '
        Me.IntakeTempLabel.AutoSize = True
        Me.IntakeTempLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IntakeTempLabel.Location = New System.Drawing.Point(27, 114)
        Me.IntakeTempLabel.Name = "IntakeTempLabel"
        Me.IntakeTempLabel.Size = New System.Drawing.Size(212, 19)
        Me.IntakeTempLabel.TabIndex = 16
        Me.IntakeTempLabel.Text = "Intake Temperature: 20 º"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(141, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Fan Speed"
        '
        'WindowsLabel
        '
        Me.WindowsLabel.AutoSize = True
        Me.WindowsLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.WindowsLabel.Location = New System.Drawing.Point(112, 379)
        Me.WindowsLabel.Name = "WindowsLabel"
        Me.WindowsLabel.Size = New System.Drawing.Size(160, 19)
        Me.WindowsLabel.TabIndex = 18
        Me.WindowsLabel.Text = "Windows: CLOSED"
        Me.WindowsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TrunkLabel
        '
        Me.TrunkLabel.AutoSize = True
        Me.TrunkLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TrunkLabel.Location = New System.Drawing.Point(125, 460)
        Me.TrunkLabel.Name = "TrunkLabel"
        Me.TrunkLabel.Size = New System.Drawing.Size(132, 19)
        Me.TrunkLabel.TabIndex = 19
        Me.TrunkLabel.Text = "Trunk: CLOSED"
        Me.TrunkLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Temp
        '
        Me.Temp.AutoSize = True
        Me.Temp.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Temp.Location = New System.Drawing.Point(160, 211)
        Me.Temp.Name = "Temp"
        Me.Temp.Size = New System.Drawing.Size(53, 36)
        Me.Temp.TabIndex = 20
        Me.Temp.Text = "20"
        '
        'LowerTempIcon
        '
        Me.LowerTempIcon.BackColor = System.Drawing.Color.DimGray
        Me.LowerTempIcon.Image = CType(resources.GetObject("LowerTempIcon.Image"), System.Drawing.Image)
        Me.LowerTempIcon.Location = New System.Drawing.Point(90, 212)
        Me.LowerTempIcon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.LowerTempIcon.Name = "LowerTempIcon"
        Me.LowerTempIcon.Size = New System.Drawing.Size(33, 35)
        Me.LowerTempIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LowerTempIcon.TabIndex = 11
        Me.LowerTempIcon.TabStop = False
        '
        'IncreaseTempIcon
        '
        Me.IncreaseTempIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IncreaseTempIcon.Image = Global.ECarApp.My.Resources.Resources.RightARrow
        Me.IncreaseTempIcon.Location = New System.Drawing.Point(252, 212)
        Me.IncreaseTempIcon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.IncreaseTempIcon.Name = "IncreaseTempIcon"
        Me.IncreaseTempIcon.Size = New System.Drawing.Size(33, 35)
        Me.IncreaseTempIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IncreaseTempIcon.TabIndex = 11
        Me.IncreaseTempIcon.TabStop = False
        '
        'FanSpeedDown
        '
        Me.FanSpeedDown.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FanSpeedDown.Image = CType(resources.GetObject("FanSpeedDown.Image"), System.Drawing.Image)
        Me.FanSpeedDown.Location = New System.Drawing.Point(90, 309)
        Me.FanSpeedDown.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.FanSpeedDown.Name = "FanSpeedDown"
        Me.FanSpeedDown.Size = New System.Drawing.Size(33, 35)
        Me.FanSpeedDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FanSpeedDown.TabIndex = 11
        Me.FanSpeedDown.TabStop = False
        '
        'FanSpeedUp
        '
        Me.FanSpeedUp.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FanSpeedUp.Image = Global.ECarApp.My.Resources.Resources.RightARrow
        Me.FanSpeedUp.Location = New System.Drawing.Point(252, 309)
        Me.FanSpeedUp.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.FanSpeedUp.Name = "FanSpeedUp"
        Me.FanSpeedUp.Size = New System.Drawing.Size(33, 35)
        Me.FanSpeedUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FanSpeedUp.TabIndex = 11
        Me.FanSpeedUp.TabStop = False
        '
        'FanSpeed
        '
        Me.FanSpeed.AutoSize = True
        Me.FanSpeed.Font = New System.Drawing.Font("Eras Medium ITC", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FanSpeed.Location = New System.Drawing.Point(170, 308)
        Me.FanSpeed.Name = "FanSpeed"
        Me.FanSpeed.Size = New System.Drawing.Size(34, 36)
        Me.FanSpeed.TabIndex = 20
        Me.FanSpeed.Text = "1"
        Me.FanSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(103, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Cabin Temperature"
        '
        'windowsBtn
        '
        Me.windowsBtn.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.windowsBtn.Location = New System.Drawing.Point(90, 403)
        Me.windowsBtn.Name = "windowsBtn"
        Me.windowsBtn.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.windowsBtn.Size = New System.Drawing.Size(195, 45)
        Me.windowsBtn.TabIndex = 21
        Me.windowsBtn.Text = "Open/Close Windows"
        Me.windowsBtn.UseVisualStyleBackColor = True
        '
        'TrunkBtn
        '
        Me.TrunkBtn.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TrunkBtn.Location = New System.Drawing.Point(90, 484)
        Me.TrunkBtn.Name = "TrunkBtn"
        Me.TrunkBtn.Size = New System.Drawing.Size(195, 45)
        Me.TrunkBtn.TabIndex = 21
        Me.TrunkBtn.Text = "Open/Close Trunk"
        Me.TrunkBtn.UseVisualStyleBackColor = True
        '
        'HeatedSeatsLabel
        '
        Me.HeatedSeatsLabel.AutoSize = True
        Me.HeatedSeatsLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HeatedSeatsLabel.Location = New System.Drawing.Point(112, 546)
        Me.HeatedSeatsLabel.Name = "HeatedSeatsLabel"
        Me.HeatedSeatsLabel.Size = New System.Drawing.Size(160, 19)
        Me.HeatedSeatsLabel.TabIndex = 19
        Me.HeatedSeatsLabel.Text = "Heated Seats: OFF"
        Me.HeatedSeatsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HeatedSeatsBtn
        '
        Me.HeatedSeatsBtn.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HeatedSeatsBtn.Location = New System.Drawing.Point(90, 570)
        Me.HeatedSeatsBtn.Name = "HeatedSeatsBtn"
        Me.HeatedSeatsBtn.Size = New System.Drawing.Size(195, 45)
        Me.HeatedSeatsBtn.TabIndex = 21
        Me.HeatedSeatsBtn.Text = "TURN ON/OFF"
        Me.HeatedSeatsBtn.UseVisualStyleBackColor = True
        '
        'DefrostLabel
        '
        Me.DefrostLabel.AutoSize = True
        Me.DefrostLabel.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DefrostLabel.Location = New System.Drawing.Point(141, 633)
        Me.DefrostLabel.Name = "DefrostLabel"
        Me.DefrostLabel.Size = New System.Drawing.Size(112, 19)
        Me.DefrostLabel.TabIndex = 19
        Me.DefrostLabel.Text = "Defrost: OFF"
        Me.DefrostLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DefrostBtn
        '
        Me.DefrostBtn.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DefrostBtn.Location = New System.Drawing.Point(90, 657)
        Me.DefrostBtn.Name = "DefrostBtn"
        Me.DefrostBtn.Size = New System.Drawing.Size(195, 45)
        Me.DefrostBtn.TabIndex = 21
        Me.DefrostBtn.Text = "TURN ON/OFF"
        Me.DefrostBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(203, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "º"
        '
        'CarControlsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.DefrostBtn)
        Me.Controls.Add(Me.HeatedSeatsBtn)
        Me.Controls.Add(Me.TrunkBtn)
        Me.Controls.Add(Me.windowsBtn)
        Me.Controls.Add(Me.DefrostLabel)
        Me.Controls.Add(Me.FanSpeed)
        Me.Controls.Add(Me.HeatedSeatsLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Temp)
        Me.Controls.Add(Me.TrunkLabel)
        Me.Controls.Add(Me.WindowsLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IntakeTempLabel)
        Me.Controls.Add(Me.OutsideTempLabel)
        Me.Controls.Add(Me.CarControlsLabel)
        Me.Controls.Add(Me.FanSpeedUp)
        Me.Controls.Add(Me.FanSpeedDown)
        Me.Controls.Add(Me.IncreaseTempIcon)
        Me.Controls.Add(Me.LowerTempIcon)
        Me.Controls.Add(Me.BackIcon)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "CarControlsPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CarControlsPage"
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LowerTempIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncreaseTempIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanSpeedDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FanSpeedUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarControlsLabel As Label
    Friend WithEvents BackIcon As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents OutsideTempLabel As Label
    Friend WithEvents IntakeTempLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents WindowsLabel As Label
    Friend WithEvents TrunkLabel As Label
    Friend WithEvents Temp As Label
    Friend WithEvents LowerTempIcon As PictureBox
    Friend WithEvents IncreaseTempIcon As PictureBox
    Friend WithEvents FanSpeedDown As PictureBox
    Friend WithEvents FanSpeedUp As PictureBox
    Friend WithEvents FanSpeed As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents windowsBtn As Button
    Friend WithEvents TrunkBtn As Button
    Friend WithEvents HeatedSeatsLabel As Label
    Friend WithEvents HeatedSeatsBtn As Button
    Friend WithEvents DefrostLabel As Label
    Friend WithEvents DefrostBtn As Button
    Friend WithEvents Label1 As Label
End Class
