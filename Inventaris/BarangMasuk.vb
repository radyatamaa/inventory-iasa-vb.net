Imports System.Configuration
Imports System.Data.SqlClient

Public Class BarangMasuk
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
    Function SimpanBarangMasuk(barangMasuk As Object)
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
                                    " + barangMasuk.id_toko.ToString + ",
                                    " + barangMasuk.harga_beli.ToString + ",
                                    " + barangMasuk.harga_jual.ToString + ",
                                    " + barangMasuk.stock.ToString + ",
                                    '" + barangMasuk.licence + "',
                                    '" + barangMasuk.ios + "',
                                    '" + barangMasuk.foto_barang + "',
                                    '" + MenuStrip1.Tag.Username + "',
                                    '" + DateTime.Now + "',
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
                                    '" + barangMasuk.tgl_masuk + "',
                                    " + barangMasuk.id_toko.ToString + ",
                                    " + barangMasuk.jumlah.ToString + ",
                                    '" + MenuStrip1.Tag.Username + "',
                                    '" + DateTime.Now + "',
                                    " + 1.ToString + "
                                    ) "

            cmd.CommandText = queryTblBarangMasuk
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            reader = cmd.ExecuteReader()

            CONN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("Sukses!")
        End Try


    End Function
    Function GetBarangMasuk()
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_barang_masuk bm
                                    INNER JOIN tbl_barang b ON bm.id_barang = b.id
                                    WHERE bm.is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim toko As New With {
                            .IdToko = reader("id_toko"),
                            .NamaToko = reader("nama_toko").ToString,
                            .LogoToko = reader("logo_toko").ToString
                            }
            result.Add(toko)
            'handle returned value before next loop here
        End While
        CONN.Close()

        Return result
    End Function
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim tested As Integer
        If Me.cbx_teruji.Checked Then
            tested = 1
        ElseIf cbx_tidak_teruji.Checked Then
            tested = 0
        End If
        Dim insertDataBarangMasuk = New With
                {
                 .kd_barang = Me.txt_kode_barang.Text,
                 .id_jenis = Me.cmb_jenis_barang.SelectedValue,
                 .id_tipe = Me.cmb_tipe_barang.SelectedValue,
                 .serial_number = Me.txt_serial.Text,
                 .id_kondisi = Me.cmb_kondisi.SelectedValue,
                 .warna = "",
                 .id_status_barang = Me.cmb_status.SelectedValue,
                 .tested = tested,
                 .id_lokasi = Me.cmb_lokasi.SelectedValue,
                 .id_detail_lokasi = Me.cmb_detail_lokasi.SelectedValue,
                 .id_toko = MenuStrip1.Tag.IdToko,
                 .harga_beli = Me.txt_harga_modal.Text,
                 .harga_jual = Me.txt_harga_barang.Text,
                 .stock = 0,
                 .licence = Me.txt_lisensi.Text,
                 .ios = "",
                 .foto_barang = "",
                 .kd_transaksi_masuk = "adjaskld",
                 .tgl_masuk = Me.date_tgl_masuk.Value,
                 .jumlah = 0
                }

        SimpanBarangMasuk(insertDataBarangMasuk)
    End Sub

    Private Sub btn_menuutama_Click(sender As Object, e As EventArgs) Handles btn_menuutama.Click
        MenuUtama.Show()
        Me.Close()
    End Sub
    Private Sub btn_penjualan_Click(sender As Object, e As EventArgs) Handles btn_penjualan.Click
        BarangKeluar.Show()
        Me.Close()
    End Sub
    Private Sub btn_rental_Click(sender As Object, e As EventArgs) Handles btn_rental.Click
        Rental.Show()
        Me.Close()
    End Sub

    Private Sub btn_repair_Click(sender As Object, e As EventArgs) Handles btn_repair.Click
        Repair.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_jenis_Click(sender As Object, e As EventArgs) Handles btn_master_jenis.Click
        MasterJenisBarang.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_tipe_Click(sender As Object, e As EventArgs) Handles btn_master_tipe.Click
        MasterTipe.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_toko_Click(sender As Object, e As EventArgs) Handles btn_master_toko.Click
        MasterDataToko.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_client_Click(sender As Object, e As EventArgs) Handles btn_master_client.Click
        MasterClient.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_kondisi_Click(sender As Object, e As EventArgs) Handles btn_master_kondisi.Click
        MasterKondisi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_status_Click(sender As Object, e As EventArgs) Handles btn_master_status.Click
        MasterStatus.Show()
        Me.Close()
    End Sub

    Private Sub MasterLokasiToolStripMenuIbtn_master_lokasi_Click(sender As Object, e As EventArgs) Handles MasterLokasiToolStripMenuIbtn_master_lokasi.Click
        MasterLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_detail_Click(sender As Object, e As EventArgs) Handles btn_master_detail.Click
        MasterDetailLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_alasan_Click(sender As Object, e As EventArgs) Handles btn_master_alasan.Click
        MasterAlasan.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_data_user_Click(sender As Object, e As EventArgs) Handles btn_master_data_user.Click
        MasterUser.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            VBnetSQLSeverConnection()

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

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CONN.Close()
        End Try
    End Sub

    Private Sub data_barang_masuk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_barang_masuk.CellContentClick

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

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
End Class