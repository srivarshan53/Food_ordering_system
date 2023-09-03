<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblprompt = New System.Windows.Forms.Label()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblprompt
        '
        Me.lblprompt.AutoSize = True
        Me.lblprompt.BackColor = System.Drawing.Color.Transparent
        Me.lblprompt.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprompt.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblprompt.Location = New System.Drawing.Point(74, 227)
        Me.lblprompt.Name = "lblprompt"
        Me.lblprompt.Size = New System.Drawing.Size(314, 76)
        Me.lblprompt.TabIndex = 0
        Me.lblprompt.Text = "Grab your best coffee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        in town"
        '
        'piclogo
        '
        Me.piclogo.BackgroundImage = CType(resources.GetObject("piclogo.BackgroundImage"), System.Drawing.Image)
        Me.piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piclogo.Location = New System.Drawing.Point(93, 21)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(267, 203)
        Me.piclogo.TabIndex = 1
        Me.piclogo.TabStop = False
        '
        'btnregister
        '
        Me.btnregister.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnregister.FlatAppearance.BorderSize = 5
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregister.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnregister.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnregister.Location = New System.Drawing.Point(18, 306)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(190, 38)
        Me.btnregister.TabIndex = 2
        Me.btnregister.Text = "Register"
        Me.btnregister.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btnlogin.FlatAppearance.BorderSize = 5
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnlogin.Location = New System.Drawing.Point(252, 306)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(190, 38)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.piclogo)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.lblprompt)
        Me.Panel1.Controls.Add(Me.btnregister)
        Me.Panel1.Location = New System.Drawing.Point(87, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 371)
        Me.Panel1.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(636, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblprompt As Label
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents btnregister As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents Panel1 As Panel
End Class
