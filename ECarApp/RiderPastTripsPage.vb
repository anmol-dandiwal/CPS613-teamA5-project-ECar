Imports System.Data.DataTable
Public Class RiderPastTripsPage
    Dim riderPastTrips As New DataTable("Table")

    Private Sub BackIcon_Click(sender As Object, e As EventArgs) Handles BackIcon.Click, BackButton.Click
        Me.Close()
    End Sub

    Private Sub FocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseEnter
        BackButton.Focus()
    End Sub

    Private Sub UnfocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseLeave
        RiderPastTripsLabel.Focus()
    End Sub

    Private Sub PopulatePastTrips()
        riderPastTrips.Columns.Add("Date")
        riderPastTrips.Columns.Add("Cost")
        riderPastTrips.Columns.Add("Distance")

        riderPastTrips.Rows.Add("May 19, 2019", "$10.23", "5KM")
        riderPastTrips.Rows.Add("Jan 29, 2019", "$12.49", "6KM")
        riderPastTrips.Rows.Add("May 05, 2016", "$6.23", "1KM")
        riderPastTrips.Rows.Add("Mar 20, 2019", "$20.21", "12KM")
        riderPastTrips.Rows.Add("Feb 15, 2018", "$23.10", "13KM")
        riderPastTrips.Rows.Add("Feb 11, 2018", "$13.19", "6KM")
        riderPastTrips.Rows.Add("Dec 05, 2017", "$19.21", "16KM")
        riderPastTrips.Rows.Add("Nov 29, 2017", "$15.39", "14KM")
        riderPastTrips.Rows.Add("Nov 10, 2017", "$9.31", "8KM")
        riderPastTrips.Rows.Add("Nov 01, 2017", "$24.81", "20KM")
        riderPastTrips.Rows.Add("Oct 31, 2017", "$39.21", "41KM")
        riderPastTrips.Rows.Add("Oct 21, 2017", "$42.41", "44KM")
        riderPastTrips.Rows.Add("Oct 13, 2017", "$13.99", "10KM")

        RiderPastTripsTable.DataSource = riderPastTrips
    End Sub

    Private Sub PastTripsPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulatePastTrips()
    End Sub


End Class