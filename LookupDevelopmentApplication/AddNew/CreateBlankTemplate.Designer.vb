<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBlankTemplate
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateBlankTemplate))
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCreateTemplate = New DevExpress.XtraEditors.SimpleButton()
        Me.cboAppType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDAnumber = New DevExpress.XtraEditors.TextEdit()
        Me.dtRego = New DevExpress.XtraEditors.DateEdit()
        Me.txtFileNo = New DevExpress.XtraEditors.TextEdit()
        Me.cboOfficer = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtappPcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppTown = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppAddress = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppName = New DevExpress.XtraEditors.TextEdit()
        CType(Me.cboAppType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDAnumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRego.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRego.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOfficer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtappPcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppTown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(651, 141)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 35)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        '
        'btnCreateTemplate
        '
        Me.btnCreateTemplate.Image = CType(resources.GetObject("btnCreateTemplate.Image"), System.Drawing.Image)
        Me.btnCreateTemplate.Location = New System.Drawing.Point(651, 188)
        Me.btnCreateTemplate.Name = "btnCreateTemplate"
        Me.btnCreateTemplate.Size = New System.Drawing.Size(98, 35)
        Me.btnCreateTemplate.TabIndex = 1
        Me.btnCreateTemplate.Text = "Create"
        '
        'cboAppType
        '
        Me.cboAppType.Location = New System.Drawing.Point(112, 25)
        Me.cboAppType.Name = "cboAppType"
        Me.cboAppType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAppType.Properties.NullText = "[Application Type]"
        Me.cboAppType.Size = New System.Drawing.Size(133, 20)
        Me.cboAppType.TabIndex = 2
        '
        'txtDAnumber
        '
        Me.txtDAnumber.Location = New System.Drawing.Point(112, 59)
        Me.txtDAnumber.Name = "txtDAnumber"
        Me.txtDAnumber.Size = New System.Drawing.Size(100, 20)
        Me.txtDAnumber.TabIndex = 3
        '
        'dtRego
        '
        Me.dtRego.EditValue = Nothing
        Me.dtRego.Location = New System.Drawing.Point(112, 91)
        Me.dtRego.Name = "dtRego"
        Me.dtRego.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Size = New System.Drawing.Size(100, 20)
        Me.dtRego.TabIndex = 4
        '
        'txtFileNo
        '
        Me.txtFileNo.Location = New System.Drawing.Point(112, 117)
        Me.txtFileNo.Name = "txtFileNo"
        Me.txtFileNo.Size = New System.Drawing.Size(100, 20)
        Me.txtFileNo.TabIndex = 5
        '
        'cboOfficer
        '
        Me.cboOfficer.Location = New System.Drawing.Point(112, 149)
        Me.cboOfficer.Name = "cboOfficer"
        Me.cboOfficer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOfficer.Properties.NullText = "[Allocated Officer]"
        Me.cboOfficer.Size = New System.Drawing.Size(183, 20)
        Me.cboOfficer.TabIndex = 6
        '
        'cboStatus
        '
        Me.cboStatus.Location = New System.Drawing.Point(112, 175)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboStatus.Properties.NullText = "[Status?]"
        Me.cboStatus.Size = New System.Drawing.Size(133, 20)
        Me.cboStatus.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Application Type:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "D.A. Number:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Registration Date:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 120)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "File Number:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 149)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Officer:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 178)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Status:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(15, 30)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl7.TabIndex = 14
        Me.LabelControl7.Text = "Name:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(15, 83)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl8.TabIndex = 15
        Me.LabelControl8.Text = "Address:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(16, 119)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl9.TabIndex = 16
        Me.LabelControl9.Text = "Town:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 147)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl10.TabIndex = 17
        Me.LabelControl10.Text = "Phone:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 173)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl11.TabIndex = 18
        Me.LabelControl11.Text = "E-Mail:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.cboStatus)
        Me.GroupControl1.Controls.Add(Me.cboOfficer)
        Me.GroupControl1.Controls.Add(Me.txtFileNo)
        Me.GroupControl1.Controls.Add(Me.dtRego)
        Me.GroupControl1.Controls.Add(Me.txtDAnumber)
        Me.GroupControl1.Controls.Add(Me.cboAppType)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(316, 213)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "Application Details"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtEmail)
        Me.GroupControl2.Controls.Add(Me.txtAppPhone)
        Me.GroupControl2.Controls.Add(Me.txtappPcode)
        Me.GroupControl2.Controls.Add(Me.txtAppTown)
        Me.GroupControl2.Controls.Add(Me.txtAppAddress)
        Me.GroupControl2.Controls.Add(Me.txtAppName)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Location = New System.Drawing.Point(336, 10)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(304, 213)
        Me.GroupControl2.TabIndex = 117
        Me.GroupControl2.Text = "Applicant Details"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(67, 170)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(227, 20)
        Me.txtEmail.TabIndex = 122
        '
        'txtAppPhone
        '
        Me.txtAppPhone.Location = New System.Drawing.Point(67, 144)
        Me.txtAppPhone.Name = "txtAppPhone"
        Me.txtAppPhone.Size = New System.Drawing.Size(227, 20)
        Me.txtAppPhone.TabIndex = 121
        '
        'txtappPcode
        '
        Me.txtappPcode.Location = New System.Drawing.Point(257, 116)
        Me.txtappPcode.Name = "txtappPcode"
        Me.txtappPcode.Properties.Mask.EditMask = "f0"
        Me.txtappPcode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtappPcode.Size = New System.Drawing.Size(39, 20)
        Me.txtappPcode.TabIndex = 120
        '
        'txtAppTown
        '
        Me.txtAppTown.Location = New System.Drawing.Point(67, 116)
        Me.txtAppTown.Name = "txtAppTown"
        Me.txtAppTown.Size = New System.Drawing.Size(186, 20)
        Me.txtAppTown.TabIndex = 119
        '
        'txtAppAddress
        '
        Me.txtAppAddress.Location = New System.Drawing.Point(67, 80)
        Me.txtAppAddress.Name = "txtAppAddress"
        Me.txtAppAddress.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAppAddress.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.txtAppAddress.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txtAppAddress.Properties.AutoHeight = False
        Me.txtAppAddress.Size = New System.Drawing.Size(229, 36)
        Me.txtAppAddress.TabIndex = 118
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(67, 29)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAppName.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.txtAppName.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.txtAppName.Properties.AutoHeight = False
        Me.txtAppName.Size = New System.Drawing.Size(229, 51)
        Me.txtAppName.TabIndex = 117
        '
        'CreateBlankTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(761, 234)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnCreateTemplate)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CreateBlankTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Blank Template"
        CType(Me.cboAppType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDAnumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRego.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRego.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFileNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOfficer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtappPcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppTown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreateTemplate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboAppType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDAnumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtRego As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFileNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cboOfficer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtappPcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppTown As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppName As DevExpress.XtraEditors.TextEdit
End Class
