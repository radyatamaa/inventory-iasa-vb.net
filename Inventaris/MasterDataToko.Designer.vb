<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterDataToko
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
        Me.txt_nama_toko = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_no_rekening = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_tlp_owner = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_nama_owner = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_logo_toko = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_tlp_toko = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_kdpos_toko = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_kota_toko = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_alamat_toko = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.data_master_toko = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_toko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_toko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kota_toko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdpos_toko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlp_toko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.logo_toko = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlp_owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.norek_owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.data_master_toko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nama_toko
        '
        Me.txt_nama_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_toko.Location = New System.Drawing.Point(153, 28)
        Me.txt_nama_toko.Name = "txt_nama_toko"
        Me.txt_nama_toko.Size = New System.Drawing.Size(236, 22)
        Me.txt_nama_toko.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Toko"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(469, 160)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.txt_no_rekening)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_tlp_owner)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txt_nama_owner)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_logo_toko)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_tlp_toko)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_kdpos_toko)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_kota_toko)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_alamat_toko)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_toko)
        Me.Panel2.Controls.Add(Me.txt_nama_toko)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1539, 468)
        Me.Panel2.TabIndex = 16
        '
        'txt_no_rekening
        '
        Me.txt_no_rekening.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_no_rekening.Location = New System.Drawing.Point(992, 115)
        Me.txt_no_rekening.Name = "txt_no_rekening"
        Me.txt_no_rekening.Size = New System.Drawing.Size(236, 22)
        Me.txt_no_rekening.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(884, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "No Rekening"
        '
        'txt_tlp_owner
        '
        Me.txt_tlp_owner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_tlp_owner.Location = New System.Drawing.Point(992, 68)
        Me.txt_tlp_owner.Name = "txt_tlp_owner"
        Me.txt_tlp_owner.Size = New System.Drawing.Size(236, 22)
        Me.txt_tlp_owner.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(884, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Telepon Owner"
        '
        'txt_nama_owner
        '
        Me.txt_nama_owner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_owner.Location = New System.Drawing.Point(992, 28)
        Me.txt_nama_owner.Name = "txt_nama_owner"
        Me.txt_nama_owner.Size = New System.Drawing.Size(236, 22)
        Me.txt_nama_owner.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(884, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Nama Owner"
        '
        'txt_logo_toko
        '
        Me.txt_logo_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_logo_toko.Location = New System.Drawing.Point(581, 115)
        Me.txt_logo_toko.Name = "txt_logo_toko"
        Me.txt_logo_toko.Size = New System.Drawing.Size(236, 22)
        Me.txt_logo_toko.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(445, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Logo Toko"
        '
        'txt_tlp_toko
        '
        Me.txt_tlp_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_tlp_toko.Location = New System.Drawing.Point(581, 68)
        Me.txt_tlp_toko.Name = "txt_tlp_toko"
        Me.txt_tlp_toko.Size = New System.Drawing.Size(236, 22)
        Me.txt_tlp_toko.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(445, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Telepon Toko"
        '
        'txt_kdpos_toko
        '
        Me.txt_kdpos_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos_toko.Location = New System.Drawing.Point(581, 28)
        Me.txt_kdpos_toko.Name = "txt_kdpos_toko"
        Me.txt_kdpos_toko.Size = New System.Drawing.Size(236, 22)
        Me.txt_kdpos_toko.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(445, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Kodepos Toko"
        '
        'txt_kota_toko
        '
        Me.txt_kota_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota_toko.Location = New System.Drawing.Point(153, 115)
        Me.txt_kota_toko.Name = "txt_kota_toko"
        Me.txt_kota_toko.Size = New System.Drawing.Size(236, 22)
        Me.txt_kota_toko.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Kota Toko"
        '
        'txt_alamat_toko
        '
        Me.txt_alamat_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat_toko.Location = New System.Drawing.Point(153, 68)
        Me.txt_alamat_toko.Name = "txt_alamat_toko"
        Me.txt_alamat_toko.Size = New System.Drawing.Size(236, 22)
        Me.txt_alamat_toko.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Alamat Toko"
        '
        'data_master_toko
        '
        Me.data_master_toko.AllowUserToOrderColumns = True
        Me.data_master_toko.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_toko.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_toko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_toko.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_toko, Me.alamat_toko, Me.kota_toko, Me.kdpos_toko, Me.tlp_toko, Me.logo_toko, Me.nama_owner, Me.tlp_owner, Me.norek_owner})
        Me.data_master_toko.Location = New System.Drawing.Point(0, 208)
        Me.data_master_toko.Name = "data_master_toko"
        Me.data_master_toko.RowHeadersWidth = 51
        Me.data_master_toko.RowTemplate.Height = 24
        Me.data_master_toko.Size = New System.Drawing.Size(1539, 254)
        Me.data_master_toko.TabIndex = 16
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'nama_toko
        '
        Me.nama_toko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_toko.HeaderText = "Nama Toko"
        Me.nama_toko.MinimumWidth = 6
        Me.nama_toko.Name = "nama_toko"
        '
        'alamat_toko
        '
        Me.alamat_toko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.alamat_toko.HeaderText = "Alamat Toko"
        Me.alamat_toko.MinimumWidth = 6
        Me.alamat_toko.Name = "alamat_toko"
        '
        'kota_toko
        '
        Me.kota_toko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kota_toko.HeaderText = "Kota Toko"
        Me.kota_toko.MinimumWidth = 6
        Me.kota_toko.Name = "kota_toko"
        '
        'kdpos_toko
        '
        Me.kdpos_toko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kdpos_toko.HeaderText = "Kode Pos Toko"
        Me.kdpos_toko.MinimumWidth = 6
        Me.kdpos_toko.Name = "kdpos_toko"
        '
        'tlp_toko
        '
        Me.tlp_toko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tlp_toko.HeaderText = "Telepon Toko"
        Me.tlp_toko.MinimumWidth = 6
        Me.tlp_toko.Name = "tlp_toko"
        '
        'logo_toko
        '
        Me.logo_toko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.logo_toko.HeaderText = "Logo Toko"
        Me.logo_toko.MinimumWidth = 6
        Me.logo_toko.Name = "logo_toko"
        '
        'nama_owner
        '
        Me.nama_owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_owner.HeaderText = "Nama Owner"
        Me.nama_owner.MinimumWidth = 6
        Me.nama_owner.Name = "nama_owner"
        '
        'tlp_owner
        '
        Me.tlp_owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tlp_owner.HeaderText = "Telepon Owner"
        Me.tlp_owner.MinimumWidth = 6
        Me.tlp_owner.Name = "tlp_owner"
        '
        'norek_owner
        '
        Me.norek_owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.norek_owner.HeaderText = "No Rekening"
        Me.norek_owner.MinimumWidth = 6
        Me.norek_owner.Name = "norek_owner"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Ubuntu Condensed", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_menuutama, Me.btn_barang_masuk, Me.BarangKeluarToolStripMenuItem, Me.QuotationToolStripMenuItem, Me.ReportToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.MasterUserToolStripMenuItem, Me.btn_logout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1542, 59)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btn_menuutama
        '
        Me.btn_menuutama.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_menuutama.Name = "btn_menuutama"
        Me.btn_menuutama.Size = New System.Drawing.Size(191, 55)
        Me.btn_menuutama.Text = "Menu Utama"
        '
        'btn_barang_masuk
        '
        Me.btn_barang_masuk.Name = "btn_barang_masuk"
        Me.btn_barang_masuk.Size = New System.Drawing.Size(153, 55)
        Me.btn_barang_masuk.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_penjualan, Me.btn_rental, Me.btn_repair})
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(153, 55)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'btn_penjualan
        '
        Me.btn_penjualan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_penjualan.Name = "btn_penjualan"
        Me.btn_penjualan.Size = New System.Drawing.Size(176, 28)
        Me.btn_penjualan.Text = "Penjualan"
        '
        'btn_rental
        '
        Me.btn_rental.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rental.Name = "btn_rental"
        Me.btn_rental.Size = New System.Drawing.Size(176, 28)
        Me.btn_rental.Text = "Rental"
        '
        'btn_repair
        '
        Me.btn_repair.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_repair.Name = "btn_repair"
        Me.btn_repair.Size = New System.Drawing.Size(176, 28)
        Me.btn_repair.Text = "Repair"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_qrental, Me.btn_qinstallasi, Me.btn_qmaintenence})
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(120, 55)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'btn_qrental
        '
        Me.btn_qrental.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qrental.Name = "btn_qrental"
        Me.btn_qrental.Size = New System.Drawing.Size(259, 28)
        Me.btn_qrental.Text = "Rental Barang"
        '
        'btn_qinstallasi
        '
        Me.btn_qinstallasi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qinstallasi.Name = "btn_qinstallasi"
        Me.btn_qinstallasi.Size = New System.Drawing.Size(259, 28)
        Me.btn_qinstallasi.Text = "Installation Service"
        '
        'btn_qmaintenence
        '
        Me.btn_qmaintenence.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_qmaintenence.Name = "btn_qmaintenence"
        Me.btn_qmaintenence.Size = New System.Drawing.Size(259, 28)
        Me.btn_qmaintenence.Text = "Maintenence Serivce"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_r_barang_masuk, Me.btn_r_hasil_penjualan, Me.btn_r_invoice_keluar, Me.btn_r_barang_rental, Me.btn_r_garansi, Me.btn_r_stock_barang})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(87, 55)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'btn_r_barang_masuk
        '
        Me.btn_r_barang_masuk.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_barang_masuk.Name = "btn_r_barang_masuk"
        Me.btn_r_barang_masuk.Size = New System.Drawing.Size(297, 28)
        Me.btn_r_barang_masuk.Text = "Hasil Input Barang Masuk"
        '
        'btn_r_hasil_penjualan
        '
        Me.btn_r_hasil_penjualan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_hasil_penjualan.Name = "btn_r_hasil_penjualan"
        Me.btn_r_hasil_penjualan.Size = New System.Drawing.Size(297, 28)
        Me.btn_r_hasil_penjualan.Text = "Hasil Penjualan"
        '
        'btn_r_invoice_keluar
        '
        Me.btn_r_invoice_keluar.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_invoice_keluar.Name = "btn_r_invoice_keluar"
        Me.btn_r_invoice_keluar.Size = New System.Drawing.Size(297, 28)
        Me.btn_r_invoice_keluar.Text = "List Invoice Keluar"
        '
        'btn_r_barang_rental
        '
        Me.btn_r_barang_rental.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_barang_rental.Name = "btn_r_barang_rental"
        Me.btn_r_barang_rental.Size = New System.Drawing.Size(297, 28)
        Me.btn_r_barang_rental.Text = "List Barang Rental"
        '
        'btn_r_garansi
        '
        Me.btn_r_garansi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_garansi.Name = "btn_r_garansi"
        Me.btn_r_garansi.Size = New System.Drawing.Size(297, 28)
        Me.btn_r_garansi.Text = "Garansi"
        '
        'btn_r_stock_barang
        '
        Me.btn_r_stock_barang.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_r_stock_barang.Name = "btn_r_stock_barang"
        Me.btn_r_stock_barang.Size = New System.Drawing.Size(297, 28)
        Me.btn_r_stock_barang.Text = "Stock Barang"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_master_jenis, Me.btn_master_tipe, Me.btn_master_toko, Me.btn_master_client, Me.btn_master_kondisi, Me.btn_master_status, Me.MasterLokasiToolStripMenuIbtn_master_lokasi, Me.btn_master_detail, Me.btn_master_alasan})
        Me.MasterDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(158, 55)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'btn_master_jenis
        '
        Me.btn_master_jenis.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_jenis.Name = "btn_master_jenis"
        Me.btn_master_jenis.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_jenis.Text = "Master Jenis Barang"
        '
        'btn_master_tipe
        '
        Me.btn_master_tipe.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_tipe.Name = "btn_master_tipe"
        Me.btn_master_tipe.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_tipe.Text = "Master Tipe Barang"
        '
        'btn_master_toko
        '
        Me.btn_master_toko.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_toko.Name = "btn_master_toko"
        Me.btn_master_toko.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_toko.Text = "Master Toko"
        '
        'btn_master_client
        '
        Me.btn_master_client.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_client.Name = "btn_master_client"
        Me.btn_master_client.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_client.Text = "Master Client"
        '
        'btn_master_kondisi
        '
        Me.btn_master_kondisi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_kondisi.Name = "btn_master_kondisi"
        Me.btn_master_kondisi.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_kondisi.Text = "Master Kondisi"
        '
        'btn_master_status
        '
        Me.btn_master_status.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_status.Name = "btn_master_status"
        Me.btn_master_status.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_status.Text = "Master Status Barang"
        '
        'MasterLokasiToolStripMenuIbtn_master_lokasi
        '
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Name = "MasterLokasiToolStripMenuIbtn_master_lokasi"
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Size = New System.Drawing.Size(261, 28)
        Me.MasterLokasiToolStripMenuIbtn_master_lokasi.Text = "Master Lokasi"
        '
        'btn_master_detail
        '
        Me.btn_master_detail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_detail.Name = "btn_master_detail"
        Me.btn_master_detail.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_detail.Text = "Master Detail Lokasi"
        '
        'btn_master_alasan
        '
        Me.btn_master_alasan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_alasan.Name = "btn_master_alasan"
        Me.btn_master_alasan.Size = New System.Drawing.Size(261, 28)
        Me.btn_master_alasan.Text = "Master Alasan"
        '
        'MasterUserToolStripMenuItem
        '
        Me.MasterUserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_master_data_user, Me.btn_master_ubahprofil})
        Me.MasterUserToolStripMenuItem.Name = "MasterUserToolStripMenuItem"
        Me.MasterUserToolStripMenuItem.Size = New System.Drawing.Size(132, 55)
        Me.MasterUserToolStripMenuItem.Text = "Master User"
        '
        'btn_master_data_user
        '
        Me.btn_master_data_user.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_data_user.Name = "btn_master_data_user"
        Me.btn_master_data_user.Size = New System.Drawing.Size(187, 28)
        Me.btn_master_data_user.Text = "Data User"
        '
        'btn_master_ubahprofil
        '
        Me.btn_master_ubahprofil.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_master_ubahprofil.Name = "btn_master_ubahprofil"
        Me.btn_master_ubahprofil.Size = New System.Drawing.Size(187, 28)
        Me.btn_master_ubahprofil.Text = "Ubah Profil"
        '
        'btn_logout
        '
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(90, 55)
        Me.btn_logout.Text = "Logout"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(113, 533)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(94, 39)
        Me.Button13.TabIndex = 47
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(13, 533)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(94, 39)
        Me.Button12.TabIndex = 46
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'MasterDataToko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 832)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MasterDataToko"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterDataToko"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.data_master_toko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_nama_toko As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_no_rekening As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_tlp_owner As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_nama_owner As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_logo_toko As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_tlp_toko As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_kdpos_toko As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_kota_toko As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_alamat_toko As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents data_master_toko As DataGridView
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
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_toko As DataGridViewTextBoxColumn
    Friend WithEvents alamat_toko As DataGridViewTextBoxColumn
    Friend WithEvents kota_toko As DataGridViewTextBoxColumn
    Friend WithEvents kdpos_toko As DataGridViewTextBoxColumn
    Friend WithEvents tlp_toko As DataGridViewTextBoxColumn
    Friend WithEvents logo_toko As DataGridViewTextBoxColumn
    Friend WithEvents nama_owner As DataGridViewTextBoxColumn
    Friend WithEvents tlp_owner As DataGridViewTextBoxColumn
    Friend WithEvents norek_owner As DataGridViewTextBoxColumn
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
End Class
