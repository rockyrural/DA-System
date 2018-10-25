<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewCD
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
        Dim CCAppNoLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.OfficerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets()
        Me.CCDescWorkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CCdata = New LookupDevelopmentApplication.CCdata()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboDecision = New System.Windows.Forms.ComboBox()
        Me.DADecisionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFileNo = New System.Windows.Forms.TextBox()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.txtAppAddress = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.DADecisionTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.DADecisionTableAdapter()
        Me.OfficerTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.OfficerTableAdapter()
        Me.txtCDno = New System.Windows.Forms.TextBox()
        Me.txtAppTown = New System.Windows.Forms.TextBox()
        Me.AssessmentData = New LookupDevelopmentApplication.AssessmentData()
        Me.CCBuildSolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CCAppTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CCClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDAOfficer = New System.Windows.Forms.ComboBox()
        Me.dtRego = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btndtRego = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAppPhone = New System.Windows.Forms.TextBox()
        Me.CCAppTypeTableAdapter = New LookupDevelopmentApplication.AssessmentDataTableAdapters.CCAppTypeTableAdapter()
        Me.CCDescWorkTableAdapter = New LookupDevelopmentApplication.CCdataTableAdapters.CCDescWorkTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CCBuildSolTableAdapter = New LookupDevelopmentApplication.CCdataTableAdapters.CCBuildSolTableAdapter()
        Me.CCClassTableAdapter = New LookupDevelopmentApplication.CCdataTableAdapters.CCClassTableAdapter()
        Me.btnKeep1 = New System.Windows.Forms.Button()
        Me.btnUse1 = New System.Windows.Forms.Button()
        Me.cboCertifier = New System.Windows.Forms.ComboBox()
        Me.txtappPcode = New LookupDevelopmentApplication.NumericTextBox()
        CCAppNoLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OfficerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCDescWorkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DADecisionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessmentData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCBuildSolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCAppTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CCClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CCAppNoLabel
        '
        CCAppNoLabel.AutoSize = True
        CCAppNoLabel.Location = New System.Drawing.Point(39, 52)
        CCAppNoLabel.Name = "CCAppNoLabel"
        CCAppNoLabel.Size = New System.Drawing.Size(64, 13)
        CCAppNoLabel.TabIndex = 97
        CCAppNoLabel.Text = "CD App No:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(3, 15)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(101, 13)
        Label10.TabIndex = 114
        Label10.Text = "Who is the certifier?"
        '
        'AAdata
        '
        Me.AAdata.DataSetName = "AAdata"
        Me.AAdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OfficerBindingSource
        '
        Me.OfficerBindingSource.DataMember = "Officer"
        Me.OfficerBindingSource.DataSource = Me.DAdatasets
        '
        'DAdatasets
        '
        Me.DAdatasets.DataSetName = "DAdatasets"
        Me.DAdatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CCDescWorkBindingSource
        '
        Me.CCDescWorkBindingSource.DataMember = "CCDescWork"
        Me.CCDescWorkBindingSource.DataSource = Me.CCdata
        '
        'CCdata
        '
        Me.CCdata.DataSetName = "CCdata"
        Me.CCdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "File No.:"
        '
        'cboDecision
        '
        Me.cboDecision.BackColor = System.Drawing.SystemColors.Window
        Me.cboDecision.DataSource = Me.DADecisionBindingSource
        Me.cboDecision.DisplayMember = "DADecision"
        Me.cboDecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDecision.FormattingEnabled = True
        Me.cboDecision.Location = New System.Drawing.Point(408, 76)
        Me.cboDecision.Name = "cboDecision"
        Me.cboDecision.Size = New System.Drawing.Size(176, 21)
        Me.cboDecision.TabIndex = 83
        Me.cboDecision.ValueMember = "DADecisionId"
        '
        'DADecisionBindingSource
        '
        Me.DADecisionBindingSource.DataMember = "DADecision"
        Me.DADecisionBindingSource.DataSource = Me.DAdatasets
        '
        'txtFileNo
        '
        Me.txtFileNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFileNo.Location = New System.Drawing.Point(110, 103)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Size = New System.Drawing.Size(131, 20)
        Me.txtFileNo.TabIndex = 81
        '
        'txtAppName
        '
        Me.txtAppName.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppName.Location = New System.Drawing.Point(110, 129)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(192, 20)
        Me.txtAppName.TabIndex = 84
        '
        'txtAppAddress
        '
        Me.txtAppAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppAddress.Location = New System.Drawing.Point(110, 148)
        Me.txtAppAddress.Multiline = True
        Me.txtAppAddress.Name = "txtAppAddress"
        Me.txtAppAddress.Size = New System.Drawing.Size(192, 36)
        Me.txtAppAddress.TabIndex = 85
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(433, 183)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(151, 41)
        Me.btnCreate.TabIndex = 99
        Me.btnCreate.Text = "Create record"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'DADecisionTableAdapter
        '
        Me.DADecisionTableAdapter.ClearBeforeFill = True
        '
        'OfficerTableAdapter
        '
        Me.OfficerTableAdapter.ClearBeforeFill = True
        '
        'txtCDno
        '
        Me.txtCDno.BackColor = System.Drawing.SystemColors.Window
        Me.txtCDno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCDno.Location = New System.Drawing.Point(110, 50)
        Me.txtCDno.Name = "txtCDno"
        Me.txtCDno.Size = New System.Drawing.Size(121, 20)
        Me.txtCDno.TabIndex = 78
        '
        'txtAppTown
        '
        Me.txtAppTown.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppTown.Location = New System.Drawing.Point(110, 183)
        Me.txtAppTown.Name = "txtAppTown"
        Me.txtAppTown.Size = New System.Drawing.Size(154, 20)
        Me.txtAppTown.TabIndex = 86
        '
        'AssessmentData
        '
        Me.AssessmentData.DataSetName = "AssessmentData"
        Me.AssessmentData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CCBuildSolBindingSource
        '
        Me.CCBuildSolBindingSource.DataMember = "CCBuildSol"
        Me.CCBuildSolBindingSource.DataSource = Me.CCdata
        '
        'CCAppTypeBindingSource
        '
        Me.CCAppTypeBindingSource.DataMember = "CCAppType"
        Me.CCAppTypeBindingSource.DataSource = Me.AssessmentData
        '
        'CCClassBindingSource
        '
        Me.CCClassBindingSource.DataMember = "CCClass"
        Me.CCClassBindingSource.DataSource = Me.CCdata
        '
        'cboDAOfficer
        '
        Me.cboDAOfficer.BackColor = System.Drawing.SystemColors.Window
        Me.cboDAOfficer.DataSource = Me.OfficerBindingSource
        Me.cboDAOfficer.DisplayMember = "Officer"
        Me.cboDAOfficer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDAOfficer.FormattingEnabled = True
        Me.cboDAOfficer.Location = New System.Drawing.Point(408, 50)
        Me.cboDAOfficer.Name = "cboDAOfficer"
        Me.cboDAOfficer.Size = New System.Drawing.Size(176, 21)
        Me.cboDAOfficer.TabIndex = 82
        Me.cboDAOfficer.ValueMember = "OfficerId"
        '
        'dtRego
        '
        Me.dtRego.BackColor = System.Drawing.SystemColors.Info
        Me.dtRego.Location = New System.Drawing.Point(110, 77)
        Me.dtRego.Mask = "00/00/0000"
        Me.dtRego.Name = "dtRego"
        Me.dtRego.ReadOnly = True
        Me.dtRego.Size = New System.Drawing.Size(65, 20)
        Me.dtRego.TabIndex = 80
        Me.dtRego.ValidatingType = GetType(Date)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(364, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Officer:"
        '
        'btndtRego
        '
        Me.btndtRego.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndtRego.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndtRego.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndtRego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndtRego.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndtRego.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btndtRego.Location = New System.Drawing.Point(177, 77)
        Me.btndtRego.Name = "btndtRego"
        Me.btndtRego.Size = New System.Drawing.Size(20, 20)
        Me.btndtRego.TabIndex = 96
        Me.btndtRego.Text = "u"
        Me.btndtRego.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndtRego.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(67, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Town:"
        '
        'txtAppPhone
        '
        Me.txtAppPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppPhone.Location = New System.Drawing.Point(110, 204)
        Me.txtAppPhone.Name = "txtAppPhone"
        Me.txtAppPhone.Size = New System.Drawing.Size(192, 20)
        Me.txtAppPhone.TabIndex = 87
        '
        'CCAppTypeTableAdapter
        '
        Me.CCAppTypeTableAdapter.ClearBeforeFill = True
        '
        'CCDescWorkTableAdapter
        '
        Me.CCDescWorkTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Registration Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(362, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Phone:"
        '
        'CCBuildSolTableAdapter
        '
        Me.CCBuildSolTableAdapter.ClearBeforeFill = True
        '
        'CCClassTableAdapter
        '
        Me.CCClassTableAdapter.ClearBeforeFill = True
        '
        'btnKeep1
        '
        Me.btnKeep1.Location = New System.Drawing.Point(308, 183)
        Me.btnKeep1.Name = "btnKeep1"
        Me.btnKeep1.Size = New System.Drawing.Size(40, 23)
        Me.btnKeep1.TabIndex = 109
        Me.btnKeep1.Text = "Keep"
        Me.btnKeep1.UseVisualStyleBackColor = True
        '
        'btnUse1
        '
        Me.btnUse1.Location = New System.Drawing.Point(308, 206)
        Me.btnUse1.Name = "btnUse1"
        Me.btnUse1.Size = New System.Drawing.Size(40, 23)
        Me.btnUse1.TabIndex = 111
        Me.btnUse1.Text = "Use"
        Me.btnUse1.UseVisualStyleBackColor = True
        '
        'cboCertifier
        '
        Me.cboCertifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCertifier.FormattingEnabled = True
        Me.cboCertifier.Items.AddRange(New Object() {"Council", "Private"})
        Me.cboCertifier.Location = New System.Drawing.Point(110, 12)
        Me.cboCertifier.Name = "cboCertifier"
        Me.cboCertifier.Size = New System.Drawing.Size(121, 21)
        Me.cboCertifier.TabIndex = 115
        '
        'txtappPcode
        '
        Me.txtappPcode.AllowSpace = False
        Me.txtappPcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtappPcode.Location = New System.Drawing.Point(263, 183)
        Me.txtappPcode.Name = "txtappPcode"
        Me.txtappPcode.Size = New System.Drawing.Size(39, 20)
        Me.txtappPcode.TabIndex = 116
        '
        'AddNewCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 254)
        Me.Controls.Add(Me.txtappPcode)
        Me.Controls.Add(Me.cboCertifier)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.btnUse1)
        Me.Controls.Add(Me.btnKeep1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDecision)
        Me.Controls.Add(Me.txtFileNo)
        Me.Controls.Add(Me.txtAppName)
        Me.Controls.Add(Me.txtAppAddress)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtCDno)
        Me.Controls.Add(Me.txtAppTown)
        Me.Controls.Add(CCAppNoLabel)
        Me.Controls.Add(Me.cboDAOfficer)
        Me.Controls.Add(Me.dtRego)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btndtRego)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAppPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddNewCD"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New CD"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OfficerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCDescWorkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DADecisionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessmentData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCBuildSolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCAppTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CCClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents OfficerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAdatasets As LookupDevelopmentApplication.DAdatasets
    Friend WithEvents CCDescWorkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CCdata As LookupDevelopmentApplication.CCdata
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDecision As System.Windows.Forms.ComboBox
    Friend WithEvents DADecisionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtFileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAppName As System.Windows.Forms.TextBox
    Friend WithEvents txtAppAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents DADecisionTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.DADecisionTableAdapter
    Friend WithEvents OfficerTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.OfficerTableAdapter
    Friend WithEvents txtCDno As System.Windows.Forms.TextBox
    Friend WithEvents txtAppTown As System.Windows.Forms.TextBox
    Friend WithEvents AssessmentData As LookupDevelopmentApplication.AssessmentData
    Friend WithEvents CCBuildSolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CCAppTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CCClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cboDAOfficer As System.Windows.Forms.ComboBox
    Friend WithEvents dtRego As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btndtRego As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAppPhone As System.Windows.Forms.TextBox
    Friend WithEvents CCAppTypeTableAdapter As LookupDevelopmentApplication.AssessmentDataTableAdapters.CCAppTypeTableAdapter
    Friend WithEvents CCDescWorkTableAdapter As LookupDevelopmentApplication.CCdataTableAdapters.CCDescWorkTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CCBuildSolTableAdapter As LookupDevelopmentApplication.CCdataTableAdapters.CCBuildSolTableAdapter
    Friend WithEvents CCClassTableAdapter As LookupDevelopmentApplication.CCdataTableAdapters.CCClassTableAdapter
    Friend WithEvents btnKeep1 As System.Windows.Forms.Button
    Friend WithEvents btnUse1 As System.Windows.Forms.Button
    Friend WithEvents cboCertifier As System.Windows.Forms.ComboBox
    Friend WithEvents txtappPcode As LookupDevelopmentApplication.NumericTextBox
End Class
