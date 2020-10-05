Imports System.Configuration
Imports System.IO
Imports System.Net

Public Class Form2

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btntk0.Click
        MenuUtama.MenuStrip1.Tag = btntk0.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk0.Tag
        MenuUtama.Show()
        Me.Hide()
    End Sub
    Private Sub btntk1_Click(sender As Object, e As EventArgs) Handles btntk1.Click
        MenuUtama.MenuStrip1.Tag = btntk1.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk1.Tag
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub btntk2_Click(sender As Object, e As EventArgs) Handles btntk2.Click
        MenuUtama.MenuStrip1.Tag = btntk2.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk2.Tag
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub btntk3_Click(sender As Object, e As EventArgs) Handles btntk3.Click
        MenuUtama.MenuStrip1.Tag = btntk3.Tag
        'BarangMasuk.MenuStrip1.Tag = btntk3.Tag
        MenuUtama.Show()
        Me.Hide()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Friend Shared Function UserInfo() As Object
        Throw New NotImplementedException()
    End Function
End Class