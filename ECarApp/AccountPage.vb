Public Class AccountPage
    Private Sub RiderLabel_Click(sender As Object, e As EventArgs) Handles RiderLabel.Click
        sender.BackColor = Color.FromName("ControlDark")
        sender.ForeColor = Color.FromName("ControlLightLight")
        OwnerLabel.BackColor = Color.FromName("ControlLight")
        OwnerLabel.ForeColor = Color.FromName("ControlText")
    End Sub

    Private Sub OwnerLabel_Click(sender As Object, e As EventArgs) Handles OwnerLabel.Click
        sender.BackColor = Color.FromName("ControlDark")
        sender.ForeColor = Color.FromName("ControlLightLight")
        RiderLabel.BackColor = Color.FromName("ControlLight")
        RiderLabel.ForeColor = Color.FromName("ControlText")
    End Sub

    Private Sub SwapIcon_Click(sender As Object, e As EventArgs) Handles SwapIcon.Click
        If (RiderLabel.BackColor = Color.FromName("ControlLight")) Then
            RiderLabel_Click(RiderLabel, e)
        Else
            OwnerLabel_Click(OwnerLabel, e)
        End If
    End Sub

    Private Sub SwapIcon_Highlight(sender As Object, e As EventArgs) Handles SwapIcon.MouseEnter
        SwapIcon.Size = New Size(SwapIcon.Width + 5, SwapIcon.Height + 5)
        SwapIcon.Location = New Point(SwapIcon.Location.X - 2.5, SwapIcon.Location.Y - 2.5)
    End Sub

    Private Sub SwapIcon_Unhighlight(sender As Object, e As EventArgs) Handles SwapIcon.MouseLeave
        SwapIcon.Size = New Size(SwapIcon.Width - 5, SwapIcon.Height - 5)
        SwapIcon.Location = New Point(SwapIcon.Location.X + 2.5, SwapIcon.Location.Y + 2.5)
    End Sub
End Class