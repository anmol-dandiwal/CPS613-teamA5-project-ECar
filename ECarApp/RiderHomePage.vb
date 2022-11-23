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

    Private Sub ControlsButton_Click(sender As Object, e As EventArgs) Handles ControlsButton.Click, CarControlsIcon.Click
        CarControlsPage.Show()
    End Sub

    Private Sub CloseApp(sender As Object, e As EventArgs) Handles Me.Closed
        HomePage.Close()
    End Sub

    Private Sub ChatBtn_Click(sender As Object, e As EventArgs) Handles ChatBtn.Click
        Dim message, defaultValue As String
        Dim box As Object

        message = "Please type the issue you are facing."
        defaultValue = "I can't reset my password"

        box = InputBox(message, "Chat Support", defaultValue)

        MsgBox("Thank you for you message, our team will get back to you in 3-5 business days.")

    End Sub
End Class