<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRideDialog
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
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.DeclineButton = New System.Windows.Forms.Button()
        Me.NotificationLabel = New System.Windows.Forms.Label()
        Me.NotificationBodyLabel = New System.Windows.Forms.Label()
        Me.CancelScheduledRide = New System.Windows.Forms.Button()
        Me.ReturnToHomePage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AcceptButton
        '
        Me.AcceptButton.BackColor = System.Drawing.Color.ForestGreen
        Me.AcceptButton.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AcceptButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AcceptButton.Location = New System.Drawing.Point(208, 305)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(128, 56)
        Me.AcceptButton.TabIndex = 0
        Me.AcceptButton.Text = "Accept"
        Me.AcceptButton.UseVisualStyleBackColor = False
        '
        'DeclineButton
        '
        Me.DeclineButton.BackColor = System.Drawing.Color.Firebrick
        Me.DeclineButton.Font = New System.Drawing.Font("Eras Medium ITC", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DeclineButton.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DeclineButton.Location = New System.Drawing.Point(52, 305)
        Me.DeclineButton.Name = "DeclineButton"
        Me.DeclineButton.Size = New System.Drawing.Size(133, 56)
        Me.DeclineButton.TabIndex = 1
        Me.DeclineButton.Text = "Decline"
        Me.DeclineButton.UseVisualStyleBackColor = False
        '
        'NotificationLabel
        '
        Me.NotificationLabel.AutoSize = True
        Me.NotificationLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NotificationLabel.Location = New System.Drawing.Point(15, 15)
        Me.NotificationLabel.Name = "NotificationLabel"
        Me.NotificationLabel.Size = New System.Drawing.Size(0, 27)
        Me.NotificationLabel.TabIndex = 2
        Me.NotificationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NotificationBodyLabel
        '
        Me.NotificationBodyLabel.Location = New System.Drawing.Point(15, 122)
        Me.NotificationBodyLabel.Name = "NotificationBodyLabel"
        Me.NotificationBodyLabel.Size = New System.Drawing.Size(356, 180)
        Me.NotificationBodyLabel.TabIndex = 3
        '
        'CancelScheduledRide
        '
        Me.CancelScheduledRide.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelScheduledRide.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CancelScheduledRide.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CancelScheduledRide.Location = New System.Drawing.Point(52, 421)
        Me.CancelScheduledRide.Name = "CancelScheduledRide"
        Me.CancelScheduledRide.Size = New System.Drawing.Size(284, 48)
        Me.CancelScheduledRide.TabIndex = 4
        Me.CancelScheduledRide.Text = "Cancel Scheduled Ride"
        Me.CancelScheduledRide.UseVisualStyleBackColor = False
        '
        'ReturnToHomePage
        '
        Me.ReturnToHomePage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ReturnToHomePage.Font = New System.Drawing.Font("Eras Medium ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ReturnToHomePage.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ReturnToHomePage.Location = New System.Drawing.Point(52, 367)
        Me.ReturnToHomePage.Name = "ReturnToHomePage"
        Me.ReturnToHomePage.Size = New System.Drawing.Size(284, 48)
        Me.ReturnToHomePage.TabIndex = 5
        Me.ReturnToHomePage.Text = "Return To HomePage"
        Me.ReturnToHomePage.UseVisualStyleBackColor = False
        '
        'NewRideDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.ReturnToHomePage)
        Me.Controls.Add(Me.CancelScheduledRide)
        Me.Controls.Add(Me.NotificationBodyLabel)
        Me.Controls.Add(Me.NotificationLabel)
        Me.Controls.Add(Me.DeclineButton)
        Me.Controls.Add(Me.AcceptButton)
        Me.Name = "NewRideDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewRideDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AcceptButton As Button
    Friend WithEvents DeclineButton As Button
    Friend WithEvents NotificationLabel As Label
    Friend WithEvents NotificationBodyLabel As Label
    Friend WithEvents CancelScheduledRide As Button
    Friend WithEvents ReturnToHomePage As Button
End Class
