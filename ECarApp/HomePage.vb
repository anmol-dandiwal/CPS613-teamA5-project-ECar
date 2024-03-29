﻿Imports System.Security.Authentication.ExtendedProtection

Public Class HomePage
    Dim IntrusionAlert = False
    Dim CollisionAlert = False
    Dim FailureAlert = False
    Dim newRideAlert = False
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TripStatusButton.Hide()
        TripStatusCarPicture.Hide()
    End Sub
    Private Sub ScheduleButton_Click(sender As Object, e As EventArgs) Handles ScheduleButton.Click, CalendarIcon.Click
        If Not IntrusionAlert Then
            IntrusionDialog.ShowDialog()
            IntrusionAlert = True
        Else
            SchedulePage.Show()
        End If
    End Sub

    Private Sub UserIcon_Click(sender As Object, e As EventArgs) Handles UserIcon.Click
        If Not FailureAlert Then
            FailureDialog.ShowDialog()
            FailureAlert = True
        Else
            AccountPage.Show()
        End If
    End Sub

    Private Sub UserIcon_MouseEnter(sender As Object, e As EventArgs) Handles UserIcon.MouseEnter
        sender.Size = New Size(sender.Width + 5, sender.Height + 5)
        sender.Location = New Point(sender.Location.X - 2.5, sender.Location.Y - 2.5)
    End Sub
    Private Sub UserIcon_MouseLeave(sender As Object, e As EventArgs) Handles UserIcon.MouseLeave
        sender.Size = New Size(sender.Width - 5, sender.Height - 5)
        sender.Location = New Point(sender.Location.X + 2.5, sender.Location.Y + 2.5)
    End Sub

    Private Sub RiderLabel_Click(sender As Object, e As EventArgs) Handles RiderLabel.Click
        If (RiderLabel.BackColor = Color.FromName("ControlLight")) Then
            Me.Hide()
            RiderHomePage.Show()
        End If
    End Sub

    Private Sub SwapIcon_Click(sender As Object, e As EventArgs) Handles SwapIcon.Click
        If (RiderLabel.BackColor = Color.FromName("ControlLight")) Then
            Me.Hide()
            RiderHomePage.Show()
        End If
    End Sub

    Private Sub SwapIcon_Highlight(sender As Object, e As EventArgs) Handles SwapIcon.MouseEnter
        sender.Size = New Size(sender.Width + 5, sender.Height + 5)
        sender.Location = New Point(sender.Location.X - 2.5, sender.Location.Y - 2.5)
    End Sub

    Private Sub SwapIcon_Unhighlight(sender As Object, e As EventArgs) Handles SwapIcon.MouseLeave
        sender.Size = New Size(sender.Width - 5, sender.Height - 5)
        sender.Location = New Point(sender.Location.X + 2.5, sender.Location.Y + 2.5)
    End Sub

    Private Sub TripHistoryButton_Click(sender As Object, e As EventArgs) Handles TripHistoryButton.Click, HistoryIcon.Click
        If Not CollisionAlert Then
            CollisionDialog.ShowDialog()
            CollisionAlert = True
        ElseIf Not newRideAlert Then
            NewRideDialog.ShowDialog()
            newRideAlert = True
        Else
            PastTripsPage.Show()
        End If
    End Sub
    Private Sub TripStatusButton_Click(sender As Object, e As EventArgs) Handles TripStatusButton.Click
        NewRideDialog.Show()
        NewRideDialog.DeclineButton.Text = "Cancel this Ride."

    End Sub
End Class
