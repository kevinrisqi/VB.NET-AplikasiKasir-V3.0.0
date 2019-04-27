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
        namaKategori.AddItem("Voucher")
    End Sub
End Class