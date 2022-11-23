Public Class CarControlsPage
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub BackIcon_Click(sender As Object, e As EventArgs) Handles BackIcon.Click, BackButton.Click
        Me.Close()
    End Sub

    Private Sub FocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseEnter
        BackButton.Focus()
    End Sub

    Private Sub UnfocusBackButton(sender As Object, e As EventArgs) Handles BackIcon.MouseLeave
        CarControlsLabel.Focus()
    End Sub

    Private Sub LowerTempIcon_Click(sender As Object, e As EventArgs) Handles LowerTempIcon.Click
        If Temp.Text > 16 Then
            Temp.Text -= 1
        End If
    End Sub

    Private Sub IncreaseTempIcon_Click(sender As Object, e As EventArgs) Handles IncreaseTempIcon.Click
        If Temp.Text < 24 Then
            Temp.Text += 1
        End If
    End Sub

    Private Sub FanSpeedDown_Click(sender As Object, e As EventArgs) Handles FanSpeedDown.Click
        If FanSpeed.Text > 0 Then
            FanSpeed.Text -= 1
        End If
    End Sub

    Private Sub FanSpeedUp_Click(sender As Object, e As EventArgs) Handles FanSpeedUp.Click
        If FanSpeed.Text < 5 Then
            FanSpeed.Text += 1
        End If
    End Sub

    Private Sub windowsBtn_Click(sender As Object, e As EventArgs) Handles windowsBtn.Click
        If WindowsLabel.Text.Contains("CLOSED") Then
            WindowsLabel.Text = WindowsLabel.Text.Replace("CLOSED", "OPEN")
        Else
            WindowsLabel.Text = WindowsLabel.Text.Replace("OPEN", "CLOSED")
        End If
    End Sub

    Private Sub TrunkBtn_Click(sender As Object, e As EventArgs) Handles TrunkBtn.Click
        If TrunkLabel.Text.Contains("CLOSED") Then
            TrunkLabel.Text = TrunkLabel.Text.Replace("CLOSED", "OPEN")
        Else
            TrunkLabel.Text = TrunkLabel.Text.Replace("OPEN", "CLOSED")
        End If
    End Sub

    Private Sub HeatedSeatsBtn_Click(sender As Object, e As EventArgs) Handles HeatedSeatsBtn.Click
        If HeatedSeatsLabel.Text.Contains("OFF") Then
            HeatedSeatsLabel.Text = HeatedSeatsLabel.Text.Replace("OFF", "ON")
        Else
            HeatedSeatsLabel.Text = HeatedSeatsLabel.Text.Replace("ON", "OFF")
        End If
    End Sub

    Private Sub DefrostBtn_Click(sender As Object, e As EventArgs) Handles DefrostBtn.Click
        If DefrostLabel.Text.Contains("OFF") Then
            DefrostLabel.Text = DefrostLabel.Text.Replace("OFF", "ON")
        Else
            DefrostLabel.Text = DefrostLabel.Text.Replace("ON", "OFF")
        End If
    End Sub

    Private Sub MouseDownBtn(sender As Object, e As MouseEventArgs) Handles FanSpeedUp.MouseDown, FanSpeedDown.MouseDown, LowerTempIcon.MouseDown, IncreaseTempIcon.MouseDown
        sender.BackColor = Color.Black
    End Sub

    Private Sub MouseUpBtn(sender As Object, e As MouseEventArgs) Handles FanSpeedUp.MouseUp, FanSpeedDown.MouseUp, LowerTempIcon.MouseUp, IncreaseTempIcon.MouseUp
        sender.BackColor = Color.DimGray
    End Sub
End Class