Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports Microsoft.Reporting.WinForms
Public Class cetak_kwitansi_barang
    Public Property KdTransaksi As String
    Public Property UserInfo As Object
    Dim kdTransaksis As New List(Of String)
    Dim listTransaksi As New List(Of Object)
    Dim listTransaksiTODataSet As New List(Of Object)
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Private _Kamus As SortedDictionary(Of Integer, String)
    Private _ArGroup() As String = {"", " RIBU", " JUTA", " MILYAR", " TRILIYUN"}

    Private Sub InitializeKamus()
        _Kamus = New SortedDictionary(Of Integer, String)
        _Kamus.Clear()
        _Kamus.Add(0, "")
        _Kamus.Add(1, " SATU")
        _Kamus.Add(2, " DUA")
        _Kamus.Add(3, " TIGA")
        _Kamus.Add(4, " EMPAT")
        _Kamus.Add(5, " LIMA")
        _Kamus.Add(6, " ENAM")
        _Kamus.Add(7, " TUJUH")
        _Kamus.Add(8, " DELAPAN")
        _Kamus.Add(9, " SEMBILAN")
        _Kamus.Add(10, " SEPULUH")
        _Kamus.Add(11, " SEBELAS")
        _Kamus.Add(100, " SERATUS")
    End Sub

    Public Function Terbilang2(Bilangan As Double) As String
        Dim sRet As String = ""
        Dim sMinus As String = ""
        Dim BilCacah As Double = 0
        Dim BilPecahan As Integer = 0


        InitializeKamus()

        Try
            If Bilangan < 0 Then sMinus = "MINUS "

            Dim grp() As String = Split(Math.Abs(Bilangan).ToString(System.Globalization.NumberFormatInfo.CurrentInfo), System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator)
            If grp.Length > 1 Then
                BilCacah = CDbl(grp(0))
                BilPecahan = CInt(grp(1))
            Else
                BilCacah = Bilangan
            End If

            Dim triple() As String = Split(BilCacah.ToString("#,##0", System.Globalization.NumberFormatInfo.CurrentInfo), System.Globalization.NumberFormatInfo.CurrentInfo.NumberGroupSeparator)
            Array.Reverse(triple)

            For i As Integer = triple.Length - 1 To 0 Step -1
                sRet = sRet & BacaGroupAngka(triple(i), False, IIf(i > 5, i - 5 + 1, i))
            Next

            If BilPecahan > 0 Then
                sRet = sRet & " Koma" & BacaGroupAngka(BilPecahan, True)
            End If

            sRet = sMinus & sRet

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Parsing Bilangan")

        End Try

        _Kamus.Clear()
        _Kamus = Nothing

        Return sRet.Trim
    End Function

    Private Function BacaGroupAngka(ByVal Angka As Integer,
                                    Optional IsPecahan As Boolean = False,
                                    Optional iGroup As Byte = 0) As String
        Dim sRet As String = ""
        Dim sAngka As String = Angka.ToString("000")

        Select Case IsPecahan
            Case True
                Try
                    For i As Integer = 0 To sAngka.Length - 1
                        If CInt(sAngka.Substring(i, 1)) = 0 Then
                            sRet = sRet & "Nol"
                        Else
                            sRet = sRet & _Kamus(CInt(sAngka.Substring(i, 1)))
                        End If
                    Next
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly, "Baca Pecahan")
                End Try
            Case Else
                Try
                    If Angka = 1 And iGroup = 1 Then
                        sRet = " SERIBU"
                    ElseIf _Kamus.ContainsKey(Angka) Then
                        sRet = _Kamus(Angka) & _ArGroup(iGroup)
                    Else
                        Dim Satuan As String = _Kamus(CInt(sAngka.Substring(2, 1)))
                        Dim puluhan As String = ""
                        Dim ratusan As String = ""

                        If _Kamus.ContainsKey(CInt(sAngka.Substring(1, 2))) Then
                            puluhan = _Kamus(CInt(sAngka.Substring(1, 2)))
                        Else
                            If CInt(sAngka.Substring(1, 1)) = 0 Then
                                puluhan = Satuan
                            ElseIf CInt(sAngka.Substring(1, 1)) = 1 Then
                                puluhan = Satuan & " BELAS"
                            Else
                                puluhan = _Kamus(CInt(sAngka.Substring(1, 1))) & " PULUH" & Satuan
                            End If
                        End If

                        If CInt(sAngka.Substring(0, 1)) = 0 Then
                            ratusan = puluhan
                        ElseIf CInt(sAngka.Substring(0, 1)) = 1 Then
                            ratusan = " SERATUS" & puluhan
                        Else
                            ratusan = _Kamus(CInt(sAngka.Substring(0, 1))) & " RATUS" & puluhan
                        End If

                        sRet = ratusan & _ArGroup(iGroup)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly, "Baca Bilangan Bulat")
                End Try
        End Select

        Return sRet
    End Function
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
    Private Sub cetak_kwitansi_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VBnetSQLSeverConnection()
        Me.ReportViewer1.RefreshReport()
        LoadReport()
    End Sub
    Public Function GetCountNamaJenisTipe(kdTransaksi As String, namaJenisTipe As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT count(*) as count 
                                    FROM View_invoice 
                                    WHERE kd_transaksi_keluar = '" + kdTransaksi + "' 
                                    AND nama_jenis_tipe = '" + namaJenisTipe + "' "


        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        Try

            'CONN.Open()
        Catch ex As Exception
            'CONN.Close()
            'CONN.Open()
        End Try
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim barang = New With
                {
            .count = reader("count")
                }
            'listTransaksi.Add(barang)
            result.Add(barang)

        End While
        Return result
    End Function
    Public Function GetTransaksi(idToko As String, startDate As DateTime, endDate As DateTime)
        dt_transaksi.Rows.Clear()
        listTransaksi.Clear()
        Dim result As New List(Of Object)
        Dim query As String = "SELECT t.*,tc.nama_client, a.id_toko FROM tbl_transaksi t
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
    Public Function Terbilang(ByVal x As Integer) As String

        Dim bilangan As String() = {"", "SATU", "DUA", "TIGA", "EMPAT", "LIMA", "ENAM", "TUJUH", "DELAPAN", "SEMBILAN", "SEPULUH", "SEBELAS"}

        Dim temp As String = ""

        If x < 12 Then
            temp = bilangan(x)
        ElseIf x < 20 Then
            temp = Terbilang(x - 10) + " BELAS "
        ElseIf x < 100 Then
            temp = Terbilang(x / 10) + " PULUH " + Terbilang(x Mod 10)
        ElseIf x < 200 Then
            temp = " SERATUS" + Terbilang(x - 100)
        ElseIf x < 1000 Then
            temp = Terbilang(x / 100) + " RATUS " + Terbilang(x Mod 100)
        ElseIf x < 2000 Then
            temp = " SERIBU " + Terbilang(x - 1000)
        ElseIf x < 1000000 Then
            temp = Terbilang(x / 1000) + " RIBU " + Terbilang(x Mod 1000)
        ElseIf x < 1000000000 Then
            temp = Terbilang(x / 1000000) + " JUTA " + Terbilang(x Mod 1000000)
        End If

        Return temp

    End Function
    Sub LoadReport()
        Dim rptDS As ReportDataSource
        Me.ReportViewer1.RefreshReport()
        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\Report6_kwitansi_barang.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New SqlDataAdapter

            'CONN.Open()
            listTransaksi.Clear()
            listTransaksiTODataSet.Clear()
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
                                            tgl_keluar
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
            .kd_client = reader("kd_client"),
            .tgl_keluar = reader("tgl_keluar")
                }
                Dim checkBarang = listTransaksi.Where(Function(x) x.nama_tipe = barang.nama_tipe And x.kd_transaksi_keluar = barang.kd_transaksi_keluar).ToList()
                If checkBarang.Count = 0 Then
                    barang.nama_jenis_tipe_serial = barang.nama_tipe + " SN: " + barang.serial_number
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

            Dim index = 0
            For i = 0 To listTransaksi.Count - 1

                Dim barang = New With
              {
               .id_transaksi = listTransaksi(i).id_transaksi,
               .kd_transaksi_keluar = listTransaksi(i).kd_transaksi_keluar,
          .qty = listTransaksi(i).qty,
          .nama_jenis = listTransaksi(i).nama_jenis,
          .nama_tipe = listTransaksi(i).nama_tipe,
          .serial_number = listTransaksi(i).serial_number,
          .nama_jenis_tipe = listTransaksi(i).nama_jenis_tipe,
          .nama_barang = listTransaksi(i).nama_barang,
          .harga_jual = listTransaksi(i).harga_jual,
          .harga_total = listTransaksi(i).harga_total,
          .diskon = listTransaksi(i).diskon,
          .harga_akhir = listTransaksi(i).harga_akhir,
          .id_status_barang = listTransaksi(i).id_status_barang,
          .nama_status = listTransaksi(i).nama_status,
          .nama_client = listTransaksi(i).nama_client,
          .alamat_pengiriman = listTransaksi(i).alamat_pengiriman,
          .kota_pengiriman = listTransaksi(i).kota_pengiriman,
          .kdpos_pengiriman = listTransaksi(i).kdpos_pengiriman,
          .tlp_client = listTransaksi(i).tlp_client,
          .nama_toko = listTransaksi(i).nama_toko,
          .alamat_toko = listTransaksi(i).alamat_toko,
          .kota_toko = listTransaksi(i).kota_toko,
          .kdpos_toko = listTransaksi(i).kdpos_toko,
          .tlp_toko = listTransaksi(i).tlp_toko,
          .nama_owner = listTransaksi(i).nama_owner,
          .norek_owner = listTransaksi(i).norek_owner,
          .tlp_owner = listTransaksi(i).tlp_owner,
          .nama_jenis_tipe_serial = listTransaksi(i).nama_jenis_tipe_serial,
          .shipto_nama = listTransaksi(i).shipto_nama,
          .shipto_alamat = listTransaksi(i).shipto_alamat,
          .shipto_kota = listTransaksi(i).shipto_kota,
          .shipto_kdpos = listTransaksi(i).shipto_kdpos,
          .persen_ppn = listTransaksi(i).persen_ppn,
          .nominal_ppn = listTransaksi(i).nominal_ppn,
          .shipping_handling = listTransaksi(i).shipping_handling,
          .subtotal = listTransaksi(i).subtotal,
          .logo_toko = listTransaksi(i).logo_toko,
          .id_toko = listTransaksi(i).id_toko,
          .company_name = listTransaksi(i).company_name,
          .kd_client = listTransaksi(i).kd_client,
          .terbilangNominal = "",
          .tgl_keluar = listTransaksi(i).tgl_keluar
              }

                Dim checkTransaksi = listTransaksiTODataSet.Where(Function(x) x.kd_transaksi_keluar = barang.kd_transaksi_keluar).ToList()
                If checkTransaksi.Count = 0 Then
                    Try
                        barang.terbilangNominal = Terbilang2(barang.subtotal)
                        barang.terbilangNominal = barang.terbilangNominal + " RUPIAH "
                    Catch ex As Exception

                    End Try

                    barang.nama_jenis_tipe_serial = barang.qty.ToString + " Unit " + barang.nama_jenis_tipe_serial
                    listTransaksiTODataSet.Add(barang)
                    index = index + 1
                Else
                    listTransaksiTODataSet.Where(Function(x) x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().
                        nama_jenis_tipe_serial = listTransaksiTODataSet.Where(Function(x) x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().
                        nama_jenis_tipe_serial + ", " + barang.qty.ToString + " Unit " + barang.nama_jenis_tipe_serial

                    listTransaksiTODataSet.Where(Function(x) x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().
                       qty = listTransaksiTODataSet.Where(Function(x) x.kd_transaksi_keluar = barang.kd_transaksi_keluar).FirstOrDefault().
                       qty + barang.qty

                End If
            Next

            For Each insertDataBarangMasuk As Object In listTransaksiTODataSet
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
                row.Item(40) = insertDataBarangMasuk.terbilangNominal
                row.Item(41) = insertDataBarangMasuk.tgl_keluar

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

    Private Sub btn_tampil_list_Click(sender As Object, e As EventArgs) Handles btn_tampil_list.Click
        GetTransaksi(UserInfo.IdToko, date_tgl_keluar1.Value, date_tgl_keluar2.Value)
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

    Private Sub dt_transaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_transaksi.CellContentClick

    End Sub
End Class