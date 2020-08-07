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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipe_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drop1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.dropbutton1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallationServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenenceSerivceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasilInputBarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HasilPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListInvoiceKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBarangRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GaransiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drop1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 23)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(160, 436)
        Me.Button13.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(70, 32)
        Me.Button13.TabIndex = 9
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(85, 436)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(70, 32)
        Me.Button12.TabIndex = 8
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(10, 436)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(70, 32)
        Me.Button11.TabIndex = 7
        Me.Button11.Text = "Lihat Data"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Master User"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.drop1)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.ComboBox4)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1154, 380)
        Me.Panel2.TabIndex = 6
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(328, 23)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(177, 23)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "Simpan"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_user, Me.tipe_barang, Me.serial_number, Me.kondisi, Me.tested})
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 172)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1024, 206)
        Me.DataGridView1.TabIndex = 16
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(135, 135)
        Me.ComboBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox4.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox3.Location = New System.Drawing.Point(135, 110)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(178, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 141)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ID Level"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(135, 84)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox2.Location = New System.Drawing.Point(135, 55)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 21
        '
        'id_user
        '
        Me.id_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_user.HeaderText = "ID User"
        Me.id_user.MinimumWidth = 6
        Me.id_user.Name = "id_user"
        '
        'tipe_barang
        '
        Me.tipe_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipe_barang.HeaderText = "Username"
        Me.tipe_barang.MinimumWidth = 6
        Me.tipe_barang.Name = "tipe_barang"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Nama Lengkap"
        Me.serial_number.MinimumWidth = 6
        Me.serial_number.Name = "serial_number"
        '
        'kondisi
        '
        Me.kondisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kondisi.HeaderText = "Password"
        Me.kondisi.MinimumWidth = 6
        Me.kondisi.Name = "kondisi"
        '
        'tested
        '
        Me.tested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tested.HeaderText = "ID Level"
        Me.tested.MinimumWidth = 6
        Me.tested.Name = "tested"
        '
        'drop1
        '
        Me.drop1.Controls.Add(Me.Button1)
        Me.drop1.Controls.Add(Me.Button16)
        Me.drop1.Controls.Add(Me.dropbutton1)
        Me.drop1.Location = New System.Drawing.Point(620, 8)
        Me.drop1.Margin = New System.Windows.Forms.Padding(2)
        Me.drop1.Name = "drop1"
        Me.drop1.Size = New System.Drawing.Size(172, 150)
        Me.drop1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 99)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ubah Profil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(2, 50)
        Me.Button16.Margin = New System.Windows.Forms.Padding(2)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(103, 50)
        Me.Button16.TabIndex = 1
        Me.Button16.Text = "Data User"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'dropbutton1
        '
        Me.dropbutton1.BackColor = System.Drawing.Color.Transparent
        Me.dropbutton1.Image = Global.Inventaris.My.Resources.Resources.icons8_chevron_left_26
        Me.dropbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dropbutton1.Location = New System.Drawing.Point(2, 2)
        Me.dropbutton1.Margin = New System.Windows.Forms.Padding(2)
        Me.dropbutton1.Name = "dropbutton1"
        Me.dropbutton1.Size = New System.Drawing.Size(103, 50)
        Me.dropbutton1.TabIndex = 0
        Me.dropbutton1.Text = "Master User"
        Me.dropbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dropbutton1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.QuotationToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.RentalToolStripMenuItem, Me.RepairToolStripMenuItem})
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'RepairToolStripMenuItem
        '
        Me.RepairToolStripMenuItem.Name = "RepairToolStripMenuItem"
        Me.RepairToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RepairToolStripMenuItem.Text = "Repair"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RentalBarangToolStripMenuItem, Me.InstallationServiceToolStripMenuItem, Me.MaintenenceSerivceToolStripMenuItem})
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'RentalBarangToolStripMenuItem
        '
        Me.RentalBarangToolStripMenuItem.Name = "RentalBarangToolStripMenuItem"
        Me.RentalBarangToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RentalBarangToolStripMenuItem.Text = "Rental Barang"
        '
        'InstallationServiceToolStripMenuItem
        '
        Me.InstallationServiceToolStripMenuItem.Name = "InstallationServiceToolStripMenuItem"
        Me.InstallationServiceToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.InstallationServiceToolStripMenuItem.Text = "Installation Service"
        '
        'MaintenenceSerivceToolStripMenuItem
        '
        Me.MaintenenceSerivceToolStripMenuItem.Name = "MaintenenceSerivceToolStripMenuItem"
        Me.MaintenenceSerivceToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.MaintenenceSerivceToolStripMenuItem.Text = "Maintenence Serivce"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HasilInputBarangMasukToolStripMenuItem, Me.HasilPenjualanToolStripMenuItem, Me.ListInvoiceKeluarToolStripMenuItem, Me.ListBarangRentalToolStripMenuItem, Me.GaransiToolStripMenuItem, Me.StockBarangToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HasilInputBarangMasukToolStripMenuItem
        '
        Me.HasilInputBarangMasukToolStripMenuItem.Name = "HasilInputBarangMasukToolStripMenuItem"
        Me.HasilInputBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.HasilInputBarangMasukToolStripMenuItem.Text = "Hasil Input Barang Masuk"
        '
        'HasilPenjualanToolStripMenuItem
        '
        Me.HasilPenjualanToolStripMenuItem.Name = "HasilPenjualanToolStripMenuItem"
        Me.HasilPenjualanToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.HasilPenjualanToolStripMenuItem.Text = "Hasil Penjualan"
        '
        'ListInvoiceKeluarToolStripMenuItem
        '
        Me.ListInvoiceKeluarToolStripMenuItem.Name = "ListInvoiceKeluarToolStripMenuItem"
        Me.ListInvoiceKeluarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ListInvoiceKeluarToolStripMenuItem.Text = "List Invoice Keluar"
        '
        'ListBarangRentalToolStripMenuItem
        '
        Me.ListBarangRentalToolStripMenuItem.Name = "ListBarangRentalToolStripMenuItem"
        Me.ListBarangRentalToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ListBarangRentalToolStripMenuItem.Text = "List Barang Rental"
        '
        'GaransiToolStripMenuItem
        '
        Me.GaransiToolStripMenuItem.Name = "GaransiToolStripMenuItem"
        Me.GaransiToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.GaransiToolStripMenuItem.Text = "Garansi"
        '
        'StockBarangToolStripMenuItem
        '
        Me.StockBarangToolStripMenuItem.Name = "StockBarangToolStripMenuItem"
        Me.StockBarangToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StockBarangToolStripMenuItem.Text = "Stock Barang"
        '
        'MasterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MasterUser"
        Me.Text = "MasterUser"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drop1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents id_user As DataGridViewTextBoxColumn
    Friend WithEvents tipe_barang As DataGridViewTextBoxColumn
    Friend WithEvents serial_number As DataGridViewTextBoxColumn
    Friend WithEvents kondisi As DataGridViewTextBoxColumn
    Friend WithEvents tested As DataGridViewTextBoxColumn
    Friend WithEvents drop1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents dropbutton1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuotationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RentalBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallationServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenenceSerivceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasilInputBarangMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HasilPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListInvoiceKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBarangRentalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GaransiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockBarangToolStripMenuItem As ToolStripMenuItem
End Class
