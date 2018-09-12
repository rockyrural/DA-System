Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports ADDINFO = ClassAdditionalInformation.AdditionalInfo

'Imports ADwrapper = ActiveDirectoryWrapper.PC.ADWrapper
Imports ADHelpr = ADHelper.ADHelper
'Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.Shared

Imports COMP = Compliance.ComplianceApp
Imports WORD = Microsoft.Office.Interop.Word

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

#If CONFIG = "Release" Then



        If My.Settings.connectionString = "Data Source=Development\dev;Initial Catalog=DevelopmentSQL;Integrated Security=True" Then
            MessageBox.Show("WARNING THIS IS TEST DATA DO NOT PROCEED,  RING BOB NOW!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


#End If
        LoadComboBoxs()


        cboSTDconditions.Visible = False
        btnAddCondition.Visible = False

        FindUserInfor()


        BiAddDA.Enabled = Administration

        If ViewOnly Then
            LockAccessIfViewOnly(Me)
            BiAssessment.Enabled = False

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

        cboSearchType.SelectedIndex = 0

    End Sub

    Private Sub LoadComboBoxs()

        isloading = True

        LoadLookupEdit(Me.cboNoteType, "usp_LoadUpFileNoteTypeList")
        'LoadLookupEdit(cboSubmissionType, "usp_LoadUpVariationList")
        LoadLookupEdit(Me.cboNotesOfficer, "usp_LoadUpOfficerList")

        LoadVariationLookupEdit()

        LoadLookupEdit(cboVariationResult, "usp_LoadUpVariationResultList")
        LoadLookupEdit(cboVariationAuthority, "usp_LoadUpDelegatedAuthorityList")

        LoadLookupEdit(Me.cboRefCodeId, "usp_LoadUpReferralCodeList")
        LoadLookupEdit(Me.cboReferralsIntProvision, "usp_LoadUpIntegratedProvisionList")


        LoadLookupEdit(Me.cboAppType, "usp_LoadUpDATypeList")
        'LoadLookupCombo(Me.cboOtherDocs, "usp_LoadUp_DocType_WordTemplateList")
        LoadListOfOtherWordTemplates("O")
        LoadLookupEdit(Me.cboDADecisionId, "usp_LoadUpDADecisionList")
        LoadLookupEdit(Me.cboDAAuthorityId, "usp_LoadUpDAAuthorityList")
        LoadLookupEdit(cboReasonOver40, "usp_LoadUp_REASON_DA_APPL_40DAYSList")
        LoadLookupEdit(cboProgressCode, "usp_LoadUp_ProgressCodeList")
        LoadLookupEdit(lupSection68, "usp_SELECT_ListOfSection68Items")

        ''LoadCombo(Me.cboDevType, "usp_LoadUpDevTypeList")
        loadDevelopmentTypeCombo()


        LoadLookupEdit(Me.cboDAtype1, "usp_LoadUpDevTypeList")
        LoadLookupEdit(Me.cboDAType2, "usp_LoadUpDevTypeList")
        LoadLookupEdit(Me.cboDAtype3, "usp_LoadUpDevTypeList")
        'LoadLetterTypeCombo()
        LoadLookupEdit(Me.cboDevUse, "usp_LoadUpDevUseList")
        LoadLookupEdit(cboIntendedLandUse, "usp_SELECT_LoadIntendLandUseList")
        LoadLookupEdit(cboAttachmentStatus, "usp_SELECT_ListOfAttachmentTypes")


        ''LoadCombo(Me.cboIntDevActs , "usp_LoadUpIntegratedDevelopmentActList")
        LoadLookupEdit(Me.cboDAlocalityCode, "usp_LoadUpLocalityCodesList")
        ''LoadCombo(cboAssessmentType, "usp_LoadUpDADefaultConditionsList")
        LoadLookupCombo(cboAssessmentType, "usp_SELECT_StandardCondition")
        LoadLookupEdit(Me.cboDACensusCode, "[usp_LoadUpCensusCodeList]")
        LoadLookupEdit(Me.cboConsentType, "usp_LoadUpConsentTypeList")

        LoadListOfWordTemplates() '<<<++++======

        LoadLookupEdit(Me.cboBuildingType, "usp_SELECT_LoadABSBuildingTypeList")







        LoadSearchCombo()


        Dim AreaDescription As New ArrayList

        ' Add division structure entries to the arraylist
        With AreaDescription
            .Add(New AreaType("Metres", "M"))
            .Add(New AreaType("Hectares", "H"))
        End With

        With cboAreaType.Properties
            .DataSource = AreaDescription
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False

        End With
        Dim colAreaType As LookUpColumnInfoCollection = cboAreaType.Properties.Columns
        colAreaType.Add(New LookUpColumnInfo("Name", 0))
        colAreaType.Add(New LookUpColumnInfo("Key", 0))

        colAreaType.Item(1).Visible = False

        Dim SectorOwnerShip As New ArrayList

        ' Add division structure entries to the arraylist
        With SectorOwnerShip
            .Add(New AreaType("Private", "1"))
            .Add(New AreaType("Government", "2"))
        End With

        With cboSector.Properties
            .DataSource = SectorOwnerShip
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False


        End With
        Dim colSector As LookUpColumnInfoCollection = cboSector.Properties.Columns
        colSector.Add(New LookUpColumnInfo("Name", 0))
        colSector.Add(New LookUpColumnInfo("Key", 0))

        colSector.Item(1).Visible = False


        '-------------------------------------
        Dim Occupancy As New ArrayList

        ' Add division structure entries to the arraylist
        With Occupancy
            .Add(New AreaType("Single", "1"))
            .Add(New AreaType("Dual", "2"))
        End With

        With lupOccupancyStatus.Properties
            .DataSource = Occupancy
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False


        End With
        Dim colOccup As LookUpColumnInfoCollection = lupOccupancyStatus.Properties.Columns
        colOccup.Add(New LookUpColumnInfo("Name", 0))
        colOccup.Add(New LookUpColumnInfo("Key", 0))

        colOccup.Item(1).Visible = False





        '----------------------------------------


        Dim CouncilDepot As New ArrayList

        ' Add division structure entries to the arraylist
        With CouncilDepot
            '.Add(New Depots("", ""))
            .Add(New Depots("All", "A"))
            .Add(New Depots("Batemans Bay", "B"))
            .Add(New Depots("Moruya", "M"))
            .Add(New Depots("Narooma", "N"))

        End With

        With cboAdvertSignDepot.Properties
            .DataSource = CouncilDepot
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False

        End With

        Dim col1 As LookUpColumnInfoCollection = cboAdvertSignDepot.Properties.Columns
        col1.Add(New LookUpColumnInfo("Name", 0))
        col1.Add(New LookUpColumnInfo("Key", 0))

        col1.Item(1).Visible = False

        Dim IntDev As New ArrayList

        ' Add division structure entries to the arraylist
        With IntDev
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
        End With

        With cboIntDevYN.Properties
            .DataSource = IntDev
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False

        End With

        Dim colIntDevYN As LookUpColumnInfoCollection = cboIntDevYN.Properties.Columns
        colIntDevYN.Add(New LookUpColumnInfo("Name", 0))
        colIntDevYN.Add(New LookUpColumnInfo("Key", 0))

        colIntDevYN.Item(1).Visible = False

        Dim Designated As New ArrayList

        ' Add division structure entries to the arraylist
        With Designated
            .Add(New YesNoAnswer("Yes", "Y"))
            .Add(New YesNoAnswer("No", "N"))
        End With

        With cboDesignatedYN.Properties
            .DataSource = Designated
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False

        End With


        Dim colDesignatedYN As LookUpColumnInfoCollection = cboDesignatedYN.Properties.Columns
        colDesignatedYN.Add(New LookUpColumnInfo("Name", 0))
        colDesignatedYN.Add(New LookUpColumnInfo("Key", 0))

        colDesignatedYN.Item(1).Visible = False



        Dim RFS As New ArrayList

        ' Add division structure entries to the arraylist
        With RFS
            .Add(New RFSSubvisionType("Residential", "2"))
            .Add(New RFSSubvisionType("Rural", "1"))
        End With

        With cboRFSSubDivisionType.Properties
            .DataSource = RFS
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False

        End With



        Dim colRFSSubDivisionType As LookUpColumnInfoCollection = cboRFSSubDivisionType.Properties.Columns
        colRFSSubDivisionType.Add(New LookUpColumnInfo("Name", 0))
        colRFSSubDivisionType.Add(New LookUpColumnInfo("Key", 0))

        colRFSSubDivisionType.Item(1).Visible = False


        Dim SubmissionType As New ArrayList

        ' Add division structure entries to the arraylist
        With SubmissionType
            .Add(New SubmissionTypes("Submision", "S"))
            .Add(New SubmissionTypes("Objection", "O"))
        End With

        With cboSubmissionType.Properties
            .DataSource = SubmissionType
            .DisplayMember = "Name"
            .ValueMember = "Key"
            .ShowFooter = False
            .ShowHeader = False

        End With
        Dim colSubmissionType As LookUpColumnInfoCollection = cboSubmissionType.Properties.Columns
        colSubmissionType.Add(New LookUpColumnInfo("Name", 0))
        colSubmissionType.Add(New LookUpColumnInfo("Key", 0))
        colSubmissionType.Item(1).Visible = False



        isloading = False



    End Sub


    Private Sub LoadVariationLookupEdit()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationLookupEdit routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpVariationList"

                        '.Parameters.Add("", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    With cboVariationType.Properties

                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboVariationType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    col2.Item(1).Visible = False



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationLookupEdit routine - form " & Me.Name)

            End Try
        End Using


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

                    With cboOtherDocs.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboOtherDocs.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    col2.Item(1).Visible = False


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

                    With cboConsentDocType.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboConsentDocType.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    col2.Item(1).Visible = False

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub



    Private Sub LoadLookupEdit(ByVal cbo As LookUpEdit, ByVal SPROC As String)

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
                        .ShowFooter = False
                        .ShowHeader = False
                    End With

                End Using

                Dim col2 As LookUpColumnInfoCollection = cbo.Properties.Columns
                col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                col2.Add(New LookUpColumnInfo("ValueMember", 0))

                col2.Item(1).Visible = False


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


    Private Sub LoadWordDocumentList()


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
                        .CommandText = "usp_LoadUp_DocType_WordTemplateList" ' "usp_LoadUp_DocType_WordTemplateList"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboOtherDocs.Properties
                        '.Items.Clear()
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    'Dim col2 As LookUpColumnInfoCollection = cboOtherDocs.Properties.Columns
                    'col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    'col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    'col2.Item(1).Visible = False

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub


    Private Sub LoadLookupCombo(ByVal cbo As LookUpEdit, ByVal SPROC As String)

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
                        .ShowFooter = False
                        .ShowHeader = False

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

    Private Function SendEmailAdvice() As Boolean
        Dim result As Boolean = True
        'Dim mailaddress As String = ADHelper.GetEmailAddress(ADHelper.GetLoginName)

        Dim Subject As String = "**Submission received for DA No: " & Me.txtDANo.Text & "**"
        Dim Body As String = "A submission has been received from " & txtAuthorName.Text & " for DA " & txtDANo.Text & " File No: " &
                              txtFileNo.Text & vbCrLf & " for " & txtStreetNo.Text & " " & Me.txtStreetName.Text & ", " &
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
            releaseObject(objWordDoc)

            releaseObject(objWordApp)




            Dim DTS As Double = CType(Now().ToOADate(), Double)






            FileIO.FileSystem.MoveFile(mydocuments & "\" & strEASEdocumentName, My.Settings.DocumentGateway & strEASEdocumentName, True)




        Catch ex As Exception
            MessageBox.Show(ex.Message, " in CreateWordDocs routine in CreateWordDocuments module ")

        End Try





    End Sub

    Private Function ThereisanImage() As Boolean

        Dim result As Boolean = False


        Using cn As New SqlConnection(My.Settings.connectionString)
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

        Using cn As New SqlConnection(My.Settings.connectionString)
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


                    grdAssociatedApps.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadAssociateApplicationsGrid routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Function SubmissionNotComplete() As Boolean
        Dim result As Boolean = False

        If cboSubmissionType.EditValue Is Nothing Then
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

        If txtSubmissionSummary.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtSubmissionSummary, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtSubmissionSummary, "A summary is required")
            End With
            result = True
        Else
            ErrorProvider.SetError(Me.txtSubmissionSummary, "")

        End If


        If txtAuthorEmail.Text = String.Empty Then

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

        Else

            If txtAuthorName.Text = String.Empty Then txtAuthorName.Text = txtAuthorEmail.Text



        End If




        Return result

    End Function
    Private Sub SaveCCNO()

        Using cn As New SqlConnection(My.Settings.connectionString)
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
    '    Using cn As New SqlConnection(My.Settings.connectionString)
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

        Using cn As New SqlConnection(My.Settings.connectionString)
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

        Using cn As New SqlConnection(My.Settings.connectionString)
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

#If CONFIG = "Release" Then

            sUserID = My.User.Name.Substring(4)
            'sUserID = "cdavey"

#Else



            sUserID = My.User.Name.Substring(4)
            sUserID = "cbarton"

#End If

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

        Using cn As New SqlConnection(My.Settings.connectionString)
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



        If cboRefCodeId.EditValue Is Nothing Then
            With ErrorProvider
                .SetIconAlignment(Me.cboRefCodeId, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboRefCodeId, "A referral source is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboRefCodeId, "")

        End If


        'If cboIntDevYN.EditValue Is Nothing Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.cboIntDevYN, ErrorIconAlignment.MiddleRight)
        '        .SetError(Me.cboIntDevYN, "You need to indicate if this is an Integrated Development")
        '    End With
        '    result = False
        'Else
        '    ErrorProvider.SetError(Me.cboIntDevYN, "")

        'End If



        'If cboDesignatedYN.EditValue Is Nothing Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.cboDesignatedYN, ErrorIconAlignment.MiddleRight)
        '        .SetError(Me.cboDesignatedYN, "You need to indicate if this is an Designated Development")
        '    End With
        '    result = False
        'Else
        '    ErrorProvider.SetError(Me.cboDesignatedYN, "")

        'End If


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

            If cboRFSSubDivisionType.EditValue Is Nothing Then
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

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                cb.Text = String.Empty

            ElseIf TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.EditValue = Nothing

            ElseIf TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.EditValue = Nothing



            ElseIf TypeOf ctrl Is CheckEdit Then
                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)
                cb.EditValue = Nothing

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

        ibGoogleMaps.Enabled = False
        ibIntraMaps.Enabled = False

    End Sub

    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls

            If TypeOf ctrl Is Button Then

                Dim cb As Button = DirectCast(ctrl, Button)

                Select Case cb.Name

                    Case "btnViewNote", "btnPrintSewer", "btnPrintBldgCert", "btnEditBldgCert", "btnEditTrees", "btnEditLTW", "btnAddFile", "btnAddPIN", "btnAddFile", "btnAddNote"
                        cb.Enabled = True

                    Case "btnAddDA", "btnEditDA", "btnViewOfficers", "btnEditStatus", "btnMapMerge", "btnPrintAdvert", "btnPrintAdvNotice", "btnDesignated", "btnDesignIntegr"

                        cb.Enabled = True

                    Case "btnAddVariation", "btnAddSub", "btnEdit68", "btnAddFee", "btnAddRefund", "btnAddReferral", "btnEditReferralsTab"

                        cb.Enabled = True

                    Case "btnAddReferral", "btnNotesAdd", "btnADDAddinfoTab", "btnGoogle", "btnEnlighten"
                        cb.Enabled = True


                    Case Else
                        cb.Enabled = bLock

                End Select

            ElseIf TypeOf ctrl Is SimpleButton Then

                Dim cb As SimpleButton = DirectCast(ctrl, SimpleButton)

                Select Case cb.Name

                    Case "btnViewNote", "btnPrintSewer", "btnPrintBldgCert", "btnEditBldgCert", "btnEditTrees", "btnEditLTW", "btnAddFile", "btnAddPIN", "btnAddFile", "btnAddNote"
                        cb.Enabled = True

                    Case "btnAddDA", "btnEditDA", "btnViewOfficers", "btnEditStatus", "btnMapMerge", "btnPrintAdvert", "btnPrintAdvNotice", "btnDesignated", "btnDesignIntegr"

                        cb.Enabled = True

                    Case "btnAddVariation", "btnAddSub", "btnEdit68", "btnAddFee", "btnAddRefund", "btnAddReferral", "btnEditReferralsTab", "btnModifyAdvertAddress"

                        cb.Enabled = True

                    Case "btnAddReferral", "btnNotesAdd", "btnADDAddinfoTab", "btnGoogle", "btnEnlighten", "btnMaitList", "btnModifyDeptPlanning", "btnModifyDesignatedText"
                        cb.Enabled = True


                    Case "btnRemoveFile", "btnAckSub"
                        cb.Enabled = False



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


            ElseIf TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)


                Select Case cb.Name
                    Case "cboIntDevActs", "lupSection68" ',"cboReferralsIntProvision","cboRefCodeId",
                        cb.ReadOnly = False
                    Case Else
                        cb.ReadOnly = Not bLock


                End Select

                'If cb.Name <> "cboIntDevActs", "lupSection68" Then

                '    cb.ReadOnly = Not bLock
                'Else
                '    cb.ReadOnly = False

                'End If


            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = Not bLock


                'ElseIf TypeOf ctrl Is devexpress.XtraEditors.ButtonEdit Then
                '    Dim cb As ButtonEdit = DirectCast(ctrl, ButtonEdit)
                '    cb.ReadOnly = True

            ElseIf TypeOf ctrl Is NumericUpDown Then
                Dim cb As NumericUpDown = DirectCast(ctrl, NumericUpDown)
                cb.Enabled = bLock

            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = bLock


            ElseIf TypeOf ctrl Is CheckEdit Then
                Dim tb As CheckEdit = DirectCast(ctrl, CheckEdit)
                tb.ReadOnly = Not bLock


            ElseIf TypeOf ctrl Is DevExpress.XtraEditors.DateEdit Then
                Dim tb As DateEdit = DirectCast(ctrl, DateEdit)
                tb.ReadOnly = Not bLock

            ElseIf TypeOf ctrl Is TextEdit Then
                Dim tb As TextEdit = DirectCast(ctrl, TextEdit)

                If tb.Name = "mskDateAct" Then

                    tb.ReadOnly = False

                Else

                    tb.ReadOnly = Not bLock

                End If





                'ElseIf TypeOf ctrl Is TextEdit Then
                '    Dim tb As TextEdit = DirectCast(ctrl, TextEdit)
                'tb.ReadOnly = Not bLock



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
        Using cn As New SqlConnection(My.Settings.connectionString)
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
    Private Sub SaveTheStatus()

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        If Not cboDADecisionId.EditValue Is Nothing Then .Parameters.Add("@DADECISONID", SqlDbType.Int).Value = CInt(cboDADecisionId.EditValue)

                        .Parameters.Add("@REGODT", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@REGODT").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")
                        .Parameters.Add("@DATOPLANNER", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAToPlannerDt.Text) Then .Parameters("@DATOPLANNER").Value = Format(CDate(Me.DAToPlannerDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@SITEINSPECTED", SqlDbType.SmallDateTime)
                        If IsDate(Me.DASiteInspectedDt.Text) Then .Parameters("@SITEINSPECTED").Value = Format(CDate(Me.DASiteInspectedDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@PREASSESSCOMP", SqlDbType.SmallDateTime)
                        If IsDate(Me.PreAssessCompleteDate.Text) Then .Parameters("@PREASSESSCOMP").Value = Format(CDate(Me.PreAssessCompleteDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@REFTOCOMM", SqlDbType.SmallDateTime)
                        If IsDate(Me.RefToPlanCom.Text) Then .Parameters("@REFTOCOMM").Value = Format(CDate(Me.RefToPlanCom.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@TOTYPE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAToTypingDt.Text) Then .Parameters("@TOTYPE").Value = Format(CDate(Me.DAToTypingDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@DETERMINED", SqlDbType.SmallDateTime)
                        If IsDate(Me.DADetermDt.Text) Then .Parameters("@DETERMINED").Value = Format(CDate(Me.DADetermDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@APPNOTIFY", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAAppNotDt.Text) Then .Parameters("@APPNOTIFY").Value = Format(CDate(Me.DAAppNotDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@CONSENTPOSTED", SqlDbType.SmallDateTime)
                        If IsDate(Me.ConsentPostedDate.Text) Then .Parameters("@CONSENTPOSTED").Value = Format(CDate(Me.ConsentPostedDate.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@TREEFEE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAFreeTreeDt.Text) Then .Parameters("@TREEFEE").Value = Format(CDate(Me.DAFreeTreeDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@PUBCONSENT", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAConsentPubDt.Text) Then .Parameters("@PUBCONSENT").Value = Format(CDate(Me.DAConsentPubDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@OCCDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAOccDt.Text) Then .Parameters("@OCCDATE").Value = Format(CDate(Me.DAOccDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@PERMEXT", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAPermExDt.Text) Then .Parameters("@PERMEXT").Value = Format(CDate(Me.DAPermExDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@ADVISEDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DAAdvisedDt.Text) Then .Parameters("@ADVISEDATE").Value = Format(CDate(Me.DAAdvisedDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@COMMENTDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.DACommDt.Text) Then .Parameters("@COMMENTDTE").Value = Format(CDate(Me.DACommDt.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@COMPDATE", SqlDbType.SmallDateTime)
                        If IsDate(DACompletedDt.Text) Then .Parameters("@COMPDATE").Value = Format(CDate(Me.DACompletedDt.EditValue), "dd/MM/yyyy")

                        .Parameters.Add("@APZYESNO", SqlDbType.Int).Value = Me.chkAPZYesNo.CheckState
                        .Parameters.Add("@PROGCOMMENT", SqlDbType.NVarChar).Value = Me.txtProgressComment.Text

                        If Not cboDAAuthorityId.EditValue Is Nothing Then .Parameters.Add("@AUTHORITY", SqlDbType.Int).Value = CInt(cboDAAuthorityId.EditValue)
                        If Not cboProgressCode.EditValue Is Nothing Then .Parameters.Add("@PROGRESSCODE", SqlDbType.Int).Value = CInt(cboProgressCode.EditValue)
                        If Not cboReasonOver40.EditValue Is Nothing Then .Parameters.Add("@OVER40REASON", SqlDbType.Int).Value = CInt(cboReasonOver40.EditValue)

                        .Parameters.Add("@STOPCLOCK", SqlDbType.Int).Value = Me.chkAPZYesNo.CheckState

                        'If cboDAAuthorityId.Text <> String.Empty Then .Parameters.Add("@AUTHORITY", SqlDbType.Int).Value = CInt(cboDAAuthorityId.SelectedValue)

                        If Not cboAdvertSignDepot.EditValue Is Nothing Then .Parameters.Add("@ADVERTDEPOT", SqlDbType.NVarChar).Value = cboAdvertSignDepot.EditValue.ToString

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

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        If Not cboDevType.EditValue Is Nothing Then .Parameters.Add("@TYPEID", SqlDbType.Int).Value = CInt(cboDevType.EditValue)
                        If Not cboDevUse.EditValue Is Nothing Then .Parameters.Add("@USEID", SqlDbType.Int).Value = CInt(Me.cboDevUse.EditValue)
                        .Parameters.Add("@DESC", SqlDbType.NVarChar).Value = Me.txtDADesc.Text
                        If txtDAestCost.Text <> String.Empty Then .Parameters.Add("@ESTCOST", SqlDbType.Money).Value = CDbl(txtDAestCost.Text)
                        .Parameters.Add("@FLOOR", SqlDbType.Int)
                        If IsNumeric(Me.txtDAFloor.Text) Then
                            .Parameters("@FLOOR").Value = CInt(txtDAFloor.Text)
                        End If
                        .Parameters.Add("@CONSENTTYPE", SqlDbType.Int).Value = CInt(cboConsentType.EditValue)
                        If cboDAtype1.Text <> String.Empty Then .Parameters.Add("@DATYPE1", SqlDbType.Int).Value = CInt(Me.cboDAtype1.EditValue)
                        If cboDAType2.Text <> String.Empty Then .Parameters.Add("@DATYPE2", SqlDbType.Int).Value = CInt(Me.cboDAType2.EditValue)
                        If cboDAtype3.Text <> String.Empty Then .Parameters.Add("@DATYPE3", SqlDbType.Int).Value = CInt(Me.cboDAtype3.EditValue)
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
        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        If Not cboDAlocalityCode.EditValue Is Nothing Then .Parameters.Add("@LOCALITY", SqlDbType.Int).Value = CInt(cboDAlocalityCode.EditValue)

                        .Parameters.Add("@OWNERNAME", SqlDbType.NVarChar).Value = txtDAOwnersName.Text
                        .Parameters.Add("@OWNERADDRESS", SqlDbType.NVarChar).Value = txtDAOwnersAddress.Text
                        .Parameters.Add("@OWNERTOWN", SqlDbType.NVarChar).Value = txtDAOwnersTown.Text
                        .Parameters.Add("@OWNERPCODE", SqlDbType.SmallInt).Value = NZ(txtDAOwnersPcode.Text)
                        .Parameters.Add("@OWNERPHONE", SqlDbType.NVarChar).Value = txtDAOwnersPhone.Text
                        If txtArea.Text <> String.Empty Then .Parameters.Add("@DAAREA", SqlDbType.Float).Value = CDbl(txtArea.Text)
                        .Parameters.Add("@AREAUNIT", SqlDbType.NVarChar).Value = Me.cboAreaType.EditValue.ToString

                        .Parameters.Add("@CENSUS", SqlDbType.NVarChar).Value = Me.cboDACensusCode.EditValue.ToString

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

    Private Sub CheckIfDataChanged()
        Dim changed As Boolean = False

        If BiSaveDA.Enabled Then
            changed = True
        End If

        If changed Then
            If MessageBox.Show("It appears you have updated some information, save the changes?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                If BiSaveDA.Enabled Then btnSaveDA_ClickExtracted()


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


            ElseIf TypeOf ctrl Is TextEdit Then
                Dim tb As TextEdit = DirectCast(ctrl, TextEdit)
                tb.Text = String.Empty


            ElseIf TypeOf ctrl Is LookUpEdit Then
                Dim tb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                tb.EditValue = Nothing


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


                    grdPIN.DataSource = objDT



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfPINS routine - form " & Me.Name)

            End Try
        End Using


    End Sub


#End Region

#Region "Build Documents"




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

                        .Parameters.Add("@id", SqlDbType.Int).Value = CInt(cboOtherDocs.EditValue)
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docType = CInt(cboOtherDocs.EditValue)
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

                    Select Case docname

                        Case "N", "NA"

                            If Me.DACompletedDt.Text = String.Empty Then

                                MessageBox.Show("Unable to proceed as these letters require Close of submission date to be completed", "Unable to Generate", MessageBoxButtons.OK)
                                Return

                            End If

                            Dim MapMergeCompleted As Boolean = False


                            'Dim fMapMerge As New DAMApMerge
                            Dim fMapMerge As New ImportAdjacentPropertiesForMailMerge

                            With fMapMerge
                                .DAnumber = txtDANo.Text
                                .ShowDialog()
                                MapMergeCompleted = .FileGenerated
                                .Dispose()

                            End With

                            If Not MapMergeCompleted Then
                                MessageBox.Show("Unable to proceed as these letters require MAPmerge data from Enlighten", "Unable to Generate", MessageBoxButtons.OK)
                                Return
                            End If



                            PrintAdjacentMailMerge(txtDANo.Text, docType, docname, docfilename)

                            RemoveOldMapData(txtDANo.Text)


                        Case Else

                            PrintConsentLetterMailMerge(txtDANo.Text, docType, docname, docfilename)



                    End Select


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

    Private Sub RemoveOldMapData(DANo As String)


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

    Private Sub btnInsertIntoLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertIntoLive.Click

        If MessageBox.Show("You are about to copy all the proposed contribution records for this DA and add them to the 'Live' Section 94 Register!  OK to proceed?", "Update the Contributions Register", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub






        Using cn As New SqlConnection(My.Settings.connectionString)
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

        BiSection94.Enabled = True

    End Sub

    Private Sub btnAssembleLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssembleLetter.Click

        If cboConsentDocType.EditValue Is Nothing Then

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



        SplashScreenManager.ShowForm(GetType(WaitForm))


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

                        .Parameters.Add("@id", SqlDbType.Int).Value = CInt(cboConsentDocType.EditValue)
                    End With




                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            docType = CInt(cboConsentDocType.EditValue)
                            docname = objDataReader.Item(0).ToString
                            docfilename = objDataReader.Item(1).ToString
                            MacroName = objDataReader.Item(2).ToString
                        Loop
                        objDataReader.Close()
                    End Using



                End Using

                Select Case docType
                    Case 98

                        PrintConsentLetterMailMerge(txtDANo.Text, 102, "CONSENTCOVER", My.Settings.ConstructionCertificates & "Consent_Cover_Letter.dotx")

                    Case 100, 107

                        CreateWordDocs(108, Me.txtDANo.Text, "DAModConsentCoverLetter", My.Settings.ConstructionCertificates & "Modification Consent Cover Letter.dotm", sysType, MacroName)
                        'PrintModificationConsentLetterMailMerge(txtDANo.Text, 106, "MODCONSENTCOVER", My.Settings.ConstructionCertificates & "Modification Consent Cover Letter.dotx")

                    Case Else

                End Select


                CreateWordDocs(docType, Me.txtDANo.Text, docname, docfilename, sysType, MacroName)

                DisplayListOfDraftDocuments(Me.txtDANo.Text)
                'RemoveStandardConditions()
                'RemoveOneUptandardConditions()
                LoadUpConditionsList(txtDANo.Text)
                LoadUpOneUpConditions(txtDANo.Text)

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAssembleLetter_Click routine - form " & Me.Name)

            Finally


                SplashScreenManager.CloseForm()
            End Try
        End Using


    End Sub


    Private Sub PrintConsentLetterMailMerge(ByVal AppNo As String, ByVal DocType As Integer, ByVal DocName As String, ByVal docfilename As String)

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

                        Select Case DocName


                            Case "OA", "OAK", "OAW", "OAR"

                                .CommandText = "usp_WordTemplate_CoverLetterMailMerge"

                            Case Else
                                .CommandText = "usp_WordTemplate_DAApproval_CoverLetterMailMerge"


                        End Select



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


        Dim objStreamWriter As StreamWriter

        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\Covermailmerge.txt") Then _
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\Covermailmerge.txt", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\Covermailmerge.txt")

        objStreamWriter.WriteLine("""DANO"",""DAFileNo"",""Name"",""Address"",""Town"",""Postcode"",""Developmentdesc"",""PropertyDesc"",""DPNO"",""LotNo"",""Phone"",""Officer"",""Title"",""ObjectorName"",""ObjectorAddress1"",""ObjectorAddress2"",""ObjectorPostcode""")


        For Each objDataRow As DataRow In objDT.Rows

            objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("DAFileNo").ToString & """,""" & objDataRow.Item("DAAppName").ToString & """,""" &
                                       objDataRow.Item("DAAppAddr").ToString & """,""" & objDataRow.Item("DAAppTown").ToString & """,""" &
                                       objDataRow.Item("DAAppPC").ToString & """,""" & objDataRow.Item("DADesc").ToString & """,""" &
                                       objDataRow.Item("AddressFormatted").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString & """,""" & objDataRow.Item("Phone").ToString & """,""" & objDataRow.Item("Officer").ToString & """,""" & objDataRow.Item("Title").ToString & """,""" & objDataRow.Item("ObjectorName").ToString & """,""" &
                                       objDataRow.Item("AuthorAddressLine1").ToString & """,""" & objDataRow.Item("AuthorAddressLine2").ToString & """,""" & objDataRow.Item("AuthorPcode").ToString & """")


        Next



        objStreamWriter.Close()


        BuildCoverLetterMailMergeDocuments(AppNo, DocName, docfilename, DocType)




    End Sub

    Private Sub PrintModificationConsentLetterMailMerge(ByVal AppNo As String, ByVal DocType As Integer, ByVal DocName As String, ByVal docfilename As String)

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
                        .CommandText = "usp_WordTemplate_MOdificationCoverLetterMailMerge"


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


        Dim objStreamWriter As StreamWriter

        If IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\Covermailmerge.txt") Then _
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\Covermailmerge.txt", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)

        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.Temp & "\Covermailmerge.txt")
        'objStreamWriter = New StreamWriter("D:\temp\Covermailmerge.txt")

        'objStreamWriter.WriteLine("""DANO"",""DAFileNo"",""Name"",""Address"",""Town"",""Postcode"",""Developmentdesc"",""PropertyDesc"",""DPNO"",""LotNo"",""Phone"",""ModNo"",""ModDesc""")
        objStreamWriter.WriteLine("""DANO"",""DAFileNo"",""Name"",""Address"",""Town"",""Postcode"",""Developmentdesc"",""PropertyDesc"",""DPNO"",""LotNo"",""Phone"",""Officer"",""Title"",""ModNo"",""ModDesc""")


        For Each objDataRow As DataRow In objDT.Rows

            'objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("DAFileNo").ToString & """,""" & objDataRow.Item("DAAppName").ToString & """,""" &
            '                           objDataRow.Item("DAAppAddr").ToString & """,""" & objDataRow.Item("DAAppTown").ToString & """,""" &
            '                           objDataRow.Item("DAAppPC").ToString & """,""" & objDataRow.Item("DADesc").ToString & """,""" &
            '                           objDataRow.Item("AddressFormatted").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString & """,""" &
            '                           objDataRow.Item("Phone").ToString & """,""" & objDataRow.Item("ModNo").ToString & """,""" &
            '                           objDataRow.Item("ModDesc").ToString & """")
            objStreamWriter.WriteLine("""" & objDataRow.Item("DANo").ToString & """,""" & objDataRow.Item("DAFileNo").ToString & """,""" & objDataRow.Item("DAAppName").ToString & """,""" &
                                       objDataRow.Item("DAAppAddr").ToString & """,""" & objDataRow.Item("DAAppTown").ToString & """,""" &
                                       objDataRow.Item("DAAppPC").ToString & """,""" & objDataRow.Item("DADesc").ToString & """,""" &
                                       objDataRow.Item("AddressFormatted").ToString & """,""" & objDataRow.Item("DADP").ToString & """,""" & objDataRow.Item("DALot").ToString & """,""" &
                                       objDataRow.Item("Phone").ToString & """,""" & objDataRow.Item("Officer").ToString & """,""" & objDataRow.Item("Title").ToString & """,""" & objDataRow.Item("ModNo").ToString & """,""" &
                                       objDataRow.Item("ModDesc").ToString & """")


        Next



        objStreamWriter.Close()


        BuildCoverLetterMailMergeDocuments(AppNo, DocName, docfilename, DocType)




    End Sub

    Private Sub BuildCoverLetterMailMergeDocuments(ByVal AppNo As String, ByVal docname As String, ByVal docFileName As String, ByVal DocType As Integer)

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
                    My.Computer.FileSystem.SpecialDirectories.Temp & "\Covermailmerge.txt",
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




    Private Sub gvwDraftDocs_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwDraftDocs.RowClick





        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)




        btnViewEditDocument.Enabled = True
        btnDeleteDoc.Enabled = True
        btnFinaliseDoc.Enabled = True


        If txtAppemail.Text <> String.Empty Then btnEmailAcknowledge.Enabled = myobj.Row.Item("Docname").ToString = "DAACKN"





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



    Private Sub btnRemoveOneOffCond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveOneOffCond.Click

        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim myobj As DataRowView = CType(gvwOneUpConditions.GetFocusedRow, DataRowView)



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
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("UniqueId"))
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



    Private Sub btnRemoveCondition_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveCondition.Click


        If MessageBox.Show("Remove the selected on up condition?", "Remove Condition", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim myobj As DataRowView = CType(gvwSTDConditions.GetFocusedRow, DataRowView)

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
                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("Id"))
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


                    grdDraftDocs.DataSource = objDT
                    grdDraftDocs.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfDraftDocuments routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private Sub DisplayListOfSubmissionDraftDocuments(ByVal AANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfSubmissionDraftDocuments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT DisplayListOfDraftSubmissionDocuments"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = AANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdSubmissionDrafts.DataSource = objDT
                    grdSubmissionDrafts.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in DisplayListOfSubmissionDraftDocuments routine - form " & Me.Name)

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

                    With cboSTDconditions.Properties
                        .Columns.Clear()
                        .DataSource = objDT
                        .DisplayMember = "Condition"
                        .ValueMember = "Id"
                        .ShowFooter = False
                        .ShowHeader = False

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

        Using cn As New SqlConnection(My.Settings.connectionString)
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

        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)


        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return



        Try

            Dim WRD As New OpenDocument
            WRD.OpenVisible(myobj.Row.Item("DraftDocPath").ToString)


        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnDeleteDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteDoc.Click

        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)



        If myobj.Row.Item("AppNo").ToString = String.Empty Then Return


        Dim FileToDelete As String = myobj.Row.Item("DraftDocPath").ToString


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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DraftDocId"))
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



        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)

        Dim FileToDelete As String = myobj.Row.Item("DraftDocPath").ToString
        Dim DocumentType As String = myobj.Row.Item("Description").ToString
        Dim DocID As Integer = CInt(myobj.Row.Item("DraftDocId"))



        'If dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "ModConsent" Or dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "StdConsent" Then

        'If myobj.Row.Item("Docname").ToString = "ModConsent" Or myobj.Row.Item("Docname").ToString = "DAConsent" Then

        Select Case myobj.Row.Item("Docname").ToString

            Case "ModConsent", "DAConsent", "DAModConsent"


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


        End Select


        'End If

        If MessageBox.Show("You are about to finalise this document. That is, no more changes are to be made. OK to proceed?", "Finalise Document?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        Dim summary As String = "Application No. " & txtDANo.Text & " Document Type: " & DocumentType

        Dim Recepient As Integer


        With My.Forms.WhoAreYouSendingMailTo
            .ShowDialog()
            Recepient = .Recepient
            .Dispose()

        End With

        'TODO: EASE DevelopmentStart DONE?

        With My.Forms.InsertEASEDocument



            Select Case Recepient
                Case 1

                    .CustName = txtDAOwnersName.Text
                    .CustAddress = txtDAOwnersAddress.Text & " " & txtDAOwnersTown.Text & " " & txtDAOwnersPcode.Text

                Case 2

                    .CustName = txtAppName.Text
                    .CustAddress = txtAppAddress.Text & " " & txtAppTown.Text & " " & txtAppPcode.Text


            End Select


            .WordDocLocation = myobj.Row.Item("DraftDocPath").ToString
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
            .DocumentType = myobj.Row.Item("Docname").ToString
            .ApplicationNo = Me.txtDANo.Text
            .TheAuthor = MyUserId
            .TheImageName = sDocumentNo.Replace(".", "_")
            .Notes = summary
            .InsertDocumentsIntoDAsystem()
            NewRecordID = .DocumentID

        End With




        If DocumentType = "Development Consent" Then


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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = DocID
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

        Me.btnEditReferralsTab.Enabled = False
        btnSaveReferralsTab.Enabled = True
        ClearReferralData(grpMain)
        Me.lblReferralID.Text = String.Empty


        'LockTheForm(pnlButtons, True)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        txtRefComm.ReadOnly = False

        LoadLstIntegrated(txtDANo.Text)
        btnAddReferral.Enabled = False
        btnEditReferralsTab.Enabled = False
        Refdt.ReadOnly = False
        RefRetDt.ReadOnly = False
    End Sub

    Private Sub SaveReferralData()
        btnEditReferralsTab.Enabled = True
        btnSaveReferralsTab.Enabled = False
        LockTheForm(grpMain, False)
        LockTheForm(pnlButtons, False)
        'LockTheForm(pnlEditButtons, False)
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
                        .Parameters.Add("@REFCODEID", SqlDbType.Int).Value = CInt(cboRefCodeId.EditValue)
                        '.Parameters.Add("@SEPP71IMPACTS", SqlDbType.NVarChar).Value = Me.txtSepp71LikelyImpacts.Text
                        .Parameters.Add("@REFCOMMENT", SqlDbType.NText).Value = Me.txtRefComm.Text
                        .Parameters.Add("@REFRESPONSE", SqlDbType.NText).Value = Me.txtRefResponse.Text
                        .Parameters.Add("@SEPP71REFER", SqlDbType.Bit).Value = Me.chksepp71.CheckState
                        '.Parameters.Add("@SEPP71INTDEV", SqlDbType.Bit).Value = Me.chkIntDev.CheckState
                        '.Parameters.Add("@SEPP71SENSITIVE", SqlDbType.Bit).Value = Me.chkSensitive.CheckState
                        '.Parameters.Add("@SEPP711100MARK", SqlDbType.Bit).Value = Me.chk100Mark.CheckState
                        '.Parameters.Add("@SEPP71SCH3", SqlDbType.Bit).Value = Me.chkSch3.CheckState
                        .Parameters.Add("@RFSSUBDIV", SqlDbType.NVarChar)
                        If Not cboRFSSubDivisionType.EditValue Is Nothing Then .Parameters("@RFSSUBDIV").Value = Me.cboRFSSubDivisionType.EditValue.ToString()
                        .Parameters.Add("@RFSLOTS", SqlDbType.Int)
                        If txtRFSSubLots.Text <> String.Empty Then .Parameters("@RFSLOTS").Value = CInt(txtRFSSubLots.Text)
                        .Parameters.Add("@ENGCOMMENTS", SqlDbType.NText).Value = Me.txtEngInternalComments.Text
                        .Parameters.Add("@ENDRETDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.EngDueReturnDate.Text) Then .Parameters("@ENDRETDTE").Value = Format(CDate(EngDueReturnDate.EditValue), "dd/MM/yyyy")

                        If Not cboIntDevYN.EditValue Is Nothing Then .Parameters.Add("@INTDEVYN", SqlDbType.NVarChar).Value = Me.cboIntDevYN.EditValue.ToString
                        If Not cboDesignatedYN.EditValue Is Nothing Then .Parameters.Add("@DESIGYN", SqlDbType.NVarChar).Value = cboDesignatedYN.EditValue.ToString


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
        'LockTheForm(pnlButtons, True)
        LockTheForm(grpMain, True)
        LockTheForm(grpRFS, True)
        LockTheForm(grpIntDesig, True)
        LockTheForm(grpEngineers, True)
        'LockTheForm(grpSepp71, True)
        Refdt.ReadOnly = False
        RefRetDt.ReadOnly = False

    End Sub

    Private Sub btnSaveReferralsTab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveReferralsTab.Click
        If Not CheckReferralData() Then Exit Sub
        SaveReferralData()

        If NZ(lblReferralID.Text) = 0 Then


            Dim Addresses(0) As String
            Dim attachments(0) As String

            SendEmail.SendEmail(Addresses, "Referral for Development Application" & txtDANo.Text, "Please refer to  Development Application " & txtDANo.Text, attachments)

        End If


        ClearReferralData(grpMain)
        Refdt.ReadOnly = True
        RefRetDt.ReadOnly = True

    End Sub






    Private Sub gvwLoadListReferrals_RowClick(ByVal sender As System.Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwLoadListReferrals.RowClick



        Try

            Dim myobj As DataRowView = CType(gvwLoadListReferrals.GetFocusedRow, DataRowView)


            LoadReferralDetails(CInt(myobj.Row.Item("ReferralId")))

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        LockTheForm(pnlButtons, True)

        'LockTheForm(grpMain, False)
        'LockTheForm(grpRFS, False)
        'LockTheForm(grpIntDesig, False)
        'LockTheForm(grpEngineers, False)
        'LockTheForm(grpSepp71, False)
        btnView.Enabled = True
        Me.btnEditReferralsTab.Enabled = True
        Me.btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.EditValue)

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
        cboRefCodeId.EditValue = Nothing
        txtRefComm.Text = String.Empty
        txtRefResponse.Text = String.Empty
        chksepp71.Checked = False
        'chkIntDev.Checked = False
        'chkSensitive.Checked = False
        'chk100Mark.Checked = False
        'chkSch3.Checked = False
        cboRFSSubDivisionType.EditValue = Nothing
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
                        If Not IsDBNull(objDataRow.Item("RefCodeId")) Then cboRefCodeId.EditValue = CInt(objDataRow.Item("RefCodeId"))
                        'txtSepp71LikelyImpacts.Text = objDataRow.Item("Sepp71LikelyImpacts").ToString
                        txtRefComm.Text = objDataRow.Item("RefComm").ToString
                        txtRefResponse.Text = objDataRow.Item("RefResponse").ToString
                        chksepp71.Checked = CBool(objDataRow.Item("Sepp71Refer"))

                        grpRFS.Visible = chksepp71.Checked

                        If Not IsDBNull(objDataRow.Item("BinaryDocument")) Then

                            With btnAddPDF

                                .Text = "View Document"
                                .Tag = "VIEW"
                                .Enabled = True

                            End With

                            btnRemovePDF.Enabled = True

                        Else
                            With btnAddPDF

                                .Text = "Add PDF/Image"
                                .Tag = "ADD"

                            End With

                            btnRemovePDF.Enabled = False

                        End If

                        'chkIntDev.Checked = CBool(objDataRow.Item("Sepp71IntDev"))
                        'chkSensitive.Checked = CBool(objDataRow.Item("Sepp71Sensitive"))
                        'chk100Mark.Checked = CBool(objDataRow.Item("Sepp71100Mark"))
                        'chkSch3.Checked = CBool(objDataRow.Item("Sepp71Schedule3"))
                        If Not IsDBNull(objDataRow.Item("RFSSubDiv")) Then cboRFSSubDivisionType.EditValue = objDataRow.Item("RFSSubDiv").ToString
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


    Private Function GetReferralConditions() As DataTable

        Dim objDT As New DataTable

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
                        .CommandText = "usp_rpt_ReferralResponseSubReport"

                        .Parameters.Add("@REFID", SqlDbType.Int).Value = NZ(lblReferralID.Text)


                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "referralResponseCond")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\referralResponsecond.xsd")

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


        Return objDT

    End Function

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

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "referralResponse")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\referralResponse.xsd")


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



                    Dim rept As New ReferralResponse

                    rept.DataSource = objDT

                    rept.ReferralConditions = GetReferralConditions()

                    rept.CreateDocument()

                    Using printTool As New ReportPrintTool(rept)
                        ' Invoke the Ribbon Print Preview form modally, 
                        ' and load the report document into it.
                        printTool.ShowPreviewDialog()

                        ' Invoke the Ribbon Print Preview form
                        ' with the specified look and feel setting.
                        printTool.ShowPreview(UserLookAndFeel.Default)
                    End Using


                    'Try

                    '    'Pass the reportname to string variable 
                    '    Dim strReportPath As String = My.Settings.ReportLocation & "ReferralResponse.rpt"

                    '    'Check file exists
                    '    If Not IO.File.Exists(strReportPath) Then
                    '        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
                    '    End If

                    '    Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                    '    myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                    '    myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
                    '    myPrintOptions.CustomPaperSource = GetSelectedSecondPaperSource()


                    '    With rptDocument
                    '        .Load(strReportPath)
                    '        .SetDataSource(objDT)
                    '        .VerifyDatabase()
                    '    End With


                    '    rptDocument.PrintToPrinter(1, False, 1, 1)


                    'Catch ex As Exception
                    '    MessageBox.Show(ex.Message & " in function btnReferral_Click")
                    'Finally
                    '    rptDocument.Close()

                    'End Try



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
        'LockTheForm(pnlEditButtons, False)

        LockTheForm(grpMain, False)
        LockTheForm(grpRFS, False)
        LockTheForm(grpIntDesig, False)
        LockTheForm(grpEngineers, False)
        'LockTheForm(grpSepp71, False)
        btnView.Enabled = True
        Me.btnEditReferralsTab.Enabled = False
        Me.btnAddReferral.Enabled = True
        btnSaveReferralsTab.Enabled = False

        Select Case CInt(cboRefCodeId.EditValue)

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

    Private Sub cboReferralsIntProvision_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReferralsIntProvision.EditValueChanged

        btnAddIntegrated.Enabled = True

    End Sub

    Private Sub btnAddIntegrated_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddIntegrated.Click
        If Not cboReferralsIntProvision.EditValue Is Nothing Then

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
                                .Parameters.Add("@PROVISIONID", SqlDbType.Int).Value = CInt(cboReferralsIntProvision.EditValue)
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
                cboReferralsIntProvision.EditValue = Nothing
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
                        .ValueMember = "id"
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


            ElseIf TypeOf ctrl Is LookUpEdit Then
                Dim cb As LookUpEdit = DirectCast(ctrl, LookUpEdit)
                cb.EditValue = Nothing

            ElseIf TypeOf ctrl Is TextEdit Then
                Dim cb As TextEdit = DirectCast(ctrl, TextEdit)
                cb.EditValue = Nothing



            ElseIf TypeOf ctrl Is CheckEdit Then
                Dim cb As CheckEdit = DirectCast(ctrl, CheckEdit)
                cb.EditValue = Nothing



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

                    grdPaymentsReceived.DataSource = objDT

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


                    grdDARefundsPaid.DataSource = objDT

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




            Dim myobj As DataRowView = CType(gvwPaymentsReceived.GetFocusedRow, DataRowView)



            With My.Forms.AddPayment
                .TheSystemType = "DA"
                .IndexID = CInt(myobj.Row.Item("PaymentId"))
                .AppID = txtDANo.Text
                .PayId = CInt(myobj.Row.Item("InspTypeId"))
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


        Dim myobj As DataRowView = CType(gvwPaymentsReceived.GetFocusedRow, DataRowView)



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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("PaymentId"))
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

            Dim myobj As DataRowView = CType(gvwDARefundsPaid.GetFocusedRow, DataRowView)


            With fFee

                .TheSystemType = "DA"
                .IDindex = CInt(myobj.Row.Item("RefundIDX"))

                .AppID = txtDANo.Text
                .PayId = CInt(myobj.Row.Item("RefundTypeId"))
                .ShowDialog()
                .Dispose()
            End With

            LoadRefundsPaid(txtDANo.Text)

            CalculateRefundsandPayments(txtDANo.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
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

        Dim myobj As DataRowView = CType(gvwDARefundsPaid.GetFocusedRow, DataRowView)


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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("RefundIDX"))
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

                    grdFileNotes.DataSource = objDT


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
        Me.cboNoteType.EditValue = Nothing
        Me.txtNotesSpokeTo.Text = String.Empty
        Me.txtNotesCC.Text = String.Empty
        Me.txtNotesFollowUp.Text = String.Empty
        lblNotesID.Text = "0"
        Me.cboNotesOfficer.EditValue = Nothing
        Me.btnEditNote.Enabled = False
        Me.btnSaveNote.Enabled = False
        btnAddNote.Enabled = True
        Me.btnNotePrint.Enabled = False
    End Sub

    Private Sub LockNotes(ByVal lock As Boolean)
        Me.NoteDate.ReadOnly = lock
        Me.txtNotesSubject.ReadOnly = lock
        Me.txtNoteDetails.ReadOnly = lock
        Me.txtNotesContactNo.ReadOnly = lock
        Me.cboNoteType.ReadOnly = lock
        Me.txtNotesSpokeTo.ReadOnly = lock
        Me.txtNotesCC.ReadOnly = lock
        Me.txtNotesFollowUp.ReadOnly = lock
        Me.cboNotesOfficer.ReadOnly = lock
        Me.btnEditNote.Enabled = lock
        Me.btnSaveNote.Enabled = Not lock
        btnAddNote.Enabled = True
        Me.btnNotePrint.Enabled = True
    End Sub
    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        ClearNoteFields()
        LockNotes(False)
        Me.btnSaveNote.Enabled = True
        btnAddNote.Enabled = False
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = False
    End Sub

    Private Sub btnNotesEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditNote.Click
        LockNotes(False)
        Me.btnSaveNote.Enabled = True
        btnAddNote.Enabled = True
        btnEditNote.Enabled = False
        btnNotePrint.Enabled = True

    End Sub

    Private Sub btnNotesSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveNote.Click
        SaveNotesData()
        ClearNoteFields()
        LockNotes(True)
        Me.btnSaveNote.Enabled = False
        btnAddNote.Enabled = True
        btnEditNote.Enabled = False
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
                        .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = Me.cboNoteType.EditValue.ToString
                        .Parameters.Add("@SPOKEN", SqlDbType.NVarChar).Value = Me.txtNotesSpokeTo.Text
                        .Parameters.Add("@CC", SqlDbType.NVarChar).Value = Me.txtNotesCC.Text
                        .Parameters.Add("@FOLLOWUP", SqlDbType.NVarChar).Value = Me.txtNotesFollowUp.Text
                        If Not cboNotesOfficer.EditValue Is Nothing Then .Parameters.Add("@AUTHOR", SqlDbType.NVarChar).Value = Me.cboNotesOfficer.EditValue.ToString
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

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "FILENOTES")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\FileNotes.xsd")


                    Dim rept As New FileNotes

                    rept.DataSource = objDT


                    Using printTool As New ReportPrintTool(rept)
                        ' Invoke the Ribbon Print Preview form modally, 
                        ' and load the report document into it.
                        printTool.ShowPreviewDialog()

                        ' Invoke the Ribbon Print Preview form
                        ' with the specified look and feel setting.
                        printTool.ShowPreview(UserLookAndFeel.Default)
                    End Using



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
                        .CommandText = "usp_RetrieveDAFileNumbers"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = CDNo
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

    Private Sub lstFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFile.SelectedIndexChanged

        btnRemoveFile.Enabled = True

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


    Private Sub btnRemoveDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDocument.Click

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

            With My.Forms.PDFDocumentViewer

                .DocumentToView = sPDFDoc

                '.PdfViewer.LoadDocument(sPDFDoc)
                .ShowDialog()
                .Dispose()


            End With
            'Dim WRD As New OpenDocument
            'WRD.OpenVisible(sPDFDoc)


            'Dim PDFviewer As New PDFviewer
            'With PDFviewer
            '    .DocumentToDisplay = sPDFDoc
            '    .ShowDialog()
            '    .Dispose()
            'End With


        End If


        'End If




    End Sub





#End Region

#Region "PCA Cond Tab"


    Private Sub UpdateConditionDate(ByVal type As Integer)
        If MessageBox.Show("Mark this condition as being met now?", "Mark condition met", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Using cn As New SqlConnection(My.Settings.connectionString)
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





                                Dim myobj As DataRowView = CType(gvwSTDCond.GetFocusedRow, DataRowView)

                                .Parameters.Add("@IDNO", SqlDbType.Int).Value = CInt(myobj.Row.Item("AppCondId"))
                            Case 2

                                Dim myobj As DataRowView = CType(gvwOneOffConditions.GetFocusedRow, DataRowView)

                                .Parameters.Add("@IDNO", SqlDbType.Int).Value = CInt(myobj.Row.Item("UniqueId"))

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

                    grdOneOffConditions.DataSource = objDT

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

                    grdSTDCond.DataSource = objDT
                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSTDConditionsPriorToCCRelease routine - form " & Me.Name)

            End Try
        End Using



    End Sub
#End Region

#Region "Section68andIntDev"


    Private Sub btnInsert68_Click(sender As Object, e As EventArgs) Handles btnInsert68.Click
        'Edit Sec68 Tab
        'LockTheForm(grp68, True)
        'grp68.Enabled = True
        btnInsert68.Enabled = False
        'Me.btnSave68.Enabled = True


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnInsert68_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "INSERT_Section68Item"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                        .Parameters.Add("@ITEMID", SqlDbType.Int).Value = CInt(lupSection68.EditValue)

                        .ExecuteNonQuery()

                    End With



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnInsert68_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadSection68(txtDANo.Text)

        lupSection68.EditValue = Nothing
    End Sub

    Private Sub btnRemove68_Click(sender As Object, e As EventArgs) Handles btnRemove68.Click




        Dim myobj As DataRowView = CType(gvwSection68.GetFocusedRow, DataRowView)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemove68_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_Section68Item"

                        .Parameters.Add("@ITEMID", SqlDbType.Int).Value = CInt(myobj.Row.Item("sectIdx"))

                        .ExecuteNonQuery()

                    End With




                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemove68_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadSection68(txtDANo.Text)

    End Sub


    Private Sub cboIntDevActs_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIntDevActs.EditValueChanged
        btnAddIntDev.Enabled = Not cboIntDevActs.EditValue Is Nothing
        mskDateAct.ReadOnly = False

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






            Dim myobj As DataRowView = CType(gvwIntDev.GetFocusedRow, DataRowView)


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
                            .CommandText = "usp_UPDATE_IntDevActDate"

                            .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("idx"))
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
            cboIntDevActs.EditValue = Nothing
            mskDateAct.EditValue = Nothing

            Exit Sub

        End If





        Using cn As New SqlConnection(My.Settings.connectionString)
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

        cboIntDevActs.EditValue = Nothing
        mskDateAct.EditValue = Nothing

        btnAddIntDev.Enabled = False
        btnRemoveIntDev.Enabled = False
        loadIntDevGrid(txtDANo.Text)


    End Sub

    Private Sub btnMaitList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaitList.Click
        With My.Forms.MaintainIntDevListofActs

            .ShowDialog()

            .Dispose()


        End With


    End Sub

    Private Sub LoadIntDevCombo()

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                    With cboIntDevActs.Properties
                        .DataSource = objDT
                        .DisplayMember = "DescriptionOfAct"
                        .ValueMember = "id"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboIntDevActs.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DescriptionOfAct", 0))
                    col2.Add(New LookUpColumnInfo("id", 0))

                    col2.Item(1).Visible = False

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadIntDevCombo routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub LoadSection68(DANumber As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection68 routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_ListOfSection68ItemsForDA"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANumber



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdSection68.DataSource = objDT


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection68 routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub loadIntDevGrid(ByVal DANo As String)

        Using cn As New SqlConnection(My.Settings.connectionString)
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


                    grdIntDev.DataSource = objDT

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
        cboAdvertSignDepot.ReadOnly = False
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
        cboAdvertSignDepot.ReadOnly = True
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


    'Private Function DepotHasNotBeenSet() As Boolean

    '    Dim result As Boolean

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in DepotHasNotBeenSet routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "StoredProcedureName"

    '                    .Parameters.Add("", SqlDbType.VarChar).Value = txtDANo.Text


    '                End With

    '                Dim objDT As New DataTable


    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using



    '            End Using



    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in DepotHasNotBeenSet routine - form " & Me.Name)

    '        End Try
    '    End Using



    '    Return result

    'End Function
    Private Sub btnPrintAdvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAdvert.Click

        'If DepotHasNotBeenSet Then Return


        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "Advertising")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\AdvertisingSign.xsd")


                End Using

                Dim rept As New AdvertisingSign

                rept.DataSource = objDT
                rept.lblDepotAdvert.Text = txtDepotAddress.Text

                Using printTool As New ReportPrintTool(rept)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    printTool.ShowPreviewDialog()

                    ' Invoke the Ribbon Print Preview form
                    ' with the specified look and feel setting.
                    printTool.ShowPreview(UserLookAndFeel.Default)
                End Using


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnPrintAdvNotice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrintAdvNotice.Click
        'Dim OwnerName As String = String.Empty
        'Dim OwnerAddress As String = String.Empty
        'Dim FileNo As String = String.Empty
        ''Dim rptDocument As New ReportDocument



        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
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


                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "Advertising")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\AdvertisingNotice.xsd")



                    Dim rept As New NoticeOfAdvertising

                    rept.DataSource = objDT


                    Using printTool As New ReportPrintTool(rept)
                        ' Invoke the Ribbon Print Preview form modally, 
                        ' and load the report document into it.
                        printTool.ShowPreviewDialog()

                        ' Invoke the Ribbon Print Preview form
                        ' with the specified look and feel setting.
                        printTool.ShowPreview(UserLookAndFeel.Default)
                    End Using



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnDesignated_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesignated.Click
        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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



                Dim rept As New AdvertisingSignDesignated

                rept.DataSource = objDT

                rept.lblDepotAdvert.Text = txtDepotAddress.Text


                Using printTool As New ReportPrintTool(rept)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    printTool.ShowPreviewDialog()

                    ' Invoke the Ribbon Print Preview form
                    ' with the specified look and feel setting.
                    printTool.ShowPreview(UserLookAndFeel.Default)
                End Using



                'Dim fViewer As New AddAdvertPrinter
                'With fViewer
                '    .objDataTable = objDT
                '    .ReportName = "advertsign_designated.rpt"
                '    .ShowDialog()
                '    .Dispose()
                'End With

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAdvNotice_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnDesignIntegr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDesignIntegr.Click

        UpdateIntegratedSignText()

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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


                Dim rept As New AdvertisingSignDesignatedIntegrated

                rept.DataSource = objDT

                rept.lblDepotAdvert.Text = txtDepotAddress.Text



                Using printTool As New ReportPrintTool(rept)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    printTool.ShowPreviewDialog()

                    ' Invoke the Ribbon Print Preview form
                    ' with the specified look and feel setting.
                    printTool.ShowPreview(UserLookAndFeel.Default)
                End Using

                'Dim fViewer As New AddAdvertPrinter
                'With fViewer
                '    .objDataTable = objDT
                '    .ReportName = "advertsign_designatedAndIntegrated.rpt"
                '    .ShowDialog()
                '    .Dispose()
                'End With

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



    Private Sub btneditVariationResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneditVariationResponse.Click
        LockVariationResponseFields(False)
        btnSaveVariationResponse.Enabled = True
        btneditVariationResponse.Enabled = False
    End Sub

    Private Sub btnSaveVariationResponse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariationResponse.Click
        If MessageBox.Show("Update add this variation?" & txtFile.Text & " ?", "Add amend Variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
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
                        If variationDecisionDate.Text <> String.Empty Then .Parameters.Add("@DATE", SqlDbType.SmallDateTime).Value = CDate(variationDecisionDate.EditValue)
                        If Not cboVariationResult.EditValue Is Nothing Then .Parameters.Add("@RESULT", SqlDbType.VarChar).Value = Me.cboVariationResult.EditValue.ToString
                        .Parameters.Add("@AUTHORITY", SqlDbType.SmallInt).Value = CInt(Me.cboVariationAuthority.EditValue)
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

        Me.cboVariationResult.EditValue = Nothing
        Me.cboVariationAuthority.EditValue = Nothing
        Me.variationDecisionDate.Text = String.Empty
        LockVariationResponseFields(True)

    End Sub

    Private Sub cboSTDconditions_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSTDconditions.KeyUp
        If e.KeyCode = Keys.Enter Then
            InsertNewCondition()
            cboSTDconditions.EditValue = Nothing
        End If

    End Sub

    Private Sub btnAddNewVariationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewVariationType.Click

        With My.Forms.MaintainVariations

            .ShowDialog()

            .Dispose()


        End With

        LoadVariationLookupEdit()

        'LoadCombo(cboSubmissionType, "usp_LoadUpVariationList")

    End Sub

    Private Sub btnAddVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddVariation.Click
        lblID.Text = "0"
        Me.cboVariationType.EditValue = Nothing
        txtVariationDetails.Text = String.Empty
        'Me.cboVariationResult.SelectedIndex = -1
        'Me.cboVariationAuthority.SelectedIndex = -1
        'Me.variationDecisionDate.Text = String.Empty

        lockVariationFields(False)

        btnAddVariation.Enabled = False
    End Sub

    Private Sub lockVariationFields(ByVal lock As Boolean)
        Me.cboVariationType.ReadOnly = lock
        txtVariationDetails.ReadOnly = lock
        btnSaveVariation.Enabled = Not lock

    End Sub

    Private Sub LockVariationResponseFields(ByVal lock As Boolean)
        Me.cboVariationResult.ReadOnly = lock
        Me.cboVariationAuthority.ReadOnly = lock
        Me.variationDecisionDate.ReadOnly = lock

    End Sub

    Private Sub btnSaveVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveVariation.Click
        If MessageBox.Show("Update add this variation?" & txtFile.Text & " ?", "Add amend Variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
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
                        .CommandText = "usp_InsertUpdateVariationRecord"
                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(lblID.Text)
                        .Parameters.Add("@DETAIL", SqlDbType.VarChar).Value = Me.txtVariationDetails.Text
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text
                        .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboVariationType.EditValue)
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

        Me.cboVariationType.EditValue = Nothing
        txtVariationDetails.Text = String.Empty
        lockVariationFields(True)

    End Sub

    Private Sub btnEditVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditVariation.Click
        lockVariationFields(False)
        btnSaveVariation.Enabled = True
        btnEditVariation.Enabled = False

    End Sub

    Private Sub btnRemoveVariation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRemoveVariation.Click

        If MessageBox.Show("Are you sure you want to remove this variation?", "Remove variation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub



        Dim myobj As DataRowView = CType(gvwVariations.GetFocusedRow, DataRowView)




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
                        .CommandText = "usp_DELETE_Variations_Remove"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("id"))
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
        If cboSTDconditions.EditValue Is Nothing Then Return

        If CheckConditionAlreadyExists(CInt(cboSTDconditions.EditValue)) Then
            MessageBox.Show("Condition """ & Me.cboSTDconditions.Text & """ already exist in the list", "Insert condition", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@CODE", SqlDbType.Int).Value = CInt(cboSTDconditions.EditValue)
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

        Dim myobj As DataRowView = CType(gvwOneUpConditions.GetFocusedRow, DataRowView)

        With My.Forms.InsertOneUpCondition
            .ID = CInt(myobj.Row.Item("UniqueId"))
            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()

        End With

        LoadUpConditionsList(txtDANo.Text)


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
                        .CommandText = "usp_RetrieveVariationsForDA"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo

                    End With


                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdVariations.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadVariationGrid routine - form " & Me.Name)

            End Try
        End Using


    End Sub


#End Region

#Region "Objection tab"


    Private Sub ClearObjections()
        Me.txtSubmissionSummary.Text = String.Empty
        Me.txtOfficerComment.Text = String.Empty
        Me.cboSubmissionType.EditValue = Nothing
        Me.txtAuthorName.Text = String.Empty
        Me.txtAuthurAddress.Text = String.Empty
        Me.txtAuthorEmail.Text = String.Empty
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
        Me.cboSubmissionType.ReadOnly = Lock
        Me.txtAuthorName.ReadOnly = Lock
        Me.txtAuthurAddress.ReadOnly = Lock
        Me.txtAuthorEmail.ReadOnly = Lock
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
        btnRemoveSub.Enabled = False
        btnSaveSub.Enabled = True
        btnAddSub.Enabled = False
        EditMode = False
    End Sub

    Private Sub btnAckSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAckSub.Click




        BuildAcknowledgementLetter()

        DisplayListOfSubmissionDraftDocuments(Me.txtDANo.Text)


        'SplashScreenManager.ShowForm(GetType(WaitForm))

        'If BackgroundWorker1.IsBusy <> True Then

        '    BackgroundWorker1.RunWorkerAsync()


        'End If




        'SplashScreenManager.CloseForm()
    End Sub


    Private Sub BuildAcknowledgementLetter()

        Dim OwnerName As String = String.Empty
        Dim OwnerAddress As String = String.Empty
        Dim FileNo As String = String.Empty

        If NZ(lblSubID.Text) = 0 Then

            MessageBox.Show("Please select a objector from the list before proceeding", "Print Acknowledgement?", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return


        End If

        If MessageBox.Show("You are about to issue a Submission Acknowledgement letter. OK to proceed?", "Print Acknowledgement?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


        Dim objDT As New DataTable


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in BuildAcknowledgementLetter routine")

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


                    PrintObjectorsMailMerge(txtDANo.Text, objDT)

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in BuildAcknowledgementLetter routine ")
            End Try
        End Using


    End Sub

    Private Sub btnEditSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEditSub.Click
        LockSubmissionFields(False)
        btnEditSub.Enabled = False
        btnRemoveSub.Enabled = False
        btnSaveSub.Enabled = True
        btnAddSub.Enabled = True
        EditMode = True
    End Sub

    Private Sub btnRemoveSub_Click(sender As Object, e As EventArgs) Handles btnRemoveSub.Click

        LockSubmissionFields(True)
        btnEditSub.Enabled = False
        btnSaveSub.Enabled = False
        btnAddSub.Enabled = True
        btnRemoveSub.Enabled = False

        If MessageBox.Show("Remove this submission?", "Remove Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveSub_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_Objection"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = NZ(lblSubID.Text)
                        .ExecuteNonQuery()


                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveSub_Click routine - form " & Me.Name)

            End Try
        End Using

        LoadSubmissionsGrid(txtDANo.Text)
        ClearObjections()


    End Sub

    Private Sub btnSaveSub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveSub.Click
        If SubmissionNotComplete() Then Exit Sub


        If MessageBox.Show("Update add submission?" & txtFile.Text & " ?", "Add amend submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@TYPE", SqlDbType.VarChar).Value = cboSubmissionType.EditValue.ToString 'txtAuthorName.Text
                        .Parameters.Add("@TOWN", SqlDbType.VarChar).Value = Me.txtAuthorTown.Text
                        .Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = Me.txtAuthorEmail.Text
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
        btnRemoveSub.Enabled = True
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

                    grdSubmissionandObjections.DataSource = objDT


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

        Dim LIMES As New SearchLIMES.SearchModule

        With LIMES

            .ServerName = "REC"

            .LoadMainInterface()

            If .Result = True Then

                NewPIN = .PIN

            End If

        End With



        If NewPIN = 0 Then Return

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
                        .Parameters.Add("@DANUM", SqlDbType.VarChar).Value = txtDANo.Text
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



        Dim myobj As DataRowView = CType(gvwPIN.GetFocusedRow, DataRowView)


        If MessageBox.Show("Remove Property number " & myobj.Row.Item("PIN") & " ?", "Remove PIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then



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
                            .Parameters.Add("@PIN", SqlDbType.Int).Value = CInt(myobj.Row.Item("PIN"))
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
        'If Me.lstPINs.Text = String.Empty Then Exit Sub

        If gvwPIN.RowCount = 0 Then Return

        Dim myobj As DataRowView = CType(gvwPIN.GetFocusedRow, DataRowView)




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

                        .Parameters.Add("@PIN", SqlDbType.Int).Value = CInt(myobj.Row.Item("PIN"))
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
                        Me.cboDAlocalityCode.EditValue = CInt(objDataRow.Item("LOC"))
                        txtDAOwnersName.Text = objDataRow.Item("Name").ToString
                        txtDAOwnersAddress.Text = objDataRow.Item("Add1").ToString
                        txtDAOwnersTown.Text = objDataRow.Item("Addrs").ToString
                        txtDAOwnersPcode.Text = objDataRow.Item("POST").ToString


                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRetrieveProperty_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub


#End Region


#Region "Main Application"




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

        Using cn As New SqlConnection(My.Settings.connectionString)
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

        If DANo.Length > 10 Then Return

        LoadingForm = True

        CheckIfDataChanged()


        ClearControls(pnlDisplayFees)
        ClearControls(pnlDisplayReferrals)
        ClearControls(pnlDisplayAssociatedApps)
        ClearControls(pnlDisplaySect68IntDev)
        ClearControls(pnlDisplayFileNotes)
        ClearControls(pnlDisplayDocs)
        ClearControls(pnlBuildLetters)
        ClearControls(pnlDisplayStatus)
        ClearControls(pnlDisplaySubmisions)
        ClearControls(pnlDisplayVariations)
        ClearControls(pnlDisplayPCAconditions)
        ClearControls(pnlApplicationData)
        lblapplicationNo.Text = String.Empty



        BiSaveDA.Enabled = False
        'btnSave68.Enabled = False
        btnRemoveIntDev.Enabled = False
        btnSaveStatus.Enabled = False

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                            cboAppType.EditValue = CInt(objDataRow.Item("DAAppTypeId"))

                        Else
                            cboAppType.EditValue = Nothing
                        End If


                        cboSector.EditValue = objDataRow.Item("Sector").ToString

                        If Not IsDBNull(objDataRow.Item("TypeBldgCode")) Then cboBuildingType.EditValue = CInt(objDataRow.Item("TypeBldgCode"))



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
                            cboDAlocalityCode.EditValue = CInt(objDataRow.Item("DALocalityCodeId"))

                        Else
                            cboDAlocalityCode.EditValue = Nothing
                        End If


                        txtDAOwnersName.Text = objDataRow.Item("DAOwnersName").ToString
                        txtDAOwnersAddress.Text = objDataRow.Item("DAOwnersPAddr").ToString
                        txtDAOwnersTown.Text = objDataRow.Item("DAOwnersTown").ToString
                        txtDAOwnersPcode.Text = objDataRow.Item("DAOwnersPC").ToString
                        txtDAOwnersPhone.Text = objDataRow.Item("DAOwnersPhone").ToString
                        txtArea.Text = objDataRow.Item("DAArea").ToString
                        cboAreaType.EditValue = objDataRow.Item("DAAreaUnit").ToString
                        cboDACensusCode.EditValue = objDataRow.Item("DACensusCode").ToString
                        txtBASIXCertNo.Text = objDataRow.Item("BasixCertNo").ToString
                        txtBASIXRcptNo.Text = objDataRow.Item("BasixReceiptNo").ToString
                        chkBASIXRecd.Checked = CBool(objDataRow.Item("BasixReceived"))
                        txtBASIXthermal.Text = objDataRow.Item("BasixThermal").ToString
                        txtBASIXenergy.Text = objDataRow.Item("BasixEnergy").ToString
                        txtBASIXwater.Text = objDataRow.Item("BasixWater").ToString
                        'radOccupancy.EditValue =1'CType(objDataRow.Item("occupancyStatus"), Integer)
                        lupOccupancyStatus.EditValue = objDataRow.Item("occupancyStatus").ToString

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


                            'cboDevType.EditValue = objDataRow.Item("DevType").ToString
                            cboDevType.EditValue = CInt(objDataRow.Item("DADevTypeId"))

                            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(cboDevType, DevExpress.XtraEditors.LookUpEdit)
                            Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
                            Dim value As Object = row("NewDwellingsReports")

                            Dim isReport As Boolean = CType(value, Boolean)

                            nudDwellings.Visible = isReport
                            lblNoDwellings.Visible = isReport

                            txtExistingDwelings.Visible = isReport
                            lblExistingDwellings.Visible = isReport

                            txtDemolishedDwelings.Visible = isReport
                            lblNoDemolishedDwellings.Visible = isReport

                            cboAttachmentStatus.Visible = isReport
                            lblAttachement.Visible = isReport

                            lupOccupancyStatus.Visible = isReport
                            lblOccupancy.Visible = isReport

                        Else

                            cboDevType.EditValue = Nothing

                            nudDwellings.Visible = False
                            lblNoDwellings.Visible = False

                            txtExistingDwelings.Visible = False
                            lblExistingDwellings.Visible = False

                            txtDemolishedDwelings.Visible = False
                            lblNoDemolishedDwellings.Visible = False

                            cboAttachmentStatus.Visible = False
                            lblAttachement.Visible = False

                            lupOccupancyStatus.Visible = False
                            lblOccupancy.Visible = False

                        End If

                        nudDwellings.Text = objDataRow.Item("NumberOfDwellings").ToString
                        txtExistingDwelings.Text = objDataRow.Item("ExistingDwelings").ToString
                        txtDemolishedDwelings.Text = objDataRow.Item("DemolishedDwelings").ToString


                        If Not IsDBNull(objDataRow.Item("AttachmentStatus")) Then

                            cboAttachmentStatus.EditValue = CInt(objDataRow.Item("AttachmentStatus"))

                        Else
                            cboAttachmentStatus.EditValue = Nothing
                        End If




                        If Not IsDBNull(objDataRow.Item("DADevUseId")) Then
                            cboDevUse.EditValue = CInt(objDataRow.Item("DADevUseId"))

                        Else
                            cboDevUse.EditValue = Nothing
                        End If


                        If Not IsDBNull(objDataRow.Item("IntendLandUse")) Then

                            cboIntendedLandUse.EditValue = CInt(objDataRow.Item("IntendLandUse"))

                        Else
                            cboIntendedLandUse.EditValue = Nothing
                        End If


                        If Not IsDBNull(objDataRow.Item("IntDevYN")) Then
                            cboIntDevYN.EditValue = objDataRow.Item("IntDevYN").ToString

                        Else
                            cboIntDevYN.EditValue = Nothing
                        End If


                        If Not IsDBNull(objDataRow.Item("DesignatedYN")) Then
                            cboDesignatedYN.EditValue = objDataRow.Item("DesignatedYN").ToString

                        Else
                            cboDesignatedYN.EditValue = Nothing
                        End If

                        txtDADesc.Text = objDataRow.Item("DADesc").ToString
                        txtModDesc.Text = objDataRow.Item("ModDesc").ToString

                        txtCurrentLandUse.Text = objDataRow.Item("CurrentLandUse").ToString

                        If Not IsDBNull(objDataRow.Item("DAEstCost")) Then _
                        txtDAestCost.Text = "$" & Format(objDataRow.Item("DAEstCost"), "#,###,##0")

                        txtDAFloor.Text = objDataRow.Item("DAFloor").ToString

                        If Not IsDBNull(objDataRow.Item("DAConsentType")) Then

                            cboConsentType.EditValue = CInt(objDataRow.Item("DAConsentType"))

                        Else
                            cboConsentType.EditValue = Nothing
                        End If

                        If Not IsDBNull(objDataRow.Item("DAType1Id")) Then
                            cboDAtype1.EditValue = CInt(objDataRow.Item("DAType1Id"))

                        Else
                            cboDAtype1.EditValue = Nothing
                        End If

                        If Not IsDBNull(objDataRow.Item("DAType2Id")) Then
                            cboDAType2.EditValue = CInt(objDataRow.Item("DAType2Id"))

                        Else
                            cboDAType2.EditValue = Nothing
                        End If

                        If Not IsDBNull(objDataRow.Item("DAType3Id")) Then
                            cboDAtype3.EditValue = CInt(objDataRow.Item("DAType3Id"))

                        Else
                            cboDAtype3.EditValue = Nothing
                        End If



                        'Status
                        If Not IsDBNull(objDataRow.Item("DADecisionId")) Then

                            cboDADecisionId.EditValue = CInt(objDataRow.Item("DADecisionId"))

                        Else
                            cboDADecisionId.EditValue = Nothing
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

                            cboDAAuthorityId.EditValue = CInt(objDataRow.Item("DA AuthorityId"))

                        Else
                            cboDAAuthorityId.EditValue = Nothing

                        End If

                        If Not IsDBNull(objDataRow.Item("ProgressCode")) Then

                            cboProgressCode.EditValue = CInt(objDataRow.Item("ProgressCode"))

                        Else
                            cboProgressCode.EditValue = Nothing
                        End If

                        If Not IsDBNull(objDataRow.Item("ReasonOver40")) Then

                            cboReasonOver40.EditValue = CInt(objDataRow.Item("ReasonOver40"))

                        Else
                            cboReasonOver40.EditValue = Nothing
                        End If


                        If Not IsDBNull(objDataRow.Item("AdvertSignDepot")) Then

                            cboAdvertSignDepot.EditValue = objDataRow.Item("AdvertSignDepot").ToString

                        Else
                            cboAdvertSignDepot.EditValue = Nothing
                        End If

                        txtDepartPlanning.Text = objDataRow.Item("PlaningDepartmentAddress").ToString
                        txtDesignatedText.Text = objDataRow.Item("DesignatedText").ToString


                        If Not IsDBNull(objDataRow.Item("Sec94YN")) Then BiSection94.Enabled = CBool(objDataRow.Item("Sec94YN"))






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



                        ibOldSystemImages.Enabled = ThereisanImage()

                        btnRemovePIN.Enabled = False

                        CalculateRefundsandPayments(DANo)

                        ClearObjections()

                        txtDaysElapsed.Text = DaysElapsed.ToString

                        lblReferralCount.Text = CalculateElapsedDays(DANo).ToString

                        txtDaysAddinfo.Text = CalculateAddnInfoElapsedDays(DANo).ToString

                        Me.txtDaysTaken.Text = CalculateDaysTakenToDetermine.ToString

                        ibLinked.Enabled = ThereISLinkedApp(DANo)

                        cboConsentDocType.EditValue = Nothing

                        If Me.cboConsentDocType.EditValue IsNot Nothing Then
                            LoadListOfConditionsByLetterType(CInt(cboConsentDocType.EditValue))
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






                    End If


                    LoadListOfPINS(DANo)
                    grdPIN.ForceInitialize()
                    RetrieveListOfFileNumbers(DANo)
                    LoadPaymentsRecieved(DANo)
                    LoadRefundsPaid(DANo)
                    LoadHistoricalDocuments()
                    RetrieveFileNotes(DANo)
                    LoadReferralsIntProvisionlList(DANo)
                    LoadLstIntegrated(DANo)
                    LoadUpConditionsList(DANo)
                    LoadUpOneUpConditions(DANo)
                    DisplayListOfDraftDocuments(DANo)
                    DisplayListOfSubmissionDraftDocuments(DANo)
                    LoadVariationGrid(DANo)
                    LoadSubmissionsGrid(DANo)
                    LoadSTDConditionsPriorToCCRelease(DANo)
                    LoadOneOffConditionsPriorToCCRelease(DANo)
                    LoadSummaryData(DANo)
                    LoadIntDevCombo()
                    loadIntDevGrid(DANo)
                    LoadSection68(DANo)


                    Dim PINS As String = String.Empty

                    For i As Integer = 0 To gvwPIN.DataRowCount - 1

                        PINS &= gvwPIN.GetRowCellValue(i, "PIN") & ","

                    Next


                    Dim View As DevExpress.XtraGrid.Views.Base.ColumnView = CType(grdPIN.MainView, DevExpress.XtraGrid.Views.Base.ColumnView)

                    View.MoveFirst()


                    If String.IsNullOrEmpty(PINS) Then

                        LoadAssociateApplicationsGrid("999999")

                    Else
                        LoadAssociateApplicationsGrid(PINS.Substring(0, PINS.Length - 1))

                    End If



                    ibImages.Enabled = True
                    BiCompliance.Enabled = True
                    BiEngineerConsent.Enabled = True
                    BiAssessment.Enabled = True
                    BiConstructionCert.Enabled = True
                    BiEditDA.Enabled = True
                    BiSaveDA.Enabled = False


                    If ViewOnly Then

                        LockAccessIfViewOnly(Me)

                        BiAssessment.Enabled = False

                    End If


                    btnAddNote.Enabled = True

                    ClearReferralData(grpMain)
                    ClearFileNotes(grpFileNotes)


                    ibGoogleMaps.Enabled = True
                    ibIntraMaps.Enabled = True



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PopulateForm routine - form " & Me.Name)

            End Try
        End Using

        LockTheForm(pnlApplicationData, False)
        LockTheForm(pnlDisplayFees, False)
        LockTheForm(pnlDisplayReferrals, False)
        LockTheForm(pnlDisplaySect68IntDev, False)
        LockTheForm(pnlDisplayFileNotes, False)
        LockTheForm(pnlDisplayDocs, False)
        LockTheForm(pnlDisplayStatus, False)
        LockTheForm(pnlDisplaySubmisions, False)
        LockTheForm(pnlDisplayPCAconditions, False)
        LockTheForm(pnlButtons, False)
        'LockTheForm(pnlEditButtons, False)



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

                        Me.txtCCInsuranceNo.Text = objDataRow.Item("CCInsuranceNo").ToString


                        If CBool(objDataRow.Item("CCOwnerBuilder")) = True Then

                            lblOwnerBuilder.Text = "Is Owner Builder"

                            txtCCOwnerBuilderNo.Visible = True
                            lblOwnerBuilderNo.Visible = True
                            txtCCLicBuilderName.Visible = False
                            lblBuilderName.Visible = False
                            txtCCOwnerBuilderNo.Text = objDataRow.Item("CCOwnerBuilderNo").ToString
                            lblInsuranceNo.Visible = True
                            txtCCInsuranceNo.Visible = True
                            CCValueTextBox.Visible = True
                            lblinsurValue.Visible = True

                        ElseIf CBool(objDataRow.Item("CCLicBuilder")) = True Then

                            lblOwnerBuilder.Text = "Is Licenced Builder"

                            txtCCLicBuilderName.Visible = True
                            lblBuilderName.Visible = True
                            txtCCLicBuilderName.Text = objDataRow.Item("CCLicBuilderName").ToString
                            txtCCOwnerBuilderNo.Visible = False
                            lblOwnerBuilderNo.Visible = False
                            lblInsuranceNo.Visible = True
                            txtCCInsuranceNo.Visible = True
                            CCValueTextBox.Visible = True
                            lblinsurValue.Visible = True


                        Else

                            lblOwnerBuilder.Text = "Not Available"
                            txtCCOwnerBuilderNo.Visible = False
                            lblOwnerBuilderNo.Visible = False
                            txtCCLicBuilderName.Visible = False
                            lblBuilderName.Visible = False
                            lblInsuranceNo.Visible = False
                            txtCCInsuranceNo.Visible = False
                            CCValueTextBox.Visible = False
                            lblinsurValue.Visible = False

                        End If

                        'Me.CCLicBuilderCheckBox.Checked = CBool(objDataRow.Item("CCLicBuilder"))


                    End If



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Private Sub btnSaveDA_ClickExtracted()

        'LockApplication()

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@DATYPE", SqlDbType.Int).Value = CInt(cboAppType.EditValue)
                        '.Parameters.Add("@OFFICER", SqlDbType.Int).Value = CInt(Me.cboDAOfficer.SelectedValue)
                        .Parameters.Add("@SEC94YN", SqlDbType.Bit).Value = Me.chkSec94.CheckState


                        .Parameters.Add("@APPNAME", SqlDbType.NVarChar).Value = txtAppName.Text
                        .Parameters.Add("@APPADDR", SqlDbType.NVarChar).Value = txtAppAddress.Text
                        .Parameters.Add("@APPTOWN", SqlDbType.NVarChar).Value = txtAppTown.Text
                        .Parameters.Add("@APPPCODE", SqlDbType.NVarChar).Value = txtAppPcode.Text
                        .Parameters.Add("@APPPHONE", SqlDbType.NVarChar).Value = txtAppPhone.Text
                        .Parameters.Add("@APPEMAIL", SqlDbType.NVarChar).Value = txtAppemail.Text





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




                        If Not cboDevType.EditValue Is Nothing Then .Parameters.Add("@TYPEID", SqlDbType.Int).Value = CInt(cboDevType.EditValue)



                        If cboSector.Text <> String.Empty Then .Parameters.Add("@SECTOR", SqlDbType.Int).Value = CInt(cboSector.EditValue)


                        If Not cboBuildingType.EditValue Is Nothing Then .Parameters.Add("@TypeBldgCode", SqlDbType.Int).Value = CInt(cboBuildingType.EditValue)



                        .Parameters.Add("@NODWELLINGS", SqlDbType.Int).Value = CType(nudDwellings.Text, Integer)
                        If txtExistingDwelings.Text <> String.Empty Then .Parameters.Add("@ExistingDwelings", SqlDbType.Int).Value = CType(txtExistingDwelings.Text, Integer)
                        If txtDemolishedDwelings.Text <> String.Empty Then .Parameters.Add("@DemolishedDwelings", SqlDbType.Int).Value = CType(txtDemolishedDwelings.Text, Integer)

                        If Not cboDevUse.EditValue Is Nothing Then .Parameters.Add("@USEID", SqlDbType.Int).Value = CInt(Me.cboDevUse.EditValue)

                        If Not cboIntendedLandUse.EditValue Is Nothing Then .Parameters.Add("@IntendedLandUse", SqlDbType.Int).Value = CInt(Me.cboIntendedLandUse.EditValue)
                        If Not cboAttachmentStatus.EditValue Is Nothing Then .Parameters.Add("@AttachmentStatus", SqlDbType.Int).Value = CInt(Me.cboAttachmentStatus.EditValue)

                        .Parameters.Add("@DESC", SqlDbType.NVarChar).Value = Me.txtDADesc.Text
                        .Parameters.Add("@MODDESC", SqlDbType.NVarChar).Value = Me.txtModDesc.Text

                        .Parameters.Add("@CURRENTLANDUSE", SqlDbType.NVarChar).Value = Me.txtCurrentLandUse.Text


                        If txtDAestCost.Text <> String.Empty Then .Parameters.Add("@ESTCOST", SqlDbType.Money).Value = CDbl(txtDAestCost.Text)
                        .Parameters.Add("@FLOOR", SqlDbType.Int)
                        If IsNumeric(Me.txtDAFloor.Text) Then
                            .Parameters("@FLOOR").Value = CInt(txtDAFloor.Text)
                        End If

                        If Not cboConsentType.EditValue Is Nothing Then .Parameters.Add("@CONSENTTYPE", SqlDbType.Int).Value = CInt(cboConsentType.EditValue)


                        If Not cboDAtype1.EditValue Is Nothing Then .Parameters.Add("@DATYPE1", SqlDbType.Int).Value = CInt(Me.cboDAtype1.EditValue)
                        If Not cboDAType2.EditValue Is Nothing Then .Parameters.Add("@DATYPE2", SqlDbType.Int).Value = CInt(Me.cboDAType2.EditValue)
                        If Not cboDAtype3.EditValue Is Nothing Then .Parameters.Add("@DATYPE3", SqlDbType.Int).Value = CInt(Me.cboDAtype3.EditValue)

                        '----------------Property 
                        .Parameters.Add("@DALOT", SqlDbType.NVarChar).Value = Me.txtLot.Text
                        .Parameters.Add("@DADP", SqlDbType.NVarChar).Value = Me.txtDP.Text
                        .Parameters.Add("@DASECT", SqlDbType.NVarChar).Value = Me.txtSection.Text
                        .Parameters.Add("@DASTREETNO", SqlDbType.NVarChar).Value = Me.txtStreetNo.Text
                        .Parameters.Add("@DASTREETNAME", SqlDbType.NVarChar).Value = Me.txtStreetName.Text
                        If Not cboDAlocalityCode.EditValue Is Nothing Then .Parameters.Add("@LOCALITY", SqlDbType.Int).Value = CInt(cboDAlocalityCode.EditValue)



                        .Parameters.Add("@OWNERNAME", SqlDbType.NVarChar).Value = txtDAOwnersName.Text
                        .Parameters.Add("@OWNERADDRESS", SqlDbType.NVarChar).Value = txtDAOwnersAddress.Text
                        .Parameters.Add("@OWNERTOWN", SqlDbType.NVarChar).Value = txtDAOwnersTown.Text
                        .Parameters.Add("@OWNERPCODE", SqlDbType.VarChar).Value = txtDAOwnersPcode.Text.ToString
                        .Parameters.Add("@OWNERPHONE", SqlDbType.NVarChar).Value = txtDAOwnersPhone.Text





                        If txtArea.Text <> String.Empty Then .Parameters.Add("@DAAREA", SqlDbType.Float).Value = CDbl(txtArea.Text)
                        .Parameters.Add("@AREAUNIT", SqlDbType.NVarChar).Value = Me.cboAreaType.EditValue.ToString
                        .Parameters.Add("@CENSUS", SqlDbType.NVarChar).Value = Me.cboDACensusCode.EditValue
                        .Parameters.Add("@BASIXCERTNO", SqlDbType.NVarChar).Value = Me.txtBASIXCertNo.Text
                        .Parameters.Add("@BASIXRCPTNO", SqlDbType.NVarChar).Value = Me.txtBASIXRcptNo.Text
                        .Parameters.Add("@BASIXRECD", SqlDbType.Bit).Value = Me.chkBASIXRecd.CheckState
                        .Parameters.Add("@BASIXTHERMAL", SqlDbType.NVarChar).Value = Me.txtBASIXthermal.Text
                        .Parameters.Add("@BASIXENERGY", SqlDbType.NVarChar).Value = Me.txtBASIXenergy.Text
                        .Parameters.Add("@BASIXWATER", SqlDbType.NVarChar).Value = Me.txtBASIXwater.Text
                        '.Parameters.Add("@occupancyStatus", SqlDbType.Int).Value = radOccupancy.EditValue
                        If lupOccupancyStatus.EditValue Is Nothing Then .Parameters.Add("@occupancyStatus", SqlDbType.Int).Value = CInt(lupOccupancyStatus.EditValue)


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
        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        BiCompliance.Enabled = CBool(.Parameters("@CONFIRM").Value)

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


    Private Function referralsData() As DataTable
        Dim objDT As New DataTable

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in referralsData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_DACertReferral"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = txtDANo.Text


                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "coversheetReferrals")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\coversheetReferrals.xsd")



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in referralsData routine - form " & Me.Name)

            End Try
        End Using

        Return objDT
    End Function


    'Private Sub btnSaveDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If cboDevUse.EditValue Is Nothing Then

    '        MessageBox.Show("you are required to select a Development Use", "Not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '        With ErrorProvider
    '            .SetIconAlignment(cboDevUse, ErrorIconAlignment.MiddleRight)
    '            .SetError(cboDevUse, "This is required")
    '        End With

    '        Return
    '    Else

    '        ErrorProvider.SetError(cboDevUse, "")

    '    End If


    '    'LockTheForm(pnlApplicationData, False)
    '    LockTheForm(pnlDisplayAssociatedApps, False)
    '    LockTheForm(pnlDisplaySect68IntDev, False)
    '    LockTheForm(grpDetails, False)
    '    LockTheForm(grpLand, False)
    '    LockTheForm(grpOwner, False)
    '    LockTheForm(grpDescription, False)
    '    LockTheForm(grpAdditional, False)
    '    LockTheForm(grpPurpose, False)
    '    LockTheForm(grpBasix, False)
    '    LockTheForm(grpFileNumber, False)
    '    LockTheForm(grpCCSum, False)


    '    BiEditDA.Enabled = True
    '    BiSaveDA.Enabled = False

    '    btnAddPIN.Enabled = False
    '    BiAddDA.Enabled = True
    '    btnRetrieveProperty.Enabled = False
    '    btnAddFile.Enabled = False

    '    btnSaveDA_ClickExtracted()
    '    'txtOfficer.Properties.Buttons(0).Enabled = False
    '    txtOfficer.ReadOnly = True

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

                    Dim objDT As New DataTable

                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboDevType.Properties

                        .DataSource = objDT
                        .DisplayMember = "DevType"
                        .ValueMember = "DevTypeId"
                        .ShowFooter = False
                        .ShowHeader = False


                    End With

                    Dim colDevType As LookUpColumnInfoCollection = cboDevType.Properties.Columns
                    colDevType.Add(New LookUpColumnInfo("DevType", 0))
                    colDevType.Add(New LookUpColumnInfo("DevTypeId", 0))
                    colDevType.Add(New LookUpColumnInfo("NewDwellingsReports", 0))

                    colDevType.Item(1).Visible = False
                    colDevType.Item(2).Visible = False


                    'cboDevType.Items.Clear()


                    'Using objDataReader As SqlDataReader = cmd.ExecuteReader
                    '    Do While objDataReader.Read

                    '        cboDevType.Items.Add(New DevelopmentTypeList(CType(objDataReader("DevTypeId"), Integer), objDataReader("DevType").ToString, CType(objDataReader("NewDwellingsReports"), Boolean)))

                    '    Loop


                    'End Using


                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in loadDevelopmentTypeCombo routine - form " & Me.Name)

            End Try
        End Using



    End Sub





#End Region

#Region "Menu"



#End Region



    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Public Sub New()
        isloading = True
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ErrorProvider = New ErrorProvider()

        ErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink

        UserLookAndFeel.Default.SkinName = My.MySettings.Default("ApplicationSkinName").ToString()

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




    Private Sub cboDevType_EditValueChanged(sender As Object, e As System.EventArgs) Handles cboDevType.EditValueChanged

        If isloading Then Exit Sub
        If cboDevType.IsLoading Then Return

        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)

        If row Is Nothing Then Return
        Dim value As Object = row("NewDwellingsReports")

        Dim isReport As Boolean = CType(value, Boolean)

        nudDwellings.Visible = isReport
        lblNoDwellings.Visible = isReport

        txtExistingDwelings.Visible = isReport
        lblExistingDwellings.Visible = isReport

        txtDemolishedDwelings.Visible = isReport
        lblNoDemolishedDwellings.Visible = isReport

        cboAttachmentStatus.Visible = isReport
        lblAttachement.Visible = isReport

        lupOccupancyStatus.Visible = isReport
        lblOccupancy.Visible = isReport


        If isReport = True Then

            Select Case CInt(cboDevType.EditValue)

                Case 0, 4, 5, 6, 9, 10, 19, 20, 28, 35, 36, 37, 39, 46, 48

                    nudDwellings.EditValue = 1
                    txtExistingDwelings.EditValue = 0
                    txtDemolishedDwelings.EditValue = 0
                    lupOccupancyStatus.EditValue = "1"

                Case Else

                    nudDwellings.EditValue = 0
                    txtExistingDwelings.EditValue = 0
                    txtDemolishedDwelings.EditValue = 0
                    'lupOccupancyStatus.EditValue = Nothing

            End Select

        End If






    End Sub


    Private Sub DAApplication_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If Not String.IsNullOrEmpty(cmdArg) Then

            PopulateForm(cmdArg)

        End If
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

    Private Sub cboConsentDocType_EditValueChanged(sender As Object, e As EventArgs) Handles cboConsentDocType.EditValueChanged
        If isloading Then Exit Sub


        If cboConsentDocType.IsLoading Then Return

        If cboConsentDocType.EditValue Is Nothing Then Return

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

                        .Parameters.Add("@DOCID", SqlDbType.Int).Value = CInt(cboConsentDocType.EditValue)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count = 0 Then

                        cboSTDconditions.Visible = False
                        btnAddCondition.Visible = False

                    Else

                        With cboSTDconditions.Properties
                            .Columns.Clear()
                            .DataSource = objDT
                            .DisplayMember = "Condition"
                            .ValueMember = "Id"
                            .ShowFooter = False
                            .ShowHeader = False

                        End With

                        Dim col2 As LookUpColumnInfoCollection = cboSTDconditions.Properties.Columns
                        col2.Add(New LookUpColumnInfo("Condition", 0))
                        col2.Add(New LookUpColumnInfo("Id", 0))
                        col2.Add(New LookUpColumnInfo("Standard", 0))

                        col2.Item(1).Visible = False
                        col2.Item(2).Visible = False

                        cboSTDconditions.Visible = True
                        btnAddCondition.Visible = True

                    End If



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in cboConsentDocType_SelectedValueChanged routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub gvwSTDConditions_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwSTDConditions.RowClick

        btnRemoveCondition.Enabled = True

    End Sub

    Private Sub gvwSTDConditions_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvwSTDConditions.RowCellClick

        Dim celclick As GridHitInfo = gvwSTDConditions.CalcHitInfo(dgvSTDConditions.PointToClient(Control.MousePosition))


        If celclick.InRowCell Then
            Dim rowHandle As Integer = celclick.RowHandle
            Dim column As GridColumn = celclick.Column

            If column.Name = "colFreeFormInserts" Then

                Dim myobj As DataRowView = CType(gvwSTDConditions.GetFocusedRow, DataRowView)

                With My.Forms.DAConditionsFreeForm

                    .ConditionCode = CInt(myobj.Row.Item("Id"))

                    .DANumber = txtDANo.Text

                    .ShowDialog()
                    .Dispose()

                End With

            End If

        End If



    End Sub



    Private Sub gvwOneUpConditions_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwOneUpConditions.RowClick

        btnRemoveOneOffCond.Enabled = True
        btnEditCondition.Enabled = True


    End Sub


    Private Sub cboAssessmentType_EditValueChanged(sender As Object, e As EventArgs) Handles cboAssessmentType.EditValueChanged

        If isloading Then Exit Sub

        If cboAssessmentType.IsLoading Then Return


        btnAddDefaultCondition.Enabled = HasStandardCondition(CInt(cboAssessmentType.EditValue))

    End Sub

    Private Sub btnAddDefaultCondition_Click(sender As Object, e As EventArgs) Handles btnAddDefaultCondition.Click

        Dim Procedurename As String = String.Empty
        If cboConsentDocType.EditValue Is Nothing Then
            MessageBox.Show("You need to select a document type!", "Add Default Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("You are about to add the default conditions for this assessment/document type to the list of conditions for this DA!", "OK to proceed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If Me.cboAssessmentType.EditValue Is Nothing Then

            Procedurename = "usp_GetDefaultConditions_no_assType"

        Else
            Procedurename = "usp_GetDefaultStandardConditions_assType"
        End If

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .Parameters.Add("@DOCTYPE", SqlDbType.Int).Value = CInt(cboConsentDocType.EditValue)
                        .Parameters.Add("@ASSTYPE", SqlDbType.Int).Value = CInt(cboAssessmentType.EditValue)
                        .ExecuteNonQuery()
                    End With
                End Using


                LoadUpConditionsList(txtDANo.Text)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnAddDefaultCondition_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub gvwFileNotes_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwFileNotes.RowClick




        Dim myobj As DataRowView = CType(gvwFileNotes.GetFocusedRow, DataRowView)



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

                        .Parameters.Add("@NOTEID", SqlDbType.Int).Value = CInt(myobj.Row.Item("id"))
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
                        Me.cboNoteType.EditValue = objDataRow.Item(4).ToString
                        Me.txtNotesSpokeTo.Text = objDataRow.Item(5).ToString
                        Me.txtNotesCC.Text = objDataRow.Item(6).ToString
                        Me.txtNotesFollowUp.Text = objDataRow.Item(7).ToString
                        Me.cboNotesOfficer.EditValue = CInt(objDataRow.Item(8).ToString)
                        Me.lblNotesID.Text = objDataRow.Item(9).ToString
                        btnEditNote.Enabled = True
                        btnSaveNote.Enabled = False
                        btnAddNote.Enabled = True
                        btnNotePrint.Enabled = True
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

    Private Sub gvwSubmissionandObjections_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwSubmissionandObjections.RowClick





        Dim myobj As DataRowView = CType(gvwSubmissionandObjections.GetFocusedRow, DataRowView)



        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in gvwSubmissionandObjections_RowClick routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadSubmissionAndObjections"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("id"))
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
                        Me.cboSubmissionType.EditValue = objDataRow.Item("SubmissionType").ToString
                        Me.txtAuthorName.Text = objDataRow.Item("AuthorName").ToString
                        Me.txtAuthurAddress.Text = objDataRow.Item("AuthorAddressLine1").ToString
                        Me.txtAuthorEmail.Text = objDataRow.Item("emailAddress").ToString
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
                        btnRemoveSub.Enabled = True
                        Me.btnSaveSub.Enabled = False
                        Me.btnAddSub.Enabled = True
                        btnAckSub.Enabled = True
                        btnEmailAcknowledgement.Enabled = False


                    End If



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in gvwSubmissionandObjections_RowClick routine - form " & Me.Name)

            End Try
        End Using




        'Me.btnEditSub.Enabled = True

    End Sub

    Private Sub gvwVariations_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwVariations.RowClick

        'If dgvVariations.CurrentRow.Cells(0).Value.ToString = String.Empty Then Exit Sub




        Dim myobj As DataRowView = CType(gvwVariations.GetFocusedRow, DataRowView)


        lblID.Text = myobj.Row.Item("id").ToString
        Me.cboVariationType.EditValue = CInt(myobj.Row.Item("Type"))
        txtVariationDetails.Text = myobj.Row.Item("detail").ToString
        Me.cboVariationResult.EditValue = myobj.Row.Item("VariationResultDesc").ToString
        Me.cboVariationAuthority.EditValue = myobj.Row.Item("DelegatedAuthority").ToString

        Dim valuetocheck As String = myobj.Row.Item("DecisionDate").ToString


        If valuetocheck <> String.Empty Then Me.variationDecisionDate.EditValue = CDate(myobj.Row.Item("DecisionDate"))




        Me.btnEditVariation.Enabled = True
        Me.btnSaveVariation.Enabled = False
        Me.btnAddVariation.Enabled = True
        Me.btneditVariationResponse.Enabled = True
        Me.btnSaveVariationResponse.Enabled = False
        btnRemoveVariation.Enabled = True


    End Sub

    Private Sub gvwPaymentsReceived_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwPaymentsReceived.RowClick

        Me.btnEditPayment.Enabled = True
        btnRemoveFee.Enabled = True

    End Sub

    Private Sub gvwDARefundsPaid_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwDARefundsPaid.RowClick
        Me.btnEditRefund.Enabled = True
        btnRemoveRefund.Enabled = True
    End Sub

    Private Sub gvwIntDev_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwIntDev.RowClick


        btnRemoveIntDev.Enabled = True
        btnSetIntDevDate.Enabled = True


    End Sub

    Private Sub btnRemoveIntDev_Click(sender As Object, e As EventArgs) Handles btnRemoveIntDev.Click


        Dim myobj As DataRowView = CType(gvwIntDev.GetFocusedRow, DataRowView)


        If MessageBox.Show("Remove " & myobj.Row.Item("TheAct").ToString & " from the list?", "Remove Act", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveIntDev_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_IntDevAct"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("idx"))

                        .ExecuteNonQuery()

                        loadIntDevGrid(txtDANo.Text)


                    End With



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemoveIntDev_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Sub gvwSTDCond_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwSTDCond.RowClick

        Dim myobj As DataRowView = CType(gvwSTDCond.GetFocusedRow, DataRowView)


        btnStdCondDone.Enabled = myobj.Row.Item("CCMetDate").ToString = String.Empty

    End Sub

    Private Sub gvwOneOffConditions_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwOneOffConditions.RowClick

        Dim myobj As DataRowView = CType(gvwOneOffConditions.GetFocusedRow, DataRowView)

        btnOneOffCondDone.Enabled = myobj.Row.Item("CCMetDate").ToString = String.Empty

    End Sub

    Private Sub btnStdCondDone_Click(sender As Object, e As EventArgs) Handles btnStdCondDone.Click



        UpdateConditionDate(1)

        LoadOneOffConditionsPriorToCCRelease(txtDANo.Text)


        LoadSTDConditionsPriorToCCRelease(txtDANo.Text)


    End Sub

    Private Sub btnOneOffCondDone_Click(sender As Object, e As EventArgs) Handles btnOneOffCondDone.Click



        UpdateConditionDate(2)

        LoadOneOffConditionsPriorToCCRelease(txtDANo.Text)


        LoadSTDConditionsPriorToCCRelease(txtDANo.Text)


    End Sub

    'Private Sub gvwOneOffConditions_CalcRowHeight(sender As Object, e As RowHeightEventArgs) Handles gvwOneOffConditions.CalcRowHeight
    '    If e.RowHandle >= 0 Then e.RowHeight = CInt(Fix(gvwOneOffConditions.GetDataRow(e.RowHandle)("RowHeight")))

    'End Sub

    Private Sub btnEmailAcknowledgement_Click(sender As Object, e As EventArgs) Handles btnEmailAcknowledgement.Click


        Dim myobj As DataRowView = CType(gvwSubmissionDrafts.GetFocusedRow, DataRowView)


        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return


        With My.Forms.SendEmail

            .EmailAddress = txtAuthorEmail.Text

            .LetterBeingSent = "SUB"


            .DANo = txtDANo.Text

            .DocumentName = myobj.Row.Item("DraftDocPath").ToString

            .ShowDialog()

            .Dispose()

        End With



    End Sub

    Private Sub txtAppemail_Validating(sender As Object, e As CancelEventArgs)

        Try
            MyValidatingCode(txtAppemail)

        Catch ex As Exception
            ' Cancel the event and select the text to be corrected by the user.
            e.Cancel = True
            txtAppemail.Select(0, txtAppemail.Text.Length)

            ' Set the ErrorProvider error with the text to display. 
            With ErrorProvider
                .SetIconAlignment(txtAppemail, ErrorIconAlignment.MiddleRight)
                .SetIconPadding(txtAppemail, 1)
                .SetError(txtAppemail, ex.Message)
            End With
        End Try

    End Sub

    Private Sub MyValidatingCode(TextField As Object)

        Dim myEmailField As TextBox = DirectCast(TextField, TextBox)

        ' Confirm there is text in the control.
        If myEmailField.Text.Length <> 0 Then
            '    Throw New Exception("Email address is a required field")
            'Else
            ' Confirm that there is a "." and an "@" in the e-mail address.
            'If txtemailAddress.Text.IndexOf(".") = -1 Or txtemailAddress.Text.IndexOf("@") = -1 Then
            If Not ValidateEmail(myEmailField.Text) Then
                Throw New Exception("Email address must be valid e-mail address format." +
                  Microsoft.VisualBasic.ControlChars.Cr + "For example 'someone@example.com'")
            End If
        End If
    End Sub


    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Private Sub txtAppemail_Validated(sender As Object, e As EventArgs)

        ErrorProvider.SetError(txtAppemail, "")

    End Sub

    Private Sub txtAuthorEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtAuthorEmail.Validating

        Try
            MyValidatingCode(txtAuthorEmail)

        Catch ex As Exception
            ' Cancel the event and select the text to be corrected by the user.
            e.Cancel = True
            txtAuthorEmail.Select(0, txtAuthorEmail.Text.Length)

            ' Set the ErrorProvider error with the text to display. 
            With ErrorProvider
                .SetIconAlignment(txtAuthorEmail, ErrorIconAlignment.MiddleRight)
                .SetIconPadding(txtAuthorEmail, 1)
                .SetError(txtAuthorEmail, ex.Message)
            End With
        End Try
    End Sub

    Private Sub txtAuthorEmail_Validated(sender As Object, e As EventArgs) Handles txtAuthorEmail.Validated

        ErrorProvider.SetError(txtAuthorEmail, "")

    End Sub

    Private Sub gvwSubmissionDrafts_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwSubmissionDrafts.RowClick






        Dim myobj As DataRowView = CType(gvwSubmissionDrafts.GetFocusedRow, DataRowView)

        btnEditSubmision.Enabled = True
        btnDeleteSubmission.Enabled = True
        btnFinaliseSubmission.Enabled = True

        If txtAuthorEmail.Text <> String.Empty Then btnEmailAcknowledgement.Enabled = myobj.Row.Item("Docname").ToString = "OAK"

    End Sub

    Private Sub btnEditSubmision_Click(sender As Object, e As EventArgs) Handles btnEditSubmision.Click



        Dim myobj As DataRowView = CType(gvwSubmissionDrafts.GetFocusedRow, DataRowView)


        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return



        Try

            Dim WRD As New OpenDocument
            WRD.OpenVisible(myobj.Row.Item("DraftDocPath").ToString)


        Catch ex As Exception

        End Try



    End Sub

    Private Sub btnDeleteSubmission_Click(sender As Object, e As EventArgs) Handles btnDeleteSubmission.Click


        Dim myobj As DataRowView = CType(gvwSubmissionDrafts.GetFocusedRow, DataRowView)



        If myobj.Row.Item("AppNo").ToString = String.Empty Then Return


        Dim FileToDelete As String = myobj.Row.Item("DraftDocPath").ToString


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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(myobj.Row.Item("DraftDocId"))
                        .ExecuteNonQuery()
                    End With


                End Using


                My.Computer.FileSystem.DeleteFile(FileToDelete)


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDeleteDoc_Click routine - form " & Me.Name)

            End Try
        End Using

        Try
            DisplayListOfSubmissionDraftDocuments(txtDANo.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnFinaliseSubmission_Click(sender As Object, e As EventArgs) Handles btnFinaliseSubmission.Click




        Dim myobj As DataRowView = CType(gvwSubmissionDrafts.GetFocusedRow, DataRowView)

        Dim FileToDelete As String = myobj.Row.Item("DraftDocPath").ToString
        Dim DocumentType As String = myobj.Row.Item("Description").ToString
        Dim DocID As Integer = CInt(myobj.Row.Item("DraftDocId"))



        'If dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "ModConsent" Or dgvDraftDocs.CurrentRow.Cells("colDocType").Value.ToString = "StdConsent" Then

        If myobj.Row.Item("Docname").ToString = "ModConsent" Or myobj.Row.Item("Docname").ToString = "StdConsent" Then


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

        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return

        Dim sDocumentNo As String = GetNextDocumentNumber()
        Dim Filename As String = EASEfunctions.CreateNewFileName(sDocumentNo)

        Dim summary As String = "Application No. " & txtDANo.Text & " Document Type: " & DocumentType

        Dim Recepient As Integer


        With My.Forms.WhoAreYouSendingMailTo
            .ShowDialog()
            Recepient = .Recepient
            .Dispose()

        End With

        'TODO: EASE DONE?



        '======================================================================================================================================================

        With My.Forms.InsertEASEDocument



            Select Case Recepient
                Case 1

                    .CustName = txtDAOwnersName.Text
                    .CustAddress = txtDAOwnersAddress.Text & " " & txtDAOwnersTown.Text & " " & txtDAOwnersPcode.Text

                Case 2

                    .CustName = txtAppName.Text
                    .CustAddress = txtAppAddress.Text & " " & txtAppTown.Text & " " & txtAppPcode.Text


            End Select


            .WordDocLocation = myobj.Row.Item("DraftDocPath").ToString
            .DocSummary = summary
            .DocNumber = sDocumentNo
            .FileNumber = Me.txtFileNo.Text
            .ShowDialog()
            .Dispose()


        End With




        '======================================================================================================================================================
        Dim NewRecordID As Integer

        Dim InsertDocData As New InsertDocumentData
        With InsertDocData
            .ApplicationType = "DA"
            .DocumentType = myobj.Row.Item("Docname").ToString
            .ApplicationNo = Me.txtDANo.Text
            .TheAuthor = MyUserId
            .TheImageName = sDocumentNo.Replace(".", "_")
            .Notes = summary
            .InsertDocumentsIntoDAsystem()
            NewRecordID = .DocumentID

        End With




        If DocumentType = "Standard Consent Letter" Then


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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = DocID
                        .ExecuteNonQuery()
                    End With
                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnFinaliseDoc_Click routine - form " & Me.Name)

            End Try
        End Using


        LoadHistoricalDocuments()
        DisplayListOfSubmissionDraftDocuments(txtDANo.Text)





    End Sub

    Private Sub btnEmailAcknowledge_Click(sender As Object, e As EventArgs) Handles btnEmailAcknowledge.Click


        Dim myobj As DataRowView = CType(gvwDraftDocs.GetFocusedRow, DataRowView)


        If myobj.Row.Item("DraftDocPath").ToString = String.Empty Then Return

        Dim developmentAddress As String = txtStreetNo.Text & " " & txtStreetName.Text & ", " & cboDAlocalityCode.Text

        With My.Forms.SendEmail

            .EmailAddress = txtAppemail.Text

            .LetterBeingSent = "DAACK"

            .developmentAddress = developmentAddress

            .DANo = txtDANo.Text

            .DocumentName = myobj.Row.Item("DraftDocPath").ToString

            .ShowDialog()

            .Dispose()

        End With


    End Sub



    Private Sub chksepp71_EditValueChanged(sender As Object, e As EventArgs) Handles chksepp71.EditValueChanged

        grpRFS.Visible = chksepp71.EditValue

    End Sub



    Private Sub txtOfficer_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtOfficer.ButtonClick
        With My.Forms.AssignOfficerList
            .AppNumber = txtDANo.Text
            .SysRef = "DA"
            .ShowDialog()
            If .Officer <> String.Empty Then txtOfficer.Text = .Officer
            .Dispose()
        End With
    End Sub

    Private Sub cboAdvertSignDepot_EditValueChanged(sender As Object, e As EventArgs) Handles cboAdvertSignDepot.EditValueChanged

        If cboAdvertSignDepot.IsLoading Then Return

        If cboAdvertSignDepot.EditValue Is Nothing Then Return

        Dim sql As String = String.Empty

        Select Case cboAdvertSignDepot.EditValue.ToString
            Case "A" : sql = "SELECT OtherAdvert as AddressForAdvert  FROM  ApplicationVariables"
            Case "B" : sql = "SELECT BatemansBayAdvert as AddressForAdvert  FROM  ApplicationVariables"
            Case "M" : sql = "SELECT MoruyaAdvert as AddressForAdvert  FROM  ApplicationVariables"
            Case "N" : sql = "SELECT NaroomaAdvert as AddressForAdvert  FROM  ApplicationVariables"

        End Select

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
                        .CommandType = CommandType.Text
                        .CommandText = sql


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        txtDepotAddress.Text = objDataRow.Item("AddressForAdvert").ToString

                    End If

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnModifyAdvertAddress_Click(sender As Object, e As EventArgs) Handles btnModifyAdvertAddress.Click
        txtDepotAddress.ReadOnly = False
    End Sub

    Private Sub btnModifyDeptPlanning_Click(sender As Object, e As EventArgs) Handles btnModifyDeptPlanning.Click

        txtDepartPlanning.ReadOnly = False
        btnSaveDeptPlanning.Enabled = True


    End Sub

    Private Sub btnSaveDeptPlanning_Click(sender As Object, e As EventArgs) Handles btnSaveDeptPlanning.Click

        txtDepartPlanning.ReadOnly = True
        btnSaveDeptPlanning.Enabled = False

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDeptPlanning_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_ApplicationVariableDeptPlanning"

                        .Parameters.Add("@DEPTPLANNING", SqlDbType.VarChar).Value = txtDepartPlanning.Text

                        .ExecuteNonQuery()



                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDeptPlanning_Click routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnModifyDesignatedText_Click(sender As Object, e As EventArgs) Handles btnModifyDesignatedText.Click
        txtDesignatedText.ReadOnly = False
        btnSaveDesignatedText.Enabled = True

    End Sub

    Private Sub btnSaveDesignatedText_Click(sender As Object, e As EventArgs) Handles btnSaveDesignatedText.Click

        txtDesignatedText.ReadOnly = True
        btnSaveDesignatedText.Enabled = False

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDeptPlanning_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_ApplicationVariableDesignatedText"

                        .Parameters.Add("@DESIGNATEDTEXT", SqlDbType.VarChar).Value = txtDesignatedText.Text

                        .ExecuteNonQuery()



                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveDeptPlanning_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub btnRemovePDF_Click(sender As Object, e As EventArgs) Handles btnRemovePDF.Click

        If MessageBox.Show("Remove this document?", "Remove Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemovePDF_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_UPDATE_Remove_Referrals_Image"

                        .Parameters.Add("@REFERRALID", SqlDbType.Int).Value = CInt(lblReferralID.Text)
                        .ExecuteNonQuery()

                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnRemovePDF_Click routine - form " & Me.Name)

            End Try
        End Using




        btnAddPDF.Text = "Add PDF/Image"
        btnAddPDF.Tag = "ADD"
        btnRemovePDF.Enabled = False


    End Sub



    'Private Sub btnTest_Click(sender As Object, e As EventArgs) 

    '    SplashScreenManager.ShowDefaultWaitForm()

    '    For i As Integer = 0 To 100

    '        Thread.Sleep(100)


    '    Next

    '    SplashScreenManager.CloseForm()
    'End Sub



    Private Sub BiMyOSDas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiMyOSDas.ItemClick
        With My.Forms.MyOutstandingDAs
            .Show()
        End With
    End Sub

    Private Sub BiAssessment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiAssessment.ItemClick
        'If UAT = True Then

        With My.Forms.NewAssessmentForm

            .DANoToFind = Me.txtDANo.Text
            .OriginalDA = DAmodificationNumber
            .ApplicantName = txtAppName.Text
            .ApplicantAddress = txtAppAddress.Text
            .ApplicantTown = txtAppTown.Text
            .ApplicantPostCode = txtAppPcode.Text
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

    Private Sub BiEngineerConsent_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiEngineerConsent.ItemClick

        'With My.Forms.EngineerPostConsent
        With My.Forms.EngineeringPostConsentModule
            .DAnumber = Me.txtDANo.Text
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub BiConstructionCert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiConstructionCert.ItemClick
        With My.Forms.IssueConstructionCertificate
            .DANumber = txtDANo.Text
            .FileNumber = Me.txtFileNo.Text
            .DAUseType = NZ(cboDevUse.EditValue)
            .StartPosition = FormStartPosition.CenterScreen
            'Me.Hide()
            .ShowDialog()
            Me.txtCCno.Text = .CCNo

            LoadSummaryData(txtDANo.Text)

            .Dispose()

        End With

        SaveCCNO()
    End Sub

    Private Sub BiCompliance_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiCompliance.ItemClick

        Dim Compl As New COMP


        With Compl
            .SystemType = "DA"
            .UserId = MyUserId
            .DAnumber = txtDANo.Text
            .CCnumber = txtCCno.Text
            .LoadMainInterface()

        End With

        LoadSummaryData(txtDANo.Text)


    End Sub

    Private Sub BiSection94_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiSection94.ItemClick
        Dim fSec94 As New Sec9464contributions
        With fSec94
            .DANumber = Me.txtDANo.Text
            .DateDetermined = CStr(IIf(DADetermDt.Text = "  /  /", String.Empty, DADetermDt.Text))
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub




    Private Sub Exit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibExit.ItemClick, ibRptsExit.ItemClick, ibMaintExit.ItemClick
        Me.Close()
    End Sub




    Private Sub BiAddDA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiAddDA.ItemClick
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


        PopulateForm(NewDANumber)



        Me.txtReceipts.Text = String.Empty
        Me.txtRefunds.Text = String.Empty
        txtDifference.Text = String.Empty


        BiEditDA.Enabled = False

        BiSaveDA.Enabled = True
        BiAddDA.Enabled = False



        Me.btnAddPIN.Enabled = True
        Me.btnAddFile.Enabled = True
        Me.btnRetrieveProperty.Enabled = False

        LockTheForm(grpDetails, True)
        LockTheForm(grpLand, True)
        LockTheForm(grpOwner, True)
        LockTheForm(grpDescription, True)
        LockTheForm(grpAdditional, True)
        LockTheForm(grpPurpose, True)
        LockTheForm(grpBasix, True)
        LockTheForm(grpFileNumber, True)
        LockTheForm(grpCCSum, True)
        txtOfficer.ReadOnly = False
    End Sub

    Private Sub BiSaveDA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiSaveDA.ItemClick
        If cboDevUse.EditValue Is Nothing Then

            MessageBox.Show("you are required to select a Development Use", "Not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

            With ErrorProvider
                .SetIconAlignment(cboDevUse, ErrorIconAlignment.MiddleRight)
                .SetError(cboDevUse, "This is required")
            End With

            Return
        Else

            ErrorProvider.SetError(cboDevUse, "")

        End If


        'LockTheForm(pnlApplicationData, False)
        LockTheForm(pnlDisplayAssociatedApps, False)
        LockTheForm(pnlDisplaySect68IntDev, False)
        LockTheForm(grpDetails, False)
        LockTheForm(grpLand, False)
        LockTheForm(grpOwner, False)
        LockTheForm(grpDescription, False)
        LockTheForm(grpAdditional, False)
        LockTheForm(grpPurpose, False)
        LockTheForm(grpBasix, False)
        LockTheForm(grpFileNumber, False)
        LockTheForm(grpCCSum, False)


        BiEditDA.Enabled = True
        BiSaveDA.Enabled = False

        btnAddPIN.Enabled = False
        BiAddDA.Enabled = True
        btnRetrieveProperty.Enabled = False
        btnAddFile.Enabled = False

        btnSaveDA_ClickExtracted()
        txtOfficer.ReadOnly = True
    End Sub

    Private Sub BiEditDA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BiEditDA.ItemClick
        LockTheForm(grpDetails, True)
        LockTheForm(grpLand, True)
        LockTheForm(grpOwner, True)
        LockTheForm(grpDescription, True)
        LockTheForm(grpAdditional, True)
        LockTheForm(grpPurpose, True)
        LockTheForm(grpBasix, True)
        LockTheForm(grpFileNumber, True)
        LockTheForm(grpCCSum, True)


        txtCCno.ReadOnly = Not Administration
        chkSec94.Enabled = Administration
        cboAppType.Enabled = Administration
        txtFileNo.ReadOnly = Not Administration
        txtAppName.ReadOnly = Not Administration
        txtAppAddress.ReadOnly = Not Administration
        txtAppTown.ReadOnly = Not Administration
        txtAppPcode.ReadOnly = Not Administration
        txtAppPhone.ReadOnly = False 'Not Administration
        txtAppemail.ReadOnly = False 'Not Administration
        'txtOfficer.Properties.Buttons(0).Enabled = True

        'Edit Property Tab
        txtLot.ReadOnly = False
        txtDP.ReadOnly = False
        txtSection.ReadOnly = False
        txtArea.ReadOnly = False
        cboAreaType.Enabled = True
        txtStreetNo.ReadOnly = False
        txtStreetName.ReadOnly = False
        cboDAlocalityCode.Enabled = True
        cboDACensusCode.Enabled = True
        txtDAOwnersName.ReadOnly = False
        txtDAOwnersAddress.ReadOnly = False
        txtDAOwnersTown.ReadOnly = False
        txtDAOwnersPcode.ReadOnly = False
        txtDAOwnersPhone.ReadOnly = False

        chkBASIXRecd.Enabled = True
        txtBASIXCertNo.ReadOnly = False
        txtBASIXRcptNo.ReadOnly = False
        txtBASIXwater.ReadOnly = False
        txtBASIXthermal.ReadOnly = False
        txtBASIXenergy.ReadOnly = False
        txtOfficer.ReadOnly = False

        chkDesc1.Enabled = True
        chkDADesc2.Enabled = True
        chkDADesc3.Enabled = True
        chkDADesc4.Enabled = True
        chkDADesc5.Enabled = True
        chkDADesc6.Enabled = True
        chkDADesc7.Enabled = True
        chkDADesc8.Enabled = True
        chkGiftDonation.Enabled = True
        cboDevType.Enabled = True
        cboDevUse.Enabled = True
        txtDADesc.ReadOnly = False
        txtDAestCost.ReadOnly = False
        txtDAFloor.ReadOnly = False
        cboConsentType.Enabled = True
        cboDAtype1.Enabled = True
        cboDAType2.Enabled = True
        cboDAtype3.Enabled = True
        txtModDesc.ReadOnly = False

        BiEditDA.Enabled = False
        BiSaveDA.Enabled = True

        btnAddFile.Enabled = True
        btnAddPIN.Enabled = True
        btnRetrieveProperty.Enabled = False



    End Sub

    Private Sub ibOldSystemImages_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibOldSystemImages.ItemClick

        Dim images As New OldImagesViewer

        With images

            .DAnumber = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()


        End With

    End Sub

    Private Sub ibCurrentImages_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibCurrentImages.ItemClick

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

    Private Sub ibVideos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibVideos.ItemClick



        'Dim GroupImageIDB4 As Integer = _VideoGroupId


        'Dim VidCapture As New VIDEO

        'With VidCapture
        '    .ServerName = "REC"
        '    .Application = 7
        '    .VideoGroupID = _VideoGroupId
        '    .DisplayCaptureScreen()
        '    _VideoGroupId = .VideoGroupID

        'End With
        'If GroupImageIDB4 <= 0 And _VideoGroupId <> 0 Then UpdateVideoGroupID(_VideoGroupId)



    End Sub

    Private Sub ibPrintCoverSheet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibPrintCoverSheet.ItemClick

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "coversheet")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\coversheet.xsd")

                End Using

                Dim fish As String = String.Empty
                Dim Heritage As String = String.Empty
                Dim Mine As String = String.Empty
                Dim NationalParks As String = String.Empty
                Dim River As String = String.Empty
                Dim Roads As String = String.Empty
                Dim Waste As String = String.Empty
                Dim Polution As String = String.Empty
                Dim Water As String = String.Empty

                If objDT.Rows.Count > 0 Then

                    Dim objDataRow As DataRow = objDT.Rows.Item(0)

                    If CBool(objDataRow.Item("S144")) Then
                        fish = "S144"
                    End If
                    If CBool(objDataRow.Item("S201")) Then
                        fish &= ", S201"
                    End If
                    If CBool(objDataRow.Item("S205")) Then
                        fish &= ", S205"
                    End If

                    If CBool(objDataRow.Item("S58")) Then
                        Heritage = "S58"
                    End If

                    If CBool(objDataRow.Item("S15")) Then
                        Mine = "S15"
                    End If

                    If CBool(objDataRow.Item("S90")) Then
                        NationalParks = "S90"
                    End If

                    If CBool(objDataRow.Item("P3A")) Then
                        River = "Part 3A"
                    End If

                    If CBool(objDataRow.Item("S138")) Then
                        Roads = "S138"
                    End If

                    If CBool(objDataRow.Item("S44")) Then
                        Waste = "S44"
                    End If

                    If CBool(objDataRow.Item("S17A")) Then
                        Polution = "S17A"
                    End If
                    If CBool(objDataRow.Item("S17C")) Then
                        Polution &= ", S17C"
                    End If
                    If CBool(objDataRow.Item("S17D")) Then
                        Polution &= ", S17D"
                    End If
                    If CBool(objDataRow.Item("S171")) Then
                        Polution &= ", S171"
                    End If


                    If CBool(objDataRow.Item("S10")) Then
                        Water = "S10"
                    End If
                    If CBool(objDataRow.Item("S13A")) Then
                        Water &= ", S13A"
                    End If
                    If CBool(objDataRow.Item("S18F")) Then
                        Water &= ", S18F"
                    End If
                    If CBool(objDataRow.Item("S20B")) Then
                        Water &= ", S20B"
                    End If
                    If CBool(objDataRow.Item("S20CA")) Then
                        Water &= ", S20C"
                    End If
                    If CBool(objDataRow.Item("S20L")) Then
                        Water &= ", S20L"
                    End If
                    If CBool(objDataRow.Item("S116")) Then
                        Water &= ", S116"
                    End If
                    If CBool(objDataRow.Item("P8")) Then
                        Water &= ", Part 8"
                    End If


                End If

                Dim rept As New DAcoverSheet

                rept.lblFish.Text = fish
                rept.LblHeritage.Text = Heritage
                rept.lblMine.Text = Mine
                rept.lblNatParks.Text = NationalParks
                rept.lblPollution.Text = Polution
                rept.lblRivers.Text = River
                rept.lblRoads.Text = Roads
                rept.lblWaste.Text = Waste
                rept.lblWater.Text = Water

                rept.DataSource = objDT

                rept.ReferralsObjDT = referralsData()

                Using printTool As New ReportPrintTool(rept)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    printTool.ShowPreviewDialog()

                    ' Invoke the Ribbon Print Preview form
                    ' with the specified look and feel setting.
                    printTool.ShowPreview(UserLookAndFeel.Default)
                End Using


                'Dim strReportPath As String = My.Settings.ReportLocation & "DACert.rpt"
                'Try

                '    If Not IO.File.Exists(strReportPath) Then
                '        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

                '    End If

                '    Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                '    myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                '    myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical
                '    'myPrintOptions.CustomPaperSource = GetSelectedPaperSource()

                '    With rptDocument
                '        .Load(strReportPath)
                '        .SetDataSource(objDT)
                '        .VerifyDatabase()
                '        .PrintToPrinter(1, False, 1, 99)
                '    End With
                'Catch ex As SqlException
                '    MessageBox.Show(ex.Message, " in mnuPrintFileCoverSheet_Click routine ")
                'End Try


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

    Private Sub ibCreateTemplate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibCreateTemplate.ItemClick

        With My.Forms.CreateBlankTemplate

            .ShowDialog()

            .Dispose()

        End With

    End Sub

    Private Sub ibOfficers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibOfficers.ItemClick


        With My.Forms.SystemUsersMaintenance
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub ibSection94Codes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibSection94Codes.ItemClick


        With My.Forms.MaintainSec94Codes

            .ShowDialog()

            .Dispose()

        End With

    End Sub

    Private Sub ibSection94RF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibSection94RF.ItemClick


        With My.Forms.MaintainRoadFundingPercentages

            .ShowDialog()

            .Dispose()

        End With


    End Sub

    Private Sub ibDevelopmentTypes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibDevelopmentTypes.ItemClick

        With My.Forms.MaintDevelopmentType
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

        loadDevelopmentTypeCombo()

        'LoadCombo(cboDevType, "usp_LoadUpDevTypeList")

    End Sub

    Private Sub ibPCAbuilders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibPCAbuilders.ItemClick
        Dim fBuilderMaint As New MaintainBuilders
        With fBuilderMaint
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibAuthorities_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibAuthorities.ItemClick

        Dim fAuthorities As New MaintainApprovalAuthorities
        With fAuthorities
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibDAUsers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibDAUsers.ItemClick

        With My.Forms.MaintainDAUsers
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibReferralList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibReferralList.ItemClick
        With My.Forms.MaintainReferralCategories
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibSEPPcodes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibSEPPcodes.ItemClick

        With My.Forms.MaintainSEPPCategories
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibDCPtypes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibDCPtypes.ItemClick

        With My.Forms.MaintainDCPTypes
            .ShowDialog()
            .Dispose()
        End With


    End Sub

    Private Sub ibInspectionTypes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibInspectionTypes.ItemClick
        With My.Forms.MaintainInspectionType
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibStdCondCodes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibStdCondCodes.ItemClick
        With My.Forms.MaintainDefaultConditions
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibInsuranceCoy_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ibInsuranceCoy.ItemClick

        With My.Forms.MaintainInsuranceCompanies

            .ShowDialog()

            .Dispose()

        End With


    End Sub

    Private Sub ibDCPGuidlines_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibDCPGuidlines.ItemClick
        With My.Forms.MaintainDCPGuidelines
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibNavision_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibNavision.ItemClick
        With My.Forms.FeeReconciliationToNavision
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
        End With
    End Sub

    Private Sub ibABSStats_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibABSStats.ItemClick
        Dim fABS As New ABSReportSetup
        With fABS
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibConsentAdvert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibConsentAdvert.ItemClick
        Dim rptDocument As New ReportDocument

        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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

    Private Sub ibCCresults_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibCCresults.ItemClick
        Dim daResults As New ApplicationCounterCC
        With daResults
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibCDresults_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibCDresults.ItemClick
        Dim daResults As New ApplicationCounterCD
        With daResults
            .ShowDialog()
            .Dispose()
        End With


    End Sub

    Private Sub ibDAresults_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibDAresults.ItemClick
        Dim daResults As New ApplicationCounterDA
        With daResults
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibAllResults_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibAllResults.ItemClick
        Dim daResults As New ApplicationCounter
        With daResults
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibApprovals_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibApprovals.ItemClick

        Dim rept As New ApprovalsReport

        With My.Forms.ApprovalsReportViewer
            .reportName = rept
            .StoredProcedureName = "usp_rpt_Approvals"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub ibDevelopmentApps_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibDevelopmentApps.ItemClick
        With My.Forms.ReportViewer
            .ReportType = "DAALLOC"
            '.reportName = rept
            .StoredProcedureName = "usp_rpt_DAs_AllocatedToOfficers"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()



        End With
    End Sub

    Private Sub ibConstructionCertificates_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibConstructionCertificates.ItemClick

        With My.Forms.ReportViewer
            .ReportType = "CCALLOC"
            '.reportName = rept
            .StoredProcedureName = "usp_rpt_CCs_Allocated_ByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()



        End With
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibCCdetermined.ItemClick

        With My.Forms.reportSetupApprovalsByOfficer
            .ReportType = "ConstructionCertificatesByOfficer"
            .StoredProcedureName = "usp_rpt_CCsByOfficer"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibSepticByTown_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibSepticByTown.ItemClick
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "SepticApprovalsByTownAndType.rpt"
            .StoredProcedureName = "usp_rpt_SepticApprovalsByTownAndType"
            '.StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ibAppliByOfficer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibAppliByOfficer.ItemClick
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "ApplicationsRegisteredByOfficer.rpt"
            .StoredProcedureName = "usp_rpt_ApplicationsRegisteredBY"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ibDAreceived_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibDAreceived.ItemClick
        Dim rept As New DAAddressProperty

        'rept.lblEurobodallaShireCouncil.Text = "Eurobodalla Shire Council" & vbCrLf & "Development Applications Registered List"

        With My.Forms.ApprovalsReportViewer
            .reportName = rept
            .StoredProcedureName = "usp_rpt_DAAddr"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ibCCOwner_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibCCOwner.ItemClick

        Dim rept As New CCAddressProperty

        'rept.lblEurobodallaShireCouncil.Text = "Eurobodalla Shire Council" & vbCrLf & "Construction Certificate Registered List"

        With My.Forms.ApprovalsReportViewer
            .reportName = rept
            .StoredProcedureName = "usp_rpt_CCAddr"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub ibOutstandingDA_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibOutstandingDA.ItemClick
        Dim freportSetup As New ReportSetupOutStandingDAs

        With freportSetup
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibDAdetermined_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibDAdetermined.ItemClick
        With My.Forms.reportSetupApprovalsByOfficer
            .ReportType = "ApprovalsByOfficer"
            .StoredProcedureName = "usp_rpt_ApprovalsByOfficer"
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibAverageTime_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibAverageTime.ItemClick
        With My.Forms.ReportSetupAverageInspectTimes

            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibApprovalsByTown_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibApprovalsByTown.ItemClick
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "ApprovalsByTownAndType.rpt"
            .StoredProcedureName = "usp_rpt_ApprovalsByTownByTypebyDateRange"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ibOccupByTown_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibOccupByTown.ItemClick

        Dim rept As New OccupationCertsByTownandType


        With My.Forms.ReportViewer
            .ReportType = "OCCUP"

            .reportName = rept
            .StoredProcedureName = "usp_rpt_FinalOccsByTown"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()



        End With
    End Sub

    Private Sub ibLTW_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibLTW.ItemClick

        Dim objDT As New DataTable

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "LTW")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\LTW.xsd")

                    Dim rept As New LTWapplications

                    rept.DataSource = objDT


                    Using printTool As New ReportPrintTool(rept)
                        ' Invoke the Ribbon Print Preview form modally, 
                        ' and load the report document into it.
                        printTool.ShowPreviewDialog()

                        ' Invoke the Ribbon Print Preview form
                        ' with the specified look and feel setting.
                        printTool.ShowPreview(UserLookAndFeel.Default)
                    End Using


                End Using

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LiquidWasteApplicationsToolStripMenuItem.Click routine ")
            End Try
        End Using
    End Sub

    Private Sub ibTotalNoDACC_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibTotalNoDACC.ItemClick
        Dim daResults As New reportSetupApprovals
        With daResults
            .ReportToPrint = "NumberOfDaCCapprovedSummary.rpt"
            .StoredProcedureName = "usp_rpt_NumberDAsApprovedSummary"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibStatutoryTime_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibStatutoryTime.ItemClick
        Dim daResults As New ReportSetupStatutoryTime
        With daResults
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibMayoralDetermined_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibMayoralDetermined.ItemClick

        Dim reptview As New reportSetupMayoral
        With reptview
            .ReportToPrint = "DAMayoralSummaryDeterm.rpt"
            .StoredProcedureName = "usp_rpt_DADetermSummary"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibMayoralRecd_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibMayoralRecd.ItemClick
        Dim reptview As New reportSetupMayoral
        With reptview
            .ReportToPrint = "DAMayoralSummaryRecv.rpt"
            .StoredProcedureName = "usp_rpt_DARecvSummary"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With

    End Sub

    Private Sub ibCCwithoutOC_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibCCwithoutOC.ItemClick
        Dim reptview As New reportSetupApprovals
        With reptview
            .ReportToPrint = "CCWithoutOccCert.rpt"
            .StoredProcedureName = "usp_rpt_CCWithoutOccCert"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibExpiredIOC_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibExpiredIOC.ItemClick
        With My.Forms.reportSetupApprovals
            .ReportToPrint = "CCWithOutstandingInterimOccCert.rpt"
            .StoredProcedureName = "usp_rpt_CCExpiredInterimOC"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibCCPCA_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibCCPCA.ItemClick

        Dim rept As New CCAddressPropertyByPCA

        rept.lblEurobodallaShireCouncil.Text = "Eurobodalla Shire Council" & vbCrLf & "Construction Certificate Registered List"

        With My.Forms.ApprovalsReportViewer
            .reportName = rept
            .StoredProcedureName = "usp_rpt_CC_PCA"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ibNumberDwellingsAppd_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibNumberDwellingsAppd.ItemClick
        With My.Forms.NumberDwellingsApproved

            .ShowDialog()

            .Dispose()

        End With
    End Sub

    Private Sub ibOutstandCC_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibOutstandCC.ItemClick
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

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "outstandingCC")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\outstandingCC.xsd")


                End Using

                Dim rept As New OutstandingConstructionCertificates

                With rept
                    .DataSource = objDT
                    .CreateDocument()

                End With

                Using printTool As New ReportPrintTool(rept)
                    ' Invoke the Ribbon Print Preview form modally, 
                    ' and load the report document into it.
                    printTool.ShowPreviewDialog()

                    ' Invoke the Ribbon Print Preview form
                    ' with the specified look and feel setting.
                    printTool.ShowPreview(UserLookAndFeel.Default)
                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PrintTheReport routine ")
            End Try


        End Using
    End Sub

    Private Sub ibAppdDelegation_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibAppdDelegation.ItemClick

    End Sub

    Private Sub ibLEPRegister_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibLEPRegister.ItemClick

        With My.Forms.LEPVariationsReport

            .ShowDialog()

            .Dispose()

        End With

    End Sub

    Private Sub ibInspectFileNumber_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibInspectFileNumber.ItemClick
        Dim reptview As New reportSetupApprovals
        With reptview
            .ReportToPrint = "InspectionsByFileNo.rpt"
            .StoredProcedureName = "usp_rpt_InspectByFileNo"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub ibInspectionByOfficer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibInspectionByOfficer.ItemClick
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "ComplianceInspectionsByOfficer.rpt"
            .StoredProcedureName = "usp_rpt_ComplianceInspectionsByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ibInspectOfficerAndType_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibInspectOfficerAndType.ItemClick
        Dim reptview As New reportSetupApprovals

        With reptview
            .ReportToPrint = "InspectionsByOfficerXtab.rpt"
            .StoredProcedureName = "usp_rpt_ComplianceInspectionsByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With

    End Sub

    Private Sub ibInspectOfficerSummary_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibInspectOfficerSummary.ItemClick
        Dim reptview As New reportSetupApprovals
        With reptview
            .ReportToPrint = "InspectionsByOfficerXtabSummary.rpt"
            .StoredProcedureName = "usp_rpt_ComplianceInspectionsByOfficer"
            .StartPosition = FormStartPosition.CenterParent
            .ShowDialog()
            .Dispose()

        End With
    End Sub

    Private Sub ibReferralsByOfficer_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibReferralsByOfficer.ItemClick

        With My.Forms.ReportSetupReferralsByOfficer

            .ShowDialog()

            .Dispose()

        End With
    End Sub

    Private Sub ibOSreferrals_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibOSreferrals.ItemClick

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OutstandingReferralsMenuItem_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_OutstandingReferrals"



                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "referrals")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\Devexpress Reports\referrals.xsd")

                    Dim rept As New OutStandingReferrals

                    With rept
                        .DataSource = objDT
                        .CreateDocument()

                    End With

                    Using printTool As New ReportPrintTool(rept)
                        ' Invoke the Ribbon Print Preview form modally, 
                        ' and load the report document into it.
                        printTool.ShowPreviewDialog()

                        ' Invoke the Ribbon Print Preview form
                        ' with the specified look and feel setting.
                        printTool.ShowPreview(UserLookAndFeel.Default)
                    End Using


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in OutstandingReferralsMenuItem_Click routine - form " & Me.Name)

            End Try
        End Using
    End Sub



    Private Sub ibAdditionalIfo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibAdditionalIfo.ItemClick

        Dim AdditionalInfo As New ADDINFO

        With AdditionalInfo
            .ServerName = "REC"
            .SystemType = "DA"
            .ApplicationNumber = txtDANo.Text
            .UserId = MyUserId
            .LoadMainInterface()
        End With

    End Sub

    Private Sub ibLinked_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibLinked.ItemClick
        With DALinkToParent
            .DaNo = Me.txtDANo.Text
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub grpAdditional_Paint(sender As Object, e As PaintEventArgs) Handles grpAdditional.Paint

    End Sub

    Private Sub gvwPIN_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwPIN.RowClick
        btnRetrieveProperty.Enabled = True
        btnRemovePIN.Enabled = True
    End Sub

    Private Sub ibIntraMaps_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibIntraMaps.ItemClick
        If gvwPIN.RowCount = 0 Then Return



        Dim myobj As DataRowView = CType(gvwPIN.GetFocusedRow, DataRowView)


        Dim cadId As String = myobj.Row.Item("Cadid")


        If cadId = String.Empty Then

            MessageBox.Show("There is not a CADID associated with this property, therefore unable to display Mapview", "MISSING CADID", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        Else

            Dim EnlightenURL As String = "https://esct1prodgis01v.esc.nsw.gov.au/IntraMaps80/?project=EUROBODALLA&module=PROPERTY%20&layer=REGISTERED%20PARCELS&mapkey=" & cadId
            Process.Start(EnlightenURL)

        End If
    End Sub

    Private Sub ibGoogleMaps_ItemClick(sender As Object, e As ItemClickEventArgs) Handles ibGoogleMaps.ItemClick
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

    Private Sub cboDevUse_EditValueChanged(sender As Object, e As EventArgs) Handles cboDevUse.EditValueChanged
        If cboDevUse.IsLoading Or LoadingForm Then Return

        Select Case CInt(cboDevUse.EditValue)

            Case 1 : cboIntendedLandUse.EditValue = 1

            Case Else : cboIntendedLandUse.EditValue = 2

        End Select



    End Sub

    Private Sub lupSection68_EditValueChanged(sender As Object, e As EventArgs) Handles lupSection68.EditValueChanged

        If lupSection68.IsLoading Then Return

        btnInsert68.Enabled = True

    End Sub

    Private Sub gvwSection68_RowClick(sender As Object, e As RowClickEventArgs) Handles gvwSection68.RowClick
        btnRemove68.Enabled = True
    End Sub

    Private Sub DevelopmentStart_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing


#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        My.Settings.Default("ApplicationSkinName") = UserLookAndFeel.Default.SkinName
        My.Settings.Default.Save()

#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance

    End Sub

    Private Sub btnKeep_Click(sender As Object, e As EventArgs) Handles btnKeep.Click

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
    Private Sub btnUse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUse.Click
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

    Private Sub btnKeep2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnKeep2.Click
        Dim objStreamWriter As StreamWriter

        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp", False)
        'Write a line of text.
        objStreamWriter.WriteLine(txtDAOwnersName.Text)
        objStreamWriter.WriteLine(txtDAOwnersAddress.Text)
        objStreamWriter.WriteLine(txtDAOwnersTown.Text)
        objStreamWriter.WriteLine(txtDAOwnersPcode.Text)
        objStreamWriter.WriteLine(txtDAOwnersPhone.Text)


        'Close the file.
        objStreamWriter.Close()

    End Sub

    Private Sub btnUse2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUse2.Click
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


#Region "Redundant"

    'Private Sub LoadLetterTypeCombo()


    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in DALookup_Load routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_LoadCreateLetterListBox"
    '                    .Parameters.Add("@TYPE", SqlDbType.NVarChar).Value = "DA"

    '                End With

    '                cboLetterType.Items.Clear()

    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    Do While objDataReader.Read
    '                        cboLetterType.Items.Add(New DocumentTypeListing(objDataReader("DocumentType").ToString, objDataReader("DocumentDescription").ToString, objDataReader("ReportName").ToString))
    '                    Loop
    '                End Using



    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in DALookup_Load routine - form " & Me.Name)

    '        End Try
    '    End Using


    'End Sub

    'Private Sub txtDANo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    lblapplicationNo.Text = txtDANo.Text
    'End Sub


    'Private Sub ReferralsByOfficerDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim reptview As New ReportSetupReferralsByOfficer

    '    With reptview
    '        .ShowDialog()
    '        .Dispose()
    '    End With


    'End Sub


    'Private Sub OSDAsByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim objDT As New DataTable

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in OSDAsByOfficerToolStripMenuItem_Click routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_rpt_DAToDoList"

    '                End With



    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using


    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in OSDAsByOfficerToolStripMenuItem_Click routine - form " & Me.Name)

    '        End Try
    '    End Using




    '    Dim reptviewer As New AddAdvertPrinter


    '    With reptviewer

    '        .objDataTable = objDT
    '        .ReportName = "DA_ToDoList.rpt"
    '        .ShowDialog()
    '        .Dispose()

    '    End With

    'End Sub

    'Private Sub OutstandingCCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim rptDocument As New ReportDocument

    '    Dim objDT As New DataTable

    '    'Check file exists

    '    Using cn As New SqlConnection(My.Settings.connectionString)
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
    '                    .CommandText = "usp_rpt_OutstandingCC"
    '                End With



    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using



    '            End Using


    '            'Dim strReportPath As String = My.Settings.ReportLocation & "OutstandingCCs.rpt"

    '            Dim reptviewer As New AddAdvertPrinter
    '            With reptviewer
    '                .ReportName = "OutstandingCCs.rpt"
    '                .objDataTable = objDT
    '                .ShowDialog()
    '                .Dispose()
    '            End With

    '            'Try

    '            '    If Not IO.File.Exists(strReportPath) Then
    '            '        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

    '            '    End If

    '            '    Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
    '            '    myPrintOptions.PrinterName = My.Settings.DefaultPrinter
    '            '    myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical

    '            '    With rptDocument
    '            '        .Load(strReportPath)
    '            '        .SetDataSource(objDT)
    '            '        .VerifyDatabase()

    '            '        .PrintToPrinter(1, False, 1, 99)
    '            '    End With


    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in PrintTheReport routine ")
    '        End Try


    '        'Catch ex As SqlException
    '        '    MessageBox.Show(ex.Message, " in PrintTheReport routine ")
    '        'End Try
    '    End Using
    'End Sub

    'Private Sub SepticsOutstandingByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim rptDocument As New ReportDocument

    '    Dim objDT As New DataTable

    '    'Check file exists

    '    Using cn As New SqlConnection(My.Settings.connectionString)
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

    'Private Sub BASIXCompleteNotifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim freportSetup As New ReportSetupBasixComplete

    '    With freportSetup
    '        .ShowDialog()
    '        .Dispose()
    '    End With
    'End Sub

    'Private Sub DAsAllocatedByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim reptview As New ReportSetupDAAllocatedToOfficers

    '    With reptview
    '        .ShowDialog()
    '        .Dispose()
    '    End With


    'End Sub

    'Private Sub CCsAllocatedByOfficerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim reptview As New reportSetupApprovals
    '    With reptview
    '        .ReportToPrint = "CCs_AllocatedByOfficer.rpt"
    '        .StoredProcedureName = "usp_rpt_CCs_Allocated_ByOfficer"
    '        .StartPosition = FormStartPosition.CenterParent
    '        .ShowDialog()
    '        .Dispose()
    '    End With

    'End Sub

    'Private Sub OutstandingReferralsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim objDT As New DataTable

    '    Using cn As New SqlConnection(My.Settings.connectionString)
    '        Try
    '            cn.Open()
    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in OutstandingReferralsToolStripMenuItem_Click routine - form " & Me.Name)

    '        End Try


    '        Try

    '            Using cmd As New SqlCommand

    '                With cmd
    '                    .Connection = cn
    '                    .CommandType = CommandType.StoredProcedure
    '                    .CommandText = "usp_rpt_OutstandingReferrals"

    '                    '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
    '                End With



    '                Using objDataReader As SqlDataReader = cmd.ExecuteReader
    '                    objDT.Load(objDataReader)
    '                End Using


    '            End Using




    '        Catch ex As SqlException
    '            MessageBox.Show(ex.Message, " in OutstandingReferralsToolStripMenuItem_Click routine - form " & Me.Name)

    '        End Try
    '    End Using


    '    Dim reptViewer As New AddAdvertPrinter
    '    With reptViewer
    '        .ReportName = "OutstandingReferrals.rpt"
    '        .objDataTable = objDT
    '        .ShowDialog()
    '        .Dispose()

    '    End With




    'End Sub
#End Region

End Class
