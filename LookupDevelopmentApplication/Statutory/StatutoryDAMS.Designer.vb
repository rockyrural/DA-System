<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatutoryDAMS
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
        Dim DamShapeLabel As System.Windows.Forms.Label
        Dim DamLengthLabel As System.Windows.Forms.Label
        Dim DamWidthLabel As System.Windows.Forms.Label
        Dim DamDepthLabel As System.Windows.Forms.Label
        Dim DamExistVolLabel As System.Windows.Forms.Label
        Dim DamLotSizeLabel As System.Windows.Forms.Label
        Dim DamMultiplierLabel As System.Windows.Forms.Label
        Dim DamSubdivDateLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.DamYNLabel = New System.Windows.Forms.Label()
        Me.AAdata = New LookupDevelopmentApplication.AAdata()
        Me.DAAssessmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAAssessmentDataTableAdapter = New LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter()
        Me.cboDamYN = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DamWidthTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DamLengthTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.txtVolume = New DevExpress.XtraEditors.TextEdit()
        Me.txtLicenceRequired = New DevExpress.XtraEditors.TextEdit()
        Me.txtDifference = New DevExpress.XtraEditors.TextEdit()
        Me.txtAllowed = New DevExpress.XtraEditors.TextEdit()
        Me.txtMHRDC = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalVolume = New DevExpress.XtraEditors.TextEdit()
        Me.txtArea = New DevExpress.XtraEditors.TextEdit()
        Me.btnDARegoDt = New System.Windows.Forms.Button()
        Me.DamSubdivDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DamShapeExtendedComboBox = New System.Windows.Forms.ComboBox()
        Me.DamDepthTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DamExistVolTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DamLotSizeTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.DamMultiplierTextBox = New DevExpress.XtraEditors.TextEdit()
        DamShapeLabel = New System.Windows.Forms.Label()
        DamLengthLabel = New System.Windows.Forms.Label()
        DamWidthLabel = New System.Windows.Forms.Label()
        DamDepthLabel = New System.Windows.Forms.Label()
        DamExistVolLabel = New System.Windows.Forms.Label()
        DamLotSizeLabel = New System.Windows.Forms.Label()
        DamMultiplierLabel = New System.Windows.Forms.Label()
        DamSubdivDateLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DamShapeLabel
        '
        DamShapeLabel.AutoSize = True
        DamShapeLabel.Location = New System.Drawing.Point(27, 19)
        DamShapeLabel.Name = "DamShapeLabel"
        DamShapeLabel.Size = New System.Drawing.Size(41, 13)
        DamShapeLabel.TabIndex = 0
        DamShapeLabel.Text = "Shape:"
        '
        'DamLengthLabel
        '
        DamLengthLabel.AutoSize = True
        DamLengthLabel.Location = New System.Drawing.Point(8, 50)
        DamLengthLabel.Name = "DamLengthLabel"
        DamLengthLabel.Size = New System.Drawing.Size(60, 13)
        DamLengthLabel.TabIndex = 2
        DamLengthLabel.Text = "Length (m):"
        '
        'DamWidthLabel
        '
        DamWidthLabel.AutoSize = True
        DamWidthLabel.Location = New System.Drawing.Point(13, 74)
        DamWidthLabel.Name = "DamWidthLabel"
        DamWidthLabel.Size = New System.Drawing.Size(55, 13)
        DamWidthLabel.TabIndex = 4
        DamWidthLabel.Text = "Width (m):"
        '
        'DamDepthLabel
        '
        DamDepthLabel.AutoSize = True
        DamDepthLabel.Location = New System.Drawing.Point(236, 19)
        DamDepthLabel.Name = "DamDepthLabel"
        DamDepthLabel.Size = New System.Drawing.Size(56, 13)
        DamDepthLabel.TabIndex = 6
        DamDepthLabel.Text = "Depth (m):"
        '
        'DamExistVolLabel
        '
        DamExistVolLabel.AutoSize = True
        DamExistVolLabel.Location = New System.Drawing.Point(201, 74)
        DamExistVolLabel.Name = "DamExistVolLabel"
        DamExistVolLabel.Size = New System.Drawing.Size(91, 13)
        DamExistVolLabel.TabIndex = 8
        DamExistVolLabel.Text = "Existing  Vol (ML):"
        '
        'DamLotSizeLabel
        '
        DamLotSizeLabel.AutoSize = True
        DamLotSizeLabel.Location = New System.Drawing.Point(440, 19)
        DamLotSizeLabel.Name = "DamLotSizeLabel"
        DamLotSizeLabel.Size = New System.Drawing.Size(69, 13)
        DamLotSizeLabel.TabIndex = 10
        DamLotSizeLabel.Text = "Lot Size (ha):"
        '
        'DamMultiplierLabel
        '
        DamMultiplierLabel.AutoSize = True
        DamMultiplierLabel.Location = New System.Drawing.Point(458, 46)
        DamMultiplierLabel.Name = "DamMultiplierLabel"
        DamMultiplierLabel.Size = New System.Drawing.Size(51, 13)
        DamMultiplierLabel.TabIndex = 12
        DamMultiplierLabel.Text = "Multiplier:"
        '
        'DamSubdivDateLabel
        '
        DamSubdivDateLabel.AutoSize = True
        DamSubdivDateLabel.Location = New System.Drawing.Point(419, 74)
        DamSubdivDateLabel.Name = "DamSubdivDateLabel"
        DamSubdivDateLabel.Size = New System.Drawing.Size(90, 13)
        DamSubdivDateLabel.TabIndex = 14
        DamSubdivDateLabel.Text = "Subdivision Date:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(223, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(69, 13)
        Label1.TabIndex = 6
        Label1.Text = "Volume (ML):"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(6, 153)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(114, 13)
        Label2.TabIndex = 6
        Label2.Text = "Allowed MHRDC (ML):"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(236, 153)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(56, 13)
        Label3.TabIndex = 6
        Label3.Text = "Difference"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(419, 153)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(97, 13)
        Label4.TabIndex = 6
        Label4.Text = "Licence Required?"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(6, 109)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(60, 13)
        Label5.TabIndex = 6
        Label5.Text = "Area (sqm):"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(191, 109)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(101, 13)
        Label6.TabIndex = 6
        Label6.Text = "Total Volumes (ML):"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(419, 109)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(92, 13)
        Label7.TabIndex = 6
        Label7.Text = "MHRDC Calc ML:"
        '
        'DamYNLabel
        '
        Me.DamYNLabel.AutoSize = True
        Me.DamYNLabel.Location = New System.Drawing.Point(12, 9)
        Me.DamYNLabel.Name = "DamYNLabel"
        Me.DamYNLabel.Size = New System.Drawing.Size(161, 13)
        Me.DamYNLabel.TabIndex = 2
        Me.DamYNLabel.Text = "DAM CALCULATION APPLIES?"
        '
        'AAdata
        '
        Me.AAdata.DataSetName = "AAdata"
        Me.AAdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DAAssessmentDataBindingSource
        '
        Me.DAAssessmentDataBindingSource.DataMember = "DAAssessmentData"
        Me.DAAssessmentDataBindingSource.DataSource = Me.AAdata
        '
        'DAAssessmentDataTableAdapter
        '
        Me.DAAssessmentDataTableAdapter.ClearBeforeFill = True
        '
        'cboDamYN
        '
        Me.cboDamYN.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "DamYN", True))
        Me.cboDamYN.FormattingEnabled = True
        Me.cboDamYN.Location = New System.Drawing.Point(179, 6)
        Me.cboDamYN.Name = "cboDamYN"
        Me.cboDamYN.Size = New System.Drawing.Size(74, 21)
        Me.cboDamYN.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DamMultiplierTextBox)
        Me.GroupBox1.Controls.Add(Me.DamLotSizeTextBox)
        Me.GroupBox1.Controls.Add(Me.DamExistVolTextBox)
        Me.GroupBox1.Controls.Add(Me.DamDepthTextBox)
        Me.GroupBox1.Controls.Add(Me.DamWidthTextBox)
        Me.GroupBox1.Controls.Add(Me.DamLengthTextBox)
        Me.GroupBox1.Controls.Add(Me.txtVolume)
        Me.GroupBox1.Controls.Add(Me.txtLicenceRequired)
        Me.GroupBox1.Controls.Add(Me.txtDifference)
        Me.GroupBox1.Controls.Add(Me.txtAllowed)
        Me.GroupBox1.Controls.Add(Me.txtMHRDC)
        Me.GroupBox1.Controls.Add(Me.txtTotalVolume)
        Me.GroupBox1.Controls.Add(Me.txtArea)
        Me.GroupBox1.Controls.Add(Me.btnDARegoDt)
        Me.GroupBox1.Controls.Add(DamSubdivDateLabel)
        Me.GroupBox1.Controls.Add(Me.DamSubdivDateMaskedTextBox)
        Me.GroupBox1.Controls.Add(DamMultiplierLabel)
        Me.GroupBox1.Controls.Add(DamLotSizeLabel)
        Me.GroupBox1.Controls.Add(DamExistVolLabel)
        Me.GroupBox1.Controls.Add(Label7)
        Me.GroupBox1.Controls.Add(Label6)
        Me.GroupBox1.Controls.Add(Label4)
        Me.GroupBox1.Controls.Add(Label5)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(DamDepthLabel)
        Me.GroupBox1.Controls.Add(DamWidthLabel)
        Me.GroupBox1.Controls.Add(DamLengthLabel)
        Me.GroupBox1.Controls.Add(DamShapeLabel)
        Me.GroupBox1.Controls.Add(Me.DamShapeExtendedComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 187)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'DamWidthTextBox
        '
        Me.DamWidthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DamWidth", True))
        Me.DamWidthTextBox.Location = New System.Drawing.Point(74, 71)
        Me.DamWidthTextBox.Name = "DamWidthTextBox"
        Me.DamWidthTextBox.Size = New System.Drawing.Size(87, 20)
        Me.DamWidthTextBox.TabIndex = 32
        '
        'DamLengthTextBox
        '
        Me.DamLengthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DamLength", True))
        Me.DamLengthTextBox.Location = New System.Drawing.Point(74, 47)
        Me.DamLengthTextBox.Name = "DamLengthTextBox"
        Me.DamLengthTextBox.Size = New System.Drawing.Size(87, 20)
        Me.DamLengthTextBox.TabIndex = 5
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(293, 43)
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.ReadOnly = True
        Me.txtVolume.Size = New System.Drawing.Size(86, 20)
        Me.txtVolume.TabIndex = 31
        '
        'txtLicenceRequired
        '
        Me.txtLicenceRequired.Location = New System.Drawing.Point(515, 150)
        Me.txtLicenceRequired.Name = "txtLicenceRequired"
        Me.txtLicenceRequired.ReadOnly = True
        Me.txtLicenceRequired.Size = New System.Drawing.Size(86, 20)
        Me.txtLicenceRequired.TabIndex = 31
        '
        'txtDifference
        '
        Me.txtDifference.Location = New System.Drawing.Point(293, 150)
        Me.txtDifference.Name = "txtDifference"
        Me.txtDifference.ReadOnly = True
        Me.txtDifference.Size = New System.Drawing.Size(86, 20)
        Me.txtDifference.TabIndex = 30
        '
        'txtAllowed
        '
        Me.txtAllowed.Location = New System.Drawing.Point(126, 150)
        Me.txtAllowed.Name = "txtAllowed"
        Me.txtAllowed.ReadOnly = True
        Me.txtAllowed.Size = New System.Drawing.Size(86, 20)
        Me.txtAllowed.TabIndex = 29
        '
        'txtMHRDC
        '
        Me.txtMHRDC.Location = New System.Drawing.Point(515, 106)
        Me.txtMHRDC.Name = "txtMHRDC"
        Me.txtMHRDC.ReadOnly = True
        Me.txtMHRDC.Size = New System.Drawing.Size(86, 20)
        Me.txtMHRDC.TabIndex = 28
        '
        'txtTotalVolume
        '
        Me.txtTotalVolume.Location = New System.Drawing.Point(293, 106)
        Me.txtTotalVolume.Name = "txtTotalVolume"
        Me.txtTotalVolume.ReadOnly = True
        Me.txtTotalVolume.Size = New System.Drawing.Size(86, 20)
        Me.txtTotalVolume.TabIndex = 27
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(72, 106)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(86, 20)
        Me.txtArea.TabIndex = 26
        '
        'btnDARegoDt
        '
        Me.btnDARegoDt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDARegoDt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDARegoDt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDARegoDt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDARegoDt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDARegoDt.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnDARegoDt.Location = New System.Drawing.Point(604, 71)
        Me.btnDARegoDt.Name = "btnDARegoDt"
        Me.btnDARegoDt.Size = New System.Drawing.Size(20, 20)
        Me.btnDARegoDt.TabIndex = 20
        Me.btnDARegoDt.Text = "u"
        Me.btnDARegoDt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDARegoDt.UseVisualStyleBackColor = False
        '
        'DamSubdivDateMaskedTextBox
        '
        Me.DamSubdivDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DamSubdivDate", True))
        Me.DamSubdivDateMaskedTextBox.Location = New System.Drawing.Point(515, 71)
        Me.DamSubdivDateMaskedTextBox.Name = "DamSubdivDateMaskedTextBox"
        Me.DamSubdivDateMaskedTextBox.ReadOnly = True
        Me.DamSubdivDateMaskedTextBox.Size = New System.Drawing.Size(86, 20)
        Me.DamSubdivDateMaskedTextBox.TabIndex = 7
        Me.DamSubdivDateMaskedTextBox.TabStop = False
        '
        'DamShapeExtendedComboBox
        '
        Me.DamShapeExtendedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DAAssessmentDataBindingSource, "DamShape", True))
        Me.DamShapeExtendedComboBox.FormattingEnabled = True
        Me.DamShapeExtendedComboBox.Location = New System.Drawing.Point(74, 16)
        Me.DamShapeExtendedComboBox.Name = "DamShapeExtendedComboBox"
        Me.DamShapeExtendedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DamShapeExtendedComboBox.TabIndex = 0
        '
        'DamDepthTextBox
        '
        Me.DamDepthTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DamDepth", True))
        Me.DamDepthTextBox.Location = New System.Drawing.Point(293, 16)
        Me.DamDepthTextBox.Name = "DamDepthTextBox"
        Me.DamDepthTextBox.Size = New System.Drawing.Size(87, 20)
        Me.DamDepthTextBox.TabIndex = 33
        '
        'DamExistVolTextBox
        '
        Me.DamExistVolTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DamExistVol", True))
        Me.DamExistVolTextBox.Location = New System.Drawing.Point(293, 71)
        Me.DamExistVolTextBox.Name = "DamExistVolTextBox"
        Me.DamExistVolTextBox.Size = New System.Drawing.Size(87, 20)
        Me.DamExistVolTextBox.TabIndex = 34
        '
        'DamLotSizeTextBox
        '
        Me.DamLotSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DamLotSize", True))
        Me.DamLotSizeTextBox.Location = New System.Drawing.Point(515, 16)
        Me.DamLotSizeTextBox.Name = "DamLotSizeTextBox"
        Me.DamLotSizeTextBox.Size = New System.Drawing.Size(87, 20)
        Me.DamLotSizeTextBox.TabIndex = 35
        '
        'DamMultiplierTextBox
        '
        Me.DamMultiplierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DAAssessmentDataBindingSource, "DamMultiplier", True))
        Me.DamMultiplierTextBox.Location = New System.Drawing.Point(515, 43)
        Me.DamMultiplierTextBox.Name = "DamMultiplierTextBox"
        Me.DamMultiplierTextBox.Size = New System.Drawing.Size(87, 20)
        Me.DamMultiplierTextBox.TabIndex = 36
        '
        'StatutoryDAMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 239)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DamYNLabel)
        Me.Controls.Add(Me.cboDamYN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "StatutoryDAMS"
        Me.Text = "Statutory DAMS"
        CType(Me.AAdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAAssessmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AAdata As LookupDevelopmentApplication.AAdata
    Friend WithEvents DAAssessmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAAssessmentDataTableAdapter As LookupDevelopmentApplication.AAdataTableAdapters.DAAssessmentDataTableAdapter
    Friend WithEvents cboDamYN As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DamYNLabel As System.Windows.Forms.Label
    Friend WithEvents DamShapeExtendedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DamSubdivDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnDARegoDt As System.Windows.Forms.Button
    Friend WithEvents txtVolume As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLicenceRequired As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDifference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAllowed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMHRDC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalVolume As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DamWidthTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DamLengthTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DamDepthTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DamExistVolTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DamLotSizeTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DamMultiplierTextBox As DevExpress.XtraEditors.TextEdit
End Class
