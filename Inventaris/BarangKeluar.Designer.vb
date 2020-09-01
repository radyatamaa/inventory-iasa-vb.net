<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BarangKeluar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarangKeluar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_tgl_keluar = New System.Windows.Forms.DateTimePicker()
        Me.dt_barang_masuk = New System.Windows.Forms.DataGridView()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.catatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_tipe_barang = New System.Windows.Forms.ComboBox()
        Me.cmb_jenis_barang = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_client = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_kdpos_ship = New System.Windows.Forms.TextBox()
        Me.txt_kota_ship = New System.Windows.Forms.TextBox()
        Me.txt_alamat_ship = New System.Windows.Forms.TextBox()
        Me.txt_client_ship = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_tambha = New System.Windows.Forms.Button()
        Me.dt_barang_keluar_fix = New System.Windows.Forms.DataGridView()
        Me.jenis_barang2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tested2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lokasi2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.catatan2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jual2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.garansi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.garansi_type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.garansi_exp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_kdpos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_kota = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_garansi = New System.Windows.Forms.ComboBox()
        Me.txt_kd_transaksi = New System.Windows.Forms.TextBox()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_harga_total = New System.Windows.Forms.TextBox()
        Me.txt_diskon = New System.Windows.Forms.TextBox()
        Me.txt_harga_akhir = New System.Windows.Forms.TextBox()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_kwitansi = New System.Windows.Forms.Button()
        Me.btn_tanda_terima = New System.Windows.Forms.Button()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_ppn = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PPN = New System.Windows.Forms.Label()
        Me.txt_shiphand = New System.Windows.Forms.TextBox()
        Me.txt_ppn_nominal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dt_barang_masuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kode Transaksi"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(518, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tanggal Keluar"
        '
        'date_tgl_keluar
        '
        Me.date_tgl_keluar.Location = New System.Drawing.Point(677, 151)
        Me.date_tgl_keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_tgl_keluar.Name = "date_tgl_keluar"
        Me.date_tgl_keluar.Size = New System.Drawing.Size(236, 22)
        Me.date_tgl_keluar.TabIndex = 9
        '
        'dt_barang_masuk
        '
        Me.dt_barang_masuk.AllowUserToOrderColumns = True
        Me.dt_barang_masuk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_masuk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt_barang_masuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_masuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenis_barang, Me.tipe_barang, Me.serial_number, Me.kondisi, Me.tested, Me.lokasi, Me.detail_lokasi, Me.catatan, Me.status, Me.harga_jual})
        Me.dt_barang_masuk.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_barang_masuk.Location = New System.Drawing.Point(0, 226)
        Me.dt_barang_masuk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt_barang_masuk.Name = "dt_barang_masuk"
        Me.dt_barang_masuk.RowHeadersWidth = 51
        Me.dt_barang_masuk.RowTemplate.Height = 24
        Me.dt_barang_masuk.Size = New System.Drawing.Size(1759, 146)
        Me.dt_barang_masuk.TabIndex = 15
        '
        'jenis_barang
        '
        Me.jenis_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang.HeaderText = "Jenis Barang"
        Me.jenis_barang.MinimumWidth = 70
        Me.jenis_barang.Name = "jenis_barang"
        '
        'tipe_barang
        '
        Me.tipe_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang.HeaderText = "Tipe Barang"
        Me.tipe_barang.MinimumWidth = 70
        Me.tipe_barang.Name = "tipe_barang"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Serial Number"
        Me.serial_number.MinimumWidth = 70
        Me.serial_number.Name = "serial_number"
        '
        'kondisi
        '
        Me.kondisi.HeaderText = "Kondisi"
        Me.kondisi.MinimumWidth = 6
        Me.kondisi.Name = "kondisi"
        Me.kondisi.Width = 125
        '
        'tested
        '
        Me.tested.HeaderText = "Tested"
        Me.tested.MinimumWidth = 6
        Me.tested.Name = "tested"
        Me.tested.Width = 125
        '
        'lokasi
        '
        Me.lokasi.HeaderText = "Lokasi"
        Me.lokasi.MinimumWidth = 6
        Me.lokasi.Name = "lokasi"
        Me.lokasi.Width = 125
        '
        'detail_lokasi
        '
        Me.detail_lokasi.HeaderText = "Detail Lokasi"
        Me.detail_lokasi.MinimumWidth = 6
        Me.detail_lokasi.Name = "detail_lokasi"
        Me.detail_lokasi.Width = 125
        '
        'catatan
        '
        Me.catatan.HeaderText = "Catatan"
        Me.catatan.MinimumWidth = 6
        Me.catatan.Name = "catatan"
        Me.catatan.Width = 125
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.Width = 125
        '
        'harga_jual
        '
        Me.harga_jual.HeaderText = "Harga Jual"
        Me.harga_jual.MinimumWidth = 6
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Width = 125
        '
        'cmb_tipe_barang
        '
        Me.cmb_tipe_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_tipe_barang.FormattingEnabled = True
        Me.cmb_tipe_barang.Location = New System.Drawing.Point(250, 113)
        Me.cmb_tipe_barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_tipe_barang.Name = "cmb_tipe_barang"
        Me.cmb_tipe_barang.Size = New System.Drawing.Size(236, 24)
        Me.cmb_tipe_barang.TabIndex = 3
        '
        'cmb_jenis_barang
        '
        Me.cmb_jenis_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis_barang.FormattingEnabled = True
        Me.cmb_jenis_barang.Location = New System.Drawing.Point(250, 78)
        Me.cmb_jenis_barang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_jenis_barang.Name = "cmb_jenis_barang"
        Me.cmb_jenis_barang.Size = New System.Drawing.Size(236, 24)
        Me.cmb_jenis_barang.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Client"
        '
        'cmb_client
        '
        Me.cmb_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_client.FormattingEnabled = True
        Me.cmb_client.Location = New System.Drawing.Point(250, 146)
        Me.cmb_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_client.Name = "cmb_client"
        Me.cmb_client.Size = New System.Drawing.Size(236, 24)
        Me.cmb_client.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Garansi"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipe Barang"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Barang"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.txt_kdpos_ship)
        Me.Panel2.Controls.Add(Me.txt_kota_ship)
        Me.Panel2.Controls.Add(Me.txt_alamat_ship)
        Me.Panel2.Controls.Add(Me.txt_client_ship)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.btn_tambha)
        Me.Panel2.Controls.Add(Me.dt_barang_keluar_fix)
        Me.Panel2.Controls.Add(Me.txt_kdpos)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_kota)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txt_alamat)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cmb_garansi)
        Me.Panel2.Controls.Add(Me.txt_kd_transaksi)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.date_tgl_keluar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dt_barang_masuk)
        Me.Panel2.Controls.Add(Me.cmb_client)
        Me.Panel2.Controls.Add(Me.cmb_tipe_barang)
        Me.Panel2.Controls.Add(Me.cmb_jenis_barang)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 82)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(3351, 635)
        Me.Panel2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(913, 180)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 25)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.Location = New System.Drawing.Point(677, 181)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 22)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.Text = "Serial Numvber"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_kdpos_ship
        '
        Me.txt_kdpos_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos_ship.Location = New System.Drawing.Point(1121, 154)
        Me.txt_kdpos_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kdpos_ship.Multiline = True
        Me.txt_kdpos_ship.Name = "txt_kdpos_ship"
        Me.txt_kdpos_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_kdpos_ship.TabIndex = 14
        '
        'txt_kota_ship
        '
        Me.txt_kota_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota_ship.Location = New System.Drawing.Point(1121, 116)
        Me.txt_kota_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kota_ship.Multiline = True
        Me.txt_kota_ship.Name = "txt_kota_ship"
        Me.txt_kota_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_kota_ship.TabIndex = 13
        '
        'txt_alamat_ship
        '
        Me.txt_alamat_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat_ship.Location = New System.Drawing.Point(1121, 82)
        Me.txt_alamat_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_alamat_ship.Multiline = True
        Me.txt_alamat_ship.Name = "txt_alamat_ship"
        Me.txt_alamat_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_alamat_ship.TabIndex = 12
        '
        'txt_client_ship
        '
        Me.txt_client_ship.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_client_ship.Location = New System.Drawing.Point(1121, 47)
        Me.txt_client_ship.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_client_ship.Multiline = True
        Me.txt_client_ship.Name = "txt_client_ship"
        Me.txt_client_ship.Size = New System.Drawing.Size(236, 22)
        Me.txt_client_ship.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(932, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 17)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Ship To Name"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(932, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 17)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Ship To Kodepos"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(932, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 17)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "Ship To Kota"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(932, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(170, 17)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Ship To Alamat Transaksi"
        '
        'btn_tambha
        '
        Me.btn_tambha.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_tambha.FlatAppearance.BorderSize = 0
        Me.btn_tambha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tambha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tambha.Location = New System.Drawing.Point(34, 391)
        Me.btn_tambha.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tambha.Name = "btn_tambha"
        Me.btn_tambha.Size = New System.Drawing.Size(237, 32)
        Me.btn_tambha.TabIndex = 16
        Me.btn_tambha.Text = "Tambah"
        Me.btn_tambha.UseVisualStyleBackColor = False
        '
        'dt_barang_keluar_fix
        '
        Me.dt_barang_keluar_fix.AllowUserToOrderColumns = True
        Me.dt_barang_keluar_fix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_keluar_fix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt_barang_keluar_fix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_keluar_fix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenis_barang2, Me.tipe_barang2, Me.serial_number2, Me.kondisi2, Me.tested2, Me.lokasi2, Me.detail_lokasi2, Me.catatan2, Me.status2, Me.harga_jual2, Me.garansi, Me.garansi_type, Me.garansi_exp})
        Me.dt_barang_keluar_fix.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_barang_keluar_fix.Location = New System.Drawing.Point(0, 457)
        Me.dt_barang_keluar_fix.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dt_barang_keluar_fix.Name = "dt_barang_keluar_fix"
        Me.dt_barang_keluar_fix.RowHeadersWidth = 51
        Me.dt_barang_keluar_fix.RowTemplate.Height = 24
        Me.dt_barang_keluar_fix.Size = New System.Drawing.Size(1759, 146)
        Me.dt_barang_keluar_fix.TabIndex = 17
        '
        'jenis_barang2
        '
        Me.jenis_barang2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang2.HeaderText = "Jenis Barang"
        Me.jenis_barang2.MinimumWidth = 70
        Me.jenis_barang2.Name = "jenis_barang2"
        '
        'tipe_barang2
        '
        Me.tipe_barang2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang2.HeaderText = "Tipe Barang"
        Me.tipe_barang2.MinimumWidth = 70
        Me.tipe_barang2.Name = "tipe_barang2"
        '
        'serial_number2
        '
        Me.serial_number2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number2.HeaderText = "Serial Number"
        Me.serial_number2.MinimumWidth = 70
        Me.serial_number2.Name = "serial_number2"
        '
        'kondisi2
        '
        Me.kondisi2.HeaderText = "Kondisi"
        Me.kondisi2.MinimumWidth = 6
        Me.kondisi2.Name = "kondisi2"
        Me.kondisi2.Width = 125
        '
        'tested2
        '
        Me.tested2.HeaderText = "Tested"
        Me.tested2.MinimumWidth = 6
        Me.tested2.Name = "tested2"
        Me.tested2.Width = 125
        '
        'lokasi2
        '
        Me.lokasi2.HeaderText = "Lokasi"
        Me.lokasi2.MinimumWidth = 6
        Me.lokasi2.Name = "lokasi2"
        Me.lokasi2.Width = 125
        '
        'detail_lokasi2
        '
        Me.detail_lokasi2.HeaderText = "Detail Lokasi"
        Me.detail_lokasi2.MinimumWidth = 6
        Me.detail_lokasi2.Name = "detail_lokasi2"
        Me.detail_lokasi2.Width = 125
        '
        'catatan2
        '
        Me.catatan2.HeaderText = "Catatan"
        Me.catatan2.MinimumWidth = 6
        Me.catatan2.Name = "catatan2"
        Me.catatan2.Width = 125
        '
        'status2
        '
        Me.status2.HeaderText = "Status"
        Me.status2.MinimumWidth = 6
        Me.status2.Name = "status2"
        Me.status2.Width = 125
        '
        'harga_jual2
        '
        Me.harga_jual2.HeaderText = "Harga Jual"
        Me.harga_jual2.MinimumWidth = 6
        Me.harga_jual2.Name = "harga_jual2"
        Me.harga_jual2.Width = 125
        '
        'garansi
        '
        Me.garansi.HeaderText = "Periode Garansi"
        Me.garansi.MinimumWidth = 6
        Me.garansi.Name = "garansi"
        Me.garansi.Width = 125
        '
        'garansi_type
        '
        Me.garansi_type.HeaderText = "Tipe Garansi"
        Me.garansi_type.Items.AddRange(New Object() {"Hari", "Bulan", "Tahun"})
        Me.garansi_type.MinimumWidth = 6
        Me.garansi_type.Name = "garansi_type"
        Me.garansi_type.Width = 125
        '
        'garansi_exp
        '
        Me.garansi_exp.HeaderText = "Tanggal Akhir Garansi"
        Me.garansi_exp.MinimumWidth = 6
        Me.garansi_exp.Name = "garansi_exp"
        Me.garansi_exp.Width = 125
        '
        'txt_kdpos
        '
        Me.txt_kdpos.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos.Location = New System.Drawing.Point(677, 115)
        Me.txt_kdpos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kdpos.Name = "txt_kdpos"
        Me.txt_kdpos.Size = New System.Drawing.Size(236, 22)
        Me.txt_kdpos.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(516, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 17)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Kodepos"
        '
        'txt_kota
        '
        Me.txt_kota.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota.Location = New System.Drawing.Point(677, 81)
        Me.txt_kota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kota.Name = "txt_kota"
        Me.txt_kota.Size = New System.Drawing.Size(236, 22)
        Me.txt_kota.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(516, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Kota Client"
        '
        'txt_alamat
        '
        Me.txt_alamat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat.Location = New System.Drawing.Point(677, 44)
        Me.txt_alamat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(236, 22)
        Me.txt_alamat.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(516, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 17)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Alamat Transaksi"
        '
        'cmb_garansi
        '
        Me.cmb_garansi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_garansi.FormattingEnabled = True
        Me.cmb_garansi.Location = New System.Drawing.Point(250, 181)
        Me.cmb_garansi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_garansi.Name = "cmb_garansi"
        Me.cmb_garansi.Size = New System.Drawing.Size(236, 24)
        Me.cmb_garansi.TabIndex = 5
        '
        'txt_kd_transaksi
        '
        Me.txt_kd_transaksi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kd_transaksi.Location = New System.Drawing.Point(250, 41)
        Me.txt_kd_transaksi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kd_transaksi.Name = "txt_kd_transaksi"
        Me.txt_kd_transaksi.Size = New System.Drawing.Size(236, 22)
        Me.txt_kd_transaksi.TabIndex = 1
        '
        'pict_logo
        '
        Me.pict_logo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1169, 4)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(180, 86)
        Me.pict_logo.TabIndex = 48
        Me.pict_logo.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(613, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(339, 58)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Penjualan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(12, 11)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(63, 69)
        Me.btn_kembali.TabIndex = 30
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(123, 734)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(93, 39)
        Me.btn_hapus.TabIndex = 19
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(11, 734)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(93, 39)
        Me.btn_simpan.TabIndex = 18
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(445, 742)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Harga Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(445, 780)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 17)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Diskon"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(445, 822)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 17)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Harga Akhir"
        '
        'txt_harga_total
        '
        Me.txt_harga_total.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_harga_total.Enabled = False
        Me.txt_harga_total.Location = New System.Drawing.Point(572, 742)
        Me.txt_harga_total.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga_total.Name = "txt_harga_total"
        Me.txt_harga_total.Size = New System.Drawing.Size(236, 22)
        Me.txt_harga_total.TabIndex = 20
        '
        'txt_diskon
        '
        Me.txt_diskon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_diskon.Location = New System.Drawing.Point(572, 780)
        Me.txt_diskon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_diskon.Name = "txt_diskon"
        Me.txt_diskon.Size = New System.Drawing.Size(236, 22)
        Me.txt_diskon.TabIndex = 21
        '
        'txt_harga_akhir
        '
        Me.txt_harga_akhir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_harga_akhir.Enabled = False
        Me.txt_harga_akhir.Location = New System.Drawing.Point(572, 820)
        Me.txt_harga_akhir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_harga_akhir.Name = "txt_harga_akhir"
        Me.txt_harga_akhir.Size = New System.Drawing.Size(236, 22)
        Me.txt_harga_akhir.TabIndex = 22
        '
        'btn_invoice
        '
        Me.btn_invoice.Location = New System.Drawing.Point(1231, 733)
        Me.btn_invoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(227, 30)
        Me.btn_invoice.TabIndex = 27
        Me.btn_invoice.Text = "Cetak Invoice"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'btn_kwitansi
        '
        Me.btn_kwitansi.Location = New System.Drawing.Point(1230, 773)
        Me.btn_kwitansi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kwitansi.Name = "btn_kwitansi"
        Me.btn_kwitansi.Size = New System.Drawing.Size(227, 30)
        Me.btn_kwitansi.TabIndex = 28
        Me.btn_kwitansi.Text = "Cetak Kwitansi"
        Me.btn_kwitansi.UseVisualStyleBackColor = True
        '
        'btn_tanda_terima
        '
        Me.btn_tanda_terima.Location = New System.Drawing.Point(1231, 813)
        Me.btn_tanda_terima.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_tanda_terima.Name = "btn_tanda_terima"
        Me.btn_tanda_terima.Size = New System.Drawing.Size(227, 30)
        Me.btn_tanda_terima.TabIndex = 29
        Me.btn_tanda_terima.Text = "Cetak Tanda Terima"
        Me.btn_tanda_terima.UseVisualStyleBackColor = True
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_subtotal.Enabled = False
        Me.txt_subtotal.Location = New System.Drawing.Point(949, 822)
        Me.txt_subtotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(236, 22)
        Me.txt_subtotal.TabIndex = 26
        '
        'txt_ppn
        '
        Me.txt_ppn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_ppn.Location = New System.Drawing.Point(572, 863)
        Me.txt_ppn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ppn.Name = "txt_ppn"
        Me.txt_ppn.Size = New System.Drawing.Size(236, 22)
        Me.txt_ppn.TabIndex = 23
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(822, 825)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 17)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "SubTotal "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(822, 783)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 17)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "ShipingHandling"
        '
        'PPN
        '
        Me.PPN.AutoSize = True
        Me.PPN.Location = New System.Drawing.Point(445, 863)
        Me.PPN.Name = "PPN"
        Me.PPN.Size = New System.Drawing.Size(36, 17)
        Me.PPN.TabIndex = 62
        Me.PPN.Text = "PPN"
        '
        'txt_shiphand
        '
        Me.txt_shiphand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_shiphand.Location = New System.Drawing.Point(949, 783)
        Me.txt_shiphand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_shiphand.Name = "txt_shiphand"
        Me.txt_shiphand.Size = New System.Drawing.Size(236, 22)
        Me.txt_shiphand.TabIndex = 25
        '
        'txt_ppn_nominal
        '
        Me.txt_ppn_nominal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_ppn_nominal.Enabled = False
        Me.txt_ppn_nominal.Location = New System.Drawing.Point(949, 742)
        Me.txt_ppn_nominal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_ppn_nominal.Name = "txt_ppn_nominal"
        Me.txt_ppn_nominal.Size = New System.Drawing.Size(236, 22)
        Me.txt_ppn_nominal.TabIndex = 24
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(822, 742)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 17)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "PPN Nominal"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Controls.Add(Me.pict_logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1458, 97)
        Me.Panel1.TabIndex = 71
        '
        'BarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1356, 922)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_ppn_nominal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_shiphand)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.txt_ppn)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.PPN)
        Me.Controls.Add(Me.btn_tanda_terima)
        Me.Controls.Add(Me.btn_kwitansi)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.txt_harga_akhir)
        Me.Controls.Add(Me.txt_diskon)
        Me.Controls.Add(Me.txt_harga_total)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BarangKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dt_barang_masuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents date_tgl_keluar As DateTimePicker
    Friend WithEvents dt_barang_masuk As DataGridView
    Friend WithEvents cmb_tipe_barang As ComboBox
    Friend WithEvents cmb_jenis_barang As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_client As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_garansi As ComboBox
    Friend WithEvents txt_kd_transaksi As TextBox
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_kdpos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_kota As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_harga_total As TextBox
    Friend WithEvents txt_diskon As TextBox
    Friend WithEvents txt_harga_akhir As TextBox
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_kwitansi As Button
    Friend WithEvents btn_tanda_terima As Button
    Friend WithEvents btn_tambha As Button
    Friend WithEvents dt_barang_keluar_fix As DataGridView
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents serial_number As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
    Friend WithEvents tested As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
    Friend WithEvents detail_lokasi As DataGridViewTextBoxColumn
    Friend WithEvents catatan As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents harga_jual As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang2 As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang2 As DataGridViewTextBoxColumn
    Friend WithEvents serial_number2 As DataGridViewTextBoxColumn
    Friend WithEvents kondisi2 As DataGridViewTextBoxColumn
    Friend WithEvents tested2 As DataGridViewTextBoxColumn
    Friend WithEvents lokasi2 As DataGridViewTextBoxColumn
    Friend WithEvents detail_lokasi2 As DataGridViewTextBoxColumn
    Friend WithEvents catatan2 As DataGridViewTextBoxColumn
    Friend WithEvents status2 As DataGridViewTextBoxColumn
    Friend WithEvents harga_jual2 As DataGridViewTextBoxColumn
    Friend WithEvents garansi As DataGridViewTextBoxColumn
    Friend WithEvents garansi_type As DataGridViewComboBoxColumn
    Friend WithEvents garansi_exp As DataGridViewTextBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_kdpos_ship As TextBox
    Friend WithEvents txt_kota_ship As TextBox
    Friend WithEvents txt_alamat_ship As TextBox
    Friend WithEvents txt_client_ship As TextBox
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents txt_ppn As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PPN As Label
    Friend WithEvents txt_shiphand As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_ppn_nominal As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
End Class
