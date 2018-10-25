Imports WORD = Microsoft.Office.Interop.Word

Imports system.data.sqlclient
Public Class EASEInsertWordDocument


#Region "Properties"


    Private _PublicID As Integer
    Public WriteOnly Property PublicID() As Integer
        Set(ByVal value As Integer)
            _PublicID = value
        End Set
    End Property


    Private FileNO As String
    Public WriteOnly Property FileNumber() As String
        Set(ByVal value As String)
            FileNO = value
        End Set
    End Property

    Private DocSumm As String
    Public WriteOnly Property DocSummary() As String
        Set(ByVal value As String)
            DocSumm = value
        End Set
    End Property

    Private DocNo As String
    Public WriteOnly Property DocNumber() As String
        Set(ByVal value As String)
            DocNo = value
        End Set
    End Property

#End Region



    Private Function CheckRecordExist() As Boolean
        Dim fileno As String = txtFileXref.Text
        Dim result As Boolean = True

        If txtFileXref.Text.IndexOf("/") > 0 Then _
            fileno = txtFileXref.Text.Substring(0, txtFileXref.Text.IndexOf("/"))

        Using cn As New SqlConnection(My.Settings.cnEASE)

            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in txtFileXref_Validating routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_GetFileDetails"

                        .Parameters.Add("@FILENUM", SqlDbType.NChar).Value = fileno
                    End With


                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    Dim RowCount As Integer = objDT.Rows.Count
                    If objDT.Rows.Count > 0 Then

                        Dim objDataRow As DataRow = objDT.Rows.Item(0)

                        Me.txtBarcode.Text = objDataRow.Item("PBarcode").ToString
                        Me.txtPartID.Text = objDataRow.Item("PId").ToString
                        Me.txtLocation.Text = objDataRow.Item("PCurLocId").ToString
                        Me.txtFileTitle.Text = objDataRow.Item("FTitle").ToString
                        Me.txtFileSubTitle.Text = objDataRow.Item("FSubTitle").ToString
                        result = True

                    Else
                        MessageBox.Show("File " & Me.txtFileXref.Text & " does not exist, please check and re-enter the number.", "Unable to locate file", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtBarcode.Text = String.Empty
                        Me.txtPartID.Text = String.Empty
                        Me.txtLocation.Text = String.Empty
                        Me.txtFileTitle.Text = String.Empty
                        Me.txtFileSubTitle.Text = String.Empty
                        txtFileXref.SelectAll()
                        result = False
                    End If

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in txtFileXref_Validating routine - form " & Me.Name)

            End Try
        End Using

        Return result

    End Function

    Private Sub SaveData()
        Using cn As New SqlConnection(My.Settings.cnEASE)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_EASEInsertNewDocument"

                        .Parameters.Add("@DOCID", SqlDbType.NVarChar).Value = DocNo
                        .Parameters.Add("@BARCODE", SqlDbType.NVarChar).Value = Me.txtBarcode.Text
                        .Parameters.Add("@SUMMARY", SqlDbType.NVarChar).Value = DocSumm
                        .Parameters.Add("@DATEWRITTEN", SqlDbType.SmallDateTime).Value = Format(Today.Date, "dd/MM/yyyy")
                        .Parameters.Add("@ACTIONOFFICER", SqlDbType.NVarChar).Value = GetEASEOfficerID()
                        .Parameters.Add("@FILENAME", SqlDbType.NVarChar).Value = DocNo.Replace(".", "_").ToString
                        .Parameters.Add("@PUBLICID", SqlDbType.NVarChar).Value = _PublicID
                        .Parameters.Add("@INOUT", SqlDbType.SmallInt).Value = 0
                        .Parameters.Add("@IMAGE", SqlDbType.Bit).Value = 1
                        .ExecuteNonQuery()

                    End With


                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in SaveData routine - form " & Me.Name)

            End Try
        End Using

    End Sub

    Private Function GetEASEOfficerID() As Integer
        Dim result As Integer
        Using cn As New SqlConnection(My.Settings.cnLIMES)
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
                        .CommandText = "usp_EASE_GetEASEOfficerID"

                        .Parameters.Add("@LANDID", SqlDbType.NVarChar).Value = My.User.Name.Substring(4)
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        Do While objDataReader.Read
                            result = CInt(objDataReader.Item(0))
                        Loop
                        objDataReader.Close()
                    End Using



                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in FunctionName routine - form " & Me.Name)

            End Try
        End Using
        Return result

    End Function

    Private Sub txtFileXref_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtFileXref.Validating
        If Not CheckRecordExist() Then e.Cancel = True

    End Sub

    Private Sub btnFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtFileXref.Text.Length = 0 Then Exit Sub
        Dim cancel As Boolean = CheckRecordExist()

    End Sub

    Private Sub btnAttachDocument_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAttachDocument.Click
        Try
            SaveData()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, " in PrintPDFdocument routine - form " & Me.Name)

        End Try
    End Sub

    Private Sub InsertEASEdocument_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtFileXref.Text = FileNO
    End Sub

    Private Sub txtFileXref_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFileXref.KeyPress
        My.Forms.DAApplication.KeyPressSendTab(e)
    End Sub
End Class