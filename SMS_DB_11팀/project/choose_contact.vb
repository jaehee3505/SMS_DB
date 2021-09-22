Public Class choose_contact
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        send_nocontact_message.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        send_contact_message.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        choose_message.Show()
        Me.Close()
    End Sub
End Class