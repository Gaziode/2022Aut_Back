Public Class Se
    Public sqlconn As SqlClient.SqlConnection
    Public scd As SqlClient.SqlCommand
    Public sda As SqlClient.SqlDataAdapter
    Public dt As DataTable

    Private Sub Se_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“STDataSet.book”中。您可以根据需要移动或移除它。
        Me.BookTableAdapter.Fill(Me.STDataSet.book)
        sqlconn = New SqlClient.SqlConnection("server=WUNDER;database=ST;uid=sa;pwd=admin") 'TODO catch login
        scd = New SqlClient.SqlCommand("select * from book", sqlconn)
        sda = New SqlClient.SqlDataAdapter
        dt = New DataTable
        sqlconn.Open()
        dt.Clear()
        sda = New SqlClient.SqlDataAdapter(scd)
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub bookname_Click(sender As Object, e As EventArgs) Handles bookname.Click
        DataGridView1.DataSource = Nothing
        Dim ss As String
        ss = TextBox1.Text
        Dim ssch As String = "Select * from book where name like '%" + ss + "%'"
        If ss = "" Then
            DataGridView1.DataSource = STDataSet.book
        Else
            Dim ds2 As New DataSet()
            Dim da2 As New SqlClient.SqlDataAdapter(ssch, sqlconn)
            da2.Fill(ds2)
            DataGridView1.DataSource = ds2.Tables(0)
        End If
    End Sub

    Private Sub author_Click(sender As Object, e As EventArgs) Handles author.Click
        DataGridView1.DataSource = Nothing
        Dim ss As String
        ss = TextBox1.Text
        Dim ssch As String = "Select * from book where author like '%" + ss + "%'"
        If ss = "" Then
            DataGridView1.DataSource = STDataSet.book
        Else
            Dim ds2 As New DataSet()
            Dim da2 As New SqlClient.SqlDataAdapter(ssch, sqlconn)
            da2.Fill(ds2)
            DataGridView1.DataSource = ds2.Tables(0)
        End If
    End Sub

    Private Sub press_Click(sender As Object, e As EventArgs) Handles press.Click
        DataGridView1.DataSource = Nothing
        Dim ss As String
        ss = TextBox1.Text
        Dim ssch As String = "Select * from book where press like '%" + ss + "%'"
        If ss = "" Then
            DataGridView1.DataSource = STDataSet.book
        Else
            Dim ds2 As New DataSet()
            Dim da2 As New SqlClient.SqlDataAdapter(ssch, sqlconn)
            da2.Fill(ds2)
            DataGridView1.DataSource = ds2.Tables(0)
        End If
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        MsgBox("Output to Excel File Successfully!")
    End Sub
End Class