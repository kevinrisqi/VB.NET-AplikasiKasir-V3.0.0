Imports System.Data.Odbc

Public Class FormUserlist

    Private Sub FormUserlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiAwal()

    End Sub

    Sub kondisiAwal()
        kodeAdmin.Text = ""
        username.Text = ""
        password.Text = ""

        kodeAdmin.Enabled = False
        username.Enabled = False
        password.Enabled = False
        simpan.Enabled = False
        batal.Enabled = False
        'hapus.Enabled = False
        levelAdmin.Enabled = False

        Call koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "admin")
        BunifuCustomDataGrid1.DataSource = Ds.Tables("admin")
        BunifuCustomDataGrid1.ReadOnly = True
        BunifuCustomDataGrid1.Enabled = True
    End Sub

    Sub isiData()
        kodeAdmin.Enabled = False
        username.Enabled = True
        password.Enabled = True
        levelAdmin.Enabled = True
        simpan.Enabled = False
        BunifuCustomDataGrid1.Enabled = False
        Button3.Enabled = False
        Button5.Enabled = True
    End Sub

    Sub updateData()
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button5.Enabled = True
        DataGridView1.Enabled = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Tambah" Then
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
        kodeAdmin.Text = urutan
    End Sub

    Private Sub BunifuCustomDataGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellClick
        'Call updateData()
        'Call comboChecked()
        Dim i As Integer
        i = BunifuCustomDataGrid1.CurrentRow.Index

        kodeAdmin.Text = BunifuCustomDataGrid1.Item(0, i).Value
        username.Text = BunifuCustomDataGrid1.Item(1, i).Value
        password.Text = BunifuCustomDataGrid1.Item(2, i).Value
        levelAdmin.Text = BunifuCustomDataGrid1.Item(3, i).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call kondisiAwal()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Apakah Anda ingin menghapusnya ?", vbInformation + vbYesNo) = vbYes Then
            Call koneksi()
            Dim deleteData As String = "DELETE FROM admin WHERE id_admin = '" & TextBox1.Text & "'"
            Cmd = New OdbcCommand(deleteData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Call kondisiAwal()
        End If
    End Sub

    Private Sub search_OnTextChange(sender As Object, e As EventArgs) Handles search.OnTextChange
        Call koneksi()
        Dim searchData As String = "select * from admin where nama_admin like '%" & search.text & "%'"
        Cmd = New OdbcCommand(searchData, Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call koneksi()
            Dim query As String = "select * from admin where nama_admin like '%" & search.text & "%'"
            Da = New OdbcDataAdapter(query, Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            BunifuCustomDataGrid1.DataSource = Ds.Tables(0)
        End If
    End Sub

    Private Sub password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password.KeyPress
        If password.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub password_OnValueChanged(sender As Object, e As EventArgs) Handles password.OnValueChanged
        password.isPassword = True
    End Sub

    Private Sub kodeAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeAdmin.KeyPress
        If kodeAdmin.Text.Length >= 6 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub kodeAdmin_OnValueChanged(sender As Object, e As EventArgs) Handles kodeAdmin.OnValueChanged

    End Sub

    Private Sub username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username.KeyPress
        If username.Text.Length >= 10 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub username_OnValueChanged(sender As Object, e As EventArgs) Handles username.OnValueChanged

    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        If input.Text = "Tambah" Then
            input.Text = "Simpan"
            'Button3.Text = "Batal"
            Call isiData()
            Call kodeOtomatis()
        Else
            If kodeAdmin.Text = "" Or username.Text = "" Or password.Text = "" Or levelAdmin.Text = "" Then
                MsgBox("Silahkan isi data dengan lengkap !", vbInformation)
            Else
                Call koneksi()
                Dim inputData As String = "INSERT INTO admin (id_admin,nama_admin,password_admin,level_admin) values ('" & kodeAdmin.Text & "', '" & username.Text & "', '" & password.Text & "', '" & levelAdmin.Text & "')"
                Cmd = New OdbcCommand(inputData, Conn)
                Cmd.ExecuteNonQuery()
                'MsgBox("Data berhasil diinputkan")
                Call kondisiAwal()
            End If
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        If kodeAdmin.Text = "" Then
            MsgBox("Pilih data yang akan dihapus !", vbInformation)
        ElseIf MsgBox("Apakah Anda ingin menghapusnya ?", vbInformation + vbYesNo) = vbYes Then
            Call koneksi()
            Dim deleteData As String = "DELETE FROM admin WHERE id_admin = '" & kodeAdmin.Text & "'"
            Cmd = New OdbcCommand(deleteData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Call kondisiAwal()
        Else
        End If
    End Sub
End Class