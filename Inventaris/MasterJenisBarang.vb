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
Public Class MasterJenisBarang
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim jenisId As Integer
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
        If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
            userlogin = MenuUtama.MenuStrip1.Tag.Username
        End If
        If jenis.id_jenis <> 0 Then
            Try
                Dim queryTbljenis As String = " UPDATE tbl_jenis SET 
                                    nama_jenis =  '" + jenis.nama_jenis + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_jenis = " + jenis.id_jenis.ToString


                cmd.CommandText = queryTbljenis
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idJenis = jenis.id_jenis

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                jenisId = 0
            End Try
            Return idJenis
        Else
            Try
                Dim queryTbljenis As String = " INSERT INTO tbl_jenis (
                                    nama_jenis,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + jenis.nama_jenis + "',
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
        Dim queryjenis As String = "SELECT * FROM tbl_jenis t
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
                .id_jenis = reader("id_jenis"),
            .nama_jenis = reader("nama_jenis")
                }

            resultjenis.Add(jenis)

        End While

        For Each insertDataBarangMasuk As Object In resultjenis
            data_master_jenis.Rows.Add(1)

            data_master_jenis.Rows(data_master_jenis.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_jenis
            data_master_jenis.Rows(data_master_jenis.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_jenis


            data_master_jenis.Update()
        Next

        CONN.Close()

        Return resultjenis
    End Function
    Function GetDataJenisById(idJenis As Integer) As List(Of Object)
        Dim resulteditjenis As New List(Of Object)
        Dim queryeditjenis As String = "SELECT * FROM tbl_jenis t		                     
                                  WHERE t.is_active = 1 AND t.id_jenis = " + idJenis.ToString

        cmd.CommandText = queryeditjenis
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim jenis = New With
                {
                .id_jenis = reader("id_jenis"),
            .nama_jenis = reader("nama_jenis")
                }

            resulteditjenis.Add(jenis)

        End While

        CONN.Close()

        Return resulteditjenis
    End Function
    Function DeleteJenis(idJenis As Integer)
        Try
            Dim userlogin As String = ""
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                userlogin = MenuUtama.MenuStrip1.Tag.Username
            End If
            Dim queryTblJenis As String = "UPDATE tbl_jenis SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_jenis = " + idJenis.ToString
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

    Private Sub MasterJenisBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            .id_jenis = jenisId,
             .nama_jenis = Me.txt_jenis_barang.Text
            }

        Dim idjenis As Integer = SimpanJenis(insertDatajenis)
        data_master_jenis.Rows.Clear()
        GetDataJenis()
        Me.txt_jenis_barang.Text = ""
        MsgBox("Sukses!")

    End Sub

    Private Sub data_master_jenis_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_jenis.CellContentClick

    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Close()
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
            Me.txt_jenis_barang.Text = ""

        Else
        End If
    End Sub

    Private Sub data_master_jenis_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles data_master_jenis.CellFormatting

    End Sub

    Private Sub data_master_jenis_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_jenis.CellClick
        Dim idJenis = data_master_jenis.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim jenis = GetDataJenisById(idJenis)

        If jenis.Count > 0 Then
            Try
                jenisId = jenis(0).id_jenis
                Me.txt_jenis_barang.Text = jenis(0).nama_jenis
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class