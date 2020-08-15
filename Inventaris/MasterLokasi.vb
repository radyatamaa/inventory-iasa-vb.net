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


Public Class MasterLokasi
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim lokasiId As Integer

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
    Function SimpanLokasi(lokasi As Object) As Integer
        Dim userlogin As String = ""
        Dim idlokasi As Integer
        If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
            userlogin = MenuUtama.MenuStrip1.Tag.Username
        End If
        If lokasi.id_lokasi <> 0 Then
            Try
                Dim queryTbllokasi As String = " UPDATE tbl_lokasi SET 
                                    nama_lokasi =  '" + lokasi.nama_lokasi + "',
                                    alamat_lokasi =  '" + lokasi.alamat_lokasi + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_lokasi = " + lokasi.id_lokasi.ToString


                cmd.CommandText = queryTbllokasi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idlokasi = lokasi.id_lokasi

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                lokasiId = 0
            End Try
            Return idlokasi
        Else
            Try
                Dim queryTbllokasi As String = " INSERT INTO tbl_lokasi (
                                    nama_lokasi,
                                    alamat_lokasi,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + lokasi.nama_lokasi + "',
                                    '" + lokasi.alamat_lokasi + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTbllokasi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idlokasi = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                lokasiId = 0
            End Try
            Return idlokasi
        End If

    End Function
    Function GetDataLokasi() As List(Of Object)
        Dim resultlokasi As New List(Of Object)
        Dim querylokasi As String = "SELECT * FROM tbl_lokasi t
                                  WHERE t.is_active = 1 "

        cmd.CommandText = querylokasi
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim lokasi = New With
                {
                .id_lokasi = reader("id_lokasi"),
                .nama_lokasi = reader("nama_lokasi"),
                .alamat_lokasi = reader("alamat_lokasi")
                }

            resultlokasi.Add(lokasi)

        End While

        For Each insertDataBarangMasuk As Object In resultlokasi
            data_master_lokasi.Rows.Add(1)

            data_master_lokasi.Rows(data_master_lokasi.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_lokasi
            data_master_lokasi.Rows(data_master_lokasi.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_lokasi
            data_master_lokasi.Rows(data_master_lokasi.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.alamat_lokasi
            data_master_lokasi.Update()
        Next

        CONN.Close()

        Return resultlokasi
    End Function

    Function GetDatalokasiById(idlokasi As Integer) As List(Of Object)
        Dim resulteditlokasi As New List(Of Object)
        Dim queryeditlokasi As String = "SELECT * FROM tbl_lokasi t		                     
                                  WHERE t.is_active = 1 AND t.id_lokasi = " + idlokasi.ToString

        cmd.CommandText = queryeditlokasi
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim lokasi = New With
                {
                .id_lokasi = reader("id_lokasi"),
                .nama_lokasi = reader("nama_lokasi"),
                .alamat_lokasi = reader("alamat_lokasi")
                }

            resulteditlokasi.Add(lokasi)

        End While

        CONN.Close()

        Return resulteditlokasi
    End Function

    Function Deletelokasi(idlokasi As Integer)
        Try
            Dim userlogin As String = ""
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                userlogin = MenuUtama.MenuStrip1.Tag.Username
            End If
            Dim queryTbllokasi As String = "UPDATE tbl_lokasi SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_lokasi = " + idlokasi.ToString
            cmd.CommandText = queryTbllokasi
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            lokasiId = 0
        End Try

    End Function

    Private Sub MasterLokasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lokasiId = 0
            VBnetSQLSeverConnection()
            GetDataLokasi()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertDatalokasi = New With
         {
         .id_lokasi = lokasiId,
         .nama_lokasi = Me.txt_nama_lokasi.Text,
         .alamat_lokasi = Me.txt_alamat.Text
         }

        Dim idlokasi As Integer = SimpanLokasi(insertDatalokasi)
        data_master_lokasi.Rows.Clear()
        GetDataLokasi()
        Me.txt_nama_lokasi.Text = ""
        Me.txt_alamat.Text = ""
        MsgBox("Sukses!")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim resulthapuslokasi As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                        "Hapus Data",
                        MessageBoxButtons.YesNo)

        If (resulthapuslokasi = DialogResult.Yes) Then
            Dim idlokasi = lokasiId
            Deletelokasi(idlokasi)
            data_master_lokasi.Rows.Clear()
            GetDataLokasi()
            Me.txt_nama_lokasi.Text = ""
            Me.txt_alamat.Text = ""
        Else
        End If
    End Sub
    Private Sub data_master_lokasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_lokasi.CellClick
        Dim idlokasi = data_master_lokasi.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim lokasi = GetDatalokasiById(idlokasi)

        If lokasi.Count > 0 Then
            Try
                lokasiId = lokasi(0).id_lokasi
                Me.txt_nama_lokasi.Text = lokasi(0).nama_lokasi
                Me.txt_alamat.Text = lokasi(0).alamat_lokasi

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Close()
    End Sub
End Class