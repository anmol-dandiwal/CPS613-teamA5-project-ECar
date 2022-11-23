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
        Me.SwapIcon = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VehicleInfoLabel = New System.Windows.Forms.Label()
        Me.CarPicture = New System.Windows.Forms.PictureBox()
        Me.BankInfoHeader = New System.Windows.Forms.Label()
        Me.BankInfoLabel = New System.Windows.Forms.Label()
        Me.BankEdit = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankEdit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OwnerLabel.Location = New System.Drawing.Point(72, 64)
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
        Me.RiderLabel.Location = New System.Drawing.Point(215, 64)
        Me.RiderLabel.Name = "RiderLabel"
        Me.RiderLabel.Size = New System.Drawing.Size(86, 27)
        Me.RiderLabel.TabIndex = 8
        Me.RiderLabel.Text = "Rider"
        Me.RiderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SwapIcon
        '
        Me.SwapIcon.Image = Global.ECarApp.My.Resources.Resources.SwapIcon
        Me.SwapIcon.Location = New System.Drawing.Point(170, 63)
        Me.SwapIcon.Name = "SwapIcon"
        Me.SwapIcon.Size = New System.Drawing.Size(34, 31)
        Me.SwapIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SwapIcon.TabIndex = 9
        Me.SwapIcon.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 192)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Vehicle Info" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Model:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colour:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VIN:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "License:"
        '
        'VehicleInfoLabel
        '
        Me.VehicleInfoLabel.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VehicleInfoLabel.Location = New System.Drawing.Point(129, 161)
        Me.VehicleInfoLabel.Name = "VehicleInfoLabel"
        Me.VehicleInfoLabel.Size = New System.Drawing.Size(251, 147)
        Me.VehicleInfoLabel.TabIndex = 11
        Me.VehicleInfoLabel.Text = "Audi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E-Tron" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gray" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ABCDEFGH0123456789" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ABCD 123"
        Me.VehicleInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CarPicture
        '
        Me.CarPicture.Image = Global.ECarApp.My.Resources.Resources.Car
        Me.CarPicture.Location = New System.Drawing.Point(72, 314)
        Me.CarPicture.Margin = New System.Windows.Forms.Padding(6)
        Me.CarPicture.Name = "CarPicture"
        Me.CarPicture.Size = New System.Drawing.Size(227, 149)
        Me.CarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarPicture.TabIndex = 12
        Me.CarPicture.TabStop = False
        '
        'BankInfoHeader
        '
        Me.BankInfoHeader.AutoSize = True
        Me.BankInfoHeader.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BankInfoHeader.Location = New System.Drawing.Point(3, 469)
        Me.BankInfoHeader.Name = "BankInfoHeader"
        Me.BankInfoHeader.Size = New System.Drawing.Size(128, 120)
        Me.BankInfoHeader.TabIndex = 13
        Me.BankInfoHeader.Text = "Bank Info" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Branch No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Transit No. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account No."
        '
        'BankInfoLabel
        '
        Me.BankInfoLabel.Font = New System.Drawing.Font("Eras Medium ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BankInfoLabel.Location = New System.Drawing.Point(129, 515)
        Me.BankInfoLabel.Name = "BankInfoLabel"
        Me.BankInfoLabel.Size = New System.Drawing.Size(251, 74)
        Me.BankInfoLabel.TabIndex = 14
        Me.BankInfoLabel.Text = "12345" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "001" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1234567890"
        Me.BankInfoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BankEdit
        '
        Me.BankEdit.Image = CType(resources.GetObject("BankEdit.Image"), System.Drawing.Image)
        Me.BankEdit.Location = New System.Drawing.Point(103, 469)
        Me.BankEdit.Name = "BankEdit"
        Me.BankEdit.Size = New System.Drawing.Size(28, 28)
        Me.BankEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BankEdit.TabIndex = 15
        Me.BankEdit.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'AccountPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BankEdit)
        Me.Controls.Add(Me.BankInfoLabel)
        Me.Controls.Add(Me.BankInfoHeader)
        Me.Controls.Add(Me.CarPicture)
        Me.Controls.Add(Me.VehicleInfoLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SwapIcon)
        Me.Controls.Add(Me.RiderLabel)
        Me.Controls.Add(Me.OwnerLabel)
        Me.Controls.Add(Me.BackIcon)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.YourAccountLabel)
        Me.Name = "AccountPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SwapIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents YourAccountLabel As Label
    Friend WithEvents BackIcon As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents OwnerLabel As Label
    Friend WithEvents RiderLabel As Label
    Friend WithEvents SwapIcon As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VehicleInfoLabel As Label
    Friend WithEvents CarPicture As PictureBox
    Friend WithEvents BankInfoHeader As Label
    Friend WithEvents BankInfoLabel As Label
    Friend WithEvents BankEdit As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
