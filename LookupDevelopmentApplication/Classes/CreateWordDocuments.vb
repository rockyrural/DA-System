Imports System.Data.SqlClient
Imports System.IO
Imports WORD = Microsoft.Office.Interop.Word
Module CreateWordDocuments


#Region "Word Functions"

    Friend Sub PrintAdjacentMailMerge(ByVal AppNo As String, ByVal DocType As Integer, ByVal DocName As String, ByVal docfilename As String)

        Dim objDT As New DataTable

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintSewer_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_Notification"


                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AppNo

                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using




                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintSewer_Click routine ")
            End Try
        End Using


        BuildAdjacentOwnersMergeFile(objDT)

        BuildMailMergeDocuments(AppNo, DocName, docfilename, DocType)

        RemoveOldMapData(AppNo)




    End Sub

    Private Sub RemoveOldMapData(DAno As String)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldMapData")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveOldMapMergeData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                        .ExecuteNonQuery()

                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldMapData routine  ")

            End Try
        End Using


    End Sub


    Friend Sub PrintMailMerge(ByVal AppNo As String, ByVal DocType As Integer, ByVal DocName As String, ByVal docfilename As String)

        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintSewer_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_WordTemplate_ObjectorLetters"


                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AppNo
                        .Parameters.Add("@USERID", SqlDbType.NVarChar).Value = sUserID

                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using




                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintSewer_Click routine ")
            End Try
        End Using


        BuildMergeFile(objDT)

        BuildMailMergeDocuments(AppNo, DocName, docfilename, DocType)




    End Sub


    Friend Sub PrintObjectorsMailMerge(AppNo As String, ObjDt As DataTable, email As Boolean)





        BuildObjectorMergeFile(ObjDt, email)

        BuildMailMergeDocuments(AppNo, "OAK", "H:\DB\Development\ConditionDocs\ObjectorSubmissionAcknowledgment.dotx", 54)




    End Sub

    Friend Sub BuildObjectorMergeFile(ByVal objDt As DataTable, email As Boolean)

        'Dim objDataRow As DataRow = objDt.Rows.Item(0)


        Dim objStreamWriter As StreamWriter
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt") Then _
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt")

        objStreamWriter.WriteLine("""DANO"",""DAFileNo"",""ObjectorName"",""ObjectorAddress1"",""ObjectorAddress2"",""ObjectorPostcode"",""Developmentdesc"",""PropertyDesc"",""DPNO"",""LotNo"",""Phone"",""FullName"",""Officer"",""Title""")


        If email Then


            For Each objDataRow As DataRow In objDt.Rows

                If objDataRow.Item("emailAddress").ToString <> "" Then

                    objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("DAFileNo").ToString & """,""" & objDataRow.Item("ObjectorName").ToString & ""","""  & objDataRow.Item("emailAddress").ToString & ""","""","""",""" & objDataRow.Item("DADesc").ToString & """,""" &
                                              objDataRow.Item("AddressFormatted").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString &
                                              """,""" & objDataRow.Item("Phone").ToString & """,""" & objDataRow.Item("FullName").ToString & """,""" & objDataRow.Item("Officer").ToString & """,""" & objDataRow.Item("Title").ToString & """")
                Else
                    objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("DAFileNo").ToString & """,""" & objDataRow.Item("ObjectorName").ToString & """,""" &
                                              objDataRow.Item("AuthorAddressLine1").ToString & """,""" & objDataRow.Item("AuthorAddressLine2").ToString & """,""" &
                                              objDataRow.Item("AuthorPCode").ToString & """,""" & objDataRow.Item("DADesc").ToString & """,""" &
                                              objDataRow.Item("AddressFormatted").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString &
                                              """,""" & objDataRow.Item("Phone").ToString & """,""" & objDataRow.Item("FullName").ToString & """,""" & objDataRow.Item("Officer").ToString & """,""" & objDataRow.Item("Title").ToString & """")

                End If

            Next

        Else

            For Each objDataRow As DataRow In objDt.Rows

                objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("DAFileNo").ToString & """,""" & objDataRow.Item("ObjectorName").ToString & """,""" &
                                          objDataRow.Item("AuthorAddressLine1").ToString & """,""" & objDataRow.Item("AuthorAddressLine2").ToString & """,""" &
                                          objDataRow.Item("AuthorPCode").ToString & """,""" & objDataRow.Item("DADesc").ToString & """,""" &
                                          objDataRow.Item("AddressFormatted").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString &
                                          """,""" & objDataRow.Item("Phone").ToString & """,""" & objDataRow.Item("FullName").ToString & """,""" & objDataRow.Item("Officer").ToString & """,""" & objDataRow.Item("Title").ToString & """")


            Next

        End If





        objStreamWriter.Close()





    End Sub

    Friend Sub BuildMergeFile(ByVal objDt As DataTable)

        'Dim objDataRow As DataRow = objDt.Rows.Item(0)


        Dim objStreamWriter As StreamWriter
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt") Then _
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt")

        objStreamWriter.WriteLine("""DANO"",""DAFileNo"",""ObjectorName"",""ObjectorAddress1"",""ObjectorAddress2"",""ObjectorPostcode"",""Developmentdesc"",""PropertyDesc"",""DPNO"",""LotNo"",""Phone"",""FullName"",""Officer"",""Title""")


        For Each objDataRow As DataRow In objDt.Rows

            objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("DAFileNo").ToString & """,""" & objDataRow.Item("ObjectorName").ToString & """,""" &
                                       objDataRow.Item("AuthorAddressLine1").ToString & """,""" & objDataRow.Item("AuthorAddressLine2").ToString & """,""" &
                                       objDataRow.Item("AuthorPCode").ToString & """,""" & objDataRow.Item("DADesc").ToString & """,""" &
                                       objDataRow.Item("AddressFormatted").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString &
                                       """,""" & objDataRow.Item("Phone").ToString & """,""" & objDataRow.Item("FullName").ToString & """,""" & objDataRow.Item("Officer").ToString & """,""" & objDataRow.Item("Title").ToString & """")


        Next



        objStreamWriter.Close()





    End Sub

    Friend Sub BuildMailMergeDocuments(ByVal AppNo As String, ByVal docname As String, ByVal docFileName As String, ByVal DocType As Integer)

        Dim WordDocName As String = String.Empty
        Dim sdate As String = String.Empty



        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document


        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString) Then _
             My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString)
        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM")) Then
            My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM"))
        End If


        Try

            WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & docname & "_" & AppNo.Replace("/", "_") & "_DATE_" & sdate.Replace("/", "_") & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"

            objWordDoc = objWordApp.Application.Documents.Add(Template:=(docFileName), NewTemplate:=False, DocumentType:=0)

            Threading.Thread.Sleep(2000)

            Dim newname As String = objWordDoc.Name.ToString

            objWordApp.Visible = False

            With objWordDoc


                .MailMerge.MainDocumentType = WORD.WdMailMergeMainDocType.wdFormLetters
                .MailMerge.OpenDataSource(Name:=
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt",
                    ConfirmConversions:=False, ReadOnly:=False, LinkToSource:=True,
                    AddToRecentFiles:=False, PasswordDocument:="", PasswordTemplate:="",
                    WritePasswordDocument:="", WritePasswordTemplate:="", Revert:=False,
                    Format:=WORD.WdOpenFormat.wdOpenFormatAuto, Connection:="", SQLStatement:="", SQLStatement1 _
                    :="", SubType:=WORD.WdMergeSubType.wdMergeSubTypeOther)


                .MailMerge.ViewMailMergeFieldCodes = WORD.WdConstants.wdToggle
                .MailMerge.ViewMailMergeFieldCodes = WORD.WdConstants.wdToggle

                With .MailMerge
                    .Destination = WORD.WdMailMergeDestination.wdSendToNewDocument
                    .SuppressBlankLines = True
                    With .DataSource
                        .FirstRecord = WORD.WdMailMergeDefaultRecord.wdDefaultFirstRecord
                        .LastRecord = WORD.WdMailMergeDefaultRecord.wdDefaultLastRecord
                    End With
                    .Execute(Pause:=False)

                End With



                objWordApp.ActiveDocument.SaveAs(FileName:=WordDocName.ToString, FileFormat:=
                WORD.WdSaveFormat.wdFormatXMLDocument, LockComments:=False, Password:="", AddToRecentFiles _
                :=True, WritePassword:="", ReadOnlyRecommended:=False, EmbedTrueTypeFonts _
                :=False, SaveNativePictureFormat:=False, SaveFormsData:=False,
                SaveAsAOCELetter:=False)

                .Activate()

                .Close(False)


                With objWordApp.ActiveDocument 'SB 20130612
                    .UpdateStylesOnOpen = False
                    .AttachedTemplate = ""
                    '.XMLSchemaReferences.AutomaticValidation = True
                    '.XMLSchemaReferences.AllowSaveAsXMLWithoutValidation = False
                    .Save()


                End With




            End With


            'objWordApp.Quit()

            'releaseObject(objWordDoc)

            'releaseObject(objWordApp)


            InsertRecordIntoDraftDocs(AppNo, DocType, WordDocName, Format(Today.Date, "MMM"), Year(Today.Date))


        Catch ex As Exception
            MessageBox.Show("The following error has occured in routine FileExists " & ex.InnerException.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'If Not objWordApp Is Nothing Then

            '    objWordApp.Quit()

            '    releaseObject(objWordDoc)

            '    releaseObject(objWordApp)

            'End If


        Finally

            If Not objWordApp Is Nothing Then

                objWordApp.Quit()

                releaseObject(objWordDoc)

                releaseObject(objWordApp)

            End If

        End Try


    End Sub


    Friend Sub BuildAdjacentOwnersMergeFile(ByVal objDt As DataTable)

        'Dim objDataRow As DataRow = objDt.Rows.Item(0)


        Dim objStreamWriter As StreamWriter
        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt") Then _
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\damailmerge.txt")

        objStreamWriter.WriteLine("""DANO"",  ""ObjectorName"",""ObjectorAddress1"",""ObjectorAddress2"",""Developmentdesc"",""PropertyDesc"",""ApplicantsName"",""DPNO"",""LotNo"",""AdvertisingCheck"",""DAcompleteDate"",""Officer"",""Title""")


        For Each objDataRow As DataRow In objDt.Rows

            Dim Advertising As String = String.Empty

            If objDataRow.Item("AdvertNotifCheck").ToString = "3" Then

                Advertising = "The application is also available for viewing at Council's Administration Office at Moruya between the hours of 8:30am and 4:30pm Monday to Friday."

            End If

            Dim Completed As String = String.Empty

            If Not IsDBNull(objDataRow.Item("DACompletedDt")) Then Completed = Format(CDate(objDataRow.Item("DACompletedDt").ToString), "dd MMMM yyyy")



            objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("Owners_Name").ToString & """,""" &
                                       objDataRow.Item("Owners_Addr1").ToString & """,""" & objDataRow.Item("Owners_Addr2").ToString & """,""" &
                                       objDataRow.Item("DADesc").ToString & """,""" & objDataRow.Item("AddressFormatted").ToString & """,""" &
                                       objDataRow.Item("DAAppName").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString & """,""" &
                                       Advertising & """,""" & Completed & """,""" &
                                       objDataRow.Item("FullName").ToString & """,""" & objDataRow.Item("Title").ToString & """")


        Next



        objStreamWriter.Close()





    End Sub



#End Region


    Public Sub CreateWordDocs(ByVal doctype As Integer, ByVal AppNo As String, ByVal docname As String, ByVal docfilename As String, ByVal appsys As String, Optional ByVal macroName As String = "", Optional ByVal DocCode As String = "", Optional ByVal LHead As String = "Y")


        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document


        Dim addressformat As String = String.Empty
        Dim lotformat As String = String.Empty
        Dim keepprinter As String = String.Empty
        Dim bookcode As String = String.Empty
        Dim fieldcode As String = String.Empty
        Dim fieldval As String = String.Empty
        Dim WordDocFileName As String = String.Empty
        Dim bcappno As String = String.Empty
        Dim ConsentDataExtractQueryName As String = String.Empty
        Dim CommonFieldsLinkQueryName As String = String.Empty
        Dim ConditionComponentQueryName As String = String.Empty
        Dim sdate As String = Format(Today.Date, "dd_MM_yyyy")
        Dim objDataRow As DataRow
        Dim WordDocName As String = String.Empty

        Try

            'sdate = Format(Today.Date, "dd/MM/yyyy")

            bcappno = AppNo


            Select Case appsys.ToUpper
                Case "AA"
                    ConsentDataExtractQueryName = "usp_AA_ConsentDataExtract"
                    CommonFieldsLinkQueryName = "usp_AA_CommonFieldsLink"
                    ConditionComponentQueryName = "usp_ConditionComponents_AA"
                Case "CC"
                    ConsentDataExtractQueryName = "usp_CC_ConsentDatExtract"
                    CommonFieldsLinkQueryName = "usp_CC_CommonFieldsLink"
                    ConditionComponentQueryName = "usp_ConditionComponents_CC"


                Case Else
                    ConsentDataExtractQueryName = "usp_DAConsentDataExtract"
                    CommonFieldsLinkQueryName = "usp_DA_CommonFieldsLink"
                    ConditionComponentQueryName = "usp_ConditionComponents_DA"

            End Select

            objWordApp.Visible = False

            objWordDoc = objWordApp.Application.Documents.Add(Template:=(docfilename.ToString), NewTemplate:=False)

            'Specify time to sleep in milliseconds. This pauses the application for 3 seconds
            System.Threading.Thread.Sleep(3000)



            With objWordApp

                With .ActiveDocument

                    'Retrieve the base data for this application

                    Dim objDTextract As DataTable = GetTheBaseData(ConsentDataExtractQueryName, AppNo)
                    Dim RowCount As Integer = objDTextract.Rows.Count
                    'if there is not base data then no need to continue
                    If objDTextract.Rows.Count <= 0 Then
                        Exit Sub
                    Else
                        objDataRow = objDTextract.Rows.Item(0)
                    End If


                    'Insert CommonFields---------------------------------

                    ' Get the common fields to be used to extract the data from the base data
                    Dim objDRCommonFields As DataTable = GetTheCommonFields(CommonFieldsLinkQueryName, AppNo, doctype)

                    If objDRCommonFields.Rows.Count > 0 Then
                        'Loop thru the commonfields and extract the data and populate the word document



                        For i As Integer = 0 To objDRCommonFields.Rows.Count - 1
                            fieldcode = objDRCommonFields.Rows(i).Item(0).ToString
                            bookcode = objDRCommonFields.Rows(i).Item(1).ToString
                            .Bookmarks(bookcode).Select()
                            If objDataRow.Item(fieldcode).ToString <> String.Empty Or Not IsDBNull(objDataRow.Item(fieldcode)) Then
                                .Application.Selection.Text = objDataRow.Item(fieldcode).ToString
                            End If

                        Next


                    End If

                    'END INSERT COMMON FIELDS------------------------------

                    ' OK TO HERE <<<<--------



                    'Insert Attached Conditions and headings if applicable

                    Dim objDRSTDcond As DataTable = GetConditionsAndHeadings(AppNo, doctype)


                    'Loop thru the commonfields and extract the data and populate the word document
                    If objDRSTDcond.Rows.Count > 0 Then
                        'Loop thru the commonfields and extract the data and populate the word document

                        For i As Integer = 0 To objDRSTDcond.Rows.Count - 1
                            fieldcode = objDRSTDcond.Rows(i).Item(2).ToString
                            bookcode = objDRSTDcond.Rows(i).Item(3).ToString

                            If CBool(objDRSTDcond.Rows(i).Item(5).ToString) = False Then

                                .Bookmarks(bookcode).Select()

                                If fieldcode <> String.Empty Then
                                    .Application.Selection.Text = GetOneOffCondition(CInt(fieldcode))
                                End If
                            Else
                                .Bookmarks(bookcode).Range.Select()
                                objWordApp.Selection.InsertFile(fieldcode)

                            End If

                        Next


                    End If
                    'END INSERT STD CONDITIONS-----------------------------------








                    'Insert Attached Conditions and headings if applicable -----------


                    Dim objDROneUpDcond As DataTable = GetTheCommonFields(ConditionComponentQueryName, AppNo, doctype)


                    If objDROneUpDcond.Rows.Count > 0 Then
                        'Loop thru the commonfields and extract the data and populate the word document

                        For i As Integer = 0 To objDROneUpDcond.Rows.Count - 1
                            fieldcode = objDROneUpDcond.Rows(i).Item(1).ToString
                            bookcode = objDROneUpDcond.Rows(i).Item(0).ToString
                            .Bookmarks(bookcode).Select()
                            If objDataRow.Item(fieldcode).ToString <> String.Empty Or Not IsDBNull(objDataRow.Item(fieldcode)) Then
                                .Application.Selection.Text = objDataRow.Item(fieldcode).ToString
                            End If


                        Next


                    End If


                    'END Insert Attached Conditions and headings-------------------------------



                    'Insert free-format inserts for standard conditions------------------------

                    Dim objDRFreeForm As DataTable = GetFreeFormText(AppNo, doctype)

                    'Loop thru the commonfields and extract the data and populate the word document

                    If objDRFreeForm.Rows.Count > 0 Then
                        'Loop thru the commonfields and extract the data and populate the word document

                        For i As Integer = 0 To objDRFreeForm.Rows.Count - 1
                            fieldcode = objDRFreeForm.Rows(i).Item(1).ToString
                            bookcode = objDRFreeForm.Rows(i).Item(3).ToString
                            Try
                                .Bookmarks(bookcode).Select()
                                If fieldcode.ToString <> String.Empty Then
                                    .Application.Selection.Text = fieldcode
                                End If

                            Catch ex As Exception

                            End Try

                        Next


                    End If



                    'END Insert free-format inserts for standard conditions------------------------




                    If macroName <> String.Empty Then .Application.Run(macroName)


                    If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString) Then _
                        My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString)
                    If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM")) Then
                        My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM"))
                    End If

                    WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & docname & "_" & AppNo.Replace("/", "_") & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"




                    .UpdateStylesOnOpen = False
                    .AttachedTemplate = ""



                    .SaveAs(FileName:=WordDocName.ToString, FileFormat:=
                    WORD.WdSaveFormat.wdFormatXMLDocument, LockComments:=False, Password:="", AddToRecentFiles _
                    :=True, WritePassword:="", ReadOnlyRecommended:=False, EmbedTrueTypeFonts _
                    :=False, SaveNativePictureFormat:=False, SaveFormsData:=False,
                    SaveAsAOCELetter:=False)


                    .Close(SaveChanges:=False)


                End With


            End With



            'objWordApp.Quit()

            'releaseObject(objWordDoc)

            'releaseObject(objWordApp)




            InsertRecordIntoDraftDocs(AppNo, doctype, WordDocName, Format(Today.Date, "MMM"), Year(Today.Date))



        Catch ex As Exception

            MessageBox.Show(ex.Message, " in CreateWordDocs routine in CreateWordDocuments module ")

            'If Not objWordApp Is Nothing Then

            '    objWordApp.Quit()

            '    releaseObject(objWordDoc)

            '    releaseObject(objWordApp)

            'End If

        Finally

            If Not objWordApp Is Nothing Then

                objWordApp.Quit()

                releaseObject(objWordDoc)

                releaseObject(objWordApp)

            End If



        End Try

        If WordDocName <> String.Empty Then

            If docname <> "DAACKN" Then

                Dim WRD As New OpenDocument
                WRD.OpenVisible(WordDocName)


            End If

        End If



    End Sub

    'Public Sub CreateWordToPDF(ByVal Summary As String, ByVal doctype As Integer, ByVal AppNo As String, ByVal docname As String, ByVal docfilename As String, ByVal appsys As String, Optional ByVal macroName As String = "", Optional ByVal DocCode As String = "", Optional ByVal LHead As String = "Y", Optional ByVal DisplayWord As Boolean = False)

    '    Dim objWordApp As New WORD.Application
    '    Dim objWordDoc As New WORD.Document

    '    Dim addressformat As String = String.Empty
    '    Dim lotformat As String = String.Empty
    '    Dim keepprinter As String = String.Empty
    '    Dim bookcode As String = String.Empty
    '    Dim fieldcode As String = String.Empty
    '    Dim fieldval As String = String.Empty
    '    Dim WordDocFileName As String = String.Empty
    '    Dim bcappno As String = String.Empty
    '    Dim ConsentDataExtractQueryName As String = String.Empty
    '    Dim CommonFieldsLinkQueryName As String = String.Empty
    '    Dim ConditionComponentQueryName As String = String.Empty
    '    Dim sdate As String = String.Empty
    '    Dim objDataRow As DataRow
    '    Dim strDocumentNo As String
    '    Dim strEASEdocumentName As String = String.Empty

    '    If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)


    '    Try

    '        sdate = Format(Today.Date, "dd/MM/yyyy")

    '        bcappno = AppNo


    '        Select Case appsys.ToUpper
    '            Case "AA"
    '                ConsentDataExtractQueryName = "usp_AA_ConsentDataExtract"
    '                CommonFieldsLinkQueryName = "usp_AA_CommonFieldsLink"
    '                ConditionComponentQueryName = "usp_ConditionComponents_AA"
    '            Case "CC"
    '                ConsentDataExtractQueryName = "usp_CC_ConsentDatExtract"
    '                CommonFieldsLinkQueryName = "usp_CC_CommonFieldsLink"
    '                ConditionComponentQueryName = "usp_ConditionComponents_CC"


    '            Case Else
    '                ConsentDataExtractQueryName = "usp_DAConsentDataExtract"
    '                CommonFieldsLinkQueryName = "usp_DA_CommonFieldsLink"
    '                ConditionComponentQueryName = "usp_ConditionComponents_DA"

    '        End Select


    '        objWordApp.Visible = True


    '        objWordDoc = objWordApp.Application.Documents.Add(Template:=(docfilename.ToString), NewTemplate:=False, DocumentType:=0)
    '        With objWordDoc

    '            'Retrieve the base data for this application

    '            Dim objDTextract As DataTable = GetTheBaseData(ConsentDataExtractQueryName, AppNo)
    '            Dim RowCount As Integer = objDTextract.Rows.Count
    '            'if there is not base data then no need to continue
    '            If objDTextract.Rows.Count <= 0 Then
    '                Exit Sub
    '            Else
    '                objDataRow = objDTextract.Rows.Item(0)
    '            End If


    '            'Insert CommonFields---------------------------------

    '            ' Get the common fields to be used to extract the data from the base data
    '            Dim objDRCommonFields As DataTable = GetTheCommonFields(CommonFieldsLinkQueryName, AppNo, doctype)

    '            If objDRCommonFields.Rows.Count > 0 Then
    '                'Loop thru the commonfields and extract the data and populate the word document

    '                For i As Integer = 0 To objDRCommonFields.Rows.Count - 1
    '                    fieldcode = objDRCommonFields.Rows(i).Item(0).ToString
    '                    bookcode = objDRCommonFields.Rows(i).Item(1).ToString
    '                    .Bookmarks(bookcode).Select()
    '                    If objDataRow.Item(fieldcode).ToString <> String.Empty Or Not IsDBNull(objDataRow.Item(fieldcode)) Then
    '                        .Application.Selection.Text = objDataRow.Item(fieldcode).ToString
    '                    End If

    '                Next


    '            End If

    '            'END INSERT COMMON FIELDS------------------------------

    '            ' INSERT STD CONDITIONS-----------------------------------
    '            Dim objDRSTDcond As DataTable = GetConditionsAndHeadings(AppNo, doctype)


    '            'Loop thru the commonfields and extract the data and populate the word document
    '            If objDRSTDcond.Rows.Count > 0 Then
    '                'Loop thru the commonfields and extract the data and populate the word document

    '                For i As Integer = 0 To objDRSTDcond.Rows.Count - 1
    '                    fieldcode = objDRSTDcond.Rows(i).Item(2).ToString
    '                    bookcode = objDRSTDcond.Rows(i).Item(3).ToString

    '                    If CBool(objDRSTDcond.Rows(i).Item(5).ToString) = False Then

    '                        .Bookmarks(bookcode).Select()

    '                        If fieldcode <> String.Empty Then
    '                            .Application.Selection.Text = GetOneOffCondition(CInt(fieldcode))
    '                        End If
    '                    Else
    '                        .Bookmarks(bookcode).Range.Select()
    '                        objWordApp.Selection.InsertFile(fieldcode)

    '                    End If

    '                Next


    '            End If
    '            'END INSERT STD CONDITIONS-----------------------------------




    '            'Insert Attached Conditions and headings if applicable -----------


    '            Dim objDROneUpDcond As DataTable = GetTheCommonFields(ConditionComponentQueryName, AppNo, doctype)


    '            If objDROneUpDcond.Rows.Count > 0 Then
    '                'Loop thru the commonfields and extract the data and populate the word document

    '                For i As Integer = 0 To objDROneUpDcond.Rows.Count - 1
    '                    fieldcode = objDROneUpDcond.Rows(i).Item(0).ToString
    '                    bookcode = objDROneUpDcond.Rows(i).Item(1).ToString
    '                    .Bookmarks(bookcode).Select()
    '                    If objDataRow.Item(fieldcode).ToString <> String.Empty Or Not IsDBNull(objDataRow.Item(fieldcode)) Then
    '                        .Application.Selection.Text = objDataRow.Item(fieldcode).ToString
    '                    End If

    '                Next


    '            End If



    '            'END Insert Attached Conditions and headings-------------------------------


    '            'Insert free-format inserts for standard conditions------------------------

    '            Dim objDRFreeForm As DataTable = GetFreeFormText(AppNo, doctype)

    '            'Loop thru the commonfields and extract the data and populate the word document
    '            If objDRFreeForm.Rows.Count > 0 Then
    '                'Loop thru the commonfields and extract the data and populate the word document

    '                For i As Integer = 0 To objDRFreeForm.Rows.Count - 1
    '                    fieldcode = objDRFreeForm.Rows(i).Item(0).ToString
    '                    bookcode = objDRFreeForm.Rows(i).Item(1).ToString
    '                    .Bookmarks(bookcode).Select()
    '                    If fieldcode.ToString <> String.Empty Then
    '                        .Application.Selection.Text = fieldcode
    '                    End If
    '                Next

    '            End If


    '            'END Insert free-format inserts for standard conditions------------------------




    '            If macroName <> String.Empty Then .Application.Run(macroName)

    '            If Not DisplayWord Then


    '                If LHead = "Y" Then
    '                    .PageSetup.FirstPageTray = WORD.WdPaperTray.wdPrinterUpperBin
    '                    .PageSetup.OtherPagesTray = WORD.WdPaperTray.wdPrinterLowerBin
    '                    .PrintOut(Background:=False, Copies:=2)


    '                Else
    '                    .PageSetup.FirstPageTray = WORD.WdPaperTray.wdPrinterLowerBin
    '                    .PrintOut(Background:=False, Copies:=2)
    '                End If

    '            End If

    '            strDocumentNo = GetNextDocumentNumber()
    '            strEASEdocumentName = Replace(strDocumentNo, ".", "_") & ".pdf"

    '            .ExportAsFixedFormat(OutputFileName:=LOCALRECORDFOLDER & "\" & strEASEdocumentName, ExportFormat:=WORD.WdExportFormat.wdExportFormatPDF, OpenAfterExport:=False,
    '            OptimizeFor:=WORD.WdExportOptimizeFor.wdExportOptimizeForPrint, Range:=WORD.WdExportRange.wdExportAllDocument)

    '            If DisplayWord Then
    '                objWordApp.Visible = True
    '            Else
    '                .Close(SaveChanges:=False)
    '                objWordApp.Quit()
    '            End If


    '        End With

    '        CreateEASErecord(AppNo)

    '        objWordApp.Quit()

    '        releaseObject(objWordDoc)

    '        releaseObject(objWordApp)


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, " in CreateWordToPDF routine in CreateWordDocuments module ")


    '        objWordApp.Quit()

    '        releaseObject(objWordDoc)

    '        releaseObject(objWordApp)

    '    End Try





    'End Sub


    'Private Sub CreateEASErecord(AppNo As String)



    '    Dim OwnerName As String = String.Empty
    '    Dim OwnerAddress As String = String.Empty
    '    Dim FileNo As String = String.Empty

    '    Dim objAppData As DataTable = GetMetadatForEASE(AppNo)

    '    Dim RowCount1 As Integer = objAppData.Rows.Count
    '    If objAppData.Rows.Count > 0 Then

    '        Dim objDataRow1 As DataRow = objAppData.Rows.Item(0)

    '        OwnerName = objDataRow1.Item(1).ToString
    '        OwnerAddress = objDataRow1.Item(2).ToString
    '        FileNo = objDataRow1.Item(0).ToString

    '    End If


    '    Dim fEase As New OutwardEaseCorro

    '    With fEase
    '        .CustName = OwnerName
    '        .CustAddress = OwnerAddress
    '        .FileNumber = FileNo
    '        .DocSummary = Summary & AppNo
    '        .DocumnetNo = strDocumentNo
    '        .ShowDialog()
    '        .Dispose()
    '    End With



    '    FileIO.FileSystem.MoveFile(LOCALRECORDFOLDER & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)



    '    Dim InsertDocData As New InsertDocumentData
    '    With InsertDocData
    '        .ApplicationType = appsys.ToUpper
    '        .DocumentType = doctype.ToString
    '        .ApplicationNo = AppNo
    '        .TheAuthor = MyUserId
    '        .TheImageName = Replace(strDocumentNo, ".", "_")
    '        '.Notes = txtLetterNotes.Text
    '        .InsertDocumentsIntoDAsystem()
    '    End With




    'End Sub

    Private Function GetMetadatForEASE(ByVal AppNo As String) As DataTable

        Dim result As New DataTable

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetMetadatForEASE routine - CreateWordDocuments")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveAAApplicantDataForEASE "

                        .Parameters.Add("@AANO", SqlDbType.NVarChar).Value = AppNo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    result = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetMetadatForEASE routine - CreateWordDocuments")

            End Try
        End Using


        Return result
    End Function
    Public Sub InsertRecordIntoDraftDocs(ByVal Appno As String, ByVal DocType As Integer, ByVal DraftDocPath As String, ByVal DocMth As String, ByVal docYear As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRecordIntoDraftDocs routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertDraftDocument"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Appno
                        .Parameters.Add("@PATH", SqlDbType.NVarChar).Value = DraftDocPath
                        .Parameters.Add("@DOCTYPE", SqlDbType.Int).Value = DocType
                        .Parameters.Add("@MTH", SqlDbType.NVarChar).Value = DocMth
                        .Parameters.Add("@YEAR", SqlDbType.SmallInt).Value = docYear
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRecordIntoDraftDocs routine in CreateWordDocuments module ")

            End Try
        End Using

    End Sub

    Public Sub InsertRecordIntoEGDraftDocs(ByVal Appno As String, ByVal DocType As String, ByVal DraftDocPath As String, ByVal DocMth As String, ByVal docYear As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRecordIntoDraftDocs routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertEngineeringConsentDraftDocument"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Appno
                        .Parameters.Add("@PATH", SqlDbType.NVarChar).Value = DraftDocPath
                        .Parameters.Add("@DOCTYPE", SqlDbType.NVarChar).Value = DocType
                        .Parameters.Add("@MTH", SqlDbType.NVarChar).Value = DocMth
                        .Parameters.Add("@YEAR", SqlDbType.SmallInt).Value = docYear
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertRecordIntoDraftDocs routine in CreateWordDocuments module ")

            End Try
        End Using

    End Sub


    Friend Function GetOneOffCondition(ByVal ID As Integer) As String

        Dim result As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetOneOffCondition routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetOneOffConditionText"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = ID
                        .Parameters.Add("@ONEOFFTEXT", SqlDbType.NVarChar, 3000).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = .Parameters("@ONEOFFTEXT").Value.ToString

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetOneOffCondition routine in CreateWordDocuments module ")

            End Try
        End Using
        Return result

    End Function

    Friend Function GetConditionsAndHeadings(ByVal AppNo As String, ByVal DocID As Integer) As DataTable


        Dim result As DataTable = Nothing

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DA_ConditionExtractUnion"

                        .Parameters.Add("@APPID", SqlDbType.NVarChar).Value = AppNo
                        .Parameters.Add("@DOCTYPE", SqlDbType.Int).Value = DocID
                    End With





                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    result = objDT


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine in CreateWordDocuments module")

            End Try

        End Using

        Return result
    End Function

    Friend Function GetFreeFormText(ByVal AppNo As String, ByVal DocID As Integer) As DataTable


        Dim objDatatable As DataTable = Nothing

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ConditionComponentQuery_FreeForm"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AppNo
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = DocID
                    End With





                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    objDatatable = objDT


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine in CreateWordDocuments module")

            End Try

        End Using

        Return objDatatable
    End Function

    Friend Function GetTheCommonFields(ByVal sproc As String, ByVal AppNo As String, ByVal DocType As Integer) As DataTable
        Dim objDatatable As DataTable = Nothing

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetTheBaseData routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = sproc

                        .Parameters.Add("@APPID", SqlDbType.NVarChar).Value = AppNo
                        .Parameters.Add("@DOCTYPE", SqlDbType.Int).Value = DocType
                    End With



                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    objDatatable = objDT


                End Using





            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetTheBaseData routine CreateWordDocuments module")

            End Try
        End Using

        Return objDatatable
    End Function

    Friend Function GetTheBaseData(ByVal Sproc As String, ByVal AppNo As String) As DataTable

        Dim objDatatable As DataTable = Nothing

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetTheBaseData routine in CreateWordDocuments module ")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = Sproc

                        .Parameters.Add("@APPID", SqlDbType.NVarChar).Value = AppNo
                        .Parameters.Add("@USERID", SqlDbType.NVarChar).Value = sUserID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    objDatatable = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetTheBaseData routine CreateWordDocuments module")

            End Try
        End Using

        Return objDatatable

    End Function

End Module
