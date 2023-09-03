Imports System.Data.SqlClient
Public Class frmhome
    Dim cn As New SqlConnection
    Private Sub frmhome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlmenu.Hide()
        pnloffer1.Hide()
        picprevious.Hide()
        pnlhome.Show()
        pnlbeverages.Hide()
        pnldesserts.Hide()
        pnlsides.Hide()
        pnlfrozen.Hide()
        cn = New SqlConnection("Data Source=.;Initial Catalog=mycafe;Integrated Security=True")
        cn.Open()
        If frmlogin.txtname.Text = "" Then
            lblhi.Text = "Hi" & frmregister.txtname.Text
        Else
            lblhi.Text = "Hi" & frmlogin.txtname.Text
        End If
    End Sub
    Private Sub picmenu_Click(sender As Object, e As EventArgs) Handles picmenu.Click
        pnlmenu.Show()
    End Sub

    Private Sub btnbeverages_MouseEnter(sender As Object, e As EventArgs) Handles btnbeverages.MouseEnter
        btnbeverages.BackColor = Color.SaddleBrown
        btnbeverages.ForeColor = Color.White
    End Sub

    Private Sub btnbeverages_MouseLeave(sender As Object, e As EventArgs) Handles btnbeverages.MouseLeave
        btnbeverages.BackColor = Color.White
        btnbeverages.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btndesserts_MouseEnter(sender As Object, e As EventArgs) Handles btndesserts.MouseEnter
        btndesserts.BackColor = Color.SaddleBrown
        btndesserts.ForeColor = Color.White
    End Sub

    Private Sub btndesserts_MouseLeave(sender As Object, e As EventArgs) Handles btndesserts.MouseLeave
        btndesserts.BackColor = Color.White
        btndesserts.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnfrozen_MouseEnter(sender As Object, e As EventArgs) Handles btnfrozen.MouseEnter
        btnfrozen.BackColor = Color.SaddleBrown
        btnfrozen.ForeColor = Color.White
    End Sub

    Private Sub btnfrozen_MouseLeave(sender As Object, e As EventArgs) Handles btnfrozen.MouseLeave
        btnfrozen.BackColor = Color.White
        btnfrozen.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnsides_MouseEnter(sender As Object, e As EventArgs) Handles btnsides.MouseEnter
        btnsides.BackColor = Color.SaddleBrown
        btnsides.ForeColor = Color.White
    End Sub

    Private Sub btnsides_MouseLeave(sender As Object, e As EventArgs) Handles btnsides.MouseLeave
        btnsides.BackColor = Color.White
        btnsides.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnoffer1_MouseEnter(sender As Object, e As EventArgs) Handles btnoffer2.MouseEnter
        btnoffer2.BackColor = Color.SaddleBrown
        btnoffer2.ForeColor = Color.White
    End Sub

    Private Sub btnoffer1_MouseLeave(sender As Object, e As EventArgs) Handles btnoffer2.MouseLeave
        btnoffer2.BackColor = Color.White
        btnoffer2.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnoffer2_MouseEnter(sender As Object, e As EventArgs)
        btnoffer1.BackColor = Color.SaddleBrown
        btnoffer1.ForeColor = Color.White
    End Sub

    Private Sub btnoffer2_MouseLeave(sender As Object, e As EventArgs)
        btnoffer1.BackColor = Color.White
        btnoffer1.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnpopular1_MouseEnter(sender As Object, e As EventArgs) Handles btnpopular1.MouseEnter
        btnpopular1.BackColor = Color.SaddleBrown
        btnpopular1.ForeColor = Color.White
    End Sub

    Private Sub btnpopular1_MouseLeave(sender As Object, e As EventArgs) Handles btnpopular1.MouseLeave
        btnpopular1.BackColor = Color.White
        btnpopular1.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnpopular2_MouseEnter(sender As Object, e As EventArgs) Handles btnpopular2.MouseEnter
        btnpopular2.BackColor = Color.SaddleBrown
        btnpopular2.ForeColor = Color.White
    End Sub

    Private Sub btnpopular2_MouseLeave(sender As Object, e As EventArgs) Handles btnpopular2.MouseLeave
        btnpopular2.BackColor = Color.White
        btnpopular2.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnpopular3_MouseEnter(sender As Object, e As EventArgs) Handles btnpopular3.MouseEnter
        btnpopular3.BackColor = Color.SaddleBrown
        btnpopular3.ForeColor = Color.White
    End Sub

    Private Sub btnpopular3_MouseLeave(sender As Object, e As EventArgs) Handles btnpopular3.MouseLeave
        btnpopular3.BackColor = Color.White
        btnpopular3.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnpopular4_MouseEnter(sender As Object, e As EventArgs) Handles btnpopular4.MouseEnter
        btnpopular4.BackColor = Color.SaddleBrown
        btnpopular4.ForeColor = Color.White
    End Sub

    Private Sub btnpopular4_MouseLeave(sender As Object, e As EventArgs) Handles btnpopular4.MouseLeave
        btnpopular4.BackColor = Color.White
        btnpopular4.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnpopular5_MouseEnter(sender As Object, e As EventArgs) Handles btnpopular5.MouseEnter
        btnpopular5.BackColor = Color.SaddleBrown
        btnpopular5.ForeColor = Color.White
    End Sub

    Private Sub btnpopular5_MouseLeave(sender As Object, e As EventArgs) Handles btnpopular5.MouseLeave
        btnpopular5.BackColor = Color.White
        btnpopular5.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnpopular6_MouseEnter(sender As Object, e As EventArgs) Handles btnpopular6.MouseEnter
        btnpopular6.BackColor = Color.SaddleBrown
        btnpopular6.ForeColor = Color.White
    End Sub

    Private Sub btnpopular6_MouseLeave(sender As Object, e As EventArgs) Handles btnpopular6.MouseLeave
        btnpopular6.BackColor = Color.White
        btnpopular6.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub picprevious_Click(sender As Object, e As EventArgs) Handles picprevious.Click
        pnloffer2.Show()
        pnloffer1.Hide()
        picnext.Show()
        picprevious.Hide()
    End Sub

    Private Sub picnext_Click(sender As Object, e As EventArgs) Handles picnext.Click
        pnloffer1.Show()
        pnloffer2.Hide()
        picprevious.Show()
        picnext.Hide()
    End Sub

    Private Sub picmenu_MouseEnter(sender As Object, e As EventArgs) Handles picmenu.MouseEnter
        picmenu.BackColor = Color.SaddleBrown
    End Sub

    Private Sub picmenu_MouseLeave(sender As Object, e As EventArgs) Handles picmenu.MouseLeave
        picmenu.BackColor = Color.White
    End Sub
    Private Sub btnhome_click(sender As Object, e As EventArgs) Handles btnhome.Click
        pnlhome.Show()
        pnlmenu.Hide()
        pnlbeverages.Hide()
        pnldesserts.Hide()
        pnlsides.Hide()
        pnlfrozen.Hide()
        lbltitle.Text = "Home"
    End Sub
    Private Sub btnpopular1_Click(sender As Object, e As EventArgs) Handles btnpopular1.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cappuccino',169)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cappuccino"
            frmcart.lbl1.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cappuccino"
            frmcart.lbl2.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cappuccino"
            frmcart.lbl3.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cappuccino"
            frmcart.lbl4.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cappuccino"
            frmcart.lbl5.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cappuccino"
            frmcart.lbl6.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cappuccino"
            frmcart.lbl7.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cappuccino"
            frmcart.lbl8.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cappuccino"
            frmcart.lbl9.Text = " 169/-"
            btnpopular1.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cappuccino"
            frmcart.lbl10.Text = " 169/-"
            btnpopular1.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnpopular2_Click(sender As Object, e As EventArgs) Handles btnpopular2.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cafelatteregular',169)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cafelatte"
            frmcart.lbl1.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cafelatte"
            frmcart.lbl2.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cafelatte"
            frmcart.lbl3.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cafelatte"
            frmcart.lbl4.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cafelatte"
            frmcart.lbl5.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cafelatte"
            frmcart.lbl6.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cafelatte"
            frmcart.lbl7.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cafelatte"
            frmcart.lbl8.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cafelatte"
            frmcart.lbl9.Text = " 169/-"
            btnpopular2.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cafelatte"
            frmcart.lbl10.Text = " 169/-"
            btnpopular2.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnpopular3_Click(sender As Object, e As EventArgs) Handles btnpopular3.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chocolavacup',109)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chocolava"
            frmcart.lbl1.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chocolava"
            frmcart.lbl2.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chocolava"
            frmcart.lbl3.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chocolava"
            frmcart.lbl4.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chocolava"
            frmcart.lbl5.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chocolava"
            frmcart.lbl6.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chocolava"
            frmcart.lbl7.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chocolava"
            frmcart.lbl8.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chocolava"
            frmcart.lbl9.Text = " 109/-"
            btnpopular3.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chocolava"
            frmcart.lbl10.Text = " 109/-"
            btnpopular3.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnpopular4_Click(sender As Object, e As EventArgs) Handles btnpopular4.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','vanillablueberrymuffin',119)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "vanillamuffin"
            frmcart.lbl1.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "vanillamuffin"
            frmcart.lbl2.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "vanillamuffin"
            frmcart.lbl3.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "vanillamuffin"
            frmcart.lbl4.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "vanillamuffin"
            frmcart.lbl5.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "vanillamuffin"
            frmcart.lbl6.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "vanillamuffin"
            frmcart.lbl7.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "vanillamuffin"
            frmcart.lbl8.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "vanillamuffin"
            frmcart.lbl9.Text = " 119/-"
            btnpopular4.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "vanillamuffin"
            frmcart.lbl10.Text = " 119/-"
            btnpopular4.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnpopular5_Click(sender As Object, e As EventArgs) Handles btnpopular5.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chickendumplings',410)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "dumplings"
            frmcart.lbl1.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "dumplings"
            frmcart.lbl2.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "dumplings"
            frmcart.lbl3.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "dumplings"
            frmcart.lbl4.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "dumplings"
            frmcart.lbl5.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "dumplings"
            frmcart.lbl6.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "dumplings"
            frmcart.lbl7.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "dumplings"
            frmcart.lbl8.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "dumplings"
            frmcart.lbl9.Text = " 410/-"
            btnpopular5.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "dumplings"
            frmcart.lbl10.Text = " 410/-"
            btnpopular5.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnpopular6_Click(sender As Object, e As EventArgs) Handles btnpopular6.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chocofudgesundae',175)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chocosundae"
            frmcart.lbl1.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chocosundae"
            frmcart.lbl2.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chocosundae"
            frmcart.lbl3.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chocosundae"
            frmcart.lbl4.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chocosundae"
            frmcart.lbl5.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chocosundae"
            frmcart.lbl6.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chocosundae"
            frmcart.lbl7.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chocosundae"
            frmcart.lbl8.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chocosundae"
            frmcart.lbl9.Text = " 175/-"
            btnpopular6.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chocosundae"
            frmcart.lbl10.Text = " 175/-"
            btnpopular6.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnoffer1_Click(sender As Object, e As EventArgs)
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','supersaver1',521)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "supersaver1"
            frmcart.lbl1.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "supersaver1"
            frmcart.lbl2.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "supersaver1"
            frmcart.lbl3.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "supersaver1"
            frmcart.lbl4.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "supersaver1"
            frmcart.lbl5.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "supersaver1"
            frmcart.lbl6.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "supersaver1"
            frmcart.lbl7.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "supersaver1"
            frmcart.lbl8.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "supersaver1"
            frmcart.lbl9.Text = " 521/-"
            btnoffer1.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "supersaver1"
            frmcart.lbl10.Text = " 521/-"
            btnoffer1.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnoffer2_Click(sender As Object, e As EventArgs) Handles btnoffer2.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','supersaver2',516)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "supersaver2"
            frmcart.lbl1.Text = " 516/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "supersaver2"
            frmcart.lbl2.Text = " 516/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "supersaver2"
            frmcart.lbl3.Text = " 516/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "supersaver2"
            frmcart.lbl4.Text = " 516/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "supersaver2"
            frmcart.lbl5.Text = " 516/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "supersaver2"
            frmcart.lbl6.Text = " 512/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "supersaver2"
            frmcart.lbl7.Text = " 512/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "supersaver2"
            frmcart.lbl8.Text = " 512/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "supersaver2"
            frmcart.lbl9.Text = " 512/-"
            btnoffer2.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "supersaver2"
            frmcart.lbl10.Text = " 512/-"
            btnoffer2.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnbeverages_Click(sender As Object, e As EventArgs) Handles btnbeverages.Click
        pnlbeverages.Show()
        pnldesserts.Hide()
        pnlhome.Hide()
        pnlsides.Hide()
        pnlfrozen.Hide()
        pnlmenu.Hide()
        lbltitle.Text = "Beverages"
    End Sub

    Private Sub btnamericanosmall_Click(sender As Object, e As EventArgs) Handles btnamericanosmall.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','americanosmall',109)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "americano"
            frmcart.lbl1.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "americano"
            frmcart.lbl2.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "americano"
            frmcart.lbl3.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "americano"
            frmcart.lbl4.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "americano"
            frmcart.lbl5.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "americano"
            frmcart.lbl6.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "americano"
            frmcart.lbl7.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "americano"
            frmcart.lbl8.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "americano"
            frmcart.lbl9.Text = " 109/-"
            btnamericanosmall.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "americano"
            frmcart.lbl10.Text = " 109/-"
            btnamericanosmall.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnamericanosmall_MouseEnter(sender As Object, e As EventArgs) Handles btnamericanosmall.MouseEnter
        btnamericanosmall.BackColor = Color.SaddleBrown
        btnamericanosmall.ForeColor = Color.White
    End Sub

    Private Sub btnamericanosmall_MouseLeave(sender As Object, e As EventArgs) Handles btnamericanosmall.MouseLeave
        btnamericanosmall.BackColor = Color.White
        btnamericanosmall.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnamericano_Click(sender As Object, e As EventArgs) Handles btnamericano.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','americano',139)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "americano"
            frmcart.lbl1.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "americano"
            frmcart.lbl2.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "americano"
            frmcart.lbl3.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "americano"
            frmcart.lbl4.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "americano"
            frmcart.lbl5.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "americano"
            frmcart.lbl6.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "americano"
            frmcart.lbl7.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "americano"
            frmcart.lbl8.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "americano"
            frmcart.lbl9.Text = " 139/-"
            btnamericano.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "americano"
            frmcart.lbl10.Text = " 139/-"
            btnamericano.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnamericano_MouseEnter(sender As Object, e As EventArgs) Handles btnamericano.MouseEnter
        btnamericano.BackColor = Color.SaddleBrown
        btnamericano.ForeColor = Color.White
    End Sub

    Private Sub btnamericano_MouseLeave(sender As Object, e As EventArgs) Handles btnamericano.MouseLeave
        btnamericano.BackColor = Color.White
        btnamericano.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btncappuccinosmall_Click(sender As Object, e As EventArgs) Handles btncappuccinosmall.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cappuccinosmall',139)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cappuccino"
            frmcart.lbl1.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cappuccino"
            frmcart.lbl2.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cappuccino"
            frmcart.lbl3.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cappuccino"
            frmcart.lbl4.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cappuccino"
            frmcart.lbl5.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cappuccino"
            frmcart.lbl6.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cappuccino"
            frmcart.lbl7.Text = " 139/-"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cappuccino"
            frmcart.lbl8.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cappuccino"
            frmcart.lbl9.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cappuccino"
            frmcart.lbl10.Text = " 139/-"
            btncappuccinosmall.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btncappuccinosmall_MouseEnter(sender As Object, e As EventArgs) Handles btncappuccinosmall.MouseEnter
        btncappuccinosmall.BackColor = Color.SaddleBrown
        btncappuccinosmall.ForeColor = Color.White
    End Sub

    Private Sub btncappuccinosmall_MouseLeave(sender As Object, e As EventArgs) Handles btncappuccinosmall.MouseLeave
        btncappuccinosmall.BackColor = Color.White
        btncappuccinosmall.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btncappuccino_Click(sender As Object, e As EventArgs) Handles btncappuccino.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cappuccino',169)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cappuccino"
            frmcart.lbl1.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cappuccino"
            frmcart.lbl2.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cappuccino"
            frmcart.lbl3.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cappuccino"
            frmcart.lbl4.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cappuccino"
            frmcart.lbl5.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cappuccino"
            frmcart.lbl6.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cappuccino"
            frmcart.lbl7.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cappuccino"
            frmcart.lbl8.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cappuccino"
            frmcart.lbl9.Text = " 169/-"
            btncappuccino.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cappuccino"
            frmcart.lbl10.Text = " 169/-"
            btncappuccino.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btncappuccino_MouseEnter(sender As Object, e As EventArgs) Handles btncappuccino.MouseEnter
        btncappuccino.BackColor = Color.SaddleBrown
        btncappuccino.ForeColor = Color.White
    End Sub

    Private Sub btncappuccino_MouseLeave(sender As Object, e As EventArgs) Handles btncappuccino.MouseLeave
        btncappuccino.BackColor = Color.White
        btncappuccino.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnlattesmall_Click(sender As Object, e As EventArgs) Handles btnlattesmall.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cafelattesmall',139)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cafelatte"
            frmcart.lbl1.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cafelatte"
            frmcart.lbl2.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cafelatte"
            frmcart.lbl3.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cafelatte"
            frmcart.lbl4.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cafelatte"
            frmcart.lbl5.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cafelatte"
            frmcart.lbl6.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cafelatte"
            frmcart.lbl7.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cafelatte"
            frmcart.lbl8.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cafelatte"
            frmcart.lbl9.Text = " 139/-"
            btnlattesmall.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cafelatte"
            frmcart.lbl10.Text = " 139/-"
            btnlattesmall.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnlattesmall_MouseEnter(sender As Object, e As EventArgs) Handles btnlattesmall.MouseEnter
        btnlattesmall.BackColor = Color.SaddleBrown
        btnlattesmall.ForeColor = Color.White
    End Sub

    Private Sub btnlattesmall_MouseLeave(sender As Object, e As EventArgs) Handles btnlattesmall.MouseLeave
        btnlattesmall.BackColor = Color.White
        btnlattesmall.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnlatte_Click(sender As Object, e As EventArgs) Handles btnlatte.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cafelatte',169)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cafelatte"
            frmcart.lbl1.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cafelatte"
            frmcart.lbl2.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cafelatte"
            frmcart.lbl3.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cafelatte"
            frmcart.lbl4.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cafelatte"
            frmcart.lbl5.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cafelatte"
            frmcart.lbl6.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cafelatte"
            frmcart.lbl7.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cafelatte"
            frmcart.lbl8.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cafelatte"
            frmcart.lbl9.Text = " 169/-"
            btnlatte.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cafelatte"
            frmcart.lbl10.Text = " 169/-"
            btnlatte.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnlatte_MouseEnter(sender As Object, e As EventArgs) Handles btnlatte.MouseEnter
        btnlatte.BackColor = Color.SaddleBrown
        btnlatte.ForeColor = Color.White
    End Sub

    Private Sub btnlatte_MouseLeave(sender As Object, e As EventArgs) Handles btnlatte.MouseLeave
        btnlatte.BackColor = Color.White
        btnlatte.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnmochaccinosmall_Click(sender As Object, e As EventArgs) Handles btnmochaccinosmall.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','mochaccinosmall',159)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "mochaccino"
            frmcart.lbl1.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "mochaccino"
            frmcart.lbl2.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "mochaccino"
            frmcart.lbl3.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "mochaccino"
            frmcart.lbl4.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "mochaccino"
            frmcart.lbl5.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "mochaccino"
            frmcart.lbl6.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "mochaccino"
            frmcart.lbl7.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "mochaccino"
            frmcart.lbl8.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "mochaccino"
            frmcart.lbl9.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "mochaccino"
            frmcart.lbl10.Text = " 159/-"
            btnmochaccinosmall.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnmochaccinosmall_MouseEnter(sender As Object, e As EventArgs) Handles btnmochaccinosmall.MouseEnter
        btnmochaccinosmall.BackColor = Color.SaddleBrown
        btnmochaccinosmall.ForeColor = Color.White
    End Sub

    Private Sub btnmochaccinosmall_MouseLeave(sender As Object, e As EventArgs) Handles btnmochaccinosmall.MouseLeave
        btnmochaccinosmall.BackColor = Color.White
        btnmochaccinosmall.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnmochaccino_Click(sender As Object, e As EventArgs) Handles btnmochaccino.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','mochaccino',189)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "mochaccino"
            frmcart.lbl1.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "mochaccino"
            frmcart.lbl2.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "mochaccino"
            frmcart.lbl3.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "mochaccino"
            frmcart.lbl4.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "mochaccino"
            frmcart.lbl5.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "mochaccino"
            frmcart.lbl6.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "mochaccino"
            frmcart.lbl7.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "mochaccino"
            frmcart.lbl8.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "mochaccino"
            frmcart.lbl9.Text = " 189/-"
            btnmochaccino.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "mochaccino"
            frmcart.lbl10.Text = " 189/-"
            btnmochaccino.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnmochaccino_MouseEnter(sender As Object, e As EventArgs) Handles btnmochaccino.MouseEnter
        btnmochaccino.BackColor = Color.SaddleBrown
        btnmochaccino.ForeColor = Color.White
    End Sub

    Private Sub btnmochaccino_MouseLeave(sender As Object, e As EventArgs) Handles btnmochaccino.MouseLeave
        btnmochaccino.BackColor = Color.White
        btnmochaccino.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btncaramellosmall_Click(sender As Object, e As EventArgs) Handles btncaramellosmall.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cafecaramellosmall',159)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cafecaramello"
            frmcart.lbl1.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cafecaramello"
            frmcart.lbl2.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cafecaramello"
            frmcart.lbl3.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cafecaramello"
            frmcart.lbl4.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cafecaramello"
            frmcart.lbl5.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cafecaramello"
            frmcart.lbl6.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cafecaramello"
            frmcart.lbl7.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cafecaramello"
            frmcart.lbl8.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cafecaramello"
            frmcart.lbl9.Text = " 159/-"
            btncaramellosmall.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cafecaramello"
            frmcart.lbl10.Text = " 159/-"
            btncaramellosmall.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If

    End Sub

    Private Sub btncaramellosmall_MouseEnter(sender As Object, e As EventArgs) Handles btncaramellosmall.MouseEnter
        btncaramellosmall.BackColor = Color.SaddleBrown
        btncaramellosmall.ForeColor = Color.White
    End Sub

    Private Sub btncaramellosmall_MouseLeave(sender As Object, e As EventArgs) Handles btncaramellosmall.MouseLeave
        btncaramellosmall.BackColor = Color.White
        btncaramellosmall.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btncaramello_Click(sender As Object, e As EventArgs) Handles btncaramello.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','cafecaramello',189)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "cafecaramello"
            frmcart.lbl1.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "cafecaramello"
            frmcart.lbl2.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "cafecaramello"
            frmcart.lbl3.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "cafecaramello"
            frmcart.lbl4.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "cafecaramello"
            frmcart.lbl5.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "cafecaramello"
            frmcart.lbl6.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "cafecaramello"
            frmcart.lbl7.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "cafecaramello"
            frmcart.lbl8.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "cafecaramello"
            frmcart.lbl9.Text = " 189/-"
            btncaramello.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "cafecaramello"
            frmcart.lbl10.Text = " 189/-"
            btncaramello.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btncaramello_MouseEnter(sender As Object, e As EventArgs) Handles btncaramello.MouseEnter
        btncaramello.BackColor = Color.SaddleBrown
        btncaramello.ForeColor = Color.White
    End Sub

    Private Sub btncaramello_MouseLeave(sender As Object, e As EventArgs) Handles btncaramello.MouseLeave
        btncaramello.BackColor = Color.White
        btncaramello.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnhazelnutsmall_Click(sender As Object, e As EventArgs) Handles btnhazelnutsmall.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','hazelnutcappuccinosmall',159)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "hazelnut"
            frmcart.lbl1.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "hazelnut"
            frmcart.lbl2.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "hazelnut"
            frmcart.lbl3.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "hazelnut"
            frmcart.lbl4.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "hazelnut"
            frmcart.lbl5.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "hazelnut"
            frmcart.lbl6.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "hazelnut"
            frmcart.lbl7.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "hazelnut"
            frmcart.lbl8.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "hazelnut"
            frmcart.lbl9.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "hazelnut"
            frmcart.lbl10.Text = " 159/-"
            btnhazelnutsmall.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnhazelnutsmall_MouseEnter(sender As Object, e As EventArgs) Handles btnhazelnutsmall.MouseEnter
        btnhazelnutsmall.BackColor = Color.SaddleBrown
        btnhazelnutsmall.ForeColor = Color.White
    End Sub

    Private Sub btnhazelnutsmall_MouseLeave(sender As Object, e As EventArgs) Handles btnhazelnutsmall.MouseLeave
        btnhazelnutsmall.BackColor = Color.White
        btnhazelnutsmall.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnhazelnut_Click(sender As Object, e As EventArgs) Handles btnhazelnut.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','hazelnutcappuccino',189)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "hazelnut"
            frmcart.lbl1.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "hazelnut"
            frmcart.lbl2.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "hazelnut"
            frmcart.lbl3.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "hazelnut"
            frmcart.lbl4.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "hazelnut"
            frmcart.lbl5.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "hazelnut"
            frmcart.lbl6.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "hazelnut"
            frmcart.lbl7.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "hazelnut"
            frmcart.lbl8.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "hazelnut"
            frmcart.lbl9.Text = " 189/-"
            btnhazelnut.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "hazelnut"
            frmcart.lbl10.Text = " 189/-"
            btnhazelnut.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnhazelnut_MouseEnter(sender As Object, e As EventArgs) Handles btnhazelnut.MouseEnter
        btnhazelnut.BackColor = Color.SaddleBrown
        btnhazelnut.ForeColor = Color.White
    End Sub

    Private Sub btnhazelnut_MouseLeave(sender As Object, e As EventArgs) Handles btnhazelnut.MouseLeave
        btnhazelnut.BackColor = Color.White
        btnhazelnut.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnhotchocolate_Click(sender As Object, e As EventArgs) Handles btnhotchocolate.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','hotchocolate',209)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "hotchocolate"
            frmcart.lbl1.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "hotchocolate"
            frmcart.lbl2.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "hotchocolate"
            frmcart.lbl3.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "hotchocolate"
            frmcart.lbl4.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "hotchocolate"
            frmcart.lbl5.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "hotchocolate"
            frmcart.lbl6.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "hotchocolate"
            frmcart.lbl7.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "hotchocolate"
            frmcart.lbl8.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "hotchocolate"
            frmcart.lbl9.Text = " 209/-"
            btnhotchocolate.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "hotchocolate"
            frmcart.lbl10.Text = " 209/-"
            btnhotchocolate.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnhotchocolate_MouseEnter(sender As Object, e As EventArgs) Handles btnhotchocolate.MouseEnter
        btnhotchocolate.BackColor = Color.SaddleBrown
        btnhotchocolate.ForeColor = Color.White
    End Sub

    Private Sub btnhotchocolate_MouseLeave(sender As Object, e As EventArgs) Handles btnhotchocolate.MouseLeave
        btnhotchocolate.BackColor = Color.White
        btnhotchocolate.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btngreentea_Click(sender As Object, e As EventArgs) Handles btngreentea.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','greentea',99)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "greentea"
            frmcart.lbl1.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "greentea"
            frmcart.lbl2.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "greentea"
            frmcart.lbl3.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "greentea"
            frmcart.lbl4.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "greentea"
            frmcart.lbl5.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "greentea"
            frmcart.lbl6.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "greentea"
            frmcart.lbl7.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "greentea"
            frmcart.lbl8.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "greentea"
            frmcart.lbl9.Text = " 99/-"
            btngreentea.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "greentea"
            frmcart.lbl10.Text = " 99/-"
            btngreentea.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btngreentea_MouseEnter(sender As Object, e As EventArgs) Handles btngreentea.MouseEnter
        btngreentea.BackColor = Color.SaddleBrown
        btngreentea.ForeColor = Color.White
    End Sub

    Private Sub btngreentea_MouseLeave(sender As Object, e As EventArgs) Handles btngreentea.MouseLeave
        btngreentea.BackColor = Color.White
        btngreentea.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btndesserts_Click(sender As Object, e As EventArgs) Handles btndesserts.Click
        pnldesserts.Show()
        pnlhome.Hide()
        pnlbeverages.Hide()
        pnlsides.Hide()
        pnlfrozen.Hide()
        pnlmenu.Hide()
        lbltitle.Text = "Desserts"
    End Sub

    Private Sub btnwalnutbrownie_Click(sender As Object, e As EventArgs) Handles btnwalnutbrownie.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','walnutbrownie',89)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "Walnutbrownie"
            frmcart.lbl1.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "Walnutbrownie"
            frmcart.lbl2.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "Walnutbrownie"
            frmcart.lbl3.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "Walnutbrownie"
            frmcart.lbl4.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "Walnutbrownie"
            frmcart.lbl5.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "Walnutbrownie"
            frmcart.lbl6.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "Walnutbrownie"
            frmcart.lbl7.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "Walnutbrownie"
            frmcart.lbl8.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "Walnutbrownie"
            frmcart.lbl9.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "Walnutbrownie"
            frmcart.lbl10.Text = " 89/-"
            btnwalnutbrownie.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnwalnutbrownie_MouseEnter(sender As Object, e As EventArgs) Handles btnwalnutbrownie.MouseEnter
        btnwalnutbrownie.BackColor = Color.SaddleBrown
        btnwalnutbrownie.ForeColor = Color.White
    End Sub

    Private Sub btnwalnutbrownie_MouseLeave(sender As Object, e As EventArgs) Handles btnwalnutbrownie.MouseLeave
        btnwalnutbrownie.BackColor = Color.White
        btnwalnutbrownie.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnbrownie_Click(sender As Object, e As EventArgs) Handles btnbrownie.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','gooeytrufflebrownie',79)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "brownie"
            frmcart.lbl1.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "brownie"
            frmcart.lbl2.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "brownie"
            frmcart.lbl3.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "brownie"
            frmcart.lbl4.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "brownie"
            frmcart.lbl5.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "brownie"
            frmcart.lbl6.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "brownie"
            frmcart.lbl7.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "brownie"
            frmcart.lbl8.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "brownie"
            frmcart.lbl9.Text = " 79/-"
            btnbrownie.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "brownie"
            frmcart.lbl10.Text = " 79/-"
            btnbrownie.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnbrownie_MouseEnter(sender As Object, e As EventArgs) Handles btnbrownie.MouseEnter
        btnbrownie.BackColor = Color.SaddleBrown
        btnbrownie.ForeColor = Color.White
    End Sub

    Private Sub btnbrownie_MouseLeave(sender As Object, e As EventArgs) Handles btnbrownie.MouseLeave
        btnbrownie.BackColor = Color.White
        btnbrownie.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnmousse_Click(sender As Object, e As EventArgs) Handles btnmousse.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values(" & frmlogin.txtname.Text & "','chocolatemoussecup',109)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chocomousse"
            frmcart.lbl1.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chocomousse"
            frmcart.lbl2.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chocomousse"
            frmcart.lbl3.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chocomousse"
            frmcart.lbl4.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chocomousse"
            frmcart.lbl5.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chocomousse"
            frmcart.lbl6.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chocomousse"
            frmcart.lbl7.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chocomousse"
            frmcart.lbl8.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chocomousse"
            frmcart.lbl9.Text = " 109/-"
            btnmousse.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chocomousse"
            frmcart.lbl10.Text = " 109/-"
            btnmousse.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnmousse_MouseEnter(sender As Object, e As EventArgs) Handles btnmousse.MouseEnter
        btnmousse.BackColor = Color.SaddleBrown
        btnmousse.ForeColor = Color.White
    End Sub

    Private Sub btnmousse_MouseLeave(sender As Object, e As EventArgs) Handles btnmousse.MouseLeave
        btnmousse.BackColor = Color.White
        btnmousse.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnchocolava_Click(sender As Object, e As EventArgs) Handles btnchocolava.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chocolavacups',109)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chocolava"
            frmcart.lbl1.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chocolava"
            frmcart.lbl2.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chocolava"
            frmcart.lbl3.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chocolava"
            frmcart.lbl4.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chocolava"
            frmcart.lbl5.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chocolava"
            frmcart.lbl6.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chocolava"
            frmcart.lbl7.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chocolava"
            frmcart.lbl8.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chocolava"
            frmcart.lbl9.Text = " 109/-"
            btnchocolava.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chocolava"
            frmcart.lbl10.Text = " 109/-"
            btnchocolava.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnchocolava_MouseEnter(sender As Object, e As EventArgs) Handles btnchocolava.MouseEnter
        btnchocolava.BackColor = Color.SaddleBrown
        btnchocolava.ForeColor = Color.White
    End Sub

    Private Sub btnchocolava_MouseLeave(sender As Object, e As EventArgs) Handles btnchocolava.MouseLeave
        btnchocolava.BackColor = Color.White
        btnchocolava.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnchocomuffin_Click(sender As Object, e As EventArgs) Handles btnchocomuffin.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chocochipmuffin',109)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chocomuffin"
            frmcart.lbl1.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chocomuffin"
            frmcart.lbl2.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chocomuffin"
            frmcart.lbl3.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chocomuffin"
            frmcart.lbl4.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chocomuffin"
            frmcart.lbl5.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chocomuffin"
            frmcart.lbl6.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chocomuffin"
            frmcart.lbl7.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chocomuffin"
            frmcart.lbl8.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chocomuffin"
            frmcart.lbl9.Text = " 109/-"
            btnchocomuffin.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chocomuffin"
            frmcart.lbl10.Text = " 109/-"
            btnchocomuffin.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnchocomuffin_MouseEnter(sender As Object, e As EventArgs) Handles btnchocomuffin.MouseEnter
        btnchocomuffin.BackColor = Color.SaddleBrown
        btnchocomuffin.ForeColor = Color.White
    End Sub

    Private Sub btnchocomuffin_MouseLeave(sender As Object, e As EventArgs) Handles btnchocomuffin.MouseLeave
        btnchocomuffin.BackColor = Color.White
        btnchocomuffin.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnvanillamuffin_Click(sender As Object, e As EventArgs) Handles btnvanillamuffin.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','vanillablueberrymuffin',119)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "vanillamuffin"
            frmcart.lbl1.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "vanillamuffin"
            frmcart.lbl2.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "vanillamuffin"
            frmcart.lbl3.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "vanillamuffin"
            frmcart.lbl4.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "vanillamuffin"
            frmcart.lbl5.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "vanillamuffin"
            frmcart.lbl6.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "vanillamuffin"
            frmcart.lbl7.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "vanillamuffin"
            frmcart.lbl8.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "vanillamuffin"
            frmcart.lbl9.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "vanillamuffin"
            frmcart.lbl10.Text = " 119/-"
            btnvanillamuffin.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnvanillamuffin_MouseEnter(sender As Object, e As EventArgs) Handles btnvanillamuffin.MouseEnter
        btnvanillamuffin.BackColor = Color.SaddleBrown
        btnvanillamuffin.ForeColor = Color.White
    End Sub

    Private Sub btnvanillamuffin_MouseLeave(sender As Object, e As EventArgs) Handles btnvanillamuffin.MouseLeave
        btnvanillamuffin.BackColor = Color.White
        btnvanillamuffin.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnsides_Click(sender As Object, e As EventArgs) Handles btnsides.Click
        pnlsides.Show()
        pnlbeverages.Hide()
        pnldesserts.Hide()
        pnlhome.Hide()
        pnlfrozen.Hide()
        pnlmenu.Hide()
        lbltitle.Text = "Sides"
    End Sub

    Private Sub btnchickenfries_Click(sender As Object, e As EventArgs) Handles btnchickenfries.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chickenfries',79)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chickenfries"
            frmcart.lbl1.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chickenfries"
            frmcart.lbl2.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chickenfries"
            frmcart.lbl3.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chickenfries"
            frmcart.lbl4.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chickenfries"
            frmcart.lbl5.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chickenfries"
            frmcart.lbl6.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chickenfries"
            frmcart.lbl7.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chickenfries"
            frmcart.lbl8.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chickenfries"
            frmcart.lbl9.Text = " 79/-"
            btnchickenfries.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chickenfries"
            frmcart.lbl10.Text = " 79/-"
            btnchickenfries.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnchickenfries_MouseEnter(sender As Object, e As EventArgs) Handles btnchickenfries.MouseEnter
        btnchickenfries.BackColor = Color.SaddleBrown
        btnchickenfries.ForeColor = Color.White
    End Sub

    Private Sub btnchickenfries_MouseLeave(sender As Object, e As EventArgs) Handles btnchickenfries.MouseLeave
        btnchickenfries.BackColor = Color.White
        btnchickenfries.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnfrenchfries_Click(sender As Object, e As EventArgs) Handles btnfrenchfries.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chilligarlicfrenchfries',129)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "frenchfries"
            frmcart.lbl1.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "frenchfries"
            frmcart.lbl2.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "frenchfries"
            frmcart.lbl3.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "frenchfries"
            frmcart.lbl4.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "frenchfries"
            frmcart.lbl5.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "frenchfries"
            frmcart.lbl6.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "frenchfries"
            frmcart.lbl7.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "frenchfries"
            frmcart.lbl8.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "frenchfries"
            frmcart.lbl9.Text = " 129/-"
            btnfrenchfries.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "frenchfries"
            frmcart.lbl10.Text = " 129/-"
            btnfrenchfries.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnfrenchfries_MouseEnter(sender As Object, e As EventArgs) Handles btnfrenchfries.MouseEnter
        btnfrenchfries.BackColor = Color.SaddleBrown
        btnfrenchfries.ForeColor = Color.White
    End Sub

    Private Sub btnfrenchfries_MouseLeave(sender As Object, e As EventArgs) Handles btnfrenchfries.MouseLeave
        btnfrenchfries.BackColor = Color.White
        btnfrenchfries.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btntacopinto_Click(sender As Object, e As EventArgs) Handles btntacopinto.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','Tacopintobean',105)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "tacopinto"
            frmcart.lbl1.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "tacopinto"
            frmcart.lbl2.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "tacopinto"
            frmcart.lbl3.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "tacopinto"
            frmcart.lbl4.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "tacopinto"
            frmcart.lbl5.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "tacopinto"
            frmcart.lbl6.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "tacopinto"
            frmcart.lbl7.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "tacopinto"
            frmcart.lbl8.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "tacopinto"
            frmcart.lbl9.Text = " 105/-"
            btntacopinto.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "tacopinto"
            frmcart.lbl10.Text = " 105/-"
            btntacopinto.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btntacopinto_MouseEnter(sender As Object, e As EventArgs) Handles btntacopinto.MouseEnter
        btntacopinto.BackColor = Color.SaddleBrown
        btntacopinto.ForeColor = Color.White
    End Sub

    Private Sub btntacopinto_MouseLeave(sender As Object, e As EventArgs) Handles btntacopinto.MouseLeave
        btntacopinto.BackColor = Color.White
        btntacopinto.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnchickentaco_Click(sender As Object, e As EventArgs) Handles btnchickentaco.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chickentaco',209)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chickentaco"
            frmcart.lbl1.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chickentaco"
            frmcart.lbl2.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chickentaco"
            frmcart.lbl3.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chickentaco"
            frmcart.lbl4.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chickentaco"
            frmcart.lbl5.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chickentaco"
            frmcart.lbl6.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chickentaco"
            frmcart.lbl7.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chickentaco"
            frmcart.lbl8.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chickentaco"
            frmcart.lbl9.Text = " 209/-"
            btnchickentaco.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chickentaco"
            frmcart.lbl10.Text = " 209/-"
            btnchickentaco.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnchickentaco_MouseEnter(sender As Object, e As EventArgs) Handles btnchickentaco.MouseEnter
        btnchickentaco.BackColor = Color.SaddleBrown
        btnchickentaco.ForeColor = Color.White
    End Sub

    Private Sub btnchickentaco_MouseLeave(sender As Object, e As EventArgs) Handles btnchickentaco.MouseLeave
        btnchickentaco.BackColor = Color.White
        btnchickentaco.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btndimsums_Click(sender As Object, e As EventArgs) Handles btndimsums.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','edamamedimsums',400)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "dimsums"
            frmcart.lbl1.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "dimsums"
            frmcart.lbl2.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "dimsums"
            frmcart.lbl3.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "dimsums"
            frmcart.lbl4.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "dimsums"
            frmcart.lbl5.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "dimsums"
            frmcart.lbl6.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "dimsums"
            frmcart.lbl7.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "dimsums"
            frmcart.lbl8.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "dimsums"
            frmcart.lbl9.Text = " 400/-"
            btndimsums.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "dimsums"
            frmcart.lbl10.Text = " 400/-"
            btndimsums.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btndimsums_MouseEnter(sender As Object, e As EventArgs) Handles btndimsums.MouseEnter
        btndimsums.BackColor = Color.SaddleBrown
        btndimsums.ForeColor = Color.White
    End Sub

    Private Sub btndimsums_MouseLeave(sender As Object, e As EventArgs) Handles btndimsums.MouseLeave
        btndimsums.BackColor = Color.White
        btndimsums.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btndumplings_Click(sender As Object, e As EventArgs) Handles btndumplings.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chickendumplings',410)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "dumplings"
            frmcart.lbl1.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "dumplings"
            frmcart.lbl2.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "dumplings"
            frmcart.lbl3.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "dumplings"
            frmcart.lbl4.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "dumplings"
            frmcart.lbl5.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "dumplings"
            frmcart.lbl6.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chickendumplings"
            frmcart.lbl7.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "dumplings"
            frmcart.lbl8.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "dumplings"
            frmcart.lbl9.Text = " 410/-"
            btndumplings.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "dumplings"
            frmcart.lbl10.Text = " 410/-"
            btndumplings.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btndumplings_MouseEnter(sender As Object, e As EventArgs) Handles btndumplings.MouseEnter
        btndumplings.BackColor = Color.SaddleBrown
        btndumplings.ForeColor = Color.White
    End Sub

    Private Sub btndumplings_MouseLeave(sender As Object, e As EventArgs) Handles btndumplings.MouseLeave
        btndumplings.BackColor = Color.White
        btndumplings.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnfrozen_Click(sender As Object, e As EventArgs) Handles btnfrozen.Click
        pnlfrozen.Show()
        pnlhome.Hide()
        pnldesserts.Hide()
        pnlbeverages.Hide()
        pnlsides.Hide()
        pnlmenu.Hide()
        lbltitle.Text = "Frozen"
    End Sub

    Private Sub btnchocolatesundae_Click(sender As Object, e As EventArgs) Handles btnchocolatesundae.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chocolatesundae',210)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chocolatesundae"
            frmcart.lbl1.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chocolatesundae"
            frmcart.lbl2.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chocolatesundae"
            frmcart.lbl3.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chocolatesundae"
            frmcart.lbl4.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chocolatesundae"
            frmcart.lbl5.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chocolatesundae"
            frmcart.lbl6.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chocolatesundae"
            frmcart.lbl7.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chocolatesundae"
            frmcart.lbl8.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chocolatesundae"
            frmcart.lbl9.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chocolatesundae"
            frmcart.lbl10.Text = " 210/-"
            btnchocolatesundae.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnchocolatesundae_MouseEnter(sender As Object, e As EventArgs) Handles btnchocolatesundae.MouseEnter
        btnchocolatesundae.BackColor = Color.SaddleBrown
        btnchocolatesundae.ForeColor = Color.White
    End Sub

    Private Sub btnchocolatesundae_MouseLeave(sender As Object, e As EventArgs) Handles btnchocolatesundae.MouseLeave
        btnchocolatesundae.BackColor = Color.White
        btnchocolatesundae.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnchocofudge_Click(sender As Object, e As EventArgs) Handles btnchocofudge.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','chocofudgesundae',175)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "chocosundae"
            frmcart.lbl1.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "chocosundae"
            frmcart.lbl2.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "chocosundae"
            frmcart.lbl3.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "chocosundae"
            frmcart.lbl4.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "chocosundae"
            frmcart.lbl5.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "chocosundae"
            frmcart.lbl7.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "chocosundae"
            frmcart.lbl7.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "chocosundae"
            frmcart.lbl8.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "chocosundae"
            frmcart.lbl9.Text = " 175/-"
            btnchocofudge.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "chocosundae"
            frmcart.lbl10.Text = " 175/-"
            btnchocofudge.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnchocofudge_MouseEnter(sender As Object, e As EventArgs) Handles btnchocofudge.MouseEnter
        btnchocofudge.BackColor = Color.SaddleBrown
        btnchocofudge.ForeColor = Color.White
    End Sub

    Private Sub btnchocofudge_MouseLeave(sender As Object, e As EventArgs) Handles btnchocofudge.MouseLeave
        btnchocofudge.BackColor = Color.White
        btnchocofudge.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnrainbow_Click(sender As Object, e As EventArgs) Handles btnrainbow.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','rainbowsundae',229)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "rainbowsundae"
            frmcart.lbl1.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "rainbowsundae"
            frmcart.lbl2.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "rainbowsundae"
            frmcart.lbl3.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "rainbowsundae"
            frmcart.lbl4.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "rainbowsundae"
            frmcart.lbl5.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "rainbowsundae"
            frmcart.lbl6.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "rainbowsundae"
            frmcart.lbl7.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "rainbowsundae"
            frmcart.lbl8.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "rainbowsundae"
            frmcart.lbl9.Text = " 229/-"
            btnrainbow.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "rainbowsundae"
            frmcart.lbl10.Text = " 229/-"
            btnrainbow.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnrainbow_MouseEnter(sender As Object, e As EventArgs) Handles btnrainbow.MouseEnter
        btnrainbow.BackColor = Color.SaddleBrown
        btnrainbow.ForeColor = Color.White
    End Sub

    Private Sub btnrainbow_MouseLeave(sender As Object, e As EventArgs) Handles btnrainbow.MouseLeave
        btnrainbow.BackColor = Color.White
        btnrainbow.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btngudbud_Click(sender As Object, e As EventArgs) Handles btngudbud.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','fruitygudbud',399)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "gudbud"
            frmcart.lbl1.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "gudbud"
            frmcart.lbl2.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "gudbud"
            frmcart.lbl3.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "gudbud"
            frmcart.lbl4.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "gudbud"
            frmcart.lbl5.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "gudbud"
            frmcart.lbl6.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "gudbud"
            frmcart.lbl7.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "gudbud"
            frmcart.lbl8.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "gudbud"
            frmcart.lbl9.Text = " 399/-"
            btngudbud.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "gudbud"
            frmcart.lbl10.Text = " 399/-"
            btngudbud.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btngudbud_MouseEnter(sender As Object, e As EventArgs) Handles btngudbud.MouseEnter
        btngudbud.BackColor = Color.SaddleBrown
        btngudbud.ForeColor = Color.White
    End Sub

    Private Sub btngudbud_MouseLeave(sender As Object, e As EventArgs) Handles btngudbud.MouseLeave
        btngudbud.BackColor = Color.White
        btngudbud.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnnuttychoco_Click(sender As Object, e As EventArgs) Handles btnnuttychoco.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','nuttychocojar',269)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "nuttychoco"
            frmcart.lbl1.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "nuttychoco"
            frmcart.lbl2.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "nuttychoco"
            frmcart.lbl3.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "nuttychoco"
            frmcart.lbl4.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "nuttychoco"
            frmcart.lbl5.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "nuttychoco"
            frmcart.lbl6.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "nuttychoco"
            frmcart.lbl7.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "nuttychoco"
            frmcart.lbl8.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "nuttychoco"
            frmcart.lbl9.Text = " 269/-"
            btnnuttychoco.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "nuttychoco"
            frmcart.lbl10.Text = " 269/-"
            btnnuttychoco.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnnuttychoco_MouseEnter(sender As Object, e As EventArgs) Handles btnnuttychoco.MouseEnter
        btnnuttychoco.BackColor = Color.SaddleBrown
        btnnuttychoco.ForeColor = Color.White
    End Sub

    Private Sub btnnuttychoco_MouseLeave(sender As Object, e As EventArgs) Handles btnnuttychoco.MouseLeave
        btnnuttychoco.BackColor = Color.White
        btnnuttychoco.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnalmondfudge_Click(sender As Object, e As EventArgs) Handles btnalmondfudge.Click
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("insert into cart(uname,item,rate)values('" & frmlogin.txtname.Text & "','almondfudge',200)", cn)
        cmd.ExecuteNonQuery()
        If frmcart.Panel1.Enabled = False Then
            frmcart.Panel1.Enabled = True
            frmcart.Panel1.Visible = True
            frmcart.Label1.Text = "almondfudge"
            frmcart.lbl1.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel2.Enabled = False Then
            frmcart.Panel2.Enabled = True
            frmcart.Panel2.Visible = True
            frmcart.Label2.Text = "almondfudge"
            frmcart.lbl2.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel3.Enabled = False Then
            frmcart.Panel3.Enabled = True
            frmcart.Panel3.Visible = True
            frmcart.Label3.Text = "almondfudge"
            frmcart.lbl3.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel4.Enabled = False Then
            frmcart.Panel4.Enabled = True
            frmcart.Panel4.Visible = True
            frmcart.Label4.Text = "almondfudge"
            frmcart.lbl4.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel5.Enabled = False Then
            frmcart.Panel5.Enabled = True
            frmcart.Panel5.Visible = True
            frmcart.Label5.Text = "almondfudge"
            frmcart.lbl5.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel6.Enabled = False Then
            frmcart.Panel6.Enabled = True
            frmcart.Panel6.Visible = True
            frmcart.Label6.Text = "almondfudge"
            frmcart.lbl6.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel7.Enabled = False Then
            frmcart.Panel7.Enabled = True
            frmcart.Panel7.Visible = True
            frmcart.Label7.Text = "almondfudge"
            frmcart.lbl7.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel8.Enabled = False Then
            frmcart.Panel8.Enabled = True
            frmcart.Panel8.Visible = True
            frmcart.Label8.Text = "almondfudge"
            frmcart.lbl8.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel9.Enabled = False Then
            frmcart.Panel9.Enabled = True
            frmcart.Panel9.Visible = True
            frmcart.Label9.Text = "almondfudge"
            frmcart.lbl9.Text = " 200/-"
            btnalmondfudge.Text = "added"
        ElseIf frmcart.Panel10.Enabled = False Then
            frmcart.Panel10.Enabled = True
            frmcart.Panel10.Visible = True
            frmcart.Label10.Text = "almondfudge"
            frmcart.lbl10.Text = " 200/-"
            btnalmondfudge.Text = "added"
        Else
            MsgBox("exceeded the order limit")
        End If
    End Sub

    Private Sub btnalmondfudge_MouseEnter(sender As Object, e As EventArgs) Handles btnalmondfudge.MouseEnter
        btnalmondfudge.BackColor = Color.SaddleBrown
        btnalmondfudge.ForeColor = Color.White
    End Sub

    Private Sub btnalmondfudge_MouseLeave(sender As Object, e As EventArgs) Handles btnalmondfudge.MouseLeave
        btnalmondfudge.BackColor = Color.White
        btnalmondfudge.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnprofile_Click(sender As Object, e As EventArgs) Handles btnprofile.Click
        frmprofile.Show()
    End Sub

    Private Sub btnaboutus_Click(sender As Object, e As EventArgs) Handles btnaboutus.Click
        frmaboutus.Show()
    End Sub

    Private Sub btncart_Click(sender As Object, e As EventArgs) Handles btncart.Click
        frmcart.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub btnprofile_MouseEnter(sender As Object, e As EventArgs) Handles btnprofile.MouseEnter
        btnprofile.BackColor = Color.SaddleBrown
        btnprofile.ForeColor = Color.White
    End Sub

    Private Sub btnprofile_MouseLeave(sender As Object, e As EventArgs) Handles btnprofile.MouseLeave
        btnprofile.BackColor = Color.White
        btnprofile.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnaboutus_MouseEnter(sender As Object, e As EventArgs) Handles btnaboutus.MouseEnter
        btnaboutus.BackColor = Color.SaddleBrown
        btnaboutus.ForeColor = Color.White
    End Sub

    Private Sub btnaboutus_MouseLeave(sender As Object, e As EventArgs) Handles btnaboutus.MouseLeave
        btnaboutus.BackColor = Color.White
        btnaboutus.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnlogout_MouseEnter(sender As Object, e As EventArgs) Handles btnlogout.MouseEnter
        btnlogout.BackColor = Color.SaddleBrown
        btnlogout.ForeColor = Color.White
    End Sub

    Private Sub btnlogout_MouseLeave(sender As Object, e As EventArgs) Handles btnlogout.MouseLeave
        btnlogout.BackColor = Color.White
        btnlogout.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnhome_MouseEnter(sender As Object, e As EventArgs) Handles btnhome.MouseEnter
        btnhome.BackColor = Color.SaddleBrown
        btnhome.ForeColor = Color.White
    End Sub

    Private Sub btnhome_MouseLeave(sender As Object, e As EventArgs) Handles btnhome.MouseLeave
        btnhome.BackColor = Color.White
        btnhome.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btncart_MouseEnter(sender As Object, e As EventArgs) Handles btncart.MouseEnter
        btncart.BackColor = Color.SaddleBrown
        btncart.ForeColor = Color.White
    End Sub

    Private Sub btncart_MouseLeave(sender As Object, e As EventArgs) Handles btncart.MouseLeave
        btncart.BackColor = Color.White
        btncart.ForeColor = Color.SaddleBrown
    End Sub

    Private Sub btnmyorders_Click(sender As Object, e As EventArgs) Handles btnmyorders.Click
        frmmyorders.Show()
    End Sub

    Private Sub btnmyorders_MouseEnter(sender As Object, e As EventArgs) Handles btnmyorders.MouseEnter
        btnmyorders.BackColor = Color.SaddleBrown
        btnmyorders.ForeColor = Color.White
    End Sub

    Private Sub btnmyorders_MouseLeave(sender As Object, e As EventArgs) Handles btnmyorders.MouseLeave
        btnmyorders.BackColor = Color.White
        btnmyorders.ForeColor = Color.SaddleBrown
    End Sub
End Class