Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns

Public Class MaintainDAUsers



    Public Sub UpdateDatasource(ByVal grid As GridControl)
        'Save the latest changes to the bound DataTable 
        Dim View As ColumnView = grid.FocusedView
        If Not (View.PostEditor() And View.UpdateCurrentRow()) Then Return

        Me.DAUserTableAdapter.Update(Me.DevelopmentAuthority.DAUser)
        gvwDAUsers.OptionsBehavior.Editable = False

    End Sub


    Private Sub MaintainDAUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DAUserTableAdapter.Fill(Me.DevelopmentAuthority.DAUser)

        gvwDAUsers.OptionsBehavior.Editable = False

    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Me.DAUserTableAdapter.Fill(Me.DevelopmentAuthority.DAUser)

        gvwDAUsers.OptionsBehavior.Editable = True

        gvwDAUsers.AddNewRow()

    End Sub



    Private Sub gvwDAUsers_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvwDAUsers.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvwDAUsers_InvalidValueException(sender As Object, e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvwDAUsers.InvalidValueException

        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        e.WindowCaption = "Input Error"
        e.ErrorText = "You MUST enter data"


    End Sub

    Private Sub gvwDAUsers_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwDAUsers.RowClick

        btnChange.Enabled = True

    End Sub






    Private Sub gvwDAUsers_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvwDAUsers.RowUpdated

        UpdateDatasource(grdDAUsers)

    End Sub

    Private Sub gvwDAUsers_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles gvwDAUsers.ValidateRow


        Dim View As GridView = CType(sender, GridView)

        Dim IDCol As GridColumn = View.Columns("LanUserID")

        Dim theID As String

        theID = View.GetRowCellValue(e.RowHandle, colLanUserID).ToString()

        If theID = String.Empty Then


            e.Valid = False

            View.SetColumnError(IDCol, "You MUST enter network logon ID")

        End If


        Dim DescriptionCol As GridColumn = View.Columns("MyUser")

        Dim theDescription As String

        theDescription = View.GetRowCellValue(e.RowHandle, colMyUser).ToString()

        If theDescription = String.Empty Then


            e.Valid = False

            View.SetColumnError(DescriptionCol, "You MUST enter User ID (network logon) description")

        End If


        Dim NameCol As GridColumn = View.Columns("FullName")

        Dim theName As String

        theName = View.GetRowCellValue(e.RowHandle, colFullName).ToString()

        If theName = String.Empty Then


            e.Valid = False

            View.SetColumnError(DescriptionCol, "You MUST enter User's full name")

        End If


    End Sub

    Private Sub gvwDAUsers_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvwDAUsers.ValidatingEditor



        Dim View As GridView = CType(sender, GridView)


        If View.FocusedColumn.FieldName = "FeeCode" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If


        If View.FocusedColumn.FieldName = "LanUserID" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If



        If View.FocusedColumn.FieldName = "FullName" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If




    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        gvwDAUsers.OptionsBehavior.Editable = True

    End Sub
End Class