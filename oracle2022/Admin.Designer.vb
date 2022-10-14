<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.stu = New System.Windows.Forms.Button()
        Me.book = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'stu
        '
        Me.stu.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.stu.Location = New System.Drawing.Point(182, 150)
        Me.stu.Name = "stu"
        Me.stu.Size = New System.Drawing.Size(419, 61)
        Me.stu.TabIndex = 0
        Me.stu.Text = "Student Information Management"
        Me.stu.UseVisualStyleBackColor = True
        '
        'book
        '
        Me.book.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.book.Location = New System.Drawing.Point(182, 263)
        Me.book.Name = "book"
        Me.book.Size = New System.Drawing.Size(419, 61)
        Me.book.TabIndex = 1
        Me.book.Text = "Book Information Management"
        Me.book.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(543, 57)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome, administrator!"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DBe1.My.Resources.Resources.a1
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.book)
        Me.Controls.Add(Me.stu)
        Me.DoubleBuffered = True
        Me.Name = "Admin"
        Me.Text = "admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stu As Button
    Friend WithEvents book As Button
    Friend WithEvents Label1 As Label
End Class
