Public Class FormMenuUtama

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Sub terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        MasterBarangToolStripMenuItem.Enabled = False
        MasterSupplierToolStripMenuItem.Enabled = False
        MasterUserlistToolStripMenuItem.Enabled = False
        SetupTokoToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        TransaksiPembelianToolStripMenuItem.Enabled = False
        TransaksiPenjualanToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        LaporanPenjualanToolStripMenuItem.Enabled = False
        LaporanPembelianToolStripMenuItem.Enabled = True
        ListToolStripMenuItem.Enabled = False
        ListBarangToolStripMenuItem.Enabled = False
        ListSupplierToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Visible = False
    End Sub

    Sub terbuka()
        LoginToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = True
        MasterToolStripMenuItem.Enabled = True
        MasterBarangToolStripMenuItem.Enabled = True
        MasterSupplierToolStripMenuItem.Enabled = True
        MasterUserlistToolStripMenuItem.Enabled = True
        SetupTokoToolStripMenuItem.Enabled = True
        TransaksiToolStripMenuItem.Enabled = True
        TransaksiPembelianToolStripMenuItem.Enabled = True
        TransaksiPenjualanToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Enabled = True
        LaporanPenjualanToolStripMenuItem.Enabled = True
        LaporanPembelianToolStripMenuItem.Enabled = True
        ListToolStripMenuItem.Enabled = True
        ListBarangToolStripMenuItem.Enabled = True
        ListSupplierToolStripMenuItem.Enabled = True
        LoginToolStripMenuItem.Visible = False
    End Sub


    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        terkunci()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MasterBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBarangToolStripMenuItem.Click
        FormBarang.Show()
    End Sub

    Private Sub MasterUserlistToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterUserlistToolStripMenuItem.Click
        FormUserlist.Show()
    End Sub

    Private Sub MasterSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSupplierToolStripMenuItem.Click
        FormKategori.Show()
    End Sub

    Private Sub SetupTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupTokoToolStripMenuItem.Click
        FormSetupToko.Show()
    End Sub
End Class
