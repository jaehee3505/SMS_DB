Imports MySql.Data.MySqlClient
Public Class choose_message
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        choose_contact2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        choose_contact.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conversation.Show()
        Me.Close()
    End Sub
End Class