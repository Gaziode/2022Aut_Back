<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.welcomeTitle = New System.Windows.Forms.Label()
        Me.Manage = New System.Windows.Forms.Button()
        Me.lend = New System.Windows.Forms.Button()
        Me.ret = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.Button()
        Me.uidtext = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pwdtext = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.SuspendLayout()
        '
        'welcomeTitle
        '
        Me.welcomeTitle.AutoSize = True
        Me.welcomeTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.welcomeTitle.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.welcomeTitle.Location = New System.Drawing.Point(321, 29)
        Me.welcomeTitle.Name = "welcomeTitle"
        Me.welcomeTitle.Size = New System.Drawing.Size(449, 27)
        Me.welcomeTitle.TabIndex = 0
        Me.welcomeTitle.Text = "Library Manage System - offline, please log in"
        '
        'Manage
        '
        Me.Manage.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Manage.Location = New System.Drawing.Point(23, 317)
        Me.Manage.Name = "Manage"
        Me.Manage.Size = New System.Drawing.Size(216, 61)
        Me.Manage.TabIndex = 1
        Me.Manage.Text = "Administrator"
        Me.Manage.UseVisualStyleBackColor = True
        '
        'lend
        '
        Me.lend.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lend.Location = New System.Drawing.Point(23, 148)
        Me.lend.Name = "lend"
        Me.lend.Size = New System.Drawing.Size(216, 61)
        Me.lend.TabIndex = 2
        Me.lend.Text = "Borrow"
        Me.lend.UseVisualStyleBackColor = True
        '
        'ret
        '
        Me.ret.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ret.Location = New System.Drawing.Point(23, 235)
        Me.ret.Name = "ret"
        Me.ret.Size = New System.Drawing.Size(216, 61)
        Me.ret.TabIndex = 3
        Me.ret.Text = "Return"
        Me.ret.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.search.Location = New System.Drawing.Point(23, 66)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(216, 61)
        Me.search.TabIndex = 4
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = True
        '
        'uidtext
        '
        Me.uidtext.Location = New System.Drawing.Point(440, 124)
        Me.uidtext.Name = "uidtext"
        Me.uidtext.Size = New System.Drawing.Size(250, 25)
        Me.uidtext.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(358, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password:"
        '
        'pwdtext
        '
        Me.pwdtext.Location = New System.Drawing.Point(440, 169)
        Me.pwdtext.Name = "pwdtext"
        Me.pwdtext.Size = New System.Drawing.Size(250, 25)
        Me.pwdtext.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(343, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(383, 39)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Log in"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLIRDA11;Data Source=.;Integrated Security=SSPI;Initial Catalog=ST"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pwdtext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uidtext)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.ret)
        Me.Controls.Add(Me.lend)
        Me.Controls.Add(Me.Manage)
        Me.Controls.Add(Me.welcomeTitle)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents welcomeTitle As Label
    Friend WithEvents Manage As Button
    Friend WithEvents lend As Button
    Friend WithEvents ret As Button
    Friend WithEvents search As Button
    Friend WithEvents uidtext As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pwdtext As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
End Class
