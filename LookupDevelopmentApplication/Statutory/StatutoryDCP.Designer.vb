<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutoryDCP
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
        Me.lblREPid = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.LoadGuideLinesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLoadGuidLinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnUpdateREPCode = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLoadDCPcodesList = New System.Windows.Forms.ComboBox()
        Me.LoadDCPcodesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLoadGuidLinesTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GridLoadGuidLinesTableAdapter()
        Me.LoadGuideLinesListTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.LoadGuideLinesListTableAdapter()
        Me.GridLoadDCPcodesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCPDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DCPCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GridLoadDCP_DArecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadDCPcodesListTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.LoadDCPcodesListTableAdapter()
        Me.GridLoadDCP_DArecordsTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GridLoadDCP_DArecordsTableAdapter()
        Me.txtComment = New System.Windows.Forms.TextBox()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadGuideLinesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLoadGuidLinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadDCPcodesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLoadDCPcodesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLoadDCP_DArecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblREPid
        '
        Me.lblREPid.AutoSize = True
        Me.lblREPid.Location = New System.Drawing.Point(27, 217)
        Me.lblREPid.Name = "lblREPid"
        Me.lblREPid.Size = New System.Drawing.Size(0, 13)
        Me.lblREPid.TabIndex = 19
        '
        'AAdata
        '
        Me.AAdata.DataSetName = "AAdata"
        Me.AAdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoadGuideLinesListBindingSource
        '
        Me.LoadGuideLinesListBindingSource.DataMember = "LoadGuideLinesList"
        Me.LoadGuideLinesListBindingSource.DataSource = Me.AAdata
        '
        'GridLoadGuidLinesBindingSource
        '
        Me.GridLoadGuidLinesBindingSource.DataMember = "GridLoadGuidLines"
        Me.GridLoadGuidLinesBindingSource.DataSource = Me.AAdata
        '
        'btnUpdateREPCode
        '
        Me.btnUpdateREPCode.Location = New System.Drawing.Point(568, 249)
        Me.btnUpdateREPCode.Name = "btnUpdateREPCode"
        Me.btnUpdateREPCode.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateREPCode.TabIndex = 2
        Me.btnUpdateREPCode.Text = "Update"
        Me.btnUpdateREPCode.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Comment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "DCP Code"
        '
        'cboLoadDCPcodesList
        '
        Me.cboLoadDCPcodesList.DataSource = Me.LoadDCPcodesListBindingSource
        Me.cboLoadDCPcodesList.DisplayMember = "DCPDesc"
        Me.cboLoadDCPcodesList.Location = New System.Drawing.Point(18, 185)
        Me.cboLoadDCPcodesList.Name = "cboLoadDCPcodesList"
        Me.cboLoadDCPcodesList.Size = New System.Drawing.Size(300, 21)
        Me.cboLoadDCPcodesList.TabIndex = 0
        Me.cboLoadDCPcodesList.ValueMember = "DCPType"
        '
        'LoadDCPcodesListBindingSource
        '
        Me.LoadDCPcodesListBindingSource.DataMember = "LoadDCPcodesList"
        Me.LoadDCPcodesListBindingSource.DataSource = Me.AAdata
        '
        'GridLoadGuidLinesTableAdapter
        '
        Me.GridLoadGuidLinesTableAdapter.ClearBeforeFill = True
        '
        'LoadGuideLinesListTableAdapter
        '
        Me.LoadGuideLinesListTableAdapter.ClearBeforeFill = True
        '
        'GridLoadDCPcodesDataGridView
        '
        Me.GridLoadDCPcodesDataGridView.AllowUserToAddRows = False
        Me.GridLoadDCPcodesDataGridView.AllowUserToDeleteRows = False
        Me.GridLoadDCPcodesDataGridView.AutoGenerateColumns = False
        Me.GridLoadDCPcodesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DCPDescDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn, Me.DCPCode})
        Me.GridLoadDCPcodesDataGridView.DataSource = Me.GridLoadDCP_DArecordsBindingSource
        Me.GridLoadDCPcodesDataGridView.Location = New System.Drawing.Point(14, 9)
        Me.GridLoadDCPcodesDataGridView.Name = "GridLoadDCPcodesDataGridView"
        Me.GridLoadDCPcodesDataGridView.ReadOnly = True
        Me.GridLoadDCPcodesDataGridView.RowHeadersVisible = False
        Me.GridLoadDCPcodesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridLoadDCPcodesDataGridView.Size = New System.Drawing.Size(626, 152)
        Me.GridLoadDCPcodesDataGridView.TabIndex = 13
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = ""
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 2
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdDataGridViewTextBoxColumn.Visible = False
        Me.IdDataGridViewTextBoxColumn.Width = 2
        '
        'DCPDescDataGridViewTextBoxColumn
        '
        Me.DCPDescDataGridViewTextBoxColumn.DataPropertyName = "DCPDesc"
        Me.DCPDescDataGridViewTextBoxColumn.HeaderText = "DCP Code"
        Me.DCPDescDataGridViewTextBoxColumn.Name = "DCPDescDataGridViewTextBoxColumn"
        Me.DCPDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.DCPDescDataGridViewTextBoxColumn.Width = 300
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommentsDataGridViewTextBoxColumn.Width = 300
        '
        'DCPCode
        '
        Me.DCPCode.DataPropertyName = "DCPCode"
        Me.DCPCode.HeaderText = "DCPCodeID"
        Me.DCPCode.MinimumWidth = 2
        Me.DCPCode.Name = "DCPCode"
        Me.DCPCode.ReadOnly = True
        Me.DCPCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DCPCode.Visible = False
        Me.DCPCode.Width = 2
        '
        'GridLoadDCP_DArecordsBindingSource
        '
        Me.GridLoadDCP_DArecordsBindingSource.DataMember = "GridLoadDCP_DArecords"
        Me.GridLoadDCP_DArecordsBindingSource.DataSource = Me.AAdata
        '
        'LoadDCPcodesListTableAdapter
        '
        Me.LoadDCPcodesListTableAdapter.ClearBeforeFill = True
        '
        'GridLoadDCP_DArecordsTableAdapter
        '
        Me.GridLoadDCP_DArecordsTableAdapter.ClearBeforeFill = True
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(332, 185)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(307, 58)
        Me.txtComment.TabIndex = 20
        '
        'StatutoryDCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 280)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblREPid)
        Me.Controls.Add(Me.btnUpdateREPCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLoadDCPcodesList)
        Me.Controls.Add(Me.GridLoadDCPcodesDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StatutoryDCP"
        Me.Text = "Statutory DCP"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadGuideLinesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLoadGuidLinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadDCPcodesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLoadDCPcodesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLoadDCP_DArecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblREPid As System.Windows.Forms.Label
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents LoadGuideLinesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLoadGuidLinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnUpdateREPCode As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLoadDCPcodesList As System.Windows.Forms.ComboBox
    Friend WithEvents GridLoadGuidLinesTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GridLoadGuidLinesTableAdapter
    Friend WithEvents LoadGuideLinesListTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.LoadGuideLinesListTableAdapter
    Friend WithEvents GridLoadDCPcodesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LoadDCPcodesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadDCPcodesListTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.LoadDCPcodesListTableAdapter
    Friend WithEvents GridLoadDCP_DArecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLoadDCP_DArecordsTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GridLoadDCP_DArecordsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCPDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DCPCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
End Class
