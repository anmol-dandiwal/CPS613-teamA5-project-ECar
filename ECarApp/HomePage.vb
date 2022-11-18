Imports System.Security.Authentication.ExtendedProtection

Public Class HomePage
    Private Sub ScheduleButton_Click(sender As Object, e As EventArgs) Handles ScheduleButton.Click, CalendarIcon.Click
        SchedulePage.Show()
    End Sub

    Private Sub UserIcon_Click(sender As Object, e As EventArgs) Handles UserIcon.Click
        AccountPage.Show()
    End Sub
End Class
