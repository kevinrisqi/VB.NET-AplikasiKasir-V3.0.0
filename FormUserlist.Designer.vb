<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserlist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUserlist))
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.levelAdmin = New System.Windows.Forms.ComboBox()
        Me.username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.kodeAdmin = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.search = New Bunifu.Framework.UI.BunifuTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.hapus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.input = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.batal = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.MidnightBlue
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 51
        Me.LineShape1.X2 = 955
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1018, 599)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(178, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Master User"
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeight = 41
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(504, 184)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowHeadersVisible = False
        Me.BunifuCustomDataGrid1.RowTemplate.DividerHeight = 3
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 30
        Me.BunifuCustomDataGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(452, 198)
        Me.BunifuCustomDataGrid1.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_admin"
        Me.Column1.HeaderText = "Kode Admin"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nama_admin"
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "password_admin"
        Me.Column3.HeaderText = "Password Admin"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "level_admin"
        Me.Column4.HeaderText = "Level Admin"
        Me.Column4.Name = "Column4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(595, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Pencarian Username"
        '
        'levelAdmin
        '
        Me.levelAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.levelAdmin.FormattingEnabled = True
        Me.levelAdmin.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.levelAdmin.Location = New System.Drawing.Point(51, 393)
        Me.levelAdmin.Name = "levelAdmin"
        Me.levelAdmin.Size = New System.Drawing.Size(205, 26)
        Me.levelAdmin.TabIndex = 44
        '
        'username
        '
        Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.username.HintForeColor = System.Drawing.Color.Empty
        Me.username.HintText = "Username"
        Me.username.isPassword = False
        Me.username.LineFocusedColor = System.Drawing.Color.Blue
        Me.username.LineIdleColor = System.Drawing.Color.Gray
        Me.username.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.username.LineThickness = 3
        Me.username.Location = New System.Drawing.Point(51, 223)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(353, 44)
        Me.username.TabIndex = 42
        Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'password
        '
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password.HintForeColor = System.Drawing.Color.Empty
        Me.password.HintText = "Password"
        Me.password.isPassword = True
        Me.password.LineFocusedColor = System.Drawing.Color.Blue
        Me.password.LineIdleColor = System.Drawing.Color.Gray
        Me.password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.password.LineThickness = 3
        Me.password.Location = New System.Drawing.Point(51, 295)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(166, 44)
        Me.password.TabIndex = 43
        Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'kodeAdmin
        '
        Me.kodeAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kodeAdmin.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.kodeAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kodeAdmin.HintForeColor = System.Drawing.Color.Empty
        Me.kodeAdmin.HintText = "Kode Admin"
        Me.kodeAdmin.isPassword = False
        Me.kodeAdmin.LineFocusedColor = System.Drawing.Color.Blue
        Me.kodeAdmin.LineIdleColor = System.Drawing.Color.Gray
        Me.kodeAdmin.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.kodeAdmin.LineThickness = 3
        Me.kodeAdmin.Location = New System.Drawing.Point(51, 153)
        Me.kodeAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.kodeAdmin.Name = "kodeAdmin"
        Me.kodeAdmin.Size = New System.Drawing.Size(114, 44)
        Me.kodeAdmin.TabIndex = 41
        Me.kodeAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.White
        Me.search.BackgroundImage = CType(resources.GetObject("search.BackgroundImage"), System.Drawing.Image)
        Me.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Icon = CType(resources.GetObject("search.Icon"), System.Drawing.Image)
        Me.search.Location = New System.Drawing.Point(755, 146)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(201, 32)
        Me.search.TabIndex = 40
        Me.search.text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplikasiPenjualan.My.Resources.Resources.user_group_man_woman_64px
        Me.PictureBox1.Location = New System.Drawing.Point(94, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'hapus
        '
        Me.hapus.Activecolor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hapus.BorderRadius = 0
        Me.hapus.ButtonText = "Hapus"
        Me.hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.hapus.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.hapus.Iconcolor = System.Drawing.Color.Transparent
        Me.hapus.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.full_trash_64px
        Me.hapus.Iconimage_right = Nothing
        Me.hapus.Iconimage_right_Selected = Nothing
        Me.hapus.Iconimage_Selected = Nothing
        Me.hapus.IconMarginLeft = 0
        Me.hapus.IconMarginRight = 0
        Me.hapus.IconRightVisible = True
        Me.hapus.IconRightZoom = 0.0R
        Me.hapus.IconVisible = True
        Me.hapus.IconZoom = 59.0R
        Me.hapus.IsTab = False
        Me.hapus.Location = New System.Drawing.Point(852, 393)
        Me.hapus.Name = "hapus"
        Me.hapus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.hapus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.hapus.OnHoverTextColor = System.Drawing.Color.White
        Me.hapus.selected = False
        Me.hapus.Size = New System.Drawing.Size(104, 48)
        Me.hapus.TabIndex = 48
        Me.hapus.Text = "Hapus"
        Me.hapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.hapus.Textcolor = System.Drawing.Color.White
        Me.hapus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'input
        '
        Me.input.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.input.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.input.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.input.BorderRadius = 0
        Me.input.ButtonText = "Tambah"
        Me.input.Cursor = System.Windows.Forms.Cursors.Hand
        Me.input.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.input.Iconcolor = System.Drawing.Color.Transparent
        Me.input.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.strategy_board_40px
        Me.input.Iconimage_right = Nothing
        Me.input.Iconimage_right_Selected = Nothing
        Me.input.Iconimage_Selected = Nothing
        Me.input.IconMarginLeft = 0
        Me.input.IconMarginRight = 0
        Me.input.IconRightVisible = True
        Me.input.IconRightZoom = 0.0R
        Me.input.IconVisible = True
        Me.input.IconZoom = 58.0R
        Me.input.IsTab = False
        Me.input.Location = New System.Drawing.Point(51, 442)
        Me.input.Name = "input"
        Me.input.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.input.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.input.OnHoverTextColor = System.Drawing.Color.White
        Me.input.selected = False
        Me.input.Size = New System.Drawing.Size(114, 48)
        Me.input.TabIndex = 46
        Me.input.Text = "Tambah"
        Me.input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.input.Textcolor = System.Drawing.Color.White
        Me.input.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'simpan
        '
        Me.simpan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.simpan.BorderRadius = 0
        Me.simpan.ButtonText = "Ubah"
        Me.simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.simpan.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.simpan.Iconcolor = System.Drawing.Color.Transparent
        Me.simpan.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.box_edit_1_100px
        Me.simpan.Iconimage_right = Nothing
        Me.simpan.Iconimage_right_Selected = Nothing
        Me.simpan.Iconimage_Selected = Nothing
        Me.simpan.IconMarginLeft = 0
        Me.simpan.IconMarginRight = 0
        Me.simpan.IconRightVisible = True
        Me.simpan.IconRightZoom = 0.0R
        Me.simpan.IconVisible = True
        Me.simpan.IconZoom = 90.0R
        Me.simpan.IsTab = False
        Me.simpan.Location = New System.Drawing.Point(171, 442)
        Me.simpan.Name = "simpan"
        Me.simpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.simpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.simpan.OnHoverTextColor = System.Drawing.Color.White
        Me.simpan.selected = False
        Me.simpan.Size = New System.Drawing.Size(114, 48)
        Me.simpan.TabIndex = 45
        Me.simpan.Text = "Ubah"
        Me.simpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.simpan.Textcolor = System.Drawing.Color.White
        Me.simpan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'batal
        '
        Me.batal.Activecolor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.batal.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.batal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.batal.BorderRadius = 0
        Me.batal.ButtonText = "Batal"
        Me.batal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.batal.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.batal.Iconcolor = System.Drawing.Color.Transparent
        Me.batal.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.cancel_subscription_48px
        Me.batal.Iconimage_right = Nothing
        Me.batal.Iconimage_right_Selected = Nothing
        Me.batal.Iconimage_Selected = Nothing
        Me.batal.IconMarginLeft = 0
        Me.batal.IconMarginRight = 0
        Me.batal.IconRightVisible = True
        Me.batal.IconRightZoom = 0.0R
        Me.batal.IconVisible = True
        Me.batal.IconZoom = 59.0R
        Me.batal.IsTab = False
        Me.batal.Location = New System.Drawing.Point(291, 442)
        Me.batal.Name = "batal"
        Me.batal.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.batal.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.batal.OnHoverTextColor = System.Drawing.Color.White
        Me.batal.selected = False
        Me.batal.Size = New System.Drawing.Size(114, 48)
        Me.batal.TabIndex = 47
        Me.batal.Text = "Batal"
        Me.batal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.batal.Textcolor = System.Drawing.Color.White
        Me.batal.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.BunifuCustomDataGrid1
        '
        'FormUserlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.levelAdmin)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.kodeAdmin)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormUserlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Userlist"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents search As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents levelAdmin As System.Windows.Forms.ComboBox
    Friend WithEvents username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents kodeAdmin As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents input As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents batal As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents hapus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
