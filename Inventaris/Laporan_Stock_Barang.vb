Public Class Laporan_Stock_Barang
    Private Sub Laporan_Stock_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_db_inventory_iasaDataSet2.View_StockBarang' table. You can move, or remove it, as needed.
        Me.View_StockBarangTableAdapter.Fill(Me._db_inventory_iasaDataSet2.View_StockBarang)
        'TODO: This line of code loads data into the '_db_inventory_iasaDataSet.View_BARANG_MASUK_DUMMY' table. You can move, or remove it, as needed.
        Me.View_BARANG_MASUK_DUMMYTableAdapter.Fill(Me._db_inventory_iasaDataSet.View_BARANG_MASUK_DUMMY)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class