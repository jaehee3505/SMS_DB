Imports MySql.Data.MySqlClient
Public Class receive_contact_message
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "select `전화번호` from `contact_address` where `이 름` = '" & TextBox3.Text & "'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim command As New MySqlCommand("insert ignore into `conversation`(`전화번호`,`이 름`) values(@전화번호,@이름)", MyConn)
            command.Parameters.Add("@전화번호", MySqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@이름", MySqlDbType.VarChar).Value = TextBox3.Text
            MyConn.Open()
            command.ExecuteNonQuery()
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        End Try
        Try
            Dim command2 As New MySqlCommand("Insert into `message`(`전화번호`,`수신내용`) VALUES(@전화번호,@수신내용)", MyConn)
            command2.Parameters.Add("@전화번호", MySqlDbType.VarChar).Value = TextBox1.Text
            command2.Parameters.Add("@수신내용", MySqlDbType.VarChar).Value = TextBox2.Text
            If command2.ExecuteNonQuery() = 1 Then
                MessageBox.Show("수신성공!")
            Else
                MessageBox.Show("입력실패")
            End If
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        End Try
        MyConn.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        choose_contact2.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class