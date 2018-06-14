Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports ADHelpr = ADHelper.ADHelper
Imports fso = System.IO
Imports SB = System.Text.StringBuilder
Imports WORD = Microsoft.Office.Interop.Word

Public Class NewAssessmentForm



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

    Private _NAR As Boolean
    Public WriteOnly Property NAR() As Boolean
        Set(ByVal value As Boolean)
            _NAR = value
        End Set
    End Property

    Private _ApplicantName As String
    Public WriteOnly Property ApplicantName() As String

        Set(ByVal value As String)
            _ApplicantName = value
        End Set
    End Property

    Private _ApplicantAddress As String
    Public WriteOnly Property ApplicantAddress() As String

        Set(ByVal value As String)
            _ApplicantAddress = value
        End Set
    End Property

    Private _ApplicantTown As String
    Public WriteOnly Property ApplicantTown() As String
        Set(ByVal value As String)
            _ApplicantTown = value
        End Set
    End Property

    Private _ApplicantPostCode As String
    Public WriteOnly Property ApplicantPostCode() As String

        Set(ByVal value As String)
            _ApplicantPostCode = value
        End Set
    End Property

#End Region

#Region "Declarations"
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    'Private CNR As New CentalNamesInterface.CentralNames




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
    Private _AssessmentLocked As Boolean = False

    Private _PDFDocumentLocation As String = String.Empty

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

            If TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.ReadOnly = locked


                'ElseIf TypeOf ctrl Is ESCDate.ESCDate Then
                '    Dim tb As ESCDate.ESCDate = DirectCast(ctrl, ESCDate.ESCDate)
                '    tb.Enabled = Not locked


            ElseIf TypeOf ctrl Is TextEdit Then
                Dim tb As TextEdit = DirectCast(ctrl, TextEdit)
                tb.ReadOnly = locked

            ElseIf TypeOf ctrl Is MemoEdit Then
                Dim tb As MemoEdit = DirectCast(ctrl, MemoEdit)
                tb.ReadOnly = locked



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

    'Private Sub BtnWanted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVariations.Click, btnStatutoryMerits.Click, btnModifications.Click, btnHistory.Click, btnContributions.Click, btnConclusions.Click
    '    For Each ctrl As Control In Me.pnlBtn.Controls
    '        If TypeOf ctrl Is Button Then ctrl.BackgroundImage = imlNavigation.Images(1)
    '    Next

    '    ClickButton(sender)

    'End Sub

    'Private Sub ClickButton(ByVal sender As System.Object)

    '    UnDockNavPanelControl(pnlDisplayConclusions)
    '    UnDockNavPanelControl(pnlDisplayContributions)
    '    UnDockNavPanelControl(pnlDisplayHistory)
    '    UnDockNavPanelControl(pnlDisplayModifications)
    '    UnDockNavPanelControl(pnlDisplayStatutory)
    '    UnDockNavPanelControl(pnlDisplayVariations)


    '    Dim btn As Button = DirectCast(sender, Button)
    '    Select Case btn.Tag.ToString.ToUpper
    '        Case "MERITS"
    '            lblMenu.Text = "Statutory and Merits"
    '            Me.pnlDisplayStatutory.Dock = DockStyle.Fill

    '        Case "HISTORY"
    '            lblMenu.Text = "Development History"
    '            pnlDisplayHistory.Dock = DockStyle.Fill

    '        Case "MODIFICATION"
    '            lblMenu.Text = "Modifications"
    '            pnlDisplayModifications.Dock = DockStyle.Fill

    '        Case "VARIATION"
    '            lblMenu.Text = "Variations"
    '            pnlDisplayVariations.Dock = DockStyle.Fill

    '        Case "CONTRIB"
    '            lblMenu.Text = "Contributions"
    '            pnlDisplayContributions.Dock = DockStyle.Fill

    '        Case "CONCLUSIONS"
    '            lblMenu.Text = "Conclusions"
    '            pnlDisplayConclusions.Dock = DockStyle.Fill
    '            'LoadTrapStatus()

    '    End Select
    'End Sub

    'Private Sub btnImpoundDetails_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContributions.MouseEnter, btnVariations.MouseEnter, btnStatutoryMerits.MouseEnter, btnModifications.MouseEnter, btnHistory.MouseEnter, btnConclusions.MouseEnter

    '    Dim btn As Button = CType(sender, Button)


    '    imgCurrentNavImage = btn.BackgroundImage
    '    btn.BackgroundImage = imlNavigation.Images(ImageHighLighted)
    '    btn.Cursor = Cursors.Hand

    'End Sub

    'Private Sub btnImpoundDetails_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContributions.MouseLeave, btnVariations.MouseLeave, btnStatutoryMerits.MouseLeave, btnModifications.MouseLeave, btnHistory.MouseLeave, btnConclusions.MouseLeave
    '    Dim btn As Button = CType(sender, Button)
    '    btn.BackgroundImage = imgCurrentNavImage
    '    btn.Cursor = Cursors.Default

    'End Sub

    'Private Sub btnImpoundDetails_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnContributions.MouseUp, btnVariations.MouseUp, btnStatutoryMerits.MouseUp, btnModifications.MouseUp, btnHistory.MouseUp, btnConclusions.MouseUp
    '    imgCurrentNavImage = imlNavigation.Images(ImageSelected)

    'End Sub

    'Private Sub UnDockNavPanelControl(ByRef objPanel As Panel)
    '    'Undock the Panel
    '    objPanel.Dock = DockStyle.None

    '    'Move it out of the way
    '    objPanel.Location = New Point(5000, 5000)
    'End Sub

    Private Sub ApplicationforApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.connectionString = "Data Source=DEVELOPMENT\DEV;Initial Catalog=DevelopmentSQL;Integrated Security=True" Then
            MessageBox.Show("WARNING THIS IS TEST DATA DO NOT PROCEED,  RING BOB OR STEPHEN NOW!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        IsAssessmentLocked()


        LoadCombo(cboVariationType, "usp_LoadUpVariationList")
        LoadCombo(Me.cboOfficerRecomforVariation, "usp_LoadVariationResultOfficersRecomCombo")

        LoadUpVariationResultCombo()
        LoadDelegatedAuthority()



        LoadVariationGridData(lblapplicationNo.Text)

        LoadVariationGrid(lblapplicationNo.Text)
        LoadUpConclusionConditions(dgvConditions)
        loadOneUpConditions(dgvConditionText)

        LoadUpConclusionConditions(dgvStandConditions)
        loadOneUpConditions(dgvOneOffConditions)

        LoadDevelopmentHistoryComment()

        pnlModificationConclusion.Visible = False

        btnLockAssessment.Visible = Not _AssessmentLocked

        btnEditVariation.Enabled = Not _AssessmentLocked
        btnAddVariation.Enabled = Not _AssessmentLocked
        btneditVariationResponse.Enabled = Not _AssessmentLocked
        btnRemoveVariation.Enabled = Not _AssessmentLocked
        btnUpdateModDetails.Enabled = Not _AssessmentLocked

    End Sub

    Private Sub LoadUpVariationResultCombo()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpVariationResultCombo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpVariationResultList"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboVariationResult.Properties

                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "DisplayMember"

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboVariationResult.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))
                    col2.Add(New LookUpColumnInfo("VariationResultDesc", 0))

                    col2.Item(1).Visible = False
                    col2.Item(2).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpVariationResultCombo routine - form " & Me.Name)

            End Try
        End Using


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

    'Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
    '    Me.Close()
    'End Sub

#End Region

#Region "Combo Box Load"



    Private Sub LoadCombo(ByVal cbo As LookUpEdit, ByVal SPROC As String)

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

                    With cbo.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cbo.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    col2.Item(1).Visible = False


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub LoadDelegatedAuthority()

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
                        .CommandText = "usp_LoadUpDelegatedAuthorityList"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboVariationAuthority.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboVariationAuthority.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))
                    col2.Add(New LookUpColumnInfo("DelegatedAuthorityId", 0))

                    col2.Item(1).Visible = False
                    col2.Item(2).Visible = False

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub

#End Region

#Region "Functions and Sub routines"

    Private Sub IsAssessmentLocked()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in IsAssessmentLocked routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_IsAssessmentLocked"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANumber
                        .Parameters.Add("@RESULT", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()

                        _AssessmentLocked = CBool(.Parameters("@RESULT").Value)


                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in IsAssessmentLocked routine - form " & Me.Name)

            End Try
        End Using



    End Sub


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

        Using cn As New SqlConnection(My.Settings.connectionString)
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

            If TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.EditValue = Nothing

            ElseIf TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.Text = String.Empty

            ElseIf TypeOf ctrl Is MemoEdit Then
                Dim cb As MemoEdit = DirectCast(ctrl, MemoEdit)
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





    Private Sub ClearControls(ByVal pnl As Control)


        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.EditValue = Nothing


            ElseIf TypeOf ctrl Is MemoEdit Then
                Dim tb As MemoEdit = DirectCast(ctrl, MemoEdit)
                tb.Text = String.Empty


            ElseIf TypeOf ctrl Is TextEdit Then
                Dim tb As TextEdit = DirectCast(ctrl, TextEdit)
                tb.Text = String.Empty

            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim mskb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                mskb.Text = String.Empty

            ElseIf TypeOf ctrl Is CheckBox Then

                Dim chkb As CheckBox = DirectCast(ctrl, CheckBox)
                chkb.CheckState = CheckState.Unchecked

                'ElseIf TypeOf ctrl Is ESCDate.ESCDate Then

                '    Dim dtp As ESCDate.ESCDate = DirectCast(ctrl, ESCDate.ESCDate)
                '    dtp.ClearTheDate()

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
        tpgStatutory.Enabled = True
        tpgModifications.Enabled = True

        pnlModificationConclusion.Visible = False

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
                                grpMod.Text = "Section96(1) Assessment"
                                scrolModification.Visible = True
                                btnUpdateModDetails.Enabled = Not _AssessmentLocked
                                btnUpdateModData.Visible = True
                                Me.pnlMod1andMod2.Visible = False
                                Me.pnlMod2.Visible = False
                                Me.pnlMod1A.Visible = False
                                pnlMod1.Visible = False
                                Me.pnlMod1.Location = New Point(3, 3)
                            Case "1A"
                                scrolModification.Visible = True
                                grpMod.Text = "Section96(1A) Assessment"
                                btnUpdateModDetails.Enabled = Not _AssessmentLocked
                                btnUpdateModData.Visible = True
                                Me.pnlMod1andMod2.Visible = True
                                Me.pnlMod2.Visible = False
                                Me.pnlMod1A.Visible = True
                                pnlMod1.Visible = True
                                Me.pnlMod1.Location = New Point(8, 400)

                            Case "2"
                                scrolModification.Visible = True
                                grpMod.Text = "Section96(2) Assessment"
                                btnUpdateModDetails.Enabled = Not _AssessmentLocked
                                btnUpdateModData.Visible = True
                                Me.pnlMod1andMod2.Visible = True
                                Me.pnlMod2.Visible = True
                                Me.pnlMod1A.Visible = False
                                pnlMod1.Visible = True
                                Me.pnlMod1.Location = New Point(8, 573)


                            Case Else
                                grpMod.Text = String.Empty
                                scrolModification.Visible = True
                                Me.pnlMod1andMod2.Visible = False
                                Me.pnlMod2.Visible = False
                                pnlMod1.Visible = False
                                Me.pnlMod1A.Visible = False
                                btnUpdateModData.Enabled = False
                                btnUpdateModDetails.Enabled = Not _AssessmentLocked
                        End Select

                        Select Case CInt(objAssessRow.Item("DAAppTypeId"))

                            Case 3

                                Me.lblConclusion.Text = "MODIFICATION - Conclusion/Summary"
                                Me.pnlModificationConclusion.Visible = True
                                scrolMainConclusion.Visible = False
                                Modification = True
                                tpgStatutory.Enabled = False

                            Case Else


                                'Me.lblModification.Visible = False
                                tpgModifications.Enabled = False
                                Modification = False
                                Me.lblConclusion.Text = "Conclusion/Summary"
                                Me.pnlModificationConclusion.Visible = False
                                scrolMainConclusion.Visible = True
                        End Select


                        '---Conclusion
                        clearForm(pnlDisplayConclusions)

                        'lblConclusion.Text = objAssessRow.Item("ComplianceStatProvComments").ToString
                        cboReferralsYesNo.EditValue = objAssessRow.Item("ReferralsYesNo").ToString
                        cboComplianceStatProvYesNo.EditValue = objAssessRow.Item("ComplianceStatProvYesNo").ToString
                        ComplianceStatProvCommentsTextBox.Text = objAssessRow.Item("ComplianceStatProvComments").ToString
                        cboVariationsYesNo.EditValue = objAssessRow.Item("VariationsYesNo").ToString
                        txtVariationComment.Text = objAssessRow.Item("VariationsComment").ToString

                        cboApplicationConclResult.EditValue = objAssessRow.Item("ApplicationConclResult").ToString
                        txtApplicationConclreasons.Text = objAssessRow.Item("ApplicationConclreasons").ToString
                        cboAssessmentDecision.EditValue = objAssessRow.Item("AssessmentDecision").ToString

                        lupConflict.EditValue = objAssessRow.Item("ConflictOfInterest").ToString

                        cboAuthority.EditValue = objAssessRow.Item("AuthorityCode").ToString

                        If Not IsDBNull(objAssessRow.Item("PropDetermDate")) Then dteConclusionDate.EditValue = CDate(objAssessRow.Item("PropDetermDate"))

                        cboModSec96Comply.EditValue = objAssessRow.Item("Modsec96ComplyYN").ToString
                        cboModSec79Satisfactory.EditValue = objAssessRow.Item("Modsec79SatisYN").ToString
                        cboModAssessmentDecision.EditValue = objAssessRow.Item("AssessmentDecision").ToString
                        ApplicationConclreasonsTextBox.Text = objAssessRow.Item("ApplicationConclreasons").ToString
                        cboModAuthority.EditValue = objAssessRow.Item("AuthorityCode").ToString

                        If Not IsDBNull(objAssessRow.Item("PropDetermDate")) Then dteProposedDetermDate.EditValue = CDate(objAssessRow.Item("PropDetermDate"))


                        clearForm(pnlDisplayModifications)

                        '---Modification

                        ModDetailsTextBox.Text = objAssessRow.Item("ModDetails").ToString
                        ModReasonTextBox.Text = objAssessRow.Item("ModReason").ToString
                        cboModSect96.EditValue = objAssessRow.Item("ModSect96").ToString
                        ModSubstSameYNComboBox.EditValue = objAssessRow.Item("ModSubstSameYN").ToString
                        ModSubStSameCommentTextBox.Text = objAssessRow.Item("ModSubStSameComment").ToString
                        ModNotificationYNComboBox.EditValue = objAssessRow.Item("ModNotificationYN").ToString
                        ModSubmConsYNComboBox.EditValue = objAssessRow.Item("ModSubmConsYN").ToString
                        ModMinEnvImpactYNComboBox.EditValue = objAssessRow.Item("ModMinEnvImpactYN").ToString
                        ModMinEnvImpCommentTextBox.Text = objAssessRow.Item("ModMinEnvImpComment").ToString
                        ModMinisterCommentTextBox.Text = objAssessRow.Item("ModMinisterComment").ToString
                        ModThreatSpecYNComboBox.EditValue = objAssessRow.Item("ModThreatSpecYN").ToString
                        ModThreatComplYNComboBox.EditValue = objAssessRow.Item("ModThreatComplYN").ToString
                        ModThreatCommentTextBox.Text = objAssessRow.Item("ModThreatComment").ToString
                        Modsect79cYNComboBox.EditValue = objAssessRow.Item("Modsect79cYN").ToString
                        ModSect79cCommentTextBox.Text = objAssessRow.Item("ModSect79cComment").ToString
                        ModSect94YNComboBox.EditValue = objAssessRow.Item("ModSect94YN").ToString
                        ModSect94CommentTextBox.Text = objAssessRow.Item("ModSect94Comment").ToString

                        ModConsMinisterYNComboBox.EditValue = objAssessRow.Item("ModConsMinisterYN").ToString
                        ModMinisterOBjYNComboBox.EditValue = objAssessRow.Item("ModMinisterOBjYN").ToString
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
                    LoadPlansToView()



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        LockForm(pnlConclusion, _AssessmentLocked)
        txtOther79Cissues.ReadOnly = _AssessmentLocked
        DevHistoryCommentTextBox.ReadOnly = _AssessmentLocked
        btnUpdateConclusion.Enabled = Not _AssessmentLocked
        LockForm(grpHistoricalDA, _AssessmentLocked)
        btnEdit79.Enabled = Not _AssessmentLocked
        btnRetrievePreviousDAHistory.Enabled = Not _AssessmentLocked
        btnSaveDevHistComment.Enabled = Not _AssessmentLocked

    End Sub

    Private Sub LoadPlansToView()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPlansToView routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_ApplicationPlan"

                        .Parameters.Add("@DANo", SqlDbType.VarChar).Value = lblapplicationNo.Text


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdPlans.DataSource = objDT


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPlansToView routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub AssessmentForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        PopulateForm()
    End Sub


#End Region

#Region "Menu"



    'Private Sub SepticApprovalsByTownAndTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepticApprovalsByTownAndTypeToolStripMenuItem.
    '    Dim reptview As New reportSetupApprovals

    '    With reptview
    '        .ReportToPrint = "SepticApprovalsByTownAndType.rpt"
    '        .StoredProcedureName = "usp_rpt_SepticApprovalsByTownAndType"
    '        .StartPosition = FormStartPosition.CenterParent
    '        .ShowDialog()
    '        .Dispose()

    '    End With
    'End Sub








#End Region


    Public Sub New()
        isloading = True
        ' This call is required by the Windows Form Designer.
        InitializeComponent()


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

        With Me.cboApplicationConclResult.Properties
            .DataSource = ConclusionSummary
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim colApplicationConclResult As LookUpColumnInfoCollection = cboApplicationConclResult.Properties.Columns
        colApplicationConclResult.Add(New LookUpColumnInfo("Name", 0))
        colApplicationConclResult.Add(New LookUpColumnInfo("Key", 0))

        colApplicationConclResult.Item(1).Visible = False


        Dim Sect64ContribType As New ArrayList

        ' Add division structure entries to the arraylist
        With Sect64ContribType
            .Add(New AreaType("S64", "1"))
            .Add(New AreaType("S94/S94A", "2"))
            .Add(New AreaType("Bond", "3"))
        End With

        With Me.cboContribType.Properties
            .DataSource = Sect64ContribType
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim colContribType As LookUpColumnInfoCollection = cboContribType.Properties.Columns
        colContribType.Add(New LookUpColumnInfo("Name", 0))
        colContribType.Add(New LookUpColumnInfo("Key", 0))

        colContribType.Item(1).Visible = False


        Dim Enacted As New ArrayList

        ' Add division structure entries to the arraylist
        With Enacted
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
        End With

        With cboActedOn.Properties
            .DataSource = Enacted
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim colActedOn As LookUpColumnInfoCollection = cboActedOn.Properties.Columns
        colActedOn.Add(New LookUpColumnInfo("Name", 0))
        colActedOn.Add(New LookUpColumnInfo("Key", 0))

        colActedOn.Item(1).Visible = False


        Dim ModSec96Comply As New ArrayList

        ' Add division structure entries to the arraylist
        With ModSec96Comply
            .Add(New Depots("Complies", "Y"))
            .Add(New Depots("does not comply", "n"))
        End With

        With Me.cboModSec96Comply.Properties
            .DataSource = ModSec96Comply
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim colModSec96Comply As LookUpColumnInfoCollection = cboModSec96Comply.Properties.Columns
        colModSec96Comply.Add(New LookUpColumnInfo("Name", 0))
        colModSec96Comply.Add(New LookUpColumnInfo("Key", 0))

        colModSec96Comply.Item(1).Visible = False

        Dim ModSec79Satisfactory As New ArrayList

        ' Add division structure entries to the arraylist
        With ModSec79Satisfactory
            .Add(New Depots("satisfactory", "Y"))
            .Add(New Depots("unsatisfactory", "n"))
        End With

        With Me.cboModSec79Satisfactory.Properties
            .DataSource = ModSec79Satisfactory
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim colModSec79Satisfactory As LookUpColumnInfoCollection = cboModSec79Satisfactory.Properties.Columns
        colModSec79Satisfactory.Add(New LookUpColumnInfo("Name", 0))
        colModSec79Satisfactory.Add(New LookUpColumnInfo("Key", 0))

        colModSec79Satisfactory.Item(1).Visible = False

        Dim Sect96 As New ArrayList

        ' Add division structure entries to the arraylist
        With Sect96
            .Add(New AreaType("1", "1"))
            .Add(New AreaType("1A", "1A"))
            .Add(New AreaType("2", "2"))
        End With

        With cboModSect96.Properties
            .DataSource = Sect96
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim colModSect96 As LookUpColumnInfoCollection = cboModSect96.Properties.Columns
        colModSect96.Add(New LookUpColumnInfo("Name", 0))
        colModSect96.Add(New LookUpColumnInfo("Key", 0))

        colModSect96.Item(1).Visible = False

        Dim ModAssessmentDecision As New ArrayList

        ' Add division structure entries to the arraylist
        With ModAssessmentDecision
            .Add(New Depots("Approved", "A"))
            .Add(New Depots("Refused", "R"))
        End With

        With Me.cboModAssessmentDecision.Properties
            .DataSource = ModAssessmentDecision
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With



        Dim conflictOfInterest As New ArrayList

        ' Add division structure entries to the arraylist
        With conflictOfInterest
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
        End With

        With lupConflict.Properties
            .DataSource = conflictOfInterest
            .DisplayMember = "Name"
            .ValueMember = "Key"
        End With

        Dim colConflict As LookUpColumnInfoCollection = lupConflict.Properties.Columns
        colConflict.Add(New LookUpColumnInfo("Name", 0))
        colConflict.Add(New LookUpColumnInfo("Key", 0))

        colConflict.Item(1).Visible = False

        LoadConclusionRecomendation()




        isloading = False
    End Sub



#Region "Variation Tab"


    Private Sub btneditVariationResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditVariationResponse.Click
        LockVariationResponseFields(False)
        btnSaveVariationResponse.Enabled = True
        btneditVariationResponse.Enabled = False
    End Sub

    Private Sub btnSaveVariationResponse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariationResponse.Click
        If MessageBox.Show("Update add this variation?", "Add amend Variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        If Not variationDecisionDate.EditValue Is Nothing Then .Parameters.Add("@DATE", SqlDbType.SmallDateTime).Value = CDate(variationDecisionDate.EditValue)
                        If Me.cboVariationResult.Text <> String.Empty Then .Parameters.Add("@RESULT", SqlDbType.VarChar).Value = Me.cboVariationResult.EditValue.ToString

                        If Me.cboVariationAuthority.Text <> String.Empty Then

                            Dim row As DataRowView = CType(cboVariationAuthority.GetSelectedDataRow, DataRowView)

                            Dim TheReportName As String = row("DelegatedAuthorityId").ToString

                            .Parameters.Add("@AUTHORITY", SqlDbType.SmallInt).Value = CInt(TheReportName)

                        End If

                        .ExecuteNonQuery()
                    End With

                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            LoadVariationGridData(lblapplicationNo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        btnSaveVariationResponse.Enabled = False
        btneditVariationResponse.Enabled = True
        variationDecisionDate.ReadOnly = False
        lblID.Text = "0"

        Me.cboVariationResult.EditValue = Nothing
        Me.cboVariationAuthority.EditValue = Nothing
        Me.variationDecisionDate.EditValue = Nothing
        LockVariationResponseFields(True)
    End Sub



    Private Sub btnAddNewVariationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        With My.Forms.MaintainVariations

            .ShowDialog()

            .Dispose()

        End With

        LoadUpVariationResultCombo()

    End Sub

    Private Sub btnAddVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddVariation.Click
        lblID.Text = "0"
        Me.cboVariationType.EditValue = Nothing
        txtVariationDetails.Text = String.Empty
        Me.cboVariationResult.EditValue = Nothing
        Me.cboVariationAuthority.EditValue = Nothing
        Me.variationDecisionDate.EditValue = Nothing
        Me.btnSaveVariation.Enabled = True
        btnAddVariation.Enabled = False

        lockVariationFields(False)
    End Sub

    Private Sub lockVariationFields(ByVal lock As Boolean)
        Me.cboVariationType.ReadOnly = lock
        txtVariationDetails.ReadOnly = lock
        cboOfficerRecomforVariation.ReadOnly = lock
        Me.txtOfficersReasons.ReadOnly = lock
        txtVariationDetails.ReadOnly = lock
        cboOfficerRecomforVariation.ReadOnly = lock
        variationDecisionDate.ReadOnly = lock
        btnSaveVariation.Enabled = Not lock

    End Sub

    Private Sub LockVariationResponseFields(ByVal lock As Boolean)
        Me.cboVariationResult.ReadOnly = lock
        Me.cboVariationAuthority.ReadOnly = lock
        Me.variationDecisionDate.ReadOnly = lock


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
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        If Not cboVariationType.EditValue Is Nothing Then .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboVariationType.EditValue)
                        '.Parameters.Add("@RESULT", SqlDbType.VarChar).Value = Me.cboVariationResult.SelectedValue.ToString
                        '.Parameters.Add("@AUTHORITY", SqlDbType.SmallInt).Value = CInt(Me.cboVariationAuthority.SelectedValue)
                        If Not cboOfficerRecomforVariation.EditValue Is Nothing Then .Parameters.Add("@OFFRRECOMD", SqlDbType.VarChar).Value = Me.cboOfficerRecomforVariation.EditValue.ToString
                        .Parameters.Add("@REASON", SqlDbType.NText).Value = txtOfficersReasons.Text

                        .ExecuteNonQuery()
                    End With

                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try
        End Using

        Try

            LoadVariationGridData(lblapplicationNo.Text)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        btnSaveVariation.Enabled = False
        btnEditVariation.Enabled = True
        btnAddVariation.Enabled = True
        lblID.Text = "0"

        Me.cboVariationType.EditValue = Nothing
        txtVariationDetails.Text = String.Empty
        Me.cboVariationResult.EditValue = Nothing
        Me.cboVariationAuthority.EditValue = Nothing
        cboOfficerRecomforVariation.EditValue = Nothing
        txtOfficersReasons.Text = String.Empty
        Me.variationDecisionDate.EditValue = Nothing
        lockVariationFields(True)


    End Sub

    Private Sub btnEditVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditVariation.Click
        lockVariationFields(False)
        btnEditVariation.Enabled = False
    End Sub

    Private Sub LoadVariationGridData(ByVal DANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationGridData routine - form " & Me.Name)

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


                    grdVariations.DataSource = objDT
                    'dgvSales.Refresh()

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationGridData routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadVariationGrid(ByVal DANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                    grdConclusionVariations.DataSource = objDT



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationGrid routine - form " & Me.Name)

            End Try
        End Using


    End Sub


#End Region

#Region "Conclusions"


    Private Sub loadOneUpConditions(ByVal dgv As DevExpress.XtraGrid.GridControl)

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

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub



    Private Sub btnViewReco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewReco.Click
        With ViewComments
            .CommentText = ApplicationConclreasonsTextBox.Text
            .ShowDialog()
            ApplicationConclreasonsTextBox.Text = .CommentText
            .Dispose()
        End With
    End Sub

    Private Sub LoadUpConclusionConditions(ByVal dgv As DevExpress.XtraGrid.GridControl)

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

                    With cboAssessmentDecision.Properties
                        .DataSource = objDT
                        .DisplayMember = "RecoResultDesc"
                        .ValueMember = "RecommendedResult"
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboAssessmentDecision.Properties.Columns
                    col2.Add(New LookUpColumnInfo("RecoResultDesc", 0))
                    col2.Add(New LookUpColumnInfo("RecommendedResult", 0))

                    col2.Item(1).Visible = False


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadConclusionRecomendation routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadAuthorityCombo(ByVal combo As LookUpEdit)

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

                    With combo.Properties
                        .DataSource = objDT
                        .DisplayMember = "Description"
                        .ValueMember = "id"

                    End With


                    Dim col2 As LookUpColumnInfoCollection = combo.Properties.Columns
                    col2.Add(New LookUpColumnInfo("Description", 0))
                    col2.Add(New LookUpColumnInfo("id", 0))

                    col2.Item(1).Visible = False



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAuthorityCombo routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Sub LoadGenericAnswersToQuestions(ByVal combo As LookUpEdit)

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

                    With combo.Properties
                        .DataSource = objDT
                        .DisplayMember = "ResultCodeDesc"
                        .ValueMember = "ResultCode"
                    End With

                    Dim col2 As LookUpColumnInfoCollection = combo.Properties.Columns
                    col2.Add(New LookUpColumnInfo("ResultCodeDesc", 0))
                    col2.Add(New LookUpColumnInfo("ResultCode", 0))

                    col2.Item(1).Visible = False


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadGenericAnswersToQuestions routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnViewConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewConclusion.Click
        With ViewComments

            .Islocked = _AssessmentLocked

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

        If Not OKtoProceed Then

            'MessageBox.Show("Unable to update check with Bob is a modification =" & modification.ToString, "ERROR STATE", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return

        End If

        If MessageBox.Show("Update the conclusion?", "Complete Conclusion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        If cboReferralsYesNo.EditValue IsNot Nothing Then .Parameters.Add("@ReferralsYesNo", SqlDbType.NVarChar).Value = Me.cboReferralsYesNo.EditValue.ToString
                        If cboComplianceStatProvYesNo.EditValue IsNot Nothing Then .Parameters.Add("@ComplianceStatProvYesNo", SqlDbType.NVarChar).Value = Me.cboComplianceStatProvYesNo.EditValue.ToString
                        .Parameters.Add("@ComplianceStatProvComments", SqlDbType.NText).Value = Me.ComplianceStatProvCommentsTextBox.Text
                        If cboVariationsYesNo.EditValue IsNot Nothing Then .Parameters.Add("@VariationsYesNo", SqlDbType.NVarChar).Value = Me.cboVariationsYesNo.EditValue.ToString
                        .Parameters.Add("@VariationsComment", SqlDbType.NText).Value = txtVariationComment.Text

                        If cboApplicationConclResult.EditValue IsNot Nothing Then .Parameters.Add("@ApplicationConclResult", SqlDbType.NVarChar).Value = Me.cboApplicationConclResult.EditValue.ToString

                        .Parameters.Add("@ApplicationConclreasons", SqlDbType.NText)
                        .Parameters.Add("@AssessmentDecision", SqlDbType.NVarChar)
                        .Parameters.Add("@AuthorityCode", SqlDbType.NVarChar)
                        .Parameters.Add("@PropDetermDate", SqlDbType.SmallDateTime)

                        If modification Then
                            .Parameters("@ApplicationConclreasons").Value = Me.ApplicationConclreasonsTextBox.Text
                            If cboModAssessmentDecision.EditValue IsNot Nothing Then .Parameters("@AssessmentDecision").Value = Me.cboModAssessmentDecision.EditValue.ToString
                            If cboModAuthority.EditValue IsNot Nothing Then .Parameters("@AuthorityCode").Value = Me.cboModAuthority.EditValue.ToString
                            .Parameters("@PropDetermDate").Value = CDate(dteProposedDetermDate.EditValue)
                        Else
                            .Parameters("@ApplicationConclreasons").Value = Me.txtApplicationConclreasons.Text
                            If cboAssessmentDecision.EditValue IsNot Nothing Then .Parameters("@AssessmentDecision").Value = Me.cboAssessmentDecision.EditValue.ToString
                            If cboAuthority.EditValue IsNot Nothing Then .Parameters("@AuthorityCode").Value = Me.cboAuthority.EditValue.ToString
                            .Parameters("@PropDetermDate").Value = CDate(dteConclusionDate.EditValue)
                        End If


                        If cboModSec96Comply.EditValue IsNot Nothing Then .Parameters.Add("@Modsec96ComplyYN", SqlDbType.NVarChar).Value = Me.cboModSec96Comply.EditValue.ToString
                        If cboModSec79Satisfactory.EditValue IsNot Nothing Then .Parameters.Add("@Modsec79SatisYN", SqlDbType.NVarChar).Value = Me.cboModSec79Satisfactory.EditValue.ToString

                        .Parameters.Add("@Conflict", SqlDbType.VarChar).Value = lupConflict.EditValue.ToString


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

        If dteProposedDetermDate.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.dteProposedDetermDate, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.dteProposedDetermDate, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.dteProposedDetermDate, "")

        End If

        If Me.cboModSec96Comply.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModSec96Comply, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboModSec96Comply, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboModSec96Comply, "")

        End If
        If Me.cboModSec79Satisfactory.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModSec79Satisfactory, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboModSec79Satisfactory, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboModSec79Satisfactory, "")

        End If
        If Me.cboModAssessmentDecision.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModAssessmentDecision, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboModAssessmentDecision, "This is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboModAssessmentDecision, "")

        End If

        If Me.cboModAuthority.EditValue Is Nothing Then
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



        If lupConflict.Text="" Then
            With ErrorProvider
                .SetIconAlignment(lupConflict, ErrorIconAlignment.MiddleRight)
                .SetError(lupConflict, "You MUST select either Yes or No!")
            End With
            result = False
        Else
            ErrorProvider.SetError(lupConflict, "")

        End If



        Return result
    End Function

    Private Function ConclusionChecksOut() As Boolean
        Dim result As Boolean = True

        Dim sbMsg As New SB



        If dteConclusionDate.EditValue Is Nothing Then

            With ErrorProvider
                .SetIconAlignment(Me.dteConclusionDate, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.dteConclusionDate, "This is a required field")
                sbMsg.Append("ConclusionChecksOut Date is required" & vbCrLf)
            End With

            result = False
        Else
            ErrorProvider.SetError(Me.dteConclusionDate, "")

        End If

        If cboReferralsYesNo.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboReferralsYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboReferralsYesNo, "This is a required field")
                sbMsg.Append("Referral is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboReferralsYesNo, "")

        End If

        If cboComplianceStatProvYesNo.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboComplianceStatProvYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboComplianceStatProvYesNo, "This is a required field")
                sbMsg.Append("Compliance stat provided is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboComplianceStatProvYesNo, "")

        End If

        If cboVariationsYesNo.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboVariationsYesNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboVariationsYesNo, "This is a required field")
                sbMsg.Append("Variation is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboVariationsYesNo, "")

        End If

        If cboApplicationConclResult.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboApplicationConclResult, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboApplicationConclResult, "This is a required field")
                sbMsg.Append("Summary conclusion is required" & vbCrLf)
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboApplicationConclResult, "")

        End If

        If cboAuthority.EditValue Is Nothing Then
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

        If lupConflict.Text = "" Then
            With ErrorProvider
                .SetIconAlignment(lupConflict, ErrorIconAlignment.MiddleRight)
                .SetError(lupConflict, "You MUST select either Yes or No!")
                sbMsg.Append("You MUST indicate whether you have a conflict of Interest")
            End With
            result = False
        Else
            ErrorProvider.SetError(lupConflict, "")

        End If





        If sbMsg.ToString <> String.Empty Then

            MessageBox.Show(sbMsg.ToString, "Following Fields need to be completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If







        Return result


    End Function



    Private Sub btnViewComplainceReason_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewComplainceReason.Click
        With ViewComments
            .Islocked = _AssessmentLocked

            .CommentText = ComplianceStatProvCommentsTextBox.Text
            .ShowDialog()
            ComplianceStatProvCommentsTextBox.Text = .CommentText
            .Dispose()
        End With
    End Sub

    Private Sub cboModAssessmentDecision_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModAssessmentDecision.EditValueChanged
        If cboModAssessmentDecision.IsLoading Then Return

        If cboModAssessmentDecision.Text = String.Empty Then Return
        Dim recommendationTwo As String = String.Empty
        Dim decision As String = String.Empty
        If cboModAssessmentDecision.EditValue.ToString = "R" Then
            decision = "remains unchanged for the reasons set out below:"
        ElseIf cboModAssessmentDecision.EditValue.ToString = "A" Then
            decision = "is modified in the manner specified for the reasons set out below:-"
        End If

        recommendationTwo = "and therefore the consent notice dated " & lblDetermineDate.Text & " " & decision

        lblRecommendTwo.Text = recommendationTwo

    End Sub


#End Region 'Conclusions

#Region "Modifications"

    Private Sub btnUpdateModDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateModDetails.Click

        scrolModification.Enabled = True
        pnlMod1.Enabled = True

        LockForm(scrolModification, False)

        pnlMod1andMod2.Enabled = True
        pnlMod2.Enabled = True
        pnlMod1A.Enabled = True
        ModDetailsTextBox.ReadOnly = False
        ModReasonTextBox.ReadOnly = False
        cboModSect96.Enabled = True
        btnUpdateModDetails.Enabled = False
        btnUpdateModData.Enabled = True




    End Sub

    Private Sub cboModSect96_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboModSect96.EditValueChanged


        If cboModSect96.IsLoading Then Return

        If cboModSect96.Text = String.Empty Then Return

        Select Case cboModSect96.EditValue.ToString.ToUpper
            Case "1"
                grpMod.Text = "Section96(1) Assessment"
                scrolModification.Visible = True
                btnUpdateModData.Visible = True
                Me.pnlMod1andMod2.Visible = False
                Me.pnlMod2.Visible = False
                Me.pnlMod1A.Visible = False
                pnlMod1.Visible = False
                Me.pnlMod1.Location = New Point(3, 3)
            Case "1A"
                scrolModification.Visible = True
                btnUpdateModData.Visible = True
                grpMod.Text = "Section96(1A) Assessment"
                Me.pnlMod1andMod2.Visible = True
                Me.pnlMod2.Visible = False
                Me.pnlMod1A.Visible = True
                pnlMod1.Visible = True
                Me.pnlMod1.Location = New Point(8, 400)

            Case "2"
                scrolModification.Visible = True
                btnUpdateModData.Visible = True
                grpMod.Text = "Section96(2) Assessment"
                Me.pnlMod1andMod2.Visible = True
                Me.pnlMod2.Visible = True
                Me.pnlMod1A.Visible = False
                pnlMod1.Visible = True
                Me.pnlMod1.Location = New Point(8, 573)


            Case Else
                grpMod.Text = String.Empty
                btnUpdateModData.Visible = False
                pnlMod1.Visible = True
                scrolModification.Visible = True
        End Select


    End Sub

    Private Sub btnUpdateModData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateModData.Click



        If Me.cboModSect96.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboModSect96, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.cboModSect96, "A response IS required")
            End With
            Exit Sub
        Else
            ErrorProvider.SetError(Me.cboModSect96, "")

        End If

        'scrolModification.Enabled = False
        'pnlMod1.Enabled = False
        'pnlMod1andMod2.Enabled = False
        'pnlMod2.Enabled = False
        'pnlMod1A.Enabled = False
        ModDetailsTextBox.ReadOnly = True
        ModReasonTextBox.ReadOnly = True
        cboModSect96.Enabled = False
        btnUpdateModData.Enabled = False
        btnUpdateModDetails.Enabled = True
        LockForm(scrolModification, True)

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@MODSECT96", SqlDbType.NVarChar).Value = Me.cboModSect96.EditValue.ToString
                        If Not ModMinEnvImpactYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModMinEnvImpactYN", SqlDbType.NVarChar).Value = Me.ModMinEnvImpactYNComboBox.EditValue.ToString
                        .Parameters.Add("@ModMinEnvImpComment", SqlDbType.NText).Value = Me.ModMinEnvImpCommentTextBox.Text
                        If Not ModSubstSameYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModSubstSameYN", SqlDbType.NVarChar).Value = Me.ModSubstSameYNComboBox.EditValue.ToString
                        .Parameters.Add("@SubStSameComment", SqlDbType.NText).Value = Me.ModSubStSameCommentTextBox.Text
                        If Not ModNotificationYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModNotificationYN", SqlDbType.NVarChar).Value = Me.ModNotificationYNComboBox.EditValue.ToString
                        If Not ModSubmConsYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModSubmConsYN", SqlDbType.NVarChar).Value = Me.ModSubmConsYNComboBox.EditValue.ToString
                        If Not ModConsMinisterYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModConsMinisterYN", SqlDbType.NVarChar).Value = Me.ModConsMinisterYNComboBox.EditValue.ToString
                        If Not ModMinisterOBjYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModMinisterOBjYN", SqlDbType.NVarChar).Value = Me.ModMinisterOBjYNComboBox.EditValue.ToString
                        .Parameters.Add("@ModMinisterComment", SqlDbType.NText).Value = Me.ModMinisterCommentTextBox.Text
                        If Not ModThreatSpecYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModThreatSpecYN", SqlDbType.NVarChar).Value = Me.ModThreatSpecYNComboBox.EditValue.ToString
                        If Not ModThreatComplYNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModThreatComplYN", SqlDbType.NVarChar).Value = Me.ModThreatComplYNComboBox.EditValue.ToString
                        .Parameters.Add("@ModThreatComment", SqlDbType.NText).Value = Me.ModThreatCommentTextBox.Text
                        If Not Modsect79cYNComboBox.EditValue Is Nothing Then .Parameters.Add("@Modsect79cYN", SqlDbType.NVarChar).Value = Me.Modsect79cYNComboBox.EditValue.ToString
                        .Parameters.Add("@ModSect79cComment", SqlDbType.NText).Value = Me.ModSect79cCommentTextBox.Text
                        If Not ModSect94YNComboBox.EditValue Is Nothing Then .Parameters.Add("@ModSect94YN", SqlDbType.NVarChar).Value = Me.ModSect94YNComboBox.EditValue.ToString
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


    Private Sub btnRemove64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove64.Click

        If MessageBox.Show("Are you sure you want to remove this contribution?", "Remove Contribution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Dim myobj As DataRowView = CType(gvwSection64Contributions.GetFocusedRow, DataRowView)


        RemoveContribution(CInt(myobj.Row.Item("S94ID")))

    End Sub

    Private Sub RemoveContribution(ByVal CodeId As Integer)

        Using cn As New SqlConnection(My.Settings.connectionString)
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

        Dim myobj As DataRowView = CType(gvwSection94.GetFocusedRow, DataRowView)


        RemoveContribution(CInt(myobj.Row.Item("S94ID")))

    End Sub

    Private Sub btnRemoveBond_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveBond.Click
        If MessageBox.Show("Are you sure you want to remove this contribution?", "Remove Contribution", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim myobj As DataRowView = CType(gvwProposedBondContrib.GetFocusedRow, DataRowView)


        RemoveContribution(CInt(myobj.Row.Item("S94ID")))

    End Sub

    'Private Sub btnInsertIntoLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertIntoLive.Click

    '    If MessageBox.Show("You are about to copy all the proposed contribution records for this DA and add them to the 'Live' Section 94 Register!  OK to proceed?", "Update the Contributions Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub






    '    Using cn As New SqlConnection(My.Settings.connectionString)
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

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@CODE", SqlDbType.NVarChar).Value = Me.cboSection64Type.EditValue.ToString
                        .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(Me.txt64Amount.Text)
                        .Parameters.Add("@NOTE", SqlDbType.NVarChar).Value = Me.txt64Note.Text
                        If cboS64Type.Text <> String.Empty Then .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboS64Type.EditValue)
                        If cboContribType.Text <> String.Empty Then .Parameters.Add("@CATEORY", SqlDbType.Int).Value = CInt(cboContribType.EditValue)
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

        If cboSection64Type.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSection64Type, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSection64Type, "A plan type is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSection64Type, "")

        End If

        If cboS64Type.EditValue Is Nothing Then
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
        If cboContribType.EditValue Is Nothing Then
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

                    With cboSection64Type.Properties
                        .DataSource = objDT
                        .DisplayMember = "s94PLAN"
                        .ValueMember = "s94Code"
                    End With


                    Dim col2 As LookUpColumnInfoCollection = cboSection64Type.Properties.Columns
                    col2.Add(New LookUpColumnInfo("s94PLAN", 0))
                    col2.Add(New LookUpColumnInfo("s94Code", 0))

                    col2.Item(1).Visible = False


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


                    With cboS64Type.Properties
                        .DataSource = objDT
                        .DisplayMember = "S94Type"
                        .ValueMember = "S94TypeId"
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboS64Type.Properties.Columns
                    col2.Add(New LookUpColumnInfo("S94Type", 0))
                    col2.Add(New LookUpColumnInfo("S94TypeId", 0))

                    col2.Item(1).Visible = False

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

                    grdSection64Contributions.DataSource = objDT

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

                    grdSection94.DataSource = objDT
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

                    grdProposedBondContrib.DataSource = objDT

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

                    grdHistoricalDA.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using






    End Sub

    Private Sub ShowHistoricalComments(ByVal PreviousDAno As String)

        cboActedOn.EditValue = Nothing
        CommentTextBox.Text = String.Empty

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

                        If Not IsDBNull(objDataRow.Item("ActedOn")) Then cboActedOn.EditValue = objDataRow.Item("ActedOn").ToString
                        CommentTextBox.Text = objDataRow.Item("Comment").ToString
                        'DevHistoryCommentTextBox.Text = objDataRow.Item("DevHistoryComment").ToString

                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in ShowHistoricalComments routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private Sub btnRetrievePreviousDAHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrievePreviousDAHistory.Click
        If MessageBox.Show("You are about to insert Development History, Ok to proceed?", "Insert DA History", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
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




        Dim myobj As DataRowView = CType(gvwHistoricalDA.GetFocusedRow, DataRowView)



        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@PREVDANO", SqlDbType.NVarChar).Value = myobj.Row.Item("PrevDANo")
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = lblapplicationNo.Text
                        .Parameters.Add("@ACTED", SqlDbType.NVarChar).Value = cboActedOn.EditValue.ToString
                        .Parameters.Add("@COMMENT", SqlDbType.NText).Value = CommentTextBox.Text
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDevHistComment_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadHistoricalGrid()

    End Sub

    Private Sub btnSaveDevHistComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDevHistComment.Click


        If MessageBox.Show("Update comment now?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
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

        Using cn As New SqlConnection(My.Settings.connectionString)
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

    Private Sub btnSepp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSepp.Click
        With My.Forms.StatutorySEPP
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnGuidLines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuidLines.Click
        With My.Forms.StatutoryGuidelines
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnDCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCP.Click
        With My.Forms.StatutoryDCP
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnDams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDams.Click

        With My.Forms.StatutoryDAMS
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub


    Private Sub btnLEP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLEP.Click

        With My.Forms.StatutoryLEP
            .Islocked = _AssessmentLocked
            .AssessmentNo = lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnREP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREP.Click
        With My.Forms.StatutoryREP
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub
    Private Sub btnDCPCheckList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDCPCheckList.Click
        With My.Forms.StatutoryDCPCheckList
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()

    End Sub

    Private Sub btnGenImpacts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenImpacts.Click


        With My.Forms.GeneralImpacts
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnDepositedPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositedPlan.Click

        With My.Forms.DepositedPlanAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnThreatenSpecies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThreatenSpecies.Click

        With My.Forms.ThreatenSpeciesAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnTraficCarParks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraficCarParks.Click

        With My.Forms.TrafficAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSocialEconomic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSocialEconomic.Click

        With My.Forms.SocialEconomicImpactsAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnDisabDiscrimAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisabDiscrimAct.Click

        With My.Forms.DiabilityDiscriminationActAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnHeritage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeritage.Click

        With My.Forms.HeritageAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnLandscaping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLandscaping.Click

        With My.Forms.LandscapingAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSustainability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSustainability.Click
        With My.Forms.SustainabilityAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub btnSubdivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubdivision.Click
        With My.Forms.SubdivisionAssessment
            .Islocked = _AssessmentLocked
            .AssessmentNo = Me.lblapplicationNo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
        DisplayChecks()
    End Sub

    Private Sub DisplayChecks()


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

    Private Sub RetrieveAssociatesList(ByVal ApplicationNo As Integer)



    End Sub

    Private Sub btnFinaliseDoc_Click(sender As System.Object, e As System.EventArgs) Handles btnFinaliseDoc.Click




        If MessageBox.Show("You are about to finalise this document into EASE. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        Dim summary As String = "Application No. " & lblapplicationNo.Text & " Document Type: Assessment report"





        With My.Forms.InsertAssessmentIntoEASE



            .CustName = My.Forms.DevelopmentStart.txtAppName.Text
            .CustAddress = My.Forms.DevelopmentStart.txtAppAddress.Text & " " & My.Forms.DevelopmentStart.txtAppTown.Text & " " & My.Forms.DevelopmentStart.txtAppPcode.Text


            .WordDocLocation = lblAssessmentreport.Text
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = My.Forms.DevelopmentStart.txtFileNo.Text
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

    Private Sub btnPrintAssessment_Click(sender As Object, e As EventArgs) Handles btnPrintAssessment.Click

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

    Private Sub gvwVariations_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwVariations.RowClick

        lblID.Text = String.Empty
        cboVariationType.EditValue = Nothing
        txtVariationDetails.Text = String.Empty
        Me.cboVariationResult.EditValue = Nothing
        Me.cboVariationAuthority.EditValue = Nothing
        Me.variationDecisionDate.EditValue = Nothing
        cboOfficerRecomforVariation.EditValue = Nothing
        txtOfficersReasons.Text = String.Empty

        Dim myobj As DataRowView = CType(gvwVariations.GetFocusedRow, DataRowView)


        Dim objDT As New DataTable

        'objDT = GetVariationRecord(CInt(myobj.Row.Item("id")))


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetVariationRecord routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_VariationRecordByID"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("id"))
                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetVariationRecord routine - form " & Me.Name)

            End Try
        End Using


        If objDT.Rows.Count > 0 Then

            Dim objDataRow As DataRow = objDT.Rows.Item(0)


            lblID.Text = objDataRow.Item("id").ToString
            cboVariationType.EditValue = CInt(objDataRow.Item("type"))
            txtVariationDetails.Text = objDataRow.Item("detail").ToString
            cboVariationResult.EditValue = objDataRow.Item("VariationResultDesc").ToString
            cboVariationAuthority.EditValue = objDataRow.Item("DelegatedAuthority").ToString
            If Not IsDBNull(objDataRow.Item("DecisionDate")) Then variationDecisionDate.EditValue = CDate(objDataRow.Item("DecisionDate"))
            cboOfficerRecomforVariation.EditValue = objDataRow.Item("result").ToString
            txtOfficersReasons.Text = objDataRow.Item("AssReasons").ToString



        End If

        lockVariationFields(True)
        LockVariationResponseFields(True)

        btnSaveVariation.Enabled = False
        btnSaveVariationResponse.Enabled = False
        btnEditVariation.Enabled = Not _AssessmentLocked
        btnAddVariation.Enabled = Not _AssessmentLocked
        btneditVariationResponse.Enabled = Not _AssessmentLocked
        btnRemoveVariation.Enabled = Not _AssessmentLocked

    End Sub

    Private Sub InsertPlanLocationIntoTable(FileName As String)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertPlanLocationIntoTable routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_ApplicationPlan"

                        .Parameters.Add("@DANo", SqlDbType.VarChar).Value = lblapplicationNo.Text
                        .Parameters.Add("@PlanName", SqlDbType.VarChar).Value = FileName

                        .ExecuteNonQuery()

                    End With




                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertPlanLocationIntoTable routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Function DisplayPDFdocument() As String

        Dim myobj As DataRowView = CType(gvwPlans.GetFocusedRow, DataRowView)


        Dim sDocname As String = myobj.Row.Item("DocId").ToString.Replace(".", "_")
        Dim sPDFDoc As String = String.Empty


        If CType(BuildYear(sDocname).Substring(0, 4), Int32) <> Today.Date.Year Then

            sPDFDoc = My.Settings.ARCHIVE & BuildYear(sDocname) & FolderHash(sDocname) & ImagePDFFileName(sDocname)

        Else

            sPDFDoc = My.Settings.HASHBIN & BuildYear(sDocname) & FolderHash(sDocname) & ImagePDFFileName(sDocname)

        End If


        Return sPDFDoc

    End Function

    Public Function ImagePDFFileName(ByVal sDocumentNumber As String) As String
        ImagePDFFileName = "\" & sDocumentNumber & ".pdf"
    End Function


    Private Sub MovePlanToStorageLocation(DocumentToMOve As String)

        My.Computer.FileSystem.MoveFile(DocumentToMOve, My.Settings.PlanLocation & My.Computer.FileSystem.GetName(DocumentToMOve), True)

    End Sub

    Private Sub UpdatePlanTableToIndicateEASED(PlanIndex As Integer, Document As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdatePlanTableToIndicateEASED routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_ApplicationPlan"

                        .Parameters.Add("@INDEXID", SqlDbType.Int).Value = PlanIndex
                        .Parameters.Add("@DOCUMENTNO", SqlDbType.VarChar).Value = Document

                        .ExecuteNonQuery()


                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdatePlanTableToIndicateEASED routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub gvwHistoricalDA_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwHistoricalDA.RowClick

        Try



            Dim myobj As DataRowView = CType(gvwHistoricalDA.GetFocusedRow, DataRowView)



            ShowHistoricalComments(myobj.Row.Item("PrevDANo"))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.btnViewDa.Enabled = True

        Me.btnUpDateHistory.Enabled = True


    End Sub

    Private Sub gvwSection64Contributions_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwSection64Contributions.RowClick

        Me.btnRemove64.Enabled = True

    End Sub

    Private Sub gvwSection94_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwSection94.RowClick

        Me.btnRemove94.Enabled = True

    End Sub

    Private Sub gvwProposedBondContrib_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwProposedBondContrib.RowClick

        Me.btnRemoveBond.Enabled = True

    End Sub

    Private Sub btnRemoveVariation_Click(sender As Object, e As EventArgs) Handles btnRemoveVariation.Click

        If MessageBox.Show("Remove variation?", "REMOVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Dim myobj As DataRowView = CType(gvwVariations.GetFocusedRow, DataRowView)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetVariationRecord routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_VariationRecordByID"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("id"))
                        .ExecuteNonQuery()



                    End With



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetVariationRecord routine - form " & Me.Name)

            End Try
        End Using

        LoadVariationGridData(lblapplicationNo.Text)

        lblID.Text = String.Empty
        cboVariationType.EditValue = Nothing
        txtVariationDetails.Text = String.Empty
        Me.cboVariationResult.EditValue = Nothing
        Me.cboVariationAuthority.EditValue = Nothing
        Me.variationDecisionDate.EditValue = Nothing
        cboOfficerRecomforVariation.EditValue = Nothing
        txtOfficersReasons.Text = String.Empty

        btnRemoveVariation.Enabled = False

    End Sub



    Private Sub btnLockAssessment_Click(sender As Object, e As EventArgs) Handles btnLockAssessment.Click


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnLockAssessment_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_LockAssessment"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANumber

                        .ExecuteNonQuery()

                        _AssessmentLocked = True

                    End With


                End Using

                btnLockAssessment.Visible = Not _AssessmentLocked

                btnEditVariation.Enabled = Not _AssessmentLocked
                btnAddVariation.Enabled = Not _AssessmentLocked
                btneditVariationResponse.Enabled = Not _AssessmentLocked
                btnRemoveVariation.Enabled = Not _AssessmentLocked
                btnUpdateModDetails.Enabled = Not _AssessmentLocked

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnLockAssessment_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub btnAddPlan_Click(sender As Object, e As EventArgs) Handles btnFindPlan.Click

        Dim sfilename As String = String.Empty


        Dim openfileDialog1 As New OpenFileDialog

        With openfileDialog1
            .FileName = String.Empty
            .Filter = "(Acrobat *.pdf)|*.PDF"
            .DefaultExt = "*.pdf"
        End With

        If openfileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then


            sfilename = openfileDialog1.FileName()


            If sfilename = String.Empty Then Return 'nothing to do


            If sfilename <> String.Empty Then



                _PDFDocumentLocation = sfilename

                With PdfViewer
                    .ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel
                    .LoadDocument(_PDFDocumentLocation)
                End With

                btnSavePlan.Enabled = True

            End If


        Else

            sfilename = String.Empty
            btnSavePlan.Enabled = False

        End If


    End Sub

    Private Sub btnSavePlan_Click(sender As Object, e As EventArgs) Handles btnSavePlan.Click

        Dim sPathname As String = String.Empty

        sPathname = fso.Path.GetDirectoryName(_PDFDocumentLocation) & "\"

        My.Computer.FileSystem.GetName(_PDFDocumentLocation)

        InsertPlanLocationIntoTable(My.Computer.FileSystem.GetName(_PDFDocumentLocation))

        PdfViewer.CloseDocument()

        MovePlanToStorageLocation(_PDFDocumentLocation)

        LoadPlansToView()

    End Sub

    Private Sub gvwPlans_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwPlans.RowClick

        Dim myobj As DataRowView = CType(gvwPlans.GetFocusedRow, DataRowView)

        Dim PDFDocumentName As String = myobj.Row.Item("PlanName").ToString
        Dim EASEed As Boolean = CBool(myobj.Row.Item("InEASE"))

        With PdfViewer
            .ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel

            If EASEed Then

                .LoadDocument(DisplayPDFdocument)

                btnFinalisePlan.Enabled = False

            Else
                .LoadDocument(My.Settings.PlanLocation & PDFDocumentName)

                btnFinalisePlan.Enabled = True


            End If
        End With

        btnPDF.Enabled = True



    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click

        Dim myobj As DataRowView = CType(gvwPlans.GetFocusedRow, DataRowView)

        Dim PDFDocumentName As String = myobj.Row.Item("PlanName").ToString
        Dim EASEed As Boolean = CBool(myobj.Row.Item("InEASE"))

        Dim WRD As New OpenDocument

        If EASEed Then

            WRD.OpenVisible(DisplayPDFdocument)

        Else

            WRD.OpenVisible(My.Settings.PlanLocation & PDFDocumentName)

        End If




    End Sub

    Private Sub btnFinalisePlan_Click(sender As Object, e As EventArgs) Handles btnFinalisePlan.Click



        If MessageBox.Show("You are about to finalise this plan into EASE. OK to proceed?", "Finalise Plan?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim myobj As DataRowView = CType(gvwPlans.GetFocusedRow, DataRowView)

        Dim PDFDocumentName As String = myobj.Row.Item("PlanName").ToString
        Dim PlanIndex As Integer = CType(myobj.Row.Item("PlanIDX"), Integer)

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        Dim summary As String = "Application No. " & lblapplicationNo.Text & " Document Type: " & IO.Path.GetFileNameWithoutExtension(PDFDocumentName) ' Application Plan"




        PdfViewer.CloseDocument()

        With My.Forms.InsertAssessmentIntoEASE



            .CustName = My.Forms.DevelopmentStart.txtAppName.Text
            .CustAddress = My.Forms.DevelopmentStart.txtAppAddress.Text & " " & My.Forms.DevelopmentStart.txtAppTown.Text & " " & My.Forms.DevelopmentStart.txtAppPcode.Text


            .WordDocLocation = My.Settings.PlanLocation & PDFDocumentName
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = My.Forms.DevelopmentStart.txtFileNo.Text
            .ShowDialog()
            .Dispose()

        End With


        UpdatePlanTableToIndicateEASED(PlanIndex, sDocumentNo)


        LoadPlansToView()



    End Sub

    Private Sub lupConflict_EditValueChanged(sender As Object, e As EventArgs) Handles lupConflict.EditValueChanged

    End Sub
End Class