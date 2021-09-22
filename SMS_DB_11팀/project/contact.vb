Imports MySql.Data.MySqlClient
Public Class contact
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim mycommand As New MySqlCommand
        Dim myadapter As New MySqlDataAdapter
        Dim mydata As New DataTable
        Try
            MyConn.Open()
            sql = "select * from contact_address order by `이 름` asc;"
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
        add_contact.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        del_contact.Show()
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ser_contact.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        main.Show()
        Me.Close()
    End Sub
End Class