<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_kembali = New System.Windows.Forms.Button()
        Me.txt_password_lama = New System.Windows.Forms.TextBox()
        Me.txt_password_baru = New System.Windows.Forms.TextBox()
        Me.btn_ubah = New System.Windows.Forms.Button()
        Me.txt_konfirmasi_password = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(221, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(444, 58)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Ubah Password"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_kembali
        '
        Me.btn_kembali.BackColor = System.Drawing.Color.Transparent
        Me.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_kembali.FlatAppearance.BorderSize = 0
        Me.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_kembali.Image = CType(resources.GetObject("btn_kembali.Image"), System.Drawing.Image)
        Me.btn_kembali.Location = New System.Drawing.Point(3, 0)
        Me.btn_kembali.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_kembali.Name = "btn_kembali"
        Me.btn_kembali.Size = New System.Drawing.Size(82, 80)
        Me.btn_kembali.TabIndex = 54
        Me.btn_kembali.UseVisualStyleBackColor = False
        '
        'txt_password_lama
        '
        Me.txt_password_lama.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_password_lama.Location = New System.Drawing.Point(370, 137)
        Me.txt_password_lama.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_password_lama.Name = "txt_password_lama"
        Me.txt_password_lama.Size = New System.Drawing.Size(236, 22)
        Me.txt_password_lama.TabIndex = 21
        Me.txt_password_lama.UseSystemPasswordChar = True
        '
        'txt_password_baru
        '
        Me.txt_password_baru.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_password_baru.Location = New System.Drawing.Point(370, 179)
        Me.txt_password_baru.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_password_baru.Name = "txt_password_baru"
        Me.txt_password_baru.Size = New System.Drawing.Size(236, 22)
        Me.txt_password_baru.TabIndex = 20
        Me.txt_password_baru.UseSystemPasswordChar = True
        '
        'btn_ubah
        '
        Me.btn_ubah.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_ubah.FlatAppearance.BorderSize = 0
        Me.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ubah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_ubah.Location = New System.Drawing.Point(308, 269)
        Me.btn_ubah.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ubah.Name = "btn_ubah"
        Me.btn_ubah.Size = New System.Drawing.Size(236, 28)
        Me.btn_ubah.TabIndex = 17
        Me.btn_ubah.Text = "Ubah"
        Me.btn_ubah.UseVisualStyleBackColor = False
        '
        'txt_konfirmasi_password
        '
        Me.txt_konfirmasi_password.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_konfirmasi_password.Location = New System.Drawing.Point(370, 218)
        Me.txt_konfirmasi_password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_konfirmasi_password.Name = "txt_konfirmasi_password"
        Me.txt_konfirmasi_password.Size = New System.Drawing.Size(236, 22)
        Me.txt_konfirmasi_password.TabIndex = 8
        Me.txt_konfirmasi_password.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Konfirmasi Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password Baru"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password Lama"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.btn_kembali)
        Me.Panel2.Controls.Add(Me.txt_password_lama)
        Me.Panel2.Controls.Add(Me.txt_password_baru)
        Me.Panel2.Controls.Add(Me.btn_ubah)
        Me.Panel2.Controls.Add(Me.txt_konfirmasi_password)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 398)
        Me.Panel2.TabIndex = 60
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 406)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Ubah Password"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents btn_kembali As Button
    Friend WithEvents txt_password_lama As TextBox
    Friend WithEvents txt_password_baru As TextBox
    Friend WithEvents btn_ubah As Button
    Friend WithEvents txt_konfirmasi_password As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class
