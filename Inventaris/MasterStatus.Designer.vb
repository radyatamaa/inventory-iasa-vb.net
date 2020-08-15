<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterStatus))
        Me.data_master_status = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        CType(Me.data_master_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_master_status
        '
        Me.data_master_status.AllowUserToOrderColumns = True
        Me.data_master_status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_status.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_status.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_status.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_status})
        Me.data_master_status.Location = New System.Drawing.Point(0, 269)
        Me.data_master_status.Name = "data_master_status"
        Me.data_master_status.RowHeadersWidth = 51
        Me.data_master_status.RowTemplate.Height = 24
        Me.data_master_status.Size = New System.Drawing.Size(1539, 254)
        Me.data_master_status.TabIndex = 16
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'nama_status
        '
        Me.nama_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_status.HeaderText = "Nama Status"
        Me.nama_status.MinimumWidth = 6
        Me.nama_status.Name = "nama_status"
        '
        'txt_status
        '
        Me.txt_status.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_status.Location = New System.Drawing.Point(185, 173)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(236, 22)
        Me.txt_status.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Status"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(185, 231)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
        Me.btn_simpan.TabIndex = 17
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.data_master_status)
        Me.Panel2.Controls.Add(Me.txt_status)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1539, 525)
        Me.Panel2.TabIndex = 26
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(125, 532)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(94, 39)
        Me.Button13.TabIndex = 53
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(25, 532)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(94, 39)
        Me.Button12.TabIndex = 52
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'pict_logo
        '
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1380, 5)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(156, 86)
        Me.pict_logo.TabIndex = 56
        Me.pict_logo.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(547, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(339, 58)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Barang Masuk"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(16, 5)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(101, 69)
        Me.btn_kembali.TabIndex = 54
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'MasterStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1542, 832)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MasterStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterStatus"
        CType(Me.data_master_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents data_master_status As DataGridView
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_status As DataGridViewTextBoxColumn
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_kembali As Button
End Class
