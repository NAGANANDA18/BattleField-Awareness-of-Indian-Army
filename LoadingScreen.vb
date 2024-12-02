Public Class LoadingScreen
    Dim I As Integer
    Private Sub LoadingTimer_Tick(sender As System.Object, e As System.EventArgs) Handles LoadingTimer.Tick
        If I = 100 Then
            LoadingTimer.Enabled = False
            LoadingTimer2.Enabled = False
            Me.Hide()
            Login.Show()
        ElseIf I Mod 20 = 0 Then
            Label1.Text += "."
        End If
        I += 2
    End Sub

    Private Sub LoadingTimer2_Tick(sender As System.Object, e As System.EventArgs) Handles LoadingTimer2.Tick
        PictureBox2.Size = New Size(PictureBox2.Size.Width - 50, PictureBox2.Size.Height)
    End Sub
End Class