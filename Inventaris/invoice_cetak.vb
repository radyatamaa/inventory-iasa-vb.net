Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports Microsoft.Reporting.WinForms

Public Class invoice_cetak
    Dim indexPenampung As New List(Of Integer)
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
    Public Function MappingToDataGrid(transaksi As List(Of Object))
        For Each insertDataBarangMasuk As Object In transaksi
            dt_transaksi.Rows.Add(1)
            Dim isTest As String
            Dim flagBayar = "No"
            If insertDataBarangMasuk.flag_bayar = 1 Then
                flagBayar = "Yes"
            End If
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
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(12).Value = insertDataBarangMasuk.nama_status
            dt_transaksi.Rows(dt_transaksi.RowCount - 2).Cells(13).Value = flagBayar
            dt_transaksi.Update()
            'Index = Index + 1


        Next
    End Function
    Function UpdateFlagBayar(flagBayar As Integer, userlogin As String, kdTransaksi As String)
        Dim barangKeluarId
        Dim queryTblBarang As String = " UPDATE tbl_transaksi SET 
                                    flag_bayar = " + flagBayar.ToString + ",
                                    updated_by = '" + userlogin + "',
                                    updated_date =   CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                    WHERE kd_transaksi_keluar = '" + kdTransaksi.ToString + "'"

        cmd.CommandText = queryTblBarang
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        barangKeluarId = cmd.ExecuteScalar()
        'reader = cmd.ExecuteReader()

        CONN.Close()
    End Function
    Function UpdateStatusBarang(idStatusBarang As Integer, userlogin As String, idBarang As Integer)
        Dim barangKeluarId
        Dim queryTblBarang As String = " UPDATE tbl_barang SET 
                                    id_status_barang = " + idStatusBarang.ToString + ",
                                    updated_by = '" + userlogin + "',
                                    updated_date =   CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                    WHERE id_barang = " + idBarang.ToString

        cmd.CommandText = queryTblBarang
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        barangKeluarId = cmd.ExecuteScalar()
        'reader = cmd.ExecuteReader()

        CONN.Close()
    End Function
    Public Function GetTransaksi(idToko As String, startDate As DateTime, endDate As DateTime)
        dt_transaksi.Rows.Clear()
        listTransaksi.Clear()
        Dim result As New List(Of Object)
        Dim query As String = "  SELECT t.*,tc.nama_client, a.id_toko,
                                  (SELECT top 1 s.nama_status FROM tbl_barang_keluar bk
                                    JOIN tbl_status_barang s ON bk.id_status_barang = s.id_status_barang 
                                    WHERE bk.kd_transaksi_keluar = t.kd_transaksi_keluar) as nama_status
                                    FROM tbl_transaksi t
                                    INNER JOIN tbl_client tc ON t.id_client = tc.id_client
									LEFT OUTER JOIN (select kd_transaksi_keluar, max(id_toko) as id_toko from tbl_barang_keluar group by kd_transaksi_keluar) a on t.kd_transaksi_keluar = a.kd_transaksi_keluar
                                    WHERE t.is_active = 1 and 
                                    (CAST(t.created_date as DATE) BETWEEN CAST('" + startDate.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATE) AND 
                                    CAST('" + endDate.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATE)) AND a.id_toko =" + idToko.ToString


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
                .nama_status = reader("nama_status"),
                .flag_bayar = reader("flag_bayar"),
                 .kd_transaksi_keluar = reader("kd_transaksi_keluar"),
                    .harga_total = reader("harga_total"),
            .diskon = reader("diskon"),
            .harga_akhir = reader("harga_akhir"),
            .id_client = reader("id_client"),
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

        MappingToDataGrid(listTransaksi)

        CONN.Close()

        Return result
    End Function
    Public Function BmpToBytes_Serialization(bmp As Bitmap) As Byte()



        '// stream to save the bitmap to
        Dim MS As MemoryStream = New MemoryStream()
        Dim bf As BinaryFormatter = New BinaryFormatter()
        bf.Serialize(MS, bmp)

        '// read to end
        Dim bmpBytes As Byte() = MS.GetBuffer()
        bmp.Dispose()
        MS.Close()

        Return bmpBytes
    End Function

    Sub LoadReport()
        kdTransaksis.Clear()
        indexPenampung.Clear()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\Report3.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New SqlDataAdapter

            'CONN.Open()
            listTransaksi.Clear()
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
                                            tlp_owner,
                                            shipto_nama,
                                            shipto_alamat,
                                            shipto_kota,
                                            shipto_kdpos,
                                            persen_ppn,
                                            nominal_ppn,
                                            shipping_handling,
                                            subtotal,
                                            logo_toko,
                                            id_toko,
                                            company_name,
                                            kd_client,
                                            tgl_keluar,
                                            periode_rental,
                                            rental_type,
                                            rental_exp,
                                            flag_bayar
                                  from view_invoice "

            If KdTransaksi IsNot Nothing And KdTransaksi <> "" Then
                query = query + " where kd_transaksi_keluar = '" + KdTransaksi + "' "
            End If
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
                .flag_bayar = reader("flag_bayar"),
                 .id_transaksi = reader("id_transaksi"),
                 .kd_transaksi_keluar = reader("kd_transaksi_keluar"),
            .qty = reader("qty"),
            .nama_jenis = reader("nama_jenis"),
            .nama_tipe = reader("nama_tipe"),
            .serial_number = reader("serial_number"),
            .nama_jenis_tipe = reader("nama_jenis_tipe"),
            .nama_barang = reader("nama_barang"),
            .harga_jual = reader("harga_jual"),
            .harga_total = reader("harga_total"),
            .diskon = reader("diskon"),
            .harga_akhir = reader("harga_akhir"),
            .id_status_barang = reader("id_status_barang"),
            .nama_status = reader("nama_status"),
            .kd_client = reader("kd_client"),
            .nama_client = reader("nama_client"),
            .alamat_pengiriman = reader("alamat_pengiriman"),
            .kota_pengiriman = reader("kota_pengiriman"),
            .kdpos_pengiriman = reader("kdpos_pengiriman"),
            .tlp_client = reader("tlp_client"),
            .nama_toko = reader("nama_toko"),
              .alamat_toko = reader("alamat_toko"),
            .kota_toko = reader("kota_toko"),
            .kdpos_toko = reader("kdpos_toko"),
            .tlp_toko = reader("tlp_toko"),
            .nama_owner = reader("nama_owner"),
            .norek_owner = reader("norek_owner"),
            .tlp_owner = reader("tlp_owner"),
            .nama_jenis_tipe_serial = "",
            .shipto_nama = reader("shipto_nama"),
            .shipto_alamat = reader("shipto_alamat"),
            .shipto_kota = reader("shipto_kota"),
            .shipto_kdpos = reader("shipto_kdpos"),
            .persen_ppn = reader("persen_ppn"),
            .nominal_ppn = reader("nominal_ppn"),
            .shipping_handling = reader("shipping_handling"),
            .subtotal = reader("subtotal"),
            .logo_toko = reader("logo_toko"),
            .id_toko = reader("id_toko"),
            .company_name = reader("company_name"),
            .tgl_keluar = reader("tgl_keluar"),
            .periode_rental = reader("periode_rental"),
            .rental_type = reader("rental_type"),
            .rental_exp = reader("rental_exp")
                }
                Dim checkBarang = listTransaksi.Where(Function(x) x.nama_tipe = barang.nama_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).ToList()
                If checkBarang.Count = 0 Then
                    barang.nama_jenis_tipe_serial = barang.nama_tipe + vbCrLf + "SN: " + barang.serial_number
                    barang.qty = 1
                    listTransaksi.Add(barang)
                    'listTransaksi.Where(Function(x) x.nama_jenis_tipe = barang.nama_jenis_tipe).FirstOrDefault().nama_jenis_tipe = checkBarang.FirstOrDefault().nama_jenis_tipe + " SN: " + barang.serial_number
                Else
                    listTransaksi.Where(Function(x) x.nama_tipe = barang.nama_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().qty = Val(checkBarang.FirstOrDefault().qty) + 1

                    listTransaksi.Where(Function(x) x.nama_tipe = barang.nama_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().serial_number = checkBarang.FirstOrDefault().serial_number + ", " + barang.serial_number

                    listTransaksi.Where(Function(x) x.nama_tipe = barang.nama_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().nama_jenis_tipe_serial = checkBarang.FirstOrDefault().nama_jenis_tipe_serial + ", " + barang.serial_number
                End If

                'Result.Add(barang)

            End While
            CONN.Close()
            Dim data = New DataSet1()


            For Each insertDataBarangMasuk As Object In listTransaksi
                Dim row As DataRow

                row = ds.Tables("DataInvoice").NewRow
                row.Item(0) = insertDataBarangMasuk.id_transaksi
                row.Item(1) = insertDataBarangMasuk.kd_transaksi_keluar
                row.Item(2) = insertDataBarangMasuk.qty
                row.Item(3) = insertDataBarangMasuk.nama_jenis
                row.Item(4) = insertDataBarangMasuk.nama_tipe
                row.Item(5) = insertDataBarangMasuk.serial_number
                row.Item(6) = insertDataBarangMasuk.nama_jenis_tipe
                row.Item(7) = insertDataBarangMasuk.nama_barang
                row.Item(8) = insertDataBarangMasuk.harga_jual
                row.Item(9) = insertDataBarangMasuk.harga_total
                row.Item(10) = insertDataBarangMasuk.diskon
                row.Item(11) = insertDataBarangMasuk.harga_akhir
                row.Item(12) = insertDataBarangMasuk.id_status_barang
                row.Item(13) = insertDataBarangMasuk.nama_status
                row.Item(14) = insertDataBarangMasuk.nama_client
                row.Item(15) = insertDataBarangMasuk.alamat_pengiriman
                row.Item(16) = insertDataBarangMasuk.kota_pengiriman
                row.Item(17) = insertDataBarangMasuk.kdpos_pengiriman
                row.Item(18) = insertDataBarangMasuk.tlp_client
                row.Item(19) = insertDataBarangMasuk.nama_toko
                row.Item(20) = insertDataBarangMasuk.alamat_toko
                row.Item(21) = insertDataBarangMasuk.kota_toko
                row.Item(22) = insertDataBarangMasuk.kdpos_toko
                row.Item(23) = insertDataBarangMasuk.tlp_toko
                row.Item(24) = insertDataBarangMasuk.nama_owner
                row.Item(25) = insertDataBarangMasuk.norek_owner
                row.Item(26) = insertDataBarangMasuk.tlp_owner
                row.Item(27) = insertDataBarangMasuk.nama_jenis_tipe_serial
                row.Item(28) = insertDataBarangMasuk.shipto_nama
                row.Item(29) = insertDataBarangMasuk.shipto_alamat
                row.Item(30) = insertDataBarangMasuk.shipto_kota
                row.Item(31) = insertDataBarangMasuk.shipto_kdpos
                row.Item(32) = insertDataBarangMasuk.persen_ppn
                row.Item(33) = insertDataBarangMasuk.nominal_ppn
                row.Item(34) = insertDataBarangMasuk.shipping_handling
                row.Item(35) = insertDataBarangMasuk.subtotal
                Dim tClient As WebClient = New WebClient
                Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(insertDataBarangMasuk.logo_toko.ToString)))
                'tkButton.FirstOrDefault().BackgroundImage = downloadImage
                'Dim logoToko = BmpToBytes_Serialization(downloadImage)
                'Dim convertLogoTOko = Convert.ToBase64String(logoToko)
                row.Item(36) = Application.StartupPath & "\Reports\" + insertDataBarangMasuk.id_toko.ToString + ".jpeg"
                row.Item(37) = insertDataBarangMasuk.id_toko
                row.Item(38) = insertDataBarangMasuk.company_name
                row.Item(39) = insertDataBarangMasuk.kd_client
                'Dim edate = insertDataBarangMasuk.tgl_keluar.ToString
                'Dim iDate As String = "05/05/2005"
                'Dim oDate As Date = Convert.ToDateTime(edate)
                'row.Item(41) = oDate.ToShortDateString
                row.Item(41) = insertDataBarangMasuk.tgl_keluar
                row.Item(42) = insertDataBarangMasuk.periode_rental

                Try
                    If insertDataBarangMasuk.rental_type = "Hari" Then
                        row.Item(43) = "Days"
                    ElseIf insertDataBarangMasuk.rental_type = "Bulan" Then
                        row.Item(43) = "Months"
                    ElseIf insertDataBarangMasuk.rental_type = "Tahun" Then
                        row.Item(43) = "Years"
                    End If
                Catch ex As Exception
                    row.Item(43) = ""
                End Try

                'row.Item(43) = insertDataBarangMasuk.rental_type Then
                ds.Tables("DataInvoice").Rows.Add(row)


            Next

            Dim r(0) As ReportParameter
            r(0) = New ReportParameter("rpt_image", "File:\" + Application.StartupPath & "\Reports\" + listTransaksi.FirstOrDefault.id_toko.ToString + ".jpeg", True)

            ReportViewer1.LocalReport.EnableExternalImages = True
            ReportViewer1.LocalReport.SetParameters(New ReportParameter() {r(0)})

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
        GetTransaksi(UserInfo.IdToko, date_tgl_keluar1.Value, date_tgl_keluar2.Value)
    End Sub

    Private Sub dt_transaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_transaksi.CellContentClick
        kdTransaksis.Clear()
        indexPenampung.Clear()
    End Sub

    Private Sub dt_transaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_transaksi.CellClick
        kdTransaksis.Clear()
        indexPenampung.Clear()
        Dim selectedIdBarangKeluar = dt_transaksi.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangKeluar
            Dim idBarangMasuk = selectedItem.Cells(0).Value
            Dim index = selectedItem.Index
            indexPenampung.Add(index)
            kdTransaksis.Add(idBarangMasuk)
        Next selectedItem
    End Sub
    Function DeleteTransaksi(kdTransaksi As String)
        Try
            Dim userlogin As String = ""
            If UserInfo IsNot Nothing Then
                userlogin = UserInfo.Username
            End If

            Dim queryTblBarangMasuk As String = "UPDATE tbl_transaksi SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE kd_transaksi_keluar = '" + kdTransaksi.ToString + "'"

            cmd.CommandText = queryTblBarangMasuk
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("Data Telah Di Hapus")
        End Try

    End Function
    Private Sub btn_tampil_Click(sender As Object, e As EventArgs) Handles btn_tampil.Click
        If kdTransaksis.Count > 0 Then
            KdTransaksi = kdTransaksis(0)
            LoadReport()
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub btncari2_Click(sender As Object, e As EventArgs) Handles btncari2.Click
        dt_transaksi.Rows.Clear()
        Dim search = listTransaksi
        If TextBox1.Text <> "" Then
            Dim keywoard = TextBox1.Text
            If ComboBox1.Text = "No. Invoice" Then
                search = listTransaksi.Where(Function(x) x.kd_transaksi_keluar.ToString.Contains(keywoard)).ToList()

            ElseIf ComboBox1.Text = "Nama Client" Then
                search = listTransaksi.Where(Function(x) x.nama_client.ToString.Contains(keywoard)).ToList()

            ElseIf ComboBox1.Text = "ID Client" Then
                search = listTransaksi.Where(Function(x) x.kd_client.ToString.Contains(keywoard)).ToList()

            ElseIf ComboBox1.Text = "Flag Bayar" Then
                search = listTransaksi.Where(Function(x) x.flag_bayar.ToString.Contains(keywoard)).ToList()
            End If
        End If

        If TextBox2.Text <> "" Then
            Dim keywoard = TextBox2.Text
            If ComboBox2.Text = "No. Invoice" Then
                search = listTransaksi.Where(Function(x) x.kd_transaksi_keluar.ToString.Contains(keywoard)).ToList()

            ElseIf ComboBox2.Text = "Nama Client" Then
                search = listTransaksi.Where(Function(x) x.nama_client.ToString.Contains(keywoard)).ToList()

            ElseIf ComboBox2.Text = "ID Client" Then
                search = listTransaksi.Where(Function(x) x.kd_client.ToString.Contains(keywoard)).ToList()

            ElseIf ComboBox2.Text = "Flag Bayar" Then
                search = listTransaksi.Where(Function(x) x.flag_bayar.ToString.Contains(keywoard)).ToList()
            End If
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            GetTransaksi(UserInfo.IdToko, date_tgl_keluar1.Value, date_tgl_keluar2.Value)
        Else
            MappingToDataGrid(search)
            'listTransaksi = search
        End If

    End Sub

    Private Sub dt_transaksi_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dt_transaksi.CellValueChanged
        Dim changeHargaJualBarangKeluar = dt_transaksi.SelectedCells

        Dim index = 0
        For Each selectedItem As DataGridViewCell In changeHargaJualBarangKeluar
            If selectedItem.ColumnIndex = 13 Then
                If selectedItem.Value IsNot Nothing Then
                    Dim flagBayar = selectedItem.Value
                    If selectedItem.Value = "Yes" Then
                        flagBayar = 1
                    ElseIf selectedItem.Value = "No" Then
                        flagBayar = 0
                    End If
                    listTransaksi(selectedItem.RowIndex).flag_bayar = flagBayar

                    index = index + 1

                End If
            End If
        Next selectedItem
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        For Each data As Object In listTransaksi
            UpdateFlagBayar(data.flag_bayar, UserInfo.Username, data.kd_transaksi_keluar)
        Next
        kdTransaksis.Clear()
        indexPenampung.Clear()

        MsgBox("Data Telah Tersimpan")
        dt_transaksi.Rows.Clear()
        MappingToDataGrid(listTransaksi)
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click

        For Each data As Object In kdTransaksis
            Dim index = listTransaksi.Where(Function(x) x.kd_transaksi_keluar = data).FirstOrDefault()
            listTransaksi.Remove(index)
            DeleteTransaksi(data)
        Next

        kdTransaksis.Clear()
        indexPenampung.Clear()

        dt_transaksi.Rows.Clear()
        MappingToDataGrid(listTransaksi)
    End Sub
End Class