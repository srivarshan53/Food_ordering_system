<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmmyorders
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmyorders))
        Me.pnlmyorders = New System.Windows.Forms.Panel()
        Me.pnltop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.piclogo = New System.Windows.Forms.PictureBox()
        Me.btngoback = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MycafeDataSet = New MYCAFE.mycafeDataSet()
        Me.CartTableAdapter = New MYCAFE.mycafeDataSetTableAdapters.cartTableAdapter()
        Me.ItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlmyorders.SuspendLayout()
        Me.pnltop.SuspendLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MycafeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlmyorders
        '
        Me.pnlmyorders.BackColor = System.Drawing.Color.White
        Me.pnlmyorders.Controls.Add(Me.pnltop)
        Me.pnlmyorders.Controls.Add(Me.DataGridView1)
        Me.pnlmyorders.Location = New System.Drawing.Point(36, 42)
        Me.pnlmyorders.Name = "pnlmyorders"
        Me.pnlmyorders.Size = New System.Drawing.Size(251, 415)
        Me.pnlmyorders.TabIndex = 0
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.SaddleBrown
        Me.pnltop.Controls.Add(Me.Label1)
        Me.pnltop.Controls.Add(Me.piclogo)
        Me.pnltop.Controls.Add(Me.btngoback)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(251, 46)
        Me.pnltop.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(70, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "your orders"
        '
        'piclogo
        '
        Me.piclogo.BackgroundImage = CType(resources.GetObject("piclogo.BackgroundImage"), System.Drawing.Image)
        Me.piclogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piclogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.piclogo.Location = New System.Drawing.Point(191, 0)
        Me.piclogo.Name = "piclogo"
        Me.piclogo.Size = New System.Drawing.Size(60, 46)
        Me.piclogo.TabIndex = 1
        Me.piclogo.TabStop = False
        '
        'btngoback
        '
        Me.btngoback.BackColor = System.Drawing.Color.White
        Me.btngoback.BackgroundImage = CType(resources.GetObject("btngoback.BackgroundImage"), System.Drawing.Image)
        Me.btngoback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btngoback.Dock = System.Windows.Forms.DockStyle.Left
        Me.btngoback.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown
        Me.btngoback.FlatAppearance.BorderSize = 2
        Me.btngoback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngoback.Location = New System.Drawing.Point(0, 0)
        Me.btngoback.Name = "btngoback"
        Me.btngoback.Size = New System.Drawing.Size(31, 46)
        Me.btngoback.TabIndex = 0
        Me.btngoback.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CartBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(245, 360)
        Me.DataGridView1.TabIndex = 0
        '
        'CartBindingSource
        '
        Me.CartBindingSource.DataMember = "cart"
        Me.CartBindingSource.DataSource = Me.MycafeDataSet
        '
        'MycafeDataSet
        '
        Me.MycafeDataSet.DataSetName = "mycafeDataSet"
        Me.MycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartTableAdapter
        '
        Me.CartTableAdapter.ClearBeforeFill = True
        '
        'ItemDataGridViewTextBoxColumn
        '
        Me.ItemDataGridViewTextBoxColumn.DataPropertyName = "item"
        Me.ItemDataGridViewTextBoxColumn.HeaderText = "item"
        Me.ItemDataGridViewTextBoxColumn.Name = "ItemDataGridViewTextBoxColumn"
        Me.ItemDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        Me.RateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmmyorders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(329, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlmyorders)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmmyorders"
        Me.pnlmyorders.ResumeLayout(False)
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        CType(Me.piclogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MycafeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlmyorders As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MycafeDataSet As mycafeDataSet
    Friend WithEvents CartBindingSource As BindingSource
    Friend WithEvents CartTableAdapter As mycafeDataSetTableAdapters.cartTableAdapter
    Friend WithEvents pnltop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents piclogo As PictureBox
    Friend WithEvents btngoback As Button
    Friend WithEvents ItemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
