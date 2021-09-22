Imports MySql.Data.MySqlClient
Public Class del_contact
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "delete from `contact_address` where `이 름` = '" & TextBox1.Text & "'"
            Dim mycomm As New MySqlCommand(sql, MyConn)
            mycomm.ExecuteNonQuery()
            MessageBox.Show("삭제 완료")
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        Finally
        End Try
        MyConn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contact.Show()
        Me.Close()
    End Sub
End Class