<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblcvv = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblcardno = New System.Windows.Forms.Label()
        Me.btnpay = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btncancel)
        Me.Panel1.Controls.Add(Me.lblamount)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.lblcvv)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblcardno)
        Me.Panel1.Controls.Add(Me.btnpay)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(40, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 365)
        Me.Panel1.TabIndex = 0
        '
        'btncancel
        '
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btncancel.FlatAppearance.BorderSize = 2
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Chocolate
        Me.btncancel.Location = New System.Drawing.Point(77, 329)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 30)
        Me.btncancel.TabIndex = 10
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblamount.Location = New System.Drawing.Point(83, 31)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(50, 19)
        Me.lblamount.TabIndex = 9
        Me.lblamount.Text = "Label5"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblname.Location = New System.Drawing.Point(19, 221)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(50, 19)
        Me.lblname.TabIndex = 8
        Me.lblname.Text = "Name:"
        '
        'lblcvv
        '
        Me.lblcvv.AutoSize = True
        Me.lblcvv.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcvv.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblcvv.Location = New System.Drawing.Point(148, 151)
        Me.lblcvv.Name = "lblcvv"
        Me.lblcvv.Size = New System.Drawing.Size(34, 19)
        Me.lblcvv.TabIndex = 7
        Me.lblcvv.Text = "cvv:"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lbldate.Location = New System.Drawing.Point(16, 148)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(107, 19)
        Me.lbldate.TabIndex = 6
        Me.lbldate.Text = "year of expiry:"
        '
        'lblcardno
        '
        Me.lblcardno.AutoSize = True
        Me.lblcardno.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcardno.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblcardno.Location = New System.Drawing.Point(19, 83)
        Me.lblcardno.Name = "lblcardno"
        Me.lblcardno.Size = New System.Drawing.Size(94, 19)
        Me.lblcardno.TabIndex = 5
        Me.lblcardno.Text = "card number:"
        '
        'btnpay
        '
        Me.btnpay.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnpay.FlatAppearance.BorderSize = 2
        Me.btnpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpay.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpay.ForeColor = System.Drawing.Color.Chocolate
        Me.btnpay.Location = New System.Drawing.Point(77, 293)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(75, 30)
        Me.btnpay.TabIndex = 4
        Me.btnpay.Text = "pay now"
        Me.btnpay.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.Chocolate
        Me.TextBox4.Location = New System.Drawing.Point(20, 243)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(193, 26)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.Chocolate
        Me.TextBox3.Location = New System.Drawing.Point(148, 170)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(65, 26)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.Chocolate
        Me.TextBox2.Location = New System.Drawing.Point(20, 170)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(58, 26)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Chocolate
        Me.TextBox1.Location = New System.Drawing.Point(20, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 26)
        Me.TextBox1.TabIndex = 0
        '
        'frmcard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(309, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmcard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btncancel As Button
    Friend WithEvents lblamount As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblcvv As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents lblcardno As Label
    Friend WithEvents btnpay As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
