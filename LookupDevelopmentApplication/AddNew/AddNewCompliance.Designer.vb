<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewCompliance
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
        Dim CCAppNoLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.grpPrinCert = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLicenceNo = New System.Windows.Forms.TextBox()
        Me.txtCoPCAPhone = New System.Windows.Forms.TextBox()
        Me.txtCoPCAPcode = New System.Windows.Forms.TextBox()
        Me.txtCoPCATown = New System.Windows.Forms.TextBox()
        Me.txtCoPCAaddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBuildersNames = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpApplicant = New System.Windows.Forms.GroupBox()
        Me.btnUse2 = New System.Windows.Forms.Button()
        Me.btnKeep1 = New System.Windows.Forms.Button()
        Me.txtAppName = New System.Windows.Forms.TextBox()
        Me.txtAppAddress = New System.Windows.Forms.TextBox()
        Me.txtAppTown = New System.Windows.Forms.TextBox()
        Me.txtAppPhone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAppPcode = New System.Windows.Forms.TextBox()
        Me.txtCCno = New System.Windows.Forms.TextBox()
        Me.btndtRego = New System.Windows.Forms.Button()
        Me.dtRego = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDANo = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.cboCertifier = New System.Windows.Forms.ComboBox()
        CCAppNoLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.grpPrinCert.SuspendLayout()
        Me.grpApplicant.SuspendLayout()
        Me.SuspendLayout()
        '
        'CCAppNoLabel
        '
        CCAppNoLabel.AutoSize = True
        CCAppNoLabel.Location = New System.Drawing.Point(269, 15)
        CCAppNoLabel.Name = "CCAppNoLabel"
        CCAppNoLabel.Size = New System.Drawing.Size(65, 13)
        CCAppNoLabel.TabIndex = 62
        CCAppNoLabel.Text = "Co App No.:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(21, 15)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(101, 13)
        Label10.TabIndex = 112
        Label10.Text = "Who is the certifier?"
        '
        'grpPrinCert
        '
        Me.grpPrinCert.Controls.Add(Me.Label7)
        Me.grpPrinCert.Controls.Add(Me.txtLicenceNo)
        Me.grpPrinCert.Controls.Add(Me.txtCoPCAPhone)
        Me.grpPrinCert.Controls.Add(Me.txtCoPCAPcode)
        Me.grpPrinCert.Controls.Add(Me.txtCoPCATown)
        Me.grpPrinCert.Controls.Add(Me.txtCoPCAaddress)
        Me.grpPrinCert.Controls.Add(Me.Label1)
        Me.grpPrinCert.Controls.Add(Me.Label3)
        Me.grpPrinCert.Controls.Add(Me.cboBuildersNames)
        Me.grpPrinCert.Controls.Add(Me.Label5)
        Me.grpPrinCert.Controls.Add(Me.Label6)
        Me.grpPrinCert.Location = New System.Drawing.Point(325, 69)
        Me.grpPrinCert.Name = "grpPrinCert"
        Me.grpPrinCert.Size = New System.Drawing.Size(299, 151)
        Me.grpPrinCert.TabIndex = 50
        Me.grpPrinCert.TabStop = False
        Me.grpPrinCert.Text = "Principal Certifying Authority"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Accreditation No:"
        '
        'txtLicenceNo
        '
        Me.txtLicenceNo.Location = New System.Drawing.Point(114, 118)
        Me.txtLicenceNo.Name = "txtLicenceNo"
        Me.txtLicenceNo.ReadOnly = True
        Me.txtLicenceNo.Size = New System.Drawing.Size(100, 20)
        Me.txtLicenceNo.TabIndex = 33
        '
        'txtCoPCAPhone
        '
        Me.txtCoPCAPhone.Location = New System.Drawing.Point(66, 95)
        Me.txtCoPCAPhone.Name = "txtCoPCAPhone"
        Me.txtCoPCAPhone.ReadOnly = True
        Me.txtCoPCAPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtCoPCAPhone.TabIndex = 32
        '
        'txtCoPCAPcode
        '
        Me.txtCoPCAPcode.Location = New System.Drawing.Point(245, 74)
        Me.txtCoPCAPcode.Name = "txtCoPCAPcode"
        Me.txtCoPCAPcode.ReadOnly = True
        Me.txtCoPCAPcode.Size = New System.Drawing.Size(43, 20)
        Me.txtCoPCAPcode.TabIndex = 31
        '
        'txtCoPCATown
        '
        Me.txtCoPCATown.Location = New System.Drawing.Point(66, 74)
        Me.txtCoPCATown.Name = "txtCoPCATown"
        Me.txtCoPCATown.ReadOnly = True
        Me.txtCoPCATown.Size = New System.Drawing.Size(180, 20)
        Me.txtCoPCATown.TabIndex = 30
        '
        'txtCoPCAaddress
        '
        Me.txtCoPCAaddress.Location = New System.Drawing.Point(66, 40)
        Me.txtCoPCAaddress.Multiline = True
        Me.txtCoPCAaddress.Name = "txtCoPCAaddress"
        Me.txtCoPCAaddress.ReadOnly = True
        Me.txtCoPCAaddress.Size = New System.Drawing.Size(222, 35)
        Me.txtCoPCAaddress.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Address:"
        '
        'cboBuildersNames
        '
        Me.cboBuildersNames.FormattingEnabled = True
        Me.cboBuildersNames.Location = New System.Drawing.Point(66, 19)
        Me.cboBuildersNames.Name = "cboBuildersNames"
        Me.cboBuildersNames.Size = New System.Drawing.Size(222, 21)
        Me.cboBuildersNames.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Town:"
        '
        'grpApplicant
        '
        Me.grpApplicant.Controls.Add(Me.btnUse2)
        Me.grpApplicant.Controls.Add(Me.btnKeep1)
        Me.grpApplicant.Controls.Add(Me.txtAppName)
        Me.grpApplicant.Controls.Add(Me.txtAppAddress)
        Me.grpApplicant.Controls.Add(Me.txtAppTown)
        Me.grpApplicant.Controls.Add(Me.txtAppPhone)
        Me.grpApplicant.Controls.Add(Me.Label8)
        Me.grpApplicant.Controls.Add(Me.Label9)
        Me.grpApplicant.Controls.Add(Me.Label12)
        Me.grpApplicant.Controls.Add(Me.Label11)
        Me.grpApplicant.Controls.Add(Me.txtAppPcode)
        Me.grpApplicant.Location = New System.Drawing.Point(12, 69)
        Me.grpApplicant.Name = "grpApplicant"
        Me.grpApplicant.Size = New System.Drawing.Size(301, 151)
        Me.grpApplicant.TabIndex = 49
        Me.grpApplicant.TabStop = False
        Me.grpApplicant.Text = "Applicant"
        '
        'btnUse2
        '
        Me.btnUse2.Location = New System.Drawing.Point(251, 88)
        Me.btnUse2.Name = "btnUse2"
        Me.btnUse2.Size = New System.Drawing.Size(40, 23)
        Me.btnUse2.TabIndex = 112
        Me.btnUse2.Text = "Use"
        Me.btnUse2.UseVisualStyleBackColor = True
        '
        'btnKeep1
        '
        Me.btnKeep1.Location = New System.Drawing.Point(251, 65)
        Me.btnKeep1.Name = "btnKeep1"
        Me.btnKeep1.Size = New System.Drawing.Size(40, 23)
        Me.btnKeep1.TabIndex = 111
        Me.btnKeep1.Text = "Keep"
        Me.btnKeep1.UseVisualStyleBackColor = True
        '
        'txtAppName
        '
        Me.txtAppName.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppName.Location = New System.Drawing.Point(56, 19)
        Me.txtAppName.Name = "txtAppName"
        Me.txtAppName.Size = New System.Drawing.Size(192, 20)
        Me.txtAppName.TabIndex = 0
        '
        'txtAppAddress
        '
        Me.txtAppAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppAddress.Location = New System.Drawing.Point(56, 38)
        Me.txtAppAddress.Multiline = True
        Me.txtAppAddress.Name = "txtAppAddress"
        Me.txtAppAddress.Size = New System.Drawing.Size(192, 36)
        Me.txtAppAddress.TabIndex = 1
        '
        'txtAppTown
        '
        Me.txtAppTown.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppTown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppTown.Location = New System.Drawing.Point(56, 73)
        Me.txtAppTown.Name = "txtAppTown"
        Me.txtAppTown.Size = New System.Drawing.Size(154, 20)
        Me.txtAppTown.TabIndex = 2
        '
        'txtAppPhone
        '
        Me.txtAppPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppPhone.Location = New System.Drawing.Point(56, 94)
        Me.txtAppPhone.Name = "txtAppPhone"
        Me.txtAppPhone.Size = New System.Drawing.Size(192, 20)
        Me.txtAppPhone.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Phone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Town:"
        '
        'txtAppPcode
        '
        Me.txtAppPcode.BackColor = System.Drawing.SystemColors.Window
        Me.txtAppPcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppPcode.Location = New System.Drawing.Point(209, 73)
        Me.txtAppPcode.Name = "txtAppPcode"
        Me.txtAppPcode.Size = New System.Drawing.Size(39, 20)
        Me.txtAppPcode.TabIndex = 3
        '
        'txtCCno
        '
        Me.txtCCno.BackColor = System.Drawing.SystemColors.Info
        Me.txtCCno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCCno.Location = New System.Drawing.Point(340, 13)
        Me.txtCCno.Name = "txtCCno"
        Me.txtCCno.ReadOnly = True
        Me.txtCCno.Size = New System.Drawing.Size(64, 20)
        Me.txtCCno.TabIndex = 63
        '
        'btndtRego
        '
        Me.btndtRego.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndtRego.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndtRego.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndtRego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndtRego.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndtRego.Font = New System.Drawing.Font("Marlett", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btndtRego.Location = New System.Drawing.Point(602, 13)
        Me.btndtRego.Name = "btndtRego"
        Me.btndtRego.Size = New System.Drawing.Size(20, 20)
        Me.btndtRego.TabIndex = 0
        Me.btndtRego.Text = "u"
        Me.btndtRego.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndtRego.UseVisualStyleBackColor = False
        '
        'dtRego
        '
        Me.dtRego.BackColor = System.Drawing.SystemColors.Info
        Me.dtRego.Location = New System.Drawing.Point(534, 13)
        Me.dtRego.Name = "dtRego"
        Me.dtRego.ReadOnly = True
        Me.dtRego.Size = New System.Drawing.Size(65, 20)
        Me.dtRego.TabIndex = 60
        Me.dtRego.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(417, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Commencement Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "DA No.:"
        '
        'txtDANo
        '
        Me.txtDANo.BackColor = System.Drawing.SystemColors.Info
        Me.txtDANo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDANo.Location = New System.Drawing.Point(128, 43)
        Me.txtDANo.Name = "txtDANo"
        Me.txtDANo.ReadOnly = True
        Me.txtDANo.Size = New System.Drawing.Size(64, 20)
        Me.txtDANo.TabIndex = 57
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(473, 237)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(151, 41)
        Me.btnCreate.TabIndex = 77
        Me.btnCreate.Text = "Create record"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'cboCertifier
        '
        Me.cboCertifier.FormattingEnabled = True
        Me.cboCertifier.Items.AddRange(New Object() {"Council", "Private"})
        Me.cboCertifier.Location = New System.Drawing.Point(128, 12)
        Me.cboCertifier.Name = "cboCertifier"
        Me.cboCertifier.Size = New System.Drawing.Size(121, 21)
        Me.cboCertifier.TabIndex = 113
        '
        'AddNewCompliance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 289)
        Me.Controls.Add(Me.cboCertifier)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtCCno)
        Me.Controls.Add(CCAppNoLabel)
        Me.Controls.Add(Me.btndtRego)
        Me.Controls.Add(Me.dtRego)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDANo)
        Me.Controls.Add(Me.grpPrinCert)
        Me.Controls.Add(Me.grpApplicant)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddNewCompliance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add New Compliance"
        Me.grpPrinCert.ResumeLayout(False)
        Me.grpPrinCert.PerformLayout()
        Me.grpApplicant.ResumeLayout(False)
        Me.grpApplicant.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPrinCert As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLicenceNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCoPCAPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCoPCAPcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCoPCATown As System.Windows.Forms.TextBox
    Friend WithEvents txtCoPCAaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboBuildersNames As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grpApplicant As System.Windows.Forms.GroupBox
    Friend WithEvents txtAppName As System.Windows.Forms.TextBox
    Friend WithEvents txtAppAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtAppTown As System.Windows.Forms.TextBox
    Friend WithEvents txtAppPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAppPcode As System.Windows.Forms.TextBox
    Friend WithEvents txtCCno As System.Windows.Forms.TextBox
    Friend WithEvents btndtRego As System.Windows.Forms.Button
    Friend WithEvents dtRego As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDANo As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnUse2 As System.Windows.Forms.Button
    Friend WithEvents btnKeep1 As System.Windows.Forms.Button
    Friend WithEvents cboCertifier As System.Windows.Forms.ComboBox
End Class
