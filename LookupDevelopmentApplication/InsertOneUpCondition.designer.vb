<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertOneUpCondition
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
        Me.cboOneUpConditions = New System.Windows.Forms.ComboBox()
        Me.ConditionCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets()
        Me.ConditionCodeTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.ConditionCodeTableAdapter()
        Me.txtConditionText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInsert = New System.Windows.Forms.Button()
        CType(Me.ConditionCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboOneUpConditions
        '
        Me.cboOneUpConditions.DataSource = Me.ConditionCodeBindingSource
        Me.cboOneUpConditions.DisplayMember = "ConditionDesc"
        Me.cboOneUpConditions.DropDownWidth = 300
        Me.cboOneUpConditions.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOneUpConditions.FormattingEnabled = True
        Me.cboOneUpConditions.Location = New System.Drawing.Point(12, 24)
        Me.cboOneUpConditions.Name = "cboOneUpConditions"
        Me.cboOneUpConditions.Size = New System.Drawing.Size(292, 19)
        Me.cboOneUpConditions.TabIndex = 19
        Me.cboOneUpConditions.ValueMember = "Id"
        '
        'ConditionCodeBindingSource
        '
        Me.ConditionCodeBindingSource.DataMember = "ConditionCode"
        Me.ConditionCodeBindingSource.DataSource = Me.DAdatasets
        '
        'DAdatasets
        '
        Me.DAdatasets.DataSetName = "DAdatasets"
        Me.DAdatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConditionCodeTableAdapter
        '
        Me.ConditionCodeTableAdapter.ClearBeforeFill = True
        '
        'txtConditionText
        '
        Me.txtConditionText.Location = New System.Drawing.Point(12, 64)
        Me.txtConditionText.Multiline = True
        Me.txtConditionText.Name = "txtConditionText"
        Me.txtConditionText.Size = New System.Drawing.Size(734, 285)
        Me.txtConditionText.TabIndex = 20
        Me.txtConditionText.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(#)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Select Condition Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Type in the condition (check your spelling)"
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(629, 355)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(117, 36)
        Me.btnInsert.TabIndex = 23
        Me.btnInsert.Text = "Insert Condition"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'InsertOneUpCondition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 403)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConditionText)
        Me.Controls.Add(Me.cboOneUpConditions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InsertOneUpCondition"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insert One Up Condition"
        CType(Me.ConditionCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboOneUpConditions As System.Windows.Forms.ComboBox
    Friend WithEvents DAdatasets As LookupDevelopmentApplication.DAdatasets
    Friend WithEvents ConditionCodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConditionCodeTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.ConditionCodeTableAdapter
    Friend WithEvents txtConditionText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
End Class
