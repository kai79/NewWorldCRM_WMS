<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassHistoryForm
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
        Dim ClsIDLabel As System.Windows.Forms.Label
        Dim ClsMenuNameLabel As System.Windows.Forms.Label
        Dim ClsDateLabel As System.Windows.Forms.Label
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.ClsTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClsTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.ClsTblTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager()
        Me.ClsIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClsMenuNameTextBox = New System.Windows.Forms.TextBox()
        Me.ClsDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClsHisLookupBtn = New System.Windows.Forms.Button()
        Me.ClsHisSaveBtn = New System.Windows.Forms.Button()
        Me.ClsHisCancelBtn = New System.Windows.Forms.Button()
        ClsIDLabel = New System.Windows.Forms.Label()
        ClsMenuNameLabel = New System.Windows.Forms.Label()
        ClsDateLabel = New System.Windows.Forms.Label()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClsIDLabel
        '
        ClsIDLabel.AutoSize = True
        ClsIDLabel.Location = New System.Drawing.Point(307, 15)
        ClsIDLabel.Name = "ClsIDLabel"
        ClsIDLabel.Size = New System.Drawing.Size(59, 13)
        ClsIDLabel.TabIndex = 1
        ClsIDLabel.Text = "Record ID:"
        ClsIDLabel.Visible = False
        '
        'ClsMenuNameLabel
        '
        ClsMenuNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ClsMenuNameLabel.AutoSize = True
        ClsMenuNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClsMenuNameLabel.Location = New System.Drawing.Point(10, 69)
        ClsMenuNameLabel.Name = "ClsMenuNameLabel"
        ClsMenuNameLabel.Size = New System.Drawing.Size(101, 16)
        ClsMenuNameLabel.TabIndex = 2
        ClsMenuNameLabel.Text = "Menu Attended:"
        '
        'ClsDateLabel
        '
        ClsDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        ClsDateLabel.AutoSize = True
        ClsDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClsDateLabel.Location = New System.Drawing.Point(14, 99)
        ClsDateLabel.Name = "ClsDateLabel"
        ClsDateLabel.Size = New System.Drawing.Size(97, 16)
        ClsDateLabel.TabIndex = 4
        ClsDateLabel.Text = "Date Attended:"
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClsTblBindingSource
        '
        Me.ClsTblBindingSource.DataMember = "ClsTbl"
        Me.ClsTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'ClsTblTableAdapter
        '
        Me.ClsTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClsTblTableAdapter = Me.ClsTblTableAdapter
        Me.TableAdapterManager.MemTblTableAdapter = Nothing
        Me.TableAdapterManager.MenuTblTableAdapter = Nothing
        Me.TableAdapterManager.ProdTblTableAdapter = Nothing
        Me.TableAdapterManager.PurTblTableAdapter = Nothing
        Me.TableAdapterManager.RootTblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WhCusTblTableAdapter = Nothing
        Me.TableAdapterManager.WhItemTblTableAdapter = Nothing
        Me.TableAdapterManager.WhProdTblTableAdapter = Nothing
        Me.TableAdapterManager.WhTblTableAdapter = Nothing
        '
        'ClsIDTextBox
        '
        Me.ClsIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.ClsIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsTblBindingSource, "ClsID", True))
        Me.ClsIDTextBox.Location = New System.Drawing.Point(372, 12)
        Me.ClsIDTextBox.Name = "ClsIDTextBox"
        Me.ClsIDTextBox.ReadOnly = True
        Me.ClsIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClsIDTextBox.TabIndex = 2
        Me.ClsIDTextBox.Visible = False
        '
        'ClsMenuNameTextBox
        '
        Me.ClsMenuNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClsMenuNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClsTblBindingSource, "ClsMenuName", True))
        Me.ClsMenuNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsMenuNameTextBox.Location = New System.Drawing.Point(114, 66)
        Me.ClsMenuNameTextBox.Name = "ClsMenuNameTextBox"
        Me.ClsMenuNameTextBox.ReadOnly = True
        Me.ClsMenuNameTextBox.Size = New System.Drawing.Size(264, 22)
        Me.ClsMenuNameTextBox.TabIndex = 3
        '
        'ClsDateDateTimePicker
        '
        Me.ClsDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClsDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClsTblBindingSource, "ClsDate", True))
        Me.ClsDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsDateDateTimePicker.Location = New System.Drawing.Point(114, 94)
        Me.ClsDateDateTimePicker.Name = "ClsDateDateTimePicker"
        Me.ClsDateDateTimePicker.Size = New System.Drawing.Size(242, 22)
        Me.ClsDateDateTimePicker.TabIndex = 5
        '
        'ClsHisLookupBtn
        '
        Me.ClsHisLookupBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClsHisLookupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsHisLookupBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_addRound_icon
        Me.ClsHisLookupBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClsHisLookupBtn.Location = New System.Drawing.Point(384, 65)
        Me.ClsHisLookupBtn.Name = "ClsHisLookupBtn"
        Me.ClsHisLookupBtn.Size = New System.Drawing.Size(88, 24)
        Me.ClsHisLookupBtn.TabIndex = 6
        Me.ClsHisLookupBtn.Text = "Lookup"
        Me.ClsHisLookupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClsHisLookupBtn.UseVisualStyleBackColor = True
        '
        'ClsHisSaveBtn
        '
        Me.ClsHisSaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsHisSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsHisSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.save2_icon
        Me.ClsHisSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClsHisSaveBtn.Location = New System.Drawing.Point(351, 157)
        Me.ClsHisSaveBtn.Name = "ClsHisSaveBtn"
        Me.ClsHisSaveBtn.Size = New System.Drawing.Size(121, 45)
        Me.ClsHisSaveBtn.TabIndex = 7
        Me.ClsHisSaveBtn.Text = "Save"
        Me.ClsHisSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClsHisSaveBtn.UseVisualStyleBackColor = True
        '
        'ClsHisCancelBtn
        '
        Me.ClsHisCancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsHisCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClsHisCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsHisCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.ClsHisCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClsHisCancelBtn.Location = New System.Drawing.Point(224, 157)
        Me.ClsHisCancelBtn.Name = "ClsHisCancelBtn"
        Me.ClsHisCancelBtn.Size = New System.Drawing.Size(121, 45)
        Me.ClsHisCancelBtn.TabIndex = 8
        Me.ClsHisCancelBtn.Text = "Cancel"
        Me.ClsHisCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClsHisCancelBtn.UseVisualStyleBackColor = True
        '
        'ClassHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClsHisCancelBtn
        Me.ClientSize = New System.Drawing.Size(484, 227)
        Me.Controls.Add(Me.ClsHisCancelBtn)
        Me.Controls.Add(Me.ClsHisSaveBtn)
        Me.Controls.Add(Me.ClsHisLookupBtn)
        Me.Controls.Add(ClsDateLabel)
        Me.Controls.Add(Me.ClsDateDateTimePicker)
        Me.Controls.Add(ClsMenuNameLabel)
        Me.Controls.Add(Me.ClsMenuNameTextBox)
        Me.Controls.Add(ClsIDLabel)
        Me.Controls.Add(Me.ClsIDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClassHistoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class History"
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents ClsTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClsTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.ClsTblTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClsIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClsMenuNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClsDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ClsHisLookupBtn As System.Windows.Forms.Button
    Friend WithEvents ClsHisSaveBtn As System.Windows.Forms.Button
    Friend WithEvents ClsHisCancelBtn As System.Windows.Forms.Button
End Class
