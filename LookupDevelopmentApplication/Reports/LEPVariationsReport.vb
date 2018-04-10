Imports System.Data.SqlClient
Public Class LEPVariationsReport
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LoadLEPVariations()


    End Sub

    Private Sub LoadLEPVariations()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadLEPVariations routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_LEP_VariationsListing"


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdLEPvariations.DataSource = objDT

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadLEPVariations routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click

        Me.Cursor = Cursors.WaitCursor

        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(grdLEPvariations.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

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