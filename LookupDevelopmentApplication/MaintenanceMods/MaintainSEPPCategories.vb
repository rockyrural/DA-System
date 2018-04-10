Public Class MaintainSEPPCategories

    Private Sub Usp_ReferralCode_SELECTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SEPPCodeBindingSource.EndEdit()
        Me.SEPPCodeTableAdapter.Update(Me.ReferralCategories.SEPPCode)

    End Sub

    Private Sub MaintainReferralCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReferralCategories.SEPPCode' table. You can move, or remove it, as needed.
        Me.SEPPCodeTableAdapter.Fill(Me.ReferralCategories.SEPPCode)
        ''TODO: This line of code loads data into the 'ReferralCategories.usp_LoadUpListOfReferralCodeCategories' table. You can move, or remove it, as needed.
        'Me.Usp_LoadUpListOfReferralCodeCategoriesTableAdapter.Fill(Me.ReferralCategories.usp_LoadUpListOfReferralCodeCategories)
        ''TODO: This line of code loads data into the 'ReferralCategories.usp_ReferalCodes' table. You can move, or remove it, as needed.
        'Me.Usp_ReferralCode_SELECTTableAdapter.Fill(Me.ReferralCategories.usp_ReferralCode_SELECT)

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With dgvSEPPCodes
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .ReadOnly = False
            Dim iRow As Integer = .Rows.Count
            .CurrentCell = dgvSEPPCodes(0, iRow - 1)
            .CurrentCell.Selected = True
        End With
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False

    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        dgvSEPPCodes.ReadOnly = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Try

            Me.SEPPCodeBindingSource.EndEdit()
            Me.SEPPCodeTableAdapter.Update(Me.ReferralCategories.SEPPCode)

            With dgvSEPPCodes
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With

            btnSave.Enabled = False
            btnAdd.Enabled = True
            btnEdit.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Unable to Update", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    'Private Sub dgvReferralCategories_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvReferralCategories.DataError
    '    Select Case e.ColumnIndex
    '        Case 1
    '            MessageBox.Show("You are required to enter a referral type", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            e.Cancel = True

    '        Case 2
    '            MessageBox.Show("You are required to select a value from this list", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            e.Cancel = True

    '    End Select

    'End Sub
End Class