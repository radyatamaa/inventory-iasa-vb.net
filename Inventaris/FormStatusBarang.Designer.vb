<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatusBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStatusBarang))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.date_tgl_keluar = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btncari2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.dt_status = New System.Windows.Forms.DataGridView()
        Me.device = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.device_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tested = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.condition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dt_status)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 583)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox2)
        Me.Panel3.Controls.Add(Me.date_tgl_keluar)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.btncari2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 97)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1028, 166)
        Me.Panel3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Device", "Device Type", "Serial Number", "Tested", "Condition", "Location"})
        Me.ComboBox2.Location = New System.Drawing.Point(393, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(105, 21)
        Me.ComboBox2.TabIndex = 106
        '
        'date_tgl_keluar
        '
        Me.date_tgl_keluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.date_tgl_keluar.Location = New System.Drawing.Point(502, 19)
        Me.date_tgl_keluar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.date_tgl_keluar.Name = "date_tgl_keluar"
        Me.date_tgl_keluar.Size = New System.Drawing.Size(98, 20)
        Me.date_tgl_keluar.TabIndex = 100
        Me.date_tgl_keluar.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(382, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Tanggal Pengembalian"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Device", "Device Type", "Serial Number", "Tested", "Condition", "Location"})
        Me.ComboBox1.Location = New System.Drawing.Point(393, 61)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 21)
        Me.ComboBox1.TabIndex = 105
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(502, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 102
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(502, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 103
        '
        'btncari2
        '
        Me.btncari2.Location = New System.Drawing.Point(680, 88)
        Me.btncari2.Name = "btncari2"
        Me.btncari2.Size = New System.Drawing.Size(39, 20)
        Me.btncari2.TabIndex = 104
        Me.btncari2.Text = "Cari"
        Me.btncari2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 97)
        Me.Panel2.TabIndex = 1
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(9, 9)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(75, 67)
        Me.btn_kembali.TabIndex = 49
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 47)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Form Status Barang"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pict_logo
        '
        Me.pict_logo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(876, 9)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(135, 70)
        Me.pict_logo.TabIndex = 51
        Me.pict_logo.TabStop = False
        Me.pict_logo.Visible = False
        '
        'dt_status
        '
        Me.dt_status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_status.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.device, Me.device_type, Me.serial_number, Me.tested, Me.ios, Me.condition, Me.location})
        Me.dt_status.Location = New System.Drawing.Point(0, 267)
        Me.dt_status.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dt_status.Name = "dt_status"
        Me.dt_status.RowHeadersWidth = 51
        Me.dt_status.RowTemplate.Height = 24
        Me.dt_status.Size = New System.Drawing.Size(1028, 314)
        Me.dt_status.TabIndex = 0
        '
        'device
        '
        Me.device.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.device.HeaderText = "Device"
        Me.device.MinimumWidth = 6
        Me.device.Name = "device"
        '
        'device_type
        '
        Me.device_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.device_type.HeaderText = "Device Type"
        Me.device_type.MinimumWidth = 6
        Me.device_type.Name = "device_type"
        '
        'serial_number
        '
        Me.serial_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serial_number.HeaderText = "Serial Number"
        Me.serial_number.MinimumWidth = 6
        Me.serial_number.Name = "serial_number"
        '
        'tested
        '
        Me.tested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tested.HeaderText = "Tested"
        Me.tested.MinimumWidth = 6
        Me.tested.Name = "tested"
        '
        'ios
        '
        Me.ios.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ios.HeaderText = "IOS"
        Me.ios.MinimumWidth = 6
        Me.ios.Name = "ios"
        '
        'condition
        '
        Me.condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.condition.HeaderText = "Condition"
        Me.condition.MinimumWidth = 6
        Me.condition.Name = "condition"
        '
        'location
        '
        Me.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.location.HeaderText = "Location"
        Me.location.MinimumWidth = 6
        Me.location.Name = "location"
        '
        'FormStatusBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 583)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormStatusBarang"
        Me.Text = "FormStatusBarang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btncari2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date_tgl_keluar As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents dt_status As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents device As DataGridViewTextBoxColumn
    Friend WithEvents device_type As DataGridViewTextBoxColumn
    Friend WithEvents serial_number As DataGridViewTextBoxColumn
    Friend WithEvents tested As DataGridViewTextBoxColumn
    Friend WithEvents ios As DataGridViewTextBoxColumn
    Friend WithEvents condition As DataGridViewTextBoxColumn
    Friend WithEvents location As DataGridViewTextBoxColumn
End Class
