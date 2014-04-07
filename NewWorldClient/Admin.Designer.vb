<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.AdminDataGridView = New System.Windows.Forms.DataGridView()
        Me.RootIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootPwDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootFirstLogDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RootTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RootLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.RootTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.RootTblTableAdapter()
        Me.NewUserBtn = New System.Windows.Forms.Button()
        Me.ResetPwBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RootTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminDataGridView
        '
        Me.AdminDataGridView.AllowUserToAddRows = False
        Me.AdminDataGridView.AllowUserToDeleteRows = False
        Me.AdminDataGridView.AutoGenerateColumns = False
        Me.AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RootIDDataGridViewTextBoxColumn, Me.RootNameDataGridViewTextBoxColumn, Me.RootPwDataGridViewTextBoxColumn, Me.RootFirstLogDataGridViewCheckBoxColumn, Me.RootTypeDataGridViewTextBoxColumn, Me.RootLockDataGridViewCheckBoxColumn, Me.RootLockUserDataGridViewTextBoxColumn})
        Me.AdminDataGridView.DataSource = Me.RootTblBindingSource
        Me.AdminDataGridView.Location = New System.Drawing.Point(173, 21)
        Me.AdminDataGridView.Name = "AdminDataGridView"
        Me.AdminDataGridView.ReadOnly = True
        Me.AdminDataGridView.Size = New System.Drawing.Size(275, 379)
        Me.AdminDataGridView.TabIndex = 0
        '
        'RootIDDataGridViewTextBoxColumn
        '
        Me.RootIDDataGridViewTextBoxColumn.DataPropertyName = "RootID"
        Me.RootIDDataGridViewTextBoxColumn.HeaderText = "RootID"
        Me.RootIDDataGridViewTextBoxColumn.Name = "RootIDDataGridViewTextBoxColumn"
        Me.RootIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.RootIDDataGridViewTextBoxColumn.Visible = False
        '
        'RootNameDataGridViewTextBoxColumn
        '
        Me.RootNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RootNameDataGridViewTextBoxColumn.DataPropertyName = "RootName"
        Me.RootNameDataGridViewTextBoxColumn.HeaderText = "User Login ID"
        Me.RootNameDataGridViewTextBoxColumn.Name = "RootNameDataGridViewTextBoxColumn"
        Me.RootNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RootPwDataGridViewTextBoxColumn
        '
        Me.RootPwDataGridViewTextBoxColumn.DataPropertyName = "RootPw"
        Me.RootPwDataGridViewTextBoxColumn.HeaderText = "RootPw"
        Me.RootPwDataGridViewTextBoxColumn.Name = "RootPwDataGridViewTextBoxColumn"
        Me.RootPwDataGridViewTextBoxColumn.ReadOnly = True
        Me.RootPwDataGridViewTextBoxColumn.Visible = False
        '
        'RootFirstLogDataGridViewCheckBoxColumn
        '
        Me.RootFirstLogDataGridViewCheckBoxColumn.DataPropertyName = "RootFirstLog"
        Me.RootFirstLogDataGridViewCheckBoxColumn.HeaderText = "RootFirstLog"
        Me.RootFirstLogDataGridViewCheckBoxColumn.Name = "RootFirstLogDataGridViewCheckBoxColumn"
        Me.RootFirstLogDataGridViewCheckBoxColumn.ReadOnly = True
        Me.RootFirstLogDataGridViewCheckBoxColumn.Visible = False
        '
        'RootTypeDataGridViewTextBoxColumn
        '
        Me.RootTypeDataGridViewTextBoxColumn.DataPropertyName = "RootType"
        Me.RootTypeDataGridViewTextBoxColumn.HeaderText = "Account Type"
        Me.RootTypeDataGridViewTextBoxColumn.Name = "RootTypeDataGridViewTextBoxColumn"
        Me.RootTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RootLockDataGridViewCheckBoxColumn
        '
        Me.RootLockDataGridViewCheckBoxColumn.DataPropertyName = "RootLock"
        Me.RootLockDataGridViewCheckBoxColumn.HeaderText = "RootLock"
        Me.RootLockDataGridViewCheckBoxColumn.Name = "RootLockDataGridViewCheckBoxColumn"
        Me.RootLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.RootLockDataGridViewCheckBoxColumn.Visible = False
        '
        'RootLockUserDataGridViewTextBoxColumn
        '
        Me.RootLockUserDataGridViewTextBoxColumn.DataPropertyName = "RootLockUser"
        Me.RootLockUserDataGridViewTextBoxColumn.HeaderText = "RootLockUser"
        Me.RootLockUserDataGridViewTextBoxColumn.Name = "RootLockUserDataGridViewTextBoxColumn"
        Me.RootLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.RootLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'RootTblBindingSource
        '
        Me.RootTblBindingSource.DataMember = "RootTbl"
        Me.RootTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RootTblTableAdapter
        '
        Me.RootTblTableAdapter.ClearBeforeFill = True
        '
        'NewUserBtn
        '
        Me.NewUserBtn.Location = New System.Drawing.Point(21, 21)
        Me.NewUserBtn.Name = "NewUserBtn"
        Me.NewUserBtn.Size = New System.Drawing.Size(134, 34)
        Me.NewUserBtn.TabIndex = 1
        Me.NewUserBtn.Text = "New User"
        Me.NewUserBtn.UseVisualStyleBackColor = True
        '
        'ResetPwBtn
        '
        Me.ResetPwBtn.Location = New System.Drawing.Point(21, 61)
        Me.ResetPwBtn.Name = "ResetPwBtn"
        Me.ResetPwBtn.Size = New System.Drawing.Size(134, 34)
        Me.ResetPwBtn.TabIndex = 2
        Me.ResetPwBtn.Text = "Reset Password"
        Me.ResetPwBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.Location = New System.Drawing.Point(373, 425)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 4
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(21, 101)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(134, 34)
        Me.DelBtn.TabIndex = 5
        Me.DelBtn.Text = "Delete User"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseBtn
        Me.ClientSize = New System.Drawing.Size(467, 460)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.ResetPwBtn)
        Me.Controls.Add(Me.NewUserBtn)
        Me.Controls.Add(Me.AdminDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administration"
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RootTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AdminDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents RootTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RootTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.RootTblTableAdapter
    Friend WithEvents NewUserBtn As System.Windows.Forms.Button
    Friend WithEvents ResetPwBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents DelBtn As System.Windows.Forms.Button
    Friend WithEvents RootIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RootNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RootPwDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RootFirstLogDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RootTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RootLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RootLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
