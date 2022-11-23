Public Class NewRideDialog


    Private Sub NewRideDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotificationLabel.Text = "Guest1 is requesting a ride at " & vbCrLf & BookARidePage.dateOfRide & vbCrLf
        NotificationBodyLabel.Text = "From: " & BookARidePage.fromAddress & "." & vbCrLf & "To: " & BookARidePage.destinationAddress & "."
        CancelScheduledRide.Hide()
        ReturnToHomePage.Hide()
    End Sub

    Private Sub DeclineButton_Click(sender As Object, e As EventArgs) Handles DeclineButton.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub AcceptButton_Click(sender As Object, e As EventArgs) Handles AcceptButton.Click
        Me.Hide()
        HomePage.TripStatusButton.Show()
        HomePage.TripStatusCarPicture.Show()
        HomePage.CurrLocationLabel.Hide()
        AcceptButton.Hide()
        DeclineButton.Hide()
        CancelScheduledRide.Show()
        ReturnToHomePage.Show()
        HomePage.Show()
    End Sub

    Private Sub CancelScheduledRide_Click(sender As Object, e As EventArgs) Handles CancelScheduledRide.Click
        Me.Hide()
        CancelScheduledRide.Hide()
        ReturnToHomePage.Hide()
        HomePage.TripStatusButton.Hide()
        HomePage.TripStatusCarPicture.Hide()
        HomePage.CurrLocationLabel.Show()
        HomePage.Show()
    End Sub

    Private Sub ReturnToHomePage_Click(sender As Object, e As EventArgs) Handles ReturnToHomePage.Click
        Me.Hide()
        HomePage.Show()
    End Sub
End Class