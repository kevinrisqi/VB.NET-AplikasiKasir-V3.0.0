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
            namaKategori.Items.Add(Rd.Item("nama_kategori"))
        Loop
    End Sub

    Sub showCategoriById()
        Call koneksi()
        Dim showcat As String = "SELECT * FROM kategori_barang WHERE nama_kategori = '" & namaKategori.Text & "'"
        Cmd = New OdbcCommand(showcat, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            kategoriID.Text = Rd.Item("id_kategori")
        End If
    End Sub

    Private Sub namaKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles namaKategori.SelectedIndexChanged, namaKategori.SelectedIndexChanged
        Call showCategoriById()
    End Sub

    Private Sub kodeBarang_OnValueChanged(sender As Object, e As EventArgs) Handles kodeBarang.OnValueChanged
        If kodeBarang.Text.Length = 7 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub namaBarang_OnValueChanged(sender As Object, e As EventArgs) Handles namaBarang.OnValueChanged
        If namaBarang.Text.Length = 35 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub stok_OnValueChanged(sender As Object, e As EventArgs) Handles stok.OnValueChanged
        If stok.Text.Length = 4 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub beli_OnValueChanged(sender As Object, e As EventArgs) Handles beli.OnValueChanged
        If beli.Text.Length = 10 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub jual_OnValueChanged(sender As Object, e As EventArgs) Handles jual.OnValueChanged
        If jual.Text.Length = 10 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub ppn_OnValueChanged(sender As Object, e As EventArgs)
        If ppn.Text.Length = 9 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub satuan_OnValueChanged(sender As Object, e As EventArgs) Handles satuan.OnValueChanged
        If satuan.Text.Length = 15 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub keterangan_OnValueChanged(sender As Object, e As EventArgs) Handles keterangan.OnValueChanged
        If keterangan.Text.Length = 150 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub

    Private Sub ppn_OnValueChanged_1(sender As Object, e As EventArgs) Handles ppn.OnValueChanged
        If ppn.Text.Length = 9 Then
            MsgBox("Karakter melebihi batas !")
        End If
    End Sub
End Class