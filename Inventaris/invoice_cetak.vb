Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports Microsoft.Reporting.WinForms

Public Class invoice_cetak
    Public Property UserInfo As Object
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
            da.SelectCommand = New SqlCommand(" select id_transaksi, kd_transaksi_keluar,qty,nama_jenis,nama_tipe,serial_number,nama_jenis_tipe,nama_barang,harga_jual,harga_total,diskon,harga_akhir,id_status_barang,nama_status,nama_client, alamat_pengiriman,kota_pengiriman,kdpos_pengiriman,tlp_client, nama_toko, alamat_toko,kota_toko,kdpos_toko,tlp_toko,nama_owner,norek_owner,tlp_owner from view_invoice where kd_transaksi_keluar = 'GG75N2Q66L28ADZ0W' ", CONN)
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
End Class