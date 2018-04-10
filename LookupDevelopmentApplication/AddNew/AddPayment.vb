Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Public Class AddPayment

    Private ErrorProvider As System.Windows.Forms.ErrorProvider

    Private Sub AddPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCombo()

        If PaymentID <> 0 Then LoadForm()


    End Sub

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


    Private IDindex As Integer
    Public WriteOnly Property IndexID() As Integer
        Set(ByVal value As Integer)
            IDindex = value
        End Set
    End Property
    Private Sub LoadForm()
        PopulateData()
        Me.cboPayment.ReadOnly = False

    End Sub


    Private Sub PopulateData()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PopulateData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RetrievePaymentMade"

                        .Parameters.Add("@INDEX", SqlDbType.Int).Value = IDindex
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        cboPayment.EditValue = NZ(objDataRow.Item("InspTypeId"))
                        txtAmount.EditValue = CDbl(objDataRow.Item("ReceiptAmt"))
                        dtRego.EditValue = CDate(objDataRow.Item("ReceiptDt"))
                        txtRecptNo.Text = objDataRow.Item("ReceiptNo").ToString
                        txtNotes.Text = objDataRow.Item("ReceiptNotes").ToString
                        txtPaidInspections.Text = objDataRow.Item("InspectionsPaid").ToString
                        chkTrackInCompliance.EditValue = CBool(objDataRow.Item("TrackInCompliance"))

                    End If



                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in PopulateData routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Sub LoadCombo()

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadCombo routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.Text
                        .CommandText = "SELECT Payment.PaymentId, Payment.Payment FROM Payment ORDER BY Payment.Payment;"


                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    With cboPayment.Properties
                        .DataSource = objDT
                        .DisplayMember = "Payment"
                        .ValueMember = "PaymentId"
                        .ShowFooter = False
                        .ShowHeader = False
                    End With

                    Dim col2 As LookUpColumnInfoCollection = cboPayment.Properties.Columns
                    col2.Add(New LookUpColumnInfo("Payment", 0))
                    col2.Add(New LookUpColumnInfo("PaymentId", 0))

                    col2.Item(1).Visible = False

                End Using



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using


    End Sub
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

        Select Case CInt(cboPayment.EditValue)
            Case 9, 28, 13
                If txtPaidInspections.Text = String.Empty Then
                    MessageBox.Show("You must include Inspections with Final occupation certificates, Compliance and Plumbing Compliance Fees", "Inspections", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                If Not IsNumeric(txtPaidInspections.Text) Then
                    MessageBox.Show("Paid inspections MUST be a number", "Inspections", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub

                End If

        End Select


        If MessageBox.Show("Confirm that you want update/insert  " & Me.cboPayment.Text & " Now?", "Insert Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub


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
                        .CommandText = "usp_InsertANewPayement"
                        .Parameters.Add("@IDX", SqlDbType.Int).Value = IDindex
                        .Parameters.Add("@ID", SqlDbType.NVarChar).Value = ApplicationID
                        .Parameters.Add("@SYSTEM", SqlDbType.NVarChar).Value = SystemType
                        .Parameters.Add("@TYPEID", SqlDbType.SmallInt).Value = NZ(cboPayment.EditValue)
                        If Not String.IsNullOrEmpty(txtAmount.Text) Then .Parameters.Add("@AMOUNT", SqlDbType.Money).Value = CDbl(txtAmount.Text)
                        .Parameters.Add("@RECDDTE", SqlDbType.SmallDateTime).Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")
                        .Parameters.Add("@RECEIPT", SqlDbType.NVarChar).Value = Me.txtRecptNo.Text
                        .Parameters.Add("@NOTES", SqlDbType.NVarChar).Value = Me.txtNotes.Text
                        .Parameters.Add("@TRACK", SqlDbType.Bit).Value = chkTrackInCompliance.Checked
                        If Not String.IsNullOrEmpty(txtPaidInspections.Text) Then .Parameters.Add("@INSPECTNOPAID", SqlDbType.Float).Value = CDbl(txtPaidInspections.Text)

                        .ExecuteNonQuery()

                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnSave_Click routine - form " & Me.Name)

            End Try
        End Using

        Me.Close()


    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub




End Class