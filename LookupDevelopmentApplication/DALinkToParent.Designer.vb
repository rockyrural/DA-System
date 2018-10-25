<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DALinkToParent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoadParent = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.DaModLinkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDeterminDate = New System.Windows.Forms.Label()
        Me.lblRegoDate = New System.Windows.Forms.Label()
        Me.lblDANo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DaModLink_ChildAppsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DaModLink_ChildAppsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaModLinkTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.DaModLinkTableAdapter()
        Me.DaModLink_ChildAppsTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.DaModLink_ChildAppsTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DaModLinkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaModLink_ChildAppsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaModLink_ChildAppsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLoadParent)
        Me.Panel1.Controls.Add(Me.lblStatus)
        Me.Panel1.Controls.Add(Me.lblDescription)
        Me.Panel1.Controls.Add(Me.lblDeterminDate)
        Me.Panel1.Controls.Add(Me.lblRegoDate)
        Me.Panel1.Controls.Add(Me.lblDANo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 74)
        Me.Panel1.TabIndex = 0
        '
        'btnLoadParent
        '
        Me.btnLoadParent.Location = New System.Drawing.Point(559, 44)
        Me.btnLoadParent.Name = "btnLoadParent"
        Me.btnLoadParent.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadParent.TabIndex = 7
        Me.btnLoadParent.Text = "Go to DA"
        Me.btnLoadParent.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DaModLinkBindingSource, "DADecision", True))
        Me.lblStatus.Location = New System.Drawing.Point(284, 50)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 6
        '
        'DaModLinkBindingSource
        '
        Me.DaModLinkBindingSource.DataMember = "DaModLink"
        Me.DaModLinkBindingSource.DataSource = Me.DAdatasets
        '
        'DAdatasets
        '
        Me.DAdatasets.DataSetName = "DAdatasets"
        Me.DAdatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblDescription
        '
        Me.lblDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DaModLinkBindingSource, "DADesc", True))
        Me.lblDescription.Location = New System.Drawing.Point(284, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(343, 28)
        Me.lblDescription.TabIndex = 6
        '
        'lblDeterminDate
        '
        Me.lblDeterminDate.AutoSize = True
        Me.lblDeterminDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DaModLinkBindingSource, "DADetermDt", True))
        Me.lblDeterminDate.Location = New System.Drawing.Point(138, 50)
        Me.lblDeterminDate.Name = "lblDeterminDate"
        Me.lblDeterminDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDeterminDate.TabIndex = 6
        '
        'lblRegoDate
        '
        Me.lblRegoDate.AutoSize = True
        Me.lblRegoDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DaModLinkBindingSource, "DARegoDt", True))
        Me.lblRegoDate.Location = New System.Drawing.Point(138, 30)
        Me.lblRegoDate.Name = "lblRegoDate"
        Me.lblRegoDate.Size = New System.Drawing.Size(0, 13)
        Me.lblRegoDate.TabIndex = 6
        '
        'lblDANo
        '
        Me.lblDANo.AutoSize = True
        Me.lblDANo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DaModLinkBindingSource, "AppNo", True))
        Me.lblDANo.Location = New System.Drawing.Point(138, 10)
        Me.lblDANo.Name = "lblDANo"
        Me.lblDANo.Size = New System.Drawing.Size(0, 13)
        Me.lblDANo.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(238, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Determined Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rego Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "D.A.#"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Parent D.A."
        '
        'DaModLink_ChildAppsDataGridView
        '
        Me.DaModLink_ChildAppsDataGridView.AllowUserToAddRows = False
        Me.DaModLink_ChildAppsDataGridView.AllowUserToDeleteRows = False
        Me.DaModLink_ChildAppsDataGridView.AutoGenerateColumns = False
        Me.DaModLink_ChildAppsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2})
        Me.DaModLink_ChildAppsDataGridView.DataSource = Me.DaModLink_ChildAppsBindingSource
        Me.DaModLink_ChildAppsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DaModLink_ChildAppsDataGridView.Location = New System.Drawing.Point(0, 74)
        Me.DaModLink_ChildAppsDataGridView.Name = "DaModLink_ChildAppsDataGridView"
        Me.DaModLink_ChildAppsDataGridView.ReadOnly = True
        Me.DaModLink_ChildAppsDataGridView.RowHeadersVisible = False
        Me.DaModLink_ChildAppsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DaModLink_ChildAppsDataGridView.Size = New System.Drawing.Size(639, 166)
        Me.DaModLink_ChildAppsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ModNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DA#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DARegoDt"
        DataGridViewCellStyle1.Format = "dd/MM/yy"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DADetermDt"
        DataGridViewCellStyle2.Format = "dd/MM/yy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Determined"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DADecision"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DADesc"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DaModLink_ChildAppsBindingSource
        '
        Me.DaModLink_ChildAppsBindingSource.DataMember = "DaModLink_ChildApps"
        Me.DaModLink_ChildAppsBindingSource.DataSource = Me.DAdatasets
        '
        'DaModLinkTableAdapter
        '
        Me.DaModLinkTableAdapter.ClearBeforeFill = True
        '
        'DaModLink_ChildAppsTableAdapter
        '
        Me.DaModLink_ChildAppsTableAdapter.ClearBeforeFill = True
        '
        'DALinkToParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 240)
        Me.Controls.Add(Me.DaModLink_ChildAppsDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DALinkToParent"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DA Link To Parent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DaModLinkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaModLink_ChildAppsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaModLink_ChildAppsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblDeterminDate As System.Windows.Forms.Label
    Friend WithEvents lblRegoDate As System.Windows.Forms.Label
    Friend WithEvents lblDANo As System.Windows.Forms.Label
    Friend WithEvents DAdatasets As LookupDevelopmentApplication.DAdatasets
    Friend WithEvents DaModLinkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaModLinkTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.DaModLinkTableAdapter
    Friend WithEvents btnLoadParent As System.Windows.Forms.Button
    Friend WithEvents DaModLink_ChildAppsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaModLink_ChildAppsTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.DaModLink_ChildAppsTableAdapter
    Friend WithEvents DaModLink_ChildAppsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
