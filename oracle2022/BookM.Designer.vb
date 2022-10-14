<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookM
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

        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.STDataSet2 = New DBe1.STDataSet2()
        Me.BookBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableAdapter1 = New DBe1.STDataSet2TableAdapters.bookTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.STDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IsbnDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PressDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.RnumDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(1144, 424)
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

        '

        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(25, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(379, 25)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(428, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(579, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(736, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 49)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(891, 28)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 49)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'STDataSet2
        '
        Me.STDataSet2.DataSetName = "STDataSet2"
        Me.STDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookBindingSource1
        '
        Me.BookBindingSource1.DataMember = "book"
        Me.BookBindingSource1.DataSource = Me.STDataSet2
        '
        'BookTableAdapter1
        '
        Me.BookTableAdapter1.ClearBeforeFill = True
        '
        'BookM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 536)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "BookM"
        Me.Text = "Book"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.STDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents DataGridView1 As DataGridView

    Friend WithEvents BookBindingSource As BindingSource

    Friend WithEvents IsbnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RnumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents STDataSet2 As STDataSet2
    Friend WithEvents BookBindingSource1 As BindingSource
    Friend WithEvents BookTableAdapter1 As STDataSet2TableAdapters.bookTableAdapter
End Class
