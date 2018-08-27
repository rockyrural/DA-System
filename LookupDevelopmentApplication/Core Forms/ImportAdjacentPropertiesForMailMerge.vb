Imports System.Data.SqlClient
Imports System.IO

Public Class ImportAdjacentPropertiesForMailMerge

    Private fileName As String = String.Empty
    Private MapMergeRan As Boolean = False

    Private DANo As String
    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DANo = value
        End Set
    End Property


    Public ReadOnly Property FileGenerated() As Boolean
        Get
            Return MapMergeRan
        End Get
    End Property

    Private Sub RemoveOldMapData()


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldMapData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveOldMapMergeData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldMapData routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub InsertMapMergData()
        Dim Ok As Boolean = True ' Assume success

        Dim CadId As String=string.empty
        Dim PIN As Integer
        Dim PropertyAddress As String = String.Empty
        Dim Lot As String = String.Empty
        Dim Section As String = String.Empty
        Dim DP As String = String.Empty
        Dim StreetNo As String = String.Empty
        Dim Street As String = String.Empty
        Dim name As String = String.Empty
        Dim Suburb As String = String.Empty
        Dim postcode As String = String.Empty
        Dim Owner As String = String.Empty
        Dim address As String = String.Empty
        Dim town As String = String.Empty

 
        Dim csvData As String = File.ReadAllText(bedtMergeFile.Text)

        For Each row As String In csvData.Split(ControlChars.Lf)

            If Not String.IsNullOrEmpty(row) And row.Trim <> ",,,,,,,," Then

                If row.Substring(0, 3) <> "Cad" Then


                    Dim i As Integer = 1

                    For Each cell As String In row.Split(","c)

                        Select Case i

                            Case 1:CadId=cell

                            Case 2:PIN=cell

                            Case 3:PropertyAddress=cell.Replace("""","")

                            Case 4:Lot=cell.Replace("""","")

                            Case 5:Section=cell.Replace("""","")

                            Case 6:DP=cell.Replace("""","")

                            Case 7:StreetNo=cell.Replace("""","")

                            Case 8:Street=cell.Replace("""","")

                            Case 9:Suburb=cell.Replace("""","")

                            Case 10:postcode=cell.Replace("""","")

                            Case 11:Owner=cell.Replace("""","")

                            Case 12 : address=cell.Replace("""","")

                            Case 13 : town=cell.Replace("""","")

                        End Select

                        i += 1

                    Next

                    InsertMapMergDataExtracted(Owner, address, town, pin)

                End If


            End If



        Next


        'My.Computer.FileSystem.DeleteFile(bedtMergeFile.Text)



    End Sub
    Private Sub InsertMapMergDataExtracted(ByVal name As String, ByVal address As String, ByVal town As String, ByVal tag As Integer)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertMapMergData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Insert_Into_MapMerge"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@NAME", SqlDbType.NVarChar).Value = name
                        .Parameters.Add("@ADDRS", SqlDbType.NVarChar).Value = address
                        .Parameters.Add("@TOWN", SqlDbType.NVarChar).Value = town'.substring(0,town.length-1)
                        .Parameters.Add("@TAG", SqlDbType.Int).Value = tag
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertMapMergData routine - form " & Me.Name)

            End Try
        End Using
    End Sub


    Private Sub bedtMergeFile_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bedtMergeFile.ButtonClick

        Dim OpenFile As New OpenFileDialog

        With OpenFile
            .Title = "SELECT MERGE DATA"
            .Filter = "csv files (*.csv)|*.csv"
        End With

        If (OpenFile.ShowDialog) = DialogResult.OK Then

            bedtMergeFile.Text = OpenFile.FileName.ToString

            btnRun.Enabled = True

        Else

            btnRun.Enabled = False


        End If

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        RemoveOldMapData()
        InsertMapMergData()
        MapMergeRan = True

        DialogResult=DialogResult.OK

    End Sub
End Class