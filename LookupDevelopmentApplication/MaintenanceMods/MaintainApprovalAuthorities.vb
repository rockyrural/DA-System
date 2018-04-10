Public Class MaintainApprovalAuthorities


    Private Sub MaintainApprovalAuthorities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Usp_DAAuthority_SELECTTableAdapter.Fill(Me.DevelopmentAuthority.usp_DAAuthority_SELECT)

    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With dgvAuthorities
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .ReadOnly = False
            Dim iRow As Integer = .Rows.Count
            .CurrentCell = dgvAuthorities(2, iRow - 1)
            .CurrentCell.Selected = True
        End With
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False

    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        dgvAuthorities.ReadOnly = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.Usp_DAAuthority_SELECTBindingSource.EndEdit()
        Me.Usp_DAAuthority_SELECTTableAdapter.Update(Me.DevelopmentAuthority.usp_DAAuthority_SELECT)

        With dgvAuthorities
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
        End With

        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True

    End Sub

End Class