Imports System.Data.Odbc
Public Class FormPenjualan

    Private Sub FormPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            If qty.Text = "" Or 0 Then
                MsgBox("Mohon untuk mengisi qty !", vbInformation)
            Else
                Call inputBarang()
            End If
        End If
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
        Call loadDetail()
        'Call hitungSubTotal()
    End Sub

    Sub kondisiAwal()
        Call kodeOtomatis()
        txtIdAdmin.Text = MainForm.lblIdAdmin.Text
        namaKasir.Text = MainForm.btnLogin.Text
        kodeBarang.Text = ""
        qty.Text = "1"
        kembali.Text = ""
        bayar.Text = ""
        Total.Text = "0"
    End Sub


    Sub kodeOtomatis()
        Cmd = New OdbcCommand("select * from penjualan where id_penjualan in (select max(id_penjualan) from penjualan)", Conn)
        Dim urutan As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutan = "T" + Format(Now, "yyyyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            urutan = "T" + Format(Now, "yyyyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        noTransaksi.Text = urutan
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = DateTime.Now.ToString("hh:mm:ss")
        tanggal.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Sub inputBarang()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT * FROM barang WHERE id_barang = '" & kodeBarang.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            namaBarang.Text = Rd.Item("nama_barang")
            hargaSatuan.Text = Rd.Item("harga_jual")
            Cmd = New OdbcCommand("INSERT INTO detail_penjualan (id_penjualan,id_barang,nama_barang,harga_satuan,qty,subtotal) VALUES ('" & noTransaksi.Text & "', '" & kodeBarang.Text & "','" & namaBarang.Text & "','" & hargaSatuan.Text & "','" & qty.Text & "','" & Val(hargaSatuan.Text) * Val(qty.Text) & "')", Conn)
            Cmd.ExecuteNonQuery()
            Call loadDetail()
            Call hitungSubTotal()
            Call totalQty()
        Else
            MsgBox("Kode Barang tidak tersedia !", vbInformation)
        End If
    End Sub


    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Sub hitungSubTotal()
        Dim count As Integer = 0
        Call koneksi()
        Cmd = New OdbcCommand("SELECT SUM(subtotal) FROM detail_penjualan WHERE id_penjualan='" & noTransaksi.Text & "'", Conn)
        count = Cmd.ExecuteScalar
        Total.Text = count
    End Sub

    Sub hitungKembalian()
        Dim kembalian As Integer
        If bayar.Text = "" Then
            kembali.Text = "0"
        Else
            kembalian = Val(bayar.Text) - Val(Total.Text)
            kembali.Text = kembalian
        End If
    End Sub

    Private Sub bayar_TextChanged(sender As Object, e As EventArgs) Handles bayar.TextChanged
        Call hitungKembalian()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        DetailBarang.Show()
    End Sub

    Sub totalQty()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT SUM(qty) FROM detail_penjualan WHERE id_penjualan='" & noTransaksi.Text & "'", Conn)
        Dim count As Integer = Cmd.ExecuteScalar
        qtyTotal.Text = count
    End Sub

    Sub loadDetail()
        Call koneksi()
        Da = New OdbcDataAdapter("SELECT id_barang, nama_barang,harga_satuan,SUM(qty) AS qty,SUM(subtotal) AS SubTotal FROM detail_penjualan WHERE id_penjualan='" & noTransaksi.Text & "' GROUP BY id_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "detail")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("detail")
        BunifuCustomDataGrid1.ReadOnly = True
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If (bayar.Text = "" Or Total.Text = "" Or kembali.Text = "") Then
            MsgBox("Silahkan lakukan transaksi !", vbInformation)
        ElseIf Val(kembali.Text) < 0 Then
            MsgBox("Pembayaran kurang !", vbInformation)
        Else
            Call koneksi()
            Cmd = New OdbcCommand("INSERT INTO penjualan (id_penjualan,tanggal,jam,item_jual,total_jual,total_dibayar,kembali,id_admin) VALUES ('" & noTransaksi.Text & "', '" & tanggal.Text & "','" & jam.Text & "','" & qtyTotal.Text & "','" & Total.Text & "','" & bayar.Text & "','" & kembali.Text & "','" & txtIdAdmin.Text & "')", Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di inputkan !", vbInformation)
            Call kondisiAwal()
            Call loadDetail()
        End If
    End Sub

End Class