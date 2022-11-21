Imports System.Data.DataTable
Public Class PastTripsPage
    Dim pastTrips As New DataTable("Table")
    Private Sub BackIcon_Click(sender As Object, e As EventArgs) Handles BackIcon.Click, BackButton.Click
        Me.Close()
    End Sub

    Private Sub FocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseEnter
        BackButton.Focus()
    End Sub

    Private Sub UnfocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseLeave
        PastTripsLabel.Focus()
    End Sub

    Private Sub PopulatePastTrips()
        pastTrips.Columns.Add("Rider Name")
        pastTrips.Columns.Add("Cost")
        pastTrips.Columns.Add("Distance")

        pastTrips.Rows.Add("Jeff A", "$10.23", "5KM")
        pastTrips.Rows.Add("Malcom B", "$12.49", "6KM")
        pastTrips.Rows.Add("Taylor C", "$6.23", "1KM")
        pastTrips.Rows.Add("Frankie D", "$20.21", "12KM")
        pastTrips.Rows.Add("Homer E", "$23.10", "13KM")
        pastTrips.Rows.Add("Justin F", "$13.19", "6KM")
        pastTrips.Rows.Add("Homer G", "$19.21", "16KM")
        pastTrips.Rows.Add("Tyron H", "$15.39", "14KM")
        pastTrips.Rows.Add("Robert I", "$9.31", "8KM")
        pastTrips.Rows.Add("Fassie J", "$24.81", "20KM")
        pastTrips.Rows.Add("Earl K", "$39.21", "41KM")
        pastTrips.Rows.Add("Qoui L", "$42.41", "44KM")
        pastTrips.Rows.Add("Kate M", "$13.99", "10KM")

        PastTripsTable.DataSource = pastTrips
    End Sub

    Private Sub PastTripsPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulatePastTrips()
    End Sub
End Class