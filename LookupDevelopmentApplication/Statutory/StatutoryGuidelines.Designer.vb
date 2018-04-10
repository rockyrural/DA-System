<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutoryGuidelines
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
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.GridLoadGuidLinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLoadGuidLinesTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.GridLoadGuidLinesTableAdapter()
        Me.GridLoadGuidLinesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuideLineDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuideCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblREPid = New System.Windows.Forms.Label()
        Me.btnUpdateREPCode = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLoadGuidLineList = New System.Windows.Forms.ComboBox()
        Me.LoadGuideLinesListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadGuideLinesListTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.LoadGuideLinesListTableAdapter()
        Me.txtComment = New System.Windows.Forms.TextBox()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLoadGuidLinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLoadGuidLinesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadGuideLinesListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AAdata
        '
        Me.AAdata.DataSetName = "AAdata"
        Me.AAdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLoadGuidLinesBindingSource
        '
        Me.GridLoadGuidLinesBindingSource.DataMember = "GridLoadGuidLines"
        Me.GridLoadGuidLinesBindingSource.DataSource = Me.AAdata
        '
        'GridLoadGuidLinesTableAdapter
        '
        Me.GridLoadGuidLinesTableAdapter.ClearBeforeFill = True
        '
        'GridLoadGuidLinesDataGridView
        '
        Me.GridLoadGuidLinesDataGridView.AllowUserToAddRows = False
        Me.GridLoadGuidLinesDataGridView.AllowUserToDeleteRows = False
        Me.GridLoadGuidLinesDataGridView.AutoGenerateColumns = False
        Me.GridLoadGuidLinesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.GuideLineDesc, Me.DataGridViewTextBoxColumn3, Me.GuideCode})
        Me.GridLoadGuidLinesDataGridView.DataSource = Me.GridLoadGuidLinesBindingSource
        Me.GridLoadGuidLinesDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.GridLoadGuidLinesDataGridView.Name = "GridLoadGuidLinesDataGridView"
        Me.GridLoadGuidLinesDataGridView.ReadOnly = True
        Me.GridLoadGuidLinesDataGridView.RowHeadersVisible = False
        Me.GridLoadGuidLinesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridLoadGuidLinesDataGridView.Size = New System.Drawing.Size(626, 152)
        Me.GridLoadGuidLinesDataGridView.TabIndex = 2
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
        'GuideLineDesc
        '
        Me.GuideLineDesc.DataPropertyName = "GuideLineDesc"
        Me.GuideLineDesc.HeaderText = "GuideLineDesc"
        Me.GuideLineDesc.Name = "GuideLineDesc"
        Me.GuideLineDesc.ReadOnly = True
        Me.GuideLineDesc.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Comments"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'GuideCode
        '
        Me.GuideCode.DataPropertyName = "GuideCode"
        Me.GuideCode.HeaderText = "GuideCode"
        Me.GuideCode.Name = "GuideCode"
        Me.GuideCode.ReadOnly = True
        Me.GuideCode.Visible = False
        '
        'lblREPid
        '
        Me.lblREPid.AutoSize = True
        Me.lblREPid.Location = New System.Drawing.Point(25, 220)
        Me.lblREPid.Name = "lblREPid"
        Me.lblREPid.Size = New System.Drawing.Size(0, 13)
        Me.lblREPid.TabIndex = 12
        '
        'btnUpdateREPCode
        '
        Me.btnUpdateREPCode.Location = New System.Drawing.Point(566, 252)
        Me.btnUpdateREPCode.Name = "btnUpdateREPCode"
        Me.btnUpdateREPCode.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateREPCode.TabIndex = 2
        Me.btnUpdateREPCode.Text = "Update"
        Me.btnUpdateREPCode.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Comment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "GuideLine Code"
        '
        'cboLoadGuidLineList
        '
        Me.cboLoadGuidLineList.DataSource = Me.LoadGuideLinesListBindingSource
        Me.cboLoadGuidLineList.DisplayMember = "GuideLineDesc"
        Me.cboLoadGuidLineList.Location = New System.Drawing.Point(16, 188)
        Me.cboLoadGuidLineList.Name = "cboLoadGuidLineList"
        Me.cboLoadGuidLineList.Size = New System.Drawing.Size(300, 21)
        Me.cboLoadGuidLineList.TabIndex = 0
        Me.cboLoadGuidLineList.ValueMember = "GuideCode"
        '
        'LoadGuideLinesListBindingSource
        '
        Me.LoadGuideLinesListBindingSource.DataMember = "LoadGuideLinesList"
        Me.LoadGuideLinesListBindingSource.DataSource = Me.AAdata
        '
        'LoadGuideLinesListTableAdapter
        '
        Me.LoadGuideLinesListTableAdapter.ClearBeforeFill = True
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(328, 189)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(309, 52)
        Me.txtComment.TabIndex = 13
        '
        'StatutoryGuidelines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 280)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.lblREPid)
        Me.Controls.Add(Me.btnUpdateREPCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboLoadGuidLineList)
        Me.Controls.Add(Me.GridLoadGuidLinesDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StatutoryGuidelines"
        Me.Text = "Statutory Guidelines"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLoadGuidLinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLoadGuidLinesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadGuideLinesListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents GridLoadGuidLinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLoadGuidLinesTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.GridLoadGuidLinesTableAdapter
    Friend WithEvents GridLoadGuidLinesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblREPid As System.Windows.Forms.Label
    Friend WithEvents btnUpdateREPCode As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLoadGuidLineList As System.Windows.Forms.ComboBox
    Friend WithEvents LoadGuideLinesListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadGuideLinesListTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.LoadGuideLinesListTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuideLineDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuideCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
End Class
