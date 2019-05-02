Imports System.Data.Odbc
Public Class FormSetupToko

    Sub tampilData()
        Call koneksi()
        Dim show As String = "SELECT * FROM setup_toko"
        Cmd = New OdbcCommand(show, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            namaToko.Text = Rd.Item("nama_toko")
            alamatToko.Text = Rd.Item("alamat_toko")
            telepon.Text = Rd.Item("telepon")
        End If
    End Sub

    Private Sub FormSetupToko_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            Call updateData()
        End If
    End Sub

    Private Sub FormSetupToko_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
    End Sub

    Private Sub telepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telepon.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call updateData()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        namaToko.Text = ""
        alamatToko.Text = ""
        telepon.Text = ""
    End Sub

    Private Sub namaToko_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaToko.KeyPress
        If namaToko.Text.Length >= 15 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub alamatToko_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alamatToko.KeyPress
        If alamatToko.Text.Length >= 35 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub telepon1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telepon.KeyPress
        If telepon.Text.Length >= 13 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub updateData()
        If namaToko.Text = "" Or alamatToko.Text = "" Or telepon.Text = "" Then
            MsgBox("Silahkan isi identitas toko Anda !", vbInformation)
        Else
            Call koneksi()
            Dim updateData As String = "UPDATE setup_toko SET nama_toko = '" & namaToko.Text & "', alamat_toko = '" & alamatToko.Text & "', telepon = '" & telepon.Text & "' WHERE id = '1'"
            Cmd = New OdbcCommand(updateData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diubah !")
            tampilData()
        End If
    End Sub
End Class