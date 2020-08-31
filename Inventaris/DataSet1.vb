

Partial Class DataSet1
    Partial Public Class DataInvoiceDataTable
        Private Sub DataInvoiceDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ID_TRANSAKSIColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
