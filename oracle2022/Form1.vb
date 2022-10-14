Public Class Form1
    Public uid, pwd As String
    Public sqlconn As SqlClient.SqlConnection
    Public scd As SqlClient.SqlCommand
    Public sda As SqlClient.SqlDataAdapter
    Dim reader As SqlClient.SqlDataReader
    Dim openState As Boolean = False
    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If Not openState Then
            MsgBox("Please log in first!")
        Else
            Se.ShowDialog()
        End If

    End Sub

    Private Sub lend_Click(sender As Object, e As EventArgs) Handles lend.Click
        If Not openState Then
            MsgBox("Please log in first!")
        Else
            Borrow.ShowDialog()
        End If

    End Sub

    Private Sub ret_Click(sender As Object, e As EventArgs) Handles ret.Click
        If Not openState Then
            MsgBox("Please log in first!")
        Else
            Re.ShowDialog()
        End If

    End Sub

    Private Sub Manage_Click(sender As Object, e As EventArgs) Handles Manage.Click
        If Not openState Then
            MsgBox("Please log in first!")
        ElseIf uid <> "admin" Then
            MsgBox("You are not Administrator!")
        Else
            Admin.ShowDialog()
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        uid = uidtext.Text
        pwd = pwdtext.Text
        'sqlconn = New SqlClient.SqlConnection("server=WUNDER;database=ST;uid=sa;pwd=admin")
        'sqlconn.Open()
        'Dim qs As String = "SELECT * FROM user WHERE uid='" + uid + "' AND pwd='" + pwd + "'"
        'scd = New SqlClient.SqlCommand(qs, sqlconn)
        'reader = scd.ExecuteReader()
        'If reader.Read Then
        'welcomeTitle.Text = "Library Manage System -welcome, user" + uid
        'openState = True
        'Else
        'MsgBox("账号或密码错误！")
        'End If
        If uid = "" Or pwd = "" Then
            MsgBox("账号或密码有误！")
        Else
            welcomeTitle.Text = "Library Manage System -welcome, user" + uid
            openState = True
        End If
    End Sub
End Class
