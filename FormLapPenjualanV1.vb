Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Odbc
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Data

Public Class FormLapPenjualanV1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Dim cryRpt As New ReportDocument
        'cryRpt.Load("G:\Project\AplikasiKasir - Fail\AplikasiPenjualanV1\Aplikasi-Penjualan\LaporanPenjualan.rpt")
        'cryRpt.Datas()
        'CrystalReportViewer1.ReportSource = cryRpt
        'CrystalReportViewer1.Refresh()

        Call dailyReport()
    End Sub

    Private Sub FormLapPenjualanV1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub dailyReport()
        Call koneksi()
        Dim strPath As String
        Dim tanggal As String
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        tanggal = DateTimePicker1.Text
        strPath = Application.StartupPath
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath + "\"
        Dim rpt As New ReportDocument
        Da = New OdbcDataAdapter("SELECT detail_penjualan.id_barang, detail_penjualan.nama_barang,harga_satuan, SUM(qty) AS Qty, SUM(SubTotal) AS SubTotal,SUM(diskon) AS diskon,SUM(netto) AS netto,SUM(total_pokok) AS total_pokok,nama_kategori,ppn,tanggal FROM detail_penjualan JOIN barang ON detail_penjualan.id_barang = barang.id_barang JOIN kategori_barang ON kategori_barang.id_kategori = barang.id_kategori JOIN penjualan ON penjualan.id_penjualan = detail_penjualan.id_penjualan WHERE tanggal = '" & tanggal & "' GROUP BY detail_penjualan.id_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "DetailTransaksi")
        DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        tanggal = DateTimePicker1.Text
        rpt.Load(strPath + "\Reports\LaporanHarian.rpt")
        rpt.SetDataSource(Ds.Tables(0))
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub

    Sub monthReport()
        Call koneksi()
        Dim strPath As String
        Dim month As String
        Dim year As String
        month = DateTimePicker2.Value.Month
        year = DateTimePicker2.Value.Year
        Label1.Text = month + year
        strPath = Application.StartupPath
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath + "\"
        Dim rpt As New ReportDocument
        Da = New OdbcDataAdapter("SELECT detail_penjualan.id_barang, detail_penjualan.nama_barang,harga_satuan, SUM(qty) AS Qty, SUM(SubTotal) AS SubTotal,SUM(diskon) AS diskon,SUM(netto) AS netto,SUM(total_pokok) AS total_pokok,nama_kategori,ppn,tanggal FROM detail_penjualan JOIN barang ON detail_penjualan.id_barang = barang.id_barang JOIN kategori_barang ON kategori_barang.id_kategori = barang.id_kategori JOIN penjualan ON penjualan.id_penjualan = detail_penjualan.id_penjualan WHERE MONTH(tanggal) = '" & month & "' AND YEAR(tanggal) = '" & year & "' GROUP BY detail_penjualan.id_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "DetailTransaksi")
        rpt.Load(strPath + "\Reports\LaporanBulanan.rpt")
        rpt.SetDataSource(Ds.Tables(0))
        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub

    Sub customReport()
        Call koneksi()
        Dim strPath As String
        Dim tanggal1 As String
        Dim tanggal2 As String
        'Dim paramV As CrystalDecisions.Shared.ParameterValues
        'Dim paramDValue As CrystalDecisions.Shared.ParameterDiscreteValue
        DateTimePicker3.CustomFormat = "yyyy-MM-dd"
        DateTimePicker4.CustomFormat = "yyyy-MM-dd"
        tanggal1 = DateTimePicker3.Text
        tanggal2 = DateTimePicker4.Text
        strPath = Application.StartupPath
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath.Substring(0, strPath.LastIndexOf("\"))
        strPath = strPath + "\"
        Dim rpt As New ReportDocument
        Da = New OdbcDataAdapter("SELECT detail_penjualan.id_barang, detail_penjualan.nama_barang,harga_satuan, SUM(qty) AS Qty, SUM(SubTotal) AS SubTotal,SUM(diskon) AS diskon,SUM(netto) AS netto,SUM(total_pokok) AS total_pokok,nama_kategori,ppn,tanggal FROM detail_penjualan JOIN barang ON detail_penjualan.id_barang = barang.id_barang JOIN kategori_barang ON kategori_barang.id_kategori = barang.id_kategori JOIN penjualan ON penjualan.id_penjualan = detail_penjualan.id_penjualan WHERE tanggal between '" & tanggal1 & "' and '" & tanggal2 & "' GROUP BY detail_penjualan.id_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "DetailTransaksi")
        DateTimePicker3.CustomFormat = "dd-MM-yyyy"
        tanggal1 = DateTimePicker3.Text
        DateTimePicker4.CustomFormat = "dd-MM-yyyy"
        tanggal2 = DateTimePicker4.Text
        rpt.Load(strPath + "\Reports\LaporanCustom.rpt")
        rpt.SetDataSource(Ds.Tables(0))
        rpt.SetParameterValue("tanggal1", tanggal1)
        rpt.SetParameterValue("tanggal2", tanggal2)
        CrystalReportViewer1.ReportSource = rpt
        'paramV = New CrystalDecisions.Shared.ParameterValues
        'paramDValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        'paramDValue.Value = tanggal1
        'paramV.Add(paramDValue)
        'rpt.ParameterFields.Item("tanggal1").CurrentValues = paramV
        'rpt.ParameterFields.Item("tanggal1").HasCurrentValue = True

        'CrystalReportViewer1.Refresh()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Call dailyReport()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Call customReport()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Call monthReport()
    End Sub
End Class