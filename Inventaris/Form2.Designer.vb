<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btntk3 = New System.Windows.Forms.Button()
        Me.btntk1 = New System.Windows.Forms.Button()
        Me.btntk2 = New System.Windows.Forms.Button()
        Me.btntk0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.btntk3)
        Me.Panel1.Controls.Add(Me.btntk1)
        Me.Panel1.Controls.Add(Me.btntk2)
        Me.Panel1.Controls.Add(Me.btntk0)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(290, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 337)
        Me.Panel1.TabIndex = 0
        '
        'btntk3
        '
        Me.btntk3.Location = New System.Drawing.Point(256, 188)
        Me.btntk3.Margin = New System.Windows.Forms.Padding(2)
        Me.btntk3.Name = "btntk3"
        Me.btntk3.Size = New System.Drawing.Size(148, 116)
        Me.btntk3.TabIndex = 4
        Me.btntk3.Text = "Button4"
        Me.btntk3.UseVisualStyleBackColor = True
        '
        'btntk1
        '
        Me.btntk1.Location = New System.Drawing.Point(256, 40)
        Me.btntk1.Margin = New System.Windows.Forms.Padding(2)
        Me.btntk1.Name = "btntk1"
        Me.btntk1.Size = New System.Drawing.Size(148, 116)
        Me.btntk1.TabIndex = 3
        Me.btntk1.Text = "Button3"
        Me.btntk1.UseVisualStyleBackColor = True
        '
        'btntk2
        '
        Me.btntk2.Location = New System.Drawing.Point(74, 188)
        Me.btntk2.Margin = New System.Windows.Forms.Padding(2)
        Me.btntk2.Name = "btntk2"
        Me.btntk2.Size = New System.Drawing.Size(148, 116)
        Me.btntk2.TabIndex = 2
        Me.btntk2.Text = "Button2"
        Me.btntk2.UseVisualStyleBackColor = True
        '
        'btntk0
        '
        Me.btntk0.Location = New System.Drawing.Point(74, 40)
        Me.btntk0.Margin = New System.Windows.Forms.Padding(2)
        Me.btntk0.Name = "btntk0"
        Me.btntk0.Size = New System.Drawing.Size(148, 116)
        Me.btntk0.TabIndex = 1
        Me.btntk0.Text = "Button1"
        Me.btntk0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(194, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Toko"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 587)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btntk3 As Button
    Friend WithEvents btntk1 As Button
    Friend WithEvents btntk2 As Button
    Friend WithEvents btntk0 As Button
    Friend WithEvents Label1 As Label
End Class
