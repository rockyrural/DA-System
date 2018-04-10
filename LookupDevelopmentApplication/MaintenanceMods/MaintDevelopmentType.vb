Public Class MaintDevelopmentType

  

    Private Sub MaintDevelopmentType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LoadUpBusinessPaperCategoryTableAdapter.Fill(Me.DevelopmentSQLDataSet.LoadUpBusinessPaperCategory)
        Me.DevTypeTableAdapter.Fill(Me.DevelopmentSQLDataSet.DevType)

    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With DevTypeDataGridView
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .ReadOnly = False
            Dim iRow As Integer = .Rows.Count
            .CurrentCell = DevTypeDataGridView(2, iRow - 1)
            .CurrentCell.Selected = True
        End With
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False

    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        DevTypeDataGridView.ReadOnly = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.DevTypeBindingSource.EndEdit()
        Me.DevTypeTableAdapter.Update(Me.DevelopmentSQLDataSet.DevType)

        With DevTypeDataGridView
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
        End With

        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True

    End Sub

    Private Sub DevTypeDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DevTypeDataGridView.DataError
        Select Case e.ColumnIndex
            Case 1
                MessageBox.Show("You are required to enter a development type", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True

            Case 2
                MessageBox.Show("You are required to select a value from this list", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True

        End Select

    End Sub
End Class