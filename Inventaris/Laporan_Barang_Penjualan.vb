Public Class Laporan_Barang_Penjualan
    Private Sub Laporan_Barang_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_db_inventory_iasaDataSet3.VIEW_DETAIL_BARANG_KELUAR' table. You can move, or remove it, as needed.
        Me.VIEW_DETAIL_BARANG_KELUARTableAdapter.Fill(Me._db_inventory_iasaDataSet3.VIEW_DETAIL_BARANG_KELUAR)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class