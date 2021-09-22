Imports MySql.Data.MySqlClient
Public Class del_conversation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim sql2 As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "delete from `message` where `전화번호` = '" & TextBox1.Text & "'"
            Dim mycomm As New MySqlCommand(sql, MyConn)
            mycomm.ExecuteNonQuery()
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        Finally
        End Try
        Try
            sql2 = "delete from `conversation` where `전화번호` = '" & TextBox1.Text & "'"
            Dim mycomm2 As New MySqlCommand(sql2, MyConn)
            mycomm2.ExecuteNonQuery()
            MessageBox.Show("삭제 완료")
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)

        End Try
        MyConn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "select `전화번호` from `contact_address` where `이 름` = '" & TextBox2.Text & "'"
            Dim mycomm As New MySqlCommand(sql, MyConn)
            Dim dbreader As MySqlDataReader
            dbreader = mycomm.ExecuteReader
            While dbreader.Read
                TextBox1.Text = dbreader.GetString(0)
            End While
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        End Try
        MyConn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conversation.Show()
        Me.Close()
    End Sub
End Class