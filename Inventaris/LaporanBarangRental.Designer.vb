<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LaporanBarangRental
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataRentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2_Stock = New Inventaris.DataSet2_Stock()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DataRentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataRentalBindingSource
        '
        Me.DataRentalBindingSource.DataMember = "DataRental"
        Me.DataRentalBindingSource.DataSource = Me.DataSet2_Stock
        '
        'DataSet2_Stock
        '
        Me.DataSet2_Stock.DataSetName = "DataSet2_Stock"
        Me.DataSet2_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.AutoScroll = True
        Me.ReportViewer1.AutoSize = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataRentalBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Inventaris.ReportRental.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(912, 364)
        Me.ReportViewer1.TabIndex = 1
        '
        'LaporanBarangRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 366)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "LaporanBarangRental"
        Me.Text = "LaporanBarangRental"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataRentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataRentalBindingSource As BindingSource
    Friend WithEvents DataSet2_Stock As DataSet2_Stock
End Class
