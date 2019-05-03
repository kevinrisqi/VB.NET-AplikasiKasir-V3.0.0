Imports System.Data.Odbc
Public Class DetailBarang

    Sub tampilBarang()
        Call koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("barang")
        BunifuCustomDataGrid1.ReadOnly = True
    End Sub

    Private Sub DetailBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call tampilBarang()
    End Sub
End Class