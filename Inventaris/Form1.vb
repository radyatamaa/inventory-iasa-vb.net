Imports System.Configuration
Imports System.Data.SqlClient
Public Class Form1
    Public Function Login(usernameLogin As String, passwordLogin As String) As Object
        Dim username As String
        Dim nama As String
        Dim idLevel As String
        Dim result
        Using connObj As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString)
            Using cmdObj As New SqlClient.SqlCommand("SELECT username, nama, id_level FROM tbl_user WHERE is_active = 1 AND username = '" + usernameLogin + "' AND password = '" + passwordLogin + "'", connObj)
                connObj.Open()
                Using readerObj As SqlClient.SqlDataReader = cmdObj.ExecuteReader
                    'This will loop through all returned records 
                    While readerObj.Read
                        username = readerObj("username").ToString
                        nama = readerObj("nama").ToString
                        idLevel = readerObj("id_level").ToString
                        'handle returned value before next loop here
                    End While
                End Using
                connObj.Close()
            End Using
        End Using
        result = New With {
            .Username = username,
            .Nama = nama,
            .IdLevel = idLevel
            }
        Return result
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim user As Object = Login(Me.TextBox2.Text, Me.TextBox1.Text)
        If user.username IsNot Nothing Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Username dan Password Salah!")
        End If
    End Sub
End Class
