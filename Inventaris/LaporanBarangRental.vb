Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports Microsoft.Reporting.WinForms
Public Class LaporanBarangRental
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
                .ReportPath = Application.StartupPath & "\Reports\ReportRental.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2_Stock
            Dim da As New SqlDataAdapter

            'CONN.Open()
            listTransaksi.Clear()
            Dim query As String = "SELECT kd_transaksi_keluar
                                  ,nama_barang
                                  ,nama_toko
                                  ,nama_jenis 
                                  ,nama_tipe 
                                  ,serial_number 
                                  ,tgl_keluar
                                  ,periode_rental 
                                  ,rental_type 
                                  ,rental_exp 
                                  ,nama_lokasi
                                  ,detail_lokasi
                                  ,nama_client
                                  ,company_name
                                  ,alamat_pengiriman 
                                  ,kota_pengiriman 
                                  ,kdpos_pengiriman 
                                  ,id_status_barang 
                                  ,nama_status
                                  ,created_by
                                  ,created_date
                                  from view_detail_barang_rental "

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
            .kd_transaksi_keluar = reader("kd_transaksi_keluar"),
            .nama_barang = reader("nama_barang"),
            .nama_toko = reader("nama_toko"),
            .nama_jenis = reader("nama_jenis"),
            .nama_tipe = reader("nama_tipe"),
            .serial_number = reader("serial_number"),
            .tgl_keluar = reader("tgl_keluar"),
            .periode_rental = reader("periode_rental"),
            .rental_type = reader("rental_type"),
            .rental_exp = reader("rental_exp"),
            .nama_lokasi = reader("nama_lokasi"),
            .detail_lokasi = reader("detail_lokasi"),
            .nama_client = reader("nama_client"),
            .company_name = reader("company_name"),
            .alamat_pengiriman = reader("alamat_pengiriman"),
            .kota_pengiriman = reader("kota_pengiriman"),
            .kdpos_pengiriman = reader("kdpos_pengiriman"),
            .id_status_barang = reader("id_status_barang"),
            .nama_status = reader("nama_status"),
            .created_by = reader("created_by"),
            .created_date = reader("created_date")
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


            For Each insertDataBarangMasuk As Object In listTransaksi
                Dim row As DataRow

                row = ds.Tables("DataRental").NewRow
                row.Item(0) = insertDataBarangMasuk.kd_transaksi_keluar
                row.Item(1) = insertDataBarangMasuk.nama_barang
                row.Item(2) = insertDataBarangMasuk.nama_jenis
                row.Item(3) = insertDataBarangMasuk.nama_tipe
                row.Item(4) = insertDataBarangMasuk.serial_number
                row.Item(4) = insertDataBarangMasuk.tgl_keluar
                row.Item(7) = insertDataBarangMasuk.periode_rental
                row.Item(8) = insertDataBarangMasuk.rental_type
                row.Item(9) = insertDataBarangMasuk.rental_exp
                row.Item(10) = insertDataBarangMasuk.nama_lokasi
                row.Item(11) = insertDataBarangMasuk.detail_lokasi
                row.Item(12) = insertDataBarangMasuk.nama_client
                row.Item(13) = insertDataBarangMasuk.alamat_pengiriman
                row.Item(14) = insertDataBarangMasuk.kota_pengiriman
                row.Item(15) = insertDataBarangMasuk.kdpos_pengiriman
                row.Item(16) = insertDataBarangMasuk.id_status_barang
                row.Item(17) = insertDataBarangMasuk.nama_status
                row.Item(18) = insertDataBarangMasuk.created_by
                row.Item(19) = insertDataBarangMasuk.created_date
                row.Item(20) = insertDataBarangMasuk.company_name
                'If UserInfo.IdLevel = 1 Then
                '    row.Item(12) = insertDataBarangMasuk.harga_beli.ToString
                'Else
                '    row.Item(12) = "-"
                'End If


                'row.Item(13) = insertDataBarangMasuk.harga_jual
                'row.Item(14) = insertDataBarangMasuk.licence
                'row.Item(15) = insertDataBarangMasuk.ios
                'row.Item(16) = insertDataBarangMasuk.stock
                'row.Item(17) = "1"
                ds.Tables("DataRental").Rows.Add(row)


            Next

            'Dim r(0) As ReportParameter
            'r(0) = New ReportParameter("rpt_image", "File:\" + Application.StartupPath & "\Reports\" + listTransaksi.FirstOrDefault.id_toko.ToString + ".jpeg", True)

            'ReportViewer1.LocalReport.EnableExternalImages = True
            'ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})

            rptDS = New ReportDataSource("DataSet2_Stock", ds.Tables("DataRental"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            'CONN.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LaporanBarangRental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VBnetSQLSeverConnection()
        Me.ReportViewer1.RefreshReport()
        LoadReport()
    End Sub
End Class