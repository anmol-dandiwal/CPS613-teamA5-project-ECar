<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.scheduleButton = New System.Windows.Forms.Button()
        Me.pastTripButton = New System.Windows.Forms.Button()
        Me.mapButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECarApp.My.Resources.Resources.settingUser
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ECarApp.My.Resources.Resources.rotatingCar
        Me.PictureBox2.Location = New System.Drawing.Point(66, 95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(260, 156)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'scheduleButton
        '
        Me.scheduleButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.scheduleButton.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.scheduleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.scheduleButton.Location = New System.Drawing.Point(66, 404)
        Me.scheduleButton.Name = "scheduleButton"
        Me.scheduleButton.Size = New System.Drawing.Size(253, 69)
        Me.scheduleButton.TabIndex = 2
        Me.scheduleButton.Text = "Schedule"
        Me.scheduleButton.UseVisualStyleBackColor = False
        '
        'pastTripButton
        '
        Me.pastTripButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pastTripButton.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pastTripButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pastTripButton.Location = New System.Drawing.Point(66, 483)
        Me.pastTripButton.Name = "pastTripButton"
        Me.pastTripButton.Size = New System.Drawing.Size(253, 69)
        Me.pastTripButton.TabIndex = 3
        Me.pastTripButton.Text = "Past Trips"
        Me.pastTripButton.UseVisualStyleBackColor = False
        '
        'mapButton
        '
        Me.mapButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mapButton.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mapButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mapButton.Location = New System.Drawing.Point(66, 562)
        Me.mapButton.Name = "mapButton"
        Me.mapButton.Size = New System.Drawing.Size(253, 69)
        Me.mapButton.TabIndex = 5
        Me.mapButton.Text = "Map"
        Me.mapButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 757)
        Me.Controls.Add(Me.mapButton)
        Me.Controls.Add(Me.pastTripButton)
        Me.Controls.Add(Me.scheduleButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents scheduleButton As Button
    Friend WithEvents pastTripButton As Button
    Friend WithEvents mapButton As Button
End Class
