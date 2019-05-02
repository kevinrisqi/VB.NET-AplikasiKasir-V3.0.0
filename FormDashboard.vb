Imports System.Data.Odbc
Public Class FormDashboard

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call totalUser()
        Call totalProduct()
    End Sub

    Sub totalUser()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT COUNT(id_admin) FROM admin", Conn)
        Dim count As Integer = Cmd.ExecuteScalar
        lblUser.Text = count
    End Sub

    Sub totalProduct()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT COUNT(*) FROM barang", Conn)
        Dim count As Integer = Cmd.ExecuteScalar
        lblProduct.Text = count
    End Sub

End Class