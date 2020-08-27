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
Public Class MasterDataToko
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim tokoid As Integer
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
    'Function GetToko() As List(Of Object)
    '    Dim result As New List(Of Object)
    '    'result.Add(jenisREsult)
    '    Dim query As String = "SELECT * FROM tbl_toko WHERE is_active = 1 "
    '    cmd.CommandText = query
    '    cmd.CommandType = CommandType.Text
    '    cmd.Connection = CONN
    '    CONN.Open()
    '    reader = cmd.ExecuteReader()
    '    'This will loop through all returned records 
    '    While reader.Read
    '        Dim toko As New With {
    '                        .nama_toko = reader("nama_tipe").ToString,
    '                        .alamat_toko = reader("alamat_toko").ToString,
    '                        .kota_toko = reader("kota_toko").ToString,
    '                        .kdpos_toko = reader("kdpos_toko").ToString,
    '                        .tlp_toko = reader("tlp_toko").ToString,
    '                        .logo_toko = reader("logo_toko").ToString,
    '                        .nama_owner = reader("nama_owner").ToString,
    '                        .tlp_owner = reader("tlp_owner").ToString,
    '                        .norek_owner = reader("norek_owner").ToString
    '                        }
    '        result.Add(toko)
    '        'handle returned value before next loop here
    '    End While
    '    CONN.Close()
    '    Return result
    'End Function
    Function GetDataToko() As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_toko t
                                  WHERE t.is_active = 1 "

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim toko = New With
                {
            .nama_toko = reader("nama_toko"),
            .alamat_toko = reader("alamat_toko"),
            .kota_toko = reader("kota_toko"),
            .kdpos_toko = reader("kdpos_toko"),
            .tlp_toko = reader("tlp_toko"),
            .logo_toko = reader("logo_toko"),
            .nama_owner = reader("nama_owner"),
            .tlp_owner = reader("tlp_owner"),
            .norek_owner = reader("norek_owner"),
            .id_toko = reader("id_toko")
                }

            result.Add(toko)

        End While

        For Each insertDataBarangMasuk As Object In result
            data_master_toko.Rows.Add(1)

            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_toko
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_toko
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.alamat_toko
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.kota_toko
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(4).Value = insertDataBarangMasuk.kdpos_toko
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(5).Value = insertDataBarangMasuk.tlp_toko
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(6).Value = insertDataBarangMasuk.logo_toko
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(7).Value = insertDataBarangMasuk.nama_owner
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(8).Value = insertDataBarangMasuk.tlp_owner
            data_master_toko.Rows(data_master_toko.RowCount - 2).Cells(9).Value = insertDataBarangMasuk.norek_owner

            data_master_toko.Update()
        Next

        CONN.Close()

        Return result
    End Function
    Function GetDataTokoById(idToko As Integer) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_toko t
                                  WHERE t.is_active = 1 AND t.id_toko = " + idToko.ToString

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim toko = New With
                {
            .nama_toko = reader("nama_toko"),
            .alamat_toko = reader("alamat_toko"),
            .kota_toko = reader("kota_toko"),
            .kdpos_toko = reader("kdpos_toko"),
            .tlp_toko = reader("tlp_toko"),
            .logo_toko = reader("logo_toko"),
            .nama_owner = reader("nama_owner"),
            .tlp_owner = reader("tlp_owner"),
            .norek_owner = reader("norek_owner"),
            .id_toko = reader("id_toko")
                }

            result.Add(toko)

        End While

        CONN.Close()

        Return result
    End Function



    Function SimpanToko(toko As Object) As Integer
        Dim userlogin As String = ""
        Dim idToko As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
        End If
        If toko.id_toko <> 0 Then
            Try
                Dim queryTbltoko As String = " UPDATE tbl_toko SET 
                                    nama_toko =  '" + toko.nama_toko + "',
                                    alamat_toko =  '" + toko.alamat_toko + "',
                                    kota_toko =  '" + toko.kota_toko + "',
                                    kdpos_toko =  '" + toko.kdpos_toko + "',
                                    tlp_toko =  '" + toko.tlp_toko + "',
                                    logo_toko =  '" + toko.logo_toko.ToString + "',
                                    nama_owner =  '" + toko.nama_owner + "',
                                    tlp_owner =  '" + toko.tlp_owner + "',
                                    norek_owner =  '" + toko.norek_owner + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_toko = " + toko.id_toko.ToString


                cmd.CommandText = queryTbltoko
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idToko = toko.id_toko

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                tokoid = 0
            End Try
            Return idToko
        Else
            Try
                Dim queryTbltoko As String = " INSERT INTO tbl_toko (
                                    nama_toko,
                                    alamat_toko,
                                    kota_toko,
                                    kdpos_toko,
                                    tlp_toko,
                                    logo_toko,
                                    nama_owner,
                                    tlp_owner,
                                    norek_owner,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + toko.nama_toko + "',
                                    '" + toko.alamat_toko + "',
                                    '" + toko.kota_toko + "',
                                    '" + toko.kdpos_toko + "',
                                    '" + toko.tlp_toko + "',
                                    '" + toko.logo_toko + "',
                                    '" + toko.nama_owner + "',
                                    '" + toko.tlp_owner + "',
                                    '" + toko.norek_owner + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTbltoko
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idToko = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                tokoid = 0
            End Try
            Return idToko
        End If

    End Function
    Function DeleteToko(idToko As Integer)
        Try
            Dim userlogin As String = ""
            If UserInfo IsNot Nothing Then
                userlogin = UserInfo.Username
            End If
            Dim queryTblToko As String = "UPDATE tbl_toko SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_toko = " + idToko.ToString
            cmd.CommandText = queryTblToko
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            tokoid = 0
        End Try

    End Function
    Function RandomString(r As Random) As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Function UploadToStorageAzure(image As String) As String
        Dim accountname As String = ConfigurationManager.AppSettings.Get("AzureStorageAccount")

        Dim accesskey As String = ConfigurationManager.AppSettings.Get("AzureStorageAccessKey")

        Dim container As String = ConfigurationManager.AppSettings.Get("AzureStorageContainer")

        Dim resultPath As String = ""

        Try
            Dim creden As StorageCredentials = New StorageCredentials(accountname, accesskey)

            Dim acc As CloudStorageAccount = New CloudStorageAccount(creden, True)

            Dim client As CloudBlobClient = acc.CreateCloudBlobClient()

            Dim cont As CloudBlobContainer = client.GetContainerReference(container)

            cont.CreateIfNotExists()

            cont.SetPermissions(New BlobContainerPermissions With
             {
                .PublicAccess = BlobContainerPublicAccessType.Blob
            })
            Dim fileImage As String = RandomString(New Random)
            Dim cblob As CloudBlockBlob = cont.GetBlockBlobReference("toko/" + fileImage + ".jpg")
            image = image.Replace(";", "\")
            Using file As Stream = System.IO.File.OpenRead(image)
                cblob.UploadFromStream(file)
            End Using
            resultPath = cblob.StorageUri.PrimaryUri.AbsoluteUri
            Return resultPath
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function
    Private Sub txt_logo_toko_TextChanged(sender As Object, e As EventArgs) Handles txt_logo_toko.TextChanged
        txt_logo_toko.Text = (Replace(txt_logo_toko.Text, "\", ";"))
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.Filter = "Jpg|*.JPG|Jpeg|*.JPEG|Bitmap| *.BMP|Gif| *.GIF"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        txt_logo_toko.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.MenuStrip1.Tag = UserInfo
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub MasterDataToko_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tokoid = 0
            VBnetSQLSeverConnection()
            GetDataToko()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim imagePath As String = ""
        If Me.txt_logo_toko.Text <> "" Then
            imagePath = UploadToStorageAzure(Me.txt_logo_toko.Text)
        ElseIf Me.txt_logo_toko.Text = "" And tokoid <> 0 Then
            Dim toko = GetDataTokoById(tokoid)
            imagePath = toko(0).logo_toko
        End If
        Dim insertDataToko = New With
            {
            .id_toko = tokoid,
             .nama_toko = Me.txt_nama_toko.Text,
             .alamat_toko = Me.txt_alamat_toko.Text,
             .kota_toko = Me.txt_kota_toko.Text,
             .kdpos_toko = Me.txt_kdpos_toko.Text,
             .tlp_toko = Me.txt_tlp_toko.Text,
             .logo_toko = imagePath,
             .nama_owner = Me.txt_nama_owner.Text,
             .tlp_owner = Me.txt_tlp_owner.Text,
             .norek_owner = Me.txt_norek_owner.Text
            }

        Dim idToko As Integer = SimpanToko(insertDataToko)
        data_master_toko.Rows.Clear()
        GetDataToko()
        Me.txt_nama_toko.Text = ""
        Me.txt_alamat_toko.Text = ""
        Me.txt_kota_toko.Text = ""
        Me.txt_kdpos_toko.Text = ""
        Me.txt_tlp_toko.Text = ""
        Me.txt_logo_toko.Text = ""
        Me.txt_nama_owner.Text = ""
        Me.txt_tlp_owner.Text = ""
        Me.txt_norek_owner.Text = ""
        MsgBox("Sukses!")

        'Dim imagePath As String = UploadToStorageAzure(Me.txt_logo_toko.Text)
        'Dim insertDataToko = New With
        '    {
        '     .id_toko = tokoid,
        '     .nama_toko = Me.txt_nama_toko.Text,
        '     .alamat_toko = Me.txt_alamat_toko.Text,
        '     .kota_toko = Me.txt_kota_toko.Text,
        '     .kdpos_toko = Me.txt_kdpos_toko.Text,
        '     .tlp_toko = Me.txt_tlp_toko.Text,
        '     .logo_toko = imagePath,
        '     .nama_owner = Me.txt_nama_owner.Text,
        '     .tlp_owner = Me.txt_tlp_owner.Text,
        '     .norek_owner = Me.txt_norek_owner.Text
        '    }

        'Dim idToko As Integer = SimpanToko(insertDataToko)
        'data_master_toko.Rows.Clear()
        'GetDataToko()
        'Me.txt_nama_toko.Text = ""
        'Me.txt_alamat_toko.Text = ""
        'Me.txt_kota_toko.Text = ""
        'Me.txt_kdpos_toko.Text = ""
        'Me.txt_tlp_toko.Text = ""
        'Me.txt_logo_toko.Text = ""
        'Me.txt_nama_owner.Text = ""
        'Me.txt_tlp_owner.Text = ""
        'Me.txt_norek_owner.Text = ""
        'MsgBox("Sukses!")
    End Sub

    Private Sub hapus_data_toko_Click(sender As Object, e As EventArgs) Handles hapus_data_toko.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                             "Hapus Data",
                             MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Dim idToko = tokoid
            DeleteToko(idToko)
            data_master_toko.Rows.Clear()
            GetDataToko()
            Me.txt_nama_toko.Text = ""
            Me.txt_alamat_toko.Text = ""
            Me.txt_kota_toko.Text = ""
            Me.txt_kdpos_toko.Text = ""
            Me.txt_tlp_toko.Text = ""
            Me.txt_logo_toko.Text = ""
            Me.txt_nama_owner.Text = ""
            Me.txt_tlp_owner.Text = ""
            Me.txt_norek_owner.Text = ""
        Else
        End If
    End Sub

    Private Sub data_master_toko_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_toko.CellClick
        Dim idToko = data_master_toko.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim toko = GetDataTokoById(idToko)

        If toko.Count > 0 Then
            tokoid = toko(0).id_toko
            Me.txt_nama_toko.Text = toko(0).nama_toko
            Dim alamat_toko As String
            Dim kota_toko As String
            Dim kdpos_toko As String
            Dim tlp_toko As String
            Dim nama_owner As String
            Dim tlp_owner As String
            Dim norek_owner As String
            'If toko(0).alamat_toko IsNot Nothing Then
            '    alamat_toko = toko(0).alamat_toko
            'End If
            If Not IsDBNull(toko(0).alamat_toko) Then
                alamat_toko = toko(0).alamat_toko
            End If
            Me.txt_alamat_toko.Text = alamat_toko
            If Not IsDBNull(toko(0).kota_toko) Then
                kota_toko = toko(0).kota_toko
            End If
            Me.txt_kota_toko.Text = kota_toko
            If Not IsDBNull(toko(0).kdpos_toko) Then
                kdpos_toko = toko(0).kdpos_toko
            End If
            Me.txt_kdpos_toko.Text = kdpos_toko
            If Not IsDBNull(toko(0).tlp_toko) Then
                tlp_toko = toko(0).tlp_toko
            End If
            Me.txt_tlp_toko.Text = tlp_toko
            If Not IsDBNull(toko(0).nama_owner) Then
                nama_owner = toko(0).nama_owner
            End If
            Me.txt_nama_owner.Text = nama_owner
            If Not IsDBNull(toko(0).tlp_owner) Then
                tlp_owner = toko(0).tlp_owner
            End If
            Me.txt_tlp_owner.Text = tlp_owner
            If Not IsDBNull(toko(0).norek_owner) Then
                norek_owner = toko(0).norek_owner
            End If
            Me.txt_norek_owner.Text = norek_owner
            If Not IsDBNull(toko(0).logo_toko) Then
                    If toko(0).logo_toko <> Nothing Then
                    'Me.txt_logo_toko.Text = toko(0).logo_toko
                    Dim tClient As WebClient = New WebClient
                        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(toko(0).logo_toko.ToString)))
                        Me.logo_toko.BackgroundImage = downloadImage
                    End If
                End If

            End If
    End Sub


End Class