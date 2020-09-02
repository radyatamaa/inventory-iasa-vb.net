<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterClient))
        Me.txt_kota_client = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_kdpos_client = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_alamat_client = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nama_client = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_kd_client = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_company_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tlp_client = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.data_master_client = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kota_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdpos_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlp_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.data_master_client, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_kota_client
        '
        Me.txt_kota_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kota_client.Location = New System.Drawing.Point(538, 90)
        Me.txt_kota_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kota_client.Name = "txt_kota_client"
        Me.txt_kota_client.Size = New System.Drawing.Size(236, 22)
        Me.txt_kota_client.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(411, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Kota Client"
        '
        'txt_kdpos_client
        '
        Me.txt_kdpos_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kdpos_client.Location = New System.Drawing.Point(538, 128)
        Me.txt_kdpos_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kdpos_client.Name = "txt_kdpos_client"
        Me.txt_kdpos_client.Size = New System.Drawing.Size(236, 22)
        Me.txt_kdpos_client.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(402, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Kodepos Client"
        '
        'txt_alamat_client
        '
        Me.txt_alamat_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_alamat_client.Location = New System.Drawing.Point(538, 46)
        Me.txt_alamat_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_alamat_client.Name = "txt_alamat_client"
        Me.txt_alamat_client.Size = New System.Drawing.Size(236, 22)
        Me.txt_alamat_client.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Alamat Client"
        '
        'txt_nama_client
        '
        Me.txt_nama_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_client.Location = New System.Drawing.Point(158, 90)
        Me.txt_nama_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nama_client.Name = "txt_nama_client"
        Me.txt_nama_client.Size = New System.Drawing.Size(236, 22)
        Me.txt_nama_client.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nama Client"
        '
        'txt_kd_client
        '
        Me.txt_kd_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_kd_client.Location = New System.Drawing.Point(158, 46)
        Me.txt_kd_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_kd_client.Name = "txt_kd_client"
        Me.txt_kd_client.Size = New System.Drawing.Size(236, 22)
        Me.txt_kd_client.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Kode Client"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(158, 174)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
        Me.btn_simpan.TabIndex = 8
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.txt_company_name)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_tlp_client)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txt_kota_client)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_kdpos_client)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_alamat_client)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_nama_client)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_client)
        Me.Panel2.Controls.Add(Me.txt_kd_client)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 97)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1367, 561)
        Me.Panel2.TabIndex = 21
        '
        'txt_company_name
        '
        Me.txt_company_name.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_company_name.Location = New System.Drawing.Point(158, 128)
        Me.txt_company_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_company_name.Name = "txt_company_name"
        Me.txt_company_name.Size = New System.Drawing.Size(236, 22)
        Me.txt_company_name.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nama Perusahaan"
        '
        'txt_tlp_client
        '
        Me.txt_tlp_client.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_tlp_client.Location = New System.Drawing.Point(942, 46)
        Me.txt_tlp_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_tlp_client.Name = "txt_tlp_client"
        Me.txt_tlp_client.Size = New System.Drawing.Size(236, 22)
        Me.txt_tlp_client.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(806, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Telepon Client"
        '
        'data_master_client
        '
        Me.data_master_client.AllowUserToOrderColumns = True
        Me.data_master_client.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_client.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_client.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.kd_client, Me.nama_client, Me.company_name, Me.alamat_client, Me.kota_client, Me.kdpos_client, Me.tlp_client})
        Me.data_master_client.Location = New System.Drawing.Point(-2, 224)
        Me.data_master_client.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_client.Name = "data_master_client"
        Me.data_master_client.RowHeadersWidth = 51
        Me.data_master_client.RowTemplate.Height = 24
        Me.data_master_client.Size = New System.Drawing.Size(1366, 335)
        Me.data_master_client.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(503, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(381, 58)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Master Data Client"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_kembali.Size = New System.Drawing.Size(101, 69)
        Me.btn_kembali.TabIndex = 11
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(12, 662)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(93, 39)
        Me.Button13.TabIndex = 10
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.pict_logo)
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 97)
        Me.Panel1.TabIndex = 58
        '
        'pict_logo
        '
        Me.pict_logo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1213, 7)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(155, 86)
        Me.pict_logo.TabIndex = 51
        Me.pict_logo.TabStop = False
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'kd_client
        '
        Me.kd_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kd_client.HeaderText = "Kode Client"
        Me.kd_client.MinimumWidth = 6
        Me.kd_client.Name = "kd_client"
        '
        'nama_client
        '
        Me.nama_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_client.HeaderText = "Nama Client"
        Me.nama_client.MinimumWidth = 6
        Me.nama_client.Name = "nama_client"
        '
        'company_name
        '
        Me.company_name.HeaderText = "Nama Perusahaan"
        Me.company_name.MinimumWidth = 6
        Me.company_name.Name = "company_name"
        Me.company_name.Width = 125
        '
        'alamat_client
        '
        Me.alamat_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.alamat_client.HeaderText = "Alamat Client"
        Me.alamat_client.MinimumWidth = 6
        Me.alamat_client.Name = "alamat_client"
        '
        'kota_client
        '
        Me.kota_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kota_client.HeaderText = "Kota Client"
        Me.kota_client.MinimumWidth = 6
        Me.kota_client.Name = "kota_client"
        '
        'kdpos_client
        '
        Me.kdpos_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kdpos_client.HeaderText = "Kode Pos Client"
        Me.kdpos_client.MinimumWidth = 6
        Me.kdpos_client.Name = "kdpos_client"
        '
        'tlp_client
        '
        Me.tlp_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tlp_client.HeaderText = "Telepon Client"
        Me.tlp_client.MinimumWidth = 6
        Me.tlp_client.Name = "tlp_client"
        '
        'MasterClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterClient"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.data_master_client, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_kota_client As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_kdpos_client As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_alamat_client As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nama_client As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_kd_client As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents data_master_client As DataGridView
    Friend WithEvents txt_tlp_client As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents txt_company_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents kd_client As DataGridViewTextBoxColumn
    Friend WithEvents nama_client As DataGridViewTextBoxColumn
    Friend WithEvents company_name As DataGridViewTextBoxColumn
    Friend WithEvents alamat_client As DataGridViewTextBoxColumn
    Friend WithEvents kota_client As DataGridViewTextBoxColumn
    Friend WithEvents kdpos_client As DataGridViewTextBoxColumn
    Friend WithEvents tlp_client As DataGridViewTextBoxColumn
End Class
