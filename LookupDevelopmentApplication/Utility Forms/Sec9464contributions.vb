Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UI




Public Class Sec9464contributions
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private EditPayt As Boolean = False

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
        Me.cboS94Type.SelectedIndex = -1
        Me.cboSection94Code.SelectedIndex = -1
        'Dim totalcontribution As Double
        'Dim totalrefunds As Double
        'Dim totalreceipts As Double


        Dim year2 As Long
        Dim year1 As Long = Year(DateAdd(DateInterval.Day, 182, Today.Date))



        FillTheGrid()

        'Try
        '    Me.Section9464ContiributionsTableAdapter.Fill(Me.AAdata.Section9464Contiributions, DANo)


        '    'loop thru table and add up the values

        '    Dim rowcount As Integer = AAdata.Section9464Contiributions.Rows.Count

        '    For iloop As Integer = 0 To rowcount - 1

        '        totalcontribution += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94ContCalc"))
        '        totalreceipts += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec1Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec2Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec3Amt"))
        '        totalrefunds += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94RefAmt"))
        '    Next

        '    'txtTotalContributions.Text = Format(totalcontribution.ToString, "Currency")
        '    'txtTotal.Text = Format(totalreceipts - totalrefunds, "Currency")
        '    txtOutstanding.Text = Format(((totalcontribution - totalreceipts) + totalrefunds), "Currency")





        '    'Me.Section94ContribDetailsTableAdapter.Fill(Me.AAdata.Section94ContribDetails, New System.Nullable(Of Integer)(CType(objDataRow.Item(0), Integer)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try


        If DeterminedDate = String.Empty Then
            year2 = year1
        Else
            year2 = Year(DateAdd(DateInterval.Day, 182, CDate(DeterminedDate)))
        End If

        Me.lblStatus.Visible = Not year1 = year2

    End Sub


    Private Sub LoadSection94TypeList()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94TypeList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpS94TypeList"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboS94Type
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .SelectedIndex = -1
                    End With

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94TypeList routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadSection94CodeList()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94CodeList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_LoadUpS94CodeList"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboSection94Code
                        .DataSource = objDT
                        .DisplayMember = "DisplayMember"
                        .ValueMember = "ValueMember"
                        .SelectedIndex = -1
                    End With

                End Using
                cn.Close()



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadSection94CodeList routine - form " & Me.Name)

            End Try
        End Using


    End Sub


    Private Sub FillTheGrid()

        Dim totalcontribution As Double
        Dim totalrefunds As Double
        Dim totalreceipts As Double
        Dim totalBondRefunds As Double

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
                        .CommandText = "usp_SELECT_Section9464Contiributions"

                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANo
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdSection9464Contiributions.DataSource = objDT
                    'dgvSales.Refresh()


                    If objDT.Rows.Count > 0 Then

                        'Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        For Each row As DataRow In objDT.Rows

                            totalcontribution += CDbl(row.Item("s94ContCalc"))
                            totalreceipts += CDbl(row.Item("Payments")) '+ CDbl(row.Item("s94Rec2Amt")) + CDbl(row.Item("s94Rec3Amt"))
                            totalrefunds += CDbl(row.Item("s94RefAmt"))
                            totalBondRefunds += CDbl(row.Item("BondRefund"))
                        Next

                        'txtTotalContributions.Text = Format(totalcontribution.ToString, "Currency")
                        'txtTotal.Text = Format(totalreceipts - totalrefunds, "Currency")
                        txtOutstanding.Text = Format(((totalcontribution - totalreceipts) + totalrefunds) - totalBondRefunds, "Currency")



                    End If




                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using



    End Sub


    Private Sub LoadSec94PaymentsRecd(ByVal Sec94ID As Integer)

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
                        .CommandText = "usp_SELECT_S94PaymentsReceived"

                        .Parameters.Add("@SEC94ID", SqlDbType.Int).Value = Sec94ID


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    grdPayments.DataSource = objDT


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using

    End Sub
    Private Sub LoadSec94Payt(ByVal Sec94ID As Integer)

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
                        .CommandText = "usp_SEC94_PaymentRation"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = Sec94ID
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdSec94Payt.DataSource = objDT

                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using




    End Sub


    Private Sub gvwSection9464Contiributions_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwSection9464Contiributions.RowClick


        Dim myobj As DataRowView = CType(gvwSection9464Contiributions.GetFocusedRow, DataRowView)


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in gvwSection9464Contiributions_RowClick routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Section94ContribDetails"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CType(myobj.Row.Item("S94ID"), Integer)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using



                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        lblS94ID.Text = objDataRow.Item("S94ID").ToString
                        cboSection94Code.SelectedValue = objDataRow.Item("S94Code").ToString
                        If Not IsDBNull(objDataRow.Item("S94Type")) Then cboS94Type.SelectedValue = CInt(objDataRow.Item("S94Type"))
                        If Not IsDBNull(objDataRow.Item("S94ContCalc")) Then txtS94ContCalc.Text = Format(objDataRow.Item("S94ContCalc"), "currency")
                        txtS94CalcNote.Text = objDataRow.Item("S94CalcNote").ToString

                        'If Not IsDBNull(objDataRow.Item("S94Rec1Amt")) Then txtS94Rec1Amt.Text = Format(objDataRow.Item("S94Rec1Amt"), "currency")
                        'If Not IsDBNull(objDataRow.Item("S94Rec2Amt")) Then txtS94RecdtAmount2.Text = Format(objDataRow.Item("S94Rec2Amt"), "currency")
                        'If Not IsDBNull(objDataRow.Item("S94Rec3Amt")) Then S94Rec3AmtTextBox.Text = Format(objDataRow.Item("S94Rec3Amt"), "currency")

                        'If Not IsDBNull(objDataRow.Item("S94Rec1Dt")) Then S94Rec1DtMaskedTextBox.Text = CDate(objDataRow.Item("S94Rec1Dt"))
                        'If Not IsDBNull(objDataRow.Item("S94Rec2Dt")) Then S94Rec2DtMaskedTextBox.Text = CDate(objDataRow.Item("S94Rec2Dt"))
                        'If Not IsDBNull(objDataRow.Item("S94Rec3Dt")) Then S94Rec3DtMaskedTextBox.Text = CDate(objDataRow.Item("S94Rec3Dt"))

                        'S94Rec1NoTextBox.Text = objDataRow.Item("S94Rec1No").ToString
                        'S94Rec2NoTextBox.Text = objDataRow.Item("S94Rec2No").ToString
                        'S94Rec3NoTextBox.Text = objDataRow.Item("S94Rec3No").ToString


                        S94RefAmtTextBox.Text = Format(objDataRow.Item("S94RefAmt"), "currency")

                        If Not IsDBNull(objDataRow.Item("S94RefDt")) Then S94RefDtMaskedTextBox.Text = CDate(objDataRow.Item("S94RefDt"))

                        S94RefNoTextBox.Text = objDataRow.Item("S94RefNo").ToString
                        S94RefNotesTextBox.Text = objDataRow.Item("S94RefNotes").ToString


                    End If
                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in gvwSection9464Contiributions_RowClick routine - form " & Me.Name)

            End Try
        End Using



        'Try
        '    Section94ContribDetailsTableAdapter.Fill(Me.AAdata.Section94ContribDetails, New System.Nullable(Of Integer)(CType(myobj.Row.Item("S94ID"), Integer)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

        LoadSec94Payt(CType(myobj.Row.Item("S94ID"), Integer))
        LoadSec94PaymentsRecd(CType(myobj.Row.Item("S94ID"), Integer))


        LockTheForm(Me.GroupBox1, True)
        'LockTheForm(Me.GroupBox2, True)
        btnEdit.Enabled = True
        btnRemoveLine.Enabled = True
        btnSave.Enabled = False
        Me.btnAddNew.Enabled = True
        btnAddPayment.Enabled = True

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
            ElseIf TypeOf ctrl Is DevExpress.XtraEditors.DateEdit Then
                Dim cb As DevExpress.XtraEditors.DateEdit = DirectCast(ctrl, DevExpress.XtraEditors.DateEdit)
                cb.ReadOnly = bLock
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
            ElseIf TypeOf ctrl Is DevExpress.XtraEditors.DateEdit Then
                Dim cb As DevExpress.XtraEditors.DateEdit = DirectCast(ctrl, DevExpress.XtraEditors.DateEdit)
                cb.EditValue = Nothing

            End If
        Next

    End Sub

    Private Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        LockTheForm(Me.GroupBox1, False)
        'LockTheForm(Me.GroupBox2, False)
        btnEdit.Enabled = False
        btnRemoveLine.Enabled = False

        btnSave.Enabled = True
        Me.btnAddNew.Enabled = True
        btnAddPayment.Enabled = True


    End Sub

    Private Sub btnAddNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAddNew.Click

        With My.Forms.AddSection94Contribution

            .DANo = DANo

            .ShowDialog()

            If .DialogResult = DialogResult.OK Then FillTheGrid()

            .Dispose()


        End With

        'LockTheForm(Me.GroupBox1, False)
        ''LockTheForm(Me.GroupBox2, False)
        'ClearData(GroupBox1)
        ''ClearData(GroupBox2)


        'Me.lblS94ID.Text = "0"

        'Me.cboS94Type.SelectedIndex = -1
        'Me.cboSection94Code.SelectedIndex = -1

        'btnEdit.Enabled = False
        'btnRemoveLine.Enabled = False

        'btnSave.Enabled = True
        'Me.btnAddNew.Enabled = False

        'btnAddPayment.Enabled = True

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Not CheckDataEntry() Then Exit Sub

        LockTheForm(Me.GroupBox1, True)
        'LockTheForm(Me.GroupBox2, True)
        btnEdit.Enabled = False
        btnRemoveLine.Enabled = False

        btnSave.Enabled = False
        Me.btnAddNew.Enabled = True
        btnAddPayment.Enabled = False

        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        '.Parameters.Add("@RECAMT1", SqlDbType.Money)
                        'If txtS94Rec1Amt.Text <> String.Empty Then .Parameters("@RECAMT1").Value = CDbl(txtS94Rec1Amt.Text)
                        '.Parameters.Add("@RECPTNO1", SqlDbType.NVarChar).Value = S94Rec1NoTextBox.Text

                        '.Parameters.Add("@RECP1TDTE", SqlDbType.SmallDateTime)
                        'If IsDate(S94Rec1DtMaskedTextBox.Text) Then .Parameters("@RECP1TDTE").Value = Format(CDate(S94Rec1DtMaskedTextBox.EditValue), "dd/MM/yyyy")

                        '.Parameters.Add("@RECAMT2", SqlDbType.Money)
                        'If txtS94RecdtAmount2.Text <> String.Empty Then .Parameters("@RECAMT2").Value = CDbl(txtS94RecdtAmount2.Text)

                        '.Parameters.Add("@RECPTNO2", SqlDbType.NVarChar).Value = S94Rec2NoTextBox.Text

                        '.Parameters.Add("@RECPT2DTE", SqlDbType.SmallDateTime)
                        'If IsDate(S94Rec2DtMaskedTextBox.Text) Then .Parameters("@RECPT2DTE").Value = Format(CDate(S94Rec2DtMaskedTextBox.EditValue), "dd/MM/yyyy")

                        '.Parameters.Add("@RECAMT3", SqlDbType.Money)
                        'If S94Rec3AmtTextBox.Text <> String.Empty Then .Parameters("@RECAMT3").Value = CDbl(S94Rec3AmtTextBox.Text)

                        '.Parameters.Add("@RECPTNO3", SqlDbType.NVarChar).Value = S94Rec3NoTextBox.Text

                        '.Parameters.Add("@RECPT3DTE", SqlDbType.SmallDateTime)
                        'If IsDate(S94Rec3DtMaskedTextBox.Text) Then .Parameters("@RECPT3DTE").Value = Format(CDate(S94Rec3DtMaskedTextBox.EditValue), "dd/MM/yyy")

                        .Parameters.Add("@REFUND", SqlDbType.Money)
                        If S94RefAmtTextBox.Text <> String.Empty Then .Parameters("@REFUND").Value = CDbl(S94RefAmtTextBox.Text)

                        .Parameters.Add("@REFUNDDTE", SqlDbType.SmallDateTime)
                        If IsDate(S94RefDtMaskedTextBox.Text) Then .Parameters("@REFUNDDTE").Value = Format(CDate(S94RefDtMaskedTextBox.EditValue), "dd/MM/yyyy")
                        .Parameters.Add("@REFUNDNO", SqlDbType.NVarChar).Value = S94RefNoTextBox.Text
                        .Parameters.Add("@REFUNDNOTE", SqlDbType.NVarChar).Value = S94RefNotesTextBox.Text
                        .ExecuteNonQuery()

                    End With

                    'Me.Section9464ContiributionsTableAdapter.Fill(Me.AAdata.Section9464Contiributions, DANo)

                    FillTheGrid()

                    'Dim totalcontribution As Double
                    'Dim totalrefunds As Double
                    'Dim totalreceipts As Double

                    'Dim rowcount As Integer = AAdata.Section9464Contiributions.Rows.Count

                    'For iloop As Integer = 0 To rowcount - 1

                    '    totalcontribution += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94ContCalc"))
                    '    totalreceipts += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec1Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec2Amt")) + CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94Rec3Amt"))
                    '    totalrefunds += CDbl(AAdata.Section9464Contiributions.Rows(iloop).Item("s94RefAmt"))
                    'Next

                    ''txtTotalContributions.Text = Format(totalcontribution.ToString, "Currency")
                    ''txtTotal.Text = Format(totalreceipts - totalrefunds, "Currency")
                    'txtOutstanding.Text = Format(((totalcontribution - totalreceipts) + totalrefunds), "Currency")

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

        'If Me.txtS94Rec1Amt.Text <> "$0.00" And Me.txtS94Rec1Amt.Text <> String.Empty Then
        '    If Me.S94Rec1DtMaskedTextBox.Text = String.Empty Then
        '        With ErrorProvider
        '            .SetIconAlignment(Me.S94Rec1DtMaskedTextBox, ErrorIconAlignment.MiddleRight)
        '            .SetError(Me.S94Rec1DtMaskedTextBox, "Receipt date is a required field")
        '        End With
        '        result = False
        '    Else
        '        ErrorProvider.SetError(Me.S94Rec1DtMaskedTextBox, "")

        '    End If

        '    If Me.S94Rec1NoTextBox.Text = String.Empty Then
        '        With ErrorProvider
        '            .SetIconAlignment(Me.S94Rec1NoTextBox, ErrorIconAlignment.MiddleRight)
        '            .SetError(Me.S94Rec1NoTextBox, "Receipt date is a required field")
        '        End With
        '        result = False
        '    Else
        '        ErrorProvider.SetError(Me.S94Rec1NoTextBox, "")

        '    End If

        'End If


        'If Me.txtS94RecdtAmount2.Text <> "$0.00" And txtS94RecdtAmount2.Text <> String.Empty Then
        '    If Me.S94Rec2DtMaskedTextBox.Text = String.Empty Then
        '        With ErrorProvider
        '            .SetIconAlignment(Me.S94Rec2DtMaskedTextBox, ErrorIconAlignment.MiddleRight)
        '            .SetError(Me.S94Rec2DtMaskedTextBox, "Receipt date is a required field")
        '        End With
        '        result = False
        '    Else
        '        ErrorProvider.SetError(Me.S94Rec2DtMaskedTextBox, "")

        '    End If

        '    If Me.S94Rec2NoTextBox.Text = String.Empty Then
        '        With ErrorProvider
        '            .SetIconAlignment(Me.S94Rec2NoTextBox, ErrorIconAlignment.MiddleRight)
        '            .SetError(Me.S94Rec2NoTextBox, "Receipt date is a required field")
        '        End With
        '        result = False
        '    Else
        '        ErrorProvider.SetError(Me.S94Rec2NoTextBox, "")

        '    End If

        'End If

        'If Me.S94Rec3AmtTextBox.Text <> "$0.00" And S94Rec3AmtTextBox.Text <> String.Empty Then
        '    If Me.S94Rec3DtMaskedTextBox.Text = String.Empty Then
        '        With ErrorProvider
        '            .SetIconAlignment(Me.S94Rec3DtMaskedTextBox, ErrorIconAlignment.MiddleRight)
        '            .SetError(Me.S94Rec3DtMaskedTextBox, "Receipt date is a required field")
        '        End With
        '        result = False
        '    Else
        '        ErrorProvider.SetError(Me.S94Rec3DtMaskedTextBox, "")

        '    End If

        '    If Me.S94Rec3NoTextBox.Text = String.Empty Then
        '        With ErrorProvider
        '            .SetIconAlignment(Me.S94Rec3NoTextBox, ErrorIconAlignment.MiddleRight)
        '            .SetError(Me.S94Rec3NoTextBox, "Receipt date is a required field")
        '        End With
        '        result = False
        '    Else
        '        ErrorProvider.SetError(Me.S94Rec3NoTextBox, "")

        '    End If



        'End If

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




    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

        LoadSection94CodeList()
        LoadSection94TypeList()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim rptDocument As New ReportDocument
        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .CommandText = "usp_SELECT_rpt_Section_9464Contribution"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "Section94")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\section94full.xsd")

                End Using


                Dim rept As New Section9464DistributionOfPaymentsReport

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


                'Dim strReportPath As String = My.Settings.ReportLocation & "Section9464DistributionofPayts.rpt" '"Section9464Contributions.rpt"
                'Try

                '    If Not IO.File.Exists(strReportPath) Then
                '        Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))

                '    End If

                '    'Dim myPrintOptions As PrintOptions = rptDocument.PrintOptions
                '    'myPrintOptions.PrinterName = My.Settings.DefaultPrinter
                '    'myPrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical
                '    ''myPrintOptions.CustomPaperSource = GetSelectedPaperSource()

                '    'With rptDocument
                '    '    .Load(strReportPath)
                '    '    .SetDataSource(objDT)
                '    '    .VerifyDatabase()
                '    '    .PrintToPrinter(1, False, 1, 99)
                '    'End With
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

    Private Sub btnPrintAbbrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintAbbrev.Click
        Dim objDT As New DataTable

        'Check file exists

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .CommandText = "usp_SELECT_rpt_Section_9464Contribution"
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    'Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    'Dim mylist As DataSet = New DataSet
                    'adapter.Fill(mylist, "Section94")

                    'mylist.WriteXmlSchema("D:\Development\DA System\LookupDevelopmentApplication\New Version\Reports\section94full.xsd")

                End Using


                Dim rept As New AbbreviatedSection9464DistributionOfPaymentsReport

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
                MessageBox.Show(ex.Message, " in mnuPreviewAssessment_Click routine ")
            End Try
        End Using
    End Sub

    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        EditPayt = False
        txtPaymentAmount.ReadOnly = False
        dtePaytRecd.ReadOnly = False
        txtReceiptNo.ReadOnly = False
        txtPaymentAmount.Text = String.Empty
        dtePaytRecd.EditValue = Nothing
        txtReceiptNo.Text = String.Empty


        btnSavePayment.Enabled = True
        btnAddPayment.Enabled = False
        txtPaymentAmount.Focus()

    End Sub

    Private Sub btnSavePayment_Click(sender As Object, e As EventArgs) Handles btnSavePayment.Click

        If PaymentDoesNotCheckOut() Then Return

        Dim Whatever As Integer

        If MessageBox.Show("Insert this payment?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return

        If EditPayt = True Then


            Dim myobj As DataRowView = CType(gvwPayments.GetFocusedRow, DataRowView)


            Whatever = CInt(myobj.Row.Item("S94Idx"))


        End If


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePayment_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_INSERT_S94PaymentsReceived"

                        If EditPayt = True Then .Parameters.Add("@PAYIDX", SqlDbType.Int).Value = Whatever

                        .Parameters.Add("@SEC94ID", SqlDbType.Int).Value = CInt(lblS94ID.Text)
                        .Parameters.Add("@PAYTAMT", SqlDbType.Money).Value = CDbl(txtPaymentAmount.Text)
                        .Parameters.Add("@PAYTDATE", SqlDbType.Date).Value = Format(CDate(dtePaytRecd.EditValue), "yyyy-MM-dd")
                        .Parameters.Add("@RECEIPTNO", SqlDbType.VarChar).Value = txtReceiptNo.Text
                        .Parameters.Add("@DANO", SqlDbType.VarChar).Value = DANo

                        .ExecuteNonQuery()

                    End With





                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSavePayment_Click routine - form " & Me.Name)

            End Try
        End Using

        btnSavePayment.Enabled = False
        btnAddPayment.Enabled = True

        txtPaymentAmount.Text = String.Empty
        dtePaytRecd.EditValue = Nothing
        txtReceiptNo.Text = String.Empty
        EditPayt = False


        LoadSec94PaymentsRecd(CInt(lblS94ID.Text))
        FillTheGrid()


    End Sub


    Private Function PaymentDoesNotCheckOut() As Boolean

        Dim result As Boolean = False

        If txtPaymentAmount.EditValue Is Nothing And txtPaymentAmount.Text <> String.Empty Then

            ErrorProvider.SetError(txtPaymentAmount, "Receipt amount is a required field")
            result = True

        Else

            ErrorProvider.SetError(txtPaymentAmount, "")

        End If

        If dtePaytRecd.EditValue Is Nothing Then

            ErrorProvider.SetError(dtePaytRecd, "Receipt date is a required field")
            result = True

        Else

            ErrorProvider.SetError(dtePaytRecd, "")

        End If

        If txtReceiptNo.Text = String.Empty Then

            ErrorProvider.SetError(txtReceiptNo, "Receipt number is a required field")
            result = True

        Else

            ErrorProvider.SetError(txtReceiptNo, "")

        End If



        Return result

    End Function
    Private Sub gvwPayments_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvwPayments.RowClick

        Dim myobj As DataRowView = CType(gvwPayments.GetFocusedRow, DataRowView)


        txtPaymentAmount.Text = myobj.Row.Item("PaytAmount").ToString
        dtePaytRecd.EditValue = CDate(myobj.Row.Item("PaytDate"))
        txtReceiptNo.Text = myobj.Row.Item("PaytReceiptNo").ToString


        btnDelete.Enabled = True
        btnModifyReceipt.Enabled = True

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim myobj As DataRowView = CType(gvwPayments.GetFocusedRow, DataRowView)


        Dim Whatever As Integer = CInt(myobj.Row.Item("S94Idx"))

        If MessageBox.Show("Remove payment for " & Format(myobj.Row.Item("PaytAmount"), "currency") & " received " & Format(CDate(myobj.Row.Item("PaytDate")), "dd-MM-yyyy") & "?", "Delete payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDelete_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_S94PaymentsReceived"

                        .Parameters.Add("@SEC94ID", SqlDbType.Int).Value = Whatever

                        .ExecuteNonQuery()

                    End With


                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDelete_Click routine - form " & Me.Name)

            End Try
        End Using

        btnDelete.Enabled = False

        LoadSec94PaymentsRecd(CInt(lblS94ID.Text))

    End Sub

    Private Sub btnModifyReceipt_Click(sender As Object, e As EventArgs) Handles btnModifyReceipt.Click

        EditPayt = True
        btnModifyReceipt.Enabled = False
        txtPaymentAmount.ReadOnly = False
        dtePaytRecd.ReadOnly = False
        txtReceiptNo.ReadOnly = False
        btnSavePayment.Enabled = True
        txtPaymentAmount.Focus()


    End Sub

    Private Sub btnRemoveLine_Click(sender As Object, e As EventArgs) Handles btnRemoveLine.Click

        If MessageBox.Show("Remove the line?", "R E M O V E  L I N E", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Return


        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDelete_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_DELETE_Section94Contibution"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = CInt(lblS94ID.Text)

                        .ExecuteNonQuery()

                    End With


                End Using

                LockTheForm(Me.GroupBox1, True)
                ClearData(GroupBox1)

                FillTheGrid()


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnDelete_Click routine - form " & Me.Name)

            End Try
        End Using

    End Sub
End Class