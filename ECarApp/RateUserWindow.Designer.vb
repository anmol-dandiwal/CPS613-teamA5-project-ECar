<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RateUserWindow
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Stars = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Stars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(88, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How was your trip?"
        '
        'Stars
        '
        Me.Stars.Image = Global.ECarApp.My.Resources.Resources.rating
        Me.Stars.Location = New System.Drawing.Point(23, 12)
        Me.Stars.Name = "Stars"
        Me.Stars.Size = New System.Drawing.Size(335, 196)
        Me.Stars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Stars.TabIndex = 1
        Me.Stars.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(126, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tap to rate your ride"
        '
        'RateUserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 240)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Stars)
        Me.Name = "RateUserWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RateUserWindow"
        CType(Me.Stars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Stars As PictureBox
    Friend WithEvents Label2 As Label
End Class
