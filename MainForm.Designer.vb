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
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.footer = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlBarang = New System.Windows.Forms.Panel()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuTileButton4 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.sidebar = New Bunifu.Framework.UI.BunifuGradientPanel()
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.header.SuspendLayout()
        Me.footer.SuspendLayout()
        Me.pnlBarang.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.WhiteSmoke
        Me.header.Controls.Add(Me.btnLogin)
        Me.header.Controls.Add(Me.BunifuImageButton3)
        Me.header.Controls.Add(Me.BunifuImageButton1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(306, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1060, 54)
        Me.header.TabIndex = 1
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
        Me.footer.Location = New System.Drawing.Point(306, 690)
        Me.footer.Name = "footer"
        Me.footer.Size = New System.Drawing.Size(1060, 30)
        Me.footer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(395, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Copyright ZenAI Software @ 2019"
        '
        'pnlBarang
        '
        Me.pnlBarang.Controls.Add(Me.DataGridView1)
        Me.pnlBarang.Controls.Add(Me.Label12)
        Me.pnlBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBarang.Location = New System.Drawing.Point(306, 54)
        Me.pnlBarang.Name = "pnlBarang"
        Me.pnlBarang.Size = New System.Drawing.Size(1060, 636)
        Me.pnlBarang.TabIndex = 3
        Me.pnlBarang.Visible = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlDashboard.Controls.Add(Me.BunifuTileButton4)
        Me.pnlDashboard.Controls.Add(Me.GroupBox4)
        Me.pnlDashboard.Controls.Add(Me.BunifuTileButton3)
        Me.pnlDashboard.Controls.Add(Me.GroupBox3)
        Me.pnlDashboard.Controls.Add(Me.BunifuTileButton2)
        Me.pnlDashboard.Controls.Add(Me.GroupBox2)
        Me.pnlDashboard.Controls.Add(Me.BunifuTileButton1)
        Me.pnlDashboard.Controls.Add(Me.Label3)
        Me.pnlDashboard.Controls.Add(Me.GroupBox1)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(306, 54)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(1060, 636)
        Me.pnlDashboard.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Dashboard"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 93)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Products"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(110, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "25"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 93)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Users"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(521, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 93)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "78"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(109, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Sales"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(768, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(210, 93)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(110, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Rp 2.300.000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(109, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Income"
        '
        'BunifuTileButton4
        '
        Me.BunifuTileButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuTileButton4.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTileButton4.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton4.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton4.Image = Global.AplikasiPenjualan.My.Resources.Resources.money_bag_80px
        Me.BunifuTileButton4.ImagePosition = 20
        Me.BunifuTileButton4.ImageZoom = 50
        Me.BunifuTileButton4.LabelPosition = 10
        Me.BunifuTileButton4.LabelText = ""
        Me.BunifuTileButton4.Location = New System.Drawing.Point(768, 76)
        Me.BunifuTileButton4.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton4.Name = "BunifuTileButton4"
        Me.BunifuTileButton4.Size = New System.Drawing.Size(85, 85)
        Me.BunifuTileButton4.TabIndex = 9
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BunifuTileButton3.color = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton3.Image = Global.AplikasiPenjualan.My.Resources.Resources.shopping_cart_50px
        Me.BunifuTileButton3.ImagePosition = 20
        Me.BunifuTileButton3.ImageZoom = 50
        Me.BunifuTileButton3.LabelPosition = 10
        Me.BunifuTileButton3.LabelText = ""
        Me.BunifuTileButton3.Location = New System.Drawing.Point(521, 76)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(85, 85)
        Me.BunifuTileButton3.TabIndex = 7
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.BunifuTileButton2.color = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton2.Image = Global.AplikasiPenjualan.My.Resources.Resources.conference_background_selected_80px
        Me.BunifuTileButton2.ImagePosition = 20
        Me.BunifuTileButton2.ImageZoom = 50
        Me.BunifuTileButton2.LabelPosition = 10
        Me.BunifuTileButton2.LabelText = ""
        Me.BunifuTileButton2.Location = New System.Drawing.Point(278, 76)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(85, 85)
        Me.BunifuTileButton2.TabIndex = 5
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BunifuTileButton1.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Global.AplikasiPenjualan.My.Resources.Resources.box_50px
        Me.BunifuTileButton1.ImagePosition = 20
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 10
        Me.BunifuTileButton1.LabelText = ""
        Me.BunifuTileButton1.Location = New System.Drawing.Point(37, 76)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(85, 85)
        Me.BunifuTileButton1.TabIndex = 3
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
        Me.btnLogin.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.under_computer_48px
        Me.btnLogin.Iconimage_right = Nothing
        Me.btnLogin.Iconimage_right_Selected = Nothing
        Me.btnLogin.Iconimage_Selected = Nothing
        Me.btnLogin.IconMarginLeft = 0
        Me.btnLogin.IconMarginRight = 0
        Me.btnLogin.IconRightVisible = True
        Me.btnLogin.IconRightZoom = 0.0R
        Me.btnLogin.IconVisible = True
        Me.btnLogin.IconZoom = 90.0R
        Me.btnLogin.IsTab = False
        Me.btnLogin.Location = New System.Drawing.Point(6, 17)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Normalcolor = System.Drawing.Color.Transparent
        Me.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnLogin.OnHoverTextColor = System.Drawing.Color.White
        Me.btnLogin.selected = False
        Me.btnLogin.Size = New System.Drawing.Size(156, 31)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'sidebar
        '
        Me.sidebar.BackgroundImage = CType(resources.GetObject("sidebar.BackgroundImage"), System.Drawing.Image)
        Me.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.sidebar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Quality = 10
        Me.sidebar.Size = New System.Drawing.Size(306, 720)
        Me.sidebar.TabIndex = 0
        '
        'btnSetup
        '
        Me.btnSetup.Activecolor = System.Drawing.Color.Transparent
        Me.btnSetup.BackColor = System.Drawing.Color.Transparent
        Me.btnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetup.BorderRadius = 0
        Me.btnSetup.ButtonText = "   Setup Toko"
        Me.btnSetup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetup.DisabledColor = System.Drawing.Color.Gray
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
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.Transparent
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
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.Blue
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
        Me.btnLaporan.DisabledColor = System.Drawing.Color.Gray
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
        Me.BunifuFlatButton9.Activecolor = System.Drawing.Color.Transparent
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
        Me.BunifuFlatButton9.OnHovercolor = System.Drawing.Color.Blue
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
        Me.btnPenjualan.DisabledColor = System.Drawing.Color.Gray
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
        Me.BunifuFlatButton8.Activecolor = System.Drawing.Color.Transparent
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
        Me.BunifuFlatButton8.OnHovercolor = System.Drawing.Color.Blue
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
        Me.btnDashboard.DisabledColor = System.Drawing.Color.Gray
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
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.Transparent
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
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.Blue
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
        Me.btnUser.DisabledColor = System.Drawing.Color.Gray
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
        Me.btnBarang.DisabledColor = System.Drawing.Color.Gray
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
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent
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
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Blue
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
        Me.Label1.Size = New System.Drawing.Size(126, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Citra Cellular"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Master Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(983, 330)
        Me.DataGridView1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(306, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 636)
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 720)
        Me.Controls.Add(Me.pnlBarang)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.footer)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.header.ResumeLayout(False)
        Me.footer.ResumeLayout(False)
        Me.footer.PerformLayout()
        Me.pnlBarang.ResumeLayout(False)
        Me.pnlBarang.PerformLayout()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidebar.ResumeLayout(False)
        Me.sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents pnlBarang As System.Windows.Forms.Panel
    Friend WithEvents btnDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPenjualan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton8 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSetup As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton11 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLaporan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton9 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pnlDashboard As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BunifuTileButton4 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
