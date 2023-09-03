Public Class frmpaymentsuccess
    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        frmhome.Close()
        frmhome.Show()
        Me.Close()
        frmcart.Close()
    End Sub
End Class