<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoice_cetak
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dt_transaksi = New System.Windows.Forms.DataGridView()
        Me.kd_transaksi_keluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_akhir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_pengiriman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kota_pengiriman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdpos_pengiriman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_keluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flag_bayar = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btn_tampil = New System.Windows.Forms.Button()
        Me.date_tgl_keluar1 = New System.Windows.Forms.DateTimePicker()
        Me.date_tgl_keluar2 = New System.Windows.Forms.DateTimePicker()
        Me.btn_tampil_list = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncari2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.dt_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 523)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(960, 560)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.Visible = False
        '
        'dt_transaksi
        '
        Me.dt_transaksi.AllowUserToOrderColumns = True
        Me.dt_transaksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_transaksi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_transaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_transaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_transaksi_keluar, Me.harga_total, Me.diskon, Me.harga_akhir, Me.nama_client, Me.alamat_pengiriman, Me.kota_pengiriman, Me.kdpos_pengiriman, Me.tgl_keluar, Me.total_barang, Me.created_by, Me.created_date, Me.status_barang, Me.flag_bayar})
        Me.dt_transaksi.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_transaksi.Location = New System.Drawing.Point(1, 83)
        Me.dt_transaksi.Margin = New System.Windows.Forms.Padding(2)
        Me.dt_transaksi.Name = "dt_transaksi"
        Me.dt_transaksi.RowHeadersWidth = 51
        Me.dt_transaksi.RowTemplate.Height = 24
        Me.dt_transaksi.Size = New System.Drawing.Size(960, 393)
        Me.dt_transaksi.TabIndex = 56
        '
        'kd_transaksi_keluar
        '
        Me.kd_transaksi_keluar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.kd_transaksi_keluar.DefaultCellStyle = DataGridViewCellStyle2
        Me.kd_transaksi_keluar.HeaderText = "Kode Transaksi / Invoice No"
        Me.kd_transaksi_keluar.MinimumWidth = 170
        Me.kd_transaksi_keluar.Name = "kd_transaksi_keluar"
        '
        'harga_total
        '
        Me.harga_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.harga_total.DefaultCellStyle = DataGridViewCellStyle3
        Me.harga_total.HeaderText = "Harga Total"
        Me.harga_total.MinimumWidth = 125
        Me.harga_total.Name = "harga_total"
        '
        'diskon
        '
        Me.diskon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.diskon.DefaultCellStyle = DataGridViewCellStyle4
        Me.diskon.HeaderText = "Diskon"
        Me.diskon.MinimumWidth = 125
        Me.diskon.Name = "diskon"
        '
        'harga_akhir
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.harga_akhir.DefaultCellStyle = DataGridViewCellStyle5
        Me.harga_akhir.HeaderText = "Harga Akhir"
        Me.harga_akhir.MinimumWidth = 125
        Me.harga_akhir.Name = "harga_akhir"
        Me.harga_akhir.Width = 125
        '
        'nama_client
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.nama_client.DefaultCellStyle = DataGridViewCellStyle6
        Me.nama_client.HeaderText = "Nama Client"
        Me.nama_client.MinimumWidth = 6
        Me.nama_client.Name = "nama_client"
        Me.nama_client.Width = 125
        '
        'alamat_pengiriman
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.alamat_pengiriman.DefaultCellStyle = DataGridViewCellStyle7
        Me.alamat_pengiriman.HeaderText = "Alamat Pengiriman"
        Me.alamat_pengiriman.MinimumWidth = 6
        Me.alamat_pengiriman.Name = "alamat_pengiriman"
        Me.alamat_pengiriman.Width = 125
        '
        'kota_pengiriman
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.kota_pengiriman.DefaultCellStyle = DataGridViewCellStyle8
        Me.kota_pengiriman.HeaderText = "Kota Pengiriman"
        Me.kota_pengiriman.MinimumWidth = 6
        Me.kota_pengiriman.Name = "kota_pengiriman"
        Me.kota_pengiriman.Width = 125
        '
        'kdpos_pengiriman
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.kdpos_pengiriman.DefaultCellStyle = DataGridViewCellStyle9
        Me.kdpos_pengiriman.HeaderText = "Kodepos Pengiriman"
        Me.kdpos_pengiriman.MinimumWidth = 140
        Me.kdpos_pengiriman.Name = "kdpos_pengiriman"
        Me.kdpos_pengiriman.Width = 140
        '
        'tgl_keluar
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.tgl_keluar.DefaultCellStyle = DataGridViewCellStyle10
        Me.tgl_keluar.HeaderText = "Tanggal Keluar"
        Me.tgl_keluar.MinimumWidth = 6
        Me.tgl_keluar.Name = "tgl_keluar"
        Me.tgl_keluar.Width = 125
        '
        'total_barang
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.total_barang.DefaultCellStyle = DataGridViewCellStyle11
        Me.total_barang.HeaderText = "Total Barang"
        Me.total_barang.MinimumWidth = 6
        Me.total_barang.Name = "total_barang"
        Me.total_barang.Width = 125
        '
        'created_by
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.created_by.DefaultCellStyle = DataGridViewCellStyle12
        Me.created_by.HeaderText = "Created By"
        Me.created_by.Name = "created_by"
        '
        'created_date
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.created_date.DefaultCellStyle = DataGridViewCellStyle13
        Me.created_date.HeaderText = "Created Date"
        Me.created_date.Name = "created_date"
        '
        'status_barang
        '
        Me.status_barang.HeaderText = "Type Of Service"
        Me.status_barang.Name = "status_barang"
        '
        'flag_bayar
        '
        Me.flag_bayar.HeaderText = "Already Paid"
        Me.flag_bayar.Items.AddRange(New Object() {"No", "Yes"})
        Me.flag_bayar.Name = "flag_bayar"
        '
        'btn_tampil
        '
        Me.btn_tampil.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_tampil.FlatAppearance.BorderSize = 0
        Me.btn_tampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tampil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tampil.Location = New System.Drawing.Point(11, 492)
        Me.btn_tampil.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tampil.Name = "btn_tampil"
        Me.btn_tampil.Size = New System.Drawing.Size(178, 26)
        Me.btn_tampil.TabIndex = 57
        Me.btn_tampil.Text = "Tampil"
        Me.btn_tampil.UseVisualStyleBackColor = False
        '
        'date_tgl_keluar1
        '
        Me.date_tgl_keluar1.Location = New System.Drawing.Point(110, 7)
        Me.date_tgl_keluar1.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tgl_keluar1.Name = "date_tgl_keluar1"
        Me.date_tgl_keluar1.Size = New System.Drawing.Size(183, 20)
        Me.date_tgl_keluar1.TabIndex = 58
        '
        'date_tgl_keluar2
        '
        Me.date_tgl_keluar2.Location = New System.Drawing.Point(324, 7)
        Me.date_tgl_keluar2.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tgl_keluar2.Name = "date_tgl_keluar2"
        Me.date_tgl_keluar2.Size = New System.Drawing.Size(193, 20)
        Me.date_tgl_keluar2.TabIndex = 61
        '
        'btn_tampil_list
        '
        Me.btn_tampil_list.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_tampil_list.FlatAppearance.BorderSize = 0
        Me.btn_tampil_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tampil_list.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tampil_list.Location = New System.Drawing.Point(520, 4)
        Me.btn_tampil_list.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tampil_list.Name = "btn_tampil_list"
        Me.btn_tampil_list.Size = New System.Drawing.Size(178, 26)
        Me.btn_tampil_list.TabIndex = 62
        Me.btn_tampil_list.Text = "Tampilkan List"
        Me.btn_tampil_list.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-2, 11)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Tanggal Keluar"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "s/d"
        '
        'btncari2
        '
        Me.btncari2.Location = New System.Drawing.Point(288, 59)
        Me.btncari2.Name = "btncari2"
        Me.btncari2.Size = New System.Drawing.Size(39, 20)
        Me.btncari2.TabIndex = 89
        Me.btncari2.Text = "Cari"
        Me.btncari2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(110, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 88
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 85
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(193, 492)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(95, 26)
        Me.btn_simpan.TabIndex = 91
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_hapus.FlatAppearance.BorderSize = 0
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_hapus.Location = New System.Drawing.Point(292, 492)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(95, 26)
        Me.btn_hapus.TabIndex = 92
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"No. Invoice", "Nama Client", "ID Client", "Flag Bayar"})
        Me.ComboBox1.Location = New System.Drawing.Point(1, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 21)
        Me.ComboBox1.TabIndex = 93
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"No. Invoice", "Nama Client", "ID Client", "Flag Bayar"})
        Me.ComboBox2.Location = New System.Drawing.Point(1, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(105, 21)
        Me.ComboBox2.TabIndex = 94
        '
        'invoice_cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(977, 749)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btncari2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_tampil_list)
        Me.Controls.Add(Me.date_tgl_keluar2)
        Me.Controls.Add(Me.date_tgl_keluar1)
        Me.Controls.Add(Me.btn_tampil)
        Me.Controls.Add(Me.dt_transaksi)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "invoice_cetak"
        Me.Text = "Cetak Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dt_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dt_transaksi As DataGridView
    Friend WithEvents btn_tampil As Button
    Friend WithEvents date_tgl_keluar1 As DateTimePicker
    Friend WithEvents date_tgl_keluar2 As DateTimePicker
    Friend WithEvents btn_tampil_list As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btncari2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents kd_transaksi_keluar As DataGridViewTextBoxColumn
    Friend WithEvents harga_total As DataGridViewTextBoxColumn
    Friend WithEvents diskon As DataGridViewTextBoxColumn
    Friend WithEvents harga_akhir As DataGridViewTextBoxColumn
    Friend WithEvents nama_client As DataGridViewTextBoxColumn
    Friend WithEvents alamat_pengiriman As DataGridViewTextBoxColumn
    Friend WithEvents kota_pengiriman As DataGridViewTextBoxColumn
    Friend WithEvents kdpos_pengiriman As DataGridViewTextBoxColumn
    Friend WithEvents tgl_keluar As DataGridViewTextBoxColumn
    Friend WithEvents total_barang As DataGridViewTextBoxColumn
    Friend WithEvents created_by As DataGridViewTextBoxColumn
    Friend WithEvents created_date As DataGridViewTextBoxColumn
    Friend WithEvents status_barang As DataGridViewTextBoxColumn
    Friend WithEvents flag_bayar As DataGridViewComboBoxColumn
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
