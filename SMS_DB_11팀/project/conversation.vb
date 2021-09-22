Imports MySql.Data.MySqlClient
Public Class conversation
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "select * from conversation;"
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
        del_conversation.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ser_conversation.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        choose_message.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        view_message.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        main.Show()
        Me.Close()
    End Sub
End Class