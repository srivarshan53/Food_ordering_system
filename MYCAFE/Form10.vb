Public Class frmcard
    Private Sub frmcard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblamount.Text = "rs." + frmcart.lbltotal.Text
    End Sub
    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("enter all the detials")
        Else
            frmpaymentsuccess.Show()
            Me.Close()
        End If
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        frmpayment.Show()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) = 8) Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) = 8) Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) = 8) Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Then
            e.KeyChar = Nothing
        Else
        End If
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If TextBox3.TextLength <> 3 Then
            MsgBox("enter a valid CVV")
            TextBox3.Text = ""
        End If
    End Sub
End Class