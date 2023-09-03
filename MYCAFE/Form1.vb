Public Class frmlogo
    Private Sub tmrlogo_Tick(sender As Object, e As EventArgs) Handles tmrlogo.Tick
        If tmrlogo.Interval = 3000 Then
            tmrlogo.Enabled = False
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class
