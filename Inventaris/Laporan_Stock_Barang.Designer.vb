<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Stock_Barang
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.View_StockBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._db_inventory_iasaDataSet2 = New Inventaris._db_inventory_iasaDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._db_inventory_iasaDataSet = New Inventaris._db_inventory_iasaDataSet()
        Me.View_BARANG_MASUK_DUMMYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_BARANG_MASUK_DUMMYTableAdapter = New Inventaris._db_inventory_iasaDataSetTableAdapters.View_BARANG_MASUK_DUMMYTableAdapter()
        Me.View_StockBarangTableAdapter = New Inventaris._db_inventory_iasaDataSet2TableAdapters.View_StockBarangTableAdapter()
        CType(Me.View_StockBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._db_inventory_iasaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._db_inventory_iasaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BARANG_MASUK_DUMMYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_StockBarangBindingSource
        '
        Me.View_StockBarangBindingSource.DataMember = "View_StockBarang"
        Me.View_StockBarangBindingSource.DataSource = Me._db_inventory_iasaDataSet2
        '
        '_db_inventory_iasaDataSet2
        '
        Me._db_inventory_iasaDataSet2.DataSetName = "_db_inventory_iasaDataSet2"
        Me._db_inventory_iasaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet3"
        ReportDataSource1.Value = Me.View_StockBarangBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Inventaris.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(797, 452)
        Me.ReportViewer1.TabIndex = 0
        '
        '_db_inventory_iasaDataSet
        '
        Me._db_inventory_iasaDataSet.DataSetName = "_db_inventory_iasaDataSet"
        Me._db_inventory_iasaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_BARANG_MASUK_DUMMYBindingSource
        '
        Me.View_BARANG_MASUK_DUMMYBindingSource.DataMember = "View_BARANG_MASUK_DUMMY"
        Me.View_BARANG_MASUK_DUMMYBindingSource.DataSource = Me._db_inventory_iasaDataSet
        '
        'View_BARANG_MASUK_DUMMYTableAdapter
        '
        Me.View_BARANG_MASUK_DUMMYTableAdapter.ClearBeforeFill = True
        '
        'View_StockBarangTableAdapter
        '
        Me.View_StockBarangTableAdapter.ClearBeforeFill = True
        '
        'Laporan_Stock_Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Laporan_Stock_Barang"
        Me.Text = "Laporan_Stock_Barang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.View_StockBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._db_inventory_iasaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._db_inventory_iasaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BARANG_MASUK_DUMMYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents View_BARANG_MASUK_DUMMYBindingSource As BindingSource
    Friend WithEvents _db_inventory_iasaDataSet As _db_inventory_iasaDataSet
    Friend WithEvents View_BARANG_MASUK_DUMMYTableAdapter As _db_inventory_iasaDataSetTableAdapters.View_BARANG_MASUK_DUMMYTableAdapter
    Friend WithEvents View_StockBarangBindingSource As BindingSource
    Friend WithEvents _db_inventory_iasaDataSet2 As _db_inventory_iasaDataSet2
    Friend WithEvents View_StockBarangTableAdapter As _db_inventory_iasaDataSet2TableAdapters.View_StockBarangTableAdapter
End Class
