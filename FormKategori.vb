Imports System.Data.Odbc
Public Class FormKategori

    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()
    End Sub

    Sub dgv()
        DataGridView1.Columns(0).HeaderText = "ID Kategori"
        DataGridView1.Columns(1).HeaderText = "Nama Kategori"

        DataGridView1.Columns(0).Width = "90"
        DataGridView1.Columns(1).Width = "241"
    End Sub

    Sub tampilData()
        Call koneksi()
        Dim show As String = "SELECT * FROM kategori_barang"
        Da = New OdbcDataAdapter(show, Conn)
        Ds = New DataSet
        Da.Fill(Ds, "kategori")
        DataGridView1.DataSource = Ds.Tables("kategori")
        DataGridView1.ReadOnly = True
    End Sub

    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox1.Enabled = False

        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False

        Call tampilData()
        Call dgv()
    End Sub

    Sub isiData()
        TextBox1.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
            Button1.Text = "Simpan"
            Call isiData()
        Else
            If TextBox1.Text = "" Then
                MsgBox("Silahkan isi nama kategori barang !", vbInformation)
            Else
                Call koneksi()
                Dim inputData As String = "INSERT INTO kategori_barang (nama_kategori) values ('" & TextBox1.Text & "')"
                Cmd = New OdbcCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diinputkan")
                Call kondisiAwal()
            End If
        End If
    End Sub
End Class