<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportSetupApprovalsByOfficer
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
        Me.components = New System.ComponentModel.Container
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboOfficer = New QSS.Components.Windows.Forms.ExtendedComboBox
        Me.ListOfficersandIDsForReportSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CZONES = New LookupDevelopmentApplication.CZONES
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker
        Me.btnPrint = New System.Windows.Forms.Button
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblOfficer = New System.Windows.Forms.Label
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ListOfficersandIDsForReportSelectionTableAdapter = New LookupDevelopmentApplication.CZONESTableAdapters.ListOfficersandIDsForReportSelectionTableAdapter
        Me.Panel1.SuspendLayout()
        CType(Me.ListOfficersandIDsForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboOfficer)
        Me.Panel1.Controls.Add(Me.dtpFromDate)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.dtpToDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblOfficer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 42)
        Me.Panel1.TabIndex = 0
        '
        'cboOfficer
        '
        Me.cboOfficer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOfficer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOfficer.DataSource = Me.ListOfficersandIDsForReportSelectionBindingSource
        Me.cboOfficer.DisplayMember = "Officer"
        Me.cboOfficer.Location = New System.Drawing.Point(324, 12)
        Me.cboOfficer.Name = "cboOfficer"
        Me.cboOfficer.Size = New System.Drawing.Size(217, 21)
        Me.cboOfficer.TabIndex = 19
        Me.cboOfficer.ValueMember = "OfficerId"
        '
        'ListOfficersandIDsForReportSelectionBindingSource
        '
        Me.ListOfficersandIDsForReportSelectionBindingSource.DataMember = "ListOfficersandIDsForReportSelection"
        Me.ListOfficersandIDsForReportSelectionBindingSource.DataSource = Me.CZONES
        '
        'CZONES
        '
        Me.CZONES.DataSetName = "CZONES"
        Me.CZONES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(52, 11)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpFromDate.TabIndex = 13
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(562, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(184, 11)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(87, 20)
        Me.dtpToDate.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "From"
        '
        'lblOfficer
        '
        Me.lblOfficer.AutoSize = True
        Me.lblOfficer.Location = New System.Drawing.Point(288, 15)
        Me.lblOfficer.Name = "lblOfficer"
        Me.lblOfficer.Size = New System.Drawing.Size(30, 13)
        Me.lblOfficer.TabIndex = 16
        Me.lblOfficer.Text = "From"
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.DisplayGroupTree = False
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 42)
        Me.crv.Name = "crv"
        Me.crv.SelectionFormula = ""
        Me.crv.Size = New System.Drawing.Size(859, 707)
        Me.crv.TabIndex = 21
        Me.crv.ViewTimeSelectionFormula = ""
        '
        'ListOfficersandIDsForReportSelectionTableAdapter
        '
        Me.ListOfficersandIDsForReportSelectionTableAdapter.ClearBeforeFill = True
        '
        'reportSetupApprovalsByOfficer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 749)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "reportSetupApprovalsByOfficer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Approvals By Officer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ListOfficersandIDsForReportSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboOfficer As QSS.Components.Windows.Forms.ExtendedComboBox
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOfficer As System.Windows.Forms.Label
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CZONES As LookupDevelopmentApplication.CZONES
    Friend WithEvents ListOfficersandIDsForReportSelectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListOfficersandIDsForReportSelectionTableAdapter As LookupDevelopmentApplication.CZONESTableAdapters.ListOfficersandIDsForReportSelectionTableAdapter
End Class
