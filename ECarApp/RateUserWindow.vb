Public Class RateUserWindow
    Private Sub Stars_Click(sender As Object, e As EventArgs) Handles Stars.Click
        MsgBox("Your submission was recorded, thank you!", MsgBoxStyle.SystemModal, "Rate your ride")
        If MsgBoxResult.Ok Then
            Me.Hide()
        End If
    End Sub
End Class