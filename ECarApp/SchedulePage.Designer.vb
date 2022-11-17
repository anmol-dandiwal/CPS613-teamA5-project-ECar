﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SchedulePage))
        Me.Calendar = New System.Windows.Forms.MonthCalendar()
        Me.BackIcon = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ScheduleLabel = New System.Windows.Forms.Label()
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Calendar
        '
        Me.Calendar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Calendar.Font = New System.Drawing.Font("Eras Medium ITC", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Calendar.Location = New System.Drawing.Point(144, 103)
        Me.Calendar.Name = "Calendar"
        Me.Calendar.TabIndex = 0
        Me.Calendar.TitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Calendar.TitleForeColor = System.Drawing.Color.Coral
        Me.Calendar.TrailingForeColor = System.Drawing.SystemColors.Info
        '
        'BackIcon
        '
        Me.BackIcon.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackIcon.Image = CType(resources.GetObject("BackIcon.Image"), System.Drawing.Image)
        Me.BackIcon.Location = New System.Drawing.Point(36, 28)
        Me.BackIcon.Name = "BackIcon"
        Me.BackIcon.Size = New System.Drawing.Size(45, 52)
        Me.BackIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BackIcon.TabIndex = 1
        Me.BackIcon.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackButton.Location = New System.Drawing.Point(14, 14)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 80)
        Me.BackButton.TabIndex = 2
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ScheduleLabel
        '
        Me.ScheduleLabel.AutoSize = True
        Me.ScheduleLabel.Font = New System.Drawing.Font("Eras Medium ITC", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ScheduleLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ScheduleLabel.Location = New System.Drawing.Point(225, 26)
        Me.ScheduleLabel.Name = "ScheduleLabel"
        Me.ScheduleLabel.Size = New System.Drawing.Size(266, 68)
        Me.ScheduleLabel.TabIndex = 3
        Me.ScheduleLabel.Text = "Schedule"
        '
        'SchedulePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(740, 1529)
        Me.Controls.Add(Me.ScheduleLabel)
        Me.Controls.Add(Me.BackIcon)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Calendar)
        Me.Name = "SchedulePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule"
        CType(Me.BackIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Calendar As MonthCalendar
    Friend WithEvents BackIcon As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents ScheduleLabel As Label
End Class