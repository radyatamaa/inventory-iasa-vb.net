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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarangMasuk))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dt_barang_masuk = New System.Windows.Forms.DataGridView()
        Me.dt_jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_tested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_detail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_lincese = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_catatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_hargamodal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_hargabarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_tgl_masuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_warna = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
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
        Me.warna = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.hapus_data_barang_masuk = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dt_barang_masuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_barang_masuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.dt_barang_masuk)
        Me.Panel2.Controls.Add(Me.cmb_warna)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btn_kembali)
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
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1158, 739)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(884, 127)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dt_barang_masuk
        '
        Me.dt_barang_masuk.AllowUserToOrderColumns = True
        Me.dt_barang_masuk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_masuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dt_barang_masuk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt_barang_masuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_masuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dt_jenis_barang, Me.dt_tipe_barang, Me.dt_serial, Me.dt_kondisi, Me.dt_tested, Me.dt_lokasi, Me.dt_detail, Me.dt_lincese, Me.dt_catatan, Me.dt_status, Me.dt_hargamodal, Me.dt_hargabarang, Me.dt_tgl_masuk})
        Me.dt_barang_masuk.Location = New System.Drawing.Point(2, 534)
        Me.dt_barang_masuk.Margin = New System.Windows.Forms.Padding(2)
        Me.dt_barang_masuk.Name = "dt_barang_masuk"
        Me.dt_barang_masuk.RowHeadersWidth = 51
        Me.dt_barang_masuk.RowTemplate.Height = 24
        Me.dt_barang_masuk.Size = New System.Drawing.Size(1140, 191)
        Me.dt_barang_masuk.TabIndex = 55
        '
        'dt_jenis_barang
        '
        Me.dt_jenis_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_jenis_barang.HeaderText = "Jenis Barang"
        Me.dt_jenis_barang.MinimumWidth = 6
        Me.dt_jenis_barang.Name = "dt_jenis_barang"
        '
        'dt_tipe_barang
        '
        Me.dt_tipe_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_tipe_barang.HeaderText = "Tipe Detail Barang"
        Me.dt_tipe_barang.MinimumWidth = 6
        Me.dt_tipe_barang.Name = "dt_tipe_barang"
        '
        'dt_serial
        '
        Me.dt_serial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_serial.HeaderText = "Serial Number"
        Me.dt_serial.MinimumWidth = 6
        Me.dt_serial.Name = "dt_serial"
        '
        'dt_kondisi
        '
        Me.dt_kondisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_kondisi.HeaderText = "Kondisi"
        Me.dt_kondisi.MinimumWidth = 6
        Me.dt_kondisi.Name = "dt_kondisi"
        '
        'dt_tested
        '
        Me.dt_tested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_tested.HeaderText = "Tested"
        Me.dt_tested.MinimumWidth = 6
        Me.dt_tested.Name = "dt_tested"
        '
        'dt_lokasi
        '
        Me.dt_lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_lokasi.HeaderText = "Lokasi"
        Me.dt_lokasi.MinimumWidth = 6
        Me.dt_lokasi.Name = "dt_lokasi"
        '
        'dt_detail
        '
        Me.dt_detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_detail.HeaderText = "Detail Lokasi"
        Me.dt_detail.MinimumWidth = 6
        Me.dt_detail.Name = "dt_detail"
        '
        'dt_lincese
        '
        Me.dt_lincese.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_lincese.HeaderText = "License"
        Me.dt_lincese.MinimumWidth = 6
        Me.dt_lincese.Name = "dt_lincese"
        '
        'dt_catatan
        '
        Me.dt_catatan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_catatan.HeaderText = "Catatan"
        Me.dt_catatan.MinimumWidth = 6
        Me.dt_catatan.Name = "dt_catatan"
        '
        'dt_status
        '
        Me.dt_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_status.HeaderText = "Status"
        Me.dt_status.MinimumWidth = 6
        Me.dt_status.Name = "dt_status"
        '
        'dt_hargamodal
        '
        Me.dt_hargamodal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_hargamodal.HeaderText = "Harga Modal"
        Me.dt_hargamodal.MinimumWidth = 6
        Me.dt_hargamodal.Name = "dt_hargamodal"
        '
        'dt_hargabarang
        '
        Me.dt_hargabarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_hargabarang.HeaderText = "Harga Barang"
        Me.dt_hargabarang.MinimumWidth = 6
        Me.dt_hargabarang.Name = "dt_hargabarang"
        '
        'dt_tgl_masuk
        '
        Me.dt_tgl_masuk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dt_tgl_masuk.HeaderText = "Tanggal Masuk"
        Me.dt_tgl_masuk.MinimumWidth = 6
        Me.dt_tgl_masuk.Name = "dt_tgl_masuk"
        '
        'cmb_warna
        '
        Me.cmb_warna.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_warna.FormattingEnabled = True
        Me.cmb_warna.Location = New System.Drawing.Point(695, 131)
        Me.cmb_warna.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_warna.Name = "cmb_warna"
        Me.cmb_warna.Size = New System.Drawing.Size(178, 21)
        Me.cmb_warna.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(610, 136)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Warna"
        '
        'pict_logo
        '
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(981, 7)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(117, 70)
        Me.pict_logo.TabIndex = 51
        Me.pict_logo.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(398, 7)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(254, 47)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Barang Masuk"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(2, 7)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(76, 56)
        Me.btn_kembali.TabIndex = 49
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'txt_kode_barang
        '
        Me.txt_kode_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kode_barang.Location = New System.Drawing.Point(137, 131)
        Me.txt_kode_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_kode_barang.Name = "txt_kode_barang"
        Me.txt_kode_barang.Size = New System.Drawing.Size(178, 20)
        Me.txt_kode_barang.TabIndex = 35
        '
        'cmb_status
        '
        Me.cmb_status.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Location = New System.Drawing.Point(695, 164)
        Me.cmb_status.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(178, 21)
        Me.cmb_status.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(610, 162)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Status"
        '
        'txt_catatan
        '
        Me.txt_catatan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_catatan.Location = New System.Drawing.Point(423, 244)
        Me.txt_catatan.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_catatan.Name = "txt_catatan"
        Me.txt_catatan.Size = New System.Drawing.Size(178, 20)
        Me.txt_catatan.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(338, 246)
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
        Me.cmb_detail_lokasi.Location = New System.Drawing.Point(423, 188)
        Me.cmb_detail_lokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_detail_lokasi.Name = "cmb_detail_lokasi"
        Me.cmb_detail_lokasi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_detail_lokasi.TabIndex = 30
        '
        'txt_harga_modal
        '
        Me.txt_harga_modal.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_harga_modal.Location = New System.Drawing.Point(695, 188)
        Me.txt_harga_modal.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_harga_modal.Name = "txt_harga_modal"
        Me.txt_harga_modal.Size = New System.Drawing.Size(178, 20)
        Me.txt_harga_modal.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(610, 190)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Harga Modal"
        '
        'txt_harga_barang
        '
        Me.txt_harga_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_harga_barang.Location = New System.Drawing.Point(695, 219)
        Me.txt_harga_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_harga_barang.Name = "txt_harga_barang"
        Me.txt_harga_barang.Size = New System.Drawing.Size(178, 20)
        Me.txt_harga_barang.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(610, 219)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Harga Barang"
        '
        'txt_lisensi
        '
        Me.txt_lisensi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_lisensi.Location = New System.Drawing.Point(423, 219)
        Me.txt_lisensi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_lisensi.Name = "txt_lisensi"
        Me.txt_lisensi.Size = New System.Drawing.Size(178, 20)
        Me.txt_lisensi.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(338, 222)
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
        Me.Label9.Location = New System.Drawing.Point(610, 250)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tanggal Masuk"
        '
        'date_tgl_masuk
        '
        Me.date_tgl_masuk.Location = New System.Drawing.Point(695, 250)
        Me.date_tgl_masuk.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tgl_masuk.Name = "date_tgl_masuk"
        Me.date_tgl_masuk.Size = New System.Drawing.Size(178, 20)
        Me.date_tgl_masuk.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(338, 193)
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
        Me.Label1.Location = New System.Drawing.Point(16, 132)
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
        Me.btn_simpan.Location = New System.Drawing.Point(8, 484)
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
        Me.data_barang_masuk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_barang_masuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_barang_masuk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_barang_masuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_barang_masuk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenis_barang, Me.tipe_barang, Me.serial_number, Me.kondisi, Me.tested, Me.lokasi, Me.detail_lokasi, Me.lisensi, Me.catatan, Me.status_barang, Me.warna, Me.harga_modal, Me.harga_barang, Me.tgl_masuk})
        Me.data_barang_masuk.Location = New System.Drawing.Point(0, 281)
        Me.data_barang_masuk.Margin = New System.Windows.Forms.Padding(2)
        Me.data_barang_masuk.Name = "data_barang_masuk"
        Me.data_barang_masuk.RowHeadersWidth = 51
        Me.data_barang_masuk.RowTemplate.Height = 24
        Me.data_barang_masuk.Size = New System.Drawing.Size(1140, 184)
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
        'warna
        '
        Me.warna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.warna.HeaderText = "Warna"
        Me.warna.MinimumWidth = 6
        Me.warna.Name = "warna"
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
        Me.cbx_tidak_teruji.Location = New System.Drawing.Point(477, 134)
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
        Me.cbx_teruji.Location = New System.Drawing.Point(423, 134)
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
        Me.cmb_lokasi.Location = New System.Drawing.Point(423, 159)
        Me.cmb_lokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_lokasi.Name = "cmb_lokasi"
        Me.cmb_lokasi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_lokasi.TabIndex = 13
        '
        'cmb_kondisi
        '
        Me.cmb_kondisi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_kondisi.FormattingEnabled = True
        Me.cmb_kondisi.Location = New System.Drawing.Point(137, 244)
        Me.cmb_kondisi.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_kondisi.Name = "cmb_kondisi"
        Me.cmb_kondisi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_kondisi.TabIndex = 11
        '
        'cmb_tipe_barang
        '
        Me.cmb_tipe_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_tipe_barang.FormattingEnabled = True
        Me.cmb_tipe_barang.Location = New System.Drawing.Point(137, 191)
        Me.cmb_tipe_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipe_barang.Name = "cmb_tipe_barang"
        Me.cmb_tipe_barang.Size = New System.Drawing.Size(178, 21)
        Me.cmb_tipe_barang.TabIndex = 10
        '
        'cmb_jenis_barang
        '
        Me.cmb_jenis_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis_barang.FormattingEnabled = True
        Me.cmb_jenis_barang.Location = New System.Drawing.Point(137, 164)
        Me.cmb_jenis_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_jenis_barang.Name = "cmb_jenis_barang"
        Me.cmb_jenis_barang.Size = New System.Drawing.Size(178, 21)
        Me.cmb_jenis_barang.TabIndex = 9
        '
        'txt_serial
        '
        Me.txt_serial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_serial.Location = New System.Drawing.Point(137, 219)
        Me.txt_serial.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_serial.Name = "txt_serial"
        Me.txt_serial.Size = New System.Drawing.Size(178, 20)
        Me.txt_serial.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(336, 162)
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
        Me.Label6.Location = New System.Drawing.Point(336, 136)
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
        Me.Label5.Location = New System.Drawing.Point(16, 250)
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
        Me.Label4.Location = New System.Drawing.Point(16, 219)
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
        Me.Label3.Location = New System.Drawing.Point(16, 193)
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
        Me.Label2.Location = New System.Drawing.Point(16, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Barang"
        '
        'hapus_data_barang_masuk
        '
        Me.hapus_data_barang_masuk.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.hapus_data_barang_masuk.FlatAppearance.BorderSize = 0
        Me.hapus_data_barang_masuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus_data_barang_masuk.Location = New System.Drawing.Point(16, 772)
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
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.hapus_data_barang_masuk)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BarangMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang Masuk"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dt_barang_masuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_barang_masuk, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents hapus_data_barang_masuk As Button
    Friend WithEvents txt_kode_barang As TextBox
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dt_barang_masuk As DataGridView
    Friend WithEvents dt_jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents dt_tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents dt_serial As DataGridViewTextBoxColumn
    Friend WithEvents dt_kondisi As DataGridViewTextBoxColumn
    Friend WithEvents dt_tested As DataGridViewTextBoxColumn
    Friend WithEvents dt_lokasi As DataGridViewTextBoxColumn
    Friend WithEvents dt_detail As DataGridViewTextBoxColumn
    Friend WithEvents dt_lincese As DataGridViewTextBoxColumn
    Friend WithEvents dt_catatan As DataGridViewTextBoxColumn
    Friend WithEvents dt_status As DataGridViewTextBoxColumn
    Friend WithEvents dt_hargamodal As DataGridViewTextBoxColumn
    Friend WithEvents dt_hargabarang As DataGridViewTextBoxColumn
    Friend WithEvents dt_tgl_masuk As DataGridViewTextBoxColumn
    Friend WithEvents cmb_warna As ComboBox
    Friend WithEvents Label16 As Label
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
    Friend WithEvents warna As DataGridViewTextBoxColumn
    Friend WithEvents harga_modal As DataGridViewTextBoxColumn
    Friend WithEvents harga_barang As DataGridViewTextBoxColumn
    Friend WithEvents tgl_masuk As DataGridViewTextBoxColumn
End Class
