Imports System.Data.Odbc
Public Class FormKategoriBarang
    Private Sub FormKategoriBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        Call tampilData()
        Call kondisiAwal()
    End Sub

    Sub tampilData()
        Call koneksi()
        Dim show As String = "SELECT * FROM kategori_barang"
        Da = New OdbcDataAdapter(show, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kategori")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("kategori")
        BunifuCustomDataGrid1.ReadOnly = True
    End Sub

    Sub kondisiAwal()
        namaKategori.Text = ""
        namaKategori.Focus()
        Call tampilData()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call inputData()
    End Sub

    Sub inputData()
        If namaKategori.Text = "" Then
            MsgBox("Silahkan isi nama kategori barang !", vbInformation)
        Else
            Call koneksi()
            Dim inputData As String = "INSERT INTO kategori_barang (nama_kategori) values ('" & namaKategori.Text & "')"
            Cmd = New OdbcCommand(inputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diinputkan", vbInformation)
            Call kondisiAwal
        End If
    End Sub

    Private Sub FormKategoriBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call inputData()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub namaKategori_OnValueChanged(sender As Object, e As EventArgs) Handles namaKategori.OnValueChanged

    End Sub

    Private Sub namaKategori_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaKategori.KeyPress
        If namaKategori.Text.Length >= 13 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick
        Dim i As Integer
        Dim id As String
        i = BunifuCustomDataGrid1.CurrentRow.Index

        id = BunifuCustomDataGrid1.Item(0, i).Value
        Call koneksi()
        If MsgBox("Apakah Anda ingin menghapusnya?", vbInformation + vbYesNo) = vbYes Then
            Cmd = New OdbcCommand("DELETE FROM kategori_barang WHERE id_kategori = '" & id & "'", Conn)
            Cmd.ExecuteNonQuery()
            Call kondisiAwal()
        End If
    End Sub
End Class