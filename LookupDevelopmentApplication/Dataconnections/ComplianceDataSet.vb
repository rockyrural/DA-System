Partial Class ComplianceDataSet
    Partial Class ComplianceInspectionDataTable

        Private Sub ComplianceInspectionDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CoInspNotesColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
