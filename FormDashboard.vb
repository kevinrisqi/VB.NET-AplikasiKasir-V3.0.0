Imports System.Data.Odbc
Public Class FormDashboard

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call totalUser()
        Call totalProduct()
        Call totalSales()
        Call totalIncome()
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

    Sub totalSales()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT COUNT(*) FROM penjualan", Conn)
        Dim count As Integer = Cmd.ExecuteScalar
        lblSales.Text = count
    End Sub

    Sub totalIncome()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT SUM(total_jual) FROM penjualan WHERE tanggal = CURRENT_DATE()", Conn)
        Dim count As Integer = Cmd.ExecuteScalar
        lblIncome.Text = count
        lblIncome.Text = FormatCurrency(lblIncome.Text)
    End Sub

End Class