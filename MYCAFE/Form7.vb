Public Class frmcart
    Dim i As Integer
    Dim fbill As Double

    Private Sub btngoback_Click(sender As Object, e As EventArgs) Handles btngoback.Click
        frmhome.Show()
        Me.Hide()
    End Sub

    Private Sub btngoback_MouseEnter(sender As Object, e As EventArgs) Handles btngoback.MouseEnter
        btngoback.BackColor = Color.SaddleBrown
    End Sub

    Private Sub btngoback_MouseLeave(sender As Object, e As EventArgs) Handles btngoback.MouseLeave
        btngoback.BackColor = Color.White
    End Sub

    Private Sub btnadd1_Click(sender As Object, e As EventArgs) Handles btnadd1.Click
        i = Val(q1.Text)
        i = i + 1
        q1.Text = i
    End Sub

    Private Sub btnadd2_Click(sender As Object, e As EventArgs) Handles btnadd2.Click
        i = Val(q2.Text)
        i = i + 1
        q2.Text = i
    End Sub

    Private Sub btnadd3_Click(sender As Object, e As EventArgs) Handles btnadd3.Click
        i = Val(q3.Text)
        i = i + 1
        q3.Text = i
    End Sub

    Private Sub btnadd4_Click(sender As Object, e As EventArgs) Handles btnadd4.Click
        i = Val(q4.Text)
        i = i + 1
        q4.Text = i
    End Sub

    Private Sub btnadd5_Click(sender As Object, e As EventArgs) Handles btnadd5.Click
        i = Val(q5.Text)
        i = i + 1
        q5.Text = i
    End Sub

    Private Sub btnadd6_Click(sender As Object, e As EventArgs) Handles btnadd6.Click
        i = Val(q6.Text)
        i = i + 1
        q6.Text = i
    End Sub

    Private Sub btnadd7_Click(sender As Object, e As EventArgs) Handles btnadd7.Click
        i = Val(q7.Text)
        i = i + 1
        q7.Text = i
    End Sub

    Private Sub btnadd8_Click(sender As Object, e As EventArgs) Handles btnadd8.Click
        i = Val(q8.Text)
        i = i + 1
        q8.Text = i
    End Sub

    Private Sub btnadd9_Click(sender As Object, e As EventArgs) Handles btnadd9.Click
        i = Val(q9.Text)
        i = i + 1
        q9.Text = i
    End Sub

    Private Sub btnadd10_Click(sender As Object, e As EventArgs) Handles btnadd10.Click
        i = Val(q10.Text)
        i = i + 1
        q10.Text = i
    End Sub

    Private Sub btnsub1_Click(sender As Object, e As EventArgs) Handles btnsub1.Click
        i = Val(q1.Text)
        i = i - 1
        q1.Text = i
    End Sub

    Private Sub btnsub2_Click(sender As Object, e As EventArgs) Handles btnsub2.Click
        i = Val(q2.Text)
        i = i - 1
        q2.Text = i
    End Sub

    Private Sub btnsub3_Click(sender As Object, e As EventArgs) Handles btnsub3.Click
        i = Val(q3.Text)
        i = i - 1
        q3.Text = i
    End Sub

    Private Sub btnsub4_Click(sender As Object, e As EventArgs) Handles btnsub4.Click
        i = Val(q4.Text)
        i = i - 1
        q4.Text = i
    End Sub

    Private Sub btnsub5_Click(sender As Object, e As EventArgs) Handles btnsub5.Click
        i = Val(q5.Text)
        i = i - 1
        q5.Text = i
    End Sub

    Private Sub btnsub6_Click(sender As Object, e As EventArgs) Handles btnsub6.Click
        i = Val(q6.Text)
        i = i - 1
        q6.Text = i
    End Sub

    Private Sub btnsub7_Click(sender As Object, e As EventArgs) Handles btnsub7.Click
        i = Val(q7.Text)
        i = i - 1
        q7.Text = i
    End Sub

    Private Sub btnsub8_Click(sender As Object, e As EventArgs) Handles btnsub8.Click
        i = Val(q8.Text)
        i = i - 1
        q8.Text = i
    End Sub

    Private Sub btnsub9_Click(sender As Object, e As EventArgs) Handles btnsub9.Click
        i = Val(q9.Text)
        i = i - 1
        q9.Text = i
    End Sub

    Private Sub btnsub10_Click(sender As Object, e As EventArgs) Handles btnsub10.Click
        i = Val(q10.Text)
        i = i - 1
        q10.Text = i
    End Sub

    Private Sub btnplaceorder_Click(sender As Object, e As EventArgs) Handles btnplaceorder.Click
        If Panel1.Enabled = True Then
            Dim a1 As Integer
            a1 = Val(lbl1.Text) * Val(q1.Text)
            fbill = fbill + a1
        End If
        If Panel2.Enabled = True Then
            Dim a2 As Integer
            a2 = Val(lbl2.Text) * Val(q2.Text)
            fbill = fbill + a2
        End If
        If Panel3.Enabled = True Then
            Dim a3 As Integer
            a3 = Val(lbl3.Text) * Val(q3.Text)
            fbill = fbill + a3
        End If
        If Panel4.Enabled = True Then
            Dim a4 As Integer
            a4 = Val(lbl4.Text) * Val(q4.Text)
            fbill = fbill + a4
        End If
        If Panel5.Enabled = True Then
            Dim a5 As Integer
            a5 = Val(lbl5.Text) * Val(q5.Text)
            fbill = fbill + a5
        End If
        If Panel6.Enabled = True Then
            Dim a6 As Integer
            a6 = Val(lbl6.Text) * Val(q6.Text)
            fbill = fbill + a6
        End If
        If Panel7.Enabled = True Then
            Dim a7 As Integer
            a7 = Val(lbl7.Text) * Val(q7.Text)
            fbill = fbill + a7
        End If
        If Panel8.Enabled = True Then
            Dim a8 As Integer
            a8 = Val(lbl8.Text) * Val(q8.Text)
            fbill = fbill + a8
        End If
        If Panel9.Enabled = True Then
            Dim a9 As Integer
            a9 = Val(lbl9.Text) * Val(q9.Text)
            fbill = fbill + a9
        End If
        If Panel10.Enabled = True Then
            Dim a10 As Integer
            a10 = Val(lbl10.Text) * Val(q10.Text)
            fbill = fbill + a10
        End If
        lbltotal.Text = fbill
        Label11.Visible = True
        lbltotal.Visible = True
        btnpay.Visible = True
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        frmpayment.Show()
    End Sub
End Class