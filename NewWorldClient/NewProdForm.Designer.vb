<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProdForm
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
        Dim ProdIDLabel As System.Windows.Forms.Label
        Dim ProdNameLabel As System.Windows.Forms.Label
        Dim ProdPriceLabel As System.Windows.Forms.Label
        Dim ProdWarrantyLabel1 As System.Windows.Forms.Label
        Dim ProdCatLabel As System.Windows.Forms.Label
        Dim ProdCreditLabel As System.Windows.Forms.Label
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.ProdTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager()
        Me.ProdIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProdNameTextBox = New System.Windows.Forms.TextBox()
        Me.NewProdSaveBtn = New System.Windows.Forms.Button()
        Me.ProdNewCancelBtn = New System.Windows.Forms.Button()
        Me.ProdWarrantyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProdNewClearBtn = New System.Windows.Forms.Button()
        Me.ProdCatComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProdCreditNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProdPriceNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ProdNewLockBtn = New System.Windows.Forms.Button()
        ProdIDLabel = New System.Windows.Forms.Label()
        ProdNameLabel = New System.Windows.Forms.Label()
        ProdPriceLabel = New System.Windows.Forms.Label()
        ProdWarrantyLabel1 = New System.Windows.Forms.Label()
        ProdCatLabel = New System.Windows.Forms.Label()
        ProdCreditLabel = New System.Windows.Forms.Label()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdWarrantyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdCreditNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdPriceNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProdIDLabel
        '
        ProdIDLabel.AutoSize = True
        ProdIDLabel.Location = New System.Drawing.Point(391, 15)
        ProdIDLabel.Name = "ProdIDLabel"
        ProdIDLabel.Size = New System.Drawing.Size(59, 13)
        ProdIDLabel.TabIndex = 1
        ProdIDLabel.Text = "Record ID:"
        ProdIDLabel.Visible = False
        '
        'ProdNameLabel
        '
        ProdNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ProdNameLabel.AutoSize = True
        ProdNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProdNameLabel.Location = New System.Drawing.Point(16, 61)
        ProdNameLabel.Name = "ProdNameLabel"
        ProdNameLabel.Size = New System.Drawing.Size(128, 16)
        ProdNameLabel.TabIndex = 2
        ProdNameLabel.Text = "Product Description:"
        '
        'ProdPriceLabel
        '
        ProdPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ProdPriceLabel.AutoSize = True
        ProdPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProdPriceLabel.Location = New System.Drawing.Point(58, 89)
        ProdPriceLabel.Name = "ProdPriceLabel"
        ProdPriceLabel.Size = New System.Drawing.Size(86, 16)
        ProdPriceLabel.TabIndex = 4
        ProdPriceLabel.Text = "Unit Price ($):"
        '
        'ProdWarrantyLabel1
        '
        ProdWarrantyLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        ProdWarrantyLabel1.AutoSize = True
        ProdWarrantyLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProdWarrantyLabel1.Location = New System.Drawing.Point(36, 116)
        ProdWarrantyLabel1.Name = "ProdWarrantyLabel1"
        ProdWarrantyLabel1.Size = New System.Drawing.Size(108, 16)
        ProdWarrantyLabel1.TabIndex = 9
        ProdWarrantyLabel1.Text = "Warranty Period:"
        '
        'ProdCatLabel
        '
        ProdCatLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ProdCatLabel.AutoSize = True
        ProdCatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProdCatLabel.Location = New System.Drawing.Point(78, 145)
        ProdCatLabel.Name = "ProdCatLabel"
        ProdCatLabel.Size = New System.Drawing.Size(66, 16)
        ProdCatLabel.TabIndex = 11
        ProdCatLabel.Text = "Category:"
        '
        'ProdCreditLabel
        '
        ProdCreditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ProdCreditLabel.AutoSize = True
        ProdCreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProdCreditLabel.Location = New System.Drawing.Point(61, 175)
        ProdCreditLabel.Name = "ProdCreditLabel"
        ProdCreditLabel.Size = New System.Drawing.Size(83, 16)
        ProdCreditLabel.TabIndex = 15
        ProdCreditLabel.Text = "Class Credit:"
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProdTblBindingSource
        '
        Me.ProdTblBindingSource.DataMember = "ProdTbl"
        Me.ProdTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'ProdTblTableAdapter
        '
        Me.ProdTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClsTblTableAdapter = Nothing
        Me.TableAdapterManager.MemTblTableAdapter = Nothing
        Me.TableAdapterManager.MenuTblTableAdapter = Nothing
        Me.TableAdapterManager.ProdTblTableAdapter = Me.ProdTblTableAdapter
        Me.TableAdapterManager.PurTblTableAdapter = Nothing
        Me.TableAdapterManager.RootTblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WhCusTblTableAdapter = Nothing
        Me.TableAdapterManager.WhItemTblTableAdapter = Nothing
        Me.TableAdapterManager.WhProdTblTableAdapter = Nothing
        Me.TableAdapterManager.WhTblTableAdapter = Nothing
        '
        'ProdIDTextBox
        '
        Me.ProdIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ProdIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdTblBindingSource, "ProdID", True))
        Me.ProdIDTextBox.Location = New System.Drawing.Point(456, 12)
        Me.ProdIDTextBox.Name = "ProdIDTextBox"
        Me.ProdIDTextBox.ReadOnly = True
        Me.ProdIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProdIDTextBox.TabIndex = 2
        Me.ProdIDTextBox.Visible = False
        '
        'ProdNameTextBox
        '
        Me.ProdNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProdNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProdNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdTblBindingSource, "ProdName", True))
        Me.ProdNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNameTextBox.Location = New System.Drawing.Point(150, 58)
        Me.ProdNameTextBox.Name = "ProdNameTextBox"
        Me.ProdNameTextBox.Size = New System.Drawing.Size(406, 22)
        Me.ProdNameTextBox.TabIndex = 3
        '
        'NewProdSaveBtn
        '
        Me.NewProdSaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewProdSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewProdSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.save2_icon
        Me.NewProdSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewProdSaveBtn.Location = New System.Drawing.Point(435, 227)
        Me.NewProdSaveBtn.Name = "NewProdSaveBtn"
        Me.NewProdSaveBtn.Size = New System.Drawing.Size(121, 45)
        Me.NewProdSaveBtn.TabIndex = 8
        Me.NewProdSaveBtn.Text = "Save"
        Me.NewProdSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewProdSaveBtn.UseVisualStyleBackColor = True
        '
        'ProdNewCancelBtn
        '
        Me.ProdNewCancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProdNewCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ProdNewCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNewCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.ProdNewCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProdNewCancelBtn.Location = New System.Drawing.Point(181, 227)
        Me.ProdNewCancelBtn.Name = "ProdNewCancelBtn"
        Me.ProdNewCancelBtn.Size = New System.Drawing.Size(121, 45)
        Me.ProdNewCancelBtn.TabIndex = 9
        Me.ProdNewCancelBtn.Text = "Cancel"
        Me.ProdNewCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProdNewCancelBtn.UseVisualStyleBackColor = True
        '
        'ProdWarrantyNumericUpDown
        '
        Me.ProdWarrantyNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProdWarrantyNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProdTblBindingSource, "ProdWarranty", True))
        Me.ProdWarrantyNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdWarrantyNumericUpDown.Location = New System.Drawing.Point(150, 114)
        Me.ProdWarrantyNumericUpDown.Name = "ProdWarrantyNumericUpDown"
        Me.ProdWarrantyNumericUpDown.Size = New System.Drawing.Size(134, 22)
        Me.ProdWarrantyNumericUpDown.TabIndex = 10
        '
        'ProdNewClearBtn
        '
        Me.ProdNewClearBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProdNewClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNewClearBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_edit_clear_icon
        Me.ProdNewClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProdNewClearBtn.Location = New System.Drawing.Point(308, 227)
        Me.ProdNewClearBtn.Name = "ProdNewClearBtn"
        Me.ProdNewClearBtn.Size = New System.Drawing.Size(121, 45)
        Me.ProdNewClearBtn.TabIndex = 11
        Me.ProdNewClearBtn.Text = "Clear"
        Me.ProdNewClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProdNewClearBtn.UseVisualStyleBackColor = True
        '
        'ProdCatComboBox
        '
        Me.ProdCatComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProdCatComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdTblBindingSource, "ProdCat", True))
        Me.ProdCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProdCatComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdCatComboBox.FormattingEnabled = True
        Me.ProdCatComboBox.Items.AddRange(New Object() {"Cooking", "Electric", "Nutrition"})
        Me.ProdCatComboBox.Location = New System.Drawing.Point(149, 142)
        Me.ProdCatComboBox.Name = "ProdCatComboBox"
        Me.ProdCatComboBox.Size = New System.Drawing.Size(135, 24)
        Me.ProdCatComboBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Months"
        '
        'ProdCreditNumericUpDown
        '
        Me.ProdCreditNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProdCreditNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProdTblBindingSource, "ProdWarranty", True))
        Me.ProdCreditNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdCreditNumericUpDown.Location = New System.Drawing.Point(150, 172)
        Me.ProdCreditNumericUpDown.Name = "ProdCreditNumericUpDown"
        Me.ProdCreditNumericUpDown.Size = New System.Drawing.Size(134, 22)
        Me.ProdCreditNumericUpDown.TabIndex = 16
        '
        'ProdPriceNumericUpDown
        '
        Me.ProdPriceNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ProdPriceNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProdTblBindingSource, "ProdWarranty", True))
        Me.ProdPriceNumericUpDown.DecimalPlaces = 2
        Me.ProdPriceNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdPriceNumericUpDown.Location = New System.Drawing.Point(150, 86)
        Me.ProdPriceNumericUpDown.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.ProdPriceNumericUpDown.Name = "ProdPriceNumericUpDown"
        Me.ProdPriceNumericUpDown.Size = New System.Drawing.Size(134, 22)
        Me.ProdPriceNumericUpDown.TabIndex = 17
        '
        'ProdNewLockBtn
        '
        Me.ProdNewLockBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProdNewLockBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ProdNewLockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProdNewLockBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Lock_icon
        Me.ProdNewLockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProdNewLockBtn.Location = New System.Drawing.Point(54, 227)
        Me.ProdNewLockBtn.Name = "ProdNewLockBtn"
        Me.ProdNewLockBtn.Size = New System.Drawing.Size(121, 45)
        Me.ProdNewLockBtn.TabIndex = 18
        Me.ProdNewLockBtn.Text = "Lock"
        Me.ProdNewLockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ProdNewLockBtn.UseVisualStyleBackColor = True
        '
        'NewProdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ProdNewCancelBtn
        Me.ClientSize = New System.Drawing.Size(568, 309)
        Me.Controls.Add(Me.ProdNewLockBtn)
        Me.Controls.Add(Me.ProdPriceNumericUpDown)
        Me.Controls.Add(Me.ProdCreditNumericUpDown)
        Me.Controls.Add(ProdCreditLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ProdCatLabel)
        Me.Controls.Add(Me.ProdCatComboBox)
        Me.Controls.Add(Me.ProdNewClearBtn)
        Me.Controls.Add(ProdWarrantyLabel1)
        Me.Controls.Add(Me.ProdWarrantyNumericUpDown)
        Me.Controls.Add(Me.ProdNewCancelBtn)
        Me.Controls.Add(Me.NewProdSaveBtn)
        Me.Controls.Add(ProdPriceLabel)
        Me.Controls.Add(ProdNameLabel)
        Me.Controls.Add(Me.ProdNameTextBox)
        Me.Controls.Add(ProdIDLabel)
        Me.Controls.Add(Me.ProdIDTextBox)
        Me.Name = "NewProdForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Form"
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdWarrantyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdCreditNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdPriceNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents ProdTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProdIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProdNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewProdSaveBtn As System.Windows.Forms.Button
    Friend WithEvents ProdNewCancelBtn As System.Windows.Forms.Button
    Friend WithEvents ProdWarrantyNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProdNewClearBtn As System.Windows.Forms.Button
    Friend WithEvents ProdCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProdCreditNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProdPriceNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents ProdNewLockBtn As System.Windows.Forms.Button
End Class
