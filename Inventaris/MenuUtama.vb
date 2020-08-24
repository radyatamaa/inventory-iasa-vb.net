Imports System.Collections.Specialized
Imports System.Runtime.Serialization
Imports Microsoft.Extensions.Caching.Memory
Imports Newtonsoft.Json

Public Class MenuUtama
    'Public Shared ObjInfoCache As MemoryCache
    'Shared Sub New()

    '    ''Dim userLoginInfo = Me.MenuStrip1.Tag
    '    'Dim CacheSettings As NameValueCollection = New NameValueCollection(3)
    '    'CacheSettings.Add("CacheMemoryLimitMegabytes", 1024.ToString())
    '    'CacheSettings.Add("physicalMemoryLimitPercentage", 50.ToString())
    '    'CacheSettings.Add("pollingInterval", TimeSpan.FromMinutes(2).ToString())
    '    'Try

    '    '    ObjInfoCache = New MemoryCache("TestCache", CacheSettings)
    '    'Catch ex As Exception
    '    '    MsgBox(ex.Message)
    '    'End Try

    'End Sub
    Private Sub btn_barang_masuk_Click(sender As Object, e As EventArgs) Handles btn_barang_masuk.Click
        'BarangMasuk.MenuStrip1.Tag = BarangMasuk.MenuStrip1.Tag
        BarangMasuk.UserInfo = Me.MenuStrip1.Tag
        BarangMasuk.Show()
        Me.Close()
    End Sub
    Private Sub btn_penjualan_Click(sender As Object, e As EventArgs) Handles btn_penjualan.Click
        BarangKeluar.UserInfo = Me.MenuStrip1.Tag
        BarangKeluar.Show()
        Me.Close()
    End Sub
    Private Sub btn_rental_Click(sender As Object, e As EventArgs) Handles btn_rental.Click
        Rental.UserInfo = Me.MenuStrip1.Tag
        Rental.Show()
        Me.Close()
    End Sub

    Private Sub btn_repair_Click(sender As Object, e As EventArgs) Handles btn_repair.Click
        Repair.UserInfo = Me.MenuStrip1.Tag
        Repair.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_jenis_Click(sender As Object, e As EventArgs) Handles btn_master_jenis.Click
        MasterJenisBarang.UserInfo = Me.MenuStrip1.Tag
        MasterJenisBarang.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_tipe_Click(sender As Object, e As EventArgs) Handles btn_master_tipe.Click
        MasterTipe.UserInfo = Me.MenuStrip1.Tag
        MasterTipe.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_toko_Click(sender As Object, e As EventArgs) Handles btn_master_toko.Click
        MasterDataToko.UserInfo = Me.MenuStrip1.Tag
        MasterDataToko.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_client_Click(sender As Object, e As EventArgs) Handles btn_master_client.Click
        MasterClient.UserInfo = Me.MenuStrip1.Tag
        MasterClient.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_kondisi_Click(sender As Object, e As EventArgs) Handles btn_master_kondisi.Click
        MasterKondisi.UserInfo = Me.MenuStrip1.Tag
        MasterKondisi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_status_Click(sender As Object, e As EventArgs) Handles btn_master_status.Click
        MasterStatus.UserInfo = Me.MenuStrip1.Tag
        MasterStatus.Show()
        Me.Close()
    End Sub

    Private Sub MasterLokasiToolStripMenuIbtn_master_lokasi_Click(sender As Object, e As EventArgs) Handles MasterLokasiToolStripMenuIbtn_master_lokasi.Click
        MasterLokasi.UserInfo = Me.MenuStrip1.Tag
        MasterLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_detail_Click(sender As Object, e As EventArgs) Handles btn_master_detail.Click
        MasterDetailLokasi.UserInfo = Me.MenuStrip1.Tag
        MasterDetailLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_alasan_Click(sender As Object, e As EventArgs) Handles btn_master_alasan.Click
        MasterAlasan.UserInfo = Me.MenuStrip1.Tag
        MasterAlasan.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_data_user_Click(sender As Object, e As EventArgs) Handles btn_master_data_user.Click
        'MasterAlasan.UserInfo = Me.MenuStrip1.Tag
        MasterUser.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btn_r_barang_masuk_Click(sender As Object, e As EventArgs) Handles btn_r_barang_masuk.Click
        Laporan_Barang_Masuk.Show()
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click

    End Sub

    Private Sub ReplacementBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplacementBarangToolStripMenuItem.Click

    End Sub

    Private Sub ExtendRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtendRentalToolStripMenuItem.Click
        extend_rental.Show()
    End Sub

    Private Sub CetakInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakInvoiceToolStripMenuItem.Click
        invoice_cetak.Show()
    End Sub
End Class