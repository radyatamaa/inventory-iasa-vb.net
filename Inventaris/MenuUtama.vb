Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
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
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))

        BarangMasuk.UserInfo = Me.MenuStrip1.Tag
        BarangMasuk.cmb_jenis_barang.Text = ""
        BarangMasuk.cmb_tipe_barang.Text = ""
        BarangMasuk.cmb_detail_lokasi.Text = ""
        BarangMasuk.cmb_kondisi.Text = ""
        BarangMasuk.cmb_lokasi.Text = ""
        BarangMasuk.cmb_status.Text = ""
        BarangMasuk.pict_logo.BackgroundImage = downloadImage
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
        BarangKeluar.cmb_tipe_barang.Text = ""
        BarangKeluar.cmb_jenis_barang.Text = ""
        BarangKeluar.cmb_garansi.Text = ""
        BarangKeluar.cmb_client.Text = ""
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        BarangKeluar.pict_logo.BackgroundImage = downloadImage


        BarangKeluar.Show()
        Me.Close()
    End Sub
    Private Sub btn_rental_Click(sender As Object, e As EventArgs) Handles btn_rental.Click
        Rental.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        Rental.pict_logo.BackgroundImage = downloadImage
        Rental.Show()
        Me.Close()
    End Sub

    Private Sub btn_repair_Click(sender As Object, e As EventArgs) Handles btn_repair.Click
        Repair.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        Repair.pict_logo.BackgroundImage = downloadImage
        Repair.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_jenis_Click(sender As Object, e As EventArgs) Handles btn_master_jenis.Click
        MasterJenisBarang.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterJenisBarang.pict_logo.BackgroundImage = downloadImage
        MasterJenisBarang.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_tipe_Click(sender As Object, e As EventArgs) Handles btn_master_tipe.Click
        MasterTipe.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterTipe.pict_logo.BackgroundImage = downloadImage
        MasterTipe.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_toko_Click(sender As Object, e As EventArgs) Handles btn_master_toko.Click
        MasterDataToko.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterDataToko.pict_logo.BackgroundImage = downloadImage
        MasterDataToko.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_client_Click(sender As Object, e As EventArgs) Handles btn_master_client.Click
        MasterClient.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterClient.pict_logo.BackgroundImage = downloadImage
        MasterClient.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_kondisi_Click(sender As Object, e As EventArgs) Handles btn_master_kondisi.Click
        MasterKondisi.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterKondisi.pict_logo.BackgroundImage = downloadImage
        MasterKondisi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_status_Click(sender As Object, e As EventArgs) Handles btn_master_status.Click
        MasterStatus.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterStatus.pict_logo.BackgroundImage = downloadImage
        MasterStatus.Show()
        Me.Close()
    End Sub

    Private Sub MasterLokasiToolStripMenuIbtn_master_lokasi_Click(sender As Object, e As EventArgs) Handles MasterLokasiToolStripMenuIbtn_master_lokasi.Click
        MasterLokasi.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterLokasi.pict_logo.BackgroundImage = downloadImage
        MasterLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_detail_Click(sender As Object, e As EventArgs) Handles btn_master_detail.Click
        MasterDetailLokasi.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterDetailLokasi.pict_logo.BackgroundImage = downloadImage
        MasterDetailLokasi.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_alasan_Click(sender As Object, e As EventArgs) Handles btn_master_alasan.Click
        MasterAlasan.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterAlasan.pict_logo.BackgroundImage = downloadImage
        MasterAlasan.Show()
        Me.Close()
    End Sub

    Private Sub btn_master_data_user_Click(sender As Object, e As EventArgs) Handles btn_master_data_user.Click
        MasterUser.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        MasterUser.pict_logo.BackgroundImage = downloadImage
        MasterUser.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        Form1.Show()
        Me.Close()
        Form2.Close()
    End Sub

    Private Sub BarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))

        Me.p_logo.Image = downloadImage
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
        End If
    End Sub
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btn_r_barang_masuk_Click(sender As Object, e As EventArgs) Handles ccc.Click
        'Laporan_Barang_Masuk.user
        Laporan_Barang_Masuk.Show()
    End Sub

    Private Sub BarangKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangKeluarToolStripMenuItem.Click

    End Sub

    Private Sub ReplacementBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplacementBarangToolStripMenuItem.Click
        ReplacementBarang.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        ReplacementBarang.pict_logo.BackgroundImage = downloadImage
        ReplacementBarang.Show()
        Me.Close()
    End Sub

    Private Sub ExtendRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtendRentalToolStripMenuItem.Click
        extend_rental.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        extend_rental.pict_logo.BackgroundImage = downloadImage
        extend_rental.Show()
        Me.Close()
    End Sub

    Private Sub CetakInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakInvoiceToolStripMenuItem.Click
        invoice_cetak.UserInfo = Me.MenuStrip1.Tag
        invoice_cetak.Show()
    End Sub

    Private Sub btn_r_stock_barang_Click(sender As Object, e As EventArgs) Handles btn_r_stock_barang.Click
        Laporan_Stock_Barang.UserInfo = MenuStrip1.Tag
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

    Private Sub CetakTandaTerimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakTandaTerimaToolStripMenuItem.Click
        cetak_tanda_terima.UserInfo = Me.MenuStrip1.Tag
        cetak_tanda_terima.Show()
    End Sub

    Private Sub CetakKwitansiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakKwitansiToolStripMenuItem.Click
        cetak_kwitansi_barang.UserInfo = Me.MenuStrip1.Tag
        cetak_kwitansi_barang.Show()
    End Sub

    Private Sub MasterJenisMaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterJenisMaintenanceToolStripMenuItem.Click
        MasterJenisMaintenance.Show()
        Me.Hide()
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click
        transaksi_maintenance.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        transaksi_maintenance.pict_logo.BackgroundImage = downloadImage
        transaksi_maintenance.Show()
    End Sub

    Private Sub btn_r_barang_rental_Click(sender As Object, e As EventArgs) Handles btn_r_barang_rental.Click
        LaporanBarangRental.Show()
    End Sub

    Private Sub PengembalianBarangRentalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianBarangRentalToolStripMenuItem.Click
        PengembalianRental.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        PengembalianRental.pict_logo.BackgroundImage = downloadImage
        PengembalianRental.Show()
    End Sub

    Private Sub MaintenanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem1.Click
        LaporanMaintenance.UserInfo = Me.MenuStrip1.Tag
        LaporanMaintenance.Show()
    End Sub


    Private Sub GaransiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GaransiToolStripMenuItem1.Click
        FormGaransi.UserInfo = Me.MenuStrip1.Tag
        FormGaransi.Show()
    End Sub

    Private Sub StatusBarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StatusBarangToolStripMenuItem1.Click
        FormStatusBarang.UserInfo = Me.MenuStrip1.Tag
        FormStatusBarang.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click
        invoice_cetak.UserInfo = Me.MenuStrip1.Tag
        invoice_cetak.Show()
    End Sub

    Private Sub StockBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockBarangToolStripMenuItem.Click
        PengembalianRental.UserInfo = Me.MenuStrip1.Tag
        Dim tClient As WebClient = New WebClient
        Dim downloadImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Me.MenuStrip1.Tag.LogoToko.ToString)))
        PengembalianRental.pict_logo.BackgroundImage = downloadImage
        PengembalianRental.Show()
    End Sub

    Private Sub PilihTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PilihTokoToolStripMenuItem.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class