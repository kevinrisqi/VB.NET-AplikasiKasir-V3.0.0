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
        txtusername.Focus()
        Call reset()
    End Sub

    Sub adminActive()
        MainForm.btnBarang.Enabled = True
        MainForm.btnUser.Enabled = True
        MainForm.btnPenjualan.Enabled = True
        MainForm.btnLaporan.Enabled = True
        MainForm.btnSetup.Enabled = True
        MainForm.btnDashboard.Enabled = True
        MainForm.lblLevel.Visible = True
    End Sub

    Sub userActive()
        MainForm.btnBarang.Enabled = True
        MainForm.btnUser.Enabled = False
        MainForm.btnPenjualan.Enabled = True
        MainForm.btnLaporan.Enabled = True
        MainForm.btnSetup.Enabled = True
        MainForm.btnDashboard.Enabled = True
        MainForm.lblLevel.Visible = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call login()
    End Sub

    Sub reset()
        txtusername.Focus()
        txtusername.Text = ""
        txtpassword.Text = ""
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
                MainForm.lblLevel.Text = Rd.Item("level_admin")
                MainForm.btnLogin.Text = Rd.Item("nama_admin")
                Me.Dispose()
                Call adminActive()
                MainForm.switchPanel(FormDashboard)
                If MainForm.lblLevel.Text = "USER" Then
                    Call userActive()
                End If
            Else
                MsgBox("Username dan Password salah")
            End If
        End If
        Call reset()
    End Sub


End Class