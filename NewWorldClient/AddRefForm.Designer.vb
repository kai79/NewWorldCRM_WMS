<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRefForm
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
        Me.NewMemAddRefDataGridView = New System.Windows.Forms.DataGridView()
        Me.MemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.MemTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.MemTblTableAdapter()
        Me.NewMemAddRefMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMemAddRefContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FindToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRefCancelBtn = New System.Windows.Forms.Button()
        Me.MemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemRankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemNRIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemCtcHomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemCtcMobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemZoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.NewMemAddRefDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewMemAddRefMenuStrip.SuspendLayout()
        Me.NewMemAddRefContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewMemAddRefDataGridView
        '
        Me.NewMemAddRefDataGridView.AllowUserToAddRows = False
        Me.NewMemAddRefDataGridView.AllowUserToDeleteRows = False
        Me.NewMemAddRefDataGridView.AutoGenerateColumns = False
        Me.NewMemAddRefDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.NewMemAddRefDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NewMemAddRefDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemIDDataGridViewTextBoxColumn, Me.MemRankDataGridViewTextBoxColumn, Me.MemNameDataGridViewTextBoxColumn, Me.MemAddressDataGridViewTextBoxColumn, Me.MemNRIC, Me.MemCtcHomeDataGridViewTextBoxColumn, Me.MemCtcMobDataGridViewTextBoxColumn, Me.MemEmailDataGridViewTextBoxColumn, Me.MemZoneDataGridViewTextBoxColumn, Me.MemRefDataGridViewTextBoxColumn, Me.MemLockDataGridViewCheckBoxColumn})
        Me.NewMemAddRefDataGridView.DataSource = Me.MemTblBindingSource
        Me.NewMemAddRefDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewMemAddRefDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.NewMemAddRefDataGridView.Name = "NewMemAddRefDataGridView"
        Me.NewMemAddRefDataGridView.ReadOnly = True
        Me.NewMemAddRefDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.NewMemAddRefDataGridView.Size = New System.Drawing.Size(911, 506)
        Me.NewMemAddRefDataGridView.TabIndex = 0
        '
        'MemTblBindingSource
        '
        Me.MemTblBindingSource.DataMember = "MemTbl"
        Me.MemTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemTblTableAdapter
        '
        Me.MemTblTableAdapter.ClearBeforeFill = True
        '
        'NewMemAddRefMenuStrip
        '
        Me.NewMemAddRefMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FilterToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.NewMemAddRefMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.NewMemAddRefMenuStrip.Name = "NewMemAddRefMenuStrip"
        Me.NewMemAddRefMenuStrip.Size = New System.Drawing.Size(911, 24)
        Me.NewMemAddRefMenuStrip.TabIndex = 1
        Me.NewMemAddRefMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'NewMemAddRefContextMenuStrip
        '
        Me.NewMemAddRefContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem1})
        Me.NewMemAddRefContextMenuStrip.Name = "NewMemAddRefContextMenuStrip"
        Me.NewMemAddRefContextMenuStrip.Size = New System.Drawing.Size(98, 26)
        '
        'FindToolStripMenuItem1
        '
        Me.FindToolStripMenuItem1.Name = "FindToolStripMenuItem1"
        Me.FindToolStripMenuItem1.Size = New System.Drawing.Size(97, 22)
        Me.FindToolStripMenuItem1.Text = "Find"
        '
        'AddRefCancelBtn
        '
        Me.AddRefCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AddRefCancelBtn.Location = New System.Drawing.Point(811, 479)
        Me.AddRefCancelBtn.Name = "AddRefCancelBtn"
        Me.AddRefCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddRefCancelBtn.TabIndex = 2
        Me.AddRefCancelBtn.Text = "Cancel"
        Me.AddRefCancelBtn.UseVisualStyleBackColor = True
        '
        'MemIDDataGridViewTextBoxColumn
        '
        Me.MemIDDataGridViewTextBoxColumn.DataPropertyName = "MemID"
        Me.MemIDDataGridViewTextBoxColumn.HeaderText = "MemID"
        Me.MemIDDataGridViewTextBoxColumn.Name = "MemIDDataGridViewTextBoxColumn"
        Me.MemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemIDDataGridViewTextBoxColumn.Visible = False
        '
        'MemRankDataGridViewTextBoxColumn
        '
        Me.MemRankDataGridViewTextBoxColumn.DataPropertyName = "MemRank"
        Me.MemRankDataGridViewTextBoxColumn.HeaderText = "Rank"
        Me.MemRankDataGridViewTextBoxColumn.Name = "MemRankDataGridViewTextBoxColumn"
        Me.MemRankDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemRankDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemRankDataGridViewTextBoxColumn.Visible = False
        '
        'MemNameDataGridViewTextBoxColumn
        '
        Me.MemNameDataGridViewTextBoxColumn.DataPropertyName = "MemName"
        Me.MemNameDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.MemNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.MemNameDataGridViewTextBoxColumn.Name = "MemNameDataGridViewTextBoxColumn"
        Me.MemNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemAddressDataGridViewTextBoxColumn
        '
        Me.MemAddressDataGridViewTextBoxColumn.DataPropertyName = "MemAddress"
        Me.MemAddressDataGridViewTextBoxColumn.FillWeight = 83.9467!
        Me.MemAddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.MemAddressDataGridViewTextBoxColumn.Name = "MemAddressDataGridViewTextBoxColumn"
        Me.MemAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemNRIC
        '
        Me.MemNRIC.DataPropertyName = "MemNRIC"
        Me.MemNRIC.FillWeight = 120.0!
        Me.MemNRIC.HeaderText = "NRIC"
        Me.MemNRIC.Name = "MemNRIC"
        Me.MemNRIC.ReadOnly = True
        Me.MemNRIC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemCtcHomeDataGridViewTextBoxColumn
        '
        Me.MemCtcHomeDataGridViewTextBoxColumn.DataPropertyName = "MemCtcHome"
        Me.MemCtcHomeDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.MemCtcHomeDataGridViewTextBoxColumn.HeaderText = "Contact (H)"
        Me.MemCtcHomeDataGridViewTextBoxColumn.Name = "MemCtcHomeDataGridViewTextBoxColumn"
        Me.MemCtcHomeDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemCtcHomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemCtcMobDataGridViewTextBoxColumn
        '
        Me.MemCtcMobDataGridViewTextBoxColumn.DataPropertyName = "MemCtcMob"
        Me.MemCtcMobDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.MemCtcMobDataGridViewTextBoxColumn.HeaderText = "Contact (M)"
        Me.MemCtcMobDataGridViewTextBoxColumn.Name = "MemCtcMobDataGridViewTextBoxColumn"
        Me.MemCtcMobDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemCtcMobDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemEmailDataGridViewTextBoxColumn
        '
        Me.MemEmailDataGridViewTextBoxColumn.DataPropertyName = "MemEmail"
        Me.MemEmailDataGridViewTextBoxColumn.HeaderText = "MemEmail"
        Me.MemEmailDataGridViewTextBoxColumn.Name = "MemEmailDataGridViewTextBoxColumn"
        Me.MemEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemEmailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemEmailDataGridViewTextBoxColumn.Visible = False
        '
        'MemZoneDataGridViewTextBoxColumn
        '
        Me.MemZoneDataGridViewTextBoxColumn.DataPropertyName = "MemZone"
        Me.MemZoneDataGridViewTextBoxColumn.HeaderText = "Zone"
        Me.MemZoneDataGridViewTextBoxColumn.Name = "MemZoneDataGridViewTextBoxColumn"
        Me.MemZoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemZoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemZoneDataGridViewTextBoxColumn.Visible = False
        '
        'MemRefDataGridViewTextBoxColumn
        '
        Me.MemRefDataGridViewTextBoxColumn.DataPropertyName = "MemRef"
        Me.MemRefDataGridViewTextBoxColumn.HeaderText = "MemRef"
        Me.MemRefDataGridViewTextBoxColumn.Name = "MemRefDataGridViewTextBoxColumn"
        Me.MemRefDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemRefDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemRefDataGridViewTextBoxColumn.Visible = False
        '
        'MemLockDataGridViewCheckBoxColumn
        '
        Me.MemLockDataGridViewCheckBoxColumn.DataPropertyName = "MemLock"
        Me.MemLockDataGridViewCheckBoxColumn.HeaderText = "MemLock"
        Me.MemLockDataGridViewCheckBoxColumn.Name = "MemLockDataGridViewCheckBoxColumn"
        Me.MemLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.MemLockDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemLockDataGridViewCheckBoxColumn.Visible = False
        '
        'AddRefForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.AddRefCancelBtn
        Me.ClientSize = New System.Drawing.Size(911, 530)
        Me.Controls.Add(Me.NewMemAddRefDataGridView)
        Me.Controls.Add(Me.AddRefCancelBtn)
        Me.Controls.Add(Me.NewMemAddRefMenuStrip)
        Me.MainMenuStrip = Me.NewMemAddRefMenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddRefForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Referral"
        CType(Me.NewMemAddRefDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewMemAddRefMenuStrip.ResumeLayout(False)
        Me.NewMemAddRefMenuStrip.PerformLayout()
        Me.NewMemAddRefContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewMemAddRefDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents MemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.MemTblTableAdapter
    Friend WithEvents NewMemAddRefMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewMemAddRefContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FindToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRefCancelBtn As System.Windows.Forms.Button
    Friend WithEvents MemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemRankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemNRIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemCtcHomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemCtcMobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemZoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemRefDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
