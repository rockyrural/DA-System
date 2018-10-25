<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchResults
    Inherits System.Windows.Forms.Form

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
        Me.grdSearch = New DevExpress.XtraGrid.GridControl()
        Me.gvwSearch = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdSearch
        '
        Me.grdSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSearch.Location = New System.Drawing.Point(0, 0)
        Me.grdSearch.MainView = Me.gvwSearch
        Me.grdSearch.Name = "grdSearch"
        Me.grdSearch.Size = New System.Drawing.Size(580, 392)
        Me.grdSearch.TabIndex = 1
        Me.grdSearch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvwSearch})
        '
        'gvwSearch
        '
        Me.gvwSearch.GridControl = Me.grdSearch
        Me.gvwSearch.Name = "gvwSearch"
        Me.gvwSearch.OptionsFind.AlwaysVisible = True
        Me.gvwSearch.OptionsView.ShowGroupPanel = False
        '
        'SearchResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 392)
        Me.Controls.Add(Me.grdSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SearchResults"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search Results"
        CType(Me.grdSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdSearch As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvwSearch As DevExpress.XtraGrid.Views.Grid.GridView
End Class
