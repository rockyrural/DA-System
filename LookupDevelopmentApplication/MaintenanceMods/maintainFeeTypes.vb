Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class maintainFeeTypes
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadCategory()
    End Sub

    Public Sub UpdateDatasource(ByVal grid As GridControl)
        'Save the latest changes to the bound DataTable 
        Dim View As ColumnView = grid.FocusedView
        If Not (View.PostEditor() And View.UpdateCurrentRow()) Then Return

        Me.PaymentTableAdapter.Update(Me.Maintenance.Payment)
        gvwFees.OptionsBehavior.Editable = False

    End Sub

    Private Sub maintainFeeTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.PaymentTableAdapter.Fill(Me.Maintenance.Payment)

        gvwFees.OptionsBehavior.Editable = False

    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.PaymentTableAdapter.Fill(Me.Maintenance.Payment)

        gvwFees.OptionsBehavior.Editable = True

        gvwFees.AddNewRow()

        'btnSave.Enabled = True


    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        gvwFees.OptionsBehavior.Editable = True

    End Sub

    Private Sub gvwFees_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)Handles gvwFees.RowClick

        btnChange.Enabled = True

    End Sub

    Private Sub gvwFees_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)

        Dim View As GridView = CType(sender, GridView)

        Dim colChargCat As GridColumn = View.Columns("ChargeCategory")

        Dim theID As String

        theID = View.GetRowCellValue(e.RowHandle, colChargeCategory).ToString()

        If theID = String.Empty Then


            e.Valid = False

            View.SetColumnError(colChargCat, "You select a Charge Category")

        End If


        Dim DescriptionCol As GridColumn = View.Columns("Payment")

        Dim theDescription As String

        theDescription = View.GetRowCellValue(e.RowHandle, colPayment).ToString()

        If theDescription = String.Empty Then


            e.Valid = False

            View.SetColumnError(DescriptionCol, "You MUST enter payment type")

        End If




    End Sub

    Private Sub gvwFees_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs)


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

    Private Sub gvwFees_InvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs)Handles gvwFees.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvwFees_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs)Handles gvwFees.InvalidValueException

        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        e.WindowCaption = "Input Error"
        e.ErrorText = "You MUST enter data"

    End Sub

    Private Sub gvwFees_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvwFees.RowUpdated

        UpdateDatasource(grdFees)

    End Sub


    Private Sub LoadCategory()


        Dim SearchList As New ArrayList
        ' You need to create a class Eg. SecurityCodes to hold the values in memory
        With SearchList
            .Add(New County("Other", "OT"))
            .Add(New County("Construction Certificate", "CC"))
            .Add(New County("Compliance", "CO"))
            .Add(New County("Water Inspection", "WP"))
            .Add(New County("Sewer", "SP"))

        End With

        With cboCategories

            .Columns.Clear()
            .DataSource = SearchList
            .DisplayMember = "County"
            .ValueMember = "Code"
            .BestFitMode = BestFitMode.BestFitResizePopup
            .SearchMode = SearchMode.AutoComplete
            .AutoSearchColumnIndex = 1
            .ShowFooter = False
            .ShowHeader = False

        End With
        Dim col2 As LookUpColumnInfoCollection = cboCategories.Columns
        col2.Add(New LookUpColumnInfo("Code", 0))
        col2.Add(New LookUpColumnInfo("County", 0))

        col2.Item(0).Visible = False

    End Sub

 
End Class