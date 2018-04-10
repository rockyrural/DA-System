Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository

Public Class SearchResults
    Dim SearchResults As New DataTable


    Dim Keypressed As Boolean = False

    Public WriteOnly Property DataSet() As DataTable
        Set(ByVal value As DataTable)
            SearchResults = value
        End Set
    End Property
    Dim mdlParentForm As String
    Public WriteOnly Property ParentModule() As String
        Set(ByVal value As String)
            mdlParentForm = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub



    Private Sub SetUpGrid()
        Select Case mdlParentForm
            Case "APPLICATIONFORAPPROVAL"
                '    With dgvSearch
                '        .Columns.Clear()
                '        .Columns.Add("AANo", "#")
                '        .Columns.Add("AAAppName", "Applicant Name")
                '        .Columns.Add("Address", "Address")
                '        .Columns(0).DataPropertyName = "AANo"
                '        .Columns(0).Width = 60
                '        .Columns(1).DataPropertyName = "AAAppName"
                '        .Columns(1).Width = 200
                '        .Columns(2).DataPropertyName = "Address"
                '        .Columns(2).Width = 300

                '    End With

                AddAAColumn()

            Case Else
                'With dgvSearch
                '    .Columns.Clear()
                '    .Columns.Add("DANo", "#")
                '    .Columns.Add("DAAppName", "Applicant Name")
                '    .Columns.Add("Address", "Address")
                '    .Columns(0).DataPropertyName = "DANo"
                '    .Columns(0).Width = 60
                '    .Columns(1).DataPropertyName = "DAAppName"
                '    .Columns(1).Width = 200
                '    .Columns(2).DataPropertyName = "Address"
                '    .Columns(2).Width = 300

                'End With


                AddDAColumn()

        End Select


    End Sub

    Private Sub AddDAColumn()

        gvwSearch.Columns.Clear()

        Dim column3 As New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Address", .FieldName = "address", .Width = 180}
        gvwSearch.Columns.Add(column3)
        column3.VisibleIndex = 0

        Dim column2 As New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Applicant Name", .FieldName = "DAAppName", .Width = 120}
        gvwSearch.Columns.Add(column2)
        column2.VisibleIndex = 0

        Dim column As New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "#", .FieldName = "DANo", .Width = 35}
        gvwSearch.Columns.Add(column)
        column.VisibleIndex = 0

        gvwSearch.OptionsBehavior.Editable = False
        gvwSearch.OptionsBehavior.ReadOnly = True



    End Sub


    Private Sub AddAAColumn()

        gvwSearch.Columns.Clear()

        Dim column3 As New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Address", .FieldName = "address", .Width = 180}
        gvwSearch.Columns.Add(column3)
        column3.VisibleIndex = 0

        Dim column2 As New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "Applicant Name", .FieldName = "AAAppName", .Width = 120}
        gvwSearch.Columns.Add(column2)
        column2.VisibleIndex = 0

        Dim column As New DevExpress.XtraGrid.Columns.GridColumn() With {.Caption = "#", .FieldName = "AANo", .Width = 35}
        gvwSearch.Columns.Add(column)
        column.VisibleIndex = 0


        gvwSearch.OptionsBehavior.Editable = False
        gvwSearch.OptionsBehavior.ReadOnly = True





    End Sub

    Private Sub SearchResults_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetUpGrid()


        'dgvSearch.DataSource = SearchResults
        'dgvSearch.Refresh()

        grdSearch.DataSource = SearchResults

    End Sub

    'Private Sub dgvSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSearch.Click


    '    DevelopmentStartKeep.PopulateForm(dgvSearch.CurrentRow.Cells(0).Value.ToString)

    'End Sub

    Private Sub gvwSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles gvwSearch.KeyDown

        Keypressed = False

        If e.KeyCode = Keys.Enter Then


            Dim myobj As DataRowView = CType(gvwSearch.GetFocusedRow, DataRowView)



            DevelopmentStart.PopulateForm(myobj.Row.Item("DANo").ToString)


            Keypressed = True


        End If


    End Sub

    Private Sub gvwSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles gvwSearch.KeyPress

        If Keypressed = True Then
            e.Handled = True
        End If

    End Sub

    Private Sub gvwSearch_DoubleClick(sender As Object, e As EventArgs) Handles gvwSearch.DoubleClick

        Dim myobj As DataRowView = CType(gvwSearch.GetFocusedRow, DataRowView)



        DevelopmentStart.PopulateForm(myobj.Row.Item("DANo").ToString)

    End Sub
End Class