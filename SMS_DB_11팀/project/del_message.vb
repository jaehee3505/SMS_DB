Imports MySql.Data.MySqlClient
Public Class del_message
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "delete from `message` where `수신내용` = '" & TextBox1.Text & "'"
            Dim mycomm2 As New MySqlCommand(sql, MyConn)
            mycomm2.ExecuteNonQuery()
            MessageBox.Show("삭제 완료")
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
            MyConn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "delete from `message` where `발신내용` = '" & TextBox2.Text & "'"
            Dim mycomm2 As New MySqlCommand(sql, MyConn)
            mycomm2.ExecuteNonQuery()
            MessageBox.Show("삭제 완료")
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        End Try
        MyConn.Close()
    End Sub

End Class