<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMenuForm
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
        Dim MenuIDLabel As System.Windows.Forms.Label
        Dim MenuNameLabel As System.Windows.Forms.Label
        Dim MenuDescLabel As System.Windows.Forms.Label
        Dim MenuProdLabel As System.Windows.Forms.Label
        Dim MenuCreditLabel As System.Windows.Forms.Label
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.MenuTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.MenuTblTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager()
        Me.MenuIDTextBox = New System.Windows.Forms.TextBox()
        Me.MenuNameTextBox = New System.Windows.Forms.TextBox()
        Me.MenuDescTextBox = New System.Windows.Forms.TextBox()
        Me.NewMenuAddProdBtn = New System.Windows.Forms.Button()
        Me.NewMenuSaveBtn = New System.Windows.Forms.Button()
        Me.NewMenuClearBtn = New System.Windows.Forms.Button()
        Me.NewMenuCancelBtn = New System.Windows.Forms.Button()
        Me.MenuAssocProdTxtBox = New System.Windows.Forms.TextBox()
        Me.MenuCreditNumericUpDown = New System.Windows.Forms.NumericUpDown()
        MenuIDLabel = New System.Windows.Forms.Label()
        MenuNameLabel = New System.Windows.Forms.Label()
        MenuDescLabel = New System.Windows.Forms.Label()
        MenuProdLabel = New System.Windows.Forms.Label()
        MenuCreditLabel = New System.Windows.Forms.Label()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuCreditNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuIDLabel
        '
        MenuIDLabel.AutoSize = True
        MenuIDLabel.Location = New System.Drawing.Point(329, 15)
        MenuIDLabel.Name = "MenuIDLabel"
        MenuIDLabel.Size = New System.Drawing.Size(59, 13)
        MenuIDLabel.TabIndex = 1
        MenuIDLabel.Text = "Record ID:"
        MenuIDLabel.Visible = False
        '
        'MenuNameLabel
        '
        MenuNameLabel.AutoSize = True
        MenuNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenuNameLabel.Location = New System.Drawing.Point(72, 61)
        MenuNameLabel.Name = "MenuNameLabel"
        MenuNameLabel.Size = New System.Drawing.Size(84, 16)
        MenuNameLabel.TabIndex = 2
        MenuNameLabel.Text = "Menu Name:"
        '
        'MenuDescLabel
        '
        MenuDescLabel.AutoSize = True
        MenuDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenuDescLabel.Location = New System.Drawing.Point(41, 186)
        MenuDescLabel.Name = "MenuDescLabel"
        MenuDescLabel.Size = New System.Drawing.Size(115, 16)
        MenuDescLabel.TabIndex = 4
        MenuDescLabel.Text = "Menu Description:"
        '
        'MenuProdLabel
        '
        MenuProdLabel.AutoSize = True
        MenuProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenuProdLabel.Location = New System.Drawing.Point(13, 90)
        MenuProdLabel.Name = "MenuProdLabel"
        MenuProdLabel.Size = New System.Drawing.Size(143, 16)
        MenuProdLabel.TabIndex = 12
        MenuProdLabel.Text = "Associated Product(s):"
        '
        'MenuCreditLabel
        '
        MenuCreditLabel.AutoSize = True
        MenuCreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MenuCreditLabel.Location = New System.Drawing.Point(77, 331)
        MenuCreditLabel.Name = "MenuCreditLabel"
        MenuCreditLabel.Size = New System.Drawing.Size(82, 16)
        MenuCreditLabel.TabIndex = 13
        MenuCreditLabel.Text = "Menu Credit:"
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuTblBindingSource
        '
        Me.MenuTblBindingSource.DataMember = "MenuTbl"
        Me.MenuTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'MenuTblTableAdapter
        '
        Me.MenuTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClsTblTableAdapter = Nothing
        Me.TableAdapterManager.MemTblTableAdapter = Nothing
        Me.TableAdapterManager.MenuTblTableAdapter = Me.MenuTblTableAdapter
        Me.TableAdapterManager.ProdTblTableAdapter = Nothing
        Me.TableAdapterManager.PurTblTableAdapter = Nothing
        Me.TableAdapterManager.RootTblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WhCusTblTableAdapter = Nothing
        Me.TableAdapterManager.WhItemTblTableAdapter = Nothing
        Me.TableAdapterManager.WhProdTblTableAdapter = Nothing
        Me.TableAdapterManager.WhTblTableAdapter = Nothing
        '
        'MenuIDTextBox
        '
        Me.MenuIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.MenuIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTblBindingSource, "MenuID", True))
        Me.MenuIDTextBox.Location = New System.Drawing.Point(394, 12)
        Me.MenuIDTextBox.Name = "MenuIDTextBox"
        Me.MenuIDTextBox.ReadOnly = True
        Me.MenuIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MenuIDTextBox.TabIndex = 2
        Me.MenuIDTextBox.Visible = False
        '
        'MenuNameTextBox
        '
        Me.MenuNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTblBindingSource, "MenuName", True))
        Me.MenuNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuNameTextBox.Location = New System.Drawing.Point(162, 58)
        Me.MenuNameTextBox.Name = "MenuNameTextBox"
        Me.MenuNameTextBox.Size = New System.Drawing.Size(343, 22)
        Me.MenuNameTextBox.TabIndex = 3
        '
        'MenuDescTextBox
        '
        Me.MenuDescTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTblBindingSource, "MenuDesc", True))
        Me.MenuDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuDescTextBox.Location = New System.Drawing.Point(162, 183)
        Me.MenuDescTextBox.Multiline = True
        Me.MenuDescTextBox.Name = "MenuDescTextBox"
        Me.MenuDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MenuDescTextBox.Size = New System.Drawing.Size(343, 140)
        Me.MenuDescTextBox.TabIndex = 5
        '
        'NewMenuAddProdBtn
        '
        Me.NewMenuAddProdBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMenuAddProdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMenuAddProdBtn.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon
        Me.NewMenuAddProdBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewMenuAddProdBtn.Location = New System.Drawing.Point(423, 90)
        Me.NewMenuAddProdBtn.Name = "NewMenuAddProdBtn"
        Me.NewMenuAddProdBtn.Size = New System.Drawing.Size(82, 87)
        Me.NewMenuAddProdBtn.TabIndex = 6
        Me.NewMenuAddProdBtn.Text = "Add Product"
        Me.NewMenuAddProdBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NewMenuAddProdBtn.UseVisualStyleBackColor = True
        '
        'NewMenuSaveBtn
        '
        Me.NewMenuSaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMenuSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMenuSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.save2_icon
        Me.NewMenuSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewMenuSaveBtn.Location = New System.Drawing.Point(389, 394)
        Me.NewMenuSaveBtn.Name = "NewMenuSaveBtn"
        Me.NewMenuSaveBtn.Size = New System.Drawing.Size(121, 45)
        Me.NewMenuSaveBtn.TabIndex = 7
        Me.NewMenuSaveBtn.Text = "Save"
        Me.NewMenuSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewMenuSaveBtn.UseVisualStyleBackColor = True
        '
        'NewMenuClearBtn
        '
        Me.NewMenuClearBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMenuClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMenuClearBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_edit_clear_icon
        Me.NewMenuClearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewMenuClearBtn.Location = New System.Drawing.Point(262, 394)
        Me.NewMenuClearBtn.Name = "NewMenuClearBtn"
        Me.NewMenuClearBtn.Size = New System.Drawing.Size(121, 45)
        Me.NewMenuClearBtn.TabIndex = 8
        Me.NewMenuClearBtn.Text = "Clear"
        Me.NewMenuClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewMenuClearBtn.UseVisualStyleBackColor = True
        '
        'NewMenuCancelBtn
        '
        Me.NewMenuCancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMenuCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewMenuCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMenuCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.NewMenuCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewMenuCancelBtn.Location = New System.Drawing.Point(135, 394)
        Me.NewMenuCancelBtn.Name = "NewMenuCancelBtn"
        Me.NewMenuCancelBtn.Size = New System.Drawing.Size(121, 45)
        Me.NewMenuCancelBtn.TabIndex = 9
        Me.NewMenuCancelBtn.Text = "Cancel"
        Me.NewMenuCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewMenuCancelBtn.UseVisualStyleBackColor = True
        '
        'MenuAssocProdTxtBox
        '
        Me.MenuAssocProdTxtBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuAssocProdTxtBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuTblBindingSource, "MenuName", True))
        Me.MenuAssocProdTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuAssocProdTxtBox.Location = New System.Drawing.Point(162, 90)
        Me.MenuAssocProdTxtBox.Multiline = True
        Me.MenuAssocProdTxtBox.Name = "MenuAssocProdTxtBox"
        Me.MenuAssocProdTxtBox.ReadOnly = True
        Me.MenuAssocProdTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MenuAssocProdTxtBox.Size = New System.Drawing.Size(249, 87)
        Me.MenuAssocProdTxtBox.TabIndex = 11
        '
        'MenuCreditNumericUpDown
        '
        Me.MenuCreditNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuCreditNumericUpDown.Location = New System.Drawing.Point(162, 329)
        Me.MenuCreditNumericUpDown.Name = "MenuCreditNumericUpDown"
        Me.MenuCreditNumericUpDown.Size = New System.Drawing.Size(82, 22)
        Me.MenuCreditNumericUpDown.TabIndex = 14
        '
        'NewMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NewMenuCancelBtn
        Me.ClientSize = New System.Drawing.Size(522, 465)
        Me.Controls.Add(Me.MenuCreditNumericUpDown)
        Me.Controls.Add(MenuCreditLabel)
        Me.Controls.Add(MenuProdLabel)
        Me.Controls.Add(Me.MenuAssocProdTxtBox)
        Me.Controls.Add(Me.NewMenuCancelBtn)
        Me.Controls.Add(Me.NewMenuClearBtn)
        Me.Controls.Add(Me.NewMenuSaveBtn)
        Me.Controls.Add(Me.NewMenuAddProdBtn)
        Me.Controls.Add(MenuDescLabel)
        Me.Controls.Add(Me.MenuDescTextBox)
        Me.Controls.Add(MenuNameLabel)
        Me.Controls.Add(Me.MenuNameTextBox)
        Me.Controls.Add(MenuIDLabel)
        Me.Controls.Add(Me.MenuIDTextBox)
        Me.Name = "NewMenuForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Form"
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuCreditNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents MenuTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.MenuTblTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewMenuAddProdBtn As System.Windows.Forms.Button
    Friend WithEvents NewMenuSaveBtn As System.Windows.Forms.Button
    Friend WithEvents NewMenuClearBtn As System.Windows.Forms.Button
    Friend WithEvents NewMenuCancelBtn As System.Windows.Forms.Button
    Friend WithEvents MenuAssocProdTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuCreditNumericUpDown As System.Windows.Forms.NumericUpDown
End Class
