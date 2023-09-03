<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprofile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprofile))
        Me.pnlprofile = New System.Windows.Forms.Panel()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtphone = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.picaddress = New System.Windows.Forms.PictureBox()
        Me.picemail = New System.Windows.Forms.PictureBox()
        Me.picphone = New System.Windows.Forms.PictureBox()
        Me.picprofile = New System.Windows.Forms.PictureBox()
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.btngoback = New System.Windows.Forms.Button()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pnlprofile.SuspendLayout()
        CType(Me.picaddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picemail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picphone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picprofile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnltop.SuspendLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlprofile
        '
        Me.pnlprofile.BackColor = System.Drawing.Color.White
        Me.pnlprofile.Controls.Add(Me.lblname)
        Me.pnlprofile.Controls.Add(Me.txtemail)
        Me.pnlprofile.Controls.Add(Me.txtphone)
        Me.pnlprofile.Controls.Add(Me.txtaddress)
        Me.pnlprofile.Controls.Add(Me.picaddress)
        Me.pnlprofile.Controls.Add(Me.picemail)
        Me.pnlprofile.Controls.Add(Me.picphone)
        Me.pnlprofile.Controls.Add(Me.picprofile)
        Me.pnlprofile.Controls.Add(Me.pnltop)
        Me.pnlprofile.Location = New System.Drawing.Point(44, 40)
        Me.pnlprofile.Name = "pnlprofile"
        Me.pnlprofile.Size = New System.Drawing.Size(277, 455)
        Me.pnlprofile.TabIndex = 0
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblname.Location = New System.Drawing.Point(107, 173)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(61, 23)
        Me.lblname.TabIndex = 8
        Me.lblname.Text = "Label2"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtemail.Location = New System.Drawing.Point(57, 270)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(189, 26)
        Me.txtemail.TabIndex = 7
        '
        'txtphone
        '
        Me.txtphone.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphone.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtphone.Location = New System.Drawing.Point(57, 220)
        Me.txtphone.Name = "txtphone"
        Me.txtphone.Size = New System.Drawing.Size(189, 26)
        Me.txtphone.TabIndex = 6
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtaddress.Location = New System.Drawing.Point(57, 325)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(189, 80)
        Me.txtaddress.TabIndex = 5
        '
        'picaddress
        '
        Me.picaddress.BackgroundImage = CType(resources.GetObject("picaddress.BackgroundImage"), System.Drawing.Image)
        Me.picaddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picaddress.Location = New System.Drawing.Point(20, 325)
        Me.picaddress.Name = "picaddress"
        Me.picaddress.Size = New System.Drawing.Size(29, 28)
        Me.picaddress.TabIndex = 4
        Me.picaddress.TabStop = False
        '
        'picemail
        '
        Me.picemail.BackgroundImage = CType(resources.GetObject("picemail.BackgroundImage"), System.Drawing.Image)
        Me.picemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picemail.Location = New System.Drawing.Point(19, 268)
        Me.picemail.Name = "picemail"
        Me.picemail.Size = New System.Drawing.Size(30, 28)
        Me.picemail.TabIndex = 3
        Me.picemail.TabStop = False
        '
        'picphone
        '
        Me.picphone.BackgroundImage = CType(resources.GetObject("picphone.BackgroundImage"), System.Drawing.Image)
        Me.picphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picphone.Location = New System.Drawing.Point(19, 218)
        Me.picphone.Name = "picphone"
        Me.picphone.Size = New System.Drawing.Size(29, 28)
        Me.picphone.TabIndex = 2
        Me.picphone.TabStop = False
        '
        'picprofile
        '
        Me.picprofile.BackgroundImage = CType(resources.GetObject("picprofile.BackgroundImage"), System.Drawing.Image)
        Me.picprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picprofile.Location = New System.Drawing.Point(82, 79)
        Me.picprofile.Name = "picprofile"
        Me.picprofile.Size = New System.Drawing.Size(111, 79)
        Me.picprofile.TabIndex = 1
        Me.picprofile.TabStop = False
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.SaddleBrown
        Me.pnltop.Controls.Add(Me.btngoback)
        Me.pnltop.Controls.Add(Me.piclogo)
        Me.pnltop.Controls.Add(Me.label1)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(277, 42)
        Me.pnltop.TabIndex = 0
        '
        'btngoback
        '
        Me.btngoback.BackColor = System.Drawing.Color.White
        Me.btngoback.BackgroundImage = CType(resources.GetObject("btngoback.BackgroundImage"), System.Drawing.Image)
        Me.btngoback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btngoback.Dock = System.Windows.Forms.DockStyle.Left
        Me.btngoback.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btngoback.FlatAppearance.BorderSize = 3
        Me.btngoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngoback.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btngoback.Location = New System.Drawing.Point(0, 0)
        Me.btngoback.Name = "btngoback"
        Me.btngoback.Size = New System.Drawing.Size(26, 42)
        Me.btngoback.TabIndex = 4
        Me.btngoback.UseVisualStyleBackColor = False
        '
        'piclogo
        '
        Me.piclogo.BackgroundImage = CType(resources.GetObject("piclogo.BackgroundImage"), System.Drawing.Image)
        Me.piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.piclogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.piclogo.Location = New System.Drawing.Point(214, 0)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(63, 42)
        Me.piclogo.TabIndex = 2
        Me.piclogo.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.SaddleBrown
        Me.label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(107, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(75, 19)
        Me.label1.TabIndex = 0
        Me.label1.Text = "My profile"
        '
        'frmprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(368, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlprofile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmprofile"
        Me.pnlprofile.ResumeLayout(False)
        Me.pnlprofile.PerformLayout()
        CType(Me.picaddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picemail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picphone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picprofile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlprofile As Panel
    Friend WithEvents lblname As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents picaddress As PictureBox
    Friend WithEvents picemail As PictureBox
    Friend WithEvents picphone As PictureBox
    Friend WithEvents picprofile As PictureBox
    Friend WithEvents pnltop As Panel
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents label1 As Label
    Friend WithEvents btngoback As Button
End Class
