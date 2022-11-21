<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PastTripsPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PastTripsPage))
        Me.PastTripsLabel = New System.Windows.Forms.Label()
        Me.BackIcon = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PastTripsTable = New System.Windows.Forms.DataGridView()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PastTripsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PastTripsLabel
        '
        Me.PastTripsLabel.AutoSize = True
        Me.PastTripsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PastTripsLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PastTripsLabel.Location = New System.Drawing.Point(130, 25)
        Me.PastTripsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PastTripsLabel.Name = "PastTripsLabel"
        Me.PastTripsLabel.Size = New System.Drawing.Size(149, 36)
        Me.PastTripsLabel.TabIndex = 6
        Me.PastTripsLabel.Text = "Past Trips"
        '
        'BackIcon
        '
        Me.BackIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackIcon.Image = CType(resources.GetObject("BackIcon.Image"), System.Drawing.Image)
        Me.BackIcon.Location = New System.Drawing.Point(33, 22)
        Me.BackIcon.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackIcon.Name = "BackIcon"
        Me.BackIcon.Size = New System.Drawing.Size(33, 35)
        Me.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackIcon.TabIndex = 4
        Me.BackIcon.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Location = New System.Drawing.Point(25, 21)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(49, 38)
        Me.BackButton.TabIndex = 5
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'PastTripsTable
        '
        Me.PastTripsTable.AllowUserToAddRows = False
        Me.PastTripsTable.AllowUserToDeleteRows = False
        Me.PastTripsTable.AllowUserToResizeColumns = False
        Me.PastTripsTable.AllowUserToResizeRows = False
        Me.PastTripsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PastTripsTable.Location = New System.Drawing.Point(25, 90)
        Me.PastTripsTable.MultiSelect = False
        Me.PastTripsTable.Name = "PastTripsTable"
        Me.PastTripsTable.ReadOnly = True
        Me.PastTripsTable.RowTemplate.Height = 25
        Me.PastTripsTable.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PastTripsTable.ShowEditingIcon = False
        Me.PastTripsTable.Size = New System.Drawing.Size(321, 632)
        Me.PastTripsTable.TabIndex = 7
        '
        'PastTripsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 757)
        Me.Controls.Add(Me.PastTripsTable)
        Me.Controls.Add(Me.PastTripsLabel)
        Me.Controls.Add(Me.BackIcon)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "PastTripsPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PastTripsPage"
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PastTripsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PastTripsLabel As Label
    Friend WithEvents BackIcon As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents PastTripsTable As DataGridView
End Class
