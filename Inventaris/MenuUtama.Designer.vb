<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btn_menuutama = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_barang_masuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_rental = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_repair = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_qrental = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_qinstallasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_qmaintenence = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_r_barang_masuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_r_hasil_penjualan = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_r_invoice_keluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_r_barang_rental = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_r_garansi = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_r_stock_barang = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_jenis = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_tipe = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_toko = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_client = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_kondisi = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_status = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_detail = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_alasan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_data_user = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_master_ubahprofil = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.p_logo = New System.Windows.Forms.PictureBox()
        Me.ExtendRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplacementBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.p_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menuutama, Me.btn_barang_masuk, Me.BarangKeluarToolStripMenuItem, Me.QuotationToolStripMenuItem, Me.ReportToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.MasterUserToolStripMenuItem, Me.btn_logout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 48)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btn_menuutama
        '
        Me.btn_menuutama.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menuutama.Name = "btn_menuutama"
        Me.btn_menuutama.Size = New System.Drawing.Size(150, 44)
        Me.btn_menuutama.Text = "Menu Utama"
        '
        'btn_barang_masuk
        '
        Me.btn_barang_masuk.Name = "btn_barang_masuk"
        Me.btn_barang_masuk.Size = New System.Drawing.Size(142, 44)
        Me.btn_barang_masuk.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_penjualan, Me.btn_rental, Me.btn_repair, Me.ExtendRentalToolStripMenuItem, Me.ReplacementBarangToolStripMenuItem})
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(141, 44)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'btn_penjualan
        '
        Me.btn_penjualan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_penjualan.Name = "btn_penjualan"
        Me.btn_penjualan.Size = New System.Drawing.Size(257, 28)
        Me.btn_penjualan.Text = "Penjualan"
        '
        'btn_rental
        '
        Me.btn_rental.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rental.Name = "btn_rental"
        Me.btn_rental.Size = New System.Drawing.Size(257, 28)
        Me.btn_rental.Text = "Rental"
        '
        'btn_repair
        '
        Me.btn_repair.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_repair.Name = "btn_repair"
        Me.btn_repair.Size = New System.Drawing.Size(257, 28)
        Me.btn_repair.Text = "Repair"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_qrental, Me.btn_qinstallasi, Me.btn_qmaintenence})
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(103, 44)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'btn_qrental
        '
        Me.btn_qrental.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qrental.Name = "btn_qrental"
        Me.btn_qrental.Size = New System.Drawing.Size(204, 24)
        Me.btn_qrental.Text = "Rental Barang"
        '
        'btn_qinstallasi
        '
        Me.btn_qinstallasi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qinstallasi.Name = "btn_qinstallasi"
        Me.btn_qinstallasi.Size = New System.Drawing.Size(204, 24)
        Me.btn_qinstallasi.Text = "Installation Service"
        '
        'btn_qmaintenence
        '
        Me.btn_qmaintenence.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qmaintenence.Name = "btn_qmaintenence"
        Me.btn_qmaintenence.Size = New System.Drawing.Size(204, 24)
        Me.btn_qmaintenence.Text = "Maintenence Serivce"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_r_barang_masuk, Me.btn_r_hasil_penjualan, Me.btn_r_invoice_keluar, Me.btn_r_barang_rental, Me.btn_r_garansi, Me.btn_r_stock_barang})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(78, 44)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'btn_r_barang_masuk
        '
        Me.btn_r_barang_masuk.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_barang_masuk.Name = "btn_r_barang_masuk"
        Me.btn_r_barang_masuk.Size = New System.Drawing.Size(237, 24)
        Me.btn_r_barang_masuk.Text = "Hasil Input Barang Masuk"
        '
        'btn_r_hasil_penjualan
        '
        Me.btn_r_hasil_penjualan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_hasil_penjualan.Name = "btn_r_hasil_penjualan"
        Me.btn_r_hasil_penjualan.Size = New System.Drawing.Size(237, 24)
        Me.btn_r_hasil_penjualan.Text = "Hasil Penjualan"
        '
        'btn_r_invoice_keluar
        '
        Me.btn_r_invoice_keluar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_invoice_keluar.Name = "btn_r_invoice_keluar"
        Me.btn_r_invoice_keluar.Size = New System.Drawing.Size(237, 24)
        Me.btn_r_invoice_keluar.Text = "List Invoice Keluar"
        '
        'btn_r_barang_rental
        '
        Me.btn_r_barang_rental.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_barang_rental.Name = "btn_r_barang_rental"
        Me.btn_r_barang_rental.Size = New System.Drawing.Size(237, 24)
        Me.btn_r_barang_rental.Text = "List Barang Rental"
        '
        'btn_r_garansi
        '
        Me.btn_r_garansi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_garansi.Name = "btn_r_garansi"
        Me.btn_r_garansi.Size = New System.Drawing.Size(237, 24)
        Me.btn_r_garansi.Text = "Garansi"
        '
        'btn_r_stock_barang
        '
        Me.btn_r_stock_barang.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_stock_barang.Name = "btn_r_stock_barang"
        Me.btn_r_stock_barang.Size = New System.Drawing.Size(237, 24)
        Me.btn_r_stock_barang.Text = "Stock Barang"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_master_jenis, Me.btn_master_tipe, Me.btn_master_toko, Me.btn_master_client, Me.btn_master_kondisi, Me.btn_master_status, Me.MasterLokasiToolStripMenuIbtn_master_lokasi, Me.btn_master_detail, Me.btn_master_alasan})
        Me.MasterDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(126, 44)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'btn_master_jenis
        '
        Me.btn_master_jenis.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_jenis.Name = "btn_master_jenis"
        Me.btn_master_jenis.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_jenis.Text = "Master Jenis Barang"
        '
        'btn_master_tipe
        '
        Me.btn_master_tipe.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_tipe.Name = "btn_master_tipe"
        Me.btn_master_tipe.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_tipe.Text = "Master Tipe Barang"
        '
        'btn_master_toko
        '
        Me.btn_master_toko.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_toko.Name = "btn_master_toko"
        Me.btn_master_toko.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_toko.Text = "Master Toko"
        '
        'btn_master_client
        '
        Me.btn_master_client.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_client.Name = "btn_master_client"
        Me.btn_master_client.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_client.Text = "Master Client"
        '
        'btn_master_kondisi
        '
        Me.btn_master_kondisi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_kondisi.Name = "btn_master_kondisi"
        Me.btn_master_kondisi.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_kondisi.Text = "Master Kondisi"
        '
        'btn_master_status
        '
        Me.btn_master_status.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_status.Name = "btn_master_status"
        Me.btn_master_status.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_status.Text = "Master Status Barang"
        '
        'MasterLokasiToolStripMenuIbtn_master_lokasi
        '
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Name = "MasterLokasiToolStripMenuIbtn_master_lokasi"
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Size = New System.Drawing.Size(213, 24)
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Text = "Master Lokasi"
        '
        'btn_master_detail
        '
        Me.btn_master_detail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_detail.Name = "btn_master_detail"
        Me.btn_master_detail.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_detail.Text = "Master Detail Lokasi"
        '
        'btn_master_alasan
        '
        Me.btn_master_alasan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_alasan.Name = "btn_master_alasan"
        Me.btn_master_alasan.Size = New System.Drawing.Size(213, 24)
        Me.btn_master_alasan.Text = "Master Alasan"
        '
        'MasterUserToolStripMenuItem
        '
        Me.MasterUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_master_data_user, Me.btn_master_ubahprofil})
        Me.MasterUserToolStripMenuItem.Name = "MasterUserToolStripMenuItem"
        Me.MasterUserToolStripMenuItem.Size = New System.Drawing.Size(122, 44)
        Me.MasterUserToolStripMenuItem.Text = "Master User"
        '
        'btn_master_data_user
        '
        Me.btn_master_data_user.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_data_user.Name = "btn_master_data_user"
        Me.btn_master_data_user.Size = New System.Drawing.Size(147, 24)
        Me.btn_master_data_user.Text = "Data User"
        '
        'btn_master_ubahprofil
        '
        Me.btn_master_ubahprofil.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_ubahprofil.Name = "btn_master_ubahprofil"
        Me.btn_master_ubahprofil.Size = New System.Drawing.Size(147, 24)
        Me.btn_master_ubahprofil.Text = "Ubah Profil"
        '
        'btn_logout
        '
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(80, 44)
        Me.btn_logout.Text = "Logout"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.p_logo)
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 626)
        Me.Panel1.TabIndex = 44
        '
        'p_logo
        '
        Me.p_logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.p_logo.Location = New System.Drawing.Point(336, 86)
        Me.p_logo.Margin = New System.Windows.Forms.Padding(2)
        Me.p_logo.Name = "p_logo"
        Me.p_logo.Size = New System.Drawing.Size(445, 435)
        Me.p_logo.TabIndex = 0
        Me.p_logo.TabStop = False
        '
        'ExtendRentalToolStripMenuItem
        '
        Me.ExtendRentalToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ExtendRentalToolStripMenuItem.Name = "ExtendRentalToolStripMenuItem"
        Me.ExtendRentalToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.ExtendRentalToolStripMenuItem.Text = "Extend Rental"
        '
        'ReplacementBarangToolStripMenuItem
        '
        Me.ReplacementBarangToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.ReplacementBarangToolStripMenuItem.Name = "ReplacementBarangToolStripMenuItem"
        Me.ReplacementBarangToolStripMenuItem.Size = New System.Drawing.Size(204, 24)
        Me.ReplacementBarangToolStripMenuItem.Text = "Replacement Barang"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.p_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btn_menuutama As ToolStripMenuItem
    Friend WithEvents btn_barang_masuk As ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_penjualan As ToolStripMenuItem
    Friend WithEvents btn_rental As ToolStripMenuItem
    Friend WithEvents btn_repair As ToolStripMenuItem
    Friend WithEvents QuotationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_qrental As ToolStripMenuItem
    Friend WithEvents btn_qinstallasi As ToolStripMenuItem
    Friend WithEvents btn_qmaintenence As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_r_barang_masuk As ToolStripMenuItem
    Friend WithEvents btn_r_hasil_penjualan As ToolStripMenuItem
    Friend WithEvents btn_r_invoice_keluar As ToolStripMenuItem
    Friend WithEvents btn_r_barang_rental As ToolStripMenuItem
    Friend WithEvents btn_r_garansi As ToolStripMenuItem
    Friend WithEvents btn_r_stock_barang As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_master_jenis As ToolStripMenuItem
    Friend WithEvents btn_master_tipe As ToolStripMenuItem
    Friend WithEvents btn_master_toko As ToolStripMenuItem
    Friend WithEvents btn_master_client As ToolStripMenuItem
    Friend WithEvents btn_master_kondisi As ToolStripMenuItem
    Friend WithEvents btn_master_status As ToolStripMenuItem
    Friend WithEvents MasterLokasiToolStripMenuIbtn_master_lokasi As ToolStripMenuItem
    Friend WithEvents btn_master_detail As ToolStripMenuItem
    Friend WithEvents btn_master_alasan As ToolStripMenuItem
    Friend WithEvents MasterUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_master_data_user As ToolStripMenuItem
    Friend WithEvents btn_master_ubahprofil As ToolStripMenuItem
    Friend WithEvents btn_logout As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents p_logo As PictureBox
    Friend WithEvents ExtendRentalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplacementBarangToolStripMenuItem As ToolStripMenuItem
End Class
