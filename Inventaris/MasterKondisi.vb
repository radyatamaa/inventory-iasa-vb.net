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
Public Class MasterKondisi
    Dim CONN As SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim kondisiId As Integer

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
    Function Simpankondisi(kondisi As Object) As Integer
        Dim userlogin As String = ""
        Dim idkondisi As Integer
        If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
            userlogin = MenuUtama.MenuStrip1.Tag.Username
        End If
        If kondisi.id_kondisi <> 0 Then
            Try
                Dim queryTblkondisi As String = " UPDATE tbl_kondisi SET 
                                    nama_kondisi =  '" + kondisi.nama_kondisi + "',
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_kondisi = " + kondisi.id_kondisi.ToString


                cmd.CommandText = queryTblkondisi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                idkondisi = kondisi.id_kondisi

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                kondisiId = 0
            End Try
            Return idkondisi
        Else
            Try
                Dim queryTblkondisi As String = " INSERT INTO tbl_kondisi (
                                    nama_kondisi,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + kondisi.nama_kondisi + "',
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTblkondisi
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                idkondisi = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                kondisiId = 0
            End Try
            Return idkondisi
        End If

    End Function

    Function GetDatakondisi() As List(Of Object)
        Dim resultkondisi As New List(Of Object)
        Dim querykondisi As String = "SELECT * FROM tbl_kondisi t
                                  WHERE t.is_active = 1 "

        cmd.CommandText = querykondisi
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim kondisi = New With
                {
                .id_kondisi = reader("id_kondisi"),
            .nama_kondisi = reader("nama_kondisi")
                }

            resultkondisi.Add(kondisi)

        End While

        For Each insertDataBarangMasuk As Object In resultkondisi
            data_master_kondisi.Rows.Add(1)

            data_master_kondisi.Rows(data_master_kondisi.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_kondisi
            data_master_kondisi.Rows(data_master_kondisi.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.nama_kondisi


            data_master_kondisi.Update()
        Next

        CONN.Close()

        Return resultkondisi
    End Function
    Function GetDatakondisiById(idkondisi As Integer) As List(Of Object)
        Dim resulteditkondisi As New List(Of Object)
        Dim queryeditkondisi As String = "SELECT * FROM tbl_kondisi t		                     
                                  WHERE t.is_active = 1 AND t.id_kondisi = " + idkondisi.ToString

        cmd.CommandText = queryeditkondisi
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim kondisi = New With
                {
                .id_kondisi = reader("id_kondisi"),
            .nama_kondisi = reader("nama_kondisi")
                }

            resulteditkondisi.Add(kondisi)

        End While

        CONN.Close()

        Return resulteditkondisi
    End Function
    Function Deletekondisi(idkondisi As Integer)
        Try
            Dim userlogin As String = ""
            If MenuUtama.MenuStrip1.Tag IsNot Nothing Then
                userlogin = MenuUtama.MenuStrip1.Tag.Username
            End If
            Dim queryTblkondisi As String = "UPDATE tbl_kondisi SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_kondisi = " + idkondisi.ToString
            cmd.CommandText = queryTblkondisi
            cmd.CommandType = CommandType.Text
            cmd.Connection = CONN
            CONN.Open()
            reader = cmd.ExecuteReader()
            CONN.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            kondisiId = 0
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

    Private Sub btn_master_kondisi_Click(sender As Object, e As EventArgs)
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



    Private Sub btn_master_status_Click(sender As Object, e As EventArgs)
        MasterStatus.Show()
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

    Private Sub MasterKondisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            kondisiId = 0
            VBnetSQLSeverConnection()
            GetDatakondisi()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertDatakondisi = New With
          {
          .id_kondisi = kondisiId,
           .nama_kondisi = Me.txt_nama_kondisi.Text
          }

        Dim idkondisi As Integer = Simpankondisi(insertDatakondisi)
        data_master_kondisi.Rows.Clear()
        GetDatakondisi()
        Me.txt_nama_kondisi.Text = ""
        MsgBox("Sukses!")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim resulthapuskondisi As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                          "Hapus Data",
                          MessageBoxButtons.YesNo)

        If (resulthapuskondisi = DialogResult.Yes) Then
            Dim idkondisi = kondisiId
            Deletekondisi(idkondisi)
            data_master_kondisi.Rows.Clear()
            GetDatakondisi()
            Me.txt_nama_kondisi.Text = ""

        Else
        End If
    End Sub
    Private Sub data_master_kondisi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_kondisi.CellClick
        Dim idkondisi = data_master_kondisi.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim kondisi = GetDatakondisiById(idkondisi)


        If kondisi.Count > 0 Then
            Try
                kondisiId = kondisi(0).id_kondisi
                Me.txt_nama_kondisi.Text = kondisi(0).nama_kondisi
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub data_master_kondisi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_kondisi.CellContentClick

    End Sub

    Private Sub data_master_kondisi_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_kondisi.CellContextMenuStripChanged

    End Sub
End Class