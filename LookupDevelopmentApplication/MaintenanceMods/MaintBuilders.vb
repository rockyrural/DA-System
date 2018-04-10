Imports System.Collections
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class MaintainBuilders

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DevelopmentSQLDataSet.PCA_Builder_Names' table. You can move, or remove it, as needed.
        Me.PCA_Builder_NamesTableAdapter.Fill(Me.DevelopmentSQLDataSet.PCA_Builder_Names)
        Me.PCA_Builder_namesTableAdapter.Fill(Me.DevelopmentSQLDataSet.PCA_Builder_Names)



        Dim AreaDescription As New ArrayList

        ' Add division structure entries to the arraylist
        With AreaDescription
            .Add(New AreaType("B", "B"))
            .Add(New AreaType("P", "P"))
            .Add(New AreaType("PL", "PL"))
        End With

        With cboNameType
            .DataSource = AreaDescription
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim col2 As LookUpColumnInfoCollection = cboNameType.Columns
        col2.Add(New LookUpColumnInfo("Name", 0))
        col2.Add(New LookUpColumnInfo("Key", 0))

        col2.Item(1).Visible = False

        gvwBuilders.OptionsBehavior.Editable = False
        gvwBuilders.OptionsBehavior.ReadOnly = True


    End Sub



    Public Sub UpdateBuilderDatasource(ByVal grid As GridControl)

        Me.PCA_Builder_namesTableAdapter.Update(Me.DevelopmentSQLDataSet.PCA_Builder_Names)


        gvwBuilders.OptionsBehavior.Editable = False
        gvwBuilders.OptionsBehavior.ReadOnly = True

        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True


    End Sub




    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        gvwBuilders.OptionsBehavior.Editable = True
        gvwBuilders.OptionsBehavior.ReadOnly = False
        gvwBuilders.AddNewRow()

        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnEdit.Enabled = False

    End Sub
    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        gvwBuilders.OptionsBehavior.Editable = True
        gvwBuilders.OptionsBehavior.ReadOnly = False

        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = True

    End Sub
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        UpdateBuilderDatasource(grdBuilders)


        btnSave.Enabled = False
        btnAdd.Enabled = True
        btnEdit.Enabled = True

    End Sub

    Private Sub gvwBuilders_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs) Handles gvwBuilders.ValidatingEditor


        Dim View As GridView = CType(sender, GridView)


        If View.FocusedColumn.FieldName = "Name" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If



        If View.FocusedColumn.FieldName = "NameType" Then

            If e.Value.ToString.Trim = "" Then

                e.Valid = False

            End If



        End If



    End Sub

    Private Sub gvwBuilders_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles gvwBuilders.ValidateRow


        Dim View As GridView = CType(sender, GridView)

        Dim BotCol As GridColumn = View.Columns("Name")

        Dim theName As String

        theName = View.GetRowCellValue(e.RowHandle, colName).ToString()

        If theName = String.Empty Then


            e.Valid = False

            View.SetColumnError(BotCol, "You enter a builder Name")

        End If


        Dim ESCCatCol As GridColumn = View.Columns("NameType")



        theName = View.GetRowCellValue(e.RowHandle, colNameType).ToString()

        If theName = String.Empty Then


            e.Valid = False

            View.SetColumnError(ESCCatCol, "You select a name type")

        End If
    End Sub

    Private Sub gvwBuilders_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles gvwBuilders.RowUpdated

        UpdateBuilderDatasource(grdBuilders)

    End Sub

    Private Sub gvwBuilders_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwBuilders.RowClick

        btnEdit.Enabled = True

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Me.Cursor = Cursors.WaitCursor

        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdBuilders.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

        Dim saveData As New SaveFileDialog
        Dim myStream As System.IO.Stream

        With saveData
            .Filter = "Excel files (*.xlsx)|*.xlsx"
            .RestoreDirectory = True
            If .ShowDialog = DialogResult.OK Then
                myStream = .OpenFile

                If Not View Is Nothing Then
                    View.OptionsPrint.ExpandAllDetails = True
                    View.ExportToXlsx(myStream)
                    'View.ExportToPdf("MainViewData.pdf")
                End If


                If (myStream IsNot Nothing) Then

                    myStream.Close()
                End If

            End If

        End With

        Me.Cursor = Cursors.Default

    End Sub
End Class
