<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSetupInspectionsByOfficer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.CZONES = New LookupDevelopmentApplication.CZONES()
        Me.ListOfOfficersForReportSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListOfOfficersForReportSelectionTableAdapter = New LookupDevelopmentApplication.CZONESTableAdapters.ListOfOfficersForReportSelectionTableAdapter()
        Me.cboOfficer = New System.Windows.Forms.ComboBox()
        Me.Officer = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListOfOfficersForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(562, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From"
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(184, 11)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpToDate.TabIndex = 6
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(52, 11)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpFromDate.TabIndex = 5
        '
        'CZONES
        '
        Me.CZONES.DataSetName = "CZONES"
        Me.CZONES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListOfOfficersForReportSelectionBindingSource
        '
        Me.ListOfOfficersForReportSelectionBindingSource.DataMember = "ListOfOfficersForReportSelection"
        Me.ListOfOfficersForReportSelectionBindingSource.DataSource = Me.CZONES
        '
        'ListOfOfficersForReportSelectionTableAdapter
        '
        Me.ListOfOfficersForReportSelectionTableAdapter.ClearBeforeFill = True
        '
        'cboOfficer
        '
        Me.cboOfficer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOfficer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOfficer.DataSource = Me.ListOfOfficersForReportSelectionBindingSource
        Me.cboOfficer.DisplayMember = "Officer"
        Me.cboOfficer.Location = New System.Drawing.Point(324, 12)
        Me.cboOfficer.Name = "cboOfficer"
        Me.cboOfficer.Size = New System.Drawing.Size(217, 21)
        Me.cboOfficer.TabIndex = 10
        Me.cboOfficer.ValueMember = "Officer"
        '
        'Officer
        '
        Me.Officer.AutoSize = True
        Me.Officer.Location = New System.Drawing.Point(288, 15)
        Me.Officer.Name = "Officer"
        Me.Officer.Size = New System.Drawing.Size(30, 13)
        Me.Officer.TabIndex = 7
        Me.Officer.Text = "From"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboOfficer)
        Me.Panel1.Controls.Add(Me.dtpFromDate)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.dtpToDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Officer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(884, 50)
        Me.Panel1.TabIndex = 11
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 50)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(884, 636)
        Me.crv.TabIndex = 12
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'ReportSetupInspectionsByOfficer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 686)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ReportSetupInspectionsByOfficer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report Setup Inspections By Officer"
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListOfOfficersForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CZONES As LookupDevelopmentApplication.CZONES
    Friend WithEvents ListOfOfficersForReportSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfOfficersForReportSelectionTableAdapter As LookupDevelopmentApplication.CZONESTableAdapters.ListOfOfficersForReportSelectionTableAdapter
    Friend WithEvents cboOfficer As System.Windows.Forms.ComboBox
    Friend WithEvents Officer As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
