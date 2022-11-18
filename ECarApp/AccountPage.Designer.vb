<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountPage))
        Me.YourAccountLabel = New System.Windows.Forms.Label()
        Me.BackIcon = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.RiderLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YourAccountLabel
        '
        Me.YourAccountLabel.AutoSize = True
        Me.YourAccountLabel.Font = New System.Drawing.Font("Eras Medium ITC", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.YourAccountLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.YourAccountLabel.Location = New System.Drawing.Point(93, 13)
        Me.YourAccountLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.YourAccountLabel.Name = "YourAccountLabel"
        Me.YourAccountLabel.Size = New System.Drawing.Size(198, 34)
        Me.YourAccountLabel.TabIndex = 4
        Me.YourAccountLabel.Text = "Your Account"
        '
        'BackIcon
        '
        Me.BackIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackIcon.Image = CType(resources.GetObject("BackIcon.Image"), System.Drawing.Image)
        Me.BackIcon.Location = New System.Drawing.Point(21, 10)
        Me.BackIcon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackIcon.Name = "BackIcon"
        Me.BackIcon.Size = New System.Drawing.Size(33, 35)
        Me.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackIcon.TabIndex = 5
        Me.BackIcon.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(13, 9)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(49, 38)
        Me.BackButton.TabIndex = 6
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'OwnerLabel
        '
        Me.OwnerLabel.AutoSize = True
        Me.OwnerLabel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.OwnerLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OwnerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.OwnerLabel.Location = New System.Drawing.Point(74, 94)
        Me.OwnerLabel.Name = "OwnerLabel"
        Me.OwnerLabel.Size = New System.Drawing.Size(86, 27)
        Me.OwnerLabel.TabIndex = 7
        Me.OwnerLabel.Text = "Owner"
        '
        'RiderLabel
        '
        Me.RiderLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RiderLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RiderLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RiderLabel.Location = New System.Drawing.Point(217, 94)
        Me.RiderLabel.Name = "RiderLabel"
        Me.RiderLabel.Size = New System.Drawing.Size(86, 27)
        Me.RiderLabel.TabIndex = 8
        Me.RiderLabel.Text = "Rider"
        Me.RiderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECarApp.My.Resources.Resources.SwapIcon
        Me.PictureBox1.Location = New System.Drawing.Point(172, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'AccountPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RiderLabel)
        Me.Controls.Add(Me.OwnerLabel)
        Me.Controls.Add(Me.BackIcon)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.YourAccountLabel)
        Me.Name = "AccountPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YourAccountLabel As Label
    Friend WithEvents BackIcon As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents OwnerLabel As Label
    Friend WithEvents RiderLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
