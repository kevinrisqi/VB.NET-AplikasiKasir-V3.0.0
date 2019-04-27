Imports System.Data.Odbc
Public Class FormAddBarang

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If kodeBarang.Text = "" Or namaBarang.Text = "" Or satuan.Text = "" Or stok.Text = "" Or beli.Text = "" Or jual.Text = "" Or kategoriID.Text = "" Or keterangan.Text = "" Or namaKategori.Text = "" Then
            MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
        Else
            Call koneksi()
            Dim inputData As String = "INSERT INTO barang (id_barang,nama_barang,harga_beli,harga_jual,stok,satuan,keterangan,id_kategori) values ('" & kodeBarang.Text & "', '" & namaBarang.Text & "', '" & beli.Text & "', '" & jual.Text & "', '" & stok.Text & "', '" & satuan.Text & "', '" & keterangan.Text & "', '" & kategoriID.Text & "')"
            Cmd = New OdbcCommand(inputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diinputkan")
        End If
    End Sub

    Private Sub FormAddBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'namaKategori.AddItem("Voucher")
        Call combobox()
    End Sub

    Sub combobox()
        Call koneksi()
        Dim combo As String = "SELECT DISTINCT * FROM kategori_barang"
        Cmd = New OdbcCommand(combo, Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read = True
            namaKategori.AddItem(Rd.Item("nama_kategori"))
        Loop
    End Sub

    Sub showCategoriById()
        Call koneksi()
        Dim showcat As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE kategori_barang.nama_kategori = '" & namaKategori.Text & "'"
        Cmd = New OdbcCommand(showcat, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            kategoriID.Text = Rd.Item("id_kategori")
        End If
    End Sub

    Private Sub namaKategori_onItemSelected(sender As Object, e As EventArgs) Handles namaKategori.onItemSelected
        Call showCategoriById()
    End Sub
End Class