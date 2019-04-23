Imports System.Data.Odbc
Public Class B_FormLogin

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        
    End Sub

    Private Sub txtpassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtpassword.OnValueChanged
        txtpassword.isPassword = True
    End Sub

    Private Sub B_FormLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Escape) Then
            Me.Hide()
        End If
        If e.KeyChar = Chr(13) Then
            Call login()
        End If
    End Sub

    Private Sub B_FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call reset()
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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call login()
    End Sub

    Sub reset()
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusername.Focus()
    End Sub

    Sub login()
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Username dan Password harus diisi")
        Else
            Call koneksi()
            Cmd = New OdbcCommand("SELECT * FROM admin WHERE nama_admin = '" & txtusername.Text & "' and password_admin = '" & txtpassword.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                FormMenuUtama.panel2.Text = "Nama User : " + Rd.Item("nama_admin")
                FormMenuUtama.panel3.Text = "Level User : " + Rd.Item("level_admin")
                Me.Hide()
                Call adminActive()
                If FormMenuUtama.panel3.Text = "Level User : USER" Then
                    Call userActive()
                End If
            Else
                MsgBox("Username dan Password salah")
            End If
        End If
        Call reset()
    End Sub


End Class