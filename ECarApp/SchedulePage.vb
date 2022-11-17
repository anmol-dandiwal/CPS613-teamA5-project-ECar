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
End Class