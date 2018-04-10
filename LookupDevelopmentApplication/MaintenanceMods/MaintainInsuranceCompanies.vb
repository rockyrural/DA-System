
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class MaintainInsuranceCompanies


    Public Sub UpdateDatasource(ByVal grid As GridControl)
        'Save the latest changes to the bound DataTable 
        Dim View As ColumnView = grid.FocusedView
        If Not (View.PostEditor() And View.UpdateCurrentRow()) Then Return

        Me.InsuranceCompaniesTableAdapter.Update(Me.CCdata.InsuranceCompanies)
        gvwFees.OptionsBehavior.Editable = False

    End Sub
    Private Sub MaintainInsuranceCompanies_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.InsuranceCompaniesTableAdapter.Fill(Me.CCdata.InsuranceCompanies)

        gvwFees.OptionsBehavior.Editable = False


    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.InsuranceCompaniesTableAdapter.Fill(Me.CCdata.InsuranceCompanies)

        gvwFees.OptionsBehavior.Editable = True

        gvwFees.AddNewRow()

        'btnSave.Enabled = True


    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        gvwFees.OptionsBehavior.Editable = True

    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs)

    '    btnSave.Enabled = False
    '    btnChange.Enabled = True
    '    UpdateDatasource(grdOfficers)


    'End Sub

    Private Sub gvwFees_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwFees.RowClick

        btnChange.Enabled = True

    End Sub

    Private Sub gvwFees_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvwFees.ValidateRow

        Dim View As GridView = CType(sender, GridView)

        'Dim IDCol As GridColumn = View.Columns("FeeCode")

        'Dim theID As String

        'theID = View.GetRowCellValue(e.RowHandle, colFeeCode).ToString()

        'If theID = String.Empty Then


        '    e.Valid = False

        '    View.SetColumnError(IDCol, "You MUST enter fee code")

        'End If


        Dim DescriptionCol As GridColumn = View.Columns("Insurance")

        Dim theDescription As String

        theDescription = View.GetRowCellValue(e.RowHandle, colInsurance).ToString()

        If theDescription = String.Empty Then


            e.Valid = False

            View.SetColumnError(DescriptionCol, "You MUST enter Company name")

        End If



    End Sub

    Private Sub gvwFees_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvwFees.ValidatingEditor


        Dim View As GridView = CType(sender, GridView)


        'If View.FocusedColumn.FieldName = "FeeCode" Then

        '    If e.Value.ToString.Trim = "" Then

        '        e.Valid = False

        '    End If



        'End If


        If View.FocusedColumn.FieldName = "Insurance" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If




    End Sub

    Private Sub gvwFees_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles gvwFees.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvwFees_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvwFees.InvalidValueException

        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        e.WindowCaption = "Input Error"
        e.ErrorText = "You MUST enter data"

    End Sub

    Private Sub gvwFees_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvwFees.RowUpdated

        UpdateDatasource(grdFees)

    End Sub

End Class