Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports Microsoft.Reporting.WinForms
Public Class Laporan_Stock_Barang
    Public Property KdTransaksi As String
    Public Property UserInfo As Object
    Dim kdTransaksis As New List(Of String)
    Dim listTransaksi As New List(Of Object)
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Sub VBnetSQLSeverConnection()
        Try
            'SQL connection script to SQL Server Instance
            CONN = New SqlConnection(ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString)
            CONN.Open()

            'Show a test connection message status
            'MsgBox("Successfully connected to SQL Server Instance")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CONN.Close()
    End Sub

    Sub LoadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\Report4.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2_Stock
            Dim da As New SqlDataAdapter

            'CONN.Open()
            listTransaksi.Clear()
            Dim query As String = "SELECT id_barang 
                                  ,nama_barang 
                                  ,nama_jenis 
                                  ,nama_tipe 
                                  ,serial_number 
                                  ,nama_kondisi
                                  ,warna 
                                  ,nama_status 
                                  ,tested 
                                  ,nama_lokasi 
                                  ,detail_lokasi 
                                  ,nama_toko 
                                  ,harga_beli 
                                  ,harga_jual 
                                  ,licence 
                                  ,ios 
                                  ,stock
                                  from view_stockbarang "

            'If KdTransaksi IsNot Nothing And KdTransaksi <> "" Then
            '    query = query + " where kd_transaksi_keluar = '" + KdTransaksi + "' "
            'End If
            'da.SelectCommand = New SqlCommand(query, CONN)
            'da.Fill(ds.Tables("DataInvoice"))

            'CONN.Close()

            cmd.CommandText = query
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            Try

                CONN.Open()
            Catch ex As Exception
                CONN.Close()
                CONN.Open()
            End Try
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader

            While reader.Read

                Dim barang = New With
                {
            .id_barang = reader("id_barang"),
            .nama_barang = reader("nama_barang"),
            .nama_jenis = reader("nama_jenis"),
            .nama_tipe = reader("nama_tipe"),
            .serial_number = reader("serial_number"),
            .nama_kondisi = reader("nama_kondisi"),
            .warna = reader("warna"),
            .nama_status = reader("nama_status"),
            .tested = reader("tested"),
            .nama_lokasi = reader("nama_lokasi"),
            .detail_lokasi = reader("detail_lokasi"),
            .nama_toko = reader("nama_toko"),
            .harga_beli = reader("harga_beli"),
            .harga_jual = reader("harga_jual"),
            .licence = reader("licence"),
            .ios = reader("ios"),
            .stock = reader("stock")
                }
                'Dim checkBarang = listTransaksi.Where(Function(x) x.nama_jenis_tipe = barang.nama_jenis_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).ToList()
                'If checkBarang.Count = 0 Then
                '    barang.nama_jenis_tipe_serial = barang.nama_jenis_tipe + vbCrLf + "SN: " + barang.serial_number
                '    barang.qty = 1
                listTransaksi.Add(barang)
                '    'listTransaksi.Where(Function(x) x.nama_jenis_tipe = barang.nama_jenis_tipe).FirstOrDefault().nama_jenis_tipe = checkBarang.FirstOrDefault().nama_jenis_tipe + " SN: " + barang.serial_number
                'Else
                '    listTransaksi.Where(Function(x) x.nama_jenis_tipe = barang.nama_jenis_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().qty = Val(checkBarang.FirstOrDefault().qty) + 1

                '    listTransaksi.Where(Function(x) x.nama_jenis_tipe = barang.nama_jenis_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().serial_number = checkBarang.FirstOrDefault().serial_number + "," + barang.serial_number

                '    listTransaksi.Where(Function(x) x.nama_jenis_tipe = barang.nama_jenis_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().nama_jenis_tipe_serial = checkBarang.FirstOrDefault().nama_jenis_tipe_serial + "," + barang.serial_number
                'End If

                'Result.Add(barang)

            End While
            CONN.Close()
            Dim data = New DataSet1()


            For Each insertDataBarangMasuk As Object In listTransaksi
                Dim row As DataRow

                row = ds.Tables("DataStock").NewRow
                row.Item(0) = insertDataBarangMasuk.id_barang
                row.Item(1) = insertDataBarangMasuk.nama_barang
                row.Item(2) = insertDataBarangMasuk.nama_jenis
                row.Item(3) = insertDataBarangMasuk.nama_tipe
                row.Item(4) = insertDataBarangMasuk.serial_number
                row.Item(5) = insertDataBarangMasuk.nama_kondisi
                row.Item(6) = insertDataBarangMasuk.warna
                row.Item(7) = insertDataBarangMasuk.nama_status
                row.Item(8) = insertDataBarangMasuk.tested
                row.Item(9) = insertDataBarangMasuk.nama_lokasi
                row.Item(10) = insertDataBarangMasuk.detail_lokasi
                row.Item(11) = insertDataBarangMasuk.nama_toko
                If UserInfo.IdLevel = 1 Then
                    row.Item(12) = insertDataBarangMasuk.harga_beli.ToString
                Else
                    row.Item(12) = "-"
                End If


                row.Item(13) = insertDataBarangMasuk.harga_jual
                row.Item(14) = insertDataBarangMasuk.licence
                row.Item(15) = insertDataBarangMasuk.ios
                row.Item(16) = insertDataBarangMasuk.stock
                'row.Item(17) = "1"
                ds.Tables("DataStock").Rows.Add(row)


            Next

            'Dim r(0) As ReportParameter
            'r(0) = New ReportParameter("rpt_image", "File:\" + Application.StartupPath & "\Reports\" + listTransaksi.FirstOrDefault.id_toko.ToString + ".jpeg", True)

            'ReportViewer1.LocalReport.EnableExternalImages = True
            'ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})

            rptDS = New ReportDataSource("DataSet2_Stock", ds.Tables("DataStock"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            'CONN.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Laporan_Stock_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VBnetSQLSeverConnection()
        Me.ReportViewer1.RefreshReport()
        LoadReport()
    End Sub
End Class