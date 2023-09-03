Imports System.Data.SqlClient
Public Class frmmyorders
    Dim cn As New SqlConnection
    Private Sub frmmyorders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MycafeDataSet.cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.MycafeDataSet.cart)
        cn = New SqlConnection("Data Source=.;Initial Catalog=mycafe;Integrated Security=True")
        cn.Open()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("select item, rate from cart where uname='" & frmlogin.txtname.Text & "'", cn)
        Using da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
        End Using
    End Sub

    Private Sub btngoback_Click(sender As Object, e As EventArgs) Handles btngoback.Click
        frmhome.Show()
        Me.Close()
    End Sub
End Class