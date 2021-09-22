Imports MySql.Data.MySqlClient
Public Class receive_nocontact_message
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim command As New MySqlCommand("Insert ignore into `conversation`(`전화번호`) VALUES(@전화번호)", MyConn)
            command.Parameters.Add("@전화번호", MySqlDbType.VarChar).Value = TextBox1.Text
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        choose_contact2.Show()
        Me.Close()
    End Sub

    Private Sub receive_nocontact_message_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class