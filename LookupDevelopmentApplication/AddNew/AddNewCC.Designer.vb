<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewCC
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewCC))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAppPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppPcode = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppTown = New DevExpress.XtraEditors.TextEdit()
        Me.txtAppAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.txtAppName = New DevExpress.XtraEditors.TextEdit()
        Me.txtDANo = New DevExpress.XtraEditors.TextEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCCno = New DevExpress.XtraEditors.TextEdit()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnCreate = New DevExpress.XtraEditors.SimpleButton()
        Me.btnKeep1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUse2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtEstCost = New DevExpress.XtraEditors.TextEdit()
        Me.txtDesc = New DevExpress.XtraEditors.MemoEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.cboCertifier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboAppType = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboOfficer = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboDecision = New DevExpress.XtraEditors.LookUpEdit()
        Me.cboBldgSolution = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtRego = New DevExpress.XtraEditors.DateEdit()
        Me.lvwCodes = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cboBldgCodeAust = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        CCAppNoLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.txtAppPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppPcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppTown.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAppName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDANo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCertifier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboAppType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboOfficer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDecision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboBldgSolution.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRego.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRego.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cboBldgCodeAust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CCAppNoLabel
        '
        CCAppNoLabel.AutoSize = True
        CCAppNoLabel.Location = New System.Drawing.Point(49, 50)
        CCAppNoLabel.Name = "CCAppNoLabel"
        CCAppNoLabel.Size = New System.Drawing.Size(60, 13)
        CCAppNoLabel.TabIndex = 33
        CCAppNoLabel.Text = "CCApp No:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(8, 24)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(103, 13)
        Label7.TabIndex = 33
        Label7.Text = "Who is the certifier?"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(29, 133)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 13)
        Label1.TabIndex = 113
        Label1.Text = "Estimated Cost:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(325, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Phone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(325, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Town:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(325, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Registration Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DA No.:"
        '
        'txtAppPhone
        '
        Me.txtAppPhone.Location = New System.Drawing.Point(389, 94)
        Me.txtAppPhone.Name = "txtAppPhone"
        Me.txtAppPhone.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPhone.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppPhone.Size = New System.Drawing.Size(192, 20)
        Me.txtAppPhone.TabIndex = 13
        '
        'txtAppPcode
        '
        Me.txtAppPcode.Location = New System.Drawing.Point(542, 73)
        Me.txtAppPcode.Name = "txtAppPcode"
        Me.txtAppPcode.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPcode.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppPcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppPcode.Size = New System.Drawing.Size(39, 20)
        Me.txtAppPcode.TabIndex = 12
        '
        'txtAppTown
        '
        Me.txtAppTown.Location = New System.Drawing.Point(389, 73)
        Me.txtAppTown.Name = "txtAppTown"
        Me.txtAppTown.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppTown.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppTown.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppTown.Size = New System.Drawing.Size(154, 20)
        Me.txtAppTown.TabIndex = 11
        '
        'txtAppAddress
        '
        Me.txtAppAddress.Location = New System.Drawing.Point(389, 38)
        Me.txtAppAddress.Name = "txtAppAddress"
        Me.txtAppAddress.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppAddress.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppAddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppAddress.Size = New System.Drawing.Size(192, 36)
        Me.txtAppAddress.TabIndex = 10
        '
        'txtAppName
        '
        Me.txtAppName.Location = New System.Drawing.Point(389, 19)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppName.Properties.Appearance.Options.UseBackColor = True
        Me.txtAppName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAppName.Size = New System.Drawing.Size(192, 20)
        Me.txtAppName.TabIndex = 9
        '
        'txtDANo
        '
        Me.txtDANo.Location = New System.Drawing.Point(243, 48)
        Me.txtDANo.Name = "txtDANo"
        Me.txtDANo.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.txtDANo.Properties.Appearance.Options.UseBackColor = True
        Me.txtDANo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDANo.Properties.ReadOnly = True
        Me.txtDANo.Size = New System.Drawing.Size(64, 20)
        Me.txtDANo.TabIndex = 0
        Me.txtDANo.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(71, 159)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Officer:"
        '
        'txtCCno
        '
        Me.txtCCno.Location = New System.Drawing.Point(115, 48)
        Me.txtCCno.Name = "txtCCno"
        Me.txtCCno.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtCCno.Properties.Appearance.Options.UseBackColor = True
        Me.txtCCno.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCCno.Size = New System.Drawing.Size(64, 20)
        Me.txtCCno.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(46, 212)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(66, 13)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "Bld Solution:"
        '
        'btnCreate
        '
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.Location = New System.Drawing.Point(528, 252)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(99, 41)
        Me.btnCreate.TabIndex = 44
        Me.btnCreate.Text = "Create " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Certificate"
        '
        'btnKeep1
        '
        Me.btnKeep1.Image = CType(resources.GetObject("btnKeep1.Image"), System.Drawing.Image)
        Me.btnKeep1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnKeep1.Location = New System.Drawing.Point(587, 67)
        Me.btnKeep1.Name = "btnKeep1"
        Me.btnKeep1.Size = New System.Drawing.Size(40, 23)
        Me.btnKeep1.TabIndex = 109
        '
        'btnUse2
        '
        Me.btnUse2.Image = CType(resources.GetObject("btnUse2.Image"), System.Drawing.Image)
        Me.btnUse2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnUse2.Location = New System.Drawing.Point(587, 90)
        Me.btnUse2.Name = "btnUse2"
        Me.btnUse2.Size = New System.Drawing.Size(40, 23)
        Me.btnUse2.TabIndex = 110
        '
        'txtEstCost
        '
        Me.txtEstCost.Location = New System.Drawing.Point(115, 131)
        Me.txtEstCost.Name = "txtEstCost"
        Me.txtEstCost.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtEstCost.Properties.Appearance.Options.UseBackColor = True
        Me.txtEstCost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtEstCost.Properties.DisplayFormat.FormatString = "c"
        Me.txtEstCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEstCost.Properties.EditFormat.FormatString = "c"
        Me.txtEstCost.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEstCost.Properties.Mask.EditMask = "c"
        Me.txtEstCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEstCost.Size = New System.Drawing.Size(100, 20)
        Me.txtEstCost.TabIndex = 112
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(325, 131)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Properties.Appearance.BackColor = System.Drawing.SystemColors.Window
        Me.txtDesc.Properties.Appearance.Options.UseBackColor = True
        Me.txtDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDesc.Size = New System.Drawing.Size(302, 50)
        Me.txtDesc.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(325, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Description:"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "PowerShot S1 IS.ico")
        Me.ImageList2.Images.SetKeyName(1, "Tips.ico")
        Me.ImageList2.Images.SetKeyName(2, "BINOCULR.ICO")
        Me.ImageList2.Images.SetKeyName(3, "NOTE14.ICO")
        Me.ImageList2.Images.SetKeyName(4, "Printer_OFF.ico")
        Me.ImageList2.Images.SetKeyName(5, "writer.ico")
        Me.ImageList2.Images.SetKeyName(6, "RECYFULL.ICO")
        Me.ImageList2.Images.SetKeyName(7, "CDROM02.ICO")
        Me.ImageList2.Images.SetKeyName(8, "Delete.ico")
        Me.ImageList2.Images.SetKeyName(9, "dollar.ico")
        Me.ImageList2.Images.SetKeyName(10, "props.ico")
        Me.ImageList2.Images.SetKeyName(11, "SCDRESPL.ICO")
        Me.ImageList2.Images.SetKeyName(12, "SCDRESNL.ICO")
        Me.ImageList2.Images.SetKeyName(13, "Add Record.ico")
        '
        'cboCertifier
        '
        Me.cboCertifier.Location = New System.Drawing.Point(113, 21)
        Me.cboCertifier.Name = "cboCertifier"
        Me.cboCertifier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCertifier.Properties.Items.AddRange(New Object() {"Council", "Private"})
        Me.cboCertifier.Properties.NullText = "[Select Certifier Type]"
        Me.cboCertifier.Properties.NullValuePrompt = "[Select Certifier Type]"
        Me.cboCertifier.Properties.NullValuePromptShowForEmptyValue = True
        Me.cboCertifier.Size = New System.Drawing.Size(133, 20)
        Me.cboCertifier.TabIndex = 121
        '
        'cboAppType
        '
        Me.cboAppType.Location = New System.Drawing.Point(115, 77)
        Me.cboAppType.Name = "cboAppType"
        Me.cboAppType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboAppType.Properties.NullText = "[Select Type]"
        Me.cboAppType.Size = New System.Drawing.Size(131, 20)
        Me.cboAppType.TabIndex = 122
        '
        'cboOfficer
        '
        Me.cboOfficer.Location = New System.Drawing.Point(115, 157)
        Me.cboOfficer.Name = "cboOfficer"
        Me.cboOfficer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboOfficer.Properties.NullText = "[Select Officer]"
        Me.cboOfficer.Size = New System.Drawing.Size(176, 20)
        Me.cboOfficer.TabIndex = 123
        '
        'cboDecision
        '
        Me.cboDecision.Location = New System.Drawing.Point(115, 183)
        Me.cboDecision.Name = "cboDecision"
        Me.cboDecision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDecision.Properties.NullText = "[Select Description]"
        Me.cboDecision.Size = New System.Drawing.Size(176, 20)
        Me.cboDecision.TabIndex = 124
        '
        'cboBldgSolution
        '
        Me.cboBldgSolution.Location = New System.Drawing.Point(115, 209)
        Me.cboBldgSolution.Name = "cboBldgSolution"
        Me.cboBldgSolution.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBldgSolution.Properties.NullText = "[Select Solution]"
        Me.cboBldgSolution.Size = New System.Drawing.Size(176, 20)
        Me.cboBldgSolution.TabIndex = 125
        '
        'dtRego
        '
        Me.dtRego.EditValue = Nothing
        Me.dtRego.Location = New System.Drawing.Point(115, 103)
        Me.dtRego.Name = "dtRego"
        Me.dtRego.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Size = New System.Drawing.Size(100, 20)
        Me.dtRego.TabIndex = 126
        '
        'lvwCodes
        '
        Me.lvwCodes.FullRowSelect = True
        Me.lvwCodes.GridLines = True
        Me.lvwCodes.Location = New System.Drawing.Point(8, 20)
        Me.lvwCodes.MultiSelect = False
        Me.lvwCodes.Name = "lvwCodes"
        Me.lvwCodes.Size = New System.Drawing.Size(75, 81)
        Me.lvwCodes.TabIndex = 116
        Me.lvwCodes.UseCompatibleStateImageBehavior = False
        Me.lvwCodes.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.cboBldgCodeAust)
        Me.GroupBox1.Controls.Add(Me.lvwCodes)
        Me.GroupBox1.Location = New System.Drawing.Point(317, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 107)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bldg Code of Aust.:"
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(92, 78)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(30, 23)
        Me.btnRemove.TabIndex = 119
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(92, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(30, 23)
        Me.btnAdd.TabIndex = 118
        '
        'cboBldgCodeAust
        '
        Me.cboBldgCodeAust.Location = New System.Drawing.Point(92, 17)
        Me.cboBldgCodeAust.Name = "cboBldgCodeAust"
        Me.cboBldgCodeAust.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboBldgCodeAust.Properties.NullText = "[Code?]"
        Me.cboBldgCodeAust.Size = New System.Drawing.Size(67, 20)
        Me.cboBldgCodeAust.TabIndex = 117
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(528, 206)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 41)
        Me.btnCancel.TabIndex = 127
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "CANCEL"
        '
        'AddNewCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dtRego)
        Me.Controls.Add(Me.cboBldgSolution)
        Me.Controls.Add(Me.cboDecision)
        Me.Controls.Add(Me.cboOfficer)
        Me.Controls.Add(Me.cboAppType)
        Me.Controls.Add(Me.cboCertifier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEstCost)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.btnUse2)
        Me.Controls.Add(Me.btnKeep1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtCCno)
        Me.Controls.Add(Me.txtDANo)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtAppName)
        Me.Controls.Add(Me.txtAppAddress)
        Me.Controls.Add(Me.txtAppTown)
        Me.Controls.Add(Me.txtAppPcode)
        Me.Controls.Add(Me.txtAppPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Label7)
        Me.Controls.Add(CCAppNoLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddNewCC"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Construction Certificate"
        CType(Me.txtAppPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppPcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppTown.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAppName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDANo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCertifier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboAppType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboOfficer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDecision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboBldgSolution.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRego.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRego.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cboBldgCodeAust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAppPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppPcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppTown As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAppAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAppName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDANo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCCno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnCreate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnKeep1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnUse2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtEstCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDesc As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents cboCertifier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cboAppType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboOfficer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboDecision As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboBldgSolution As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtRego As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lvwCodes As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRemove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboBldgCodeAust As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
