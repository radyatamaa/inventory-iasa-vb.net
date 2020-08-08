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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detail_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
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
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button10)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1154, 380)
        Me.Panel2.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ID Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(135, 61)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox2.TabIndex = 20
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(135, 26)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Master Data"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(135, 132)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.id_lokasi, Me.detail_lokasi})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 169)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1154, 206)
        Me.DataGridView1.TabIndex = 16
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
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox3.Location = New System.Drawing.Point(135, 96)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(178, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Detail Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(85, 436)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(70, 32)
        Me.Button12.TabIndex = 38
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(10, 436)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(70, 32)
        Me.Button11.TabIndex = 37
        Me.Button11.Text = "Lihat Data"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(160, 436)
        Me.Button13.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(70, 32)
        Me.Button13.TabIndex = 39
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'BarangMasukToolStripMenuItem
        '
        Me.BarangMasukToolStripMenuItem.Name = "BarangMasukToolStripMenuItem"
        Me.BarangMasukToolStripMenuItem.Size = New System.Drawing.Size(144, 29)
        Me.BarangMasukToolStripMenuItem.Text = "Barang Masuk"
        '
        'BarangKeluarToolStripMenuItem
        '
        Me.BarangKeluarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.RentalToolStripMenuItem, Me.RepairToolStripMenuItem})
        Me.BarangKeluarToolStripMenuItem.Name = "BarangKeluarToolStripMenuItem"
        Me.BarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(143, 29)
        Me.BarangKeluarToolStripMenuItem.Text = "Barang Keluar"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(167, 30)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(167, 30)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'RepairToolStripMenuItem
        '
        Me.RepairToolStripMenuItem.Name = "RepairToolStripMenuItem"
        Me.RepairToolStripMenuItem.Size = New System.Drawing.Size(167, 30)
        Me.RepairToolStripMenuItem.Text = "Repair"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RentalBarangToolStripMenuItem, Me.InstallationServiceToolStripMenuItem, Me.MaintenenceSerivceToolStripMenuItem})
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(109, 29)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'RentalBarangToolStripMenuItem
        '
        Me.RentalBarangToolStripMenuItem.Name = "RentalBarangToolStripMenuItem"
        Me.RentalBarangToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.RentalBarangToolStripMenuItem.Text = "Rental Barang"
        '
        'InstallationServiceToolStripMenuItem
        '
        Me.InstallationServiceToolStripMenuItem.Name = "InstallationServiceToolStripMenuItem"
        Me.InstallationServiceToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.InstallationServiceToolStripMenuItem.Text = "Installation Service"
        '
        'MaintenenceSerivceToolStripMenuItem
        '
        Me.MaintenenceSerivceToolStripMenuItem.Name = "MaintenenceSerivceToolStripMenuItem"
        Me.MaintenenceSerivceToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.MaintenenceSerivceToolStripMenuItem.Text = "Maintenence Serivce"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HasilInputBarangMasukToolStripMenuItem, Me.HasilPenjualanToolStripMenuItem, Me.ListInvoiceKeluarToolStripMenuItem, Me.ListBarangRentalToolStripMenuItem, Me.GaransiToolStripMenuItem, Me.StockBarangToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(79, 29)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HasilInputBarangMasukToolStripMenuItem
        '
        Me.HasilInputBarangMasukToolStripMenuItem.Name = "HasilInputBarangMasukToolStripMenuItem"
        Me.HasilInputBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.HasilInputBarangMasukToolStripMenuItem.Text = "Hasil Input Barang Masuk"
        '
        'HasilPenjualanToolStripMenuItem
        '
        Me.HasilPenjualanToolStripMenuItem.Name = "HasilPenjualanToolStripMenuItem"
        Me.HasilPenjualanToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.HasilPenjualanToolStripMenuItem.Text = "Hasil Penjualan"
        '
        'ListInvoiceKeluarToolStripMenuItem
        '
        Me.ListInvoiceKeluarToolStripMenuItem.Name = "ListInvoiceKeluarToolStripMenuItem"
        Me.ListInvoiceKeluarToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.ListInvoiceKeluarToolStripMenuItem.Text = "List Invoice Keluar"
        '
        'ListBarangRentalToolStripMenuItem
        '
        Me.ListBarangRentalToolStripMenuItem.Name = "ListBarangRentalToolStripMenuItem"
        Me.ListBarangRentalToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.ListBarangRentalToolStripMenuItem.Text = "List Barang Rental"
        '
        'GaransiToolStripMenuItem
        '
        Me.GaransiToolStripMenuItem.Name = "GaransiToolStripMenuItem"
        Me.GaransiToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.GaransiToolStripMenuItem.Text = "Garansi"
        '
        'StockBarangToolStripMenuItem
        '
        Me.StockBarangToolStripMenuItem.Name = "StockBarangToolStripMenuItem"
        Me.StockBarangToolStripMenuItem.Size = New System.Drawing.Size(299, 30)
        Me.StockBarangToolStripMenuItem.Text = "Stock Barang"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.QuotationToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 48)
        Me.MenuStrip1.TabIndex = 40
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDetailLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button13)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MasterDetailLokasi"
        Me.Text = "MasterDetailLokasi"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
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
End Class
