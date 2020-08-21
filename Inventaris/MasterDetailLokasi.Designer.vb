<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterDetailLokasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterDetailLokasi))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_id_lokasi = New System.Windows.Forms.ComboBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.data_master_detail = New System.Windows.Forms.DataGridView()
        Me.txt_detail_lokasi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hapus_data_detail_lokasi = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_master_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmb_id_lokasi)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_detail)
        Me.Panel2.Controls.Add(Me.txt_detail_lokasi)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1282, 479)
        Me.Panel2.TabIndex = 36
        '
        'pict_logo
        '
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1032, 13)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(117, 70)
        Me.pict_logo.TabIndex = 60
        Me.pict_logo.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(405, 13)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(294, 47)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Master Detail Lokasi"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(9, 13)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(76, 69)
        Me.btn_kembali.TabIndex = 58
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ID Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmb_id_lokasi
        '
        Me.cmb_id_lokasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_id_lokasi.FormattingEnabled = True
        Me.cmb_id_lokasi.Location = New System.Drawing.Point(128, 139)
        Me.cmb_id_lokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_id_lokasi.Name = "cmb_id_lokasi"
        Me.cmb_id_lokasi.Size = New System.Drawing.Size(178, 21)
        Me.cmb_id_lokasi.TabIndex = 20
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(128, 204)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(177, 23)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'data_master_detail
        '
        Me.data_master_detail.AllowUserToOrderColumns = True
        Me.data_master_detail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_detail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_detail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_lokasi, Me.detail_lokasi})
        Me.data_master_detail.Location = New System.Drawing.Point(0, 237)
        Me.data_master_detail.Margin = New System.Windows.Forms.Padding(2)
        Me.data_master_detail.Name = "data_master_detail"
        Me.data_master_detail.RowHeadersWidth = 51
        Me.data_master_detail.RowTemplate.Height = 24
        Me.data_master_detail.Size = New System.Drawing.Size(1025, 193)
        Me.data_master_detail.TabIndex = 16
        '
        'txt_detail_lokasi
        '
        Me.txt_detail_lokasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_detail_lokasi.Location = New System.Drawing.Point(128, 174)
        Me.txt_detail_lokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_detail_lokasi.Name = "txt_detail_lokasi"
        Me.txt_detail_lokasi.Size = New System.Drawing.Size(178, 20)
        Me.txt_detail_lokasi.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Detail Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'hapus_data_detail_lokasi
        '
        Me.hapus_data_detail_lokasi.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.hapus_data_detail_lokasi.FlatAppearance.BorderSize = 0
        Me.hapus_data_detail_lokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hapus_data_detail_lokasi.Location = New System.Drawing.Point(87, 498)
        Me.hapus_data_detail_lokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.hapus_data_detail_lokasi.Name = "hapus_data_detail_lokasi"
        Me.hapus_data_detail_lokasi.Size = New System.Drawing.Size(70, 32)
        Me.hapus_data_detail_lokasi.TabIndex = 49
        Me.hapus_data_detail_lokasi.Text = "Hapus"
        Me.hapus_data_detail_lokasi.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(12, 498)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(70, 32)
        Me.Button12.TabIndex = 48
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'nama_lokasi
        '
        Me.nama_lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_lokasi.HeaderText = "Nama Lokasi"
        Me.nama_lokasi.MinimumWidth = 6
        Me.nama_lokasi.Name = "nama_lokasi"
        '
        'detail_lokasi
        '
        Me.detail_lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.detail_lokasi.HeaderText = "Detail Lokasi"
        Me.detail_lokasi.MinimumWidth = 6
        Me.detail_lokasi.Name = "detail_lokasi"
        '
        'MasterDetailLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.hapus_data_detail_lokasi)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MasterDetailLokasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterDetailLokasi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_master_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_simpan As Button
    Friend WithEvents data_master_detail As DataGridView
    Friend WithEvents txt_detail_lokasi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_id_lokasi As ComboBox
    Friend WithEvents hapus_data_detail_lokasi As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_lokasi As DataGridViewTextBoxColumn
    Friend WithEvents detail_lokasi As DataGridViewTextBoxColumn
End Class
