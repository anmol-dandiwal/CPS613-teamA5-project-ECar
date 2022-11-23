Public Class FailureDialog
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        MessageBox.Show("Service Appointment Booked.", "Success", MessageBoxButtons.OK)
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        MessageBox.Show("Service Appointment Declined.", "Declined", MessageBoxButtons.OK)
        Me.Close()
    End Sub
End Class