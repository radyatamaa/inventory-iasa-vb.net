<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cetak_kwitansi_barang
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
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_tampil_list = New System.Windows.Forms.Button()
        Me.date_tgl_keluar2 = New System.Windows.Forms.DateTimePicker()
        Me.date_tgl_keluar1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_tampil = New System.Windows.Forms.Button()
        Me.dt_transaksi = New System.Windows.Forms.DataGridView()
        CType(Me.dt_transaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Tanggal Keluar"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Inventaris.Report6_kwitansi_barang.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 200)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(974, 321)
        Me.ReportViewer1.TabIndex = 73
        '
        'kd_transaksi_keluar
        '
        Me.kd_transaksi_keluar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.kd_transaksi_keluar.DefaultCellStyle = DataGridViewCellStyle27
        Me.kd_transaksi_keluar.HeaderText = "Kode Transaksi / Invoice No"
        Me.kd_transaksi_keluar.MinimumWidth = 170
        Me.kd_transaksi_keluar.Name = "kd_transaksi_keluar"
        '
        'harga_total
        '
        Me.harga_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "N2"
        Me.harga_total.DefaultCellStyle = DataGridViewCellStyle28
        Me.harga_total.HeaderText = "Harga Total"
        Me.harga_total.MinimumWidth = 125
        Me.harga_total.Name = "harga_total"
        '
        'diskon
        '
        Me.diskon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Format = "N2"
        Me.diskon.DefaultCellStyle = DataGridViewCellStyle29
        Me.diskon.HeaderText = "Diskon"
        Me.diskon.MinimumWidth = 125
        Me.diskon.Name = "diskon"
        '
        'harga_akhir
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "N2"
        Me.harga_akhir.DefaultCellStyle = DataGridViewCellStyle30
        Me.harga_akhir.HeaderText = "Harga Akhir"
        Me.harga_akhir.MinimumWidth = 125
        Me.harga_akhir.Name = "harga_akhir"
        Me.harga_akhir.Width = 125
        '
        'nama_client
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.nama_client.DefaultCellStyle = DataGridViewCellStyle31
        Me.nama_client.HeaderText = "Nama Client"
        Me.nama_client.MinimumWidth = 6
        Me.nama_client.Name = "nama_client"
        Me.nama_client.Width = 125
        '
        'alamat_pengiriman
        '
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.alamat_pengiriman.DefaultCellStyle = DataGridViewCellStyle32
        Me.alamat_pengiriman.HeaderText = "Alamat Pengiriman"
        Me.alamat_pengiriman.MinimumWidth = 6
        Me.alamat_pengiriman.Name = "alamat_pengiriman"
        Me.alamat_pengiriman.Width = 125
        '
        'kota_pengiriman
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.kota_pengiriman.DefaultCellStyle = DataGridViewCellStyle33
        Me.kota_pengiriman.HeaderText = "Kota Pengiriman"
        Me.kota_pengiriman.MinimumWidth = 6
        Me.kota_pengiriman.Name = "kota_pengiriman"
        Me.kota_pengiriman.Width = 125
        '
        'kdpos_pengiriman
        '
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.kdpos_pengiriman.DefaultCellStyle = DataGridViewCellStyle34
        Me.kdpos_pengiriman.HeaderText = "Kodepos Pengiriman"
        Me.kdpos_pengiriman.MinimumWidth = 140
        Me.kdpos_pengiriman.Name = "kdpos_pengiriman"
        Me.kdpos_pengiriman.Width = 140
        '
        'tgl_keluar
        '
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.tgl_keluar.DefaultCellStyle = DataGridViewCellStyle35
        Me.tgl_keluar.HeaderText = "Tanggal Keluar"
        Me.tgl_keluar.MinimumWidth = 6
        Me.tgl_keluar.Name = "tgl_keluar"
        Me.tgl_keluar.Width = 125
        '
        'total_barang
        '
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.total_barang.DefaultCellStyle = DataGridViewCellStyle36
        Me.total_barang.HeaderText = "Total Barang"
        Me.total_barang.MinimumWidth = 6
        Me.total_barang.Name = "total_barang"
        Me.total_barang.Width = 125
        '
        'created_by
        '
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.created_by.DefaultCellStyle = DataGridViewCellStyle37
        Me.created_by.HeaderText = "Created By"
        Me.created_by.Name = "created_by"
        '
        'created_date
        '
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.created_date.DefaultCellStyle = DataGridViewCellStyle38
        Me.created_date.HeaderText = "Created Date"
        Me.created_date.Name = "created_date"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "s/d"
        '
        'btn_tampil_list
        '
        Me.btn_tampil_list.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_tampil_list.FlatAppearance.BorderSize = 0
        Me.btn_tampil_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tampil_list.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tampil_list.Location = New System.Drawing.Point(520, 9)
        Me.btn_tampil_list.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tampil_list.Name = "btn_tampil_list"
        Me.btn_tampil_list.Size = New System.Drawing.Size(178, 26)
        Me.btn_tampil_list.TabIndex = 78
        Me.btn_tampil_list.Text = "Tampilkan List"
        Me.btn_tampil_list.UseVisualStyleBackColor = False
        '
        'date_tgl_keluar2
        '
        Me.date_tgl_keluar2.Location = New System.Drawing.Point(324, 12)
        Me.date_tgl_keluar2.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tgl_keluar2.Name = "date_tgl_keluar2"
        Me.date_tgl_keluar2.Size = New System.Drawing.Size(193, 20)
        Me.date_tgl_keluar2.TabIndex = 77
        '
        'date_tgl_keluar1
        '
        Me.date_tgl_keluar1.Location = New System.Drawing.Point(110, 12)
        Me.date_tgl_keluar1.Margin = New System.Windows.Forms.Padding(2)
        Me.date_tgl_keluar1.Name = "date_tgl_keluar1"
        Me.date_tgl_keluar1.Size = New System.Drawing.Size(183, 20)
        Me.date_tgl_keluar1.TabIndex = 76
        '
        'btn_tampil
        '
        Me.btn_tampil.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_tampil.FlatAppearance.BorderSize = 0
        Me.btn_tampil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_tampil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_tampil.Location = New System.Drawing.Point(11, 166)
        Me.btn_tampil.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_tampil.Name = "btn_tampil"
        Me.btn_tampil.Size = New System.Drawing.Size(178, 26)
        Me.btn_tampil.TabIndex = 75
        Me.btn_tampil.Text = "Tampil"
        Me.btn_tampil.UseVisualStyleBackColor = False
        '
        'dt_transaksi
        '
        Me.dt_transaksi.AllowUserToOrderColumns = True
        Me.dt_transaksi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_transaksi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_transaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle39
        Me.dt_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_transaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_transaksi_keluar, Me.harga_total, Me.diskon, Me.harga_akhir, Me.nama_client, Me.alamat_pengiriman, Me.kota_pengiriman, Me.kdpos_pengiriman, Me.tgl_keluar, Me.total_barang, Me.created_by, Me.created_date})
        Me.dt_transaksi.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dt_transaksi.Location = New System.Drawing.Point(1, 43)
        Me.dt_transaksi.Margin = New System.Windows.Forms.Padding(2)
        Me.dt_transaksi.Name = "dt_transaksi"
        Me.dt_transaksi.RowHeadersWidth = 51
        Me.dt_transaksi.RowTemplate.Height = 24
        Me.dt_transaksi.Size = New System.Drawing.Size(974, 119)
        Me.dt_transaksi.TabIndex = 74
        '
        'cetak_kwitansi_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 530)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_tampil_list)
        Me.Controls.Add(Me.date_tgl_keluar2)
        Me.Controls.Add(Me.date_tgl_keluar1)
        Me.Controls.Add(Me.btn_tampil)
        Me.Controls.Add(Me.dt_transaksi)
        Me.Name = "cetak_kwitansi_barang"
        Me.Text = "Cetak Kwitansi"
        CType(Me.dt_transaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
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
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_tampil_list As Button
    Friend WithEvents date_tgl_keluar2 As DateTimePicker
    Friend WithEvents date_tgl_keluar1 As DateTimePicker
    Friend WithEvents btn_tampil As Button
    Friend WithEvents dt_transaksi As DataGridView
End Class
