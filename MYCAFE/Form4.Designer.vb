<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.pnllogin = New System.Windows.Forms.Panel()
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.lblpword = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.pnllogin.SuspendLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnllogin
        '
        Me.pnllogin.Controls.Add(Me.lbllogin)
        Me.pnllogin.Controls.Add(Me.Label2)
        Me.pnllogin.Controls.Add(Me.btnlogin)
        Me.pnllogin.Controls.Add(Me.txtpword)
        Me.pnllogin.Controls.Add(Me.lblpword)
        Me.pnllogin.Controls.Add(Me.txtname)
        Me.pnllogin.Controls.Add(Me.lblname)
        Me.pnllogin.Controls.Add(Me.Label1)
        Me.pnllogin.Controls.Add(Me.piclogo)
        Me.pnllogin.Location = New System.Drawing.Point(41, 35)
        Me.pnllogin.Name = "pnllogin"
        Me.pnllogin.Size = New System.Drawing.Size(303, 411)
        Me.pnllogin.TabIndex = 0
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbllogin.Location = New System.Drawing.Point(162, 370)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(60, 19)
        Me.lbllogin.TabIndex = 15
        Me.lbllogin.Text = "Register"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Don't have an account!"
        '
        'btnlogin
        '
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnlogin.FlatAppearance.BorderSize = 5
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnlogin.Location = New System.Drawing.Point(51, 306)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(190, 38)
        Me.btnlogin.TabIndex = 13
        Me.btnlogin.Text = "Sign in"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'txtpword
        '
        Me.txtpword.BackColor = System.Drawing.Color.White
        Me.txtpword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtpword.Location = New System.Drawing.Point(14, 247)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.Size = New System.Drawing.Size(256, 26)
        Me.txtpword.TabIndex = 8
        '
        'lblpword
        '
        Me.lblpword.AutoSize = True
        Me.lblpword.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpword.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblpword.Location = New System.Drawing.Point(10, 214)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(71, 19)
        Me.lblpword.TabIndex = 7
        Me.lblpword.Text = "Password:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtname.Location = New System.Drawing.Point(14, 161)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(256, 26)
        Me.txtname.TabIndex = 4
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblname.Location = New System.Drawing.Point(10, 129)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(75, 19)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(127, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 76)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "back!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'piclogo
        '
        Me.piclogo.BackgroundImage = CType(resources.GetObject("piclogo.BackgroundImage"), System.Drawing.Image)
        Me.piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piclogo.Location = New System.Drawing.Point(14, 21)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(107, 77)
        Me.piclogo.TabIndex = 1
        Me.piclogo.TabStop = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(386, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnllogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmlogin"
        Me.pnllogin.ResumeLayout(False)
        Me.pnllogin.PerformLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnllogin As Panel
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblpword As Label
    Friend WithEvents txtpword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbllogin As Label
End Class
