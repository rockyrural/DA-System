Imports System.Data.SqlClient

Public Class AssignOfficerList
    Private ErrorProvider As New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider

    Private _AppNo As String

    Public WriteOnly Property AppNumber As String
        Set(ByVal value As String)
            _AppNo = value
        End Set
    End Property

    Private _sysRef As String

    Public WriteOnly Property SysRef As String
        Set(ByVal value As String)
            _sysRef = value
        End Set
    End Property


    Private OfficersName As String = String.Empty

    Public ReadOnly Property Officer As String
        Get
            Return OfficersName
        End Get
    End Property



    Private Sub LoadOfficersList(ByVal external As Boolean)

        Using cn As New SqlConnection(My.Settings.connectionString)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficersList routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_SelectListOfActiveOfficers"
                        .Parameters.Add("@EXTERNAL", SqlDbType.Bit).Value = External
                    End With

                    Dim objDT As New DataTable


                    Using objDataReader As SqlDataReader = cmd.ExecuteReader
                        objDT.Load(objDataReader)
                    End Using


                    grdOfficers.DataSource = objDT

                End Using
                 



            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in LoadOfficersList routine - form " & Me.Name)

            End Try
        End Using




    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        LoadOfficersList(False)
    End Sub

    Private Sub btnAssignOfficer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAssignOfficer.Click

        If txtreasonAssigned.Text = String.Empty Then
            ErrorProvider.SetError(Me.txtreasonAssigned, "The reason reassigned cannot be blank.  Please provide a reason")

            'MessageBox.Show("The reason reassigned cannot be blank.  Please provide a reason", "Reason Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        ElseIf gvwOfficers.SelectedRowsCount = 0 Then

            ErrorProvider.SetError(grdOfficers, "You MUST select an officer.")

            'MessageBox.Show("You MUST select an officer.", "Officer Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return

        Else

            ErrorProvider.SetError(Me.txtreasonAssigned, "")
            ErrorProvider.SetError(grdOfficers, "")


            Dim myobj As DataRowView = CType(gvwOfficers.GetFocusedRow, DataRowView)

            OfficersName = myobj.Row.Item("Officer").ToString

            Using cn As New SqlConnection(My.Settings.connectionString)
                Try
                    cn.Open()
                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnAssignOfficer_Click routine - form " & Me.Name)

                End Try


                Try

                    Using cmd As New SqlCommand

                        With cmd
                            .Connection = cn
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "usp_AssignNewOfficer"

                            .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = _AppNo
                            .Parameters.Add("@DAOfficerId", SqlDbType.Int).Value = CInt(myobj.Row.Item("OfficerId"))
                            .Parameters.Add("@REASON", SqlDbType.NVarChar).Value = txtreasonAssigned.Text
                            .Parameters.Add("@SYSREF", SqlDbType.NVarChar).Value = _sysRef
                            .ExecuteNonQuery()

                        End With


                    End Using




                Catch ex As SqlException
                    MessageBox.Show(ex.Message, " in btnAssignOfficer_Click routine - form " & Me.Name)

                End Try
            End Using
            DialogResult = DialogResult.OK

        End If
    End Sub


    Private Sub rbnInternal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnInternal.Click
        LoadList()
    End Sub

    Private Sub rbnExternal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnExternal.Click
        LoadList()

    End Sub

    Private Sub LoadList()
        If rbnExternal.Checked Then
            LoadOfficersList(True)
        Else
            LoadOfficersList(False)

        End If



    End Sub
End Class