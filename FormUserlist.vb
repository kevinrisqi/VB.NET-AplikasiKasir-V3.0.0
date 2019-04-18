Imports System.Data.Odbc

Public Class FormUserlist

    Private Sub FormUserlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()

        DataGridView1.Columns(0).HeaderText = "ID Admin"
        DataGridView1.Columns(1).HeaderText = "Username"
        DataGridView1.Columns(2).HeaderText = "Password"
        DataGridView1.Columns(3).HeaderText = "Level Admin"

        'hide column password
        DataGridView1.Columns(2).Visible = False

        DataGridView1.Columns(0).Width = "100"
        DataGridView1.Columns(1).Width = "200"
        DataGridView1.Columns(2).Width = "50"
        DataGridView1.Columns(3).Width = "120"
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
    End Sub

    Sub kondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        'ComboBox1.Items.Clear()

        Button1.Text = "Input"
        'Button3.Text = "Hapus"

        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        Button5.Enabled = False
        Button3.Enabled = False
        Button2.Enabled = False
        ComboBox1.Enabled = False
        ComboBox1.Text = ""

        Call koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "admin")
        DataGridView1.DataSource = Ds.Tables("admin")
        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = True
    End Sub

    Sub isiData()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        Button2.Enabled = False
        DataGridView1.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = True
    End Sub

    Sub updateData()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = True
        DataGridView1.Enabled = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            'Button3.Text = "Batal"
            Call isiData()
            Call kodeOtomatis()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
            Else
                Call koneksi()
                Dim inputData As String = "INSERT INTO admin (id_admin,nama_admin,password_admin,level_admin) values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "')"
                Cmd = New OdbcCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diinputkan")
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Call isiData()

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
        Else
            Call koneksi()
            Dim updateData As String = "UPDATE admin set nama_admin = '" & TextBox2.Text & "', password_admin = '" & TextBox3.Text & "', level_admin = '" & ComboBox1.Text & "' WHERE id_admin = '" & TextBox1.Text & "'"
            Cmd = New OdbcCommand(updateData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diubah")
            Call kondisiAwal()
        End If
    End Sub

    Sub kodeOtomatis()
        Cmd = New OdbcCommand("select * from admin where id_admin in (select max(id_admin) from admin)", Conn)
        Dim urutan As String
        Dim hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            urutan = "ADM" + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
            urutan = "ADM" + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox1.Text = urutan
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Call updateData()
        'Call comboChecked()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
        ComboBox1.Text = DataGridView1.Item(3, i).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call kondisiAwal()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan pilih data yang akan dihapus !", vbInformation)
        Else
            Call koneksi()
            Dim deleteData As String = "DELETE FROM admin WHERE id_admin = '" & TextBox1.Text & "'"
            Cmd = New OdbcCommand(deleteData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Call kondisiAwal()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Call koneksi()
        Dim searchData As String = "select * from admin where nama_admin like '%" & TextBox4.Text & "%'"
        Cmd = New OdbcCommand(searchData, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call koneksi()
            Dim query As String = "select * from admin where nama_admin like '%" & TextBox4.Text & "%'"
            Da = New OdbcDataAdapter(query, Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            DataGridView1.DataSource = Ds.Tables(0)
        End If
    End Sub

    Sub comboChecked()
        Call koneksi()
        Dim combo As String = "SELECT * FROM admin WHERE id_admin = 'ADM001'"
        Cmd = New OdbcCommand(combo, Conn)
        Rd.Read()
        If Rd.HasRows Then
            ComboBox1.Items.Add(Rd.Item(3))
        End If
    End Sub

End Class