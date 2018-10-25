Imports system.data.sqlclient
Imports System.IO


Public Class AddNewCD

    Private ErrorProvider As System.Windows.Forms.ErrorProvider
    Private bisloading As Boolean

    Private Sub AddNewCD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bisloading = True

        Me.OfficerTableAdapter.Fill(Me.DAdatasets.Officer)
        Me.DADecisionTableAdapter.Fill(Me.DAdatasets.DADecision)
        Me.cboDAOfficer.SelectedIndex = -1
        Me.cboDecision.SelectedIndex = -1
        bisloading = False
    End Sub

    Private Sub GetNextCDNumber()
        Using cn As New SqlConnection(My.Settings.DataConnection)
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
                        .CommandText = "usp_GetNextCDNumber"

                        .Parameters.Add("@CDNO", SqlDbType.NVarChar, 10).Direction = ParameterDirection.Output

                        .ExecuteNonQuery()
                        Dim number As String = .Parameters("@CDNO").Value.ToString

                        Me.txtCDno.Text = number
                        txtCDno.ReadOnly = True
                        NewCDNo = number
                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in AddNewCC_Load routine - form " & Me.Name)

            End Try
        End Using
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

        If Me.txtCDno.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtCDno, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtCDno, "CD number is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtCDno, "")

        End If


        If Not IsDate(dtRego.Text) Then
            With ErrorProvider
                .SetIconAlignment(Me.dtRego, ErrorIconAlignment.MiddleRight)
                .SetError(Me.dtRego, "Registered date is a required field")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.dtRego, "")

        End If


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

        If Me.txtappPcode.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.txtappPcode, ErrorIconAlignment.MiddleRight)
                .SetError(Me.txtappPcode, "Applicants postcode is required")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.txtappPcode, "")

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


    Private NewCDNo As String = String.Empty
    Public ReadOnly Property NewCDNumber() As String
        Get
            Return NewCDNo
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
        datefield.Text = TheNewDate

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
                        .CommandText = "usp_CD_InsertData"

                        .Parameters.Add("@CDNO", SqlDbType.NVarChar).Value = Me.txtCDno.Text
                        .Parameters.Add("@CDRegoDt", SqlDbType.SmallDateTime)
                        If IsDate(Me.dtRego.Text) Then .Parameters("@CDRegoDt").Value = Format(CDate(dtRego.Text), "dd/MM/yyyy")

                        .Parameters.Add("@CDDecisionId", SqlDbType.Int)
                        If cboDecision.SelectedIndex <> -1 Then .Parameters("@CDDecisionId").Value = CInt(cboDecision.SelectedValue)
                        .Parameters.Add("@CDOfficerId", SqlDbType.Int)
                        If cboDAOfficer.SelectedIndex <> -1 Then .Parameters("@CDOfficerId").Value = CInt(cboDAOfficer.SelectedValue)
                        .Parameters.Add("@CDFileNo", SqlDbType.NVarChar).Value = Me.txtFileNo.Text
                        .Parameters.Add("@CDAppName", SqlDbType.NVarChar).Value = Me.txtAppName.Text
                        .Parameters.Add("@CDAppAddr", SqlDbType.NVarChar).Value = Me.txtAppAddress.Text
                        .Parameters.Add("@CDAppTown", SqlDbType.NVarChar).Value = Me.txtAppTown.Text
                        .Parameters.Add("@CDAppPC", SqlDbType.SmallInt)
                        If txtappPcode.Text <> String.Empty Then .Parameters("@CDAppPC").Value = CInt(txtappPcode.Text)
                        .Parameters.Add("@CDAppPhone", SqlDbType.NVarChar).Value = Me.txtAppPhone.Text
                        .ExecuteNonQuery()

                    End With



                End Using
                 
                NewCDNo = Me.txtCDno.Text
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


    Private Sub cboCertifier_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCertifier.SelectedValueChanged
        Select Case cboCertifier.Text.ToUpper
            Case "COUNCIL"
                GetNextCDNumber()
                Me.txtCDno.ReadOnly = True


            Case "PRIVATE"
                Me.txtCDno.ReadOnly = False
                Me.txtCDno.Focus()

            Case Else

        End Select

    End Sub

End Class