<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DCPCheckList6
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
        Me.OpenSpaceTextBox = New System.Windows.Forms.TextBox
        Me.DevelopmentDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DAdatasets = New LookupDevelopmentApplication.DAdatasets
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.DWSpaceTextBox = New System.Windows.Forms.TextBox
        Me.DWCombSExtTextBox = New System.Windows.Forms.TextBox
        Me.DWCombSEntTextBox = New System.Windows.Forms.TextBox
        Me.DWCombEETextBox = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.cboDWSpace = New System.Windows.Forms.ComboBox
        Me.cboDWCoombSext = New System.Windows.Forms.ComboBox
        Me.cboDWCoombSent = New System.Windows.Forms.ComboBox
        Me.cboDWCombEE = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.pnlDCPCheck1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.OSVisitorValueTextBox = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cboOSvisitorParking = New System.Windows.Forms.ComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cboOpenSpace = New System.Windows.Forms.ComboBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label24 = New System.Windows.Forms.Label
        Me.OSParkProxTextBox = New System.Windows.Forms.TextBox
        Me.OSParkSpaceTextBox = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cboOSParkSpace = New System.Windows.Forms.ComboBox
        Me.cboOSParkPRox = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DAFloorTextBox = New System.Windows.Forms.TextBox
        Me.EPSValueTextBox = New System.Windows.Forms.TextBox
        Me.MaxHeightTextBox = New System.Windows.Forms.TextBox
        Me.cboMaxHeight = New System.Windows.Forms.ComboBox
        Me.cboFSR = New System.Windows.Forms.ComboBox
        Me.cboEPS = New System.Windows.Forms.ComboBox
        Me.cboNatHERSComply = New System.Windows.Forms.ComboBox
        Me.NatHERS_RatingTextBox = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DevelopmentDataTableAdapter = New LookupDevelopmentApplication.DAdatasetsTableAdapters.DevelopmentDataTableAdapter
        CType(Me.DevelopmentDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.pnlDCPCheck1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenSpaceTextBox
        '
        Me.OpenSpaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OpenSpace", True))
        Me.OpenSpaceTextBox.Location = New System.Drawing.Point(503, 6)
        Me.OpenSpaceTextBox.Name = "OpenSpaceTextBox"
        Me.OpenSpaceTextBox.Size = New System.Drawing.Size(396, 20)
        Me.OpenSpaceTextBox.TabIndex = 1
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
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.DWSpaceTextBox)
        Me.Panel5.Controls.Add(Me.DWCombSExtTextBox)
        Me.Panel5.Controls.Add(Me.DWCombSEntTextBox)
        Me.Panel5.Controls.Add(Me.DWCombEETextBox)
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Controls.Add(Me.Label32)
        Me.Panel5.Controls.Add(Me.Label31)
        Me.Panel5.Controls.Add(Me.Label30)
        Me.Panel5.Controls.Add(Me.cboDWSpace)
        Me.Panel5.Controls.Add(Me.cboDWCoombSext)
        Me.Panel5.Controls.Add(Me.cboDWCoombSent)
        Me.Panel5.Controls.Add(Me.cboDWCombEE)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Location = New System.Drawing.Point(12, 480)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(922, 158)
        Me.Panel5.TabIndex = 7
        '
        'DWSpaceTextBox
        '
        Me.DWSpaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "DWSpace", True))
        Me.DWSpaceTextBox.Location = New System.Drawing.Point(503, 103)
        Me.DWSpaceTextBox.Name = "DWSpaceTextBox"
        Me.DWSpaceTextBox.Size = New System.Drawing.Size(396, 20)
        Me.DWSpaceTextBox.TabIndex = 7
        '
        'DWCombSExtTextBox
        '
        Me.DWCombSExtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "DWCombSExt", True))
        Me.DWCombSExtTextBox.Location = New System.Drawing.Point(503, 63)
        Me.DWCombSExtTextBox.Name = "DWCombSExtTextBox"
        Me.DWCombSExtTextBox.Size = New System.Drawing.Size(396, 20)
        Me.DWCombSExtTextBox.TabIndex = 5
        '
        'DWCombSEntTextBox
        '
        Me.DWCombSEntTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "DWCombSEnt", True))
        Me.DWCombSEntTextBox.Location = New System.Drawing.Point(503, 36)
        Me.DWCombSEntTextBox.Name = "DWCombSEntTextBox"
        Me.DWCombSEntTextBox.Size = New System.Drawing.Size(396, 20)
        Me.DWCombSEntTextBox.TabIndex = 3
        '
        'DWCombEETextBox
        '
        Me.DWCombEETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "DWCombEE", True))
        Me.DWCombEETextBox.Location = New System.Drawing.Point(503, 9)
        Me.DWCombEETextBox.Name = "DWCombEETextBox"
        Me.DWCombEETextBox.Size = New System.Drawing.Size(396, 20)
        Me.DWCombEETextBox.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(14, 3)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 13)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "DriveWay Widths"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(170, 97)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(128, 26)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Space Required between" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Separate Entry/Exit:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(170, 66)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(70, 13)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Separate Exit"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(170, 39)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Separate Entry"
        '
        'cboDWSpace
        '
        Me.cboDWSpace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDWSpace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDWSpace.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "DWSpaceComply", True))
        Me.cboDWSpace.FormattingEnabled = True
        Me.cboDWSpace.Location = New System.Drawing.Point(349, 103)
        Me.cboDWSpace.Name = "cboDWSpace"
        Me.cboDWSpace.Size = New System.Drawing.Size(117, 21)
        Me.cboDWSpace.TabIndex = 6
        '
        'cboDWCoombSext
        '
        Me.cboDWCoombSext.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDWCoombSext.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDWCoombSext.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "DWCombSExtComply", True))
        Me.cboDWCoombSext.FormattingEnabled = True
        Me.cboDWCoombSext.Location = New System.Drawing.Point(349, 63)
        Me.cboDWCoombSext.Name = "cboDWCoombSext"
        Me.cboDWCoombSext.Size = New System.Drawing.Size(117, 21)
        Me.cboDWCoombSext.TabIndex = 4
        '
        'cboDWCoombSent
        '
        Me.cboDWCoombSent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDWCoombSent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDWCoombSent.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "DWCombSEntComply", True))
        Me.cboDWCoombSent.FormattingEnabled = True
        Me.cboDWCoombSent.Location = New System.Drawing.Point(349, 36)
        Me.cboDWCoombSent.Name = "cboDWCoombSent"
        Me.cboDWCoombSent.Size = New System.Drawing.Size(117, 21)
        Me.cboDWCoombSent.TabIndex = 2
        '
        'cboDWCombEE
        '
        Me.cboDWCombEE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDWCombEE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDWCombEE.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "DWCombEEComply", True))
        Me.cboDWCombEE.FormattingEnabled = True
        Me.cboDWCombEE.Location = New System.Drawing.Point(349, 9)
        Me.cboDWCombEE.Name = "cboDWCombEE"
        Me.cboDWCombEE.Size = New System.Drawing.Size(117, 21)
        Me.cboDWCombEE.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(170, 12)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(103, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Combined Entry/Exit"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Private Open Space"
        '
        'pnlDCPCheck1
        '
        Me.pnlDCPCheck1.Controls.Add(Me.Panel5)
        Me.pnlDCPCheck1.Controls.Add(Me.Label6)
        Me.pnlDCPCheck1.Controls.Add(Me.Label5)
        Me.pnlDCPCheck1.Controls.Add(Me.Label4)
        Me.pnlDCPCheck1.Controls.Add(Me.Label3)
        Me.pnlDCPCheck1.Controls.Add(Me.Label2)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel6)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel3)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel4)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel2)
        Me.pnlDCPCheck1.Controls.Add(Me.Panel1)
        Me.pnlDCPCheck1.Location = New System.Drawing.Point(12, 10)
        Me.pnlDCPCheck1.Name = "pnlDCPCheck1"
        Me.pnlDCPCheck1.Size = New System.Drawing.Size(946, 653)
        Me.pnlDCPCheck1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Comply?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(503, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Standard"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "OTHER - Prescriptive Standard Checklist"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.OSVisitorValueTextBox)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.cboOSvisitorParking)
        Me.Panel6.Location = New System.Drawing.Point(11, 444)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(923, 53)
        Me.Panel6.TabIndex = 1
        '
        'OSVisitorValueTextBox
        '
        Me.OSVisitorValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OSVisitorValue", True))
        Me.OSVisitorValueTextBox.Location = New System.Drawing.Point(503, 7)
        Me.OSVisitorValueTextBox.Name = "OSVisitorValueTextBox"
        Me.OSVisitorValueTextBox.Size = New System.Drawing.Size(396, 20)
        Me.OSVisitorValueTextBox.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Private Open Space"
        '
        'cboOSvisitorParking
        '
        Me.cboOSvisitorParking.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOSvisitorParking.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOSvisitorParking.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OSVisitorComply", True))
        Me.cboOSvisitorParking.FormattingEnabled = True
        Me.cboOSvisitorParking.Location = New System.Drawing.Point(349, 6)
        Me.cboOSvisitorParking.Name = "cboOSvisitorParking"
        Me.cboOSvisitorParking.Size = New System.Drawing.Size(117, 21)
        Me.cboOSvisitorParking.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.OpenSpaceTextBox)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.cboOpenSpace)
        Me.Panel3.Location = New System.Drawing.Point(11, 346)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(923, 37)
        Me.Panel3.TabIndex = 1
        '
        'cboOpenSpace
        '
        Me.cboOpenSpace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOpenSpace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOpenSpace.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OpenSpaceComply", True))
        Me.cboOpenSpace.FormattingEnabled = True
        Me.cboOpenSpace.Location = New System.Drawing.Point(349, 6)
        Me.cboOpenSpace.Name = "cboOpenSpace"
        Me.cboOpenSpace.Size = New System.Drawing.Size(117, 21)
        Me.cboOpenSpace.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.OSParkProxTextBox)
        Me.Panel4.Controls.Add(Me.OSParkSpaceTextBox)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.cboOSParkSpace)
        Me.Panel4.Controls.Add(Me.cboOSParkPRox)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Location = New System.Drawing.Point(11, 382)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(923, 63)
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
        'OSParkProxTextBox
        '
        Me.OSParkProxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OSParkProx", True))
        Me.OSParkProxTextBox.Location = New System.Drawing.Point(503, 32)
        Me.OSParkProxTextBox.Name = "OSParkProxTextBox"
        Me.OSParkProxTextBox.Size = New System.Drawing.Size(396, 20)
        Me.OSParkProxTextBox.TabIndex = 3
        '
        'OSParkSpaceTextBox
        '
        Me.OSParkSpaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "OSParkSpace", True))
        Me.OSParkSpaceTextBox.Location = New System.Drawing.Point(503, 6)
        Me.OSParkSpaceTextBox.Name = "OSParkSpaceTextBox"
        Me.OSParkSpaceTextBox.Size = New System.Drawing.Size(396, 20)
        Me.OSParkSpaceTextBox.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(174, 8)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Private Spaces"
        '
        'cboOSParkSpace
        '
        Me.cboOSParkSpace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOSParkSpace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOSParkSpace.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OSParkSpaceComply", True))
        Me.cboOSParkSpace.FormattingEnabled = True
        Me.cboOSParkSpace.Location = New System.Drawing.Point(349, 5)
        Me.cboOSParkSpace.Name = "cboOSParkSpace"
        Me.cboOSParkSpace.Size = New System.Drawing.Size(117, 21)
        Me.cboOSParkSpace.TabIndex = 0
        '
        'cboOSParkPRox
        '
        Me.cboOSParkPRox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOSParkPRox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOSParkPRox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "OSParkPRoxComply", True))
        Me.cboOSParkPRox.FormattingEnabled = True
        Me.cboOSParkPRox.Location = New System.Drawing.Point(349, 32)
        Me.cboOSParkPRox.Name = "cboOSParkPRox"
        Me.cboOSParkPRox.Size = New System.Drawing.Size(117, 21)
        Me.cboOSParkPRox.TabIndex = 2
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(174, 35)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Prox to Boundaries"
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
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(11, 187)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(923, 160)
        Me.Panel2.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Setbacks"
        '
        'SetbackFSTextBox
        '
        Me.SetbackFSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackFS", True))
        Me.SetbackFSTextBox.Location = New System.Drawing.Point(503, 119)
        Me.SetbackFSTextBox.Name = "SetbackFSTextBox"
        Me.SetbackFSTextBox.Size = New System.Drawing.Size(396, 20)
        Me.SetbackFSTextBox.TabIndex = 9
        '
        'SetbackRTextBox
        '
        Me.SetbackRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackR", True))
        Me.SetbackRTextBox.Location = New System.Drawing.Point(503, 92)
        Me.SetbackRTextBox.Name = "SetbackRTextBox"
        Me.SetbackRTextBox.Size = New System.Drawing.Size(396, 20)
        Me.SetbackRTextBox.TabIndex = 7
        '
        'SetbackSTextBox
        '
        Me.SetbackSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackS", True))
        Me.SetbackSTextBox.Location = New System.Drawing.Point(503, 66)
        Me.SetbackSTextBox.Name = "SetbackSTextBox"
        Me.SetbackSTextBox.Size = New System.Drawing.Size(396, 20)
        Me.SetbackSTextBox.TabIndex = 5
        '
        'SetbackSSTextBox
        '
        Me.SetbackSSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackSS", True))
        Me.SetbackSSTextBox.Location = New System.Drawing.Point(503, 40)
        Me.SetbackSSTextBox.Name = "SetbackSSTextBox"
        Me.SetbackSSTextBox.Size = New System.Drawing.Size(396, 20)
        Me.SetbackSSTextBox.TabIndex = 3
        '
        'SetbackFTextBox
        '
        Me.SetbackFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "SetbackF", True))
        Me.SetbackFTextBox.Location = New System.Drawing.Point(503, 13)
        Me.SetbackFTextBox.Name = "SetbackFTextBox"
        Me.SetbackFTextBox.Size = New System.Drawing.Size(396, 20)
        Me.SetbackFTextBox.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(174, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Foreshore"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(174, 95)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Rear "
        '
        'cboSetBkFS
        '
        Me.cboSetBkFS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboSetBkFS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSetBkFS.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "SetbackFSComply", True))
        Me.cboSetBkFS.FormattingEnabled = True
        Me.cboSetBkFS.Location = New System.Drawing.Point(349, 119)
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
        Me.cboSetBkR.Location = New System.Drawing.Point(349, 92)
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
        Me.cboSetBkS.Location = New System.Drawing.Point(349, 66)
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
        Me.cbosetbkSS.Location = New System.Drawing.Point(349, 40)
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
        Me.cboSetBkFront.Location = New System.Drawing.Point(349, 13)
        Me.cboSetBkFront.Name = "cboSetBkFront"
        Me.cboSetBkFront.Size = New System.Drawing.Size(117, 21)
        Me.cboSetBkFront.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(174, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Side "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(174, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Side-Street "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(174, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Front "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DAFloorTextBox)
        Me.Panel1.Controls.Add(Me.EPSValueTextBox)
        Me.Panel1.Controls.Add(Me.MaxHeightTextBox)
        Me.Panel1.Controls.Add(Me.cboMaxHeight)
        Me.Panel1.Controls.Add(Me.cboFSR)
        Me.Panel1.Controls.Add(Me.cboEPS)
        Me.Panel1.Controls.Add(Me.cboNatHERSComply)
        Me.Panel1.Controls.Add(Me.NatHERS_RatingTextBox)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(11, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(923, 137)
        Me.Panel1.TabIndex = 1
        '
        'DAFloorTextBox
        '
        Me.DAFloorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "DAFloor", True))
        Me.DAFloorTextBox.Location = New System.Drawing.Point(503, 67)
        Me.DAFloorTextBox.Name = "DAFloorTextBox"
        Me.DAFloorTextBox.Size = New System.Drawing.Size(396, 20)
        Me.DAFloorTextBox.TabIndex = 5
        '
        'EPSValueTextBox
        '
        Me.EPSValueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "EPSValue", True))
        Me.EPSValueTextBox.Location = New System.Drawing.Point(503, 38)
        Me.EPSValueTextBox.Name = "EPSValueTextBox"
        Me.EPSValueTextBox.Size = New System.Drawing.Size(396, 20)
        Me.EPSValueTextBox.TabIndex = 3
        '
        'MaxHeightTextBox
        '
        Me.MaxHeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "MaxHeight", True))
        Me.MaxHeightTextBox.Location = New System.Drawing.Point(503, 104)
        Me.MaxHeightTextBox.Name = "MaxHeightTextBox"
        Me.MaxHeightTextBox.Size = New System.Drawing.Size(396, 20)
        Me.MaxHeightTextBox.TabIndex = 7
        '
        'cboMaxHeight
        '
        Me.cboMaxHeight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboMaxHeight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaxHeight.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "MaxHeightComply", True))
        Me.cboMaxHeight.FormattingEnabled = True
        Me.cboMaxHeight.Location = New System.Drawing.Point(349, 104)
        Me.cboMaxHeight.Name = "cboMaxHeight"
        Me.cboMaxHeight.Size = New System.Drawing.Size(117, 21)
        Me.cboMaxHeight.TabIndex = 6
        '
        'cboFSR
        '
        Me.cboFSR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFSR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFSR.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "FSRComply", True))
        Me.cboFSR.FormattingEnabled = True
        Me.cboFSR.Location = New System.Drawing.Point(349, 67)
        Me.cboFSR.Name = "cboFSR"
        Me.cboFSR.Size = New System.Drawing.Size(117, 21)
        Me.cboFSR.TabIndex = 4
        '
        'cboEPS
        '
        Me.cboEPS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboEPS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEPS.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "EPSComply", True))
        Me.cboEPS.FormattingEnabled = True
        Me.cboEPS.Location = New System.Drawing.Point(349, 38)
        Me.cboEPS.Name = "cboEPS"
        Me.cboEPS.Size = New System.Drawing.Size(117, 21)
        Me.cboEPS.TabIndex = 2
        '
        'cboNatHERSComply
        '
        Me.cboNatHERSComply.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNatHERSComply.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNatHERSComply.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DevelopmentDataBindingSource, "NatHERSComply", True))
        Me.cboNatHERSComply.FormattingEnabled = True
        Me.cboNatHERSComply.Location = New System.Drawing.Point(349, 9)
        Me.cboNatHERSComply.Name = "cboNatHERSComply"
        Me.cboNatHERSComply.Size = New System.Drawing.Size(117, 21)
        Me.cboNatHERSComply.TabIndex = 0
        '
        'NatHERS_RatingTextBox
        '
        Me.NatHERS_RatingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DevelopmentDataBindingSource, "NatHERS_Rating", True))
        Me.NatHERS_RatingTextBox.Location = New System.Drawing.Point(503, 10)
        Me.NatHERS_RatingTextBox.Name = "NatHERS_RatingTextBox"
        Me.NatHERS_RatingTextBox.Size = New System.Drawing.Size(396, 20)
        Me.NatHERS_RatingTextBox.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Max Build Height"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Energy Perf Statemt"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "FSR"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(174, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 34)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "8.5 m (10m if in 2t adj 3aBus in Bay, Mor and Nar town) "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "YES"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(174, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "0.45:1 (Zone 2ec 0.35:1)"
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
        'DevelopmentDataTableAdapter
        '
        Me.DevelopmentDataTableAdapter.ClearBeforeFill = True
        '
        'DCPCheckList6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 675)
        Me.Controls.Add(Me.pnlDCPCheck1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DCPCheckList6"
        Me.Text = "OTHER - Prescriptive Standard Checklist"
        CType(Me.DevelopmentDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DAdatasets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlDCPCheck1.ResumeLayout(False)
        Me.pnlDCPCheck1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenSpaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DevelopmentDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DAdatasets As LookupDevelopmentApplication.DAdatasets
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DWSpaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DWCombSExtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DWCombSEntTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DWCombEETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboDWSpace As System.Windows.Forms.ComboBox
    Friend WithEvents cboDWCoombSext As System.Windows.Forms.ComboBox
    Friend WithEvents cboDWCoombSent As System.Windows.Forms.ComboBox
    Friend WithEvents cboDWCombEE As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents pnlDCPCheck1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents OSVisitorValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboOSvisitorParking As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cboOpenSpace As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents OSParkProxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OSParkSpaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cboOSParkSpace As System.Windows.Forms.ComboBox
    Friend WithEvents cboOSParkPRox As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DAFloorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EPSValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaxHeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cboMaxHeight As System.Windows.Forms.ComboBox
    Friend WithEvents cboFSR As System.Windows.Forms.ComboBox
    Friend WithEvents cboEPS As System.Windows.Forms.ComboBox
    Friend WithEvents cboNatHERSComply As System.Windows.Forms.ComboBox
    Friend WithEvents NatHERS_RatingTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DevelopmentDataTableAdapter As LookupDevelopmentApplication.DAdatasetsTableAdapters.DevelopmentDataTableAdapter
End Class
