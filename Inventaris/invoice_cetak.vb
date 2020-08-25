Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports Microsoft.Reporting.WinForms

Public Class invoice_cetak

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
    Private Sub invoice_cetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VBnetSQLSeverConnection()
        Me.ReportViewer1.RefreshReport()
        LoadReport()
    End Sub
    Public Function GetTransaksi(startDate As DateTime, endDate As DateTime)
        dt_transaksi.Rows.Clear()
        listTransaksi.Clear()
        Dim result As New List(Of Object)
        Dim query As String = "SELECT t.*,tc.nama_client FROM tbl_transaksi t
                                    INNER JOIN tbl_client tc ON t.id_client = tc.id_client
                                    WHERE t.is_active = 1 and 
                                    (t.created_date BETWEEN CAST('" + startDate.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME) AND 
                                    CAST('" + endDate.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME))"


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
                    .harga_total = reader("harga_total"),
            .diskon = reader("diskon"),
            .harga_akhir = reader("harga_akhir"),
            .nama_client = reader("nama_client"),
            .alamat_pengiriman = reader("alamat_pengiriman"),
            .kota_pengiriman = reader("kota_pengiriman"),
            .kdpos_pengiriman = reader("kdpos_pengiriman"),
            .tgl_keluar = reader("tgl_keluar"),
            .total_barang = reader("total_barang"),
            .created_by = reader("created_by"),
            .created_date = reader("created_date")
                }
            listTransaksi.Add(barang)
            result.Add(barang)

        End While

        Dim index = 0
        For Each insertDataBarangMasuk As Object In listTransaksi
            dt_transaksi.Rows.Add(1)
            Dim isTest As String

            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.kd_transaksi_keluar
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.harga_total
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.diskon
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.harga_akhir
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(4).Value = insertDataBarangMasuk.nama_client
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(5).Value = insertDataBarangMasuk.alamat_pengiriman
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.kota_pengiriman
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(7).Value = insertDataBarangMasuk.kdpos_pengiriman
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(8).Value = insertDataBarangMasuk.tgl_keluar
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(9).Value = insertDataBarangMasuk.total_barang
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(10).Value = insertDataBarangMasuk.created_by
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(11).Value = insertDataBarangMasuk.created_date

            dt_transaksi.Update()
            index = index + 1


        Next

        CONN.Close()

        Return result
    End Function

    Sub LoadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\Report3.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New SqlDataAdapter

            CONN.Open()
            Dim query As String = "select id_transaksi, 
                                            kd_transaksi_keluar,
                                            qty,
                                            nama_jenis,
                                            nama_tipe,
                                            serial_number,
                                            nama_jenis_tipe,
                                            nama_barang,
                                            harga_jual,
                                            harga_total,
                                            diskon,
                                            harga_akhir,
                                            id_status_barang,
                                            nama_status,
                                            nama_client, 
                                            alamat_pengiriman,
                                            kota_pengiriman,
                                            kdpos_pengiriman,
                                            tlp_client, 
                                            nama_toko, 
                                            alamat_toko,
                                            kota_toko,
                                            kdpos_toko,
                                            tlp_toko,
                                            nama_owner,
                                            norek_owner,
                                            tlp_owner 
                                  from view_invoice "

            If KdTransaksi IsNot Nothing And KdTransaksi <> "" Then
                query = query + " where kd_transaksi_keluar = '" + KdTransaksi + "' "
            End If
            da.SelectCommand = New SqlCommand(query, CONN)
            da.Fill(ds.Tables("DataInvoice"))

            CONN.Close()

            rptDS = New ReportDataSource("DataSet1", ds.Tables("DataInvoice"))
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

    Private Sub btn_tampil_list_Click(sender As Object, e As EventArgs) Handles btn_tampil_list.Click
        GetTransaksi(date_tgl_keluar1.Value, date_tgl_keluar2.Value)
    End Sub

    Private Sub dt_transaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_transaksi.CellContentClick

    End Sub

    Private Sub dt_transaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_transaksi.CellClick
        kdTransaksis.Clear()
        Dim selectedIdBarangKeluar = dt_transaksi.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangKeluar
            Dim idBarangMasuk = selectedItem.Cells(0).Value
            kdTransaksis.Add(idBarangMasuk)
        Next selectedItem
    End Sub

    Private Sub btn_tampil_Click(sender As Object, e As EventArgs) Handles btn_tampil.Click
        If kdTransaksis.Count > 0 Then
            KdTransaksi = kdTransaksis(0)
            LoadReport()
        End If
    End Sub
End Class