Public Class B_FormLogin

    Private Sub txtpassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtpassword.OnValueChanged
        txtpassword.isPassword = True
    End Sub

    Private Sub B_FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class