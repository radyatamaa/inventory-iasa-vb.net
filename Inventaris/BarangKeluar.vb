Public Class BarangKeluar
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub BarangKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
    End Sub
End Class