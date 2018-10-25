Imports system.data.sqlclient
Imports System.IO

Public Class AddNewAA
    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private bisloading As Boolean
 
    Private Sub AddNewAA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bisloading = True

        Me.OfficerTableAdapter.Fill(Me.DAdatasets.Officer)
        Me.AATypeTableAdapter.Fill(Me.AAdata.AAType)
        Me.DADecisionTableAdapter.Fill(Me.DAdatasets.DADecision)
        Me.cboAppType.SelectedIndex = -1
        Me.cboDAOfficer.SelectedIndex = -1
        Me.cboDecision.SelectedIndex = -1
        bisloading = False
    End Sub



    Public Sub New()

        ' This call is required by the Windows Form Designer.
        bisloading = True
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

        If Me.cboAppType.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboAppType, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboAppType, "Type is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboAppType, "")

        End If


        If Me.txtFileNo.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtFileNo, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtFileNo, "File number is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtFileNo, "")

        End If


        If Me.cboDAOfficer.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDAOfficer, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDAOfficer, "Officer is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDAOfficer, "")

        End If

        If Me.cboDecision.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboDecision, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboDecision, "Description is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboDecision, "")

        End If


        Return result
    End Function


    Private NewAANo As String = String.Empty
    Public ReadOnly Property NewCCNumber() As String
        Get
            Return NewAANo
        End Get
    End Property

    Private Sub RetrieveDate(ByVal datefield As MaskedTextBox)
        Dim TheNewDate As String = String.Empty

        Dim fRegoDate As New DatePicker
        With fRegoDate
            .ShowDialog()
            TheNewDate = .GetTheDate
            .Dispose()
        End With
        If TheNewDate <> String.Empty Then datefield.Text = TheNewDate

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
                        .CommandText = "usp_AA_InsertData"

                        .Parameters.Add("@AANO", SqlDbType.NVarChar).Value = Me.txtAAno.Text
                        .Parameters.Add("@AATypeId", SqlDbType.NVarChar).Value = cboAppType.SelectedValue
                        .Parameters.Add("@AARegoDt", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@AARegoDt").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")

                        .Parameters.Add("@AADecisionId", SqlDbType.Int)
                        If cboDecision.SelectedIndex <> -1 Then .Parameters("@AADecisionId").Value = CInt(cboDecision.SelectedValue)
                        .Parameters.Add("@AAOfficerId", SqlDbType.Int)
                        If cboDAOfficer.SelectedIndex <> -1 Then .Parameters("@AAOfficerId").Value = CInt(cboDAOfficer.SelectedValue)
                        .Parameters.Add("@AAFileNo", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@AAAppName", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@AAAppAddr", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@AAAppTown", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@AAAppPC", SqlDbType.SmallInt)
                        If txtappPcode.Text <> String.Empty Then .Parameters("@AAAppPC").Value = CInt(txtappPcode.Text)
                        .Parameters.Add("@AAAppPhone", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text
                        .ExecuteNonQuery()

                    End With



                End Using
                 
                bisloading = True


            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in btnCreate_Click routine - form " & Me.Name)

            End Try
        End Using



        Me.Close()
    End Sub

 

    Private Sub btndtRego_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndtRego.Click
        RetrieveDate(Me.dtRego)
    End Sub

    Private Sub cboAppType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAppType.SelectedValueChanged
        If bisloading Then Exit Sub

        If MessageBox.Show("Create this " + Me.cboAppType.Text & " record?", "Create new Application for Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim newNumber As String = String.Empty



        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in cboAppType_SelectedValueChanged routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GettheNextAAnumber"

                        .Parameters.Add("@NEWNUMBER", SqlDbType.Int).Direction = ParameterDirection.Output
                        .Parameters.Add("@YEARS", SqlDbType.NVarChar, 4).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()
                        Dim number As String = .Parameters("@NEWNUMBER").Value.ToString
                        Dim years As String = .Parameters("@YEARS").Value.ToString

                        newNumber = Me.cboAppType.SelectedValue.ToString & number & "/" & years
                        Me.txtAAno.Text = newNumber
                        NewAANo = newNumber

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in cboAppType_SelectedValueChanged routine - form " & Me.Name)

            End Try
        End Using


    End Sub

    Private Sub btnKeep1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeep1.Click

        Dim objStreamWriter As StreamWriter

        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\da.tmp", False)
        'Write a line of text.
        objStreamWriter.WriteLine(Me.txtAppName.Text)
        objStreamWriter.WriteLine(Me.txtAppAddress.Text)
        objStreamWriter.WriteLine(Me.txtAppTown.Text)
        objStreamWriter.WriteLine(Me.txtappPcode.Text)
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
        txtappPcode.Text = strLine

        strLine = objStreamReader.ReadLine
        txtAppPhone.Text = strLine


        objStreamReader.Close()

    End Sub
End Class