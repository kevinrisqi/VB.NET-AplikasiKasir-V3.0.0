Imports System.Data.Odbc
Public Class FormAddBarang

    Private Sub FormAddBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            If id.Text = "" Then
                Call insertData()
            Else
                Call updateData()
            End If
        End If
    End Sub

    Private Sub FormAddBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combobox()
        KeyPreview = True
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

    Private Sub kodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeBarang.KeyPress
        If kodeBarang.Text.Length >= 6 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub namaBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaBarang.KeyPress
        If namaBarang.Text.Length >= 35 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub stok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stok.KeyPress
        If stok.Text.Length >= 4 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub stokMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub beliMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles beli.KeyPress
        If beli.Text.Length >= 9 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub beli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles beli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub jual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jual.KeyPress
        If jual.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub jualMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub ppn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ppn.KeyPress
        If ppn.Text.Length >= 9 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub satuan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles satuan.KeyPress
        If satuan.Text.Length >= 15 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub keterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keterangan.KeyPress
        If keterangan.Text.Length >= 130 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub keteranganSubmit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles keterangan.KeyPress

    End Sub

    Sub switchPanel(ByVal panel As Form)
        MainForm.Panel2.Controls.Clear()
        panel.TopLevel = False
        MainForm.Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub kondisiAwal()
        kodeBarang.Text = ""
        namaBarang.Text = ""
        satuan.Text = ""
        beli.Text = ""
        jual.Text = ""
        keterangan.Text = ""
        stok.Text = ""
        kategoriID.Text = ""
        id.Text = ""
    End Sub

    Sub insertData()
        If kodeBarang.Text = "" Or namaBarang.Text = "" Or satuan.Text = "" Or stok.Text = "" Or beli.Text = "" Or jual.Text = "" Or kategoriID.Text = "" Or keterangan.Text = "" Or namaKategori.Text = "" Then
            MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
        ElseIf Val(beli.Text) > Val(jual.Text) Then
            MsgBox("Harga beli harus lebih kecil dari harga jual !", vbInformation)
        Else
            Call koneksi()
            Dim inputData As String = "INSERT INTO barang (id_barang,nama_barang,harga_beli,harga_jual,stok,satuan,keterangan,id_kategori,tanggal_input,nama_admin) values ('" & kodeBarang.Text & "', '" & namaBarang.Text & "', '" & beli.Text & "', '" & jual.Text & "', '" & stok.Text & "', '" & satuan.Text & "', '" & keterangan.Text & "', '" & kategoriID.Text & "', '" & tanggalInput.Text & "','" & MainForm.btnLogin.Text & "')"
            Cmd = New OdbcCommand(inputData, Conn)
            Cmd.ExecuteNonQuery()
            Call FormBarang.tampilBarang()
            Call kondisiAwal()
            Call FormBarang.kondisiAwal()
            switchPanel(FormBarang)
        End If
    End Sub

    Sub updateData()
        If kodeBarang.Text = "" Or namaBarang.Text = "" Or satuan.Text = "" Or stok.Text = "" Or beli.Text = "" Or jual.Text = "" Or kategoriID.Text = "" Or keterangan.Text = "" Then
            MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
        ElseIf Val(beli.Text) > Val(jual.Text) Then
            MsgBox("Harga beli harus lebih kecil dari harga jual !", vbInformation)
        Else
            Call koneksi()
            Dim updateData As String = "UPDATE barang SET id_barang = '" & kodeBarang.Text & "',nama_barang = '" & namaBarang.Text & "', harga_beli = '" & beli.Text & "', harga_jual = '" & jual.Text & "',stok = '" & stok.Text & "', satuan = '" & satuan.Text & "', keterangan = '" & keterangan.Text & "',id_kategori = '" & kategoriID.Text & "', tanggal_update = '" & tanggalUpdate.Text & "', nama_admin='" & MainForm.btnLogin.Text & "' WHERE id = '" & id.Text & "' "
            Cmd = New OdbcCommand(updateData, Conn)
            Cmd.ExecuteNonQuery()
            Call FormBarang.tampilBarang()
            Call kondisiAwal()
            Call FormBarang.kondisiAwal()
            switchPanel(FormBarang)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tanggalInput.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        tanggalUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub beli_OnValueChanged(sender As Object, e As EventArgs) Handles beli.OnValueChanged

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If id.Text = "" Then
            Call insertData()
        Else
            Call updateData()
        End If
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        switchPanel(FormBarang)
        Call kondisiAwal()
    End Sub
End Class