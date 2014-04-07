<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemPurchaseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MemPurchaseForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurSearchDataGridView = New System.Windows.Forms.DataGridView()
        Me.MemPurchaseContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.PurTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.PurTblTableAdapter()
        Me.MemPurchaseCancelBtn = New System.Windows.Forms.Button()
        Me.PurOrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurWarrNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurDevStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurMemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurSDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurEDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurHisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PurSaveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PurAmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurProdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurCreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurDepoDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurRemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip.SuspendLayout()
        CType(Me.PurSearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MemPurchaseContextMenuStrip.SuspendLayout()
        CType(Me.PurTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FilterToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(989, 24)
        Me.MenuStrip.TabIndex = 0
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
        'PurSearchDataGridView
        '
        Me.PurSearchDataGridView.AllowUserToAddRows = False
        Me.PurSearchDataGridView.AllowUserToDeleteRows = False
        Me.PurSearchDataGridView.AutoGenerateColumns = False
        Me.PurSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PurSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurSearchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurOrderNoDataGridViewTextBoxColumn, Me.PurWarrNoDataGridViewTextBoxColumn, Me.PurDateDataGridViewTextBoxColumn, Me.PurProdNameDataGridViewTextBoxColumn, Me.PurDevStatusDataGridViewTextBoxColumn, Me.PurIDDataGridViewTextBoxColumn, Me.PurMemIDDataGridViewTextBoxColumn, Me.PurSDateDataGridViewTextBoxColumn, Me.PurEDateDataGridViewTextBoxColumn, Me.PurHisDataGridViewTextBoxColumn, Me.PurLockUserDataGridViewTextBoxColumn, Me.PurLockDataGridViewCheckBoxColumn, Me.PurSaveDataGridViewCheckBoxColumn, Me.PurAmtDataGridViewTextBoxColumn, Me.PurQtyDataGridViewTextBoxColumn, Me.PurProdIDDataGridViewTextBoxColumn, Me.PurCreditDataGridViewTextBoxColumn, Me.PurDepoDateDataGridViewTextBoxColumn, Me.PurRemarkDataGridViewTextBoxColumn})
        Me.PurSearchDataGridView.ContextMenuStrip = Me.MemPurchaseContextMenuStrip
        Me.PurSearchDataGridView.DataSource = Me.PurTblBindingSource
        Me.PurSearchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PurSearchDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.PurSearchDataGridView.Name = "PurSearchDataGridView"
        Me.PurSearchDataGridView.ReadOnly = True
        Me.PurSearchDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.PurSearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect
        Me.PurSearchDataGridView.Size = New System.Drawing.Size(989, 486)
        Me.PurSearchDataGridView.TabIndex = 1
        '
        'MemPurchaseContextMenuStrip
        '
        Me.MemPurchaseContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.FilterToolStripMenuItem1, Me.RefreshToolStripMenuItem1})
        Me.MemPurchaseContextMenuStrip.Name = "MemPurchaseContextMenuStrip"
        Me.MemPurchaseContextMenuStrip.Size = New System.Drawing.Size(114, 70)
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.OpenToolStripMenuItem1.Text = "Open"
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
        'PurTblBindingSource
        '
        Me.PurTblBindingSource.DataMember = "PurTbl"
        Me.PurTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurTblTableAdapter
        '
        Me.PurTblTableAdapter.ClearBeforeFill = True
        '
        'MemPurchaseCancelBtn
        '
        Me.MemPurchaseCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MemPurchaseCancelBtn.Location = New System.Drawing.Point(882, 458)
        Me.MemPurchaseCancelBtn.Name = "MemPurchaseCancelBtn"
        Me.MemPurchaseCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.MemPurchaseCancelBtn.TabIndex = 2
        Me.MemPurchaseCancelBtn.Text = "Cancel"
        Me.MemPurchaseCancelBtn.UseVisualStyleBackColor = True
        '
        'PurOrderNoDataGridViewTextBoxColumn
        '
        Me.PurOrderNoDataGridViewTextBoxColumn.DataPropertyName = "PurOrderNo"
        Me.PurOrderNoDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.PurOrderNoDataGridViewTextBoxColumn.HeaderText = "Order No"
        Me.PurOrderNoDataGridViewTextBoxColumn.Name = "PurOrderNoDataGridViewTextBoxColumn"
        Me.PurOrderNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurOrderNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'PurWarrNoDataGridViewTextBoxColumn
        '
        Me.PurWarrNoDataGridViewTextBoxColumn.DataPropertyName = "PurWarrNo"
        Me.PurWarrNoDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.PurWarrNoDataGridViewTextBoxColumn.HeaderText = "Warranty No"
        Me.PurWarrNoDataGridViewTextBoxColumn.Name = "PurWarrNoDataGridViewTextBoxColumn"
        Me.PurWarrNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurWarrNoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'PurDateDataGridViewTextBoxColumn
        '
        Me.PurDateDataGridViewTextBoxColumn.DataPropertyName = "PurDate"
        Me.PurDateDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.PurDateDataGridViewTextBoxColumn.HeaderText = "Purchase Date"
        Me.PurDateDataGridViewTextBoxColumn.Name = "PurDateDataGridViewTextBoxColumn"
        Me.PurDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'PurProdNameDataGridViewTextBoxColumn
        '
        Me.PurProdNameDataGridViewTextBoxColumn.DataPropertyName = "PurProdName"
        Me.PurProdNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.PurProdNameDataGridViewTextBoxColumn.Name = "PurProdNameDataGridViewTextBoxColumn"
        Me.PurProdNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurProdNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'PurDevStatusDataGridViewTextBoxColumn
        '
        Me.PurDevStatusDataGridViewTextBoxColumn.DataPropertyName = "PurDevStatus"
        Me.PurDevStatusDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.PurDevStatusDataGridViewTextBoxColumn.HeaderText = "Delivery Status"
        Me.PurDevStatusDataGridViewTextBoxColumn.Name = "PurDevStatusDataGridViewTextBoxColumn"
        Me.PurDevStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurDevStatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'PurIDDataGridViewTextBoxColumn
        '
        Me.PurIDDataGridViewTextBoxColumn.DataPropertyName = "PurID"
        Me.PurIDDataGridViewTextBoxColumn.HeaderText = "PurID"
        Me.PurIDDataGridViewTextBoxColumn.Name = "PurIDDataGridViewTextBoxColumn"
        Me.PurIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurIDDataGridViewTextBoxColumn.Visible = False
        '
        'PurMemIDDataGridViewTextBoxColumn
        '
        Me.PurMemIDDataGridViewTextBoxColumn.DataPropertyName = "PurMemID"
        Me.PurMemIDDataGridViewTextBoxColumn.HeaderText = "PurMemID"
        Me.PurMemIDDataGridViewTextBoxColumn.Name = "PurMemIDDataGridViewTextBoxColumn"
        Me.PurMemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurMemIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurMemIDDataGridViewTextBoxColumn.Visible = False
        '
        'PurSDateDataGridViewTextBoxColumn
        '
        Me.PurSDateDataGridViewTextBoxColumn.DataPropertyName = "PurSDate"
        Me.PurSDateDataGridViewTextBoxColumn.HeaderText = "PurSDate"
        Me.PurSDateDataGridViewTextBoxColumn.Name = "PurSDateDataGridViewTextBoxColumn"
        Me.PurSDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurSDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurSDateDataGridViewTextBoxColumn.Visible = False
        '
        'PurEDateDataGridViewTextBoxColumn
        '
        Me.PurEDateDataGridViewTextBoxColumn.DataPropertyName = "PurEDate"
        Me.PurEDateDataGridViewTextBoxColumn.HeaderText = "PurEDate"
        Me.PurEDateDataGridViewTextBoxColumn.Name = "PurEDateDataGridViewTextBoxColumn"
        Me.PurEDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurEDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurEDateDataGridViewTextBoxColumn.Visible = False
        '
        'PurHisDataGridViewTextBoxColumn
        '
        Me.PurHisDataGridViewTextBoxColumn.DataPropertyName = "PurHis"
        Me.PurHisDataGridViewTextBoxColumn.HeaderText = "PurHis"
        Me.PurHisDataGridViewTextBoxColumn.Name = "PurHisDataGridViewTextBoxColumn"
        Me.PurHisDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurHisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurHisDataGridViewTextBoxColumn.Visible = False
        '
        'PurLockUserDataGridViewTextBoxColumn
        '
        Me.PurLockUserDataGridViewTextBoxColumn.DataPropertyName = "PurLockUser"
        Me.PurLockUserDataGridViewTextBoxColumn.HeaderText = "PurLockUser"
        Me.PurLockUserDataGridViewTextBoxColumn.Name = "PurLockUserDataGridViewTextBoxColumn"
        Me.PurLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurLockUserDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'PurLockDataGridViewCheckBoxColumn
        '
        Me.PurLockDataGridViewCheckBoxColumn.DataPropertyName = "PurLock"
        Me.PurLockDataGridViewCheckBoxColumn.HeaderText = "PurLock"
        Me.PurLockDataGridViewCheckBoxColumn.Name = "PurLockDataGridViewCheckBoxColumn"
        Me.PurLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PurLockDataGridViewCheckBoxColumn.Visible = False
        '
        'PurSaveDataGridViewCheckBoxColumn
        '
        Me.PurSaveDataGridViewCheckBoxColumn.DataPropertyName = "PurSave"
        Me.PurSaveDataGridViewCheckBoxColumn.HeaderText = "PurSave"
        Me.PurSaveDataGridViewCheckBoxColumn.Name = "PurSaveDataGridViewCheckBoxColumn"
        Me.PurSaveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.PurSaveDataGridViewCheckBoxColumn.Visible = False
        '
        'PurAmtDataGridViewTextBoxColumn
        '
        Me.PurAmtDataGridViewTextBoxColumn.DataPropertyName = "PurAmt"
        Me.PurAmtDataGridViewTextBoxColumn.HeaderText = "PurAmt"
        Me.PurAmtDataGridViewTextBoxColumn.Name = "PurAmtDataGridViewTextBoxColumn"
        Me.PurAmtDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurAmtDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurAmtDataGridViewTextBoxColumn.Visible = False
        '
        'PurQtyDataGridViewTextBoxColumn
        '
        Me.PurQtyDataGridViewTextBoxColumn.DataPropertyName = "PurQty"
        Me.PurQtyDataGridViewTextBoxColumn.HeaderText = "PurQty"
        Me.PurQtyDataGridViewTextBoxColumn.Name = "PurQtyDataGridViewTextBoxColumn"
        Me.PurQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurQtyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurQtyDataGridViewTextBoxColumn.Visible = False
        '
        'PurProdIDDataGridViewTextBoxColumn
        '
        Me.PurProdIDDataGridViewTextBoxColumn.DataPropertyName = "PurProdID"
        Me.PurProdIDDataGridViewTextBoxColumn.HeaderText = "PurProdID"
        Me.PurProdIDDataGridViewTextBoxColumn.Name = "PurProdIDDataGridViewTextBoxColumn"
        Me.PurProdIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurProdIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurProdIDDataGridViewTextBoxColumn.Visible = False
        '
        'PurCreditDataGridViewTextBoxColumn
        '
        Me.PurCreditDataGridViewTextBoxColumn.DataPropertyName = "PurCredit"
        Me.PurCreditDataGridViewTextBoxColumn.HeaderText = "PurCredit"
        Me.PurCreditDataGridViewTextBoxColumn.Name = "PurCreditDataGridViewTextBoxColumn"
        Me.PurCreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurCreditDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurCreditDataGridViewTextBoxColumn.Visible = False
        '
        'PurDepoDateDataGridViewTextBoxColumn
        '
        Me.PurDepoDateDataGridViewTextBoxColumn.DataPropertyName = "PurDepoDate"
        Me.PurDepoDateDataGridViewTextBoxColumn.HeaderText = "PurDepoDate"
        Me.PurDepoDateDataGridViewTextBoxColumn.Name = "PurDepoDateDataGridViewTextBoxColumn"
        Me.PurDepoDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurDepoDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurDepoDateDataGridViewTextBoxColumn.Visible = False
        '
        'PurRemarkDataGridViewTextBoxColumn
        '
        Me.PurRemarkDataGridViewTextBoxColumn.DataPropertyName = "PurRemark"
        Me.PurRemarkDataGridViewTextBoxColumn.HeaderText = "PurRemark"
        Me.PurRemarkDataGridViewTextBoxColumn.Name = "PurRemarkDataGridViewTextBoxColumn"
        Me.PurRemarkDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurRemarkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PurRemarkDataGridViewTextBoxColumn.Visible = False
        '
        'MemPurchaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.MemPurchaseCancelBtn
        Me.ClientSize = New System.Drawing.Size(989, 510)
        Me.Controls.Add(Me.PurSearchDataGridView)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.MemPurchaseCancelBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MemPurchaseForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Search"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.PurSearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MemPurchaseContextMenuStrip.ResumeLayout(False)
        CType(Me.PurTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurSearchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents PurTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.PurTblTableAdapter
    Friend WithEvents MemPurchaseContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemPurchaseCancelBtn As System.Windows.Forms.Button
    Friend WithEvents PurOrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurWarrNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurDevStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurMemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurSDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurEDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurHisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PurSaveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PurAmtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurProdIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurCreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurDepoDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurRemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
