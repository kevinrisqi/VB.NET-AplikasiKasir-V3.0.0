Public Class MainForm

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If MsgBox("Apakah Anda yakin ingin keluar ?", vbYesNo + vbInformation) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Sub nonAktif()
        btnLogin.Text = "Login"
        btnBarang.Enabled = False
        btnUser.Enabled = False
        btnDashboard.Enabled = False
        btnPenjualan.Enabled = False
        btnLaporan.Enabled = False
        btnSetup.Enabled = False
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call nonAktif()
    End Sub
End Class