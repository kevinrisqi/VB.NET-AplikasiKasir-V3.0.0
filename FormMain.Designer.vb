<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tabExit = New Bunifu.Framework.UI.BunifuTileButton()
        Me.tabLogin = New Bunifu.Framework.UI.BunifuTileButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.ItemSize = New System.Drawing.Size(42, 22)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(729, 112)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.tabExit)
        Me.TabPage1.Controls.Add(Me.tabLogin)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(721, 82)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        '
        'tabExit
        '
        Me.tabExit.BackColor = System.Drawing.Color.Transparent
        Me.tabExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabExit.color = System.Drawing.Color.Transparent
        Me.tabExit.colorActive = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabExit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabExit.ForeColor = System.Drawing.Color.Black
        Me.tabExit.Image = Global.AplikasiPenjualan.My.Resources.Resources.Close_Box_Red
        Me.tabExit.ImagePosition = 10
        Me.tabExit.ImageZoom = 55
        Me.tabExit.LabelPosition = 20
        Me.tabExit.LabelText = "Exit"
        Me.tabExit.Location = New System.Drawing.Point(84, 3)
        Me.tabExit.Margin = New System.Windows.Forms.Padding(4)
        Me.tabExit.Name = "tabExit"
        Me.tabExit.Size = New System.Drawing.Size(75, 75)
        Me.tabExit.TabIndex = 3
        '
        'tabLogin
        '
        Me.tabLogin.BackColor = System.Drawing.Color.Transparent
        Me.tabLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tabLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabLogin.color = System.Drawing.Color.Transparent
        Me.tabLogin.colorActive = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tabLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tabLogin.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabLogin.ForeColor = System.Drawing.Color.Black
        Me.tabLogin.Image = Global.AplikasiPenjualan.My.Resources.Resources.Login_Manager
        Me.tabLogin.ImagePosition = 0
        Me.tabLogin.ImageZoom = 70
        Me.tabLogin.LabelPosition = 20
        Me.tabLogin.LabelText = "Login"
        Me.tabLogin.Location = New System.Drawing.Point(5, 3)
        Me.tabLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.tabLogin.Name = "tabLogin"
        Me.tabLogin.Size = New System.Drawing.Size(75, 75)
        Me.tabLogin.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(721, 82)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Master"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(721, 82)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Transaksi"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 26)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(721, 82)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Laporan"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 26)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(721, 82)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "About"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.AplikasiPenjualan.My.Resources.Resources.BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(729, 398)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".:: ZenAI Software - Aplikasi Kasir Pulsa ::."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabLogin As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents tabExit As Bunifu.Framework.UI.BunifuTileButton
End Class
