<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterJenisMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterJenisMaintenance))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.data_master_jenis = New System.Windows.Forms.DataGridView()
        Me.id_jenis_maintenance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_jenis_maintenance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_jenis_maintenance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_jenis_maintenance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.data_master_jenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.pict_logo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 97)
        Me.Panel1.TabIndex = 51
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
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Condensed", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(576, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(388, 58)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "JENIS MAINTENANCE"
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
        Me.btn_kembali.Size = New System.Drawing.Size(79, 75)
        Me.btn_kembali.TabIndex = 5
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_harga)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_jenis)
        Me.Panel2.Controls.Add(Me.txt_jenis_maintenance)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(-83, 97)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1451, 576)
        Me.Panel2.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Harga Default Maintenance"
        '
        'txt_harga
        '
        Me.txt_harga.Location = New System.Drawing.Point(276, 117)
        Me.txt_harga.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(236, 22)
        Me.txt_harga.TabIndex = 4
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(276, 153)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
        Me.btn_simpan.TabIndex = 2
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'data_master_jenis
        '
        Me.data_master_jenis.AllowUserToOrderColumns = True
        Me.data_master_jenis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_jenis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_jenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_jenis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_jenis_maintenance, Me.nama_jenis_maintenance, Me.harga_jenis_maintenance})
        Me.data_master_jenis.Location = New System.Drawing.Point(83, 230)
        Me.data_master_jenis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_jenis.Name = "data_master_jenis"
        Me.data_master_jenis.RowHeadersWidth = 51
        Me.data_master_jenis.RowTemplate.Height = 24
        Me.data_master_jenis.Size = New System.Drawing.Size(1365, 311)
        Me.data_master_jenis.TabIndex = 3
        '
        'id_jenis_maintenance
        '
        Me.id_jenis_maintenance.HeaderText = "ID"
        Me.id_jenis_maintenance.MinimumWidth = 6
        Me.id_jenis_maintenance.Name = "id_jenis_maintenance"
        Me.id_jenis_maintenance.Width = 125
        '
        'nama_jenis_maintenance
        '
        Me.nama_jenis_maintenance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_jenis_maintenance.HeaderText = "Nama Jenis Maintenance"
        Me.nama_jenis_maintenance.MinimumWidth = 6
        Me.nama_jenis_maintenance.Name = "nama_jenis_maintenance"
        '
        'harga_jenis_maintenance
        '
        Me.harga_jenis_maintenance.HeaderText = "Harga Jenis Maintenance"
        Me.harga_jenis_maintenance.MinimumWidth = 200
        Me.harga_jenis_maintenance.Name = "harga_jenis_maintenance"
        Me.harga_jenis_maintenance.Width = 200
        '
        'txt_jenis_maintenance
        '
        Me.txt_jenis_maintenance.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_jenis_maintenance.Location = New System.Drawing.Point(276, 81)
        Me.txt_jenis_maintenance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_jenis_maintenance.Name = "txt_jenis_maintenance"
        Me.txt_jenis_maintenance.Size = New System.Drawing.Size(236, 22)
        Me.txt_jenis_maintenance.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Jenis Maintenance"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(0, 677)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(93, 36)
        Me.Button13.TabIndex = 49
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'MasterJenisMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button13)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MasterJenisMaintenance"
        Me.Text = "MasterJenisMaintenance"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.data_master_jenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_simpan As Button
    Friend WithEvents data_master_jenis As DataGridView
    Friend WithEvents txt_jenis_maintenance As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents id_jenis_maintenance As DataGridViewTextBoxColumn
    Friend WithEvents nama_jenis_maintenance As DataGridViewTextBoxColumn
    Friend WithEvents harga_jenis_maintenance As DataGridViewTextBoxColumn
End Class
