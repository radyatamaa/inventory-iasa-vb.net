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
Public Class MasterJenisMaintenance
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim jenisId As Integer
    Public Property UserInfo As Object
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
    Function SimpanJenis(jenis As Object) As Integer
        Dim userlogin As String = ""
        Dim idJenis As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
        End If
        If jenis.id_jenis_maintenance <> 0 Then
            Try
                Dim queryTbljenis As String = " UPDATE tbl_jenis_maintenance SET 
                                    nama_jenis_maintenance =  '" + jenis.nama_jenis_maintenance + "',
                                    harga =  '" + jenis.harga + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_jenis_maintenance = " + jenis.id_jenis_maintenance.ToString


                cmd.CommandText = queryTbljenis
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idJenis = jenis.id_jenis_maintenance

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                jenisId = 0
            End Try
            Return idJenis
        Else
            Try
                Dim queryTbljenis As String = " INSERT INTO tbl_jenis_maintenance (
                                    nama_jenis_maintenance,
                                    harga,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + jenis.nama_jenis_maintenance + "',
                                    '" + jenis.harga + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTbljenis
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idJenis = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                jenisId = 0
            End Try
            Return idJenis
        End If

    End Function

    Function GetDataJenis() As List(Of Object)
        Dim resultjenis As New List(Of Object)
        Dim queryjenis As String = "SELECT * FROM tbl_jenis_maintenance t
                                  WHERE t.is_active = 1 "

        cmd.CommandText = queryjenis
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim jenis = New With
                {
                .id_jenis_maintenance = reader("id_jenis_maintenance"),
                .nama_jenis_maintenance = reader("nama_jenis_maintenance"),
                .harga = reader("harga")
                }

            resultjenis.Add(jenis)

        End While

        For Each insertDataBarangMasuk As Object In resultjenis
            data_master_jenis.Rows.Add(1)

            data_master_jenis.Rows(data_master_jenis.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_jenis_maintenance
            data_master_jenis.Rows(data_master_jenis.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_jenis_maintenance
            data_master_jenis.Rows(data_master_jenis.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.harga


            data_master_jenis.Update()
        Next

        CONN.Close()

        Return resultjenis
    End Function
    Function GetDataJenisById(idJenis As Integer) As List(Of Object)
        Dim resulteditjenis As New List(Of Object)
        Dim queryeditjenis As String = "SELECT * FROM tbl_jenis_maintenance t		                     
                                  WHERE t.is_active = 1 AND t.id_jenis_maintenance = " + idJenis.ToString

        cmd.CommandText = queryeditjenis
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim jenis = New With
                {
                .id_jenis_maintenance = reader("id_jenis_maintenance"),
                .nama_jenis_maintenance = reader("nama_jenis_maintenance"),
                .harga = reader("harga")
                }

            resulteditjenis.Add(jenis)

        End While

        CONN.Close()

        Return resulteditjenis
    End Function
    Function DeleteJenis(idJenis As Integer)
        Try
            Dim userlogin As String = ""
            If UserInfo IsNot Nothing Then
                userlogin = UserInfo.Username
            End If
            Dim queryTblJenis As String = "UPDATE tbl_jenis_maintenance SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_jenis_maintenance = " + idJenis.ToString
            cmd.CommandText = queryTblJenis
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            jenisId = 0
        End Try

    End Function
    Private Sub MasterJenisMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            jenisId = 0
            VBnetSQLSeverConnection()
            GetDataJenis()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertDatajenis = New With
           {
           .id_jenis_maintenance = jenisId,
            .nama_jenis_maintenance = Me.txt_jenis_maintenance.Text,
            .harga = Me.txt_harga.Text
           }

        Dim idjenis As Integer = SimpanJenis(insertDatajenis)
        data_master_jenis.Rows.Clear()
        GetDataJenis()
        Me.txt_jenis_maintenance.Text = ""
        Me.txt_harga.Text = ""
        MsgBox("Sukses!")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim resulthapusjenis As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                          "Hapus Data",
                          MessageBoxButtons.YesNo)

        If (resulthapusjenis = DialogResult.Yes) Then
            Dim idJenis = jenisId
            DeleteJenis(idJenis)
            data_master_jenis.Rows.Clear()
            GetDataJenis()
            Me.txt_jenis_maintenance.Text = ""
            Me.txt_harga.Text = ""

        Else
        End If
    End Sub

    Private Sub data_master_jenis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_jenis.CellContentClick

    End Sub

    Private Sub data_master_jenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_jenis.CellClick
        Dim idJenis = data_master_jenis.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim jenis = GetDataJenisById(idJenis)

        If jenis.Count > 0 Then
            Try
                jenisId = jenis(0).id_jenis_maintenance
                Me.txt_jenis_maintenance.Text = jenis(0).nama_jenis_maintenance
                Me.txt_harga.Text = jenis(0).harga
            Catch ex As Exception

            End Try

        End If
    End Sub



    Private Sub btn_kembali_Click_1(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub txt_harga_TextChanged(sender As Object, e As EventArgs) Handles txt_harga.TextChanged
        If Len(txt_harga.Text) > 0 Then
            txt_harga.Text = FormatNumber(CDbl(txt_harga.Text), 0)
            Dim x As Integer = txt_harga.SelectionStart.ToString
            If x = 0 Then
                txt_harga.SelectionStart = Len(txt_harga.Text)
                txt_harga.SelectionLength = 0
            Else
                txt_harga.SelectionStart = x
                txt_harga.SelectionLength = 0
            End If
        End If
    End Sub
End Class