Public Class MaintainDefaultConditions



    Private Sub MaintDevelopmentType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssessmentData.usp_SELECT_StandardCondition' table. You can move, or remove it, as needed.
        Me.Usp_SELECT_StandardConditionTableAdapter.Fill(Me.AssessmentData.usp_SELECT_StandardCondition)
        'TODO: This line of code loads data into the 'AssessmentData.usp_LoadUpStandardConditionsCodes' table. You can move, or remove it, as needed.
        Me.Usp_LoadUpStandardConditionsCodesTableAdapter.Fill(Me.AssessmentData.usp_LoadUpStandardConditionsCodes)
        'TODO: This line of code loads data into the 'AssessmentData.usp_DASETUP_LoadUpAssessmentTypes' table. You can move, or remove it, as needed.
        Me.Usp_DASETUP_LoadUpAssessmentTypesTableAdapter.Fill(Me.AssessmentData.usp_DASETUP_LoadUpAssessmentTypes)
        'TODO: This line of code loads data into the 'AssessmentData.usp_LoadUpStandardWordTemplateLetterList' table. You can move, or remove it, as needed.
        Me.Usp_LoadUpStandardWordTemplateLetterListTableAdapter.Fill(Me.AssessmentData.usp_LoadUpStandardWordTemplateLetterList)
        'TODO: This line of code loads data into the 'AssessmentData.StandardDefaultConditions' table. You can move, or remove it, as needed.
        Me.StandardDefaultConditionsTableAdapter.Fill(Me.AssessmentData.StandardDefaultConditions)



    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With dgvStdCond
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .ReadOnly = False
            Dim iRow As Integer = .Rows.Count
            .CurrentCell = dgvStdCond(2, iRow - 1)
            .CurrentCell.Selected = True
        End With
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False

    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        dgvStdCond.ReadOnly = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.StandardDefaultConditionsBindingSource.EndEdit()
        Me.StandardDefaultConditionsTableAdapter.Update(Me.AssessmentData.StandardDefaultConditions)

        With dgvStdCond
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
        End With

        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True

    End Sub



    Private Sub dgvCoType_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvStdCond.DataError
        Select Case e.ColumnIndex
            Case 1
                MessageBox.Show("You are required to enter a inspection type", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True

            Case 2
                MessageBox.Show("You are required to select a value from this list", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Cancel = True

        End Select

    End Sub

 
End Class