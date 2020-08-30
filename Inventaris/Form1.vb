Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net

Public Class Form1
    Function GetToko() As List(Of Object)
        Dim result As New List(Of Object)
        Using connObj As New SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings("myConnectionString").ConnectionString)
            Using cmdObj As New SqlClient.SqlCommand("SELECT id_toko, nama_toko, logo_toko FROM tbl_toko WHERE is_active = 1 ", connObj)
                connObj.Open()
                Using readerObj As SqlClient.SqlDataReader = cmdObj.ExecuteReader
                    'This will loop through all returned records 
                    While readerObj.Read
                        Dim toko As New With {
                            .IdToko = readerObj("id_toko"),
                            .NamaToko = readerObj("nama_toko").ToString,
                            .LogoToko = readerObj("logo_toko").ToString
                            }
                        result.Add(toko)
                        'handle returned value before next loop here
                    End While
                End Using
                connObj.Close()
            End Using
        End Using

        Return result
    End Function
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

            Form2.Panel1.Tag = user
            Dim listToko = GetToko()
            For i As Integer = 0 To 3
                Dim tkButton As Control() = Form2.Controls.Find("btntk" + i.ToString(), True)
                Dim tklabel As Control() = Form2.Controls.Find("lbltk" + i.ToString(), True)

                Try
                    If listToko(i).LogoToko.ToString <> "" Then
                        Dim tClient As WebClient = New WebClient
                        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(listToko(i).LogoToko.ToString)))
                        tkButton.FirstOrDefault().BackgroundImage = downloadImage
                    End If
                    Dim standardData = New With
                {
                 .IdToko = listToko(i).IdToko,
                 .NamaToko = listToko(i).NamaToko,
                 .Username = user.Username,
                 .Nama = user.Nama,
                 .IdLevel = user.IdLevel,
                 .LogoToko = listToko(i).LogoToko
                }
                    tkButton.FirstOrDefault().Tag = standardData
                    tklabel.FirstOrDefault().Text = standardData.NamaToko
                    'rmButton.FirstOrDefault().Show()
                    'lastIndex = lastIndex + 1
                Catch ex As Exception

                End Try

            Next i

            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Username dan Password Salah!")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.UseSystemPasswordChar = True Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub
End Class
