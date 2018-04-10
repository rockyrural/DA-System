<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeReconciliationToNavision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeeReconciliationToNavision))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkGST = New System.Windows.Forms.CheckBox()
        Me.LoadUpPaymentComboBoxBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CZONES = New LookupDevelopmentApplication.CZONES()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNavision = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSpreadSheet = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LoadUpPaymentComboBoxTableAdapter = New LookupDevelopmentApplication.CZONESTableAdapters.LoadUpPaymentComboBoxTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCreateLSLreturnHardCopy = New System.Windows.Forms.Button()
        Me.btnCreateLSLreturnElectronic = New System.Windows.Forms.Button()
        Me.btnPlanningNSW = New System.Windows.Forms.Button()
        Me.cboLoadUpPayment = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpFromDate = New DevExpress.XtraEditors.DateEdit()
        Me.dtpToDate = New DevExpress.XtraEditors.DateEdit()
        Me.Panel1.SuspendLayout()
        CType(Me.LoadUpPaymentComboBoxBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.cboLoadUpPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFromDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpToDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dtpToDate)
        Me.Panel1.Controls.Add(Me.dtpFromDate)
        Me.Panel1.Controls.Add(Me.cboLoadUpPayment)
        Me.Panel1.Controls.Add(Me.chkGST)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 57)
        Me.Panel1.TabIndex = 0
        '
        'chkGST
        '
        Me.chkGST.AutoSize = True
        Me.chkGST.Location = New System.Drawing.Point(554, 25)
        Me.chkGST.Name = "chkGST"
        Me.chkGST.Size = New System.Drawing.Size(54, 17)
        Me.chkGST.TabIndex = 4
        Me.chkGST.Text = "GST?"
        Me.chkGST.UseVisualStyleBackColor = True
        '
        'LoadUpPaymentComboBoxBindingSource
        '
        Me.LoadUpPaymentComboBoxBindingSource.DataMember = "LoadUpPaymentComboBox"
        Me.LoadUpPaymentComboBoxBindingSource.DataSource = Me.CZONES
        '
        'CZONES
        '
        Me.CZONES.DataSetName = "CZONES"
        Me.CZONES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(411, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DA SYSTEM:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnNavision)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 79)
        Me.Panel2.TabIndex = 1
        '
        'btnNavision
        '
        Me.btnNavision.Enabled = False
        Me.btnNavision.Location = New System.Drawing.Point(388, 15)
        Me.btnNavision.Name = "btnNavision"
        Me.btnNavision.Size = New System.Drawing.Size(113, 41)
        Me.btnNavision.TabIndex = 2
        Me.btnNavision.Text = "Launch NAVISION"
        Me.btnNavision.UseVisualStyleBackColor = True
        Me.btnNavision.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 41)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Go to Navision and run the job which creates the transaction extract from the fin" &
    "ance system."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Step 1:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.btnSpreadSheet)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(634, 91)
        Me.Panel3.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(385, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 28)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Note:you can run this report as many times as required."
        '
        'btnSpreadSheet
        '
        Me.btnSpreadSheet.Location = New System.Drawing.Point(388, 7)
        Me.btnSpreadSheet.Name = "btnSpreadSheet"
        Me.btnSpreadSheet.Size = New System.Drawing.Size(136, 32)
        Me.btnSpreadSheet.TabIndex = 3
        Me.btnSpreadSheet.Text = "Create Reconc S/Sheet"
        Me.btnSpreadSheet.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Step 2:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(74, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(287, 75)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Check: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-  the dates above are correct, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-  the GST flag is correct for this fe" &
    "e type , " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "then produce the reconciliation spreadsheet:-"
        '
        'LoadUpPaymentComboBoxTableAdapter
        '
        Me.LoadUpPaymentComboBoxTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Returns"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(75, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(533, 86)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'btnCreateLSLreturnHardCopy
        '
        Me.btnCreateLSLreturnHardCopy.Location = New System.Drawing.Point(75, 323)
        Me.btnCreateLSLreturnHardCopy.Name = "btnCreateLSLreturnHardCopy"
        Me.btnCreateLSLreturnHardCopy.Size = New System.Drawing.Size(192, 26)
        Me.btnCreateLSLreturnHardCopy.TabIndex = 4
        Me.btnCreateLSLreturnHardCopy.Text = " Create LSL Return - Hardcopy"
        Me.btnCreateLSLreturnHardCopy.UseVisualStyleBackColor = True
        '
        'btnCreateLSLreturnElectronic
        '
        Me.btnCreateLSLreturnElectronic.Location = New System.Drawing.Point(75, 355)
        Me.btnCreateLSLreturnElectronic.Name = "btnCreateLSLreturnElectronic"
        Me.btnCreateLSLreturnElectronic.Size = New System.Drawing.Size(192, 26)
        Me.btnCreateLSLreturnElectronic.TabIndex = 5
        Me.btnCreateLSLreturnElectronic.Text = "Create LSL Return - Electronic"
        Me.btnCreateLSLreturnElectronic.UseVisualStyleBackColor = True
        '
        'btnPlanningNSW
        '
        Me.btnPlanningNSW.Location = New System.Drawing.Point(284, 323)
        Me.btnPlanningNSW.Name = "btnPlanningNSW"
        Me.btnPlanningNSW.Size = New System.Drawing.Size(192, 26)
        Me.btnPlanningNSW.TabIndex = 6
        Me.btnPlanningNSW.Text = " Create PlanningNSW Return"
        Me.btnPlanningNSW.UseVisualStyleBackColor = True
        '
        'cboLoadUpPayment
        '
        Me.cboLoadUpPayment.Location = New System.Drawing.Point(87, 22)
        Me.cboLoadUpPayment.Name = "cboLoadUpPayment"
        Me.cboLoadUpPayment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLoadUpPayment.Properties.DataSource = Me.LoadUpPaymentComboBoxBindingSource
        Me.cboLoadUpPayment.Properties.DisplayMember = "Payment"
        Me.cboLoadUpPayment.Properties.NullText = "[Select System]"
        Me.cboLoadUpPayment.Properties.ShowFooter = False
        Me.cboLoadUpPayment.Properties.ShowHeader = False
        Me.cboLoadUpPayment.Properties.ValueMember = "PaymentId"
        Me.cboLoadUpPayment.Size = New System.Drawing.Size(157, 20)
        Me.cboLoadUpPayment.TabIndex = 5
        '
        'dtpFromDate
        '
        Me.dtpFromDate.EditValue = Nothing
        Me.dtpFromDate.Location = New System.Drawing.Point(305, 22)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFromDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpFromDate.TabIndex = 6
        '
        'dtpToDate
        '
        Me.dtpToDate.EditValue = Nothing
        Me.dtpToDate.Location = New System.Drawing.Point(440, 24)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpToDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpToDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpToDate.TabIndex = 7
        '
        'FeeReconciliationToNavision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 399)
        Me.Controls.Add(Me.btnPlanningNSW)
        Me.Controls.Add(Me.btnCreateLSLreturnElectronic)
        Me.Controls.Add(Me.btnCreateLSLreturnHardCopy)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FeeReconciliationToNavision"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "LSL Return"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LoadUpPaymentComboBoxBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CZONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.cboLoadUpPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFromDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpToDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CZONES As LookupDevelopmentApplication.CZONES
    Friend WithEvents LoadUpPaymentComboBoxBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadUpPaymentComboBoxTableAdapter As LookupDevelopmentApplication.CZONESTableAdapters.LoadUpPaymentComboBoxTableAdapter
    Friend WithEvents chkGST As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNavision As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSpreadSheet As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCreateLSLreturnHardCopy As System.Windows.Forms.Button
    Friend WithEvents btnCreateLSLreturnElectronic As System.Windows.Forms.Button
    Friend WithEvents btnPlanningNSW As System.Windows.Forms.Button
    Friend WithEvents cboLoadUpPayment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFromDate As DevExpress.XtraEditors.DateEdit
End Class
