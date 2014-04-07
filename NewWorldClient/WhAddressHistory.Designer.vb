<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhAddressHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhAddressHistory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.WhCusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhCusNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhCusAddDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhCusCtcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhCusLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhCusLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhCusTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.WhAddHistoryTextBox = New System.Windows.Forms.TextBox()
        Me.WhAddHistoryNewBtn = New System.Windows.Forms.Button()
        Me.WhAddHistoryOKBtn = New System.Windows.Forms.Button()
        Me.WhAddhistoryCancelBtn = New System.Windows.Forms.Button()
        Me.WhCusTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.WhCusTblTableAdapter()
        Me.WhAddHistoryResetBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AddHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhCusTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find Delivery Location (搜寻店名):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddHistoryDataGridView)
        Me.GroupBox1.Controls.Add(Me.WhAddHistoryTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 526)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address History"
        '
        'AddHistoryDataGridView
        '
        Me.AddHistoryDataGridView.AllowUserToAddRows = False
        Me.AddHistoryDataGridView.AllowUserToDeleteRows = False
        Me.AddHistoryDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddHistoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AddHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WhCusIDDataGridViewTextBoxColumn, Me.WhCusNameDataGridViewTextBoxColumn, Me.WhCusAddDataGridViewTextBoxColumn, Me.WhCusCtcDataGridViewTextBoxColumn, Me.WhCusLockUserDataGridViewTextBoxColumn, Me.WhCusLockDataGridViewCheckBoxColumn})
        Me.AddHistoryDataGridView.DataSource = Me.WhCusTblBindingSource
        Me.AddHistoryDataGridView.Location = New System.Drawing.Point(22, 85)
        Me.AddHistoryDataGridView.Name = "AddHistoryDataGridView"
        Me.AddHistoryDataGridView.ReadOnly = True
        Me.AddHistoryDataGridView.Size = New System.Drawing.Size(611, 409)
        Me.AddHistoryDataGridView.TabIndex = 2
        '
        'WhCusIDDataGridViewTextBoxColumn
        '
        Me.WhCusIDDataGridViewTextBoxColumn.DataPropertyName = "WhCusID"
        Me.WhCusIDDataGridViewTextBoxColumn.HeaderText = "WhCusID"
        Me.WhCusIDDataGridViewTextBoxColumn.Name = "WhCusIDDataGridViewTextBoxColumn"
        Me.WhCusIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhCusIDDataGridViewTextBoxColumn.Visible = False
        '
        'WhCusNameDataGridViewTextBoxColumn
        '
        Me.WhCusNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WhCusNameDataGridViewTextBoxColumn.DataPropertyName = "WhCusName"
        Me.WhCusNameDataGridViewTextBoxColumn.HeaderText = "Delivery Location/Outlet Name"
        Me.WhCusNameDataGridViewTextBoxColumn.Name = "WhCusNameDataGridViewTextBoxColumn"
        Me.WhCusNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhCusAddDataGridViewTextBoxColumn
        '
        Me.WhCusAddDataGridViewTextBoxColumn.DataPropertyName = "WhCusAdd"
        Me.WhCusAddDataGridViewTextBoxColumn.HeaderText = "WhCusAdd"
        Me.WhCusAddDataGridViewTextBoxColumn.Name = "WhCusAddDataGridViewTextBoxColumn"
        Me.WhCusAddDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhCusAddDataGridViewTextBoxColumn.Visible = False
        '
        'WhCusCtcDataGridViewTextBoxColumn
        '
        Me.WhCusCtcDataGridViewTextBoxColumn.DataPropertyName = "WhCusCtc"
        Me.WhCusCtcDataGridViewTextBoxColumn.HeaderText = "WhCusCtc"
        Me.WhCusCtcDataGridViewTextBoxColumn.Name = "WhCusCtcDataGridViewTextBoxColumn"
        Me.WhCusCtcDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhCusCtcDataGridViewTextBoxColumn.Visible = False
        '
        'WhCusLockUserDataGridViewTextBoxColumn
        '
        Me.WhCusLockUserDataGridViewTextBoxColumn.DataPropertyName = "WhCusLockUser"
        Me.WhCusLockUserDataGridViewTextBoxColumn.HeaderText = "WhCusLockUser"
        Me.WhCusLockUserDataGridViewTextBoxColumn.Name = "WhCusLockUserDataGridViewTextBoxColumn"
        Me.WhCusLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhCusLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'WhCusLockDataGridViewCheckBoxColumn
        '
        Me.WhCusLockDataGridViewCheckBoxColumn.DataPropertyName = "WhCusLock"
        Me.WhCusLockDataGridViewCheckBoxColumn.HeaderText = "WhCusLock"
        Me.WhCusLockDataGridViewCheckBoxColumn.Name = "WhCusLockDataGridViewCheckBoxColumn"
        Me.WhCusLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.WhCusLockDataGridViewCheckBoxColumn.Visible = False
        '
        'WhCusTblBindingSource
        '
        Me.WhCusTblBindingSource.DataMember = "WhCusTbl"
        Me.WhCusTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WhAddHistoryTextBox
        '
        Me.WhAddHistoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddHistoryTextBox.Location = New System.Drawing.Point(22, 53)
        Me.WhAddHistoryTextBox.Name = "WhAddHistoryTextBox"
        Me.WhAddHistoryTextBox.Size = New System.Drawing.Size(611, 26)
        Me.WhAddHistoryTextBox.TabIndex = 1
        '
        'WhAddHistoryNewBtn
        '
        Me.WhAddHistoryNewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddHistoryNewBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Document_search_icon
        Me.WhAddHistoryNewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddHistoryNewBtn.Location = New System.Drawing.Point(12, 12)
        Me.WhAddHistoryNewBtn.Name = "WhAddHistoryNewBtn"
        Me.WhAddHistoryNewBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddHistoryNewBtn.TabIndex = 11
        Me.WhAddHistoryNewBtn.Text = "Find"
        Me.WhAddHistoryNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddHistoryNewBtn.UseVisualStyleBackColor = True
        '
        'WhAddHistoryOKBtn
        '
        Me.WhAddHistoryOKBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddHistoryOKBtn.Image = Global.WindowsApplication1.My.Resources.Resources.check_icon
        Me.WhAddHistoryOKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddHistoryOKBtn.Location = New System.Drawing.Point(513, 12)
        Me.WhAddHistoryOKBtn.Name = "WhAddHistoryOKBtn"
        Me.WhAddHistoryOKBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddHistoryOKBtn.TabIndex = 12
        Me.WhAddHistoryOKBtn.Text = "OK"
        Me.WhAddHistoryOKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddHistoryOKBtn.UseVisualStyleBackColor = True
        '
        'WhAddhistoryCancelBtn
        '
        Me.WhAddhistoryCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.WhAddhistoryCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddhistoryCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.WhAddhistoryCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddhistoryCancelBtn.Location = New System.Drawing.Point(357, 12)
        Me.WhAddhistoryCancelBtn.Name = "WhAddhistoryCancelBtn"
        Me.WhAddhistoryCancelBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddhistoryCancelBtn.TabIndex = 13
        Me.WhAddhistoryCancelBtn.Text = "Cancel"
        Me.WhAddhistoryCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddhistoryCancelBtn.UseVisualStyleBackColor = True
        '
        'WhCusTblTableAdapter
        '
        Me.WhCusTblTableAdapter.ClearBeforeFill = True
        '
        'WhAddHistoryResetBtn
        '
        Me.WhAddHistoryResetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddHistoryResetBtn.Image = Global.WindowsApplication1.My.Resources.Resources.App_restart_icon
        Me.WhAddHistoryResetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddHistoryResetBtn.Location = New System.Drawing.Point(168, 12)
        Me.WhAddHistoryResetBtn.Name = "WhAddHistoryResetBtn"
        Me.WhAddHistoryResetBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddHistoryResetBtn.TabIndex = 14
        Me.WhAddHistoryResetBtn.Text = "Reset"
        Me.WhAddHistoryResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddHistoryResetBtn.UseVisualStyleBackColor = True
        '
        'WhAddressHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.WhAddhistoryCancelBtn
        Me.ClientSize = New System.Drawing.Size(675, 621)
        Me.Controls.Add(Me.WhAddHistoryResetBtn)
        Me.Controls.Add(Me.WhAddHistoryOKBtn)
        Me.Controls.Add(Me.WhAddhistoryCancelBtn)
        Me.Controls.Add(Me.WhAddHistoryNewBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhAddressHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Address History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AddHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhCusTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WhAddHistoryNewBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddHistoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddHistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WhAddHistoryOKBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddhistoryCancelBtn As System.Windows.Forms.Button
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents WhCusTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WhCusTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.WhCusTblTableAdapter
    Friend WithEvents WhAddHistoryResetBtn As System.Windows.Forms.Button
    Friend WithEvents WhCusIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhCusNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhCusAddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhCusCtcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhCusLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhCusLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
