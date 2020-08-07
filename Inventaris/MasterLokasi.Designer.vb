<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterLokasi
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
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_lokasi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button10.Location = New System.Drawing.Point(135, 133)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(177, 23)
        Me.Button10.TabIndex = 17
        Me.Button10.Text = "Simpan"
        Me.Button10.UseVisualStyleBackColor = False
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_lokasi})
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
        'nama_lokasi
        '
        Me.nama_lokasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_lokasi.HeaderText = "Nama Lokasi"
        Me.nama_lokasi.MinimumWidth = 6
        Me.nama_lokasi.Name = "nama_lokasi"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox3.Location = New System.Drawing.Point(135, 76)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(178, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(85, 436)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(70, 32)
        Me.Button12.TabIndex = 33
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(10, 436)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(70, 32)
        Me.Button11.TabIndex = 32
        Me.Button11.Text = "Lihat Data"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(160, 436)
        Me.Button13.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(70, 32)
        Me.Button13.TabIndex = 34
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label2)
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
        Me.Panel2.TabIndex = 31
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Location = New System.Drawing.Point(135, 100)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Alamat Lokasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarangMasukToolStripMenuItem, Me.BarangKeluarToolStripMenuItem, Me.QuotationToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 35
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
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'RepairToolStripMenuItem
        '
        Me.RepairToolStripMenuItem.Name = "RepairToolStripMenuItem"
        Me.RepairToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
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
        'MasterLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MasterLokasi"
        Me.Text = "MasterLokasi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button10 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_lokasi As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
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
