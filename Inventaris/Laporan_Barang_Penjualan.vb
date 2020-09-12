Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports Microsoft.Reporting.WinForms
Public Class Laporan_Barang_Penjualan
    Public Property KdTransaksi As String
    Public Property UserInfo As Object
    Dim kdTransaksis As New List(Of String)
    Dim listTransaksi As New List(Of Object)
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Private Sub Laporan_Barang_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_db_inventory_iasaDataSet3.VIEW_DETAIL_BARANG_KELUAR' table. You can move, or remove it, as needed.
        Me.VIEW_DETAIL_BARANG_KELUARTableAdapter.Fill(Me._db_inventory_iasaDataSet3.VIEW_DETAIL_BARANG_KELUAR)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub LoadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\Report_Penjualan.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2_Stock
            Dim da As New SqlDataAdapter

            'CONN.Open()
            listTransaksi.Clear()
            Dim query As String = "SELECT kd_transaksi_masuk
                                  ,nama_barang
                                  ,nama_toko
                                  ,nama_jenis 
                                  ,nama_tipe 
                                  ,serial_number 
                                  ,tgl_keluar
                                  ,garansi 
                                  ,garansi_type 
                                  ,garansi_exp 
                                  ,nama_lokasi
                                  ,detail_lokasi 
                                  ,alamat_pengiriman 
                                  ,kota_pengiriman 
                                  ,kdpos_pengiriman 
                                  ,harga_jual
                                  ,jumlah
                                  ,id_status_barang 
                                  ,nama_status
                                  ,created_by
                                  ,created_date
                                  ,company_name
                                  from view_detail_barang_keluar "

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
            .garansi = reader("garansi"),
            .garansi_type = reader("garansi_type"),
            .garansi_exp = reader("garansi_exp"),
            .nama_lokasi = reader("nama_lokasi"),
            .detail_lokasi = reader("detail_lokasi"),
            .nama_client = reader("nama_client"),
            .alamat_pengiriman = reader("alamat_pengiriman"),
            .kota_pengiriman = reader("kota_pengiriman"),
            .kdpos_pengiriman = reader("kdpos_pengiriman"),
            .harga_jual = reader("harga_jual"),
            .jumlah = reader("jumlah"),
            .id_status_barang = reader("id_status_barang"),
            .nama_status = reader("nama_status"),
            .created_by = reader("created_by"),
            .created_date = reader("created_date"),
            .company_name = reader("company_name")
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

                row = ds.Tables("DataPenjualan").NewRow
                row.Item(0) = insertDataBarangMasuk.id_barang_masuk
                row.Item(0) = insertDataBarangMasuk.kd_transaksi_masuk
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
                row.Item(11) = insertDataBarangMasuk.harga_beli
                row.Item(11) = insertDataBarangMasuk.harga_jual
                row.Item(11) = insertDataBarangMasuk.stock
                row.Item(11) = insertDataBarangMasuk.licence
                row.Item(11) = insertDataBarangMasuk.ios
                row.Item(11) = insertDataBarangMasuk.created_by
                row.Item(11) = insertDataBarangMasuk.created_date
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
                ds.Tables("DataPenjualan").Rows.Add(row)


            Next

            'Dim r(0) As ReportParameter
            'r(0) = New ReportParameter("rpt_image", "File:\" + Application.StartupPath & "\Reports\" + listTransaksi.FirstOrDefault.id_toko.ToString + ".jpeg", True)

            'ReportViewer1.LocalReport.EnableExternalImages = True
            'ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})

            rptDS = New ReportDataSource("DataSet2_Stock", ds.Tables("DataPenjualan"))
            ReportViewer1.LocalReport.DataSources.Add(rptDS)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100
        Catch ex As Exception
            'CONN.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
End Class