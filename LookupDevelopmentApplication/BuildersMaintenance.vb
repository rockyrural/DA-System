Public Class BuildersMaintenance

    Private Sub PCA_BUILDERS_NAMEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCA_BUILDERS_NAMEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PCA_BUILDERS_NAMEBindingSource.EndEdit()
        Me.PCA_BUILDERS_NAME_TableAdapter.Update(Me.Maintenance.PCA_BUILDERS_NAME)

    End Sub

    Private Sub BuildersMaintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Maintenance.PCA_BUILDERS_NAME' table. You can move, or remove it, as needed.
        Me.PCA_BUILDERS_NAME_TableAdapter.Fill(Me.Maintenance.PCA_BUILDERS_NAME)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With dgvPCA_BUILDERS_NAME
            .AllowUserToAddRows = True
            .ReadOnly = False
            Dim iRow As Integer = .Rows.Count
            .CurrentCell = dgvPCA_BUILDERS_NAME(2, iRow - 1)
            .CurrentCell.Selected = True
        End With

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        dgvPCA_BUILDERS_NAME.ReadOnly = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        PCA_BUILDERS_NAMEBindingSource.EndEdit()
        Me.PCA_BUILDERS_NAME_TableAdapter.Update(Me.Maintenance.PCA_BUILDERS_NAME)
        With dgvPCA_BUILDERS_NAME
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With

    End Sub


End Class