Imports MySql.Data.MySqlClient
Public Class ser_conversation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "select * from `conversation` where `이 름` like '%" & TextBox1.Text & "%'"
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "select * from `conversation` where `전화번호` like '%" & TextBox2.Text & "%'"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conversation.Show()
        Me.Close()
    End Sub
End Class