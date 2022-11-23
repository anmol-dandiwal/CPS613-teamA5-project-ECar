Public Class SchedulePage
    Private Sub BackIcon_Click(sender As Object, e As EventArgs) Handles BackIcon.Click, BackButton.Click
        Me.Close()
    End Sub

    Private Sub FocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseEnter
        BackButton.Focus()
    End Sub

    Private Sub UnfocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseLeave
        ScheduleLabel.Focus()
    End Sub

    Private Sub DatePicker_ValueChanged(sender As Object, e As EventArgs)
        DatePopUp.Show()
    End Sub

    Private Sub Calendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendar.DateSelected
        DatePopUp.Show()
        If Calendar.BoldedDates.Length > 0 Then
            DatePopUp.HourPicker1.SelectedText = "12"
            DatePopUp.MinutePicker1.SelectedText = "00"
            DatePopUp.AmPmPicker1.SelectedText = "PM"
            DatePopUp.HourPicker2.SelectedText = "04"
            DatePopUp.MinutePicker2.SelectedText = "00"
            DatePopUp.AmPmPicker2.SelectedText = "PM"
            DatePopUp.RepeatPicker.SelectedText = "Weekly"
        End If
    End Sub
End Class