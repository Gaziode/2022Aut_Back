<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.num = New System.Windows.Forms.TextBox()
        Me.confirm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID:"
        '
        'sid
        '
        Me.sid.Location = New System.Drawing.Point(113, 23)
        Me.sid.Name = "sid"
        Me.sid.Size = New System.Drawing.Size(329, 25)
        Me.sid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Book ISBN:"
        '
        'isbn
        '
        Me.isbn.Location = New System.Drawing.Point(145, 68)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(297, 25)
        Me.isbn.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity:"
        '
        'num
        '
        Me.num.Location = New System.Drawing.Point(123, 112)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(70, 25)
        Me.num.TabIndex = 5
        '
        'confirm
        '
        Me.confirm.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.confirm.Location = New System.Drawing.Point(24, 159)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(418, 59)
        Me.confirm.TabIndex = 6
        Me.confirm.Text = "Borrow"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(418, 59)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Reserve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.isbn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Borrow"
        Me.ShowIcon = False
        Me.Text = "Borrow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents sid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents isbn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents num As TextBox
    Friend WithEvents confirm As Button

    Friend WithEvents SidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsbnDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
