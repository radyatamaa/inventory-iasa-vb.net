<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarangKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarangKeluar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.date_tgl_keluar = New System.Windows.Forms.DateTimePicker()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.data_barang_penjualan = New System.Windows.Forms.DataGridView()
        Me.judul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.garansi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_keluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_tipe = New System.Windows.Forms.ComboBox()
        Me.cmb_jenis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_client = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.cmb_garansi = New System.Windows.Forms.ComboBox()
        Me.txt_judul = New System.Windows.Forms.TextBox()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.btn_lihat = New System.Windows.Forms.Button()
        CType(Me.data_barang_penjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 130)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Judul "
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(416, 132)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Tanggal Keluar"
        '
        'date_tgl_keluar
        '
        Me.date_tgl_keluar.Location = New System.Drawing.Point(499, 132)
        Me.date_tgl_keluar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.date_tgl_keluar.Name = "date_tgl_keluar"
        Me.date_tgl_keluar.Size = New System.Drawing.Size(178, 20)
        Me.date_tgl_keluar.TabIndex = 22
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(466, 183)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(178, 26)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'data_barang_penjualan
        '
        Me.data_barang_penjualan.AllowUserToOrderColumns = True
        Me.data_barang_penjualan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_barang_penjualan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_barang_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_barang_penjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.judul, Me.jenis_barang, Me.tipe_barang, Me.garansi, Me.client, Me.tgl_keluar})
        Me.data_barang_penjualan.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.data_barang_penjualan.Location = New System.Drawing.Point(0, 280)
        Me.data_barang_penjualan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.data_barang_penjualan.Name = "data_barang_penjualan"
        Me.data_barang_penjualan.RowHeadersWidth = 51
        Me.data_barang_penjualan.RowTemplate.Height = 24
        Me.data_barang_penjualan.Size = New System.Drawing.Size(1154, 206)
        Me.data_barang_penjualan.TabIndex = 16
        '
        'judul
        '
        Me.judul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.judul.HeaderText = "Judul"
        Me.judul.MinimumWidth = 6
        Me.judul.Name = "judul"
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
        Me.tipe_barang.HeaderText = "Tipe Barang"
        Me.tipe_barang.MinimumWidth = 6
        Me.tipe_barang.Name = "tipe_barang"
        '
        'garansi
        '
        Me.garansi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.garansi.HeaderText = "Garansi"
        Me.garansi.MinimumWidth = 6
        Me.garansi.Name = "garansi"
        '
        'client
        '
        Me.client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.client.HeaderText = "Client"
        Me.client.MinimumWidth = 6
        Me.client.Name = "client"
        '
        'tgl_keluar
        '
        Me.tgl_keluar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tgl_keluar.HeaderText = "Tanggal Keluar"
        Me.tgl_keluar.MinimumWidth = 6
        Me.tgl_keluar.Name = "tgl_keluar"
        '
        'cmb_tipe
        '
        Me.cmb_tipe.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_tipe.FormattingEnabled = True
        Me.cmb_tipe.Location = New System.Drawing.Point(217, 189)
        Me.cmb_tipe.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_tipe.Name = "cmb_tipe"
        Me.cmb_tipe.Size = New System.Drawing.Size(178, 21)
        Me.cmb_tipe.TabIndex = 10
        '
        'cmb_jenis
        '
        Me.cmb_jenis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_jenis.FormattingEnabled = True
        Me.cmb_jenis.Location = New System.Drawing.Point(217, 162)
        Me.cmb_jenis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_jenis.Name = "cmb_jenis"
        Me.cmb_jenis.Size = New System.Drawing.Size(178, 21)
        Me.cmb_jenis.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 248)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Client"
        '
        'cmb_client
        '
        Me.cmb_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_client.FormattingEnabled = True
        Me.cmb_client.Location = New System.Drawing.Point(217, 242)
        Me.cmb_client.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_client.Name = "cmb_client"
        Me.cmb_client.Size = New System.Drawing.Size(178, 21)
        Me.cmb_client.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 218)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Garansi"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 192)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tipe Barang"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(95, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Barang"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.cmb_garansi)
        Me.Panel2.Controls.Add(Me.txt_judul)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.date_tgl_keluar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_barang_penjualan)
        Me.Panel2.Controls.Add(Me.cmb_client)
        Me.Panel2.Controls.Add(Me.cmb_tipe)
        Me.Panel2.Controls.Add(Me.cmb_jenis)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1154, 488)
        Me.Panel2.TabIndex = 6
        '
        'pict_logo
        '
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1029, 7)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(117, 70)
        Me.pict_logo.TabIndex = 48
        Me.pict_logo.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Condensed", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(460, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(254, 47)
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
        Me.btn_kembali.Location = New System.Drawing.Point(8, 7)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(76, 61)
        Me.btn_kembali.TabIndex = 46
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'cmb_garansi
        '
        Me.cmb_garansi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_garansi.FormattingEnabled = True
        Me.cmb_garansi.Location = New System.Drawing.Point(217, 218)
        Me.cmb_garansi.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmb_garansi.Name = "cmb_garansi"
        Me.cmb_garansi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_garansi.TabIndex = 27
        '
        'txt_judul
        '
        Me.txt_judul.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_judul.Location = New System.Drawing.Point(217, 132)
        Me.txt_judul.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_judul.Name = "txt_judul"
        Me.txt_judul.Size = New System.Drawing.Size(178, 20)
        Me.txt_judul.TabIndex = 26
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(159, 492)
        Me.btn_hapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(70, 32)
        Me.btn_hapus.TabIndex = 45
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_ubah
        '
        Me.btn_ubah.Location = New System.Drawing.Point(84, 492)
        Me.btn_ubah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(70, 32)
        Me.btn_ubah.TabIndex = 44
        Me.btn_ubah.Text = "Edit"
        Me.btn_ubah.UseVisualStyleBackColor = True
        '
        'btn_lihat
        '
        Me.btn_lihat.Location = New System.Drawing.Point(9, 492)
        Me.btn_lihat.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_lihat.Name = "btn_lihat"
        Me.btn_lihat.Size = New System.Drawing.Size(70, 32)
        Me.btn_lihat.TabIndex = 43
        Me.btn_lihat.Text = "Lihat Data"
        Me.btn_lihat.UseVisualStyleBackColor = True
        '
        'BarangKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_ubah)
        Me.Controls.Add(Me.btn_lihat)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BarangKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data_barang_penjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents date_tgl_keluar As DateTimePicker
    Friend WithEvents btn_simpan As Button
    Friend WithEvents data_barang_penjualan As DataGridView
    Friend WithEvents cmb_tipe As ComboBox
    Friend WithEvents cmb_jenis As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_client As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmb_garansi As ComboBox
    Friend WithEvents txt_judul As TextBox
    Friend WithEvents judul As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents garansi As DataGridViewTextBoxColumn
    Friend WithEvents client As DataGridViewTextBoxColumn
    Friend WithEvents tgl_keluar As DataGridViewTextBoxColumn
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_ubah As Button
    Friend WithEvents btn_lihat As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label6 As Label
End Class
