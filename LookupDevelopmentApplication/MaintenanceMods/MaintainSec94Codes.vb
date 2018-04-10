Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class MaintainSec94Codes


    Public Sub UpdateDatasource(ByVal grid As GridControl)
        'Save the latest changes to the bound DataTable 
        Dim View As ColumnView = grid.FocusedView
        If Not (View.PostEditor() And View.UpdateCurrentRow()) Then Return

        Me.S94CodeTableAdapter.Update(Me.DevelopmentSQLDataSet1.S94Code)

        gvwSection94.OptionsBehavior.Editable = False

    End Sub

    Private Sub MaintainSec94Codes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.S94CodeTableAdapter.Fill(Me.DevelopmentSQLDataSet1.S94Code)

        gvwSection94.OptionsBehavior.Editable = False

        btnChange.Enabled = False

        btnAdd.Enabled = True


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.S94CodeTableAdapter.Fill(Me.DevelopmentSQLDataSet1.S94Code)

        gvwSection94.OptionsBehavior.Editable = True

        gvwSection94.AddNewRow()

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        gvwSection94.OptionsBehavior.Editable = True

        btnChange.Enabled = False


    End Sub

    Private Sub gvwSection94_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwSection94.RowClick

        btnChange.Enabled = True

    End Sub

    Private Sub gvwSection94_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles gvwSection94.ValidateRow



        Dim View As GridView = CType(sender, GridView)

        Dim BreedCol As GridColumn = View.Columns("s94Code")

        Dim theBreed As String

        theBreed = View.GetRowCellValue(e.RowHandle, cols94Code).ToString()

        If theBreed = String.Empty Then


            e.Valid = False

            View.SetColumnError(BreedCol, "You MUST enter a Code")

        End If


        Dim DescriptionCol As GridColumn = View.Columns("s94Plan")

        Dim theDescription As String

        theDescription = View.GetRowCellValue(e.RowHandle, cols94Plan).ToString()

        If theDescription = String.Empty Then


            e.Valid = False

            View.SetColumnError(DescriptionCol, "You MUST enter a plan Description")

        End If


        Dim SpeciesCol As GridColumn = View.Columns("s94Subplan")

        Dim theSpecies As String

        theSpecies = View.GetRowCellValue(e.RowHandle, cols94Subplan).ToString()

        If theSpecies = String.Empty Then


            e.Valid = False

            View.SetColumnError(SpeciesCol, "You MUST enter a sub plan description")

        End If


    End Sub

    Private Sub gvwSection94_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvwSection94.ValidatingEditor


        Dim View As GridView = CType(sender, GridView)


        If View.FocusedColumn.FieldName = "s94Code" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If


        If View.FocusedColumn.FieldName = "s94Plan" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If


        If View.FocusedColumn.FieldName = "s94Subplan" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If

    End Sub

    Private Sub gvwSection94_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvwSection94.RowUpdated

        UpdateDatasource(grdSection94)


    End Sub
End Class