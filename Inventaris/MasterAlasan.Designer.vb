<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterAlasan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterAlasan))
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.data_master_alasan = New System.Windows.Forms.DataGridView()
        Me.id_alasan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_alasan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_nama_alasan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pict_logo = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        CType(Me.data_master_alasan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(217, 598)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(93, 39)
        Me.Button13.TabIndex = 19
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(117, 598)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(93, 39)
        Me.Button12.TabIndex = 18
        Me.Button12.Text = "Edit"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'data_master_alasan
        '
        Me.data_master_alasan.AllowUserToOrderColumns = True
        Me.data_master_alasan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_alasan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_alasan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_alasan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_alasan, Me.nama_alasan})
        Me.data_master_alasan.Location = New System.Drawing.Point(3, 334)
        Me.data_master_alasan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_alasan.Name = "data_master_alasan"
        Me.data_master_alasan.RowHeadersWidth = 51
        Me.data_master_alasan.RowTemplate.Height = 24
        Me.data_master_alasan.Size = New System.Drawing.Size(1539, 254)
        Me.data_master_alasan.TabIndex = 16
        '
        'id_alasan
        '
        Me.id_alasan.HeaderText = "ID"
        Me.id_alasan.MinimumWidth = 6
        Me.id_alasan.Name = "id_alasan"
        Me.id_alasan.Width = 125
        '
        'nama_alasan
        '
        Me.nama_alasan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_alasan.HeaderText = "Nama Alasan"
        Me.nama_alasan.MinimumWidth = 6
        Me.nama_alasan.Name = "nama_alasan"
        '
        'txt_nama_alasan
        '
        Me.txt_nama_alasan.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_alasan.Location = New System.Drawing.Point(215, 153)
        Me.txt_nama_alasan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nama_alasan.Name = "txt_nama_alasan"
        Me.txt_nama_alasan.Size = New System.Drawing.Size(236, 22)
        Me.txt_nama_alasan.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Alasan"
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(215, 231)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.pict_logo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_alasan)
        Me.Panel2.Controls.Add(Me.txt_nama_alasan)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1539, 591)
        Me.Panel2.TabIndex = 16
        '
        'pict_logo
        '
        Me.pict_logo.BackgroundImage = CType(resources.GetObject("pict_logo.BackgroundImage"), System.Drawing.Image)
        Me.pict_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pict_logo.Location = New System.Drawing.Point(1372, 2)
        Me.pict_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pict_logo.Name = "pict_logo"
        Me.pict_logo.Size = New System.Drawing.Size(156, 86)
        Me.pict_logo.TabIndex = 51
        Me.pict_logo.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Condensed", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(613, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(339, 58)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Master Alasan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(11, 2)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(101, 75)
        Me.btn_kembali.TabIndex = 49
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'MasterAlasan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterAlasan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterAlasan"
        CType(Me.data_master_alasan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pict_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents data_master_alasan As DataGridView
    Friend WithEvents txt_nama_alasan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_simpan As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pict_logo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents id_alasan As DataGridViewTextBoxColumn
    Friend WithEvents nama_alasan As DataGridViewTextBoxColumn
End Class
