<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Se
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Se))
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IsbnDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STDataSet = New DBe1.STDataSet()
        Me.BookTableAdapter = New DBe1.STDataSetTableAdapters.bookTableAdapter()
        Me.print = New System.Windows.Forms.Button()
        Me.press = New System.Windows.Forms.Button()
        Me.author = New System.Windows.Forms.Button()
        Me.bookname = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsbnDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PressDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.RnumDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(370, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(831, 487)
        Me.DataGridView1.TabIndex = 0
        '
        'IsbnDataGridViewTextBoxColumn
        '
        Me.IsbnDataGridViewTextBoxColumn.DataPropertyName = "isbn"
        Me.IsbnDataGridViewTextBoxColumn.HeaderText = "isbn"
        Me.IsbnDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IsbnDataGridViewTextBoxColumn.Name = "IsbnDataGridViewTextBoxColumn"
        Me.IsbnDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "author"
        Me.AuthorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.Width = 125
        '
        'PressDataGridViewTextBoxColumn
        '
        Me.PressDataGridViewTextBoxColumn.DataPropertyName = "press"
        Me.PressDataGridViewTextBoxColumn.HeaderText = "press"
        Me.PressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PressDataGridViewTextBoxColumn.Name = "PressDataGridViewTextBoxColumn"
        Me.PressDataGridViewTextBoxColumn.Width = 125
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "location"
        Me.LocationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.Width = 125
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Width = 125
        '
        'RnumDataGridViewTextBoxColumn
        '
        Me.RnumDataGridViewTextBoxColumn.DataPropertyName = "r_num"
        Me.RnumDataGridViewTextBoxColumn.HeaderText = "r_num"
        Me.RnumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RnumDataGridViewTextBoxColumn.Name = "RnumDataGridViewTextBoxColumn"
        Me.RnumDataGridViewTextBoxColumn.Width = 125
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "book"
        Me.BookBindingSource.DataSource = Me.STDataSet
        '
        'STDataSet
        '
        Me.STDataSet.DataSetName = "STDataSet"
        Me.STDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'print
        '
        Me.print.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.print.Location = New System.Drawing.Point(12, 407)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(337, 40)
        Me.print.TabIndex = 10
        Me.print.Text = "Output Result"
        Me.print.UseVisualStyleBackColor = True
        '
        'press
        '
        Me.press.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.press.Location = New System.Drawing.Point(12, 142)
        Me.press.Name = "press"
        Me.press.Size = New System.Drawing.Size(337, 40)
        Me.press.TabIndex = 9
        Me.press.Text = "Search by press"
        Me.press.UseVisualStyleBackColor = True
        '
        'author
        '
        Me.author.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.author.Location = New System.Drawing.Point(12, 96)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(337, 40)
        Me.author.TabIndex = 8
        Me.author.Text = "Search by author"
        Me.author.UseVisualStyleBackColor = True
        '
        'bookname
        '
        Me.bookname.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bookname.Location = New System.Drawing.Point(12, 50)
        Me.bookname.Name = "bookname"
        Me.bookname.Size = New System.Drawing.Size(337, 40)
        Me.bookname.TabIndex = 7
        Me.bookname.Text = "Search by book name"
        Me.bookname.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(337, 25)
        Me.TextBox1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(141, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Se
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 487)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.press)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.bookname)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Se"
        Me.Text = "se"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents STDataSet As STDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As STDataSetTableAdapters.bookTableAdapter
    Friend WithEvents IsbnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents print As Button
    Friend WithEvents press As Button
    Friend WithEvents author As Button
    Friend WithEvents bookname As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
