<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSearchForm
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
        Me.MenuSearchMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSearchDataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuLockUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.MenuTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.MenuTblTableAdapter()
        Me.MenuSearchContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSearchCancelBtn = New System.Windows.Forms.Button()
        Me.MenuSearchMenuStrip.SuspendLayout()
        CType(Me.MenuSearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuSearchContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuSearchMenuStrip
        '
        Me.MenuSearchMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RefreshToolStripMenuItem2})
        Me.MenuSearchMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuSearchMenuStrip.Name = "MenuSearchMenuStrip"
        Me.MenuSearchMenuStrip.Size = New System.Drawing.Size(327, 24)
        Me.MenuSearchMenuStrip.TabIndex = 0
        Me.MenuSearchMenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ExiToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ExiToolStripMenuItem
        '
        Me.ExiToolStripMenuItem.Name = "ExiToolStripMenuItem"
        Me.ExiToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExiToolStripMenuItem.Text = "Exit"
        '
        'RefreshToolStripMenuItem2
        '
        Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
        Me.RefreshToolStripMenuItem2.Size = New System.Drawing.Size(58, 20)
        Me.RefreshToolStripMenuItem2.Text = "Refresh"
        '
        'MenuSearchDataGridView
        '
        Me.MenuSearchDataGridView.AllowUserToAddRows = False
        Me.MenuSearchDataGridView.AllowUserToDeleteRows = False
        Me.MenuSearchDataGridView.AutoGenerateColumns = False
        Me.MenuSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuSearchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn, Me.MenuNameDataGridViewTextBoxColumn, Me.MenuDescDataGridViewTextBoxColumn, Me.MenuProdNameDataGridViewTextBoxColumn, Me.MenuCredit, Me.MenuLockDataGridViewCheckBoxColumn, Me.MenuLockUser})
        Me.MenuSearchDataGridView.DataSource = Me.MenuTblBindingSource
        Me.MenuSearchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuSearchDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.MenuSearchDataGridView.Name = "MenuSearchDataGridView"
        Me.MenuSearchDataGridView.ReadOnly = True
        Me.MenuSearchDataGridView.Size = New System.Drawing.Size(327, 502)
        Me.MenuSearchDataGridView.TabIndex = 2
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
        Me.MenuNameDataGridViewTextBoxColumn.HeaderText = "MenuName"
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
        'MenuCredit
        '
        Me.MenuCredit.DataPropertyName = "MenuCredit"
        Me.MenuCredit.HeaderText = "MenuCredit"
        Me.MenuCredit.Name = "MenuCredit"
        Me.MenuCredit.ReadOnly = True
        Me.MenuCredit.Visible = False
        '
        'MenuLockDataGridViewCheckBoxColumn
        '
        Me.MenuLockDataGridViewCheckBoxColumn.DataPropertyName = "MenuLock"
        Me.MenuLockDataGridViewCheckBoxColumn.HeaderText = "MenuLock"
        Me.MenuLockDataGridViewCheckBoxColumn.Name = "MenuLockDataGridViewCheckBoxColumn"
        Me.MenuLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.MenuLockDataGridViewCheckBoxColumn.Visible = False
        '
        'MenuLockUser
        '
        Me.MenuLockUser.DataPropertyName = "MenuLockUser"
        Me.MenuLockUser.HeaderText = "MenuLockUser"
        Me.MenuLockUser.Name = "MenuLockUser"
        Me.MenuLockUser.ReadOnly = True
        Me.MenuLockUser.Visible = False
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
        'MenuSearchContextMenuStrip
        '
        Me.MenuSearchContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem1, Me.RefreshToolStripMenuItem1, Me.DeleteToolStripMenuItem1})
        Me.MenuSearchContextMenuStrip.Name = "MenuSearchContextMenuStrip"
        Me.MenuSearchContextMenuStrip.Size = New System.Drawing.Size(114, 70)
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'RefreshToolStripMenuItem1
        '
        Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
        Me.RefreshToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.RefreshToolStripMenuItem1.Text = "Refresh"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'MenuSearchCancelBtn
        '
        Me.MenuSearchCancelBtn.Location = New System.Drawing.Point(226, 454)
        Me.MenuSearchCancelBtn.Name = "MenuSearchCancelBtn"
        Me.MenuSearchCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.MenuSearchCancelBtn.TabIndex = 3
        Me.MenuSearchCancelBtn.Text = "Cancel"
        Me.MenuSearchCancelBtn.UseVisualStyleBackColor = True
        '
        'MenuSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.MenuSearchCancelBtn
        Me.ClientSize = New System.Drawing.Size(327, 526)
        Me.ContextMenuStrip = Me.MenuSearchContextMenuStrip
        Me.Controls.Add(Me.MenuSearchDataGridView)
        Me.Controls.Add(Me.MenuSearchCancelBtn)
        Me.Controls.Add(Me.MenuSearchMenuStrip)
        Me.MainMenuStrip = Me.MenuSearchMenuStrip
        Me.Name = "MenuSearchForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Search"
        Me.MenuSearchMenuStrip.ResumeLayout(False)
        Me.MenuSearchMenuStrip.PerformLayout()
        CType(Me.MenuSearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuSearchContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuSearchMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuSearchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents MenuTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.MenuTblTableAdapter
    Friend WithEvents MenuSearchContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuDescDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuLockUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuSearchCancelBtn As System.Windows.Forms.Button
End Class
