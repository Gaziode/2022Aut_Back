Public Class Borrow
    Private Sub Borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“STDataSet1.lend”中。您可以根据需要移动或移除它。


    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        MsgBox("Borrow Confirmed")
        isbn.Text = ""
        sid.Text = ""
        num.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Reserve Confirmed")
        isbn.Text = ""
        sid.Text = ""
        num.Text = ""
    End Sub
End Class