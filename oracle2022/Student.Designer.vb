<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.SidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SdeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.STDataSet3 = New DBe1.STDataSet3()
        Me.StuBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StuTableAdapter1 = New DBe1.STDataSet3TableAdapters.stuTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()

        CType(Me.STDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StuBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SidDataGridViewTextBoxColumn, Me.SnameDataGridViewTextBoxColumn, Me.SdeptDataGridViewTextBoxColumn, Me.StelDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StuBindingSource1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(1066, 389)
        Me.DataGridView1.TabIndex = 0
        '
        'SidDataGridViewTextBoxColumn
        '
        Me.SidDataGridViewTextBoxColumn.DataPropertyName = "s_id"
        Me.SidDataGridViewTextBoxColumn.HeaderText = "s_id"
        Me.SidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SidDataGridViewTextBoxColumn.Name = "SidDataGridViewTextBoxColumn"
        Me.SidDataGridViewTextBoxColumn.Width = 125
        '
        'SnameDataGridViewTextBoxColumn
        '
        Me.SnameDataGridViewTextBoxColumn.DataPropertyName = "s_name"
        Me.SnameDataGridViewTextBoxColumn.HeaderText = "s_name"
        Me.SnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SnameDataGridViewTextBoxColumn.Name = "SnameDataGridViewTextBoxColumn"
        Me.SnameDataGridViewTextBoxColumn.Width = 125
        '
        'SdeptDataGridViewTextBoxColumn
        '
        Me.SdeptDataGridViewTextBoxColumn.DataPropertyName = "s_dept"
        Me.SdeptDataGridViewTextBoxColumn.HeaderText = "s_dept"
        Me.SdeptDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SdeptDataGridViewTextBoxColumn.Name = "SdeptDataGridViewTextBoxColumn"
        Me.SdeptDataGridViewTextBoxColumn.Width = 125
        '
        'StelDataGridViewTextBoxColumn
        '
        Me.StelDataGridViewTextBoxColumn.DataPropertyName = "s_tel"
        Me.StelDataGridViewTextBoxColumn.HeaderText = "s_tel"
        Me.StelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StelDataGridViewTextBoxColumn.Name = "StelDataGridViewTextBoxColumn"
        Me.StelDataGridViewTextBoxColumn.Width = 125
        '
        'StuBindingSource
        '
        Me.StuBindingSource.DataMember = "stu"

        'DataSet1
        '

        'StuTableAdapter
        '

        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(436, 25)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(467, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(854, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.Location = New System.Drawing.Point(725, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 47)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.Location = New System.Drawing.Point(596, 21)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 47)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'STDataSet3
        '
        Me.STDataSet3.DataSetName = "STDataSet3"
        Me.STDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StuBindingSource1
        '
        Me.StuBindingSource1.DataMember = "stu"
        Me.StuBindingSource1.DataSource = Me.STDataSet3
        '
        'StuTableAdapter1
        '
        Me.StuTableAdapter1.ClearBeforeFill = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 497)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Student"
        Me.Text = "Stu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()

        CType(Me.STDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StuBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents DataGridView1 As DataGridView

    Friend WithEvents StuBindingSource As BindingSource

    Friend WithEvents SidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SdeptDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents STDataSet3 As STDataSet3
    Friend WithEvents StuBindingSource1 As BindingSource
    Friend WithEvents StuTableAdapter1 As STDataSet3TableAdapters.stuTableAdapter
End Class
