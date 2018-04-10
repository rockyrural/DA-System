<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SystemUsersMaintenance
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemUsersMaintenance))
        Me.Panel1 = New DevExpress.XtraEditors.GroupControl()
        Me.grdOfficers = New DevExpress.XtraGrid.GridControl()
        Me.gvwOfficers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOfficerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOfficer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkActiveOnly = New DevExpress.XtraEditors.CheckEdit()
        Me.rbExternal = New System.Windows.Forms.RadioButton()
        Me.rbStaff = New System.Windows.Forms.RadioButton()
        Me.txtOfficer = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.txtMobilePhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit()
        Me.txtLAN = New DevExpress.XtraEditors.TextEdit()
        Me.txtSignature = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSignature = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.chkExternal = New DevExpress.XtraEditors.CheckEdit()
        Me.chkActive = New DevExpress.XtraEditors.CheckEdit()
        Me.cd = New System.Windows.Forms.OpenFileDialog()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBPBNumber = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox2 = New DevExpress.XtraEditors.GroupControl()
        Me.chkAssessmentOfficer = New DevExpress.XtraEditors.CheckEdit()
        Me.picSignature = New System.Windows.Forms.PictureBox()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grdOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActiveOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOfficer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMobilePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLAN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSignature.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkExternal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBPBNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.chkAssessmentOfficer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdOfficers)
        Me.Panel1.Controls.Add(Me.chkActiveOnly)
        Me.Panel1.Controls.Add(Me.rbExternal)
        Me.Panel1.Controls.Add(Me.rbStaff)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 569)
        Me.Panel1.TabIndex = 0
        Me.Panel1.Text = "Development Applications Officers and Entities"
        '
        'grdOfficers
        '
        Me.grdOfficers.Location = New System.Drawing.Point(12, 50)
        Me.grdOfficers.MainView = Me.gvwOfficers
        Me.grdOfficers.Name = "grdOfficers"
        Me.grdOfficers.Size = New System.Drawing.Size(289, 507)
        Me.grdOfficers.TabIndex = 27
        Me.grdOfficers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwOfficers})
        '
        'gvwOfficers
        '
        Me.gvwOfficers.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOfficerID, Me.colOfficer, Me.colPhone})
        Me.gvwOfficers.GridControl = Me.grdOfficers
        Me.gvwOfficers.Name = "gvwOfficers"
        Me.gvwOfficers.OptionsBehavior.Editable = False
        Me.gvwOfficers.OptionsBehavior.ReadOnly = True
        Me.gvwOfficers.OptionsFind.AlwaysVisible = True
        Me.gvwOfficers.OptionsView.ShowGroupPanel = False
        '
        'colOfficerID
        '
        Me.colOfficerID.Caption = "id"
        Me.colOfficerID.FieldName = "OfficerID"
        Me.colOfficerID.Name = "colOfficerID"
        '
        'colOfficer
        '
        Me.colOfficer.Caption = "Officer"
        Me.colOfficer.FieldName = "Officer"
        Me.colOfficer.Name = "colOfficer"
        Me.colOfficer.Visible = True
        Me.colOfficer.VisibleIndex = 0
        '
        'colPhone
        '
        Me.colPhone.Caption = "Phone"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.Name = "colPhone"
        '
        'chkActiveOnly
        '
        Me.chkActiveOnly.EditValue = True
        Me.chkActiveOnly.Location = New System.Drawing.Point(175, 27)
        Me.chkActiveOnly.Name = "chkActiveOnly"
        Me.chkActiveOnly.Properties.Caption = "Active only?"
        Me.chkActiveOnly.Size = New System.Drawing.Size(84, 19)
        Me.chkActiveOnly.TabIndex = 25
        '
        'rbExternal
        '
        Me.rbExternal.AutoSize = True
        Me.rbExternal.Location = New System.Drawing.Point(104, 26)
        Me.rbExternal.Name = "rbExternal"
        Me.rbExternal.Size = New System.Drawing.Size(65, 17)
        Me.rbExternal.TabIndex = 2
        Me.rbExternal.Text = "External"
        Me.rbExternal.UseVisualStyleBackColor = True
        '
        'rbStaff
        '
        Me.rbStaff.AutoSize = True
        Me.rbStaff.Checked = True
        Me.rbStaff.Location = New System.Drawing.Point(12, 26)
        Me.rbStaff.Name = "rbStaff"
        Me.rbStaff.Size = New System.Drawing.Size(86, 17)
        Me.rbStaff.TabIndex = 2
        Me.rbStaff.TabStop = True
        Me.rbStaff.Text = "Council Staff"
        Me.rbStaff.UseVisualStyleBackColor = True
        '
        'txtOfficer
        '
        Me.txtOfficer.Location = New System.Drawing.Point(25, 47)
        Me.txtOfficer.Name = "txtOfficer"
        Me.txtOfficer.Properties.ReadOnly = True
        Me.txtOfficer.Size = New System.Drawing.Size(256, 20)
        Me.txtOfficer.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(284, 48)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Properties.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(22, 182)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(362, 20)
        Me.txtEmail.TabIndex = 5
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.Location = New System.Drawing.Point(284, 95)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Properties.ReadOnly = True
        Me.txtMobilePhone.Size = New System.Drawing.Size(100, 20)
        Me.txtMobilePhone.TabIndex = 4
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(22, 95)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Properties.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(256, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtLAN
        '
        Me.txtLAN.Location = New System.Drawing.Point(22, 237)
        Me.txtLAN.Name = "txtLAN"
        Me.txtLAN.Properties.ReadOnly = True
        Me.txtLAN.Size = New System.Drawing.Size(100, 20)
        Me.txtLAN.TabIndex = 6
        '
        'txtSignature
        '
        Me.txtSignature.Location = New System.Drawing.Point(22, 288)
        Me.txtSignature.Name = "txtSignature"
        Me.txtSignature.Properties.ReadOnly = True
        Me.txtSignature.Size = New System.Drawing.Size(325, 20)
        Me.txtSignature.TabIndex = 9
        Me.txtSignature.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Officer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Mobile Phone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Title (Official Council Title Not Mr):"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "LAN UserID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Signature Path:"
        '
        'btnSignature
        '
        Me.btnSignature.Enabled = False
        Me.btnSignature.Image = CType(resources.GetObject("btnSignature.Image"), System.Drawing.Image)
        Me.btnSignature.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSignature.Location = New System.Drawing.Point(353, 286)
        Me.btnSignature.Name = "btnSignature"
        Me.btnSignature.Size = New System.Drawing.Size(31, 23)
        Me.btnSignature.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(105, 495)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(91, 40)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Location = New System.Drawing.Point(203, 495)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 40)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(309, 495)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 40)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        '
        'chkExternal
        '
        Me.chkExternal.Location = New System.Drawing.Point(153, 208)
        Me.chkExternal.Name = "chkExternal"
        Me.chkExternal.Properties.Caption = "External?"
        Me.chkExternal.Size = New System.Drawing.Size(71, 19)
        Me.chkExternal.TabIndex = 7
        '
        'chkActive
        '
        Me.chkActive.Location = New System.Drawing.Point(153, 231)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Properties.Caption = "Not Active?"
        Me.chkActive.Size = New System.Drawing.Size(81, 19)
        Me.chkActive.TabIndex = 8
        '
        'cd
        '
        Me.cd.FileName = "OpenFileDialog1"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(386, 2)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Building Professional Number"
        '
        'txtBPBNumber
        '
        Me.txtBPBNumber.Location = New System.Drawing.Point(22, 139)
        Me.txtBPBNumber.Name = "txtBPBNumber"
        Me.txtBPBNumber.Properties.ReadOnly = True
        Me.txtBPBNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtBPBNumber.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAssessmentOfficer)
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.txtBPBNumber)
        Me.GroupBox2.Controls.Add(Me.lblID)
        Me.GroupBox2.Controls.Add(Me.chkActive)
        Me.GroupBox2.Controls.Add(Me.chkExternal)
        Me.GroupBox2.Controls.Add(Me.btnSignature)
        Me.GroupBox2.Controls.Add(Me.picSignature)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSignature)
        Me.GroupBox2.Controls.Add(Me.txtLAN)
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.txtMobilePhone)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtPhone)
        Me.GroupBox2.Controls.Add(Me.txtOfficer)
        Me.GroupBox2.Location = New System.Drawing.Point(331, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 552)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.Text = "DA System User Information"
        '
        'chkAssessmentOfficer
        '
        Me.chkAssessmentOfficer.Location = New System.Drawing.Point(256, 231)
        Me.chkAssessmentOfficer.Name = "chkAssessmentOfficer"
        Me.chkAssessmentOfficer.Properties.Caption = "Assessment Officer"
        Me.chkAssessmentOfficer.Size = New System.Drawing.Size(119, 19)
        Me.chkAssessmentOfficer.TabIndex = 25
        '
        'picSignature
        '
        Me.picSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSignature.Location = New System.Drawing.Point(22, 323)
        Me.picSignature.Name = "picSignature"
        Me.picSignature.Size = New System.Drawing.Size(245, 132)
        Me.picSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSignature.TabIndex = 15
        Me.picSignature.TabStop = False
        '
        'SystemUsersMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 569)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SystemUsersMaintenance"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Users Maintenance"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.grdOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwOfficers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActiveOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOfficer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMobilePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLAN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSignature.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkExternal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBPBNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.chkAssessmentOfficer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSignature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rbExternal As System.Windows.Forms.RadioButton
    Friend WithEvents rbStaff As System.Windows.Forms.RadioButton
    Friend WithEvents txtOfficer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMobilePhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLAN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSignature As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents picSignature As System.Windows.Forms.PictureBox
    Friend WithEvents btnSignature As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkExternal As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkActive As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBPBNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkActiveOnly As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAssessmentOfficer As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grdOfficers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwOfficers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOfficerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOfficer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
End Class
