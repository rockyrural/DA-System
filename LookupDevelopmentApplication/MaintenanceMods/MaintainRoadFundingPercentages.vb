Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Public Class MaintainRoadFundingPercentages


    Public Sub UpdateDatasource(ByVal grid As GridControl)
        'Save the latest changes to the bound DataTable 
        Dim View As ColumnView = grid.FocusedView
        If Not (View.PostEditor() And View.UpdateCurrentRow()) Then Return

        Me.S94CodeRFnumbersTableAdapter.Update(Me.DevelopmentSQLDataSet.S94CodeRFnumbers)

        gvwSec94RF.OptionsBehavior.Editable = False

    End Sub

    Private Sub MaintainRoadFundingPercentages_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.S94CodeRFnumbersTableAdapter.Fill(Me.DevelopmentSQLDataSet.S94CodeRFnumbers)

        gvwSec94RF.OptionsBehavior.Editable = False

        btnChange.Enabled = False

        btnAdd.Enabled = True



    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.S94CodeRFnumbersTableAdapter.Fill(Me.DevelopmentSQLDataSet.S94CodeRFnumbers)

        gvwSec94RF.OptionsBehavior.Editable = True

        gvwSec94RF.AddNewRow()

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        gvwSec94RF.OptionsBehavior.Editable = True

        btnChange.Enabled = False


    End Sub

    Private Sub gvwSec94RF_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwSec94RF.RowClick

        btnChange.Enabled = True

    End Sub

    Private Sub gvwSec94RF_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles gvwSec94RF.ValidateRow



        Dim View As GridView = CType(sender, GridView)

        Dim BreedCol As GridColumn = View.Columns("s94Code")

        Dim theBreed As String

        theBreed = View.GetRowCellValue(e.RowHandle, cols94code).ToString()

        If theBreed = String.Empty Then


            e.Valid = False

            View.SetColumnError(BreedCol, "You MUST enter a Code")

        End If


        Dim DescriptionCol As GridColumn = View.Columns("Percentage")

        Dim theDescription As String

        theDescription = View.GetRowCellValue(e.RowHandle, colPercentage).ToString()

        If theDescription = String.Empty Then


            e.Valid = False

            View.SetColumnError(DescriptionCol, "You MUST enter a %")

        End If


        Dim SpeciesCol As GridColumn = View.Columns("rfnumber")

        Dim theSpecies As String

        theSpecies = View.GetRowCellValue(e.RowHandle, colrfnumber).ToString()

        If theSpecies = String.Empty Then


            e.Valid = False

            View.SetColumnError(SpeciesCol, "You MUST enter a road fund number")

        End If


    End Sub

    Private Sub gvwSec94RF_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvwSec94RF.ValidatingEditor


        Dim View As GridView = CType(sender, GridView)


        If View.FocusedColumn.FieldName = "s94Code" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If


        If View.FocusedColumn.FieldName = "Percentage" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If


        If View.FocusedColumn.FieldName = "rfnumber" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If

    End Sub

    Private Sub gvwSec94RF_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvwSec94RF.RowUpdated

        UpdateDatasource(grdSec94RF)


    End Sub
End Class