Public Class Form2
    Private Sub btnregister_mouseenter(sender As Object, e As EventArgs) Handles btnregister.MouseEnter
        btnregister.BackColor = Color.SaddleBrown
        btnregister.ForeColor = Color.White
    End Sub
    Private Sub btnregister_MouseLeave(sender As Object, e As EventArgs) Handles btnregister.MouseLeave
        btnregister.BackColor = Color.White
        btnregister.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnlogin_mouseenter(sender As Object, e As EventArgs) Handles btnlogin.MouseEnter
        btnlogin.BackColor = Color.SaddleBrown
        btnlogin.ForeColor = Color.White
    End Sub
    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave
        btnlogin.BackColor = Color.White
        btnlogin.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        frmregister.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        frmlogin.Show()
        Me.Hide()
    End Sub


End Class