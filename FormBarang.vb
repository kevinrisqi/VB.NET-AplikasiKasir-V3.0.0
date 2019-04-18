Imports System.Data.Odbc
Public Class FormBarang

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call tampilBarang()
        Call kondisiAwal()
        Call dgv()
        Call combobox()
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
            Call isiData()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or RichTextBox1.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
            Else
                Call koneksi()
                Dim inputData As String = "INSERT INTO barang (id_barang,nama_barang,harga_beli,harga_jual,stok,satuan,keterangan,id_kategori) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox3.Text & "', '" & TextBox8.Text & "', '" & RichTextBox1.Text & "', '" & TextBox7.Text & "')"
                Cmd = New OdbcCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diinputkan")
                Call kondisiAwal()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call updateData()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TextBox9.Text = DataGridView1.Item(0, i).Value
        TextBox1.Text = DataGridView1.Item(1, i).Value
        TextBox2.Text = DataGridView1.Item(2, i).Value
        TextBox5.Text = DataGridView1.Item(3, i).Value
        TextBox6.Text = DataGridView1.Item(4, i).Value
        TextBox3.Text = DataGridView1.Item(5, i).Value
        TextBox8.Text = DataGridView1.Item(6, i).Value
        RichTextBox1.Text = DataGridView1.Item(7, i).Value
        TextBox7.Text = DataGridView1.Item(8, i).Value

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
        Dim combo As String = "SELECT DISTINCT kategori_barang.nama_kategori FROM barang JOIN kategori_barang ON barang.id_kategori = kategori_barang.id_kategori"
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
        TextBox8.Text = ""
        RichTextBox1.Text = ""
        'ComboBox1.Text = ""

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox8.Enabled = False
        RichTextBox1.Enabled = False
        ComboBox1.Enabled = False

        Button1.Text = "Input"
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = False
        DataGridView1.Enabled = True

        Call tampilBarang()
    End Sub

    Sub isiData()
        TextBox1.Focus()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox8.Enabled = True
        RichTextBox1.Enabled = True
        ComboBox1.Enabled = True
        DataGridView1.Enabled = False
        Button5.Enabled = True
    End Sub

    Sub updateData()
        TextBox1.Focus()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox8.Enabled = True
        RichTextBox1.Enabled = True
        ComboBox1.Enabled = True
        DataGridView1.Enabled = True
        Button5.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Enabled = False
    End Sub
    
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call kondisiAwal()
    End Sub
End Class