<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Barang_Penjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._db_inventory_iasaDataSet3 = New Inventaris._db_inventory_iasaDataSet3()
        Me.VIEW_DETAIL_BARANG_KELUARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VIEW_DETAIL_BARANG_KELUARTableAdapter = New Inventaris._db_inventory_iasaDataSet3TableAdapters.VIEW_DETAIL_BARANG_KELUARTableAdapter()
        CType(Me._db_inventory_iasaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIEW_DETAIL_BARANG_KELUARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.AutoScroll = True
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.VIEW_DETAIL_BARANG_KELUARBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Inventaris.Report_Penjualan.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, -1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(798, 451)
        Me.ReportViewer1.TabIndex = 0
        '
        '_db_inventory_iasaDataSet3
        '
        Me._db_inventory_iasaDataSet3.DataSetName = "_db_inventory_iasaDataSet3"
        Me._db_inventory_iasaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VIEW_DETAIL_BARANG_KELUARBindingSource
        '
        Me.VIEW_DETAIL_BARANG_KELUARBindingSource.DataMember = "VIEW_DETAIL_BARANG_KELUAR"
        Me.VIEW_DETAIL_BARANG_KELUARBindingSource.DataSource = Me._db_inventory_iasaDataSet3
        '
        'VIEW_DETAIL_BARANG_KELUARTableAdapter
        '
        Me.VIEW_DETAIL_BARANG_KELUARTableAdapter.ClearBeforeFill = True
        '
        'Laporan_Barang_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Laporan_Barang_Penjualan"
        Me.Text = "Laporan_Barang_Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._db_inventory_iasaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIEW_DETAIL_BARANG_KELUARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VIEW_DETAIL_BARANG_KELUARBindingSource As BindingSource
    Friend WithEvents _db_inventory_iasaDataSet3 As _db_inventory_iasaDataSet3
    Friend WithEvents VIEW_DETAIL_BARANG_KELUARTableAdapter As _db_inventory_iasaDataSet3TableAdapters.VIEW_DETAIL_BARANG_KELUARTableAdapter
End Class
