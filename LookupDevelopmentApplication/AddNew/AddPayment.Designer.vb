<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPayment))
        Me.cboPayment = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRecptNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAmount = New DevExpress.XtraEditors.TextEdit()
        Me.txtPaidInspections = New DevExpress.XtraEditors.TextEdit()
        Me.chkTrackInCompliance = New DevExpress.XtraEditors.CheckEdit()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.dtRego = New DevExpress.XtraEditors.DateEdit()
        Me.txtNotes = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.cboPayment.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRecptNo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAmount.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPaidInspections.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.chkTrackInCompliance.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dtRego.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dtRego.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNotes.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cboPayment
        '
        Me.cboPayment.Location = New System.Drawing.Point(12, 23)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPayment.Properties.NullText = "[Select fee type]"
        Me.cboPayment.Size = New System.Drawing.Size(286, 20)
        Me.cboPayment.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Payment Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(318, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(441, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Receipt Date:"
        '
        'txtRecptNo
        '
        Me.txtRecptNo.Location = New System.Drawing.Point(441, 69)
        Me.txtRecptNo.Name = "txtRecptNo"
        Me.txtRecptNo.Size = New System.Drawing.Size(95, 20)
        Me.txtRecptNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(441, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Receipt No."
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(12, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Notes"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(318, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Paid Inspections"
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"),System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(564, 55)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 34)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(321, 23)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAmount.Properties.DisplayFormat.FormatString = "c"
        Me.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.EditFormat.FormatString = "c"
        Me.txtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAmount.Properties.Mask.EditMask = "c"
        Me.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 33
        '
        'txtPaidInspections
        '
        Me.txtPaidInspections.Location = New System.Drawing.Point(321, 69)
        Me.txtPaidInspections.Name = "txtPaidInspections"
        Me.txtPaidInspections.Size = New System.Drawing.Size(48, 20)
        Me.txtPaidInspections.TabIndex = 34
        '
        'chkTrackInCompliance
        '
        Me.chkTrackInCompliance.Location = New System.Drawing.Point(321, 95)
        Me.chkTrackInCompliance.Name = "chkTrackInCompliance"
        Me.chkTrackInCompliance.Properties.Caption = "Track in Compliance"
        Me.chkTrackInCompliance.Size = New System.Drawing.Size(120, 19)
        Me.chkTrackInCompliance.TabIndex = 35
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ImageOptions.Image = CType(resources.GetObject("btnCancel.ImageOptions.Image"),System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(564, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 34)
        Me.btnCancel.TabIndex = 36
        Me.btnCancel.Text = "Cancel"
        '
        'dtRego
        '
        Me.dtRego.EditValue = Nothing
        Me.dtRego.Location = New System.Drawing.Point(441, 23)
        Me.dtRego.Name = "dtRego"
        Me.dtRego.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRego.Size = New System.Drawing.Size(100, 20)
        Me.dtRego.TabIndex = 37
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(13, 64)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(285, 45)
        Me.txtNotes.TabIndex = 4
        '
        'AddPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(663, 117)
        Me.ControlBox = false
        Me.Controls.Add(Me.dtRego)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chkTrackInCompliance)
        Me.Controls.Add(Me.txtPaidInspections)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtRecptNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPayment)
        Me.Controls.Add(Me.txtNotes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddPayment"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Payment"
        CType(Me.cboPayment.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRecptNo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAmount.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPaidInspections.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkTrackInCompliance.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dtRego.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dtRego.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNotes.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cboPayment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRecptNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPaidInspections As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkTrackInCompliance As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtRego As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNotes As DevExpress.XtraEditors.MemoEdit
End Class
