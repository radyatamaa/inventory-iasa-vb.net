Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text
Imports Microsoft.Azure.Management.Storage.Models
Imports Microsoft.Azure.Storage
Imports Microsoft.Azure.Storage.Auth
Imports Microsoft.Azure.Storage.Blob
Public Class MasterClient
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim clientid As Integer
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
    Function SimpanClient(client As Object) As Integer
        Dim userlogin As String = ""
        Dim idclient As Integer
        If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
            userlogin = MenuUtama.MenuStrip1.Tag.Username
        End If
        If client.id_client <> 0 Then
            Try
                Dim queryTblclient As String = " UPDATE tbl_client SET 
                                    kd_client =  '" + client.kd_client + "',
                                    nama_client =  '" + client.nama_client + "',
                                    alamat_client =  '" + client.alamat_client + "',
                                    kota_client =  '" + client.kota_client + "',
                                    kdpos_client =  '" + client.kdpos_client + "',
                                    tlp_client =  '" + client.tlp_client + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_client = " + client.id_client.ToString


                cmd.CommandText = queryTblclient
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idclient = client.id_client

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                clientid = 0
            End Try
            Return idclient
        Else
            Try
                Dim queryTblclient As String = " INSERT INTO tbl_client (
                                    kd_client,
                                    nama_client,
                                    alamat_client,
                                    kota_client,
                                    kdpos_client,
                                    tlp_client,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + client.kd_client + "',
                                    '" + client.nama_client + "',
                                    '" + client.alamat_client + "',
                                    '" + client.kota_client + "',
                                    '" + client.kdpos_client + "',
                                    '" + client.tlp_client + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTblclient
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idclient = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                clientid = 0
            End Try
            Return idclient
        End If

    End Function
    Function GetDataClient() As List(Of Object)
        Dim resultclient As New List(Of Object)
        Dim queryclient As String = "SELECT * FROM tbl_client t
                                  WHERE t.is_active = 1 "

        cmd.CommandText = queryclient
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim client = New With
                {
                .id_client = reader("id_client"),
                .kd_client = reader("kd_client"),
                .nama_client = reader("nama_client"),
                .alamat_client = reader("alamat_client"),
                .kota_client = reader("kota_client"),
                .kdpos_client = reader("kdpos_client"),
                .tlp_client = reader("tlp_client")
                }

            resultclient.Add(client)

        End While

        For Each insertDataBarangMasuk As Object In resultclient
            data_master_client.Rows.Add(1)

            data_master_client.Rows(data_master_client.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_client
            data_master_client.Rows(data_master_client.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.kd_client
            data_master_client.Rows(data_master_client.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.nama_client
            data_master_client.Rows(data_master_client.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.alamat_client
            data_master_client.Rows(data_master_client.RowCount - 2).Cells(4).Value = insertDataBarangMasuk.kota_client
            data_master_client.Rows(data_master_client.RowCount - 2).Cells(5).Value = insertDataBarangMasuk.kdpos_client
            data_master_client.Rows(data_master_client.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.tlp_client


            data_master_client.Update()
        Next

        CONN.Close()

        Return resultclient
    End Function
    Function GetDataClientById(idclient As Integer) As List(Of Object)
        Dim resulteditclient As New List(Of Object)
        Dim queryeditclient As String = "SELECT * FROM tbl_client t		                     
                                  WHERE t.is_active = 1 AND t.id_client = " + idclient.ToString

        cmd.CommandText = queryeditclient
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim client = New With
                {
                 .id_client = reader("id_client"),
                .kd_client = reader("kd_client"),
                .nama_client = reader("nama_client"),
                .alamat_client = reader("alamat_client"),
                .kota_client = reader("kota_client"),
                .kdpos_client = reader("kdpos_client"),
                .tlp_client = reader("tlp_client")
                }

            resulteditclient.Add(client)

        End While

        CONN.Close()

        Return resulteditclient
    End Function
    Function Deleteclient(idclient As Integer)
        Try
            Dim userlogin As String = ""
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                userlogin = MenuUtama.MenuStrip1.Tag.Username
            End If
            Dim queryTblclient As String = "UPDATE tbl_client SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_client = " + idclient.ToString
            cmd.CommandText = queryTblclient
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            clientid = 0
        End Try

    End Function
    Private Sub btn_menuutama_Click(sender As Object, e As EventArgs) 
        MenuUtama.Show()
        Me.Close()
    End Sub
    Private Sub btn_barang_masuk_Click(sender As Object, e As EventArgs) 
        BarangMasuk.Show()
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

    Private Sub btn_master_client_Click(sender As Object, e As EventArgs) 
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
    Private Sub btn_penjualan_Click(sender As Object, e As EventArgs) 
        BarangKeluar.Show()
        Me.Close()
    End Sub

    Private Sub MasterClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clientid = 0
            VBnetSQLSeverConnection()
            GetDataClient()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertDataclient = New With
            {
            .id_client = clientid,
             .kd_client = Me.txt_kd_client.Text,
             .nama_client = Me.txt_nama_client.Text,
             .alamat_client = Me.txt_alamat_client.Text,
        .kota_client = Me.txt_kota_client.Text,
        .kdpos_client = Me.txt_kdpos_client.Text,
        .tlp_client = Me.txt_tlp_client.Text
            }

        Dim idclient As Integer = SimpanClient(insertDataclient)
        data_master_client.Rows.Clear()
        GetDataClient()
        Me.txt_kd_client.Text = ""
        Me.txt_nama_client.Text = ""
        Me.txt_alamat_client.Text = ""
        Me.txt_kota_client.Text = ""
        Me.txt_kdpos_client.Text = ""
        Me.txt_tlp_client.Text = ""

        MsgBox("Sukses!")

    End Sub
    Private Sub data_master_client_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_client.CellClick
        Dim idclient = data_master_client.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim client = GetDataClientById(idclient)

        If client.Count > 0 Then
            Try
                clientid = client(0).id_client
                Me.txt_kd_client.Text = client(0).kd_client
                Me.txt_nama_client.Text = client(0).nama_client
                Me.txt_alamat_client.Text = client(0).alamat_client
                Me.txt_kota_client.Text = client(0).kota_client
                Me.txt_kdpos_client.Text = client(0).kdpos_client
                Me.txt_tlp_client.Text = client(0).tlp_client
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim resulthapusclient As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                          "Hapus Data",
                          MessageBoxButtons.YesNo)

        If (resulthapusclient = DialogResult.Yes) Then
            Dim idclient = clientid
            Deleteclient(idclient)
            data_master_client.Rows.Clear()
            GetDataClient()
            Me.txt_kd_client.Text = ""
            Me.txt_nama_client.Text = ""
            Me.txt_alamat_client.Text = ""
            Me.txt_kota_client.Text = ""
            Me.txt_kdpos_client.Text = ""
            Me.txt_tlp_client.Text = ""

        Else
        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Close()
    End Sub
End Class