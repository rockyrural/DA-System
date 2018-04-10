Public Class MaintainInspectionType



    Private Sub MaintDevelopmentType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AssessmentData.CCAppType' table. You can move, or remove it, as needed.
        Me.CCAppTypeTableAdapter.Fill(Me.AssessmentData.CCAppType)
         'TODO: This line of code loads data into the 'DevelopmentSQLDataSet.CoType' table. You can move, or remove it, as needed.
        Me.CoTypeTableAdapter.Fill(Me.DevelopmentSQLDataSet.CoType)


    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        With dgvCoType
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .ReadOnly = False
            Dim iRow As Integer = .Rows.Count
            .CurrentCell = dgvCoType(2, iRow - 1)
            .CurrentCell.Selected = True
        End With
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False

    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        dgvCoType.ReadOnly = False
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.CoTypeBindingSource.EndEdit()
        Me.CoTypeTableAdapter.Update(Me.DevelopmentSQLDataSet.CoType)

        With dgvCoType
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .ReadOnly = True
        End With

        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True

    End Sub

 

    Private Sub dgvCoType_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCoType.DataError
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