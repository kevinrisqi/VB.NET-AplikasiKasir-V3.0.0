<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailBarang
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailBarang))
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.search = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.BunifuCustomDataGrid1.ColumnHeadersHeight = 41
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column9, Me.Column14})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid1.DefaultCellStyle = DataGridViewCellStyle6
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(12, 57)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowHeadersVisible = False
        Me.BunifuCustomDataGrid1.RowTemplate.DividerHeight = 3
        Me.BunifuCustomDataGrid1.RowTemplate.Height = 30
        Me.BunifuCustomDataGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(563, 231)
        Me.BunifuCustomDataGrid1.TabIndex = 40
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "id_barang"
        Me.Column2.HeaderText = "Kode Barang"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "nama_barang"
        Me.Column3.HeaderText = "Nama Barang"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "harga_beli"
        Me.Column4.HeaderText = "Harga Beli"
        Me.Column4.Name = "Column4"
        Me.Column4.Visible = False
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "harga_jual"
        Me.Column5.HeaderText = "Harga Satuan"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "stok"
        Me.Column6.HeaderText = "Stok"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "satuan"
        Me.Column7.HeaderText = "Satuan"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "keterangan"
        Me.Column8.HeaderText = "Keterangan"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "tanggal_input"
        Me.Column10.HeaderText = "Tanggal Input"
        Me.Column10.Name = "Column10"
        Me.Column10.Visible = False
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "tanggal_update"
        Me.Column11.HeaderText = "Tanggal Update"
        Me.Column11.Name = "Column11"
        Me.Column11.Visible = False
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "nama_admin"
        Me.Column12.HeaderText = "Nama Admin"
        Me.Column12.Name = "Column12"
        Me.Column12.Visible = False
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "nama_kategori"
        Me.Column13.HeaderText = "Kategori"
        Me.Column13.Name = "Column13"
        Me.Column13.Visible = False
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "id_kategori"
        Me.Column9.HeaderText = "ID Kategori"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "id_kategori1"
        Me.Column14.HeaderText = "ID Kategori 1"
        Me.Column14.Name = "Column14"
        Me.Column14.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(491, 28)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 44
        Me.RadioButton2.Text = "Nama Barang"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(398, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(87, 17)
        Me.RadioButton1.TabIndex = 43
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Kode Barang"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Pencarian Barang"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.BunifuCustomDataGrid1
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.White
        Me.search.BackgroundImage = CType(resources.GetObject("search.BackgroundImage"), System.Drawing.Image)
        Me.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Icon = CType(resources.GetObject("search.Icon"), System.Drawing.Image)
        Me.search.Location = New System.Drawing.Point(172, 19)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(201, 32)
        Me.search.TabIndex = 42
        Me.search.text = ""
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.BunifuCustomDataGrid1
        Me.BunifuDragControl2.Vertical = True
        '
        'DetailBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(587, 300)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "DetailBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetailBarang"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents search As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
End Class
