<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProdLookupform
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
        Me.PurProdLookupDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElectricToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NutritionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdLookupDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdWarrantyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdCreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProdTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.ProdTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter()
        Me.ProdLookupFormCancelBtn = New System.Windows.Forms.Button()
        CType(Me.PurProdLookupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.ProdLookupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurProdLookupDataGridView
        '
        Me.PurProdLookupDataGridView.AllowUserToAddRows = False
        Me.PurProdLookupDataGridView.AllowUserToDeleteRows = False
        Me.PurProdLookupDataGridView.AutoGenerateColumns = False
        Me.PurProdLookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurProdLookupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PurProdLookupDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PurProdLookupDataGridView.Name = "PurProdLookupDataGridView"
        Me.PurProdLookupDataGridView.ReadOnly = True
        Me.PurProdLookupDataGridView.Size = New System.Drawing.Size(284, 519)
        Me.PurProdLookupDataGridView.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FilterToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(375, 24)
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
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
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
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ProdLookupDataGridView
        '
        Me.ProdLookupDataGridView.AllowUserToAddRows = False
        Me.ProdLookupDataGridView.AllowUserToDeleteRows = False
        Me.ProdLookupDataGridView.AutoGenerateColumns = False
        Me.ProdLookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdLookupDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProdIDDataGridViewTextBoxColumn, Me.ProdNameDataGridViewTextBoxColumn, Me.ProdPriceDataGridViewTextBoxColumn, Me.ProdWarrantyDataGridViewTextBoxColumn, Me.ProdLockUserDataGridViewTextBoxColumn, Me.ProdCatDataGridViewTextBoxColumn, Me.ProdCreditDataGridViewTextBoxColumn, Me.ProdLockDataGridViewCheckBoxColumn})
        Me.ProdLookupDataGridView.DataSource = Me.ProdTblBindingSource
        Me.ProdLookupDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdLookupDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.ProdLookupDataGridView.Name = "ProdLookupDataGridView"
        Me.ProdLookupDataGridView.ReadOnly = True
        Me.ProdLookupDataGridView.Size = New System.Drawing.Size(375, 526)
        Me.ProdLookupDataGridView.TabIndex = 2
        '
        'ProdIDDataGridViewTextBoxColumn
        '
        Me.ProdIDDataGridViewTextBoxColumn.DataPropertyName = "ProdID"
        Me.ProdIDDataGridViewTextBoxColumn.HeaderText = "ProdID"
        Me.ProdIDDataGridViewTextBoxColumn.Name = "ProdIDDataGridViewTextBoxColumn"
        Me.ProdIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdIDDataGridViewTextBoxColumn.Visible = False
        '
        'ProdNameDataGridViewTextBoxColumn
        '
        Me.ProdNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProdNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName"
        Me.ProdNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProdNameDataGridViewTextBoxColumn.Name = "ProdNameDataGridViewTextBoxColumn"
        Me.ProdNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProdPriceDataGridViewTextBoxColumn
        '
        Me.ProdPriceDataGridViewTextBoxColumn.DataPropertyName = "ProdPrice"
        Me.ProdPriceDataGridViewTextBoxColumn.HeaderText = "ProdPrice"
        Me.ProdPriceDataGridViewTextBoxColumn.Name = "ProdPriceDataGridViewTextBoxColumn"
        Me.ProdPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdPriceDataGridViewTextBoxColumn.Visible = False
        '
        'ProdWarrantyDataGridViewTextBoxColumn
        '
        Me.ProdWarrantyDataGridViewTextBoxColumn.DataPropertyName = "ProdWarranty"
        Me.ProdWarrantyDataGridViewTextBoxColumn.HeaderText = "ProdWarranty"
        Me.ProdWarrantyDataGridViewTextBoxColumn.Name = "ProdWarrantyDataGridViewTextBoxColumn"
        Me.ProdWarrantyDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdWarrantyDataGridViewTextBoxColumn.Visible = False
        '
        'ProdLockUserDataGridViewTextBoxColumn
        '
        Me.ProdLockUserDataGridViewTextBoxColumn.DataPropertyName = "ProdLockUser"
        Me.ProdLockUserDataGridViewTextBoxColumn.HeaderText = "ProdLockUser"
        Me.ProdLockUserDataGridViewTextBoxColumn.Name = "ProdLockUserDataGridViewTextBoxColumn"
        Me.ProdLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'ProdCatDataGridViewTextBoxColumn
        '
        Me.ProdCatDataGridViewTextBoxColumn.DataPropertyName = "ProdCat"
        Me.ProdCatDataGridViewTextBoxColumn.HeaderText = "ProdCat"
        Me.ProdCatDataGridViewTextBoxColumn.Name = "ProdCatDataGridViewTextBoxColumn"
        Me.ProdCatDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdCatDataGridViewTextBoxColumn.Visible = False
        '
        'ProdCreditDataGridViewTextBoxColumn
        '
        Me.ProdCreditDataGridViewTextBoxColumn.DataPropertyName = "ProdCredit"
        Me.ProdCreditDataGridViewTextBoxColumn.HeaderText = "ProdCredit"
        Me.ProdCreditDataGridViewTextBoxColumn.Name = "ProdCreditDataGridViewTextBoxColumn"
        Me.ProdCreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProdCreditDataGridViewTextBoxColumn.Visible = False
        '
        'ProdLockDataGridViewCheckBoxColumn
        '
        Me.ProdLockDataGridViewCheckBoxColumn.DataPropertyName = "ProdLock"
        Me.ProdLockDataGridViewCheckBoxColumn.HeaderText = "ProdLock"
        Me.ProdLockDataGridViewCheckBoxColumn.Name = "ProdLockDataGridViewCheckBoxColumn"
        Me.ProdLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ProdLockDataGridViewCheckBoxColumn.Visible = False
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
        'ProdLookupFormCancelBtn
        '
        Me.ProdLookupFormCancelBtn.Location = New System.Drawing.Point(288, 497)
        Me.ProdLookupFormCancelBtn.Name = "ProdLookupFormCancelBtn"
        Me.ProdLookupFormCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.ProdLookupFormCancelBtn.TabIndex = 3
        Me.ProdLookupFormCancelBtn.Text = "Cancel"
        Me.ProdLookupFormCancelBtn.UseVisualStyleBackColor = True
        '
        'ProdLookupform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ProdLookupFormCancelBtn
        Me.ClientSize = New System.Drawing.Size(375, 550)
        Me.Controls.Add(Me.ProdLookupDataGridView)
        Me.Controls.Add(Me.ProdLookupFormCancelBtn)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProdLookupform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Lookup"
        CType(Me.PurProdLookupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.ProdLookupDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PurProdLookupDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdLookupDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents ProdTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter
    Friend WithEvents ProdIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdWarrantyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdCatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdCreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElectricToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NutritionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdLookupFormCancelBtn As System.Windows.Forms.Button
End Class
