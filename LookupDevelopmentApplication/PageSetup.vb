Imports System.Drawing.Printing


Public Class PageSetup
    Private ErrorProvider As System.Windows.Forms.ErrorProvider


    Private mdl_dPrinterSetUp As Boolean


    Private Sub PopulateInstalledPrintersCombo()
        Dim prtdoc2 As New PrintDocument
        Dim strDefaultPrinter As String = String.Empty

        If My.Settings.DefaultPrinter = String.Empty Then
            strDefaultPrinter = prtdoc2.PrinterSettings.PrinterName
        Else
            strDefaultPrinter = My.Settings.DefaultPrinter
        End If
        For Each strPrinter As String In PrinterSettings.InstalledPrinters
            cboPrinters.Items.Add(strPrinter)
            If strPrinter = strDefaultPrinter Then
                cboPrinters.SelectedIndex = cboPrinters.Items.IndexOf(strPrinter)
            End If
        Next

    End Sub




    Private Sub LoadPaperSource()
        Dim myPrinterSettings As System.Drawing.Printing.PrinterSettings = New System.Drawing.Printing.PrinterSettings()
        myPrinterSettings.PrinterName = Me.cboPrinters.Text
        lbFirstTray.Items.Clear()
        lbOtherTray.Items.Clear()
        For Each myPaperSource As System.Drawing.Printing.PaperSource In myPrinterSettings.PaperSources
            lbFirstTray.Items.Add(myPaperSource.SourceName.ToString)
            lbOtherTray.Items.Add(myPaperSource.SourceName.ToString)
        Next

        lbFirstTray.Text = My.Settings.FirstTray
        lbOtherTray.Text = My.Settings.OtherTray

    End Sub

    Private mdl_PageSetup As Boolean
    Public ReadOnly Property PageHasbeenSet() As Boolean
        Get
            Return mdl_PageSetup

        End Get
    End Property

    Private Sub cboPrinters_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPrinters.SelectedIndexChanged
        LoadPaperSource()
    End Sub

    Private Sub PageSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PopulateInstalledPrintersCombo()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Not Notcheckedout() Then Exit Sub


        If Me.cboPrinters.Text <> "" Then
            My.Settings.DefaultPrinter = cboPrinters.Text
            My.Settings.FirstTray = lbFirstTray.SelectedItem.ToString
            My.Settings.OtherTray = lbOtherTray.SelectedItem.ToString
            mdl_PageSetup = True
        End If

        Me.Close()
        'Me.Dispose()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If My.Settings.FirstTray = "" Or My.Settings.OtherTray = "" Then
            MessageBox.Show("You must setup a printer the first time you run this application", "Select Printer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mdl_PageSetup = False
        End If
        Me.Close()
    End Sub


    Private Function Notcheckedout() As Boolean
        Dim result As Boolean = True



        If Me.cboPrinters.Text = String.Empty Then
            With ErrorProvider
                .SetIconAlignment(Me.cboPrinters, ErrorIconAlignment.MiddleRight)
                .SetError(Me.cboPrinters, "You MUST select a printer")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.cboPrinters, "")

        End If

        If Me.lbFirstTray.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.lbFirstTray, ErrorIconAlignment.TopRight)
                .SetError(Me.lbFirstTray, "You MUST select a first page tray")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.lbFirstTray, "")

        End If

        If Me.lbOtherTray.SelectedIndex = -1 Then
            With ErrorProvider
                .SetIconAlignment(Me.lbOtherTray, ErrorIconAlignment.TopRight)
                .SetError(Me.lbOtherTray, "You MUST select a other pages tray")
            End With
            result = False
        Else
            ErrorProvider.SetError(Me.lbOtherTray, "")

        End If


        Return result


    End Function

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ErrorProvider = New System.Windows.Forms.ErrorProvider()
        ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink

    End Sub
End Class