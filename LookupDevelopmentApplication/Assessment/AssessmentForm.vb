Imports System.Data.SqlClient
Imports WORD = Microsoft.Office.Interop.Word

Imports System.IO

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared

Imports COMP = Compliance.ComplianceApp
Imports ADDINFO = ClassAdditionalInformation.AdditionalInfo
Imports System.Drawing.Printing

Imports SB = System.Text.StringBuilder

Imports ADHelpr = ADHelper.ADHelper


Public Class AssessmentForm



#Region "Properties"
    Public WriteOnly Property DisplayMyDA() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                'LoadForm(value)
            End If
        End Set
    End Property

    Private DANumber As String
    Public WriteOnly Property DANoToFind() As String
        Set(ByVal value As String)
            DANumber = value
            lblapplicationNo.Text = DANumber
        End Set
    End Property

    Private OriginalDANo As String = String.Empty
    Public WriteOnly Property OriginalDA() As String
        Set(ByVal value As String)
            OriginalDANo = value
        End Set
    End Property

#End Region

#Region "Declarations"
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private Const iNAME As Integer = 0
    Private Const iADDRESS As Integer = 1
    Private Const iFILENO As Integer = 2
    Private Const iPIN As Integer = 3
    Private Const iCC As Integer = 4
    Private Const iOWNERNAME As Integer = 5
    Private Const iPROPADDRESS As Integer = 6
    Private Const iTYPE As Integer = 7
    Private Const iDESC As Integer = 8
    Private Const iDA As Integer = 9

    Private bSearch As Boolean = False
    Private isloading As Boolean
    Private AddingNew As Boolean
    Private imgCurrentNavImage As Image
    Private objDS As New DataSet
    Private isEditingOrder As Boolean = False
    Private _RoadNumber As Integer
    Private Modification As Boolean = False

    Private bSaveChanges As Boolean = True


    Private EditMode As Boolean

    Private mdl_GroupImageID As Integer
    Private DAmodificationNumber As String = String.Empty

    Private compliancenumber As String = String.Empty
    Private ADHelper As New ADHelpr


    Private Const ImageSelected As Integer = 0
    Private Const ImageUnSelected As Integer = 1
    Private Const ImageHighLighted As Integer = 2

    Public Shared READ_ONLY_COLOR As Color = Color.Gray
    Public Shared READ_WRITE_COLOR As Color = Color.Black

#End Region

#Region "Navigation Code"

    Private Sub LockForm(ByVal pnl As Control, ByVal locked As Boolean)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                With cb
                    .Enabled = Not locked
                End With

            ElseIf TypeOf ctrl Is ESCDate.ESCDate Then
                Dim tb As ESCDate.ESCDate = DirectCast(ctrl, ESCDate.ESCDate)
                tb.Enabled = Not locked


            ElseIf TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                With tb
                    .ReadOnly = locked
                End With

            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim mskb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                With mskb
                    .ReadOnly = locked
                End With

            ElseIf TypeOf ctrl Is CheckBox Then
                Dim chkb As CheckBox = DirectCast(ctrl, CheckBox)
                chkb.Enabled = Not locked
            End If

            If ctrl.HasChildren Then
                LockForm(ctrl, locked)
            End If

        Next

    End Sub

    Private Sub BtnWanted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVariations.Click, btnStatutoryMerits.Click, btnModifications.Click, btnHistory.Click, btnContributions.Click, btnConclusions.Click
        For Each ctrl As Control In Me.pnlBtn.Controls
            If TypeOf ctrl Is Button Then ctrl.BackgroundImage = imlNavigation.Images(1)
        Next

        ClickButton(sender)

    End Sub

    Private Sub ClickButton(ByVal sender As System.Object)

        UnDockNavPanelControl(pnlDisplayConclusions)
        UnDockNavPanelControl(pnlDisplayContributions)
        UnDockNavPanelControl(pnlDisplayHistory)
        UnDockNavPanelControl(pnlDisplayModifications)
        UnDockNavPanelControl(pnlDisplayStatutory)
        UnDockNavPanelControl(pnlDisplayVariations)


        Dim btn As Button = DirectCast(sender, Button)
        Select Case btn.Tag.ToString.ToUpper
            Case "MERITS"
                lblMenu.Text = "Statutory and Merits"
                Me.pnlDisplayStatutory.Dock = DockStyle.Fill

            Case "HISTORY"
                lblMenu.Text = "Development History"
                pnlDisplayHistory.Dock = DockStyle.Fill

            Case "MODIFICATION"
                lblMenu.Text = "Modifications"
                pnlDisplayModifications.Dock = DockStyle.Fill

            Case "VARIATION"
                lblMenu.Text = "Variations"
                pnlDisplayVariations.Dock = DockStyle.Fill

            Case "CONTRIB"
                lblMenu.Text = "Contributions"
                pnlDisplayContributions.Dock = DockStyle.Fill

            Case "CONCLUSIONS"
                lblMenu.Text = "Conclusions"
                pnlDisplayConclusions.Dock = DockStyle.Fill
                'LoadTrapStatus()

        End Select
    End Sub

    Private Sub btnImpoundDetails_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContributions.MouseEnter, btnVariations.MouseEnter, btnStatutoryMerits.MouseEnter, btnModifications.MouseEnter, btnHistory.MouseEnter, btnConclusions.MouseEnter

        Dim btn As Button = CType(sender, Button)


        imgCurrentNavImage = btn.BackgroundImage
        btn.BackgroundImage = imlNavigation.Images(ImageHighLighted)
        btn.Cursor = Cursors.Hand

    End Sub

    Private Sub btnImpoundDetails_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContributions.MouseLeave, btnVariations.MouseLeave, btnStatutoryMerits.MouseLeave, btnModifications.MouseLeave, btnHistory.MouseLeave, btnConclusions.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackgroundImage = imgCurrentNavImage
        btn.Cursor = Cursors.Default

    End Sub

    Private Sub btnImpoundDetails_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnContributions.MouseUp, btnVariations.MouseUp, btnStatutoryMerits.MouseUp, btnModifications.MouseUp, btnHistory.MouseUp, btnConclusions.MouseUp
        imgCurrentNavImage = imlNavigation.Images(ImageSelected)

    End Sub

    Private Sub UnDockNavPanelControl(ByRef objPanel As Panel)
        'Undock the Panel
        objPanel.Dock = DockStyle.None

        'Move it out of the way
        objPanel.Location = New Point(5000, 5000)
    End Sub

    Private Sub ApplicationforApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.DataConnection = "Data Source=HOT;Initial Catalog=DevelopmentSQL;Integrated Security=True" Then
            MessageBox.Show("WARNING THIS IS TEST DATA DO NOT PROCEED,  RING BOB OR STEPHEN NOW!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        LoadCombo(cboVariationType, "usp_LoadUpVariationList")
        LoadCombo(Me.cboOfficerRecomforVariation, "usp_LoadVariationResultOfficersRecomCombo")

        LoadCombo(cboVariationResult, "usp_LoadUpVariationResultList")
        LoadCombo(cboVariationAuthority, "usp_LoadUpDelegatedAuthorityList")



        LoadVariationGrid(dgvVariations, lblapplicationNo.Text)
        LoadVariationGrid(dgvConclusionVariations, lblapplicationNo.Text)
        LoadUpConclusionConditions(dgvConditions)
        loadOneUpConditions(dgvConditionText)

        LoadUpConclusionConditions(dgvStandConditions)
        loadOneUpConditions(dgvOneOffConditions)

        LoadDevelopmentHistoryComment()


    End Sub


    Private Sub LoadDevelopmentHistoryComment()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDevelopmentHistoryComment routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetTheDevelopmentHistoryComment"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANumber
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        DevHistoryCommentTextBox.Text = objDataRow.Item("DevHistoryComment").ToString

                    Else
                        DevHistoryCommentTextBox.Text = String.Empty

                    End If


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadDevelopmentHistoryComment routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Combo Box Load"



    Private Sub LoadCombo(ByVal cbo As ComboBox, ByVal SPROC As String)

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
                        .CommandText = SPROC

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cbo
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .SelectedIndex = -1
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub


#End Region

#Region "Functions and Sub routines"

    Private Sub PrintAdvertisingSheet(ByVal objDT As DataTable)
        Dim objWordApp As New WORD.Application
        Dim objWordDoc As New WORD.Document
        Dim c As Integer = 1
        Dim r As Integer = 2
        objWordApp.Visible = True

        objWordDoc = objWordApp.Application.Documents.Add(Template:=("\\fs\common\db\development\consentadvert.dotx"), NewTemplate:=False, DocumentType:=0)
        With objWordDoc

            Dim RowCount As Integer = objDT.Rows.Count
            'if there is not base data then no need to continue
            If objDT.Rows.Count <= 0 Then
                Exit Sub
            Else
                For i As Integer = 0 To objDT.Rows.Count - 1
                    .Tables(1).Cell(r, c).Select()
                    If Not IsDBNull(objDT.Rows(i).Item(0)) Then
                        .Application.Selection.Text = objDT.Rows(i).Item(0).ToString
                        .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord
                    End If
                    c += 1
                    .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                    If Not IsDBNull(objDT.Rows(i).Item(1)) Then
                        .Tables(1).Cell(r, c).Select()
                    End If
                    .Application.Selection.Text = objDT.Rows(i).Item(1).ToString
                    'insert line break in cell
                    .Application.Selection.EndKey(Unit:=WORD.WdUnits.wdLine)
                    .Application.Selection.TypeParagraph()
                    If Not IsDBNull(objDT.Rows(i).Item(2)) Then
                        .Application.Selection.Text = objDT.Rows(i).Item(2).ToString
                        .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                    End If

                    c += 1
                    .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                    .Tables(1).Cell(r, c).Select()
                    If Not IsDBNull(objDT.Rows(i).Item(3)) Then
                        .Application.Selection.Text = objDT.Rows(i).Item(3).ToString
                        .Application.Selection.Range.Case = WORD.WdCharacterCase.wdTitleWord

                    End If
                    c += 1
                    .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)

                    If Not IsDBNull(objDT.Rows(i).Item(4)) Then
                        .Tables(1).Cell(r, c).Select()
                    End If
                    .Application.Selection.Text = objDT.Rows(i).Item(4).ToString
                    'insert line break in cell
                    .Application.Selection.EndKey(Unit:=WORD.WdUnits.wdLine)
                    .Application.Selection.TypeParagraph()

                    If Not IsDBNull(objDT.Rows(i).Item(5)) Then
                        .Application.Selection.Text = objDT.Rows(i).Item(5).ToString
                    End If


                    c += 1
                    .Application.Selection.MoveRight(Unit:=WORD.WdUnits.wdCell)
                    c = 1
                    r += 1
                Next
            End If

        End With


    End Sub


    Private Function ThereISLinkedApp(ByVal DANo As String) As Boolean
        Dim result As Boolean

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctThereISLinkedAppionName routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveModifiedDALinks"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount As Integer = objDT.Rows.Count

                    If RowCount = 0 Then
                        result = False
                    Else
                        result = True
                    End If


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctThereISLinkedAppionName routine - form " & Me.Name)

            End Try
        End Using


        Return result

    End Function





    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .GetTheDate = datefield.Text
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        'If TheNewDate <> String.Empty Then datefield.Text = TheNewDate
        datefield.Text = TheNewDate
    End Sub

    Private Function NZ(ByVal ValueToCheck As String) As Integer
        Dim valuetoreturn As Integer = 0
        If ValueToCheck <> String.Empty Then
            valuetoreturn = CInt(ValueToCheck)

        End If

        Return valuetoreturn

    End Function

    Private Sub KeyPressSendTab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True

        End If
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





    Private Sub clearForm(ByVal pnl As Control)

        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                cb.SelectedIndex = -1
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Checked = False
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim cb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                cb.Text = String.Empty
            ElseIf TypeOf ctrl Is RadioButton Then
                Dim cb As RadioButton = DirectCast(ctrl, RadioButton)
                cb.Checked = False

            End If
        Next


    End Sub




    Private Sub LockApplication()


    End Sub






    Private Sub ClearControls(ByVal pnl As Control)


        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                cb.SelectedIndex = -1

            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo As ComboBox = DirectCast(ctrl, ComboBox)
                cbo.SelectedIndex = -1


            ElseIf TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                tb.Text = String.Empty

            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim mskb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                mskb.Text = String.Empty

            ElseIf TypeOf ctrl Is CheckBox Then

                Dim chkb As CheckBox = DirectCast(ctrl, CheckBox)
                chkb.CheckState = CheckState.Unchecked

            ElseIf TypeOf ctrl Is ESCDate.ESCDate Then

                Dim dtp As ESCDate.ESCDate = DirectCast(ctrl, ESCDate.ESCDate)
                dtp.ClearTheDate()

                'ElseIf TypeOf ctrl Is Label Then

                '    Dim lbl As Label = DirectCast(ctrl, Label)
                '    Select Case lbl.Name
                '        Case "lblTrapID", "lblID"
                '            lbl.Text = String.Empty
                '        Case "lblStatus"
                '            lbl.Visible = False
                '    End Select

            End If

            If ctrl.HasChildren Then
                ClearControls(ctrl)
            End If

        Next

        _RoadNumber = 0

    End Sub



#End Region


#Region "Main Application"

    Private Sub PopulateForm()
        btnStatutoryMerits.Enabled = True
        btnModifications.Enabled = True

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
                        .CommandText = "usp_DAAssessmentData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    If objDT.Rows.Count > 0 Then

                        Dim objAssessRow As DataRow = objDT.Rows.Item(0)


                        Select Case objAssessRow.Item("ModSect96").ToString.ToUpper
                            Case "1"
                                lblModeType.Text = "Section96(1) Assessment"
                                pnlMod0.Visible = True
                                btnUpdateModDetails.Enabled = True
                                btnUpdateModData.Visible = True
                                Me.pnlMod1andMod2.Visible = False
                                Me.pnlMod2.Visible = False
                                Me.pnlMod1A.Visible = False
                                pnlMod1.Visible = False
                                Me.pnlMod1.Location = New Point(3, 3)
                            Case "1A"
                                pnlMod0.Visible = True
                                lblModeType.Text = "Section96(1A) Assessment"
                                btnUpdateModDetails.Enabled = True
                                btnUpdateModData.Visible = True
                                Me.pnlMod1andMod2.Visible = True
                                Me.pnlMod2.Visible = False
                                Me.pnlMod1A.Visible = True
                                pnlMod1.Visible = True
                                Me.pnlMod1.Location = New Point(8, 400)

                            Case "2"
                                pnlMod0.Visible = True
                                lblModeType.Text = "Section96(2) Assessment"
                                btnUpdateModDetails.Enabled = True
                                btnUpdateModData.Visible = True
                                Me.pnlMod1andMod2.Visible = True
                                Me.pnlMod2.Visible = True
                                Me.pnlMod1A.Visible = False
                                pnlMod1.Visible = True
                                Me.pnlMod1.Location = New Point(8, 573)


                            Case Else
                                lblModeType.Text = String.Empty
                                pnlMod0.Visible = True
                                Me.pnlMod1andMod2.Visible = False
                                Me.pnlMod2.Visible = False
                                pnlMod1.Visible = False
                                Me.pnlMod1A.Visible = False
                                btnUpdateModData.Enabled = False
                                btnUpdateModDetails.Enabled = True
                        End Select

                        Select Case CInt(objAssessRow.Item("DAAppTypeId"))

                            Case 3

                                Me.lblConclusion.Text = "MODIFICATION - Conclusion/Summary"
                                Me.pnlModificationConclusion.Visible = True
                                pnlMainConclusion.Visible = False
                                lblModification.Visible = True
                                Modification = True
                                btnStatutoryMerits.Enabled = False

                            Case Else

                                'Me.lblModification.Visible = False
                                btnModifications.Enabled = False
                                Modification = False
                                Me.lblConclusion.Text = "Conclusion/Summary"
                                Me.pnlModificationConclusion.Visible = False
                                pnlMainConclusion.Visible = True
                                lblModification.Visible = False
                        End Select


                        '---Conclusion
                        clearForm(pnlDisplayConclusions)

                        lblConclusion.Text = objAssessRow.Item("ComplianceStatProvComments").ToString
                        cboReferralsYesNo.SelectedValue = objAssessRow.Item("ReferralsYesNo").ToString
                        cboComplianceStatProvYesNo.SelectedValue = objAssessRow.Item("ComplianceStatProvYesNo").ToString
                        ComplianceStatProvCommentsTextBox.Text = objAssessRow.Item("ComplianceStatProvComments").ToString
                        cboVariationsYesNo.SelectedValue = objAssessRow.Item("VariationsYesNo").ToString
                        txtVariationComment.Text = objAssessRow.Item("VariationsComment").ToString

                        cboApplicationConclResult.SelectedValue = objAssessRow.Item("ApplicationConclResult").ToString
                        txtApplicationConclreasons.Text = objAssessRow.Item("ApplicationConclreasons").ToString
                        cboAssessmentDecision.SelectedValue = objAssessRow.Item("AssessmentDecision").ToString
                        cboAuthority.SelectedValue = objAssessRow.Item("AuthorityCode").ToString
                        txtConclusionDate.Text = objAssessRow.Item("PropDetermDate").ToString

                        cboModSec96Comply.SelectedValue = objAssessRow.Item("Modsec96ComplyYN").ToString
                        cboModSec79Satisfactory.SelectedValue = objAssessRow.Item("Modsec79SatisYN").ToString
                        cboModAssessmentDecision.SelectedValue = objAssessRow.Item("AssessmentDecision").ToString
                        ApplicationConclreasonsTextBox.Text = objAssessRow.Item("ApplicationConclreasons").ToString
                        cboModAuthority.SelectedValue = objAssessRow.Item("AuthorityCode").ToString
                        txtProposedDetermDate.Text = objAssessRow.Item("PropDetermDate").ToString

 
                        clearForm(pnlDisplayModifications)

                        '---Modification

                        ModDetailsTextBox.Text = objAssessRow.Item("ModDetails").ToString
                        ModReasonTextBox.Text = objAssessRow.Item("ModReason").ToString
                        cboModSect96.SelectedValue = objAssessRow.Item("ModSect96").ToString
                        ModSubstSameYNComboBox.SelectedValue = objAssessRow.Item("ModSubstSameYN").ToString
                        ModSubStSameCommentTextBox.Text = objAssessRow.Item("ModSubStSameComment").ToString
                        ModNotificationYNComboBox.SelectedValue = objAssessRow.Item("ModNotificationYN").ToString
                        ModSubmConsYNComboBox.SelectedValue = objAssessRow.Item("ModSubmConsYN").ToString
                        ModMinEnvImpactYNComboBox.SelectedValue = objAssessRow.Item("ModMinEnvImpactYN").ToString
                        ModMinEnvImpCommentTextBox.Text = objAssessRow.Item("ModMinEnvImpComment").ToString
                        ModMinisterCommentTextBox.Text = objAssessRow.Item("ModMinisterComment").ToString
                        ModThreatSpecYNComboBox.SelectedValue = objAssessRow.Item("ModThreatSpecYN").ToString
                        ModThreatComplYNComboBox.SelectedValue = objAssessRow.Item("ModThreatComplYN").ToString
                        ModThreatCommentTextBox.Text = objAssessRow.Item("ModThreatComment").ToString
                        Modsect79cYNComboBox.SelectedValue = objAssessRow.Item("Modsect79cYN").ToString
                        ModSect79cCommentTextBox.Text = objAssessRow.Item("ModSect79cComment").ToString
                        ModSect94YNComboBox.SelectedValue = objAssessRow.Item("ModSect94YN").ToString
                        ModSect94CommentTextBox.Text = objAssessRow.Item("ModSect94Comment").ToString

                        ModConsMinisterYNComboBox.SelectedValue = objAssessRow.Item("ModConsMinisterYN").ToString
                        ModMinisterOBjYNComboBox.SelectedValue = objAssessRow.Item("ModMinisterOBjYN").ToString
                        ModMinisterCommentTextBox.Text = objAssessRow.Item("ModMinisterComment").ToString

                        txtOther79Cissues.Text = objAssessRow.Item("Other79CIssues").ToString
                        If Not IsDBNull(objAssessRow.Item("DADetermDt")) Then lblDetermineDate.Text = Format(CDate(objAssessRow.Item("DADetermDt")), "dd/MM/yyyy")


                        lblAssessmentreport.Text = objAssessRow.Item("PrintedReportName").ToString

                        If lblAssessmentreport.Text <> String.Empty Then

                            If lblAssessmentreport.Text <> "EASED" Then

                                gbxAssessmentRept.Visible = True


                            Else

                                gbxAssessmentRept.Visible = False

                            End If

                        Else

                            gbxAssessmentRept.Visible = False

                        End If


                            'gbxAssessmentRept.Visible = lblAssessmentreport.Text <> "EASED" Or lblAssessmentreport.Text <> String.Empty

                            lblAssessmentReportEased.Visible = lblAssessmentreport.Text = "EASED"

                            If IsDBNull(objAssessRow.Item("GenImpactCompt")) Then
                                Me.picGenImpacts.Visible = False
                            Else
                                Me.picGenImpacts.Visible = objAssessRow.Item("GenImpactCompt")
                            End If

                            If IsDBNull(objAssessRow.Item("DPComplt")) Then
                                Me.picDP.Visible = False
                            Else
                                Me.picDP.Visible = CBool(objAssessRow.Item("DPComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("ThreatenSpecComplt")) Then
                                Me.picThreaten.Visible = False
                            Else
                                Me.picThreaten.Visible = CBool(objAssessRow.Item("ThreatenSpecComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("TraficComplt")) Then
                                Me.picTraffic.Visible = False
                            Else
                                Me.picTraffic.Visible = CBool(objAssessRow.Item("TraficComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("SocialComplt")) Then
                                Me.picSocial.Visible = False
                            Else
                                Me.picSocial.Visible = CBool(objAssessRow.Item("SocialComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("DDAComplt")) Then
                                Me.picDDA.Visible = False
                            Else
                                Me.picDDA.Visible = CBool(objAssessRow.Item("DDAComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("HeritageComplt")) Then
                                Me.picHeritage.Visible = False
                            Else
                                Me.picHeritage.Visible = CBool(objAssessRow.Item("HeritageComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("LandScapeComplt")) Then
                                Me.picLandscape.Visible = False
                            Else
                                Me.picLandscape.Visible = CBool(objAssessRow.Item("LandScapeComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("SustainComplt")) Then
                                Me.picSustain.Visible = False
                            Else
                                Me.picSustain.Visible = CBool(objAssessRow.Item("SustainComplt"))
                            End If

                            If IsDBNull(objAssessRow.Item("SubDiviComplte")) Then
                                Me.picSubDivision.Visible = False
                            Else
                                Me.picSubDivision.Visible = CBool(objAssessRow.Item("SubDiviComplte"))
                            End If


                            If IsDBNull(objAssessRow.Item("LEPComplt")) Then
                                Me.picLEP.Visible = False
                            Else
                                Me.picLEP.Visible = CBool(objAssessRow.Item("LEPComplt"))
                            End If


                            If IsDBNull(objAssessRow.Item("SEPPComplt")) Then
                                Me.picSEPP.Visible = False
                            Else
                                Me.picSEPP.Visible = CBool(objAssessRow.Item("SEPPComplt"))
                            End If


                            If IsDBNull(objAssessRow.Item("DCPComplt")) Then
                                Me.picDCP.Visible = False
                            Else
                                Me.picDCP.Visible = CBool(objAssessRow.Item("DCPComplt"))
                            End If


                            If IsDBNull(objAssessRow.Item("DAMSComplt")) Then
                                Me.picDAMS.Visible = False
                            Else
                                Me.picDAMS.Visible = CBool(objAssessRow.Item("DAMSComplt"))
                            End If


                            If IsDBNull(objAssessRow.Item("REPComplt")) Then
                                Me.picREP.Visible = False
                            Else
                                Me.picREP.Visible = CBool(objAssessRow.Item("REPComplt"))
                            End If


                            If IsDBNull(objAssessRow.Item("Guidlines")) Then
                                Me.picGUIDES.Visible = False
                            Else
                                Me.picGUIDES.Visible = CBool(objAssessRow.Item("Guidlines"))
                            End If

                            If IsDBNull(objAssessRow.Item("DCPCheckListComplt")) Then
                                Me.picDCPchkList.Visible = False
                            Else
                                Me.picDCPchkList.Visible = CBool(objAssessRow.Item("DCPCheckListComplt"))
                            End If


                        End If

                    ReloadContributionsGrids()
                    LoadHistoricalGrid()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub AssessmentForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        btnHistory.BackgroundImage = imlNavigation.Images(ImageSelected)
        PopulateForm()
    End Sub


#End Region

#Region "Menu"



    Private Sub SepticApprovalsByTownAndTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "SepticApprovalsByTownAndType.rpt"
            .StoredProcedureName = "usp_rpt_SepticApprovalsByTownAndType"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub








#End Region


    Public Sub New()
        isloading = True
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

  

        lblMenu.Text = "Development History"
        Me.pnlDisplayHistory.Dock = DockStyle.Fill

        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink


        LoadGenericAnswersToQuestions(cboReferralsYesNo)
        LoadGenericAnswersToQuestions(cboComplianceStatProvYesNo)
        LoadGenericAnswersToQuestions(cboVariationsYesNo)

        'LoadGenericAnswersToQuestions(cboModSect96)
        LoadGenericAnswersToQuestions(ModSubstSameYNComboBox)
        LoadGenericAnswersToQuestions(ModNotificationYNComboBox)
        LoadGenericAnswersToQuestions(ModSubmConsYNComboBox)
        LoadGenericAnswersToQuestions(ModMinEnvImpactYNComboBox)
        LoadGenericAnswersToQuestions(ModThreatSpecYNComboBox)
        LoadGenericAnswersToQuestions(ModThreatComplYNComboBox)
        LoadGenericAnswersToQuestions(Modsect79cYNComboBox)
        LoadGenericAnswersToQuestions(ModSect94YNComboBox)
        LoadGenericAnswersToQuestions(ModConsMinisterYNComboBox)
        LoadGenericAnswersToQuestions(ModMinisterOBjYNComboBox)

        LoadAuthorityCombo(cboModAuthority)
        LoadAuthorityCombo(cboAuthority)

        LoadSection94Combo()
        LoadSection94Type()

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

        LoadConclusionRecomendation()




        isloading = False
    End Sub



#Region "Variation Tab"

    Private Sub dgvVariations_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVariations.CellClick
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

    Private Sub btneditVariationResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditVariationResponse.Click
        LockVariationResponseFields(False)
        btnSaveVariationResponse.Enabled = True
        btneditVariationResponse.Enabled = False
    End Sub

    Private Sub btnSaveVariationResponse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariationResponse.Click
        If MessageBox.Show("Update add this variation?", "Add amend Variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
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

        Try
            LoadVariationGrid(dgvVariations, lblapplicationNo.Text)

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



    Private Sub btnAddNewVariationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TODO: Write  code for btnAddNewVariationType button

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

    Private Sub btnDecisionDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecisionDate.Click
        RetrieveDate(variationDecisionDate)
    End Sub

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

    Private Sub btnSaveVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariation.Click

        If Not VariationOK() Then Exit Sub

        If MessageBox.Show("Update add this variation?", "Add amend Variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
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
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = lblapplicationNo.Text
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

        Try
            LoadVariationGrid(dgvVariations, lblapplicationNo.Text)

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

    Private Sub LoadVariationGrid(ByVal Grid As DataGridView, ByVal DANo As String)

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationGrid routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveVariationsForDAAssessment"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo

                    End With


                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With dgvVariations
                        .DataSource = objDT
                        .Refresh()
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationGrid routine - form " & Me.Name)

            End Try
        End Using


    End Sub


#End Region

#Region "Conclusions"


    Private Sub loadOneUpConditions(ByVal dgv As DataGridView)

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
                        .CommandText = "usp_LoadOneUpConditions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgv.DataSource = objDT
                    dgv.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnProposedDetermDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProposedDetermDate.Click
        RetrieveDate(txtProposedDetermDate)
    End Sub

    Private Sub btnViewReco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReco.Click
        With ViewComments
            .CommentText = ApplicationConclreasonsTextBox.Text
            .ShowDialog()
            ApplicationConclreasonsTextBox.Text = .CommentText
            .Dispose()
        End With
    End Sub

    Private Sub LoadUpConclusionConditions(ByVal dgv As DataGridView)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpConclusionConditions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpConditionList"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgv.DataSource = objDT
                    dgv.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpConclusionConditions routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadConclusionRecomendation()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadConclusionRecomendation routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadConclusionRecomendationCombo"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboAssessmentDecision
                        .DataSource = objDT
                        .DisplayMember = "RecoResultDesc"
                        .ValueMember = "RecommendedResult"
                        .SelectedIndex = -1
                    End With

                    'dgvSales
                    'dgvSales.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadConclusionRecomendation routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadAuthorityCombo(ByVal combo As ComboBox)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAuthorityCombo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadAuthorityComboBox"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With combo
                        .DataSource = objDT
                        .DisplayMember = "Description"
                        .ValueMember = "id"
                        .SelectedIndex = -1

                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAuthorityCombo routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub LoadGenericAnswersToQuestions(ByVal combo As ComboBox)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadGenericAnswersToQuestions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GenericAnswersToQuestions"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With combo
                        .DataSource = objDT
                        .DisplayMember = "ResultCodeDesc"
                        .ValueMember = "ResultCode"
                        .SelectedIndex = -1
                    End With
                    'dgvSales
                    'dgvSales.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadGenericAnswersToQuestions routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnViewConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewConclusion.Click
        With ViewComments
            .CommentText = txtApplicationConclreasons.Text
            .ShowDialog()
            txtApplicationConclreasons.Text = .CommentText
            .Dispose()
        End With
    End Sub

    Private Sub btnUpdateConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateConclusion.Click
        Dim modification As Boolean = pnlModificationConclusion.Visible = True
        Dim OKtoProceed As Boolean = False


        ' Request list item number 22 RO 2 May 2011
        If modification Then
            OKtoProceed = modificationConclusionChecksOut()
        Else
            OKtoProceed = ConclusionChecksOut()

        End If

        If Not OKtoProceed Then Exit Sub

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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.lblapplicationNo.Text
                        If cboReferralsYesNo.SelectedIndex <> -1 Then .Parameters.Add("@ReferralsYesNo", SqlDbType.NVarChar).Value = Me.cboReferralsYesNo.SelectedValue.ToString
                        If cboComplianceStatProvYesNo.SelectedIndex <> -1 Then .Parameters.Add("@ComplianceStatProvYesNo", SqlDbType.NVarChar).Value = Me.cboComplianceStatProvYesNo.SelectedValue.ToString
                        .Parameters.Add("@ComplianceStatProvComments", SqlDbType.NText).Value = Me.ComplianceStatProvCommentsTextBox.Text
                        If cboVariationsYesNo.SelectedIndex <> -1 Then .Parameters.Add("@VariationsYesNo", SqlDbType.NVarChar).Value = Me.cboVariationsYesNo.SelectedValue.ToString
                        .Parameters.Add("@VariationsComment", SqlDbType.NText).Value = txtVariationComment.Text

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

        Dim sbMsg As New SB



        If Not IsDate(txtConclusionDate.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.txtConclusionDate, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.txtConclusionDate, "This is a required field")
                sbMsg.Append("ConclusionChecksOut Date is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtConclusionDate, "")

        End If

        If Me.cboReferralsYesNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboReferralsYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboReferralsYesNo, "This is a required field")
                sbMsg.Append("Referral is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboReferralsYesNo, "")

        End If
        If Me.cboComplianceStatProvYesNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboComplianceStatProvYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboComplianceStatProvYesNo, "This is a required field")
                sbMsg.Append("Compliance stat provided is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboComplianceStatProvYesNo, "")

        End If
        If Me.cboVariationsYesNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboVariationsYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboVariationsYesNo, "This is a required field")
                sbMsg.Append("Variation is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboVariationsYesNo, "")

        End If

        If Me.cboApplicationConclResult.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboApplicationConclResult, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboApplicationConclResult, "This is a required field")
                sbMsg.Append("Summary conclusion is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboApplicationConclResult, "")

        End If

        If Me.cboAuthority.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboAuthority, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboAuthority, "This is a required field")
                sbMsg.Append("Authority is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboAuthority, "")

        End If


        If Me.txtApplicationConclreasons.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtApplicationConclreasons, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtApplicationConclreasons, "A comment is required")
                sbMsg.Append("Conclusion reasons required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtApplicationConclreasons, "")

        End If

        If sbMsg.ToString <> String.Empty Then

            MessageBox.Show(sbMsg.ToString, "Following Fields need to be completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return result


    End Function


    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        RetrieveDate(txtConclusionDate)
    End Sub

    Private Sub btnViewComplainceReason_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewComplainceReason.Click
        With ViewComments
            .CommentText = ComplianceStatProvCommentsTextBox.Text
            .ShowDialog()
            ComplianceStatProvCommentsTextBox.Text = .CommentText
            .Dispose()
        End With
    End Sub

    Private Sub cboModAssessmentDecision_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModAssessmentDecision.SelectedValueChanged
        If cboModAssessmentDecision.SelectedIndex = -1 Then Exit Sub
        Dim recommendationTwo As String = String.Empty
        Dim decision As String = String.Empty
        If cboModAssessmentDecision.SelectedValue.ToString = "R" Then
            decision = "remains unchanged for the reasons set out below:"
        ElseIf cboModAssessmentDecision.SelectedValue.ToString = "A" Then
            decision = "is modified in the manner specified for the reasons set out below:-"
        End If

        recommendationTwo = "and therefore the consent notice dated " & lblDetermineDate.Text & " " & decision

        lblRecommendTwo.Text = recommendationTwo

    End Sub


#End Region 'Conclusions

#Region "Modifications"

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
                pnlMod1.Visible = False
                Me.pnlMod1.Location = New Point(3, 3)
            Case "1A"
                pnlMod0.Visible = True
                btnUpdateModData.Visible = True
                lblModeType.Text = "Section96(1A) Assessment"
                Me.pnlMod1andMod2.Visible = True
                Me.pnlMod2.Visible = False
                Me.pnlMod1A.Visible = True
                pnlMod1.Visible = True
                Me.pnlMod1.Location = New Point(8, 400)

            Case "2"
                pnlMod0.Visible = True
                btnUpdateModData.Visible = True
                lblModeType.Text = "Section96(2) Assessment"
                Me.pnlMod1andMod2.Visible = True
                Me.pnlMod2.Visible = True
                Me.pnlMod1A.Visible = False
                pnlMod1.Visible = True
                Me.pnlMod1.Location = New Point(8, 573)


            Case Else
                lblModeType.Text = String.Empty
                btnUpdateModData.Visible = False
                pnlMod1.Visible = True
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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
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

        PopulateForm()


    End Sub

#End Region 'Modifications

#Region "Contributions"

    Private Sub ReloadContributionsGrids()
        '-------Load the section64 data------

        Try
            LoadProposedContributions()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        '------------------------------------

        '-------Load the section94 data------
        Try
            LoadProposedSection94Contributions()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        '------------------------------------

        '-------Load the Bond data------
        Try
            LoadProposedBondContributions()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        '------------------------------------

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

    'Private Sub btnInsertIntoLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertIntoLive.Click

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

    '                    .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
    '                    .ExecuteNonQuery()

    '                End With


    '            End Using
    '             



    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnInsertIntoLive_Click routine - form " & Me.Name)

    '        End Try
    '    End Using



    'End Sub

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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
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

    Private Sub LoadSection94Combo()



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94Combo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadSection94TypeComboBox"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboSection64Type
                        .DataSource = objDT
                        .DisplayMember = "s94PLAN"
                        .ValueMember = "s94Code"
                        .SelectedIndex = -1
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94Combo routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub LoadSection94Type()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94Type routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadS94Type"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboS64Type
                        .DataSource = objDT
                        .DisplayMember = "s94Type"
                        .ValueMember = "s94TypeId"
                        .SelectedIndex = -1
                    End With

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94Type routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub LoadProposedContributions()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadProposedContributions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadGridforProposedContributions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvSection64Contributions.DataSource = objDT
                    dgvSection64Contributions.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadProposedContributions routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub LoadProposedSection94Contributions()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadProposedSection94Contributions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadGridforProposedSect94Contributions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvSection94.DataSource = objDT
                    dgvSection94.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadProposedSection94Contributions routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub LoadProposedBondContributions()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadProposedBondContributions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadGridforProposedBondContributions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvProposedBondContrib.DataSource = objDT
                    dgvProposedBondContrib.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadProposedBondContributions routine - form " & Me.Name)

            End Try
        End Using





    End Sub


#End Region

#Region "History"


    Private Sub LoadHistoricalGrid()


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
                        .CommandText = "usp_ShowHistoricalDA"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    ShowHistoricalDADataGridView.DataSource = objDT
                    ShowHistoricalDADataGridView.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using






    End Sub

    Private Sub ShowHistoricalComments(ByVal PreviousDAno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in ShowHistoricalComments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Retrieve_DAHistoryComments"

                        .Parameters.Add("@PREVDANO", SqlDbType.NVarChar).Value = PreviousDAno
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        If Not IsDBNull(objDataRow.Item("ActedOn")) Then cboActedOn.SelectedValue = CInt(objDataRow.Item("ActedOn"))
                        CommentTextBox.Text = objDataRow.Item("Comment").ToString
                        'DevHistoryCommentTextBox.Text = objDataRow.Item("DevHistoryComment").ToString

                    End If


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in ShowHistoricalComments routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub ShowHistoricalDADataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ShowHistoricalDADataGridView.CellClick, ShowHistoricalDADataGridView.CellContentClick
        If e.ColumnIndex = -1 Then Exit Sub
        Try
            ShowHistoricalComments(ShowHistoricalDADataGridView.CurrentRow.Cells(0).Value.ToString)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.btnViewDa.Enabled = True
        Me.btnUpDateHistory.Enabled = True
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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .ExecuteNonQuery()
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrievePreviousDAHistory_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadHistoricalGrid()

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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .Parameters.Add("@ACTED", SqlDbType.NVarChar).Value = cboActedOn.SelectedValue.ToString
                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = CommentTextBox.Text
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnUpDateHistory_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadHistoricalGrid()


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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = DevHistoryCommentTextBox.Text
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDevHistComment_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadHistoricalGrid()

    End Sub


#End Region ' History

#Region "Statutory and Merit"

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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .Parameters.Add("@OTHER79", SqlDbType.NText).Value = txtOther79Cissues.Text
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave79_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private Sub btnLEP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLEP.Click

        With My.Forms.StatutoryLEP
            .AssessmentNo = lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnREP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREP.Click
        With My.Forms.StatutoryREP
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnSepp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSepp.Click
        With My.Forms.StatutorySEPP
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnGuidLines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuidLines.Click
        With My.Forms.StatutoryGuidelines
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnDCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCP.Click
        With My.Forms.StatutoryDCP
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnDams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDams.Click

        With My.Forms.StatutoryDAMS
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub


    Private Sub btnDCPCheckList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCPCheckList.Click
        With My.Forms.StatutoryDCPCheckList
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnGenImpacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenImpacts.Click


        With My.Forms.GeneralImpacts
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnDepositedPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositedPlan.Click

        With My.Forms.DepositedPlanAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnThreatenSpecies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThreatenSpecies.Click

        With My.Forms.ThreatenSpeciesAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnTraficCarParks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraficCarParks.Click

        With My.Forms.TrafficAssessment
            .AssessmentNo = lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSocialEconomic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocialEconomic.Click

        With My.Forms.SocialEconomicImpactsAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnDisabDiscrimAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisabDiscrimAct.Click

        With My.Forms.DiabilityDiscriminationActAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnHeritage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeritage.Click

        With My.Forms.HeritageAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnLandscaping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLandscaping.Click

        With My.Forms.LandscapingAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSustainability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSustainability.Click
        With My.Forms.SustainabilityAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSubdivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubdivision.Click
        With My.Forms.SubdivisionAssessment
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

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

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.lblapplicationNo.Text
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


#End Region

    Private Sub mnuPreviewAssessment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPreviewAssessment.Click

        Dim rptDocument As New ReportDocument
        Dim reportName As String = String.Empty
        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.lblapplicationNo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String
                If Modification Then
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

                    Dim sdate As String = Format(Today.Date, "dd_MM_yyyy")

                    reportName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\DAAssessment_" & lblapplicationNo.Text.Replace("/", "_") & "_DATE_" & sdate & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".pdf"

                    With rptDocument
                        .Load(strReportPath)
                        .SetDataSource(objDT)
                        .VerifyDatabase()
                        .ExportToDisk(ExportFormatType.PortableDocFormat, reportName)
                        '.PrintToPrinter(1, False, 1, 99)
                    End With
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in mnuPreviewAssessment_Click routine ")
                End Try

                InsertIntoTable(reportName)

                lblAssessmentreport.Text = reportName

                gbxAssessmentRept.Visible = True


                Dim WRD As New OpenDocument
                WRD.OpenVisible(reportName)


                'With My.Forms.ReportPrintScreen

                '    .ReportName = rptDocument

                '    .ShowDialog()

                '    .Dispose()



                'End With

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


    Private Sub InsertIntoTable(reportName As String)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoTable routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_InsertAssessmentReportName"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .Parameters.Add("@REPORTNAME", SqlDbType.NVarChar).Value = reportName
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertIntoTable routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnFinaliseDoc_Click(sender As System.Object, e As System.EventArgs) Handles btnFinaliseDoc.Click


     

        If MessageBox.Show("You are about to finalise this document into EASE. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

 
        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        Dim summary As String = "Application No. " & lblapplicationNo.Text & " Document Type: Assessment report"

 



        With My.Forms.InsertAssessmentIntoEASE



            .CustName = My.Forms.DAApplication.txtAppName.Text
            .CustAddress = My.Forms.DAApplication.txtAppAddress.Text & " " & My.Forms.DAApplication.txtAppTown.Text & " " & My.Forms.DAApplication.txtAppPcode.Text


            .WordDocLocation = lblAssessmentreport.Text
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = My.Forms.DAApplication.txtFileNo.Text
            .ShowDialog()
            .Dispose()
        End With



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
                        .CommandText = "usp_UPDATE_MarkAssessmentReportSentToEASE"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .ExecuteNonQuery()
                    End With
                End Using
  

                lblAssessmentreport.Text = String.Empty

                gbxAssessmentRept.Visible = False


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub btnDeleteDoc_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteDoc.Click
        Dim FileToDelete As String = lblAssessmentreport.Text

        If MessageBox.Show("You are about to delete this document FOREVER" & vbCrLf & "OK to proceed?", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

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
                        .CommandText = "usp_DELETE_AssessmentReportName"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .ExecuteNonQuery()
                    End With


                End Using


                My.Computer.FileSystem.DeleteFile(FileToDelete)


                lblAssessmentreport.Text = String.Empty

                gbxAssessmentRept.Visible = False


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try
        End Using

        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnViewEditDocument_Click(sender As System.Object, e As System.EventArgs) Handles btnViewEditDocument.Click

        Dim WRD As New OpenDocument
        WRD.OpenVisible(lblAssessmentreport.Text)

    End Sub
End Class
