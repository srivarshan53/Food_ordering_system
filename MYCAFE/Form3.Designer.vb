<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmregister))
        Me.pnlregister = New System.Windows.Forms.Panel()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.lblconfirm = New System.Windows.Forms.Label()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.lblpword = New System.Windows.Forms.Label()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.lblphone = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.pnlregister.SuspendLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlregister
        '
        Me.pnlregister.Controls.Add(Me.btnregister)
        Me.pnlregister.Controls.Add(Me.lbllogin)
        Me.pnlregister.Controls.Add(Me.Label2)
        Me.pnlregister.Controls.Add(Me.txtconfirm)
        Me.pnlregister.Controls.Add(Me.lblconfirm)
        Me.pnlregister.Controls.Add(Me.txtpword)
        Me.pnlregister.Controls.Add(Me.lblpword)
        Me.pnlregister.Controls.Add(Me.txtphone)
        Me.pnlregister.Controls.Add(Me.lblphone)
        Me.pnlregister.Controls.Add(Me.txtname)
        Me.pnlregister.Controls.Add(Me.lblname)
        Me.pnlregister.Controls.Add(Me.Label1)
        Me.pnlregister.Controls.Add(Me.piclogo)
        Me.pnlregister.Location = New System.Drawing.Point(40, 30)
        Me.pnlregister.Name = "pnlregister"
        Me.pnlregister.Size = New System.Drawing.Size(303, 492)
        Me.pnlregister.TabIndex = 0
        '
        'btnregister
        '
        Me.btnregister.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnregister.FlatAppearance.BorderSize = 5
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregister.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnregister.Location = New System.Drawing.Point(62, 400)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(190, 38)
        Me.btnregister.TabIndex = 12
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = True
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbllogin.Location = New System.Drawing.Point(188, 456)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(38, 19)
        Me.lbllogin.TabIndex = 11
        Me.lbllogin.Text = "login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "already have an account!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtconfirm
        '
        Me.txtconfirm.BackColor = System.Drawing.Color.White
        Me.txtconfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtconfirm.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirm.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtconfirm.Location = New System.Drawing.Point(29, 356)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(256, 26)
        Me.txtconfirm.TabIndex = 9
        '
        'lblconfirm
        '
        Me.lblconfirm.AutoSize = True
        Me.lblconfirm.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfirm.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblconfirm.Location = New System.Drawing.Point(25, 334)
        Me.lblconfirm.Name = "lblconfirm"
        Me.lblconfirm.Size = New System.Drawing.Size(126, 19)
        Me.lblconfirm.TabIndex = 8
        Me.lblconfirm.Text = "Confirm password:"
        '
        'txtpword
        '
        Me.txtpword.BackColor = System.Drawing.Color.White
        Me.txtpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtpword.Location = New System.Drawing.Point(29, 287)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.Size = New System.Drawing.Size(256, 26)
        Me.txtpword.TabIndex = 7
        '
        'lblpword
        '
        Me.lblpword.AutoSize = True
        Me.lblpword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblpword.Location = New System.Drawing.Point(25, 265)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(71, 19)
        Me.lblpword.TabIndex = 6
        Me.lblpword.Text = "Password:"
        '
        'txtphone
        '
        Me.txtphone.BackColor = System.Drawing.Color.White
        Me.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtphone.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtphone.Location = New System.Drawing.Point(29, 218)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(256, 26)
        Me.txtphone.TabIndex = 5
        '
        'lblphone
        '
        Me.lblphone.AutoSize = True
        Me.lblphone.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblphone.Location = New System.Drawing.Point(25, 196)
        Me.lblphone.Name = "lblphone"
        Me.lblphone.Size = New System.Drawing.Size(102, 19)
        Me.lblphone.TabIndex = 4
        Me.lblphone.Text = "Phone number:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtname.Location = New System.Drawing.Point(29, 149)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(256, 26)
        Me.txtname.TabIndex = 3
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblname.Location = New System.Drawing.Point(25, 127)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(75, 19)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(127, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 76)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create an " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Account" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'piclogo
        '
        Me.piclogo.BackgroundImage = CType(resources.GetObject("piclogo.BackgroundImage"), System.Drawing.Image)
        Me.piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piclogo.Location = New System.Drawing.Point(14, 21)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(107, 77)
        Me.piclogo.TabIndex = 0
        Me.piclogo.TabStop = False
        '
        'frmregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(386, 558)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlregister)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmregister"
        Me.pnlregister.ResumeLayout(False)
        Me.pnlregister.PerformLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlregister As Panel
    Friend WithEvents btnregister As Button
    Friend WithEvents lbllogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents lblconfirm As Label
    Friend WithEvents txtpword As TextBox
    Friend WithEvents lblpword As Label
    Friend WithEvents txtphone As TextBox
    Friend WithEvents lblphone As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents piclogo As PictureBox
End Class
