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

Public Class Form3
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim userId As Integer
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

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.MenuStrip1.Tag = UserInfo
        MenuUtama.Show()
        Me.Close()
    End Sub
    Function UpdatePassword(user As Object) As Integer
        Dim userlogin As String = ""
        Dim iduser As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
        End If
        Try
            Dim queryTbluser As String = " UPDATE tbl_user SET 
                                    password =  '" + user.password + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  username = '" + user.username + "'"

            cmd.CommandText = queryTbluser
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            userId = 0
        End Try
        Return iduser
    End Function
    Function GetDataUserByUsername(username As String) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_user t
                                  WHERE t.is_active = 1 AND t.username = '" + username + "'"

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim user = New With
                {
                .id_user = reader("id_user"),
                .username = reader("username"),
                .password = reader("password")
                }

            result.Add(user)

        End While

        CONN.Close()

        Return result
    End Function
    Private Sub btn_ubah_Click(sender As Object, e As EventArgs) Handles btn_ubah.Click
        Dim getuser = GetDataUserByUsername(UserInfo.Username)
        Dim passwordlama = txt_password_lama.Text
        Dim passwordbaru = txt_password_baru.Text
        Dim konfirmasipassword = txt_konfirmasi_password.Text
        If getuser(0).password <> passwordlama Then
            MsgBox("Password Lama Salah!")
            Return
        End If
        If konfirmasipassword <> passwordbaru Then
            MsgBox("Konfirmasi Password Tidak Sama  Dengan Password Baru!")
            Return
        End If

        Dim user = New With
            {
                .password = passwordbaru,
                .username = UserInfo.Username
            }
        UpdatePassword(user)
        MsgBox("Berhasil Diubah!")
        txt_konfirmasi_password.Text = ""
        txt_password_lama.Text = ""
        txt_password_baru.Text = ""
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            VBnetSQLSeverConnection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class