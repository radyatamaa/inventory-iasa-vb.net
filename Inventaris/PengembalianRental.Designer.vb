<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PengembalianRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PengembalianRental))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.date_tgl_keluar = New System.Windows.Forms.DateTimePicker()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.dt_barang_keluar_fix = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_barang_keluar = New System.Windows.Forms.DataGridView()
        Me.kd_transaksi_keluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.periode_rental_lama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rental_type_lama = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.rental_exp_lama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncari = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_client = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_tipe_barang = New System.Windows.Forms.ComboBox()
        Me.cmb_jenis_barang = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_barang_keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.pict_logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 97)
        Me.Panel1.TabIndex = 0
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(9, 9)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(75, 67)
        Me.btn_kembali.TabIndex = 49
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(267, 47)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Pengembalian Rental"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pict_logo
        '
        Me.pict_logo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(877, 9)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(135, 70)
        Me.pict_logo.TabIndex = 51
        Me.pict_logo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.date_tgl_keluar)
        Me.Panel2.Controls.Add(Me.btn_tambah)
        Me.Panel2.Controls.Add(Me.dt_barang_keluar_fix)
        Me.Panel2.Controls.Add(Me.dt_barang_keluar)
        Me.Panel2.Controls.Add(Me.btncari)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cmb_client)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cmb_tipe_barang)
        Me.Panel2.Controls.Add(Me.cmb_jenis_barang)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 93)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1116, 466)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(461, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Tanggal Pengembalian"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'date_tgl_keluar
        '
        Me.date_tgl_keluar.Location = New System.Drawing.Point(581, 18)
        Me.date_tgl_keluar.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tgl_keluar.Name = "date_tgl_keluar"
        Me.date_tgl_keluar.Size = New System.Drawing.Size(178, 20)
        Me.date_tgl_keluar.TabIndex = 80
        '
        'btn_tambah
        '
        Me.btn_tambah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_tambah.FlatAppearance.BorderSize = 0
        Me.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tambah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tambah.Location = New System.Drawing.Point(9, 248)
        Me.btn_tambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(178, 26)
        Me.btn_tambah.TabIndex = 79
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = False
        '
        'dt_barang_keluar_fix
        '
        Me.dt_barang_keluar_fix.AllowUserToOrderColumns = True
        Me.dt_barang_keluar_fix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_keluar_fix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_barang_keluar_fix.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_barang_keluar_fix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_keluar_fix.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn13})
        Me.dt_barang_keluar_fix.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_barang_keluar_fix.Location = New System.Drawing.Point(2, 291)
        Me.dt_barang_keluar_fix.Margin = New System.Windows.Forms.Padding(2)
        Me.dt_barang_keluar_fix.Name = "dt_barang_keluar_fix"
        Me.dt_barang_keluar_fix.RowHeadersWidth = 51
        Me.dt_barang_keluar_fix.RowTemplate.Height = 24
        Me.dt_barang_keluar_fix.Size = New System.Drawing.Size(1015, 119)
        Me.dt_barang_keluar_fix.TabIndex = 78
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode Transaksi Keluar"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Jenis Barang"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 125
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipe Barang"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 125
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.HeaderText = "Serial Number"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 125
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Kondisi"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 125
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tested"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Lokasi"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Detail Lokasi"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Catatan"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn11.HeaderText = "Harga Rental Lama"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Periode Rental Lama"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.HeaderText = "Rental Type Lama"
        Me.DataGridViewComboBoxColumn1.Items.AddRange(New Object() {"Hari", "Bulan", "Tahun"})
        Me.DataGridViewComboBoxColumn1.MinimumWidth = 6
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Rental Exp Lama"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'dt_barang_keluar
        '
        Me.dt_barang_keluar.AllowUserToOrderColumns = True
        Me.dt_barang_keluar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_barang_keluar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_barang_keluar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_barang_keluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_barang_keluar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_transaksi_keluar, Me.jenis_barang, Me.tipe_barang, Me.serial_number, Me.kondisi, Me.tested, Me.lokasi, Me.detail_lokasi, Me.catatan, Me.status, Me.harga_jual, Me.periode_rental_lama, Me.rental_type_lama, Me.rental_exp_lama})
        Me.dt_barang_keluar.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_barang_keluar.Location = New System.Drawing.Point(2, 116)
        Me.dt_barang_keluar.Margin = New System.Windows.Forms.Padding(2)
        Me.dt_barang_keluar.Name = "dt_barang_keluar"
        Me.dt_barang_keluar.RowHeadersWidth = 51
        Me.dt_barang_keluar.RowTemplate.Height = 24
        Me.dt_barang_keluar.Size = New System.Drawing.Size(1015, 119)
        Me.dt_barang_keluar.TabIndex = 77
        '
        'kd_transaksi_keluar
        '
        Me.kd_transaksi_keluar.HeaderText = "Kode Transaksi Keluar"
        Me.kd_transaksi_keluar.MinimumWidth = 150
        Me.kd_transaksi_keluar.Name = "kd_transaksi_keluar"
        Me.kd_transaksi_keluar.Width = 150
        '
        'jenis_barang
        '
        Me.jenis_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jenis_barang.HeaderText = "Jenis Barang"
        Me.jenis_barang.MinimumWidth = 125
        Me.jenis_barang.Name = "jenis_barang"
        '
        'tipe_barang
        '
        Me.tipe_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang.HeaderText = "Tipe Barang"
        Me.tipe_barang.MinimumWidth = 125
        Me.tipe_barang.Name = "tipe_barang"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Serial Number"
        Me.serial_number.MinimumWidth = 125
        Me.serial_number.Name = "serial_number"
        '
        'kondisi
        '
        Me.kondisi.HeaderText = "Kondisi"
        Me.kondisi.MinimumWidth = 125
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.harga_jual.DefaultCellStyle = DataGridViewCellStyle4
        Me.harga_jual.HeaderText = "Harga Rental Lama"
        Me.harga_jual.MinimumWidth = 6
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Width = 125
        '
        'periode_rental_lama
        '
        Me.periode_rental_lama.HeaderText = "Periode Rental Lama"
        Me.periode_rental_lama.MinimumWidth = 6
        Me.periode_rental_lama.Name = "periode_rental_lama"
        Me.periode_rental_lama.Width = 125
        '
        'rental_type_lama
        '
        Me.rental_type_lama.HeaderText = "Rental Type Lama"
        Me.rental_type_lama.Items.AddRange(New Object() {"Hari", "Bulan", "Tahun"})
        Me.rental_type_lama.MinimumWidth = 6
        Me.rental_type_lama.Name = "rental_type_lama"
        Me.rental_type_lama.Width = 125
        '
        'rental_exp_lama
        '
        Me.rental_exp_lama.HeaderText = "Rental Exp Lama"
        Me.rental_exp_lama.MinimumWidth = 6
        Me.rental_exp_lama.Name = "rental_exp_lama"
        Me.rental_exp_lama.Width = 125
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(759, 73)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(39, 23)
        Me.btncari.TabIndex = 75
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(581, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 26)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Cari Barang/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Serial Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmb_client
        '
        Me.cmb_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_client.FormattingEnabled = True
        Me.cmb_client.Location = New System.Drawing.Point(271, 14)
        Me.cmb_client.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_client.Name = "cmb_client"
        Me.cmb_client.Size = New System.Drawing.Size(178, 21)
        Me.cmb_client.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Kode Client"
        '
        'cmb_tipe_barang
        '
        Me.cmb_tipe_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_tipe_barang.FormattingEnabled = True
        Me.cmb_tipe_barang.Location = New System.Drawing.Point(271, 76)
        Me.cmb_tipe_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipe_barang.Name = "cmb_tipe_barang"
        Me.cmb_tipe_barang.Size = New System.Drawing.Size(178, 21)
        Me.cmb_tipe_barang.TabIndex = 8
        '
        'cmb_jenis_barang
        '
        Me.cmb_jenis_barang.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis_barang.FormattingEnabled = True
        Me.cmb_jenis_barang.Location = New System.Drawing.Point(271, 44)
        Me.cmb_jenis_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_jenis_barang.Name = "cmb_jenis_barang"
        Me.cmb_jenis_barang.Size = New System.Drawing.Size(178, 21)
        Me.cmb_jenis_barang.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipe Barang"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jenis Barang"
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(76, 564)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(70, 49)
        Me.btn_hapus.TabIndex = 21
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(2, 563)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(70, 49)
        Me.btn_simpan.TabIndex = 20
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'PengembalianRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PengembalianRental"
        Me.Text = "PengembalianRental"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dt_barang_keluar_fix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_barang_keluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_tipe_barang As ComboBox
    Friend WithEvents cmb_jenis_barang As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_client As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btncari As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dt_barang_keluar_fix As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents dt_barang_keluar As DataGridView
    Friend WithEvents kd_transaksi_keluar As DataGridViewTextBoxColumn
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
    Friend WithEvents periode_rental_lama As DataGridViewTextBoxColumn
    Friend WithEvents rental_type_lama As DataGridViewComboBoxColumn
    Friend WithEvents rental_exp_lama As DataGridViewTextBoxColumn
    Friend WithEvents btn_tambah As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents date_tgl_keluar As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
