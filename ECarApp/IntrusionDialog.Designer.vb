<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntrusionDialog
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IntrusionLabel = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECarApp.My.Resources.Resources.Car_BreakIn
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'IntrusionLabel
        '
        Me.IntrusionLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IntrusionLabel.Location = New System.Drawing.Point(12, 256)
        Me.IntrusionLabel.Name = "IntrusionLabel"
        Me.IntrusionLabel.Size = New System.Drawing.Size(342, 192)
        Me.IntrusionLabel.TabIndex = 2
        Me.IntrusionLabel.Text = "WARNING: Possible intrusion detected. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The above is the latest view from insid" &
    "e your vehicle. Would you like to dispatch emergency services?"
        Me.IntrusionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesButton.Font = New System.Drawing.Font("Eras Medium ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.YesButton.Location = New System.Drawing.Point(12, 502)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(167, 167)
        Me.YesButton.TabIndex = 3
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = False
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Eras Medium ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoButton.Location = New System.Drawing.Point(201, 502)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(167, 167)
        Me.NoButton.TabIndex = 4
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'IntrusionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.IntrusionLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "IntrusionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intrusion Alert"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IntrusionLabel As Label
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
End Class
