Imports System.Data.Odbc
Public Class FormLogin

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username dan Password harus diisi")
            reset()
        Else
            Call koneksi()
            Cmd = New OdbcCommand("SELECT * FROM admin WHERE nama_admin = '" & TextBox1.Text & "' and password_admin = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                FormMenuUtama.panel2.Text = "Nama User : " + Rd.Item("nama_admin")
                FormMenuUtama.panel3.Text = "Level User : " + Rd.Item("level_admin")
                Me.Close()
                Call adminActive()
                If FormMenuUtama.panel3.Text = "Level User : USER" Then
                    Call userActive()
                End If
            Else
                MsgBox("Username dan Password salah")
                reset()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click

    End Sub

    Sub reset()
        TextBox1.Focus()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Sub adminActive()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterBarangToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterSupplierToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterUserlistToolStripMenuItem.Enabled = True
        FormMenuUtama.SetupTokoToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiPembelianToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiPenjualanToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanPenjualanToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanPembelianToolStripMenuItem.Enabled = True
        FormMenuUtama.ListToolStripMenuItem.Enabled = True
        FormMenuUtama.ListBarangToolStripMenuItem.Enabled = True
        FormMenuUtama.ListSupplierToolStripMenuItem.Enabled = True
        FormMenuUtama.LoginToolStripMenuItem.Visible = False
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
    End Sub

    Sub userActive()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterBarangToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterSupplierToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterUserlistToolStripMenuItem.Enabled = False
        FormMenuUtama.SetupTokoToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiPembelianToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiPenjualanToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanPenjualanToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanPembelianToolStripMenuItem.Enabled = True
        FormMenuUtama.ListToolStripMenuItem.Enabled = True
        FormMenuUtama.ListBarangToolStripMenuItem.Enabled = True
        FormMenuUtama.ListSupplierToolStripMenuItem.Enabled = True
        FormMenuUtama.LoginToolStripMenuItem.Visible = False
        FormMenuUtama.LogoutToolStripMenuItem.Visible = True
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
    End Sub


End Class