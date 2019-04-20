Imports System.Data.Odbc
Public Class FormSetupToko


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Sub tampilData()
        Call koneksi()
        Dim show As String = "SELECT * FROM setup_toko"
        Cmd = New OdbcCommand(show, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            TextBox1.Text = Rd.Item("nama_toko")
            TextBox2.Text = Rd.Item("alamat_toko")
            TextBox3.Text = Rd.Item("telepon")
        End If
    End Sub

    Private Sub FormSetupToko_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Silahkan isi nama kategori barang !", vbInformation)
        Else
            Call koneksi()
            Dim updateData As String = "UPDATE setup_toko SET nama_toko = '" & TextBox1.Text & "', alamat_toko = '" & TextBox2.Text & "', telepon = '" & TextBox3.Text & "' WHERE id = '1'"
            Cmd = New OdbcCommand(updateData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diubah !")
            tampilData()
        End If
    End Sub
End Class