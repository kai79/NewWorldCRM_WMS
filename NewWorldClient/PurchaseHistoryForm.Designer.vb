<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseHistoryForm
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
        Dim PurIDLabel As System.Windows.Forms.Label
        Dim PurWarrNoLabel As System.Windows.Forms.Label
        Dim PurOrderNoLabel As System.Windows.Forms.Label
        Dim PurDateLabel As System.Windows.Forms.Label
        Dim PurSDateLabel As System.Windows.Forms.Label
        Dim PurEDateLabel As System.Windows.Forms.Label
        Dim PurProdNameLabel As System.Windows.Forms.Label
        Dim PurAmtLabel As System.Windows.Forms.Label
        Dim PurQtyLabel As System.Windows.Forms.Label
        Dim PurCkassCreditLabel As System.Windows.Forms.Label
        Dim PurDepoLabel As System.Windows.Forms.Label
        Dim PurDevStatusLabel As System.Windows.Forms.Label
        Me.PurIDTextBox = New System.Windows.Forms.TextBox()
        Me.PurTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.PurWarrNoTextBox = New System.Windows.Forms.TextBox()
        Me.PurOrderNoTextBox = New System.Windows.Forms.TextBox()
        Me.PurDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PurSDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PurEDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PurHisTextBox = New System.Windows.Forms.TextBox()
        Me.AddPurHisSaveBtn = New System.Windows.Forms.Button()
        Me.AddPurHisCnlBtn = New System.Windows.Forms.Button()
        Me.PurProdNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddPurProLookupBtn = New System.Windows.Forms.Button()
        Me.PurTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.PurTblTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager()
        Me.ProdTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter()
        Me.PurCreditNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PurRemarkTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PurDepoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PurDevStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.PurQtyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.PurAmtNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        PurIDLabel = New System.Windows.Forms.Label()
        PurWarrNoLabel = New System.Windows.Forms.Label()
        PurOrderNoLabel = New System.Windows.Forms.Label()
        PurDateLabel = New System.Windows.Forms.Label()
        PurSDateLabel = New System.Windows.Forms.Label()
        PurEDateLabel = New System.Windows.Forms.Label()
        PurProdNameLabel = New System.Windows.Forms.Label()
        PurAmtLabel = New System.Windows.Forms.Label()
        PurQtyLabel = New System.Windows.Forms.Label()
        PurCkassCreditLabel = New System.Windows.Forms.Label()
        PurDepoLabel = New System.Windows.Forms.Label()
        PurDevStatusLabel = New System.Windows.Forms.Label()
        CType(Me.PurTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurCreditNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PurQtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurAmtNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PurIDLabel
        '
        PurIDLabel.AutoSize = True
        PurIDLabel.Location = New System.Drawing.Point(556, 15)
        PurIDLabel.Name = "PurIDLabel"
        PurIDLabel.Size = New System.Drawing.Size(59, 13)
        PurIDLabel.TabIndex = 1
        PurIDLabel.Text = "Record ID:"
        PurIDLabel.Visible = False
        '
        'PurWarrNoLabel
        '
        PurWarrNoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurWarrNoLabel.AutoSize = True
        PurWarrNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurWarrNoLabel.Location = New System.Drawing.Point(31, 33)
        PurWarrNoLabel.Name = "PurWarrNoLabel"
        PurWarrNoLabel.Size = New System.Drawing.Size(86, 16)
        PurWarrNoLabel.TabIndex = 2
        PurWarrNoLabel.Text = "Warranty No:"
        '
        'PurOrderNoLabel
        '
        PurOrderNoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurOrderNoLabel.AutoSize = True
        PurOrderNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurOrderNoLabel.Location = New System.Drawing.Point(72, 31)
        PurOrderNoLabel.Name = "PurOrderNoLabel"
        PurOrderNoLabel.Size = New System.Drawing.Size(66, 16)
        PurOrderNoLabel.TabIndex = 4
        PurOrderNoLabel.Text = "Order No:"
        '
        'PurDateLabel
        '
        PurDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurDateLabel.AutoSize = True
        PurDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurDateLabel.Location = New System.Drawing.Point(38, 88)
        PurDateLabel.Name = "PurDateLabel"
        PurDateLabel.Size = New System.Drawing.Size(100, 16)
        PurDateLabel.TabIndex = 8
        PurDateLabel.Text = "Purchase Date:"
        '
        'PurSDateLabel
        '
        PurSDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurSDateLabel.AutoSize = True
        PurSDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurSDateLabel.Location = New System.Drawing.Point(23, 62)
        PurSDateLabel.Name = "PurSDateLabel"
        PurSDateLabel.Size = New System.Drawing.Size(95, 16)
        PurSDateLabel.TabIndex = 10
        PurSDateLabel.Text = "Warranty Start:"
        '
        'PurEDateLabel
        '
        PurEDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurEDateLabel.AutoSize = True
        PurEDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurEDateLabel.Location = New System.Drawing.Point(352, 62)
        PurEDateLabel.Name = "PurEDateLabel"
        PurEDateLabel.Size = New System.Drawing.Size(92, 16)
        PurEDateLabel.TabIndex = 12
        PurEDateLabel.Text = "Warranty End:"
        '
        'PurProdNameLabel
        '
        PurProdNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurProdNameLabel.AutoSize = True
        PurProdNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurProdNameLabel.Location = New System.Drawing.Point(14, 59)
        PurProdNameLabel.Name = "PurProdNameLabel"
        PurProdNameLabel.Size = New System.Drawing.Size(125, 16)
        PurProdNameLabel.TabIndex = 17
        PurProdNameLabel.Text = "Product Purchased:"
        '
        'PurAmtLabel
        '
        PurAmtLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurAmtLabel.AutoSize = True
        PurAmtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurAmtLabel.Location = New System.Drawing.Point(18, 115)
        PurAmtLabel.Name = "PurAmtLabel"
        PurAmtLabel.Size = New System.Drawing.Size(120, 16)
        PurAmtLabel.TabIndex = 19
        PurAmtLabel.Text = "Purchase Price ($):"
        '
        'PurQtyLabel
        '
        PurQtyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurQtyLabel.AutoSize = True
        PurQtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurQtyLabel.Location = New System.Drawing.Point(458, 88)
        PurQtyLabel.Name = "PurQtyLabel"
        PurQtyLabel.Size = New System.Drawing.Size(127, 16)
        PurQtyLabel.TabIndex = 21
        PurQtyLabel.Text = "Quantity Purchased:"
        '
        'PurCkassCreditLabel
        '
        PurCkassCreditLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurCkassCreditLabel.AutoSize = True
        PurCkassCreditLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurCkassCreditLabel.Location = New System.Drawing.Point(502, 59)
        PurCkassCreditLabel.Name = "PurCkassCreditLabel"
        PurCkassCreditLabel.Size = New System.Drawing.Size(83, 16)
        PurCkassCreditLabel.TabIndex = 24
        PurCkassCreditLabel.Text = "Class Credit:"
        '
        'PurDepoLabel
        '
        PurDepoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurDepoLabel.AutoSize = True
        PurDepoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurDepoLabel.Location = New System.Drawing.Point(381, 115)
        PurDepoLabel.Name = "PurDepoLabel"
        PurDepoLabel.Size = New System.Drawing.Size(90, 16)
        PurDepoLabel.TabIndex = 27
        PurDepoLabel.Text = "Deposit Date:"
        '
        'PurDevStatusLabel
        '
        PurDevStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PurDevStatusLabel.AutoSize = True
        PurDevStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PurDevStatusLabel.Location = New System.Drawing.Point(17, 89)
        PurDevStatusLabel.Name = "PurDevStatusLabel"
        PurDevStatusLabel.Size = New System.Drawing.Size(101, 16)
        PurDevStatusLabel.TabIndex = 30
        PurDevStatusLabel.Text = "Delivery Status:"
        '
        'PurIDTextBox
        '
        Me.PurIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PurIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurTblBindingSource, "PurID", True))
        Me.PurIDTextBox.Location = New System.Drawing.Point(621, 12)
        Me.PurIDTextBox.Name = "PurIDTextBox"
        Me.PurIDTextBox.ReadOnly = True
        Me.PurIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PurIDTextBox.TabIndex = 2
        Me.PurIDTextBox.Visible = False
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
        'PurWarrNoTextBox
        '
        Me.PurWarrNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurWarrNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurTblBindingSource, "PurWarrNo", True))
        Me.PurWarrNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurWarrNoTextBox.Location = New System.Drawing.Point(123, 30)
        Me.PurWarrNoTextBox.Name = "PurWarrNoTextBox"
        Me.PurWarrNoTextBox.Size = New System.Drawing.Size(217, 22)
        Me.PurWarrNoTextBox.TabIndex = 8
        '
        'PurOrderNoTextBox
        '
        Me.PurOrderNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurOrderNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PurOrderNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurTblBindingSource, "PurOrderNo", True))
        Me.PurOrderNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurOrderNoTextBox.Location = New System.Drawing.Point(144, 28)
        Me.PurOrderNoTextBox.Name = "PurOrderNoTextBox"
        Me.PurOrderNoTextBox.Size = New System.Drawing.Size(217, 22)
        Me.PurOrderNoTextBox.TabIndex = 1
        '
        'PurDateDateTimePicker
        '
        Me.PurDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurTblBindingSource, "PurDate", True))
        Me.PurDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurDateDateTimePicker.Location = New System.Drawing.Point(144, 84)
        Me.PurDateDateTimePicker.Name = "PurDateDateTimePicker"
        Me.PurDateDateTimePicker.Size = New System.Drawing.Size(218, 22)
        Me.PurDateDateTimePicker.TabIndex = 4
        '
        'PurSDateDateTimePicker
        '
        Me.PurSDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurSDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurTblBindingSource, "PurSDate", True))
        Me.PurSDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurSDateDateTimePicker.Location = New System.Drawing.Point(123, 58)
        Me.PurSDateDateTimePicker.Name = "PurSDateDateTimePicker"
        Me.PurSDateDateTimePicker.Size = New System.Drawing.Size(217, 22)
        Me.PurSDateDateTimePicker.TabIndex = 9
        '
        'PurEDateDateTimePicker
        '
        Me.PurEDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurEDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurTblBindingSource, "PurEDate", True))
        Me.PurEDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurEDateDateTimePicker.Location = New System.Drawing.Point(450, 58)
        Me.PurEDateDateTimePicker.Name = "PurEDateDateTimePicker"
        Me.PurEDateDateTimePicker.Size = New System.Drawing.Size(217, 22)
        Me.PurEDateDateTimePicker.TabIndex = 10
        '
        'PurHisTextBox
        '
        Me.PurHisTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurHisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurTblBindingSource, "PurHis", True))
        Me.PurHisTextBox.Location = New System.Drawing.Point(3, 3)
        Me.PurHisTextBox.Multiline = True
        Me.PurHisTextBox.Name = "PurHisTextBox"
        Me.PurHisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PurHisTextBox.Size = New System.Drawing.Size(694, 175)
        Me.PurHisTextBox.TabIndex = 15
        '
        'AddPurHisSaveBtn
        '
        Me.AddPurHisSaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddPurHisSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPurHisSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.save2_icon
        Me.AddPurHisSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddPurHisSaveBtn.Location = New System.Drawing.Point(600, 600)
        Me.AddPurHisSaveBtn.Name = "AddPurHisSaveBtn"
        Me.AddPurHisSaveBtn.Size = New System.Drawing.Size(121, 45)
        Me.AddPurHisSaveBtn.TabIndex = 16
        Me.AddPurHisSaveBtn.Text = "Save"
        Me.AddPurHisSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddPurHisSaveBtn.UseVisualStyleBackColor = True
        '
        'AddPurHisCnlBtn
        '
        Me.AddPurHisCnlBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddPurHisCnlBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AddPurHisCnlBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPurHisCnlBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.AddPurHisCnlBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddPurHisCnlBtn.Location = New System.Drawing.Point(471, 600)
        Me.AddPurHisCnlBtn.Name = "AddPurHisCnlBtn"
        Me.AddPurHisCnlBtn.Size = New System.Drawing.Size(121, 45)
        Me.AddPurHisCnlBtn.TabIndex = 17
        Me.AddPurHisCnlBtn.Text = "Cancel"
        Me.AddPurHisCnlBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddPurHisCnlBtn.UseVisualStyleBackColor = True
        '
        'PurProdNameTextBox
        '
        Me.PurProdNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurProdNameTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.PurProdNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurTblBindingSource, "PurProdName", True))
        Me.PurProdNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurProdNameTextBox.Location = New System.Drawing.Point(144, 56)
        Me.PurProdNameTextBox.Name = "PurProdNameTextBox"
        Me.PurProdNameTextBox.ReadOnly = True
        Me.PurProdNameTextBox.Size = New System.Drawing.Size(237, 22)
        Me.PurProdNameTextBox.TabIndex = 18
        '
        'AddPurProLookupBtn
        '
        Me.AddPurProLookupBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddPurProLookupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddPurProLookupBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_addRound_icon
        Me.AddPurProLookupBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddPurProLookupBtn.Location = New System.Drawing.Point(387, 55)
        Me.AddPurProLookupBtn.Name = "AddPurProLookupBtn"
        Me.AddPurProLookupBtn.Size = New System.Drawing.Size(102, 24)
        Me.AddPurProLookupBtn.TabIndex = 2
        Me.AddPurProLookupBtn.Text = "Lookup"
        Me.AddPurProLookupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddPurProLookupBtn.UseVisualStyleBackColor = True
        '
        'PurTblTableAdapter
        '
        Me.PurTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClsTblTableAdapter = Nothing
        Me.TableAdapterManager.MemTblTableAdapter = Nothing
        Me.TableAdapterManager.MenuTblTableAdapter = Nothing
        Me.TableAdapterManager.ProdTblTableAdapter = Nothing
        Me.TableAdapterManager.PurTblTableAdapter = Me.PurTblTableAdapter
        Me.TableAdapterManager.RootTblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WhCusTblTableAdapter = Nothing
        Me.TableAdapterManager.WhItemTblTableAdapter = Nothing
        Me.TableAdapterManager.WhProdTblTableAdapter = Nothing
        Me.TableAdapterManager.WhTblTableAdapter = Nothing
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
        'PurCreditNumericUpDown
        '
        Me.PurCreditNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurCreditNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurCreditNumericUpDown.Location = New System.Drawing.Point(591, 57)
        Me.PurCreditNumericUpDown.Name = "PurCreditNumericUpDown"
        Me.PurCreditNumericUpDown.Size = New System.Drawing.Size(98, 22)
        Me.PurCreditNumericUpDown.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 371)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(708, 207)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PurRemarkTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(700, 181)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Remarks"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PurRemarkTextBox
        '
        Me.PurRemarkTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurRemarkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurTblBindingSource, "PurHis", True))
        Me.PurRemarkTextBox.Location = New System.Drawing.Point(3, 3)
        Me.PurRemarkTextBox.Multiline = True
        Me.PurRemarkTextBox.Name = "PurRemarkTextBox"
        Me.PurRemarkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PurRemarkTextBox.Size = New System.Drawing.Size(694, 175)
        Me.PurRemarkTextBox.TabIndex = 16
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PurHisTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(700, 181)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Repair History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PurDepoDateTimePicker
        '
        Me.PurDepoDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurDepoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PurTblBindingSource, "PurEDate", True))
        Me.PurDepoDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurDepoDateTimePicker.Location = New System.Drawing.Point(472, 113)
        Me.PurDepoDateTimePicker.Name = "PurDepoDateTimePicker"
        Me.PurDepoDateTimePicker.Size = New System.Drawing.Size(217, 22)
        Me.PurDepoDateTimePicker.TabIndex = 7
        '
        'PurDevStatusComboBox
        '
        Me.PurDevStatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurDevStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PurDevStatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurDevStatusComboBox.FormattingEnabled = True
        Me.PurDevStatusComboBox.Items.AddRange(New Object() {"Delivered", "Non Delivered"})
        Me.PurDevStatusComboBox.Location = New System.Drawing.Point(123, 86)
        Me.PurDevStatusComboBox.Name = "PurDevStatusComboBox"
        Me.PurDevStatusComboBox.Size = New System.Drawing.Size(121, 24)
        Me.PurDevStatusComboBox.TabIndex = 11
        '
        'PurQtyNumericUpDown
        '
        Me.PurQtyNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurQtyNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurQtyNumericUpDown.Location = New System.Drawing.Point(590, 85)
        Me.PurQtyNumericUpDown.Name = "PurQtyNumericUpDown"
        Me.PurQtyNumericUpDown.Size = New System.Drawing.Size(98, 22)
        Me.PurQtyNumericUpDown.TabIndex = 31
        '
        'PurAmtNumericUpDown
        '
        Me.PurAmtNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PurAmtNumericUpDown.DecimalPlaces = 2
        Me.PurAmtNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurAmtNumericUpDown.Location = New System.Drawing.Point(144, 112)
        Me.PurAmtNumericUpDown.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.PurAmtNumericUpDown.Name = "PurAmtNumericUpDown"
        Me.PurAmtNumericUpDown.Size = New System.Drawing.Size(98, 22)
        Me.PurAmtNumericUpDown.TabIndex = 32
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.AddPurProLookupBtn)
        Me.GroupBox1.Controls.Add(Me.PurAmtNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.PurOrderNoTextBox)
        Me.GroupBox1.Controls.Add(Me.PurQtyNumericUpDown)
        Me.GroupBox1.Controls.Add(PurOrderNoLabel)
        Me.GroupBox1.Controls.Add(Me.PurDateDateTimePicker)
        Me.GroupBox1.Controls.Add(PurDateLabel)
        Me.GroupBox1.Controls.Add(PurDepoLabel)
        Me.GroupBox1.Controls.Add(Me.PurProdNameTextBox)
        Me.GroupBox1.Controls.Add(Me.PurDepoDateTimePicker)
        Me.GroupBox1.Controls.Add(PurProdNameLabel)
        Me.GroupBox1.Controls.Add(PurAmtLabel)
        Me.GroupBox1.Controls.Add(Me.PurCreditNumericUpDown)
        Me.GroupBox1.Controls.Add(PurQtyLabel)
        Me.GroupBox1.Controls.Add(PurCkassCreditLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(711, 156)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(PurEDateLabel)
        Me.GroupBox2.Controls.Add(Me.PurWarrNoTextBox)
        Me.GroupBox2.Controls.Add(PurDevStatusLabel)
        Me.GroupBox2.Controls.Add(PurWarrNoLabel)
        Me.GroupBox2.Controls.Add(Me.PurDevStatusComboBox)
        Me.GroupBox2.Controls.Add(Me.PurSDateDateTimePicker)
        Me.GroupBox2.Controls.Add(PurSDateLabel)
        Me.GroupBox2.Controls.Add(Me.PurEDateDateTimePicker)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(708, 133)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warrantry Information"
        '
        'PurchaseHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.AddPurHisCnlBtn
        Me.ClientSize = New System.Drawing.Size(736, 657)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.AddPurHisCnlBtn)
        Me.Controls.Add(Me.AddPurHisSaveBtn)
        Me.Controls.Add(PurIDLabel)
        Me.Controls.Add(Me.PurIDTextBox)
        Me.Name = "PurchaseHistoryForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase History"
        CType(Me.PurTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurCreditNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PurQtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurAmtNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents PurTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.PurTblTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PurIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurWarrNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurOrderNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PurSDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PurEDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PurHisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddPurHisSaveBtn As System.Windows.Forms.Button
    Friend WithEvents AddPurHisCnlBtn As System.Windows.Forms.Button
    Friend WithEvents ProdTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.ProdTblTableAdapter
    Friend WithEvents PurProdNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddPurProLookupBtn As System.Windows.Forms.Button
    Friend WithEvents PurCreditNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents PurRemarkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents PurDepoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PurDevStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PurQtyNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents PurAmtNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
