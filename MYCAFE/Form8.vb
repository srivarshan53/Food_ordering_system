Public Class frmpayment
    Private Sub btngoback_Click(sender As Object, e As EventArgs) Handles btngoback.Click
        frmcart.Show()
        Me.Close()
    End Sub

    Private Sub btncard_Click(sender As Object, e As EventArgs) Handles btncard.Click
        frmcard.Show()
        Me.Hide()
    End Sub

    Private Sub btngpay_Click(sender As Object, e As EventArgs) Handles btngpay.Click
        frmupi.Show()
        Me.Hide()
    End Sub

    Private Sub btnphonepe_Click(sender As Object, e As EventArgs) Handles btnphonepe.Click
        frmupi.Show()
        Me.Hide()
    End Sub

    Private Sub btncash_Click(sender As Object, e As EventArgs) Handles btncash.Click
        frmpaymentsuccess.Show()
        Me.Close()
    End Sub
End Class