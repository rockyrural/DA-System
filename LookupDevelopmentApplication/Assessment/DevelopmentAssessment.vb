Imports System.Data.SqlClient
Imports WORD = Microsoft.Office.Interop.Word

Imports System.IO
'Imports System.String
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports System.text
Imports ADHelpr = ADHelper.ADHelper


Public Class DevelopmentAssessment

#Region "Declarations"
    Private Const iNAME As Integer = 0
    Private Const iADDRESS As Integer = 1
    Private Const iFILENO As Integer = 2
    Private Const iPIN As Integer = 3

    Private Modification As Boolean = False
    Private mdl_GroupImageID As Integer

    Private compliancenumber As String = String.Empty
    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private OwnersName As String = String.Empty
    Private OwnersAddress As String = String.Empty
    Private OwnersTown As String = String.Empty
    Private OwnersPostCode As String = String.Empty
    Private ADHelper As New ADHelpr


#End Region

#Region "Properties"
    Public WriteOnly Property DisplayMyDA() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                LoadForm(value)
            End If
        End Set
    End Property

    Private DANumber As String
    Public WriteOnly Property DANoToFind() As String
        Set(ByVal value As String)
            DANumber = value
        End Set
    End Property

    Private OriginalDANo As String = String.Empty
    Public WriteOnly Property OriginalDA() As String
        Set(ByVal value As String)
            OriginalDANo = value
        End Set
    End Property


#End Region

#Region "Functions and Sub routines"

    Private Sub PartLockgrpAddinfo()
        btnAIRequestDt.Enabled = True
        AICommentTextBox.ReadOnly = False
    End Sub


    Private Sub ReloadContributionsGrids()
        '-------Load the section64 data------

        Try
            Me.LoadGridforProposedContributionsTableAdapter.Fill(Me.AAdata.LoadGridforProposedContributions, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '------------------------------------

        '-------Load the section94 data------
        Try
            Me.LoadGridforProposedSect94ContributionsTableAdapter.Fill(Me.AAdata.LoadGridforProposedSect94Contributions, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        '------------------------------------

        '-------Load the Bond data------
        Try
            Me.LoadGridforProposedBondContributionsTableAdapter.Fill(Me.AAdata.LoadGridforProposedBondContributions, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        '------------------------------------

    End Sub

    Private Sub UpdatePropertyImage(ByVal imageID As Integer)
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdatePropertyImage routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateGroupImageId"
                        .Parameters.Add("@DANO", SqlDbType.Int).Value = Me.txtDANo.Text
                        .Parameters.Add("@GROUPID", SqlDbType.Int).Value = imageID
                        .ExecuteNonQuery()
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdatePropertyImage routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function CheckSection64() As Boolean
        Dim result As Boolean = True

        If cboSection64Type.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSection64Type, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSection64Type, "A plan type is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSection64Type, "")

        End If

        If cboS64Type.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboS64Type, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboS64Type, "A  type is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboS64Type, "")

        End If
        'If txtRefComm.Text = String.Empty Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.txtRefComm, ErrorIconAlignment.MiddleRight)
        '        .SetError(Me.txtRefComm, "A comment is required")
        '    End With
        '    result = False
        'Else
        '    ErrorProvider.SetError(Me.txtRefComm, "")

        'End If
        If cboContribType.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboContribType, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboContribType, "A category is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboContribType, "")

        End If


        Return result
    End Function

    Private Function CalculateElapsedDays(ByVal DAno As String) As Integer

        Dim dateVar As Date = CDate("1/1/1900")
        Dim objDT As New DataTable
        Dim dayscount As Integer

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateElapsedDays routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_NetReferalDays"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DAno
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CalculateElapsedDays routine - form " & Me.Name)

            End Try
        End Using




        If objDT.Rows.Count > 0 Then
            For count2 As Integer = 0 To objDT.Rows.Count - 1
                Dim objdatarow2 As DataRow = objDT.Rows.Item(count2)

                If Not IsDBNull(objdatarow2.Item("RefRetDt")) And Not IsDBNull(objdatarow2.Item("Refdt")) Then

                    'If (objdatarow2.Item("RefRetDt") <> null) And (objdatarow2.Item("RefDt") <> null) Then
                    If DateDiff(DateInterval.Day, CDate(objdatarow2.Item("RefRetDt")), dateVar) > 0 Then

                    ElseIf DateDiff(DateInterval.Day, dateVar, CDate(objdatarow2.Item("Refdt"))) <= 0 Then
                        dayscount += CInt(DateDiff(DateInterval.Day, CDate(objdatarow2.Item("RefRetDt")), dateVar))
                        dateVar = CDate(objdatarow2.Item("RefRetDt"))

                    Else
                        dayscount += CInt(DateDiff(DateInterval.Day, CDate(objdatarow2.Item("Refdt")), CDate(objdatarow2.Item("RefRetDt"))))
                        dateVar = CDate(objdatarow2.Item("RefRetDt"))

                    End If
                End If
            Next
        End If
        Return dayscount
    End Function

    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        If TheNewDate <> String.Empty Then datefield.Text = TheNewDate

    End Sub

    Private Function GetOriginalDAnumber(ByVal DaNo As String) As String
        Dim result As String = String.Empty

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetOriginalDAnumber routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetOriginalDAnumber"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DaNo
                        .Parameters.Add("@ORIGNO", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = .Parameters("@ORIGNO").Value.ToString

                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetOriginalDAnumber routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function

    Private Sub LoadForm(ByVal daNo As String)
        'Try
        '    Me.DevelopmentDataTableAdapter.Fill(Me.DAdatasets.DevelopmentData, DANOToolStripTextBox.Text)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try


        Try
            Me.DevelopmentDataTableAdapter.Fill(Me.DAdatasets.DevelopmentData, daNo)

            If DAdatasets.DevelopmentData.Rows.Count > 0 Then

                Dim objDataRow As DataRow = DAdatasets.DevelopmentData.Rows.Item(0)

                If Not IsDBNull(objDataRow.Item("AdvertNotifCheck")) Then

                    Select Case CInt(objDataRow.Item("AdvertNotifCheck"))
                        Case 1
                            Me.rbNone.Checked = True
                            lblAdvertising.Text = "No Notification"
                        Case 2
                            rbNotify.Checked = True
                            lblAdvertising.Text = "Notified- No Advert"
                        Case 3
                            rbNotifyAdvert.Checked = True
                            lblAdvertising.Text = "Advertised & Notified"

                    End Select

                Else

                    Me.rbNone.Checked = False
                    rbNotify.Checked = False
                    rbNotifyAdvert.Checked = False
                    lblAdvertising.Text = ""


                End If

                If objDataRow.Item("DesignatedYN").ToString = "Y" Then
                    If objDataRow.Item("IntDevYN").ToString = "Y" Then
                        lblDesignated.Text = "INTEGRATED+DESIGNATED"
                    Else
                        lblDesignated.Text = "DESIGNATED"

                    End If
                Else
                    lblDesignated.Text = ""

                End If

                If objDataRow.Item("IntDevYN").ToString = "Y" Then
                    If objDataRow.Item("DesignatedYN").ToString = "Y" Then
                        lblDesignated.Text = "INTEGRATED+DESIGNATED"
                    Else
                        lblDesignated.Text = "INTEGRATED"

                    End If
                Else
                    lblDesignated.Text = ""

                End If

                Select Case CInt(objDataRow.Item("DAAppTypeId"))
                    Case 3

                        Me.lblModification.Visible = True
                        Me.lblConclusion.Text = "MODIFICATION - Conclusion/Summary"
                        Me.pnlModificationConclusion.Visible = True
                        pnlMainConclusion.Visible = False
                        Modification = True

                        'Now we remove the tab if it exists.

                        tabDAdata.TabPages.Remove(pgStatutory)
                        tabDAdata.TabPages.Remove(pgMerits)
                        tabDAdata.TabPages.Remove(pgMerits)

                        Try
                            Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, daNo)
                        Catch ex As System.Exception
                            System.Windows.Forms.MessageBox.Show(ex.Message)
                        End Try

                        Dim RowCount As Integer = AAdata.DAAssessmentData.Rows.Count
                        If AAdata.DAAssessmentData.Rows.Count > 0 Then

                            Dim objDataRow1 As DataRow = AAdata.DAAssessmentData.Rows.Item(0)

                            Select Case objDataRow1.Item("ModSect96").ToString.ToUpper
                                Case "1"
                                    lblModeType.Text = "Section96(1) Assessment"
                                    pnlMod0.Visible = True
                                    btnUpdateModDetails.Enabled = True
                                    btnUpdateModData.Visible = True
                                    Me.pnlMod1andMod2.Visible = False
                                    Me.pnlMod2.Visible = False
                                    Me.pnlMod1A.Visible = False
                                    Me.pnlMod1.Location = New Point(3, 3)
                                Case "1A"
                                    pnlMod0.Visible = True
                                    lblModeType.Text = "Section96(1A) Assessment"
                                    btnUpdateModDetails.Enabled = True
                                    btnUpdateModData.Visible = True
                                    Me.pnlMod1andMod2.Visible = True
                                    Me.pnlMod2.Visible = False
                                    Me.pnlMod1A.Visible = True
                                    Me.pnlMod1.Location = New Point(3, 283)

                                Case "2"
                                    pnlMod0.Visible = True
                                    lblModeType.Text = "Section96(2) Assessment"
                                    btnUpdateModDetails.Enabled = True
                                    btnUpdateModData.Visible = True
                                    Me.pnlMod1andMod2.Visible = True
                                    Me.pnlMod2.Visible = True
                                    Me.pnlMod1A.Visible = False
                                    Me.pnlMod1.Location = New Point(3, 437)


                                Case Else
                                    lblModeType.Text = String.Empty
                                    pnlMod0.Visible = True
                                    Me.pnlMod1andMod2.Visible = False
                                    Me.pnlMod2.Visible = False
                                    Me.pnlMod1A.Visible = False
                                    btnUpdateModData.Enabled = False
                                    btnUpdateModDetails.Enabled = True
                            End Select
                        End If


                    Case Else
                        Me.lblModification.Visible = False
                        tabDAdata.TabPages.Remove(pgModDetails)
                        Me.lblConclusion.Text = "Conclusion/Summary"
                        Me.pnlModificationConclusion.Visible = False
                        pnlMainConclusion.Visible = True

                        Modification = False
                End Select


                If IsDBNull(objDataRow.Item("GenImpactCompt")) Then
                    Me.picGenImpacts.Visible = False
                Else
                    Me.picGenImpacts.Visible = CBool(objDataRow.Item("GenImpactCompt"))
                End If

                If IsDBNull(objDataRow.Item("DPComplt")) Then
                    Me.picDP.Visible = False
                Else
                    Me.picDP.Visible = CBool(objDataRow.Item("DPComplt"))
                End If

                If IsDBNull(objDataRow.Item("ThreatenSpecComplt")) Then
                    Me.picThreaten.Visible = False
                Else
                    Me.picThreaten.Visible = CBool(objDataRow.Item("GenImpactCompt"))
                End If

                If IsDBNull(objDataRow.Item("TraficComplt")) Then
                    Me.picTraffic.Visible = False
                Else
                    Me.picTraffic.Visible = CBool(objDataRow.Item("TraficComplt"))
                End If

                If IsDBNull(objDataRow.Item("SocialComplt")) Then
                    Me.picSocial.Visible = False
                Else
                    Me.picSocial.Visible = CBool(objDataRow.Item("SocialComplt"))
                End If

                If IsDBNull(objDataRow.Item("DDAComplt")) Then
                    Me.picDDA.Visible = False
                Else
                    Me.picDDA.Visible = CBool(objDataRow.Item("DDAComplt"))
                End If

                If IsDBNull(objDataRow.Item("HeritageComplt")) Then
                    Me.picHeritage.Visible = False
                Else
                    Me.picHeritage.Visible = CBool(objDataRow.Item("HeritageComplt"))
                End If

                If IsDBNull(objDataRow.Item("LandScapeComplt")) Then
                    Me.picLandscape.Visible = False
                Else
                    Me.picLandscape.Visible = CBool(objDataRow.Item("LandScapeComplt"))
                End If

                If IsDBNull(objDataRow.Item("SustainComplt")) Then
                    Me.picSustain.Visible = False
                Else
                    Me.picSustain.Visible = CBool(objDataRow.Item("SustainComplt"))
                End If

                If IsDBNull(objDataRow.Item("SubDiviComplte")) Then
                    Me.picSubDivision.Visible = False
                Else
                    Me.picSubDivision.Visible = CBool(objDataRow.Item("SubDiviComplte"))
                End If


                If IsDBNull(objDataRow.Item("LEPComplt")) Then
                    Me.picLEP.Visible = False
                Else
                    Me.picLEP.Visible = CBool(objDataRow.Item("LEPComplt"))
                End If


                If IsDBNull(objDataRow.Item("SEPPComplt")) Then
                    Me.picSEPP.Visible = False
                Else
                    Me.picSEPP.Visible = CBool(objDataRow.Item("SEPPComplt"))
                End If


                If IsDBNull(objDataRow.Item("DCPComplt")) Then
                    Me.picDCP.Visible = False
                Else
                    Me.picDCP.Visible = CBool(objDataRow.Item("DCPComplt"))
                End If


                If IsDBNull(objDataRow.Item("DAMSComplt")) Then
                    Me.picDAMS.Visible = False
                Else
                    Me.picDAMS.Visible = CBool(objDataRow.Item("DAMSComplt"))
                End If


                If IsDBNull(objDataRow.Item("REPComplt")) Then
                    Me.picREP.Visible = False
                Else
                    Me.picREP.Visible = CBool(objDataRow.Item("REPComplt"))
                End If


                If IsDBNull(objDataRow.Item("Guidlines")) Then
                    Me.picGUIDES.Visible = False
                Else
                    Me.picGUIDES.Visible = CBool(objDataRow.Item("Guidlines"))
                End If


                If IsDBNull(objDataRow.Item("DCPCheckListComplt")) Then
                    Me.picDCPchkList.Visible = False
                Else
                    Me.picDCPchkList.Visible = CBool(objDataRow.Item("DCPCheckListComplt"))
                End If


                If Not IsDBNull(objDataRow.Item("DAOwnersname")) Then OwnersName = objDataRow.Item("DAOwnersname")
                If Not IsDBNull(objDataRow.Item("DAOwnersPAddr")) Then OwnersAddress = objDataRow.Item("DAOwnersPAddr")
                If Not IsDBNull(objDataRow.Item("DAOwnersTown")) Then OwnersTown = objDataRow.Item("DAOwnersTown")
                If Not IsDBNull(objDataRow.Item("DAOwnersPC")) Then OwnersPostCode = objDataRow.Item("DAOwnersPC")

            End If



            'Check for compliance
            Using cn As New SqlConnection(My.Settings.DataConnection)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in LoadForm routine - form " & Me.Name)

                End Try

                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_CheckForComplianceRecord"

                            .Parameters.Add("@DANO", SqlDbType.VarChar).Value = daNo
                            .Parameters.Add("@CCNUMBER", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output
                            .Parameters.Add("@CONFIRM", SqlDbType.Bit).Direction = ParameterDirection.Output
                            .ExecuteNonQuery()


                        End With
                    End Using
                     

                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in LoadForm routine - form " & Me.Name)

                End Try
            End Using


            lblReferralCount.Text = CalculateElapsedDays(daNo).ToString
            Me.txtDaysTaken.Text = CalculateDaysTakenToDetermine.ToString





            Me.DASummaryDataTableAdapter.Fill(Me.DAdatasets.DASummaryData, daNo)
            Me.CCSummaryDataTableAdapter.Fill(Me.DAdatasets.CCSummaryData, daNo)




            Me.RetrieveDAFileNumbersTableAdapter.Fill(Me.DAdatasets.RetrieveDAFileNumbers, daNo)
            Me.Property_NumbersTableAdapter.Fill(Me.DAdatasets.Property_Numbers, daNo)

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, daNo, "DA")
            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, daNo, "DA")
            Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, daNo)

            CalculateRefundsandPayments(daNo)
            Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, daNo, "DA")
            Me.RetrieveVariationsForDAAssessmentTableAdapter.Fill(Me.AssessmentData.RetrieveVariationsForDAAssessment, daNo)

            Me.SubmissionandObjectionsTableAdapter.Fill(Me.DAdatasets.SubmissionandObjections, daNo)

            ClearObjections()
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "DA", daNo)
            Me.RetrieveFileNotesTableAdapter.Fill(Me.DAdatasets.RetrieveFileNotes, daNo, "DA")
            Me.OneOffCondPriorToCCReleaseTableAdapter.Fill(Me.DAdatasets.OneOffCondPriorToCCRelease, daNo)
            Me.STDCondPrioerToCCReleaseTableAdapter.Fill(Me.DAdatasets.STDCondPrioerToCCRelease, daNo)
            Me.Da_DocType_WordTemplateTableAdapter.Fill(Me.DAdatasets.da_DocType_WordTemplate, "")


            If Me.cboConsentDocType.SelectedIndex <> -1 Then
                Me.ListofConditionsByLetterTypeTableAdapter.Fill(Me.DAdatasets.ListofConditionsByLetterType, New System.Nullable(Of Integer)(CType(cboConsentDocType.SelectedValue, Integer)))
            End If
            Me.LoadUpConditionListTableAdapter.Fill(Me.DAdatasets.LoadUpConditionList, daNo)
            Me.LoadOneUpConditionsTableAdapter.Fill(Me.DAdatasets.LoadOneUpConditions, daNo)
            Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, daNo)
            Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, daNo, "DA")
            'Me.RetrieveListOfReferralsbySystemTableAdapter.Fill(Me.DAdatasets.RetrieveListOfReferralsbySystem, "DA", daNo)
            ShowHistoricalDATableAdapter.Fill(Me.DAdatasets.ShowHistoricalDA, daNo)

            Try
                Me.RetrieveListOfReferralsbySystemTableAdapter.Fill(Me.DAdatasets.RetrieveListOfReferralsbySystem, "DA", daNo)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try



            '-------Load the section64 data------

            Try
                Me.LoadGridforProposedContributionsTableAdapter.Fill(Me.AAdata.LoadGridforProposedContributions, daNo)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            '------------------------------------

            '-------Load the section94 data------
            Try
                Me.LoadGridforProposedSect94ContributionsTableAdapter.Fill(Me.AAdata.LoadGridforProposedSect94Contributions, daNo)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            '------------------------------------

            '-------Load the Bond data------
            Try
                Me.LoadGridforProposedBondContributionsTableAdapter.Fill(Me.AAdata.LoadGridforProposedBondContributions, daNo)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            '------------------------------------

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        cboConsentDocType.SelectedIndex = -1

        ClearAddInfoData(grpAddinfo)

        btnSaveAddInfoTab.Enabled = False
        btnEditAddinfoTab.Enabled = False
        btnADDAddinfoTab.Enabled = True


        btnEditDA.Enabled = True
        Me.btnEditAddinfoTab.Enabled = True
        Me.btnEditReferralsTab.Enabled = True
        Me.btnAddReferral.Enabled = True
        btnEditAddinfoTab.Enabled = True

        btnEditDesc.Enabled = True
        btnEditIntDev.Enabled = True
        btnEditStatus.Enabled = True
        btnEdit79.Enabled = True

        If ViewOnly Then
            LockAccessIfViewOnly(Me)
            tabDAdata.TabPages.Remove(pgConsent)

        End If



    End Sub





    Private Function CalculateDaysTakenToDetermine() As Integer
        Dim ReturnValue As Integer = 0

        Dim daysAddinfo As Integer = NZ(Me.txtDaysAddinfo.Text)
        If daysAddinfo <> 0 Then
            ReturnValue = NZ(txtDaysElapsed.Text) - NZ(txtDaysAddinfo.Text)
        Else
            ReturnValue = NZ(txtDaysElapsed.Text)
        End If
        Return ReturnValue

    End Function

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Private Function FileExists(ByVal sFileNumber As String, ByRef errorMessage As String) As Boolean
        ' Confirm there is text in the control.
        If sFileNumber.Length = 0 Then
            errorMessage = "File number is required"
            Return False
        End If


        Using Connection As New SqlConnection(My.Settings.DataConnection)
            Dim Returnvalue As Boolean = False

            Try

                Using cmd As New SqlCommand


                    With cmd
                        .Connection = Connection
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckEASEFileExists"
                        .Parameters.Add("@FILENO", SqlDbType.VarChar, 20, Nothing)

                        .Parameters.Add("@OK", SqlDbType.Bit, 0, Nothing)
                        .Parameters("@OK").Direction = ParameterDirection.Output
                        .Parameters("@FILENO").Value = sFileNumber
                    End With


                    Connection.Open()
                    cmd.ExecuteNonQuery()


                    Returnvalue = DirectCast(cmd.Parameters("@OK").Value, Boolean)
                    Connection.Close()
                    If Not Returnvalue Then errorMessage = "This is not a valid file number"
                    Return Returnvalue
                End Using

            Catch ex As Exception
                MessageBox.Show("The following error has occured in routine FileExists " & ex.InnerException.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                errorMessage = "This is not a valid file number"
                Return Returnvalue
            End Try
        End Using

    End Function

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
                        .Parameters.Add("@SYSID", SqlDbType.VarChar).Value = "DA"
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


    Private Function CheckConditionAlreadyExists(ByVal condID As Integer) As Boolean
        Dim result As Boolean = False
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckConditionAlreadyExists routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckIfCodeDoseNoteExitInList"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = condID
                        .Parameters.Add("@EXIST", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CBool(.Parameters("@EXIST").Value)

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckConditionAlreadyExists routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function



    Private Sub InsertIntoDADocumentsTable(ByVal DocType As String, ByVal FileName As String)
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoDADocumentsTable routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertDocumentData"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "DA"
                        .Parameters.Add("@AUTHOR", SqlDbType.Int).Value = MyUserId
                        .Parameters.Add("@DOCTYPE", SqlDbType.NVarChar).Value = DocType
                        .Parameters.Add("@FILENAME", SqlDbType.NVarChar).Value = FileName
                        .ExecuteNonQuery()
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoDADocumentsTable routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function GetEmailAddress() As String
        Dim result As String = String.Empty

        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_GetOfficerEmailAddress"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(cboDAOfficer.SelectedValue)
                        .Parameters.Add("@EMAIL", SqlDbType.NVarChar, 200).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = .Parameters("@EMAIL").Value.ToString
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using
        Return result
    End Function

    Private Sub ClearReferralData(ByVal Pnl As Control)
        For Each ctrl As Control In Pnl.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.CheckState = CheckState.Unchecked

            End If
        Next
        Me.lblReferralID.Text = String.Empty

    End Sub

    Private Function CheckAdditionalInfo() As Boolean
        Dim result As Boolean = True

        If Not IsDate(AIRequestDt.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.AIRequestDt, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.AIRequestDt, "A request date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.AIRequestDt, "")

        End If
        If AICommentTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.AICommentTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.AICommentTextBox, "A comment is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.AICommentTextBox, "")

        End If
        Return result
    End Function

    Private Function FormNotesChecksOut() As Boolean
        Dim result As Boolean = True

        'Me.txtNotesFollowUp.Text = String.Empty
        'txtNotesReferredTo.Text = String.Empty

        If Not IsDate(NoteDate.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.btnNoteDate, ErrorIconAlignment.MiddleRight)
                .SetError(Me.btnNoteDate, "Date is a required value")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.btnNoteDate, "")

        End If

        If cboNoteType.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboNoteType, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboNoteType, "Required value")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboNoteType, "")

        End If

        If cboNotesOfficer.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboNotesOfficer, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboNotesOfficer, "Required value")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboNotesOfficer, "")

        End If

        If txtNotesSubject.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtNotesSubject, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtNotesSubject, "Required value")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtNotesSubject, "")

        End If

        If txtNoteDetails.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtNoteDetails, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtNoteDetails, "Required value")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtNoteDetails, "")

        End If


        If txtNotesSpokeTo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtNotesSpokeTo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtNotesSpokeTo, "Required value")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtNotesSpokeTo, "")

        End If



        If txtNotesContactNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtNotesContactNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtNotesContactNo, "Required value")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtNotesContactNo, "")

        End If


        Return result

    End Function

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
                    .SetError(Me.cboRFSSubDivisionType, "A value is required")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.cboRFSSubDivisionType, "")

            End If

            '    If Me.txtRFSSubLots.Text = String.Empty Then
            '        With ErrorProvider
            '            .SetIconAlignment(Me.txtRFSSubLots, ErrorIconAlignment.MiddleRight)
            '            .SetError(Me.txtRFSSubLots, "A comment is required")
            '        End With
            '        result = False
            '    Else
            '        ErrorProvider.SetError(Me.txtRFSSubLots, "")

            '    End If
        End If
        Return result
    End Function

    Private Sub DisplayChecks()


        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_DisplayTicks"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)


                        If IsDBNull(objDataRow.Item("GenImpactCompt")) Then
                            Me.picGenImpacts.Visible = False
                        Else
                            Me.picGenImpacts.Visible = CBool(objDataRow.Item("GenImpactCompt"))
                        End If

                        If IsDBNull(objDataRow.Item("DPComplt")) Then
                            Me.picDP.Visible = False
                        Else
                            Me.picDP.Visible = CBool(objDataRow.Item("DPComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("ThreatenSpecComplt")) Then
                            Me.picThreaten.Visible = False
                        Else
                            Me.picThreaten.Visible = CBool(objDataRow.Item("ThreatenSpecComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("TraficComplt")) Then
                            Me.picTraffic.Visible = False
                        Else
                            Me.picTraffic.Visible = CBool(objDataRow.Item("TraficComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("SocialComplt")) Then
                            Me.picSocial.Visible = False
                        Else
                            Me.picSocial.Visible = CBool(objDataRow.Item("SocialComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("DDAComplt")) Then
                            Me.picDDA.Visible = False
                        Else
                            Me.picDDA.Visible = CBool(objDataRow.Item("DDAComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("HeritageComplt")) Then
                            Me.picHeritage.Visible = False
                        Else
                            Me.picHeritage.Visible = CBool(objDataRow.Item("HeritageComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("LandScapeComplt")) Then
                            Me.picLandscape.Visible = False
                        Else
                            Me.picLandscape.Visible = CBool(objDataRow.Item("LandScapeComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("SustainComplt")) Then
                            Me.picSustain.Visible = False
                        Else
                            Me.picSustain.Visible = CBool(objDataRow.Item("SustainComplt"))
                        End If

                        If IsDBNull(objDataRow.Item("SubDiviComplte")) Then
                            Me.picSubDivision.Visible = False
                        Else
                            Me.picSubDivision.Visible = CBool(objDataRow.Item("SubDiviComplte"))
                        End If

                        If IsDBNull(objDataRow.Item("LEPComplt")) Then
                            Me.picLEP.Visible = False
                        Else
                            Me.picLEP.Visible = CBool(objDataRow.Item("LEPComplt"))
                        End If


                        If IsDBNull(objDataRow.Item("SEPPComplt")) Then
                            Me.picSEPP.Visible = False
                        Else
                            Me.picSEPP.Visible = CBool(objDataRow.Item("SEPPComplt"))
                        End If


                        If IsDBNull(objDataRow.Item("DCPComplt")) Then
                            Me.picDCP.Visible = False
                        Else
                            Me.picDCP.Visible = CBool(objDataRow.Item("DCPComplt"))
                        End If


                        If IsDBNull(objDataRow.Item("DAMSComplt")) Then
                            Me.picDAMS.Visible = False
                        Else
                            Me.picDAMS.Visible = CBool(objDataRow.Item("DAMSComplt"))
                        End If


                        If IsDBNull(objDataRow.Item("REPComplt")) Then
                            Me.picREP.Visible = False
                        Else
                            Me.picREP.Visible = CBool(objDataRow.Item("REPComplt"))
                        End If


                        If IsDBNull(objDataRow.Item("Guidlines")) Then
                            Me.picGUIDES.Visible = False
                        Else
                            Me.picGUIDES.Visible = CBool(objDataRow.Item("Guidlines"))
                        End If


                        If IsDBNull(objDataRow.Item("DCPCheckListComplt")) Then
                            Me.picDCPchkList.Visible = False
                        Else
                            Me.picDCPchkList.Visible = CBool(objDataRow.Item("DCPCheckListComplt"))
                        End If
                    End If


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using






    End Sub


    Private Sub ClearAddInfoData(ByVal pnl As Control)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
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

        Me.lblAdditionalInfoId.Text = String.Empty
    End Sub


    Private Function modificationConclusionChecksOut() As Boolean
        Dim result As Boolean = True

        If Not IsDate(txtProposedDetermDate.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.txtProposedDetermDate, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.txtProposedDetermDate, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtProposedDetermDate, "")

        End If

        If Me.cboModSec96Comply.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModSec96Comply, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboModSec96Comply, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboModSec96Comply, "")

        End If
        If Me.cboModSec79Satisfactory.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModSec79Satisfactory, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboModSec79Satisfactory, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboModSec79Satisfactory, "")

        End If
        If Me.cboModAssessmentDecision.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModAssessmentDecision, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboModAssessmentDecision, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboModAssessmentDecision, "")

        End If

        If Me.cboModAuthority.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModAuthority, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboModAuthority, "A comment is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboModAuthority, "")

        End If


        If Me.ApplicationConclreasonsTextBox.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.ApplicationConclreasonsTextBox, ErrorIconAlignment.MiddleRight)
                .SetError(Me.ApplicationConclreasonsTextBox, "A comment is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.ApplicationConclreasonsTextBox, "")

        End If
        Return result
    End Function

    Private Function ConclusionChecksOut() As Boolean
        Dim result As Boolean = True

        If Not IsDate(txtConclusionDate.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.txtConclusionDate, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.txtConclusionDate, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtConclusionDate, "")

        End If

        If Me.cboReferralsYesNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboReferralsYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboReferralsYesNo, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboReferralsYesNo, "")

        End If
        If Me.cboComplianceStatProvYesNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboComplianceStatProvYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboComplianceStatProvYesNo, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboComplianceStatProvYesNo, "")

        End If
        If Me.cboVariationsYesNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboVariationsYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboVariationsYesNo, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboVariationsYesNo, "")

        End If

        If Me.cboApplicationConclResult.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboApplicationConclResult, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboApplicationConclResult, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboApplicationConclResult, "")

        End If

        If Me.cboAuthority.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboAuthority, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboAuthority, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboAuthority, "")

        End If


        If Me.txtApplicationConclreasons.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtApplicationConclreasons, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtApplicationConclreasons, "A comment is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtApplicationConclreasons, "")

        End If
        Return result
    End Function

    Private Function VariationOK() As Boolean
        Dim result As Boolean = True

        'If Not IsDate(variationDecisionDate.Text) Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.cboVariationType, ErrorIconAlignment.MiddleLeft)
        '        .SetError(Me.cboVariationType, "This is a required field")
        '    End With
        '    result = False
        'Else
        '    ErrorProvider.SetError(Me.cboVariationType, "")

        'End If

        If Me.cboOfficerRecomforVariation.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboOfficerRecomforVariation, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboOfficerRecomforVariation, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboOfficerRecomforVariation, "")

        End If

        If Me.cboVariationType.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboVariationType, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboVariationType, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboVariationType, "")

        End If

        Return result
    End Function

#End Region

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
                    Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtDANo.Text, "DA")
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
                Me.ReferralsIntegratedProvisionTableAdapter.Fill(Me.DAdatasets.ReferralsIntegratedProvision, txtDANo.Text, "DA")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

#End Region

#Region "Variation Tab"

    Private Sub dgvVariations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvVariations.Click
        If dgvVariations.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub
        lblID.Text = dgvVariations.CurrentRow.Cells(0).Value.ToString
        Me.cboVariationType.Text = dgvVariations.CurrentRow.Cells(1).Value.ToString
        txtVariationDetails.Text = dgvVariations.CurrentRow.Cells(2).Value.ToString
        Me.cboVariationResult.Text = dgvVariations.CurrentRow.Cells(3).Value.ToString
        Me.cboVariationAuthority.Text = dgvVariations.CurrentRow.Cells(4).Value.ToString
        Dim valuetocheck As String = dgvVariations.CurrentRow.Cells(5).Value.ToString
        If valuetocheck <> String.Empty Then
            Me.variationDecisionDate.Text = Format(CDate(dgvVariations.CurrentRow.Cells(5).Value.ToString), "dd/MM/yyyy")
        End If
        Me.cboOfficerRecomforVariation.SelectedValue = dgvVariations.CurrentRow.Cells(6).Value.ToString
        txtOfficersReasons.Text = dgvVariations.CurrentRow.Cells(7).Value.ToString


        Me.btnEditVariation.Enabled = True
        Me.btnSaveVariation.Enabled = False
        Me.btnAddVariation.Enabled = True

    End Sub

    Private Sub btnAddVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddVariation.Click
        lblID.Text = "0"
        Me.cboVariationType.SelectedIndex = -1
        txtVariationDetails.Text = String.Empty
        Me.cboVariationResult.SelectedIndex = -1
        Me.cboVariationAuthority.SelectedIndex = -1
        Me.variationDecisionDate.Text = String.Empty
        Me.btnSaveVariation.Enabled = True
        btnAddVariation.Enabled = False

        lockVariationFields(False)
    End Sub

    Private Sub lockVariationFields(ByVal lock As Boolean)
        Me.cboVariationType.Enabled = Not lock
        txtVariationDetails.ReadOnly = lock
        cboOfficerRecomforVariation.Enabled = Not lock
        Me.txtOfficersReasons.ReadOnly = lock
        txtVariationDetails.ReadOnly = lock
        cboOfficerRecomforVariation.Enabled = Not lock
        btnDecisionDate.Enabled = Not lock
        btnSaveVariation.Enabled = Not lock

    End Sub

    Private Sub LockVariationResponseFields(ByVal lock As Boolean)
        Me.cboVariationResult.Enabled = Not lock
        Me.cboVariationAuthority.Enabled = Not lock
        Me.variationDecisionDate.ReadOnly = True
        btnDecisionDate.Enabled = Not lock

    End Sub
    Private Sub btnSaveVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariation.Click

        If Not VariationOK() Then Exit Sub

        If MessageBox.Show("Update add this variation?" & txtFile.Text & " ?", "Add amend Variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateAssessmentVariationRecord"
                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(lblID.Text)
                        .Parameters.Add("@DETAIL", SqlDbType.VarChar).Value = Me.txtVariationDetails.Text
                        'If IsDate(variationDecisionDate.Text) Then .Parameters.Add("@DATE", SqlDbType.SmallDateTime).Value = CDate(variationDecisionDate.Text)
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                        .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboVariationType.SelectedValue)
                        '.Parameters.Add("@RESULT", SqlDbType.VarChar).Value = Me.cboVariationResult.SelectedValue.ToString
                        '.Parameters.Add("@AUTHORITY", SqlDbType.SmallInt).Value = CInt(Me.cboVariationAuthority.SelectedValue)
                        .Parameters.Add("@OFFRRECOMD", SqlDbType.VarChar).Value = Me.cboOfficerRecomforVariation.SelectedValue.ToString
                        .Parameters.Add("@REASON", SqlDbType.NText).Value = txtOfficersReasons.Text

                        .ExecuteNonQuery()
                    End With

                End Using
                 
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        Try
            Me.RetrieveVariationsForDAAssessmentTableAdapter.Fill(Me.AssessmentData.RetrieveVariationsForDAAssessment, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        btnSaveVariation.Enabled = False
        btnEditVariation.Enabled = True
        btnAddVariation.Enabled = True
        btnDecisionDate.Enabled = False
        lblID.Text = "0"

        Me.cboVariationType.SelectedIndex = -1
        txtVariationDetails.Text = String.Empty
        Me.cboVariationResult.SelectedIndex = -1
        Me.cboVariationAuthority.SelectedIndex = -1
        cboOfficerRecomforVariation.SelectedIndex = -1
        txtOfficersReasons.Text = String.Empty
        Me.variationDecisionDate.Text = String.Empty
        lockVariationFields(True)

    End Sub

    Private Sub btnEditVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditVariation.Click
        lockVariationFields(False)
        btnEditVariation.Enabled = False
    End Sub
#End Region


#Region "Objection tab"

    Private Sub dgvSubmissionandObjections_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSubmissionandObjections.Click
        '

        If dgvSubmissionandObjections.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvSubmissionandObjections_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadSubmissionAndObjections"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvSubmissionandObjections.CurrentRow.Cells(0).Value)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.txtSubmissionSummary.Text = objDataRow.Item("SubmissionSummary").ToString
                        Me.txtOfficerComment.Text = objDataRow.Item("OfficerNotes").ToString
                        Me.cboSubmissionType.SelectedValue = objDataRow.Item("SubmissionType").ToString
                        Me.txtAuthorName.Text = objDataRow.Item("AuthorName").ToString
                        Me.txtAuthurAddress.Text = objDataRow.Item("AuthorAddressLine1").ToString
                        Me.txtAuthorTown.Text = objDataRow.Item("AuthorAddressLine2").ToString
                        Me.txtAuthorPCode.Text = objDataRow.Item("AuthorPcode").ToString
                        Me.txtAuthorPhone.Text = objDataRow.Item("AuthorPhone").ToString
                        Me.SubRecdDate.Text = Format(CDate(objDataRow.Item("DateReceived")), "dd/MM/yyyy")
                        lblSubID.Text = objDataRow.Item("id").ToString


                    End If



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in dgvSubmissionandObjections_Click routine - form " & Me.Name)

            End Try
        End Using




        Me.btnEditSub.Enabled = True
        Me.btnSaveSub.Enabled = False
        Me.btnAddSub.Enabled = True

    End Sub

    Private Sub ClearObjections()
        Me.txtSubmissionSummary.Text = String.Empty
        Me.txtOfficerComment.Text = String.Empty
        Me.cboSubmissionType.SelectedIndex = -1
        Me.txtAuthorName.Text = String.Empty
        Me.txtAuthurAddress.Text = String.Empty
        Me.txtAuthorTown.Text = String.Empty
        Me.txtAuthorPCode.Text = String.Empty
        Me.txtAuthorPhone.Text = String.Empty
        Me.SubRecdDate.Text = String.Empty
        lblSubID.Text = "0"

    End Sub

    Private Sub LockSubmissionFields(ByVal Lock As Boolean)
        Me.txtSubmissionSummary.ReadOnly = Lock
        Me.txtOfficerComment.ReadOnly = Lock
        Me.cboSubmissionType.Enabled = Not Lock
        Me.txtAuthorName.ReadOnly = Lock
        Me.txtAuthurAddress.ReadOnly = Lock
        Me.txtAuthorTown.ReadOnly = Lock
        Me.txtAuthorPCode.ReadOnly = Lock
        Me.txtAuthorPhone.ReadOnly = Lock
        Me.SubRecdDate.ReadOnly = True
        btnSubRecdDate.Enabled = Not Lock
        Me.btnSaveSub.Enabled = Not Lock

    End Sub

    Private Sub btnAddSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddSub.Click
        ClearObjections()
        LockSubmissionFields(False)
        btnEditSub.Enabled = False
        btnSaveSub.Enabled = True
        btnAddSub.Enabled = False

    End Sub

    Private Sub btnEditSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditSub.Click
        LockSubmissionFields(False)
        btnEditSub.Enabled = False
        btnSaveSub.Enabled = True
        btnAddSub.Enabled = True

    End Sub

    Private Sub btnSaveSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveSub.Click
        If MessageBox.Show("Update add submission?" & txtFile.Text & " ?", "Add amend submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveSub_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateObjections"
                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(lblSubID.Text)
                        .Parameters.Add("@FILENO", SqlDbType.VarChar).Value = Me.txtFileNo.Text
                        If IsDate(SubRecdDate.Text) Then .Parameters.Add("@DATERECD", SqlDbType.SmallDateTime).Value = CDate(SubRecdDate.Text)
                        .Parameters.Add("@SUBMISSION", SqlDbType.Text).Value = txtSubmissionSummary.Text
                        .Parameters.Add("@NOTES", SqlDbType.Text).Value = Me.txtOfficerComment.Text
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                        .Parameters.Add("@PHONE", SqlDbType.VarChar).Value = txtAuthorPhone.Text
                        .Parameters.Add("@NAME", SqlDbType.VarChar).Value = txtAuthorName.Text
                        .Parameters.Add("@ADDRESS", SqlDbType.VarChar).Value = txtAuthurAddress.Text
                        .Parameters.Add("@PCODE", SqlDbType.VarChar).Value = txtAuthorPCode.Text
                        .Parameters.Add("@TYPE", SqlDbType.VarChar).Value = cboSubmissionType.SelectedValue.ToString
                        .Parameters.Add("@TOWN", SqlDbType.VarChar).Value = Me.txtAuthorTown.Text
                        .ExecuteNonQuery()
                    End With

                End Using
                 
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveSub_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        Try
            SubmissionandObjectionsTableAdapter.Fill(Me.DAdatasets.SubmissionandObjections, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        btnSaveSub.Enabled = False
        btnEditSub.Enabled = True
        btnAddSub.Enabled = True
        btnSubRecdDate.Enabled = False
        ClearObjections()
        LockSubmissionFields(True)

    End Sub
#End Region

#Region "Documents Tab"
    Private Sub dgvDocumentsList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDocumentsList.CellClick
        If IsANonHeaderButtonCell(e) Then
            DisplayPDFdocument()
        ElseIf IsANonHeaderTextCell(e) Then
            txtDocNote.Text = dgvDocumentsList.CurrentRow.Cells(6).Value.ToString
            Me.btnRemoveDocument.Enabled = True

        End If

    End Sub

    Private Function IsANonHeaderTextCell(ByVal cellEvent As  _
          DataGridViewCellEventArgs) As Boolean
        If cellEvent.ColumnIndex = -1 Then Exit Function
        If TypeOf dgvDocumentsList.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewTextBoxColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
            Return True Else Return (False)

    End Function

    Private Function IsANonHeaderButtonCell(ByVal cellEvent As  _
        DataGridViewCellEventArgs) As Boolean
        If cellEvent.ColumnIndex = -1 Then Exit Function
        If TypeOf dgvDocumentsList.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
            Return True Else Return (False)

    End Function

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



        If Is64BitOperatingSystem Then

            If sPDFDoc <> String.Empty Then WebBrowser1.Navigate(sPDFDoc)

        Else

            If sPDFDoc <> String.Empty Then
                Dim PDFviewer As New PDFviewer
                With PDFviewer
                    .DocumentToDisplay = sPDFDoc
                    .ShowDialog()
                    .Dispose()
                End With
            End If


        End If




    End Sub
#End Region

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
                        .Parameters.Add("@ID", SqlDbType.NText).Value = Me.txtDocNote.Text
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(dgvDocumentsList.CurrentRow.Cells(10).Value)
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
            RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "DA", txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClearNoteFields()
        Me.NoteDate.Text = String.Empty
        Me.txtNotesSubject.Text = String.Empty
        Me.txtNoteDetails.Text = String.Empty
        Me.txtNotesContactNo.Text = String.Empty
        Me.cboNoteType.SelectedIndex = -1
        Me.txtNotesSpokeTo.Text = String.Empty
        Me.txtNotesCC.Text = String.Empty
        Me.txtNotesFollowUp.Text = String.Empty
        lblNotesID.Text = "0"
        txtNotesReferredTo.Text = String.Empty
        Me.cboNotesOfficer.SelectedIndex = -1
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
        txtNotesReferredTo.ReadOnly = lock

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

                        Me.NoteDate.Text = Format(CDate(objDataRow.Item("NoteDate").ToString), "dd/MM/yyyy")
                        Me.txtNotesSubject.Text = objDataRow.Item("Subject").ToString
                        Me.txtNoteDetails.Text = objDataRow.Item("Detail").ToString
                        Me.txtNotesContactNo.Text = objDataRow.Item("ContactNumber").ToString
                        Me.cboNoteType.SelectedValue = objDataRow.Item("NoteType").ToString
                        Me.txtNotesSpokeTo.Text = objDataRow.Item("SpokenTo").ToString
                        Me.txtNotesCC.Text = objDataRow.Item("CarbonCopy").ToString
                        Me.txtNotesFollowUp.Text = objDataRow.Item("FollowUp").ToString
                        Me.cboNotesOfficer.SelectedValue = CInt(objDataRow.Item("Author").ToString)
                        Me.lblNotesID.Text = objDataRow.Item("id").ToString
                        txtNotesReferredTo.Text = objDataRow.Item("ReferredTo").ToString
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

        If Not FormNotesChecksOut Then Exit Sub

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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
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
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@REFERRED", SqlDbType.NVarChar).Value = Me.txtNotesReferredTo.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Me.Name)

            End Try
        End Using

        Me.RetrieveFileNotesTableAdapter.Fill(Me.DAdatasets.RetrieveFileNotes, txtDANo.Text, "DA")



    End Sub

#End Region

#Region "PCA Cond Tab"
    Private Sub dgvSTDCond_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSTDCond.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If TypeOf Me.dgvSTDCond.Columns(e.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not e.RowIndex = -1 Then
            UpdateConditionDate(1)
            Try
                Me.OneOffCondPriorToCCReleaseTableAdapter.Fill(Me.DAdatasets.OneOffCondPriorToCCRelease, Me.txtDANo.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            Try
                Me.STDCondPrioerToCCReleaseTableAdapter.Fill(Me.DAdatasets.STDCondPrioerToCCRelease, Me.txtDANo.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub UpdateConditionDate(ByVal type As Integer)
        If MessageBox.Show("Mark this condition as being met now?", "Mark condition met", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateConditionDate routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_MarkConditionAsBeingMet"

                        .Parameters.Add("@IDNO", SqlDbType.Int).Value = CInt(dgvSTDCond.CurrentRow.Cells(0).Value)
                        .Parameters.Add("@TYPE", SqlDbType.TinyInt).Value = type
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateConditionDate routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub dgvOneOffConditions_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOneOffConditions.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If TypeOf Me.dgvOneOffConditions.Columns(e.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not e.RowIndex = -1 Then UpdateConditionDate(2)

    End Sub

#End Region

#Region "From Events"

    Private Sub btnAddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFile.Click
        If txtFile.Text <> "" Then
            If MessageBox.Show("Add file number " & txtFile.Text & " ?", "Add File", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Using cn As New SqlConnection(My.Settings.DataConnection)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddFile_Click routine - form " & Me.Name)

                    End Try


                    Try

                        Using cmd As New SqlCommand

                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_InsertNewFileNumber"
                                .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                                .Parameters.Add("@FILENO", SqlDbType.VarChar).Value = txtFile.Text
                                .ExecuteNonQuery()
                            End With

                        End Using
                         
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddFile_Click routine - form " & Me.Name)

                    End Try
                End Using
                'reload file numbers
                Try
                    Me.RetrieveDAFileNumbersTableAdapter.Fill(Me.DAdatasets.RetrieveDAFileNumbers, txtDANo.Text)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                txtFile.Text = ""
            End If
        End If

    End Sub

    Private Sub btnRemoveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFile.Click
        If MessageBox.Show("Remove file number " & lstFile.Text & " ?", "Remove File", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.DataConnection)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in lstFile_SelectedIndexChanged routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_RemoveDAFileNumber"
                            .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                            .Parameters.Add("@BARCODE", SqlDbType.VarChar).Value = lstFile.SelectedValue.ToString
                            .ExecuteNonQuery()
                        End With

                    End Using
                     
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in lstFile_SelectedIndexChanged routine - form " & Me.Name)

                End Try
            End Using

            'reload file numbers
            Try
                Me.RetrieveDAFileNumbersTableAdapter.Fill(Me.DAdatasets.RetrieveDAFileNumbers, txtDANo.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub

    Private Sub txtFile_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFile.Validating
        Dim errorMsg As String = String.Empty
        If Not FileExists(txtFile.Text, errorMsg) Then
            ErrorProvider.SetIconAlignment(Me.txtFile, ErrorIconAlignment.MiddleRight)
            ErrorProvider.SetIconPadding(Me.txtFile, 1)
            ErrorProvider.SetError(Me.txtFile, "This is not a valid file number.")
            txtFile.Select(0, txtFile.Text.Length)
            'e.Cancel = True

        Else

            ' Clear the error, if any, in the error provider.
            ErrorProvider.SetError(Me.txtFile, "")

        End If

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        KeyPressSendTab(e)
    End Sub

    'Private Sub cboConsentDocType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboConsentDocType.SelectedValueChanged
    '    If cboConsentDocType.SelectedIndex = -1 Then Exit Sub
    '    Try
    '        Me.ListofConditionsByLetterTypeTableAdapter.Fill(Me.DAdatasets.ListofConditionsByLetterType, New System.Nullable(Of Integer)(CType(cboConsentDocType.SelectedValue, Integer)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
    Private Sub cboConsentDocType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboConsentDocType.SelectedValueChanged
        If cboConsentDocType.SelectedIndex = -1 Then Exit Sub
        Try
            Me.ListofConditionsByLetterTypeTableAdapter.Fill(Me.DAdatasets.ListofConditionsByLetterType, New System.Nullable(Of Integer)(CType(cboConsentDocType.SelectedValue, Integer)))

            Dim RowCount As Integer = DAdatasets.ListofConditionsByLetterType.Rows.Count
            If RowCount = 0 Then
                btnAddCondition.Enabled = False
                cboSTDconditions.Enabled = False
            Else
                cboSTDconditions.Enabled = True
                btnAddCondition.Enabled = True
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub InsertNewCondition()
        If cboSTDconditions.SelectedIndex = -1 Then Exit Sub

        If CheckConditionAlreadyExists(CInt(cboSTDconditions.SelectedValue)) Then
            MessageBox.Show("Condition """ & Me.cboSTDconditions.Text & """ already exist in the list", "Insert condition", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertIndividualSTDCondition"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(cboSTDconditions.SelectedValue)
                        .ExecuteNonQuery()

                    End With

                    Try
                        Me.LoadUpConditionListTableAdapter.Fill(Me.DAdatasets.LoadUpConditionList, Me.txtDANo.Text)
                    Catch ex As System.Exception
                        System.Windows.Forms.MessageBox.Show(ex.Message)
                    End Try


                End Using
                 
                cboSTDconditions.SelectedIndex = -1


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub
    Private Sub btnAddCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCondition.Click
        'If MessageBox.Show("Insert """ & Me.cboSTDconditions.Text & """ into the list?", "Insert condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        InsertNewCondition()
        cboSTDconditions.Focus()

    End Sub

    Private Sub btnAddOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOneOffCond.Click
        Dim fOneUpCond As New InsertOneUpCondition
        With fOneUpCond
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()

        End With

        Try
            LoadOneUpConditionsTableAdapter.Fill(Me.DAdatasets.LoadOneUpConditions, Me.txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgvSTDConditions_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSTDConditions.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If TypeOf Me.dgvSTDConditions.Columns(e.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not e.RowIndex = -1 Then
            If CBool(dgvSTDConditions.CurrentRow.Cells(2).Value) Then
                Dim fFreeForm As New DAConditionsFreeForm
                With fFreeForm
                    .ConditionCode = CInt(dgvSTDConditions.CurrentRow.Cells(0).Value)
                    .DANumber = Me.txtDANo.Text

                    .ShowDialog()
                    .Dispose()

                End With
            End If

        End If

    End Sub

    Private Sub btnRemoveOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveOneOffCond.Click

        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveOneOffCond_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveOneUpCondition"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvOneUpConditions.CurrentRow.Cells(2).Value)
                        .ExecuteNonQuery()
                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveOneOffCond_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnRemoveCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveCondition.Click


        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveConditionCode"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvSTDConditions.CurrentRow.Cells(0).Value)
                        .ExecuteNonQuery()
                    End With



                End Using
                 

                Me.LoadUpConditionListTableAdapter.Fill(Me.DAdatasets.LoadUpConditionList, txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnAddDefaultCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDefaultCondition.Click
        Dim Procedurename As String = String.Empty
        If cboConsentDocType.SelectedIndex = -1 Then
            MessageBox.Show("You need to select a document type!", "Add Default Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("You are about to add the default conditions for this assessment/document type to the list of conditions for this DA!", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If Me.cboAssessmentType.SelectedIndex = -1 Then

            Procedurename = "usp_GetDefaultConditions_no_assType"

        Else
            Procedurename = "usp_GetDefaultConditions_assType"
        End If

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddDefaultCondition_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = Procedurename
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@DOCTYPE", SqlDbType.Int).Value = CInt(cboConsentDocType.SelectedValue)
                        .Parameters.Add("@ASSTYPE", SqlDbType.Int).Value = CInt(cboAssessmentType.SelectedValue)
                        .ExecuteNonQuery()
                    End With
                End Using
                 

                Me.LoadUpConditionListTableAdapter.Fill(Me.DAdatasets.LoadUpConditionList, Me.txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddDefaultCondition_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        'TODO: Write  code for Condition setup button - this is a maintenance function be look at end of coding

    End Sub

    Private Sub btnViewEditDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEditDocument.Click
        If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub
        Try
            Dim objWordApp As New Microsoft.Office.Interop.Word.Application
            Dim objWordDoc As Microsoft.Office.Interop.Word.Document = objWordApp.Application.Documents.Open(Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString)
            objWordDoc.Activate()
            objWordApp.Visible = True

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnDeleteDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDoc.Click
        If Me.dgvDraftDocs.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub
        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells(3).Value.ToString

        If MessageBox.Show("You are about to delete this word document FOREVER" & vbCrLf & "OK to proceed?", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_RemoveDraftDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells(4).Value)
                        .ExecuteNonQuery()
                    End With


                End Using
                 

                My.Computer.FileSystem.DeleteFile(FileToDelete)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnFinaliseDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinaliseDoc.Click

        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        InsertIntoDADocumentsTable(dgvDraftDocs.CurrentRow.Cells(1).Value.ToString, sDocumentNo.Replace(".", "_"))

        Dim summary As String = "Application No. " & txtDANo.Text & " Application Type: DA Document Type: " & dgvDraftDocs.CurrentRow.Cells(1).Value.ToString



        Dim fEASE As New InsertEASEDocument
        With fEASE
            .WordDocLocation = dgvDraftDocs.CurrentRow.Cells(3).Value.ToString
            .CustName = OwnersName
            .CustAddress = OwnersAddress & " " & OwnersTown & " " & OwnersPostCode
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = Me.txtFileNo.Text
            .ShowDialog()
            .Dispose()
        End With

        Dim InsertDocData As New InsertDocumentData
        With InsertDocData
            .ApplicationType = "DA"
            .DocumentType = dgvDraftDocs.CurrentRow.Cells(1).Value.ToString
            .ApplicationNo = Me.txtDANo.Text
            .TheAuthor = MyUserId
            .TheImageName = Replace(sDocumentNo, ".", "_")
            .Notes = txtLetterNotes.Text
            .InsertDocumentsIntoDAsystem()
        End With



        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells(3).Value.ToString
        My.Computer.FileSystem.DeleteFile(FileToDelete)

        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_RemoveDraftDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells(4).Value)
                        .ExecuteNonQuery()
                    End With
                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        Try
            Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnPrintAddinfoLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAddinfoLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue an AddInfo Request letter. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAddinfoLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Additional Information Request letter" & Me.txtDANo.Text, "AddInfo_Request_Letter.rpt", 2, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAddinfoLetter_Click routine ")
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
            Dim strReportPath As String = My.Settings.ReportLocation & reportName

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


            rptDocument.PrintToPrinter(1, False, 1, 1)

            If Copies = 2 Then

                Dim myPrintOptionsTwo As PrintOptions = rptDocument.PrintOptions
                myPrintOptionsTwo.PrinterName = My.Settings.DefaultPrinter
                myPrintOptionsTwo.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
                myPrintOptionsTwo.CustomPaperSource = GetSelectedSecondPaperSource()
                rptDocument.PrintToPrinter(1, False, 1, 1)

            End If
            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\test\test.pdf")


            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            Dim fEase As New OutwardEaseCorro

            With fEase
                .CustName = OwnerName
                .CustAddress = OwnerAddress
                .FileNumber = FileNo
                .DocSummary = Summary & Me.txtDANo.Text
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
                    .ApplicationType = "DA"
                    .DocumentType = DocType
                    .ApplicationNo = Me.txtDANo.Text
                    .TheAuthor = MyUserId
                    .TheImageName = Replace(strDocumentNo, ".", "_")
                    .Notes = txtLetterNotes.Text
                    .InsertDocumentsIntoDAsystem()
                End With

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")
        Finally
            rptDocument.Close()

        End Try


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



            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\test\test.pdf")

            'Dim strDocumentNo As String = GetNextDocumentNumber()
            'Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            'Dim fEase As New OutwardEaseCorro

            'With fEase
            '    .CustName = OwnerName
            '    .CustAddress = OwnerAddress
            '    .FileNumber = FileNo
            '    .DocSummary = Summary & Me.txtDANo.Text
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

    Private Sub btnPrint100DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint100DayLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue the first follow-up letter for AddInfo over 100 days. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint100DayLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "First follow-up letter for AddInfo over 100 days" & Me.txtDANo.Text, "Over100DayLetter.rpt", 2, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint100DayLetter_Click routine ")
            End Try
        End Using
        Over100LetterDate.Text = Format(Today.Date, "dd/MM/yyyy")
        SaveAddInfoData()

    End Sub

    Private Sub btnPrint200DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint200DayLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue the first follow-up letter for AddInfo over 200 days. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint200DayLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "First follow-up letter for AddInfo over 200 days" & Me.txtDANo.Text, "Over200Day_A_Letter.rpt", 2, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint200DayLetter_Click routine ")
            End Try
        End Using
        Over200LetterADate.Text = Format(Today.Date, "dd/MM/yyyy")
        SaveReferralData()

    End Sub

    Private Sub btnPrintOver200DayLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintOver200DayLetter.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue the FINAL follow-up letter for AddInfo over 200 days. OK to proceed?", "Print Addinfo Followup?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintOver200DayLetter_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AddInfo_Request"
                        .Parameters.Add("@AINO", SqlDbType.Int).Value = CInt(lblAdditionalInfoId.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "FINAL follow-up letter for AddInfo over 200 days" & Me.txtDANo.Text, "Over200Day_B_Letter.rpt", 2, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintOver200DayLetter_Click routine ")
            End Try
        End Using

        Over200LetterBDate.Text = Format(Today.Date, "dd/MM/yyyy")
        SaveReferralData()

    End Sub

    Private Sub btnEditAddinfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAddinfoTab.Click
        LockTheForm(grpAddinfo, True)
        btnEditAddinfoTab.Enabled = False
        btnSaveAddInfoTab.Enabled = True
        btnPrintAddinfoLetter.Enabled = False
        btnPrint200DayLetter.Enabled = False
        btnPrint100DayLetter.Enabled = False
        btnPrintOver200DayLetter.Enabled = False

    End Sub

    Private Sub SaveAddInfoData()
        LockTheForm(grpAddinfo, False)
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveAddInfoData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_AdditionalInfo"

                        .Parameters.Add("@IDNO", SqlDbType.Int).Value = NZ(lblAdditionalInfoId.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@REQDATE", SqlDbType.SmallDateTime)
                        If IsDate(AIRequestDt.Text) Then .Parameters("@REQDATE").Value = Format(CDate(AIRequestDt.Text), "dd/MM/yyyy")


                        .Parameters.Add("@RECDDTE", SqlDbType.SmallDateTime)
                        If IsDate(AIReceivedDt.Text) Then .Parameters("@RECDDTE").Value = Format(CDate(AIReceivedDt.Text), "dd/MM/yyyy")

                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = AICommentTextBox.Text
                        .Parameters.Add("@LETRA200DTE", SqlDbType.SmallDateTime)
                        If IsDate(Over200LetterADate.Text) Then .Parameters("@LETRA200DTE").Value = Format(CDate(Over200LetterADate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@LETRB200DTE", SqlDbType.SmallDateTime)
                        If IsDate(Over200LetterBDate.Text) Then .Parameters("@LETRB200DTE").Value = Format(CDate(Over200LetterBDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@LETR100DTE", SqlDbType.SmallDateTime)
                        If IsDate(Over100LetterDate.Text) Then .Parameters("@LETR100DTE").Value = Format(CDate(Over100LetterDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"
                        .Parameters.Add("@RequestNo", SqlDbType.Int).Direction = ParameterDirection.Output


                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveAddInfoTab_Click routine - form " & Me.Name)

            End Try
        End Using



        Try
            Me.RetrieveListOfReferralsbySystemTableAdapter.Fill(Me.DAdatasets.RetrieveListOfReferralsbySystem, "DA", txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try




    End Sub
    Private Sub btnSaveAddInfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAddInfoTab.Click
        If Not CheckAdditionalInfo() Then Exit Sub

        SaveAddInfoData()

        btnSaveAddInfoTab.Enabled = False
        btnEditAddinfoTab.Enabled = False
        btnADDAddinfoTab.Enabled = True

        ClearAddInfoData(grpAddinfo)

    End Sub

    Private Sub btnDraftconditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraftconditions.Click
        Dim fDraftConditions As New DraftConditions
        With fDraftConditions
            .TheReferralId = CInt(lblReferralID.Text)
            .ApplicationID = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnMailResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMailResponse.Click
        If Me.txtRefResponse.Text = String.Empty Then
            MessageBox.Show("There is nothing typed in the response area - please complete and try again", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Subject As String = "Referral Response for Appl No: " & Me.txtDANo.Text
        Dim Body As String = "Please find attached my response to your referral regarding application number " & vbCrLf & txtRefResponse.Text

        'Dim mailaddress As String = ADHelper.GetEmailAddress(ADHelper.GetLoginName)
        Dim emailaddress As String = GetEmailAddress()
        If emailaddress = String.Empty Then
            MessageBox.Show("Responsible Officer Not selected - Can't send e-mail !", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            'MAIL.SendMailMessage(mailaddress, emailaddress, "", "", Subject, Body, "")

            Dim OutlookHlp As New OutlookHelper

            OutlookHlp.SendMail(emailaddress, "", "", Subject, Body, "")


        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

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

    Private Sub btnEditDA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditDA.Click
        txtCCno.ReadOnly = False
        'chkSec94.Enabled = True
        cboAppType.Enabled = True
        txtFileNo.ReadOnly = False
        txtAppName.ReadOnly = False
        btnEditDA.Enabled = False
        Me.btnSaveDA.Enabled = True

    End Sub

    Private Sub btnSaveDA_ClickExtracted()
        txtCCno.ReadOnly = True
        'chkSec94.Enabled = False
        cboAppType.Enabled = False
        txtFileNo.ReadOnly = True
        txtAppName.ReadOnly = True
        txtConsentPlanNumber.ReadOnly = True
        btnEditDA.Enabled = True
        Me.btnSaveDA.Enabled = False





        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDA_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "[usp_UPDATE_DA_AssessmentHeader]"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@DATYPE", SqlDbType.Int).Value = CInt(cboAppType.SelectedValue)
                        .Parameters.Add("@CONSENTPLAN", SqlDbType.NVarChar).Value = txtConsentPlanNumber.Text
                        .Parameters.Add("@OFFICER", SqlDbType.Int).Value = CInt(Me.cboDAOfficer.SelectedValue)
                        .Parameters.Add("@APPNAME", SqlDbType.NVarChar).Value = Me.txtAppName.Text

                        .ExecuteNonQuery()

                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDA_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub
    Private Sub btnSaveDA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveDA.Click



        btnSaveDA_ClickExtracted()



    End Sub

    Private Sub btnAssembleLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssembleLetter.Click



        If cboConsentDocType.SelectedIndex = -1 Then
            MessageBox.Show("You need to select a document type!", "Create a draft document?", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("You are about to assemble a draft document. OK to proceed?", "Create a draft document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim docType As Integer
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim sysType As String = "DA"


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveDataToBuildWordDocument"

                        .Parameters.Add("@id", SqlDbType.Int).Value = CInt(cboConsentDocType.SelectedValue)
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docType = CInt(cboConsentDocType.SelectedValue)
                            docname = objDataReader.Item(0).ToString
                            docfilename = objDataReader.Item(1).ToString
                            MacroName = objDataReader.Item(2).ToString
                        Loop
                        objDataReader.Close()
                    End Using



                End Using
                 

                CreateWordDocs(docType, Me.txtDANo.Text, docname, docfilename, sysType, MacroName)

                Me.DisplayListOfDraftDocumentsTableAdapter.Fill(Me.DAdatasets.DisplayListOfDraftDocuments, txtDANo.Text)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub cboRefCodeId_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRefCodeId.SelectedValueChanged
        Select Case CInt(cboRefCodeId.SelectedValue)

            Case 2, 3
                Me.grpRFS.Visible = False
                btnRTA.Visible = True
            Case 59
                Me.grpRFS.Visible = True
                btnRTA.Visible = False
            Case Else
                Me.grpRFS.Visible = False
                btnRTA.Visible = False

        End Select
    End Sub

    Private Sub chksepp71_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksepp71.CheckStateChanged
        If chksepp71.CheckState = CheckState.Checked Then
            Me.grpSepp71.Visible = True
        Else
            Me.grpSepp71.Visible = False

        End If
    End Sub

    Private Sub dgvLoadListReferrals_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLoadListReferrals.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If Not e.RowIndex = -1 Then
            Try
                Me.ReferalInfoTableAdapter.Fill(Me.DAdatasets.ReferalInfo, CInt(dgvLoadListReferrals.CurrentRow.Cells(0).Value))
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
            Me.btnEditReferralsTab.Enabled = True
            Me.btnAddReferral.Enabled = True
            btnSaveReferralsTab.Enabled = False
            btnPrintRFSOther.Enabled = False
            btnPrintRFSSub.Enabled = False
            Me.grpRFS.Visible = False
            btnRTA.Visible = False


            Select Case CInt(cboRefCodeId.SelectedValue)

                Case 2, 3
                    Me.grpRFS.Visible = False
                    btnRTA.Visible = True
                    btnRTA.Enabled = True

                Case 59
                    Me.grpRFS.Visible = True
                    btnRTA.Visible = False
                    btnPrintRFSOther.Enabled = True
                    btnPrintRFSSub.Enabled = True

                Case Else
                    Me.grpRFS.Visible = False
                    btnRTA.Visible = False

            End Select




        End If

        If Me.lblReferralID.Text.Length = 0 Then
            Me.btnAddIntegrated.Enabled = False
            Me.btnRemoveIntegated.Enabled = False
        End If
        Me.btnRemoveRefer.Enabled = True

    End Sub

    Private Sub btnAddReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferral.Click
        btnAddReferral.Enabled = False
        Me.btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        btnRefdt.Enabled = True
        btnRefRetDt.Enabled = True
        ClearReferralData(grpMain)
        Me.lblReferralID.Text = String.Empty
        lstIntegrated.DataSource = Nothing
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        LockTheForm(grpSepp71, True)

    End Sub

    Private Sub dgvRetrieveListOfReferrals_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRetrieveListOfReferrals.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If Not e.RowIndex = -1 Then

            Try
                Me.RequestForAdditionalInfoDataTableAdapter.Fill(Me.DAdatasets.RequestForAdditionalInfoData, CInt(dgvRetrieveListOfReferrals.CurrentRow.Cells(0).Value))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
        LockTheForm(grpAddinfo, False)

        btnSaveAddInfoTab.Enabled = False
        btnEditAddinfoTab.Enabled = True

        btnPrintAddinfoLetter.Enabled = True
        btnPrint200DayLetter.Enabled = True
        btnPrint100DayLetter.Enabled = True
        btnPrintOver200DayLetter.Enabled = True

    End Sub

    Private Sub btnADDAddinfoTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnADDAddinfoTab.Click

        PartLockgrpAddinfo()
        btnEditAddinfoTab.Enabled = False
        btnSaveAddInfoTab.Enabled = True
        btnPrintAddinfoLetter.Enabled = False
        btnPrint200DayLetter.Enabled = False
        btnPrint100DayLetter.Enabled = False
        btnPrintOver200DayLetter.Enabled = False
        ClearAddInfoData(grpAddinfo)
        btnADDAddinfoTab.Enabled = False



    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim cb As Button = DirectCast(ctrl, Button)
                cb.Enabled = bLock
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
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
                        .Parameters.Add("@INTDEVYN", SqlDbType.NVarChar).Value = Me.cboIntDevYN.SelectedValue
                        .Parameters.Add("@DESIGYN", SqlDbType.NVarChar).Value = cboDesignatedYN.SelectedValue
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"

                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveReferral_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub btnSaveReferralsTab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveReferralsTab.Click
        If Not CheckReferralData() Then Exit Sub
        SaveReferralData()




    End Sub

    Private Sub btnAddFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFee.Click
        Try

            Dim fFee As New AddPayment

            With fFee

                .TheSystemType = "DA"
                .IndexID = 0
                .AppID = txtDANo.Text
                .PayId = 0
                .ShowDialog()
                .Dispose()
            End With

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, txtDANo.Text, "AA")
            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnAddRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefund.Click
        Try

            Dim fFee As New AddRefund

            With fFee

                .TheSystemType = "DA"
                .IDindex = 0
                .AppID = Me.txtDANo.Text
                .ShowDialog()
                .Dispose()
            End With

            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, txtDANo.Text, "DA")
            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAckSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAckSub.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a Submission Acknowledgement letter. OK to proceed?", "Print Submission Acknowledgement?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAckSub_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_SubmissionAck"
                        .Parameters.Add("@ObjID", SqlDbType.Int).Value = NZ(lblSubID.Text)
                        .Parameters.Add("@LANID", SqlDbType.NVarChar).Value = sUserID
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Submission Acknowledgement" & Me.txtDANo.Text, "ObjectorsAckdgmt.rpt", 2, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAckSub_Click routine ")
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
                    PrintOnPlainPaperOnly(objDT, "File note " & Me.txtDANo.Text, "FileNotes.rpt", 1)


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnNotePrint_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintRFSOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSOther.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSOther_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_RFSReferral"
                        .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Referral letter for Rural Fires Service" & Me.txtDANo.Text, "RFSReferralDA.rpt", 1, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSOther_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintRFSSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSSub.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSSub_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_RFSReferral"
                        .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Referral letter for Rural Fires Service" & Me.txtDANo.Text, "RFSReferralSubDiv.rpt", 1, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintRFSSub_Click routine ")
            End Try
        End Using
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
                MessageBox.Show(ex.Message, " in btnPrintSewer_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ReportSelectionData"

                        .Parameters.Add("@REPTTYPE", SqlDbType.NVarChar).Value = mlist.DocTypeName.ToString
                        .Parameters.Add("@LANID", SqlDbType.NVarChar).Value = sUserID
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text

                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Document Type: " & Me.cboLetterType.Text & " Application No. " & Me.txtDANo.Text & " " & Me.txtLetterNotes.Text, mlist.TheReportName.ToString, 2, mlist.DocTypeName.ToString)

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintSewer_Click routine ")
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
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "DA"
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintOnPlainPaperOnly(objDT, "Referral Response " & Me.txtDANo.Text, "ReferralResponse.rpt", 1)


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
                    PrintOnPlainPaperOnly(objDT, "SEPP 71 Referral to fax to PlanningNSW" & Me.txtDANo.Text, "Sepp71Referral.rpt", 1)


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine ")
            End Try
        End Using
    End Sub


#Region "Date Buttons"
    Private Sub btnRefToPlanCom_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefToPlanCom.Click
        RetrieveDate(RefToPlanCom)

    End Sub

    Private Sub btnDARegoDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RetrieveDate(DARegoDt)
    End Sub

    Private Sub btnDAToPlannerDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAToPlannerDt.Click
        RetrieveDate(DAToPlannerDt)
    End Sub

    Private Sub btnDASiteInspectedDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDASiteInspectedDt.Click
        RetrieveDate(DASiteInspectedDt)
    End Sub


    Private Sub btnfishDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfishDate.Click
        RetrieveDate(fishDate)

    End Sub

    Private Sub btnwasteDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwasteDate.Click
        RetrieveDate(wasteDate)
    End Sub

    Private Sub btnPollutionDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPollutionDate.Click
        RetrieveDate(PollutionDate)
    End Sub

    Private Sub btnRiverDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRiverDate.Click
        RetrieveDate(RiverDate)
    End Sub

    Private Sub btnEnvironDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvironDate.Click
        RetrieveDate(EnvironDate)
    End Sub

    Private Sub btnHeritageDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeritageDate.Click
        RetrieveDate(HeritageDate)
    End Sub

    Private Sub btnMineDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMineDate.Click
        RetrieveDate(MineDate)
    End Sub

    Private Sub btnRoadsDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoadsDate.Click
        RetrieveDate(RoadsDate)
    End Sub

    Private Sub btnNationalParksDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNationalParksDate.Click
        RetrieveDate(NationalParksDate)
    End Sub

    Private Sub btnWaterDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWaterDt.Click
        RetrieveDate(WaterDt)
    End Sub

    Private Sub btnPreAssessCompleteDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreAssessCompleteDate.Click
        RetrieveDate(PreAssessCompleteDate)

    End Sub

    Private Sub btnDAToTypingDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAToTypingDt.Click
        RetrieveDate(DAToTypingDt)
    End Sub

    Private Sub btnDAAdvisedDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAAdvisedDt.Click
        RetrieveDate(DAAdvisedDt)
    End Sub

    Private Sub btnDACommDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDACommDt.Click
        RetrieveDate(DACommDt)
    End Sub

    Private Sub btnDACompletedDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDACompletedDt.Click
        RetrieveDate(DACompletedDt)
    End Sub

    Private Sub btnDADetermDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDADetermDt.Click
        RetrieveDate(DADetermDt)
    End Sub

    Private Sub btnDAAppNotDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAAppNotDt.Click
        RetrieveDate(DAAppNotDt)
    End Sub

    Private Sub btnConsentPostedDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsentPostedDate.Click
        RetrieveDate(ConsentPostedDate)
    End Sub

    Private Sub btnDAFreeTreeDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAFreeTreeDt.Click
        RetrieveDate(DAFreeTreeDt)
    End Sub

    Private Sub btnDAConsentPubDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAConsentPubDt.Click
        RetrieveDate(DAConsentPubDt)
    End Sub

    Private Sub btnDAOccDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAOccDt.Click
        RetrieveDate(DAOccDt)
    End Sub

    Private Sub btnDAPermExDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAPermExDt.Click
        RetrieveDate(DAPermExDt)
    End Sub

    Private Sub btnAIReceivedDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAIReceivedDt.Click
        RetrieveDate(AIReceivedDt)

        lblReferralCount.Text = CalculateElapsedDays(Me.txtDANo.Text).ToString
        Me.txtDaysTaken.Text = CalculateDaysTakenToDetermine.ToString



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

    Private Sub btnDecisionDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecisionDate.Click
        RetrieveDate(variationDecisionDate)
    End Sub

    Private Sub btnSubRecdDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubRecdDate.Click
        RetrieveDate(SubRecdDate)
    End Sub

    Private Sub btnNoteDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoteDate.Click
        RetrieveDate(NoteDate)
    End Sub

    Private Sub btnAIRequestDt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAIRequestDt.Click
        RetrieveDate(AIRequestDt)
    End Sub


#End Region


    Private Sub DevelopmentAssessment_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            Me.LoadVariationResultOfficersRecomComboTableAdapter.Fill(Me.AssessmentData.LoadVariationResultOfficersRecomCombo)
            cboOfficerRecomforVariation.SelectedIndex = -1
            Me.LoadConclusionRecomendationComboTableAdapter.Fill(Me.AssessmentData.LoadConclusionRecomendationCombo)
            cboAssessmentDecision.SelectedIndex = -1
            Me.GenericAnswersToQuestionsTableAdapter.Fill(Me.AAdata.GenericAnswersToQuestions)
            cboComplianceStatProvYesNo.SelectedIndex = -1
            Me.LoadAuthorityComboBoxTableAdapter.Fill(Me.AAdata.LoadAuthorityComboBox)
            Me.cboModAuthority.SelectedIndex = -1
            Me.LoadS94TypeTableAdapter.Fill(Me.AAdata.LoadS94Type)
            Me.cboS64Type.SelectedIndex = -1
            Me.LoadSection94TypeComboBoxTableAdapter.Fill(Me.AAdata.LoadSection94TypeComboBox)
            cboSection64Type.SelectedIndex = -1
            Me.GenericAnswersForModFormTableAdapter.Fill(Me.AAdata.GenericAnswersForModForm)
            Me.DA_AssessmentTypeTableAdapter.Fill(Me.AAdata.DA_AssessmentType)
            Me.OtherDocTypesListTableAdapter.Fill(Me.DAdatasets.OtherDocTypesList)
            Me.AssessmentSheetTypeTableAdapter.Fill(Me.DAdatasets.AssessmentSheetType)
            Me.FileNoteTypeTableAdapter.Fill(Me.DAdatasets.FileNoteType)
            Me.DelegatedAuthorityTableAdapter.Fill(Me.DAdatasets.DelegatedAuthority)
            Me.VariationResultTableAdapter.Fill(Me.DAdatasets.VariationResult)
            Me.VariationTableAdapter.Fill(Me.DAdatasets.Variation)
            Me.LoadReferralsIntProvisionListTableAdapter.Fill(Me.DAdatasets.LoadReferralsIntProvisionList)
            Me.ReferralCodeTableAdapter.Fill(Me.DAdatasets.ReferralCode)
            Me.ProgressCodeTableAdapter.Fill(Me.DAdatasets.ProgressCode)
            Me.REASON_DA_APPL_40DAYSTableAdapter.Fill(Me.DAdatasets.REASON_DA_APPL_40DAYS)
            Me.DAAuthorityTableAdapter.Fill(Me.DAdatasets.DAAuthority)
            Me.DAClassificationTableAdapter.Fill(Me.DAdatasets.DAClassification)
            Me.ConsentTypeTableAdapter.Fill(Me.DAdatasets.ConsentType)
            Me.DevUseTableAdapter.Fill(Me.DAdatasets.DevUse)
            Me.DevTypeTableAdapter.Fill(Me.DAdatasets.DevType)
            Me.OfficerTableAdapter.Fill(Me.DAdatasets.Officer)
            Me.CensusCodeTableAdapter.Fill(Me.DAdatasets.CensusCode)
            Me.LocalityCodeTableAdapter.Fill(Me.DAdatasets.LocalityCode)
            Me.DADecisionTableAdapter.Fill(Me.DAdatasets.DADecision)
            Me.DAAppTypeTableAdapter.Fill(Me.DAdatasets.DAAppType)
            Me.cboReferralsIntProvision.SelectedIndex = -1
            cboAppType.SelectedIndex = -1
            cboDecision.SelectedIndex = -1
            cboDAOfficer.SelectedIndex = -1
            cboDevType.SelectedIndex = -1
            cboDevUse.SelectedIndex = -1
            cboDAClass.SelectedIndex = -1
            cboConsentType.SelectedIndex = -1
            cboDAtype1.SelectedIndex = -1
            cboDAType2.SelectedIndex = -1
            cboDAtype3.SelectedIndex = -1
            cboDAClass1.SelectedIndex = -1
            cboDAClass2.SelectedIndex = -1
            cboDAClass3.SelectedIndex = -1
            cboDAAuthorityId.SelectedIndex = -1
            cboDADecisionId.SelectedIndex = -1
            cboReasonOver40.SelectedIndex = -1
            cboVariationsYesNo.SelectedIndex = -1
            Me.cboVariationType.SelectedIndex = -1
            Me.cboVariationResult.SelectedIndex = -1
            Me.cboVariationAuthority.SelectedIndex = -1
            Me.cboConsentDocType.SelectedIndex = -1
            Me.cboOtherDocs.SelectedIndex = -1
            Me.cboSTDconditions.SelectedIndex = -1
            cboRefCodeId.SelectedIndex = -1
            cboIntDevYN.SelectedIndex = -1
            cboDesignatedYN.SelectedIndex = -1
            Me.Modsect79cYNComboBox.SelectedIndex = -1
            Me.ModSect94YNComboBox.SelectedIndex = -1
            Me.ModSubmConsYNComboBox.SelectedIndex = -1
            Me.ModSubstSameYNComboBox.SelectedIndex = -1
            Me.ModThreatComplYNComboBox.SelectedIndex = -1
            Me.ModThreatSpecYNComboBox.SelectedIndex = -1
            Me.ModNotificationYNComboBox.SelectedIndex = -1
            Me.ModMinisterOBjYNComboBox.SelectedIndex = -1
            Me.ModMinEnvImpactYNComboBox.SelectedIndex = -1
            Me.ModConsMinisterYNComboBox.SelectedIndex = -1

            Dim Sect64ContribType As New ArrayList

            ' Add division structure entries to the arraylist
            With Sect64ContribType
                .Add(New AreaType("S64", "1"))
                .Add(New AreaType("S94/S94A", "2"))
                .Add(New AreaType("Bond", "3"))
            End With

            With Me.cboContribType
                .DataSource = Sect64ContribType
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With


            Dim AreaDescription As New ArrayList

            ' Add division structure entries to the arraylist
            With AreaDescription
                .Add(New AreaType("Metres", "M"))
                .Add(New AreaType("Hectares", "H"))
            End With

            With cboAreaType
                .DataSource = AreaDescription
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With


            Dim CouncilDepot As New ArrayList

            ' Add division structure entries to the arraylist
            With CouncilDepot
                .Add(New Depots("Batemans Bay", "B"))
                .Add(New Depots("Moruya", "M"))
                .Add(New Depots("Narooma", "N"))
            End With

            With cboAdvertSignDepot
                .DataSource = CouncilDepot
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With

            Dim IntDev As New ArrayList

            ' Add division structure entries to the arraylist
            With IntDev
                .Add(New YesNoAnswer("Yes", "Y"))
                .Add(New YesNoAnswer("No", "N"))
            End With

            With cboIntDevYN
                .DataSource = IntDev
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With

            Dim Designated As New ArrayList

            ' Add division structure entries to the arraylist
            With Designated
                .Add(New YesNoAnswer("Yes", "Y"))
                .Add(New YesNoAnswer("No", "N"))
            End With

            With cboDesignatedYN
                .DataSource = Designated
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With




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

            Dim SubmissionType As New ArrayList

            ' Add division structure entries to the arraylist
            With SubmissionType
                .Add(New SubmissionTypes("Submision", "S"))
                .Add(New SubmissionTypes("Objection", "O"))
            End With

            With cboSubmissionType
                .DataSource = SubmissionType
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With


            Dim Enacted As New ArrayList

            ' Add division structure entries to the arraylist
            With Enacted
                .Add(New YesNoAnswer("Yes", "Y"))
                .Add(New YesNoAnswer("No", "N"))
            End With

            With cboActedOn
                .DataSource = Enacted
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With


            Dim Sect96 As New ArrayList

            ' Add division structure entries to the arraylist
            With Sect96
                .Add(New AreaType("1", "1"))
                .Add(New AreaType("1A", "1A"))
                .Add(New AreaType("2", "2"))
            End With

            With cboModSect96
                .DataSource = Sect96
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With



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
                            .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = "DA"

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

            LoadForm(DANumber)

            'Conclusion modification



            Dim ModSec96Comply As New ArrayList

            ' Add division structure entries to the arraylist
            With ModSec96Comply
                .Add(New Depots("Complies", "Y"))
                .Add(New Depots("does not comply", "n"))
            End With

            With Me.cboModSec96Comply
                .DataSource = ModSec96Comply
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With

            Dim ModSec79Satisfactory As New ArrayList

            ' Add division structure entries to the arraylist
            With ModSec79Satisfactory
                .Add(New Depots("satisfactory", "Y"))
                .Add(New Depots("unsatisfactory", "n"))
            End With

            With Me.cboModSec79Satisfactory
                .DataSource = ModSec79Satisfactory
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With

            Dim ConclusionSummary As New ArrayList

            ' Add division structure entries to the arraylist
            With ConclusionSummary
                .Add(New Depots("satisfactory", "S"))
                .Add(New Depots("unsatisfactory", "U"))
            End With

            With Me.cboApplicationConclResult
                .DataSource = ConclusionSummary
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With


            Dim ModAssessmentDecision As New ArrayList

            ' Add division structure entries to the arraylist
            With ModAssessmentDecision
                .Add(New Depots("Approved", "A"))
                .Add(New Depots("Refused", "R"))
            End With

            With Me.cboModAssessmentDecision
                .DataSource = ModAssessmentDecision
                .DisplayMember = "Name"
                .ValueMember = "Key"
                .SelectedIndex = -1
            End With


            Dim recommendation As String = "THAT the application pursuant to Section 96 of Environmental Planning and Assessment Amendment Act 1997 for modification of the consent granted in respect of Development Application Number " & OriginalDANo & " be:"
            Me.lblRecommendation.Text = recommendation

            Dim recommendationTwo As String = String.Empty
            If cboModAssessmentDecision.SelectedIndex <> -1 Then
                Dim decision As String = String.Empty
                If cboModAssessmentDecision.SelectedValue.ToString = "R" Then
                    decision = "remains unchanged for the reasons set out below:"
                ElseIf cboModAssessmentDecision.SelectedValue.ToString = "A" Then
                    decision = "is modified in the manner specified for the reasons set out below:-"
                Else
                    decision = "**select decision code**"
                End If


                recommendationTwo = "and therefore the consent notice dated " & DADetermDt.Text & " " & decision
            End If
            lblRecommendTwo.Text = recommendationTwo
        Catch ex As Exception
            MessageBox.Show(ex.Message, " in DALookup_Load routine - form " & Me.Name)


        End Try


    End Sub



    'Private Sub lstPINs_SelectedValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPINs.SelectedValueChanged
    '    If Me.lstPINs.SelectedIndex <> -1 Then
    '        LoadZonesAndRestrictions(CInt(lstPINs.SelectedValue))
    '    End If
    'End Sub


    Private Sub btnGenImpacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenImpacts.Click
        Dim fPopUp As New GeneralImpacts
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnDepositedPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositedPlan.Click
        Dim fPopUp As New DepositedPlanAssessment
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnThreatenSpecies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThreatenSpecies.Click
        Dim fPopUp As New ThreatenSpeciesAssessment
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnTraficCarParks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraficCarParks.Click
        Dim fPopUp As New TrafficAssessment
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSocialEconomic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocialEconomic.Click
        Dim fPopUp As New SocialEconomicImpactsAssessment
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnDisabDiscrimAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisabDiscrimAct.Click
        Dim fPopUp As New DiabilityDiscriminationActAssessment
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnHeritage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeritage.Click
        Dim fPopUp As New HeritageAssessment
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnLandscaping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLandscaping.Click
        Dim fPopUp As New LandscapingAssessment
        With fPopUp
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSustainability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSustainability.Click
        With My.Forms.SustainabilityAssessment
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSubdivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubdivision.Click
        With My.Forms.SubdivisionAssessment
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnLEP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLEP.Click

        With My.Forms.StatutoryLEP
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnREP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREP.Click
        With My.Forms.StatutoryREP
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnSepp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSepp.Click
        With My.Forms.StatutorySEPP
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnGuidLines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuidLines.Click
        With My.Forms.StatutoryGuidelines
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnDCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCP.Click
        With My.Forms.StatutoryDCP
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnDams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDams.Click

        With My.Forms.StatutoryDAMS
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub


    Private Sub btnDCPCheckList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCPCheckList.Click
        With My.Forms.StatutoryDCPCheckList
            .AssessmentNo = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnRetrievePreviousDAHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrievePreviousDAHistory.Click
        If MessageBox.Show("You are about to insert Development History, Ok to proceed?", "Insert DA History", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrievePreviousDAHistory_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertPreviousDAintoDA_DevelopmentHistory"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrievePreviousDAHistory_Click routine - form " & Me.Name)

            End Try
        End Using

        ShowHistoricalDATableAdapter.Fill(Me.DAdatasets.ShowHistoricalDA, Me.txtDANo.Text)

    End Sub

    Private Sub ShowHistoricalDADataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowHistoricalDADataGridView.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Try
            Me.Retrieve_DAHistoryCommentsTableAdapter.Fill(Me.AAdata.Retrieve_DAHistoryComments, ShowHistoricalDADataGridView.CurrentRow.Cells(0).Value.ToString, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.btnViewDa.Enabled = True
        Me.btnUpDateHistory.Enabled = True
    End Sub

    Private Sub btnUpDateHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpDateHistory.Click


        If MessageBox.Show("Update this information now?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpDateHistory_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateCommentsInDevelopmentHistory"

                        .Parameters.Add("@PREVDANO", SqlDbType.NVarChar).Value = Me.lblDAno.Text
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@ACTED", SqlDbType.NVarChar).Value = cboActedOn.SelectedValue.ToString
                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = CommentTextBox.Text
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpDateHistory_Click routine - form " & Me.Name)

            End Try
        End Using

        ShowHistoricalDATableAdapter.Fill(Me.DAdatasets.ShowHistoricalDA, Me.txtDANo.Text)


    End Sub

    Private Sub btnUpdateModDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateModDetails.Click

        pnlMod0.Enabled = True
        pnlMod1.Enabled = True
        pnlMod1andMod2.Enabled = True
        pnlMod2.Enabled = True
        pnlMod1A.Enabled = True
        ModDetailsTextBox.ReadOnly = False
        ModReasonTextBox.ReadOnly = False
        cboModSect96.Enabled = True
        btnUpdateModDetails.Enabled = False
        btnUpdateModData.Enabled = True

        'If Me.cboModSect96.SelectedIndex = -1 Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.cboModSect96, ErrorIconAlignment.MiddleLeft)
        '        .SetError(Me.cboModSect96, "A response IS required")
        '    End With
        '    Exit Sub
        'Else
        '    ErrorProvider.SetError(Me.cboModSect96, "")

        'End If

        'Using cn As New SqlConnection(My.Settings.DataConnection)
        '    Try
        '        cn.Open()
        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnUpdateModDetails_Click routine - form " & Me.Name)

        '    End Try


        '    Try

        '        Using cmd As New SqlCommand

        '            With cmd
        '                .Connection = cn
        '                .CommandType = CommandType.StoredProcedure
        '                .CommandText = "usp_InsertUpdateDAassessment_ModDetails"

        '                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
        '                .Parameters.Add("@MODDETAILS", SqlDbType.NText).Value = Me.ModDetailsTextBox.Text
        '                .Parameters.Add("@MODREASON", SqlDbType.NText).Value = Me.ModReasonTextBox.Text
        '                .Parameters.Add("@MODSECT96", SqlDbType.NVarChar).Value = Me.cboModSect96.SelectedValue.ToString
        '                .ExecuteNonQuery()
        '            End With



        '        End Using
        '         



        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnUpdateModDetails_Click routine - form " & Me.Name)

        '    End Try
        'End Using


        'Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, txtDANo.Text)


    End Sub

    Private Sub cboModSect96_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModSect96.SelectedIndexChanged
        If cboModSect96.SelectedIndex = -1 Then Exit Sub

        Select Case cboModSect96.SelectedValue.ToString.ToUpper
            Case "1"
                lblModeType.Text = "Section96(1) Assessment"
                pnlMod0.Visible = True
                btnUpdateModData.Visible = True
                Me.pnlMod1andMod2.Visible = False
                Me.pnlMod2.Visible = False
                Me.pnlMod1A.Visible = False
                Me.pnlMod1.Location = New Point(3, 3)
            Case "1A"
                pnlMod0.Visible = True
                btnUpdateModData.Visible = True
                lblModeType.Text = "Section96(1A) Assessment"
                Me.pnlMod1andMod2.Visible = True
                Me.pnlMod2.Visible = False
                Me.pnlMod1A.Visible = True
                Me.pnlMod1.Location = New Point(3, 283)

            Case "2"
                pnlMod0.Visible = True
                btnUpdateModData.Visible = True
                lblModeType.Text = "Section96(2) Assessment"
                Me.pnlMod1andMod2.Visible = True
                Me.pnlMod2.Visible = True
                Me.pnlMod1A.Visible = False
                Me.pnlMod1.Location = New Point(3, 437)


            Case Else
                lblModeType.Text = String.Empty
                btnUpdateModData.Visible = False
                pnlMod0.Visible = True
        End Select


    End Sub

    Private Sub btnUpdateModData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateModData.Click

        If Me.cboModSect96.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModSect96, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.cboModSect96, "A response IS required")
            End With
            Exit Sub
        Else
            ErrorProvider.SetError(Me.cboModSect96, "")

        End If

        pnlMod0.Enabled = False
        pnlMod1.Enabled = False
        pnlMod1andMod2.Enabled = False
        pnlMod2.Enabled = False
        pnlMod1A.Enabled = False
        ModDetailsTextBox.ReadOnly = True
        ModReasonTextBox.ReadOnly = True
        cboModSect96.Enabled = False
        btnUpdateModData.Enabled = False
        btnUpdateModDetails.Enabled = True


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateModData_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertUpdateDAassessment_ModSection96Data"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@MODDETAILS", SqlDbType.NText).Value = Me.ModDetailsTextBox.Text
                        .Parameters.Add("@MODREASON", SqlDbType.NText).Value = Me.ModReasonTextBox.Text
                        .Parameters.Add("@MODSECT96", SqlDbType.NVarChar).Value = Me.cboModSect96.SelectedValue.ToString
                        If ModMinEnvImpactYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModMinEnvImpactYN", SqlDbType.NVarChar).Value = Me.ModMinEnvImpactYNComboBox.SelectedValue.ToString
                        .Parameters.Add("@ModMinEnvImpComment", SqlDbType.NText).Value = Me.ModMinEnvImpCommentTextBox.Text
                        If ModSubstSameYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModSubstSameYN", SqlDbType.NVarChar).Value = Me.ModSubstSameYNComboBox.SelectedValue.ToString
                        .Parameters.Add("@SubStSameComment", SqlDbType.NText).Value = Me.ModSubStSameCommentTextBox.Text
                        If ModNotificationYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModNotificationYN", SqlDbType.NVarChar).Value = Me.ModNotificationYNComboBox.SelectedValue.ToString
                        If ModSubmConsYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModSubmConsYN", SqlDbType.NVarChar).Value = Me.ModSubmConsYNComboBox.SelectedValue.ToString
                        If ModConsMinisterYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModConsMinisterYN", SqlDbType.NVarChar).Value = Me.ModConsMinisterYNComboBox.SelectedValue.ToString
                        If ModMinisterOBjYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModMinisterOBjYN", SqlDbType.NVarChar).Value = Me.ModMinisterOBjYNComboBox.SelectedValue.ToString
                        .Parameters.Add("@ModMinisterComment", SqlDbType.NText).Value = Me.ModMinisterCommentTextBox.Text
                        If ModThreatSpecYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModThreatSpecYN", SqlDbType.NVarChar).Value = Me.ModThreatSpecYNComboBox.SelectedValue.ToString
                        If ModThreatComplYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModThreatComplYN", SqlDbType.NVarChar).Value = Me.ModThreatComplYNComboBox.SelectedValue.ToString
                        .Parameters.Add("@ModThreatComment", SqlDbType.NText).Value = Me.ModThreatCommentTextBox.Text
                        If Modsect79cYNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@Modsect79cYN", SqlDbType.NVarChar).Value = Me.Modsect79cYNComboBox.SelectedValue.ToString
                        .Parameters.Add("@ModSect79cComment", SqlDbType.NText).Value = Me.ModSect79cCommentTextBox.Text
                        If ModSect94YNComboBox.SelectedIndex <> -1 Then .Parameters.Add("@ModSect94YN", SqlDbType.NVarChar).Value = Me.ModSect94YNComboBox.SelectedValue.ToString
                        .Parameters.Add("@ModSect94Comment", SqlDbType.NText).Value = Me.ModSect94CommentTextBox.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateModData_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.DAAssessmentDataTableAdapter.Fill(Me.AAdata.DAAssessmentData, txtDANo.Text)


    End Sub

    Private Sub BtnInsertNewSection64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsertNewSection64.Click
        If Not CheckSection64() Then Exit Sub
        If MessageBox.Show("Insert this contribution?", "Insert Contribution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in BtnInsertNewSection64_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertProposedSection64_94_Bond_Contribution"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@CODE", SqlDbType.NVarChar).Value = Me.cboSection64Type.SelectedValue.ToString
                        .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(Me.txt64Amount.Text)
                        .Parameters.Add("@NOTE", SqlDbType.NVarChar).Value = Me.txt64Note.Text
                        .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboS64Type.SelectedValue)
                        .Parameters.Add("@CATEORY", SqlDbType.Int).Value = CInt(cboContribType.SelectedValue)
                        .ExecuteNonQuery()
                    End With


                End Using
                 

                ReloadContributionsGrids()

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in BtnInsertNewSection64_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub
    Private Sub cboAssessmentType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAssessmentType.SelectedValueChanged

        If cboAssessmentType.SelectedIndex = -1 Then Exit Sub

        btnAddDefaultCondition.Enabled = HasStandardCondition(CInt(cboAssessmentType.SelectedValue))
    End Sub




    Private Sub dgvSection64Contributions_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSection64Contributions.CellClick
        If e.RowIndex = -1 Then Exit Sub
        Me.btnRemove64.Enabled = True

    End Sub

    Private Sub dgvProposedBondContrib_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProposedBondContrib.CellClick
        If e.RowIndex = -1 Then Exit Sub
        Me.btnRemoveBond.Enabled = True

    End Sub

    Private Sub dgvSection94_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSection94.CellClick
        If e.RowIndex = -1 Then Exit Sub
        Me.btnRemove94.Enabled = True

    End Sub

    Private Sub btnRemove64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove64.Click

        If MessageBox.Show("Are you sure you want to remove this contribution?", "Remove Contribution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        RemoveContribution(CInt(dgvSection64Contributions.CurrentRow.Cells(0).Value))

    End Sub

    Private Sub RemoveContribution(ByVal CodeId As Integer)

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveContribution routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveSection64Contribution"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CodeId
                        .ExecuteNonQuery()
                    End With


                End Using
                 

                ReloadContributionsGrids()

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveContribution routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnRemove94_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemove94.Click
        If MessageBox.Show("Are you sure you want to remove this contribution?", "Remove Contribution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        RemoveContribution(CInt(Me.dgvSection94.CurrentRow.Cells(0).Value))
    End Sub

    Private Sub btnRemoveBond_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveBond.Click
        If MessageBox.Show("Are you sure you want to remove this contribution?", "Remove Contribution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        RemoveContribution(CInt(Me.dgvProposedBondContrib.CurrentRow.Cells(0).Value))

    End Sub

    'Private Sub btnInsertIntoLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If MessageBox.Show("You are about to copy all the proposed contribution records for this DA and add them to the 'Live' Section 94 Register!  OK to proceed?", "Update the Contributions Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub






    '    Using cn As New SqlConnection(My.Settings.DataConnection)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnInsertIntoLive_Click routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_MoveProposedSection64ContributionsToLive"

    '                    .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
    '                    .ExecuteNonQuery()

    '                End With


    '            End Using
    '             



    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnInsertIntoLive_Click routine - form " & Me.Name)

    '        End Try
    '    End Using



    'End Sub

    Private Sub cboModAssessmentDecision_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModAssessmentDecision.SelectedValueChanged
        If cboModAssessmentDecision.SelectedIndex = -1 Then Exit Sub
        Dim recommendationTwo As String = String.Empty
        Dim decision As String = String.Empty
        If cboModAssessmentDecision.SelectedValue.ToString = "R" Then
            decision = "remains unchanged for the reasons set out below:"
        ElseIf cboModAssessmentDecision.SelectedValue.ToString = "A" Then
            decision = "is modified in the manner specified for the reasons set out below:-"
        End If

        recommendationTwo = "and therefore the consent notice dated " & DADetermDt.Text & " " & decision

        lblRecommendTwo.Text = recommendationTwo

    End Sub

    Private Sub btnProposedDetermDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProposedDetermDate.Click
        RetrieveDate(txtProposedDetermDate)
    End Sub

    Private Sub btnUpdateConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateConclusion.Click
        Dim modification As Boolean = Me.pnlModificationConclusion.Visible
        Dim OKtoProceed As Boolean = False


        ' Request list item number 22 RO 2 May 2011
        'If modification Then
        '    OKtoProceed = modificationConclusionChecksOut()
        'Else
        '    OKtoProceed = ConclusionChecksOut()

        'End If

        'If Not OKtoProceed Then Exit Sub

        If MessageBox.Show("Update the conclusion?", "Complete Conclusion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateConclusion_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateInsertDAConclusion"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        If cboReferralsYesNo.SelectedIndex <> -1 Then .Parameters.Add("@ReferralsYesNo", SqlDbType.NVarChar).Value = Me.cboReferralsYesNo.SelectedValue.ToString
                        If cboComplianceStatProvYesNo.SelectedIndex <> -1 Then .Parameters.Add("@ComplianceStatProvYesNo", SqlDbType.NVarChar).Value = Me.cboComplianceStatProvYesNo.SelectedValue.ToString
                        .Parameters.Add("@ComplianceStatProvComments", SqlDbType.NText).Value = Me.ComplianceStatProvCommentsTextBox.Text
                        If cboVariationsYesNo.SelectedIndex <> -1 Then .Parameters.Add("@VariationsYesNo", SqlDbType.NVarChar).Value = Me.cboVariationsYesNo.SelectedValue.ToString
                        If cboApplicationConclResult.SelectedIndex <> -1 Then .Parameters.Add("@ApplicationConclResult", SqlDbType.NVarChar).Value = Me.cboApplicationConclResult.SelectedValue.ToString

                        .Parameters.Add("@ApplicationConclreasons", SqlDbType.NText)
                        .Parameters.Add("@AssessmentDecision", SqlDbType.NVarChar)
                        .Parameters.Add("@AuthorityCode", SqlDbType.NVarChar)
                        .Parameters.Add("@PropDetermDate", SqlDbType.SmallDateTime)

                        If modification Then
                            .Parameters("@ApplicationConclreasons").Value = Me.ApplicationConclreasonsTextBox.Text
                            If cboModAssessmentDecision.SelectedIndex <> -1 Then .Parameters("@AssessmentDecision").Value = Me.cboModAssessmentDecision.SelectedValue.ToString
                            If cboModAuthority.SelectedIndex <> -1 Then .Parameters("@AuthorityCode").Value = Me.cboModAuthority.SelectedValue.ToString
                            .Parameters("@PropDetermDate").Value = Format(CDate(txtProposedDetermDate.Text), "dd/MM/yyyy")
                        Else
                            .Parameters("@ApplicationConclreasons").Value = Me.txtApplicationConclreasons.Text
                            If cboAssessmentDecision.SelectedIndex <> -1 Then .Parameters("@AssessmentDecision").Value = Me.cboAssessmentDecision.SelectedValue.ToString
                            If cboAuthority.SelectedIndex <> -1 Then .Parameters("@AuthorityCode").Value = Me.cboAuthority.SelectedValue.ToString
                            .Parameters("@PropDetermDate").Value = Format(CDate(txtConclusionDate.Text), "dd/MM/yyyy")
                        End If


                        If cboModSec96Comply.SelectedIndex <> -1 Then .Parameters.Add("@Modsec96ComplyYN", SqlDbType.NVarChar).Value = Me.cboModSec96Comply.SelectedValue.ToString
                        If cboModSec79Satisfactory.SelectedIndex <> -1 Then .Parameters.Add("@Modsec79SatisYN", SqlDbType.NVarChar).Value = Me.cboModSec79Satisfactory.SelectedValue.ToString
                        .ExecuteNonQuery()


                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpdateConclusion_Click routine - form " & Me.Name)

            End Try
        End Using





    End Sub


    Private Sub mnuPreviewAssessment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPreviewAssessment.Click

        Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in mnuPreviewAssessment_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_DAAssessment"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String
                If lblModification.Visible Then
                    strReportPath = My.Settings.ReportLocation & "DAAssessmentMod.rpt"
                Else
                    strReportPath = My.Settings.ReportLocation & "DAAssessment.rpt"
                End If
                Try

                    If Not IO.File.Exists(strReportPath) Then
                        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

                    End If

                    Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                    myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                    myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical
                    'myPrintOptions.CustomPaperSource = GetSelectedPaperSource()

                    With rptDocument
                        .Load(strReportPath)
                        .SetDataSource(objDT)
                        .VerifyDatabase()
                        .PrintToPrinter(1, False, 1, 99)
                    End With
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in mnuPreviewAssessment_Click routine ")
                End Try


                '    Dim fViewer As New AddAdvertPrinter
                '    With fViewer
                '        .objDataTable = objDT
                '        If Modification Then
                '            .ReportName = "DAAssessmentMod.rpt"

                '        Else
                '            .ReportName = "DAAssessment.rpt"

                '        End If
                '        .ShowDialog()
                '        .Dispose()
                '    End With

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in mnuPreviewAssessment_Click routine ")
            End Try
        End Using


    End Sub

    Private Sub cboLetterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLetterType.SelectedIndexChanged
        If cboLetterType.SelectedIndex = -1 Then Exit Sub
        btnCreateNewLetter.Enabled = True
    End Sub


    Private Sub btnRTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRTA.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Roads and Traffic Authority. OK to proceed?", "Print RTA Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRTA_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_RTAReferral"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    PrintReferralLetter(objDT, "Referral letter for Roads and Traffic Authority" & Me.txtDANo.Text, "RTAReferral.rpt", 1, "NO")


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRTA_Click routine ")
            End Try
        End Using
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

        Me.LoadListReferralsTableAdapter.Fill(Me.DAdatasets.LoadListReferrals, Me.txtDANo.Text, "DA")

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
                btnRTA.Visible = True
                btnRTA.Enabled = True

            Case 59
                Me.grpRFS.Visible = True
                btnRTA.Visible = False
                btnPrintRFSOther.Enabled = True
                btnPrintRFSSub.Enabled = True

            Case Else
                Me.grpRFS.Visible = False
                btnRTA.Visible = False

        End Select

        If Me.lblReferralID.Text.Length = 0 Then
            Me.btnAddIntegrated.Enabled = False
            Me.btnRemoveIntegated.Enabled = False
        End If
        Me.btnRemoveRefer.Enabled = True


    End Sub

    Private Sub btnEditPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPayment.Click
        Try

            Dim fFee As New AddPayment

            With fFee

                .TheSystemType = "DA"
                .IndexID = CInt(PaymentsReceivedDataGridView.CurrentRow.Cells(7).Value)
                .AppID = txtDANo.Text
                .PayId = CShort(PaymentsReceivedDataGridView.CurrentRow.Cells(6).Value)
                .ShowDialog()
                .Dispose()
            End With

            Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, txtDANo.Text, "DA")
            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub PaymentsReceivedDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles PaymentsReceivedDataGridView.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Me.btnEditPayment.Enabled = True
        Me.btnRemoveFee.Enabled = True
    End Sub

    Private Sub btnEditRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRefund.Click
        Try

            Dim fFee As New AddRefund

            With fFee

                .TheSystemType = "DA"
                .AppID = txtDANo.Text
                .IDindex = CInt(DARefundsPaidDataGridView.CurrentRow.Cells(6).Value)
                .PayId = CShort(DARefundsPaidDataGridView.CurrentRow.Cells(5).Value)
                .ShowDialog()
                .Dispose()
            End With

            Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, txtDANo.Text, "DA")
            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DARefundsPaidDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DARefundsPaidDataGridView.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        btnRemoveRefund.Enabled = True
        Me.btnEditRefund.Enabled = True
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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(PaymentsReceivedDataGridView.CurrentRow.Cells(6).Value)
                        .ExecuteNonQuery()

                    End With


                End Using
                 

                Me.PaymentsReceivedTableAdapter.Fill(Me.DAdatasets.PaymentsReceived, txtDANo.Text, "DA")
                CalculateRefundsandPayments(txtDANo.Text)


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
                 

                Me.DARefundsPaidTableAdapter.Fill(Me.DAdatasets.DARefundsPaid, txtDANo.Text, "DA")
                CalculateRefundsandPayments(txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub mnuImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImages.Click
        Dim fMultimedia As New MultimediaInterface
        Dim GroupImageIDB4 As Integer = mdl_GroupImageID

        With fMultimedia
            .DAnumber = Me.txtDANo.Text
            .ImageGroupID = Me.mdl_GroupImageID
            .ShowDialog()
            mdl_GroupImageID = .ImageGroupID
        End With
        If GroupImageIDB4 = 0 And mdl_GroupImageID <> 0 Then UpdatePropertyImage(mdl_GroupImageID)


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
            Me.RetrieveHistoricalDocumentsTableAdapter.Fill(Me.DAdatasets.RetrieveHistoricalDocuments, "DA", Me.txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub



#End Region

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        RetrieveDate(txtConclusionDate)
    End Sub

    Private Sub DevelopmentAssessment_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.btnSaveDA.Enabled Then
            If MessageBox.Show("It appears you have made changes to this application. Save changes before exiting?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                btnSaveDA_ClickExtracted()
            End If
        End If
    End Sub

#Region "EDIT DESC"

    Private Sub btnEditDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDesc.Click
        'Edit Description Tab
        Me.chkDesc1.Enabled = True
        Me.chkDADesc2.Enabled = True
        Me.chkDADesc3.Enabled = True
        Me.chkDADesc4.Enabled = True
        Me.chkDADesc5.Enabled = True
        Me.chkDADesc6.Enabled = True
        Me.chkDADesc7.Enabled = True
        Me.chkDADesc8.Enabled = True
        Me.cboDevType.Enabled = True
        Me.cboDevUse.Enabled = True
        txtDADesc.ReadOnly = False
        txtDAestCost.ReadOnly = False
        txtDAFloor.ReadOnly = False
        cboConsentType.Enabled = True
        cboDAtype1.Enabled = True
        cboDAType2.Enabled = True
        cboDAtype3.Enabled = True
        cboDAClass.Enabled = True
        cboDAClass1.Enabled = True
        cboDAClass2.Enabled = True
        cboDAClass3.Enabled = True
        btnAddFile.Enabled = True
        btnRemoveFile.Enabled = True
        btnSaveDesc.Enabled = True
        btnEditDesc.Enabled = False


    End Sub

    Private Sub btnSaveDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDesc.Click
        Me.chkDesc1.Enabled = False
        Me.chkDADesc2.Enabled = False
        Me.chkDADesc3.Enabled = False
        Me.chkDADesc4.Enabled = False
        Me.chkDADesc5.Enabled = False
        Me.chkDADesc6.Enabled = False
        Me.chkDADesc7.Enabled = False
        Me.chkDADesc8.Enabled = False
        Me.cboDevType.Enabled = False
        Me.cboDevUse.Enabled = False
        txtDADesc.ReadOnly = True
        txtDAestCost.ReadOnly = True
        txtDAFloor.ReadOnly = True
        cboConsentType.Enabled = False
        cboDAtype1.Enabled = False
        cboDAType2.Enabled = False
        cboDAtype3.Enabled = False
        cboDAClass.Enabled = False
        cboDAClass1.Enabled = False
        cboDAClass2.Enabled = False
        cboDAClass3.Enabled = False
        btnAddFile.Enabled = False
        btnRemoveFile.Enabled = False
        btnSaveDesc.Enabled = False
        btnEditDesc.Enabled = True
        SaveDescription()
    End Sub

    Private Sub SaveDescription()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveDescription routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_Description"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@DADESC1", SqlDbType.Bit).Value = Me.chkDesc1.CheckState
                        .Parameters.Add("@DADESC2", SqlDbType.Bit).Value = Me.chkDADesc2.CheckState
                        .Parameters.Add("@DADESC3", SqlDbType.Bit).Value = Me.chkDADesc3.CheckState
                        .Parameters.Add("@DADESC4", SqlDbType.Bit).Value = Me.chkDADesc4.CheckState
                        .Parameters.Add("@DADESC5", SqlDbType.Bit).Value = Me.chkDADesc5.CheckState
                        .Parameters.Add("@DADESC6", SqlDbType.Bit).Value = Me.chkDADesc6.CheckState
                        .Parameters.Add("@DADESC7", SqlDbType.Bit).Value = Me.chkDADesc7.CheckState
                        .Parameters.Add("@DADESC8", SqlDbType.Bit).Value = Me.chkDADesc8.CheckState
                        If cboDevType.SelectedIndex <> -1 Then .Parameters.Add("@TYPEID", SqlDbType.Int).Value = CInt(cboDevType.SelectedValue)
                        If cboDevUse.SelectedIndex <> -1 Then .Parameters.Add("@USEID", SqlDbType.Int).Value = CInt(Me.cboDevUse.SelectedValue)
                        .Parameters.Add("@DESC", SqlDbType.NVarChar).Value = Me.txtDADesc.Text
                        If txtDAestCost.Text <> String.Empty Then .Parameters.Add("@ESTCOST", SqlDbType.Money).Value = CDbl(txtDAestCost.Text)
                        .Parameters.Add("@FLOOR", SqlDbType.Int)
                        If IsNumeric(Me.txtDAFloor.Text) Then
                            .Parameters("@FLOOR").Value = CInt(txtDAFloor.Text)
                        End If
                        .Parameters.Add("@CONSENTTYPE", SqlDbType.Int).Value = CInt(cboConsentType.SelectedValue)
                        If cboDAtype1.Text <> String.Empty Then .Parameters.Add("@DATYPE1", SqlDbType.Int).Value = CInt(Me.cboDAtype1.SelectedValue)
                        If cboDAType2.Text <> String.Empty Then .Parameters.Add("@DATYPE2", SqlDbType.Int).Value = CInt(Me.cboDAType2.SelectedValue)
                        If cboDAtype3.Text <> String.Empty Then .Parameters.Add("@DATYPE3", SqlDbType.Int).Value = CInt(Me.cboDAtype3.SelectedValue)
                        If cboDAClass.Text <> String.Empty Then .Parameters.Add("@DACLASS", SqlDbType.NVarChar).Value = Me.cboDAClass.SelectedValue
                        If cboDAClass1.Text <> String.Empty Then .Parameters.Add("@DACLASS1", SqlDbType.NVarChar).Value = Me.cboDAClass1.SelectedValue
                        If cboDAClass2.Text <> String.Empty Then .Parameters.Add("@DACLASS2", SqlDbType.NVarChar).Value = Me.cboDAClass2.SelectedValue
                        If cboDAClass3.Text <> String.Empty Then .Parameters.Add("@DACLASS3", SqlDbType.NVarChar).Value = Me.cboDAClass3.SelectedValue
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveDescription routine - form " & Me.Name)

            End Try
        End Using


    End Sub

#End Region

#Region "STATUS TAB"
    Private Sub btnEditStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStatus.Click

        'Edit Status Tab

        LockTheForm(grpAssessment, True)
        LockTheForm(grpDetermination, True)
        LockTheForm(grpNotification, True)
        cboAdvertSignDepot.Enabled = True
        rbNotifyAdvert.Enabled = Administration
        Me.rbNone.Enabled = Administration
        Me.rbNotify.Enabled = Administration
        Me.btnEditStatus.Enabled = False
        Me.btnSaveStatus.Enabled = True

    End Sub

    Private Sub btnSaveStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveStatus.Click
        LockTheForm(grpAssessment, False)
        LockTheForm(grpDetermination, False)
        LockTheForm(grpNotification, False)
        cboAdvertSignDepot.Enabled = False
        rbNotifyAdvert.Enabled = False
        Me.rbNone.Enabled = False
        Me.rbNotify.Enabled = False
        Me.btnEditStatus.Enabled = True
        Me.btnSaveStatus.Enabled = False
        SaveTheStatus()

    End Sub

    Private Sub SaveTheStatus()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveTheStatus routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_Assessment_STATUS_DATA"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        If cboDADecisionId.Text <> String.Empty Then .Parameters.Add("@DADECISONID", SqlDbType.Int).Value = CInt(cboDADecisionId.SelectedValue)
                        .Parameters.Add("@REGODT", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@REGODT").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")
                        .Parameters.Add("@DATOPLANNER", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAToPlannerDt.Text) Then .Parameters("@DATOPLANNER").Value = Format(CDate(Me.DAToPlannerDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@SITEINSPECTED", SqlDbType.SmallDateTime)
                        If IsDate(Me.DASiteInspectedDt.Text) Then .Parameters("@SITEINSPECTED").Value = Format(CDate(Me.DASiteInspectedDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@PREASSESSCOMP", SqlDbType.SmallDateTime)
                        If IsDate(Me.PreAssessCompleteDate.Text) Then .Parameters("@PREASSESSCOMP").Value = Format(CDate(Me.PreAssessCompleteDate.Text), "dd/MM/yyyy")
                        .Parameters.Add("@REFTOCOMM", SqlDbType.SmallDateTime)
                        If IsDate(Me.RefToPlanCom.Text) Then .Parameters("@REFTOCOMM").Value = Format(CDate(Me.RefToPlanCom.Text), "dd/MM/yyyy")
                        .Parameters.Add("@TOTYPE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAToTypingDt.Text) Then .Parameters("@TOTYPE").Value = Format(CDate(Me.DAToTypingDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@DETERMINED", SqlDbType.SmallDateTime)
                        If IsDate(Me.DADetermDt.Text) Then .Parameters("@DETERMINED").Value = Format(CDate(Me.DADetermDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@APPNOTIFY", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAAppNotDt.Text) Then .Parameters("@APPNOTIFY").Value = Format(CDate(Me.DAAppNotDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@CONSENTPOSTED", SqlDbType.SmallDateTime)
                        If IsDate(Me.ConsentPostedDate.Text) Then .Parameters("@CONSENTPOSTED").Value = Format(CDate(Me.ConsentPostedDate.Text), "dd/MM/yyyy")
                        .Parameters.Add("@TREEFEE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAFreeTreeDt.Text) Then .Parameters("@TREEFEE").Value = Format(CDate(Me.DAFreeTreeDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@PUBCONSENT", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAConsentPubDt.Text) Then .Parameters("@PUBCONSENT").Value = Format(CDate(Me.DAConsentPubDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@OCCDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAOccDt.Text) Then .Parameters("@OCCDATE").Value = Format(CDate(Me.DAOccDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@PERMEXT", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAPermExDt.Text) Then .Parameters("@PERMEXT").Value = Format(CDate(Me.DAPermExDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@ADVISEDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAAdvisedDt.Text) Then .Parameters("@ADVISEDATE").Value = Format(CDate(Me.DAAdvisedDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@COMMENTDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DACommDt.Text) Then .Parameters("@COMMENTDTE").Value = Format(CDate(Me.DACommDt.Text), "dd/MM/yyyy")
                        .Parameters.Add("@COMPDATE", SqlDbType.SmallDateTime)
                        If IsDate(DACompletedDt.Text) Then .Parameters("@COMPDATE").Value = Format(CDate(Me.DACompletedDt.Text), "dd/MM/yyyy")

                        .Parameters.Add("@APZYESNO", SqlDbType.Int).Value = Me.chkAPZYesNo.CheckState

                        If cboDAAuthorityId.Text <> String.Empty Then .Parameters.Add("@AUTHORITY", SqlDbType.Int).Value = CInt(cboDAAuthorityId.SelectedValue)
                        If cboReasonOver40.Text <> String.Empty Then .Parameters.Add("@OVER40REASON", SqlDbType.Int).Value = CInt(cboReasonOver40.SelectedValue)

                        .Parameters.Add("@STOPCLOCK", SqlDbType.Int).Value = Me.chkAPZYesNo.CheckState

                        'If cboDAAuthorityId.Text <> String.Empty Then .Parameters.Add("@AUTHORITY", SqlDbType.Int).Value = CInt(cboDAAuthorityId.SelectedValue)

                        If cboAdvertSignDepot.SelectedIndex <> -1 Then .Parameters.Add("@ADVERTDEPOT", SqlDbType.NVarChar).Value = cboAdvertSignDepot.SelectedValue.ToString

                        If rbNone.Checked = True Then
                            .Parameters.Add("@ADVERTNOTCHECK", SqlDbType.NVarChar).Value = 1

                        ElseIf rbNotify.Checked = True Then
                            .Parameters.Add("@ADVERTNOTCHECK", SqlDbType.NVarChar).Value = 2

                        ElseIf rbNotifyAdvert.Checked = True Then
                            .Parameters.Add("@ADVERTNOTCHECK", SqlDbType.NVarChar).Value = 3


                        End If

                        .ExecuteNonQuery()
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveTheStatus routine - form " & Me.Name)

            End Try
        End Using



    End Sub

#End Region

#Region "INT DEV"

    Private Sub btnEditIntDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditIntDev.Click

        'Edit IntDev Tab
        Me.grpEnvironment.Enabled = True
        Me.grpFish.Enabled = True
        Me.grpHeritage.Enabled = True
        Me.grpMine.Enabled = True
        Me.grpParks.Enabled = True
        Me.grpPollution.Enabled = True
        Me.grpRivers.Enabled = True
        Me.grpRoads.Enabled = True
        Me.grpWaste.Enabled = True
        Me.grpWater.Enabled = True
        btnEditIntDev.Enabled = False
        btnSaveIntDev.Enabled = True

    End Sub

    Private Sub btnSaveIntDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveIntDev.Click

        Me.grpEnvironment.Enabled = False
        Me.grpFish.Enabled = False
        Me.grpHeritage.Enabled = False
        Me.grpMine.Enabled = False
        Me.grpParks.Enabled = False
        Me.grpPollution.Enabled = False
        Me.grpRivers.Enabled = False
        Me.grpRoads.Enabled = False
        Me.grpWaste.Enabled = False
        Me.grpWater.Enabled = False
        btnEditIntDev.Enabled = True
        btnSaveIntDev.Enabled = False
        SaveIntDev()

    End Sub

    Private Sub SaveIntDev()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDA_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_IntDevTab"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text

                        .Parameters.Add("@S201", SqlDbType.Bit).Value = Me.chks201.CheckState
                        .Parameters.Add("@S205", SqlDbType.Bit).Value = Me.chks205.CheckState

                        .Parameters.Add("@FISHDTE", SqlDbType.SmallDateTime)

                        If IsDate(fishDate.Text) Then .Parameters("@FISHDTE").Value = Format(CDate(Me.fishDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S44", SqlDbType.Bit).Value = Me.chks44.CheckState

                        .Parameters.Add("@WASTEDTE", SqlDbType.SmallDateTime)
                        If IsDate(wasteDate.Text) Then .Parameters("@WASTEDTE").Value = Format(CDate(Me.wasteDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S17A", SqlDbType.Bit).Value = Me.chks17a.CheckState
                        .Parameters.Add("@S17C", SqlDbType.Bit).Value = Me.chks17c.CheckState
                        .Parameters.Add("@S17D", SqlDbType.Bit).Value = Me.chks17d.CheckState
                        .Parameters.Add("@S171", SqlDbType.Bit).Value = Me.chks171.CheckState

                        .Parameters.Add("@POLLDTE", SqlDbType.SmallDateTime)
                        If IsDate(PollutionDate.Text) Then .Parameters("@POLLDTE").Value = Format(CDate(Me.PollutionDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@P3A", SqlDbType.Bit).Value = Me.chkPart3a.CheckState

                        .Parameters.Add("@RIVERDTE", SqlDbType.SmallDateTime)
                        If IsDate(RiverDate.Text) Then .Parameters("@RIVERDTE").Value = Format(CDate(Me.RiverDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S10", SqlDbType.Bit).Value = Me.chks10.CheckState
                        .Parameters.Add("@S13A", SqlDbType.Bit).Value = Me.chks13a.CheckState
                        .Parameters.Add("@S18F", SqlDbType.Bit).Value = Me.chks18f.CheckState
                        .Parameters.Add("@S20B", SqlDbType.Bit).Value = Me.chks20b.CheckState
                        .Parameters.Add("@S20CA", SqlDbType.Bit).Value = Me.chks20ca.CheckState
                        .Parameters.Add("@S20L", SqlDbType.Bit).Value = Me.chks116.CheckState
                        .Parameters.Add("@S116", SqlDbType.Bit).Value = Me.chks116.CheckState
                        .Parameters.Add("@SP8", SqlDbType.Bit).Value = chkpart8.CheckState

                        .Parameters.Add("@WATERDTE", SqlDbType.SmallDateTime)
                        If IsDate(WaterDt.Text) Then .Parameters("@WATERDTE").Value = Format(CDate(Me.WaterDt.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S58", SqlDbType.Bit).Value = Me.chks58.CheckState

                        .Parameters.Add("@HERITAGEDTE", SqlDbType.SmallDateTime)
                        If IsDate(HeritageDate.Text) Then .Parameters("@HERITAGEDTE").Value = Format(CDate(Me.HeritageDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S15", SqlDbType.Bit).Value = Me.chks15.CheckState

                        .Parameters.Add("@MINEDTE", SqlDbType.SmallDateTime)
                        If IsDate(MineDate.Text) Then .Parameters("@MINEDTE").Value = Format(CDate(Me.MineDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S138", SqlDbType.Bit).Value = Me.chks138.CheckState

                        .Parameters.Add("@ROADSDTE", SqlDbType.SmallDateTime)
                        If IsDate(RoadsDate.Text) Then .Parameters("@ROADSDTE").Value = Format(CDate(Me.RoadsDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S90", SqlDbType.Bit).Value = Me.chks90.CheckState

                        .Parameters.Add("@NATDTE", SqlDbType.SmallDateTime)
                        If IsDate(NationalParksDate.Text) Then .Parameters("@NATDTE").Value = Format(CDate(Me.NationalParksDate.Text), "dd/MM/yyyy")

                        .Parameters.Add("@S43A", SqlDbType.Bit).Value = Me.chks43a.CheckState
                        .Parameters.Add("@S43B", SqlDbType.Bit).Value = Me.chks43b.CheckState
                        .Parameters.Add("@S43D", SqlDbType.Bit).Value = Me.chks43d.CheckState

                        .Parameters.Add("@ENVIRODTE", SqlDbType.SmallDateTime)
                        If IsDate(EnvironDate.Text) Then .Parameters("@ENVIRODTE").Value = Format(CDate(Me.EnvironDate.Text), "dd/MM/yyyy")

                        .ExecuteNonQuery()

                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDA_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

#End Region

    Private Sub btnEdit79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit79.Click
        txtOther79Cissues.ReadOnly = False
        btnSave79.Enabled = True
        btnEdit79.Enabled = False
    End Sub

    Private Sub btnSave79_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave79.Click
        txtOther79Cissues.ReadOnly = True
        btnSave79.Enabled = False
        btnEdit79.Enabled = True

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave79_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAAssessment_Other79Comments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@OTHER79", SqlDbType.NText).Value = txtOther79Cissues.Text
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave79_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub
    Private Sub btnEditCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCondition.Click
        Dim fOneUpCond As New InsertOneUpCondition
        With fOneUpCond
            .ID = CInt(dgvOneUpConditions.CurrentRow.Cells(2).Value)
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()

        End With

        Try
            LoadOneUpConditionsTableAdapter.Fill(Me.DAdatasets.LoadOneUpConditions, Me.txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub dgvOneUpConditions_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOneUpConditions.CellClick
        If e.RowIndex = -1 Then Exit Sub
        If e.ColumnIndex = -1 Then Exit Sub
        btnEditCondition.Enabled = True
        Me.btnRemoveOneOffCond.Enabled = True
    End Sub

    Private Sub cboSTDconditions_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSTDconditions.GotFocus
        cboSTDconditions.DroppedDown = True
    End Sub

    Private Sub cboSTDconditions_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSTDconditions.KeyUp
        If e.KeyCode = Keys.Enter Then
            InsertNewCondition()
            cboSTDconditions.SelectedIndex = -1
        End If

    End Sub

    Private Sub KeyPressSendTab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True

        End If
    End Sub


    Private Sub btneditVariationResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditVariationResponse.Click
        LockVariationResponseFields(False)
        btnSaveVariationResponse.Enabled = True
        btneditVariationResponse.Enabled = False
    End Sub

    Private Sub btnSaveVariationResponse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariationResponse.Click
        If MessageBox.Show("Update add this variation?" & txtFile.Text & " ?", "Add amend Variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateVariationRequestWithResponse"
                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(lblID.Text)
                        If IsDate(variationDecisionDate.Text) Then .Parameters.Add("@DATE", SqlDbType.SmallDateTime).Value = CDate(variationDecisionDate.Text)
                        If Me.cboVariationResult.SelectedIndex <> -1 Then .Parameters.Add("@RESULT", SqlDbType.VarChar).Value = Me.cboVariationResult.SelectedValue.ToString
                        .Parameters.Add("@AUTHORITY", SqlDbType.SmallInt).Value = CInt(Me.cboVariationAuthority.SelectedValue)
                        .ExecuteNonQuery()
                    End With

                End Using
                 
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        Try
            Me.RetrieveVariationsForDAAssessmentTableAdapter.Fill(Me.AssessmentData.RetrieveVariationsForDAAssessment, txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        btnSaveVariationResponse.Enabled = False
        btneditVariationResponse.Enabled = True
        btnDecisionDate.Enabled = False
        lblID.Text = "0"

        Me.cboVariationResult.SelectedIndex = -1
        Me.cboVariationAuthority.SelectedIndex = -1
        Me.variationDecisionDate.Text = String.Empty
        LockVariationResponseFields(True)

    End Sub

    Private Sub dgvVariations_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVariations.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If e.RowIndex = -1 Then Exit Sub
        If dgvVariations.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub
        lblID.Text = dgvVariations.CurrentRow.Cells(0).Value.ToString
        Me.cboVariationType.Text = dgvVariations.CurrentRow.Cells(1).Value.ToString
        txtVariationDetails.Text = dgvVariations.CurrentRow.Cells(2).Value.ToString
        Me.cboVariationResult.Text = dgvVariations.CurrentRow.Cells(3).Value.ToString
        Me.cboVariationAuthority.Text = dgvVariations.CurrentRow.Cells(4).Value.ToString
        Dim valuetocheck As String = dgvVariations.CurrentRow.Cells(5).Value.ToString
        If valuetocheck <> String.Empty Then
            Me.variationDecisionDate.Text = Format(CDate(dgvVariations.CurrentRow.Cells(5).Value.ToString), "dd/MM/yyyy")
        End If
        cboOfficerRecomforVariation.Text = dgvVariations.CurrentRow.Cells(6).Value.ToString
        txtOfficersReasons.Text = dgvVariations.CurrentRow.Cells(7).Value.ToString

        Me.btnEditVariation.Enabled = True
        Me.btnSaveVariation.Enabled = False
        Me.btnAddVariation.Enabled = True
        Me.btneditVariationResponse.Enabled = True
        Me.btnSaveVariationResponse.Enabled = False

    End Sub

    Private Sub txtConsentPlanNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsentPlanNumber.TextChanged

    End Sub


    Private Sub btnSaveDevHistComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDevHistComment.Click


        If MessageBox.Show("Update comment now?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDevHistComment_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SaveDevHistComment"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = DevHistoryCommentTextBox.Text
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDevHistComment_Click routine - form " & Me.Name)

            End Try
        End Using

        ShowHistoricalDATableAdapter.Fill(Me.DAdatasets.ShowHistoricalDA, Me.txtDANo.Text)

    End Sub

    Private Sub btnViewComplainceReason_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewComplainceReason.Click
        With ViewComments
            .CommentText = ComplianceStatProvCommentsTextBox.Text
            .ShowDialog()
            ComplianceStatProvCommentsTextBox.Text = .CommentText
            .Dispose()
        End With
    End Sub

    Private Sub btnViewConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewConclusion.Click
        With ViewComments
            .CommentText = txtApplicationConclreasons.Text
            .ShowDialog()
            txtApplicationConclreasons.Text = .CommentText
            .Dispose()
        End With
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReco.Click
        With ViewComments
            .CommentText = ApplicationConclreasonsTextBox.Text
            .ShowDialog()
            ApplicationConclreasonsTextBox.Text = .CommentText
            .Dispose()
        End With
    End Sub
End Class