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

    Private Sub search_OnTextChange(sender As Object, e As EventArgs) Handles search.OnTextChange
        If RadioButton1.Checked Then
            Call koneksi()
            Dim searchData As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.id_barang  like '%" & search.text & "%'"
            Cmd = New OdbcCommand(searchData, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call koneksi()
                Dim query As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.id_barang like '%" & search.text & "%'"
                Da = New OdbcDataAdapter(query, Conn)
                Ds = New DataSet
                Da.Fill(Ds, "barang")
                BunifuCustomDataGrid1.DataSource = Ds.Tables("barang")
            End If
        Else
            Call koneksi()
            Dim searchData As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.nama_barang  like '%" & search.text & "%'"
            Cmd = New OdbcCommand(searchData, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call koneksi()
                Dim query As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.nama_barang like '%" & search.text & "%'"
                Da = New OdbcDataAdapter(query, Conn)
                Ds = New DataSet
                Da.Fill(Ds, "barang")
                BunifuCustomDataGrid1.DataSource = Ds.Tables("barang")
            End If
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick
        Dim i As Integer
        i = BunifuCustomDataGrid1.CurrentRow.Index

        FormPenjualan.kodeBarang.Text = BunifuCustomDataGrid1.Item(1, i).Value
        FormPenjualan.namaBarang.Text = BunifuCustomDataGrid1.Item(2, i).Value
        FormPenjualan.hargaSatuan.Text = BunifuCustomDataGrid1.Item(4, i).Value
        FormPenjualan.kodeBarang.Focus()
        Me.Dispose()
    End Sub
End Class