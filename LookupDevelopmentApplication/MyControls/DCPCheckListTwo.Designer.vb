<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DCPCheckListTwo
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DCPCheckListTwo))
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton()
        Me.DevelopmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets()
        Me.DevelopmentDataTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.DevelopmentDataTableAdapter()
        Me.cboOSParkPRox = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SetbackFSTextBox = New System.Windows.Forms.TextBox()
        Me.SetbackRTextBox = New System.Windows.Forms.TextBox()
        Me.SetbackSTextBox = New System.Windows.Forms.TextBox()
        Me.SetbackSSTextBox = New System.Windows.Forms.TextBox()
        Me.ExtendedComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ExtendedComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SetbackFTextBox = New System.Windows.Forms.TextBox()
        Me.ExtendedComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboSetBkFS = New System.Windows.Forms.ComboBox()
        Me.cboSetBkR = New System.Windows.Forms.ComboBox()
        Me.cboSetBkS = New System.Windows.Forms.ComboBox()
        Me.cbosetbkSS = New System.Windows.Forms.ComboBox()
        Me.cboSetBkFront = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DAFloorTextBox = New System.Windows.Forms.TextBox()
        Me.MaxHeightTextBox = New System.Windows.Forms.TextBox()
        Me.cboMaxHeight = New System.Windows.Forms.ComboBox()
        Me.cboFSR = New System.Windows.Forms.ComboBox()
        Me.cboNatHERSComply = New System.Windows.Forms.ComboBox()
        Me.NatHERS_RatingTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.OpenSpaceTextBox = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboOpenSpace = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlDCPCheck1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.OSParkEntryTextBox = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.OSParkProxTextBox = New System.Windows.Forms.TextBox()
        Me.OSParkSpaceTextBox = New System.Windows.Forms.TextBox()
        Me.cboOSParkEntry = New System.Windows.Forms.ComboBox()
        Me.cboOSParkSpace = New System.Windows.Forms.ComboBox()
        CType(Me.DevelopmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlDCPCheck1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.Location = New System.Drawing.Point(775, 447)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(107, 34)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
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
        'DevelopmentDataTableAdapter
        '
        Me.DevelopmentDataTableAdapter.ClearBeforeFill = True
        '
        'cboOSParkPRox
        '
        Me.cboOSParkPRox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOSParkPRox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOSParkPRox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OSParkPRoxComply", True))
        Me.cboOSParkPRox.FormattingEnabled = True
        Me.cboOSParkPRox.Location = New System.Drawing.Point(334, 57)
        Me.cboOSParkPRox.Name = "cboOSParkPRox"
        Me.cboOSParkPRox.Size = New System.Drawing.Size(117, 21)
        Me.cboOSParkPRox.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(174, 88)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(124, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "# of Entry/Exit points: 1"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.SetbackFSTextBox)
        Me.Panel2.Controls.Add(Me.SetbackRTextBox)
        Me.Panel2.Controls.Add(Me.SetbackSTextBox)
        Me.Panel2.Controls.Add(Me.SetbackSSTextBox)
        Me.Panel2.Controls.Add(Me.ExtendedComboBox3)
        Me.Panel2.Controls.Add(Me.ExtendedComboBox2)
        Me.Panel2.Controls.Add(Me.SetbackFTextBox)
        Me.Panel2.Controls.Add(Me.ExtendedComboBox1)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.cboSetBkFS)
        Me.Panel2.Controls.Add(Me.cboSetBkR)
        Me.Panel2.Controls.Add(Me.cboSetBkS)
        Me.Panel2.Controls.Add(Me.cbosetbkSS)
        Me.Panel2.Controls.Add(Me.cboSetBkFront)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(11, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 160)
        Me.Panel2.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Setbacks"
        '
        'SetbackFSTextBox
        '
        Me.SetbackFSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackFS", True))
        Me.SetbackFSTextBox.Location = New System.Drawing.Point(457, 119)
        Me.SetbackFSTextBox.Name = "SetbackFSTextBox"
        Me.SetbackFSTextBox.Size = New System.Drawing.Size(289, 21)
        Me.SetbackFSTextBox.TabIndex = 9
        '
        'SetbackRTextBox
        '
        Me.SetbackRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackR", True))
        Me.SetbackRTextBox.Location = New System.Drawing.Point(457, 90)
        Me.SetbackRTextBox.Name = "SetbackRTextBox"
        Me.SetbackRTextBox.Size = New System.Drawing.Size(289, 21)
        Me.SetbackRTextBox.TabIndex = 7
        '
        'SetbackSTextBox
        '
        Me.SetbackSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackS", True))
        Me.SetbackSTextBox.Location = New System.Drawing.Point(457, 64)
        Me.SetbackSTextBox.Name = "SetbackSTextBox"
        Me.SetbackSTextBox.Size = New System.Drawing.Size(289, 21)
        Me.SetbackSTextBox.TabIndex = 5
        '
        'SetbackSSTextBox
        '
        Me.SetbackSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackSS", True))
        Me.SetbackSSTextBox.Location = New System.Drawing.Point(457, 38)
        Me.SetbackSSTextBox.Name = "SetbackSSTextBox"
        Me.SetbackSSTextBox.Size = New System.Drawing.Size(289, 21)
        Me.SetbackSSTextBox.TabIndex = 3
        '
        'ExtendedComboBox3
        '
        Me.ExtendedComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ExtendedComboBox3.FormattingEnabled = True
        Me.ExtendedComboBox3.Location = New System.Drawing.Point(455, 267)
        Me.ExtendedComboBox3.Name = "ExtendedComboBox3"
        Me.ExtendedComboBox3.Size = New System.Drawing.Size(117, 21)
        Me.ExtendedComboBox3.TabIndex = 8
        '
        'ExtendedComboBox2
        '
        Me.ExtendedComboBox2.FormattingEnabled = True
        Me.ExtendedComboBox2.Location = New System.Drawing.Point(455, 191)
        Me.ExtendedComboBox2.Name = "ExtendedComboBox2"
        Me.ExtendedComboBox2.Size = New System.Drawing.Size(117, 21)
        Me.ExtendedComboBox2.TabIndex = 8
        '
        'SetbackFTextBox
        '
        Me.SetbackFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackF", True))
        Me.SetbackFTextBox.Location = New System.Drawing.Point(457, 11)
        Me.SetbackFTextBox.Name = "SetbackFTextBox"
        Me.SetbackFTextBox.Size = New System.Drawing.Size(289, 21)
        Me.SetbackFTextBox.TabIndex = 1
        '
        'ExtendedComboBox1
        '
        Me.ExtendedComboBox1.FormattingEnabled = True
        Me.ExtendedComboBox1.Location = New System.Drawing.Point(455, 239)
        Me.ExtendedComboBox1.Name = "ExtendedComboBox1"
        Me.ExtendedComboBox1.Size = New System.Drawing.Size(117, 21)
        Me.ExtendedComboBox1.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(174, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Foreshore - 12.0 m"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(174, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Rear - 1.0 m"
        '
        'cboSetBkFS
        '
        Me.cboSetBkFS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSetBkFS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSetBkFS.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "SetbackFSComply", True))
        Me.cboSetBkFS.FormattingEnabled = True
        Me.cboSetBkFS.Location = New System.Drawing.Point(334, 119)
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
        Me.cboSetBkR.Location = New System.Drawing.Point(334, 92)
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
        Me.cboSetBkS.Location = New System.Drawing.Point(334, 66)
        Me.cboSetBkS.Name = "cboSetBkS"
        Me.cboSetBkS.Size = New System.Drawing.Size(117, 21)
        Me.cboSetBkS.TabIndex = 4
        '
        'cbosetbkSS
        '
        Me.cbosetbkSS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbosetbkSS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbosetbkSS.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "SetbackSSComply", True))
        Me.cbosetbkSS.FormattingEnabled = True
        Me.cbosetbkSS.Location = New System.Drawing.Point(334, 40)
        Me.cbosetbkSS.Name = "cbosetbkSS"
        Me.cbosetbkSS.Size = New System.Drawing.Size(117, 21)
        Me.cbosetbkSS.TabIndex = 2
        '
        'cboSetBkFront
        '
        Me.cboSetBkFront.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSetBkFront.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSetBkFront.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "SetbackFComply", True))
        Me.cboSetBkFront.FormattingEnabled = True
        Me.cboSetBkFront.Location = New System.Drawing.Point(334, 13)
        Me.cboSetBkFront.Name = "cboSetBkFront"
        Me.cboSetBkFront.Size = New System.Drawing.Size(117, 21)
        Me.cboSetBkFront.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(174, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Side - 1.0 m"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(174, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Side-Street - 3.0 m"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(174, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Front - Exist or 7.5 m"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.DAFloorTextBox)
        Me.Panel1.Controls.Add(Me.MaxHeightTextBox)
        Me.Panel1.Controls.Add(Me.cboMaxHeight)
        Me.Panel1.Controls.Add(Me.cboFSR)
        Me.Panel1.Controls.Add(Me.cboNatHERSComply)
        Me.Panel1.Controls.Add(Me.NatHERS_RatingTextBox)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(11, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 108)
        Me.Panel1.TabIndex = 1
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
        'DAFloorTextBox
        '
        Me.DAFloorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "DAFloor", True))
        Me.DAFloorTextBox.Location = New System.Drawing.Point(455, 44)
        Me.DAFloorTextBox.Name = "DAFloorTextBox"
        Me.DAFloorTextBox.Size = New System.Drawing.Size(289, 21)
        Me.DAFloorTextBox.TabIndex = 3
        '
        'MaxHeightTextBox
        '
        Me.MaxHeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "MaxHeight", True))
        Me.MaxHeightTextBox.Location = New System.Drawing.Point(455, 74)
        Me.MaxHeightTextBox.Name = "MaxHeightTextBox"
        Me.MaxHeightTextBox.Size = New System.Drawing.Size(289, 21)
        Me.MaxHeightTextBox.TabIndex = 5
        '
        'cboMaxHeight
        '
        Me.cboMaxHeight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMaxHeight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaxHeight.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "MaxHeightComply", True))
        Me.cboMaxHeight.FormattingEnabled = True
        Me.cboMaxHeight.Location = New System.Drawing.Point(334, 73)
        Me.cboMaxHeight.Name = "cboMaxHeight"
        Me.cboMaxHeight.Size = New System.Drawing.Size(117, 21)
        Me.cboMaxHeight.TabIndex = 4
        '
        'cboFSR
        '
        Me.cboFSR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFSR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFSR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "FSRComply", True))
        Me.cboFSR.FormattingEnabled = True
        Me.cboFSR.Location = New System.Drawing.Point(334, 43)
        Me.cboFSR.Name = "cboFSR"
        Me.cboFSR.Size = New System.Drawing.Size(117, 21)
        Me.cboFSR.TabIndex = 2
        '
        'cboNatHERSComply
        '
        Me.cboNatHERSComply.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNatHERSComply.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNatHERSComply.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "NatHERSComply", True))
        Me.cboNatHERSComply.FormattingEnabled = True
        Me.cboNatHERSComply.Location = New System.Drawing.Point(334, 8)
        Me.cboNatHERSComply.Name = "cboNatHERSComply"
        Me.cboNatHERSComply.Size = New System.Drawing.Size(117, 21)
        Me.cboNatHERSComply.TabIndex = 0
        '
        'NatHERS_RatingTextBox
        '
        Me.NatHERS_RatingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "NatHERS_Rating", True))
        Me.NatHERS_RatingTextBox.Location = New System.Drawing.Point(455, 10)
        Me.NatHERS_RatingTextBox.Name = "NatHERS_RatingTextBox"
        Me.NatHERS_RatingTextBox.Size = New System.Drawing.Size(289, 21)
        Me.NatHERS_RatingTextBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Max Build Height"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "FSR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(174, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "8.5 m"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(174, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "0.45:1 (Zone 2ec 0.35:1)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(174, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
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
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(174, 60)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(119, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Prox to Boundaries: 1m"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(174, 28)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 13)
        Me.Label35.TabIndex = 13
        Me.Label35.Text = "Balcony 15 m²"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(174, 9)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(101, 13)
        Me.Label36.TabIndex = 12
        Me.Label36.Text = "Ground Level 35 m²"
        '
        'OpenSpaceTextBox
        '
        Me.OpenSpaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OpenSpace", True))
        Me.OpenSpaceTextBox.Location = New System.Drawing.Point(457, 6)
        Me.OpenSpaceTextBox.Name = "OpenSpaceTextBox"
        Me.OpenSpaceTextBox.Size = New System.Drawing.Size(289, 21)
        Me.OpenSpaceTextBox.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Private Open Space"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label35)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.OpenSpaceTextBox)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.cboOpenSpace)
        Me.Panel3.Location = New System.Drawing.Point(11, 317)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(758, 49)
        Me.Panel3.TabIndex = 1
        '
        'cboOpenSpace
        '
        Me.cboOpenSpace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOpenSpace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOpenSpace.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OpenSpaceComply", True))
        Me.cboOpenSpace.FormattingEnabled = True
        Me.cboOpenSpace.Location = New System.Drawing.Point(334, 6)
        Me.cboOpenSpace.Name = "cboOpenSpace"
        Me.cboOpenSpace.Size = New System.Drawing.Size(117, 21)
        Me.cboOpenSpace.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(464, 32)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(343, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Comply?"
        '
        'pnlDCPCheck1
        '
        Me.pnlDCPCheck1.Controls.Add(Me.Label6)
        Me.pnlDCPCheck1.Controls.Add(Me.btnUpdate)
        Me.pnlDCPCheck1.Controls.Add(Me.Label5)
        Me.pnlDCPCheck1.Controls.Add(Me.Label4)
        Me.pnlDCPCheck1.Controls.Add(Me.Label3)
        Me.pnlDCPCheck1.Controls.Add(Me.Label2)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel3)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel4)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel2)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel1)
        Me.pnlDCPCheck1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDCPCheck1.Location = New System.Drawing.Point(0, 0)
        Me.pnlDCPCheck1.Name = "pnlDCPCheck1"
        Me.pnlDCPCheck1.Size = New System.Drawing.Size(898, 501)
        Me.pnlDCPCheck1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DUAL OCCUPANCY - Prescriptive Standard Checklist"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.OSParkEntryTextBox)
        Me.Panel4.Controls.Add(Me.Label38)
        Me.Panel4.Controls.Add(Me.OSParkProxTextBox)
        Me.Panel4.Controls.Add(Me.OSParkSpaceTextBox)
        Me.Panel4.Controls.Add(Me.cboOSParkEntry)
        Me.Panel4.Controls.Add(Me.cboOSParkSpace)
        Me.Panel4.Controls.Add(Me.cboOSParkPRox)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Location = New System.Drawing.Point(11, 365)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(758, 116)
        Me.Panel4.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(15, 9)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 32)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "On-Site Private Parking Per Dwelling"
        '
        'OSParkEntryTextBox
        '
        Me.OSParkEntryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OSParkEntry", True))
        Me.OSParkEntryTextBox.Location = New System.Drawing.Point(457, 85)
        Me.OSParkEntryTextBox.Name = "OSParkEntryTextBox"
        Me.OSParkEntryTextBox.Size = New System.Drawing.Size(289, 21)
        Me.OSParkEntryTextBox.TabIndex = 5
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(186, 5)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(107, 39)
        Me.Label38.TabIndex = 11
        Me.Label38.Text = "# of Private Spaces:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Dwlg < 125m²   :  1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Dwlg > 125m²   :  2"
        '
        'OSParkProxTextBox
        '
        Me.OSParkProxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OSParkProx", True))
        Me.OSParkProxTextBox.Location = New System.Drawing.Point(457, 57)
        Me.OSParkProxTextBox.Name = "OSParkProxTextBox"
        Me.OSParkProxTextBox.Size = New System.Drawing.Size(289, 21)
        Me.OSParkProxTextBox.TabIndex = 3
        '
        'OSParkSpaceTextBox
        '
        Me.OSParkSpaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OSParkSpace", True))
        Me.OSParkSpaceTextBox.Location = New System.Drawing.Point(457, 10)
        Me.OSParkSpaceTextBox.Name = "OSParkSpaceTextBox"
        Me.OSParkSpaceTextBox.Size = New System.Drawing.Size(289, 21)
        Me.OSParkSpaceTextBox.TabIndex = 1
        '
        'cboOSParkEntry
        '
        Me.cboOSParkEntry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOSParkEntry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOSParkEntry.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OSParkEntryComply", True))
        Me.cboOSParkEntry.FormattingEnabled = True
        Me.cboOSParkEntry.Location = New System.Drawing.Point(334, 85)
        Me.cboOSParkEntry.Name = "cboOSParkEntry"
        Me.cboOSParkEntry.Size = New System.Drawing.Size(117, 21)
        Me.cboOSParkEntry.TabIndex = 4
        '
        'cboOSParkSpace
        '
        Me.cboOSParkSpace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOSParkSpace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOSParkSpace.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OSParkSpaceComply", True))
        Me.cboOSParkSpace.FormattingEnabled = True
        Me.cboOSParkSpace.Location = New System.Drawing.Point(334, 9)
        Me.cboOSParkSpace.Name = "cboOSParkSpace"
        Me.cboOSParkSpace.Size = New System.Drawing.Size(117, 21)
        Me.cboOSParkSpace.TabIndex = 0
        '
        'DCPCheckListTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlDCPCheck1)
        Me.Name = "DCPCheckListTwo"
        Me.Size = New System.Drawing.Size(898, 501)
        CType(Me.DevelopmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlDCPCheck1.ResumeLayout(False)
        Me.pnlDCPCheck1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DevelopmentDataBindingSource As BindingSource
    Friend WithEvents DAdatasets As DAdatasets
    Friend WithEvents DevelopmentDataTableAdapter As DAdatasetsTableAdapters.DevelopmentDataTableAdapter
    Friend WithEvents cboOSParkPRox As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents SetbackFSTextBox As TextBox
    Friend WithEvents SetbackRTextBox As TextBox
    Friend WithEvents SetbackSTextBox As TextBox
    Friend WithEvents SetbackSSTextBox As TextBox
    Friend WithEvents ExtendedComboBox3 As ComboBox
    Friend WithEvents ExtendedComboBox2 As ComboBox
    Friend WithEvents SetbackFTextBox As TextBox
    Friend WithEvents ExtendedComboBox1 As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cboSetBkFS As ComboBox
    Friend WithEvents cboSetBkR As ComboBox
    Friend WithEvents cboSetBkS As ComboBox
    Friend WithEvents cbosetbkSS As ComboBox
    Friend WithEvents cboSetBkFront As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents DAFloorTextBox As TextBox
    Friend WithEvents MaxHeightTextBox As TextBox
    Friend WithEvents cboMaxHeight As ComboBox
    Friend WithEvents cboFSR As ComboBox
    Friend WithEvents cboNatHERSComply As ComboBox
    Friend WithEvents NatHERS_RatingTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents OpenSpaceTextBox As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboOpenSpace As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlDCPCheck1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents OSParkEntryTextBox As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents OSParkProxTextBox As TextBox
    Friend WithEvents OSParkSpaceTextBox As TextBox
    Friend WithEvents cboOSParkEntry As ComboBox
    Friend WithEvents cboOSParkSpace As ComboBox
End Class
