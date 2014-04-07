<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdSearchForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ProdSearchMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElectricToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NutritionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdSearchDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProdTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.ProdTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter()
        Me.ProdSearchContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdSearchFormCancelBtn = New System.Windows.Forms.Button()
        Me.ProdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdWarrantyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdLockUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdSearchMenuStrip.SuspendLayout()
        CType(Me.ProdSearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdSearchContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProdSearchMenuStrip
        '
        Me.ProdSearchMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FilterToolStripMenuItem, Me.RefreshToolStripMenuItem1})
        Me.ProdSearchMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ProdSearchMenuStrip.Name = "ProdSearchMenuStrip"
        Me.ProdSearchMenuStrip.Size = New System.Drawing.Size(1052, 24)
        Me.ProdSearchMenuStrip.TabIndex = 1
        Me.ProdSearchMenuStrip.Text = "ProdSearchMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
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
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Delete"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CookingToolStripMenuItem, Me.ElectricToolStripMenuItem, Me.NutritionToolStripMenuItem})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'CookingToolStripMenuItem
        '
        Me.CookingToolStripMenuItem.Name = "CookingToolStripMenuItem"
        Me.CookingToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CookingToolStripMenuItem.Text = "Cooking"
        '
        'ElectricToolStripMenuItem
        '
        Me.ElectricToolStripMenuItem.Name = "ElectricToolStripMenuItem"
        Me.ElectricToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ElectricToolStripMenuItem.Text = "Electric"
        '
        'NutritionToolStripMenuItem
        '
        Me.NutritionToolStripMenuItem.Name = "NutritionToolStripMenuItem"
        Me.NutritionToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.NutritionToolStripMenuItem.Text = "Nutrition"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'ProdSearchDataGridView
        '
        Me.ProdSearchDataGridView.AllowUserToAddRows = False
        Me.ProdSearchDataGridView.AllowUserToDeleteRows = False
        Me.ProdSearchDataGridView.AutoGenerateColumns = False
        Me.ProdSearchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProdSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdSearchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdIDDataGridViewTextBoxColumn, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdPriceDataGridViewTextBoxColumn, Me.ProdWarrantyDataGridViewTextBoxColumn, Me.ProdCat, Me.ProdCredit, Me.ProdLockDataGridViewCheckBoxColumn, Me.ProdLockUser})
        Me.ProdSearchDataGridView.DataSource = Me.ProdTblBindingSource
        Me.ProdSearchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdSearchDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.ProdSearchDataGridView.Name = "ProdSearchDataGridView"
        Me.ProdSearchDataGridView.ReadOnly = True
        Me.ProdSearchDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ProdSearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProdSearchDataGridView.Size = New System.Drawing.Size(1052, 486)
        Me.ProdSearchDataGridView.TabIndex = 2
        '
        'ProdTblBindingSource
        '
        Me.ProdTblBindingSource.DataMember = "ProdTbl"
        Me.ProdTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdTblTableAdapter
        '
        Me.ProdTblTableAdapter.ClearBeforeFill = True
        '
        'ProdSearchContextMenuStrip
        '
        Me.ProdSearchContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.RefreshToolStripMenuItem, Me.DeleteToolStripMenuItem1})
        Me.ProdSearchContextMenuStrip.Name = "ProdSearchContextMenuStrip"
        Me.ProdSearchContextMenuStrip.Size = New System.Drawing.Size(114, 70)
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'ProdSearchFormCancelBtn
        '
        Me.ProdSearchFormCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ProdSearchFormCancelBtn.Location = New System.Drawing.Point(665, 465)
        Me.ProdSearchFormCancelBtn.Name = "ProdSearchFormCancelBtn"
        Me.ProdSearchFormCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.ProdSearchFormCancelBtn.TabIndex = 3
        Me.ProdSearchFormCancelBtn.Text = "Cancel"
        Me.ProdSearchFormCancelBtn.UseVisualStyleBackColor = True
        '
        'ProdIDDataGridViewTextBoxColumn
        '
        Me.ProdIDDataGridViewTextBoxColumn.DataPropertyName = "ProdID"
        Me.ProdIDDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.ProdIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProdIDDataGridViewTextBoxColumn.Name = "ProdIDDataGridViewTextBoxColumn"
        Me.ProdIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdNameDataGridViewTextBoxColumn
        '
        Me.ProdNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName"
        Me.ProdNameDataGridViewTextBoxColumn.FillWeight = 180.0!
        Me.ProdNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProdNameDataGridViewTextBoxColumn.Name = "ProdNameDataGridViewTextBoxColumn"
        Me.ProdNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdPriceDataGridViewTextBoxColumn
        '
        Me.ProdPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ProdPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ProdPriceDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.ProdPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.ProdPriceDataGridViewTextBoxColumn.Name = "ProdPriceDataGridViewTextBoxColumn"
        Me.ProdPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdWarrantyDataGridViewTextBoxColumn
        '
        Me.ProdWarrantyDataGridViewTextBoxColumn.DataPropertyName = "ProdWarranty"
        Me.ProdWarrantyDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.ProdWarrantyDataGridViewTextBoxColumn.HeaderText = "Warranty Period"
        Me.ProdWarrantyDataGridViewTextBoxColumn.Name = "ProdWarrantyDataGridViewTextBoxColumn"
        Me.ProdWarrantyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdCat
        '
        Me.ProdCat.DataPropertyName = "ProdCat"
        Me.ProdCat.HeaderText = "Product Category"
        Me.ProdCat.Name = "ProdCat"
        Me.ProdCat.ReadOnly = True
        '
        'ProdCredit
        '
        Me.ProdCredit.DataPropertyName = "ProdCredit"
        Me.ProdCredit.FillWeight = 80.0!
        Me.ProdCredit.HeaderText = "Class Credit"
        Me.ProdCredit.Name = "ProdCredit"
        Me.ProdCredit.ReadOnly = True
        '
        'ProdLockDataGridViewCheckBoxColumn
        '
        Me.ProdLockDataGridViewCheckBoxColumn.DataPropertyName = "ProdLock"
        Me.ProdLockDataGridViewCheckBoxColumn.HeaderText = "ProdLock"
        Me.ProdLockDataGridViewCheckBoxColumn.Name = "ProdLockDataGridViewCheckBoxColumn"
        Me.ProdLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProdLockDataGridViewCheckBoxColumn.Visible = False
        '
        'ProdLockUser
        '
        Me.ProdLockUser.DataPropertyName = "ProdLockUser"
        Me.ProdLockUser.HeaderText = "ProdLockUser"
        Me.ProdLockUser.Name = "ProdLockUser"
        Me.ProdLockUser.ReadOnly = True
        Me.ProdLockUser.Visible = False
        '
        'ProdSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ProdSearchFormCancelBtn
        Me.ClientSize = New System.Drawing.Size(1052, 510)
        Me.ContextMenuStrip = Me.ProdSearchContextMenuStrip
        Me.Controls.Add(Me.ProdSearchDataGridView)
        Me.Controls.Add(Me.ProdSearchFormCancelBtn)
        Me.Controls.Add(Me.ProdSearchMenuStrip)
        Me.MainMenuStrip = Me.ProdSearchMenuStrip
        Me.Name = "ProdSearchForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Search"
        Me.ProdSearchMenuStrip.ResumeLayout(False)
        Me.ProdSearchMenuStrip.PerformLayout()
        CType(Me.ProdSearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdSearchContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProdSearchMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ProdSearchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents ProdTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdSearchContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElectricToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NutritionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdSearchFormCancelBtn As System.Windows.Forms.Button
    Friend WithEvents ProdIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdWarrantyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdCat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ProdLockUser As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
