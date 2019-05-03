Imports System.Data.Odbc
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
        lblLevel.Visible = False
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        'MainForm_Load(e, e)
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Call nonAktif()
        Call titleToko()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        switchPanel(FormDashboard)
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        switchPanel(FormBarang)
        FormBarang.kondisiAwal()
    End Sub

    Private Sub pnlBarang_Paint(sender As Object, e As PaintEventArgs)
        FormBarang.Show()
        FormBarang.tampilBarang()
    End Sub

    

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        switchPanel(FormUserlist)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not btnLogin.Text = "Login" Then
            Call nonAktif()
        Else
            B_FormLogin.Show()
        End If
    End Sub

    Private Sub btnPenjualan_Click(sender As Object, e As EventArgs) Handles btnPenjualan.Click
        Call switchPanel(FormPenjualan)
    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        Call switchPanel(FormSetupToko)
    End Sub

    Sub titleToko()
        Call koneksi()
        Cmd = New OdbcCommand("SELECT * FROM setup_toko", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Label1.Text = Rd.Item("nama_toko")
        End If
    End Sub
End Class