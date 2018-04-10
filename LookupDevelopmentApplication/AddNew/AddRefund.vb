Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls

Public Class AddRefund

    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private Sub AddPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.PaymentExtendedComboBox.SelectedIndex = -1

        LoadListOfPayments()

        If PaymentID <> 0 Then LoadForm()

    End Sub

    Private IndexID As Integer
    Public WriteOnly Property IDindex() As Integer
        Set(ByVal value As Integer)
            IndexID = value
        End Set
    End Property


    Private SystemType As String
    Public WriteOnly Property TheSystemType() As String
        Set(ByVal value As String)
            SystemType = value
        End Set
    End Property

    Private ApplicationID As String
    Public WriteOnly Property AppID() As String
        Set(ByVal value As String)
            ApplicationID = value
        End Set
    End Property

    Private PaymentID As Short
    Public WriteOnly Property PayId() As Short
        Set(ByVal value As Short)
            PaymentID = value
        End Set
    End Property



    Private Function FormCheckedOut() As Boolean
        Dim result As Boolean = True

        If IsNothing(dtRego.EditValue) Then
            With ErrorProvider
                .SetIconAlignment(dtRego, ErrorIconAlignment.MiddleLeft)
                .SetError(dtRego, "A date is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(dtRego, "")

        End If
        If IsNothing(cboPayment.EditValue) Then
            With ErrorProvider
                .SetIconAlignment(Me.cboPayment, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboPayment, "A payment type is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboPayment, "")

        End If

        If txtAmount.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAmount, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAmount, "Amount is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAmount, "")

        End If








        Return result
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click


        If Not FormCheckedOut() Then Exit Sub


        If MessageBox.Show("Insert this new payment for " & cboPayment.Text & " Now?", "Insert Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


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
                        .CommandText = "usp_InsertNewRefund"

                        .Parameters.Add("@IDX", SqlDbType.Int).Value = IndexID
                        .Parameters.Add("@ID", SqlDbType.NVarChar).Value = ApplicationID
                        .Parameters.Add("@SYSTEM", SqlDbType.NVarChar).Value = SystemType
                        .Parameters.Add("@TYPEID", SqlDbType.SmallInt).Value = NZ(cboPayment.EditValue)
                        If Not String.IsNullOrEmpty(txtAmount.Text) Then .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(txtAmount.Text)
                        .Parameters.Add("@RECDDTE", SqlDbType.SmallDateTime).Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")
                        .Parameters.Add("@CHEQUE", SqlDbType.NVarChar).Value = Me.txtRecptNo.Text
                        .Parameters.Add("@NOTES", SqlDbType.NVarChar).Value = Me.txtNotes.Text

                        .ExecuteNonQuery()

                    End With



                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.Close()



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
                        .CommandText = "usp_LoadUpPaymentList"

                        '.Parameters.Add("@PINNUM", SqlDbType.Int).Value = mdl_PIN
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboPayment.Properties
                        .DataSource = objDT
                        .ValueMember = "ValueMember"
                        .DisplayMember = "DisplayMember"
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboPayment.Properties.Columns
                    col2.Add(New LookUpColumnInfo("DisplayMember", 0))
                    col2.Add(New LookUpColumnInfo("ValueMember", 0))

                    col2.Item(1).Visible = False


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
                        .CommandText = "usp_RetrieveRefundsMade"

                        .Parameters.Add("@ID", SqlDbType.Int).Value = IndexID
                        .Parameters.Add("@SYSTEM", SqlDbType.NVarChar).Value = SystemType
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        If Not IsDBNull(objDataRow.Item("RefundTypeId")) Then cboPayment.EditValue = NZ(objDataRow.Item("RefundTypeId"))
                        If Not IsDBNull(objDataRow.Item("RefundAmt")) Then txtAmount.EditValue = Format(objDataRow.Item("RefundAmt"), "currency")
                        If Not IsDBNull(objDataRow.Item("RefundDt")) Then dtRego.EditValue = CDate(objDataRow.Item("RefundDt"))
                        Me.txtRecptNo.Text = objDataRow.Item("RefundCheque").ToString
                        Me.txtNotes.Text = objDataRow.Item("Refund Notes").ToString


                    End If

                    'dgvSales.DataSource = objDT
                    'dgvSales.Refresh()

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

        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink


    End Sub


End Class