Imports system.data.sqlclient
Imports System.IO



Public Class AddNewCompliance
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private isLoading As Boolean = True

    Private ComplianceNo As String
    Public WriteOnly Property Compliancenumber() As String
        Set(ByVal value As String)
            ComplianceNo = value
        End Set
    End Property
    Private DAno As String
    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DAno = value
            Me.txtDANo.Text = value
        End Set
    End Property

    Private Sub LoadBuildersNames()


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CompliancePrivateCertifiersList"

                    End With



                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            cboBuildersNames.Items.Add(New BuilderNames(objDataReader("Name").ToString, objDataReader("Acc_Lic_no").ToString, objDataReader("Address").ToString, objDataReader("Town").ToString, objDataReader("PC").ToString, objDataReader("Phone").ToString, CInt(objDataReader("ID"))))
                        Loop
                        objDataReader.Close()
                        cboBuildersNames.SelectedIndex = -1
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadBuildersNames routine - form " & Me.Name)

            End Try
        End Using



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

    Private Sub cboBuildersNames_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBuildersNames.SelectedValueChanged
        If cboBuildersNames.SelectedIndex = -1 Then Exit Sub

        Dim mlist As BuilderNames = CType(cboBuildersNames.SelectedItem, BuilderNames)
        Me.txtCoPCAaddress.Text = mlist.BldAddress.ToString
        Me.txtCoPCATown.Text = mlist.BldTown.ToString
        Me.txtCoPCAPcode.Text = mlist.BldPcode.ToString
        Me.txtCoPCAPhone.Text = mlist.Phone.ToString
        txtLicenceNo.Text = mlist.Licence.ToString

    End Sub

    Private Sub btndtRego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndtRego.Click
        RetrieveDate(dtRego)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink


    End Sub


    Private Function CheckDataEntry() As Boolean
        Dim result As Boolean = True


        If Me.txtAppName.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAppName, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAppName, "Applicants name is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAppName, "")

        End If



        If Me.txtCCno.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtCCno, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtCCno, "Construction Certificate number is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtCCno, "")

        End If


        If Me.txtAppAddress.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAppAddress, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAppAddress, "Applicants address is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAppAddress, "")

        End If

        If Me.txtAppTown.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAppTown, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAppTown, "Applicants town is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAppTown, "")

        End If

        If Me.txtAppPcode.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtAppPcode, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtAppPcode, "Applicants postcode is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtAppPcode, "")

        End If

        If Me.cboBuildersNames.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboBuildersNames, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboBuildersNames, "Certified Authority is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboBuildersNames, "")

        End If


        'If Me.dtRego.Text = String.Empty Then
        '    With ErrorProvider
        '        .SetIconAlignment(Me.btndtRego, ErrorIconAlignment.MiddleRight)
        '        .SetError(Me.btndtRego, "Commencement date is a required field")
        '    End With
        '    result = False
        'Else
        '    ErrorProvider.SetError(Me.btndtRego, "")

        'End If





        Return result
    End Function

    Private Sub LoadForm(ByVal dano As String)
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
                        .CommandText = "usp_GetApplicantsDetailsForCC"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = dano
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using

                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.txtAppName.Text = objDataRow.Item("DAAppName").ToString
                        Me.txtAppAddress.Text = objDataRow.Item("DAAppAddr").ToString
                        Me.txtAppTown.Text = objDataRow.Item("DAAppTown").ToString
                        Me.txtAppPcode.Text = objDataRow.Item("DAAppPC").ToString
                        Me.txtAppPhone.Text = objDataRow.Item("DAAppPhone").ToString

                    End If



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadForm routine - form " & Me.Name)

            End Try
        End Using

    End Sub



    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If Not CheckDataEntry() Then Exit Sub

        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreate_Click routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_CreateNewCompliance"

                        .Parameters.Add("@CONO", SqlDbType.NVarChar).Value = ComplianceNo
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DAno
                        .Parameters.Add("@COMDTE", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@COMDTE").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")

                        .Parameters.Add("@APPNAME", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@APPADDR", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@AppTown", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@AppPC", SqlDbType.SmallInt)
                        If txtAppPcode.Text <> String.Empty Then .Parameters("@AppPC").Value = CInt(txtAppPcode.Text)
                        .Parameters.Add("@AppPhone", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text

                        .Parameters.Add("@PCANAME", SqlDbType.NVarChar).Value = Me.cboBuildersNames.Text
                        .Parameters.Add("@PCAADDR", SqlDbType.NVarChar).Value = Me.txtCoPCAaddress.Text
                        .Parameters.Add("@PCATown", SqlDbType.NVarChar).Value = Me.txtCoPCATown.Text
                        .Parameters.Add("@PCAPC", SqlDbType.SmallInt)
                        If Me.txtCoPCAPcode.Text <> String.Empty Then .Parameters("@PCAPC").Value = CInt(txtCoPCAPcode.Text)
                        .Parameters.Add("@PCAPhone", SqlDbType.NVarChar).Value = Me.txtCoPCAPhone.Text
                        .Parameters.Add("@PCALICENCE", SqlDbType.NVarChar).Value = Me.txtLicenceNo.Text

                        .ExecuteNonQuery()

                    End With



                End Using
                 


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreate_Click routine - form " & Me.Name)

            End Try
        End Using



        Me.Close()
    End Sub

    Private Sub AddNewCompliance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoading = True
        LoadBuildersNames()
        Me.cboCertifier.SelectedIndex = -1
        If DAno <> String.Empty Then LoadForm(DAno)
        isLoading = False
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

    Private Sub btnUse2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUse2.Click
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
    Private Sub cboCertifier_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCertifier.SelectedValueChanged
        If isLoading Then Exit Sub
        Select Case cboCertifier.Text.ToUpper
            Case "COUNCIL"
                txtCCno.Text = ComplianceNo.ToString
                Me.txtCCno.ReadOnly = True


            Case "PRIVATE"
                txtCCno.Text = String.Empty
                Me.txtCCno.ReadOnly = False
                Me.txtCCno.Focus()

            Case Else

        End Select

    End Sub


End Class