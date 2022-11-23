<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollisionDialog
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
        Me.CollisionLabel = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CollisionLabel
        '
        Me.CollisionLabel.Font = New System.Drawing.Font("Eras Medium ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CollisionLabel.Location = New System.Drawing.Point(12, 9)
        Me.CollisionLabel.Name = "CollisionLabel"
        Me.CollisionLabel.Size = New System.Drawing.Size(260, 192)
        Me.CollisionLabel.TabIndex = 3
        Me.CollisionLabel.Text = "WARNING: Collision Detected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A minor collision has been detected. Would you lik" &
    "e to dispatch CAA?"
        Me.CollisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesButton.Font = New System.Drawing.Font("Eras Medium ITC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.YesButton.Location = New System.Drawing.Point(12, 218)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(127, 110)
        Me.YesButton.TabIndex = 4
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = False
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Eras Medium ITC", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NoButton.Location = New System.Drawing.Point(145, 218)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(127, 110)
        Me.NoButton.TabIndex = 5
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'CollisionAlert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 340)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.CollisionLabel)
        Me.Name = "CollisionAlert"
        Me.Text = "Collision/Damage Alert"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CollisionLabel As Label
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
End Class
