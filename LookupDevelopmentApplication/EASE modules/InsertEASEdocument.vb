Imports WORD = Microsoft.Office.Interop.Word

Imports system.data.sqlclient
Public Class InsertEASEDocument

    Dim LOCALRECORDFOLDER As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\records"
#Region "Properties"
    Private DocumentLocation As String
    Public WriteOnly Property WordDocLocation() As String
        Set(ByVal value As String)
            DocumentLocation = value
        End Set
    End Property

    Private CustomersName As String
    Public WriteOnly Property CustName() As String
        Set(ByVal value As String)
            CustomersName = value
        End Set
    End Property

    Private Address As String
    Public WriteOnly Property CustAddress() As String
        Set(ByVal value As String)
            Address = value
        End Set
    End Property

    Private FileNO As String
    Public WriteOnly Property FileNumber() As String
        Set(ByVal value As String)
            FileNO = value
        End Set
    End Property

    Private DocSumm As String
    Public WriteOnly Property DocSummary() As String
        Set(ByVal value As String)
            DocSumm = value
        End Set
    End Property

    Private DocNo As String
    Public WriteOnly Property DocNumber() As String
        Set(ByVal value As String)
            DocNo = value
        End Set
    End Property

#End Region


    Private Function PrintPDFdocument() As Boolean
        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document
        'assume success
        Dim result As Boolean = True
        Dim filelocation As String = LOCALRECORDFOLDER & "\recordimage.pdf"

        Try

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor



            If My.Computer.FileSystem.DirectoryExists(LOCALRECORDFOLDER) = False Then My.Computer.FileSystem.CreateDirectory(LOCALRECORDFOLDER)


            If My.Computer.FileSystem.FileExists(filelocation) Then My.Computer.FileSystem.DeleteFile(filelocation)


            objWordDoc = objWordApp.Application.Documents.Open(DocumentLocation.ToString)


            With objWordDoc
                .Activate()
                .ExportAsFixedFormat(filelocation, WORD.WdExportFormat.wdExportFormatPDF, False, _
                WORD.WdExportOptimizeFor.wdExportOptimizeForOnScreen, _
                WORD.WdExportRange.wdExportAllDocument, 1, 1, _
                WORD.WdExportItem.wdExportDocumentContent, True, False, _
                WORD.WdExportCreateBookmarks.wdExportCreateHeadingBookmarks, False, False, False)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, " in PrintPDFdocument routine - form " & Me.Name)
            result = False

        Finally

            objWordDoc.Close(SaveChanges:=False)
            objWordApp.Quit()
            releaseObject(objWordDoc)

            releaseObject(objWordApp)

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default

        End Try
        Return result



    End Function

    Private Sub MoveTheDocument()
        Try
            If My.Computer.FileSystem.FileExists(LOCALRECORDFOLDER & "\recordimage.pdf") Then
                Dim Filename As String = EASEfunctions.CreateNewFileName(DocNo)

                My.Computer.FileSystem.MoveFile(LOCALRECORDFOLDER & "\recordimage.pdf", My.Settings.EASEOUTPUTFOLDER & Filename)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, " in PrintPDFdocument routine - form " & Me.Name)

        End Try
    End Sub

    Private Function CheckRecordExist() As Boolean
        Dim fileno As String = txtFileXref.Text
        Dim result As Boolean = True

        If txtFileXref.Text.IndexOf("/") > 0 Then _
            fileno = txtFileXref.Text.Substring(0, txtFileXref.Text.IndexOf("/"))

        Using cn As New SqlConnection(My.Settings.cnEASE)

            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in txtFileXref_Validating routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetFileDetails"

                        .Parameters.Add("@FILENUM", SqlDbType.NChar).Value = fileno
                    End With


                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.txtBarcode.Text = objDataRow.Item("PBarcode").ToString
                        Me.txtPartID.Text = objDataRow.Item("PId").ToString
                        Me.txtLocation.Text = objDataRow.Item("PCurLocId").ToString
                        Me.txtFileTitle.Text = objDataRow.Item("FTitle").ToString
                        Me.txtFileSubTitle.Text = objDataRow.Item("FSubTitle").ToString
                        result = True

                    Else
                        MessageBox.Show("File " & Me.txtFileXref.Text & " does not exist, please check and re-enter the number.", "Unable to locate file", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtBarcode.Text = String.Empty
                        Me.txtPartID.Text = String.Empty
                        Me.txtLocation.Text = String.Empty
                        Me.txtFileTitle.Text = String.Empty
                        Me.txtFileSubTitle.Text = String.Empty
                        txtFileXref.SelectAll()
                        result = False
                    End If

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in txtFileXref_Validating routine - form " & Me.Name)

            End Try
        End Using

        Return result

    End Function

    Private Sub SaveData()
        Using cn As New SqlConnection(My.Settings.cnLIMES)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_EASE_InsertNewDocument"

                        .Parameters.Add("@DOCID", SqlDbType.NVarChar).Value = DocNo
                        .Parameters.Add("@BARCODE", SqlDbType.NVarChar).Value = Me.txtBarcode.Text
                        .Parameters.Add("@SUMMARY", SqlDbType.NVarChar).Value = DocSumm
                        .Parameters.Add("@DATEWRITTEN", SqlDbType.SmallDateTime).Value = Format(Today.Date, "dd/MM/yyyy")
                        .Parameters.Add("@ACTIONOFFICER", SqlDbType.NVarChar).Value = GetEASEOfficerID()
                        .Parameters.Add("@FILENAME", SqlDbType.NVarChar).Value = DocNo.Replace(".", "_").ToString
                        .Parameters.Add("@CUSTNAME", SqlDbType.NVarChar).Value = CustomersName
                        .Parameters.Add("@CUSTADDRS", SqlDbType.NVarChar).Value = Address
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function GetEASEOfficerID() As Integer
        Dim result As Integer
        Using cn As New SqlConnection(My.Settings.cnLIMES)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_EASE_GetEASEOfficerID"

                        .Parameters.Add("@LANDID", SqlDbType.NVarChar).Value = My.User.Name.Substring(4)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            result = CInt(objDataReader.Item(0))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using
        Return result

    End Function

    Private Sub txtFileXref_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFileXref.Validating
        If Not CheckRecordExist() Then e.Cancel = True

    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtFileXref.Text.Length = 0 Then Exit Sub
        Dim cancel As Boolean = CheckRecordExist()

    End Sub

    Private Sub btnAttachDocument_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAttachDocument.Click
        Try
            SaveData()
            PrintPDFdocument()
            MoveTheDocument()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, " in PrintPDFdocument routine - form " & Me.Name)

        End Try
    End Sub

    Private Sub InsertEASEdocument_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtFileXref.Text = FileNO
    End Sub
End Class