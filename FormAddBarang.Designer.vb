<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddBarang
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
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.kodeBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.namaBarang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.satuan = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.stok = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.beli = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.jual = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.keterangan = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Form Barang"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AplikasiPenjualan.My.Resources.Resources.box_edit_1_100px
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(89, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'kodeBarang
        '
        Me.kodeBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kodeBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.kodeBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.kodeBarang.HintForeColor = System.Drawing.Color.Empty
        Me.kodeBarang.HintText = "Kode Barang"
        Me.kodeBarang.isPassword = False
        Me.kodeBarang.LineFocusedColor = System.Drawing.Color.Blue
        Me.kodeBarang.LineIdleColor = System.Drawing.Color.Gray
        Me.kodeBarang.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.kodeBarang.LineThickness = 3
        Me.kodeBarang.Location = New System.Drawing.Point(89, 153)
        Me.kodeBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.kodeBarang.Name = "kodeBarang"
        Me.kodeBarang.Size = New System.Drawing.Size(114, 44)
        Me.kodeBarang.TabIndex = 3
        Me.kodeBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'namaBarang
        '
        Me.namaBarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.namaBarang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.namaBarang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.namaBarang.HintForeColor = System.Drawing.Color.Empty
        Me.namaBarang.HintText = "Nama Barang"
        Me.namaBarang.isPassword = False
        Me.namaBarang.LineFocusedColor = System.Drawing.Color.Blue
        Me.namaBarang.LineIdleColor = System.Drawing.Color.Gray
        Me.namaBarang.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.namaBarang.LineThickness = 3
        Me.namaBarang.Location = New System.Drawing.Point(89, 223)
        Me.namaBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(353, 44)
        Me.namaBarang.TabIndex = 4
        Me.namaBarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'satuan
        '
        Me.satuan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.satuan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.satuan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.satuan.HintForeColor = System.Drawing.Color.Empty
        Me.satuan.HintText = "Satuan"
        Me.satuan.isPassword = False
        Me.satuan.LineFocusedColor = System.Drawing.Color.Blue
        Me.satuan.LineIdleColor = System.Drawing.Color.Gray
        Me.satuan.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.satuan.LineThickness = 3
        Me.satuan.Location = New System.Drawing.Point(89, 300)
        Me.satuan.Margin = New System.Windows.Forms.Padding(4)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(166, 44)
        Me.satuan.TabIndex = 5
        Me.satuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'stok
        '
        Me.stok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stok.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.stok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stok.HintForeColor = System.Drawing.Color.Empty
        Me.stok.HintText = "Stok"
        Me.stok.isPassword = False
        Me.stok.LineFocusedColor = System.Drawing.Color.Blue
        Me.stok.LineIdleColor = System.Drawing.Color.Gray
        Me.stok.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.stok.LineThickness = 3
        Me.stok.Location = New System.Drawing.Point(595, 153)
        Me.stok.Margin = New System.Windows.Forms.Padding(4)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(78, 44)
        Me.stok.TabIndex = 6
        Me.stok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'beli
        '
        Me.beli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.beli.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.beli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.beli.HintForeColor = System.Drawing.Color.Empty
        Me.beli.HintText = "Harga Beli"
        Me.beli.isPassword = False
        Me.beli.LineFocusedColor = System.Drawing.Color.Blue
        Me.beli.LineIdleColor = System.Drawing.Color.Gray
        Me.beli.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.beli.LineThickness = 3
        Me.beli.Location = New System.Drawing.Point(595, 223)
        Me.beli.Margin = New System.Windows.Forms.Padding(4)
        Me.beli.Name = "beli"
        Me.beli.Size = New System.Drawing.Size(209, 44)
        Me.beli.TabIndex = 7
        Me.beli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'jual
        '
        Me.jual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jual.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.jual.HintForeColor = System.Drawing.Color.Empty
        Me.jual.HintText = "Harga Jual"
        Me.jual.isPassword = False
        Me.jual.LineFocusedColor = System.Drawing.Color.Blue
        Me.jual.LineIdleColor = System.Drawing.Color.Gray
        Me.jual.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.jual.LineThickness = 3
        Me.jual.Location = New System.Drawing.Point(595, 300)
        Me.jual.Margin = New System.Windows.Forms.Padding(4)
        Me.jual.Name = "jual"
        Me.jual.Size = New System.Drawing.Size(209, 44)
        Me.jual.TabIndex = 8
        Me.jual.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'keterangan
        '
        Me.keterangan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.keterangan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.keterangan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.keterangan.HintForeColor = System.Drawing.Color.Empty
        Me.keterangan.HintText = "Keterangan"
        Me.keterangan.isPassword = False
        Me.keterangan.LineFocusedColor = System.Drawing.Color.Blue
        Me.keterangan.LineIdleColor = System.Drawing.Color.Gray
        Me.keterangan.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.keterangan.LineThickness = 3
        Me.keterangan.Location = New System.Drawing.Point(89, 352)
        Me.keterangan.Margin = New System.Windows.Forms.Padding(4)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(715, 98)
        Me.keterangan.TabIndex = 9
        Me.keterangan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FormAddBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 599)
        Me.Controls.Add(Me.keterangan)
        Me.Controls.Add(Me.beli)
        Me.Controls.Add(Me.jual)
        Me.Controls.Add(Me.kodeBarang)
        Me.Controls.Add(Me.namaBarang)
        Me.Controls.Add(Me.stok)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "FormAddBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kodeBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents namaBarang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents satuan As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents stok As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents beli As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents jual As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents keterangan As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
