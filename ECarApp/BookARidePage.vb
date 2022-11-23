Public Class BookARidePage
    Public fromAddress As String = "George Vari Engineering and Computing Centre, ENG, 245 Church St, Toronto, ON M5B 1Z4"
    Public destinationAddress As String = "CN Tower, Front Street West, Toronto, ON"
    Public dateOfRide As String = FormatDateTime(Now, DateFormat.ShortDate).ToString()
    Public isRideScheduled As Boolean = False
    Dim timer As Timer = New Timer
    Private Sub BookARidePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ScheduleNowButton.PerformClick()
        FromAddressInput.Text = fromAddress
        DestinationAddressInput.Text = destinationAddress
    End Sub

    Private Sub ScheduleNowRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ScheduleNowButton.CheckedChanged
        If ScheduleNowButton.Checked Then
            dateOfRide = FormatDateTime(Now, DateFormat.ShortDate).ToString()
            DatePickerInput.Value = Now
            DatePickerInput.Hide()
        Else
            DatePickerInput.Show()
        End If
    End Sub

    Private Sub ScheduleLaterButton_CheckedChanged(sender As Object, e As EventArgs)
        DatePickerInput.Show()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        RiderHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        isRideScheduled = True
        dateOfRide = FormatDateTime(DatePickerInput.Value, DateFormat.ShortDate).ToString()
        RiderHomePage.Show()
        If dateOfRide = FormatDateTime(Now, DateFormat.ShortDate).ToString() Then
            ConfirmedRidePopup.Show()

        Else
            ConfirmedRidePopup.Hide()
        End If

        Me.Hide()

    End Sub

    Private Sub DatePickerInput_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerInput.ValueChanged
        dateOfRide = e.ToString
    End Sub

    Private Sub CancelButton_Click_1(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Hide()
        RiderHomePage.Show()
    End Sub

    Private Sub FromAddressInput_TextChanged(sender As Object, e As EventArgs) Handles FromAddressInput.TextChanged
        fromAddress = FromAddressInput.Text
    End Sub

    Private Sub DestinationAddressInput_TextChanged(sender As Object, e As EventArgs) Handles DestinationAddressInput.TextChanged
        destinationAddress = DestinationAddressInput.Text
    End Sub

    Private Sub BookARidePage_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub
End Class