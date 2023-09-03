Imports System.Data.SqlClient
Public Class frmprofile
    Private Sub btngoback_Click(sender As Object, e As EventArgs) Handles btngoback.Click
        frmhome.Show()
        Me.Hide()
    End Sub

    Private Sub frmprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        cn = New SqlConnection("Data Source=.;Initial Catalog=mycafe;Integrated Security=True")
        cn.Open()
        cmd = New SqlCommand("select * from login where name ='" & frmlogin.txtname.Text & "'", cn)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.Read Then
            lblname.Text = dr.GetValue(0)
            txtphone.Text = dr.GetValue(1)
        End If

    End Sub

    Private Sub btngoback_MouseEnter(sender As Object, e As EventArgs) Handles btngoback.MouseEnter
        btngoback.BackColor = Color.SaddleBrown
        btngoback.ForeColor = Color.White
    End Sub

    Private Sub btngoback_MouseLeave(sender As Object, e As EventArgs) Handles btngoback.MouseLeave
        btngoback.BackColor = Color.White
        btngoback.ForeColor = Color.SaddleBrown
    End Sub
End Class