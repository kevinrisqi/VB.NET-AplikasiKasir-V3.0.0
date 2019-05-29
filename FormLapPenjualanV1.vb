Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Odbc
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data

Public Class FormLapPenjualanV1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim cryRpt As New ReportDocument
        'cryRpt.Load("G:\Project\AplikasiKasir - Fail\AplikasiPenjualanV1\Aplikasi-Penjualan\LaporanPenjualan.rpt")
        'cryRpt.Datas()
        'CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.Refresh()
        
        Call loadReport()
    End Sub

    Private Sub FormLapPenjualanV1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub loadReport()
        Call koneksi()
        Dim strPath As String
        strPath = Application.StartupPath
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath + "\"
        Label1.Text = strPath
        Dim rpt As New ReportDocument
        Da = New OdbcDataAdapter("SELECT detail_penjualan.id_barang, detail_penjualan.nama_barang,harga_satuan, SUM(qty) AS Qty, SUM(SubTotal) AS SubTotal,SUM(diskon) AS diskon,SUM(netto) AS netto,SUM(total_pokok) AS total_pokok,nama_kategori,ppn,tanggal FROM detail_penjualan JOIN barang ON detail_penjualan.id_barang = barang.id_barang JOIN kategori_barang ON kategori_barang.id_kategori = barang.id_kategori JOIN penjualan ON penjualan.id_penjualan = detail_penjualan.id_penjualan WHERE tanggal = CURRENT_DATE() - INTERVAL 2 DAY GROUP BY detail_penjualan.id_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "DetailTransaksi")
        DataGridView1.DataSource = Ds.Tables(0)
        rpt.Load(strPath + "\Reports\LaporanHarian.rpt")
        rpt.SetDataSource(Ds.Tables(0))
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub

End Class