Public Class RiderHomePage
    Private Sub RiderHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BookARidePage.isRideScheduled = False Then
            EditButton.Hide()
            DeleteTripButton.Hide()
            ViewTripStatusButton.Hide()
        End If
    End Sub
    Private Sub RiderLabel_Click(sender As Object, e As EventArgs) Handles RiderLabel.Click
        sender.BackColor = Color.FromName("ControlDark")
        sender.ForeColor = Color.FromName("ControlLightLight")
        OwnerLabel.BackColor = Color.FromName("ControlLight")
        OwnerLabel.ForeColor = Color.FromName("ControlText")
    End Sub

    Private Sub OwnerLabel_Click(sender As Object, e As EventArgs) Handles OwnerLabel.Click
        If (OwnerLabel.BackColor = Color.FromName("ControlLight")) Then
            RiderLabel_Click(RiderLabel, e)
            Me.Hide()
            HomePage.Show()
        End If
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

    Private Sub BookRideButton_Click(sender As Object, e As EventArgs) Handles BookRideButton.Click
        BookARidePage.Show()
    End Sub

    Private Sub XButton_Click(sender As Object, e As EventArgs) Handles XButton.Click
        If BookARidePage.isRideScheduled = True And BookARidePage.dateOfRide = Today.Date Then
            StatusWindow.Text = "You currently do not have a ride scheduled."
        End If
        BookARidePage.isRideScheduled = False
        StatusWindow.Hide()
        XButton.Hide()
        EditButton.Hide()
        DeleteTripButton.Hide()
        ViewTripStatusButton.Show()

    End Sub

    Private Sub RiderHomePage_Shown(sender As Object, e As EventArgs) Handles Me.Activated
        StatusWindow.Show()
        XButton.Show()
        If BookARidePage.isRideScheduled = True And BookARidePage.dateOfRide = Today.Date Then
            StatusWindow.Text = "Your driver is arriving at your pick-up location." & vbCrLf & vbCrLf & "Your ride to " & BookARidePage.destinationAddress & " is here."
            EditButton.Hide()
            DeleteTripButton.Hide()
        ElseIf BookARidePage.isRideScheduled = True And BookARidePage.dateOfRide IsNot Today.ToString() Then
            StatusWindow.Text = "Your ride to " & BookARidePage.destinationAddress & " is scheduled for: " & BookARidePage.dateOfRide & ". "
            EditButton.Show()
            DeleteTripButton.Show()
        End If
    End Sub
    Private Sub DeleteTripButton_Click(sender As Object, e As EventArgs) Handles DeleteTripButton.Click
        BookARidePage.isRideScheduled = False
        StatusWindow.Text = "You currently do not have a ride scheduled."
        EditButton.Hide()
        DeleteTripButton.Hide()
    End Sub
    Private Sub EditTripButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        BookARidePage.Show()
        Me.Hide()
    End Sub

    Private Sub ViewTripStatusButton_Click(sender As Object, e As EventArgs) Handles ViewTripStatusButton.Click
        If StatusWindow.Text = "You currently do not have a ride scheduled." Then
            EditButton.Hide()
            DeleteTripButton.Hide()
        Else
            EditButton.Show()
            DeleteTripButton.Show()
        End If
        StatusWindow.Show()
        XButton.Show()
        ViewTripStatusButton.Hide()

    End Sub
End Class