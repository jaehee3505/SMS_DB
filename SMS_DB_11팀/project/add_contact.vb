Imports MySql.Data.MySqlClient
Public Class add_contact
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim command As New MySqlCommand("Insert into contact_address(`이 름`,`전화번호`) VALUES(@이름, @전화번호)", MyConn)
            command.Parameters.Add("@이름", MySqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@전화번호", MySqlDbType.VarChar).Value = TextBox2.Text
            MyConn.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("추가성공!")
            Else
                MessageBox.Show("입력실패")
            End If
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        End Try
        MyConn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contact.Show()
        Me.Close()
    End Sub
End Class