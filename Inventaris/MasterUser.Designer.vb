<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterUser))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_nama_lengkap = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.data_master_user = New System.Windows.Forms.DataGridView()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_lengkap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmb_id_level = New System.Windows.Forms.ComboBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.data_master_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.txt_username)
        Me.Panel2.Controls.Add(Me.txt_nama_lengkap)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_user)
        Me.Panel2.Controls.Add(Me.cmb_id_level)
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1710, 626)
        Me.Panel2.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(616, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(444, 58)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Master Tipe Barang"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(57, 8)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(101, 80)
        Me.btn_kembali.TabIndex = 54
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'txt_username
        '
        Me.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_username.Location = New System.Drawing.Point(166, 173)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(236, 22)
        Me.txt_username.TabIndex = 21
        '
        'txt_nama_lengkap
        '
        Me.txt_nama_lengkap.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_lengkap.Location = New System.Drawing.Point(166, 208)
        Me.txt_nama_lengkap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nama_lengkap.Name = "txt_nama_lengkap"
        Me.txt_nama_lengkap.Size = New System.Drawing.Size(236, 22)
        Me.txt_nama_lengkap.TabIndex = 20
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(166, 314)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'data_master_user
        '
        Me.data_master_user.AllowUserToOrderColumns = True
        Me.data_master_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_user.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_user.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_user, Me.username, Me.nama_lengkap, Me.password, Me.id_level})
        Me.data_master_user.Location = New System.Drawing.Point(3, 368)
        Me.data_master_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_user.Name = "data_master_user"
        Me.data_master_user.RowHeadersWidth = 51
        Me.data_master_user.RowTemplate.Height = 24
        Me.data_master_user.Size = New System.Drawing.Size(1536, 254)
        Me.data_master_user.TabIndex = 16
        '
        'id_user
        '
        Me.id_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_user.HeaderText = "ID User"
        Me.id_user.MinimumWidth = 6
        Me.id_user.Name = "id_user"
        '
        'username
        '
        Me.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.username.HeaderText = "Username"
        Me.username.MinimumWidth = 6
        Me.username.Name = "username"
        '
        'nama_lengkap
        '
        Me.nama_lengkap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_lengkap.HeaderText = "Nama Lengkap"
        Me.nama_lengkap.MinimumWidth = 6
        Me.nama_lengkap.Name = "nama_lengkap"
        '
        'password
        '
        Me.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.password.HeaderText = "Password"
        Me.password.MinimumWidth = 6
        Me.password.Name = "password"
        '
        'id_level
        '
        Me.id_level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_level.HeaderText = "ID Level"
        Me.id_level.MinimumWidth = 6
        Me.id_level.Name = "id_level"
        '
        'cmb_id_level
        '
        Me.cmb_id_level.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_id_level.FormattingEnabled = True
        Me.cmb_id_level.Location = New System.Drawing.Point(166, 271)
        Me.cmb_id_level.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_id_level.Name = "cmb_id_level"
        Me.cmb_id_level.Size = New System.Drawing.Size(236, 24)
        Me.cmb_id_level.TabIndex = 11
        '
        'txt_password
        '
        Me.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_password.Location = New System.Drawing.Point(166, 240)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(236, 22)
        Me.txt_password.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ID Level"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'btn_hapus
        '
        Me.btn_hapus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_hapus.FlatAppearance.BorderSize = 0
        Me.btn_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_hapus.Location = New System.Drawing.Point(31, 632)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(94, 39)
        Me.btn_hapus.TabIndex = 57
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = False
        '
        'MasterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 832)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterUser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.data_master_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_simpan As Button
    Friend WithEvents data_master_user As DataGridView
    Friend WithEvents cmb_id_level As ComboBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_nama_lengkap As TextBox
    Friend WithEvents id_user As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents nama_lengkap As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents id_level As DataGridViewTextBoxColumn
    Friend WithEvents btn_hapus As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_kembali As Button
End Class
