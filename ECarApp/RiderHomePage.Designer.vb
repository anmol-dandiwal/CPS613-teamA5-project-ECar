<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RiderHomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiderHomePage))
        Me.SwapIcon = New System.Windows.Forms.PictureBox()
        Me.RiderLabel = New System.Windows.Forms.Label()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.pastTripButton = New System.Windows.Forms.Button()
        Me.BookRideButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HistoryIcon = New System.Windows.Forms.PictureBox()
        Me.CarControlsIcon = New System.Windows.Forms.PictureBox()
        Me.ControlsButton = New System.Windows.Forms.Button()
        Me.ChatBtn = New System.Windows.Forms.Button()
        Me.StatusWindow = New System.Windows.Forms.Label()
        Me.XButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteTripButton = New System.Windows.Forms.Button()
        Me.ViewTripStatusButton = New System.Windows.Forms.Button()
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistoryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarControlsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SwapIcon
        '
        Me.SwapIcon.Image = Global.ECarApp.My.Resources.Resources.SwapIcon
        Me.SwapIcon.Location = New System.Drawing.Point(179, 17)
        Me.SwapIcon.Name = "SwapIcon"
        Me.SwapIcon.Size = New System.Drawing.Size(34, 31)
        Me.SwapIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SwapIcon.TabIndex = 19
        Me.SwapIcon.TabStop = False
        '
        'RiderLabel
        '
        Me.RiderLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RiderLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RiderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RiderLabel.Location = New System.Drawing.Point(224, 18)
        Me.RiderLabel.Name = "RiderLabel"
        Me.RiderLabel.Size = New System.Drawing.Size(86, 27)
        Me.RiderLabel.TabIndex = 18
        Me.RiderLabel.Text = "Rider"
        Me.RiderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OwnerLabel
        '
        Me.OwnerLabel.AutoSize = True
        Me.OwnerLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.OwnerLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OwnerLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OwnerLabel.Location = New System.Drawing.Point(81, 18)
        Me.OwnerLabel.Name = "OwnerLabel"
        Me.OwnerLabel.Size = New System.Drawing.Size(86, 27)
        Me.OwnerLabel.TabIndex = 17
        Me.OwnerLabel.Text = "Owner"
        '
        'pastTripButton
        '
        Me.pastTripButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pastTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pastTripButton.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pastTripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pastTripButton.Location = New System.Drawing.Point(27, 438)
        Me.pastTripButton.Margin = New System.Windows.Forms.Padding(6)
        Me.pastTripButton.Name = "pastTripButton"
        Me.pastTripButton.Size = New System.Drawing.Size(158, 88)
        Me.pastTripButton.TabIndex = 21
        Me.pastTripButton.Text = "Trip History"
        Me.pastTripButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pastTripButton.UseVisualStyleBackColor = False
        '
        'BookRideButton
        '
        Me.BookRideButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BookRideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookRideButton.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BookRideButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BookRideButton.Location = New System.Drawing.Point(27, 338)
        Me.BookRideButton.Margin = New System.Windows.Forms.Padding(6)
        Me.BookRideButton.Name = "BookRideButton"
        Me.BookRideButton.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BookRideButton.Size = New System.Drawing.Size(325, 88)
        Me.BookRideButton.TabIndex = 20
        Me.BookRideButton.Text = "Book a Ride"
        Me.BookRideButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookRideButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PictureBox1.Image = Global.ECarApp.My.Resources.Resources.bookCarIcon
        Me.PictureBox1.Location = New System.Drawing.Point(257, 351)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'HistoryIcon
        '
        Me.HistoryIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.HistoryIcon.Image = CType(resources.GetObject("HistoryIcon.Image"), System.Drawing.Image)
        Me.HistoryIcon.Location = New System.Drawing.Point(141, 463)
        Me.HistoryIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.HistoryIcon.Name = "HistoryIcon"
        Me.HistoryIcon.Size = New System.Drawing.Size(34, 37)
        Me.HistoryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HistoryIcon.TabIndex = 24
        Me.HistoryIcon.TabStop = False
        '
        'CarControlsIcon
        '
        Me.CarControlsIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CarControlsIcon.Image = Global.ECarApp.My.Resources.Resources.SlidersIcon
        Me.CarControlsIcon.Location = New System.Drawing.Point(311, 460)
        Me.CarControlsIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.CarControlsIcon.Name = "CarControlsIcon"
        Me.CarControlsIcon.Size = New System.Drawing.Size(36, 41)
        Me.CarControlsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CarControlsIcon.TabIndex = 27
        Me.CarControlsIcon.TabStop = False
        '
        'ControlsButton
        '
        Me.ControlsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ControlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ControlsButton.Font = New System.Drawing.Font("Eras Medium ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ControlsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ControlsButton.Location = New System.Drawing.Point(194, 438)
        Me.ControlsButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ControlsButton.Name = "ControlsButton"
        Me.ControlsButton.Size = New System.Drawing.Size(158, 88)
        Me.ControlsButton.TabIndex = 26
        Me.ControlsButton.Text = "Car Controls"
        Me.ControlsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ControlsButton.UseVisualStyleBackColor = False
        '
        'ChatBtn
        '
        Me.ChatBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ChatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChatBtn.Font = New System.Drawing.Font("Eras Medium ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ChatBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChatBtn.Location = New System.Drawing.Point(27, 538)
        Me.ChatBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.ChatBtn.Name = "ChatBtn"
        Me.ChatBtn.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.ChatBtn.Size = New System.Drawing.Size(325, 88)
        Me.ChatBtn.TabIndex = 22
        Me.ChatBtn.Text = "Chat Support"
        Me.ChatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChatBtn.UseVisualStyleBackColor = False
        '
        'StatusWindow
        '
        Me.StatusWindow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StatusWindow.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StatusWindow.Location = New System.Drawing.Point(17, 72)
        Me.StatusWindow.Name = "StatusWindow"
        Me.StatusWindow.Size = New System.Drawing.Size(342, 198)
        Me.StatusWindow.TabIndex = 28
        Me.StatusWindow.Text = "You currently do not have a ride scheduled."
        Me.StatusWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'XButton
        '
        Me.XButton.BackColor = System.Drawing.Color.Transparent
        Me.XButton.Location = New System.Drawing.Point(334, 72)
        Me.XButton.Name = "XButton"
        Me.XButton.Size = New System.Drawing.Size(25, 24)
        Me.XButton.TabIndex = 29
        Me.XButton.Text = "X"
        Me.XButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.EditButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EditButton.Location = New System.Drawing.Point(29, 284)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(149, 42)
        Me.EditButton.TabIndex = 30
        Me.EditButton.Text = "Edit Trip"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'DeleteTripButton
        '
        Me.DeleteTripButton.BackColor = System.Drawing.Color.Firebrick
        Me.DeleteTripButton.FlatAppearance.BorderSize = 0
        Me.DeleteTripButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteTripButton.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeleteTripButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DeleteTripButton.Location = New System.Drawing.Point(200, 284)
        Me.DeleteTripButton.Name = "DeleteTripButton"
        Me.DeleteTripButton.Size = New System.Drawing.Size(149, 42)
        Me.DeleteTripButton.TabIndex = 31
        Me.DeleteTripButton.Text = "Delete Trip"
        Me.DeleteTripButton.UseVisualStyleBackColor = False
        '
        'ViewTripStatusButton
        '
        Me.ViewTripStatusButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ViewTripStatusButton.FlatAppearance.BorderSize = 0
        Me.ViewTripStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewTripStatusButton.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ViewTripStatusButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ViewTripStatusButton.Location = New System.Drawing.Point(109, 72)
        Me.ViewTripStatusButton.Name = "ViewTripStatusButton"
        Me.ViewTripStatusButton.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.ViewTripStatusButton.Size = New System.Drawing.Size(161, 42)
        Me.ViewTripStatusButton.TabIndex = 32
        Me.ViewTripStatusButton.Text = "View Trip Status"
        Me.ViewTripStatusButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewTripStatusButton.UseVisualStyleBackColor = False
        '
        'RiderHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.ViewTripStatusButton)
        Me.Controls.Add(Me.DeleteTripButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.XButton)
        Me.Controls.Add(Me.StatusWindow)
        Me.Controls.Add(Me.CarControlsIcon)
        Me.Controls.Add(Me.ControlsButton)
        Me.Controls.Add(Me.HistoryIcon)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ChatBtn)
        Me.Controls.Add(Me.pastTripButton)
        Me.Controls.Add(Me.BookRideButton)
        Me.Controls.Add(Me.SwapIcon)
        Me.Controls.Add(Me.RiderLabel)
        Me.Controls.Add(Me.OwnerLabel)
        Me.Name = "RiderHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderHomePage"
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistoryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarControlsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SwapIcon As PictureBox
    Friend WithEvents RiderLabel As Label
    Friend WithEvents OwnerLabel As Label
    Friend WithEvents pastTripButton As Button
    Friend WithEvents BookRideButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HistoryIcon As PictureBox
    Friend WithEvents CarControlsIcon As PictureBox
    Friend WithEvents ControlsButton As Button
    Friend WithEvents ChatBtn As Button
    Friend WithEvents StatusWindow As Label
    Friend WithEvents XButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents DeleteTripButton As Button
    Friend WithEvents ViewTripStatusButton As Button
End Class
