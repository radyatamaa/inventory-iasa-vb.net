'Imports System.Configuration
'Imports System.Data.SqlClient
'Imports System.Globalization
'Imports System.IO
'Imports System.Net
'Imports System.Text
'Imports Microsoft.Azure.Management.Storage.Models
'Imports Microsoft.Azure.Storage
'Imports Microsoft.Azure.Storage.Auth
'Imports Microsoft.Azure.Storage.Blob
Public Class MasterDataToko
    'Dim CONN As SqlConnection
    'Dim cmd As New SqlCommand
    'Dim reader As SqlDataReader
    'Dim tokoid As Integer
    'Sub VBnetSQLSeverConnection()
    '    Try
    '        'SQL connection script to SQL Server Instance
    '        CONN = New SqlConnection(ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString)
    '        CONN.Open()

    '        'Show a test connection message status
    '        'MsgBox("Successfully connected to SQL Server Instance")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    CONN.Close()
    'End Sub
    'Function SimpanToko(toko As Object) As Integer
    '    Dim userlogin As String = ""
    '    Dim idtoko As Integer
    '    If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
    '        userlogin = MenuUtama.MenuStrip1.Tag.Username
    '    End If
    '    If toko.id_toko <> 0 Then
    '        Try
    '            Dim queryTbltoko As String = " UPDATE tbl_toko SET 
    '                                kd_toko =  '" + toko.kd_toko + "',
    '                                nama_toko =  '" + toko.nama_toko + "',
    '                                alamat_toko =  '" + toko.alamat_toko + "',
    '                                kota_toko =  '" + toko.kota_toko + "',
    '                                kdpos_toko =  '" + toko.kdpos_toko + "',
    '                                tlp_toko =  '" + toko.tlp_toko + "',
    '                                image_url =  '" + toko.image_url.ToString + "',
    '                                updated_by =  '" + userlogin + "',
    '                                updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
    '                        WHERE  id_toko = " + toko.id_toko.ToString


    '            cmd.CommandText = queryTbltoko
    '            cmd.CommandType = CommandType.Text
    '            cmd.Connection = CONN
    '            CONN.Open()
    '            reader = cmd.ExecuteReader()
    '            CONN.Close()
    '            idtoko = toko.id_toko

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        Finally
    '            tokoid = 0
    '        End Try
    '        Return idtoko
    '    Else
    '        Try
    '            Dim queryTbltoko As String = " INSERT INTO tbl_toko (
    '                                kd_toko,
    '                                nama_toko,
    '                                alamat_toko,
    '                                kota_toko,
    '                                kdpos_toko,
    '                                tlp_toko,
    '                                created_by,
    '                                created_date,
    '                                is_active) 
    '                        VALUES (
    '                                '" + toko.kd_toko + "',
    '                                '" + toko.nama_toko + "',
    '                                '" + toko.alamat_toko + "',
    '                                '" + toko.kota_toko + "',
    '                                '" + toko.kdpos_toko + "',
    '                                '" + toko.tlp_toko + "',
    '                                '" + userlogin + "',
    '                                CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
    '                                " + 1.ToString + "
    '                                ); SELECT SCOPE_IDENTITY() "


    '            cmd.CommandText = queryTbltoko
    '            cmd.CommandType = CommandType.Text
    '            cmd.Connection = CONN
    '            CONN.Open()
    '            idtoko = cmd.ExecuteScalar()
    '            CONN.Close()

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        Finally
    '            tokoid = 0
    '        End Try
    '        Return idtoko
    '    End If

    'End Function
    Private Sub txt_logo_toko_TextChanged(sender As Object, e As EventArgs) Handles txt_logo_toko.TextChanged
        txt_logo_toko.Text = (Replace(txt_logo_toko.Text, "\", ";"))
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.Filter = "Jpeg|*.JPG|Bitmap| *.BMP|Gif| *.GIF"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        txt_logo_toko.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Close()
    End Sub
End Class