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
        BarangMasuk.txt_harga_modal.Text = 0
        BarangMasuk.txt_harga_barang.Text = 0

        If Me.MenuStrip1.Tag.IdLevel = 2 Then
            BarangMasuk.txt_harga_modal.Visible = False
            BarangMasuk.dt_barang_masuk.Columns(10).Visible = False
            BarangMasuk.data_barang_masuk.Columns(10).Visible = False
        ElseIf Me.MenuStrip1.Tag.IdLevel = 1 Then
            BarangMasuk.txt_harga_modal.Visible = True
            BarangMasuk.dt_barang_masuk.Columns(10).Visible = True
            BarangMasuk.data_barang_masuk.Columns(10).Visible = True
        Else
            BarangMasuk.txt_harga_modal.Visible = False
            BarangMasuk.dt_barang_masuk.Columns(10).Visible = False
            BarangMasuk.data_barang_masuk.Columns(10).Visible = False
        End If

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
        MasterUser.UserInfo = Me.MenuStrip1.Tag
        MasterUser.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_barang_masuk.Visible = True
        BarangKeluarToolStripMenuItem.Visible = True
        QuotationToolStripMenuItem.Visible = True
        CetakToolStripMenuItem.Visible = True
        MasterDataToolStripMenuItem.Visible = True
        btn_master_data_user.Visible = True
        ccc.Visible = True
        btn_r_hasil_penjualan.Visible = True
        btn_r_invoice_keluar.Visible = True
        btn_r_barang_rental.Visible = True
        btn_r_garansi.Visible = False

        If Me.MenuStrip1.Tag.IdLevel = 3 Then
            btn_barang_masuk.Visible = False
            BarangKeluarToolStripMenuItem.Visible = False
            QuotationToolStripMenuItem.Visible = False
            CetakToolStripMenuItem.Visible = False
            MasterDataToolStripMenuItem.Visible = False
            btn_master_data_user.Visible = False
        ElseIf Me.MenuStrip1.Tag.IdLevel = 4 Then
            btn_barang_masuk.Visible = False
            BarangKeluarToolStripMenuItem.Visible = False
            QuotationToolStripMenuItem.Visible = False
            CetakToolStripMenuItem.Visible = False
            MasterDataToolStripMenuItem.Visible = False
            btn_master_data_user.Visible = False
            ccc.Visible = False
            btn_r_hasil_penjualan.Visible = False
            btn_r_invoice_keluar.Visible = False
            btn_r_barang_rental.Visible = False
            btn_r_garansi.Visible = False
        End If
    End Sub
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btn_r_barang_masuk_Click(sender As Object, e As EventArgs) Handles ccc.Click
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

    Private Sub btn_r_stock_barang_Click(sender As Object, e As EventArgs) Handles btn_r_stock_barang.Click
        Laporan_Stock_Barang.Show()
    End Sub

    Private Sub p_logo_Click(sender As Object, e As EventArgs) Handles p_logo.Click

    End Sub

    Private Sub btn_master_ubahprofil_Click(sender As Object, e As EventArgs) Handles btn_master_ubahprofil.Click
        Form3.UserInfo = Me.MenuStrip1.Tag
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btn_r_hasil_penjualan_Click(sender As Object, e As EventArgs) Handles btn_r_hasil_penjualan.Click
        Laporan_Barang_Penjualan.Show()
    End Sub
End Class