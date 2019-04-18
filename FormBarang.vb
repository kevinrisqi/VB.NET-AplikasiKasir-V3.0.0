Imports System.Data.Odbc
Public Class FormBarang


    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilBarang()
        Call dgv()
        Call kondisiAwal()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call showCategoriById()
    End Sub

    Sub combobox()
        Call koneksi()
        Dim combo As String = "SELECT kategori_barang.nama_kategori FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori"
        Cmd = New OdbcCommand(combo, Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read = True
            ComboBox1.Items.Add(Rd.Item("nama_kategori"))
        Loop
    End Sub

    Sub showCategoriById()
        Call koneksi()
        Dim showcat As String = "SELECT * FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori WHERE kategori_barang.nama_kategori = '" & ComboBox1.Text & "'"
        Cmd = New OdbcCommand(showcat, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            TextBox7.Text = Rd.Item("id_kategori")
        End If
    End Sub

    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        RichTextBox1.Text = ""
        ComboBox1.Text = ""

        Button1.Text = "Input"
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
    End Sub
    
End Class