Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Public Class FormStatusBarang
    Dim ppnNominal As Decimal = 0
    Dim clientKodeSelect As String
    Public Property UserInfo As Object
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim listBarangMasuk As New List(Of Object)
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
    Function MappingToDataGridBarangKeluar(result As List(Of Object))
        Dim index = 0
        For Each insertDataBarangMasuk As Object In result
            dt_status.Rows.Add(1)
            'Dim isTest As String
            'If insertDataBarangMasuk.tested = 1 Then
            '    isTest = "Teruji"
            'Else
            '    isTest = "Tidak Teruji"
            'End If

            dt_status.Rows(dt_status.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.nama_jenis
            dt_status.Rows(dt_status.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_tipe
            dt_status.Rows(dt_status.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.serial_number
            dt_status.Rows(dt_status.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.tested
            dt_status.Rows(dt_status.RowCount - 2).Cells(4).Value = insertDataBarangMasuk.ios
            dt_status.Rows(dt_status.RowCount - 2).Cells(5).Value = insertDataBarangMasuk.nama_kondisi
            dt_status.Rows(dt_status.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.nama_lokasi
            'dt_status.Rows(dt_status.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.detail_lokasi
            'dt_status.Rows(dt_status.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.id_toko

            'If index = 0 And isSelectedTipeJenis = 0 Then
            '    isSelectedTipeJenis = 1
            '    dt_status.Columns.Add("kd_transaksi_keluar", "IdBarangKeluar")
            '    dt_status.Columns(14).Visible = False
            'End If
            'dt_status.Rows(dt_status.RowCount - 2).Cells(14).Value = insertDataBarangMasuk.id_barang_keluar

            dt_status.Update()
            index = index + 1


        Next
    End Function
    Function GetBarangMasukByStatusTipeAndJenis(idStatus As Integer, idToko As Integer)
        Dim result As New List(Of Object)
        listBarangMasuk.Clear()
        Dim query As String = "SELECT nama_jenis
                                  ,nama_tipe
                                  ,serial_number 
                                  ,tested
                                  ,ios
                                  ,nama_kondisi
                                  ,nama_lokasi
                                  ,detail_lokasi
                                  ,id_toko
                                  from view_status_barang 
                                    WHERE id_toko = " + idToko.ToString

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
            .nama_jenis = reader("nama_jenis"),
            .nama_tipe = reader("nama_tipe"),
            .serial_number = reader("serial_number"),
            .tested = reader("tested"),
            .ios = reader("ios"),
            .nama_kondisi = reader("nama_kondisi"),
            .nama_lokasi = reader("nama_lokasi"),
            .detail_lokasi = reader("detail_lokasi"),
            .id_toko = reader("id_toko")
                }
            listBarangMasuk.Add(barang)
            result.Add(barang)

        End While

        MappingToDataGridBarangKeluar(result)

        CONN.Close()


        'Dim lastIdTransaksi As Integer = 0
        'Dim idTransaksi = GetLastIdTransaksi()
        'If idTransaksi.Count > 0 Then
        '    lastIdTransaksi = idTransaksi(0) + 1
        'End If
        'Dim kdTransaksi = GenerateKdtransaksi(lastIdTransaksi.ToString, clientKodeSelect, DateTime.Now.Year)
        'Me.txt_kd_transaksi.Text = kdTransaksi

        Return result
    End Function
    Private Sub btncari2_Click(sender As Object, e As EventArgs) Handles btncari2.Click
        dt_status.Rows.Clear()
        Dim search = listBarangMasuk
        If TextBox1.Text <> "" Then
            Dim keywoard = TextBox1.Text
            If ComboBox1.Text = "Device" Then
                search = listBarangMasuk.Where(Function(x) x.nama_jenis.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox1.Text = "Device Type" Then
                search = listBarangMasuk.Where(Function(x) x.nama_tipe.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox1.Text = "Serial Number" Then
                search = listBarangMasuk.Where(Function(x) x.serial_number.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox1.Text = "Tested" Then
                search = listBarangMasuk.Where(Function(x) x.tested.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox1.Text = "Condition" Then
                search = listBarangMasuk.Where(Function(x) x.nama_kondisi.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox1.Text = "Location" Then
                search = listBarangMasuk.Where(Function(x) x.nama_lokasi.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            End If
        End If
        If TextBox2.Text <> "" Then
            Dim keywoard = TextBox2.Text
            If ComboBox2.Text = "Device" Then
                search = listBarangMasuk.Where(Function(x) x.nama_jenis.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox2.Text = "Device Type" Then
                search = listBarangMasuk.Where(Function(x) x.nama_tipe.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox2.Text = "Serial Number" Then
                search = listBarangMasuk.Where(Function(x) x.serial_number.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox2.Text = "Tested" Then
                search = listBarangMasuk.Where(Function(x) x.tested.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox2.Text = "Condition" Then
                search = listBarangMasuk.Where(Function(x) x.nama_kondisi.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            ElseIf ComboBox2.Text = "Location" Then
                search = listBarangMasuk.Where(Function(x) x.nama_lokasi.ToString.ToLower.Contains(keywoard.ToLower)).ToList()

            End If
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            GetBarangMasukByStatusTipeAndJenis(3, UserInfo.IdToko)
        Else
            MappingToDataGridBarangKeluar(search)
            'listTransaksi = search
        End If
    End Sub

    Private Sub dt_status_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_status.CellContentClick
        listBarangMasukHandle.Clear()
    End Sub

    Private Sub dt_status_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_status.CellClick
        listBarangMasukHandle.Clear()
        Dim selectedIdBarangMasuk = dt_status.SelectedRows
        For Each selectedItem As DataGridViewRow In selectedIdBarangMasuk

            Dim idBarangKeluar = selectedItem.Cells(14).Value
            'Dim checkDuplicate As Object = listBarangMasukHandle.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            'If checkDuplicate Is Nothing Then
            Dim barang As Object = listBarangMasuk.Where(Function(x) x.id_barang_keluar = idBarangKeluar).FirstOrDefault()
            If barang IsNot Nothing Then

                listBarangMasukHandle.Add(barang)
            End If
            'End If

        Next selectedItem

    End Sub

    Private Sub FormStatusBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Me.txt_harga_total.Text = 0
            'Me.txt_harga_akhir.Text = 0
            'Me.txt_subtotal.Text = 0

            'Me.txt_shiphand.Text = 0
            'Me.txt_ppn.Text = 0

            isSelectedTipeJenis = 0
            'Dim kdTransaksi As String = RandomString(New Random)
            'Me.txt_kd_transaksi.Text = kdTransaksi
            'Me.txt_kd_transaksi.Enabled = False
            VBnetSQLSeverConnection()
            'Dim listbarang As List(Of Object) = GetJenisBarang()
            'If listbarang.Count > 0 Then
            '    cmb_jenis_barang.DataSource = listbarang
            '    cmb_jenis_barang.DisplayMember = "nama_jenis"
            '    cmb_jenis_barang.ValueMember = "id_jenis"
            'End If

            'Dim listClient As List(Of Object) = GetClient()
            'If listClient.Count > 0 Then
            '    cmb_client.DataSource = listClient
            '    cmb_client.DisplayMember = "kd_client"
            '    cmb_client.ValueMember = "id_client"
            'End If
            GetBarangMasukByStatusTipeAndJenis(3, UserInfo.IdToko)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'CONN.Close()
        End Try
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.MenuStrip1.Tag = UserInfo
        MenuUtama.Show()
        Me.Close()
    End Sub
End Class