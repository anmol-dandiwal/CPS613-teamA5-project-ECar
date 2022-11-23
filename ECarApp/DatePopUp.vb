Public Class DatePopUp
    Private Sub SetAvailButton_Click(sender As Object, e As EventArgs) Handles SetAvailButton.Click
        Dim availDate = New Date(2022, 11, 30)
        SchedulePage.Calendar.AddBoldedDate(availDate)
        If SchedulePage.Calendar.BoldedDates.Length = 1 Then
            SchedulePage.Calendar.AddBoldedDate(availDate.AddDays(7))
            SchedulePage.Calendar.AddBoldedDate(availDate.AddDays(14))
            SchedulePage.Calendar.AddBoldedDate(availDate.AddDays(21))
            SchedulePage.Calendar.AddBoldedDate(availDate.AddDays(28))
            SchedulePage.Calendar.AddBoldedDate(availDate.AddDays(35))
        Else
            For i As Integer = 1 To 30
                SchedulePage.Calendar.AddBoldedDate(availDate.AddDays(i))
            Next
        End If
        SchedulePage.Calendar.UpdateBoldedDates()
        Me.Close()
    End Sub
End Class