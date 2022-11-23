Public Class IntrusionDialog
    Private Sub YesButton_Click(sender As Object, e As EventArgs) Handles YesButton.Click
        MessageBox.Show("Authroities are en route.", "Success", MessageBoxButtons.OK)
        Me.Close()
    End Sub

    Private Sub NoButton_Click(sender As Object, e As EventArgs) Handles NoButton.Click
        MessageBox.Show("Emergency services declined.", "Declined", MessageBoxButtons.OK)
        Me.Close()
    End Sub
End Class