Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization

Public Class transaksi_maintenance
    Dim ppnNominal As Decimal = 0
    Dim clientKodeSelect As String
    Public Property UserInfo As Object
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim listJenisMaintance As New List(Of Object)
    Dim indexPenampung As New List(Of Integer)
    Dim isDataReal As New List(Of Integer)
    Dim listBarangMasuk As New List(Of Object)
    Dim listBarangMasuk2 As New List(Of Object)
    Dim clients As New List(Of Object)
    Dim listBarangMasukHandle As New List(Of Object)
    Dim listBarangKeluarFix As New List(Of Object)
    Dim listBarangKeluarFixHandle As New List(Of Object)
    Dim triggerTambahBarangKeluar As Boolean = False
    Dim isSelectedTipeJenis As Integer = 0
    Dim isCetakInvoice As Boolean = False
    Dim isCetakTandaTangan As Boolean = False
    Dim isCetakKwitansi As Boolean = False

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
    Public Function GetJenisMaintance()
        listJenisMaintance.Clear()
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_jenis_maintenance WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim jenis As New With {
                            .nama_jenis_maintenance = reader("nama_jenis_maintenance"),
                            .harga = reader("harga"),
                            .id_jenis_maintenance = reader("id_jenis_maintenance")
                            }
            result.Add(jenis)
            listJenisMaintance.Add(jenis)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetClient()
        clients.Clear()
        Dim result As New List(Of Object)
        'result.Add(jenisREsult)
        Dim query As String = "SELECT * FROM tbl_client WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim client As New With {
                            .id_client = reader("id_client"),
                            .nama_client = reader("nama_client"),
                            .company_name = reader("company_name"),
                              .alamat_client = reader("alamat_client"),
                            .kota_client = reader("kota_client"),
                             .kdpos_client = reader("kdpos_client"),
                             .kd_client = reader("kd_client")
                            }
            result.Add(client)
            clients.Add(client)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Function GetLastIdTransaksi() As List(Of Integer)
        Dim result As New List(Of Integer)
        Dim query As String = "SELECT TOP (1) id_transaksi FROM tbl_transaksi WHERE is_active = 1 ORDER BY id_transaksi desc"
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read

            Dim idTransaksi As Integer = reader("id_transaksi")

            result.Add(idTransaksi)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function
    Public Function LoadTransaksiMaintance()
        Try
            Me.txt_harga_total.Text = 0
            Me.txt_harga_akhir.Text = 0
            Me.txt_subtotal.Text = 0

            Me.txt_shiphand.Text = 0
            Me.txt_ppn.Text = 0

            'isSelectedTipeJenis = 0
            'Dim kdTransaksi As String = RandomString(New Random)
            'Me.txt_kd_transaksi.Text = kdTransaksi
            Me.txt_kd_transaksi.Enabled = False
            VBnetSQLSeverConnection()
            Dim listbarang As List(Of Object) = GetJenisMaintance()
            If listbarang.Count > 0 Then
                cmb_jenis_barang.DataSource = listbarang
                cmb_jenis_barang.DisplayMember = "nama_jenis_maintenance"
                cmb_jenis_barang.ValueMember = "id_jenis_maintenance"
            End If

            Dim listClient As List(Of Object) = GetClient()
            If listClient.Count > 0 Then
                cmb_client.DataSource = listClient
                cmb_client.DisplayMember = "nama_client"
                cmb_client.ValueMember = "id_client"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'CONN.Close()
        End Try
    End Function
    Function GenerateKdtransaksi(idTransaksi As String, kdclient As String, year As Integer) As String
        If (idTransaksi.Length = 1) Then
            idTransaksi = "0" + idTransaksi
        End If
        Dim resultKdTransaksi As String = idTransaksi + "/" + kdclient + "/" + year.ToString
        Return resultKdTransaksi
    End Function
    Function SimpanMaintance(barangKeluar As Object, index As Integer)
        Dim idToko
        Dim userlogin As String = ""
        Dim barangKeluarId As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
            idToko = UserInfo.IdToko.ToString
        Else
            idToko = "NULL"
        End If
        Try
            If index = 0 Then
                Dim queryTblBarangKeluarTransaksi As String = " INSERT INTO tbl_transaksi (
                                    kd_transaksi_keluar,
                                    harga_total,
                                    diskon,
                                    harga_akhir,
                                    persen_ppn,
                                    nominal_ppn,
                                    shipping_handling,
                                    subtotal,
                                    id_client,
                                    alamat_pengiriman,
                                    kota_pengiriman,
                                    kdpos_pengiriman,  
                                    company_name,
                                    tgl_keluar,
                                    shipto_nama,
                                    shipto_alamat,
                                    shipto_kota,
                                    shipto_kdpos,
                                    total_barang,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + barangKeluar.kd_transaksi_keluar + "',
                                    " + barangKeluar.harga_total.ToString + ",
                                    " + barangKeluar.diskon.ToString + ",
                                    " + barangKeluar.harga_akhir.ToString + ",
                                    " + barangKeluar.persen_ppn.ToString + ",
                                    " + barangKeluar.nominal_ppn.ToString + ",
                                    " + barangKeluar.shipping_handling.ToString + ",
                                    " + barangKeluar.subtotal.ToString + ",
                                    " + barangKeluar.id_client.ToString + ",
                                    '" + barangKeluar.alamat_pengiriman + "',
                                    '" + barangKeluar.kota_pengiriman + "',
                                    '" + barangKeluar.kdpos_pengiriman + "',
                                     '" + barangKeluar.company_name + "',
                                     CAST('" + DateTime.Parse(barangKeluar.tgl_maintenance).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),                                  
                                    '" + barangKeluar.shipto_nama + "',
                                    '" + barangKeluar.shipto_alamat + "',
                                    '" + barangKeluar.shipto_kota + "',
                                    '" + barangKeluar.shipto_kdpos + "', 
                                    " + barangKeluar.total_barang.ToString + ",
                                    '" + userlogin + "',
                                     CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "

                cmd.CommandText = queryTblBarangKeluarTransaksi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                barangKeluarId = cmd.ExecuteScalar()
                'reader = cmd.ExecuteReader()

                CONN.Close()
            End If
            Dim queryTblBarangKeluar As String = " INSERT INTO tbl_maintenance (
                                    kd_transaksi_maintenance,
                                    id_jenis_maintenance,
                                    id_alasan,
                                    id_toko,
                                    tgl_maintenance,
                                    periode_maintenance,
                                    maintenance_type,
                                    maintenance_exp,           
                                    id_client,
                                    harga,
                                    jumlah,
                                    id_status_barang,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + barangKeluar.kd_transaksi_maintenance + "',
                                    " + barangKeluar.id_jenis_maintenance.ToString + ",
                                    " + barangKeluar.id_alasan.ToString + ",
                                     " + idToko + ",
                                     CAST('" + DateTime.Parse(barangKeluar.tgl_maintenance).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),                                  
                                     " + barangKeluar.periode_maintenance.ToString + ",
                                     '" + barangKeluar.maintenance_type + "',
                                      
                                    "
            If barangKeluar.maintenance_exp = "NULL" Then
                queryTblBarangKeluar = queryTblBarangKeluar + "NULL,"

            Else
                queryTblBarangKeluar = queryTblBarangKeluar + "CAST('" + DateTime.Parse(barangKeluar.maintenance_exp).ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),"
            End If
            queryTblBarangKeluar = queryTblBarangKeluar + " " + barangKeluar.id_client.ToString + ",
                                        " + barangKeluar.harga.ToString + ",
                                    " + barangKeluar.jumlah.ToString + ",
                                        " + barangKeluar.id_status_barang.ToString + ",
                                    '" + userlogin + "',
                                     CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "
            cmd.CommandText = queryTblBarangKeluar
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            barangKeluarId = cmd.ExecuteScalar()
            'reader = cmd.ExecuteReader()

            CONN.Close()

            'UpdateStatusBarang(barangKeluar.id_status_barang, userlogin, barangKeluar.id_barang)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'GetBarangMasuk()
            'Me.Label1.Tag = 0
            'Me.Label2.Tag = 0
        End Try
        Return barangKeluarId

    End Function
    Private Sub transaksi_maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTransaksiMaintance()
    End Sub

    Private Sub cmb_jenis_barang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenis_barang.SelectedIndexChanged
        If cmb_jenis_barang.SelectedIndex <> -1 Then
            Try
                Dim idJenisBarang = cmb_jenis_barang.SelectedValue.id_jenis_maintenance
                Dim jenisMaintance = listJenisMaintance.Where(Function(x) x.id_jenis_maintenance = idJenisBarang).FirstOrDefault()
                Dim harga = Val(Double.Parse(jenisMaintance.harga))
                harga_maintance.Text = harga.ToString("N2")
            Catch ex As Exception
                Dim idJenisBarang = cmb_jenis_barang.SelectedValue
                Dim jenisMaintance = listJenisMaintance.Where(Function(x) x.id_jenis_maintenance = idJenisBarang).FirstOrDefault()
                Dim harga = Val(Double.Parse(jenisMaintance.harga))
                harga_maintance.Text = harga.ToString("N2")
            End Try

        End If
    End Sub
    Public Function MappingToDataGrid(listBarangKeluarFix As List(Of Object))
        For Each barangMasukHandle As Object In listBarangKeluarFix

            dt_barang_keluar_fix.Rows.Add(1)

            dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(0).Value = barangMasukHandle.nama_jenis_maintenance
            dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(1).Value = barangMasukHandle.harga
            dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(2).Value = barangMasukHandle.periode_maintenance
            dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(3).Value = barangMasukHandle.maintenance_type
            dt_barang_keluar_fix.Rows(dt_barang_keluar_fix.RowCount - 2).Cells(4).Value = barangMasukHandle.maintenance_exp

            dt_barang_keluar_fix.Update()

            Dim hargaTotal = Val(Double.Parse(Me.txt_harga_total.Text)) + Val(Double.Parse(barangMasukHandle.harga))
            Me.txt_harga_total.Text = hargaTotal.ToString("N2")

            Dim hargaAkhir = Val(Double.Parse(Me.txt_harga_total.Text))
            Me.txt_harga_akhir.Text = hargaAkhir.ToString("N2")

            Dim subTotal = Val(Double.Parse(Me.txt_harga_total.Text))
            Me.txt_subtotal.Text = subTotal.ToString("N2")


            'Index = Index + 1

        Next
    End Function

    Private Sub cmb_client_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_client.SelectedIndexChanged
        Try
            Dim client As Object = clients.Where(Function(x) x.id_client = cmb_client.SelectedValue.id_client).FirstOrDefault()

            If client IsNot Nothing Then
                Dim companyName As String
                Try
                    companyName = client.company_name
                Catch ex As Exception
                    companyName = ""
                End Try
                Me.txt_alamat.Text = client.alamat_client
                Me.txt_kota.Text = client.kota_client
                Me.txt_kdpos.Text = client.kdpos_client
                Me.txt_alamat_ship.Text = client.alamat_client
                Me.txt_kota_ship.Text = client.kota_client
                Me.txt_kdpos_ship.Text = client.kdpos_client
                Me.txt_client_ship.Text = cmb_client.SelectedValue.nama_client
                clientKodeSelect = client.kd_client.ToString
                Me.txt_pt.Text = companyName
            End If
        Catch ex As Exception
            Dim client As Object = clients.Where(Function(x) x.id_client = cmb_client.SelectedValue).FirstOrDefault()
            If client IsNot Nothing Then
                Dim companyName As String
                Try
                    companyName = client.company_name
                Catch c As Exception
                    companyName = ""
                End Try
                Me.txt_alamat.Text = client.alamat_client
                Me.txt_kota.Text = client.kota_client
                Me.txt_kdpos.Text = client.kdpos_client
                Me.txt_alamat_ship.Text = client.alamat_client
                Me.txt_kota_ship.Text = client.kota_client
                Me.txt_kdpos_ship.Text = client.kdpos_client
                Me.txt_client_ship.Text = cmb_client.SelectedText
                clientKodeSelect = client.kd_client.ToString
                Me.txt_pt.Text = companyName
            End If
        End Try

        Dim lastIdTransaksi As Integer = 0
        Dim idTransaksi = GetLastIdTransaksi()
        If idTransaksi.Count > 0 Then
            lastIdTransaksi = idTransaksi(0) + 1
        End If
        Dim kdTransaksi = GenerateKdtransaksi(lastIdTransaksi.ToString, clientKodeSelect, DateTime.Now.Year)
        Me.txt_kd_transaksi.Text = kdTransaksi

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim barang = New With
              {
               .nama_jenis_maintenance = cmb_jenis_barang.SelectedItem.nama_jenis_maintenance,
                  .id_jenis_maintenance = cmb_jenis_barang.SelectedValue,
          .harga = Decimal.Parse(harga_maintance.Text),
          .tgl_maintenance = date_tgl_keluar.Value,
          .kd_transaksi_keluar = "",
          .kd_transaksi_maintenance = "",
          .id_alasan = 0,
          .id_toko = Nothing,
          .periode_maintenance = Nothing,
          .maintenance_type = "",
          .maintenance_exp = Nothing,
          .id_client = cmb_client.SelectedValue,
          .id_status_barang = 0,
          .jumlah = 0,
          .harga_total = 0,
          .diskon = 0,
          .harga_akhir = 0,
          .alamat_pengiriman = "",
          .kota_pengiriman = "",
          .kdpos_pengiriman = "",
          .total_barang = 0,
          .shipto_nama = "",
          .shipto_alamat = "",
              .shipto_kota = "",
              .shipto_kdpos = "",
                .persen_ppn = 0,
              .nominal_ppn = 0,
              .shipping_handling = 0,
              .subtotal = 0,
              .company_name = "",
              .index = 0
              }
        If indexPenampung.Count > 0 Then
            listBarangKeluarFix(indexPenampung(0)).nama_jenis_maintenance = barang.nama_jenis_maintenance
            listBarangKeluarFix(indexPenampung(0)).id_jenis_maintenance = barang.id_jenis_maintenance
            listBarangKeluarFix(indexPenampung(0)).harga = barang.harga
        Else
            listBarangKeluarFix.Add(barang)
        End If


        dt_barang_keluar_fix.Rows.Clear()

        MappingToDataGrid(listBarangKeluarFix)
    End Sub

    Private Sub dt_barang_keluar_fix_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar_fix.CellContentClick
        listBarangKeluarFixHandle.Clear()
        indexPenampung.Clear()
    End Sub

    Private Sub dt_barang_keluar_fix_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar_fix.CellClick
        listBarangKeluarFixHandle.Clear()
        Dim selectedIdBarangKeluar = dt_barang_keluar_fix.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangKeluar
            Dim idBarangMasuk = selectedItem.Index
            Dim barang As Object = listBarangKeluarFix(idBarangMasuk)
            barang.index = idBarangMasuk
            listBarangKeluarFixHandle.Add(barang)

        Next selectedItem

        If listBarangKeluarFixHandle.Count > 0 Then
            indexPenampung.Add(listBarangKeluarFixHandle(0).index)
            cmb_jenis_barang.SelectedValue = listBarangKeluarFixHandle(0).id_jenis_maintenance
            Dim harga = Val(Double.Parse(listBarangKeluarFix(0).harga))
            harga_maintance.Text = harga.ToString("N2")
        End If
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Me.txt_harga_total.Text = 0
        Me.txt_harga_akhir.Text = 0
        For Each item As Object In listBarangKeluarFixHandle
            If item IsNot Nothing Then

                Dim deleteData As Object = listBarangKeluarFix.Where(Function(x) x.index = item.index).FirstOrDefault()
                listBarangKeluarFix.Remove(deleteData)
            End If
        Next
        dt_barang_keluar_fix.Rows.Clear()

        MappingToDataGrid(listBarangKeluarFix)
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim index = 0
        For Each insertDataBarangKeluar As Object In listBarangKeluarFix
            Dim diskon = 0
            Dim idToko As String
            Dim maintenance_type As String = ""
            Dim periode_maintenance = "NULL"
            Dim maintenance_exp = "NULL"

            If insertDataBarangKeluar.periode_maintenance IsNot Nothing Then
                periode_maintenance = insertDataBarangKeluar.periode_maintenance
            End If
            If insertDataBarangKeluar.maintenance_type <> "" Then
                maintenance_type = insertDataBarangKeluar.maintenance_type
            End If
            If insertDataBarangKeluar.maintenance_exp IsNot Nothing Then
                maintenance_exp = insertDataBarangKeluar.maintenance_exp
            End If
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                idToko = MenuUtama.MenuStrip1.Tag.IdToko
            End If
            If Me.txt_diskon.Text <> "" Then
                diskon = Decimal.Parse(Me.txt_diskon.Text)
            End If
            insertDataBarangKeluar.kd_transaksi_keluar = Me.txt_kd_transaksi.Text
            insertDataBarangKeluar.kd_transaksi_maintenance = Me.txt_kd_transaksi.Text
            insertDataBarangKeluar.id_client = Me.cmb_client.SelectedValue
            insertDataBarangKeluar.id_toko = idToko
            insertDataBarangKeluar.tgl_maintenance = Me.date_tgl_keluar.Value
            insertDataBarangKeluar.periode_maintenance = periode_maintenance
            insertDataBarangKeluar.maintenance_type = maintenance_type
            insertDataBarangKeluar.maintenance_exp = maintenance_exp
            insertDataBarangKeluar.id_client = Me.cmb_client.SelectedValue
            'insertDataBarangKeluar.jumlah = reader("jumlah"),
            insertDataBarangKeluar.harga_total = Decimal.Parse(Me.txt_harga_total.Text)
            insertDataBarangKeluar.diskon = diskon
            insertDataBarangKeluar.harga_akhir = Decimal.Parse(Me.txt_harga_akhir.Text)
            insertDataBarangKeluar.alamat_pengiriman = Me.txt_alamat.Text
            insertDataBarangKeluar.kota_pengiriman = Me.txt_kota.Text
            insertDataBarangKeluar.kdpos_pengiriman = Me.txt_kdpos.Text
            insertDataBarangKeluar.total_barang = listBarangKeluarFix.Count
            insertDataBarangKeluar.id_status_barang = 5
            insertDataBarangKeluar.shipto_nama = Me.txt_client_ship.Text
            insertDataBarangKeluar.shipto_alamat = Me.txt_alamat_ship.Text
            insertDataBarangKeluar.shipto_kota = Me.txt_kota_ship.Text
            insertDataBarangKeluar.shipto_kdpos = Me.txt_kdpos_ship.Text
            insertDataBarangKeluar.persen_ppn = Me.txt_ppn.Text
            insertDataBarangKeluar.nominal_ppn = ppnNominal
            insertDataBarangKeluar.shipping_handling = Decimal.Parse(Me.txt_shiphand.Text)
            insertDataBarangKeluar.subtotal = Decimal.Parse(Me.txt_subtotal.Text)
            insertDataBarangKeluar.company_name = Me.txt_pt.Text
            SimpanMaintance(insertDataBarangKeluar, index)
            index = index + 1
        Next
        index = 0
        'dt_barang_masuk.Rows.Clear()
        dt_barang_keluar_fix.Rows.Clear()
        listBarangKeluarFix.Clear()
        listBarangMasuk.Clear()
        invoice_cetak.KdTransaksi = Me.txt_kd_transaksi.Text
        cetak_kwitansi_barang.KdTransaksi = Me.txt_kd_transaksi.Text
        'Dim kdTransaksi As String = RandomString(New Random)
        Me.txt_kd_transaksi.Text = ""
        Me.txt_harga_total.Text = 0
        Me.txt_harga_akhir.Text = 0
        Me.txt_diskon.Text = 0
        indexPenampung.Clear()
        MsgBox("Sukses Data Tersimpan!")

        Me.txt_harga_total.Text = 0
        Me.txt_harga_akhir.Text = 0
        Me.txt_subtotal.Text = 0

        Me.txt_shiphand.Text = 0
        Me.txt_ppn.Text = 0


        Dim listbarang As List(Of Object) = GetJenisMaintance()
        If listbarang.Count > 0 Then
            cmb_jenis_barang.DataSource = listbarang
            cmb_jenis_barang.DisplayMember = "nama_jenis_maintenance"
            cmb_jenis_barang.ValueMember = "id_jenis_maintenance"
        End If

        Dim listClient As List(Of Object) = GetClient()
        If listClient.Count > 0 Then
            cmb_client.DataSource = listClient
            cmb_client.DisplayMember = "nama_client"
            cmb_client.ValueMember = "id_client"
        End If

    End Sub

    Private Sub dt_barang_keluar_fix_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dt_barang_keluar_fix.CellValueChanged
        listBarangKeluarFixHandle.Clear()

        Dim changeHargaJualBarangKeluar = dt_barang_keluar_fix.SelectedCells

        Dim index = 0
        For Each selectedItem As DataGridViewCell In changeHargaJualBarangKeluar
            If selectedItem.ColumnIndex = 2 Then
                If selectedItem.Value IsNot Nothing Then
                    If System.Text.RegularExpressions.Regex.IsMatch(selectedItem.Value, "[  ^ 0-9]") Then
                        listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance = selectedItem.Value

                        If listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance IsNot Nothing Then

                            If listBarangKeluarFix(selectedItem.RowIndex).maintenance_type = "Hari" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddDays(listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance)
                                listBarangKeluarFix(selectedItem.RowIndex).maintenance_exp = calculateGaransiExp

                            ElseIf listBarangKeluarFix(selectedItem.RowIndex).maintenance_type = "Bulan" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddMonths(listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance)
                                listBarangKeluarFix(selectedItem.RowIndex).maintenance_exp = calculateGaransiExp

                            ElseIf listBarangKeluarFix(selectedItem.RowIndex).maintenance_type = "Tahun" Then
                                Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                                Dim calculateGaransiExp As DateTime = tglkeluar.AddYears(listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance)
                                listBarangKeluarFix(selectedItem.RowIndex).maintenance_exp = calculateGaransiExp
                            End If
                        End If



                        If index = 0 Then
                            dt_barang_keluar_fix.Rows.Clear()
                        End If
                        Me.txt_harga_total.Text = 0
                        Me.txt_harga_akhir.Text = 0
                        MappingToDataGrid(listBarangKeluarFix)

                    ElseIf selectedItem.Value = "" Then
                        'MsgBox("harga Jual Tidak Boleh Kosong")
                    Else
                        MsgBox("garansi hanya bisa number")
                    End If
                Else
                    MsgBox("garansi tidak boleh kosong")
                End If
            ElseIf selectedItem.ColumnIndex = 3 Then
                If selectedItem.Value IsNot Nothing Then
                If selectedItem.Value <> "" Then

                    listBarangKeluarFix(selectedItem.RowIndex).maintenance_type = selectedItem.Value

                    If listBarangKeluarFix(selectedItem.RowIndex).maintenance_type <> "" Then
                        If listBarangKeluarFix(selectedItem.RowIndex).maintenance_type = "Hari" Then
                            Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                            Dim calculateGaransiExp As DateTime = tglkeluar.AddDays(listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance)
                            listBarangKeluarFix(selectedItem.RowIndex).maintenance_exp = calculateGaransiExp

                        ElseIf listBarangKeluarFix(selectedItem.RowIndex).maintenance_type = "Bulan" Then
                            Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                            Dim calculateGaransiExp As DateTime = tglkeluar.AddMonths(listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance)
                            listBarangKeluarFix(selectedItem.RowIndex).maintenance_exp = calculateGaransiExp

                        ElseIf listBarangKeluarFix(selectedItem.RowIndex).maintenance_type = "Tahun" Then
                            Dim tglkeluar As DateTime = Me.date_tgl_keluar.Value
                            Dim calculateGaransiExp As DateTime = tglkeluar.AddYears(listBarangKeluarFix(selectedItem.RowIndex).periode_maintenance)
                            listBarangKeluarFix(selectedItem.RowIndex).maintenance_exp = calculateGaransiExp

                        End If
                    End If
                    If index = 0 Then
                        dt_barang_keluar_fix.Rows.Clear()
                    End If

                        Me.txt_harga_total.Text = 0
                        Me.txt_harga_akhir.Text = 0
                        MappingToDataGrid(listBarangKeluarFix)

                ElseIf selectedItem.Value = "" Then
                    'MsgBox("harga Jual Tidak Boleh Kosong")
                Else
                    'MsgBox("harga Jual hanya bisa number")
                End If
            Else
                'MsgBox("harga Jual tidak boleh kosong")
            End If
            End If
        Next selectedItem
    End Sub

    Private Sub txt_diskon_TextChanged(sender As Object, e As EventArgs) Handles txt_diskon.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txt_diskon.Text, "[  ^ 0-9]") Then
            Dim hargaAkhir = Val(Double.Parse(Me.txt_harga_total.Text)) - Val(Double.Parse(Me.txt_diskon.Text))
            Me.txt_harga_akhir.Text = hargaAkhir.ToString("N2")
            Dim subTotal = Val(Double.Parse(txt_harga_akhir.Text)) + Val(Double.Parse(ppnNominal)) + Val(Double.Parse(txt_shiphand.Text))
            Me.txt_subtotal.Text = subTotal.ToString("N2")

            Me.txt_diskon.Text = Double.Parse(Me.txt_diskon.Text).ToString("N2")
        ElseIf txt_diskon.Text = "" Then
            Me.txt_harga_akhir.Text = Double.Parse(Me.txt_harga_total.Text).ToString("N2")
        Else
            MsgBox("Diskon hanya bisa numbering")
        End If
    End Sub

    Private Sub txt_ppn_TextChanged(sender As Object, e As EventArgs) Handles txt_ppn.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txt_ppn.Text, "[  ^ 0-9]") Then
            Dim hargaAkhir = Double.Parse(Me.txt_harga_akhir.Text)
            Dim ppnCalculate = Val(Double.Parse(txt_ppn.Text)) / 100
            Dim ppn = Val(ppnCalculate) * Val(hargaAkhir)
            Dim subtotal = Val(Double.Parse(txt_harga_akhir.Text)) + Val(ppn) + Val(Double.Parse(txt_shiphand.Text))
            ppnNominal = ppn
            Me.txt_subtotal.Text = subtotal.ToString("N2")
            Me.txt_ppn_nominal.Text = ppnNominal.ToString("N2")
        ElseIf txt_ppn.Text = "" Then
            ppnNominal = 0
            Me.txt_ppn.Text = 0
        Else
            ppnNominal = 0
            MsgBox("PPN hanya bisa numbering")
            Me.txt_ppn.Text = 0
        End If
    End Sub

    Private Sub txt_shiphand_TextChanged(sender As Object, e As EventArgs) Handles txt_shiphand.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(txt_shiphand.Text, "[  ^ 0-9]") Then
            Dim subTotal = Val(Double.Parse(txt_harga_akhir.Text)) + Val(ppnNominal) + Val(Double.Parse(txt_shiphand.Text))
            Me.txt_subtotal.Text = subTotal.ToString("N2")
            Me.txt_shiphand.Text = Double.Parse(Me.txt_shiphand.Text).ToString("N2")
        ElseIf txt_shiphand.Text = "" Then
            txt_shiphand.Text = Double.Parse(0).ToString("N2")
            Dim subTotal = Val(Double.Parse(txt_harga_akhir.Text)) + Val(ppnNominal) + Val(Double.Parse(txt_shiphand.Text))
            Me.txt_subtotal.Text = subTotal.ToString("N2")
        Else
            txt_shiphand.Text = Double.Parse(0).ToString("N2")
            MsgBox("PPN hanya bisa numbering")
            Dim subTotal = Val(Double.Parse(txt_harga_akhir.Text)) + Val(ppnNominal) + Val(Double.Parse(txt_shiphand.Text))
            Me.txt_subtotal.Text = subTotal.ToString("N2")
        End If
    End Sub

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        invoice_cetak.Show()
    End Sub

    Private Sub btn_kwitansi_Click(sender As Object, e As EventArgs) Handles btn_kwitansi.Click
        cetak_kwitansi_barang.Show()
    End Sub

    Private Sub btn_tanda_terima_Click(sender As Object, e As EventArgs) Handles btn_tanda_terima.Click
        cetak_tanda_terima.Show()
    End Sub
End Class