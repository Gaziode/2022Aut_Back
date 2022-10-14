Public Class Admin
    Private Sub stu_Click(sender As Object, e As EventArgs) Handles stu.Click
        Student.ShowDialog()
    End Sub

    Private Sub book_Click(sender As Object, e As EventArgs) Handles book.Click
        BookM.ShowDialog()
    End Sub
End Class