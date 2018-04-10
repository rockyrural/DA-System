Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class AddCharge

    Private ErrorProvider As New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider

    Private Sub AddPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.PaymentExtendedComboBox.SelectedIndex = -1


        If _ChargeID <> 0 Then LoadForm()

    End Sub



    Private ApplicationID As String
    Public WriteOnly Property AppID() As String
        Set(ByVal value As String)
            ApplicationID = value
        End Set
    End Property

    Private _ChargeID As Integer
    Public WriteOnly Property ChargeId() As Short
        Set(ByVal value As Short)
            _ChargeID = value
        End Set
    End Property


    Private _InspectionID As Integer
    Public WriteOnly Property InspectionID() As Short
        Set(ByVal value As Short)
            _InspectionID = value
        End Set
    End Property


    Private Function FormCheckedOut() As Boolean
        Dim result As Boolean = True

        If IsNothing(dteChargeDt.EditValue) Then
            With ErrorProvider

                .SetError(dteChargeDt, "A date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(dteChargeDt, "")

        End If


        If IsNothing(cboPayment.EditValue) Then
            With ErrorProvider

                .SetError(Me.cboPayment, "A payment type is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboPayment, "")

        End If

        If txtAmount.Text = String.Empty Then
            With ErrorProvider

                .SetError(Me.txtAmount, "Amount is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAmount, "")

        End If



        If txtQuantity.Text = String.Empty Then

            With ErrorProvider
                .SetError(txtQuantity, "Quantity is a required field")
            End With
            result = False

        Else
            ErrorProvider.SetError(txtQuantity, "")

        End If


        If txtRate.Text = String.Empty Then
            With ErrorProvider

                .SetError(txtRate, "Rate is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(txtRate, "")

        End If

        If txtAmount.Text = String.Empty Then
            With ErrorProvider

                .SetError(txtAmount, "Amount is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(txtAmount, "")

        End If




        Return result
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If Not FormCheckedOut() Then Exit Sub


        If MessageBox.Show("Insert this new charge for " & cboPayment.Text & " Now?", "Insert Charge", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim row As DataRowView = CType(cboPayment.GetSelectedDataRow, DataRowView)

        Dim PayID As Integer = CType(row.Item("PaymentId"), Integer)


        Using cn As New SqlConnection(My.Settings.connectionString)
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

                        .Parameters.Add("@ID", SqlDbType.Int).Value = _ChargeID

                        .Parameters.Add("@INSPECTID", SqlDbType.Int).Value = _InspectionID

                        .Parameters.Add("@TYPEID", SqlDbType.Int).Value = PayID

                        .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(txtAmount.Text)

                        If dteChargeDt.EditValue IsNot Nothing Then .Parameters.Add("@DATE", SqlDbType.SmallDateTime).Value = Format(CDate(dteChargeDt.EditValue), "yyyy-MM-dd")

                        .Parameters.Add("@REF", SqlDbType.NVarChar).Value = txtNotes.Text

                        .Parameters.Add("@QUANT", SqlDbType.Float).Value = CDbl(txtQuantity.Text)
                        .Parameters.Add("@RATE", SqlDbType.Money).Value = CDbl(txtRate.Text)


                        If Me.cboChargeUnit.EditValue IsNot Nothing Then .Parameters.Add("@UNIT", SqlDbType.NVarChar).Value = cboChargeUnit.EditValue.ToString



                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSaveCharge_Click routine - form " & Me.Name)

            End Try
        End Using

        DialogResult = DialogResult.OK


    End Sub

    Private Sub LoadChargeUnit()

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
                        .CommandText = "SELECT    ChargeUnit, ChargeUnitDesc FROM         ChargeUnit ORDER BY ChargeUnitDesc; "


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboChargeUnit.Properties

                        .DataSource = objDT
                        .DisplayMember = "ChargeUnitDesc"
                        .ValueMember = "ChargeUnit"
                        .ShowFooter = False
                        .ShowHeader = False
                    End With


                End Using

                Dim col2 As LookUpColumnInfoCollection = cboChargeUnit.Properties.Columns
                col2.Add(New LookUpColumnInfo("ChargeUnitDesc", 0))
                col2.Add(New LookUpColumnInfo("ChargeUnit", 0))

                col2.Item(1).Visible = False

            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub LoadListOfPayments()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfPayments routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SELECT_LoadChargesPaymentTypes"

                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboPayment.Properties
                        .DataSource = objDT
                        .ValueMember = "Payment"
                        .DisplayMember = "Payment"
                        .ShowFooter = False
                        .ShowHeader = False

                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboPayment.Properties.Columns
                    col2.Add(New LookUpColumnInfo("Payment", 0))
                    col2.Add(New LookUpColumnInfo("PaymentId", 0))
                    col2.Add(New LookUpColumnInfo("ChargeCalcType", 0))
                    col2.Add(New LookUpColumnInfo("ChargeFlatFee", 0))
                    col2.Add(New LookUpColumnInfo("ChargePerUnit", 0))
                    col2.Add(New LookUpColumnInfo("ChargeUnitType", 0))
                    col2.Add(New LookUpColumnInfo("ChargeMinimum", 0))
                    col2.Add(New LookUpColumnInfo("ChargeCategory", 0))

                    col2.Item(1).Visible = False
                    col2.Item(2).Visible = False
                    col2.Item(3).Visible = False
                    col2.Item(4).Visible = False
                    col2.Item(5).Visible = False
                    col2.Item(6).Visible = False
                    col2.Item(7).Visible = False


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadListOfPayments routine - form " & Me.Name)

            End Try
        End Using


    End Sub


    Private Sub LoadForm()
        'Try
        '    Me.RetrieveRefundsMadeTableAdapter.Fill(Me.AAdata.RetrieveRefundsMade, ApplicationID, SystemType, PaymentID)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .CommandText = "usp_ChargesFeesApplicable"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = _ChargeID


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)


                        If Not IsDBNull(objDataRow.Item("Payment")) Then cboPayment.EditValue = objDataRow.Item("Payment").ToString
                        txtQuantity.Text = objDataRow.Item("ChargeQuant").ToString
                        If Not IsDBNull(objDataRow.Item("ChargeUnit")) Then cboChargeUnit.EditValue = objDataRow.Item("ChargeUnit").ToString
                        txtRate.Text = objDataRow.Item("ChargeMultiplier").ToString
                        If Not IsDBNull(objDataRow.Item("ChargeDt")) Then dteChargeDt.Text = CDate(objDataRow.Item("ChargeDt"))
                        If Not IsDBNull(objDataRow.Item("ChargeAmt")) Then txtAmount.EditValue = Format(objDataRow.Item("ChargeAmt"), "currency")
                        txtNotes.Text = objDataRow.Item("ChargeRef").ToString





                    End If


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadForm routine - form " & Me.Name)

            End Try
        End Using




    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadListOfPayments()
        LoadChargeUnit()

    End Sub


End Class