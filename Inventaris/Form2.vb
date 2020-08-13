Imports System.Configuration
Imports System.IO
Imports System.Net

Public Class Form2
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
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btntk0.Click
        MenuUtama.MenuStrip1.Tag = btntk0.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk0.Tag
        MenuUtama.Show()
        Me.Close()
    End Sub
    Private Sub btntk1_Click(sender As Object, e As EventArgs) Handles btntk1.Click
        MenuUtama.MenuStrip1.Tag = btntk1.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk1.Tag
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub btntk2_Click(sender As Object, e As EventArgs) Handles btntk2.Click
        MenuUtama.MenuStrip1.Tag = btntk2.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk2.Tag
        MenuUtama.Show()
        Me.Close()
    End Sub

    Private Sub btntk3_Click(sender As Object, e As EventArgs) Handles btntk3.Click
        MenuUtama.MenuStrip1.Tag = btntk3.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk3.Tag
        MenuUtama.Show()
        Me.Close()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim listToko = GetToko()
        For i As Integer = 0 To 3
            Dim tkButton As Control() = Me.Controls.Find("btntk" + i.ToString(), True)

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
                 .Username = Me.Panel1.Tag.Username,
                 .Nama = Me.Panel1.Tag.Nama,
                 .IdLevel = Me.Panel1.Tag.IdLevel
                }
                tkButton.FirstOrDefault().Tag = standardData
                tkButton.FirstOrDefault().Text = standardData.NamaToko
                'rmButton.FirstOrDefault().Show()
                'lastIndex = lastIndex + 1
            Catch ex As Exception

            End Try

        Next i

    End Sub


End Class