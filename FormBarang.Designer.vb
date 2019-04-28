<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idBarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuiOSSwitch1 = New Bunifu.Framework.UI.BunifuiOSSwitch()
        Me.search = New Bunifu.Framework.UI.BunifuTextbox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(51, 223)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(905, 309)
        Me.DataGridView1.TabIndex = 22
        '
        'idBarang
        '
        Me.idBarang.Enabled = False
        Me.idBarang.Location = New System.Drawing.Point(654, 192)
        Me.idBarang.MaxLength = 15
        Me.idBarang.Name = "idBarang"
        Me.idBarang.Size = New System.Drawing.Size(29, 20)
        Me.idBarang.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pencarian Barang"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(162, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Master Barang"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1018, 599)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
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
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(841, 170)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 46)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "Tambah Barang"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuTileButton1.color = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Global.AplikasiPenjualan.My.Resources.Resources.waste_50px
        Me.BunifuTileButton1.ImagePosition = 5
        Me.BunifuTileButton1.ImageZoom = 50
        Me.BunifuTileButton1.LabelPosition = 0
        Me.BunifuTileButton1.LabelText = ""
        Me.BunifuTileButton1.Location = New System.Drawing.Point(896, 541)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(60, 40)
        Me.BunifuTileButton1.TabIndex = 32
        '
        'BunifuiOSSwitch1
        '
        Me.BunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuiOSSwitch1.BackgroundImage = CType(resources.GetObject("BunifuiOSSwitch1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuiOSSwitch1.Location = New System.Drawing.Point(507, 187)
        Me.BunifuiOSSwitch1.Name = "BunifuiOSSwitch1"
        Me.BunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray
        Me.BunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BunifuiOSSwitch1.Size = New System.Drawing.Size(43, 25)
        Me.BunifuiOSSwitch1.TabIndex = 31
        Me.BunifuiOSSwitch1.Value = True
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.White
        Me.search.BackgroundImage = CType(resources.GetObject("search.BackgroundImage"), System.Drawing.Image)
        Me.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Icon = CType(resources.GetObject("search.Icon"), System.Drawing.Image)
        Me.search.Location = New System.Drawing.Point(211, 185)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(250, 32)
        Me.search.TabIndex = 29
        Me.search.text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AplikasiPenjualan.My.Resources.Resources.cardboard_box_64px
        Me.PictureBox1.Location = New System.Drawing.Point(83, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1018, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.BunifuTileButton1)
        Me.Controls.Add(Me.BunifuiOSSwitch1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.idBarang)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents idBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents search As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuiOSSwitch1 As Bunifu.Framework.UI.BunifuiOSSwitch
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
End Class
