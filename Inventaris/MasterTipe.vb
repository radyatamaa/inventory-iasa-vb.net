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

Public Class MasterTipe
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim tipeId As Integer
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

    Function GetJenis() As List(Of Object)
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

    Function GetDataTipe() As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_tipe t
		                          INNER JOIN tbl_jenis j ON t.id_jenis = j.id_jenis
                                  WHERE t.is_active = 1 "

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim tipe = New With
                {
                    .nama_tipe = reader("nama_tipe"),
            .image_url = reader("image_url"),
            .id_jenis = reader("id_jenis"),
            .nama_jenis = reader("nama_jenis"),
            .id_tipe = reader("id_tipe")
                }

            result.Add(tipe)

        End While

        For Each insertDataBarangMasuk As Object In result
            data_master_tipe.Rows.Add(1)

            data_master_tipe.Rows(data_master_tipe.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_tipe
            data_master_tipe.Rows(data_master_tipe.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_tipe
            data_master_tipe.Rows(data_master_tipe.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.nama_jenis
            data_master_tipe.Rows(data_master_tipe.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.image_url

            data_master_tipe.Update()
        Next

        CONN.Close()

        Return result
    End Function
    Function GetDataTipeById(idTipe As Integer) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_tipe t
		                          INNER JOIN tbl_jenis j ON t.id_jenis = j.id_jenis
                                  WHERE t.is_active = 1 AND t.id_tipe = " + idTipe.ToString

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim tipe = New With
                {
                    .nama_tipe = reader("nama_tipe"),
            .image_url = reader("image_url"),
            .id_jenis = reader("id_jenis"),
            .nama_jenis = reader("nama_jenis"),
            .id_tipe = reader("id_tipe")
                }

            result.Add(tipe)

        End While

        CONN.Close()

        Return result
    End Function

    Function SimpanTipe(tipe As Object) As Integer
        Dim userlogin As String = ""
        Dim idTipe As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
        End If
        If tipe.id_tipe <> 0 Then
            Try
                Dim queryTblTipe As String = " UPDATE tbl_tipe SET 
                                    nama_tipe =  '" + tipe.nama_tipe + "',
                                    id_jenis =  " + tipe.id_jenis.ToString + ",
                                    image_url =  '" + tipe.image_url.ToString + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_tipe = " + tipe.id_tipe.ToString


                cmd.CommandText = queryTblTipe
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idTipe = tipe.id_tipe

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                tipeId = 0
            End Try
            Return idTipe
        Else
            Try
                Dim queryTblTipe As String = " INSERT INTO tbl_tipe (
                                    nama_tipe,
                                    id_jenis,
                                    image_url,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + tipe.nama_tipe + "',
                                    " + tipe.id_jenis.ToString + ",
                                    '" + tipe.image_url + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTblTipe
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idTipe = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                tipeId = 0
            End Try
            Return idTipe
        End If

    End Function

    Function DeleteTipe(idTipe As Integer)
        Try
            Dim userlogin As String = ""
            If UserInfo IsNot Nothing Then
                userlogin = UserInfo.Username
            End If
            Dim queryTblBarang As String = "UPDATE tbl_tipe SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_tipe = " + idTipe.ToString
            cmd.CommandText = queryTblBarang
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            tipeId = 0
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
            Dim cblob As CloudBlockBlob = cont.GetBlockBlobReference("tipe/" + fileImage + ".jpg")
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


    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.MenuStrip1.Tag = UserInfo
        MenuUtama.Show()
        Me.Close()

    End Sub

    Private Sub txt_foto_TextChanged(sender As Object, e As EventArgs) Handles txt_foto.TextChanged
        txt_foto.Text = (Replace(txt_foto.Text, "\", ";"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "Jpeg|*.JPG|Bitmap| *.BMP|Gif| *.GIF"
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then Exit Sub
        txt_foto.Text = OpenFileDialog1.FileName

    End Sub

    Private Sub MasterTipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tipeId = 0
            VBnetSQLSeverConnection()
            GetDataTipe()
            Dim listbarang As List(Of Object) = GetJenis()
            If listbarang.Count > 0 Then
                cmb_jenis_barang.DataSource = listbarang
                cmb_jenis_barang.DisplayMember = "nama_jenis"
                cmb_jenis_barang.ValueMember = "id_jenis"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmb_jenis_barang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_jenis_barang.SelectedIndexChanged

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim imagePath As String = ""
        If Me.txt_foto.Text <> "" Then
            imagePath = UploadToStorageAzure(Me.txt_foto.Text)
        ElseIf Me.txt_foto.Text = "" And tipeId <> 0 Then
            Dim tipe = GetDataTipeById(tipeId)
            imagePath = tipe(0).image_url
        End If
        Dim insertDataTipe = New With
            {
            .id_tipe = tipeId,
             .nama_jenis = Me.cmb_jenis_barang.SelectedItem.nama_jenis,
             .id_jenis = Me.cmb_jenis_barang.SelectedValue,
             .nama_tipe = Me.txt_tipe_barang.Text,
             .image_url = imagePath
            }

        Dim idTipe As Integer = SimpanTipe(insertDataTipe)
        data_master_tipe.Rows.Clear()
        GetDataTipe()
        Me.txt_tipe_barang.Text = ""
        Me.txt_foto.Text = ""
        MsgBox("Sukses!")

    End Sub

    Private Sub hapus_data_tipe_Click(sender As Object, e As EventArgs) Handles hapus_data_tipe.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                             "Hapus Data",
                             MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Dim idTipe = tipeId
            DeleteTipe(idTipe)
            data_master_tipe.Rows.Clear()
            GetDataTipe()
            Me.txt_tipe_barang.Text = ""
            Me.txt_foto.Text = ""
        Else
        End If
    End Sub

    Private Sub data_master_tipe_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_tipe.CellClick
        Dim idTipe = data_master_tipe.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim tipe = GetDataTipeById(idTipe)

        If tipe.Count > 0 Then
            tipeId = tipe(0).id_tipe
            Me.txt_tipe_barang.Text = tipe(0).nama_tipe
            Me.cmb_jenis_barang.SelectedValue = tipe(0).id_jenis
            If Not IsDBNull(tipe(0).image_url) Then
                If tipe(0).image_url <> Nothing Then
                    'Me.txt_foto.Text = tipe(0).image_url
                    Dim tClient As WebClient = New WebClient
                    Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(tipe(0).image_url.ToString)))
                    Me.image_url.BackgroundImage = downloadImage
                End If
            End If

        End If
    End Sub

    Private Sub data_master_tipe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_tipe.CellContentClick

    End Sub
End Class