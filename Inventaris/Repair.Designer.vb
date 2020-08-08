<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Repair
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
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
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(172, 184)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(236, 24)
        Me.ComboBox1.TabIndex = 27
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox2.Location = New System.Drawing.Point(172, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(236, 22)
        Me.TextBox2.TabIndex = 26
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(172, 16)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(174, 24)
        Me.ComboBox5.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ubuntu Condensed", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 32)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Penjualan"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.ComboBox5)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.ComboBox3)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1539, 505)
        Me.Panel2.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tanggal Keluar"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(172, 216)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(236, 22)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Judul "
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(423, 74)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(238, 32)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "Simpan"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenis_barang, Me.tipe_barang, Me.serial_number, Me.kondisi, Me.lokasi})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 248)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1539, 254)
        Me.DataGridView1.TabIndex = 16
        '
        'jenis_barang
        '
        Me.jenis_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang.HeaderText = "Judul"
        Me.jenis_barang.MinimumWidth = 6
        Me.jenis_barang.Name = "jenis_barang"
        '
        'tipe_barang
        '
        Me.tipe_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang.HeaderText = "Jenis Barang"
        Me.tipe_barang.MinimumWidth = 6
        Me.tipe_barang.Name = "tipe_barang"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Tipe Barang"
        Me.serial_number.MinimumWidth = 6
        Me.serial_number.Name = "serial_number"
        '
        'kondisi
        '
        Me.kondisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kondisi.HeaderText = "Serial Number"
        Me.kondisi.MinimumWidth = 6
        Me.kondisi.Name = "kondisi"
        '
        'lokasi
        '
        Me.lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lokasi.HeaderText = "Tanggal Keluar"
        Me.lokasi.MinimumWidth = 6
        Me.lokasi.Name = "lokasi"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(172, 149)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(236, 24)
        Me.ComboBox3.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(172, 116)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(236, 24)
        Me.ComboBox2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Serial Number"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipe Barang"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Barang"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(115, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 39)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(15, 578)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(94, 39)
        Me.Button11.TabIndex = 56
        Me.Button11.Text = "Edit"
        Me.Button11.UseVisualStyleBackColor = False
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
        Me.MenuStrip1.TabIndex = 58
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
        'Repair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 832)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Repair"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repair"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents serial_number As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button11 As Button
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
End Class
