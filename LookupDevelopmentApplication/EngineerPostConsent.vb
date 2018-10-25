Imports system.data.sqlclient
Imports System.IO
Imports WORD = Microsoft.Office.Interop.Word

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared


Public Class EngineerPostConsent

    Private Const iDANO As Integer = 0
    Private Const iADDRESS As Integer = 1
    Private Const iPLANNO As Integer = 2
    Private Const ID As Integer = 3
    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private isloading As Boolean

    Private DANo As String '= "1055/03"
    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DANo = value
        End Set
    End Property

#Region "Word Functions"


    Private Sub PrintEngineeringLetter(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer, ByVal DocType As String)

        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document

        Dim WordDocName As String = String.Empty
        Dim LetterName As String = String.Empty

        Dim sdate As String = Format(Today.Date, "dd_MM_yyyy")

        Dim documentType As String = String.Empty


        Try

            If objDtable.Rows.Count > 0 Then


                Dim objDataRow As DataRow = objDtable.Rows.Item(0)

                Select Case DocType

                    Case "EGAQ"

                        'WordDocName = My.Settings.DraftDocumentsFolder & "EGSubFeesAck Letter_" & lblEngDetNo.Text & ".docx"
                        WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & "EGSubFeesAck Letter_" & lblEngDetNo.Text & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"

                        documentType = "Engineering acknowledgement quoting fees"
                        LetterName = "EngConsentSubAcknQuoteFees.dotx"

                    Case "EGAL"
                        'WordDocName = My.Settings.DraftDocumentsFolder & "EGSubFeesAckLSL Letter_" & lblEngDetNo.Text & ".docx"
                        WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & "EGSubFeesAckLSL Letter_" & lblEngDetNo.Text & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"

                        documentType = "Engineering acknowledgement quoting fees and LSL"
                        LetterName = "EngConsentSubAcknowledeQuoteLSL.dotx"


                    Case "EGAP"

                    Case "EGAI"

                        'WordDocName = My.Settings.DraftDocumentsFolder & "EGInterimSubFeesAck Letter_" & lblEngDetNo.Text & ".docx"
                        WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & "EGInterimSubFeesAck Letter_" & lblEngDetNo.Text & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"

                        documentType = "Engineering interim Fees acknowledgment"
                        LetterName = "EngInterimSubFeesAckn.dotx"


                    Case "EGRP"

                End Select


                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString) Then _
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString)
                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM")) Then
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM"))
                End If




                objWordDoc = objWordApp.Application.Documents.Add(Template:=(My.Settings.ConstructionCertificates & LetterName), NewTemplate:=False, DocumentType:=0)

                Dim newname As String = objWordDoc.Name.ToString



                With objWordApp

                    .Visible = True


                    .ActiveDocument.Bookmarks("FileNo").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("DAFileNo").ToString

                    .ActiveDocument.Bookmarks("CCConsultant").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultant").ToString



                    .ActiveDocument.Bookmarks("CCConsultantAdd").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultantAdd").ToString

                    .ActiveDocument.Bookmarks("CCConsultantTown").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultantTown").ToString

                    .ActiveDocument.Bookmarks("CCConsultantPCode").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCConsultantPCode").ToString

                    .ActiveDocument.Bookmarks("DANo").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("DANo").ToString

                    .ActiveDocument.Bookmarks("CCEstate").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("CCEstate").ToString

                    .ActiveDocument.Bookmarks("Description").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("Description").ToString

                    .ActiveDocument.Bookmarks("CCPlanNo").Select()
                    .Application.Selection.Text = objDataRow.Item("CCPlanNo").ToString

                    .ActiveDocument.Bookmarks("PlanSet").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("PlanSet").ToString

                    If DocType <> "EGAI" Then

                        If Not IsDBNull(objDataRow.Item("OriginalSubmissionDate")) Then

                            .ActiveDocument.Bookmarks("SubMissionDate").Select()
                            .ActiveDocument.Application.Selection.Text = Format(CDate(objDataRow.Item("OriginalSubmissionDate")), "dd MMMM, yyyy")

                        End If


                        .ActiveDocument.Bookmarks("CCPlanNo2").Select()
                        .Application.Selection.Text = objDataRow.Item("CCPlanNo")

                        .ActiveDocument.Bookmarks("PlanSet2").Select()
                        .ActiveDocument.Application.Selection.Text = objDataRow.Item("PlanSet").ToString


                        .ActiveDocument.Bookmarks("LinealText").Select()

                        Dim LinearText As String = String.Empty

                        If CInt(objDataRow.Item("CCLinealMetres")) > 0 Then

                            LinearText = "The plans submitted indicate sewer and/or water design to service " & objDataRow.Item("CCLotsCreated").ToString & " lots and a total road length of " & objDataRow.Item("CCLinealMetres").ToString & " metres."

                        Else

                            LinearText = "The plans submitted indicate sewer and/or water design to service " & objDataRow.Item("CCLotsCreated").ToString & " lots."

                        End If


                        .ActiveDocument.Application.Selection.Text = LinearText

                    End If

                    .ActiveDocument.Bookmarks("Officer").Select()
                    .ActiveDocument.Application.Selection.Text = objDataRow.Item("EGOfficer").ToString



                    Dim tablecell As Integer = 1
                    Dim tablerow As Integer = 2
                    '.Application.Activate()
                    Dim ObjDT As DataTable = SubReportData(CInt(lblEngDetNo.Text))

                    Dim RowCount As Integer = ObjDT.Rows.Count
                    'if there is not base data then no need to continue
                    Dim GrandTotal As Double

                    If ObjDT.Rows.Count > 0 Then

                        For i As Integer = 0 To ObjDT.Rows.Count - 1


                            GrandTotal = CDbl(ObjDT.Rows(i).Item("TotalDue"))

                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("Payment")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("Payment").ToString & vbCrLf & ObjDT.Rows(i).Item("GLAccount").ToString
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord
                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)


                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeQuant")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("ChargeQuant").ToString
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)



                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeUnitDesc")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("ChargeUnitDesc").ToString
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)



                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeMultiplier")) Then
                                .Application.Selection.Text = Format(ObjDT.Rows(i).Item("ChargeMultiplier"), "Currency")
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeAmt")) Then
                                .Application.Selection.Text = Format(ObjDT.Rows(i).Item("ChargeAmt"), "Currency")
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If
                            tablecell += 1
                            .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                            .ActiveDocument.Tables(1).Cell(tablerow, tablecell).Select()
                            If Not IsDBNull(ObjDT.Rows(i).Item("ChargeRef")) Then
                                .Application.Selection.Text = ObjDT.Rows(i).Item("ChargeRef")
                                .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                            End If



                            If i <> RowCount - 1 Then .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                            If tablecell = 6 Then tablecell = 1
                            tablerow += 1
                        Next




                    End If



                    .ActiveDocument.Bookmarks("GrandTotal").Select()
                    .ActiveDocument.Application.Selection.Text = Format(GrandTotal, "Currency")


                    With .ActiveDocument
                        .UpdateStylesOnOpen = False
                        .AttachedTemplate = ""
                        '.XMLSchemaReferences.AutomaticValidation = True
                        '.XMLSchemaReferences.AllowSaveAsXMLWithoutValidation = False
                    End With

                    .ActiveDocument.SaveAs(FileName:=WordDocName.ToString, FileFormat:= _
                    WORD.WdSaveFormat.wdFormatXMLDocument, LockComments:=False, Password:="", AddToRecentFiles _
                    :=True, WritePassword:="", ReadOnlyRecommended:=False, EmbedTrueTypeFonts _
                    :=False, SaveNativePictureFormat:=False, SaveFormsData:=False, _
                    SaveAsAOCELetter:=False)

                    .ActiveDocument.Close(SaveChanges:=False)

                End With
                'PopulateTable(WordDocName.ToString)


                objWordApp.Quit()

                releaseObject(objWordDoc)

                releaseObject(objWordApp)



                InsertRecordIntoEGDraftDocs(lblEngDetNo.Text, documentType, WordDocName, Format(Today.Date, "MMM"), Year(Today.Date))


                DisplayListOfDraftDocuments()

                Dim WRD As New OpenDocument
                WRD.OpenVisible(WordDocName)

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, " in LoadSeizedItems routine - form " & Me.Name)
            objWordApp.Quit()

            releaseObject(objWordDoc)
            releaseObject(objWordApp)

        End Try

    End Sub

    Private Sub DisplayListOfDraftDocuments()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DisplayListOfEGDraftDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblEngDetNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvDraftDocs.DataSource = objDT
                    dgvDraftDocs.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Me.Name)

            End Try
        End Using



    End Sub




    Private Function SubReportData(ByVal InspectionID As Integer) As DataTable

        Dim objReturn As New DataTable

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
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

                        .CommandText = "usp_rpt_EGFeesSubReport"
                        .Parameters.Add("@INSPECTID", SqlDbType.Int).Value = InspectionID
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objReturn.Load(objDataReader)
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        Return objReturn


    End Function


#End Region





    Private Sub LoadSearchList()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ENG_Listing"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    isloading = True


                    Me.lstSearchResults.DataSource = objDT
                    Me.lstSearchResults.DisplayMember = "DANo"
                    Me.lstSearchResults.ValueMember = "EngDetNo"
                    isloading = False
                    Me.lstSearchResults.SelectedItem = 0




                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSearchList routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private Sub EngineerPostConsent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        LoadSearchList()



        Me.ChargeUnitTableAdapter.Fill(Me.ComplianceDataSet.ChargeUnit)
         Me.EngEventStatusTableAdapter.Fill(Me.ComplianceDataSet.EngEventStatus)
        Me.EngEventTypeTableAdapter.Fill(Me.ComplianceDataSet.EngEventType)
        Me.OfficerTableAdapter.Fill(Me.DAdatasets.Officer)
        Me.FileNoteTypeTableAdapter.Fill(Me.DAdatasets.FileNoteType)
        Me.ReferralCodeTableAdapter.Fill(Me.DAdatasets.ReferralCode)
        Me.cboNotesOfficer.SelectedIndex = -1
        Me.cboNoteType.SelectedIndex = -1
        Me.cboRefCodeId.SelectedIndex = -1
        Me.cboReferralsIntProvision.SelectedIndex = -1
        EngEventTypeExtendedComboBox.SelectedIndex = -1
        Me.EngEventStatusExtendedComboBox.SelectedIndex = -1



        Dim RFS As New ArrayList

        ' Add division structure entries to the arraylist
        With RFS
            .Add(New RFSSubvisionType("Residential", "2"))
            .Add(New RFSSubvisionType("Rural", "1"))
        End With

        With cboRFSSubDivisionType
            .DataSource = RFS
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = -1
        End With



        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in EngineerPostConsent_Load routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrievePlanDetails"

                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            cboPlanNo.Items.Add(New Plan(objDataReader("Plan Number").ToString, objDataReader("Set").ToString, objDataReader("Job Title").ToString, objDataReader("Description").ToString, objDataReader("Street").ToString))
                        Loop
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in EngineerPostConsent_Load routine - form " & Me.Name)

            End Try
        End Using


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DALookup_Load routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadCreateLetterListBox"
                        .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = "EG"

                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            cboLetterType.Items.Add(New DocumentTypeListing(objDataReader("DocumentType").ToString, objDataReader("DocumentDescription").ToString, objDataReader("ReportName").ToString))
                        Loop
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DALookup_Load routine - form " & Me.Name)

            End Try
        End Using
        'LoadForm(DANo)
        btnAddCC.Enabled = Administration



        'If DANo <> String.Empty Then
        '    lstSearchResults.Enabled = False
        '    Me.btnAddCC.Enabled = Administration
        'Else
        '    lstSearchResults.Enabled = True
        'End If
        'btnAddCC.Enabled = True
        'btnEditDA.Enabled = True
        'btnSaveDA.Enabled = False

        If ViewOnly Then
            LockAccessIfViewOnly(Me)

        End If

    End Sub

#Region "Documents Tab"
    Private Sub dgvDocumentsList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDocumentsList.CellClick
        If IsANonHeaderButtonCell(e) Then
            DisplayPDFdocument()
        ElseIf IsANonHeaderTextCell(e) Then
            txtDocNote.Text = dgvDocumentsList.CurrentRow.Cells(6).Value.ToString
            Me.btnRemoveDocument.Enabled = True

        End If

    End Sub

    Private Function IsANonHeaderTextCell(ByVal cellEvent As _
          DataGridViewCellEventArgs) As Boolean
        If cellEvent.ColumnIndex = -1 Then Exit Function
        If TypeOf dgvDocumentsList.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewTextBoxColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
            Return True Else Return (False)

    End Function

    Private Function IsANonHeaderButtonCell(ByVal cellEvent As _
        DataGridViewCellEventArgs) As Boolean
        If cellEvent.ColumnIndex = -1 Then Exit Function
        If TypeOf dgvDocumentsList.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
            Return True Else Return (False)

    End Function

    Private Sub clearThePanel(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is combobox Then
                Dim cb As combobox = DirectCast(ctrl, combobox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty

            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked

            End If
        Next
    End Sub

    Private Sub DisplayPDFdocument()

        If dgvDocumentsList.CurrentRow.Cells(2).Value.ToString = String.Empty Then Exit Sub
        Dim sDocname As String = dgvDocumentsList.CurrentRow.Cells(2).Value.ToString
        Dim sMTH As String = dgvDocumentsList.CurrentRow.Cells(7).Value.ToString
        Dim sYr As String = dgvDocumentsList.CurrentRow.Cells(8).Value.ToString
        Dim sPDFDoc As String = String.Empty


        If sDocname.Length <= 8 Then
            Dim YeartoCheck As String = "20" & sDocname.Substring(InStr(sDocname, "_"), 2)
            If CLng(YeartoCheck) <> Today.Year Then
                sPDFDoc = My.Settings.ARCHIVE & BuildYear(sDocname) & FolderHash(sDocname) & ImageFileName(sDocname)

            Else
                sPDFDoc = My.Settings.HASHBIN & BuildYear(sDocname) & FolderHash(sDocname) & ImageFileName(sDocname)

            End If


        ElseIf sDocname.Length <> 0 Then
            If CLng(sYr) = Today.Year Then
                sPDFDoc = My.Settings.HASHBIN & sYr & "\" & sMTH & "\" & sDocname

            Else
                sPDFDoc = My.Settings.ARCHIVE & sYr & "\" & sMTH & "\" & sDocname

            End If

        End If

        If sPDFDoc <> String.Empty Then
            Dim PDFviewer As New PDFviewer
            With PDFviewer
                .DocumentToDisplay = sPDFDoc
                .ShowDialog()
                .Dispose()
            End With
        End If


    End Sub



#End Region

    Private Sub LoadForm(ByVal EngNumber As Integer)

        If Me.btnSaveDA.Enabled Then
            If MessageBox.Show("It appears you have made changes to this application. Save changes before exiting?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                btnSaveDA_ClickExtracted()
            End If
        End If

        ClearData(pnlTop)

        Try
            Me.EngPostConsentTableAdapter.Fill(Me.ComplianceDataSet.EngPostConsent, EngNumber)

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, EngNumber, "EG")
            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, EngNumber, "EG")
            Me.RetrieveFileNotesTableAdapter.Fill(Me.DAdatasets.RetrieveFileNotes, EngNumber, "EG")
            Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, EngNumber, "EG")
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "EG", EngNumber)
            Me.RetrieveEngineeringTimeLineTableAdapter.Fill(Me.ComplianceDataSet.RetrieveEngineeringTimeLine, EngNumber)
            Me.ENG_ChargesTableAdapter.Fill(Me.ComplianceDataSet.ENG_Charges, EngNumber)

            LoadSection94(DANo)

            'Me.Engineer_Section94ContributionsTableAdapter.Fill(Me.ComplianceDataSet.Engineer_Section94Contributions, DANo)
            'Me.DASummaryDataTableAdapter.Fill(Me.DAdatasets.DASummaryData, DANo)

            LoadDASummaryData(DANo)

            Me.ChargeTransactionsTableAdapter.Fill(Me.ComplianceDataSet.ChargeTransactions, EngNumber)
            CalculateRefundsandPayments(EngNumber)
            Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, DANo, "EG")


            If ComplianceDataSet.ENG_Charges.Rows.Count > 0 Then
                Dim sumAmt As Double
                Dim objDataRow As DataRow = ComplianceDataSet.ENG_Charges.Rows.Item(0)
                For count As Integer = 0 To ComplianceDataSet.ENG_Charges.Rows.Count - 1

                    sumAmt += CDbl(objDataRow.Item("Amount"))
                Next

                Me.txtBalanceOS.Text = Format(sumAmt, "Currency")

            End If

            If ComplianceDataSet.Engineer_Section94Contributions.Rows.Count > 0 Then
                Dim sumAmt As Double

                Dim objDataRow As DataRow = ComplianceDataSet.Engineer_Section94Contributions.Rows.Item(0)
                For count As Integer = 0 To ComplianceDataSet.Engineer_Section94Contributions.Rows.Count - 1

                    sumAmt += CDbl(objDataRow.Item("BalanceOS"))
                Next

                Me.txtTotalOS.Text = Format(sumAmt, "Currency")

            End If
            Me.txtDAno.Text = DANo
            DisplayListOfDraftDocuments()

            cboLetterType.Enabled = True

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub LoadDASummaryData(ByVal DANo As String)



        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .CommandText = "usp_DASummaryData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read

                            txtPIN.Text = objDataReader.Item("PIN").ToString
                            txtDAPropNo.Text = objDataReader.Item("DAPropNo").ToString
                            If Not IsDBNull(objDataReader.Item("DADetermDt")) Then txtDADetermDt.Text = Format(CDate(objDataReader.Item("DADetermDt")), "dd/MM/yyyy")
                            txtDALot.Text = objDataReader.Item("DALot").ToString
                            txtDADP.Text = objDataReader.Item("DADP").ToString
                            txtDASection.Text = objDataReader.Item("DASection").ToString
                            txtDAAddress.Text = objDataReader.Item("Address").ToString
                            txtDAOwnersName.Text = objDataReader.Item("DAOwnersName").ToString
                            txtDAStatus.Text = objDataReader.Item("DADecision").ToString
                            txtDAFileNo.Text = objDataReader.Item("DAFileNo").ToString
                            txtDAofficer.Text = objDataReader.Item("Officer").ToString
                            txtDAno.Text = objDataReader.Item("DANo").ToString
                            txtDADesc.Text = objDataReader.Item("DADesc").ToString



                        Loop
                    End Using




                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using




    End Sub
    Private Sub LoadSection94(ByVal DANo As String)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94 routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Engineer_Section94Contributions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvSection94Contributions.DataSource = objDT
                    dgvSection94Contributions.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94 routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        datefield.Text = TheNewDate

    End Sub

    Private Sub btnOriginalSubmissionDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOriginalSubmissionDate.Click
        RetrieveDate(OriginalSubmissionDate)

    End Sub


    Private Sub btnRequisitionLetterDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequisitionLetterDate.Click
        RetrieveDate(RequisitionLetterDate)
    End Sub

    Private Sub btnLinenReleasedDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLinenReleasedDate.Click
        RetrieveDate(LinenReleasedDate)
    End Sub

    Private Sub btnSignedPlansDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSignedPlansDate.Click
        RetrieveDate(SignedPlansDate)
    End Sub

    Private Sub btnNewDPRegistrationDate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewDPRegistrationDate.Click
        RetrieveDate(NewDPRegistrationDate)
    End Sub

    Private Sub btnFindDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindDP.Click
        Dim openFileDialog1 As New OpenFileDialog()

        With openFileDialog1
            .Title = "This is used to attach the Deposit Plan"
            .InitialDirectory = "\\fs\common\gis\lto\"
            .Filter = "TIF files (*.tif)|*.tif"
            .FilterIndex = 1
            .RestoreDirectory = True
            .ShowDialog()
            If .FileName <> String.Empty Then
                NewDPImagePathTextBox.Text = .FileName.ToString
            End If
        End With
    End Sub

    Private Sub btnViewDp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDp.Click
        Dim x As Integer
        If Not IO.Directory.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview") Then
            IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview")
        End If


        If NewDPImagePathTextBox.Text <> String.Empty Then
            IO.File.Copy(NewDPImagePathTextBox.Text, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif", True)
            Dim folderTolookat As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif"
            x = Shell("c:\windows\system32\rundll32.exe c:\windows\system32\shimgvw.dll,ImageView_Fullscreen " & folderTolookat) 'DPFolderLocation & DepositedPlan)
        Else
            MessageBox.Show("Unable to find a DP file, it may not be linked, see Heidi ", "Unable to display plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub CalculateRefundsandPayments(ByVal dano As String)

        Dim Receipt As String = String.Empty
        Dim Refund As String = String.Empty
        Dim difference As String = String.Empty

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateRefundsandPayments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_TotalPaymentandRefunds"
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = dano
                        .Parameters.Add("@SYSID", SqlDbType.VarChar).Value = "EG"

                        .Parameters.Add("@TOTALREFUNDS", SqlDbType.Money).Direction = ParameterDirection.Output
                        .Parameters.Add("@TOTALPAYMENTS", SqlDbType.Money).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        Receipt = .Parameters("@TOTALPAYMENTS").Value.ToString
                        Refund = .Parameters("@TOTALREFUNDS").Value.ToString
                        difference = CStr(NZ(Receipt) - NZ(Refund))
                    End With


                End Using
                 
                Me.txtReceipts.Text = Format(Receipt, "currency")
                Me.txtRefunds.Text = Format(Refund, "currency")
                Me.txtDifference.Text = Format(difference, "currency")


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateRefundsandPayments routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnViewPlans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewPlans.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Dim FileToView As String = String.Empty
        Dim x As Integer

        With openFileDialog1
            .Title = "This is used to attach the Deposit Plan"
            .InitialDirectory = "\\fs\common\gis\lto\"
            .Filter = "TIF files (*.tif)|*.tif"
            .FilterIndex = 1
            .RestoreDirectory = True
            .ShowDialog()
            If .FileName <> String.Empty Then
                FileToView = .FileName.ToString
            End If

        End With



        If FileToView <> String.Empty Then
            IO.File.Copy(FileToView, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif", True)
            Dim folderTolookat As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DPtoview\depositplan.tif"
            x = Shell("c:\windows\system32\rundll32.exe c:\windows\system32\shimgvw.dll,ImageView_Fullscreen " & folderTolookat) 'DPFolderLocation & DepositedPlan)
        Else
            MessageBox.Show("Unable to find a DP file, it may not be linked, see Heidi ", "Unable to display plan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub btnEditPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPayment.Click
        Try

            Dim fFee As New AddPayment

            With fFee
                .TheSystemType = "EG"
                .IndexID = CInt(PaymentsReceivedDataGridView.CurrentRow.Cells(7).Value)
                .AppID = Me.lblEngDetNo.Text
                .PayId = CShort(PaymentsReceivedDataGridView.CurrentRow.Cells(6).Value)
                .ShowDialog()
                .Dispose()
            End With

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, lblEngDetNo.Text, "EG")
            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub btnAddFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFee.Click
        Try

            Dim fFee As New AddPayment

            With fFee

                .TheSystemType = "EG"
                .IndexID = 0
                .AppID = Me.lblEngDetNo.Text
                .ShowDialog()
                .Dispose()
            End With

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, lblEngDetNo.Text, "EG")
            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub btnEditRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRefund.Click
        Try

            Dim fFee As New AddRefund

            With fFee

                .TheSystemType = "EG"
                .AppID = lblEngDetNo.Text
                .IDindex = CInt(DARefundsPaidDataGridView.CurrentRow.Cells(6).Value)
                .PayId = CShort(DARefundsPaidDataGridView.CurrentRow.Cells(5).Value)
                .ShowDialog()
                .Dispose()
            End With

            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, lblEngDetNo.Text, "EG")
            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefund.Click
        Try

            Dim fFee As New AddRefund

            With fFee

                .TheSystemType = "EG"
                .AppID = Me.lblEngDetNo.Text
                .ShowDialog()
                .Dispose()
            End With

            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, lblEngDetNo.Text, "EG")
            CalculateRefundsandPayments(lblEngDetNo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub





    'Public Sub CheckForRecords()
    '    'Initialize a new instance of the data access base class
    '    Dim objDS As New DataSet
    '    Dim objDA As New SqlDataAdapter

    '    objDS.Tables.Add("results")

    '    Dim Search As Integer
    '    Using cn As New SqlConnection(My.Settings.DataConnection)
    '        Try
    '            cn.Open()
    '        Catch sqlExceptionErr As SqlException
    '            Throw New System.Exception(sqlExceptionErr.Message, _
    '            sqlExceptionErr.InnerException)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_EngSearch"
    '                    .Parameters.Add("@SEARCHTYPE", SqlDbType.Int)
    '                    .Parameters.Add("@SEARCHFOR", SqlDbType.VarChar, 20).Value = Me.txtSearch.Text


    '                    Select Case cboSearchType.Text.ToUpper.Trim
    '                        Case "DA NUMBER"
    '                            ' Set command properties
    '                            LoadForm(txtSearch.Text)
    '                            Exit Sub

    '                        Case "PLAN REGISTER #"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iPLANNO
    '                            Search = iPLANNO

    '                        Case "ID"
    '                            ' Set command properties
    '                            Dim TheDANum As String = GetTheDANo(CInt(txtSearch.Text))
    '                            If TheDANum <> String.Empty Then
    '                                LoadForm(TheDANum)
    '                            Else
    '                                MessageBox.Show("Records matching this criteria were not found...", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                            End If
    '                            Exit Sub

    '                        Case "ADDRESS"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iADDRESS
    '                            Search = iADDRESS
    '                        Case Else : Exit Sub
    '                    End Select
    '                End With

    '                ' Execute the command
    '                objDA.SelectCommand = cmd
    '                objDA.Fill(objDS.Tables("Results"))

    '            End Using
    '             




    '            'Find the number of rows


    '            Dim RowCount As Integer = objDS.Tables("Results").Rows.Count


    '            Select Case RowCount
    '                Case 0
    '                    MessageBox.Show("Records matching this criteria were not found...", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Case 1

    '                    Dim objDataRow As DataRow = objDS.Tables("Results").Rows.Item(0)

    '                    LoadForm(objDataRow.Item("DANo").ToString)
    '                Case Else

    '                    With lstSearchResults
    '                        .DataSource = objDS.Tables("Results")
    '                        .DisplayMember = "DANo"
    '                        .ValueMember = "DANo"
    '                    End With




    '            End Select



    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, " In CheckForRecords - form PropertyRO")
    '        End Try
    '    End Using

    'End Sub

    Private Function GetTheDANo(ByVal id As Integer) As String
        Dim result As String = String.Empty

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetTheDANo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetTheDANumberFromEngPostConsent"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = id
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        result = .Parameters("@DANO").Value.ToString
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetTheDANo routine - form " & Me.Name)

            End Try
        End Using


        Return result

    End Function

    Private Sub dgvLoadListReferrals_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLoadListReferrals.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If Not e.RowIndex = -1 Then
            Try
                Me.ReferalInfoTableAdapter.Fill(Me.DAdatasets.ReferalInfo, CInt(dgvLoadListReferrals.CurrentRow.Cells(0).Value))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            LockTheForm(pnlButtons, True)
            LockTheForm(grpMain, False)
            LockTheForm(grpRFS, False)
            LockTheForm(grpIntDesig, False)
            LockTheForm(grpEngineers, False)
            LockTheForm(grpSepp71, False)
            btnView.Enabled = True
            Me.btnEditReferralsTab.Enabled = True
            Me.btnAddReferral.Enabled = True
            btnSaveReferralsTab.Enabled = False
            Me.grpRFS.Visible = False


            Select Case CInt(cboRefCodeId.SelectedValue)

                Case 2, 3
                    Me.grpRFS.Visible = False

                Case 59
                    Me.grpRFS.Visible = True

                Case Else
                    Me.grpRFS.Visible = False

            End Select




        End If

        If Me.lblReferralID.Text.Length = 0 Then
            Me.btnAddIntegrated.Enabled = False
            Me.btnRemoveIntegated.Enabled = False
        End If
        Me.btnRemoveRefer.Enabled = True
    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim cb As Button = DirectCast(ctrl, Button)
                cb.Enabled = bLock
            ElseIf TypeOf ctrl Is combobox Then
                Dim cb As combobox = DirectCast(ctrl, combobox)
                cb.Enabled = bLock
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = Not bLock
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = bLock

            End If
        Next
    End Sub

    'Private Sub lstSearchResults_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    LoadForm(lstSearchResults.SelectedValue.ToString)
    'End Sub

    Private Sub dgvEngineeringTimeLine_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEngineeringTimeLine.CellClick
        If IsANonHeaderButtonCell(e) Then
            DisplayPDFdocument()
        ElseIf IsANonHeaderTextCell(e) Then
            Try
                Me.RetrieveEventTimeRecordTableAdapter.Fill(Me.ComplianceDataSet.RetrieveEventTimeRecord, New System.Nullable(Of Integer)(CType(dgvEngineeringTimeLine.CurrentRow.Cells(8).Value, Integer)))
                LockTheForm(grpEventRecord, False)
                btnEditEvent.Enabled = True
                btnSaveEvent.Enabled = False
                btnaddEvent.Enabled = True
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub btnaddEvent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaddEvent.Click
        LockTheForm(grpEventRecord, True)
        clearThePanel(grpEventRecord)
        btnEditEvent.Enabled = False
        btnSaveEvent.Enabled = True
        btnaddEvent.Enabled = False
        Me.lblEventId.Text = "0"
        EngEventTypeExtendedComboBox.SelectedIndex = -1

    End Sub

    Private Sub btnEditEvent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditEvent.Click
        LockTheForm(grpEventRecord, True)
        btnEditEvent.Enabled = False
        btnSaveEvent.Enabled = True
        btnaddEvent.Enabled = True

    End Sub

    Private Sub btnSaveEvent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveEvent.Click
        LockTheForm(grpEventRecord, False)
        btnEditEvent.Enabled = True
        btnSaveEvent.Enabled = False
        btnaddEvent.Enabled = True
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveEvent_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateEngTimeLineEvent"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblEventId.Text)
                        .Parameters.Add("@EVENTTYPE", SqlDbType.Int).Value = CInt(EngEventTypeExtendedComboBox.SelectedValue)
                        .Parameters.Add("@EVENTDATE", SqlDbType.SmallDateTime)

                        If IsDate(eventdate.Text) Then .Parameters("@EVENTDATE").Value = Format(CDate(eventdate.Text), "dd/MM/yyyy")
                        .Parameters.Add("@NOTES", SqlDbType.NVarChar).Value = Me.txtEventNotes.Text
                        .Parameters.Add("@COMPLTE", SqlDbType.SmallDateTime)
                        If IsDate(eventcompletedte.Text) Then .Parameters("@COMPLTE").Value = Format(CDate(eventcompletedte.Text), "dd/MM/yyyy")
                        If Me.EngEventStatusExtendedComboBox.SelectedIndex <> -1 Then .Parameters.Add("@STATUS", SqlDbType.Int).Value = CInt(EngEventStatusExtendedComboBox.SelectedValue)
                        .Parameters.Add("@DETNO", SqlDbType.Int).Value = NZ(lblEngDetNo.Text)
                        .ExecuteNonQuery()


                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveEvent_Click routine - form " & Me.Name)

            End Try
        End Using
        Me.RetrieveEngineeringTimeLineTableAdapter.Fill(Me.ComplianceDataSet.RetrieveEngineeringTimeLine, CType(NZ(lblEngDetNo.Text), Integer))


    End Sub

    Private Sub btnAddReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferral.Click
        btnAddReferral.Enabled = False
        Me.btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        ClearReferralData(grpMain)
        Me.lblReferralID.Text = String.Empty
        lstIntegrated.DataSource = Nothing
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        LockTheForm(grpSepp71, True)

    End Sub

    Private Sub btnEditReferralsTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditReferralsTab.Click
        btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        LockTheForm(pnlButtons, True)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        LockTheForm(grpSepp71, True)

    End Sub

    Private Sub SaveReferralData()

        btnEditReferralsTab.Enabled = True
        btnSaveReferralsTab.Enabled = False
        LockTheForm(grpMain, False)
        LockTheForm(pnlButtons, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(grpSepp71, False)
        LockTheForm(grpMain, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(grpSepp71, False)

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_Referrals"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.lblEngDetNo.Text
                        .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                        .Parameters.Add("@REFDATE", SqlDbType.SmallDateTime)
                        If IsDate(Refdt.Text) Then .Parameters("@REFDATE").Value = Format(CDate(Refdt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@RETREFDTE", SqlDbType.SmallDateTime)
                        If IsDate(RefRetDt.Text) Then .Parameters("@RETREFDTE").Value = Format(CDate(RefRetDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@REFCODEID", SqlDbType.Int).Value = CInt(cboRefCodeId.SelectedValue)
                        .Parameters.Add("@SEPP71IMPACTS", SqlDbType.NVarChar).Value = Me.txtSepp71LikelyImpacts.Text
                        .Parameters.Add("@REFCOMMENT", SqlDbType.NText).Value = Me.txtRefComm.Text
                        .Parameters.Add("@REFRESPONSE", SqlDbType.NText).Value = Me.txtRefResponse.Text
                        .Parameters.Add("@SEPP71REFER", SqlDbType.Bit).Value = Me.chksepp71.CheckState
                        .Parameters.Add("@SEPP71INTDEV", SqlDbType.Bit).Value = Me.chkIntDev.CheckState
                        .Parameters.Add("@SEPP71SENSITIVE", SqlDbType.Bit).Value = Me.chkSensitive.CheckState
                        .Parameters.Add("@SEPP711100MARK", SqlDbType.Bit).Value = Me.chk100Mark.CheckState
                        .Parameters.Add("@SEPP71SCH3", SqlDbType.Bit).Value = Me.chkSch3.CheckState
                        .Parameters.Add("@RFSSUBDIV", SqlDbType.NVarChar)
                        If cboRFSSubDivisionType.SelectedIndex <> -1 Then .Parameters("@RFSSUBDIV").Value = Me.cboRFSSubDivisionType.SelectedValue.ToString()
                        .Parameters.Add("@RFSLOTS", SqlDbType.Int)
                        If txtRFSSubLots.Text <> String.Empty Then .Parameters("@RFSLOTS").Value = CInt(txtRFSSubLots.Text)
                        .Parameters.Add("@ENGCOMMENTS", SqlDbType.NText).Value = Me.txtEngInternalComments.Text
                        .Parameters.Add("@ENDRETDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.EngDueReturnDate.Text) Then .Parameters("@ENDRETDTE").Value = Format(CDate(EngDueReturnDate.Text), "dd/MM/yyyy")
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "EG"

                        .ExecuteNonQuery()
                    End With


                End Using
                 

                Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.lblEngDetNo.Text, "EG")


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub



    Private Sub btnSaveReferralsTab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveReferralsTab.Click
        If Not CheckReferralData() Then Exit Sub
        SaveReferralData()
        Me.RetrieveEngineeringTimeLineTableAdapter.Fill(Me.ComplianceDataSet.RetrieveEngineeringTimeLine, CType(NZ(lblEngDetNo.Text), Integer))
        'btnEditReferralsTab.Enabled = True
        'btnSaveReferralsTab.Enabled = False
        'LockTheForm(grpMain, False)
        'LockTheForm(pnlButtons, False)
        'LockTheForm(grpRFS, False)
        'LockTheForm(grpIntDesig, False)
        'LockTheForm(grpEngineers, False)
        'LockTheForm(grpSepp71, False)
        'LockTheForm(grpMain, False)
        'LockTheForm(grpRFS, False)
        'LockTheForm(grpIntDesig, False)
        'LockTheForm(grpEngineers, False)
        'LockTheForm(grpSepp71, False)
        'Using cn As New SqlConnection(My.Settings.DataConnection)
        '    Try
        '        cn.Open()
        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

        '    End Try


        '    Try

        '        Using cmd As New SqlCommand

        '            With cmd
        '                .Connection = cn
        '                .CommandType = CommandType.StoredProcedure
        '                .CommandText = "usp_DAUPDATE_Referrals"

        '                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.lblEngDetNo.Text
        '                .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
        '                .Parameters.Add("@REFDATE", SqlDbType.SmallDateTime)
        '                If IsDate(Refdt.Text) Then .Parameters("@REFDATE").Value = Format(CDate(Refdt.Text), "dd/MM/yyyy")
        '                .Parameters.Add("@RETREFDTE", SqlDbType.SmallDateTime)
        '                If IsDate(RefRetDt.Text) Then .Parameters("@RETREFDTE").Value = Format(CDate(RefRetDt.Text), "dd/MM/yyyy")
        '                .Parameters.Add("@REFCODEID", SqlDbType.Int).Value = CInt(cboRefCodeId.SelectedValue)
        '                .Parameters.Add("@SEPP71IMPACTS", SqlDbType.NVarChar).Value = Me.txtSepp71LikelyImpacts.Text
        '                .Parameters.Add("@REFCOMMENT", SqlDbType.NText).Value = Me.txtRefComm.Text
        '                .Parameters.Add("@REFRESPONSE", SqlDbType.NText).Value = Me.txtRefResponse.Text
        '                .Parameters.Add("@SEPP71REFER", SqlDbType.Bit).Value = Me.chksepp71.CheckState
        '                .Parameters.Add("@SEPP71INTDEV", SqlDbType.Bit).Value = Me.chkIntDev.CheckState
        '                .Parameters.Add("@SEPP71SENSITIVE", SqlDbType.Bit).Value = Me.chkSensitive.CheckState
        '                .Parameters.Add("@SEPP711100MARK", SqlDbType.Bit).Value = Me.chk100Mark.CheckState
        '                .Parameters.Add("@SEPP71SCH3", SqlDbType.Bit).Value = Me.chkSch3.CheckState
        '                .Parameters.Add("@RFSSUBDIV", SqlDbType.NVarChar)
        '                If cboRFSSubDivisionType.SelectedIndex <> -1 Then .Parameters("@RFSSUBDIV").Value = Me.cboRFSSubDivisionType.SelectedValue.ToString()
        '                .Parameters.Add("@RFSLOTS", SqlDbType.Int)
        '                If txtRFSSubLots.Text <> String.Empty Then .Parameters("@RFSLOTS").Value = CInt(txtRFSSubLots.Text)
        '                .Parameters.Add("@ENGCOMMENTS", SqlDbType.NText).Value = Me.txtEngInternalComments.Text
        '                .Parameters.Add("@ENDRETDTE", SqlDbType.SmallDateTime)
        '                If IsDate(Me.EngDueReturnDate.Text) Then .Parameters("@ENDRETDTE").Value = Format(CDate(EngDueReturnDate.Text), "dd/MM/yyyy")
        '                .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "EG"

        '                .ExecuteNonQuery()
        '            End With


        '        End Using
        '         



        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

        '    End Try
        'End Using




    End Sub

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Private Sub ClearReferralData(ByVal Pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is combobox Then
                Dim cb As combobox = DirectCast(ctrl, combobox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty

            End If
        Next
        Me.lblReferralID.Text = String.Empty

    End Sub

    Private Function CheckReferralData() As Boolean
        Dim result As Boolean = True

        If Not IsDate(Refdt.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.Refdt, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.Refdt, "A referral date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.Refdt, "")

        End If
        If cboRefCodeId.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboRefCodeId, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboRefCodeId, "A referral source is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboRefCodeId, "")

        End If
        If txtRefComm.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtRefComm, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtRefComm, "A comment is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtRefComm, "")

        End If
        If cboRFSSubDivisionType.Visible Then
            If cboRFSSubDivisionType.SelectedIndex = -1 Then
                With ErrorProvider
                    .SetIconAlignment(Me.cboRFSSubDivisionType, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.cboRFSSubDivisionType, "A comment is required")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.cboRFSSubDivisionType, "")

            End If

            If Me.txtRFSSubLots.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.txtRFSSubLots, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.txtRFSSubLots, "A comment is required")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.txtRFSSubLots, "")

            End If
        End If
        Return result
    End Function

    Private Function CheckCharges() As Boolean
        Dim result As Boolean = True

        If Not IsDate(ChargeDt.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.btnChargeDt, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.btnChargeDt, "A date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.btnChargeDt, "")

        End If
        If cboPayment.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboPayment, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboPayment, "A payment type is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboPayment, "")

        End If

        If ChargeQuantNumberBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.ChargeQuantNumberBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.ChargeQuantNumberBox, "Quantity is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.ChargeQuantNumberBox, "")

        End If


        If Me.ChargeMultiplierNumberBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.ChargeMultiplierNumberBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.ChargeMultiplierNumberBox, "Rate is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.ChargeMultiplierNumberBox, "")

        End If

        If Me.ChargeAmtNumberBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.ChargeAmtNumberBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.ChargeAmtNumberBox, "Amount is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.ChargeAmtNumberBox, "")

        End If





        Return result
    End Function
    Public Sub New()
        isloading = True
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        LoadPaymentTypesCombo()

        isloading = False

    End Sub

#Region "File Notes Tab"
    Private Sub btnDocNote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDocNote.Click
        If MessageBox.Show("Update note?", "Add amend doc note", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateDocumentNote"
                        .Parameters.Add("@NOTES", SqlDbType.NText).Value = Me.txtDocNote.Text
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(dgvDocumentsList.CurrentRow.Cells(9).Value)
                        .ExecuteNonQuery()
                    End With

                End Using
                 
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDocNote_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        txtDocNote.Text = String.Empty
        Try
            RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "EG", txtDAno.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClearNoteFields()
        Me.NoteDate.Text = String.Empty
        Me.txtNotesSubject.Text = String.Empty
        Me.txtNoteDetails.Text = String.Empty
        Me.txtNotesContactNo.Text = String.Empty
        Me.cboNoteType.SelectedValue = -1
        Me.txtNotesSpokeTo.Text = String.Empty
        Me.txtNotesCC.Text = String.Empty
        Me.txtNotesFollowUp.Text = String.Empty
        lblNotesID.Text = "0"
        Me.cboNotesOfficer.SelectedValue = -1
        Me.btnNotesEdit.Enabled = False
        Me.btnNotesSave.Enabled = False
        btnNotesAdd.Enabled = True
        Me.btnNotePrint.Enabled = False
    End Sub

    Private Sub LockNotes(ByVal lock As Boolean)
        Me.NoteDate.ReadOnly = lock
        Me.txtNotesSubject.ReadOnly = lock
        Me.txtNoteDetails.ReadOnly = lock
        Me.txtNotesContactNo.ReadOnly = lock
        Me.cboNoteType.Enabled = Not lock
        Me.txtNotesSpokeTo.ReadOnly = lock
        Me.txtNotesCC.ReadOnly = lock
        Me.txtNotesFollowUp.ReadOnly = lock
        Me.cboNotesOfficer.Enabled = Not lock
        Me.btnNotesEdit.Enabled = lock
        Me.btnNotesSave.Enabled = Not lock
        btnNotesAdd.Enabled = lock
        Me.btnNotePrint.Enabled = Not lock

    End Sub

    Private Sub dgvFileNotes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFileNotes.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadNoteDetailsForEdit"

                        .Parameters.Add("@NOTEID", SqlDbType.Int).Value = CInt(dgvFileNotes.CurrentRow.Cells(6).Value)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.NoteDate.Text = Format(CDate(objDataRow.Item(0).ToString), "dd/MM/yyyy")
                        Me.txtNotesSubject.Text = objDataRow.Item(1).ToString
                        Me.txtNoteDetails.Text = objDataRow.Item(2).ToString
                        Me.txtNotesContactNo.Text = objDataRow.Item(3).ToString
                        Me.cboNoteType.SelectedValue = objDataRow.Item(4).ToString
                        Me.txtNotesSpokeTo.Text = objDataRow.Item(5).ToString
                        Me.txtNotesCC.Text = objDataRow.Item(6).ToString
                        Me.txtNotesFollowUp.Text = objDataRow.Item(7).ToString
                        Me.cboNotesOfficer.SelectedValue = CInt(objDataRow.Item(8).ToString)
                        Me.lblNotesID.Text = objDataRow.Item(9).ToString
                        Me.btnNotesEdit.Enabled = True
                        Me.btnNotesSave.Enabled = False
                        btnNotesAdd.Enabled = True
                        Me.btnNotePrint.Enabled = True
                        LockNotes(True)

                    Else
                        ClearNoteFields()
                    End If

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvFileNotes_CellClick routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnNotesAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNotesAdd.Click
        ClearNoteFields()
        LockNotes(False)
        Me.btnNotesSave.Enabled = True
        btnNotesAdd.Enabled = False
        btnNotesEdit.Enabled = False
        btnNotePrint.Enabled = False

    End Sub

    Private Sub btnNotesEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNotesEdit.Click
        LockNotes(False)
        Me.btnNotesSave.Enabled = True
        btnNotesAdd.Enabled = True
        btnNotesEdit.Enabled = False
        btnNotePrint.Enabled = True

    End Sub

    Private Sub btnNotesSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNotesSave.Click
        SaveNotesData()
        ClearNoteFields()
        LockNotes(True)
        Me.btnNotesSave.Enabled = False
        btnNotesAdd.Enabled = True
        btnNotesEdit.Enabled = False
        btnNotePrint.Enabled = False

    End Sub

    Private Sub SaveNotesData()
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateFileNotes"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblNotesID.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.lblEngDetNo.Text
                        .Parameters.Add("@NOTEDATE", SqlDbType.SmallDateTime).Value = Format(CDate(NoteDate.Text), "dd/MM/yyyy")
                        .Parameters.Add("@SUBJECT", SqlDbType.NVarChar).Value = Me.txtNotesSubject.Text
                        .Parameters.Add("@DETAIL", SqlDbType.NText).Value = Me.txtNoteDetails.Text
                        .Parameters.Add("@CONTACT", SqlDbType.NVarChar).Value = Me.txtNotesContactNo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "DA"
                        .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = Me.cboNoteType.SelectedValue.ToString
                        .Parameters.Add("@SPOKEN", SqlDbType.NVarChar).Value = Me.txtNotesSpokeTo.Text
                        .Parameters.Add("@CC", SqlDbType.NVarChar).Value = Me.txtNotesCC.Text
                        .Parameters.Add("@FOLLOWUP", SqlDbType.NVarChar).Value = Me.txtNotesFollowUp.Text
                        .Parameters.Add("@AUTHOR", SqlDbType.NVarChar).Value = Me.cboNotesOfficer.SelectedValue.ToString
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = Me.txtDAFileNo.Text
                        .Parameters.Add("@REFERRED", SqlDbType.NVarChar).Value = Me.txtNotesReferredTo.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Me.Name)

            End Try
        End Using

    End Sub

#End Region

    Private Sub btnAddCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCC.Click
        Dim NewEngDetNo As Integer

        lblEngDetNo.Text = "0"
        LockTheForm(Me.grpDetails1, True)
        LockTheForm(Me.grpDetails2, True)

        ClearData(Me.grpDetails1)
        ClearData(Me.grpDetails2)
        ClearData(Me.pnlTop)
        ClearData(Me.grpPlanRegistration)

        If MessageBox.Show("Create a new Engineer Post consent now?", "Create New Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        NewEngDetNo = CreatNewRecord()


        If NewEngDetNo <> 0 Then LoadForm(NewEngDetNo)






        Try
            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, "", "EG")
            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, "", "EG")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.txtReceipts.Text = String.Empty
        Me.txtRefunds.Text = String.Empty
        txtDifference.Text = String.Empty
        'LoadForm(DANo)

        btnEditDA.Enabled = False

        Me.btnSaveDA.Enabled = True
        btnAddCC.Enabled = False




    End Sub

    Private Sub btnEditDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDA.Click
        LockTheForm(Me.grpDetails1, True)
        LockTheForm(Me.grpDetails2, True)
        btnEditDA.Enabled = False

        Me.btnSaveDA.Enabled = True

    End Sub

    Private Sub btnSaveDA_ClickExtracted()
        btnEditDA.Enabled = True
        Me.btnSaveDA.Enabled = False
        btnAddCC.Enabled = True
        LockTheForm(Me.grpDetails1, False)
        LockTheForm(Me.grpDetails2, False)


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "[usp_UpdatetEngineerPostConsent]"

                        .Parameters.Add("@EngDetNo", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDAno.Text
                        .Parameters.Add("@CCPlanNo", SqlDbType.Int).Value = NZ(Me.cboPlanNo.Text)
                        .Parameters.Add("@CCLotsCreated", SqlDbType.Int).Value = NZ(CCLotsCreatedNumericTextBox.Text)

                        .Parameters.Add("@CCLinealMetres", SqlDbType.Int).Value = NZ(CCLinealMetresTextBox.Text)
                        .Parameters.Add("@CCEstate", SqlDbType.NVarChar).Value = Me.txtEstate.Text
                        .Parameters.Add("@CCConsultant", SqlDbType.NVarChar).Value = Me.CCConsultantTextBox.Text

                        .Parameters.Add("@NewDPNumber", SqlDbType.NVarChar).Value = Me.NewDPNumberTextBox.Text

                        .Parameters.Add("@NewDPRegistrationDate", SqlDbType.SmallDateTime)
                        If IsDate(Me.NewDPRegistrationDate.Text) Then .Parameters("@NewDPRegistrationDate").Value = Format(CDate(NewDPRegistrationDate.Text), "dd/MM/yyyy")


                        .Parameters.Add("@NewDPImagePath", SqlDbType.NVarChar).Value = Me.NewDPImagePathTextBox.Text
                        .Parameters.Add("@PlanSet", SqlDbType.NVarChar).Value = Me.txtPlanSet.Text
                        .Parameters.Add("@Officer", SqlDbType.Int)
                        If OfficerExtendedComboBox.SelectedIndex <> -1 Then .Parameters("@Officer").Value = CInt(OfficerExtendedComboBox.SelectedValue)

                        .Parameters.Add("@CCConsultantAdd", SqlDbType.NVarChar).Value = Me.CCConsultantAddTextBox.Text
                        .Parameters.Add("@CCConsultantTown", SqlDbType.NVarChar).Value = Me.CCConsultantTownTextBox.Text

                        .Parameters.Add("@CCConsultantPCode", SqlDbType.SmallInt)
                        If Me.CCConsultantPCodeTextBox.Text <> String.Empty Then .Parameters("@CCConsultantPCode").Value = CInt(Me.CCConsultantPCodeTextBox.Text)

                        .Parameters.Add("@CCConsultantPhone", SqlDbType.NVarChar).Value = Me.CCConsultantPhoneTextBox.Text
                        .Parameters.Add("@RequisitionText", SqlDbType.NText).Value = Me.RequisitionTextTextBox.Text

                        .Parameters.Add("@RequisitionLetterDate", SqlDbType.SmallDateTime)
                        If IsDate(Me.RequisitionLetterDate.Text) Then .Parameters("@RequisitionLetterDate").Value = Format(CDate(RequisitionLetterDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@OriginalSubmissionDate", SqlDbType.SmallDateTime)
                        If IsDate(Me.OriginalSubmissionDate.Text) Then .Parameters("@OriginalSubmissionDate").Value = Format(CDate(OriginalSubmissionDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@SignedPlansDate", SqlDbType.SmallDateTime)
                        If IsDate(Me.SignedPlansDate.Text) Then .Parameters("@SignedPlansDate").Value = Format(CDate(SignedPlansDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@LinenReleasedDate", SqlDbType.SmallDateTime)
                        If IsDate(Me.LinenReleasedDate.Text) Then .Parameters("@LinenReleasedDate").Value = Format(CDate(LinenReleasedDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@ProjectName", SqlDbType.NVarChar).Value = Me.txtPlanProject.Text
                        .Parameters.Add("@Description", SqlDbType.NVarChar).Value = Me.txtPlanDescription.Text


                        .Parameters.Add("@SubCertNo", SqlDbType.NVarChar).Value = Me.SubCertNoTextBox.Text
                        .Parameters.Add("@Street", SqlDbType.NVarChar).Value = Me.txtStreet.Text
                        .Parameters.Add("@YourRef", SqlDbType.NVarChar).Value = Me.YourRefTextBox.Text

                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePropertyTab_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub btnSaveDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDA.Click
        btnSaveDA_ClickExtracted()

    End Sub

    Private Sub ClearData(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is combobox Then
                Dim cb As combobox = DirectCast(ctrl, combobox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty

            End If
        Next

    End Sub

    Private Function CreatNewRecord() As Integer

        Dim result As Integer

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CreatNewRecord routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CreateNewEngPostConsent"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@ENGNO", SqlDbType.Int).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CInt(.Parameters("@ENGNO").Value)
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CreatNewRecord routine - form " & Me.Name)

            End Try
        End Using

        Return result

    End Function

    'Private Sub PaymentsReceivedDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentsReceivedDataGridView.CellClick
    '    If e.ColumnIndex = -1 Then Exit Sub
    '    'btnRemoveFee.Enabled = True
    'End Sub

    'Private Sub DARefundsPaidDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DARefundsPaidDataGridView.CellClick
    '    If e.ColumnIndex = -1 Then Exit Sub
    '    'btnRemoveRefund.Enabled = True
    'End Sub

    Private Sub btnAddCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCharge.Click
        LockTheForm(grpCharges, True)
        clearThePanel(grpCharges)
        btnEditCharge.Enabled = False
        btnSaveCharge.Enabled = True
        btnAddCharge.Enabled = False
        Me.btnRemoveCharge.Enabled = False
        Me.lblChargeID.Text = "0"
        cboChargeUnit.SelectedIndex = -1
        Me.cboPayment.SelectedIndex = -1

    End Sub

    Private Sub btnEditCharge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditCharge.Click
        LockTheForm(grpCharges, True)
        btnEditCharge.Enabled = False
        btnSaveCharge.Enabled = True
        btnAddCharge.Enabled = True
        Me.btnRemoveCharge.Enabled = False
    End Sub


    Private Sub LoadPaymentTypesCombo()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_LoadChargesPaymentTypes"

                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            cboPayment.Items.Add(New PaymentType(CInt(objDataReader("PaymentId")), objDataReader("Payment").ToString, objDataReader("ChargeCalcType").ToString, CDbl(objDataReader("ChargeFlatFee")), CDbl(objDataReader("ChargePerUnit")), objDataReader("ChargeUnitType").ToString, CDbl(objDataReader("ChargeMinimum")), objDataReader("ChargeCategory").ToString))
                        Loop
                        objDataReader.Close()
                        cboPayment.SelectedIndex = -1
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnSaveCharge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveCharge.Click

        If Not CheckCharges() Then Exit Sub

        LockTheForm(grpCharges, False)
        btnEditCharge.Enabled = True
        btnSaveCharge.Enabled = False
        btnAddCharge.Enabled = True
        btnRemoveCharge.Enabled = True

        Dim mlist As PaymentType = CType(cboPayment.SelectedItem, PaymentType)




        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveCharge_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertNewCharge"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblChargeID.Text)
                        .Parameters.Add("@INSPECTID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@TYPEID", SqlDbType.SmallInt).Value = mlist.PayID
                        .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(ChargeAmtNumberBox.Text)

                        .Parameters.Add("@DATE", SqlDbType.SmallDateTime)
                        If IsDate(ChargeDt.Text) Then .Parameters("@DATE").Value = Format(CDate(ChargeDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@REF", SqlDbType.NVarChar).Value = Me.txtEventNotes.Text

                        .Parameters.Add("@QUANT", SqlDbType.Float).Value = CDbl(ChargeQuantNumberBox.Text)
                        .Parameters.Add("@RATE", SqlDbType.Money).Value = CDbl(ChargeMultiplierNumberBox.Text)


                        If Me.cboChargeUnit.SelectedIndex <> -1 Then .Parameters.Add("@UNIT", SqlDbType.NVarChar).Value = cboChargeUnit.SelectedValue.ToString



                        .ExecuteNonQuery()
                        Me.ChargeTransactionsTableAdapter.Fill(Me.ComplianceDataSet.ChargeTransactions, lblEngDetNo.Text)


                        cboPayment.SelectedIndex = -1
                        ChargeQuantNumberBox.Text = String.Empty
                        cboChargeUnit.SelectedIndex = -1
                        ChargeMultiplierNumberBox.Text = String.Empty
                        ChargeDt.Text = String.Empty
                        ChargeAmtNumberBox.Text = String.Empty

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveCharge_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub dgvChargeTransactions_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChargeTransactions.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        'Me.ChargesFeesApplicableTableAdapter.Fill(Me.ComplianceDataSet.ChargesFeesApplicable, CType(CInt(lblEngDetNo.Text), Integer))
        Try
            loadFeesCharged(New System.Nullable(Of Integer)(CType(dgvChargeTransactions.CurrentRow.Cells(0).Value, Integer)))

            'Me.ChargesFeesApplicableTableAdapter.Fill(Me.ComplianceDataSet.ChargesFeesApplicable, New System.Nullable(Of Integer)(CType(dgvChargeTransactions.CurrentRow.Cells(0).Value, Integer)))
            LockTheForm(grpCharges, False)
            btnEditCharge.Enabled = True
            btnSaveCharge.Enabled = False
            btnAddCharge.Enabled = True
            btnRemoveCharge.Enabled = True
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub loadFeesCharged(ByVal id As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in loadFeesCharged routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ChargesFeesApplicable"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = id
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    cboPayment.SelectedIndex = -1
                    ChargeQuantNumberBox.Text = String.Empty
                    cboChargeUnit.SelectedIndex = -1
                    ChargeMultiplierNumberBox.Text = String.Empty
                    ChargeDt.Text = String.Empty
                    ChargeAmtNumberBox.Text = String.Empty


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        cboPayment.Text = objDataRow.Item("Payment").ToString
                        ChargeQuantNumberBox.Text = objDataRow.Item("ChargeQuant").ToString
                        cboChargeUnit.SelectedValue = objDataRow.Item("ChargeUnit").ToString
                        ChargeMultiplierNumberBox.Text = objDataRow.Item("ChargeMultiplier").ToString
                        If Not IsDBNull(objDataRow.Item("ChargeDt")) Then ChargeDt.Text = Format(CDate(objDataRow.Item("ChargeDt")), "dd/MM/yyyy")
                        ChargeAmtNumberBox.Text = objDataRow.Item("ChargeAmt").ToString

                    End If



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in loadFeesCharged routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnRemoveCharge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveCharge.Click
        If MessageBox.Show("Remove this charge from the system?", "Remove charge confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCharge_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveChargeTransaction"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblChargeID.Text)
                        .ExecuteNonQuery()

                    End With
                    Me.ChargeTransactionsTableAdapter.Fill(Me.ComplianceDataSet.ChargeTransactions, lblEngDetNo.Text)


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCharge_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnAddUrbanCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUrbanCharges.Click

        If MessageBox.Show("Insert the Urban standard charges now?", "Insert Charges", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddUrbanCharges_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertStandardChargesPostEng"

                        .Parameters.Add("@ENGREFID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@LOTS", SqlDbType.Int).Value = NZ(CCLotsCreatedNumericTextBox.Text)
                        .Parameters.Add("@LINEAR", SqlDbType.NVarChar).Value = CCLinealMetresTextBox.Text
                        .Parameters.Add("@URBANORRURAL", SqlDbType.Int).Value = 1
                        .ExecuteNonQuery()


                    End With


                End Using
                 

                Me.ChargeTransactionsTableAdapter.Fill(Me.ComplianceDataSet.ChargeTransactions, lblEngDetNo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddUrbanCharges_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnAddRuralCharges_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddRuralCharges.Click

        If MessageBox.Show("Insert the Rural standard charges now?", "Insert Charges", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddRuralCharges_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertStandardChargesPostEng"

                        .Parameters.Add("@ENGREFID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@LOTS", SqlDbType.Int).Value = NZ(CCLotsCreatedNumericTextBox.Text)
                        .Parameters.Add("@LINEAR", SqlDbType.NVarChar).Value = CCLinealMetresTextBox.Text
                        .Parameters.Add("@URBANORRURAL", SqlDbType.Int).Value = 2
                        .ExecuteNonQuery()


                    End With


                End Using
                 

                Me.ChargeTransactionsTableAdapter.Fill(Me.ComplianceDataSet.ChargeTransactions, lblEngDetNo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddRuralCharges_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferral.Click
        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnReferral_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_ReferralResponse"
                        .Parameters.Add("@REFID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "EG"
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintOnPlainPaperOnly(objDT, "Referral Response " & Me.txtDAno.Text, "ReferralResponse.rpt", 1)


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnReferral_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintsepp71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintsepp71.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a SEPP 71 Referral to fax to Planning NSW. OK to proceed?", "Print Sepp71 Facimile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_Sepp71Refer"
                        .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintOnPlainPaperOnly(objDT, "SEPP 71 Referral to fax to PlanningNSW" & Me.txtDAno.Text, "Sepp71Referral.rpt", 1)


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnNotePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotePrint.Click

        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnNotePrint_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_FileNotes"
                        .Parameters.Add("@FNID", SqlDbType.Int).Value = NZ(lblNotesID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintOnPlainPaperOnly(objDT, "File note " & Me.txtDAno.Text, "FileNotes.rpt", 1)


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnNotePrint_Click routine ")
            End Try
        End Using
    End Sub

  
    Private Sub PrintReferralLetter(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer, ByVal DocType As String)

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument


        Dim RowCount As Integer = objDtable.Rows.Count
        If objDtable.Rows.Count > 0 Then

            Dim objDataRow As DataRow = objDtable.Rows.Item(0)

            OwnerName = objDataRow.Item("DAAppName").ToString
            OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
            FileNo = objDataRow.Item("DAFileNo").ToString

        End If

        Try

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & reportName & ".rpt"

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
            myPrintOptions.PrinterName = My.Settings.DefaultPrinter
            myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            myPrintOptions.CustomPaperSource = GetSelectedPaperSource()


            With rptDocument
                .Load(strReportPath)
                .SetDataSource(objDtable)
                .VerifyDatabase()
            End With


            'remove 11/8/2009 so that users can have more control over printing
            'rptDocument.PrintToPrinter(1, False, 1, 1)

            'If Copies = 2 Then

            '    Dim myPrintOptionsTwo As PrintOptions = rptDocument.PrintOptions
            '    myPrintOptionsTwo.PrinterName = My.Settings.DefaultPrinter
            '    myPrintOptionsTwo.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            '    myPrintOptionsTwo.CustomPaperSource = GetSelectedSecondPaperSource()
            '    rptDocument.PrintToPrinter(1, False, 1, 1)

            'End If
            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\test\test.pdf")

            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            Dim fEase As New OutwardEaseCorro

            With fEase
                .CustName = OwnerName
                .CustAddress = OwnerAddress
                .FileNumber = FileNo
                .DocSummary = Summary & Me.txtDAno.Text
                .DocumnetNo = strDocumentNo
                .ShowDialog()
                .Dispose()
            End With

            If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then
                FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)
            End If

            rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, LOCALRECORDFOLDER & "\" & strEASEdocumentName)
            FileIO.FileSystem.MoveFile(LOCALRECORDFOLDER & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)

            If DocType <> "NO" Then
                Dim InsertDocData As New InsertDocumentData
                With InsertDocData
                    .ApplicationType = "EG"
                    .DocumentType = DocType
                    .ApplicationNo = Me.lblEngDetNo.Text
                    .TheAuthor = MyUserId
                    .TheImageName = Replace(strDocumentNo, ".", "_")
                    .Notes = txtLetterNotes.Text
                    .InsertDocumentsIntoDAsystem()
                End With

            End If

            DisplayDocumentToPrint(rptDocument)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")
        Finally
            rptDocument.Close()

        End Try


    End Sub

    Private Sub DisplayDocumentToPrint(ByVal rptToPrint As ReportDocument)

        Dim fPrint As New ReportPrintScreen
        With fPrint
            .StartPosition = FormStartPosition.CenterParent
            .ReportName = rptToPrint
            .ShowDialog()
            .Dispose()

        End With


    End Sub

    Private Sub PrintButDontEase(ByVal objDtable As DataTable, ByVal reportName As String)
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument


        Dim RowCount As Integer = objDtable.Rows.Count
        If objDtable.Rows.Count > 0 Then

            Dim objDataRow As DataRow = objDtable.Rows.Item(0)

            OwnerName = objDataRow.Item("DAAppName").ToString
            OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
            FileNo = objDataRow.Item("DAFileNo").ToString

        End If

        Try

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & reportName

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
            myPrintOptions.PrinterName = My.Settings.DefaultPrinter
            myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            myPrintOptions.CustomPaperSource = GetSelectedSecondPaperSource()


            With rptDocument
                .Load(strReportPath)
                .SetDataSource(objDtable)
                .VerifyDatabase()
            End With


            rptDocument.PrintToPrinter(1, False, 1, 1)


        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintButDontEase")
        Finally
            rptDocument.Close()

        End Try

    End Sub



    Private Sub PrintOnPlainPaperOnly(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer)
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument


        Dim RowCount As Integer = objDtable.Rows.Count
        If objDtable.Rows.Count > 0 Then

            Dim objDataRow As DataRow = objDtable.Rows.Item(0)

            OwnerName = objDataRow.Item("DAAppName").ToString
            OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
            FileNo = objDataRow.Item("DAFileNo").ToString

        End If

        Try

            'Pass the reportname to string variable 
            Dim strReportPath As String = My.Settings.ReportLocation & reportName

            'Check file exists
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
            myPrintOptions.PrinterName = My.Settings.DefaultPrinter
            myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
            myPrintOptions.CustomPaperSource = GetSelectedSecondPaperSource()


            With rptDocument
                .Load(strReportPath)
                .SetDataSource(objDtable)
                .VerifyDatabase()
                .PrintToPrinter(1, False, 1, 10)
                .Close()
            End With




            'Dim strDocumentNo As String = GetNextDocumentNumber()
            'Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            'Dim fEase As New OutwardEaseCorro

            'With fEase
            '    .CustName = OwnerName
            '    .CustAddress = OwnerAddress
            '    .FileNumber = FileNo
            '    .DocSummary = Summary & Me.txtDAno.Text
            '    .DocumnetNo = strDocumentNo
            '    .ShowDialog()
            '    .Dispose()
            'End With

            'If Not FileIO.FileSystem.DirectoryExists(LOCALRECORDFOLDER) Then
            '    FileIO.FileSystem.CreateDirectory(LOCALRECORDFOLDER)
            'End If

            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, LOCALRECORDFOLDER & "\" & strEASEdocumentName)
            'FileIO.FileSystem.MoveFile(LOCALRECORDFOLDER & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)

        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")

        End Try

    End Sub

    Private Sub btnDraftconditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraftconditions.Click
        Dim fDraftConditions As New DraftConditions
        With fDraftConditions
            .TheReferralId = CInt(lblReferralID.Text)
            .ApplicationID = Me.txtDAno.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub




    Private Sub btnRemoveRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefer.Click


        If MessageBox.Show("Are you sure you want to remove this referral?", "Remove Referral", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefer_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveReferral"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                        .ExecuteNonQuery()
                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefer_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.lblEngDetNo.Text, "EG")

        Try
            Me.ReferalInfoTableAdapter.Fill(Me.DAdatasets.ReferalInfo, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        LockTheForm(pnlButtons, False)
        LockTheForm(grpMain, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(grpSepp71, False)
        btnView.Enabled = True
        Me.btnEditReferralsTab.Enabled = False
        Me.btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.SelectedValue)

            Case 2, 3
                Me.grpRFS.Visible = False

            Case 59
                Me.grpRFS.Visible = True

            Case Else
                Me.grpRFS.Visible = False

        End Select

        If Me.lblReferralID.Text.Length = 0 Then
            Me.btnAddIntegrated.Enabled = False
            Me.btnRemoveIntegated.Enabled = False
        End If
        Me.btnRemoveRefer.Enabled = True


    End Sub

    Private Sub cboRefCodeId_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRefCodeId.SelectedValueChanged
        Select Case CInt(cboRefCodeId.SelectedValue)

            Case 2, 3
                Me.grpRFS.Visible = False
            Case 59
                Me.grpRFS.Visible = True
            Case Else
                Me.grpRFS.Visible = False

        End Select



    End Sub

    Private Sub btnCreateNewLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNewLetter.Click

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("Proceed and Create the " & Me.cboLetterType.Text & " now?", "Print Letter?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim mlist As DocumentTypeListing = CType(Me.cboLetterType.SelectedItem, DocumentTypeListing)


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ReportSelectionData"

                        .Parameters.Add("@REPTTYPE", SqlDbType.NVarChar).Value = mlist.DocTypeName.ToString
                        .Parameters.Add("@LANID", SqlDbType.NVarChar).Value = sUserID
                        .Parameters.Add("@COInspID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDAno.Text
                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    PrintEngineeringLetter(objDT, "Document Type: " & Me.cboLetterType.Text & " Application No. " & Me.txtDAno.Text & " " & Me.txtLetterNotes.Text, mlist.TheReportName.ToString, 2, mlist.DocTypeName.ToString)


                    'PrintReferralLetter(objDT, "Document Type: " & Me.cboLetterType.Text & " Application No. " & Me.txtDAno.Text & " " & Me.txtLetterNotes.Text, mlist.TheReportName.ToString, 2, mlist.DocTypeName.ToString)

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine ")
            End Try
        End Using


    End Sub
    Private Sub EngineerPostConsent_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.btnSaveDA.Enabled Then
            If MessageBox.Show("It appears you have made changes to this application. Save changes before exiting?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                btnSaveDA_ClickExtracted()
            End If
        End If

    End Sub

    Private Sub btneventdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneventdate.Click
        RetrieveDate(eventdate)

    End Sub

    Private Sub btneventcompletedte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneventcompletedte.Click
        RetrieveDate(eventcompletedte)
    End Sub

    Private Sub btnRemoveFee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveFee.Click


        If MessageBox.Show("Are you sure about this, remove this fee?", "Remove Fee ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveAPayment"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(PaymentsReceivedDataGridView.CurrentRow.Cells(7).Value)
                        .ExecuteNonQuery()

                    End With


                End Using
                 

                Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, lblEngDetNo.Text, "EG")
                CalculateRefundsandPayments(lblEngDetNo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnRemoveRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefund.Click
        If MessageBox.Show("Are you sure about this, remove this refund?", "Remove refund ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveARefund"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(DARefundsPaidDataGridView.CurrentRow.Cells(6).Value)
                        .ExecuteNonQuery()

                    End With


                End Using
                 

                Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, txtDAno.Text, "EG")
                CalculateRefundsandPayments(txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnRefdt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefdt.Click
        RetrieveDate(Refdt)
    End Sub

    Private Sub btnRefRetDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefRetDt.Click
        RetrieveDate(RefRetDt)
    End Sub

    Private Sub btnEngDueReturnDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEngDueReturnDate.Click
        RetrieveDate(EngDueReturnDate)
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim fpopup As New ReferralsResponsePopUp
        With fpopup
            .ResponseText = Me.txtRefResponse.Text
            .ShowDialog()
            txtRefResponse.Text = .ResponseText
            .Dispose()
        End With
    End Sub
#Region "Integrated Development Tab"

    Private Sub cboReferralsIntProvision_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReferralsIntProvision.SelectedValueChanged

        btnAddIntegrated.Enabled = True

    End Sub

    Private Sub btnAddIntegrated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegrated.Click
        If cboReferralsIntProvision.SelectedIndex <> -1 Then
            If MessageBox.Show("Add  " & cboReferralsIntProvision.Text & " ?", "Add ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Using cn As New SqlConnection(My.Settings.DataConnection)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Me.Name)

                    End Try


                    Try

                        Using cmd As New SqlCommand

                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_InsertNewReferralIntProvision"
                                .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                                .Parameters.Add("@PROVISIONID", SqlDbType.Int).Value = CInt(cboReferralsIntProvision.SelectedValue)
                                .ExecuteNonQuery()
                            End With

                        End Using
                         
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddIntegrated_Click routine - form " & Me.Name)

                    End Try
                End Using
                'reload file numbers
                Try
                    Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtDAno.Text, "EG")
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                cboReferralsIntProvision.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub btnRemoveIntegated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveIntegated.Click
        If MessageBox.Show("Remove  " & Me.lstIntegrated.Text & " ?", "Remove ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.DataConnection)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemoveIntegated_Click routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_DeleteReferralsIntProvision"
                            .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lstIntegrated.SelectedValue)
                            .ExecuteNonQuery()
                        End With

                    End Using
                     
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemoveIntegated_Click routine - form " & Me.Name)

                End Try
            End Using
            'reload file numbers
            Try
                Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtDAno.Text, "EG")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

#End Region

    Private Sub cboLetterType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLetterType.SelectedValueChanged
        If cboLetterType.SelectedIndex = -1 Then Exit Sub
        btnCreateNewLetter.Enabled = True

    End Sub

    Private Sub btnChargeDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChargeDt.Click
        RetrieveDate(ChargeDt)
    End Sub

    Private Sub lstSearchResults_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSearchResults.SelectedValueChanged
        If isloading Then Exit Sub
        If Me.btnSaveDA.Enabled Then
            If MessageBox.Show("It appears you have made changes to this application. Save changes before exiting?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                btnSaveDA_ClickExtracted()
            End If
        End If
        LoadForm(lstSearchResults.SelectedValue.ToString)
       
        btnaddEvent.Enabled = True
    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.EngPostConsentTableAdapter.Fill(Me.ComplianceDataSet.EngPostConsent, New System.Nullable(Of Integer)(CType(IDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PaymentsReceivedDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentsReceivedDataGridView.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Me.btnEditPayment.Enabled = True
        Me.btnRemoveFee.Enabled = True
    End Sub

    Private Sub DARefundsPaidDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DARefundsPaidDataGridView.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Me.btnEditRefund.Enabled = True
        btnRemoveRefund.Enabled = True
    End Sub

    Private Sub btnRemoveDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDocument.Click
        Dim documentToRemove As String = dgvDocumentsList.CurrentRow.Cells(4).Value.ToString & " created " & Format(CDate(dgvDocumentsList.CurrentRow.Cells(5).Value), "dd/MM/yyyy")
        If MessageBox.Show("Remove " & documentToRemove & " from the list?", "Remove this document", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim removedocument As New RemoveDocument

        With removedocument
            .DocumentID = CType(dgvDocumentsList.CurrentRow.Cells(10).Value, Integer)
            .DocumentToRemove = dgvDocumentsList.CurrentRow.Cells(2).Value.ToString
            .RemoveDocument()
        End With

        Try
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "EG", Me.lblEngDetNo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub cboPayment_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPayment.SelectedValueChanged
        If isloading Then Exit Sub

        If cboPayment.SelectedIndex = -1 Then Exit Sub

        Dim mlist As PaymentType = CType(cboPayment.SelectedItem, PaymentType)
        Dim Unit As Integer

        Select Case mlist.ChargeCalcType.ToUpper
            Case "P"

                Select Case mlist.UnitType.ToUpper
                    Case "M"
                        If NZ(CCLinealMetresTextBox.Text) <> 0 Then Unit = CInt(CCLinealMetresTextBox.Text)

                    Case "L"

                        If NZ(CCLotsCreatedNumericTextBox.Text) <> 0 Then Unit = CInt(CCLotsCreatedNumericTextBox.Text)

                End Select

                If Unit * mlist.ChargePerUnit > mlist.ChargeMinimum Then

                    ChargeAmtNumberBox.Text = Unit * mlist.ChargePerUnit

                Else

                    ChargeAmtNumberBox.Text = mlist.ChargeMinimum
                    ChargeRefTextBox.Text = "(Min)"
                End If


            Case "C"

                Select Case mlist.UnitType.ToUpper
                    Case "M"
                        If NZ(CCLinealMetresTextBox.Text) <> 0 Then Unit = CInt(CCLinealMetresTextBox.Text)

                    Case "L"

                        If NZ(CCLotsCreatedNumericTextBox.Text) <> 0 Then Unit = CInt(CCLotsCreatedNumericTextBox.Text)

                End Select

                If ((Unit * mlist.ChargePerUnit) + mlist.ChargeFlatFee) > mlist.ChargeMinimum Then

                    ChargeAmtNumberBox.Text = ((Unit * mlist.ChargePerUnit) + mlist.ChargeFlatFee)

                Else

                    ChargeAmtNumberBox.Text = mlist.ChargeMinimum
                    ChargeRefTextBox.Text = "(Min)"
                End If

                ChargeAmtNumberBox.Text = mlist.ChargeFlatFee

            Case Else


        End Select

        cboChargeUnit.SelectedValue = mlist.UnitType
        ChargeMultiplierNumberBox.Text = mlist.ChargePerUnit
        ChargeQuantNumberBox.Text = Unit


    End Sub

    Private Sub btnViewEditDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEditDocument.Click
        If Me.dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString = String.Empty Then Exit Sub


        Try

            Dim WRD As New OpenDocument
            WRD.OpenVisible(dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDeleteDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDoc.Click

        If Me.dgvDraftDocs.CurrentRow.Cells("colAppNo").Value.ToString = String.Empty Then Exit Sub

        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString

        If MessageBox.Show("You are about to delete this word document FOREVER" & vbCrLf & "OK to proceed?", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveDraftEGDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells("colDraftDocId").Value)
                        .ExecuteNonQuery()
                    End With


                End Using
                 

                My.Computer.FileSystem.DeleteFile(FileToDelete)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            DisplayListOfDraftDocuments()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnFinaliseDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinaliseDoc.Click


        Dim summary As String = String.Empty
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_EngineeringPostConsentApplicantsDetails"

                        .Parameters.Add("@COInspID", SqlDbType.Int).Value = CInt(lblEngDetNo.Text)
                    End With

                    Dim objDT As New DataTable

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    summary = "Document Type: " & dgvDraftDocs.CurrentRow.Cells("colDocDescription").Value.ToString & " - " & lblEngDetNo.Text

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        OwnerName = objDataRow.Item("DAAppName").ToString
                        OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
                        FileNo = objDataRow.Item("DAFileNo").ToString

                    End If

 
                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreateNewLetter_Click routine ")
            End Try
        End Using



        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If Me.dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString = String.Empty Then Exit Sub

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

  
        With My.Forms.InsertEASEDocument
            .CustName = OwnerName
            .CustAddress = OwnerAddress

            .WordDocLocation = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = FileNo
            .ShowDialog()
            .Dispose()
        End With


        Dim InsertDocData As New InsertDocumentData
        With InsertDocData
            .ApplicationType = "EG"
            .DocumentType = dgvDraftDocs.CurrentRow.Cells("colDocDescription").Value.ToString
            .ApplicationNo = Me.lblEngDetNo.Text
            .TheAuthor = MyUserId
            .TheImageName = sDocumentNo.Replace(".", "_")
            .Notes = summary
            .InsertDocumentsIntoDAsystem()
        End With


        'With InsertDocData
        '    .ApplicationType = "EG"
        '    .DocumentType = DocType
        '    .ApplicationNo = Me.lblEngDetNo.Text
        '    .TheAuthor = MyUserId
        '    .TheImageName = Replace(strDocumentNo, ".", "_")
        '    .Notes = txtLetterNotes.Text
        '    .InsertDocumentsIntoDAsystem()
        'End With




        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString
        My.Computer.FileSystem.DeleteFile(FileToDelete)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveDraftEGDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells("colDraftDocId").Value)
                        .ExecuteNonQuery()
                    End With
                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        Try
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "EG", Me.lblEngDetNo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        DisplayListOfDraftDocuments()




    End Sub


    Private Sub dgvDraftDocs_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDraftDocs.CellClick
        If e.RowIndex = -1 Then Exit Sub
        btnViewEditDocument.Enabled = True
        btnDeleteDoc.Enabled = True
        btnFinaliseDoc.Enabled = True
    End Sub

End Class