<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiderHomePage
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
        Me.SwapIcon = New System.Windows.Forms.PictureBox()
        Me.RiderLabel = New System.Windows.Forms.Label()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.UserIcon = New System.Windows.Forms.PictureBox()
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'UserIcon
        '
        Me.UserIcon.Image = Global.ECarApp.My.Resources.Resources.settingUser
        Me.UserIcon.Location = New System.Drawing.Point(9, 8)
        Me.UserIcon.Margin = New System.Windows.Forms.Padding(6)
        Me.UserIcon.Name = "UserIcon"
        Me.UserIcon.Size = New System.Drawing.Size(46, 46)
        Me.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserIcon.TabIndex = 16
        Me.UserIcon.TabStop = False
        '
        'RiderHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.SwapIcon)
        Me.Controls.Add(Me.RiderLabel)
        Me.Controls.Add(Me.OwnerLabel)
        Me.Controls.Add(Me.UserIcon)
        Me.Name = "RiderHomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderHomePage"
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SwapIcon As PictureBox
    Friend WithEvents RiderLabel As Label
    Friend WithEvents OwnerLabel As Label
    Friend WithEvents UserIcon As PictureBox
End Class
