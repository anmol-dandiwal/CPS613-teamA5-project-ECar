Public Class ConfirmedRidePopup
    Sub ConfirmedRidePopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfirmedRideMessage.Text = "Your driver is arriving at: " & BookARidePage.fromAddress & "." & vbCrLf & vbCrLf & "Your ride to " & BookARidePage.destinationAddress & " is here. "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RiderPastTripsPage.setUpTable()
        RiderPastTripsPage.riderPastTrips.Rows.Add("Nov 24, 2022", "$14.00", "12 KM")
        RiderPastTripsPage.RiderPastTripsTable.DataSource = RiderPastTripsPage.riderPastTrips
        RateUserWindow.Show()
        Me.Hide()
    End Sub

End Class