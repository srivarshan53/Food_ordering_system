Imports System.Data.SqlClient
Public Class frmlogin

    Private Sub lbllogin_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        frmregister.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogin_MouseEnter(sender As Object, e As EventArgs) Handles btnlogin.MouseEnter
        btnlogin.BackColor = Color.SaddleBrown
        btnlogin.ForeColor = Color.White
    End Sub

    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave
        btnlogin.BackColor = Color.White
        btnlogin.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        If txtname.Text = "" Or txtpword.Text = "" Then
            MsgBox("enter all the details")
        End If
        cn = New SqlConnection("Data Source=.;Initial Catalog=mycafe;Integrated Security=True")
        cn.Open()
        cmd = New SqlCommand("select * from login where name='" & txtname.Text & "' and pword='" & txtpword.Text & "'", cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows = True Then
            frmhome.Show()
            Me.Hide()
        Else
            MsgBox("invalid name or password", MsgBoxStyle.Exclamation, "mycafe")
        End If
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If (Asc(e.KeyChar) >= 48) And (Asc(e.KeyChar) <= 57) Then
            e.KeyChar = Nothing
        End If
    End Sub
End Class