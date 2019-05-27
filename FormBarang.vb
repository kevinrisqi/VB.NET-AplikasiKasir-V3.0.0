Imports System.Data.Odbc
Public Class FormBarang

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub kondisiAwal()
        Call tampilBarang()
        search.text = ""
        idBarang.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Sub tampilBarang()
        Call koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("barang")
        BunifuCustomDataGrid1.ReadOnly = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Sub switchPanel(ByVal panel As Form)
        MainForm.Panel2.Controls.Clear()
        panel.TopLevel = False
        MainForm.Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuCustomDataGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellDoubleClick
        Dim i As Integer
        i = BunifuCustomDataGrid1.CurrentRow.Index

        idBarang.Text = BunifuCustomDataGrid1.Item(0, i).Value
        FormAddBarang.id.Text = BunifuCustomDataGrid1.Item(0, i).Value
        FormAddBarang.kodeBarang.Text = BunifuCustomDataGrid1.Item(1, i).Value
        FormAddBarang.namaBarang.Text = BunifuCustomDataGrid1.Item(2, i).Value
        FormAddBarang.beli.Text = BunifuCustomDataGrid1.Item(3, i).Value
        FormAddBarang.jual.Text = BunifuCustomDataGrid1.Item(4, i).Value
        FormAddBarang.stok.Text = BunifuCustomDataGrid1.Item(5, i).Value
        FormAddBarang.satuan.Text = BunifuCustomDataGrid1.Item(6, i).Value
        FormAddBarang.keterangan.Text = BunifuCustomDataGrid1.Item(7, i).Value
        FormAddBarang.kategoriID.Text = BunifuCustomDataGrid1.Item(8, i).Value
        switchPanel(FormAddBarang)
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        Dim i As Integer
        i = BunifuCustomDataGrid1.CurrentRow.Index

        idBarang.Text = BunifuCustomDataGrid1.Item(0, i).Value
    End Sub

    Private Sub search_OnTextChange(sender As Object, e As EventArgs) Handles search.OnTextChange
        If RadioButton1.Checked Then
            Call koneksi()
            Dim searchData As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.id_barang  like '%" & search.text & "%'"
            Cmd = New OdbcCommand(searchData, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call koneksi()
                Dim query As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.id_barang like '%" & search.text & "%'"
                Da = New OdbcDataAdapter(query, Conn)
                Ds = New DataSet
                Da.Fill(Ds, "barang")
                BunifuCustomDataGrid1.DataSource = Ds.Tables("barang")
            End If
        Else
            Call koneksi()
            Dim searchData As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.nama_barang  like '%" & search.text & "%'"
            Cmd = New OdbcCommand(searchData, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call koneksi()
                Dim query As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.nama_barang like '%" & search.text & "%'"
                Da = New OdbcDataAdapter(query, Conn)
                Ds = New DataSet
                Da.Fill(Ds, "barang")
                BunifuCustomDataGrid1.DataSource = Ds.Tables("barang")
            End If
        End If
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        switchPanel(FormAddBarang)
    End Sub

    Private Sub BunifuiOSSwitch1_OnValueChange(sender As Object, e As EventArgs)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        If idBarang.Text = "" Then
            MsgBox("Pilih data yang akan dihapus !", vbInformation)
        ElseIf MsgBox("Apakah Anda ingin menghapusnya ?", vbInformation + vbYesNo) = vbYes Then
            Call koneksi()
            Dim deleteData As String = "DELETE FROM barang WHERE id = '" & idBarang.Text & "'"
            Cmd = New OdbcCommand(deleteData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            idBarang.Text = ""
            Call tampilBarang()
        Else
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        FormKategoriBarang.ShowDialog()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub
End Class