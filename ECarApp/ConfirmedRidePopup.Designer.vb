<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmedRidePopup
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ConfirmedRideMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(112, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start Ride"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ConfirmedRideMessage
        '
        Me.ConfirmedRideMessage.Font = New System.Drawing.Font("Eras Medium ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ConfirmedRideMessage.Location = New System.Drawing.Point(21, 19)
        Me.ConfirmedRideMessage.Name = "ConfirmedRideMessage"
        Me.ConfirmedRideMessage.Size = New System.Drawing.Size(337, 148)
        Me.ConfirmedRideMessage.TabIndex = 1
        Me.ConfirmedRideMessage.Text = "Label1"
        Me.ConfirmedRideMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ConfirmedRidePopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 249)
        Me.Controls.Add(Me.ConfirmedRideMessage)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ConfirmedRidePopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfirmedRidePopup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ConfirmedRideMessage As Label
End Class
