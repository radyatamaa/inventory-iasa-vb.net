<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanMaintenance
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet2_Stock = New Inventaris.DataSet2_Stock()
        Me.DataMaintenanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet2_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataMaintenanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2_Stock"
        ReportDataSource1.Value = Me.DataMaintenanceBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Inventaris.ReportMaintenance.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1444, 554)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet2_Stock
        '
        Me.DataSet2_Stock.DataSetName = "DataSet2_Stock"
        Me.DataSet2_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataMaintenanceBindingSource
        '
        Me.DataMaintenanceBindingSource.DataMember = "DataMaintenance"
        Me.DataMaintenanceBindingSource.DataSource = Me.DataSet2_Stock
        '
        'LaporanMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 554)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LaporanMaintenance"
        Me.Text = "LaporanMaintenance"
        CType(Me.DataSet2_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataMaintenanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataMaintenanceBindingSource As BindingSource
    Friend WithEvents DataSet2_Stock As DataSet2_Stock
End Class
