<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DCPCheckList4
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
        Me.components = New System.ComponentModel.Container
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.DevelopmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SetbackFSTextBox = New System.Windows.Forms.TextBox
        Me.SetbackRTextBox = New System.Windows.Forms.TextBox
        Me.SetbackSTextBox = New System.Windows.Forms.TextBox
        Me.SetbackSSTextBox = New System.Windows.Forms.TextBox
        Me.SetbackFTextBox = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cboSetBkFS = New System.Windows.Forms.ComboBox
        Me.cboSetBkR = New System.Windows.Forms.ComboBox
        Me.cboSetBkS = New System.Windows.Forms.ComboBox
        Me.cbosetbkSS = New System.Windows.Forms.ComboBox
        Me.cboSetBkFront = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.MaxHeightTextBox = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboMaxHeight = New System.Windows.Forms.ComboBox
        Me.cboNatHERSComply = New System.Windows.Forms.ComboBox
        Me.NatHERS_RatingTextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlDCPCheck1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DevelopmentDataTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.DevelopmentDataTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DevelopmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlDCPCheck1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Setbacks"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "House Energy Rating"
        '
        'DevelopmentDataBindingSource
        '
        Me.DevelopmentDataBindingSource.DataMember = "DevelopmentData"
        Me.DevelopmentDataBindingSource.DataSource = Me.DAdatasets
        '
        'DAdatasets
        '
        Me.DAdatasets.DataSetName = "DAdatasets"
        Me.DAdatasets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Control"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.SetbackFSTextBox)
        Me.Panel2.Controls.Add(Me.SetbackRTextBox)
        Me.Panel2.Controls.Add(Me.SetbackSTextBox)
        Me.Panel2.Controls.Add(Me.SetbackSSTextBox)
        Me.Panel2.Controls.Add(Me.SetbackFTextBox)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.cboSetBkFS)
        Me.Panel2.Controls.Add(Me.cboSetBkR)
        Me.Panel2.Controls.Add(Me.cboSetBkS)
        Me.Panel2.Controls.Add(Me.cbosetbkSS)
        Me.Panel2.Controls.Add(Me.cboSetBkFront)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(11, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(862, 160)
        Me.Panel2.TabIndex = 1
        '
        'SetbackFSTextBox
        '
        Me.SetbackFSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackFS", True))
        Me.SetbackFSTextBox.Location = New System.Drawing.Point(443, 119)
        Me.SetbackFSTextBox.Name = "SetbackFSTextBox"
        Me.SetbackFSTextBox.Size = New System.Drawing.Size(403, 20)
        Me.SetbackFSTextBox.TabIndex = 9
        '
        'SetbackRTextBox
        '
        Me.SetbackRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackR", True))
        Me.SetbackRTextBox.Location = New System.Drawing.Point(443, 92)
        Me.SetbackRTextBox.Name = "SetbackRTextBox"
        Me.SetbackRTextBox.Size = New System.Drawing.Size(403, 20)
        Me.SetbackRTextBox.TabIndex = 7
        '
        'SetbackSTextBox
        '
        Me.SetbackSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackS", True))
        Me.SetbackSTextBox.Location = New System.Drawing.Point(443, 66)
        Me.SetbackSTextBox.Name = "SetbackSTextBox"
        Me.SetbackSTextBox.Size = New System.Drawing.Size(403, 20)
        Me.SetbackSTextBox.TabIndex = 5
        '
        'SetbackSSTextBox
        '
        Me.SetbackSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackSS", True))
        Me.SetbackSSTextBox.Location = New System.Drawing.Point(443, 40)
        Me.SetbackSSTextBox.Name = "SetbackSSTextBox"
        Me.SetbackSSTextBox.Size = New System.Drawing.Size(403, 20)
        Me.SetbackSSTextBox.TabIndex = 3
        '
        'SetbackFTextBox
        '
        Me.SetbackFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackF", True))
        Me.SetbackFTextBox.Location = New System.Drawing.Point(443, 13)
        Me.SetbackFTextBox.Name = "SetbackFTextBox"
        Me.SetbackFTextBox.Size = New System.Drawing.Size(403, 20)
        Me.SetbackFTextBox.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(174, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Foreshore - 12.0 m"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(174, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Rear - 12.0 m"
        '
        'cboSetBkFS
        '
        Me.cboSetBkFS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSetBkFS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSetBkFS.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "SetbackFSComply", True))
        Me.cboSetBkFS.FormattingEnabled = True
        Me.cboSetBkFS.Location = New System.Drawing.Point(295, 119)
        Me.cboSetBkFS.Name = "cboSetBkFS"
        Me.cboSetBkFS.Size = New System.Drawing.Size(117, 21)
        Me.cboSetBkFS.TabIndex = 8
        '
        'cboSetBkR
        '
        Me.cboSetBkR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSetBkR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSetBkR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "SetbackRComply", True))
        Me.cboSetBkR.FormattingEnabled = True
        Me.cboSetBkR.Location = New System.Drawing.Point(295, 92)
        Me.cboSetBkR.Name = "cboSetBkR"
        Me.cboSetBkR.Size = New System.Drawing.Size(117, 21)
        Me.cboSetBkR.TabIndex = 6
        '
        'cboSetBkS
        '
        Me.cboSetBkS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSetBkS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSetBkS.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "SetbackSCOmply", True))
        Me.cboSetBkS.FormattingEnabled = True
        Me.cboSetBkS.Location = New System.Drawing.Point(295, 66)
        Me.cboSetBkS.Name = "cboSetBkS"
        Me.cboSetBkS.Size = New System.Drawing.Size(117, 21)
        Me.cboSetBkS.TabIndex = 4
        '
        'cbosetbkSS
        '
        Me.cbosetbkSS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbosetbkSS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbosetbkSS.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DevelopmentDataBindingSource, "SetbackSSComply", True))
        Me.cbosetbkSS.FormattingEnabled = True
        Me.cbosetbkSS.Location = New System.Drawing.Point(295, 40)
        Me.cbosetbkSS.Name = "cbosetbkSS"
        Me.cbosetbkSS.Size = New System.Drawing.Size(117, 21)
        Me.cbosetbkSS.TabIndex = 2
        '
        'cboSetBkFront
        '
        Me.cboSetBkFront.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSetBkFront.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSetBkFront.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DevelopmentDataBindingSource, "SetbackFComply", True))
        Me.cboSetBkFront.FormattingEnabled = True
        Me.cboSetBkFront.Location = New System.Drawing.Point(295, 13)
        Me.cboSetBkFront.Name = "cboSetBkFront"
        Me.cboSetBkFront.Size = New System.Drawing.Size(117, 21)
        Me.cboSetBkFront.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(176, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Side - 12.0 m"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(174, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Side-Street - 3.0 m"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(66, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 26)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Front -(sloping  from sealed road) 10m"
        '
        'MaxHeightTextBox
        '
        Me.MaxHeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "MaxHeight", True))
        Me.MaxHeightTextBox.Location = New System.Drawing.Point(443, 74)
        Me.MaxHeightTextBox.Name = "MaxHeightTextBox"
        Me.MaxHeightTextBox.Size = New System.Drawing.Size(403, 20)
        Me.MaxHeightTextBox.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.MaxHeightTextBox)
        Me.Panel1.Controls.Add(Me.cboMaxHeight)
        Me.Panel1.Controls.Add(Me.cboNatHERSComply)
        Me.Panel1.Controls.Add(Me.NatHERS_RatingTextBox)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(11, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 108)
        Me.Panel1.TabIndex = 1
        '
        'cboMaxHeight
        '
        Me.cboMaxHeight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMaxHeight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaxHeight.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "MaxHeightComply", True))
        Me.cboMaxHeight.FormattingEnabled = True
        Me.cboMaxHeight.Location = New System.Drawing.Point(295, 74)
        Me.cboMaxHeight.Name = "cboMaxHeight"
        Me.cboMaxHeight.Size = New System.Drawing.Size(117, 21)
        Me.cboMaxHeight.TabIndex = 2
        '
        'cboNatHERSComply
        '
        Me.cboNatHERSComply.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNatHERSComply.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNatHERSComply.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "NatHERSComply", True))
        Me.cboNatHERSComply.FormattingEnabled = True
        Me.cboNatHERSComply.Location = New System.Drawing.Point(295, 9)
        Me.cboNatHERSComply.Name = "cboNatHERSComply"
        Me.cboNatHERSComply.Size = New System.Drawing.Size(117, 21)
        Me.cboNatHERSComply.TabIndex = 0
        '
        'NatHERS_RatingTextBox
        '
        Me.NatHERS_RatingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "NatHERS_Rating", True))
        Me.NatHERS_RatingTextBox.Location = New System.Drawing.Point(443, 10)
        Me.NatHERS_RatingTextBox.Name = "NatHERS_RatingTextBox"
        Me.NatHERS_RatingTextBox.Size = New System.Drawing.Size(403, 20)
        Me.NatHERS_RatingTextBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Max Build Height"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(174, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "8.5 m"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(174, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "BASIX Compliance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "House Energy Rating"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(490, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DWELLING HOUSES -RURAL ZONES Prescriptive Standard Checklist"
        '
        'pnlDCPCheck1
        '
        Me.pnlDCPCheck1.Controls.Add(Me.Label6)
        Me.pnlDCPCheck1.Controls.Add(Me.Label5)
        Me.pnlDCPCheck1.Controls.Add(Me.Label4)
        Me.pnlDCPCheck1.Controls.Add(Me.Label3)
        Me.pnlDCPCheck1.Controls.Add(Me.Label2)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel2)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel1)
        Me.pnlDCPCheck1.Location = New System.Drawing.Point(12, 12)
        Me.pnlDCPCheck1.Name = "pnlDCPCheck1"
        Me.pnlDCPCheck1.Size = New System.Drawing.Size(876, 331)
        Me.pnlDCPCheck1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(295, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Comply?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(443, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Standard"
        '
        'DevelopmentDataTableAdapter
        '
        Me.DevelopmentDataTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(174, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Front -(sloping to sealed road) 15m+"
        '
        'DCPCheckList4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 348)
        Me.Controls.Add(Me.pnlDCPCheck1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DCPCheckList4"
        Me.Text = "DWELLING HOUSES -RURAL ZONES Prescriptive Standard Checklist"
        CType(Me.DevelopmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlDCPCheck1.ResumeLayout(False)
        Me.pnlDCPCheck1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DevelopmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAdatasets As LookupDevelopmentApplication.DAdatasets
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SetbackFSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetbackRTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetbackSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetbackSSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetbackFTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboSetBkFS As System.Windows.Forms.ComboBox
    Friend WithEvents cboSetBkR As System.Windows.Forms.ComboBox
    Friend WithEvents cboSetBkS As System.Windows.Forms.ComboBox
    Friend WithEvents cbosetbkSS As System.Windows.Forms.ComboBox
    Friend WithEvents cboSetBkFront As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MaxHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboMaxHeight As System.Windows.Forms.ComboBox
    Friend WithEvents cboNatHERSComply As System.Windows.Forms.ComboBox
    Friend WithEvents NatHERS_RatingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlDCPCheck1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DevelopmentDataTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.DevelopmentDataTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
