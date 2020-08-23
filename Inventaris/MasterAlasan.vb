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
Public Class MasterAlasan
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim alasanId As Integer
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
    Function Simpanalasan(alasan As Object) As Integer
        Dim userlogin As String = ""
        Dim idalasan As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
        End If
        If alasan.id_alasan <> 0 Then
            Try
                Dim queryTblalasan As String = " UPDATE tbl_master_alasan SET 
                                    nama_alasan =  '" + alasan.nama_alasan + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_alasan = " + alasan.id_alasan.ToString


                cmd.CommandText = queryTblalasan
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idalasan = alasan.id_alasan

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                alasanId = 0
            End Try
            Return idalasan
        Else
            Try
                Dim queryTblalasan As String = " INSERT INTO tbl_master_alasan (
                                    nama_alasan,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + alasan.nama_alasan + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTblalasan
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idalasan = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                alasanId = 0
            End Try
            Return idalasan
        End If

    End Function

    Function GetDataalasan() As List(Of Object)
        Dim resultalasan As New List(Of Object)
        Dim queryalasan As String = "SELECT * FROM tbl_master_alasan t
                                  WHERE t.is_active = 1 "

        cmd.CommandText = queryalasan
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim alasan = New With
                {
                .id_alasan = reader("id_alasan"),
            .nama_alasan = reader("nama_alasan")
                }

            resultalasan.Add(alasan)

        End While

        For Each insertDataBarangMasuk As Object In resultalasan
            data_master_alasan.Rows.Add(1)

            data_master_alasan.Rows(data_master_alasan.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_alasan
            data_master_alasan.Rows(data_master_alasan.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_alasan


            data_master_alasan.Update()
        Next

        CONN.Close()

        Return resultalasan
    End Function
    Function GetDataalasanById(idalasan As Integer) As List(Of Object)
        Dim resulteditalasan As New List(Of Object)
        Dim queryeditalasan As String = "SELECT * FROM tbl_master_alasan t		                     
                                  WHERE t.is_active = 1 AND t.id_alasan = " + idalasan.ToString

        cmd.CommandText = queryeditalasan
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim alasan = New With
                {
                .id_alasan = reader("id_alasan"),
            .nama_alasan = reader("nama_alasan")
                }

            resulteditalasan.Add(alasan)

        End While

        CONN.Close()

        Return resulteditalasan
    End Function
    Function Deletealasan(idalasan As Integer)
        Try
            Dim userlogin As String = ""
            If UserInfo IsNot Nothing Then
                userlogin = UserInfo.Username
            End If
            Dim queryTblalasan As String = "UPDATE tbl_master_alasan SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_alasan = " + idalasan.ToString
            cmd.CommandText = queryTblalasan
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            alasanId = 0
        End Try

    End Function
    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.MenuStrip1.Tag = UserInfo
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub MasterAlasan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alasanId = 0
            VBnetSQLSeverConnection()
            GetDataalasan()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertDataalasan = New With
            {
            .id_alasan = alasanId,
             .nama_alasan = Me.txt_nama_alasan.Text
            }

        Dim idalasan As Integer = Simpanalasan(insertDataalasan)
        data_master_alasan.Rows.Clear()
        GetDataalasan()
        Me.txt_nama_alasan.Text = ""
        MsgBox("Sukses!")

    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim resulthapusalasan As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                           "Hapus Data",
                           MessageBoxButtons.YesNo)

        If (resulthapusalasan = DialogResult.Yes) Then
            Dim idalasan = alasanId
            Deletealasan(idalasan)
            data_master_alasan.Rows.Clear()
            GetDataalasan()
            Me.txt_nama_alasan.Text = ""

        Else
        End If
    End Sub

    Private Sub data_master_alasan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_alasan.CellClick
        Dim idalasan = data_master_alasan.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim alasan = GetDataalasanById(idalasan)

        If alasan.Count > 0 Then
            Try
                alasanId = alasan(0).id_alasan
                Me.txt_nama_alasan.Text = alasan(0).nama_alasan
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class
