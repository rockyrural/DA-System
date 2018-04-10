Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class MaintainVariations


    Public Sub UpdateDatasource(ByVal grid As GridControl)
        'Save the latest changes to the bound DataTable 
        Dim View As ColumnView = grid.FocusedView
        If Not (View.PostEditor() And View.UpdateCurrentRow()) Then Return

        Me.VariationsTableAdapter.Update(Me.DAdatasets.Variations)
        gvwVariations.OptionsBehavior.Editable = False

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.VariationsTableAdapter.Fill(Me.DAdatasets.Variations)

        gvwVariations.OptionsBehavior.Editable = True

        gvwVariations.AddNewRow()

        'btnSave.Enabled = True


    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        gvwVariations.OptionsBehavior.Editable = True

    End Sub

    Private Sub gvwVariations_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwVariations.RowClick

        btnChange.Enabled = True

    End Sub

    Private Sub gvwVariations_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvwVariations.ValidateRow

        Dim View As GridView = CType(sender, GridView)

        'Dim IDCol As GridColumn = View.Columns("FeeCode")

        'Dim theID As String

        'theID = View.GetRowCellValue(e.RowHandle, colFeeCode).ToString()

        'If theID = String.Empty Then


        '    e.Valid = False

        '    View.SetColumnError(IDCol, "You MUST enter fee code")

        'End If


        Dim DescriptionCol As GridColumn = View.Columns("Variation")

        Dim theDescription As String

        theDescription = View.GetRowCellValue(e.RowHandle, colVariation).ToString()

        If theDescription = String.Empty Then


            e.Valid = False

            View.SetColumnError(DescriptionCol, "You MUST enter variation")

        End If



    End Sub

    Private Sub gvwVariations_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvwVariations.ValidatingEditor


        Dim View As GridView = CType(sender, GridView)


        'If View.FocusedColumn.FieldName = "FeeCode" Then

        '    If e.Value.ToString.Trim = "" Then

        '        e.Valid = False

        '    End If



        'End If


        If View.FocusedColumn.FieldName = "Variation" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If




    End Sub

    Private Sub gvwVariations_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs) Handles gvwVariations.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvwVariations_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvwVariations.InvalidValueException

        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        e.WindowCaption = "Input Error"
        e.ErrorText = "You MUST enter data"

    End Sub

    Private Sub gvwVariations_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvwVariations.RowUpdated

        UpdateDatasource(grdVariations)

    End Sub

    Private Sub MaintainVariations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.VariationsTableAdapter.Fill(Me.DAdatasets.Variations)
        gvwVariations.OptionsBehavior.Editable = False

    End Sub
End Class