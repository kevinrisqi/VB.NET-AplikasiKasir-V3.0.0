<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenjualan
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
        Me.namaKasir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.noTransaksi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.kodeBarang = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.namaBarang = New System.Windows.Forms.TextBox()
        Me.hargaSatuan = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.qtyTotal = New System.Windows.Forms.TextBox()
        Me.txtIdAdmin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Diskon = New System.Windows.Forms.TextBox()
        Me.kembali = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'namaKasir
        '
        Me.namaKasir.Enabled = False
        Me.namaKasir.Location = New System.Drawing.Point(221, 142)
        Me.namaKasir.Name = "namaKasir"
        Me.namaKasir.Size = New System.Drawing.Size(122, 20)
        Me.namaKasir.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nama Kasir"
        '
        'jam
        '
        Me.jam.Enabled = False
        Me.jam.Location = New System.Drawing.Point(470, 142)
        Me.jam.Name = "jam"
        Me.jam.Size = New System.Drawing.Size(115, 20)
        Me.jam.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jam"
        '
        'tanggal
        '
        Me.tanggal.Enabled = False
        Me.tanggal.Location = New System.Drawing.Point(349, 142)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(115, 20)
        Me.tanggal.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal"
        '
        'noTransaksi
        '
        Me.noTransaksi.Enabled = False
        Me.noTransaksi.Location = New System.Drawing.Point(93, 142)
        Me.noTransaksi.Name = "noTransaksi"
        Me.noTransaksi.Size = New System.Drawing.Size(122, 20)
        Me.noTransaksi.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Transaksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Kode Barang"
        '
        'kodeBarang
        '
        Me.kodeBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.kodeBarang.Location = New System.Drawing.Point(88, 443)
        Me.kodeBarang.MaxLength = 13
        Me.kodeBarang.Name = "kodeBarang"
        Me.kodeBarang.Size = New System.Drawing.Size(106, 20)
        Me.kodeBarang.TabIndex = 1
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(200, 443)
        Me.qty.MaxLength = 3
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(51, 20)
        Me.qty.TabIndex = 2
        Me.qty.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(197, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Qty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(347, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Bayar"
        '
        'bayar
        '
        Me.bayar.Location = New System.Drawing.Point(350, 444)
        Me.bayar.MaxLength = 9
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(89, 20)
        Me.bayar.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(578, 494)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Kembali"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(86, 484)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "F5 - Browse Pencarian Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(85, 508)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Enter - Tambahkan Barang ke Transaksi"
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
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(170, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(170, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Transaksi Penjualan"
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
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column8, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column9})
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
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(48, 179)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowHeadersVisible = False
        Me.BunifuCustomDataGrid1.RowTemplate.DividerHeight = 3
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 30
        Me.BunifuCustomDataGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(942, 220)
        Me.BunifuCustomDataGrid1.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_barang"
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "nama_barang"
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "harga_pokok"
        Me.Column8.HeaderText = "Harga Pokok"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "harga_satuan"
        Me.Column3.HeaderText = "Harga Satuan"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "qty"
        Me.Column4.HeaderText = "Qty"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "SubTotal"
        Me.Column5.HeaderText = "Brutto"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "diskon"
        Me.Column6.HeaderText = "Voucher"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "netto"
        Me.Column7.HeaderText = "Netto"
        Me.Column7.Name = "Column7"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "total_pokok"
        Me.Column9.HeaderText = "Total H.Pokok"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'namaBarang
        '
        Me.namaBarang.Location = New System.Drawing.Point(387, 511)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(87, 20)
        Me.namaBarang.TabIndex = 39
        Me.namaBarang.Visible = False
        '
        'hargaSatuan
        '
        Me.hargaSatuan.Location = New System.Drawing.Point(480, 511)
        Me.hargaSatuan.Name = "hargaSatuan"
        Me.hargaSatuan.Size = New System.Drawing.Size(71, 20)
        Me.hargaSatuan.TabIndex = 40
        Me.hargaSatuan.Visible = False
        '
        'Total
        '
        Me.Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.ForeColor = System.Drawing.Color.White
        Me.Total.Location = New System.Drawing.Point(753, 415)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(237, 56)
        Me.Total.TabIndex = 41
        Me.Total.Text = "0"
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.BunifuCustomDataGrid1
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "   Simpan"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Global.AplikasiPenjualan.My.Resources.Resources.save_64px
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0.0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 70.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(867, 539)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(123, 48)
        Me.BunifuFlatButton1.TabIndex = 42
        Me.BunifuFlatButton1.Text = "   Simpan"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AplikasiPenjualan.My.Resources.Resources.shopping_basket_2_100px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(90, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuImageButton1.Image = Global.AplikasiPenjualan.My.Resources.Resources.ellipsis_filled_50px
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(175, 444)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(18, 18)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 45
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 1
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(662, 415)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 56)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "Rp. "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'qtyTotal
        '
        Me.qtyTotal.Enabled = False
        Me.qtyTotal.Location = New System.Drawing.Point(445, 444)
        Me.qtyTotal.Name = "qtyTotal"
        Me.qtyTotal.Size = New System.Drawing.Size(70, 20)
        Me.qtyTotal.TabIndex = 47
        '
        'txtIdAdmin
        '
        Me.txtIdAdmin.Location = New System.Drawing.Point(313, 110)
        Me.txtIdAdmin.Name = "txtIdAdmin"
        Me.txtIdAdmin.Size = New System.Drawing.Size(31, 20)
        Me.txtIdAdmin.TabIndex = 49
        Me.txtIdAdmin.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 417)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Diskon"
        '
        'Diskon
        '
        Me.Diskon.Location = New System.Drawing.Point(257, 444)
        Me.Diskon.MaxLength = 7
        Me.Diskon.Name = "Diskon"
        Me.Diskon.Size = New System.Drawing.Size(87, 20)
        Me.Diskon.TabIndex = 3
        Me.Diskon.Text = "0"
        '
        'kembali
        '
        Me.kembali.BackColor = System.Drawing.Color.Yellow
        Me.kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kembali.ForeColor = System.Drawing.Color.Black
        Me.kembali.Location = New System.Drawing.Point(766, 483)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(224, 38)
        Me.kembali.TabIndex = 52
        Me.kembali.Text = "0"
        Me.kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Yellow
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(734, 483)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 38)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Rp. "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(578, 438)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 24)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Total"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(442, 417)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Total Qty"
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Diskon)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIdAdmin)
        Me.Controls.Add(Me.qtyTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.hargaSatuan)
        Me.Controls.Add(Me.namaBarang)
        Me.Controls.Add(Me.namaKasir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jam)
        Me.Controls.Add(Me.noTransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.kodeBarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Penjualan"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents namaKasir As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents noTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents kodeBarang As System.Windows.Forms.TextBox
    Friend WithEvents qty As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bayar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents namaBarang As System.Windows.Forms.TextBox
    Friend WithEvents hargaSatuan As System.Windows.Forms.TextBox
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents qtyTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtIdAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Diskon As TextBox
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents kembali As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
