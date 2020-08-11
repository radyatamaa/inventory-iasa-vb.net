<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarangMasuk
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
        Me.txt_kode_barang = New System.Windows.Forms.TextBox()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_catatan = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_detail_lokasi = New System.Windows.Forms.ComboBox()
        Me.txt_harga_modal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_harga_barang = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_lisensi = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_tgl_masuk = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.data_barang_masuk = New System.Windows.Forms.DataGridView()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lisensi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.catatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_modal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_masuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbx_tidak_teruji = New System.Windows.Forms.CheckBox()
        Me.cbx_teruji = New System.Windows.Forms.CheckBox()
        Me.cmb_lokasi = New System.Windows.Forms.ComboBox()
        Me.cmb_kondisi = New System.Windows.Forms.ComboBox()
        Me.cmb_tipe_barang = New System.Windows.Forms.ComboBox()
        Me.cmb_jenis_barang = New System.Windows.Forms.ComboBox()
        Me.txt_serial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.hapus_data_barang_masuk = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.data_barang_masuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.txt_kode_barang)
        Me.Panel2.Controls.Add(Me.cmb_status)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txt_catatan)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.cmb_detail_lokasi)
        Me.Panel2.Controls.Add(Me.txt_harga_modal)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txt_harga_barang)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txt_lisensi)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.date_tgl_masuk)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_barang_masuk)
        Me.Panel2.Controls.Add(Me.cbx_tidak_teruji)
        Me.Panel2.Controls.Add(Me.cbx_teruji)
        Me.Panel2.Controls.Add(Me.cmb_lokasi)
        Me.Panel2.Controls.Add(Me.cmb_kondisi)
        Me.Panel2.Controls.Add(Me.cmb_tipe_barang)
        Me.Panel2.Controls.Add(Me.cmb_jenis_barang)
        Me.Panel2.Controls.Add(Me.txt_serial)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(1, 48)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1234, 380)
        Me.Panel2.TabIndex = 1
        '
        'txt_kode_barang
        '
        Me.txt_kode_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kode_barang.Location = New System.Drawing.Point(135, 22)
        Me.txt_kode_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_kode_barang.Name = "txt_kode_barang"
        Me.txt_kode_barang.Size = New System.Drawing.Size(178, 20)
        Me.txt_kode_barang.TabIndex = 35
        '
        'cmb_status
        '
        Me.cmb_status.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(693, 47)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(178, 21)
        Me.cmb_status.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(608, 53)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Status"
        '
        'txt_catatan
        '
        Me.txt_catatan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_catatan.Location = New System.Drawing.Point(421, 135)
        Me.txt_catatan.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_catatan.Name = "txt_catatan"
        Me.txt_catatan.Size = New System.Drawing.Size(178, 20)
        Me.txt_catatan.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(336, 137)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Catatan"
        '
        'cmb_detail_lokasi
        '
        Me.cmb_detail_lokasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_detail_lokasi.FormattingEnabled = True
        Me.cmb_detail_lokasi.Location = New System.Drawing.Point(421, 79)
        Me.cmb_detail_lokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_detail_lokasi.Name = "cmb_detail_lokasi"
        Me.cmb_detail_lokasi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_detail_lokasi.TabIndex = 30
        '
        'txt_harga_modal
        '
        Me.txt_harga_modal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_harga_modal.Location = New System.Drawing.Point(693, 79)
        Me.txt_harga_modal.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_harga_modal.Name = "txt_harga_modal"
        Me.txt_harga_modal.Size = New System.Drawing.Size(178, 20)
        Me.txt_harga_modal.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(608, 81)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Harga Modal"
        '
        'txt_harga_barang
        '
        Me.txt_harga_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_harga_barang.Location = New System.Drawing.Point(693, 108)
        Me.txt_harga_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_harga_barang.Name = "txt_harga_barang"
        Me.txt_harga_barang.Size = New System.Drawing.Size(178, 20)
        Me.txt_harga_barang.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(608, 110)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Harga Barang"
        '
        'txt_lisensi
        '
        Me.txt_lisensi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_lisensi.Location = New System.Drawing.Point(421, 110)
        Me.txt_lisensi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lisensi.Name = "txt_lisensi"
        Me.txt_lisensi.Size = New System.Drawing.Size(178, 20)
        Me.txt_lisensi.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(336, 113)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "License"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(608, 141)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tanggal Masuk"
        '
        'date_tgl_masuk
        '
        Me.date_tgl_masuk.Location = New System.Drawing.Point(693, 141)
        Me.date_tgl_masuk.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tgl_masuk.Name = "date_tgl_masuk"
        Me.date_tgl_masuk.Size = New System.Drawing.Size(178, 20)
        Me.date_tgl_masuk.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(336, 84)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Detail Lokasi"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Barang"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(884, 49)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(177, 23)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'data_barang_masuk
        '
        Me.data_barang_masuk.AllowUserToOrderColumns = True
        Me.data_barang_masuk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_barang_masuk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_barang_masuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_barang_masuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenis_barang, Me.tipe_barang, Me.serial_number, Me.kondisi, Me.tested, Me.lokasi, Me.detail_lokasi, Me.lisensi, Me.catatan, Me.status_barang, Me.harga_modal, Me.harga_barang, Me.tgl_masuk})
        Me.data_barang_masuk.Location = New System.Drawing.Point(0, 175)
        Me.data_barang_masuk.Margin = New System.Windows.Forms.Padding(2)
        Me.data_barang_masuk.Name = "data_barang_masuk"
        Me.data_barang_masuk.RowHeadersWidth = 51
        Me.data_barang_masuk.RowTemplate.Height = 24
        Me.data_barang_masuk.Size = New System.Drawing.Size(1234, 206)
        Me.data_barang_masuk.TabIndex = 16
        '
        'jenis_barang
        '
        Me.jenis_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang.HeaderText = "Jenis Barang"
        Me.jenis_barang.MinimumWidth = 6
        Me.jenis_barang.Name = "jenis_barang"
        '
        'tipe_barang
        '
        Me.tipe_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang.HeaderText = "Tipe Detail Barang"
        Me.tipe_barang.MinimumWidth = 6
        Me.tipe_barang.Name = "tipe_barang"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Serial Number"
        Me.serial_number.MinimumWidth = 6
        Me.serial_number.Name = "serial_number"
        '
        'kondisi
        '
        Me.kondisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kondisi.HeaderText = "Kondisi"
        Me.kondisi.MinimumWidth = 6
        Me.kondisi.Name = "kondisi"
        '
        'tested
        '
        Me.tested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tested.HeaderText = "Tested"
        Me.tested.MinimumWidth = 6
        Me.tested.Name = "tested"
        '
        'lokasi
        '
        Me.lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lokasi.HeaderText = "Lokasi"
        Me.lokasi.MinimumWidth = 6
        Me.lokasi.Name = "lokasi"
        '
        'detail_lokasi
        '
        Me.detail_lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.detail_lokasi.HeaderText = "Detail Lokasi"
        Me.detail_lokasi.MinimumWidth = 6
        Me.detail_lokasi.Name = "detail_lokasi"
        '
        'lisensi
        '
        Me.lisensi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lisensi.HeaderText = "License"
        Me.lisensi.MinimumWidth = 6
        Me.lisensi.Name = "lisensi"
        '
        'catatan
        '
        Me.catatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.catatan.HeaderText = "Catatan"
        Me.catatan.MinimumWidth = 6
        Me.catatan.Name = "catatan"
        '
        'status_barang
        '
        Me.status_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.status_barang.HeaderText = "Status"
        Me.status_barang.MinimumWidth = 6
        Me.status_barang.Name = "status_barang"
        '
        'harga_modal
        '
        Me.harga_modal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.harga_modal.HeaderText = "Harga Modal"
        Me.harga_modal.MinimumWidth = 6
        Me.harga_modal.Name = "harga_modal"
        '
        'harga_barang
        '
        Me.harga_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.harga_barang.HeaderText = "Harga Barang"
        Me.harga_barang.MinimumWidth = 6
        Me.harga_barang.Name = "harga_barang"
        '
        'tgl_masuk
        '
        Me.tgl_masuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tgl_masuk.HeaderText = "Tanggal Masuk"
        Me.tgl_masuk.MinimumWidth = 6
        Me.tgl_masuk.Name = "tgl_masuk"
        '
        'cbx_tidak_teruji
        '
        Me.cbx_tidak_teruji.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_tidak_teruji.AutoSize = True
        Me.cbx_tidak_teruji.Location = New System.Drawing.Point(475, 25)
        Me.cbx_tidak_teruji.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_tidak_teruji.Name = "cbx_tidak_teruji"
        Me.cbx_tidak_teruji.Size = New System.Drawing.Size(82, 17)
        Me.cbx_tidak_teruji.TabIndex = 15
        Me.cbx_tidak_teruji.Text = "Tidak Teruji"
        Me.cbx_tidak_teruji.UseVisualStyleBackColor = True
        '
        'cbx_teruji
        '
        Me.cbx_teruji.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbx_teruji.AutoSize = True
        Me.cbx_teruji.Location = New System.Drawing.Point(421, 25)
        Me.cbx_teruji.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_teruji.Name = "cbx_teruji"
        Me.cbx_teruji.Size = New System.Drawing.Size(52, 17)
        Me.cbx_teruji.TabIndex = 14
        Me.cbx_teruji.Text = "Teruji"
        Me.cbx_teruji.UseVisualStyleBackColor = True
        '
        'cmb_lokasi
        '
        Me.cmb_lokasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_lokasi.FormattingEnabled = True
        Me.cmb_lokasi.Location = New System.Drawing.Point(421, 50)
        Me.cmb_lokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_lokasi.Name = "cmb_lokasi"
        Me.cmb_lokasi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_lokasi.TabIndex = 13
        '
        'cmb_kondisi
        '
        Me.cmb_kondisi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_kondisi.FormattingEnabled = True
        Me.cmb_kondisi.Location = New System.Drawing.Point(135, 135)
        Me.cmb_kondisi.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_kondisi.Name = "cmb_kondisi"
        Me.cmb_kondisi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_kondisi.TabIndex = 11
        '
        'cmb_tipe_barang
        '
        Me.cmb_tipe_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_tipe_barang.FormattingEnabled = True
        Me.cmb_tipe_barang.Location = New System.Drawing.Point(135, 82)
        Me.cmb_tipe_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipe_barang.Name = "cmb_tipe_barang"
        Me.cmb_tipe_barang.Size = New System.Drawing.Size(178, 21)
        Me.cmb_tipe_barang.TabIndex = 10
        '
        'cmb_jenis_barang
        '
        Me.cmb_jenis_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis_barang.FormattingEnabled = True
        Me.cmb_jenis_barang.Location = New System.Drawing.Point(135, 55)
        Me.cmb_jenis_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_jenis_barang.Name = "cmb_jenis_barang"
        Me.cmb_jenis_barang.Size = New System.Drawing.Size(178, 21)
        Me.cmb_jenis_barang.TabIndex = 9
        '
        'txt_serial
        '
        Me.txt_serial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_serial.Location = New System.Drawing.Point(135, 110)
        Me.txt_serial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_serial.Name = "txt_serial"
        Me.txt_serial.Size = New System.Drawing.Size(178, 20)
        Me.txt_serial.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(334, 53)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Lokasi"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tested"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 141)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Kondisi"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Serial Number"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipe Detail Barang"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Barang"
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1108, 48)
        Me.MenuStrip1.TabIndex = 41
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
        Me.BarangKeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_penjualan, Me.btn_rental, Me.btn_repair})
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(141, 44)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'btn_penjualan
        '
        Me.btn_penjualan.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_penjualan.Name = "btn_penjualan"
        Me.btn_penjualan.Size = New System.Drawing.Size(137, 24)
        Me.btn_penjualan.Text = "Penjualan"
        '
        'btn_rental
        '
        Me.btn_rental.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rental.Name = "btn_rental"
        Me.btn_rental.Size = New System.Drawing.Size(137, 24)
        Me.btn_rental.Text = "Rental"
        '
        'btn_repair
        '
        Me.btn_repair.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_repair.Name = "btn_repair"
        Me.btn_repair.Size = New System.Drawing.Size(137, 24)
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
        'hapus_data_barang_masuk
        '
        Me.hapus_data_barang_masuk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.hapus_data_barang_masuk.FlatAppearance.BorderSize = 0
        Me.hapus_data_barang_masuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus_data_barang_masuk.Location = New System.Drawing.Point(8, 433)
        Me.hapus_data_barang_masuk.Margin = New System.Windows.Forms.Padding(2)
        Me.hapus_data_barang_masuk.Name = "hapus_data_barang_masuk"
        Me.hapus_data_barang_masuk.Size = New System.Drawing.Size(70, 32)
        Me.hapus_data_barang_masuk.TabIndex = 56
        Me.hapus_data_barang_masuk.Text = "Hapus"
        Me.hapus_data_barang_masuk.UseVisualStyleBackColor = False
        '
        'BarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 609)
        Me.Controls.Add(Me.hapus_data_barang_masuk)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang Masuk"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.data_barang_masuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents data_barang_masuk As DataGridView
    Friend WithEvents cbx_tidak_teruji As CheckBox
    Friend WithEvents cbx_teruji As CheckBox
    Friend WithEvents cmb_lokasi As ComboBox
    Friend WithEvents cmb_kondisi As ComboBox
    Friend WithEvents cmb_tipe_barang As ComboBox
    Friend WithEvents cmb_jenis_barang As ComboBox
    Friend WithEvents txt_serial As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents date_tgl_masuk As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_catatan As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_detail_lokasi As ComboBox
    Friend WithEvents txt_harga_modal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_harga_barang As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_lisensi As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
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
    Friend WithEvents btn_menuutama As ToolStripMenuItem
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
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents serial_number As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
    Friend WithEvents tested As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents detail_lokasi As DataGridViewTextBoxColumn
    Friend WithEvents lisensi As DataGridViewTextBoxColumn
    Friend WithEvents catatan As DataGridViewTextBoxColumn
    Friend WithEvents status_barang As DataGridViewTextBoxColumn
    Friend WithEvents harga_modal As DataGridViewTextBoxColumn
    Friend WithEvents harga_barang As DataGridViewTextBoxColumn
    Friend WithEvents tgl_masuk As DataGridViewTextBoxColumn
    Friend WithEvents hapus_data_barang_masuk As Button
    Friend WithEvents txt_kode_barang As TextBox
End Class
