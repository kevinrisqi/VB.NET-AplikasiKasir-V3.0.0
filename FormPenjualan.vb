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
        Call kodeOtomatis()
        namaKasir.Text = MainForm.btnLogin.Text
    End Sub

    Sub kodeOtomatis()
        Cmd = New OdbcCommand("select * from penjualan where id_admin in (select max(id_admin) from admin)", Conn)
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
            BunifuCustomDataGrid1.Rows.Add(New String() {kodeBarang.Text, namaBarang.Text, hargaSatuan.Text, qty.Text, hargaSatuan.Text * qty.Text})
        Else
            MsgBox("Kode Barang tidak tersedia !", vbInformation)
        End If
    End Sub

    Private Sub qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub qty_TextChanged(sender As Object, e As EventArgs) Handles qty.TextChanged

    End Sub

End Class