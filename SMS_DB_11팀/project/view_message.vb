Imports MySql.Data.MySqlClient
Public Class view_message
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "select `수신내용`,`발신내용`,cast(`도착시간` as time) as `도착시간` from message where `전화번호` = '" & TextBox1.Text & "' order by `도착시간` desc"
            Dim mycomm As New MySqlCommand(sql, MyConn)
            MessageBox.Show("검색 완료")
            mycommand.Connection = MyConn
            mycommand.CommandText = sql
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydata)
            DataGridView1.DataSource = mydata
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        Finally
        End Try
        MyConn.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conversation.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            'MyConn.Open()
            sql = "select * from message where `전화번호`= '" & TextBox1.Text & "' and (`발신내용` like '%" & TextBox2.Text & "%' or `수신내용` like '%" & TextBox2.Text & "%')"
            Dim mycomm As New MySqlCommand(sql, MyConn)
            MessageBox.Show("검색 완료")
            mycommand.Connection = MyConn
            mycommand.CommandText = sql
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydata)
            DataGridView1.DataSource = mydata
        Catch myerror As MySqlException
            MessageBox.Show("error was encountered when connection" & myerror.Message)
        Finally
        End Try
        MyConn.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        del_message.Show()
    End Sub
End Class