Imports System.Data.Odbc
Public Class FormPenjualan

    Private Sub FormPenjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        
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
            urutan = "TR" + "001" + DateTime.Now.ToString("yyyyMMdd")
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "TR" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        noTransaksi.Text = urutan
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        jam.Text = DateTime.Now.ToString("hh:mm:ss")
        tanggal.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub
End Class