<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInvoice
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.kd_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kd_transaksi_keluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inovice_tittle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type_service = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.already_paid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1477, 718)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Search By"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(443, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cari"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(109, 71)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(327, 31)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search By"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(443, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(327, 31)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_client, Me.kd_transaksi_keluar, Me.nama_client, Me.inovice_tittle, Me.harga_total, Me.type_service, Me.already_paid})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1477, 585)
        Me.DataGridView1.TabIndex = 0
        '
        'kd_client
        '
        Me.kd_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kd_client.HeaderText = "Client ID"
        Me.kd_client.MinimumWidth = 6
        Me.kd_client.Name = "kd_client"
        '
        'kd_transaksi_keluar
        '
        Me.kd_transaksi_keluar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.kd_transaksi_keluar.HeaderText = "Invoice Number"
        Me.kd_transaksi_keluar.MinimumWidth = 6
        Me.kd_transaksi_keluar.Name = "kd_transaksi_keluar"
        '
        'nama_client
        '
        Me.nama_client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nama_client.HeaderText = "Client's Name"
        Me.nama_client.MinimumWidth = 6
        Me.nama_client.Name = "nama_client"
        '
        'inovice_tittle
        '
        Me.inovice_tittle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.inovice_tittle.HeaderText = "Invoice Tittle"
        Me.inovice_tittle.MinimumWidth = 6
        Me.inovice_tittle.Name = "inovice_tittle"
        '
        'harga_total
        '
        Me.harga_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.harga_total.HeaderText = "Total Price"
        Me.harga_total.MinimumWidth = 6
        Me.harga_total.Name = "harga_total"
        '
        'type_service
        '
        Me.type_service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.type_service.HeaderText = "Type of Service"
        Me.type_service.MinimumWidth = 6
        Me.type_service.Name = "type_service"
        '
        'already_paid
        '
        Me.already_paid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.already_paid.HeaderText = "Already Paid"
        Me.already_paid.MinimumWidth = 6
        Me.already_paid.Name = "already_paid"
        '
        'FormInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 718)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInvoice"
        Me.Text = "FormInvoice"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents kd_client As DataGridViewTextBoxColumn
    Friend WithEvents kd_transaksi_keluar As DataGridViewTextBoxColumn
    Friend WithEvents nama_client As DataGridViewTextBoxColumn
    Friend WithEvents inovice_tittle As DataGridViewTextBoxColumn
    Friend WithEvents harga_total As DataGridViewTextBoxColumn
    Friend WithEvents type_service As DataGridViewTextBoxColumn
    Friend WithEvents already_paid As DataGridViewTextBoxColumn
End Class
