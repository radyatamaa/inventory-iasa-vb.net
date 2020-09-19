Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text
Imports Microsoft.Office.Interop

Public Class BarangMasuk
    Public Property UserInfo As Object
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim listJenis As New List(Of Object)
    Dim listTipe As New List(Of Object)
    Dim listKondisiCache As New List(Of Object)
    Dim listStatus As New List(Of Object)
    Dim listLokasiCache As New List(Of Object)
    Dim listDetailLokasiCache As New List(Of Object)
    Dim indexPenampung As New List(Of Integer)
    Dim isDataReal As New List(Of Integer)
    Dim listBarangMasuk As New List(Of Object)
    Dim listBarangMasuk2 As New List(Of Object)

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
    Private Function GetExcelSheetsName(ByVal Excelfilename As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim objExcel As Excel.Application
        Dim objWorkBook As Excel.Workbook
        Dim objWorkSheets As Excel.Worksheet
        Dim objWorkCells As Excel.DataTable
        Dim SheetList As New ArrayList
        objExcel = CreateObject("Excel.Application")
        objWorkBook = objExcel.Workbooks.Open(Excelfilename)
        Dim a
        Dim ex = objWorkBook.Worksheets(1)

        For i As Long = 2 To 999999999999999999
            a = ex.Cells(i, 1).Value
            If a IsNot Nothing Then
                Dim idToko As String
                If UserInfo IsNot Nothing Then
                    idToko = UserInfo.IdToko
                End If
                Dim test = CType(ex.Cells(i, 11), Microsoft.Office.Interop.Excel.Range).Value.ToString
                Dim test3 = CType(ex.Cells(i, 11), Microsoft.Office.Interop.Excel.Range).Value
                Dim hargaBeli As Decimal = Decimal.Parse(test)
                Dim hargaJual As Decimal = Decimal.Parse(CType(ex.Cells(i, 12), Microsoft.Office.Interop.Excel.Range).Value.ToString)
                Dim namaJenis = listJenis.Where(Function(x) x.id_jenis = CType(ex.Cells(i, 1), Microsoft.Office.Interop.Excel.Range).Value.ToString()).Select(Function(x) x.nama_jenis).FirstOrDefault()
                Dim namaTipe = listTipe.Where(Function(x) x.id_tipe = CType(ex.Cells(i, 2), Microsoft.Office.Interop.Excel.Range).Value.ToString()).Select(Function(x) x.nama_tipe).FirstOrDefault()
                Dim namaKondisi = listKondisiCache.Where(Function(x) x.id_kondisi = CType(ex.Cells(i, 4), Microsoft.Office.Interop.Excel.Range).Value.ToString()).Select(Function(x) x.nama_kondisi).FirstOrDefault()
                Dim namaLokasi = listLokasiCache.Where(Function(x) x.id_lokasi = CType(ex.Cells(i, 6), Microsoft.Office.Interop.Excel.Range).Value.ToString()).Select(Function(x) x.nama_lokasi).FirstOrDefault()
                Dim namaDetailLokasi = listDetailLokasiCache.Where(Function(x) x.id_detail_lokasi = CType(ex.Cells(i, 7), Microsoft.Office.Interop.Excel.Range).Value.ToString()).Select(Function(x) x.detail_lokasi).FirstOrDefault()
                Dim namaStatus = listStatus.Where(Function(x) x.id_status_barang = CType(ex.Cells(i, 10), Microsoft.Office.Interop.Excel.Range).Value.ToString()).Select(Function(x) x.nama_status).FirstOrDefault()
                Dim insertDataBarangMasuk = New With
                    {
                    .catatan = CType(ex.Cells(i, 9), Microsoft.Office.Interop.Excel.Range).Value.ToString,
                    .id_barang = Me.Label2.Tag,
                     .id_barang_masuk = Me.Label1.Tag,
                     .kd_barang = CType(ex.Cells(i, 13), Microsoft.Office.Interop.Excel.Range).Value.ToString,
                     .nama_jenis = namaJenis,
                     .id_jenis = CType(ex.Cells(i, 1), Microsoft.Office.Interop.Excel.Range).Value,
                     .nama_tipe = namaTipe,
                     .id_tipe = CType(ex.Cells(i, 2), Microsoft.Office.Interop.Excel.Range).Value,
                     .serial_number = CType(ex.Cells(i, 3), Microsoft.Office.Interop.Excel.Range).Value.ToString,
                     .nama_kondisi = namaKondisi,
                     .id_kondisi = CType(ex.Cells(i, 4), Microsoft.Office.Interop.Excel.Range).Value,
                     .warna = "",
                     .nama_status_barang = namaStatus,
                     .id_status_barang = CType(ex.Cells(i, 10), Microsoft.Office.Interop.Excel.Range).Value,
                     .tested = CType(ex.Cells(i, 5), Microsoft.Office.Interop.Excel.Range).Value,
                     .nama_lokasi = namaLokasi,
                     .id_lokasi = CType(ex.Cells(i, 6), Microsoft.Office.Interop.Excel.Range).Value,
                     .nama_detail_lokasi = namaDetailLokasi,
                     .id_detail_lokasi = CType(ex.Cells(i, 7), Microsoft.Office.Interop.Excel.Range).Value,
                     .id_toko = idToko,
                     .harga_beli = hargaBeli,
                     .harga_jual = hargaJual,
                     .stock = 0,
                     .licence = CType(ex.Cells(i, 8), Microsoft.Office.Interop.Excel.Range).Value.ToString,
                     .ios = CType(ex.Cells(i, 9), Microsoft.Office.Interop.Excel.Range).Value.ToString,
                     .foto_barang = "",
                     .kd_transaksi_masuk = "",
                     .tgl_masuk = CType(ex.Cells(i, 14), Microsoft.Office.Interop.Excel.Range).Value.ToString,
                     .jumlah = 0
                    }
                'validationSerialNumberDB
                Dim barang = GetBarangMasukBySerialNumber(insertDataBarangMasuk.serial_number)
                If barang.Count > 0 Then
                    MsgBox("Serial Number " + insertDataBarangMasuk.serial_number + " Sudah ada!")
                    result.Clear()
                    Return result
                End If

                'validationSerialNumberDataGrid
                Dim barangMasukCheck = listBarangMasuk.Where(Function(x) x.serial_number.ToLower() = insertDataBarangMasuk.serial_number.ToLower())
                If barangMasukCheck.Count > 0 Then
                    MsgBox("Serial Number " + insertDataBarangMasuk.serial_number + " Sudah ada!")
                    result.Clear()
                    Return result
                End If

                'validationSerialNumberExcel
                Dim barangMasukExcel = result.Where(Function(x) x.serial_number.ToLower() = insertDataBarangMasuk.serial_number.ToLower())
                If barangMasukExcel.Count > 0 Then
                    MsgBox("Serial Number " + insertDataBarangMasuk.serial_number + " Sudah ada!")
                    result.Clear()
                    Return result
                End If
                result.Add(insertDataBarangMasuk)
                'MessageBox.Show(CType(ex.Cells(i, 1), Microsoft.Office.Interop.Excel.Range).Value.ToString())

            Else
                GoTo end_of_for
            End If

        Next
end_of_for:
        objWorkBook.Close()
        Return result
    End Function
    Function DeleteBarangMasuk(idBarangMasuk As Integer, idbarang As Integer)
        Try
            Dim userlogin As String = ""
            If UserInfo IsNot Nothing Then
                userlogin = UserInfo.Username
            End If
            Dim queryTblBarang As String = "UPDATE tbl_barang SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_barang = " + idbarang.ToString
            cmd.CommandText = queryTblBarang
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

            Dim queryTblBarangMasuk As String = "UPDATE tbl_barang_masuk SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_barang_masuk = " + idBarangMasuk.ToString
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
            Me.Label1.Tag = 0
            Me.Label2.Tag = 0
        End Try

    End Function
    Function GetStatusBarang() As List(Of Object)
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_status_barang WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_status = reader("nama_status").ToString,
                            .id_status_barang = reader("id_status_barang")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetAllLokasiDetail() As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_detail_lokasi WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .detail_lokasi = reader("detail_lokasi").ToString,
                            .id_detail_lokasi = reader("id_detail_lokasi")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetLokasiDetail(idLokasi As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_detail_lokasi WHERE is_active = 1 AND id_lokasi = " + idLokasi
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .detail_lokasi = reader("detail_lokasi").ToString,
                            .id_detail_lokasi = reader("id_detail_lokasi")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetLokasi() As List(Of Object)
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_lokasi WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_lokasi = reader("nama_lokasi").ToString,
                            .id_lokasi = reader("id_lokasi")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetKondisi() As List(Of Object)
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_kondisi WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_kondisi = reader("nama_kondisi").ToString,
                            .id_kondisi = reader("id_kondisi")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetJenisBarang() As List(Of Object)
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_jenis WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_jenis = reader("nama_jenis").ToString,
                            .id_jenis = reader("id_jenis")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetTipeJenisBarang(idJenis As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_tipe WHERE is_active = 1 AND id_jenis = " + idJenis
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_tipe = reader("nama_tipe").ToString,
                            .id_tipe = reader("id_tipe")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetAllTipeJenisBarang() As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_tipe WHERE is_active = 1"
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_tipe = reader("nama_tipe").ToString,
                            .id_tipe = reader("id_tipe")
                            }
            result.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function SimpanBarangMasuk(barangMasuk As Object) As String
        Dim idToko
        Dim userlogin As String = ""
        Dim barangMasukId As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
            idToko = UserInfo.IdToko.ToString
        Else
            idToko = "NULL"
        End If
        If barangMasuk.id_barang_masuk <> 0 Then
            Try
                Dim queryTblBarang As String = " UPDATE tbl_barang SET 
                                    kd_barang =  '" + barangMasuk.kd_barang + "',
                                    id_jenis =  " + barangMasuk.id_jenis.ToString + ",
                                    id_tipe =  " + barangMasuk.id_tipe.ToString + ",
                                    serial_number =  '" + barangMasuk.serial_number + "',
                                    id_kondisi =  " + barangMasuk.id_kondisi.ToString + ",
                                    warna = '" + barangMasuk.warna + "',
                                    id_status_barang =  " + barangMasuk.id_status_barang.ToString + ",
                                    tested = " + barangMasuk.tested.ToString + ",
                                    id_lokasi  = " + barangMasuk.id_lokasi.ToString + ",
                                    id_detail_lokasi = " + barangMasuk.id_detail_lokasi.ToString + ",
                                    id_toko = " + idToko + ",
                                    harga_beli =  " + barangMasuk.harga_beli.ToString + ",
                                    harga_jual =  " + barangMasuk.harga_jual.ToString + ",
                                    stock =  " + barangMasuk.stock.ToString + ",
                                    licence =   '" + barangMasuk.licence + "',
                                    ios =  '" + barangMasuk.ios + "',
                                    foto_barang = '" + barangMasuk.foto_barang + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_barang = " + barangMasuk.id_barang.ToString


                cmd.CommandText = queryTblBarang
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                Dim idBarang As Integer = barangMasuk.id_barang
                barangMasukId = barangMasuk.id_barang_masuk
                Dim queryTblBarangMasuk As String = " UPDATE tbl_barang_masuk SET
                                    id_barang =   " + idBarang.ToString + ",
                                    tgl_masuk =   CAST('" + DateTime.Parse(barangMasuk.tgl_masuk).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    id_toko =    " + idToko + ",
                                    jumlah = " + barangMasuk.jumlah.ToString + ",
                                    updated_by =   '" + userlogin + "',
                                    updated_date =   CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_barang_masuk = " + barangMasuk.id_barang_masuk.ToString

                cmd.CommandText = queryTblBarangMasuk
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'GetBarangMasuk()
                Me.Label1.Tag = 0
                Me.Label2.Tag = 0
            End Try
            Return barangMasukId
        Else
            Try
                Dim queryTblBarang As String = " INSERT INTO tbl_barang (
                                    kd_barang,
                                    id_jenis,
                                    id_tipe,
                                    serial_number,
                                    id_kondisi,
                                    warna,
                                    id_status_barang,
                                    tested,
                                    id_lokasi,
                                    id_detail_lokasi,
                                    id_toko,
                                    harga_beli,
                                    harga_jual,
                                    stock,
                                    licence,
                                    ios,
                                    foto_barang,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + barangMasuk.kd_barang + "',
                                    " + barangMasuk.id_jenis.ToString + ",
                                    " + barangMasuk.id_tipe.ToString + ",
                                    '" + barangMasuk.serial_number + "',
                                    " + barangMasuk.id_kondisi.ToString + ",
                                    '" + barangMasuk.warna + "',
                                    " + barangMasuk.id_status_barang.ToString + ",
                                    " + barangMasuk.tested.ToString + ",
                                    " + barangMasuk.id_lokasi.ToString + ",
                                    " + barangMasuk.id_detail_lokasi.ToString + ",
                                    " + idToko + ",
                                    " + barangMasuk.harga_beli.ToString + ",
                                    " + barangMasuk.harga_jual.ToString + ",
                                    " + barangMasuk.stock.ToString + ",
                                    '" + barangMasuk.licence + "',
                                    '" + barangMasuk.ios + "',
                                    '" + barangMasuk.foto_barang + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTblBarang
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                'reader = cmd.ExecuteReader()
                Dim idBarang As Integer = cmd.ExecuteScalar()
                Dim queryTblBarangMasuk As String = " INSERT INTO tbl_barang_masuk (
                                    kd_transaksi_masuk,
                                    id_barang,
                                    tgl_masuk,
                                    id_toko,
                                    jumlah,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + barangMasuk.kd_transaksi_masuk + "',
                                    " + idBarang.ToString + ",
                                     CAST('" + DateTime.Parse(barangMasuk.tgl_masuk).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + idToko + ",
                                    " + barangMasuk.jumlah.ToString + ",
                                    '" + userlogin + "',
                                     CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "

                cmd.CommandText = queryTblBarangMasuk
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                barangMasukId = cmd.ExecuteScalar()
                'reader = cmd.ExecuteReader()

                CONN.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'GetBarangMasuk()
                Me.Label1.Tag = 0
                Me.Label2.Tag = 0
            End Try
            Return barangMasukId
        End If

    End Function
    Function GetBarangMasukById(id As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT *  FROM tbl_barang_masuk bm
                                  INNER JOIN tbl_barang b ON bm.id_barang = b.id_barang
		                          INNER JOIN tbl_kondisi k ON b.id_kondisi = k.id_kondisi
		                          INNER JOIN tbl_jenis j ON b.id_jenis = j.id_jenis
		                          INNER JOIN tbl_tipe t ON b.id_tipe = t.id_tipe
		                          INNER JOIN tbl_lokasi l ON b.id_lokasi = l.id_lokasi
		                          INNER JOIN tbl_detail_lokasi dl ON b.id_detail_lokasi = dl.id_detail_lokasi
		                          INNER JOIN tbl_status_barang sb ON b.id_status_barang = sb.id_status_barang
                                  WHERE bm.is_active = 1 AND bm.id_barang_masuk = " + id
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim barangMasuk = New With
                {
                .id_barang = reader("id_barang"),
                  .id_barang_masuk = reader("id_barang_masuk"),
                 .kd_barang = reader("kd_barang"),
                 .id_jenis = reader("id_jenis"),
                 .id_tipe = reader("id_tipe"),
                 .serial_number = reader("serial_number"),
                 .id_kondisi = reader("id_kondisi"),
                 .id_status_barang = reader("id_status_barang"),
                 .tested = reader("tested"),
                 .id_lokasi = reader("id_lokasi"),
                 .id_detail_lokasi = reader("id_detail_lokasi"),
                 .id_toko = reader("id_toko"),
                 .harga_beli = reader("harga_beli"),
                 .harga_jual = reader("harga_jual"),
                 .licence = reader("licence"),
                 .tgl_masuk = reader("tgl_masuk")
                }

            result.Add(barangMasuk)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetBarangMasukBySerialNumber(serialNumber As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT *  FROM tbl_barang_masuk bm
                                  INNER JOIN tbl_barang b ON bm.id_barang = b.id_barang
		                          INNER JOIN tbl_kondisi k ON b.id_kondisi = k.id_kondisi
		                          INNER JOIN tbl_jenis j ON b.id_jenis = j.id_jenis
		                          INNER JOIN tbl_tipe t ON b.id_tipe = t.id_tipe
		                          INNER JOIN tbl_lokasi l ON b.id_lokasi = l.id_lokasi
		                          INNER JOIN tbl_detail_lokasi dl ON b.id_detail_lokasi = dl.id_detail_lokasi
		                          INNER JOIN tbl_status_barang sb ON b.id_status_barang = sb.id_status_barang
                                  WHERE bm.is_active = 1 AND b.serial_number = '" + serialNumber + "'"
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim barangMasuk = New With
                {
                .id_barang = reader("id_barang"),
                  .id_barang_masuk = reader("id_barang_masuk"),
                 .kd_barang = reader("kd_barang"),
                 .id_jenis = reader("id_jenis"),
                 .id_tipe = reader("id_tipe"),
                 .serial_number = reader("serial_number"),
                 .id_kondisi = reader("id_kondisi"),
                 .id_status_barang = reader("id_status_barang"),
                 .tested = reader("tested"),
                 .id_lokasi = reader("id_lokasi"),
                 .id_detail_lokasi = reader("id_detail_lokasi"),
                 .id_toko = reader("id_toko"),
                 .harga_beli = reader("harga_beli"),
                 .harga_jual = reader("harga_jual"),
                 .licence = reader("licence"),
                 .tgl_masuk = reader("tgl_masuk")
                }

            result.Add(barangMasuk)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetBarangMasuk(idToko As String)

        Dim result As New List(Of Object)

        Dim query As String = "SELECT *  FROM tbl_barang_masuk bm
                                  INNER JOIN tbl_barang b ON bm.id_barang = b.id_barang
		                          INNER JOIN tbl_kondisi k ON b.id_kondisi = k.id_kondisi
		                          INNER JOIN tbl_jenis j ON b.id_jenis = j.id_jenis
		                          INNER JOIN tbl_tipe t ON b.id_tipe = t.id_tipe
		                          INNER JOIN tbl_lokasi l ON b.id_lokasi = l.id_lokasi
		                          INNER JOIN tbl_detail_lokasi dl ON b.id_detail_lokasi = dl.id_detail_lokasi
		                          INNER JOIN tbl_status_barang sb ON b.id_status_barang = sb.id_status_barang
                                  WHERE bm.is_active = 1 AND b.id_toko =" + idToko.ToString

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim test = reader("nama_jenis")
            Dim barang = New With
                {
                .id_barang = reader("id_barang"),
                 .nama_jenis = reader("nama_jenis"),
                    .nama_tipe = reader("nama_tipe"),
            .serial_number = reader("serial_number"),
            .nama_kondisi = reader("nama_kondisi"),
            .tested = reader("tested"),
            .nama_lokasi = reader("nama_lokasi"),
            .detail_lokasi = reader("detail_lokasi"),
            .licence = reader("licence"),
            .catatan = reader("ios"),
            .nama_status = reader("nama_status"),
            .harga_beli = reader("harga_beli"),
            .harga_jual = reader("harga_jual"),
            .tgl_masuk = reader("tgl_masuk"),
            .id_barang_masuk = reader("id_barang_masuk")
                }
            listBarangMasuk2.Add(barang)
            result.Add(barang)

        End While

        Dim index = 0
        For Each insertDataBarangMasuk As Object In result
            dt_barang_masuk.Rows.Add(1)
            Dim isTest As String
            If insertDataBarangMasuk.tested = 1 Then
                isTest = "Teruji"
            Else
                isTest = "Tidak Teruji"
            End If
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.nama_jenis
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_tipe
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.serial_number
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.nama_kondisi
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(4).Value = isTest
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(5).Value = insertDataBarangMasuk.nama_lokasi
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.detail_lokasi
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(7).Value = insertDataBarangMasuk.licence
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(8).Value = insertDataBarangMasuk.catatan
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(9).Value = insertDataBarangMasuk.nama_status
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(10).Value = insertDataBarangMasuk.harga_beli
            If UserInfo.IdLevel <> 1 Then
                dt_barang_masuk.Columns(10).Visible = False
            ElseIf UserInfo.IdLevel = 1 Then
                dt_barang_masuk.Columns(10).Visible = True
            End If
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(11).Value = insertDataBarangMasuk.harga_jual
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(12).Value = insertDataBarangMasuk.tgl_masuk
            If index = 0 Then
                dt_barang_masuk.Columns.Add("id_barang_masuk", "IdBarangMasuk")
                dt_barang_masuk.Columns(13).Visible = False
            End If
            dt_barang_masuk.Rows(dt_barang_masuk.RowCount - 2).Cells(13).Value = insertDataBarangMasuk.id_barang_masuk

            dt_barang_masuk.Update()
            index = index + 1

        Next

        CONN.Close()

        Return result
    End Function

    Function RandomString(r As Random) As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        For Each insertDataBarangMasuk As Object In listBarangMasuk
            Dim idBarangMasuk As Integer = SimpanBarangMasuk(insertDataBarangMasuk)
        Next
        listBarangMasuk.Clear()
        data_barang_masuk.Rows.Clear()
        dt_barang_masuk.Rows.Clear()
        indexPenampung.Clear()
        GetBarangMasuk(UserInfo.IdToko)
        Me.txt_kode_barang.Text = ""
        Me.txt_serial.Text = ""
        Me.txt_harga_modal.Text = 0
        Me.txt_harga_barang.Text = 0
        Me.txt_lisensi.Text = ""
        Me.txt_catatan.Text = ""
        Me.txt_file_excel.Text = ""
        MsgBox("Sukses!")
    End Sub

    Private Sub btn_menuutama_Click(sender As Object, e As EventArgs)
        MenuUtama.Show()
        Me.Close()
    End Sub
    Private Sub btn_penjualan_Click(sender As Object, e As EventArgs)
        BarangKeluar.Show()
        Me.Close()
    End Sub
    Private Sub btn_rental_Click(sender As Object, e As EventArgs)
        Rental.Show()
        Me.Close()
    End Sub

    Private Sub btn_repair_Click(sender As Object, e As EventArgs)
        Repair.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_jenis_Click(sender As Object, e As EventArgs)
        MasterJenisBarang.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_tipe_Click(sender As Object, e As EventArgs)
        MasterTipe.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_toko_Click(sender As Object, e As EventArgs)
        MasterDataToko.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_client_Click(sender As Object, e As EventArgs)
        MasterClient.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_kondisi_Click(sender As Object, e As EventArgs)
        MasterKondisi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_status_Click(sender As Object, e As EventArgs)
        MasterStatus.Show()
        Me.Close()
    End Sub

    Private Sub MasterLokasiToolStripMenuIbtn_master_lokasi_Click(sender As Object, e As EventArgs)
        MasterLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_detail_Click(sender As Object, e As EventArgs)
        MasterDetailLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_alasan_Click(sender As Object, e As EventArgs)
        MasterAlasan.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_data_user_Click(sender As Object, e As EventArgs)
        MasterUser.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub

    Public Sub BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txt_harga_modal.Text = 0
            txt_harga_barang.Text = 0
            If UserInfo.IdLevel = 2 Then
                Me.txt_harga_modal.Visible = False
            ElseIf UserInfo.IdLevel = 1 Then
                Me.txt_harga_modal.Visible = True
            Else
                Me.txt_harga_modal.Visible = False
            End If
            Me.Label1.Tag = 0
            Me.Label2.Tag = 0
            VBnetSQLSeverConnection()
            GetBarangMasuk(UserInfo.IdToko)
            Dim listbarang As List(Of Object) = GetJenisBarang()

            If listbarang.Count > 0 Then
                cmb_jenis_barang.DataSource = listbarang
                cmb_jenis_barang.DisplayMember = "nama_jenis"
                cmb_jenis_barang.ValueMember = "id_jenis"
            End If

            Dim listKondisi As List(Of Object) = GetKondisi()
            If listKondisi.Count > 0 Then
                cmb_kondisi.DataSource = listKondisi
                cmb_kondisi.DisplayMember = "nama_kondisi"
                cmb_kondisi.ValueMember = "id_kondisi"
            End If

            Dim listLokasi As List(Of Object) = GetLokasi()
            If listKondisi.Count > 0 Then
                cmb_lokasi.DataSource = listLokasi
                cmb_lokasi.DisplayMember = "nama_lokasi"
                cmb_lokasi.ValueMember = "id_lokasi"
            End If

            Dim listStatusBarang As List(Of Object) = GetStatusBarang()
            If listStatusBarang.Count > 0 Then
                cmb_status.DataSource = listStatusBarang
                cmb_status.DisplayMember = "nama_status"
                cmb_status.ValueMember = "id_status_barang"
            End If

            listJenis = listbarang
            listTipe = GetAllTipeJenisBarang()
            listLokasiCache = listLokasi
            listStatus = listStatusBarang
            listKondisiCache = listKondisi
            listDetailLokasiCache = GetAllLokasiDetail()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub data_barang_masuk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_barang_masuk.CellContentClick
        indexPenampung.Clear()
    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub cmb_jenis_barang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenis_barang.SelectedIndexChanged
        If cmb_jenis_barang.SelectedIndex <> -1 Then
            Try
                Dim idJenisBarang = cmb_jenis_barang.SelectedValue.id_jenis
            Catch ex As Exception
                Dim idJenisBarang = cmb_jenis_barang.SelectedValue
                Dim listTipe As List(Of Object) = GetTipeJenisBarang(idJenisBarang)
                If listTipe.Count > 0 Then
                    cmb_tipe_barang.DataSource = listTipe
                    cmb_tipe_barang.DisplayMember = "nama_tipe"
                    cmb_tipe_barang.ValueMember = "id_tipe"
                Else
                    cmb_tipe_barang.DataSource = New List(Of Object)
                End If
            End Try

        End If
    End Sub

    Private Sub cmb_tipe_barang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipe_barang.SelectedIndexChanged

    End Sub

    Private Sub cmb_lokasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_lokasi.SelectedIndexChanged
        If cmb_lokasi.SelectedIndex <> -1 Then
            Try
                Dim idLokasi = cmb_lokasi.SelectedValue.id_lokasi
            Catch ex As Exception
                Dim idLokasi = cmb_lokasi.SelectedValue
                Dim listLokasiDetail As List(Of Object) = GetLokasiDetail(idLokasi)
                If listLokasiDetail.Count > 0 Then
                    cmb_detail_lokasi.DataSource = listLokasiDetail
                    cmb_detail_lokasi.DisplayMember = "detail_lokasi"
                    cmb_detail_lokasi.ValueMember = "id_detail_lokasi"
                Else
                    cmb_detail_lokasi.DataSource = New List(Of Object)
                End If
            End Try

        End If
    End Sub

    Private Sub cbx_teruji_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_teruji.CheckedChanged
        If cbx_teruji.Checked = True Then
            cbx_tidak_teruji.Checked = False
        End If
    End Sub

    Private Sub cbx_tidak_teruji_CheckedChanged(sender As Object, e As EventArgs) Handles cbx_tidak_teruji.CheckedChanged
        If cbx_tidak_teruji.Checked = True Then
            cbx_teruji.Checked = False
        End If
    End Sub

    Private Sub data_barang_masuk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_barang_masuk.CellClick
        'Dim idBarang = data_barang_masuk.Rows(e.RowIndex)
        indexPenampung.Clear()
        Dim selectedIdBarangMasuk = data_barang_masuk.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangMasuk

            Dim idBarangMasuk = selectedItem.Index
            'Dim checkDuplicate As Object = listBarangMasukHandle.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            'If checkDuplicate Is Nothing Then
            Try
                Dim barang As Object = listBarangMasuk(idBarangMasuk)
                If barang IsNot Nothing Then

                    isDataReal.Clear()
                    'iRowIndex = Me.data_barang_masuk.SelectedCells.Item(i).RowIndex

                    indexPenampung.Add(idBarangMasuk)
                End If
            Catch ex As Exception

            End Try

            'End If

        Next selectedItem

        If indexPenampung.Count > 0 Then
            isDataReal.Clear()
            Dim barangMasuk = listBarangMasuk(indexPenampung(0))
            If barangMasuk.tested = 1 Then
                Me.cbx_teruji.Checked = True
            ElseIf barangMasuk.tested = 0 Then
                cbx_tidak_teruji.Checked = True
            End If

            Dim hargaBeli = Double.Parse(barangMasuk.harga_beli).ToString("N2")
            Dim hargaJual = Double.Parse(barangMasuk.harga_jual).ToString("N2")

            Me.txt_kode_barang.Text = barangMasuk.kd_barang
            Me.cmb_jenis_barang.SelectedValue = barangMasuk.id_jenis
            Me.cmb_tipe_barang.SelectedValue = barangMasuk.id_tipe
            Me.txt_serial.Text = barangMasuk.serial_number
            Me.cmb_kondisi.SelectedValue = barangMasuk.id_kondisi
            Me.cmb_status.SelectedValue = barangMasuk.id_status_barang
            Me.cmb_lokasi.SelectedValue = barangMasuk.id_lokasi
            Me.cmb_detail_lokasi.SelectedValue = barangMasuk.id_detail_lokasi
            Me.txt_harga_modal.Text = hargaBeli
            Me.txt_harga_barang.Text = hargaJual
            Me.txt_lisensi.Text = barangMasuk.licence
            Me.date_tgl_masuk.Value = barangMasuk.tgl_masuk
        End If
        'Dim iRowIndex As Integer
        'For i As Integer = 0 To Me.data_barang_masuk.SelectedCells.Count - 1
        '    isDataReal = Nothing
        '    iRowIndex = Me.data_barang_masuk.SelectedCells.Item(i).RowIndex
        '    Dim barangMasuk = listBarangMasuk(iRowIndex)
        '    If barangMasuk.tested = 1 Then
        '        Me.cbx_teruji.Checked = True
        '    ElseIf barangMasuk.tested = 0 Then
        '        cbx_tidak_teruji.Checked = True
        '    End If
        '    Me.txt_kode_barang.Text = barangMasuk.kd_barang
        '    Me.cmb_jenis_barang.SelectedValue = barangMasuk.id_jenis
        '    Me.cmb_tipe_barang.SelectedValue = barangMasuk.id_tipe
        '    Me.txt_serial.Text = barangMasuk.serial_number
        '    Me.cmb_kondisi.SelectedValue = barangMasuk.id_kondisi
        '    Me.cmb_status.SelectedValue = barangMasuk.id_status_barang
        '    Me.cmb_lokasi.SelectedValue = barangMasuk.id_lokasi
        '    Me.cmb_detail_lokasi.SelectedValue = barangMasuk.id_detail_lokasi
        '    Me.txt_harga_modal.Text = barangMasuk.harga_beli
        '    Me.txt_harga_barang.Text = barangMasuk.harga_jual
        '    Me.txt_lisensi.Text = barangMasuk.licence
        '    Me.date_tgl_masuk.Value = barangMasuk.tgl_masuk
        '    indexPenampung = iRowIndex
        'Next

    End Sub

    Private Sub data_barang_masuk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles data_barang_masuk.KeyPress

    End Sub

    Private Sub hapus_data_barang_masuk_Click(sender As Object, e As EventArgs) Handles hapus_data_barang_masuk.Click
        If indexPenampung.Count > 0 Then
            For Each index As Integer In indexPenampung
                listBarangMasuk.RemoveAt(index)
                Me.data_barang_masuk.Rows.RemoveAt(index)

            Next
            indexPenampung.Clear()
        Else
            Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                              "Hapus Data",
                              MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then
                Dim idbarangmasuk = Me.Label1.Tag
                Dim idBarang = Me.Label2.Tag
                For Each idbarangMsk As Integer In isDataReal
                    Dim barang = listBarangMasuk2.Where(Function(x) x.id_barang_masuk = idbarangMsk).FirstOrDefault()
                    If barang IsNot Nothing Then
                        DeleteBarangMasuk(barang.id_barang_masuk, barang.id_barang)
                        dt_barang_masuk.Rows.Clear()

                        Me.txt_kode_barang.Text = ""
                        Me.txt_serial.Text = ""
                        Me.txt_harga_modal.Text = ""
                        Me.txt_harga_barang.Text = ""
                        Me.txt_lisensi.Text = ""
                        Me.txt_catatan.Text = ""
                    End If

                Next
                GetBarangMasuk(UserInfo.IdToko)
                isDataReal.Clear()
            Else
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_file_excel.Text <> "" Then
            Dim listData = GetExcelSheetsName(txt_file_excel.Text)
            If listData.Count > 0 Then
                listBarangMasuk.AddRange(listData)
                For Each insertDataBarangMasuk As Object In listBarangMasuk

                    data_barang_masuk.Rows.Add(1)
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.nama_jenis
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_tipe
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.serial_number
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.nama_kondisi
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(4).Value = insertDataBarangMasuk.tested
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(5).Value = insertDataBarangMasuk.nama_lokasi
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.nama_detail_lokasi
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(7).Value = insertDataBarangMasuk.licence
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(8).Value = insertDataBarangMasuk.catatan
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(9).Value = insertDataBarangMasuk.nama_status_barang
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(10).Value = insertDataBarangMasuk.harga_beli
                    If UserInfo.IdLevel <> 1 Then
                        data_barang_masuk.Columns(10).Visible = False
                    ElseIf UserInfo.IdLevel = 1 Then
                        data_barang_masuk.Columns(10).Visible = True
                    End If
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(11).Value = insertDataBarangMasuk.harga_jual
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(12).Value = insertDataBarangMasuk.tgl_masuk
                    data_barang_masuk.Update()
                Next
            End If
        Else
            Dim tested As Integer
            Dim test As String
            If Me.cbx_teruji.Checked Then
                tested = 1
                test = "Teruji"
            ElseIf cbx_tidak_teruji.Checked Then
                tested = 0
                test = "Tidak Teruji"
            End If
            Dim idToko As String
            If UserInfo IsNot Nothing Then
                idToko = UserInfo.IdToko
            End If
            Dim kdTransaksi As String = RandomString(New Random)
            Dim hargaBeli As Decimal = Decimal.Parse(Me.txt_harga_modal.Text)
            Dim hargaJual As Decimal = Decimal.Parse(Me.txt_harga_barang.Text)
            Dim insertDataBarangMasuk = New With
                        {
                        .catatan = Me.txt_catatan.Text,
                        .id_barang = Me.Label2.Tag,
                         .id_barang_masuk = Me.Label1.Tag,
                         .kd_barang = Me.txt_kode_barang.Text,
                         .nama_jenis = Me.cmb_jenis_barang.SelectedItem.nama_jenis,
                         .id_jenis = Me.cmb_jenis_barang.SelectedValue,
                         .nama_tipe = Me.cmb_tipe_barang.SelectedItem.nama_tipe,
                         .id_tipe = Me.cmb_tipe_barang.SelectedValue,
                         .serial_number = Me.txt_serial.Text,
                         .nama_kondisi = Me.cmb_kondisi.SelectedItem.nama_kondisi,
                         .id_kondisi = Me.cmb_kondisi.SelectedValue,
                         .warna = "",
                         .nama_status_barang = Me.cmb_status.SelectedItem.nama_status,
                         .id_status_barang = Me.cmb_status.SelectedValue,
                         .tested = tested,
                         .nama_lokasi = Me.cmb_lokasi.SelectedItem.nama_lokasi,
                         .id_lokasi = Me.cmb_lokasi.SelectedValue,
                         .nama_detail_lokasi = Me.cmb_detail_lokasi.SelectedItem.detail_lokasi,
                         .id_detail_lokasi = Me.cmb_detail_lokasi.SelectedValue,
                         .id_toko = idToko,
                         .harga_beli = hargaBeli,
                         .harga_jual = hargaJual,
                         .stock = 0,
                         .licence = Me.txt_lisensi.Text,
                         .ios = Me.txt_catatan.Text,
                         .foto_barang = "",
                         .kd_transaksi_masuk = kdTransaksi,
                         .tgl_masuk = Me.date_tgl_masuk.Value,
                         .jumlah = 0
                        }
            'validationSerialNumberDB
            Dim barang = GetBarangMasukBySerialNumber(insertDataBarangMasuk.serial_number)
            If barang.Count > 0 And isDataReal.Count = 0 Then
                MsgBox("Serial Number Sudah ada!")
                Return
            End If

            'validationSerialNumberDataGrid
            Dim barangMasukCheck = listBarangMasuk.Where(Function(x) x.serial_number.ToLower() = insertDataBarangMasuk.serial_number.ToLower())
            If barangMasukCheck.Count > 0 And isDataReal.Count = 0 Then
                MsgBox("Serial Number Sudah ada!")
                Return
            End If
            If isDataReal.Count > 0 Then
                Dim idBarangMasuk As Integer = SimpanBarangMasuk(insertDataBarangMasuk)
                dt_barang_masuk.Rows.Clear()
                GetBarangMasuk(UserInfo.IdToko)
                Me.txt_kode_barang.Text = ""
                Me.txt_serial.Text = ""
                Me.txt_harga_modal.Text = ""
                Me.txt_harga_barang.Text = ""
                Me.txt_lisensi.Text = ""
                Me.txt_catatan.Text = ""
                isDataReal.Clear()
                MsgBox("Sukses!")
            Else
                If indexPenampung.Count > 0 Then
                    For Each index As Integer In indexPenampung
                        listBarangMasuk(index) = insertDataBarangMasuk

                        data_barang_masuk.Rows(index).Cells(0).Value = insertDataBarangMasuk.nama_jenis
                        data_barang_masuk.Rows(index).Cells(1).Value = insertDataBarangMasuk.nama_tipe
                        data_barang_masuk.Rows(index).Cells(2).Value = insertDataBarangMasuk.serial_number
                        data_barang_masuk.Rows(index).Cells(3).Value = insertDataBarangMasuk.nama_kondisi
                        data_barang_masuk.Rows(index).Cells(4).Value = test
                        data_barang_masuk.Rows(index).Cells(5).Value = insertDataBarangMasuk.nama_lokasi
                        data_barang_masuk.Rows(index).Cells(6).Value = insertDataBarangMasuk.nama_detail_lokasi
                        data_barang_masuk.Rows(index).Cells(7).Value = insertDataBarangMasuk.licence
                        data_barang_masuk.Rows(index).Cells(8).Value = insertDataBarangMasuk.catatan
                        data_barang_masuk.Rows(index).Cells(9).Value = insertDataBarangMasuk.nama_status_barang
                        data_barang_masuk.Rows(index).Cells(10).Value = insertDataBarangMasuk.harga_beli
                        If UserInfo.IdLevel <> 1 Then
                            data_barang_masuk.Columns(10).Visible = False
                        ElseIf UserInfo.IdLevel = 1 Then
                            data_barang_masuk.Columns(10).Visible = True
                        End If
                        data_barang_masuk.Rows(index).Cells(11).Value = insertDataBarangMasuk.harga_jual
                        data_barang_masuk.Rows(index).Cells(12).Value = insertDataBarangMasuk.tgl_masuk
                        data_barang_masuk.Update()

                    Next
                    indexPenampung.Clear()
                Else
                    listBarangMasuk.Add(insertDataBarangMasuk)
                    data_barang_masuk.Rows.Add(1)
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.nama_jenis
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_tipe
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.serial_number
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.nama_kondisi
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(4).Value = test
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(5).Value = insertDataBarangMasuk.nama_lokasi
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.nama_detail_lokasi
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(7).Value = insertDataBarangMasuk.licence
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(8).Value = insertDataBarangMasuk.catatan
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(9).Value = insertDataBarangMasuk.nama_status_barang
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(10).Value = insertDataBarangMasuk.harga_beli
                    If UserInfo.IdLevel <> 1 Then
                        data_barang_masuk.Columns(10).Visible = False
                    ElseIf UserInfo.IdLevel = 1 Then
                        data_barang_masuk.Columns(10).Visible = True
                    End If
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(11).Value = insertDataBarangMasuk.harga_jual
                    data_barang_masuk.Rows(data_barang_masuk.RowCount - 2).Cells(12).Value = insertDataBarangMasuk.tgl_masuk
                    data_barang_masuk.Update()
                End If

            End If
        End If


    End Sub

    Private Sub dt_barang_masuk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_masuk.CellClick
        isDataReal.Clear()
        Dim selectedIdBarangMasuk = dt_barang_masuk.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangMasuk

            Dim idBarangMasuk = selectedItem.Cells(13).Value
            'Dim checkDuplicate As Object = listBarangMasukHandle.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            'If checkDuplicate Is Nothing Then
            Dim barang As Object = listBarangMasuk2.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            If barang IsNot Nothing Then
                indexPenampung.Clear()
                isDataReal.Add(barang.id_barang_masuk)
            End If
            'End If

        Next selectedItem

        'Dim idBarang = dt_barang_masuk.Rows(e.RowIndex).Cells(13).Value.ToString
        'Dim barangMasuk = GetBarangMasukById(idBarang)

        If isDataReal.Count > 0 Then
            indexPenampung.Clear()
            'isDataReal = 1
            Dim barangMasuk = GetBarangMasukById(isDataReal(0))
            Me.Label1.Tag = barangMasuk(0).id_barang_masuk
            Me.Label2.Tag = barangMasuk(0).id_barang
            If barangMasuk(0).tested = 1 Then
                Me.cbx_teruji.Checked = True
            ElseIf barangMasuk(0).tested = 0 Then
                cbx_tidak_teruji.Checked = True
            End If
            Dim hargaBeli = Double.Parse(barangMasuk(0).harga_beli).ToString("N2")
            Dim hargaJual = Double.Parse(barangMasuk(0).harga_jual).ToString("N2")
            Me.txt_kode_barang.Text = barangMasuk(0).kd_barang
            Me.cmb_jenis_barang.SelectedValue = barangMasuk(0).id_jenis
            Me.cmb_tipe_barang.SelectedValue = barangMasuk(0).id_tipe
            Me.txt_serial.Text = barangMasuk(0).serial_number
            Me.cmb_kondisi.SelectedValue = barangMasuk(0).id_kondisi
            Me.cmb_status.SelectedValue = barangMasuk(0).id_status_barang
            Me.cmb_lokasi.SelectedValue = barangMasuk(0).id_lokasi
            Me.cmb_detail_lokasi.SelectedValue = barangMasuk(0).id_detail_lokasi
            Me.txt_harga_modal.Text = hargaBeli
            Me.txt_harga_barang.Text = hargaJual
            Me.txt_lisensi.Text = barangMasuk(0).licence
            Me.date_tgl_masuk.Value = barangMasuk(0).tgl_masuk

        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.MenuStrip1.Tag = UserInfo
        Me.cmb_jenis_barang.Text = ""
        Me.cmb_tipe_barang.Text = ""
        Me.cmb_detail_lokasi.Text = ""
        Me.cmb_kondisi.Text = ""
        Me.cmb_lokasi.Text = ""
        Me.cmb_status.Text = ""
        Me.txt_kode_barang.Text = ""
        Me.txt_serial.Text = ""
        Me.txt_harga_modal.Text = ""
        Me.txt_harga_barang.Text = ""
        Me.txt_lisensi.Text = ""
        Me.txt_catatan.Text = ""
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub dt_barang_masuk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_masuk.CellContentClick
        isDataReal.Clear()
    End Sub

    Private Sub pict_logo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dt_barang_masuk_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_masuk.CellEndEdit

    End Sub

    Private Sub txt_harga_modal_TextChanged(sender As Object, e As EventArgs) Handles txt_harga_modal.TextChanged
        If Len(txt_harga_modal.Text) > 0 Then
            txt_harga_modal.Text = FormatNumber(CDbl(txt_harga_modal.Text), 0)
            Dim x As Integer = txt_harga_modal.SelectionStart.ToString
            If x = 0 Then
                txt_harga_modal.SelectionStart = Len(txt_harga_modal.Text)
                txt_harga_modal.SelectionLength = 0
            Else
                txt_harga_modal.SelectionStart = x
                txt_harga_modal.SelectionLength = 0
            End If
        End If
    End Sub

    Private Sub txt_harga_barang_TextChanged(sender As Object, e As EventArgs) Handles txt_harga_barang.TextChanged
        If Len(txt_harga_barang.Text) > 0 Then
            txt_harga_barang.Text = FormatNumber(CDbl(txt_harga_barang.Text), 0)
            Dim x As Integer = txt_harga_barang.SelectionStart.ToString
            If x = 0 Then
                txt_harga_barang.SelectionStart = Len(txt_harga_barang.Text)
                txt_harga_barang.SelectionLength = 0
            Else
                txt_harga_barang.SelectionStart = x
                txt_harga_barang.SelectionLength = 0
            End If
        End If

    End Sub

    Private Sub dt_barang_masuk_CellContextMenuStripNeeded(sender As Object, e As DataGridViewCellContextMenuStripNeededEventArgs) Handles dt_barang_masuk.CellContextMenuStripNeeded

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            txt_file_excel.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub cmb_detail_lokasi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_detail_lokasi.SelectedIndexChanged

    End Sub
End Class