<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.header = New System.Windows.Forms.Panel()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.footer = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sidebar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.btnSetup = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton11 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnLaporan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton9 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPenjualan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton8 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnUser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnBarang = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblIdAdmin = New System.Windows.Forms.Label()
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.footer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.WhiteSmoke
        Me.header.Controls.Add(Me.lblIdAdmin)
        Me.header.Controls.Add(Me.btnLogin)
        Me.header.Controls.Add(Me.BunifuImageButton3)
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(306, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1060, 54)
        Me.header.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Activecolor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.BorderRadius = 0
        Me.btnLogin.ButtonText = "Login"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.DisabledColor = System.Drawing.Color.Gray
        Me.btnLogin.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLogin.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.gender_neutral_user_16px1
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0.0R
        Me.btnLogin.IconVisible = True
        Me.btnLogin.IconZoom = 50.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(6, 17)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.Transparent
        Me.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(102, 31)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnLogin.Textcolor = System.Drawing.Color.Black
        Me.btnLogin.TextFont = New System.Drawing.Font("News706 BT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.BackgroundImage = Global.AplikasiPenjualan.My.Resources.Resources.minimize_window_48px
        Me.BunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuImageButton3.Image = Global.AplikasiPenjualan.My.Resources.Resources.minimize_window_48px
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(979, 0)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(41, 24)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 4
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImage = Global.AplikasiPenjualan.My.Resources.Resources.close_window_48px
        Me.BunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuImageButton1.Image = Global.AplikasiPenjualan.My.Resources.Resources.close_window_48px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1019, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(41, 24)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 2
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'footer
        '
        Me.footer.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.footer.Controls.Add(Me.Label2)
        Me.footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footer.Location = New System.Drawing.Point(306, 700)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(1060, 30)
        Me.footer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(416, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Copyright ZenAI Software @ 2019"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(306, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 646)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(19, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1018, 599)
        Me.Panel2.TabIndex = 0
        '
        'sidebar
        '
        Me.sidebar.BackgroundImage = CType(resources.GetObject("sidebar.BackgroundImage"), System.Drawing.Image)
        Me.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sidebar.Controls.Add(Me.lblLevel)
        Me.sidebar.Controls.Add(Me.btnSetup)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton11)
        Me.sidebar.Controls.Add(Me.btnLaporan)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton9)
        Me.sidebar.Controls.Add(Me.btnPenjualan)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton8)
        Me.sidebar.Controls.Add(Me.btnDashboard)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton5)
        Me.sidebar.Controls.Add(Me.PictureBox1)
        Me.sidebar.Controls.Add(Me.btnUser)
        Me.sidebar.Controls.Add(Me.btnBarang)
        Me.sidebar.Controls.Add(Me.BunifuFlatButton1)
        Me.sidebar.Controls.Add(Me.Label1)
        Me.sidebar.Controls.Add(Me.MenuStrip1)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.sidebar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Quality = 10
        Me.sidebar.Size = New System.Drawing.Size(306, 730)
        Me.sidebar.TabIndex = 0
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLevel.Location = New System.Drawing.Point(122, 205)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(60, 21)
        Me.lblLevel.TabIndex = 13
        Me.lblLevel.Text = "blabla"
        Me.lblLevel.Visible = False
        '
        'btnSetup
        '
        Me.btnSetup.Activecolor = System.Drawing.Color.Transparent
        Me.btnSetup.BackColor = System.Drawing.Color.Transparent
        Me.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetup.BorderRadius = 0
        Me.btnSetup.ButtonText = "   Setup Toko"
        Me.btnSetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetup.DisabledColor = System.Drawing.Color.Transparent
        Me.btnSetup.Enabled = False
        Me.btnSetup.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSetup.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.phonelink_setup_64px
        Me.btnSetup.Iconimage_right = Nothing
        Me.btnSetup.Iconimage_right_Selected = Nothing
        Me.btnSetup.Iconimage_Selected = Nothing
        Me.btnSetup.IconMarginLeft = 0
        Me.btnSetup.IconMarginRight = 0
        Me.btnSetup.IconRightVisible = True
        Me.btnSetup.IconRightZoom = 0.0R
        Me.btnSetup.IconVisible = True
        Me.btnSetup.IconZoom = 90.0R
        Me.btnSetup.IsTab = False
        Me.btnSetup.Location = New System.Drawing.Point(54, 649)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSetup.OnHovercolor = System.Drawing.Color.Blue
        Me.btnSetup.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSetup.selected = False
        Me.btnSetup.Size = New System.Drawing.Size(249, 48)
        Me.btnSetup.TabIndex = 12
        Me.btnSetup.Text = "   Setup Toko"
        Me.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetup.Textcolor = System.Drawing.Color.White
        Me.btnSetup.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton11
        '
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton11.BackColor = System.Drawing.Color.Navy
        Me.BunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton11.BorderRadius = 0
        Me.BunifuFlatButton11.ButtonText = "            Setting"
        Me.BunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.Iconimage = Nothing
        Me.BunifuFlatButton11.Iconimage_right = Nothing
        Me.BunifuFlatButton11.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton11.Iconimage_Selected = Nothing
        Me.BunifuFlatButton11.IconMarginLeft = 0
        Me.BunifuFlatButton11.IconMarginRight = 0
        Me.BunifuFlatButton11.IconRightVisible = True
        Me.BunifuFlatButton11.IconRightZoom = 0.0R
        Me.BunifuFlatButton11.IconVisible = True
        Me.BunifuFlatButton11.IconZoom = 90.0R
        Me.BunifuFlatButton11.IsTab = False
        Me.BunifuFlatButton11.Location = New System.Drawing.Point(0, 622)
        Me.BunifuFlatButton11.Name = "BunifuFlatButton11"
        Me.BunifuFlatButton11.Normalcolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton11.selected = False
        Me.BunifuFlatButton11.Size = New System.Drawing.Size(306, 27)
        Me.BunifuFlatButton11.TabIndex = 11
        Me.BunifuFlatButton11.Text = "            Setting"
        Me.BunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton11.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton11.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnLaporan
        '
        Me.btnLaporan.Activecolor = System.Drawing.Color.Transparent
        Me.btnLaporan.BackColor = System.Drawing.Color.Transparent
        Me.btnLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLaporan.BorderRadius = 0
        Me.btnLaporan.ButtonText = "   Laporan Penjualan"
        Me.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLaporan.DisabledColor = System.Drawing.Color.Transparent
        Me.btnLaporan.Enabled = False
        Me.btnLaporan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnLaporan.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.accounting_64px
        Me.btnLaporan.Iconimage_right = Nothing
        Me.btnLaporan.Iconimage_right_Selected = Nothing
        Me.btnLaporan.Iconimage_Selected = Nothing
        Me.btnLaporan.IconMarginLeft = 0
        Me.btnLaporan.IconMarginRight = 0
        Me.btnLaporan.IconRightVisible = True
        Me.btnLaporan.IconRightZoom = 0.0R
        Me.btnLaporan.IconVisible = True
        Me.btnLaporan.IconZoom = 90.0R
        Me.btnLaporan.IsTab = False
        Me.btnLaporan.Location = New System.Drawing.Point(54, 572)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Normalcolor = System.Drawing.Color.Transparent
        Me.btnLaporan.OnHovercolor = System.Drawing.Color.Blue
        Me.btnLaporan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLaporan.selected = False
        Me.btnLaporan.Size = New System.Drawing.Size(249, 48)
        Me.btnLaporan.TabIndex = 10
        Me.btnLaporan.Text = "   Laporan Penjualan"
        Me.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.Textcolor = System.Drawing.Color.White
        Me.btnLaporan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton9
        '
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton9.BackColor = System.Drawing.Color.Navy
        Me.BunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton9.BorderRadius = 0
        Me.BunifuFlatButton9.ButtonText = "            Report"
        Me.BunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton9.Iconimage = Nothing
        Me.BunifuFlatButton9.Iconimage_right = Nothing
        Me.BunifuFlatButton9.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton9.Iconimage_Selected = Nothing
        Me.BunifuFlatButton9.IconMarginLeft = 0
        Me.BunifuFlatButton9.IconMarginRight = 0
        Me.BunifuFlatButton9.IconRightVisible = True
        Me.BunifuFlatButton9.IconRightZoom = 0.0R
        Me.BunifuFlatButton9.IconVisible = True
        Me.BunifuFlatButton9.IconZoom = 90.0R
        Me.BunifuFlatButton9.IsTab = False
        Me.BunifuFlatButton9.Location = New System.Drawing.Point(0, 545)
        Me.BunifuFlatButton9.Name = "BunifuFlatButton9"
        Me.BunifuFlatButton9.Normalcolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton9.selected = False
        Me.BunifuFlatButton9.Size = New System.Drawing.Size(306, 27)
        Me.BunifuFlatButton9.TabIndex = 9
        Me.BunifuFlatButton9.Text = "            Report"
        Me.BunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton9.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton9.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPenjualan
        '
        Me.btnPenjualan.Activecolor = System.Drawing.Color.Transparent
        Me.btnPenjualan.BackColor = System.Drawing.Color.Transparent
        Me.btnPenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPenjualan.BorderRadius = 0
        Me.btnPenjualan.ButtonText = "   Transaksi Penjualan"
        Me.btnPenjualan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPenjualan.DisabledColor = System.Drawing.Color.Transparent
        Me.btnPenjualan.Enabled = False
        Me.btnPenjualan.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPenjualan.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.shopping_basket_2_100px
        Me.btnPenjualan.Iconimage_right = Nothing
        Me.btnPenjualan.Iconimage_right_Selected = Nothing
        Me.btnPenjualan.Iconimage_Selected = Nothing
        Me.btnPenjualan.IconMarginLeft = 0
        Me.btnPenjualan.IconMarginRight = 0
        Me.btnPenjualan.IconRightVisible = True
        Me.btnPenjualan.IconRightZoom = 0.0R
        Me.btnPenjualan.IconVisible = True
        Me.btnPenjualan.IconZoom = 90.0R
        Me.btnPenjualan.IsTab = False
        Me.btnPenjualan.Location = New System.Drawing.Point(54, 494)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Normalcolor = System.Drawing.Color.Transparent
        Me.btnPenjualan.OnHovercolor = System.Drawing.Color.Blue
        Me.btnPenjualan.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPenjualan.selected = False
        Me.btnPenjualan.Size = New System.Drawing.Size(249, 48)
        Me.btnPenjualan.TabIndex = 8
        Me.btnPenjualan.Text = "   Transaksi Penjualan"
        Me.btnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPenjualan.Textcolor = System.Drawing.Color.White
        Me.btnPenjualan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton8
        '
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton8.BackColor = System.Drawing.Color.Navy
        Me.BunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton8.BorderRadius = 0
        Me.BunifuFlatButton8.ButtonText = "            Transaction"
        Me.BunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton8.Iconimage = Nothing
        Me.BunifuFlatButton8.Iconimage_right = Nothing
        Me.BunifuFlatButton8.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton8.Iconimage_Selected = Nothing
        Me.BunifuFlatButton8.IconMarginLeft = 0
        Me.BunifuFlatButton8.IconMarginRight = 0
        Me.BunifuFlatButton8.IconRightVisible = True
        Me.BunifuFlatButton8.IconRightZoom = 0.0R
        Me.BunifuFlatButton8.IconVisible = True
        Me.BunifuFlatButton8.IconZoom = 90.0R
        Me.BunifuFlatButton8.IsTab = False
        Me.BunifuFlatButton8.Location = New System.Drawing.Point(0, 467)
        Me.BunifuFlatButton8.Name = "BunifuFlatButton8"
        Me.BunifuFlatButton8.Normalcolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton8.selected = False
        Me.BunifuFlatButton8.Size = New System.Drawing.Size(306, 27)
        Me.BunifuFlatButton8.TabIndex = 7
        Me.BunifuFlatButton8.Text = "            Transaction"
        Me.BunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton8.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton8.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDashboard
        '
        Me.btnDashboard.Activecolor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboard.BorderRadius = 0
        Me.btnDashboard.ButtonText = "   Dashboard"
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.DisabledColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Enabled = False
        Me.btnDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDashboard.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.shop_48px
        Me.btnDashboard.Iconimage_right = Nothing
        Me.btnDashboard.Iconimage_right_Selected = Nothing
        Me.btnDashboard.Iconimage_Selected = Nothing
        Me.btnDashboard.IconMarginLeft = 0
        Me.btnDashboard.IconMarginRight = 0
        Me.btnDashboard.IconRightVisible = True
        Me.btnDashboard.IconRightZoom = 0.0R
        Me.btnDashboard.IconVisible = True
        Me.btnDashboard.IconZoom = 90.0R
        Me.btnDashboard.IsTab = False
        Me.btnDashboard.Location = New System.Drawing.Point(54, 284)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Normalcolor = System.Drawing.Color.Transparent
        Me.btnDashboard.OnHovercolor = System.Drawing.Color.Blue
        Me.btnDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDashboard.selected = False
        Me.btnDashboard.Size = New System.Drawing.Size(249, 48)
        Me.btnDashboard.TabIndex = 6
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Textcolor = System.Drawing.Color.White
        Me.btnDashboard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.Navy
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "            Dashboard"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = Nothing
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0.0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 90.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 257)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(306, 27)
        Me.BunifuFlatButton5.TabIndex = 5
        Me.BunifuFlatButton5.Text = "            Dashboard"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.AplikasiPenjualan.My.Resources.Resources.find_user
        Me.PictureBox1.Location = New System.Drawing.Point(89, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 126)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnUser
        '
        Me.btnUser.Activecolor = System.Drawing.Color.Transparent
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUser.BorderRadius = 0
        Me.btnUser.ButtonText = "   Master User"
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.DisabledColor = System.Drawing.Color.Transparent
        Me.btnUser.Enabled = False
        Me.btnUser.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUser.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.user_group_man_woman_64px
        Me.btnUser.Iconimage_right = Nothing
        Me.btnUser.Iconimage_right_Selected = Nothing
        Me.btnUser.Iconimage_Selected = Nothing
        Me.btnUser.IconMarginLeft = 0
        Me.btnUser.IconMarginRight = 0
        Me.btnUser.IconRightVisible = True
        Me.btnUser.IconRightZoom = 0.0R
        Me.btnUser.IconVisible = True
        Me.btnUser.IconZoom = 90.0R
        Me.btnUser.IsTab = False
        Me.btnUser.Location = New System.Drawing.Point(54, 416)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Normalcolor = System.Drawing.Color.Transparent
        Me.btnUser.OnHovercolor = System.Drawing.Color.Blue
        Me.btnUser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUser.selected = False
        Me.btnUser.Size = New System.Drawing.Size(249, 48)
        Me.btnUser.TabIndex = 3
        Me.btnUser.Text = "   Master User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Textcolor = System.Drawing.Color.White
        Me.btnUser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnBarang
        '
        Me.btnBarang.Activecolor = System.Drawing.Color.Transparent
        Me.btnBarang.BackColor = System.Drawing.Color.Transparent
        Me.btnBarang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBarang.BorderRadius = 0
        Me.btnBarang.ButtonText = "   Master Barang"
        Me.btnBarang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBarang.DisabledColor = System.Drawing.Color.Transparent
        Me.btnBarang.Enabled = False
        Me.btnBarang.Iconcolor = System.Drawing.Color.Transparent
        Me.btnBarang.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.cardboard_box_64px
        Me.btnBarang.Iconimage_right = Nothing
        Me.btnBarang.Iconimage_right_Selected = Nothing
        Me.btnBarang.Iconimage_Selected = Nothing
        Me.btnBarang.IconMarginLeft = 0
        Me.btnBarang.IconMarginRight = 0
        Me.btnBarang.IconRightVisible = True
        Me.btnBarang.IconRightZoom = 0.0R
        Me.btnBarang.IconVisible = True
        Me.btnBarang.IconZoom = 90.0R
        Me.btnBarang.IsTab = False
        Me.btnBarang.Location = New System.Drawing.Point(54, 362)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Normalcolor = System.Drawing.Color.Transparent
        Me.btnBarang.OnHovercolor = System.Drawing.Color.Blue
        Me.btnBarang.OnHoverTextColor = System.Drawing.Color.White
        Me.btnBarang.selected = False
        Me.btnBarang.Size = New System.Drawing.Size(249, 48)
        Me.btnBarang.TabIndex = 2
        Me.btnBarang.Text = "   Master Barang"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.Textcolor = System.Drawing.Color.White
        Me.btnBarang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Navy
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "            Master"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(0, 335)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Navy
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(306, 27)
        Me.BunifuFlatButton1.TabIndex = 1
        Me.BunifuFlatButton1.Text = "            Master"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(50, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Citra Cellular 2"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.BarangToolStripMenuItem, Me.UserToolStripMenuItem, Me.PenjualanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(306, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem1, Me.DashboardToolStripMenuItem1})
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'PenjualanToolStripMenuItem1
        '
        Me.PenjualanToolStripMenuItem1.Name = "PenjualanToolStripMenuItem1"
        Me.PenjualanToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.PenjualanToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.PenjualanToolStripMenuItem1.Text = "Penjualan "
        '
        'DashboardToolStripMenuItem1
        '
        Me.DashboardToolStripMenuItem1.Name = "DashboardToolStripMenuItem1"
        Me.DashboardToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DashboardToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.DashboardToolStripMenuItem1.Text = "Dashboard"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanToolStripMenuItem, Me.SetupToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.LoginToolStripMenuItem.Text = "Login "
        '
        'lblIdAdmin
        '
        Me.lblIdAdmin.AutoSize = True
        Me.lblIdAdmin.Location = New System.Drawing.Point(173, 30)
        Me.lblIdAdmin.Name = "lblIdAdmin"
        Me.lblIdAdmin.Size = New System.Drawing.Size(39, 13)
        Me.lblIdAdmin.TabIndex = 6
        Me.lblIdAdmin.Text = "Label3"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 730)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.footer.ResumeLayout(False)
        Me.footer.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.sidebar.ResumeLayout(False)
        Me.sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sidebar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnUser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnBarang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents footer As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPenjualan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSetup As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton11 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLaporan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblIdAdmin As System.Windows.Forms.Label
End Class
