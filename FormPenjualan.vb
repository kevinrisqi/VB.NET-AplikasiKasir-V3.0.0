Public Class FormPenjualan

    Private Sub FormPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class