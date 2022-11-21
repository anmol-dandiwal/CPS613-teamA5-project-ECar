Public Class RiderHomePage
    Private Sub RiderLabel_Click(sender As Object, e As EventArgs) Handles RiderLabel.Click
        sender.BackColor = Color.FromName("ControlDark")
        sender.ForeColor = Color.FromName("ControlLightLight")
        OwnerLabel.BackColor = Color.FromName("ControlLight")
        OwnerLabel.ForeColor = Color.FromName("ControlText")
    End Sub

    Private Sub OwnerLabel_Click(sender As Object, e As EventArgs) Handles OwnerLabel.Click
        sender.BackColor = Color.FromName("ControlDark")
        sender.ForeColor = Color.FromName("ControlLightLight")
        RiderLabel.BackColor = Color.FromName("ControlLight")
        RiderLabel.ForeColor = Color.FromName("ControlText")
    End Sub

    Private Sub SwapIcon_Click(sender As Object, e As EventArgs) Handles SwapIcon.Click
        If (OwnerLabel.BackColor = Color.FromName("ControlLight")) Then
            RiderLabel_Click(RiderLabel, e)
            Me.Hide()
            HomePage.Show()
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

    Private Sub pastTripButton_Click(sender As Object, e As EventArgs) Handles pastTripButton.Click, HistoryIcon.Click
        RiderPastTripsPage.Show()
    End Sub

End Class