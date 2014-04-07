<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassLookupForm
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAttandedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowUnattendedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassLookupDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuCreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.MenuTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.MenuTblTableAdapter()
        Me.MenuStrip.SuspendLayout()
        CType(Me.ClassLookupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 555)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(322, 22)
        Me.StatusStrip.TabIndex = 0
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FilterToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(322, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowAllToolStripMenuItem, Me.ShowAttandedToolStripMenuItem, Me.ShowUnattendedToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'ShowAllToolStripMenuItem
        '
        Me.ShowAllToolStripMenuItem.Name = "ShowAllToolStripMenuItem"
        Me.ShowAllToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ShowAllToolStripMenuItem.Text = "Show All"
        '
        'ShowAttandedToolStripMenuItem
        '
        Me.ShowAttandedToolStripMenuItem.Name = "ShowAttandedToolStripMenuItem"
        Me.ShowAttandedToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ShowAttandedToolStripMenuItem.Text = "Show Attended"
        '
        'ShowUnattendedToolStripMenuItem
        '
        Me.ShowUnattendedToolStripMenuItem.Name = "ShowUnattendedToolStripMenuItem"
        Me.ShowUnattendedToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ShowUnattendedToolStripMenuItem.Text = "Show Unattended"
        '
        'ClassLookupDataGridView
        '
        Me.ClassLookupDataGridView.AllowUserToAddRows = False
        Me.ClassLookupDataGridView.AllowUserToDeleteRows = False
        Me.ClassLookupDataGridView.AutoGenerateColumns = False
        Me.ClassLookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassLookupDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn, Me.MenuNameDataGridViewTextBoxColumn, Me.MenuDescDataGridViewTextBoxColumn, Me.MenuProdNameDataGridViewTextBoxColumn, Me.MenuCreditDataGridViewTextBoxColumn, Me.MenuLockDataGridViewCheckBoxColumn, Me.MenuLockUserDataGridViewTextBoxColumn})
        Me.ClassLookupDataGridView.DataSource = Me.MenuTblBindingSource
        Me.ClassLookupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClassLookupDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.ClassLookupDataGridView.Name = "ClassLookupDataGridView"
        Me.ClassLookupDataGridView.ReadOnly = True
        Me.ClassLookupDataGridView.Size = New System.Drawing.Size(322, 531)
        Me.ClassLookupDataGridView.TabIndex = 2
        '
        'MenuIDDataGridViewTextBoxColumn
        '
        Me.MenuIDDataGridViewTextBoxColumn.DataPropertyName = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.HeaderText = "MenuID"
        Me.MenuIDDataGridViewTextBoxColumn.Name = "MenuIDDataGridViewTextBoxColumn"
        Me.MenuIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn.Visible = False
        '
        'MenuNameDataGridViewTextBoxColumn
        '
        Me.MenuNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuNameDataGridViewTextBoxColumn.DataPropertyName = "MenuName"
        Me.MenuNameDataGridViewTextBoxColumn.HeaderText = "Menu Name"
        Me.MenuNameDataGridViewTextBoxColumn.Name = "MenuNameDataGridViewTextBoxColumn"
        Me.MenuNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuDescDataGridViewTextBoxColumn
        '
        Me.MenuDescDataGridViewTextBoxColumn.DataPropertyName = "MenuDesc"
        Me.MenuDescDataGridViewTextBoxColumn.HeaderText = "MenuDesc"
        Me.MenuDescDataGridViewTextBoxColumn.Name = "MenuDescDataGridViewTextBoxColumn"
        Me.MenuDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuDescDataGridViewTextBoxColumn.Visible = False
        '
        'MenuProdNameDataGridViewTextBoxColumn
        '
        Me.MenuProdNameDataGridViewTextBoxColumn.DataPropertyName = "MenuProdName"
        Me.MenuProdNameDataGridViewTextBoxColumn.HeaderText = "MenuProdName"
        Me.MenuProdNameDataGridViewTextBoxColumn.Name = "MenuProdNameDataGridViewTextBoxColumn"
        Me.MenuProdNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuProdNameDataGridViewTextBoxColumn.Visible = False
        '
        'MenuCreditDataGridViewTextBoxColumn
        '
        Me.MenuCreditDataGridViewTextBoxColumn.DataPropertyName = "MenuCredit"
        Me.MenuCreditDataGridViewTextBoxColumn.HeaderText = "MenuCredit"
        Me.MenuCreditDataGridViewTextBoxColumn.Name = "MenuCreditDataGridViewTextBoxColumn"
        Me.MenuCreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuCreditDataGridViewTextBoxColumn.Visible = False
        '
        'MenuLockDataGridViewCheckBoxColumn
        '
        Me.MenuLockDataGridViewCheckBoxColumn.DataPropertyName = "MenuLock"
        Me.MenuLockDataGridViewCheckBoxColumn.HeaderText = "MenuLock"
        Me.MenuLockDataGridViewCheckBoxColumn.Name = "MenuLockDataGridViewCheckBoxColumn"
        Me.MenuLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.MenuLockDataGridViewCheckBoxColumn.Visible = False
        '
        'MenuLockUserDataGridViewTextBoxColumn
        '
        Me.MenuLockUserDataGridViewTextBoxColumn.DataPropertyName = "MenuLockUser"
        Me.MenuLockUserDataGridViewTextBoxColumn.HeaderText = "MenuLockUser"
        Me.MenuLockUserDataGridViewTextBoxColumn.Name = "MenuLockUserDataGridViewTextBoxColumn"
        Me.MenuLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'MenuTblBindingSource
        '
        Me.MenuTblBindingSource.DataMember = "MenuTbl"
        Me.MenuTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuTblTableAdapter
        '
        Me.MenuTblTableAdapter.ClearBeforeFill = True
        '
        'ClassLookupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 577)
        Me.Controls.Add(Me.ClassLookupDataGridView)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClassLookupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class Lookup"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.ClassLookupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassLookupDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAttandedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowUnattendedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents MenuTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.MenuTblTableAdapter
    Friend WithEvents MenuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuCreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
