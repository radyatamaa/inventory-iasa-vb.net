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
Public Class MasterUser
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
    Function GetLevel() As List(Of Object)
        Dim result As New List(Of Object)
        'result.Add(levelREsult)
        Dim query As String = "SELECT * FROM tbl_level WHERE is_active = 1 "
        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        reader = cmd.ExecuteReader()
        'This will loop through all returned records 
        While reader.Read
            Dim level As New With {
                            .nama_level = reader("nama_level").ToString,
                            .id_level = reader("id_level")
                            }
            result.Add(level)
            'handle returned value before next loop here
        End While
        CONN.Close()
        Return result
    End Function

    Function GetDataUser() As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_user t
		                          INNER JOIN tbl_level j ON t.id_level = j.id_level
                                  WHERE t.is_active = 1 "

        cmd.CommandText = query
        cmd.CommandType = CommandType.Text
        cmd.Connection = CONN
        CONN.Open()
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader

        While reader.Read
            Dim level = New With
                {
                .id_user = reader("id_user"),
                    .username = reader("username"),
            .nama = reader("nama"),
            .password = reader("password"),
            .nama_level = reader("nama_level"),
            .id_level = reader("id_level")
                }

            result.Add(level)

        End While

        For Each insertDataBarangMasuk As Object In result
            data_master_user.Rows.Add(1)

            data_master_user.Rows(data_master_user.RowCount - 2).Cells(0).Value = insertDataBarangMasuk.id_user
            data_master_user.Rows(data_master_user.RowCount - 2).Cells(1).Value = insertDataBarangMasuk.username
            data_master_user.Rows(data_master_user.RowCount - 2).Cells(2).Value = insertDataBarangMasuk.nama
            data_master_user.Rows(data_master_user.RowCount - 2).Cells(3).Value = insertDataBarangMasuk.password
            data_master_user.Rows(data_master_user.RowCount - 2).Cells(4).Value = insertDataBarangMasuk.id_level

            data_master_user.Update()
        Next

        CONN.Close()

        Return result
    End Function
    Function GetDatauserById(iduser As Integer) As List(Of Object)
        Dim result As New List(Of Object)
        Dim query As String = "SELECT * FROM tbl_user t
		                          INNER JOIN tbl_level j ON t.id_level = j.id_level
                                  WHERE t.is_active = 1 AND t.id_user = " + iduser.ToString

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
            .nama = reader("nama"),
            .password = reader("password"),
            .nama_level = reader("nama_level"),
            .id_level = reader("id_level")
                }

            result.Add(user)

        End While

        CONN.Close()

        Return result
    End Function

    Function Simpanuser(user As Object) As Integer
        Dim userlogin As String = ""
        Dim iduser As Integer
        If UserInfo IsNot Nothing Then
            userlogin = UserInfo.Username
        End If
        If user.id_user <> 0 Then
            Try
                Dim queryTbluser As String = " UPDATE tbl_user SET 
                                    username =  '" + user.username + "',
                                    nama =  '" + user.nama + "',
                                    password =  '" + user.password + "',
                                    id_level =  " + user.id_level.ToString + ",
                                    updated_by =  '" + userlogin + "',
                                    updated_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                            WHERE  id_user = " + user.id_user.ToString


                cmd.CommandText = queryTbluser
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                reader = cmd.ExecuteReader()
                CONN.Close()
                iduser = user.id_user

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                userId = 0
            End Try
            Return iduser
        Else
            Try
                Dim queryTbluser As String = " INSERT INTO tbl_user (
                                    username,
                                    nama,
                                    password,
                                    id_level,
                                    created_by,
                                    created_date,
                                    is_active) 
                            VALUES (
                                    '" + user.username + "',
                                    '" + user.nama + "',
                                    '" + user.password + "',
                                    " + user.id_level.ToString + ",
                                    '" + userlogin + "',
                                    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME),
                                    " + 1.ToString + "
                                    ); SELECT SCOPE_IDENTITY() "


                cmd.CommandText = queryTbluser
                cmd.CommandType = CommandType.Text
                cmd.Connection = CONN
                CONN.Open()
                iduser = cmd.ExecuteScalar()
                CONN.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                userId = 0
            End Try
            Return iduser
        End If

    End Function

    Function Deleteuser(iduser As Integer)
        Try
            Dim userlogin As String = ""
            If UserInfo IsNot Nothing Then
                userlogin = UserInfo.Username
            End If
            Dim queryTblBarang As String = "UPDATE tbl_user SET 
                                    is_active = 0 ,
                                    deleted_by =   '" + userlogin + "',
                                    deleted_date =    CAST('" + DateTime.Now.ToString("s", DateTimeFormatInfo.InvariantInfo) + "'AS DATETIME)
                                WHERE id_user = " + iduser.ToString
            cmd.CommandText = queryTblBarang
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

    End Function
    Private Sub btn_kembali_Click(sender As Object, e As EventArgs) Handles btn_kembali.Click
        MenuUtama.MenuStrip1.Tag = UserInfo
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub MasterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            userId = 0
            VBnetSQLSeverConnection()
            GetDataUser()
            Dim listbarang As List(Of Object) = GetLevel()
            If listbarang.Count > 0 Then
                cmb_id_level.DataSource = listbarang
                cmb_id_level.DisplayMember = "nama_level"
                cmb_id_level.ValueMember = "id_level"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus?",
                            "Hapus Data",
                            MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            Dim iduser = userId
            Deleteuser(iduser)
            data_master_user.Rows.Clear()
            GetDataUser()
            Me.txt_username.Text = ""
            Me.txt_nama_lengkap.Text = ""
            Me.txt_password.Text = ""
        Else
        End If
    End Sub
    Private Sub data_master_user_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_user.CellClick
        Dim iduser = data_master_user.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim user = GetDatauserById(iduser)

        If user.Count > 0 Then
            userId = user(0).id_user
            Me.txt_username.Text = user(0).username
            Me.txt_nama_lengkap.Text = user(0).nama
            Me.txt_password.Text = user(0).password
            Me.cmb_id_level.SelectedValue = user(0).id_level

        End If
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertDataUser = New With
            {
            .id_user = userId,
            .username = Me.txt_username.Text,
            .nama = Me.txt_nama_lengkap.Text,
            .password = Me.txt_password.Text,
             .nama_level = Me.cmb_id_level.SelectedItem.nama_level,
             .id_level = Me.cmb_id_level.SelectedValue
            }

        Dim iduser As Integer = Simpanuser(insertDataUser)
        data_master_user.Rows.Clear()
        GetDataUser()
        Me.txt_username.Text = ""
        Me.txt_nama_lengkap.Text = ""
        Me.txt_password.Text = ""
        MsgBox("Sukses!")


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub txt_nama_lengkap_TextChanged(sender As Object, e As EventArgs) Handles txt_nama_lengkap.TextChanged

    End Sub

    Private Sub data_master_user_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_master_user.CellContentClick

    End Sub

    Private Sub cmb_id_level_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_id_level.SelectedIndexChanged

    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class