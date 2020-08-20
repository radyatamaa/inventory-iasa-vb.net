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

Public Class MasterDetailLokasi
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim detaillokasiId As Integer
    Dim listDetailLokasiHandle As New List(Of Object)
    Dim listIdDetailLokasi As New List(Of Integer)
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
    Function GetLokasi() As List(Of Object)
        Dim result As New List(Of Object)
        'result.Add(lokasiREsult)
        Dim query As String = "SELECT * FROM tbl_lokasi WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim lokasi As New With {
                            .nama_lokasi = reader("nama_lokasi").ToString,
                            .id_lokasi = reader("id_lokasi")
                            }
            result.Add(lokasi)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function

    Function GetDataDetailLokasi() As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_detail_lokasi t
		                          INNER JOIN tbl_lokasi j ON t.id_lokasi = j.id_lokasi
                                  WHERE t.is_active = 1 "

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim detaillokasi = New With
                {
            .nama_lokasi = reader("nama_lokasi"),
            .id_detail_lokasi = reader("id_detail_lokasi"),
            .detail_lokasi = reader("detail_lokasi")
                }

            result.Add(detaillokasi)

        End While

        For Each insertDataDetailLokasi As Object In result
            data_master_detail.Rows.Add(1)

            'data_master_detail.Rows(data_master_detail.RowCount - 2).Cells(0).Value = False
            data_master_detail.Rows(data_master_detail.RowCount - 2).Cells(0).Value = insertDataDetailLokasi.id_detail_lokasi
            data_master_detail.Rows(data_master_detail.RowCount - 2).Cells(1).Value = insertDataDetailLokasi.nama_lokasi
            data_master_detail.Rows(data_master_detail.RowCount - 2).Cells(2).Value = insertDataDetailLokasi.detail_lokasi

            data_master_detail.Update()
        Next

        'For i As Integer = 0 To data_master_detail.Rows.Count() - 1
        '     data_master_detail.Rows(i).Cells(0).Value = True
        '    data_master_detail.Rows(i).Cells(0).Value = deta id_detail_lokasi
        'Next

        CONN.Close()

        Return result
    End Function

    Function GetDataDetailLokasiById(idDetailLokasi As Integer) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_detail_lokasi t
		                          INNER JOIN tbl_lokasi j ON t.id_lokasi = j.id_lokasi
                                  WHERE t.is_active = 1 AND t.id_detail_lokasi = " + idDetailLokasi.ToString

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim detaillokasi = New With
                {
            .nama_lokasi = reader("nama_lokasi"),
            .id_detail_lokasi = reader("id_detail_lokasi"),
            .detail_lokasi = reader("detail_lokasi"),
            .id_lokasi = reader("id_lokasi")
                }

            result.Add(detaillokasi)

        End While

        CONN.Close()

        Return result
    End Function

    Function SimpanDetailLokasi(detail_lokasi As Object) As Integer
        Dim userlogin As String = ""
        Dim idDetailLokasi As Integer
        If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
            userlogin = MenuUtama.MenuStrip1.Tag.Username
        End If
        If detail_lokasi.id_detail_lokasi <> 0 Then
            Try
                Dim queryTblDetailLokasi As String = " UPDATE tbl_detail_lokasi SET 
                                    detail_lokasi =  '" + detail_lokasi.detail_lokasi + "',
                                    id_lokasi =  '" + detail_lokasi.id_lokasi.ToString + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_detail_lokasi = " + detail_lokasi.id_detail_lokasiToString


                cmd.CommandText = queryTblDetailLokasi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idDetailLokasi = detail_lokasi.id_detail_lokasi

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                detaillokasiId = 0
            End Try
            Return idDetailLokasi
        Else
            Try
                Dim queryTblDetailLokasi As String = " INSERT INTO tbl_detail_lokasi (
                                    detail_lokasi,
                                    id_lokasi,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + detail_lokasi.detail_lokasi + "',
                                    " + detail_lokasi.id_lokasi.ToString + ",
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTblDetailLokasi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idDetailLokasi = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                detaillokasiId = 0
            End Try
            Return idDetailLokasi
        End If

    End Function

    Function DeleteDetailLokasi(idDetailLokasi As Integer)
        Try
            Dim userlogin As String = ""
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                userlogin = MenuUtama.MenuStrip1.Tag.Username
            End If
            'For i As Integer = 0 To data_master_detail.Rows.Count() - 1
            'If data_master_detail.Rows(i).Cells(0).Value = True Then
            Dim queryTblDetailLokasi As String = "UPDATE tbl_detail_lokasi SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_detail_lokasi = " + idDetailLokasi.ToString
            cmd.CommandText = queryTblDetailLokasi
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()
            'End If
            'Next

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            detaillokasiId = 0
        End Try

    End Function

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub MasterDetailLokasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            detaillokasiId = 0
            VBnetSQLSeverConnection()
            GetDataDetailLokasi()
            Dim listlokasi As List(Of Object) = GetLokasi()
            If listlokasi.Count > 0 Then
                cmb_id_lokasi.DataSource = listlokasi
                cmb_id_lokasi.DisplayMember = "nama_lokasi"
                cmb_id_lokasi.ValueMember = "id_lokasi"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        'Dim imagePath As String = UploadToStorageAzure(Me.txt_foto.Text)
        Dim insertDataDetailLokasi = New With
            {
            .id_detail_lokasi = detaillokasiId,
             .nama_lokasi = Me.cmb_id_lokasi.SelectedItem.nama_lokasi,
             .id_lokasi = Me.cmb_id_lokasi.SelectedValue,
             .detail_lokasi = Me.txt_detail_lokasi.Text
            }

        Dim idDetailLokasi As Integer = SimpanDetailLokasi(insertDataDetailLokasi)
        data_master_detail.Rows.Clear()
        GetDataDetailLokasi()
        Me.txt_detail_lokasi.Text = ""
        MsgBox("Sukses!")

    End Sub

    Private Sub hapus_data_detail_lokasi_Click(sender As Object, e As EventArgs) Handles hapus_data_detail_lokasi.Click

        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                             "Hapus Data",
                             MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Dim idDetailLokasi = detaillokasiId
            For Each item As Object In listIdDetailLokasi
                If item IsNot Nothing Then
                    DeleteDetailLokasi(item)
                    data_master_detail.Rows.Clear()
                    GetDataDetailLokasi()
                    Me.txt_detail_lokasi.Text = ""
                End If
            Next

        Else
        End If

    End Sub


    Private Sub data_master_detail_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_detail.CellClick
        'Dim idDetailLokasi = data_master_detail.Rows(e.RowIndex).Cells(0).Value.ToString
        'Dim detaillokasi = GetDataDetailLokasiById(idDetailLokasi)
        Dim selectedIdDetailLokasi = data_master_detail.SelectedRows
        listIdDetailLokasi.Clear()
        ' If detaillokasi.Count > 0 Then
        'Try
        'detaillokasiId = detaillokasi(0).id_detail_lokasi
        'Me.txt_detail_lokasi.Text = detaillokasi(0).detail_lokasi
        'Me.cmb_id_lokasi.SelectedValue = detaillokasi(0).id_lokasi
        'Catch ex As Exception

        'End Try

        'End If

        For Each selectedItem As DataGridViewRow In selectedIdDetailLokasi

            Dim id = selectedItem.Cells(0).Value
            'Dim checkDuplicate As Object = listBarangMasukHandle.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            'If checkDuplicate Is Nothing Then
            'Dim barang As Integer = listBarangMasuk.Where(Function(x) x.id_barang_masuk = idBarangMasuk).FirstOrDefault()
            listIdDetailLokasi.Add(id)
            'End If

        Next selectedItem

    End Sub

    Private Sub data_master_detail_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_detail.CellContentClick

    End Sub
End Class
