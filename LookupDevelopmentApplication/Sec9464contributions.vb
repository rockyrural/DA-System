Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared




Public Class Sec9464contributions
    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private DANo As String ' = "468/04"
    Public WriteOnly Property DANumber() As String
        Set(ByVal value As String)
            DANo = value
        End Set
    End Property


    Private DeterminedDate As String
    Public WriteOnly Property DateDetermined() As String
        Set(ByVal value As String)
            DeterminedDate = value
        End Set
    End Property
    Private Sub Sec9464contributions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.S94TypeTableAdapter.Fill(Me.AAdata.S94Type)
        Me.Section94CodeTableAdapter.Fill(Me.AAdata.Section94Code)
        Me.cboS94Type.SelectedIndex = -1
        Me.cboSection94Code.SelectedIndex = -1
        Dim totalcontribution As Double
        Dim totalrefunds As Double
        Dim totalreceipts As Double


        Dim year2 As Long
        Dim year1 As Long = Year(DateAdd(DateInterval.Day, 182, Today.Date))



        Try
            Me.Section9464ContiributionsTableAdapter.Fill(Me.AAdata.Section9464Contiributions, DANo)


            'loop thru table and add up the values

            Dim rowcount As Integer = AAdata.Section9464Contiributions.Rows.Count

            For iloop As Integer = 0 To rowcount - 1

                totalcontribution += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94ContCalc"))
                totalreceipts += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec1Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec2Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec3Amt"))
                totalrefunds += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94RefAmt"))
            Next

            'txtTotalContributions.Text = Format(totalcontribution.ToString, "Currency")
            'txtTotal.Text = Format(totalreceipts - totalrefunds, "Currency")
            txtOutstanding.Text = Format(((totalcontribution - totalreceipts) + totalrefunds), "Currency")





            'Me.Section94ContribDetailsTableAdapter.Fill(Me.AAdata.Section94ContribDetails, New System.Nullable(Of Integer)(CType(objDataRow.Item(0), Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        If DeterminedDate = String.Empty Then
            year2 = year1
        Else
            year2 = Year(DateAdd(DateInterval.Day, 182, CDate(DeterminedDate)))
        End If

        Me.lblStatus.Visible = Not year1 = year2

    End Sub

    Private Sub LoadSec94Payt(ByVal Sec94ID As Integer)

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
                        .CommandText = "usp_SEC94_PaymentRation"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = Sec94ID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    dgvSec94Payt.DataSource = objDT
                    dgvSec94Payt.Refresh()

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using




    End Sub


    Private Sub gvwSection9464Contiributions_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwSection9464Contiributions.RowClick


        Dim myobj As DataRowView = CType(gvwSection9464Contiributions.GetFocusedRow, DataRowView)


        Try
            Section94ContribDetailsTableAdapter.Fill(Me.AAdata.Section94ContribDetails, New System.Nullable(Of Integer)(CType(myobj.Row.Item("S94ID"), Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        LoadSec94Payt(CType(myobj.Row.Item("S94ID"), Integer))


        LockTheForm(Me.GroupBox1, True)
        LockTheForm(Me.GroupBox2, True)
        LockTheForm(Me.GroupBox3, True)
        btnEdit.Enabled = True
        btnSave.Enabled = False
        Me.btnAddNew.Enabled = True


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


    Private Sub LockTheForm(ByVal pnl As Control, ByVal bLock As Boolean)
        For Each ctrl As Control In pnl.Controls
            If TypeOf ctrl Is Button Then
                Dim cb As Button = DirectCast(ctrl, Button)
                cb.Enabled = Not bLock
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cb As ComboBox = DirectCast(ctrl, ComboBox)
                cb.Enabled = Not bLock
            ElseIf TypeOf ctrl Is TextBox Then
                Dim cb As TextBox = DirectCast(ctrl, TextBox)
                cb.ReadOnly = bLock
            ElseIf TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                cb.Enabled = Not bLock

            End If
        Next
    End Sub

    Private Sub ClearData(ByVal pnl As Control)
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

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        LockTheForm(Me.GroupBox1, False)
        LockTheForm(Me.GroupBox2, False)
        LockTheForm(Me.GroupBox3, False)
        btnEdit.Enabled = False
        btnSave.Enabled = True
        Me.btnAddNew.Enabled = True


    End Sub

    Private Sub btnAddNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        LockTheForm(Me.GroupBox1, False)
        LockTheForm(Me.GroupBox2, False)
        LockTheForm(Me.GroupBox3, False)
        ClearData(GroupBox1)
        ClearData(GroupBox2)
        ClearData(GroupBox3)
        Me.lblS94ID.Text = "0"

        Me.cboS94Type.SelectedIndex = -1
        Me.cboSection94Code.SelectedIndex = -1

        btnEdit.Enabled = False
        btnSave.Enabled = True
        Me.btnAddNew.Enabled = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not CheckDataEntry() Then Exit Sub

        LockTheForm(Me.GroupBox1, True)
        LockTheForm(Me.GroupBox2, True)
        LockTheForm(Me.GroupBox3, True)
        btnEdit.Enabled = False
        btnSave.Enabled = False
        Me.btnAddNew.Enabled = True

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_InsertNewSection94Contibution"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblS94ID.Text)
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@CODE", SqlDbType.NVarChar).Value = Me.cboSection94Code.SelectedValue
                        .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(txtS94ContCalc.Text)
                        .Parameters.Add("@NOTE", SqlDbType.NVarChar).Value = Me.txtS94CalcNote.Text
                        .Parameters.Add("@TYPE", SqlDbType.SmallInt).Value = CInt(cboS94Type.SelectedValue)

                        .Parameters.Add("@RECAMT1", SqlDbType.Money)
                        If txtS94Rec1Amt.Text <> String.Empty Then .Parameters("@RECAMT1").Value = CDbl(txtS94Rec1Amt.Text)
                        .Parameters.Add("@RECPTNO1", SqlDbType.NVarChar).Value = S94Rec1NoTextBox.Text

                        .Parameters.Add("@RECP1TDTE", SqlDbType.SmallDateTime)
                        If IsDate(S94Rec1DtMaskedTextBox.Text) Then .Parameters("@RECP1TDTE").Value = Format(CDate(S94Rec1DtMaskedTextBox.Text), "dd/MM/yyyy")

                        .Parameters.Add("@RECAMT2", SqlDbType.Money)
                        If txtS94RecdtAmount2.Text <> String.Empty Then .Parameters("@RECAMT2").Value = CDbl(txtS94RecdtAmount2.Text)

                        .Parameters.Add("@RECPTNO2", SqlDbType.NVarChar).Value = S94Rec2NoTextBox.Text

                        .Parameters.Add("@RECPT2DTE", SqlDbType.SmallDateTime)
                        If IsDate(S94Rec2DtMaskedTextBox.Text) Then .Parameters("@RECPT2DTE").Value = Format(CDate(S94Rec2DtMaskedTextBox.Text), "dd/MM/yyyy")

                        .Parameters.Add("@RECAMT3", SqlDbType.Money)
                        If S94Rec3AmtTextBox.Text <> String.Empty Then .Parameters("@RECAMT3").Value = CDbl(S94Rec3AmtTextBox.Text)

                        .Parameters.Add("@RECPTNO3", SqlDbType.NVarChar).Value = S94Rec3NoTextBox.Text

                        .Parameters.Add("@RECPT3DTE", SqlDbType.SmallDateTime)
                        If IsDate(S94Rec3DtMaskedTextBox.Text) Then .Parameters("@RECPT3DTE").Value = Format(CDate(S94Rec3DtMaskedTextBox.Text), "dd/MM/yyy")

                        .Parameters.Add("@REFUND", SqlDbType.Money)
                        If S94RefAmtTextBox.Text <> String.Empty Then .Parameters("@REFUND").Value = CDbl(S94RefAmtTextBox.Text)

                        .Parameters.Add("@REFUNDDTE", SqlDbType.SmallDateTime)
                        If IsDate(S94RefDtMaskedTextBox.Text) Then .Parameters("@REFUNDDTE").Value = Format(CDate(S94RefDtMaskedTextBox.Text), "dd/MM/yyyy")
                        .Parameters.Add("@REFUNDNO", SqlDbType.NVarChar).Value = S94RefNoTextBox.Text
                        .Parameters.Add("@REFUNDNOTE", SqlDbType.NVarChar).Value = S94RefNotesTextBox.Text
                        .ExecuteNonQuery()

                    End With

                    Me.Section9464ContiributionsTableAdapter.Fill(Me.AAdata.Section9464Contiributions, DANo)
                    Dim totalcontribution As Double
                    Dim totalrefunds As Double
                    Dim totalreceipts As Double

                    Dim rowcount As Integer = AAdata.Section9464Contiributions.Rows.Count

                    For iloop As Integer = 0 To rowcount - 1

                        totalcontribution += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94ContCalc"))
                        totalreceipts += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec1Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec2Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec3Amt"))
                        totalrefunds += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94RefAmt"))
                    Next

                    'txtTotalContributions.Text = Format(totalcontribution.ToString, "Currency")
                    'txtTotal.Text = Format(totalreceipts - totalrefunds, "Currency")
                    txtOutstanding.Text = Format(((totalcontribution - totalreceipts) + totalrefunds), "Currency")

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave_Click routine - form " & Me.Name)

            End Try
        End Using



    End Sub

    Private Function CheckDataEntry() As Boolean
        Dim result As Boolean = True


        If Me.cboSection94Code.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboSection94Code, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboSection94Code, "Section 94 code is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboSection94Code, "")

        End If

        If Me.cboS94Type.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboS94Type, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboS94Type, "Section 94 type is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboS94Type, "")

        End If

        If Me.txtS94ContCalc.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtS94ContCalc, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtS94ContCalc, "Contribution calculation is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtS94ContCalc, "")

        End If

        If Me.txtS94Rec1Amt.Text <> "$0.00" And Me.txtS94Rec1Amt.Text <> String.Empty Then
            If Me.S94Rec1DtMaskedTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94Rec1DtMaskedTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94Rec1DtMaskedTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94Rec1DtMaskedTextBox, "")

            End If

            If Me.S94Rec1NoTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94Rec1NoTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94Rec1NoTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94Rec1NoTextBox, "")

            End If

        End If


        If Me.txtS94RecdtAmount2.Text <> "$0.00" And txtS94RecdtAmount2.Text <> String.Empty Then
            If Me.S94Rec2DtMaskedTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94Rec2DtMaskedTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94Rec2DtMaskedTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94Rec2DtMaskedTextBox, "")

            End If

            If Me.S94Rec2NoTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94Rec2NoTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94Rec2NoTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94Rec2NoTextBox, "")

            End If

        End If

        If Me.S94Rec3AmtTextBox.Text <> "$0.00" And S94Rec3AmtTextBox.Text <> String.Empty Then
            If Me.S94Rec3DtMaskedTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94Rec3DtMaskedTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94Rec3DtMaskedTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94Rec3DtMaskedTextBox, "")

            End If

            If Me.S94Rec3NoTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94Rec3NoTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94Rec3NoTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94Rec3NoTextBox, "")

            End If



        End If

        If Me.S94RefAmtTextBox.Text <> "$0.00" And S94RefAmtTextBox.Text <> String.Empty Then
            If Me.S94RefDtMaskedTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94RefDtMaskedTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94RefDtMaskedTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94RefDtMaskedTextBox, "")

            End If

            If Me.S94RefNoTextBox.Text = String.Empty Then
                With ErrorProvider
                    .SetIconAlignment(Me.S94RefNoTextBox, ErrorIconAlignment.MiddleRight)
                    .SetError(Me.S94RefNoTextBox, "Receipt date is a required field")
                End With
                result = False
            Else
                ErrorProvider.SetError(Me.S94RefNoTextBox, "")

            End If



        End If

        Return result
    End Function


 
    Private Sub btnRecdDate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecdDate1.Click
        RetrieveDate(S94Rec1DtMaskedTextBox)
    End Sub

    Private Sub btnRecdDate2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecdDate2.Click
        RetrieveDate(S94Rec2DtMaskedTextBox)
    End Sub

    Private Sub btnRecdDate3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRecdDate3.Click
        RetrieveDate(S94Rec3DtMaskedTextBox)

    End Sub

    Private Sub btnRefundDte_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefundDte.Click
        RetrieveDate(S94RefDtMaskedTextBox)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptDocument As New ReportDocument
        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrint_Click routine")

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_Section94"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                End Using
                 

                Dim strReportPath As String = My.Settings.ReportLocation & "Section9464DistributionofPayts.rpt" '"Section9464Contributions.rpt"
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

    Private Sub btnPrintAbbrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAbbrev.Click
        Dim rptDocument As New ReportDocument
        Dim objDT As New DataTable

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAbbrev_Click routine")

            End Try

            Try
                Using cmd As New SqlCommand
                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_rpt_Section94"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With
                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using
                End Using
                 

                Dim strReportPath As String = My.Settings.ReportLocation & "Section9464Abbrev.rpt" '"Section9464Contributions.rpt"
                Try
                    If Not IO.File.Exists(strReportPath) Then
                        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
                    End If
                    Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                    myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                    myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical
                    With rptDocument
                        .Load(strReportPath)
                        .SetDataSource(objDT)
                        .VerifyDatabase()
                        .PrintToPrinter(1, False, 1, 99)
                    End With
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnPrintAbbrev_Click routine ")
                End Try

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnPrintAbbrev_Click routine ")
            End Try
        End Using
    End Sub


End Class