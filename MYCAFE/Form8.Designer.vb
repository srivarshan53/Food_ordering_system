<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpayment))
        Me.pnlpayment = New System.Windows.Forms.Panel()
        Me.piccash = New System.Windows.Forms.PictureBox()
        Me.picphonepe = New System.Windows.Forms.PictureBox()
        Me.picgpay = New System.Windows.Forms.PictureBox()
        Me.btncash = New System.Windows.Forms.Button()
        Me.btnphonepe = New System.Windows.Forms.Button()
        Me.btngpay = New System.Windows.Forms.Button()
        Me.piccard = New System.Windows.Forms.PictureBox()
        Me.btngoback = New System.Windows.Forms.Button()
        Me.btncard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlpayment.SuspendLayout()
        CType(Me.piccash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picphonepe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picgpay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlpayment
        '
        Me.pnlpayment.BackColor = System.Drawing.Color.White
        Me.pnlpayment.Controls.Add(Me.piccash)
        Me.pnlpayment.Controls.Add(Me.picphonepe)
        Me.pnlpayment.Controls.Add(Me.picgpay)
        Me.pnlpayment.Controls.Add(Me.btncash)
        Me.pnlpayment.Controls.Add(Me.btnphonepe)
        Me.pnlpayment.Controls.Add(Me.btngpay)
        Me.pnlpayment.Controls.Add(Me.piccard)
        Me.pnlpayment.Controls.Add(Me.btngoback)
        Me.pnlpayment.Controls.Add(Me.btncard)
        Me.pnlpayment.Controls.Add(Me.Label1)
        Me.pnlpayment.Location = New System.Drawing.Point(36, 25)
        Me.pnlpayment.Name = "pnlpayment"
        Me.pnlpayment.Size = New System.Drawing.Size(248, 338)
        Me.pnlpayment.TabIndex = 0
        '
        'piccash
        '
        Me.piccash.BackgroundImage = CType(resources.GetObject("piccash.BackgroundImage"), System.Drawing.Image)
        Me.piccash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piccash.Location = New System.Drawing.Point(186, 251)
        Me.piccash.Name = "piccash"
        Me.piccash.Size = New System.Drawing.Size(59, 52)
        Me.piccash.TabIndex = 9
        Me.piccash.TabStop = False
        '
        'picphonepe
        '
        Me.picphonepe.BackgroundImage = CType(resources.GetObject("picphonepe.BackgroundImage"), System.Drawing.Image)
        Me.picphonepe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picphonepe.Location = New System.Drawing.Point(186, 193)
        Me.picphonepe.Name = "picphonepe"
        Me.picphonepe.Size = New System.Drawing.Size(59, 52)
        Me.picphonepe.TabIndex = 8
        Me.picphonepe.TabStop = False
        '
        'picgpay
        '
        Me.picgpay.BackgroundImage = CType(resources.GetObject("picgpay.BackgroundImage"), System.Drawing.Image)
        Me.picgpay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picgpay.Location = New System.Drawing.Point(186, 135)
        Me.picgpay.Name = "picgpay"
        Me.picgpay.Size = New System.Drawing.Size(59, 52)
        Me.picgpay.TabIndex = 7
        Me.picgpay.TabStop = False
        '
        'btncash
        '
        Me.btncash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncash.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btncash.FlatAppearance.BorderSize = 3
        Me.btncash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncash.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncash.ForeColor = System.Drawing.Color.Chocolate
        Me.btncash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncash.Location = New System.Drawing.Point(3, 251)
        Me.btncash.Name = "btncash"
        Me.btncash.Size = New System.Drawing.Size(177, 52)
        Me.btncash.TabIndex = 6
        Me.btncash.Text = "pay cash at the counter"
        Me.btncash.UseVisualStyleBackColor = True
        '
        'btnphonepe
        '
        Me.btnphonepe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnphonepe.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnphonepe.FlatAppearance.BorderSize = 3
        Me.btnphonepe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnphonepe.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnphonepe.ForeColor = System.Drawing.Color.Chocolate
        Me.btnphonepe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnphonepe.Location = New System.Drawing.Point(3, 193)
        Me.btnphonepe.Name = "btnphonepe"
        Me.btnphonepe.Size = New System.Drawing.Size(177, 52)
        Me.btnphonepe.TabIndex = 5
        Me.btnphonepe.Text = "PhonePe"
        Me.btnphonepe.UseVisualStyleBackColor = True
        '
        'btngpay
        '
        Me.btngpay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btngpay.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btngpay.FlatAppearance.BorderSize = 3
        Me.btngpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngpay.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngpay.ForeColor = System.Drawing.Color.Chocolate
        Me.btngpay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btngpay.Location = New System.Drawing.Point(3, 135)
        Me.btngpay.Name = "btngpay"
        Me.btngpay.Size = New System.Drawing.Size(177, 52)
        Me.btngpay.TabIndex = 4
        Me.btngpay.Text = "Gpay"
        Me.btngpay.UseVisualStyleBackColor = True
        '
        'piccard
        '
        Me.piccard.BackgroundImage = CType(resources.GetObject("piccard.BackgroundImage"), System.Drawing.Image)
        Me.piccard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.piccard.Location = New System.Drawing.Point(186, 77)
        Me.piccard.Name = "piccard"
        Me.piccard.Size = New System.Drawing.Size(59, 52)
        Me.piccard.TabIndex = 3
        Me.piccard.TabStop = False
        '
        'btngoback
        '
        Me.btngoback.BackgroundImage = CType(resources.GetObject("btngoback.BackgroundImage"), System.Drawing.Image)
        Me.btngoback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btngoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngoback.Location = New System.Drawing.Point(3, 3)
        Me.btngoback.Name = "btngoback"
        Me.btngoback.Size = New System.Drawing.Size(28, 28)
        Me.btngoback.TabIndex = 2
        Me.btngoback.UseVisualStyleBackColor = True
        '
        'btncard
        '
        Me.btncard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btncard.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btncard.FlatAppearance.BorderSize = 3
        Me.btncard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncard.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncard.ForeColor = System.Drawing.Color.Chocolate
        Me.btncard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncard.Location = New System.Drawing.Point(3, 77)
        Me.btncard.Name = "btncard"
        Me.btncard.Size = New System.Drawing.Size(177, 52)
        Me.btncard.TabIndex = 1
        Me.btncard.Text = "Card"
        Me.btncard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(37, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "choose " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "payment method"
        '
        'frmpayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(321, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlpayment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmpayment"
        Me.pnlpayment.ResumeLayout(False)
        Me.pnlpayment.PerformLayout()
        CType(Me.piccash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picphonepe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picgpay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlpayment As Panel
    Friend WithEvents picgpay As PictureBox
    Friend WithEvents btncash As Button
    Friend WithEvents btnphonepe As Button
    Friend WithEvents btngpay As Button
    Friend WithEvents piccard As PictureBox
    Friend WithEvents btngoback As Button
    Friend WithEvents btncard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents piccash As PictureBox
    Friend WithEvents picphonepe As PictureBox
End Class
