Public Class Student
    Public sqlconn As SqlClient.SqlConnection
    Public scd As SqlClient.SqlCommand
    Public sda As SqlClient.SqlDataAdapter
    Public dt As DataTable
    Private Sub Stu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“STDataSet3.stu”中。您可以根据需要移动或移除它。
        Me.StuTableAdapter1.Fill(Me.STDataSet3.stu)

        sqlconn = New SqlClient.SqlConnection("server=WUNDER;database=ST;uid=sa;pwd=admin") 'TODO catch login
        scd = New SqlClient.SqlCommand("select * from stu", sqlconn)
        sda = New SqlClient.SqlDataAdapter
        dt = New DataTable
        sqlconn.Open()
        dt.Clear()
        sda = New SqlClient.SqlDataAdapter(scd)
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = Nothing
        Dim ss As String
        ss = TextBox1.Text
        Dim ssch As String = "Select * from book where s_name='" + ss + "'"
        If ss = "" Then
            DataGridView1.DataSource = dt
        Else
            Dim ds2 As New DataSet()
            Dim da2 As New SqlClient.SqlDataAdapter(ssch, sqlconn)
            da2.Fill(ds2)
            DataGridView1.DataSource = ds2.Tables(0)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim scdele As New SqlClient.SqlCommand
        Dim vs As String
        vs = DataGridView1.CurrentRow.Cells(0).Value.ToString.Trim()
        scdele.CommandText = "delete from stu where s_id=" & vs
        scdele.Connection = sqlconn
        sda.DeleteCommand = scdele
        dt.Rows(DataGridView1.CurrentRow.Index).Delete()
        sda.Update(dt)
        MsgBox("Delete success!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim scb As New SqlClient.SqlCommandBuilder(sda)
        scb.GetUpdateCommand()
        sda.Update(dt)
        MsgBox("Update success!")
    End Sub
End Class