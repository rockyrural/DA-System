Imports system.data.sqlclient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls


Public Class AddNewCC

    Private ErrorProvider As New DXErrorProvider.DXErrorProvider

    Private CCLocatityCodeID As Integer
    Private DAStreetNo As String = String.Empty



    Private Sub GetNextCCNumber()
        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in AddNewCC_Load routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetNextCCNumber"

                        .Parameters.Add("@CCNO", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()
                        Dim number As String = .Parameters("@CCNO").Value.ToString

                        Me.txtCCno.Text = number
                        txtCCno.ReadOnly = True
                        NewCCNo = number
                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in AddNewCC_Load routine - form " & Me.Name)

            End Try
        End Using
    End Sub

    Private Sub AddNewCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        LoadCombo(cboBldgSolution, "usp_LoadUpCCBuildSolList")
        LoadCombo(cboDecision, "usp_LoadUpCCDescWorkList")
        LoadCombo(cboOfficer, "usp_LoadUpCurrentOfficerList")
        LoadCombo(cboAppType, "usp_LoadUpCCTypeList")
        LoadCombo(cboBldgCodeAust, "usp_LoadUpCCClassList")

        cboCertifier.SelectedIndex = -1

        With lvwCodes
            .Columns.Clear()
            .Columns.Add(New ColumnHeader)
            .Columns(0).Text = "Code"
            .Columns(0).Width = .Width - 22



        End With

        LoadForm(DANo)


    End Sub

    Private Sub LoadCombo(ByVal cbo As DevExpress.XtraEditors.LookUpEdit, ByVal SPROC As String)

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
                        .ShowNullValuePromptWhenFocused = True
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


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub LoadForm(ByVal dano As String)
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
                        If Not IsDBNull(objDataRow.Item("DAOfficerId")) Then cboOfficer.EditValue = NZ(objDataRow.Item("DAOfficerId"))
                        Me.dtRego.EditValue = CDate(objDataRow.Item("DARegoDt"))
                        If Not IsDBNull(objDataRow.Item("DAEstCost")) Then Me.txtEstCost.EditValue = CDbl(objDataRow.Item("DAEstCost"))
                        Me.txtDesc.Text = objDataRow.Item("DADesc").ToString
                        CCLocatityCodeID = CInt(objDataRow.Item("DALocalityCodeId"))
                    End If



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadForm routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function CheckDataEntry() As Boolean
        Dim result As Boolean = True

        If IsNothing(cboCertifier.EditValue) Then

            ErrorProvider.SetError(cboCertifier, "Select a certifier")

            result = False

        Else

            ErrorProvider.SetError(cboCertifier, "")

        End If

        If Me.txtCCno.Text = String.Empty Then
            ErrorProvider.SetError(Me.txtCCno, "A new CC Number is required")

            result = False
        Else
            ErrorProvider.SetError(Me.txtCCno, "")

        End If

        If Me.txtAppName.Text = String.Empty Then
            ErrorProvider.SetError(Me.txtAppName, "Applicants name is required")

            result = False
        Else
            ErrorProvider.SetError(Me.txtAppName, "")

        End If

        If Me.txtAppAddress.Text = String.Empty Then
            ErrorProvider.SetError(Me.txtAppAddress, "Applicants address is required")

            result = False
        Else
            ErrorProvider.SetError(Me.txtAppAddress, "")

        End If

        If Me.txtAppTown.Text = String.Empty Then
            ErrorProvider.SetError(Me.txtAppTown, "Applicants town is required")

            result = False
        Else
            ErrorProvider.SetError(Me.txtAppTown, "")

        End If

        If Me.txtAppPcode.Text = String.Empty Then
            ErrorProvider.SetError(Me.txtAppPcode, "Applicants postcode is required")

            result = False
        Else
            ErrorProvider.SetError(Me.txtAppPcode, "")

        End If

        If IsNothing(cboAppType.EditValue) Then
            ErrorProvider.SetError(Me.cboAppType, "Type is required")

            result = False
        Else
            ErrorProvider.SetError(Me.cboAppType, "")

        End If



        If IsNothing(cboOfficer.EditValue) Then
            ErrorProvider.SetError(Me.cboOfficer, "Officer is required")

            result = False
        Else
            ErrorProvider.SetError(Me.cboOfficer, "")

        End If

        If IsNothing(cboDecision.EditValue) Then
            ErrorProvider.SetError(Me.cboDecision, "Description is required")

            result = False
        Else
            ErrorProvider.SetError(Me.cboDecision, "")

        End If

        If Not IsNothing(cboAppType.EditValue) Then


            If cboAppType.Text.ToUpper <> "SUBDIVISION" Then
                If lvwCodes.Items.Count = 0 Then
                    ErrorProvider.SetError(Me.lvwCodes, "Australian building code is required")

                    result = False
                Else
                    ErrorProvider.SetError(Me.lvwCodes, "")

                End If

                If IsNothing(cboBldgSolution.EditValue) Then
                    ErrorProvider.SetError(Me.cboBldgSolution, "Building solution is required")

                    result = False
                Else
                    ErrorProvider.SetError(Me.cboBldgSolution, "")

                End If
            End If

        End If

        Return result
    End Function

    Private DANo As String

    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DANo = value
            Me.txtDANo.Text = DANo
        End Set
    End Property
    Private NewCCNo As String = String.Empty
    Public ReadOnly Property NewCCNumber() As String
        Get
            Return NewCCNo
        End Get
    End Property




    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        If Not CheckDataEntry() Then Exit Sub
        NewCCNo = Me.txtCCno.Text



        Dim lvwitem As ListViewItem


        Dim ClassCodes As String = String.Empty

        For Each lvwitem In Me.lvwCodes.Items
            ClassCodes &= lvwitem.Tag.ToString & "|"
        Next


        Using cn As New SqlConnection(My.Settings.connectionString)
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
                        .CommandText = "usp_AddNewConstrunctionCertificate"

                        .Parameters.Add("@CCNO", SqlDbType.NVarChar).Value = Me.txtCCno.Text
                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = Me.txtDANo.Text
                        .Parameters.Add("@APPTYPE", SqlDbType.Int).Value = NZ(cboAppType.EditValue)

                        .Parameters.Add("@REGDATE", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@REGDATE").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")

                        .Parameters.Add("@ACKDTE", SqlDbType.SmallDateTime)
                        .Parameters.Add("@DESCID", SqlDbType.Int)
                        If Not IsNothing(cboDecision.EditValue) Then .Parameters("@DESCID").Value = NZ(cboDecision.EditValue)
                        .Parameters.Add("@CLASSID", SqlDbType.NVarChar).Value = ClassCodes
                        'If cboBldgCodeAust.SelectedIndex <> -1 Then .Parameters("@CLASSID").Value = CInt(Me.cboBldgCodeAust.SelectedValue)
                        .Parameters.Add("@BLDGSOLID", SqlDbType.Int)
                        If Not IsNothing(cboBldgSolution.EditValue) Then .Parameters("@BLDGSOLID").Value = NZ(Me.cboBldgSolution.EditValue)
                        .Parameters.Add("@OFFICERID", SqlDbType.Int)
                        If Not IsNothing(cboOfficer.EditValue) Then .Parameters("@OFFICERID").Value = NZ(cboOfficer.EditValue)

                        .Parameters.Add("@NAME", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@STREET", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@TOWN", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@POSTCODE", SqlDbType.Int)
                        If txtAppPcode.Text <> String.Empty Then .Parameters("@POSTCODE").Value = NZ(txtAppPcode.Text)
                        .Parameters.Add("@PHONE", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text
                        .Parameters.Add("@ESTCOST", SqlDbType.Money)
                        If txtEstCost.Text <> String.Empty Then .Parameters("@ESTCOST").Value = CDec(Me.txtEstCost.Text)
                        .Parameters.Add("@DESC", SqlDbType.NVarChar).Value = Me.txtDesc.Text
                        .Parameters.Add("@LOCALITYCODE", SqlDbType.Int).Value = CCLocatityCodeID


                        .ExecuteNonQuery()

                    End With



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreate_Click routine - form " & Me.Name)

            End Try
        End Using



        Me.Close()
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

    Private Sub cboCertifier_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCertifier.SelectedIndexChanged
        Select Case cboCertifier.Text.ToUpper
            Case "COUNCIL"
                GetNextCCNumber()
                Me.txtCCno.ReadOnly = True


            Case "PRIVATE"
                Me.txtCCno.ReadOnly = False
                Me.txtCCno.Focus()

            Case Else

        End Select

    End Sub


    Private Sub cboBldgCodeAust_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBldgCodeAust.EditValueChanged
        btnAdd.Enabled = Not IsNothing(cboBldgCodeAust.EditValue)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim objListViewItem As New ListViewItem

        objListViewItem.Text = cboBldgCodeAust.Text
        objListViewItem.Tag = cboBldgCodeAust.Text
        'Add the ListViewItem to the ListView control
        lvwCodes.Items.Add(objListViewItem)

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Me.lvwCodes.SelectedItems.Item(0).Remove()
        Me.btnRemove.Enabled = False

    End Sub

    Private Sub lvwCodes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwCodes.Click
        If lvwCodes.SelectedItems.Item(0).ToString <> String.Empty Then _
        Me.btnRemove.Enabled = True
    End Sub
End Class