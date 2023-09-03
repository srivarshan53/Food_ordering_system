Imports System.Data.SqlClient
Public Class frmregister
    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnregister_MouseEnter(sender As Object, e As EventArgs) Handles btnregister.MouseEnter
        btnregister.BackColor = Color.SaddleBrown
        btnregister.ForeColor = Color.White
    End Sub
    Private Sub btnregister_MouseLeave(sender As Object, e As EventArgs) Handles btnregister.MouseLeave
        btnregister.BackColor = Color.White
        btnregister.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim cn As New SqlConnection
        cn = New SqlConnection("Data Source=.;Initial Catalog=mycafe;Integrated Security=True")
        cn.Open()
        If txtpword.Text <> txtconfirm.Text Then
            MsgBox("no matching password", MsgBoxStyle.Critical)
        Else
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("insert into login(name,phone,pword)values('" & txtname.Text & "'," & txtphone.Text & ",'" & txtconfirm.Text & "')", cn)
            cmd.ExecuteNonQuery()
            frmlogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtphone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtphone.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) = 8) Then
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtphone_LostFocus(sender As Object, e As EventArgs) Handles txtphone.LostFocus
        If txtphone.TextLength <> 10 Then
            MsgBox("enter a valid mobile number")
            txtphone.Text = ""
        End If
    End Sub
End Class