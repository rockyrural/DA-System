Imports System.IO
Imports System.String
Imports System.StringSplitOptions

Imports system.data.sqlclient
Public Class DAMApMerge
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkStrata As System.Windows.Forms.CheckBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chkStrata = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(81, 40)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(80, 24)
        Me.btnRun.TabIndex = 7
        Me.btnRun.Text = "Run"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DereferenceLinks = False
        '
        'chkStrata
        '
        Me.chkStrata.AutoSize = True
        Me.chkStrata.Location = New System.Drawing.Point(80, 17)
        Me.chkStrata.Name = "chkStrata"
        Me.chkStrata.Size = New System.Drawing.Size(83, 17)
        Me.chkStrata.TabIndex = 8
        Me.chkStrata.Text = "Strata/Units"
        Me.chkStrata.UseVisualStyleBackColor = True
        '
        'DAMApMerge
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(242, 86)
        Me.Controls.Add(Me.chkStrata)
        Me.Controls.Add(Me.btnRun)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DAMApMerge"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DA Map Merge Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private MapMergeRan As Boolean = False

    Private DANo As String
    Public WriteOnly Property DAnumber() As String
        Set(ByVal value As String)
            DANo = value
        End Set
    End Property


    Public ReadOnly Property FileGenerated() As Boolean
        Get
            Return MapMergeRan
        End Get
    End Property
    'Private Sub btnRun_ClickExtracted()
    '    If My.Computer.FileSystem.DirectoryExists("c:\gis") Then
    '        My.Computer.FileSystem.CreateDirectory("c:\gis")
    '    End If

    '    If My.Computer.FileSystem.DirectoryExists("c:\gis\docs") Then
    '        My.Computer.FileSystem.CreateDirectory("c:\gis\docs")

    '    End If


    '    Dim Ok As Boolean = True ' Assume success

    '    Try
    '        ' Attempt to open the input file for read-only access

    '        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            Dim srIn As New System.IO.StreamReader(OpenFileDialog1.FileName)
    '            'Dim fsIn As New FileStream(txtInput.Text, FileMode.Open, FileAccess.Read, FileShare.Read)
    '            'Dim srIn As New StreamReader(fsIn, True)
    '            Dim swOut As New StreamWriter("c:\gis\docs\mapmerge.txt", False)
    '            Dim i As Integer
    '            Dim j As Integer
    '            Dim LineOut As String
    '            Dim testArray As String() = {"</td><td>", "</td></tr><tr><td>"}

    '            ' Process every line in the file
    '            Dim Line As String = srIn.ReadLine()
    '            Line = srIn.ReadLine
    '            LineOut = """Owners_Name""" + "," + """Owners_Addr1""" + "," + """Owners_Addr2""" + "," + """Tag_Key"""
    '            swOut.WriteLine(LineOut)
    '            While (Not (Line Is Nothing)) And (Line <> "</table>")
    '                Line = Line.Substring(8, Line.Length - 18)
    '                Line = Line.Replace("&amp;", "&")
    '                Dim Words As String() = Line.Split(testArray, None) ' Split the line into words
    '                If chkStrata.Checked Then
    '                    For j = 0 To CInt((Words.Length / 6) - 1)
    '                        LineOut = """" + Words(j * 6 + 0) + """"
    '                        For i = 3 To 5
    '                            LineOut = LineOut + ",""" + Words(j * 6 + i) + """"
    '                        Next

    '                        swOut.WriteLine(LineOut)
    '                    Next
    '                Else
    '                    For j = 0 To CInt((Words.Length / 4) - 1)
    '                        LineOut = """" + Words(j * 4 + 0) + """"
    '                        For i = 1 To 3
    '                            LineOut = LineOut + ",""" + Words(j * 4 + i) + """"
    '                        Next

    '                        swOut.WriteLine(LineOut)
    '                    Next
    '                End If
    '                Line = srIn.ReadLine
    '            End While
    '            ' Explicitly close the StreamReader to properly flush all buffers
    '            srIn.Close() ' This also closes the FileStream (fsIn)
    '            swOut.Close()
    '        End If
    '    Catch

    '    End Try ' The specified input file could not be opened
    '    Me.Close()
    'End Sub
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        RemoveOldMapData()
        InsertMapMergData()
        MapMergeRan = True
        Me.Close()
    End Sub
    Private Sub InsertMapMergDataExtracted(ByVal name As String, ByVal address As String, ByVal town As String, ByVal tag As Integer)
        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertMapMergData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_Insert_Into_MapMerge"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .Parameters.Add("@NAME", SqlDbType.NVarChar).Value = Name
                        .Parameters.Add("@ADDRS", SqlDbType.NVarChar).Value = address
                        .Parameters.Add("@TOWN", SqlDbType.NVarChar).Value = town
                        .Parameters.Add("@TAG", SqlDbType.Int).Value = Tag
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in InsertMapMergData routine - form " & Me.Name)

            End Try
        End Using
    End Sub
    Private Sub InsertMapMergData()
        Dim Ok As Boolean = True ' Assume success
        Dim name As String = String.Empty
        Dim address As String = String.Empty
        Dim town As String = String.Empty
        Dim tag As Integer

        Dim NUMBEROFCOLUMNS As Integer = 6

        If chkStrata.Checked Then NUMBEROFCOLUMNS = 7



        Try
            ' Attempt to open the input file for read-only access

            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim srIn As New System.IO.StreamReader(OpenFileDialog1.FileName)
                Dim testArray As String() = {"</td><td>", "</td></tr><tr><td>"}

                '' Process every line in the file
                Dim Line As String = srIn.ReadLine()
                Line = srIn.ReadLine
                While (Not (Line Is Nothing)) And (Line <> "</table>")
                    Line = Line.Substring(8, Line.Length - 18)
                    Line = Line.Replace("&amp;", "&")
                    Dim Words As String() = Line.Split(testArray, None) ' Split the line into words
                    If chkStrata.Checked Then
                        For j As Integer = 0 To (Words.Length / NUMBEROFCOLUMNS) - 1
                            name = Words(j * NUMBEROFCOLUMNS + 0).ToString
                            address = Words(j * NUMBEROFCOLUMNS + 3).ToString
                            town = Words(j * NUMBEROFCOLUMNS + 4).ToString
                            tag = CInt(Words(j * NUMBEROFCOLUMNS + 6))
                            InsertMapMergDataExtracted(name, address, town, tag)

                        Next


                    Else
                        For j As Integer = 0 To (Words.Length / NUMBEROFCOLUMNS) - 1
                            name = Words(j * NUMBEROFCOLUMNS + 0).ToString
                            address = Words(j * NUMBEROFCOLUMNS + 1).ToString
                            town = Words(j * NUMBEROFCOLUMNS + 2).ToString
                            tag = CInt(Words(j * NUMBEROFCOLUMNS + 3))

                            InsertMapMergDataExtracted(name, address, town, tag)
                        Next


                    End If
                    Line = srIn.ReadLine


                End While
                ' Explicitly close the StreamReader to properly flush all buffers
                srIn.Close() ' This also closes the FileStream (fsIn)
            End If
            My.Computer.FileSystem.DeleteFile(OpenFileDialog1.FileName)
        Catch

        End Try ' 
    End Sub
    Private Sub RemoveOldMapData()


        Using cn As New SqlConnection(My.Settings.DataConnection)
            Try
                cn.Open()
            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldMapData routine - form " & Me.Name)

            End Try


            Try

                Using cmd As New SqlCommand

                    With cmd
                        .Connection = cn
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "usp_RemoveOldMapMergeData"

                        .Parameters.Add("@DANO", SqlDbType.NVarChar).Value = DANo
                        .ExecuteNonQuery()

                    End With


                End Using




            Catch ex As SqlException
                MessageBox.Show(ex.Message, " in RemoveOldMapData routine - form " & Me.Name)

            End Try
        End Using


    End Sub
End Class
