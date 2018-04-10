<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewDA
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CCAppNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewDA))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppName = New DevExpress.XtraEditors.MemoEdit()
        Me.txtAppAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.txtAppTown = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppPhone = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMod = New System.Windows.Forms.Label()
        Me.lblOriginalDANumber = New System.Windows.Forms.Label()
        Me.txtAAno = New System.Windows.Forms.TextBox()
        Me.txtappPcode = New DevExpress.XtraEditors.TextEdit()
        Me.cboAppType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDAOfficer = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDecision = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtRego = New DevExpress.XtraEditors.DateEdit()
        Me.btnKeep1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.lblModSuffix = New DevExpress.XtraEditors.LabelControl()
        Me.txtModeNumber = New DevExpress.XtraEditors.TextEdit()
        CCAppNoLabel = New System.Windows.Forms.Label()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppTown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtappPcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAppType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDAOfficer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRego.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRego.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModeNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CCAppNoLabel
        '
        CCAppNoLabel.AutoSize = True
        CCAppNoLabel.Location = New System.Drawing.Point(39, 43)
        CCAppNoLabel.Name = "CCAppNoLabel"
        CCAppNoLabel.Size = New System.Drawing.Size(64, 13)
        CCAppNoLabel.TabIndex = 106
        CCAppNoLabel.Text = "DA number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "File No.:"
        '
        'txtFileNo
        '
        Me.txtFileNo.Location = New System.Drawing.Point(111, 100)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtFileNo.Properties.Appearance.Options.UseBackColor = True
        Me.txtFileNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtFileNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFileNo.Size = New System.Drawing.Size(131, 20)
        Me.txtFileNo.TabIndex = 4
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(112, 163)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppName.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppName.Properties.NullValuePrompt = "Applicants Address"
        Me.txtAppName.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAppName.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAppName.Size = New System.Drawing.Size(229, 51)
        Me.txtAppName.TabIndex = 7
        '
        'txtAppAddress
        '
        Me.txtAppAddress.Location = New System.Drawing.Point(112, 214)
        Me.txtAppAddress.Name = "txtAppAddress"
        Me.txtAppAddress.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppAddress.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppAddress.Properties.NullValuePrompt = "Applicant Address"
        Me.txtAppAddress.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAppAddress.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAppAddress.Size = New System.Drawing.Size(229, 36)
        Me.txtAppAddress.TabIndex = 8
        '
        'txtAppTown
        '
        Me.txtAppTown.Location = New System.Drawing.Point(112, 250)
        Me.txtAppTown.Name = "txtAppTown"
        Me.txtAppTown.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppTown.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppTown.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppTown.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAppTown.Properties.NullValuePrompt = "Enter Town"
        Me.txtAppTown.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAppTown.Size = New System.Drawing.Size(191, 20)
        Me.txtAppTown.TabIndex = 9
        '
        'txtAppPhone
        '
        Me.txtAppPhone.Location = New System.Drawing.Point(112, 270)
        Me.txtAppPhone.Name = "txtAppPhone"
        Me.txtAppPhone.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPhone.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppPhone.Properties.NullValuePrompt = "Enter Phone Number"
        Me.txtAppPhone.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtAppPhone.Size = New System.Drawing.Size(229, 20)
        Me.txtAppPhone.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Registration Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(66, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 271)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Phone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(67, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Town:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "Officer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(112, 290)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Properties.Appearance.Options.UseBackColor = True
        Me.txtEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtEmail.Properties.NullValuePrompt = "Enter Email Address"
        Me.txtEmail.Properties.NullValuePromptShowForEmptyValue = True
        Me.txtEmail.Size = New System.Drawing.Size(229, 20)
        Me.txtEmail.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Status:"
        '
        'lblMod
        '
        Me.lblMod.AutoSize = True
        Me.lblMod.Location = New System.Drawing.Point(309, 18)
        Me.lblMod.Name = "lblMod"
        Me.lblMod.Size = New System.Drawing.Size(54, 13)
        Me.lblMod.TabIndex = 103
        Me.lblMod.Text = "of DA No:"
        Me.lblMod.Visible = False
        '
        'lblOriginalDANumber
        '
        Me.lblOriginalDANumber.AutoSize = True
        Me.lblOriginalDANumber.Location = New System.Drawing.Point(940, 15)
        Me.lblOriginalDANumber.Name = "lblOriginalDANumber"
        Me.lblOriginalDANumber.Size = New System.Drawing.Size(0, 13)
        Me.lblOriginalDANumber.TabIndex = 104
        '
        'txtAAno
        '
        Me.txtAAno.BackColor = System.Drawing.SystemColors.Window
        Me.txtAAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAAno.Location = New System.Drawing.Point(111, 41)
        Me.txtAAno.Name = "txtAAno"
        Me.txtAAno.ReadOnly = True
        Me.txtAAno.Size = New System.Drawing.Size(130, 21)
        Me.txtAAno.TabIndex = 1
        '
        'txtappPcode
        '
        Me.txtappPcode.Location = New System.Drawing.Point(302, 250)
        Me.txtappPcode.Name = "txtappPcode"
        Me.txtappPcode.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtappPcode.Properties.Appearance.Options.UseBackColor = True
        Me.txtappPcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtappPcode.Properties.Mask.EditMask = "d"
        Me.txtappPcode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtappPcode.Size = New System.Drawing.Size(39, 20)
        Me.txtappPcode.TabIndex = 10
        '
        'cboAppType
        '
        Me.cboAppType.Location = New System.Drawing.Point(111, 11)
        Me.cboAppType.Name = "cboAppType"
        Me.cboAppType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAppType.Properties.NullText = "[Select ApplicationType]"
        Me.cboAppType.Properties.ShowFooter = False
        Me.cboAppType.Properties.ShowHeader = False
        Me.cboAppType.Size = New System.Drawing.Size(192, 20)
        Me.cboAppType.TabIndex = 0
        '
        'cboDAOfficer
        '
        Me.cboDAOfficer.Location = New System.Drawing.Point(111, 125)
        Me.cboDAOfficer.Name = "cboDAOfficer"
        Me.cboDAOfficer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDAOfficer.Properties.NullText = "[Select Officer]"
        Me.cboDAOfficer.Properties.ShowFooter = False
        Me.cboDAOfficer.Properties.ShowHeader = False
        Me.cboDAOfficer.Size = New System.Drawing.Size(176, 20)
        Me.cboDAOfficer.TabIndex = 5
        '
        'cboDecision
        '
        Me.cboDecision.Location = New System.Drawing.Point(304, 125)
        Me.cboDecision.Name = "cboDecision"
        Me.cboDecision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDecision.Properties.NullText = "[Select Status]"
        Me.cboDecision.Properties.ShowFooter = False
        Me.cboDecision.Properties.ShowHeader = False
        Me.cboDecision.Size = New System.Drawing.Size(176, 20)
        Me.cboDecision.TabIndex = 6
        '
        'dtRego
        '
        Me.dtRego.EditValue = Nothing
        Me.dtRego.Location = New System.Drawing.Point(112, 70)
        Me.dtRego.Name = "dtRego"
        Me.dtRego.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Size = New System.Drawing.Size(100, 20)
        Me.dtRego.TabIndex = 3
        '
        'btnKeep1
        '
        Me.btnKeep1.Image = CType(resources.GetObject("btnKeep1.Image"), System.Drawing.Image)
        Me.btnKeep1.Location = New System.Drawing.Point(347, 163)
        Me.btnKeep1.Name = "btnKeep1"
        Me.btnKeep1.Size = New System.Drawing.Size(59, 32)
        Me.btnKeep1.TabIndex = 15
        Me.btnKeep1.TabStop = False
        Me.btnKeep1.Text = "Copy"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(388, 223)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 41)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "CANCEL"
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.Location = New System.Drawing.Point(388, 266)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(99, 41)
        Me.btnCreate.TabIndex = 14
        Me.btnCreate.Text = "CREATE"
        '
        'lblModSuffix
        '
        Me.lblModSuffix.Location = New System.Drawing.Point(251, 44)
        Me.lblModSuffix.Name = "lblModSuffix"
        Me.lblModSuffix.Size = New System.Drawing.Size(55, 13)
        Me.lblModSuffix.TabIndex = 119
        Me.lblModSuffix.Text = "Mod Suffix:"
        Me.lblModSuffix.Visible = False
        '
        'txtModeNumber
        '
        Me.txtModeNumber.Location = New System.Drawing.Point(312, 41)
        Me.txtModeNumber.Name = "txtModeNumber"
        Me.txtModeNumber.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtModeNumber.Properties.Mask.EditMask = "d"
        Me.txtModeNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtModeNumber.Size = New System.Drawing.Size(31, 20)
        Me.txtModeNumber.TabIndex = 2
        Me.txtModeNumber.Visible = False
        '
        'AddNewDA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 322)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblModSuffix)
        Me.Controls.Add(Me.txtModeNumber)
        Me.Controls.Add(Me.btnKeep1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.dtRego)
        Me.Controls.Add(Me.cboDecision)
        Me.Controls.Add(Me.cboDAOfficer)
        Me.Controls.Add(Me.cboAppType)
        Me.Controls.Add(Me.txtappPcode)
        Me.Controls.Add(Me.txtAAno)
        Me.Controls.Add(CCAppNoLabel)
        Me.Controls.Add(Me.lblOriginalDANumber)
        Me.Controls.Add(Me.lblMod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFileNo)
        Me.Controls.Add(Me.txtAppName)
        Me.Controls.Add(Me.txtAppAddress)
        Me.Controls.Add(Me.txtAppTown)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAppPhone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddNewDA"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Development Application"
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppTown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtappPcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAppType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDAOfficer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRego.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRego.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModeNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFileNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppName As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAppAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAppTown As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblMod As System.Windows.Forms.Label
    Friend WithEvents lblOriginalDANumber As System.Windows.Forms.Label
    Friend WithEvents txtAAno As System.Windows.Forms.TextBox
    Friend WithEvents txtappPcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtRego As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cboDecision As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDAOfficer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboAppType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnKeep1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblModSuffix As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModeNumber As DevExpress.XtraEditors.TextEdit
End Class
