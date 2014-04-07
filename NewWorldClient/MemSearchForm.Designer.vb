<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemSearchForm
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
        Me.MemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.MemTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.MemTblTableAdapter()
        Me.MemSearchDataGridView = New System.Windows.Forms.DataGridView()
        Me.MemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemNRIC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemZoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemCtcHomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemCtcMobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemRankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemRefDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemRefID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemDateJoin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MemLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemSearchContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemTblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemSearchMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatisticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemSearchCancelBtn = New System.Windows.Forms.Button()
        CType(Me.MemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemSearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MemSearchContextMenuStrip.SuspendLayout()
        CType(Me.MemTblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MemSearchMenuStrip.SuspendLayout()
        Me.SuspendLayout()
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
        'MemSearchDataGridView
        '
        Me.MemSearchDataGridView.AllowUserToAddRows = False
        Me.MemSearchDataGridView.AllowUserToDeleteRows = False
        Me.MemSearchDataGridView.AutoGenerateColumns = False
        Me.MemSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MemSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemSearchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemIDDataGridViewTextBoxColumn, Me.MemNameDataGridViewTextBoxColumn, Me.MemNRIC, Me.MemAddressDataGridViewTextBoxColumn, Me.MemZoneDataGridViewTextBoxColumn, Me.MemCtcHomeDataGridViewTextBoxColumn, Me.MemCtcMobDataGridViewTextBoxColumn, Me.MemEmailDataGridViewTextBoxColumn, Me.MemRankDataGridViewTextBoxColumn, Me.MemRefDataGridViewTextBoxColumn, Me.MemRefID, Me.MemDateJoin, Me.MemCredit, Me.MemLockDataGridViewCheckBoxColumn, Me.MemLockUserDataGridViewTextBoxColumn})
        Me.MemSearchDataGridView.ContextMenuStrip = Me.MemSearchContextMenuStrip
        Me.MemSearchDataGridView.DataSource = Me.MemTblBindingSource1
        Me.MemSearchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemSearchDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.MemSearchDataGridView.Name = "MemSearchDataGridView"
        Me.MemSearchDataGridView.ReadOnly = True
        Me.MemSearchDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.MemSearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.MemSearchDataGridView.Size = New System.Drawing.Size(1108, 527)
        Me.MemSearchDataGridView.TabIndex = 2
        '
        'MemIDDataGridViewTextBoxColumn
        '
        Me.MemIDDataGridViewTextBoxColumn.DataPropertyName = "MemID"
        Me.MemIDDataGridViewTextBoxColumn.HeaderText = "Member ID"
        Me.MemIDDataGridViewTextBoxColumn.Name = "MemIDDataGridViewTextBoxColumn"
        Me.MemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
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
        'MemNRIC
        '
        Me.MemNRIC.DataPropertyName = "MemNRIC"
        Me.MemNRIC.FillWeight = 120.0!
        Me.MemNRIC.HeaderText = "NRIC"
        Me.MemNRIC.Name = "MemNRIC"
        Me.MemNRIC.ReadOnly = True
        Me.MemNRIC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemAddressDataGridViewTextBoxColumn
        '
        Me.MemAddressDataGridViewTextBoxColumn.DataPropertyName = "MemAddress"
        Me.MemAddressDataGridViewTextBoxColumn.FillWeight = 500.0!
        Me.MemAddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.MemAddressDataGridViewTextBoxColumn.Name = "MemAddressDataGridViewTextBoxColumn"
        Me.MemAddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemAddressDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemZoneDataGridViewTextBoxColumn
        '
        Me.MemZoneDataGridViewTextBoxColumn.DataPropertyName = "MemZone"
        Me.MemZoneDataGridViewTextBoxColumn.HeaderText = "Region"
        Me.MemZoneDataGridViewTextBoxColumn.Name = "MemZoneDataGridViewTextBoxColumn"
        Me.MemZoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemZoneDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemCtcHomeDataGridViewTextBoxColumn
        '
        Me.MemCtcHomeDataGridViewTextBoxColumn.DataPropertyName = "MemCtcHome"
        Me.MemCtcHomeDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.MemCtcHomeDataGridViewTextBoxColumn.HeaderText = "Contact (H)"
        Me.MemCtcHomeDataGridViewTextBoxColumn.Name = "MemCtcHomeDataGridViewTextBoxColumn"
        Me.MemCtcHomeDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemCtcHomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'MemCtcMobDataGridViewTextBoxColumn
        '
        Me.MemCtcMobDataGridViewTextBoxColumn.DataPropertyName = "MemCtcMob"
        Me.MemCtcMobDataGridViewTextBoxColumn.FillWeight = 150.0!
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
        'MemRankDataGridViewTextBoxColumn
        '
        Me.MemRankDataGridViewTextBoxColumn.DataPropertyName = "MemRank"
        Me.MemRankDataGridViewTextBoxColumn.HeaderText = "MemRank"
        Me.MemRankDataGridViewTextBoxColumn.Name = "MemRankDataGridViewTextBoxColumn"
        Me.MemRankDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemRankDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemRankDataGridViewTextBoxColumn.Visible = False
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
        'MemRefID
        '
        Me.MemRefID.DataPropertyName = "MemRefID"
        Me.MemRefID.HeaderText = "MemRefID"
        Me.MemRefID.Name = "MemRefID"
        Me.MemRefID.ReadOnly = True
        Me.MemRefID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemRefID.Visible = False
        '
        'MemDateJoin
        '
        Me.MemDateJoin.DataPropertyName = "MemDateJoin"
        Me.MemDateJoin.HeaderText = "MemDateJoin"
        Me.MemDateJoin.Name = "MemDateJoin"
        Me.MemDateJoin.ReadOnly = True
        Me.MemDateJoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemDateJoin.Visible = False
        '
        'MemCredit
        '
        Me.MemCredit.DataPropertyName = "MemCredit"
        Me.MemCredit.HeaderText = "MemCredit"
        Me.MemCredit.Name = "MemCredit"
        Me.MemCredit.ReadOnly = True
        Me.MemCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemCredit.Visible = False
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
        'MemLockUserDataGridViewTextBoxColumn
        '
        Me.MemLockUserDataGridViewTextBoxColumn.DataPropertyName = "MemLockUser"
        Me.MemLockUserDataGridViewTextBoxColumn.HeaderText = "MemLockUser"
        Me.MemLockUserDataGridViewTextBoxColumn.Name = "MemLockUserDataGridViewTextBoxColumn"
        Me.MemLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemLockUserDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.MemLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'MemSearchContextMenuStrip
        '
        Me.MemSearchContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.DeleteToolStripMenuItem1, Me.FilterToolStripMenuItem1, Me.RefreshToolStripMenuItem1})
        Me.MemSearchContextMenuStrip.Name = "MemSearchContextMenuStrip"
        Me.MemSearchContextMenuStrip.Size = New System.Drawing.Size(114, 92)
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'FilterToolStripMenuItem1
        '
        Me.FilterToolStripMenuItem1.Name = "FilterToolStripMenuItem1"
        Me.FilterToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.FilterToolStripMenuItem1.Text = "Filter"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'MemTblBindingSource1
        '
        Me.MemTblBindingSource1.DataMember = "MemTbl"
        Me.MemTblBindingSource1.DataSource = Me.NewWorldDBDataSet
        '
        'MemSearchMenuStrip
        '
        Me.MemSearchMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FilterToolStripMenuItem2, Me.RefreshToolStripMenuItem2, Me.StatisticsToolStripMenuItem})
        Me.MemSearchMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MemSearchMenuStrip.Name = "MemSearchMenuStrip"
        Me.MemSearchMenuStrip.Size = New System.Drawing.Size(1108, 24)
        Me.MemSearchMenuStrip.TabIndex = 3
        Me.MemSearchMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FilterToolStripMenuItem2
        '
        Me.FilterToolStripMenuItem2.Name = "FilterToolStripMenuItem2"
        Me.FilterToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FilterToolStripMenuItem2.Size = New System.Drawing.Size(45, 20)
        Me.FilterToolStripMenuItem2.Text = "&Filter"
        '
        'RefreshToolStripMenuItem2
        '
        Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
        Me.RefreshToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshToolStripMenuItem2.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem2.Text = "&Refresh"
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatisticToolStripMenuItem})
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.StatisticsToolStripMenuItem.Text = "Tools"
        '
        'StatisticToolStripMenuItem
        '
        Me.StatisticToolStripMenuItem.Name = "StatisticToolStripMenuItem"
        Me.StatisticToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StatisticToolStripMenuItem.Text = "Statistic"
        '
        'MemSearchCancelBtn
        '
        Me.MemSearchCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MemSearchCancelBtn.Location = New System.Drawing.Point(980, 503)
        Me.MemSearchCancelBtn.Name = "MemSearchCancelBtn"
        Me.MemSearchCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.MemSearchCancelBtn.TabIndex = 4
        Me.MemSearchCancelBtn.Text = "Cancel"
        Me.MemSearchCancelBtn.UseVisualStyleBackColor = True
        '
        'MemSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.MemSearchCancelBtn
        Me.ClientSize = New System.Drawing.Size(1108, 551)
        Me.Controls.Add(Me.MemSearchDataGridView)
        Me.Controls.Add(Me.MemSearchMenuStrip)
        Me.Controls.Add(Me.MemSearchCancelBtn)
        Me.Name = "MemSearchForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Search"
        CType(Me.MemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemSearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MemSearchContextMenuStrip.ResumeLayout(False)
        CType(Me.MemTblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MemSearchMenuStrip.ResumeLayout(False)
        Me.MemSearchMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents MemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.MemTblTableAdapter
    Friend WithEvents MemSearchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MemTblBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MemSearchMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemSearchContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemSearchCancelBtn As System.Windows.Forms.Button
    Friend WithEvents MemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemNRIC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemZoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemCtcHomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemCtcMobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemRankDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemRefDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemRefID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemDateJoin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MemLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatisticToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
