Public Class frmupi
    Private Sub frmupi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblamount.Text = "rs." + frmcart.lbltotal.Text
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        If TextBox1.Text = "" Then
            MsgBox("enter the upi pin")
        Else
            frmpaymentsuccess.Show()
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        frmpayment.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.TextLength > 6 Then
            MsgBox("enter a valid UPI pin")
            TextBox1.Text = ""
        End If
    End Sub
End Class