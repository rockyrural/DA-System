<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutorySEPP
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
        Dim SEPPCommentLabel As System.Windows.Forms.Label
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.LoadSEPPcodesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadSEPPcodesListTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.LoadSEPPcodesListTableAdapter()
        Me.CboLoadSEPPcodesList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateREPCode = New System.Windows.Forms.Button()
        Me.lblSEPPid = New System.Windows.Forms.Label()
        Me.Grid_Statutry_SEPP_RECORDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Grid_Statutry_SEPP_RECORDSTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.Grid_Statutry_SEPP_RECORDSTableAdapter()
        Me.Grid_Statutry_SEPP_RECORDSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seppcodeid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.SEPPCommentTextBox = New System.Windows.Forms.TextBox()
        SEPPCommentLabel = New System.Windows.Forms.Label()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadSEPPcodesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Statutry_SEPP_RECORDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Statutry_SEPP_RECORDSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEPPCommentLabel
        '
        SEPPCommentLabel.AutoSize = True
        SEPPCommentLabel.Location = New System.Drawing.Point(12, 291)
        SEPPCommentLabel.Name = "SEPPCommentLabel"
        SEPPCommentLabel.Size = New System.Drawing.Size(54, 13)
        SEPPCommentLabel.TabIndex = 2
        SEPPCommentLabel.Text = "Comment:"
        '
        'DAAssessmentDataBindingSource
        '
        Me.DAAssessmentDataBindingSource.DataMember = "DAAssessmentData"
        Me.DAAssessmentDataBindingSource.DataSource = Me.AAdata
        '
        'AAdata
        '
        Me.AAdata.DataSetName = "AAdata"
        Me.AAdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DAAssessmentDataTableAdapter
        '
        Me.DAAssessmentDataTableAdapter.ClearBeforeFill = True
        '
        'LoadSEPPcodesListBindingSource
        '
        Me.LoadSEPPcodesListBindingSource.DataMember = "LoadSEPPcodesList"
        Me.LoadSEPPcodesListBindingSource.DataSource = Me.AAdata
        '
        'LoadSEPPcodesListTableAdapter
        '
        Me.LoadSEPPcodesListTableAdapter.ClearBeforeFill = True
        '
        'CboLoadSEPPcodesList
        '
        Me.CboLoadSEPPcodesList.DataSource = Me.LoadSEPPcodesListBindingSource
        Me.CboLoadSEPPcodesList.DisplayMember = "SeppTitle"
        Me.CboLoadSEPPcodesList.Location = New System.Drawing.Point(12, 189)
        Me.CboLoadSEPPcodesList.Name = "CboLoadSEPPcodesList"
        Me.CboLoadSEPPcodesList.Size = New System.Drawing.Size(300, 21)
        Me.CboLoadSEPPcodesList.TabIndex = 0
        Me.CboLoadSEPPcodesList.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Comment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SEPP Code"
        '
        'btnUpdateREPCode
        '
        Me.btnUpdateREPCode.Location = New System.Drawing.Point(557, 254)
        Me.btnUpdateREPCode.Name = "btnUpdateREPCode"
        Me.btnUpdateREPCode.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateREPCode.TabIndex = 3
        Me.btnUpdateREPCode.Text = "Update"
        Me.btnUpdateREPCode.UseVisualStyleBackColor = True
        '
        'lblSEPPid
        '
        Me.lblSEPPid.AutoSize = True
        Me.lblSEPPid.Location = New System.Drawing.Point(32, 220)
        Me.lblSEPPid.Name = "lblSEPPid"
        Me.lblSEPPid.Size = New System.Drawing.Size(0, 13)
        Me.lblSEPPid.TabIndex = 8
        '
        'Grid_Statutry_SEPP_RECORDSBindingSource
        '
        Me.Grid_Statutry_SEPP_RECORDSBindingSource.DataMember = "Grid_Statutry_SEPP_RECORDS"
        Me.Grid_Statutry_SEPP_RECORDSBindingSource.DataSource = Me.AAdata
        '
        'Grid_Statutry_SEPP_RECORDSTableAdapter
        '
        Me.Grid_Statutry_SEPP_RECORDSTableAdapter.ClearBeforeFill = True
        '
        'Grid_Statutry_SEPP_RECORDSDataGridView
        '
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.AllowUserToAddRows = False
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.AllowUserToDeleteRows = False
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.AutoGenerateColumns = False
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.seppcodeid})
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.DataSource = Me.Grid_Statutry_SEPP_RECORDSBindingSource
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.Location = New System.Drawing.Point(15, 9)
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.Name = "Grid_Statutry_SEPP_RECORDSDataGridView"
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.ReadOnly = True
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.RowHeadersVisible = False
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.Size = New System.Drawing.Size(626, 152)
        Me.Grid_Statutry_SEPP_RECORDSDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SeppTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SEPP Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'seppcodeid
        '
        Me.seppcodeid.DataPropertyName = "seppcodeid"
        Me.seppcodeid.HeaderText = "seppcodeid"
        Me.seppcodeid.MinimumWidth = 2
        Me.seppcodeid.Name = "seppcodeid"
        Me.seppcodeid.ReadOnly = True
        Me.seppcodeid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.seppcodeid.Visible = False
        Me.seppcodeid.Width = 2
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(323, 189)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(317, 54)
        Me.txtComment.TabIndex = 25
        '
        'SEPPCommentTextBox
        '
        Me.SEPPCommentTextBox.Location = New System.Drawing.Point(15, 307)
        Me.SEPPCommentTextBox.Multiline = True
        Me.SEPPCommentTextBox.Name = "SEPPCommentTextBox"
        Me.SEPPCommentTextBox.Size = New System.Drawing.Size(620, 71)
        Me.SEPPCommentTextBox.TabIndex = 26
        '
        'StatutorySEPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 390)
        Me.Controls.Add(Me.SEPPCommentTextBox)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Grid_Statutry_SEPP_RECORDSDataGridView)
        Me.Controls.Add(Me.lblSEPPid)
        Me.Controls.Add(Me.btnUpdateREPCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboLoadSEPPcodesList)
        Me.Controls.Add(SEPPCommentLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StatutorySEPP"
        Me.Text = "Statutory SEPP"
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadSEPPcodesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Statutry_SEPP_RECORDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Statutry_SEPP_RECORDSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents LoadSEPPcodesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadSEPPcodesListTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.LoadSEPPcodesListTableAdapter
    Friend WithEvents CboLoadSEPPcodesList As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateREPCode As System.Windows.Forms.Button
    Friend WithEvents lblSEPPid As System.Windows.Forms.Label
    Friend WithEvents Grid_Statutry_SEPP_RECORDSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Grid_Statutry_SEPP_RECORDSTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.Grid_Statutry_SEPP_RECORDSTableAdapter
    Friend WithEvents Grid_Statutry_SEPP_RECORDSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents seppcodeid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents SEPPCommentTextBox As System.Windows.Forms.TextBox
End Class
