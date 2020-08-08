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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_id_lokasi = New System.Windows.Forms.ComboBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.data_master_detail = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_detail_lokasi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.data_master_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmb_id_lokasi)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_detail)
        Me.Panel2.Controls.Add(Me.txt_detail_lokasi)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1710, 468)
        Me.Panel2.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ID Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmb_id_lokasi
        '
        Me.cmb_id_lokasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_id_lokasi.FormattingEnabled = True
        Me.cmb_id_lokasi.Location = New System.Drawing.Point(170, 34)
        Me.cmb_id_lokasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_id_lokasi.Name = "cmb_id_lokasi"
        Me.cmb_id_lokasi.Size = New System.Drawing.Size(236, 24)
        Me.cmb_id_lokasi.TabIndex = 20
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(170, 121)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
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
        Me.data_master_detail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_lokasi, Me.detail_lokasi})
        Me.data_master_detail.Location = New System.Drawing.Point(3, 212)
        Me.data_master_detail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_detail.Name = "data_master_detail"
        Me.data_master_detail.RowHeadersWidth = 51
        Me.data_master_detail.RowTemplate.Height = 24
        Me.data_master_detail.Size = New System.Drawing.Size(1539, 254)
        Me.data_master_detail.TabIndex = 16
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'id_lokasi
        '
        Me.id_lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.id_lokasi.HeaderText = "ID Lokasi"
        Me.id_lokasi.MinimumWidth = 6
        Me.id_lokasi.Name = "id_lokasi"
        '
        'detail_lokasi
        '
        Me.detail_lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.detail_lokasi.HeaderText = "Detail Lokasi"
        Me.detail_lokasi.MinimumWidth = 6
        Me.detail_lokasi.Name = "detail_lokasi"
        '
        'txt_detail_lokasi
        '
        Me.txt_detail_lokasi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_detail_lokasi.Location = New System.Drawing.Point(170, 77)
        Me.txt_detail_lokasi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_detail_lokasi.Name = "txt_detail_lokasi"
        Me.txt_detail_lokasi.Size = New System.Drawing.Size(236, 22)
        Me.txt_detail_lokasi.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Detail Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(180, 55)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.RentalToolStripMenuItem, Me.RepairToolStripMenuItem})
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(177, 55)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(207, 36)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(207, 36)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'RepairToolStripMenuItem
        '
        Me.RepairToolStripMenuItem.Name = "RepairToolStripMenuItem"
        Me.RepairToolStripMenuItem.Size = New System.Drawing.Size(207, 36)
        Me.RepairToolStripMenuItem.Text = "Repair"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RentalBarangToolStripMenuItem, Me.InstallationServiceToolStripMenuItem, Me.MaintenenceSerivceToolStripMenuItem})
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(137, 55)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'RentalBarangToolStripMenuItem
        '
        Me.RentalBarangToolStripMenuItem.Name = "RentalBarangToolStripMenuItem"
        Me.RentalBarangToolStripMenuItem.Size = New System.Drawing.Size(327, 36)
        Me.RentalBarangToolStripMenuItem.Text = "Rental Barang"
        '
        'InstallationServiceToolStripMenuItem
        '
        Me.InstallationServiceToolStripMenuItem.Name = "InstallationServiceToolStripMenuItem"
        Me.InstallationServiceToolStripMenuItem.Size = New System.Drawing.Size(327, 36)
        Me.InstallationServiceToolStripMenuItem.Text = "Installation Service"
        '
        'MaintenenceSerivceToolStripMenuItem
        '
        Me.MaintenenceSerivceToolStripMenuItem.Name = "MaintenenceSerivceToolStripMenuItem"
        Me.MaintenenceSerivceToolStripMenuItem.Size = New System.Drawing.Size(327, 36)
        Me.MaintenenceSerivceToolStripMenuItem.Text = "Maintenence Serivce"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HasilInputBarangMasukToolStripMenuItem, Me.HasilPenjualanToolStripMenuItem, Me.ListInvoiceKeluarToolStripMenuItem, Me.ListBarangRentalToolStripMenuItem, Me.GaransiToolStripMenuItem, Me.StockBarangToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(99, 55)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HasilInputBarangMasukToolStripMenuItem
        '
        Me.HasilInputBarangMasukToolStripMenuItem.Name = "HasilInputBarangMasukToolStripMenuItem"
        Me.HasilInputBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.HasilInputBarangMasukToolStripMenuItem.Text = "Hasil Input Barang Masuk"
        '
        'HasilPenjualanToolStripMenuItem
        '
        Me.HasilPenjualanToolStripMenuItem.Name = "HasilPenjualanToolStripMenuItem"
        Me.HasilPenjualanToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.HasilPenjualanToolStripMenuItem.Text = "Hasil Penjualan"
        '
        'ListInvoiceKeluarToolStripMenuItem
        '
        Me.ListInvoiceKeluarToolStripMenuItem.Name = "ListInvoiceKeluarToolStripMenuItem"
        Me.ListInvoiceKeluarToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.ListInvoiceKeluarToolStripMenuItem.Text = "List Invoice Keluar"
        '
        'ListBarangRentalToolStripMenuItem
        '
        Me.ListBarangRentalToolStripMenuItem.Name = "ListBarangRentalToolStripMenuItem"
        Me.ListBarangRentalToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.ListBarangRentalToolStripMenuItem.Text = "List Barang Rental"
        '
        'GaransiToolStripMenuItem
        '
        Me.GaransiToolStripMenuItem.Name = "GaransiToolStripMenuItem"
        Me.GaransiToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.GaransiToolStripMenuItem.Text = "Garansi"
        '
        'StockBarangToolStripMenuItem
        '
        Me.StockBarangToolStripMenuItem.Name = "StockBarangToolStripMenuItem"
        Me.StockBarangToolStripMenuItem.Size = New System.Drawing.Size(376, 36)
        Me.StockBarangToolStripMenuItem.Text = "Stock Barang"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.QuotationToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1542, 59)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(113, 535)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(94, 39)
        Me.Button13.TabIndex = 49
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(13, 535)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(94, 39)
        Me.Button12.TabIndex = 48
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'MasterDetailLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 832)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterDetailLokasi"
        Me.Text = "MasterDetailLokasi"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.data_master_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_simpan As Button
    Friend WithEvents data_master_detail As DataGridView
    Friend WithEvents txt_detail_lokasi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_id_lokasi As ComboBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents id_lokasi As DataGridViewTextBoxColumn
    Friend WithEvents detail_lokasi As DataGridViewTextBoxColumn
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
End Class
