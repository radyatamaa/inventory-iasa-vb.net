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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterDataToko))
        Me.txt_nama_toko = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logo_toko = New System.Windows.Forms.PictureBox()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.txt_norek_owner = New System.Windows.Forms.TextBox()
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
        Me.logo_toko1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlp_owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.norek_owner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hapus_data_toko = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2.SuspendLayout()
        CType(Me.logo_toko, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_master_toko, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nama_toko
        '
        Me.txt_nama_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_toko.Location = New System.Drawing.Point(110, 150)
        Me.txt_nama_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nama_toko.Name = "txt_nama_toko"
        Me.txt_nama_toko.Size = New System.Drawing.Size(178, 20)
        Me.txt_nama_toko.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Toko"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(739, 249)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(177, 23)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.logo_toko)
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.btn_browse)
        Me.Panel2.Controls.Add(Me.txt_norek_owner)
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
        Me.Panel2.Location = New System.Drawing.Point(2, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 490)
        Me.Panel2.TabIndex = 16
        '
        'logo_toko
        '
        Me.logo_toko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logo_toko.Location = New System.Drawing.Point(934, 152)
        Me.logo_toko.Name = "logo_toko"
        Me.logo_toko.Size = New System.Drawing.Size(170, 124)
        Me.logo_toko.TabIndex = 61
        Me.logo_toko.TabStop = False
        '
        'pict_logo
        '
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1025, 7)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(117, 70)
        Me.pict_logo.TabIndex = 60
        Me.pict_logo.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(398, 7)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(254, 47)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Master Data Toko"
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
        Me.btn_kembali.Size = New System.Drawing.Size(76, 64)
        Me.btn_kembali.TabIndex = 58
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'btn_browse
        '
        Me.btn_browse.Location = New System.Drawing.Point(430, 247)
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(76, 26)
        Me.btn_browse.TabIndex = 36
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'txt_norek_owner
        '
        Me.txt_norek_owner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_norek_owner.Location = New System.Drawing.Point(739, 220)
        Me.txt_norek_owner.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_norek_owner.Name = "txt_norek_owner"
        Me.txt_norek_owner.Size = New System.Drawing.Size(178, 20)
        Me.txt_norek_owner.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(658, 220)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "No Rekening"
        '
        'txt_tlp_owner
        '
        Me.txt_tlp_owner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_tlp_owner.Location = New System.Drawing.Point(739, 182)
        Me.txt_tlp_owner.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tlp_owner.Name = "txt_tlp_owner"
        Me.txt_tlp_owner.Size = New System.Drawing.Size(178, 20)
        Me.txt_tlp_owner.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(658, 182)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Telepon Owner"
        '
        'txt_nama_owner
        '
        Me.txt_nama_owner.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_owner.Location = New System.Drawing.Point(739, 150)
        Me.txt_nama_owner.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nama_owner.Name = "txt_nama_owner"
        Me.txt_nama_owner.Size = New System.Drawing.Size(178, 20)
        Me.txt_nama_owner.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(658, 150)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Nama Owner"
        '
        'txt_logo_toko
        '
        Me.txt_logo_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_logo_toko.Location = New System.Drawing.Point(430, 220)
        Me.txt_logo_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_logo_toko.Name = "txt_logo_toko"
        Me.txt_logo_toko.Size = New System.Drawing.Size(178, 20)
        Me.txt_logo_toko.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 220)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Logo Toko"
        '
        'txt_tlp_toko
        '
        Me.txt_tlp_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_tlp_toko.Location = New System.Drawing.Point(430, 182)
        Me.txt_tlp_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tlp_toko.Name = "txt_tlp_toko"
        Me.txt_tlp_toko.Size = New System.Drawing.Size(178, 20)
        Me.txt_tlp_toko.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 182)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Telepon Toko"
        '
        'txt_kdpos_toko
        '
        Me.txt_kdpos_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos_toko.Location = New System.Drawing.Point(430, 150)
        Me.txt_kdpos_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_kdpos_toko.Name = "txt_kdpos_toko"
        Me.txt_kdpos_toko.Size = New System.Drawing.Size(178, 20)
        Me.txt_kdpos_toko.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Kodepos Toko"
        '
        'txt_kota_toko
        '
        Me.txt_kota_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota_toko.Location = New System.Drawing.Point(110, 220)
        Me.txt_kota_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_kota_toko.Name = "txt_kota_toko"
        Me.txt_kota_toko.Size = New System.Drawing.Size(178, 20)
        Me.txt_kota_toko.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 220)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Kota Toko"
        '
        'txt_alamat_toko
        '
        Me.txt_alamat_toko.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat_toko.Location = New System.Drawing.Point(110, 182)
        Me.txt_alamat_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_alamat_toko.Name = "txt_alamat_toko"
        Me.txt_alamat_toko.Size = New System.Drawing.Size(178, 20)
        Me.txt_alamat_toko.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
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
        Me.data_master_toko.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_toko, Me.alamat_toko, Me.kota_toko, Me.kdpos_toko, Me.tlp_toko, Me.logo_toko1, Me.nama_owner, Me.tlp_owner, Me.norek_owner})
        Me.data_master_toko.Location = New System.Drawing.Point(2, 281)
        Me.data_master_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.data_master_toko.Name = "data_master_toko"
        Me.data_master_toko.RowHeadersWidth = 51
        Me.data_master_toko.RowTemplate.Height = 24
        Me.data_master_toko.Size = New System.Drawing.Size(1127, 206)
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
        'logo_toko1
        '
        Me.logo_toko1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.logo_toko1.HeaderText = "Logo Toko"
        Me.logo_toko1.MinimumWidth = 6
        Me.logo_toko1.Name = "logo_toko1"
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
        'hapus_data_toko
        '
        Me.hapus_data_toko.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.hapus_data_toko.FlatAppearance.BorderSize = 0
        Me.hapus_data_toko.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus_data_toko.Location = New System.Drawing.Point(86, 495)
        Me.hapus_data_toko.Margin = New System.Windows.Forms.Padding(2)
        Me.hapus_data_toko.Name = "hapus_data_toko"
        Me.hapus_data_toko.Size = New System.Drawing.Size(70, 32)
        Me.hapus_data_toko.TabIndex = 47
        Me.hapus_data_toko.Text = "Hapus"
        Me.hapus_data_toko.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(11, 495)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(70, 32)
        Me.Button12.TabIndex = 46
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MasterDataToko
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.hapus_data_toko)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MasterDataToko"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterDataToko"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.logo_toko, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_master_toko, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_nama_toko As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_norek_owner As TextBox
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
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_toko As DataGridViewTextBoxColumn
    Friend WithEvents alamat_toko As DataGridViewTextBoxColumn
    Friend WithEvents kota_toko As DataGridViewTextBoxColumn
    Friend WithEvents kdpos_toko As DataGridViewTextBoxColumn
    Friend WithEvents tlp_toko As DataGridViewTextBoxColumn
    Friend WithEvents logo_toko1 As DataGridViewTextBoxColumn
    Friend WithEvents nama_owner As DataGridViewTextBoxColumn
    Friend WithEvents tlp_owner As DataGridViewTextBoxColumn
    Friend WithEvents norek_owner As DataGridViewTextBoxColumn
    Friend WithEvents hapus_data_toko As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_browse As Button
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents logo_toko As PictureBox
End Class
