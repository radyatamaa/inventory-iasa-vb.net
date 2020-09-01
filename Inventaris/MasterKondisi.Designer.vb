<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterKondisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterKondisi))
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.data_master_kondisi = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_kondisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_nama_kondisi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.data_master_kondisi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_simpan
        '
        Me.btn_simpan.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_simpan.FlatAppearance.BorderSize = 0
        Me.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_simpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_simpan.Location = New System.Drawing.Point(172, 73)
        Me.btn_simpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(236, 28)
        Me.btn_simpan.TabIndex = 2
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = False
        '
        'data_master_kondisi
        '
        Me.data_master_kondisi.AllowUserToOrderColumns = True
        Me.data_master_kondisi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.data_master_kondisi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.data_master_kondisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_master_kondisi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nama_kondisi})
        Me.data_master_kondisi.Location = New System.Drawing.Point(3, 174)
        Me.data_master_kondisi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.data_master_kondisi.Name = "data_master_kondisi"
        Me.data_master_kondisi.RowHeadersWidth = 51
        Me.data_master_kondisi.RowTemplate.Height = 24
        Me.data_master_kondisi.Size = New System.Drawing.Size(1364, 254)
        Me.data_master_kondisi.TabIndex = 3
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'nama_kondisi
        '
        Me.nama_kondisi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_kondisi.HeaderText = "Nama Kondisi"
        Me.nama_kondisi.MinimumWidth = 6
        Me.nama_kondisi.Name = "nama_kondisi"
        '
        'txt_nama_kondisi
        '
        Me.txt_nama_kondisi.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_nama_kondisi.Location = New System.Drawing.Point(172, 31)
        Me.txt_nama_kondisi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nama_kondisi.Name = "txt_nama_kondisi"
        Me.txt_nama_kondisi.Size = New System.Drawing.Size(236, 22)
        Me.txt_nama_kondisi.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Kondisi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.btn_simpan)
        Me.Panel2.Controls.Add(Me.data_master_kondisi)
        Me.Panel2.Controls.Add(Me.txt_nama_kondisi)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(1, 97)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 430)
        Me.Panel2.TabIndex = 21
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
        Me.btn_kembali.Size = New System.Drawing.Size(101, 69)
        Me.btn_kembali.TabIndex = 5
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(12, 531)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(93, 39)
        Me.Button13.TabIndex = 4
        Me.Button13.Text = "Hapus"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btn_kembali)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1371, 97)
        Me.Panel1.TabIndex = 58
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1213, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 86)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Condensed", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(609, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(339, 58)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "KONDISI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MasterKondisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1371, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MasterKondisi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterKondisi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.data_master_kondisi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_simpan As Button
    Friend WithEvents data_master_kondisi As DataGridView
    Friend WithEvents txt_nama_kondisi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nama_kondisi As DataGridViewTextBoxColumn
    Friend WithEvents Button13 As Button
    Friend WithEvents btn_kembali As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
End Class
