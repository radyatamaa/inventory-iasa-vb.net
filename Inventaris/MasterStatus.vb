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
Public Class MasterStatus
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim statusId As Integer
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
    Function Simpanstatus(status As Object) As Integer
        Dim userlogin As String = ""
        Dim idstatus As Integer
        If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
            userlogin = MenuUtama.MenuStrip1.Tag.Username
        End If
        If status.id_status_barang <> 0 Then
            Try
                Dim queryTblstatus As String = " UPDATE tbl_status_barang SET 
                                    nama_status =  '" + status.nama_status + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_status_barang = " + status.id_status_barang.ToString


                cmd.CommandText = queryTblstatus
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idstatus = status.id_status_barang

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                statusId = 0
            End Try
            Return idstatus
        Else
            Try
                Dim queryTblstatus As String = " INSERT INTO tbl_status_barang (
                                    nama_status,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + status.nama_status + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTblstatus
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idstatus = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                statusId = 0
            End Try
            Return idstatus
        End If

    End Function

    Function GetDatastatus() As List(Of Object)
        Dim resultstatus As New List(Of Object)
        Dim querystatus As String = "SELECT * FROM tbl_status_barang t
                                  WHERE t.is_active = 1 "

        cmd.CommandText = querystatus
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim status = New With
                {
                .id_status_barang = reader("id_status_barang"),
            .nama_status = reader("nama_status")
                }

            resultstatus.Add(status)

        End While

        For Each insertDataBarangMasuk As Object In resultstatus
            data_master_status.Rows.Add(1)

            data_master_status.Rows(data_master_status.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_status_barang
            data_master_status.Rows(data_master_status.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_status


            data_master_status.Update()
        Next

        CONN.Close()

        Return resultstatus
    End Function
    Function GetDatastatusById(idstatus As Integer) As List(Of Object)
        Dim resulteditstatus As New List(Of Object)
        Dim queryeditstatus As String = "SELECT * FROM tbl_status_barang t		                     
                                  WHERE t.is_active = 1 AND t.id_status_barang = " + idstatus.ToString

        cmd.CommandText = queryeditstatus
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim status = New With
                {
                .id_status_barang = reader("id_status_barang"),
            .nama_status = reader("nama_status")
                }

            resulteditstatus.Add(status)

        End While

        CONN.Close()

        Return resulteditstatus
    End Function
    Function Deletestatus(idstatus As Integer)
        Try
            Dim userlogin As String = ""
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                userlogin = MenuUtama.MenuStrip1.Tag.Username
            End If
            Dim queryTblstatus As String = "UPDATE tbl_status_barang SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_status_barang = " + idstatus.ToString
            cmd.CommandText = queryTblstatus
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            statusId = 0
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
    Private Sub btn_penjualan_Click(sender As Object, e As EventArgs)
        BarangKeluar.Show()
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

    Private Sub btn_master_jenis_Click(sender As Object, e As EventArgs)
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

    Private Sub btn_master_client_Click(sender As Object, e As EventArgs)
        MasterClient.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_kondisi_Click(sender As Object, e As EventArgs)
        MasterKondisi.Show()
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

    Private Sub MasterStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            statusId = 0
            VBnetSQLSeverConnection()
            GetDatastatus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertDatastatus = New With
          {
          .id_status_barang = statusId,
           .nama_status = Me.txt_status.Text
          }

        Dim idstatus As Integer = Simpanstatus(insertDatastatus)
        data_master_status.Rows.Clear()
        GetDatastatus()
        Me.txt_status.Text = ""
        MsgBox("Sukses!")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim resulthapusstatus As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                          "Hapus Data",
                          MessageBoxButtons.YesNo)

        If (resulthapusstatus = DialogResult.Yes) Then
            Dim idstatus = statusId
            Deletestatus(idstatus)
            data_master_status.Rows.Clear()
            GetDatastatus()
            Me.txt_status.Text = ""

        Else
        End If
    End Sub

    Private Sub data_master_status_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_status.CellContentClick

    End Sub

    Private Sub data_master_status_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_status.CellClick
        Dim idstatus = data_master_status.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim status = GetDatastatusById(idstatus)

        If status.Count > 0 Then
            Try
                statusId = status(0).id_status_barang
                Me.txt_status.Text = status(0).nama_status
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class