Partial Class DataSet2_Stock
    Partial Public Class Data_StatusBarangDataTable
        Private Sub Data_StatusBarangDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            'If (e.Column.ColumnName = Me.DataColumn2Column.ColumnName) Then
            '    'Add user code here
            'End If

        End Sub

    End Class

    Partial Public Class DataMaintenanceDataTable
        Private Sub DataMaintenanceDataTable_DataMaintenanceRowChanging(sender As Object, e As DataMaintenanceRowChangeEvent) Handles Me.DataMaintenanceRowChanging

        End Sub

    End Class

    Partial Public Class DataRentalDataTable
        Private Sub DataRentalDataTable_DataRentalRowChanging(sender As Object, e As DataRentalRowChangeEvent) Handles Me.DataRentalRowChanging

        End Sub

    End Class
End Class
