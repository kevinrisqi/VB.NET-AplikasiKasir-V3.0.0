Imports System.Data.Odbc
Public Class FormBarang

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call dgv()
        Call tampilBarang()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Sub tampilBarang()
        Call koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "barang")
        DataGridView1.DataSource = Ds.Tables("barang")
        DataGridView1.ReadOnly = True
    End Sub

    Sub dgv()
        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False

        DataGridView1.Columns(1).HeaderText = "ID Barang"
        DataGridView1.Columns(2).HeaderText = "Nama Barang"
        DataGridView1.Columns(3).HeaderText = "Harga Beli"
        DataGridView1.Columns(4).HeaderText = "Harga Jual"
        DataGridView1.Columns(5).HeaderText = "Stok"
        DataGridView1.Columns(10).HeaderText = "Kategori"

        DataGridView1.Columns(1).Width = "90"
        DataGridView1.Columns(2).Width = "150"
        DataGridView1.Columns(3).Width = "100"
        DataGridView1.Columns(4).Width = "100"
        DataGridView1.Columns(5).Width = "50"
        DataGridView1.Columns(10).Width = "100"


        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Sub switchPanel(ByVal panel As Form)
        MainForm.Panel2.Controls.Clear()
        panel.TopLevel = False
        MainForm.Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        switchPanel(FormAddBarang)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        idBarang.Text = DataGridView1.Item(0, i).Value
        FormAddBarang.id.Text = DataGridView1.Item(0, i).Value
        FormAddBarang.kodeBarang.Text = DataGridView1.Item(1, i).Value
        FormAddBarang.namaBarang.Text = DataGridView1.Item(2, i).Value
        FormAddBarang.beli.Text = DataGridView1.Item(3, i).Value
        FormAddBarang.jual.Text = DataGridView1.Item(4, i).Value
        FormAddBarang.stok.Text = DataGridView1.Item(5, i).Value
        FormAddBarang.satuan.Text = DataGridView1.Item(6, i).Value
        FormAddBarang.keterangan.Text = DataGridView1.Item(7, i).Value
        FormAddBarang.kategoriID.Text = DataGridView1.Item(8, i).Value
        switchPanel(FormAddBarang)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        idBarang.Text = DataGridView1.Item(0, i).Value
    End Sub

    Private Sub search_OnTextChange(sender As Object, e As EventArgs) Handles search.OnTextChange
        Call koneksi()
        Dim searchData As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.nama_barang like '%" & search.text & "%'"
        Cmd = New OdbcCommand(searchData, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call koneksi()
            Dim query As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE barang.nama_barang like '%" & search.text & "%'"
            Da = New OdbcDataAdapter(query, Conn)
            Ds = New DataSet
            Da.Fill(Ds, "barang")
            DataGridView1.DataSource = Ds.Tables("barang")
        End If
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        If MsgBox("Apakah Anda ingin menghapusnya ?", vbInformation + vbYesNo) = vbYes Then
            Call koneksi()
            Dim deleteData As String = "DELETE FROM barang WHERE id = '" & idBarang.Text & "'"
            Cmd = New OdbcCommand(deleteData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            idBarang.Text = ""
            Call tampilBarang()
        End If
    End Sub
End Class