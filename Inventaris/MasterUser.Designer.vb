<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterUser
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_nama_lengkap = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.data_master_user = New System.Windows.Forms.DataGridView()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_id_level = New System.Windows.Forms.ComboBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.data_master_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.txt_username)
        Me.Panel2.Controls.Add(Me.txt_nama_lengkap)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.data_master_user)
        Me.Panel2.Controls.Add(Me.cmb_id_level)
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 59)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1710, 468)
        Me.Panel2.TabIndex = 6
        '
        'txt_username
        '
        Me.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_username.Location = New System.Drawing.Point(176, 18)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(236, 22)
        Me.txt_username.TabIndex = 21
        '
        'txt_nama_lengkap
        '
        Me.txt_nama_lengkap.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_lengkap.Location = New System.Drawing.Point(176, 53)
        Me.txt_nama_lengkap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nama_lengkap.Name = "txt_nama_lengkap"
        Me.txt_nama_lengkap.Size = New System.Drawing.Size(236, 22)
        Me.txt_nama_lengkap.TabIndex = 20
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(67, 160)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(236, 28)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "Simpan"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'data_master_user
        '
        Me.data_master_user.AllowUserToOrderColumns = True
        Me.data_master_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_user.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_user.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_user, Me.username, Me.nama_lengkap, Me.password, Me.id_level})
        Me.data_master_user.Location = New System.Drawing.Point(-1, 212)
        Me.data_master_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_user.Name = "data_master_user"
        Me.data_master_user.RowHeadersWidth = 51
        Me.data_master_user.RowTemplate.Height = 24
        Me.data_master_user.Size = New System.Drawing.Size(1536, 254)
        Me.data_master_user.TabIndex = 16
        '
        'id_user
        '
        Me.id_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_user.HeaderText = "ID User"
        Me.id_user.MinimumWidth = 6
        Me.id_user.Name = "id_user"
        '
        'username
        '
        Me.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.username.HeaderText = "Username"
        Me.username.MinimumWidth = 6
        Me.username.Name = "username"
        '
        'nama_lengkap
        '
        Me.nama_lengkap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_lengkap.HeaderText = "Nama Lengkap"
        Me.nama_lengkap.MinimumWidth = 6
        Me.nama_lengkap.Name = "nama_lengkap"
        '
        'password
        '
        Me.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.password.HeaderText = "Password"
        Me.password.MinimumWidth = 6
        Me.password.Name = "password"
        '
        'id_level
        '
        Me.id_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_level.HeaderText = "ID Level"
        Me.id_level.MinimumWidth = 6
        Me.id_level.Name = "id_level"
        '
        'cmb_id_level
        '
        Me.cmb_id_level.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_id_level.FormattingEnabled = True
        Me.cmb_id_level.Location = New System.Drawing.Point(176, 116)
        Me.cmb_id_level.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_id_level.Name = "cmb_id_level"
        Me.cmb_id_level.Size = New System.Drawing.Size(236, 24)
        Me.cmb_id_level.TabIndex = 11
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_password.Location = New System.Drawing.Point(176, 85)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(236, 22)
        Me.txt_password.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ID Level"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
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
        Me.MenuStrip1.TabIndex = 49
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(114, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(14, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 39)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MasterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 832)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterUser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.data_master_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents data_master_user As DataGridView
    Friend WithEvents cmb_id_level As ComboBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_nama_lengkap As TextBox
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
    Friend WithEvents id_user As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents nama_lengkap As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents id_level As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
