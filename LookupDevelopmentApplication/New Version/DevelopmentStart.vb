Imports System.Data.SqlClient
Imports WORD = Microsoft.Office.Interop.Word

Imports System.IO

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared

Imports COMP = Compliance.ComplianceApp
Imports ADDINFO = ClassAdditionalInformation.AdditionalInfo
Imports System.Drawing.Printing

Imports ADHelpr = ADHelper.ADHelper
Imports System.Runtime.InteropServices
Imports System.Text
Imports VIDEO = AttachVideosToApplication.VideoCapture
Imports System.Deployment.Application
Imports DevExpress.XtraEditors

Public Class DevelopmentStart

    Dim tempFolder As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\"

    Dim cmdArg As String = String.Empty



    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)>
    Public Shared Function OpenClipboard(ByVal hWndNewOwner As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)>
    Public Shared Function CloseClipboard() As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)>
    Public Shared Function GetClipboardData(ByVal format As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)>
    Public Shared Function IsClipboardFormatAvailable(ByVal format As UInteger) As Boolean
    End Function

    Public Const CF_METAFILEPICT As UInteger = 3
    Public Const CF_ENHMETAFILE As UInteger = 14

    Private Sub PasteFromClipboard(ByVal pictureBox As PictureBox)
        If OpenClipboard(Handle) Then
            If IsClipboardFormatAvailable(CF_ENHMETAFILE) Then
                Dim ptr As IntPtr = GetClipboardData(CF_ENHMETAFILE)
                If Not ptr.Equals(New IntPtr(0)) Then
                    Dim metafile As New Imaging.Metafile(ptr, True)
                    'Set the Image Property of PictureBox
                    pictureBox.Image = metafile
                End If
            End If
            CloseClipboard()
        End If
    End Sub

#Region "Properties"
    Private bTrayIsLoaded As Boolean
    Public WriteOnly Property SetPageBoolean() As Boolean
        Set(ByVal value As Boolean)
            bTrayIsLoaded = value
        End Set
    End Property

    Public WriteOnly Property DisplayMyDA() As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                PopulateForm(value)
            End If
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

    Private Const PHOTO As Integer = 0


    Private bSearch As Boolean = False
    Private isloading As Boolean
    Private LoadingForm As Boolean
    Private AddingNew As Boolean
    Private imgCurrentNavImage As Image
    Private objDS As New DataSet
    Private isEditingOrder As Boolean = False
    Private _RoadNumber As Integer

    Private mydocuments As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\records"


    Private bSaveChanges As Boolean = True


    Private EditMode As Boolean

    Private mdl_GroupImageID As Integer
    Private _VideoGroupId As Integer

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


    Private Sub ApplicationforApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Settings.DataConnection = "Data Source=Development\dev;Initial Catalog=DevelopmentSQL;Integrated Security=True" Then
            MessageBox.Show("WARNING THIS IS TEST DATA DO NOT PROCEED,  RING BOB OR STEPHEN NOW!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


        LoadComboBoxs()


        cboSTDconditions.Visible = False

        If My.Settings.FirstTray <> "" Then
            bTrayIsLoaded = True

            Dim prtdoc2 As New PrintDocument
            Dim strDefaultPrinter As String = String.Empty
            Dim bPrinterFound As Boolean = False

            strDefaultPrinter = My.Settings.DefaultPrinter
            For Each strPrinter As String In PrinterSettings.InstalledPrinters
                If strPrinter = strDefaultPrinter Then
                    bPrinterFound = True
                End If
            Next

            If Not bPrinterFound Then
                My.Settings.DefaultPrinter = prtdoc2.PrinterSettings.PrinterName
            End If

        Else

            'If Not bTrayIsLoaded Then
            With PageSetup
                .ShowDialog()
                bTrayIsLoaded = .PageHasbeenSet
                .Dispose()
            End With

            'End If

        End If
        FindUserInfor()

        LoadLetterTypeCombo()

        btnAddDA.Enabled = Administration

        If ViewOnly Then
            LockAccessIfViewOnly(Me)
            Me.menuAssessmentApplication.Enabled = False

        End If


        Dim args As String() = Nothing
        If ApplicationDeployment.IsNetworkDeployed Then
            Dim inputArgs = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData
            If Not (inputArgs Is Nothing) AndAlso inputArgs.Length > 0 Then
                args = inputArgs(0).Split(New Char() {","c})
            End If
        Else
            args = Environment.GetCommandLineArgs
        End If

        If Not IsNothing(args) Then

            cmdArg = args(0).ToString.Replace("-", "/")

        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ESC\DA\", "ExecLocation", Application.ExecutablePath)


    End Sub

    Private Sub LoadComboBoxs()

        isloading = True

        LoadCombo(Me.cboNoteType, "usp_LoadUpFileNoteTypeList")
        LoadCombo(Me.cboRefCodeId, "usp_LoadUpReferralCodeList")
        LoadCombo(Me.cboReferralsIntProvision, "usp_LoadUpIntegratedProvisionList")
        LoadCombo(Me.cboAppType, "usp_LoadUpDATypeList")
        LoadCombo(Me.cboOtherDocs, "usp_LoadUp_DocType_WordTemplateList")
        LoadListOfOtherWordTemplates("O")
        LoadCombo(Me.cboDADecisionId, "usp_LoadUpDADecisionList")
        LoadCombo(Me.cboNotesOfficer, "usp_LoadUpOfficerList")
        LoadCombo(Me.cboNoteType, "usp_LoadUpFileNoteTypeList")
        LoadCombo(Me.cboDAAuthorityId, "usp_LoadUpDAAuthorityList")

        ''LoadCombo(Me.cboDevType, "usp_LoadUpDevTypeList")
        loadDevelopmentTypeCombo()


        LoadCombo(Me.cboDAtype1, "usp_LoadUpDevTypeList")
        LoadCombo(Me.cboDAType2, "usp_LoadUpDevTypeList")
        LoadCombo(Me.cboDAtype3, "usp_LoadUpDevTypeList")
        LoadLetterTypeCombo()
        LoadCombo(Me.cboDevUse, "usp_LoadUpDevUseList")
        ''LoadCombo(Me.cboIntDevActs , "usp_LoadUpIntegratedDevelopmentActList")
        LoadCombo(Me.cboDAlocalityCode, "usp_LoadUpLocalityCodesList")
        ''LoadCombo(cboAssessmentType, "usp_LoadUpDADefaultConditionsList")
        LoadCombo(cboAssessmentType, "usp_SELECT_StandardCondition")
        LoadCombo(Me.cboDACensusCode, "[usp_LoadUpCensusCodeList]")
        LoadCombo(Me.cboConsentType, "usp_LoadUpConsentTypeList")

        LoadListOfWordTemplates() '<<<++++======

        LoadCombo(Me.cboBuildingType, "usp_SELECT_LoadABSBuildingTypeList")


        LoadCombo(Me.cboDAClass, "usp_LoadUpDAClassComboList")

        LoadCombo(Me.cboDAClass1, "usp_LoadUpDAClassComboList")
        LoadCombo(Me.cboDAClass2, "usp_LoadUpDAClassComboList")
        LoadCombo(Me.cboDAClass3, "usp_LoadUpDAClassComboList")

        LoadCombo(cboVariationType, "usp_LoadUpVariationList")
        LoadCombo(cboSubmissionType, "usp_LoadUpVariationList")

        LoadCombo(cboVariationResult, "usp_LoadUpVariationResultList")
        LoadCombo(cboVariationAuthority, "usp_LoadUpDelegatedAuthorityList")

        LoadCombo(cboReasonOver40, "usp_LoadUp_REASON_DA_APPL_40DAYSList")
        LoadCombo(cboProgressCode, "usp_LoadUp_ProgressCodeList")



        LoadSearchCombo()


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


        Dim SectorOwnerShip As New ArrayList

        ' Add division structure entries to the arraylist
        With SectorOwnerShip
            .Add(New AreaType("Private", "1"))
            .Add(New AreaType("Government", "2"))
        End With

        With cboSector
            .DataSource = SectorOwnerShip
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .SelectedIndex = 0
        End With

        Dim CouncilDepot As New ArrayList

        ' Add division structure entries to the arraylist
        With CouncilDepot
            .Add(New Depots("", ""))
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




        isloading = False



    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

#End Region

#Region "Combo Box Load"

    Private Sub LoadListOfOtherWordTemplates(ByVal SystemID As String)



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
                        .CommandText = "usp_LoadUpda_DocType_WordTemplateList"
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "O"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboOtherDocs
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

    Private Sub LoadListOfWordTemplates()



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
                        .CommandText = "usp_LoadUpda_DocType_WordTemplateList"
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "D"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboConsentDocType
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

    Private Sub LoadCombo(ByVal cbo As Windows.Forms.ComboBox, ByVal SPROC As String)

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

    Private Sub LoadSearchCombo()

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
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT  DevTypeId, DevType FROM DevType"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboSearch
                        .DataSource = objDT
                        .DisplayMember = "DevType"
                        .ValueMember = "DevTypeId"
                        .SelectedIndex = -1
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using



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

    Private Function SendEmailAdvice() As Boolean
        Dim result As Boolean = True
        'Dim mailaddress As String = ADHelper.GetEmailAddress(ADHelper.GetLoginName)

        Dim Subject As String = "**Submission received for DA No: " & Me.txtDANo.Text & "**"
        Dim Body As String = "A submission has been received from " & txtAuthorName.Text & " for DA " & txtDANo.Text & " File No: " &
                              txtFileNo.Text & vbCrLf & " for " & txtStreetNo.Text & " " & Me.txtStreetName.Text & " " &
                              cboDAlocalityCode.Text & vbCrLf & vbCrLf & " For your information."

        Dim emailaddress As String = GetEmailAddress()
        If emailaddress = "None" Then
            MessageBox.Show("This Responsible Officer has no e-mail address - email NOT sent!", "Unable to send response", MessageBoxButtons.OK, MessageBoxIcon.Information)
            result = False
            Exit Function
        End If



        Try
            'MAIL.SendMailMessage(mailaddress, emailaddress, "", "", Subject, Body, "")


            Dim OutlookHlp As New OutlookHelper

            OutlookHlp.SendMail(emailaddress, "", "", Subject, Body, "")


        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            result = False

        End Try
        Return result

    End Function

    Public Sub PrintAndEASEWordDocs(ByVal doctype As Integer, ByVal AppNo As String, ByVal docname As String, ByVal docfilename As String, ByVal appsys As String, ByVal DocSummary As String, Optional ByVal macroName As String = "", Optional ByVal DocCode As String = "", Optional ByVal LHead As String = "Y")
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
        Dim sdate As String = String.Empty
        Dim objDataRow As DataRow
        Dim WordDocName As String

        Try

            sdate = Format(Today.Date, "dd/MM/yyyy")

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

            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"

            'objWordDoc = objWordApp.Application.Documents.Open(docfilename.ToString)
            objWordDoc = objWordApp.Application.Documents.Add(Template:=(docfilename.ToString), NewTemplate:=False, DocumentType:=0)
            With objWordDoc


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


                ''If LHead = "Y" Then
                '.PageSetup.FirstPageTray = WORD.WdPaperTray.wdPrinterMiddleBin
                '.PageSetup.OtherPagesTray = WORD.WdPaperTray.wdPrinterLargeCapacityBin
                '.PrintOut(Background:=False, Copies:=2)


                ''Else
                ''.PrintOut(Background:=False, Copies:=2)
                ''End If


                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString) Then _
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString)
                If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM")) Then
                    My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM"))
                End If

                WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & docname & "_" & AppNo.Replace("/", "_") & "_DATE_" & sdate.Replace("/", "_") & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"


                '.SaveAs(WordDocName.ToString, FileFormat:=WORD.WdSaveFormat.wdFormatXMLDocument)

                With objWordApp.ActiveDocument.PageSetup

                    .FirstPageTray = WORD.WdPaperTray.wdPrinterMiddleBin
                    .OtherPagesTray = WORD.WdPaperTray.wdPrinterLargeCapacityBin
                End With


                objWordApp.ActiveDocument.PrintOut(Range:=WORD.WdPrintOutRange.wdPrintAllDocument, Item:=WORD.WdPrintOutItem.wdPrintDocumentWithMarkup, Copies:=1, Pages:="", PageType:=WORD.WdPrintOutPages.wdPrintAllPages, Collate:=True, Background:=True, PrintToFile:=False)

                objWordApp.ActiveDocument.ExportAsFixedFormat(OutputFileName:=mydocuments & "\" & strEASEdocumentName, ExportFormat:=WORD.WdExportFormat.wdExportFormatPDF, OpenAfterExport:=False, OptimizeFor:=WORD.WdExportOptimizeFor.wdExportOptimizeForPrint, Range:=WORD.WdExportRange.wdExportAllDocument)

                objWordApp.ActiveDocument.Close(SaveChanges:=False)




            End With

            objWordApp.Quit()


            Dim PublicId As Integer


            With My.Forms.EASEInsertWordDocument

                Select Case doctype
                    Case 55, 56 'RFSDAREFERRAL, RFSSUBREFERRAL
                        PublicId = 278599

                    Case 48 'RTAREFERRAL
                        PublicId = 287392
                End Select
                .PublicID = PublicId
                .FileNumber = txtFileNo.Text
                .DocSummary = DocSummary
                .DocNumber = strDocumentNo
                .ShowDialog()
                .Dispose()
            End With




            'My.Computer.FileSystem.DeleteFile(WordDocName)


            FileIO.FileSystem.MoveFile(mydocuments & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)




        Catch ex As Exception
            MessageBox.Show(ex.Message, " in CreateWordDocs routine in CreateWordDocuments module ")

        End Try





    End Sub

    Private Function ThereisanImage() As Boolean

        Dim result As Boolean = False


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in ThereisanImage routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Images_CheckForOldImages"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@HASIMAGE", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        result = CBool(.Parameters("@HASIMAGE").Value)

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in ThereisanImage routine - form " & Me.Name)

            End Try
        End Using

        Return result

    End Function

    Private Sub LoadAssociateApplicationsGrid(ByVal PINs As String)

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAssociateApplicationsGrid routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ListOfAssociatedApplicationByPIN"

                        .Parameters.Add("@PIN", SqlDbType.NVarChar).Value = PINs
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvAssociatedApps.DataSource = objDT
                    dgvAssociatedApps.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAssociateApplicationsGrid routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Function SubmissionNotComplete() As Boolean
        Dim result As Boolean = False

        If cboSubmissionType.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSubmissionType, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSubmissionType, "This is required")
            End With
            result = True

        Else
            ErrorProvider.SetError(Me.cboSubmissionType, "")

        End If

        If SubRecdDate.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(SubRecdDate, ErrorIconAlignment.MiddleRight)
                .SetError(SubRecdDate, "This is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(SubRecdDate, "")

        End If

        If txtSubmissionSummary.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtSubmissionSummary, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtSubmissionSummary, "A summary is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(Me.txtSubmissionSummary, "")

        End If

        If txtAuthorName.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAuthorName, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAuthorName, "A author is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(Me.txtAuthorName, "")

        End If
        If txtAuthurAddress.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAuthurAddress, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAuthurAddress, "An address is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(Me.txtAuthurAddress, "")

        End If
        If txtSubmissionSummary.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtSubmissionSummary, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtSubmissionSummary, "A summary is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(Me.txtSubmissionSummary, "")

        End If
        If txtAuthorTown.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAuthorTown, ErrorIconAlignment.MiddleLeft)
                .SetError(Me.txtAuthorTown, "A Town is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(Me.txtAuthorTown, "")

        End If

        If txtAuthorPCode.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAuthorPCode, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAuthorPCode, "A Town is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(Me.txtAuthorPCode, "")

        End If
        Return result

    End Function
    Private Sub SaveCCNO()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveCCNO routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UpdateDACCnumber"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = txtCCno.Text
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveCCNO routine - form " & Me.Name)

            End Try
        End Using



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
    '            Throw New System.Exception(sqlExceptionErr.Message,
    '            sqlExceptionErr.InnerException)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_DAsearch"
    '                    .Parameters.Add("@SEARCHTYPE", SqlDbType.Int)
    '                    .Parameters.Add("@SEARCHFOR", SqlDbType.NVarChar, 50)


    '                    Select Case cboSearchType.Text.ToUpper.Trim
    '                        Case "DA NUMBER"
    '                            ' Set command properties
    '                            PopulateForm(txtSearch.Text)
    '                            Exit Sub

    '                        Case "FILE NO"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iFILENO
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iFILENO

    '                        Case "APPLICANT  NAME"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iNAME
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iNAME

    '                        Case "OWNERS NAME"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iOWNERNAME
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iOWNERNAME

    '                        Case "PIN"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iPIN
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iPIN

    '                        Case "APPLICANT ADDRESS"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iADDRESS
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iADDRESS

    '                        Case "PROPERTY ADDRESS"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iPROPADDRESS
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iPROPADDRESS

    '                        Case "CONSTRUCTION CERTIFICATE"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iCC
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iCC

    '                        Case "DESCRIPTION"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iDESC
    '                            .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
    '                            Search = iDESC

    '                        Case "DEVELOPMENT TYPE"
    '                            ' Set command properties
    '                            .Parameters("@SEARCHTYPE").Value = iTYPE
    '                            .Parameters("@SEARCHFOR").Value = cboSearch.SelectedValue.ToString
    '                            .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(mskStartDate.Text), "dd/MM/yyyy")
    '                            .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = Format(CDate(mskEndDate.Text), "dd/MM/yyyy")
    '                            Search = iTYPE

    '                        Case Else : Exit Sub
    '                    End Select
    '                End With

    '                ' Execute the command
    '                objDA.SelectCommand = cmd
    '                objDA.Fill(objDS.Tables("Results"))

    '            End Using





    '            'Find the number of rows


    '            Dim RowCount As Integer = objDS.Tables("Results").Rows.Count

    '            Select Case RowCount
    '                Case 0
    '                    MessageBox.Show("Records matching this criteria were not found...", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Case 1

    '                    Dim objDataRow As DataRow = objDS.Tables("Results").Rows.Item(0)

    '                    'LoadForm(objDataRow.Item("DANo").ToString)
    '                    PopulateForm(objDataRow.Item("DANo").ToString)

    '                Case Else

    '                    Dim fsearch As New SearchResults
    '                    With fsearch
    '                        .ParentModule = Me.Name.ToUpper.ToString
    '                        .DataSet = objDS.Tables("Results")
    '                        .ShowDialog()
    '                    End With




    '            End Select
    '            'With lstSearchResults
    '            '    .DataSource = objDS.Tables("Results")
    '            '    .DisplayMember = "DANo"
    '            '    .ValueMember = "DANo"
    '            'End With



    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message, " In CheckForRecords - form PropertyRO")
    '        End Try
    '    End Using

    'End Sub

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
                        dayscount += CInt(DateDiff(DateInterval.Day, dateVar, CDate(objdatarow2.Item("RefRetDt"))))
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

    Private Function CalculateAddnInfoElapsedDays(ByVal DAno As String) As Integer

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
                        .CommandText = "usp_NetAddInfoReferalDays"

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

                If Not IsDBNull(objdatarow2.Item("AIReceivedDt")) And Not IsDBNull(objdatarow2.Item("AIRequestDt")) Then

                    'If (objdatarow2.Item("RefRetDt") <> null) And (objdatarow2.Item("AIRequestDt") <> null) Then
                    If DateDiff(DateInterval.Day, CDate(objdatarow2.Item("AIReceivedDt")), dateVar) > 0 Then

                    ElseIf DateDiff(DateInterval.Day, dateVar, CDate(objdatarow2.Item("AIRequestDt"))) <= 0 Then
                        dayscount += CInt(DateDiff(DateInterval.Day, dateVar, CDate(objdatarow2.Item("AIReceivedDt"))))
                        dateVar = CDate(objdatarow2.Item("AIReceivedDt"))

                    Else
                        dayscount += CInt(DateDiff(DateInterval.Day, CDate(objdatarow2.Item("AIRequestDt")), CDate(objdatarow2.Item("AIReceivedDt"))))
                        dateVar = CDate(objdatarow2.Item("AIReceivedDt"))

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
            .GetTheDate = datefield.Text
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        'If TheNewDate <> String.Empty Then datefield.Text = TheNewDate
        datefield.Text = TheNewDate
    End Sub

    Private Function DaysElapsed() As Integer

        Dim result As Integer

        If IsDate(dtRego.Text) Then



            If DADetermDt.Text = String.Empty Then

                result = DateDiff(DateInterval.Day, CDate(dtRego.Text), Today.Date)

            Else

                result = DateDiff(DateInterval.Day, CDate(dtRego.Text), CDate(DADetermDt.Text))

            End If

        Else

            result = 0

        End If

        Return result

    End Function

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

    Friend Sub KeyPressSendTab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            System.Windows.Forms.SendKeys.Send("{TAB}") 'Send Tab which changes active element on form
            e.Handled = True

        End If
    End Sub

    Private Sub FindUserInfor()
        Dim securitylayer As New DotNetSecLayer.clsSecLayer
        Dim sReturnValue As String
        Dim sUserInfo() As String
        Dim arrAccTypes() As String
        Dim i As Integer

        Try
            sUserID = My.User.Name.Substring(4)
            'sUserID = "gbruce"



            If sUserID = "" Then
                MsgBox("You have not logged onto the LAN correctly! " & vbCrLf _
                    & " Please try and log onto the network again " & vbCrLf _
                    & " Application is terminating now")

                Me.Close()
                Exit Sub
            Else

                'securitylayer = New SecLayer.clsSecLayer
                With securitylayer
                    .ServerName = My.Settings.ServerName
                    sReturnValue = .UsrAccLvl("DEVELOPMENT", sUserID, "")
                End With

                arrAccTypes = securitylayer.SpecAcc("DEVELOPMENT", sUserID)

                For i = 0 To UBound(arrAccTypes) - 1

                    Select Case arrAccTypes(i).ToUpper
                        Case "REGISTRATION"
                            Administration = True

                        Case "GENERAL MAINTENANCE"
                            GeneralMaint = True

                        Case "ASSESSMENT"
                            Administration = True
                            Assessment = True

                        Case "MAINTENANCE"
                            Administration = True
                            SysAdmin = True

                        Case "VIEW"
                            ViewOnly = True

                        Case "APPLICATION FOR APPLS"
                            AA = True

                        Case "UAT"
                            UAT = True

                    End Select

                Next


                sUserInfo = sReturnValue.Split(CChar("|"))




                sAccessLevel = sUserInfo(0)


                Dim lUserID As Integer = CInt(sUserInfo(1))

                GetUserID(lUserID)

                If Not CheckSeeIFInDASystem(sUserID) Then

                    MessageBox.Show("You are not registered as a user of the DA system, please click File>Maintenance>Officers and add yourself as a user.", "Not registered", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If



            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Function CheckSeeIFInDASystem(LanID As String) As Boolean

        Dim result As Boolean = False

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckSeeIFInDASystem routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_CheckSeeIfRegistered"

                        .Parameters.Add("@LANID", SqlDbType.NVarChar).Value = LanID
                        .Parameters.Add("@RESULT", SqlDbType.Int).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()

                        result = CBool(.Parameters("@RESULT").Value)


                    End With



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckSeeIFInDASystem routine - form " & Me.Name)

            End Try
        End Using

        Return result

    End Function


    Private Sub GetUserID(ByVal UserID As Integer)

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetUserID routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveUserID"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = UserID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            MyUserId = CInt(objDataReader.Item(0))
                            FullName = objDataReader.Item(1).ToString
                        Loop
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetUserID routine - form " & Me.Name)

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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblOfficer.Tag)
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

    Private Sub DisplayDocumentToPrint(ByVal rptToPrint As ReportDocument)

        Dim fPrint As New ReportPrintScreen
        With fPrint
            .StartPosition = FormStartPosition.CenterParent
            .ReportName = rptToPrint
            .ShowDialog()
            .Dispose()

        End With


    End Sub

    Private Sub ClearFileNotes(ByVal Pnl As Control)
        For Each ctrl As Control In Pnl.Controls()
            If TypeOf ctrl Is Windows.Forms.ComboBox Then
                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)
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
        Me.lblReferralID.Text = String.Empty

    End Sub

    Private Function CheckReferralData() As Boolean
        Dim result As Boolean = True

        If Refdt.EditValue Is Nothing Then
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
        'If txtRefComm.Text = String.Empty Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.txtRefComm, ErrorIconAlignment.MiddleRight)
        '        .SetError(Me.txtRefComm, "A comment is required")
        '    End With
        '    result = False
        'Else
        '    ErrorProvider.SetError(Me.txtRefComm, "")

        'End If


        'If cboRFSSubDivisionType.Visible Then
        If chksepp71.Checked = True Then

            If cboRFSSubDivisionType.SelectedIndex = -1 Then
                With ErrorProvider
                    .SetIconAlignment(Me.cboRFSSubDivisionType, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.cboRFSSubDivisionType, "A value is required")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.cboRFSSubDivisionType, "")

            End If
            'If cboRFSSubDivisionType.Text = "" Then

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
        'End If
        Return result
    End Function

    Private Function SubReportData(ByVal iReport As Integer) As DataTable
        Dim DTresult As New DataTable

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SubReportData routine - form PrintCert149Viewer")

            End Try
            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure

                        Select Case iReport
                            Case ADDINFO
                                .CommandText = "usp_rpt_DAAssessmentAddInfo"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text

                            Case REFERRAL
                                .CommandText = "usp_rpt_DAAssessmentReferral"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case SUBMISSION
                                .CommandText = "usp_rpt_DAAssessmentSubmission"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text

                            Case HISTORY
                                .CommandText = "usp_rpt_DAAssessmentDevHistory"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text

                            Case ZONE
                                .CommandText = "usp_rpt_DAAssessmentZone"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text

                            Case REP
                                .CommandText = "usp_rpt_DAAssessmentREP"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case SEPP
                                .CommandText = "usp_rpt_DAAssessmentSEPP"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case GUIDE
                                .CommandText = "usp_rpt_DAAssessmentGuide"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case DCP
                                .CommandText = "usp_rpt_DAAssessmentDCP"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case SEC94
                                .CommandText = "usp_rpt_DAAssessmentS94"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case VARIATION
                                .CommandText = "usp_rpt_DAAssessmentVariation"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case CONDLINK
                                .CommandText = "usp_rpt_DAAssessmentCondLink"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                            Case ONEOFF
                                .CommandText = "usp_rpt_DAAssessmentOneOff"
                                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text


                        End Select



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    DTresult = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SubReportData routine - form PrintCert149Viewer")
            End Try
        End Using



        Return DTresult

    End Function

    Private Sub clearForm(ByVal pnl As Control)

        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Windows.Forms.ComboBox Then
                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)
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
            ElseIf TypeOf ctrl Is NumericUpDown Then
                Dim cb As NumericUpDown = DirectCast(ctrl, NumericUpDown)
                cb.Value = 0

            End If
        Next

        btnGoogle.Enabled = False
        btnEnlighten.Enabled = False

    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim cb As Button = DirectCast(ctrl, Button)
                Select Case cb.Name

                    Case "btnViewNote", "btnPrintSewer", "btnPrintBldgCert", "btnEditBldgCert", "btnEditTrees", "btnEditLTW", "btnAddFile", "btnAddPIN", "btnAddFile"
                        cb.Enabled = True

                    Case "btnAddDA", "btnEditDA", "btnViewOfficers", "btnAssignOfficer", "btnEditStatus", "btnMapMerge", "btnPrintAdvert", "btnPrintAdvNotice", "btnDesignated", "btnDesignIntegr"

                        cb.Enabled = True

                    Case "btnAddVariation", "btnAddSub", "btnAckSub", "btnEdit68", "btnAddFee", "btnAddRefund", "btnAddReferral", "btnEditReferralsTab"

                        cb.Enabled = True

                    Case "btnAddReferral", "btnNotesAdd", "btnADDAddinfoTab", "btnGoogle", "btnEnlighten"
                        cb.Enabled = True


                    Case Else
                        cb.Enabled = bLock

                End Select
            ElseIf TypeOf ctrl Is Windows.Forms.ComboBox Then
                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)
                If cb.Name <> "cboIntDevActs" Then
                    cb.Enabled = bLock
                Else
                    cb.Enabled = True

                End If
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = Not bLock

            ElseIf TypeOf ctrl Is NumericUpDown Then
                Dim cb As NumericUpDown = DirectCast(ctrl, NumericUpDown)
                cb.Enabled = bLock

            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = bLock


            ElseIf TypeOf ctrl Is DateEdit Then
                Dim tb As DateEdit = DirectCast(ctrl, DateEdit)
                tb.ReadOnly = Not bLock

            ElseIf TypeOf ctrl Is LookUpEdit Then
                Dim tb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                tb.ReadOnly = Not bLock



            ElseIf TypeOf ctrl Is TextEdit Then
                Dim tb As TextEdit = DirectCast(ctrl, TextEdit)
                tb.ReadOnly = Not bLock



            End If


            If ctrl.HasChildren Then
                LockTheForm(ctrl, bLock)
            End If
        Next
    End Sub

    Private Sub UpdateVideoGroupID(ByVal VideoGroupID As Integer)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateVideoGroupID routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_VideoGroupId"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@GROUPID", SqlDbType.Int).Value = VideoGroupID
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateVideoGroupID routine - form " & Me.Name)

            End Try
        End Using


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
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@GROUPID", SqlDbType.Int).Value = imageID
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdatePropertyImage routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LockApplication()
        txtCCno.ReadOnly = True
        chkSec94.Enabled = False
        cboAppType.Enabled = False
        txtFileNo.ReadOnly = True
        txtAppName.ReadOnly = True
        txtAppAddress.ReadOnly = True
        txtAppTown.ReadOnly = True
        txtAppPcode.ReadOnly = True
        txtAppPhone.ReadOnly = True
        txtAppemail.ReadOnly = True
        btnEditDA.Enabled = True
        btnAddDA.Enabled = Administration
        rbNotifyAdvert.Enabled = False
        Me.rbNone.Enabled = False
        Me.rbNotify.Enabled = False

        Me.btnSaveDA.Enabled = False
        Me.txtLot.ReadOnly = True
        Me.txtDP.ReadOnly = True
        Me.txtSection.ReadOnly = True
        Me.txtArea.ReadOnly = True
        Me.cboAreaType.Enabled = False
        Me.txtStreetNo.ReadOnly = True
        Me.txtStreetName.ReadOnly = True
        Me.cboDAlocalityCode.Enabled = False
        Me.cboDACensusCode.Enabled = False
        Me.txtDAOwnersName.ReadOnly = True
        Me.txtDAOwnersAddress.ReadOnly = True
        Me.txtDAOwnersTown.ReadOnly = True
        Me.txtDAOwnersPcode.ReadOnly = True
        Me.txtDAOwnersPhone.ReadOnly = True
        Me.chkBASIXRecd.Enabled = False
        Me.txtBASIXCertNo.ReadOnly = True
        Me.txtBASIXwater.ReadOnly = True
        Me.txtBASIXthermal.ReadOnly = True
        Me.txtBASIXenergy.ReadOnly = True
        Me.btnAddPIN.Enabled = False
        'Me.btnRemovePIN.Enabled = True
        Me.btnRetrieveProperty.Enabled = False
        Me.chkDesc1.Enabled = False
        Me.chkDADesc2.Enabled = False
        Me.chkDADesc3.Enabled = False
        Me.chkDADesc4.Enabled = False
        Me.chkDADesc5.Enabled = False
        Me.chkDADesc6.Enabled = False
        Me.chkDADesc7.Enabled = False
        Me.chkDADesc8.Enabled = False
        Me.chkGiftDonation.Enabled = False
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
        txtModDesc.ReadOnly = True
        btnAddFile.Enabled = False
        btnRemoveFile.Enabled = False
        Me.chkSec68q1.Enabled = True
        Me.chkSec68q2.Enabled = True
        Me.chkSec68q3.Enabled = True
        Me.chkSec68q4.Enabled = True
        Me.chkSec68q5.Enabled = True
        Me.chkSec68q6.Enabled = True
        Me.chkSec68q7.Enabled = True
        LockTheForm(grpAssessment, False)
        LockTheForm(grpDetermination, False)
        LockTheForm(grpNotification, False)
        cboAdvertSignDepot.Enabled = False
        'Me.mnuImages.Enabled = True
        Me.mnuCompliance.Enabled = True
        Me.mnuOtherApplication.Enabled = True
        'me.mnuPreviewAssessment.Enabled=True
        Me.mnuEngDetailsPostConsent.Enabled = True
        Me.menuAssessmentApplication.Enabled = Assessment

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
                        .CommandText = "usp_DAUPDATE_STATUS_DATA"

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
                        .Parameters.Add("@PROGCOMMENT", SqlDbType.NVarChar).Value = Me.txtProgressComment.Text

                        If cboDAAuthorityId.Text <> String.Empty Then .Parameters.Add("@AUTHORITY", SqlDbType.Int).Value = CInt(cboDAAuthorityId.SelectedValue)
                        If cboProgressCode.Text <> String.Empty Then .Parameters.Add("@PROGRESSCODE", SqlDbType.Int).Value = CInt(cboProgressCode.SelectedValue)
                        If cboReasonOver40.Text <> String.Empty Then .Parameters.Add("@OVER40REASON", SqlDbType.Int).Value = CInt(cboReasonOver40.SelectedValue)

                        .Parameters.Add("@STOPCLOCK", SqlDbType.Int).Value = Me.chkAPZYesNo.CheckState

                        'If cboDAAuthorityId.Text <> String.Empty Then .Parameters.Add("@AUTHORITY", SqlDbType.Int).Value = CInt(cboDAAuthorityId.SelectedValue)

                        If cboAdvertSignDepot.SelectedIndex > 0 Then .Parameters.Add("@ADVERTDEPOT", SqlDbType.NVarChar).Value = cboAdvertSignDepot.SelectedValue.ToString

                        If rbNone.Checked = True Then
                            .Parameters.Add("@ADVERTNOTCHECK", SqlDbType.NVarChar).Value = 1

                        ElseIf rbNotify.Checked = True Then
                            .Parameters.Add("@ADVERTNOTCHECK", SqlDbType.NVarChar).Value = 2

                        ElseIf rbNotifyAdvert.Checked = True Then
                            .Parameters.Add("@ADVERTNOTCHECK", SqlDbType.NVarChar).Value = 3


                        End If


                        .Parameters.Add("@ADVERINTDETAILS", SqlDbType.NText).Value = txtAdvertSignIntDetails.Text
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveTheStatus routine - form " & Me.Name)

            End Try
        End Using



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
                        .Parameters.Add("@GIFTDONATION", SqlDbType.Bit).Value = Me.chkGiftDonation.CheckState
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
                        .Parameters.Add("@MODDESC", SqlDbType.NVarChar).Value = Me.txtModDesc.Text
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveDescription routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub SavePropertyData()
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
                        .CommandText = "usp_DAUPDATE_Property"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text

                        .Parameters.Add("@DALOT", SqlDbType.NVarChar).Value = Me.txtLot.Text
                        .Parameters.Add("@DADP", SqlDbType.NVarChar).Value = Me.txtDP.Text
                        .Parameters.Add("@DASECT", SqlDbType.NVarChar).Value = Me.txtSection.Text
                        .Parameters.Add("@DASTREETNO", SqlDbType.NVarChar).Value = Me.txtStreetNo.Text
                        .Parameters.Add("@DASTREETNAME", SqlDbType.NVarChar).Value = Me.txtStreetName.Text
                        .Parameters.Add("@LOCALITY", SqlDbType.Int).Value = CInt(cboDAlocalityCode.SelectedValue)
                        .Parameters.Add("@OWNERNAME", SqlDbType.NVarChar).Value = Me.txtDAOwnersName.Text
                        .Parameters.Add("@OWNERADDRESS", SqlDbType.NVarChar).Value = Me.txtDAOwnersAddress.Text
                        .Parameters.Add("@OWNERTOWN", SqlDbType.NVarChar).Value = Me.txtDAOwnersTown.Text
                        .Parameters.Add("@OWNERPCODE", SqlDbType.SmallInt).Value = NZ(txtDAOwnersPcode.Text)
                        .Parameters.Add("@OWNERPHONE", SqlDbType.NVarChar).Value = Me.txtDAOwnersPhone.Text
                        If txtArea.Text <> String.Empty Then .Parameters.Add("@DAAREA", SqlDbType.Float).Value = CDbl(txtArea.Text)
                        .Parameters.Add("@AREAUNIT", SqlDbType.NVarChar).Value = Me.cboAreaType.SelectedValue
                        .Parameters.Add("@CENSUS", SqlDbType.NVarChar).Value = Me.cboDACensusCode.SelectedValue
                        .Parameters.Add("@BASIXCERTNO", SqlDbType.NVarChar).Value = Me.txtBASIXCertNo.Text
                        .Parameters.Add("@BASIXRCPTNO", SqlDbType.NVarChar).Value = Me.txtBASIXRcptNo.Text
                        .Parameters.Add("@BASIXRECD", SqlDbType.Bit).Value = Me.chkBASIXRecd.CheckState
                        .Parameters.Add("@BASIXTHERMAL", SqlDbType.NVarChar).Value = Me.txtBASIXthermal.Text
                        .Parameters.Add("@BASIXENERGY", SqlDbType.NVarChar).Value = Me.txtBASIXenergy.Text
                        .Parameters.Add("@BASIXWATER", SqlDbType.NVarChar).Value = Me.txtBASIXwater.Text

                        .ExecuteNonQuery()

                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDA_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub PrintNotesOnPlainPaperOnly(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer)

        Dim rptDocument As New ReportDocument


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
                .PrintToPrinter(1, False, 1, 99)
                .Close()
            End With



        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")

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
            End With


            rptDocument.PrintToPrinter(1, False, 1, 1)
            'rptDocument.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\test\test.pdf")


            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"


            Dim Recepient As Integer


            With My.Forms.WhoAreYouSendingMailTo
                .ShowDialog()
                Recepient = .Recepient
                .Dispose()

            End With

            With My.Forms.OutwardEaseCorro
                Select Case Recepient
                    Case 1

                        .CustName = Me.txtDAOwnersName.Text
                        .CustAddress = Me.txtDAOwnersAddress.Text & " " & txtDAOwnersTown.Text & " " & Me.txtDAOwnersPcode.Text

                    Case 2

                        .CustName = Me.txtAppName.Text
                        .CustAddress = Me.txtAppAddress.Text & " " & Me.txtAppTown.Text & " " & Me.txtAppPcode.Text


                End Select
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


        Catch ex As Exception
            MessageBox.Show(ex.Message & " in function PrintReferralLetter")
        Finally
            rptDocument.Close()

        End Try

    End Sub

    Private Sub CheckIfDataChanged()
        Dim changed As Boolean = False

        If btnSaveDA.Enabled Then
            changed = True
        End If

        If changed Then
            If MessageBox.Show("It appears you have updated some information, save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                If Me.btnSaveDA.Enabled Then btnSaveDA_ClickExtracted()


            End If
        End If

    End Sub

    Private Sub ClearControls(ByVal pnl As Control)


        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Windows.Forms.ComboBox Then
                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)
                cb.SelectedIndex = -1

            ElseIf TypeOf ctrl Is TextBox Then
                Dim tb As TextBox = DirectCast(ctrl, TextBox)
                tb.Text = String.Empty

            ElseIf TypeOf ctrl Is MaskedTextBox Then
                Dim mskb As MaskedTextBox = DirectCast(ctrl, MaskedTextBox)
                mskb.Text = String.Empty

            ElseIf TypeOf ctrl Is CheckBox Then

                Dim chkb As CheckBox = DirectCast(ctrl, CheckBox)
                chkb.CheckState = CheckState.Unchecked

            ElseIf TypeOf ctrl Is DateEdit Then

                Dim dte As DateEdit = DirectCast(ctrl, DateEdit)
                dte.EditValue = Nothing

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

        picEnlightenMap.Image = Nothing




    End Sub

    Private Sub LoadListOfPINS(ByVal CDNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfPINS routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadListOfPINS"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDNo
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With lstPINs
                        .DataSource = objDT
                        .DisplayMember = "PIN"
                        .ValueMember = "PIN"
                        .SelectedIndex = -1
                    End With



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfPINS routine - form " & Me.Name)

            End Try
        End Using


    End Sub


#End Region

#Region "Build Documents"


    Private Sub cboSTDconditions_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSTDconditions.GotFocus
        cboSTDconditions.DroppedDown = True
    End Sub

    Private Sub btnCreateOtherLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateOtherLetter.Click
        If MessageBox.Show("You are about to assemble a draft document. OK to proceed?", "Create a draft document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        'If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim docType As Integer
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim BuildType As Integer = 1
        Dim sysType As String = "DA"


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@id", SqlDbType.Int).Value = CInt(cboOtherDocs.SelectedValue)
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docType = CInt(cboOtherDocs.SelectedValue)
                            docname = objDataReader.Item("Docname").ToString
                            docfilename = objDataReader.Item("DocTemplatePath").ToString
                            MacroName = objDataReader.Item("MacroName").ToString
                            BuildType = CInt(objDataReader.Item("BuildType"))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using


                If BuildType = 1 Then

                    CreateWordDocs(docType, Me.txtDANo.Text, docname, docfilename, sysType, MacroName)
                Else

                    If docname = "N" Then

                        PrintAdjacentMailMerge(txtDANo.Text, docType, docname, docfilename)


                    Else

                        PrintMailMerge(txtDANo.Text, docType, docname, docfilename)

                    End If

                End If


                DisplayListOfDraftDocuments(Me.txtDANo.Text)
                'RemoveStandardConditions()
                'RemoveOneUptandardConditions()
                'LoadUpConditionsList(txtDANo.Text)
                'LoadUpOneUpConditions(txtDANo.Text)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub btnInsertIntoLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertIntoLive.Click

        If MessageBox.Show("You are about to copy all the proposed contribution records for this DA and add them to the 'Live' Section 94 Register!  OK to proceed?", "Update the Contributions Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub






        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnInsertIntoLive_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_MoveProposedSection64ContributionsToLive"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnInsertIntoLive_Click routine - form " & Me.Name)

            End Try
        End Using

        mnuSec94.Enabled = True

    End Sub

    Private Sub btnAssembleLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssembleLetter.Click

        If cboConsentDocType.SelectedIndex = -1 Then

            MessageBox.Show("You MUST Select the type of document you are assembling", "Select document type", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return
        End If

        If MessageBox.Show("You are about to assemble a draft document. OK to proceed?", "Create a draft document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Return
        'If Me.dgvDraftDocs.CurrentRow.Cells(3).Value.ToString = String.Empty Then Exit Sub

        Dim docType As Integer
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim sysType As String = "DA"


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                DisplayListOfDraftDocuments(Me.txtDANo.Text)
                'RemoveStandardConditions()
                'RemoveOneUptandardConditions()
                LoadUpConditionsList(txtDANo.Text)
                LoadUpOneUpConditions(txtDANo.Text)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub dgvDraftDocs_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDraftDocs.CellClick
        If e.RowIndex = -1 Then Exit Sub
        btnViewEditDocument.Enabled = True
        btnDeleteDoc.Enabled = True
        btnFinaliseDoc.Enabled = True
    End Sub

    Private Sub btnAddOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddOneOffCond.Click
        With My.Forms.InsertOneUpCondition
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()

        End With

        Try
            LoadUpOneUpConditions(txtDANo.Text)

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dgvSTDConditions_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSTDConditions.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        btnRemoveCondition.Enabled = True

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

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                btnRemoveOneOffCond.Enabled = False


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveOneOffCond_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadUpOneUpConditions(txtDANo.Text)

    End Sub

    Private Sub btnAddCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCondition.Click

        InsertNewCondition()
        cboSTDconditions.Focus()

    End Sub

    Private Sub LoadUpConditionsList(ByVal AANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpConditionsList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpConditionList"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvSTDConditions.DataSource = objDT
                    dgvSTDConditions.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpConditionsList routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub LoadUpOneUpConditions(ByVal AANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpOneUpConditions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadOneUpConditions"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvOneUpConditions.DataSource = objDT
                    dgvOneUpConditions.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadUpOneUpConditions routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub cboConsentDocType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConsentDocType.SelectedValueChanged
        If isloading Then Exit Sub
        If cboConsentDocType.SelectedIndex = -1 Then Exit Sub



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in cboConsentDocType_SelectedValueChanged routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ListofConditionsByLetterType"

                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(cboConsentDocType.SelectedValue)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count = 0 Then

                        cboSTDconditions.Visible = False

                    Else

                        With cboSTDconditions
                            .Visible = True
                            .DataSource = objDT
                            .DisplayMember = "Condition"
                            .ValueMember = "ID"
                            .Refresh()

                        End With

                    End If



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in cboConsentDocType_SelectedValueChanged routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub btnRemoveCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveCondition.Click


        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                Try
                    LoadUpConditionsList(Me.txtDANo.Text)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                btnRemoveCondition.Enabled = False

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveCondition_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub DisplayListOfDraftDocuments(ByVal AANo As String)

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
                        .CommandText = "usp_DisplayListOfDraftDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AANo
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

    Private Sub LoadListOfConditionsByLetterType(ByVal DocId As Integer)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfConditionsByLetterType routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ListofConditionsByLetterType"

                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = DocId
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboSTDconditions
                        .DataSource = objDT
                        .DisplayMember = "Condition"
                        .ValueMember = "Id"
                        .SelectedIndex = -1
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfConditionsByLetterType routine - form " & Me.Name)

            End Try
        End Using





    End Sub

    Private Function CheckConditionAlreadyExists(ByVal condID As Integer) As Boolean
        Dim result As Boolean = False
        Using cn As New SqlConnection(My.Settings.connectionString)
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

    Private Sub btnSaveConsent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveConsent.Click
        If MessageBox.Show("Save Consent Plan Number?", "Update Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveConsent_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_Consent"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@CONSENT", SqlDbType.NText).Value = ConsentPlanNumberTextBox.Text
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveConsent_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnViewEditDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEditDocument.Click
        If Me.dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString = String.Empty Then Exit Sub
        'Try
        '    Dim objWordApp As New Microsoft.Office.Interop.Word.Application
        '    Dim objWordDoc As Microsoft.Office.Interop.Word.Document = objWordApp.Application.Documents.Open(Me.dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString)
        '    objWordDoc.Activate()
        '    objWordApp.Visible = True

        'Catch ex As Exception

        'End Try


        Try

            Dim WRD As New OpenDocument
            WRD.OpenVisible(dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString)

            'Dim objWordApp As New Microsoft.Office.Interop.Word.Application
            'Dim objWordDoc As Microsoft.Office.Interop.Word.Document = objWordApp.Application.Documents.Open(Me.dgvDraftDocs.CurrentRow.Cells(0).Value.ToString)
            'objWordDoc.Activate()
            'objWordApp.Visible = True

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
                        .CommandText = "usp_RemoveDraftDoc"

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
            DisplayListOfDraftDocuments(txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnFinaliseDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinaliseDoc.Click

        If dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "ModConsent" Or dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "StdConsent" Then
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
                            .CommandText = "usp_SubmissionandObjections"

                            .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        End With

                        Dim objDT As New DataTable


                        Using objDataReader As SqlDataReader = cmd.ExecuteReader
                            objDT.Load(objDataReader)
                        End Using
                        If objDT.Rows.Count > 0 Then
                            If MessageBox.Show("Have you printed Objector Advice letters yet?", "Proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
                        End If



                    End Using




                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

                End Try
            End Using
        End If

        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If Me.dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString = String.Empty Then Exit Sub

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        Dim summary As String = "Application No. " & txtDANo.Text & " Document Type: " & dgvDraftDocs.CurrentRow.Cells("colDocDescription").Value.ToString

        Dim Recepient As Integer


        With My.Forms.WhoAreYouSendingMailTo
            .ShowDialog()
            Recepient = .Recepient
            .Dispose()

        End With


        With My.Forms.InsertEASEDocument

            Select Case Recepient
                Case 1

                    .CustName = Me.txtDAOwnersName.Text
                    .CustAddress = Me.txtDAOwnersAddress.Text & " " & txtDAOwnersTown.Text & " " & Me.txtDAOwnersPcode.Text

                Case 2

                    .CustName = Me.txtAppName.Text
                    .CustAddress = Me.txtAppAddress.Text & " " & Me.txtAppTown.Text & " " & Me.txtAppPcode.Text


            End Select

            .WordDocLocation = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = Me.txtFileNo.Text
            .ShowDialog()
            .Dispose()
        End With

        Dim NewRecordID As Integer

        Dim InsertDocData As New InsertDocumentData
        With InsertDocData
            .ApplicationType = "DA"
            .DocumentType = dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString
            .ApplicationNo = Me.txtDANo.Text
            .TheAuthor = MyUserId
            .TheImageName = sDocumentNo.Replace(".", "_")
            .Notes = summary
            .InsertDocumentsIntoDAsystem()
            NewRecordID = .DocumentID

        End With



        Dim FileToDelete As String = dgvDraftDocs.CurrentRow.Cells("colDraftDocPath").Value.ToString


        If dgvDraftDocs.CurrentRow.Cells("colDocDescription").Value.ToString = "Standard Consent Letter" Then


            InsertWordDocumentIntoTable(FileToDelete, NewRecordID)

        End If



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
                        .CommandText = "usp_RemoveDraftDoc"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDraftDocs.CurrentRow.Cells("colDraftDocId").Value)
                        .ExecuteNonQuery()
                    End With
                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        LoadHistoricalDocuments()
        DisplayListOfDraftDocuments(txtDANo.Text)




    End Sub

    Private Sub InsertWordDocumentIntoTable(WordDocument As String, DocID As Integer)

        'Dim tmpFile As New FileStream(WordDocument, FileMode.Open, FileAccess.Read)
        'Dim btSaveFile(CInt(tmpFile.Length)) As Byte
        'tmpFile.Read(btSaveFile, 0, CInt(tmpFile.Length))
        'tmpFile.Close()

        Dim btSaveFile As Byte()

        btSaveFile = ReadFile(WordDocument)

        Dim DocumentName As String = My.Computer.FileSystem.GetName(WordDocument)

        'Dim blob As [Byte]() = DirectCast(btSaveFile, [Byte]())


        'Dim ms As MemoryStream = New MemoryStream(blob)


        'Using fs As FileStream = File.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

        '    ms.WriteTo(fs)
        '    'ms.Close()

        'End Using

        'ms.Close()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertWordDocumentIntoTable routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_DAStandardLetterWordDocument"

                        .Parameters.Add("@DOCUMENTTITLE", SqlDbType.VarChar).Value = DocumentName
                        .Parameters.Add("@WORDOBJECT", SqlDbType.VarBinary).Value = btSaveFile
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = DocID

                        .ExecuteNonQuery()

                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertWordDocumentIntoTable routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub RemoveOneUptandardConditions()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveStandardConditions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveOneUpConditions"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveStandardConditions routine - form " & Me.Name)

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
            Procedurename = "usp_GetDefaultStandardConditions_assType"
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


                LoadUpConditionsList(txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddDefaultCondition_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub RemoveStandardConditions()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveStandardConditions routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveAllConditionCode"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .ExecuteNonQuery()
                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveStandardConditions routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub InsertIntoDADocumentsTable(ByVal DocType As String, ByVal FileName As String)
        Using cn As New SqlConnection(My.Settings.connectionString)
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

    Private Sub cboAssessmentType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAssessmentType.SelectedValueChanged
        If isloading Then Exit Sub
        If cboAssessmentType.SelectedIndex = -1 Then Exit Sub

        btnAddDefaultCondition.Enabled = HasStandardCondition(CInt(cboAssessmentType.SelectedValue))
    End Sub

#End Region

#Region "Referrals"

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click

        With My.Forms.ReferralsResponsePopUp
            .ResponseText = Me.txtRefResponse.Text
            .ShowDialog()
            txtRefResponse.Text = .ResponseText
            .Dispose()
        End With

    End Sub

    Private Sub btnDraftconditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDraftconditions.Click
        With My.Forms.DraftConditions
            .TheReferralId = CInt(lblReferralID.Text)
            .ApplicationID = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub btnAddReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferral.Click
        btnAddReferral.Enabled = False
        Me.btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        ClearReferralData(grpMain)
        Me.lblReferralID.Text = String.Empty


        LockTheForm(pnlButtons, False)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        'LockTheForm(grpSepp71, True)
        txtRefComm.ReadOnly = False

        'LoadReferralsIntProvisionlList(txtDANo.Text)
        LoadLstIntegrated(txtDANo.Text)

    End Sub

    Private Sub SaveReferralData()
        btnEditReferralsTab.Enabled = True
        btnSaveReferralsTab.Enabled = False
        LockTheForm(grpMain, False)
        LockTheForm(pnlButtons, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        LockTheForm(grpMain, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        If IsDate(Refdt.Text) Then .Parameters("@REFDATE").Value = Format(CDate(Refdt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@RETREFDTE", SqlDbType.SmallDateTime)
                        If IsDate(RefRetDt.Text) Then .Parameters("@RETREFDTE").Value = Format(CDate(RefRetDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@REFCODEID", SqlDbType.Int).Value = CInt(cboRefCodeId.SelectedValue)
                        '.Parameters.Add("@SEPP71IMPACTS", SqlDbType.NVarChar).Value = Me.txtSepp71LikelyImpacts.Text
                        .Parameters.Add("@REFCOMMENT", SqlDbType.NText).Value = Me.txtRefComm.Text
                        .Parameters.Add("@REFRESPONSE", SqlDbType.NText).Value = Me.txtRefResponse.Text
                        .Parameters.Add("@SEPP71REFER", SqlDbType.Bit).Value = Me.chksepp71.CheckState
                        '.Parameters.Add("@SEPP71INTDEV", SqlDbType.Bit).Value = Me.chkIntDev.CheckState
                        '.Parameters.Add("@SEPP71SENSITIVE", SqlDbType.Bit).Value = Me.chkSensitive.CheckState
                        '.Parameters.Add("@SEPP711100MARK", SqlDbType.Bit).Value = Me.chk100Mark.CheckState
                        '.Parameters.Add("@SEPP71SCH3", SqlDbType.Bit).Value = Me.chkSch3.CheckState
                        .Parameters.Add("@RFSSUBDIV", SqlDbType.NVarChar)
                        If cboRFSSubDivisionType.SelectedIndex <> -1 Then .Parameters("@RFSSUBDIV").Value = Me.cboRFSSubDivisionType.SelectedValue.ToString()
                        .Parameters.Add("@RFSLOTS", SqlDbType.Int)
                        If txtRFSSubLots.Text <> String.Empty Then .Parameters("@RFSLOTS").Value = CInt(txtRFSSubLots.Text)
                        .Parameters.Add("@ENGCOMMENTS", SqlDbType.NText).Value = Me.txtEngInternalComments.Text
                        .Parameters.Add("@ENDRETDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.EngDueReturnDate.Text) Then .Parameters("@ENDRETDTE").Value = Format(CDate(EngDueReturnDate.EditValue), "dd/MM/yyyy")
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

        LoadReferralsIntProvisionlList(txtDANo.Text)
        LoadLstIntegrated(txtDANo.Text)

    End Sub

    Private Sub btnEditReferralsTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditReferralsTab.Click
        btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        LockTheForm(pnlButtons, True)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        'LockTheForm(grpSepp71, True)

    End Sub

    Private Sub btnSaveReferralsTab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveReferralsTab.Click
        If Not CheckReferralData() Then Exit Sub
        SaveReferralData()
        ClearReferralData(grpMain)

    End Sub

    Private Sub dgvLoadListReferrals_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLoadListReferrals.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        If Not e.RowIndex = -1 Then
            Try
                LoadReferralDetails(CInt(dgvLoadListReferrals.CurrentRow.Cells(0).Value))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            LockTheForm(pnlButtons, True)

            RefRetDt.ReadOnly = True
            Refdt.ReadOnly = True

            'LockTheForm(grpMain, False)
            'LockTheForm(grpRFS, False)
            'LockTheForm(grpIntDesig, False)
            'LockTheForm(grpEngineers, False)
            'LockTheForm(grpSepp71, False)
            btnView.Enabled = True
            Me.btnEditReferralsTab.Enabled = True
            Me.btnAddReferral.Enabled = True
            btnSaveReferralsTab.Enabled = False

            Select Case CInt(cboRefCodeId.SelectedValue)

                Case 2, 3
                    Me.grpRFS.Visible = False
                    btnRTA.Visible = True
                    btnRTA.Enabled = True

                Case 59

                    grpRFS.Visible = chksepp71.Checked

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

    Private Sub LoadReferralDetails(ByVal ID As Integer)


        lblReferralID.Text = String.Empty
        Refdt.EditValue = Nothing
        RefRetDt.EditValue = Nothing
        cboRefCodeId.SelectedIndex = -1
        txtRefComm.Text = String.Empty
        txtRefResponse.Text = String.Empty
        chksepp71.Checked = False
        'chkIntDev.Checked = False
        'chkSensitive.Checked = False
        'chk100Mark.Checked = False
        'chkSch3.Checked = False
        cboRFSSubDivisionType.SelectedIndex = -1
        txtRFSSubLots.Text = String.Empty
        txtEngInternalComments.Text = String.Empty
        EngDueReturnDate.EditValue = Nothing



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
                        .CommandText = "usp_RetrieveReferalInfo"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = ID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)


                        lblReferralID.Text = objDataRow.Item("ReferralID").ToString
                        If Not IsDBNull(objDataRow.Item("Refdt")) Then Refdt.EditValue = CDate(objDataRow.Item("Refdt"))
                        If Not IsDBNull(objDataRow.Item("RefRetDt")) Then RefRetDt.EditValue = CDate(objDataRow.Item("RefRetDt"))
                        DaysElapsedTextBox.Text = objDataRow.Item("DaysElapsed").ToString
                        If Not IsDBNull(objDataRow.Item("RefCodeId")) Then cboRefCodeId.SelectedValue = CInt(objDataRow.Item("RefCodeId"))
                        'txtSepp71LikelyImpacts.Text = objDataRow.Item("Sepp71LikelyImpacts").ToString
                        txtRefComm.Text = objDataRow.Item("RefComm").ToString
                        txtRefResponse.Text = objDataRow.Item("RefResponse").ToString
                        chksepp71.Checked = CBool(objDataRow.Item("Sepp71Refer"))

                        grpRFS.Visible = chksepp71.Checked

                        If Not IsDBNull(objDataRow.Item("BinaryDocument")) Then

                            btnAddPDF.Text = "View Document"
                            btnAddPDF.Tag = "VIEW"

                        Else

                            btnAddPDF.Text = "Add PDF/Image"
                            btnAddPDF.Tag = "ADD"

                        End If

                        'chkIntDev.Checked = CBool(objDataRow.Item("Sepp71IntDev"))
                        'chkSensitive.Checked = CBool(objDataRow.Item("Sepp71Sensitive"))
                        'chk100Mark.Checked = CBool(objDataRow.Item("Sepp71100Mark"))
                        'chkSch3.Checked = CBool(objDataRow.Item("Sepp71Schedule3"))
                        If Not IsDBNull(objDataRow.Item("RFSSubDiv")) Then cboRFSSubDivisionType.SelectedValue = objDataRow.Item("RFSSubDiv").ToString
                        txtRFSSubLots.Text = objDataRow.Item("RFSSubLots").ToString
                        txtEngInternalComments.Text = objDataRow.Item("EngInternalComments").ToString
                        If Not IsDBNull(objDataRow.Item("EngDueReturnDate")) Then EngDueReturnDate.EditValue = CDate(objDataRow.Item("EngDueReturnDate"))



                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    'Public Sub CreateObjectorWordDocs(ByVal objDt As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer, ByVal DocType As String)
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
    '    Dim WordDocName As String

    '    Try

    '        sdate = Format(Today.Date, "dd/MM/yyyy")

    '        bcappno = AppNo




    '        objWordApp.Visible = True


    '        'objWordDoc = objWordApp.Application.Documents.Open(docfilename.ToString)
    '        objWordDoc = objWordApp.Application.Documents.Add(Template:=(docfilename.ToString), NewTemplate:=False, DocumentType:=0)
    '        With objWordDoc


    '            'Retrieve the base data for this application

    '            Dim RowCount As Integer = objDT.Rows.Count
    '            'if there is not base data then no need to continue
    '            If objDt.Rows.Count <= 0 Then
    '                Exit Sub
    '            Else
    '                objDataRow = objDt.Rows.Item(0)
    '            End If


    '            'Insert CommonFields---------------------------------

    '            ' Get the common fields to be used to extract the data from the base data
    '            Dim objDRCommonFields As DataTable = GetTheCommonFields(CommonFieldsLinkQueryName, AppNo, DocType)

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

    '            ' OK TO HERE <<<<--------



    '            'Insert Attached Conditions and headings if applicable

    '            Dim objDRSTDcond As DataTable = GetConditionsAndHeadings(AppNo, DocType)


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


    '            Dim objDROneUpDcond As DataTable = GetTheCommonFields(ConditionComponentQueryName, AppNo, DocType)


    '            If objDROneUpDcond.Rows.Count > 0 Then
    '                'Loop thru the commonfields and extract the data and populate the word document

    '                For i As Integer = 0 To objDROneUpDcond.Rows.Count - 1
    '                    fieldcode = objDROneUpDcond.Rows(i).Item(1).ToString
    '                    bookcode = objDROneUpDcond.Rows(i).Item(0).ToString
    '                    .Bookmarks(bookcode).Select()
    '                    If objDataRow.Item(fieldcode).ToString <> String.Empty Or Not IsDBNull(objDataRow.Item(fieldcode)) Then
    '                        .Application.Selection.Text = objDataRow.Item(fieldcode).ToString
    '                    End If


    '                Next


    '            End If


    '            'END Insert Attached Conditions and headings-------------------------------



    '            'Insert free-format inserts for standard conditions------------------------

    '            Dim objDRFreeForm As DataTable = GetFreeFormText(AppNo, DocType)

    '            'Loop thru the commonfields and extract the data and populate the word document

    '            If objDRFreeForm.Rows.Count > 0 Then
    '                'Loop thru the commonfields and extract the data and populate the word document

    '                For i As Integer = 0 To objDRFreeForm.Rows.Count - 1
    '                    fieldcode = objDRFreeForm.Rows(i).Item(1).ToString
    '                    bookcode = objDRFreeForm.Rows(i).Item(3).ToString
    '                    Try
    '                        .Bookmarks(bookcode).Select()
    '                        If fieldcode.ToString <> String.Empty Then
    '                            .Application.Selection.Text = fieldcode
    '                        End If

    '                    Catch ex As Exception

    '                    End Try

    '                Next


    '            End If



    '            'END Insert free-format inserts for standard conditions------------------------




    '            If macroName <> String.Empty Then .Application.Run(macroName)


    '            ''If LHead = "Y" Then
    '            '.PageSetup.FirstPageTray = WORD.WdPaperTray.wdPrinterMiddleBin
    '            '.PageSetup.OtherPagesTray = WORD.WdPaperTray.wdPrinterLargeCapacityBin
    '            '.PrintOut(Background:=False, Copies:=2)


    '            ''Else
    '            ''.PrintOut(Background:=False, Copies:=2)
    '            ''End If


    '            If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString) Then _
    '                My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString)
    '            If Not My.Computer.FileSystem.DirectoryExists(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM")) Then
    '                My.Computer.FileSystem.CreateDirectory(My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM"))
    '            End If

    '            WordDocName = My.Settings.DraftDocumentsFolder & Year(Today.Date).ToString & "\" & Format(Today.Date, "MMM").ToString & "\" & docname & "_" & AppNo.Replace("/", "_") & "_DATE_" & sdate.Replace("/", "_") & "_" & TimeOfDay().ToShortTimeString.Replace(":", "_") & ".docx"


    '            .SaveAs(WordDocName.ToString, FileFormat:=WORD.WdSaveFormat.wdFormatXMLDocument)

    '            '.Close(SaveChanges:=False)

    '        End With
    '        'objWordDoc.Close(False)
    '        'objWordApp.Quit()

    '        InsertRecordIntoDraftDocs(AppNo, DocType, WordDocName, Format(Today.Date, "MMM"), Year(Today.Date))



    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, " in CreateWordDocs routine in CreateWordDocuments module ")

    '    End Try





    'End Sub


    Private Sub PrintReferralLetter(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer, ByVal DocType As String)

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument


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


            Dim strDocumentNo As String = GetNextDocumentNumber()
            Dim strEASEdocumentName As String = Replace(strDocumentNo, ".", "_") & ".pdf"
            Dim Recepient As Integer


            With My.Forms.WhoAreYouSendingMailTo
                .ShowDialog()
                Recepient = .Recepient
                .Dispose()

            End With
            With My.Forms.OutwardEaseCorro
                Select Case Recepient
                    Case 1

                        .CustName = Me.txtDAOwnersName.Text
                        .CustAddress = Me.txtDAOwnersAddress.Text & " " & txtDAOwnersTown.Text & " " & Me.txtDAOwnersPcode.Text

                    Case 2

                        .CustName = Me.txtAppName.Text
                        .CustAddress = Me.txtAppAddress.Text & " " & Me.txtAppTown.Text & " " & Me.txtAppPcode.Text


                End Select


                .FileNumber = txtFileNo.Text
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
                    '.Notes = txtLetterNotes.Text
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

    Private Sub PrintReferralLetter(ByVal objDtable As DataTable, ByVal Summary As String, ByVal reportName As String, ByVal Copies As Integer, Optional ByVal DocType As Boolean = False, Optional ByVal onepage As Boolean = False)


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

            If Not onepage Then

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
            Else

                Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
                myPrintOptions.CustomPaperSource = GetSelectedSecondPaperSource()
                With rptDocument
                    .Load(strReportPath)
                    .SetDataSource(objDtable)
                    .VerifyDatabase()
                    .PrintToPrinter(1, False, 1, 99)
                End With

                If Copies = 2 Then
                    With rptDocument
                        .PrintToPrinter(1, False, 1, 99)
                    End With

                End If

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

            If Not DocType Then
                Dim InsertDocData As New InsertDocumentData
                With InsertDocData
                    .ApplicationType = "DA"
                    .DocumentType = DocType.ToString
                    .ApplicationNo = Me.txtDANo.Text
                    .TheAuthor = MyUserId
                    .TheImageName = Replace(strDocumentNo, ".", "_")
                    '.Notes = txtLetterNotes.Text
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

    Private Sub btnReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReferral.Click
        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
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



                    Dim OwnerName As String = String.Empty
                    Dim OwnerAddress As String = String.Empty
                    Dim FileNo As String = String.Empty
                    Dim rptDocument As New ReportDocument


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        OwnerName = objDataRow.Item("DAAppName").ToString
                        OwnerAddress = objDataRow.Item("DAAppAddr").ToString & " " & objDataRow.Item("DAAppTown").ToString & " " & objDataRow.Item("DAAppPC").ToString
                        FileNo = objDataRow.Item("DAFileNo").ToString

                    End If

                    Try

                        'Pass the reportname to string variable 
                        Dim strReportPath As String = My.Settings.ReportLocation & "ReferralResponse.rpt"

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
                            .SetDataSource(objDT)
                            .VerifyDatabase()
                        End With


                        rptDocument.PrintToPrinter(1, False, 1, 1)


                    Catch ex As Exception
                        MessageBox.Show(ex.Message & " in function PrintReferralLetter")
                    Finally
                        rptDocument.Close()

                    End Try










                    'PrintOnPlainPaperOnly(objDT, "Referral Response " & Me.txtDANo.Text, "ReferralResponse.rpt", 1)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnReferral_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintRFSOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSOther.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Dim docType As Integer = 55
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim BuildType As Integer = 1
        Dim sysType As String = "DA"


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@id", SqlDbType.Int).Value = docType
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docname = objDataReader.Item("Docname").ToString
                            docfilename = objDataReader.Item("DocTemplatePath").ToString
                            MacroName = objDataReader.Item("MacroName").ToString
                            BuildType = CInt(objDataReader.Item("BuildType"))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using


                PrintAndEASEWordDocs(docType, txtDANo.Text, docname, docfilename, sysType, "Referral letter for Rural Fires Service" & Me.txtDANo.Text, MacroName)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using


        'Dim objDT As New DataTable


        'Using cn As New SqlConnection(My.Settings.connectionString)
        '    Try
        '        cn.Open()
        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnPrintRFSOther_Click routine")

        '    End Try


        '    Try

        '        Using cmd As New SqlCommand

        '            With cmd
        '                .Connection = cn
        '                .CommandType = CommandType.StoredProcedure
        '                .CommandText = "usp_rpt_RFSReferral"
        '                .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
        '            End With



        '            Using objDataReader As SqlDataReader = cmd.ExecuteReader
        '                objDT.Load(objDataReader)
        '            End Using
        '            PrintReferralLetter(objDT, "Referral letter for Rural Fires Service" & Me.txtDANo.Text, "RFSReferralDA.rpt", 1)


        '        End Using
        '         



        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnPrintRFSOther_Click routine ")
        '    End Try
        'End Using
    End Sub

    Private Sub btnPrintRFSSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintRFSSub.Click

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Dim docType As Integer = 56
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim BuildType As Integer = 1
        Dim sysType As String = "DA"


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@id", SqlDbType.Int).Value = docType
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docname = objDataReader.Item("Docname").ToString
                            docfilename = objDataReader.Item("DocTemplatePath").ToString
                            MacroName = objDataReader.Item("MacroName").ToString
                            BuildType = CInt(objDataReader.Item("BuildType"))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using


                PrintAndEASEWordDocs(docType, txtDANo.Text, docname, docfilename, sysType, "Referral letter for Rural Fires Service" & Me.txtDANo.Text, MacroName)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using



        'Dim OwnerName As String = String.Empty
        'Dim OwnerAddress As String = String.Empty
        'Dim FileNo As String = String.Empty

        'If MessageBox.Show("You are about to issue a referral letter for Rural Fires Service. OK to proceed?", "Print RFS Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        'Dim objDT As New DataTable


        'Using cn As New SqlConnection(My.Settings.connectionString)
        '    Try
        '        cn.Open()
        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnPrintRFSSub_Click routine")

        '    End Try


        '    Try

        '        Using cmd As New SqlCommand

        '            With cmd
        '                .Connection = cn
        '                .CommandType = CommandType.StoredProcedure
        '                .CommandText = "usp_rpt_RFSReferral"
        '                .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
        '            End With



        '            Using objDataReader As SqlDataReader = cmd.ExecuteReader
        '                objDT.Load(objDataReader)
        '            End Using
        '            PrintReferralLetter(objDT, "Referral letter for Rural Fires Service" & Me.txtDANo.Text, "RFSReferralSubDiv.rpt", 1)


        '        End Using
        '         



        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnPrintRFSSub_Click routine ")
        '    End Try
        'End Using
    End Sub

    Private Sub btnRTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRTA.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If MessageBox.Show("You are about to issue a referral letter for Roads and Traffic Authority. OK to proceed?", "Print RTA Referral?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim docType As Integer = 48
        Dim docname As String = String.Empty
        Dim docfilename As String = String.Empty
        Dim MacroName As String = String.Empty
        Dim BuildType As Integer = 1
        Dim sysType As String = "DA"


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@id", SqlDbType.Int).Value = 48 'RTA referral letter
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docname = objDataReader.Item("Docname").ToString
                            docfilename = objDataReader.Item("DocTemplatePath").ToString
                            MacroName = objDataReader.Item("MacroName").ToString
                            BuildType = CInt(objDataReader.Item("BuildType"))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using


                PrintAndEASEWordDocs(docType, txtDANo.Text, docname, docfilename, sysType, "Referral letter for Roads and Maritime Service" & Me.txtDANo.Text, MacroName)




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            End Try
        End Using
        'Dim objDT As New DataTable


        'Using cn As New SqlConnection(My.Settings.connectionString)
        '    Try
        '        cn.Open()
        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnRTA_Click routine")

        '    End Try


        '    Try

        '        Using cmd As New SqlCommand

        '            With cmd
        '                .Connection = cn
        '                .CommandType = CommandType.StoredProcedure
        '                .CommandText = "usp_rpt_RTAReferral"
        '                .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
        '            End With



        '            Using objDataReader As SqlDataReader = cmd.ExecuteReader
        '                objDT.Load(objDataReader)
        '            End Using
        '            PrintReferralLetter(objDT, "Referral letter for Roads and Traffic Authority" & Me.txtDANo.Text, "RTAReferral.rpt", 1)


        '        End Using
        '         



        '    Catch ex As SqlException
        '        MessageBox.Show(ex.Message, " in btnRTA_Click routine ")
        '    End Try
        'End Using
    End Sub

    Private Sub btnRemoveRefer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefer.Click


        If MessageBox.Show("Are you sure you want to remove this referral?", "Remove Referral", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Using cn As New SqlConnection(My.Settings.connectionString)
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

        LoadReferralsIntProvisionlList(txtDANo.Text)
        LoadLstIntegrated(txtDANo.Text)



        LockTheForm(pnlButtons, False)
        LockTheForm(grpMain, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        'LockTheForm(grpSepp71, False)
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

        ClearReferralData(grpMain)


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

    'Private Sub btnPrintsepp71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim OwnerName As String = String.Empty
    '    Dim OwnerAddress As String = String.Empty
    '    Dim FileNo As String = String.Empty

    '    If MessageBox.Show("You are about to issue a SEPP 71 Referral to fax to Planning NSW. OK to proceed?", "Print Sepp71 Facimile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


    '    Dim objDT As New DataTable


    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine")

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_rpt_Sepp71Refer"
    '                    .Parameters.Add("@RefID", SqlDbType.Int).Value = NZ(lblReferralID.Text)
    '                End With



    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using
    '                PrintNotesOnPlainPaperOnly(objDT, "SEPP 71 Referral to fax to PlanningNSW" & Me.txtDANo.Text, "Sepp71Referral.rpt", 1)


    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnPrintsepp71_Click routine ")
    '        End Try
    '    End Using
    'End Sub

    Private Sub cboReferralsIntProvision_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReferralsIntProvision.SelectedValueChanged

        btnAddIntegrated.Enabled = True

    End Sub

    Private Sub btnAddIntegrated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegrated.Click
        If cboReferralsIntProvision.SelectedIndex <> -1 Then
            If MessageBox.Show("Add  " & cboReferralsIntProvision.Text & " ?", "Add ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Using cn As New SqlConnection(My.Settings.connectionString)
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
                    LoadLstIntegrated(txtDANo.Text)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                cboReferralsIntProvision.SelectedIndex = -1
            End If
        End If

    End Sub

    Private Sub btnRemoveIntegated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveIntegated.Click
        If MessageBox.Show("Remove  " & Me.lstIntegrated.Text & " ?", "Remove ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.connectionString)
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
                LoadLstIntegrated(txtDANo.Text)

            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub LoadLstIntegrated(ByVal CdNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadLstIntegrated routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_ReferralsIntegratedProvision"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CdNo
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With lstIntegrated
                        .DataSource = objDT
                        .DisplayMember = "IntActName"
                        .ValueMember = "DANoId"
                        .SelectedIndex = -1
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadLstIntegrated routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadReferralsIntProvisionlList(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadReferralsIntProvisionlList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadListReferrals"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "DA"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvLoadListReferrals.DataSource = objDT
                    dgvLoadListReferrals.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadReferralsIntProvisionlList routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub ClearReferralData(ByVal Pnl As Control)

        For Each ctrl As Control In Pnl.Controls
            If TypeOf ctrl Is Windows.Forms.ComboBox Then
                Dim cb As Windows.Forms.ComboBox = DirectCast(ctrl, Windows.Forms.ComboBox)
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

        Me.lblReferralID.Text = String.Empty

    End Sub


    Private Sub btnAddPDF_Click(sender As Object, e As EventArgs) Handles btnAddPDF.Click

        Dim btn As DevExpress.XtraEditors.SimpleButton = TryCast(sender, DevExpress.XtraEditors.SimpleButton)



        If btn.Tag = "ADD" Then

            Dim OpenFileDialoge As New OpenFileDialog

            With OpenFileDialoge
                .Tag = "SELECT FILE TO INSERT"
                .Filter = "pdf files (*.pdf)|*.pdf|Image Files (*.jpg)|*.jpg"
            End With
            Dim filename As String = String.Empty
            Dim fileType As String = String.Empty

            If (OpenFileDialoge.ShowDialog = DialogResult.OK) Then
                filename = OpenFileDialoge.FileName.ToString
                fileType = IO.Path.GetExtension(filename)

                'Dim imageData As Byte() = ReadFile(filename)
                'Dim imageData As Byte() = File.ReadAllBytes(filename)

                Dim imageData As Byte()
                imageData = ReadFile(filename)



                Using cn As New SqlConnection(My.Settings.connectionString)
                    Try
                        cn.Open()
                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Me.Name)

                    End Try


                    Try

                        Using cmd As New SqlCommand

                            With cmd
                                .Connection = cn
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "usp_UPDATE_Referrals_Image"

                                .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                                .Parameters.Add("@BinaryDocument", SqlDbType.VarBinary).Value = imageData
                                .Parameters.Add("@DocumentType", SqlDbType.VarChar).Value = fileType


                                .ExecuteNonQuery()

                                btnAddPDF.Text = "View Document"
                                btnAddPDF.Tag = "VIEW"


                            End With



                        End Using



                    Catch ex As SqlException
                        MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Me.Name)

                    End Try
                End Using

            End If

        Else

            Using cn As New SqlConnection(My.Settings.connectionString)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnAddPDF_Click routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_referral_SELECT_ImageData"

                            .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)

                        End With

                        Dim objDT As New DataTable


                        Using objDataReader As SqlDataReader = cmd.ExecuteReader
                            objDT.Load(objDataReader)
                        End Using


                        If objDT.Rows.Count > 0 Then

                            Dim objDataRow As DataRow = objDT.Rows.Item(0)

                            If Not IsDBNull(objDataRow.Item("BinaryDocument")) Then

                                Dim blob As [Byte]() = DirectCast(objDataRow.Item("BinaryDocument"), [Byte]())

                                If Not blob Is Nothing Then

                                    Dim encoding As New UnicodeEncoding

                                    Dim ms As MemoryStream = New MemoryStream(blob)




                                    If objDataRow.Item("DocumentType").ToString.ToUpper = ".PDF" Then

                                        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf") Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")

                                        Using fs As FileStream = File.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")

                                            ms.WriteTo(fs)

                                        End Using

                                        Dim PdfView As New OpenDocument
                                        PdfView.OpenVisible(My.Computer.FileSystem.SpecialDirectories.Temp & "\temp.pdf")



                                        'With My.Forms.ViewerForPDF


                                        '    '.FileLocation = New MemoryStream(blob)

                                        '    .ShowDialog()

                                        '    .Dispose()

                                        'End With



                                    Else

                                        Dim myimage As Image = Image.FromStream(New IO.MemoryStream(blob))


                                        With My.Forms.ViewImage

                                            .PictureToShow = myimage

                                            .ShowDialog()

                                            .Dispose()

                                        End With

                                    End If





                                End If

                            End If

                        End If
                    End Using



                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " Then In btnAddPDF_Click routine - form " & Me.Name)

                End Try
            End Using



        End If

    End Sub


#End Region

#Region "PayMents and Refunds"


    Private Sub LoadPaymentsRecieved(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_PaymentsReceived"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvPaymentsReceived.DataSource = objDT
                    dgvPaymentsReceived.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub LoadRefundsPaid(ByVal CDno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DARefundsPaid"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDno
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvDARefundsPaid.DataSource = objDT
                    dgvDARefundsPaid.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadPaymentsRecieved routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub CalculateRefundsandPayments(ByVal dano As String)

        Dim Receipt As String = String.Empty
        Dim Refund As String = String.Empty
        Dim difference As String = String.Empty

        Using cn As New SqlConnection(My.Settings.connectionString)
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

    Private Sub btnEditPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPayment.Click
        Try


            With My.Forms.AddPayment
                .TheSystemType = "DA"
                .IndexID = CInt(dgvPaymentsReceived.CurrentRow.Cells(0).Value)
                .AppID = txtDANo.Text
                .PayId = CShort(dgvPaymentsReceived.CurrentRow.Cells(7).Value)
                .ShowDialog()
                .Dispose()
            End With

            LoadPaymentsRecieved(txtDANo.Text)
            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnAddFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFee.Click
        Try



            With My.Forms.AddPayment

                .TheSystemType = "DA"
                .IndexID = 0
                .AppID = txtDANo.Text
                .PayId = 0
                .ShowDialog()
                .Dispose()
            End With

            LoadPaymentsRecieved(txtDANo.Text)
            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnRemoveFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFee.Click


        If MessageBox.Show("Are you sure about this, remove this fee?", "Remove Fee ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvPaymentsReceived.CurrentRow.Cells(0).Value)
                        .ExecuteNonQuery()

                    End With


                End Using


                LoadPaymentsRecieved(txtDANo.Text)
                CalculateRefundsandPayments(txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveFee_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnEditRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRefund.Click
        Try

            Dim fFee As New AddRefund

            With fFee

                .TheSystemType = "DA"
                .IDindex = CInt(dgvDARefundsPaid.CurrentRow.Cells(0).Value)

                .AppID = txtDANo.Text
                .PayId = CShort(dgvDARefundsPaid.CurrentRow.Cells(6).Value)
                .ShowDialog()
                .Dispose()
            End With

            LoadRefundsPaid(txtDANo.Text)

            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub dgvPaymentsReceived_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPaymentsReceived.CellClick
        If e.RowIndex = -1 Then Exit Sub
        Me.btnEditPayment.Enabled = True
        Me.btnRemoveFee.Enabled = True
    End Sub

    Private Sub dgvDARefundsPaid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDARefundsPaid.CellClick
        If e.RowIndex = -1 Then Exit Sub
        Me.btnEditRefund.Enabled = True
        btnRemoveRefund.Enabled = True
    End Sub

    Private Sub btnAddRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRefund.Click
        Try


            With My.Forms.AddRefund

                .TheSystemType = "DA"
                .IDindex = 0
                .AppID = txtDANo.Text
                .ShowDialog()
                .Dispose()
            End With

            LoadRefundsPaid(txtDANo.Text)

            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnRemoveRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveRefund.Click

        If MessageBox.Show("Are you sure about this, remove this refund?", "Remove refund ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub



        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvDARefundsPaid.CurrentRow.Cells(0).Value)
                        .ExecuteNonQuery()

                    End With


                End Using


                LoadRefundsPaid(txtDANo.Text)

                CalculateRefundsandPayments(txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveRefund_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

#End Region

#Region "File Notes Tab"

    Private Sub RetrieveFileNotes(ByVal CDNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveFileNotes routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveFileNotes"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDNo
                        .Parameters.Add("@SYSTYPE", SqlDbType.NVarChar).Value = "DA"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvFileNotes.DataSource = objDT
                    dgvFileNotes.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveFileNotes routine - form " & Me.Name)

            End Try
        End Using



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
        Me.btnNotePrint.Enabled = True
    End Sub

    Private Sub dgvFileNotes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFileNotes.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@NOTEID", SqlDbType.Int).Value = CInt(dgvFileNotes.CurrentRow.Cells(0).Value)
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
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        If cboNotesOfficer.SelectedIndex <> -1 Then .Parameters.Add("@AUTHOR", SqlDbType.NVarChar).Value = Me.cboNotesOfficer.SelectedValue.ToString
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@REFERRED", SqlDbType.NVarChar).Value = Me.txtNotesReferredTo.Text
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveNotesData routine - form " & Me.Name)

            End Try
        End Using
        RetrieveFileNotes(txtDANo.Text)
    End Sub

    Private Sub btnNotePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNotePrint.Click

        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
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
                    PrintNotesOnPlainPaperOnly(objDT, "File note " & Me.txtDANo.Text, "FileNotes.rpt", 1)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnNotePrint_Click routine ")
            End Try
        End Using
    End Sub

#End Region

#Region "FileNumbers"

    Private Sub btnAddFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFile.Click
        If txtFile.Text <> "" Then

            If MessageBox.Show("Add file number " & txtFile.Text & " ?", "Add File", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Using cn As New SqlConnection(My.Settings.connectionString)
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
                    RetrieveListOfFileNumbers(txtDANo.Text)

                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try

                txtFile.Text = ""
            End If
        End If

    End Sub

    Private Sub btnRemoveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFile.Click

        If MessageBox.Show("Remove file number " & lstFile.Text & " ?", "Remove File", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

            Using cn As New SqlConnection(My.Settings.connectionString)
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
                RetrieveListOfFileNumbers(txtDANo.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If


    End Sub

    Private Function FileExists(ByVal sFileNumber As String, ByRef errorMessage As String) As Boolean
        ' Confirm there is text in the control.
        If sFileNumber.Length = 0 Then
            errorMessage = "File number is required"
            Return False
        End If


        Using Connection As New SqlConnection(My.Settings.connectionString)
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

    Private Sub RetrieveListOfFileNumbers(ByVal CDNo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveListOfFileNumbers routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveAAFileNumbers"

                        .Parameters.Add("@AANO", SqlDbType.NVarChar).Value = CDNo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With lstFile
                        .DataSource = objDT
                        .DisplayMember = "FId"
                        .ValueMember = "PBarcode"
                        .SelectedIndex = -1
                    End With

                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RetrieveListOfFileNumbers routine - form " & Me.Name)

            End Try
        End Using



    End Sub

#End Region

#Region "Historical Docs"

    Private Sub LoadHistoricalDocuments()
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadHistoricalDocuments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_RetrieveHistoricalDevDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.NVarChar).Value = "DA"
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    grdDocumentsList.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadHistoricalDocuments routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnSaveTheNote_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveTheNote.Click

        If MessageBox.Show("Update note?", "Add amend doc note", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)


        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DocId"))
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
            LoadHistoricalDocuments()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cboLetterType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLetterType.SelectedValueChanged
        If cboLetterType.SelectedIndex = -1 Then Exit Sub
        btnCreateNewLetter.Enabled = True
    End Sub

    Private Sub btnRemoveDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLetterType.SelectedValueChanged

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)


        Dim documentToRemove As String = myobj.Row.Item("DocumentDesc").ToString & " created " & Format(CDate(myobj.Row.Item("DateCreated")), "dd/MM/yyyy")



        If MessageBox.Show("Remove " & documentToRemove & " from the list?", "Remove this document", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim removedocument As New RemoveDocument

        With removedocument
            .DocumentID = CInt(myobj.Row.Item("DocId"))
            .DocumentToRemove = myobj.Row.Item("FileName").ToString
            .RemoveDocument()
        End With

        Try
            LoadHistoricalDocuments()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub DisplayPDFdocument()

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)


        'If dgvDocumentsList.CurrentRow.Cells(8).Value.ToString = String.Empty Then Exit Sub

        'Dim sDocname As String = dgvDocumentsList.CurrentRow.Cells(8).Value.ToString
        'Dim sMTH As String = dgvDocumentsList.CurrentRow.Cells(5).Value.ToString
        'Dim sYr As String = dgvDocumentsList.CurrentRow.Cells(6).Value.ToString
        'Dim sPDFDoc As String = String.Empty

        Dim sDocname As String = myobj.Row.Item("FileName").ToString
        Dim sMTH As String = myobj.Row.Item("DocMTH").ToString
        Dim sYr As String = myobj.Row.Item("DocYr").ToString
        Dim sPDFDoc As String = String.Empty


        If sDocname.Length <= 8 Then
            Dim YeartoCheck As String = "20" & sDocname.Substring(InStr(sDocname, "_"), 2)
            If CLng(YeartoCheck) <> CLng(Today.Year) Then
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


        'If Is64BitOperatingSystem Then

        '    If sPDFDoc <> String.Empty Then WebBrowser1.Navigate(sPDFDoc)

        'Else

        If sPDFDoc <> String.Empty Then


            Dim WRD As New OpenDocument
            WRD.OpenVisible(sPDFDoc)


            'Dim PDFviewer As New PDFviewer
            'With PDFviewer
            '    .DocumentToDisplay = sPDFDoc
            '    .ShowDialog()
            '    .Dispose()
            'End With


        End If


        'End If




    End Sub

    Private Sub btnCreateNewLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNewLetter.Click

        Dim MapMergeCompleted As Boolean = False

        If MessageBox.Show("Proceed and Create the " & Me.cboLetterType.Text & " now?", "Print Letter?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim mlist As DocumentTypeListing = CType(Me.cboLetterType.SelectedItem, DocumentTypeListing)

        If mlist.DocTypeName.ToString = "N" Then
            If Me.DACompletedDt.Text = String.Empty Then
                MessageBox.Show("Unable to proceed as these letters require Close of submission date to be completed", "Unable to Generate", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If


        Select Case mlist.DocTypeName.ToString.ToUpper
            Case "N"
                Dim fMapMerge As New DAMApMerge
                With fMapMerge
                    .DAnumber = Me.txtDANo.Text
                    .ShowDialog()
                    MapMergeCompleted = .FileGenerated
                    .Dispose()
                End With
                If Not MapMergeCompleted Then
                    MessageBox.Show("Unable to proceed as these letters require MAPmerge data from Enlighten", "Unable to Generate", MessageBoxButtons.OK)
                    Exit Sub
                Else
                    CreateLetter(mlist)
                End If

            Case "OA", "OAR", "OAW"
                CreateLetter(mlist) 'SB 20080814 Changed from CreateObjectorsAdviceLetters to print advice letters in one document


            Case Else
                CreateLetter(mlist)



        End Select


    End Sub

    Private Sub CreateLetter(ByVal mlist As DocumentTypeListing)
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


                LoadHistoricalDocuments()


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintSewer_Click routine ")
            End Try
        End Using
    End Sub



#End Region

#Region "PCA Cond Tab"
    Private Sub dgvSTDCond_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSTDCond.CellClick
        If e.ColumnIndex = -1 Then Exit Sub


        If TypeOf Me.dgvSTDCond.Columns(e.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not e.RowIndex = -1 Then


            UpdateConditionDate(1)

            LoadOneOffConditionsPriorToCCRelease(txtDANo.Text)

            LoadSTDConditionsPriorToCCRelease(txtDANo.Text)

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
                        Select Case type


                            Case 1
                                .Parameters.Add("@IDNO", SqlDbType.Int).Value = CInt(dgvSTDCond.CurrentRow.Cells(1).Value)
                            Case 2
                                .Parameters.Add("@IDNO", SqlDbType.Int).Value = CInt(Me.dgvOneOffConditions.CurrentRow.Cells(1).Value)

                        End Select

                        .Parameters.Add("@TYPE", SqlDbType.TinyInt).Value = type
                        .ExecuteNonQuery()
                    End With


                End Using

                LoadOneOffConditionsPriorToCCRelease(txtDANo.Text)
                LoadSTDConditionsPriorToCCRelease(txtDANo.Text)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateConditionDate routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub dgvOneOffConditions_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOneOffConditions.CellClick
        If e.ColumnIndex = -1 Then Exit Sub
        btnRemoveOneOffCond.Enabled = True
        btnEditCondition.Enabled = True

        If TypeOf Me.dgvOneOffConditions.Columns(e.ColumnIndex) _
            Is DataGridViewButtonColumn _
            AndAlso Not e.RowIndex = -1 Then

            UpdateConditionDate(2)

            LoadOneOffConditionsPriorToCCRelease(txtDANo.Text)

            LoadSTDConditionsPriorToCCRelease(txtDANo.Text)



        End If



    End Sub

    Private Sub LoadOneOffConditionsPriorToCCRelease(ByVal DANo As String)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOneOffConditionsPriorToCCRelease routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "dbo.usp_RetrieveOneOffCondPriorToCCRelease"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvOneOffConditions.DataSource = objDT
                    dgvOneOffConditions.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOneOffConditionsPriorToCCRelease routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadSTDConditionsPriorToCCRelease(ByVal DANo As String)
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSTDConditionsPriorToCCRelease routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrieveSTDCondPrioerToCCRelease"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvSTDCond.DataSource = objDT
                    dgvSTDCond.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSTDConditionsPriorToCCRelease routine - form " & Me.Name)

            End Try
        End Using



    End Sub
#End Region

#Region "Section68andIntDev"

    Private Sub btnEdit68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit68.Click
        'Edit Sec68 Tab
        LockTheForm(grp68, True)
        grp68.Enabled = True
        btnEdit68.Enabled = False
        Me.btnSave68.Enabled = True


    End Sub

    Private Sub btnSave68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave68.Click
        LockTheForm(grp68, False)
        btnSave68.Enabled = False
        btnEdit68.Enabled = True

        SaveSection68()

    End Sub

    Private Sub SaveSection68()
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveSection68 routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAUPDATE_Section68"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@SEC681", SqlDbType.Int).Value = Me.chkSec68q1.CheckState
                        .Parameters.Add("@SEC682", SqlDbType.Int).Value = Me.chkSec68q2.CheckState
                        .Parameters.Add("@SEC683", SqlDbType.Int).Value = Me.chkSec68q3.CheckState
                        .Parameters.Add("@SEC684", SqlDbType.Int).Value = Me.chkSec68q4.CheckState
                        .Parameters.Add("@SEC685", SqlDbType.Int).Value = Me.chkSec68q5.CheckState
                        .Parameters.Add("@SEC686", SqlDbType.Int).Value = Me.chkSec68q6.CheckState
                        .Parameters.Add("@SEC687", SqlDbType.Int).Value = Me.chkSec68q7.CheckState
                        .ExecuteNonQuery()

                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveSection68 routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    'Private Sub btnSaveIntDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveIntDev

    '    btnAddIntDev.Enabled = True
    '    btnRemoveIntDev.Enabled = False

    '    Using cn As New SqlConnection(My.Settings.DataConnection)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnSaveIntDev_Click routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_RemoveIntDevFromGridData"

    '                    .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvIntDev.CurrentRow.Cells(0).Value)
    '                    .ExecuteNonQuery()

    '                End With



    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in btnSaveIntDev_Click routine - form " & Me.Name)

    '        End Try
    '    End Using

    '    LoadIntDevCombo()
    '    loadIntDevGrid(txtDANo.Text)


    'End Sub

    Private Sub cboIntDevActs_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIntDevActs.SelectedValueChanged
        btnAddIntDev.Enabled = cboIntDevActs.SelectedIndex <> -1
    End Sub

    Private Sub dgvIntDev_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvIntDev.CellClick
        If e.RowIndex = -1 Then Exit Sub
        btnRemoveIntDev.Enabled = dgvIntDev.CurrentRow.Cells(0).Value.ToString <> String.Empty
        btnSetIntDevDate.Enabled = dgvIntDev.CurrentRow.Cells(0).Value.ToString <> String.Empty

    End Sub

    Private Sub btnSetIntDevDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetIntDevDate.Click
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .GetTheDate = Today.Date
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With

        If TheNewDate <> String.Empty Then

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
                            .CommandText = "usp_UPDATE_IntDevActDate"

                            .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(dgvIntDev.CurrentRow.Cells(0).Value)
                            .Parameters.Add("@ACTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(TheNewDate), "dd/MM/yyyy")
                            .ExecuteNonQuery()

                        End With


                    End Using




                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

                End Try
            End Using

            loadIntDevGrid(txtDANo.Text)

        End If

    End Sub

    Private Sub btnAddIntDev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddIntDev.Click

        If MessageBox.Show("Add " & cboIntDevActs.Text & " to list (Y/N)", "Add Act", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            cboIntDevActs.SelectedIndex = -1
            mskDateAct.EditValue = Nothing

            Exit Sub

        End If





        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddIntDev_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_IntDevAct"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@ACT", SqlDbType.NVarChar).Value = cboIntDevActs.Text
                        If Not String.IsNullOrEmpty(mskDateAct.Text) Then .Parameters.Add("@ACTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(mskDateAct.EditValue), "dd/MM/yyyy")
                        .ExecuteNonQuery()

                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddIntDev_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadIntDevCombo()

        cboIntDevActs.SelectedIndex = -1
        mskDateAct.EditValue = Nothing

        btnAddIntDev.Enabled = False
        btnRemoveIntDev.Enabled = False
        loadIntDevGrid(txtDANo.Text)


    End Sub

    Private Sub btnMaitList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaitList.Click
        ' TODO: Write code to maintain list 
    End Sub

    Private Sub LoadIntDevCombo()

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadIntDevCombo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadIntegratedLookUpTable"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                    With cboIntDevActs
                        .DataSource = objDT
                        .DisplayMember = "DescriptionOfAct"
                        .ValueMember = "id"
                        .SelectedIndex = -1
                    End With

                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadIntDevCombo routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub loadIntDevGrid(ByVal DANo As String)

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in loadIntDevGrid routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_IntDevGridData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvIntDev.DataSource = objDT
                    dgvIntDev.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in loadIntDevGrid routine - form " & Me.Name)

            End Try
        End Using



    End Sub

#End Region

#Region "Status"
    Private Sub btnEditStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStatus.Click
        LockTheForm(grpAssessment, True)
        LockTheForm(grpDetermination, True)
        LockTheForm(grpNotification, True)
        cboAdvertSignDepot.Enabled = True
        txtAdvertSignIntDetails.ReadOnly = False
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
        txtAdvertSignIntDetails.ReadOnly = True
        cboAdvertSignDepot.Enabled = False
        rbNotifyAdvert.Enabled = False
        Me.rbNone.Enabled = False
        Me.rbNotify.Enabled = False
        Me.btnEditStatus.Enabled = True
        Me.btnSaveStatus.Enabled = False
        SaveTheStatus()
    End Sub

    Private Sub btnMapMerge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMapMerge.Click
        Dim fMapMerge As New DAMApMerge
        With fMapMerge
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub btnPrintAdvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAdvert.Click
        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AdvertSigns"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using


                Dim fViewer As New AddAdvertPrinter
                With fViewer
                    .objDataTable = objDT
                    .ReportName = "test_advertsign.rpt"
                    .ShowDialog()
                    .Dispose()
                End With

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintAdvNotice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintAdvNotice.Click
        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty
        Dim rptDocument As New ReportDocument



        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine")

            End Try

            Dim strReportPath As String = My.Settings.ReportLocation & "NoticeOfAdvertising.rpt"

            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AdvertSigns"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With rptDocument
                        .Load(strReportPath)
                        .SetDataSource(objDT)
                        .VerifyDatabase()
                        .PrintToPrinter(1, False, 1, 99)
                    End With
                    'PrintButDontEase(objDT, "NoticeOfAdvertising.rpt")


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnDesignated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesignated.Click
        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AdvertSigns"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using


                Dim fViewer As New AddAdvertPrinter
                With fViewer
                    .objDataTable = objDT
                    .ReportName = "advertsign_designated.rpt"
                    .ShowDialog()
                    .Dispose()
                End With

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnDesignIntegr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesignIntegr.Click

        UpdateIntegratedSignText()

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_AdvertSigns"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using


                Dim fViewer As New AddAdvertPrinter
                With fViewer
                    .objDataTable = objDT
                    .ReportName = "advertsign_designatedAndIntegrated.rpt"
                    .ShowDialog()
                    .Dispose()
                End With

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub UpdateIntegratedSignText()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateIntegratedSignText routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_AdvertSignforIntegratedDevelopment"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@ADVERTSIGN", SqlDbType.NText).Value = txtAdvertSignIntDetails.Text
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in UpdateIntegratedSignText routine - form " & Me.Name)

            End Try
        End Using



    End Sub

#End Region

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
        Me.btnEditVariation.Enabled = True
        Me.btnSaveVariation.Enabled = False
        Me.btnAddVariation.Enabled = True
        Me.btneditVariationResponse.Enabled = True
        Me.btnSaveVariationResponse.Enabled = False
        btnRemoveVariation.Enabled = True

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
                        If variationDecisionDate.Text <> String.Empty Then .Parameters.Add("@DATE", SqlDbType.SmallDateTime).Value = CDate(variationDecisionDate.EditValue)
                        If Me.cboVariationResult.SelectedIndex <> -1 Then .Parameters.Add("@RESULT", SqlDbType.VarChar).Value = Me.cboVariationResult.SelectedValue.ToString
                        .Parameters.Add("@AUTHORITY", SqlDbType.SmallInt).Value = CInt(Me.cboVariationAuthority.SelectedValue)
                        .ExecuteNonQuery()
                    End With

                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadVariationGrid(txtDANo.Text)

        btnSaveVariationResponse.Enabled = False
        btneditVariationResponse.Enabled = True
        lblID.Text = "0"

        Me.cboVariationResult.SelectedIndex = -1
        Me.cboVariationAuthority.SelectedIndex = -1
        Me.variationDecisionDate.Text = String.Empty
        LockVariationResponseFields(True)

    End Sub

    Private Sub cboSTDconditions_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSTDconditions.KeyUp
        If e.KeyCode = Keys.Enter Then
            InsertNewCondition()
            cboSTDconditions.SelectedIndex = -1
        End If

    End Sub

    Private Sub btnAddNewVariationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewVariationType.Click

        With My.Forms.MaintainVariations

            .ShowDialog()

            .Dispose()


        End With

        LoadCombo(cboVariationType, "usp_LoadUpVariationList")
        LoadCombo(cboSubmissionType, "usp_LoadUpVariationList")

    End Sub

    Private Sub btnAddVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddVariation.Click
        lblID.Text = "0"
        Me.cboVariationType.SelectedIndex = -1
        txtVariationDetails.Text = String.Empty
        'Me.cboVariationResult.SelectedIndex = -1
        'Me.cboVariationAuthority.SelectedIndex = -1
        'Me.variationDecisionDate.Text = String.Empty

        lockVariationFields(False)
    End Sub

    Private Sub lockVariationFields(ByVal lock As Boolean)
        Me.cboVariationType.Enabled = Not lock
        txtVariationDetails.ReadOnly = lock
        btnSaveVariation.Enabled = Not lock

    End Sub

    Private Sub LockVariationResponseFields(ByVal lock As Boolean)
        Me.cboVariationResult.Enabled = Not lock
        Me.cboVariationAuthority.Enabled = Not lock
        Me.variationDecisionDate.ReadOnly = True

    End Sub

    Private Sub btnSaveVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariation.Click
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
                        .CommandText = "usp_InsertUpdateVariationRecord"
                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(lblID.Text)
                        .Parameters.Add("@DETAIL", SqlDbType.VarChar).Value = Me.txtVariationDetails.Text
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                        .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboVariationType.SelectedValue)
                        .ExecuteNonQuery()
                    End With

                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveVariation_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        LoadVariationGrid(txtDANo.Text)

        btnSaveVariation.Enabled = False
        btnEditVariation.Enabled = True
        btnAddVariation.Enabled = True
        lblID.Text = "0"

        Me.cboVariationType.SelectedIndex = -1
        txtVariationDetails.Text = String.Empty
        lockVariationFields(True)

    End Sub

    Private Sub btnEditVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditVariation.Click
        lockVariationFields(False)

    End Sub

    Private Sub btnRemoveVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveVariation.Click

        If MessageBox.Show("Are you sure you want to remove this variation?", "Remove variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub



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
                        .CommandText = "usp_DELETE_Variations_Remove"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = dgvVariations.CurrentRow.Cells(0).Value.ToString
                        .ExecuteNonQuery()
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        LoadVariationGrid(txtDANo.Text)




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


                    LoadUpConditionsList(txtDANo.Text)




                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddCondition_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub btnEditCondition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCondition.Click

        With My.Forms.InsertOneUpCondition
            .ID = CInt(dgvOneUpConditions.CurrentRow.Cells(2).Value)
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()

        End With

        LoadUpConditionsList(txtDANo.Text)


    End Sub

    Private Sub LoadVariationGrid(ByVal DANo As String)

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
                        .CommandText = "usp_RetrieveVariationsForDA"

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
                        If objDataRow.Item("SubGiftDonationYN") Is DBNull.Value Then
                        Else
                            Me.chkSubGift.Checked = objDataRow.Item("SubGiftDonationYN")
                        End If
                        btnEditSub.Enabled = True

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
        'Me.SubRecdDat = String.Empty
        Me.chkSubGift.Checked = False
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
        Me.SubRecdDate.ReadOnly = Lock
        Me.btnSaveSub.Enabled = Not Lock
        Me.chkSubGift.Enabled = Not Lock

    End Sub

    Private Sub btnAddSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddSub.Click
        ClearObjections()
        LockSubmissionFields(False)
        btnEditSub.Enabled = False
        btnSaveSub.Enabled = True
        btnAddSub.Enabled = False
        EditMode = False
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
                    PrintReferralLetter(objDT, "Submission Acknowledgement" & Me.txtDANo.Text, "ObjectorsAckdgmt.rpt", 2, "OAK")
                    'CreateWordDocs(docType, Me.txtDANo.Text, docname, docfilename, sysType, MacroName)


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAckSub_Click routine ")
            End Try
        End Using

    End Sub

    Private Sub btnEditSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditSub.Click
        LockSubmissionFields(False)
        btnEditSub.Enabled = False
        btnSaveSub.Enabled = True
        btnAddSub.Enabled = True
        EditMode = True
    End Sub

    Private Sub btnSaveSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveSub.Click
        If SubmissionNotComplete() Then Exit Sub


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
                        .Parameters.Add("@TYPE", SqlDbType.VarChar).Value = cboSubmissionType.SelectedValue.ToString 'txtAuthorName.Text
                        .Parameters.Add("@TOWN", SqlDbType.VarChar).Value = Me.txtAuthorTown.Text
                        .Parameters.Add("@GIFTDONATION", SqlDbType.Bit).Value = Me.chkSubGift.CheckState
                        .ExecuteNonQuery()
                    End With

                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveSub_Click routine - form " & Me.Name)

            End Try
        End Using
        'reload file numbers
        LoadSubmissionsGrid(txtDANo.Text)

        If Not EditMode Then
            If SendEmailAdvice() Then MessageBox.Show("Alert e-mail sent to " & txtOfficer.Text, "E-Mail Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        btnSaveSub.Enabled = False
        btnEditSub.Enabled = True
        btnAddSub.Enabled = True
        ClearObjections()
        LockSubmissionFields(True)



        EditMode = False

    End Sub


    Private Sub LoadSubmissionsGrid(ByVal DAno As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSubmissionsGrid routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SubmissionandObjections"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvSubmissionandObjections.DataSource = objDT
                    dgvSubmissionandObjections.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSubmissionsGrid routine - form " & Me.Name)

            End Try
        End Using



    End Sub


#End Region


#Region "Add Property"

    Private Sub btnAddPIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPIN.Click
        Dim NewPIN As Integer = 0
        With LIMESsearch
            .ShowDialog()
            NewPIN = .PIN
            .Dispose()
        End With

        If NewPIN = 0 Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddPIN_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertNewPropertyNo"
                        .Parameters.Add("@DANUM", SqlDbType.VarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@PIN", SqlDbType.Int).Value = NewPIN
                        .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"
                        .ExecuteNonQuery()
                    End With


                End Using


                'reload file numbers
                Try
                    LoadListOfPINS(txtDANo.Text)

                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddPIN_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnRemovePIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemovePIN.Click
        If MessageBox.Show("Remove Property number " & lstPINs.Text & " ?", "Remove PIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Using cn As New SqlConnection(My.Settings.connectionString)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemovePIN_Click routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_RemoveDAPin"
                            .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                            .Parameters.Add("@PIN", SqlDbType.Int).Value = CInt(lstPINs.SelectedValue)
                            .Parameters.Add("@SYSID", SqlDbType.NVarChar).Value = "DA"
                            .ExecuteNonQuery()
                        End With

                    End Using

                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnRemovePIN_Click routine - form " & Me.Name)

                End Try
            End Using

            'reload file numbers
            Try
                LoadListOfPINS(txtDANo.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnRetrieveProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieveProperty.Click
        If Me.lstPINs.Text = String.Empty Then Exit Sub

        Using cn As New SqlConnection(My.Settings.cnLIMES)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrieveProperty_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RatesData"

                        .Parameters.Add("@PIN", SqlDbType.Int).Value = CInt(lstPINs.Text)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.txtLot.Text = objDataRow.Item("Lotnum").ToString
                        Me.txtDP.Text = objDataRow.Item("DP").ToString
                        Me.txtSection.Text = objDataRow.Item("Sec").ToString
                        Me.txtStreetNo.Text = objDataRow.Item("HOFR").ToString
                        Me.txtStreetName.Text = objDataRow.Item("Street Name").ToString
                        Me.cboDAlocalityCode.SelectedValue = CInt(objDataRow.Item("LOC"))
                        Me.txtDAOwnersName.Text = objDataRow.Item("Name").ToString
                        Me.txtDAOwnersAddress.Text = objDataRow.Item("Add1").ToString
                        Me.txtDAOwnersTown.Text = objDataRow.Item("Addrs").ToString
                        Me.txtDAOwnersPcode.Text = objDataRow.Item("POST").ToString


                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrieveProperty_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub


#End Region


#Region "Main Application"

    Private Sub btnKeep2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnKeep2.Click
        Dim objStreamWriter As StreamWriter

        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp", False)
        'Write a line of text.
        objStreamWriter.WriteLine(Me.txtDAOwnersName.Text)
        objStreamWriter.WriteLine(Me.txtDAOwnersAddress.Text)
        objStreamWriter.WriteLine(Me.txtDAOwnersTown.Text)
        objStreamWriter.WriteLine(Me.txtDAOwnersPcode.Text)
        objStreamWriter.WriteLine(Me.txtDAOwnersPhone.Text)


        'Close the file.
        objStreamWriter.Close()
    End Sub

    Private Sub btnKeep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeep1.Click



        Dim objStreamWriter As StreamWriter

        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp", False)
        'Write a line of text.
        objStreamWriter.WriteLine(Me.txtAppName.Text)
        objStreamWriter.WriteLine(Me.txtAppAddress.Text)
        objStreamWriter.WriteLine(Me.txtAppTown.Text)
        objStreamWriter.WriteLine(Me.txtAppPcode.Text)
        objStreamWriter.WriteLine(Me.txtAppPhone.Text)


        'Close the file.
        objStreamWriter.Close()


    End Sub

    Private Sub btnUse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUse1.Click
        Dim objStreamReader As StreamReader
        Dim strLine As String
        objStreamReader = New StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp")

        strLine = objStreamReader.ReadLine
        txtAppName.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppAddress.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppTown.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppPcode.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppPhone.Text = strLine


        objStreamReader.Close()



    End Sub

    Private Sub btnUse2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUse2.Click

        Dim objStreamReader As StreamReader
        Dim strLine As String
        objStreamReader = New StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp")

        strLine = objStreamReader.ReadLine
        txtDAOwnersName.Text = strLine

        strLine = objStreamReader.ReadLine
        txtDAOwnersAddress.Text = strLine

        strLine = objStreamReader.ReadLine
        txtDAOwnersTown.Text = strLine

        strLine = objStreamReader.ReadLine
        txtDAOwnersPcode.Text = strLine

        strLine = objStreamReader.ReadLine
        txtDAOwnersPhone.Text = strLine


        objStreamReader.Close()


    End Sub
    Private Sub mnuPageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPageSetup.Click
        With My.Forms.PageSetup
            .ShowDialog()
            bTrayIsLoaded = .PageHasbeenSet
            .Dispose()
        End With

    End Sub

    Private Sub cboSearchType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboSearchType.KeyPress
        KeyPressSendTab(e)
    End Sub

    Private Sub cboSearchType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchType.SelectedIndexChanged
        grpSearch.Visible = cboSearchType.Text = "Development Type"
        mskStartDate.Text = Format(DateAdd(DateInterval.Year, -1, Today.Date), "dd/MM/yyyy")
        mskEndDate.Text = Format(Today.Date, "dd/MM/yyyy")
        txtSearch.Visible = cboSearchType.Text <> "Development Type"
        Me.txtSearch.Focus()
    End Sub

    Public Sub FindApplicationsData()
        Dim Search As Integer

        If cboSearchType.Text.ToUpper.Trim = "DA NUMBER" Then
            PopulateForm(txtSearch.Text)
            Exit Sub

        End If


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try


            Try
                Dim objDT As New DataTable

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DAsearch"

                        .Parameters.Add("@SEARCHTYPE", SqlDbType.Int)
                        .Parameters.Add("@SEARCHFOR", SqlDbType.NVarChar)


                        Select Case cboSearchType.Text.ToUpper.Trim

                            Case "FILE NO"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iFILENO
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iFILENO

                            Case "APPLICANT  NAME"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iNAME
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iNAME

                            Case "OWNERS NAME"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iOWNERNAME
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iOWNERNAME

                            Case "PIN"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iPIN
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iPIN

                            Case "APPLICANT ADDRESS"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iADDRESS
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iADDRESS

                            Case "PROPERTY ADDRESS"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iPROPADDRESS
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iPROPADDRESS

                            Case "CONSTRUCTION CERTIFICATE"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iCC
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iCC

                            Case "DESCRIPTION"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iDESC
                                .Parameters("@SEARCHFOR").Value = Me.txtSearch.Text
                                Search = iDESC

                            Case "DEVELOPMENT TYPE"
                                ' Set command properties
                                .Parameters("@SEARCHTYPE").Value = iTYPE
                                .Parameters("@SEARCHFOR").Value = cboSearch.SelectedValue.ToString
                                .Parameters.Add("@STARTDATE", SqlDbType.SmallDateTime).Value = Format(CDate(mskStartDate.EditValue), "dd/MM/yyyy")
                                .Parameters.Add("@ENDDATE", SqlDbType.SmallDateTime).Value = Format(CDate(mskEndDate.EditValue), "dd/MM/yyyy")
                                Search = iTYPE
                            Case Else : Exit Sub
                        End Select

                        Using objDataReader As SqlDataReader = .ExecuteReader
                            objDT.Load(objDataReader)
                        End Using

                    End With


                    Dim RowCount As Integer = objDT.Rows.Count


                    Select Case RowCount
                        Case 0
                            MessageBox.Show("Records matching this criteria were not found...", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case 1

                            Dim objDataRow As DataRow = objDT.Rows.Item(0)

                            PopulateForm(objDataRow.Item("DANo").ToString)

                        Case Else

                            With My.Forms.SearchResults
                                .DataSet = objDT
                                .ShowDialog()
                            End With


                    End Select


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnAssignOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignOfficer.Click
        With My.Forms.AssignOfficerList
            .AppNumber = txtDANo.Text
            .SysRef = "DA"
            .ShowDialog()
            If .Officer <> String.Empty Then txtOfficer.Text = .Officer
            .Dispose()
        End With
    End Sub

    Private Sub btnViewOfficers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewOfficers.Click
        With My.Forms.AssignedOfficers
            .AppNo = txtDANo.Text
            .sysRef = "DA"
            .ShowDialog()
            .Dispose()

        End With
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

    Public Sub PopulateForm(ByVal DANo As String)

        LoadingForm = True

        CheckIfDataChanged()


        ClearControls(pnlDisplayFees)
        ClearControls(pnlDisplayReferrals)
        ClearControls(pnlDisplayAssociatedApps)
        ClearControls(pnlDisplaySect68IntDev)
        ClearControls(pnlDisplayFileNotes)
        ClearControls(pnlDisplayDocs)
        ClearControls(pnlDisplayBuildLetters)
        ClearControls(pnlDisplayStatus)
        ClearControls(pnlDisplaySubmisions)
        ClearControls(pnlDisplayVariations)
        ClearControls(pnlDisplayPCAconditions)





        btnSaveDA.Enabled = False
        btnSave68.Enabled = False
        btnRemoveIntDev.Enabled = False
        btnSaveStatus.Enabled = False

        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PopulateForm routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DevelopmentData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)
                        'Header data
                        txtDANo.Text = objDataRow.Item("DANo").ToString
                        lblapplicationNo.Text = txtDANo.Text

                        txtCCno.Text = objDataRow.Item("CCNo").ToString
                        txtFileNo.Text = objDataRow.Item("DAFileNo").ToString

                        If Not IsDBNull(objDataRow.Item("DAAppTypeId")) Then
                            cboAppType.SelectedValue = CInt(objDataRow.Item("DAAppTypeId"))

                        Else
                            cboAppType.SelectedIndex = -1
                        End If


                        cboSector.SelectedValue = objDataRow.Item("Sector").ToString

                        If Not IsDBNull(objDataRow.Item("TypeBldgCode")) Then

                            cboBuildingType.SelectedValue = CInt(objDataRow.Item("TypeBldgCode"))


                        End If


                        ConsentPlanNumberTextBox.Text = objDataRow.Item("ConsentPlanNumber").ToString

                        If Not IsDBNull(objDataRow.Item("DAOfficerId")) Then
                            lblOfficer.Tag = objDataRow.Item("DAOfficerId").ToString

                        Else
                            lblOfficer.Tag = String.Empty
                        End If

                        txtOfficer.Text = objDataRow.Item("Officer").ToString
                        OfficerTextBox.Text = objDataRow.Item("Officer").ToString

                        txtDADecision.Text = objDataRow.Item("DADecision").ToString

                        chkSec94.Checked = CBool(objDataRow.Item("Sec94YN"))
                        txtAppName.Text = objDataRow.Item("DAAppName").ToString
                        txtAppAddress.Text = objDataRow.Item("DAAppAddr").ToString
                        txtAppTown.Text = objDataRow.Item("DAAppTown").ToString
                        txtAppPcode.Text = objDataRow.Item("DAAppPC").ToString
                        txtAppPhone.Text = objDataRow.Item("DAAppPhone").ToString
                        txtAppemail.Text = objDataRow.Item("DAAppEmail").ToString

                        'Property data
                        txtLot.Text = objDataRow.Item("DALot").ToString
                        txtDP.Text = objDataRow.Item("DADP").ToString
                        txtSection.Text = objDataRow.Item("DASection").ToString
                        Me.txtStreetNo.Text = objDataRow.Item("DAStreetNo").ToString
                        txtStreetName.Text = objDataRow.Item("DAStreet").ToString


                        If Not IsDBNull(objDataRow.Item("DALocalityCodeId")) Then
                            cboDAlocalityCode.SelectedValue = objDataRow.Item("DALocalityCodeId").ToString

                        Else
                            cboDAlocalityCode.SelectedIndex = -1
                        End If

                        btnGoogle.Enabled = True
                        btnEnlighten.Enabled = True

                        txtDAOwnersName.Text = objDataRow.Item("DAOwnersName").ToString
                        txtDAOwnersAddress.Text = objDataRow.Item("DAOwnersPAddr").ToString
                        txtDAOwnersTown.Text = objDataRow.Item("DAOwnersTown").ToString
                        txtDAOwnersPcode.Text = objDataRow.Item("DAOwnersPC").ToString
                        txtDAOwnersPhone.Text = objDataRow.Item("DAOwnersPhone").ToString
                        txtArea.Text = objDataRow.Item("DAArea").ToString
                        cboAreaType.SelectedValue = objDataRow.Item("DAAreaUnit").ToString
                        cboDACensusCode.SelectedValue = objDataRow.Item("DACensusCode").ToString
                        txtBASIXCertNo.Text = objDataRow.Item("BasixCertNo").ToString
                        txtBASIXRcptNo.Text = objDataRow.Item("BasixReceiptNo").ToString
                        chkBASIXRecd.Checked = CBool(objDataRow.Item("BasixReceived"))
                        txtBASIXthermal.Text = objDataRow.Item("BasixThermal").ToString
                        txtBASIXenergy.Text = objDataRow.Item("BasixEnergy").ToString
                        txtBASIXwater.Text = objDataRow.Item("BasixWater").ToString


                        'Description
                        If Not IsDBNull(objDataRow.Item("DADesc1")) Then chkDesc1.Checked = CBool(objDataRow.Item("DADesc1"))
                        If Not IsDBNull(objDataRow.Item("DADesc2")) Then chkDADesc2.Checked = CBool(objDataRow.Item("DADesc2"))
                        If Not IsDBNull(objDataRow.Item("DADesc3")) Then chkDADesc3.Checked = CBool(objDataRow.Item("DADesc3"))
                        If Not IsDBNull(objDataRow.Item("DADesc4")) Then chkDADesc4.Checked = CBool(objDataRow.Item("DADesc4"))
                        If Not IsDBNull(objDataRow.Item("DADesc5")) Then chkDADesc5.Checked = CBool(objDataRow.Item("DADesc5"))
                        If Not IsDBNull(objDataRow.Item("DADesc6")) Then chkDADesc6.Checked = CBool(objDataRow.Item("DADesc6"))
                        If Not IsDBNull(objDataRow.Item("DADesc7")) Then chkDADesc7.Checked = CBool(objDataRow.Item("DADesc7"))
                        Me.chkDADesc8.Checked = CBool(objDataRow.Item("DADesc8"))
                        If Not IsDBNull(objDataRow.Item("GiftDonationYN")) Then chkGiftDonation.Checked = CBool(objDataRow.Item("GiftDonationYN"))

                        If Not IsDBNull(objDataRow.Item("DADevTypeId")) Then




                            cboDevType.Text = objDataRow.Item("DevType").ToString

                        Else
                            cboDevType.SelectedIndex = -1
                        End If


                        Dim mlist As DevelopmentTypeList = CType(Me.cboDevType.SelectedItem, DevelopmentTypeList)

                        If Not mlist Is Nothing Then

                            nudDwellings.Visible = mlist.IsReport
                            lblNoDwellings.Visible = mlist.IsReport


                            nudDwellings.Value = CType(objDataRow.Item("NumberOfDwellings"), Integer)
                        Else

                            nudDwellings.Visible = False
                            lblNoDwellings.Visible = False


                        End If

                        If Not IsDBNull(objDataRow.Item("DADevUseId")) Then
                            cboDevUse.SelectedValue = objDataRow.Item("DADevUseId").ToString

                        Else
                            cboDevUse.SelectedIndex = -1
                        End If


                        If Not IsDBNull(objDataRow.Item("IntDevYN")) Then
                            cboIntDevYN.SelectedValue = objDataRow.Item("IntDevYN").ToString

                        Else
                            cboIntDevYN.SelectedIndex = -1
                        End If


                        If Not IsDBNull(objDataRow.Item("DesignatedYN")) Then
                            cboDesignatedYN.SelectedValue = objDataRow.Item("DesignatedYN").ToString

                        Else
                            cboDesignatedYN.SelectedIndex = -1
                        End If

                        txtDADesc.Text = objDataRow.Item("DADesc").ToString
                        txtModDesc.Text = objDataRow.Item("ModDesc").ToString

                        txtCurrentLandUse.Text = objDataRow.Item("CurrentLandUse").ToString

                        If Not IsDBNull(objDataRow.Item("DAEstCost")) Then _
                        txtDAestCost.Text = "$" & Format(objDataRow.Item("DAEstCost"), "#,###,##0")

                        txtDAFloor.Text = objDataRow.Item("DAFloor").ToString
                        If Not IsDBNull(objDataRow.Item("DAConsentType")) Then
                            cboConsentType.SelectedValue = objDataRow.Item("DAConsentType").ToString

                        Else
                            cboConsentType.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DAType1Id")) Then
                            cboDAtype1.SelectedValue = objDataRow.Item("DAType1Id").ToString

                        Else
                            cboDAtype1.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DAType2Id")) Then
                            cboDAType2.SelectedValue = objDataRow.Item("DAType2Id").ToString

                        Else
                            cboDAType2.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DAType3Id")) Then
                            cboDAtype3.SelectedValue = objDataRow.Item("DAType3Id").ToString

                        Else
                            cboDAtype3.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DAClassification")) Then
                            cboDAClass.SelectedValue = objDataRow.Item("DAClassification").ToString

                        Else
                            cboDAClass.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DAClassification1")) Then
                            cboDAClass1.SelectedValue = objDataRow.Item("DAClassification1").ToString

                        Else
                            cboDAClass1.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DAClassification2")) Then
                            cboDAClass2.SelectedValue = objDataRow.Item("DAClassification2").ToString

                        Else
                            cboDAClass2.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DAClassification3")) Then
                            cboDAClass3.SelectedValue = objDataRow.Item("DAClassification3").ToString

                        Else
                            cboDAClass3.SelectedIndex = -1
                        End If



                        'Section68
                        chkSec68q1.Checked = CBool(objDataRow.Item("Sec68q1"))
                        chkSec68q2.Checked = CBool(objDataRow.Item("Sec68q2"))
                        chkSec68q3.Checked = CBool(objDataRow.Item("Sec68q3"))
                        chkSec68q4.Checked = CBool(objDataRow.Item("Sec68q4"))
                        chkSec68q5.Checked = CBool(objDataRow.Item("Sec68q5"))
                        chkSec68q6.Checked = CBool(objDataRow.Item("Sec68q6"))
                        chkSec68q7.Checked = CBool(objDataRow.Item("Sec68q7"))


                        'Status
                        If Not IsDBNull(objDataRow.Item("DADecisionId")) Then
                            cboDADecisionId.SelectedValue = CInt(objDataRow.Item("DADecisionId"))

                        Else
                            cboDADecisionId.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("DARegoDt")) Then dtRego.Text = Format(CDate(objDataRow.Item("DARegoDt")), "dd/MM/yyyy")
                        If Not IsDBNull(objDataRow.Item("DAToPlannerDt")) Then DAToPlannerDt.EditValue = CDate(objDataRow.Item("DAToPlannerDt"))
                        If Not IsDBNull(objDataRow.Item("DASiteInspectedDt")) Then DASiteInspectedDt.EditValue = CDate(objDataRow.Item("DASiteInspectedDt"))
                        If Not IsDBNull(objDataRow.Item("PreAssessCompleteDate")) Then PreAssessCompleteDate.EditValue = CDate(objDataRow.Item("PreAssessCompleteDate"))
                        If Not IsDBNull(objDataRow.Item("RefToPlanCom")) Then RefToPlanCom.EditValue = CDate(objDataRow.Item("RefToPlanCom"))
                        If Not IsDBNull(objDataRow.Item("DAToTypingDt")) Then DAToTypingDt.EditValue = CDate(objDataRow.Item("DAToTypingDt"))
                        If Not IsDBNull(objDataRow.Item("DADetermDt")) Then DADetermDt.EditValue = CDate(objDataRow.Item("DADetermDt"))
                        If Not IsDBNull(objDataRow.Item("DAAppNotDt")) Then DAAppNotDt.EditValue = CDate(objDataRow.Item("DAAppNotDt"))
                        If Not IsDBNull(objDataRow.Item("ConsentPostedDate")) Then ConsentPostedDate.EditValue = CDate(objDataRow.Item("ConsentPostedDate"))
                        If Not IsDBNull(objDataRow.Item("DAFreeTreeDt")) Then DAFreeTreeDt.EditValue = CDate(objDataRow.Item("DAFreeTreeDt"))
                        If Not IsDBNull(objDataRow.Item("DAConsentPubDt")) Then DAConsentPubDt.EditValue = CDate(objDataRow.Item("DAConsentPubDt"))
                        If Not IsDBNull(objDataRow.Item("DAOccDt")) Then DAOccDt.EditValue = CDate(objDataRow.Item("DAOccDt"))
                        If Not IsDBNull(objDataRow.Item("DAPermExDt")) Then DAPermExDt.EditValue = CDate(objDataRow.Item("DAPermExDt"))
                        If Not IsDBNull(objDataRow.Item("DAAdvisedDt")) Then DAAdvisedDt.EditValue = CDate(objDataRow.Item("DAAdvisedDt"))
                        If Not IsDBNull(objDataRow.Item("DACommDt")) Then DACommDt.EditValue = CDate(objDataRow.Item("DACommDt"))
                        If Not IsDBNull(objDataRow.Item("DACompletedDt")) Then
                            DACompletedDt.EditValue = CDate(objDataRow.Item("DACompletedDt"))
                            DACompletedDtLabel2.Text = Format(CDate(objDataRow.Item("DACompletedDt")), "dd/MM/yyyy")
                        End If

                        chkAPZYesNo.Checked = CBool(objDataRow.Item("APZYesNo"))
                        txtProgressComment.Text = objDataRow.Item("ProgressComment").ToString

                        If Not IsDBNull(objDataRow.Item("DA AuthorityId")) Then
                            cboDAAuthorityId.SelectedValue = CInt(objDataRow.Item("DA AuthorityId"))

                        Else
                            cboDAAuthorityId.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("ProgressCode")) Then
                            cboProgressCode.SelectedValue = CInt(objDataRow.Item("ProgressCode"))

                        Else
                            cboProgressCode.SelectedIndex = -1
                        End If

                        If Not IsDBNull(objDataRow.Item("ReasonOver40")) Then

                            cboReasonOver40.SelectedValue = CInt(objDataRow.Item("ReasonOver40"))

                        Else
                            cboReasonOver40.SelectedIndex = -1
                        End If


                        If Not IsDBNull(objDataRow.Item("AdvertSignDepot")) Then

                            cboAdvertSignDepot.SelectedValue = objDataRow.Item("AdvertSignDepot").ToString

                        Else
                            cboAdvertSignDepot.SelectedIndex = -1
                        End If




                        If Not IsDBNull(objDataRow.Item("Sec94YN")) Then mnuSec94.Enabled = CBool(objDataRow.Item("Sec94YN"))
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

                        If Not IsDBNull(objDataRow.Item("GroupImageId")) Then
                            mdl_GroupImageID = CInt(objDataRow.Item("GroupImageId"))
                        Else
                            mdl_GroupImageID = 0

                        End If



                        _VideoGroupId = CInt(objDataRow.Item("VideoGroupId"))



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

                        Dim AppType As Integer
                        If IsDBNull(objDataRow.Item("DAAppTypeId")) Then
                            AppType = 0
                        Else
                            AppType = NZ(objDataRow.Item("DAAppTypeId"))
                        End If

                        Select Case AppType
                            Case 3, 4
                                DAmodificationNumber = GetOriginalDAnumber(objDataRow.Item("DANo").ToString)
                                Me.lblType.Text = " of DA " & DAmodificationNumber
                                Me.lblModDesc.Visible = True
                                Me.txtModDesc.Visible = True
                            Case Else
                                Me.lblType.Text = String.Empty
                                Me.lblModDesc.Visible = False
                                Me.txtModDesc.Visible = False

                        End Select

                        txtAdvertSignIntDetails.Text = objDataRow.Item("AdvertSignIntDetails").ToString

                        CheckForComplianceRecords(DANo)



                        Me.mnuOldSystemImages.Enabled = ThereisanImage()

                        btnRemovePIN.Enabled = False

                        CalculateRefundsandPayments(DANo)

                        ClearObjections()

                        txtDaysElapsed.Text = DaysElapsed.ToString

                        lblReferralCount.Text = CalculateElapsedDays(DANo).ToString

                        txtDaysAddinfo.Text = CalculateAddnInfoElapsedDays(DANo).ToString

                        Me.txtDaysTaken.Text = CalculateDaysTakenToDetermine.ToString

                        Me.mnuLinked.Enabled = ThereISLinkedApp(DANo)

                        cboConsentDocType.SelectedIndex = -1

                        If Me.cboConsentDocType.SelectedIndex <> -1 Then
                            LoadListOfConditionsByLetterType(CInt(cboConsentDocType.SelectedValue))
                        End If


                        If Not IsDBNull(objDataRow.Item("EnlightenMap")) Then

                            GetEnlightenImage()

                            btnInsertEnlightenMap.Enabled = False
                            btnSaveEnlighten.Enabled = False
                            btnClearEnlightenMap.Enabled = True

                        Else


                            btnInsertEnlightenMap.Enabled = True
                            btnSaveEnlighten.Enabled = False
                            btnClearEnlightenMap.Enabled = False



                        End If


                        LoadListOfPINS(DANo)
                        RetrieveListOfFileNumbers(DANo)
                        LoadPaymentsRecieved(DANo)
                        LoadRefundsPaid(DANo)
                        LoadHistoricalDocuments()
                        RetrieveFileNotes(DANo)
                        LoadReferralsIntProvisionlList(DANo)
                        LoadUpConditionsList(DANo)
                        LoadUpOneUpConditions(DANo)
                        DisplayListOfDraftDocuments(DANo)
                        LoadVariationGrid(DANo)
                        LoadSubmissionsGrid(DANo)
                        LoadSTDConditionsPriorToCCRelease(DANo)
                        LoadOneOffConditionsPriorToCCRelease(DANo)



                        LoadSummaryData(DANo)


                        LoadIntDevCombo()

                        loadIntDevGrid(DANo)




                        Dim PINS As String = String.Empty


                        For i As Integer = 0 To lstPINs.Items.Count - 1
                            'lstPINs.SelectedIndex = i
                            PINS &= lstPINs.GetItemText(lstPINs.Items(i)) & ","
                        Next


                        If String.IsNullOrEmpty(PINS) Then
                            LoadAssociateApplicationsGrid("999999")

                        Else

                            LoadAssociateApplicationsGrid(PINS.Substring(0, PINS.Length - 1))
                        End If


                        LockTheForm(pnlApplicationData, False)
                        LockTheForm(pnlDisplayFees, False)
                        LockTheForm(pnlDisplayReferrals, False)
                        LockTheForm(pnlDisplaySect68IntDev, False)
                        LockTheForm(pnlDisplayFileNotes, False)
                        LockTheForm(pnlDisplayDocs, True)
                        'LockTheForm(pnlDisplayBuildLetters, False)
                        LockTheForm(pnlDisplayStatus, False)
                        LockTheForm(pnlDisplaySubmisions, False)
                        LockTheForm(pnlDisplayPCAconditions, False)


                        'btnEditDA.Enabled = True
                        'Me.btnEditAddinfoTab.Enabled = True
                        'Me.btnEditReferralsTab.Enabled = True
                        'Me.btnAddReferral.Enabled = True
                        'btnEditAddinfoTab.Enabled = True
                        btnEdit68.Enabled = True
                        'btnAddIntDev.Enabled = False
                        'btnEditStatus.Enabled = True
                        'btnSetIntDevDate.Enabled = False
                        'grp68.Enabled = False
                        'btnViewOfficers.Enabled = True

                        'LockTheForm(grpMain, False)
                        LockTheForm(pnlButtons, False)
                        'LockTheForm(grpRFS, False)
                        'LockTheForm(grpIntDesig, False)
                        'LockTheForm(grpSepp71, False)
                        'LockTheForm(grpMain, False)
                        'LockTheForm(grpRFS, False)
                        'LockTheForm(grpIntDesig, False)
                        'LockTheForm(grpSepp71, False)
                        'LockTheForm(grpAddinfo, False)
                        'txtRefResponse.ReadOnly = False
                        'txtRefComm.ReadOnly = False


                        'btnSaveAddInfoTab.Enabled = False
                        'btnEditAddinfoTab.Enabled = False
                        'btnADDAddinfoTab.Enabled = True

                        'Me.btnEditVariation.Enabled = False
                        'Me.btnSaveVariation.Enabled = False
                        'Me.btnAddVariation.Enabled = True
                        'Me.btneditVariationResponse.Enabled = False
                        'Me.btnSaveVariationResponse.Enabled = False



                        'Me.mnuImages.Enabled = True
                        Me.mnuCompliance.Enabled = True
                        Me.mnuOtherApplication.Enabled = True
                        Me.mnuPrintFileCoverSheet.Enabled = True
                        Me.mnuEngDetailsPostConsent.Enabled = True
                        Me.menuAssessmentApplication.Enabled = True
                        mnuImages.Enabled = True

                        If ViewOnly Then
                            LockAccessIfViewOnly(Me)
                            menuAssessmentApplication.Enabled = False

                        End If







                        ClearReferralData(grpMain)
                        ClearFileNotes(GroupBox34)



                    End If



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PopulateForm routine - form " & Me.Name)

            End Try
        End Using


        LoadingForm = False



    End Sub

    Private Sub GetEnlightenImage()



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetEnlightenImage routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_EnlightenMap"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                    End With

                    Dim objDT As New DataTable



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read

                            If Not IsDBNull(objDataReader.Item(PHOTO)) Then
                                Dim rtf As [Byte]() = New [Byte](Convert.ToInt32((objDataReader.GetBytes(PHOTO, 0, Nothing, 0, Int32.MaxValue))) - 1) {}
                                Dim bytesReceived As Long = objDataReader.GetBytes(PHOTO, 0, rtf, 0, rtf.Length)

                                Dim encoding As New ASCIIEncoding()
                                With picEnlightenMap
                                    .SizeMode = PictureBoxSizeMode.StretchImage
                                    .Image = Image.FromStream(New IO.MemoryStream(rtf))
                                End With
                                'picPhoto.Image = Image.FromStream(New IO.MemoryStream(rtf)) 'encoding.GetString(rtf, 0, Convert.ToInt32(bytesReceived))

                            End If



                        Loop

                    End Using

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in GetEnlightenImage routine - form " & Me.Name)

            End Try
        End Using




    End Sub


    Private Sub LoadSummaryData(ByVal DAno As String)
        clearForm(grpCCSum)

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
                        .CommandText = "usp_CCSummaryData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.CCAppNoTextBox.Text = objDataRow.Item("CCAppNo").ToString

                        Me.DADecisionTextBox.Text = objDataRow.Item("DADecision").ToString

                        Me.CoPCAnameTextBox.Text = objDataRow.Item("CoPCAname").ToString

                        Me.OfficerTextBox.Text = objDataRow.Item("Officer").ToString

                        If Not IsDBNull(objDataRow.Item("CCValue")) Then Me.CCValueTextBox.Text = Format(objDataRow.Item("CCValue"), "Currency")

                        Me.CCInsuranceNoTextBox.Text = objDataRow.Item("CCInsuranceNo").ToString

                        Me.CCLicBuilderNameTextBox.Text = objDataRow.Item("CCLicBuilderName").ToString

                        Me.CCOwnerBuilderNoTextBox.Text = objDataRow.Item("CCOwnerBuilderNo").ToString

                        Me.CCOwnerBuilderCheckBox.Checked = CBool(objDataRow.Item("CCOwnerBuilder"))

                        Me.CCLicBuilderCheckBox.Checked = CBool(objDataRow.Item("CCLicBuilder"))


                    End If



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnSaveDA_ClickExtracted()

        LockApplication()

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
                        .CommandText = "usp_DAUPDATE"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@FILENO", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@DATYPE", SqlDbType.Int).Value = CInt(cboAppType.SelectedValue)
                        '.Parameters.Add("@OFFICER", SqlDbType.Int).Value = CInt(Me.cboDAOfficer.SelectedValue)
                        .Parameters.Add("@SEC94YN", SqlDbType.Bit).Value = Me.chkSec94.CheckState
                        .Parameters.Add("@APPNAME", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@APPADDR", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@APPTOWN", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@APPPCODE", SqlDbType.NVarChar).Value = Me.txtAppPcode.Text
                        .Parameters.Add("@APPPHONE", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text
                        .Parameters.Add("@APPEMAIL", SqlDbType.NVarChar).Value = Me.txtAppemail.Text
                        '---------------------------Description
                        .Parameters.Add("@DADESC1", SqlDbType.Bit).Value = Me.chkDesc1.CheckState
                        .Parameters.Add("@DADESC2", SqlDbType.Bit).Value = Me.chkDADesc2.CheckState
                        .Parameters.Add("@DADESC3", SqlDbType.Bit).Value = Me.chkDADesc3.CheckState
                        .Parameters.Add("@DADESC4", SqlDbType.Bit).Value = Me.chkDADesc4.CheckState
                        .Parameters.Add("@DADESC5", SqlDbType.Bit).Value = Me.chkDADesc5.CheckState
                        .Parameters.Add("@DADESC6", SqlDbType.Bit).Value = Me.chkDADesc6.CheckState
                        .Parameters.Add("@DADESC7", SqlDbType.Bit).Value = Me.chkDADesc7.CheckState
                        .Parameters.Add("@DADESC8", SqlDbType.Bit).Value = Me.chkDADesc8.CheckState
                        .Parameters.Add("@GIFTDONATION", SqlDbType.Bit).Value = Me.chkGiftDonation.CheckState




                        If cboDevType.SelectedIndex <> -1 Then

                            Dim mlist As DevelopmentTypeList = CType(Me.cboDevType.SelectedItem, DevelopmentTypeList)


                            .Parameters.Add("@TYPEID", SqlDbType.Int).Value = CInt(mlist.DevTypeID)



                        End If


                        .Parameters.Add("@SECTOR", SqlDbType.Int).Value = CInt(cboSector.SelectedValue)
                        If cboBuildingType.SelectedIndex <> -1 Then .Parameters.Add("@TypeBldgCode", SqlDbType.Int).Value = CInt(cboBuildingType.SelectedValue)



                        .Parameters.Add("@NODWELLINGS", SqlDbType.Int).Value = CType(nudDwellings.Value, Integer)

                        If cboDevUse.SelectedIndex <> -1 Then .Parameters.Add("@USEID", SqlDbType.Int).Value = CInt(Me.cboDevUse.SelectedValue)
                        .Parameters.Add("@DESC", SqlDbType.NVarChar).Value = Me.txtDADesc.Text
                        .Parameters.Add("@MODDESC", SqlDbType.NVarChar).Value = Me.txtModDesc.Text

                        .Parameters.Add("@CURRENTLANDUSE", SqlDbType.NVarChar).Value = Me.txtCurrentLandUse.Text


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

                        '----------------Property 
                        .Parameters.Add("@DALOT", SqlDbType.NVarChar).Value = Me.txtLot.Text
                        .Parameters.Add("@DADP", SqlDbType.NVarChar).Value = Me.txtDP.Text
                        .Parameters.Add("@DASECT", SqlDbType.NVarChar).Value = Me.txtSection.Text
                        .Parameters.Add("@DASTREETNO", SqlDbType.NVarChar).Value = Me.txtStreetNo.Text
                        .Parameters.Add("@DASTREETNAME", SqlDbType.NVarChar).Value = Me.txtStreetName.Text
                        .Parameters.Add("@LOCALITY", SqlDbType.Int).Value = CInt(cboDAlocalityCode.SelectedValue)
                        .Parameters.Add("@OWNERNAME", SqlDbType.NVarChar).Value = Me.txtDAOwnersName.Text
                        .Parameters.Add("@OWNERADDRESS", SqlDbType.NVarChar).Value = Me.txtDAOwnersAddress.Text
                        .Parameters.Add("@OWNERTOWN", SqlDbType.NVarChar).Value = Me.txtDAOwnersTown.Text
                        .Parameters.Add("@OWNERPCODE", SqlDbType.SmallInt).Value = NZ(txtDAOwnersPcode.Text)
                        .Parameters.Add("@OWNERPHONE", SqlDbType.NVarChar).Value = Me.txtDAOwnersPhone.Text
                        If txtArea.Text <> String.Empty Then .Parameters.Add("@DAAREA", SqlDbType.Float).Value = CDbl(txtArea.Text)
                        .Parameters.Add("@AREAUNIT", SqlDbType.NVarChar).Value = Me.cboAreaType.SelectedValue
                        .Parameters.Add("@CENSUS", SqlDbType.NVarChar).Value = Me.cboDACensusCode.SelectedValue
                        .Parameters.Add("@BASIXCERTNO", SqlDbType.NVarChar).Value = Me.txtBASIXCertNo.Text
                        .Parameters.Add("@BASIXRCPTNO", SqlDbType.NVarChar).Value = Me.txtBASIXRcptNo.Text
                        .Parameters.Add("@BASIXRECD", SqlDbType.Bit).Value = Me.chkBASIXRecd.CheckState
                        .Parameters.Add("@BASIXTHERMAL", SqlDbType.NVarChar).Value = Me.txtBASIXthermal.Text
                        .Parameters.Add("@BASIXENERGY", SqlDbType.NVarChar).Value = Me.txtBASIXenergy.Text
                        .Parameters.Add("@BASIXWATER", SqlDbType.NVarChar).Value = Me.txtBASIXwater.Text


                        .ExecuteNonQuery()

                    End With

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDA_Click routine - form " & Me.Name)

            End Try
        End Using

        PopulateForm(Me.txtDANo.Text)

    End Sub


    Private Function OutstandingReferrals() As Boolean

        Dim result As Boolean


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OutstandingReferrals routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_NumberOutstandingReferrals"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@NUMBEROS", SqlDbType.Bit).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()


                        result = CBool(.Parameters("@NUMBEROS").Value)

                    End With



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OutstandingReferrals routine - form " & Me.Name)

            End Try
        End Using





        Return result


    End Function

    Private Sub CheckForComplianceRecords(ByVal DANo As String)
        Using cn As New SqlConnection(My.Settings.cnDAsystem)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckForComplianceRecords routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CheckForComplianceRecord"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANo
                        .Parameters.Add("@CCNUMBER", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output
                        .Parameters.Add("@CONFIRM", SqlDbType.Bit).Direction = ParameterDirection.Output
                        .ExecuteNonQuery()
                        Me.mnuCompliance.Enabled = CBool(.Parameters("@CONFIRM").Value)
                        compliancenumber = .Parameters("@CCNUMBER").Value.ToString
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in CheckForComplianceRecords routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        If cboSearchType.Text = "" Then
            MessageBox.Show("You are required to enter the field to search..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboSearchType.Focus()
            Exit Sub
        End If

        Select Case cboSearchType.Text.Trim.ToUpper


            Case "PIN"
                If Not IsNumeric(txtSearch.Text) Then
                    MessageBox.Show("You are required to enter a numeric value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Focus()
                    Exit Sub


                Else
                    'LoadForm(Me.txtSearch.Text.ToString)
                    'txtSearch.Text = String.Empty
                    'Exit Sub

                End If

            Case "DEVELOPMENT TYPE"
                If cboSearch.SelectedIndex = -1 Then
                    MessageBox.Show("You are required to select a development type to search..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cboSearch.Focus()
                    Exit Sub

                End If

            Case Else
                If txtSearch.Text = "" Then
                    MessageBox.Show("You are required to enter a search value..", "Click OK to continue", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Focus()
                    Exit Sub
                End If


        End Select

        FindApplicationsData()


        txtSearch.Text = String.Empty
    End Sub

    Private Sub mnuPrintCoverSheet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPrintFileCoverSheet.Click

        Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in mnuPrintFileCoverSheet_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_DACert"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using


                Dim strReportPath As String = My.Settings.ReportLocation & "DACert.rpt"
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
                    MessageBox.Show(ex.Message, " in mnuPrintFileCoverSheet_Click routine ")
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

    Private Sub btnSaveDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDA.Click


        LockTheForm(pnlApplicationData, False)
        LockTheForm(pnlDisplayAssociatedApps, False)
        LockTheForm(pnlDisplaySect68IntDev, False)


        btnEditDA.Enabled = True
        Me.btnSaveDA.Enabled = False

        Me.btnAddPIN.Enabled = False
        'Me.btnRemovePIN.Enabled = True
        Me.btnRetrieveProperty.Enabled = False
        btnAddFile.Enabled = False

        btnSaveDA_ClickExtracted()
        btnAssignOfficer.Enabled = False


    End Sub

    Private Sub btnAddDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDA.Click
        Dim NewDANumber As String = String.Empty
        Dim CreatedOK As Boolean


        With My.Forms.AddNewDA
            .ShowDialog()
            If .DialogResult = Windows.Forms.DialogResult.OK Then
                NewDANumber = .NewDANumber
                CreatedOK = True
            Else
                CreatedOK = False
            End If
            .Dispose()
        End With

        If Not CreatedOK Then Exit Sub

        ClearControls(pnlDisplayFees)
        ClearControls(pnlDisplayReferrals)
        ClearControls(pnlDisplayAssociatedApps)
        ClearControls(pnlDisplaySect68IntDev)
        ClearControls(pnlDisplayFileNotes)
        ClearControls(pnlDisplayDocs)
        ClearControls(pnlDisplayBuildLetters)
        ClearControls(pnlDisplayStatus)
        ClearControls(pnlDisplaySubmisions)
        ClearControls(pnlDisplayVariations)
        ClearControls(pnlDisplayPCAconditions)
        ClearControls(pnlApplicationData)


        PopulateForm(NewDANumber)

        LockTheForm(pnlApplicationData, False)
        LockTheForm(pnlDisplayAssociatedApps, False)
        LockTheForm(pnlDisplaySect68IntDev, False)
        LockTheForm(pnlDisplayFees, False)
        LockTheForm(pnlDisplayReferrals, False)
        LockTheForm(pnlDisplayFileNotes, False)
        LockTheForm(pnlDisplayDocs, False)
        'LockTheForm(pnlDisplayBuildLetters, False)
        LockTheForm(pnlDisplayStatus, False)
        LockTheForm(pnlDisplaySubmisions, False)
        LockTheForm(pnlDisplayVariations, False)
        LockTheForm(pnlDisplayPCAconditions, False)

        btnEditDA.Enabled = False
        Me.btnSaveDA.Enabled = True


        Me.txtReceipts.Text = String.Empty
        Me.txtRefunds.Text = String.Empty
        txtDifference.Text = String.Empty


        btnEditDA.Enabled = False

        Me.btnSaveDA.Enabled = True
        btnAddDA.Enabled = False



        Me.btnAddPIN.Enabled = True
        Me.btnAddFile.Enabled = True
        'Me.btnRemovePIN.Enabled = True
        Me.btnRetrieveProperty.Enabled = True

    End Sub

    Private Sub btnEditDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDA.Click
        LockTheForm(pnlApplicationData, True)
        txtCCno.ReadOnly = Not Administration
        chkSec94.Enabled = Administration
        cboAppType.Enabled = Administration
        txtFileNo.ReadOnly = Not Administration
        txtAppName.ReadOnly = Not Administration
        txtAppAddress.ReadOnly = Not Administration
        txtAppTown.ReadOnly = Not Administration
        txtAppPcode.ReadOnly = Not Administration
        txtAppPhone.ReadOnly = Not Administration
        txtAppemail.ReadOnly = Not Administration
        btnAssignOfficer.Enabled = True

        'Edit Property Tab
        Me.txtLot.ReadOnly = False
        Me.txtDP.ReadOnly = False
        Me.txtSection.ReadOnly = False
        Me.txtArea.ReadOnly = False
        Me.cboAreaType.Enabled = True
        Me.txtStreetNo.ReadOnly = False
        Me.txtStreetName.ReadOnly = False
        Me.cboDAlocalityCode.Enabled = True
        Me.cboDACensusCode.Enabled = True
        Me.txtDAOwnersName.ReadOnly = False
        Me.txtDAOwnersAddress.ReadOnly = False
        Me.txtDAOwnersTown.ReadOnly = False
        Me.txtDAOwnersPcode.ReadOnly = False
        Me.txtDAOwnersPhone.ReadOnly = False
        Me.chkBASIXRecd.Enabled = True
        Me.txtBASIXCertNo.ReadOnly = False
        Me.txtBASIXRcptNo.ReadOnly = False
        Me.txtBASIXwater.ReadOnly = False
        Me.txtBASIXthermal.ReadOnly = False
        Me.txtBASIXenergy.ReadOnly = False

        Me.chkDesc1.Enabled = True
        Me.chkDADesc2.Enabled = True
        Me.chkDADesc3.Enabled = True
        Me.chkDADesc4.Enabled = True
        Me.chkDADesc5.Enabled = True
        Me.chkDADesc6.Enabled = True
        Me.chkDADesc7.Enabled = True
        Me.chkDADesc8.Enabled = True
        Me.chkGiftDonation.Enabled = True
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
        txtModDesc.ReadOnly = False

        btnEditDA.Enabled = False
        Me.btnSaveDA.Enabled = True

        btnAddFile.Enabled = True
        Me.btnAddPIN.Enabled = True
        Me.btnRetrieveProperty.Enabled = True



    End Sub

    'Private Sub btnFind_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    KeyPressSendTab(e)
    'End Sub

    'Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    KeyPressSendTab(e)
    'End Sub


    Private Sub loadDevelopmentTypeCombo()


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in loadDevelopmentTypeCombo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_DevTypes_For_Combo"

                    End With

                    cboDevType.Items.Clear()


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read

                            cboDevType.Items.Add(New DevelopmentTypeList(CType(objDataReader("DevTypeId"), Integer), objDataReader("DevType").ToString, CType(objDataReader("NewDwellingsReports"), Boolean)))

                        Loop


                    End Using


                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in loadDevelopmentTypeCombo routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadLetterTypeCombo()


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

                    cboLetterType.Items.Clear()

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


    End Sub

    'Private Sub txtDANo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    lblapplicationNo.Text = txtDANo.Text
    'End Sub

    Private Sub mnuInspectionTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInspectionTypes.Click
        With My.Forms.MaintainInspectionType
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub MaintainStandardConditionCodesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintainStandardConditionCodesToolStripMenuItem.Click
        With My.Forms.MaintainDefaultConditions
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub btnGoogle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoogle.Click
        Dim URL As String = "http://maps.google.com/maps?f=q&hl=en&geocode=&time=&date=&ttype=&q=@ADDR@&ie=UTF8&t=@TYPE@"

        Dim address As String = txtStreetNo.Text & " " & txtStreetName.Text & " " & cboDAlocalityCode.Text & " Australia"
        address = address.Replace(" ", "+")
        address = address.Replace(",", "%2c")

        URL = URL.Replace("@ADDR@", address)

        'Select Case "Satellite"
        '    Case "Map"
        '        URL.Replace("@TYPE@", "m")
        'Case "Satellite"
        URL = URL.Replace("@TYPE@", "h")
        '    Case "Terrain"
        'URL.Replace("@TYPE@", "p")
        'End Select

        Process.Start(URL)

    End Sub

#End Region

#Region "Menu"

    Private Sub mnuCompliance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompliance.Click
        Dim Compl As New COMP


        With Compl
            .SystemType = "DA"
            .UserId = MyUserId
            .DAnumber = Me.txtDANo.Text
            .CCnumber = txtCCno.Text
            .LoadMainInterface()

        End With
    End Sub

    Private Sub mnuLinked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLinked.Click
        With DALinkToParent
            .DaNo = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub mnuOldSystemImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOldSystemImages.Click
        Dim images As New OldImagesViewer
        With images
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()


        End With

    End Sub

    Private Sub mnuImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCurrentImages.Click
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

    Private Sub mnuSec94ToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSec94.Click
        Dim fSec94 As New Sec9464contributions
        With fSec94
            .DANumber = Me.txtDANo.Text
            .DateDetermined = CStr(IIf(DADetermDt.Text = "  /  /", String.Empty, DADetermDt.Text))
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub mnuOtherApplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOtherApplication.Click

        With My.Forms.ConstructionCertifcate
            .DANumber = txtDANo.Text
            .FileNumber = Me.txtFileNo.Text
            .DAUseType = NZ(cboDevUse.SelectedValue)
            .StartPosition = FormStartPosition.CenterScreen
            'Me.Hide()
            .ShowDialog()
            Me.txtCCno.Text = .CCNo
            .Dispose()

        End With

        SaveCCNO()
    End Sub

    Private Sub mnuEngDetailsPostConsent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEngDetailsPostConsent.Click

        With My.Forms.EngineerPostConsent
            .DAnumber = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub menuAssessmentApplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAssessmentApplication.Click
        'If UAT = True Then

        With My.Forms.NewAssessmentForm

            .DANoToFind = Me.txtDANo.Text
            .OriginalDA = DAmodificationNumber
            .StartPosition = FormStartPosition.CenterParent

            .ShowDialog()
            .Dispose()

        End With

        'Else
        'With My.Forms.DevelopmentAssessment
        '    .DANoToFind = Me.txtDANo.Text
        '    .OriginalDA = DAmodificationNumber
        '    .StartPosition = FormStartPosition.CenterParent

        '    .ShowDialog()
        '    .Dispose()

        'End With

        'End If
        PopulateForm(txtDANo.Text)
    End Sub

    Private Sub mnuMyOutstandingDAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMyOutstandingDAs.Click
        With My.Forms.MyOustandingDAs
            .Show()
        End With
    End Sub

    Private Sub OfficersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfficersToolStripMenuItem.Click

        With My.Forms.SystemUsersMaintenance
            .ShowDialog()
            .Dispose()

        End With
    End Sub


    Private Sub SepticApprovalsByTownAndTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SepticApprovalsByTownAndTypeToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "SepticApprovalsByTownAndType.rpt"
            .StoredProcedureName = "usp_rpt_SepticApprovalsByTownAndType"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ApplicationsRegisteredByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationsRegisteredByOfficerToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "ApplicationsRegisteredByOfficer.rpt"
            .StoredProcedureName = "usp_rpt_ApplicationsRegisteredBY"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub


    Private Sub ReferralListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferralListToolStripMenuItem.Click
        With My.Forms.MaintainReferralCategories
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub mnuSEPPCodes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSEPPCodes.Click
        With My.Forms.MaintainSEPPCategories
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub mnuDCPTypes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDCPTypes.Click
        With My.Forms.MaintainDCPTypes
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub mnuDCPGuidelines_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDCPGuidelines.Click
        With My.Forms.MaintainDCPGuidelines
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub AuthoritiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuthoritiesToolStripMenuItem.Click
        Dim fAuthorities As New MaintainApprovalAuthorities
        With fAuthorities
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub DAUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAUsersToolStripMenuItem.Click
        With My.Forms.MaintainDAUsers
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub DevelopmentTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevelopmentTypesToolStripMenuItem.Click
        With My.Forms.MaintDevelopmentType
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

        loadDevelopmentTypeCombo()

        'LoadCombo(cboDevType, "usp_LoadUpDevTypeList")

    End Sub

    Private Sub PCABuildersListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCABuildersListToolStripMenuItem.Click
        Dim fBuilderMaint As New MaintainBuilders
        With fBuilderMaint
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub CouncilDeterminationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouncilDeterminationToolStripMenuItem.Click
        Dim daResults As New CouncilVoting
        With daResults
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub mnuConsentAdvertising_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsentAdvertising.Click
        Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in mnuConsentAdvertising_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_DA_Advert_Union"
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    PrintAdvertisingSheet(objDT)

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in mnuPreviewAssessment_Click routine ")
            End Try
        End Using


    End Sub

    Private Sub mnuNavision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNavision.Click
        With My.Forms.FeeReconciliationToNavision
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With

    End Sub

    Private Sub mnuProduceABSStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProduceABSStatistics.Click
        Dim fABS As New ABSReportSetup
        With fABS
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub AllResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllResultsToolStripMenuItem.Click
        Dim daResults As New ApplicationCounter
        With daResults
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub DAResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAResultsToolStripMenuItem.Click
        Dim daResults As New ApplicationCounterDA
        With daResults
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub CCResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCResultsToolStripMenuItem.Click
        Dim daResults As New ApplicationCounterCC
        With daResults
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub CDResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CDResultsToolStripMenuItem.Click
        Dim daResults As New ApplicationCounterCD
        With daResults
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ApprovalsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApprovalsToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "ApprovalsReport.rpt"
            .StoredProcedureName = "usp_rpt_Approvals"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub DAsRecievedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAsReceivedToolStripMenuItem.Click

        With My.Forms.ReportSetupDAoutstanding
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub CCsByPropertyOwnerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCsByPropertyOwnerToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "CCAddrProp.rpt"
            .StoredProcedureName = "usp_rpt_CCAddr"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub OutstandingDAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutstandingDAsToolStripMenuItem.Click
        Dim freportSetup As New ReportSetupOutStandingDAs

        With freportSetup
            .ShowDialog()
            .Dispose()
        End With


    End Sub

    Private Sub OSDAsByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSDAsByOfficerToolStripMenuItem.Click

        Dim objDT As New DataTable

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OSDAsByOfficerToolStripMenuItem_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_DAToDoList"

                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OSDAsByOfficerToolStripMenuItem_Click routine - form " & Me.Name)

            End Try
        End Using




        Dim reptviewer As New AddAdvertPrinter


        With reptviewer

            .objDataTable = objDT
            .ReportName = "DA_ToDoList.rpt"
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub OutstandingCCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutstandingConstructionCertificatesToolStripMenuItem.Click
        Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_OutstandingCC"
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using


                'Dim strReportPath As String = My.Settings.ReportLocation & "OutstandingCCs.rpt"

                Dim reptviewer As New AddAdvertPrinter
                With reptviewer
                    .ReportName = "OutstandingCCs.rpt"
                    .objDataTable = objDT
                    .ShowDialog()
                    .Dispose()
                End With

                'Try

                '    If Not IO.File.Exists(strReportPath) Then
                '        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

                '    End If

                '    Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                '    myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                '    myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical

                '    With rptDocument
                '        .Load(strReportPath)
                '        .SetDataSource(objDT)
                '        .VerifyDatabase()

                '        .PrintToPrinter(1, False, 1, 99)
                '    End With


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try


            'Catch ex As SqlException
            '    MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            'End Try
        End Using
    End Sub

    'Private Sub SepticsOutstandingByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim rptDocument As New ReportDocument

    '    Dim objDT As New DataTable

    '    'Check file exists

    '    Using cn As New SqlConnection(My.Settings.DataConnection)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in PrintTheReport routine")

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_rpt_OutstandingSepticTanks"
    '                End With



    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using



    '            End Using


    '            Dim strReportPath As String = My.Settings.ReportLocation & "OutstandingSeptics.rpt"
    '            Try

    '                If Not IO.File.Exists(strReportPath) Then
    '                    Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

    '                End If

    '                Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
    '                myPrintOptions.PrinterName = My.Settings.DefaultPrinter
    '                myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical

    '                With rptDocument
    '                    .Load(strReportPath)
    '                    .SetDataSource(objDT)
    '                    .VerifyDatabase()

    '                    .PrintToPrinter(1, False, 1, 99)
    '                End With
    '            Catch ex As SqlException
    '                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
    '            End Try


    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in PrintTheReport routine ")
    '        End Try
    '    End Using
    'End Sub

    'Private Sub SewerConnectionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim freportSetup As New ReportSetupSewerConnections

    '    With freportSetup
    '        .ShowDialog()
    '        .Dispose()
    '    End With
    'End Sub

    Private Sub BASIXCompleteNotifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BASIXCompleteNotifyToolStripMenuItem.Click
        Dim freportSetup As New ReportSetupBasixComplete

        With freportSetup
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub DAsAllocatedByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAsAllocatedByOfficerToolStripMenuItem.Click
        Dim reptview As New ReportSetupDAAllocatedToOfficers

        With reptview
            .ShowDialog()
            .Dispose()
        End With


    End Sub

    Private Sub CCsAllocatedByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCsAllocatedByOfficerToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals
        With reptview
            .ReportToPrint = "CCs_AllocatedByOfficer.rpt"
            .StoredProcedureName = "usp_rpt_CCs_Allocated_ByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub OutstandingReferralsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutstandingReferralsToolStripMenuItem.Click
        Dim objDT As New DataTable

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OutstandingReferralsToolStripMenuItem_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_OutstandingReferrals"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OutstandingReferralsToolStripMenuItem_Click routine - form " & Me.Name)

            End Try
        End Using


        Dim reptViewer As New AddAdvertPrinter
        With reptViewer
            .ReportName = "OutstandingReferrals.rpt"
            .objDataTable = objDT
            .ShowDialog()
            .Dispose()

        End With




    End Sub

    Private Sub DeterminedDAsByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeterminedDAsByOfficerToolStripMenuItem.Click
        Dim daResults As New reportSetupApprovalsByOfficer
        With daResults
            .ReportType = "ApprovalsByOfficer.rpt"
            .StoredProcedureName = "usp_rpt_ApprovalsByOfficer"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub DeterminedCCsByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeterminedCCsByOfficerToolStripMenuItem.Click
        Dim daResults As New reportSetupApprovalsByOfficer
        With daResults
            .ReportType = "CCsByOfficer.rpt"
            .StoredProcedureName = "usp_rpt_CCsByOfficer"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ReferralsByOfficerDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReferrlsByOfficerDateToolStripMenuItem.Click
        Dim reptview As New ReportSetupReferralsByOfficer

        With reptview
            .ShowDialog()
            .Dispose()
        End With


    End Sub

    Private Sub ByOfficerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByOfficerToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "ComplianceInspectionsByOfficer.rpt"
            .StoredProcedureName = "usp_rpt_ComplianceInspectionsByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub TotalsByOfficerByTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalsByOfficerByTypeToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "InspectionsByOfficerXtab.rpt"
            .StoredProcedureName = "usp_rpt_ComplianceInspectionsByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub ByOfficerSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByOfficerSummaryToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals
        With reptview
            .ReportToPrint = "InspectionsByOfficerXtabSummary.rpt"
            .StoredProcedureName = "usp_rpt_ComplianceInspectionsByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ByFileNoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByFileNumberToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals
        With reptview
            .ReportToPrint = "InspectionsByFileNo.rpt"
            .StoredProcedureName = "usp_rpt_InspectByFileNo"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub AverageInspectionTimesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AverageInspectionTimesToolStripMenuItem.Click
        With My.Forms.ReportSetupAverageInspectTimes

            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub CouncilReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CouncilReportToolStripMenuItem.Click
        With My.Forms.ReportSetup
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ApprovalsByTownAndTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApprovalsByTownAndTypeToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "ApprovalsByTownAndType.rpt"
            .StoredProcedureName = "usp_rpt_ApprovalsByTownByTypebyDateRange"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub OccCertsByTownAndTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OccupationCertificatesByTownAndTypeToolStripMenuItem.Click

        With My.Forms.ReportViewer

            .ReportName = "Occup"
            .StoredProcedureName = "usp_rpt_FinalOccsByTown"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()



        End With

        'Dim reptview As New reportSetupApprovals

        'With reptview
        '    .ReportToPrint = "OccCertsByTownAndType.rpt"
        '    .StoredProcedureName = "usp_rpt_FinalOccsByTown"
        '    .StartPosition = FormStartPosition.CenterParent
        '    .ShowDialog()
        '    .Dispose()

        'End With
    End Sub

    Private Sub LiquidWasteApplicationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidTradeWasteApplicationsToolStripMenuItem.Click
        Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LiquidWasteApplicationsToolStripMenuItem.Click routine")

            End Try

            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_LTWApps"
                    End With

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                End Using


                Dim reptviewer As New AddAdvertPrinter
                With reptviewer
                    .ReportName = "LTWApps.rpt"
                    .objDataTable = objDT
                    .ShowDialog()
                    .Dispose()
                End With

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LiquidWasteApplicationsToolStripMenuItem.Click routine ")
            End Try
        End Using
    End Sub

    Private Sub TotalDAsAndCCsSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalDAsAndCCsSummaryToolStripMenuItem.Click
        Dim daResults As New reportSetupApprovals
        With daResults
            .ReportToPrint = "NumberOfDaCCapprovedSummary.rpt"
            .StoredProcedureName = "usp_rpt_NumberDAsApprovedSummary"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub StatutoryTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatutoryTimeToolStripMenuItem.Click
        Dim daResults As New ReportSetupStatutoryTime
        With daResults
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub MayoralDeterminedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MayoralDeterminedToolStripMenuItem.Click
        Dim reptview As New reportSetupMayoral
        With reptview
            .ReportToPrint = "DAMayoralSummaryDeterm.rpt"
            .StoredProcedureName = "usp_rpt_DADetermSummary"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub MayoralReceivedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MayoralReceivedToolStripMenuItem.Click
        Dim reptview As New reportSetupMayoral
        With reptview
            .ReportToPrint = "DAMayoralSummaryRecv.rpt"
            .StoredProcedureName = "usp_rpt_DARecvSummary"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub CCWithoutOccCertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCWithoutOccCertToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals
        With reptview
            .ReportToPrint = "CCWithoutOccCert.rpt"
            .StoredProcedureName = "usp_rpt_CCWithoutOccCert"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub


    Private Sub mnuExpireInterimOccupationCert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpiredInterimOccupationCertificatesToolStripMenuItem.Click

        With My.Forms.reportSetupApprovals
            .ReportToPrint = "CCWithOutstandingInterimOccCert.rpt"
            .StoredProcedureName = "usp_rpt_CCExpiredInterimOC"
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



        'LoadCombo(Me.cboNoteType, "usp_LoadUpFileNoteTypeList")
        'LoadCombo(Me.cboRefCodeId, "usp_LoadUpReferralCodeList")
        'LoadCombo(Me.cboReferralsIntProvision, "usp_LoadUpIntegratedProvisionList")
        'LoadCombo(Me.cboAppType, "usp_LoadUpDATypeList")
        ''LoadCombo(Me.cboOtherDocs, "usp_LoadUp_DocType_WordTemplateList")
        'LoadListOfOtherWordTemplates("O")
        'LoadCombo(Me.cboDADecisionId, "usp_LoadUpDADecisionList")
        'LoadCombo(Me.cboNotesOfficer, "usp_LoadUpOfficerList")
        ''LoadCombo(Me.cboNoteType, "usp_LoadUpFileNoteTypeList")
        'LoadCombo(Me.cboDAAuthorityId, "usp_LoadUpDAAuthorityList")

        ' ''LoadCombo(Me.cboDevType, "usp_LoadUpDevTypeList")
        ''loadDevelopmentTypeCombo()


        'LoadCombo(Me.cboDAtype1, "usp_LoadUpDevTypeList")
        'LoadCombo(Me.cboDAType2, "usp_LoadUpDevTypeList")
        'LoadCombo(Me.cboDAtype3, "usp_LoadUpDevTypeList")
        'LoadLetterTypeCombo()
        'LoadCombo(Me.cboDevUse, "usp_LoadUpDevUseList")
        ' ''LoadCombo(Me.cboIntDevActs , "usp_LoadUpIntegratedDevelopmentActList")
        'LoadCombo(Me.cboDAlocalityCode, "usp_LoadUpLocalityCodesList")
        ' ''LoadCombo(cboAssessmentType, "usp_LoadUpDADefaultConditionsList")
        'LoadCombo(cboAssessmentType, "usp_SELECT_StandardCondition")
        'LoadCombo(Me.cboDACensusCode, "[usp_LoadUpCensusCodeList]")
        'LoadCombo(Me.cboConsentType, "usp_LoadUpConsentTypeList")

        ''LoadListOfWordTemplates() '<<<++++======



        'LoadCombo(Me.cboDAClass, "usp_LoadUpDAClassComboList")

        'LoadCombo(Me.cboDAClass1, "usp_LoadUpDAClassComboList")
        'LoadCombo(Me.cboDAClass2, "usp_LoadUpDAClassComboList")
        'LoadCombo(Me.cboDAClass3, "usp_LoadUpDAClassComboList")

        'LoadCombo(cboVariationType, "usp_LoadUpVariationList")
        'LoadCombo(cboSubmissionType, "usp_LoadUpVariationList")

        'LoadCombo(cboVariationResult, "usp_LoadUpVariationResultList")
        'LoadCombo(cboVariationAuthority, "usp_LoadUpDelegatedAuthorityList")

        'LoadCombo(cboReasonOver40, "usp_LoadUp_REASON_DA_APPL_40DAYSList")
        'LoadCombo(cboProgressCode, "usp_LoadUp_ProgressCodeList")



        'LoadSearchCombo()


        'Dim AreaDescription As New ArrayList

        '' Add division structure entries to the arraylist
        'With AreaDescription
        '    .Add(New AreaType("Metres", "M"))
        '    .Add(New AreaType("Hectares", "H"))
        'End With

        'With cboAreaType
        '    .DataSource = AreaDescription
        '    .DisplayMember = "Name"
        '    .ValueMember = "Key"
        '    .SelectedIndex = -1
        'End With


        'Dim CouncilDepot As New ArrayList

        '' Add division structure entries to the arraylist
        'With CouncilDepot
        '    .Add(New Depots("", ""))
        '    .Add(New Depots("Batemans Bay", "B"))
        '    .Add(New Depots("Moruya", "M"))
        '    .Add(New Depots("Narooma", "N"))
        'End With

        'With cboAdvertSignDepot
        '    .DataSource = CouncilDepot
        '    .DisplayMember = "Name"
        '    .ValueMember = "Key"
        '    .SelectedIndex = -1
        'End With

        'Dim IntDev As New ArrayList

        '' Add division structure entries to the arraylist
        'With IntDev
        '    .Add(New YesNoAnswer("Yes", "Y"))
        '    .Add(New YesNoAnswer("No", "N"))
        'End With

        'With cboIntDevYN
        '    .DataSource = IntDev
        '    .DisplayMember = "Name"
        '    .ValueMember = "Key"
        '    .SelectedIndex = -1
        'End With

        'Dim Designated As New ArrayList

        '' Add division structure entries to the arraylist
        'With Designated
        '    .Add(New YesNoAnswer("Yes", "Y"))
        '    .Add(New YesNoAnswer("No", "N"))
        'End With

        'With cboDesignatedYN
        '    .DataSource = Designated
        '    .DisplayMember = "Name"
        '    .ValueMember = "Key"
        '    .SelectedIndex = -1
        'End With
        'Dim RFS As New ArrayList

        '' Add division structure entries to the arraylist
        'With RFS
        '    .Add(New RFSSubvisionType("Residential", "2"))
        '    .Add(New RFSSubvisionType("Rural", "1"))
        'End With

        'With cboRFSSubDivisionType
        '    .DataSource = RFS
        '    .DisplayMember = "Name"
        '    .ValueMember = "Key"
        '    .SelectedIndex = -1
        'End With


        'Dim SubmissionType As New ArrayList

        '' Add division structure entries to the arraylist
        'With SubmissionType
        '    .Add(New SubmissionTypes("Submision", "S"))
        '    .Add(New SubmissionTypes("Objection", "O"))
        'End With

        'With cboSubmissionType
        '    .DataSource = SubmissionType
        '    .DisplayMember = "Name"
        '    .ValueMember = "Key"
        '    .SelectedIndex = -1
        'End With



        'lblMenu.Text = "Development Application Details"
        'Me.pnlApplicationData.Dock = DockStyle.Fill
        'pnlSearch.Visible = True


        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

        isloading = False
    End Sub




    Private Sub btnInsertEnlightenMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertEnlightenMap.Click

        PasteFromClipboard(picEnlightenMap)

        btnInsertEnlightenMap.Enabled = False

        btnSaveEnlighten.Enabled = True
    End Sub

    Private Sub btnSaveEnlighten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEnlighten.Click


        If Not My.Computer.FileSystem.DirectoryExists(tempFolder) Then My.Computer.FileSystem.CreateDirectory(tempFolder)

        If My.Computer.FileSystem.FileExists(tempFolder & "\test.jpg") Then My.Computer.FileSystem.DeleteFile(tempFolder & "\test.jpg")



        picEnlightenMap.Image.Save(tempFolder & "\test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)


        Dim imageData As Byte()
        imageData = ReadFile(tempFolder & "\test.jpg")



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
                        .CommandText = "usp_INSERT_EnlightenMap"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .Parameters.Add("@ENLIGHTENMAP", SqlDbType.Image).Value = DirectCast(imageData, Object)
                        .ExecuteNonQuery()

                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        btnSaveEnlighten.Enabled = False
        btnClearEnlightenMap.Enabled = True

    End Sub


    Private Sub btnClearEnlightenMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearEnlightenMap.Click

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
                        .CommandText = "usp_UPDATE_ClearEnlightenMap"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = txtDANo.Text
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

        picEnlightenMap.Image = Nothing
        btnSaveEnlighten.Enabled = False
        btnInsertEnlightenMap.Enabled = True
        btnClearEnlightenMap.Enabled = False

    End Sub

    Private Sub mnuVideos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVideos.Click



        Dim GroupImageIDB4 As Integer = _VideoGroupId


        Dim VidCapture As New VIDEO

        With VidCapture
            .ServerName = "REC"
            .Application = 7
            .VideoGroupID = _VideoGroupId
            .DisplayCaptureScreen()
            _VideoGroupId = .VideoGroupID

        End With
        If GroupImageIDB4 <= 0 And _VideoGroupId <> 0 Then UpdateVideoGroupID(_VideoGroupId)


    End Sub


    Private Sub cboDevType_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboDevType.SelectedValueChanged

        If isloading Then Exit Sub

        Dim mlist As DevelopmentTypeList = CType(Me.cboDevType.SelectedItem, DevelopmentTypeList)

        If Not mlist Is Nothing Then



            nudDwellings.Visible = mlist.IsReport
            lblNoDwellings.Visible = mlist.IsReport


            If mlist.IsReport = True Then

                Select Case mlist.DevTypeID

                    Case 0, 4, 5, 6, 9, 10, 19, 20, 28, 35, 36, 37, 39, 46, 48

                        nudDwellings.Value = 1

                    Case Else

                        nudDwellings.Value = 0


                End Select

            End If

        Else

            nudDwellings.Visible = False
            lblNoDwellings.Visible = False


        End If



    End Sub

    Private Sub NumberOfDwellingsApprovedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NumberOfDwellingsApprovedToolStripMenuItem.Click
        With My.Forms.NumberDwellingsApproved

            .ShowDialog()

            .Dispose()

        End With
    End Sub

    Private Sub DAApplication_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If Not String.IsNullOrEmpty(cmdArg) Then

            PopulateForm(cmdArg)

        End If
    End Sub

    Private Sub CCsPCAToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CCsPCAToolStripMenuItem.Click
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "CCAddrPropByPCA.rpt"
            .StoredProcedureName = "usp_rpt_CC_PCA"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub btnEnlighten_Click(sender As System.Object, e As System.EventArgs) Handles btnEnlighten.Click

        lstPINs.SelectedIndex = 0

        Dim EnlightenURL As String = "http://escgis05v/enlighten/IntegrationLogon.cfm?search=Pin&Pin=" & CInt(lstPINs.SelectedValue) & "&refresh=YES"

        Process.Start(EnlightenURL)
    End Sub

    Private Sub chksepp71_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chksepp71.CheckedChanged

        grpRFS.Visible = chksepp71.Checked

    End Sub

    Private Sub mnuMaintainInsuranceCoys_Click(sender As Object, e As EventArgs) Handles mnuMaintainInsuranceCoys.Click

        With My.Forms.MaintainInsuranceCompanies

            .ShowDialog()

            .Dispose()

        End With

    End Sub

    Private Function ReadFile(ByVal sPath As String) As Byte()
        'Initialize byte array with a null value initially.        
        Dim data As Byte() = Nothing
        'Use FileInfo object to get file size.      
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length
        'Open FileStream to read file        
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)
        'Use BinaryReader to read file stream into byte array.       
        Dim br As New BinaryReader(fStream)
        'When you use BinaryReader, you need to supply number of bytes to read from file.        
        'In this case we want to read entire file. So supplying total number of bytes.         
        data = br.ReadBytes(CInt(numBytes))

        fStream.Close()

        Return data
    End Function


    Private Sub mnuCreateTemplate_Click(sender As Object, e As EventArgs) Handles mnuCreateTemplate.Click

        With My.Forms.CreateBlankTemplate

            .ShowDialog()

            .Dispose()

        End With

    End Sub

    Private Sub gvwDocumentsList_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwDocumentsList.RowClick

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)

        txtDocNote.Text = myobj.Row.Item("notes").ToString

        btnRemoveDocument.Enabled = True
        btnViewPDF.Enabled = True




        btnViewWord.Enabled = myobj.Row.Item("WORDDOC").ToString <> "N"



    End Sub

    Private Sub btnViewPDF_Click(sender As Object, e As EventArgs) Handles btnViewPDF.Click


        DisplayPDFdocument()

    End Sub

    Private Sub btnViewWord_Click(sender As Object, e As EventArgs) Handles btnViewWord.Click

        Dim DocumentName As String = String.Empty

        Dim myobj As DataRowView = CType(gvwDocumentsList.GetFocusedRow, DataRowView)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnViewWord_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_RetrieveWordDocument"

                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DocId"))


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        DocumentName = objDataRow.Item("WordDocName").ToString

                        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName) Then My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

                        If Not IsDBNull(objDataRow.Item("WordObject")) Then

                            Dim blob As [Byte]() = DirectCast(objDataRow.Item("WordObject"), [Byte]())


                            Dim ms As MemoryStream = New MemoryStream(blob)


                            Using fs As FileStream = File.Create(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

                                ms.WriteTo(fs)
                                'ms.Close()

                            End Using


                        End If


                    End If

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnViewWord_Click routine - form " & Me.Name)

            End Try
        End Using



        Dim mailObject As New OpenDocument

        mailObject.OpenVisible(My.Computer.FileSystem.SpecialDirectories.Temp & "\" & DocumentName)

    End Sub

    Private Sub btnAdditionalInfo_Click(sender As Object, e As EventArgs) Handles btnAdditionalInfo.Click
        Dim AdditionalInfo As New ADDINFO

        With AdditionalInfo
            .ServerName = "REC"
            .SystemType = "DA"
            .ApplicationNumber = txtDANo.Text
            .UserId = MyUserId
            .LoadMainInterface()
        End With

    End Sub

    Private Sub DADetermDt_EditValueChanged(sender As Object, e As EventArgs) Handles DADetermDt.EditValueChanged

        If DADetermDt.IsLoading Then Return

        If LoadingForm Then Return

        If OutstandingReferrals() Then

            MessageBox.Show("You are unable to insert a determination date until ALL referrals have been completed", "OUTSTANDING REFERRALS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DADetermDt.EditValue = Nothing

            Return

        End If


    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        KeyPressSendTab(e)
    End Sub

End Class
