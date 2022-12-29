Public Class Kamar_
    Private Sub ToolStripBtnKamar_Click(sender As Object, e As EventArgs)
        Dim main As New Penginapan(Login.Users.GSUserName, Login.Users.GSEmail)
        main.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUpdateKamar_Click(sender As Object, e As EventArgs)
        EditKamar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnDeleteKamar_Click(sender As Object, e As EventArgs)
        HapusKamar.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Close()
    End Sub

End Class