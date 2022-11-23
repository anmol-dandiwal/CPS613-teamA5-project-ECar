<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RiderPastTripsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RiderPastTripsPage))
        Me.RiderPastTripsTable = New System.Windows.Forms.DataGridView()
        Me.RiderPastTripsLabel = New System.Windows.Forms.Label()
        Me.BackIcon = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.RiderPastTripsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RiderPastTripsTable
        '
        Me.RiderPastTripsTable.AllowUserToAddRows = False
        Me.RiderPastTripsTable.AllowUserToDeleteRows = False
        Me.RiderPastTripsTable.AllowUserToResizeColumns = False
        Me.RiderPastTripsTable.AllowUserToResizeRows = False
        Me.RiderPastTripsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RiderPastTripsTable.Location = New System.Drawing.Point(30, 97)
        Me.RiderPastTripsTable.MultiSelect = False
        Me.RiderPastTripsTable.Name = "RiderPastTripsTable"
        Me.RiderPastTripsTable.ReadOnly = True
        Me.RiderPastTripsTable.RowTemplate.Height = 25
        Me.RiderPastTripsTable.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.RiderPastTripsTable.ShowEditingIcon = False
        Me.RiderPastTripsTable.Size = New System.Drawing.Size(321, 632)
        Me.RiderPastTripsTable.TabIndex = 11
        '
        'RiderPastTripsLabel
        '
        Me.RiderPastTripsLabel.AutoSize = True
        Me.RiderPastTripsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RiderPastTripsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RiderPastTripsLabel.Location = New System.Drawing.Point(135, 32)
        Me.RiderPastTripsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RiderPastTripsLabel.Name = "RiderPastTripsLabel"
        Me.RiderPastTripsLabel.Size = New System.Drawing.Size(147, 33)
        Me.RiderPastTripsLabel.TabIndex = 10
        Me.RiderPastTripsLabel.Text = "Past Trips"
        '
        'BackIcon
        '
        Me.BackIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackIcon.Image = CType(resources.GetObject("BackIcon.Image"), System.Drawing.Image)
        Me.BackIcon.Location = New System.Drawing.Point(38, 29)
        Me.BackIcon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackIcon.Name = "BackIcon"
        Me.BackIcon.Size = New System.Drawing.Size(33, 35)
        Me.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackIcon.TabIndex = 8
        Me.BackIcon.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(30, 28)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(49, 38)
        Me.BackButton.TabIndex = 9
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(83, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Double click a cell to view route map."
        '
        'RiderPastTripsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RiderPastTripsTable)
        Me.Controls.Add(Me.RiderPastTripsLabel)
        Me.Controls.Add(Me.BackIcon)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "RiderPastTripsPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RiderPastTripsPage"
        CType(Me.RiderPastTripsTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RiderPastTripsTable As DataGridView
    Friend WithEvents RiderPastTripsLabel As Label
    Friend WithEvents BackIcon As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
End Class
