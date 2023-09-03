<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmupi
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.btnpay = New System.Windows.Forms.Button()
        Me.lblprompt = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(67, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 26)
        Me.TextBox1.TabIndex = 0
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamount.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblamount.Location = New System.Drawing.Point(92, 26)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(50, 19)
        Me.lblamount.TabIndex = 1
        Me.lblamount.Text = "Label1"
        '
        'btnpay
        '
        Me.btnpay.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnpay.FlatAppearance.BorderSize = 2
        Me.btnpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpay.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpay.ForeColor = System.Drawing.Color.Chocolate
        Me.btnpay.Location = New System.Drawing.Point(82, 158)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(75, 33)
        Me.btnpay.TabIndex = 3
        Me.btnpay.Text = "pay"
        Me.btnpay.UseVisualStyleBackColor = True
        '
        'lblprompt
        '
        Me.lblprompt.AutoSize = True
        Me.lblprompt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprompt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblprompt.Location = New System.Drawing.Point(74, 125)
        Me.lblprompt.Name = "lblprompt"
        Me.lblprompt.Size = New System.Drawing.Size(93, 19)
        Me.lblprompt.TabIndex = 4
        Me.lblprompt.Text = "enter the pin"
        Me.lblprompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncancel
        '
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btncancel.FlatAppearance.BorderSize = 2
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Chocolate
        Me.btncancel.Location = New System.Drawing.Point(82, 217)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 33)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmupi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(237, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lblprompt)
        Me.Controls.Add(Me.btnpay)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmupi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblamount As Label
    Friend WithEvents btnpay As Button
    Friend WithEvents lblprompt As Label
    Friend WithEvents btncancel As Button
End Class
