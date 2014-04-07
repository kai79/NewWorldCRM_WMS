<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhForm
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
        Dim WhDevIDLabel As System.Windows.Forms.Label
        Dim WhPoIDLabel As System.Windows.Forms.Label
        Dim WhDateLabel As System.Windows.Forms.Label
        Dim WhProByLabel As System.Windows.Forms.Label
        Dim WhTimeStampLabel As System.Windows.Forms.Label
        Dim WhTypeLabel As System.Windows.Forms.Label
        Dim WhNameLabel As System.Windows.Forms.Label
        Dim WhAddLabel As System.Windows.Forms.Label
        Dim WhCtcLabel As System.Windows.Forms.Label
        Dim WhTranTypeLabel As System.Windows.Forms.Label
        Dim WhDevLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhForm))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.OutgoingPage = New System.Windows.Forms.TabPage()
        Me.WhItemTblDataGridView = New System.Windows.Forms.DataGridView()
        Me.WhItemIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevItemIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdCatDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdNameDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemQtyDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemTranTypeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevDateDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdIDDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemRemarkDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemUpdateDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemSaveDataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemTblBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.WhAddHistoryBtn = New System.Windows.Forms.Button()
        Me.WhCancelBtn = New System.Windows.Forms.Button()
        Me.WhOpenProdBtn = New System.Windows.Forms.Button()
        Me.WhRemoveProdBtn = New System.Windows.Forms.Button()
        Me.WhAddProdBtn = New System.Windows.Forms.Button()
        Me.WhSaveBtn = New System.Windows.Forms.Button()
        Me.WhAddBtn = New System.Windows.Forms.Button()
        Me.OutgoingGroupBox = New System.Windows.Forms.GroupBox()
        Me.WhTranTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.WhCtcTextBox = New System.Windows.Forms.TextBox()
        Me.WhAddTextBox = New System.Windows.Forms.TextBox()
        Me.WhNameTextBox = New System.Windows.Forms.TextBox()
        Me.WhTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.WhTimeStampTextBox = New System.Windows.Forms.TextBox()
        Me.WhProByTextBox = New System.Windows.Forms.TextBox()
        Me.WhDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WhPoIDTextBox = New System.Windows.Forms.TextBox()
        Me.WhDevIDTextBox = New System.Windows.Forms.TextBox()
        Me.TransPage = New System.Windows.Forms.TabPage()
        Me.WhQueryApproveAllBtn = New System.Windows.Forms.Button()
        Me.WhQueryApproveBtn = New System.Windows.Forms.Button()
        Me.WhQueryEditBtn = New System.Windows.Forms.Button()
        Me.WhQueryDeleteBtn = New System.Windows.Forms.Button()
        Me.WhQueryDataGridView = New System.Windows.Forms.DataGridView()
        Me.WhTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WhQueryRefreshBtn = New System.Windows.Forms.Button()
        Me.WhQueryOpenBtn = New System.Windows.Forms.Button()
        Me.WhQuerySearchBtn = New System.Windows.Forms.Button()
        Me.TranOverviewPage = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WhProdCatComboBox = New System.Windows.Forms.ComboBox()
        Me.WhProdLabel = New System.Windows.Forms.Label()
        Me.WhTranTo = New System.Windows.Forms.Label()
        Me.WhProdComboBox = New System.Windows.Forms.ComboBox()
        Me.WhTranBetween = New System.Windows.Forms.Label()
        Me.WhProdCatLabel = New System.Windows.Forms.Label()
        Me.WhTranEndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WhDurationLabel = New System.Windows.Forms.Label()
        Me.WhTranStartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WhTranComboBox = New System.Windows.Forms.ComboBox()
        Me.WhTranLabel = New System.Windows.Forms.Label()
        Me.WhOverviewDetailBtn = New System.Windows.Forms.Button()
        Me.WhOverviewDataGridView = New System.Windows.Forms.DataGridView()
        Me.WhItemTblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WhOverviewBtn = New System.Windows.Forms.Button()
        Me.WhOverviewGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WhProdOutTextBox = New System.Windows.Forms.TextBox()
        Me.WhProdBalancelTextBox = New System.Windows.Forms.TextBox()
        Me.WhProdSaleLabel = New System.Windows.Forms.Label()
        Me.WhProdBalanceLabel = New System.Windows.Forms.Label()
        Me.WhProdInTextBox = New System.Windows.Forms.TextBox()
        Me.ProdManPage = New System.Windows.Forms.TabPage()
        Me.WhProdManDataGridView = New System.Windows.Forms.DataGridView()
        Me.WhProdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhProdCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhProdLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhProdLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhProdCurQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhProdNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhProdEnableDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhProdTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WhDisableBtn = New System.Windows.Forms.Button()
        Me.WhEnableBtn = New System.Windows.Forms.Button()
        Me.WhItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemQtyDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemRemarkDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdCatDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemSaveDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemUpdateDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemTranTypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemTranTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemRemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemSaveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemUpdateDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WhItemTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.WhItemTblTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager()
        Me.WhTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.WhTblTableAdapter()
        Me.WhTblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WhProdTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.WhProdTblTableAdapter()
        Me.WhTranTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhDevIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhPoIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhDevDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhAddDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhCtcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhRecordCounterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhProByDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhTimeStampDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhEdit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemTranTypeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemQtyDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemDevDateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdCatDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemRemarkDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemUpdateDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemSaveDataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        WhDevIDLabel = New System.Windows.Forms.Label()
        WhPoIDLabel = New System.Windows.Forms.Label()
        WhDateLabel = New System.Windows.Forms.Label()
        WhProByLabel = New System.Windows.Forms.Label()
        WhTimeStampLabel = New System.Windows.Forms.Label()
        WhTypeLabel = New System.Windows.Forms.Label()
        WhNameLabel = New System.Windows.Forms.Label()
        WhAddLabel = New System.Windows.Forms.Label()
        WhCtcLabel = New System.Windows.Forms.Label()
        WhTranTypeLabel = New System.Windows.Forms.Label()
        WhDevLabel = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.OutgoingPage.SuspendLayout()
        CType(Me.WhItemTblDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhItemTblBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OutgoingGroupBox.SuspendLayout()
        Me.TransPage.SuspendLayout()
        CType(Me.WhQueryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TranOverviewPage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WhOverviewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhItemTblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WhOverviewGroupBox.SuspendLayout()
        Me.ProdManPage.SuspendLayout()
        CType(Me.WhProdManDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhProdTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhItemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhTblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WhDevIDLabel
        '
        WhDevIDLabel.AutoSize = True
        WhDevIDLabel.Location = New System.Drawing.Point(140, 27)
        WhDevIDLabel.Name = "WhDevIDLabel"
        WhDevIDLabel.Size = New System.Drawing.Size(0, 13)
        WhDevIDLabel.TabIndex = 0
        '
        'WhPoIDLabel
        '
        WhPoIDLabel.AutoSize = True
        WhPoIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhPoIDLabel.Location = New System.Drawing.Point(338, 20)
        WhPoIDLabel.Name = "WhPoIDLabel"
        WhPoIDLabel.Size = New System.Drawing.Size(173, 20)
        WhPoIDLabel.TabIndex = 3
        WhPoIDLabel.Text = "PO Number (采购订单):"
        '
        'WhDateLabel
        '
        WhDateLabel.AutoSize = True
        WhDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhDateLabel.Location = New System.Drawing.Point(588, 19)
        WhDateLabel.Name = "WhDateLabel"
        WhDateLabel.Size = New System.Drawing.Size(185, 20)
        WhDateLabel.TabIndex = 5
        WhDateLabel.Text = "Delivery Date (交货日期):"
        '
        'WhProByLabel
        '
        WhProByLabel.AutoSize = True
        WhProByLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhProByLabel.Location = New System.Drawing.Point(901, 16)
        WhProByLabel.Name = "WhProByLabel"
        WhProByLabel.Size = New System.Drawing.Size(154, 20)
        WhProByLabel.TabIndex = 7
        WhProByLabel.Text = "Process By (处理员):"
        '
        'WhTimeStampLabel
        '
        WhTimeStampLabel.AutoSize = True
        WhTimeStampLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhTimeStampLabel.Location = New System.Drawing.Point(1062, 16)
        WhTimeStampLabel.Name = "WhTimeStampLabel"
        WhTimeStampLabel.Size = New System.Drawing.Size(144, 20)
        WhTimeStampLabel.TabIndex = 9
        WhTimeStampLabel.Text = "Time Stamp (时间):"
        '
        'WhTypeLabel
        '
        WhTypeLabel.AutoSize = True
        WhTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhTypeLabel.Location = New System.Drawing.Point(30, 101)
        WhTypeLabel.Name = "WhTypeLabel"
        WhTypeLabel.Size = New System.Drawing.Size(198, 20)
        WhTypeLabel.TabIndex = 11
        WhTypeLabel.Text = "Customer Type (顾客类型):"
        '
        'WhNameLabel
        '
        WhNameLabel.AutoSize = True
        WhNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhNameLabel.Location = New System.Drawing.Point(251, 101)
        WhNameLabel.Name = "WhNameLabel"
        WhNameLabel.Size = New System.Drawing.Size(178, 20)
        WhNameLabel.TabIndex = 13
        WhNameLabel.Text = "Recipient (接收名/店名):"
        '
        'WhAddLabel
        '
        WhAddLabel.AutoSize = True
        WhAddLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhAddLabel.Location = New System.Drawing.Point(479, 101)
        WhAddLabel.Name = "WhAddLabel"
        WhAddLabel.Size = New System.Drawing.Size(118, 20)
        WhAddLabel.TabIndex = 15
        WhAddLabel.Text = "Address (地址):"
        '
        'WhCtcLabel
        '
        WhCtcLabel.AutoSize = True
        WhCtcLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhCtcLabel.Location = New System.Drawing.Point(1070, 101)
        WhCtcLabel.Name = "WhCtcLabel"
        WhCtcLabel.Size = New System.Drawing.Size(147, 20)
        WhCtcLabel.TabIndex = 17
        WhCtcLabel.Text = "Contact (联络号码):"
        '
        'WhTranTypeLabel
        '
        WhTranTypeLabel.AutoSize = True
        WhTranTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhTranTypeLabel.Location = New System.Drawing.Point(30, 22)
        WhTranTypeLabel.Name = "WhTranTypeLabel"
        WhTranTypeLabel.Size = New System.Drawing.Size(93, 20)
        WhTranTypeLabel.TabIndex = 20
        WhTranTypeLabel.Text = "Type (类型):"
        '
        'WhDevLabel
        '
        WhDevLabel.AutoSize = True
        WhDevLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhDevLabel.Location = New System.Drawing.Point(139, 20)
        WhDevLabel.Name = "WhDevLabel"
        WhDevLabel.Size = New System.Drawing.Size(167, 20)
        WhDevLabel.TabIndex = 22
        WhDevLabel.Text = "Delivery ID (交货号码):"
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.OutgoingPage)
        Me.TabControl.Controls.Add(Me.TransPage)
        Me.TabControl.Controls.Add(Me.TranOverviewPage)
        Me.TabControl.Controls.Add(Me.ProdManPage)
        Me.TabControl.Location = New System.Drawing.Point(1, 1)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1310, 805)
        Me.TabControl.TabIndex = 0
        '
        'OutgoingPage
        '
        Me.OutgoingPage.Controls.Add(Me.WhItemTblDataGridView)
        Me.OutgoingPage.Controls.Add(Me.WhAddHistoryBtn)
        Me.OutgoingPage.Controls.Add(Me.WhCancelBtn)
        Me.OutgoingPage.Controls.Add(Me.WhOpenProdBtn)
        Me.OutgoingPage.Controls.Add(Me.WhRemoveProdBtn)
        Me.OutgoingPage.Controls.Add(Me.WhAddProdBtn)
        Me.OutgoingPage.Controls.Add(Me.WhSaveBtn)
        Me.OutgoingPage.Controls.Add(Me.WhAddBtn)
        Me.OutgoingPage.Controls.Add(Me.OutgoingGroupBox)
        Me.OutgoingPage.Location = New System.Drawing.Point(4, 22)
        Me.OutgoingPage.Name = "OutgoingPage"
        Me.OutgoingPage.Padding = New System.Windows.Forms.Padding(3)
        Me.OutgoingPage.Size = New System.Drawing.Size(1302, 779)
        Me.OutgoingPage.TabIndex = 1
        Me.OutgoingPage.Text = "Transaction"
        Me.OutgoingPage.UseVisualStyleBackColor = True
        '
        'WhItemTblDataGridView
        '
        Me.WhItemTblDataGridView.AllowUserToAddRows = False
        Me.WhItemTblDataGridView.AllowUserToDeleteRows = False
        Me.WhItemTblDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhItemTblDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WhItemTblDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.WhItemTblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WhItemTblDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WhItemIDDataGridViewTextBoxColumn2, Me.WhItemDevItemIDDataGridViewTextBoxColumn1, Me.WhItemDevIDDataGridViewTextBoxColumn3, Me.WhItemProdCatDataGridViewTextBoxColumn3, Me.WhItemProdNameDataGridViewTextBoxColumn3, Me.WhItemQtyDataGridViewTextBoxColumn3, Me.WhItemTranTypeDataGridViewTextBoxColumn3, Me.WhItemDevDateDataGridViewTextBoxColumn3, Me.WhItemProdIDDataGridViewTextBoxColumn3, Me.WhItemRemarkDataGridViewTextBoxColumn3, Me.WhItemUpdateDataGridViewCheckBoxColumn3, Me.WhItemSaveDataGridViewCheckBoxColumn3})
        Me.WhItemTblDataGridView.DataSource = Me.WhItemTblBindingSource2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.WhItemTblDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.WhItemTblDataGridView.Location = New System.Drawing.Point(17, 257)
        Me.WhItemTblDataGridView.Name = "WhItemTblDataGridView"
        Me.WhItemTblDataGridView.ReadOnly = True
        Me.WhItemTblDataGridView.Size = New System.Drawing.Size(1262, 506)
        Me.WhItemTblDataGridView.TabIndex = 22
        '
        'WhItemIDDataGridViewTextBoxColumn2
        '
        Me.WhItemIDDataGridViewTextBoxColumn2.DataPropertyName = "WhItemID"
        Me.WhItemIDDataGridViewTextBoxColumn2.HeaderText = "WhItemID"
        Me.WhItemIDDataGridViewTextBoxColumn2.Name = "WhItemIDDataGridViewTextBoxColumn2"
        Me.WhItemIDDataGridViewTextBoxColumn2.ReadOnly = True
        Me.WhItemIDDataGridViewTextBoxColumn2.Visible = False
        '
        'WhItemDevItemIDDataGridViewTextBoxColumn1
        '
        Me.WhItemDevItemIDDataGridViewTextBoxColumn1.DataPropertyName = "WhItemDevItemID"
        Me.WhItemDevItemIDDataGridViewTextBoxColumn1.HeaderText = "Item ID"
        Me.WhItemDevItemIDDataGridViewTextBoxColumn1.Name = "WhItemDevItemIDDataGridViewTextBoxColumn1"
        Me.WhItemDevItemIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'WhItemDevIDDataGridViewTextBoxColumn3
        '
        Me.WhItemDevIDDataGridViewTextBoxColumn3.DataPropertyName = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn3.HeaderText = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn3.Name = "WhItemDevIDDataGridViewTextBoxColumn3"
        Me.WhItemDevIDDataGridViewTextBoxColumn3.ReadOnly = True
        Me.WhItemDevIDDataGridViewTextBoxColumn3.Visible = False
        '
        'WhItemProdCatDataGridViewTextBoxColumn3
        '
        Me.WhItemProdCatDataGridViewTextBoxColumn3.DataPropertyName = "WhItemProdCat"
        Me.WhItemProdCatDataGridViewTextBoxColumn3.FillWeight = 200.0!
        Me.WhItemProdCatDataGridViewTextBoxColumn3.HeaderText = "Product Category"
        Me.WhItemProdCatDataGridViewTextBoxColumn3.Name = "WhItemProdCatDataGridViewTextBoxColumn3"
        Me.WhItemProdCatDataGridViewTextBoxColumn3.ReadOnly = True
        Me.WhItemProdCatDataGridViewTextBoxColumn3.Width = 200
        '
        'WhItemProdNameDataGridViewTextBoxColumn3
        '
        Me.WhItemProdNameDataGridViewTextBoxColumn3.DataPropertyName = "WhItemProdName"
        Me.WhItemProdNameDataGridViewTextBoxColumn3.FillWeight = 200.0!
        Me.WhItemProdNameDataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.WhItemProdNameDataGridViewTextBoxColumn3.Name = "WhItemProdNameDataGridViewTextBoxColumn3"
        Me.WhItemProdNameDataGridViewTextBoxColumn3.ReadOnly = True
        Me.WhItemProdNameDataGridViewTextBoxColumn3.Width = 200
        '
        'WhItemQtyDataGridViewTextBoxColumn3
        '
        Me.WhItemQtyDataGridViewTextBoxColumn3.DataPropertyName = "WhItemQty"
        Me.WhItemQtyDataGridViewTextBoxColumn3.HeaderText = "Quantity"
        Me.WhItemQtyDataGridViewTextBoxColumn3.Name = "WhItemQtyDataGridViewTextBoxColumn3"
        Me.WhItemQtyDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'WhItemTranTypeDataGridViewTextBoxColumn3
        '
        Me.WhItemTranTypeDataGridViewTextBoxColumn3.DataPropertyName = "WhItemTranType"
        Me.WhItemTranTypeDataGridViewTextBoxColumn3.HeaderText = "WhItemTranType"
        Me.WhItemTranTypeDataGridViewTextBoxColumn3.Name = "WhItemTranTypeDataGridViewTextBoxColumn3"
        Me.WhItemTranTypeDataGridViewTextBoxColumn3.ReadOnly = True
        Me.WhItemTranTypeDataGridViewTextBoxColumn3.Visible = False
        '
        'WhItemDevDateDataGridViewTextBoxColumn3
        '
        Me.WhItemDevDateDataGridViewTextBoxColumn3.DataPropertyName = "WhItemDevDate"
        Me.WhItemDevDateDataGridViewTextBoxColumn3.HeaderText = "WhItemDevDate"
        Me.WhItemDevDateDataGridViewTextBoxColumn3.Name = "WhItemDevDateDataGridViewTextBoxColumn3"
        Me.WhItemDevDateDataGridViewTextBoxColumn3.ReadOnly = True
        Me.WhItemDevDateDataGridViewTextBoxColumn3.Visible = False
        '
        'WhItemProdIDDataGridViewTextBoxColumn3
        '
        Me.WhItemProdIDDataGridViewTextBoxColumn3.DataPropertyName = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn3.HeaderText = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn3.Name = "WhItemProdIDDataGridViewTextBoxColumn3"
        Me.WhItemProdIDDataGridViewTextBoxColumn3.ReadOnly = True
        Me.WhItemProdIDDataGridViewTextBoxColumn3.Visible = False
        '
        'WhItemRemarkDataGridViewTextBoxColumn3
        '
        Me.WhItemRemarkDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WhItemRemarkDataGridViewTextBoxColumn3.DataPropertyName = "WhItemRemark"
        Me.WhItemRemarkDataGridViewTextBoxColumn3.HeaderText = "Remarks"
        Me.WhItemRemarkDataGridViewTextBoxColumn3.Name = "WhItemRemarkDataGridViewTextBoxColumn3"
        Me.WhItemRemarkDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'WhItemUpdateDataGridViewCheckBoxColumn3
        '
        Me.WhItemUpdateDataGridViewCheckBoxColumn3.DataPropertyName = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn3.HeaderText = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn3.Name = "WhItemUpdateDataGridViewCheckBoxColumn3"
        Me.WhItemUpdateDataGridViewCheckBoxColumn3.ReadOnly = True
        Me.WhItemUpdateDataGridViewCheckBoxColumn3.Visible = False
        '
        'WhItemSaveDataGridViewCheckBoxColumn3
        '
        Me.WhItemSaveDataGridViewCheckBoxColumn3.DataPropertyName = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn3.HeaderText = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn3.Name = "WhItemSaveDataGridViewCheckBoxColumn3"
        Me.WhItemSaveDataGridViewCheckBoxColumn3.ReadOnly = True
        Me.WhItemSaveDataGridViewCheckBoxColumn3.Visible = False
        '
        'WhItemTblBindingSource2
        '
        Me.WhItemTblBindingSource2.DataMember = "WhItemTbl"
        Me.WhItemTblBindingSource2.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WhAddHistoryBtn
        '
        Me.WhAddHistoryBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhAddHistoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddHistoryBtn.Image = Global.WindowsApplication1.My.Resources.Resources.address_book_icon
        Me.WhAddHistoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddHistoryBtn.Location = New System.Drawing.Point(1129, 18)
        Me.WhAddHistoryBtn.Name = "WhAddHistoryBtn"
        Me.WhAddHistoryBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddHistoryBtn.TabIndex = 7
        Me.WhAddHistoryBtn.Text = "Address" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "History"
        Me.WhAddHistoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddHistoryBtn.UseVisualStyleBackColor = True
        '
        'WhCancelBtn
        '
        Me.WhCancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.WhCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhCancelBtn.Location = New System.Drawing.Point(177, 19)
        Me.WhCancelBtn.Name = "WhCancelBtn"
        Me.WhCancelBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhCancelBtn.TabIndex = 6
        Me.WhCancelBtn.Text = "Cancel"
        Me.WhCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhCancelBtn.UseVisualStyleBackColor = True
        '
        'WhOpenProdBtn
        '
        Me.WhOpenProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhOpenProdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhOpenProdBtn.Image = Global.WindowsApplication1.My.Resources.Resources.basket_icon
        Me.WhOpenProdBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.WhOpenProdBtn.Location = New System.Drawing.Point(886, 19)
        Me.WhOpenProdBtn.Name = "WhOpenProdBtn"
        Me.WhOpenProdBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhOpenProdBtn.TabIndex = 5
        Me.WhOpenProdBtn.Text = "Open" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product"
        Me.WhOpenProdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhOpenProdBtn.UseVisualStyleBackColor = True
        '
        'WhRemoveProdBtn
        '
        Me.WhRemoveProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhRemoveProdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhRemoveProdBtn.Image = Global.WindowsApplication1.My.Resources.Resources.basket_remove_icon
        Me.WhRemoveProdBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.WhRemoveProdBtn.Location = New System.Drawing.Point(730, 19)
        Me.WhRemoveProdBtn.Name = "WhRemoveProdBtn"
        Me.WhRemoveProdBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhRemoveProdBtn.TabIndex = 4
        Me.WhRemoveProdBtn.Text = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product"
        Me.WhRemoveProdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhRemoveProdBtn.UseVisualStyleBackColor = True
        '
        'WhAddProdBtn
        '
        Me.WhAddProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhAddProdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdBtn.Image = Global.WindowsApplication1.My.Resources.Resources.basket_add_icon
        Me.WhAddProdBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.WhAddProdBtn.Location = New System.Drawing.Point(574, 18)
        Me.WhAddProdBtn.Name = "WhAddProdBtn"
        Me.WhAddProdBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddProdBtn.TabIndex = 3
        Me.WhAddProdBtn.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product"
        Me.WhAddProdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddProdBtn.UseVisualStyleBackColor = True
        '
        'WhSaveBtn
        '
        Me.WhSaveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.save2_icon
        Me.WhSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhSaveBtn.Location = New System.Drawing.Point(333, 19)
        Me.WhSaveBtn.Name = "WhSaveBtn"
        Me.WhSaveBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhSaveBtn.TabIndex = 2
        Me.WhSaveBtn.Text = "Save"
        Me.WhSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhSaveBtn.UseVisualStyleBackColor = True
        '
        'WhAddBtn
        '
        Me.WhAddBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddBtn.Image = Global.WindowsApplication1.My.Resources.Resources.add_icon
        Me.WhAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddBtn.Location = New System.Drawing.Point(21, 18)
        Me.WhAddBtn.Name = "WhAddBtn"
        Me.WhAddBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddBtn.TabIndex = 1
        Me.WhAddBtn.Text = "Add"
        Me.WhAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddBtn.UseVisualStyleBackColor = True
        '
        'OutgoingGroupBox
        '
        Me.OutgoingGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.OutgoingGroupBox.Controls.Add(WhDevLabel)
        Me.OutgoingGroupBox.Controls.Add(WhTranTypeLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhTranTypeComboBox)
        Me.OutgoingGroupBox.Controls.Add(WhCtcLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhCtcTextBox)
        Me.OutgoingGroupBox.Controls.Add(WhAddLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhAddTextBox)
        Me.OutgoingGroupBox.Controls.Add(WhNameLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhNameTextBox)
        Me.OutgoingGroupBox.Controls.Add(WhTypeLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhTypeComboBox)
        Me.OutgoingGroupBox.Controls.Add(WhTimeStampLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhTimeStampTextBox)
        Me.OutgoingGroupBox.Controls.Add(WhProByLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhProByTextBox)
        Me.OutgoingGroupBox.Controls.Add(WhDateLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhDateDateTimePicker)
        Me.OutgoingGroupBox.Controls.Add(WhPoIDLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhPoIDTextBox)
        Me.OutgoingGroupBox.Controls.Add(WhDevIDLabel)
        Me.OutgoingGroupBox.Controls.Add(Me.WhDevIDTextBox)
        Me.OutgoingGroupBox.Location = New System.Drawing.Point(20, 75)
        Me.OutgoingGroupBox.Name = "OutgoingGroupBox"
        Me.OutgoingGroupBox.Size = New System.Drawing.Size(1259, 176)
        Me.OutgoingGroupBox.TabIndex = 0
        Me.OutgoingGroupBox.TabStop = False
        Me.OutgoingGroupBox.Text = "Delivery Order"
        '
        'WhTranTypeComboBox
        '
        Me.WhTranTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhTranTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranTypeComboBox.FormattingEnabled = True
        Me.WhTranTypeComboBox.Items.AddRange(New Object() {"Out", "In"})
        Me.WhTranTypeComboBox.Location = New System.Drawing.Point(34, 49)
        Me.WhTranTypeComboBox.Name = "WhTranTypeComboBox"
        Me.WhTranTypeComboBox.Size = New System.Drawing.Size(89, 28)
        Me.WhTranTypeComboBox.TabIndex = 21
        '
        'WhCtcTextBox
        '
        Me.WhCtcTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhCtcTextBox.Location = New System.Drawing.Point(1077, 124)
        Me.WhCtcTextBox.Name = "WhCtcTextBox"
        Me.WhCtcTextBox.Size = New System.Drawing.Size(160, 26)
        Me.WhCtcTextBox.TabIndex = 18
        '
        'WhAddTextBox
        '
        Me.WhAddTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddTextBox.Location = New System.Drawing.Point(483, 124)
        Me.WhAddTextBox.Name = "WhAddTextBox"
        Me.WhAddTextBox.Size = New System.Drawing.Size(561, 26)
        Me.WhAddTextBox.TabIndex = 16
        '
        'WhNameTextBox
        '
        Me.WhNameTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.WhNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhNameTextBox.Location = New System.Drawing.Point(255, 124)
        Me.WhNameTextBox.Name = "WhNameTextBox"
        Me.WhNameTextBox.Size = New System.Drawing.Size(194, 26)
        Me.WhNameTextBox.TabIndex = 14
        '
        'WhTypeComboBox
        '
        Me.WhTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTypeComboBox.FormattingEnabled = True
        Me.WhTypeComboBox.Items.AddRange(New Object() {"Home", "Company"})
        Me.WhTypeComboBox.Location = New System.Drawing.Point(30, 124)
        Me.WhTypeComboBox.Name = "WhTypeComboBox"
        Me.WhTypeComboBox.Size = New System.Drawing.Size(106, 28)
        Me.WhTypeComboBox.TabIndex = 12
        '
        'WhTimeStampTextBox
        '
        Me.WhTimeStampTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTimeStampTextBox.Location = New System.Drawing.Point(1066, 47)
        Me.WhTimeStampTextBox.Name = "WhTimeStampTextBox"
        Me.WhTimeStampTextBox.ReadOnly = True
        Me.WhTimeStampTextBox.Size = New System.Drawing.Size(171, 26)
        Me.WhTimeStampTextBox.TabIndex = 10
        '
        'WhProByTextBox
        '
        Me.WhProByTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProByTextBox.Location = New System.Drawing.Point(905, 47)
        Me.WhProByTextBox.Name = "WhProByTextBox"
        Me.WhProByTextBox.ReadOnly = True
        Me.WhProByTextBox.Size = New System.Drawing.Size(130, 26)
        Me.WhProByTextBox.TabIndex = 8
        '
        'WhDateDateTimePicker
        '
        Me.WhDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhDateDateTimePicker.Location = New System.Drawing.Point(592, 47)
        Me.WhDateDateTimePicker.Name = "WhDateDateTimePicker"
        Me.WhDateDateTimePicker.Size = New System.Drawing.Size(286, 26)
        Me.WhDateDateTimePicker.TabIndex = 6
        '
        'WhPoIDTextBox
        '
        Me.WhPoIDTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.WhPoIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhPoIDTextBox.Location = New System.Drawing.Point(342, 49)
        Me.WhPoIDTextBox.Name = "WhPoIDTextBox"
        Me.WhPoIDTextBox.Size = New System.Drawing.Size(227, 26)
        Me.WhPoIDTextBox.TabIndex = 4
        '
        'WhDevIDTextBox
        '
        Me.WhDevIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhDevIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhDevIDTextBox.Location = New System.Drawing.Point(143, 49)
        Me.WhDevIDTextBox.Name = "WhDevIDTextBox"
        Me.WhDevIDTextBox.ReadOnly = True
        Me.WhDevIDTextBox.Size = New System.Drawing.Size(172, 26)
        Me.WhDevIDTextBox.TabIndex = 1
        '
        'TransPage
        '
        Me.TransPage.Controls.Add(Me.WhQueryApproveAllBtn)
        Me.TransPage.Controls.Add(Me.WhQueryApproveBtn)
        Me.TransPage.Controls.Add(Me.WhQueryEditBtn)
        Me.TransPage.Controls.Add(Me.WhQueryDeleteBtn)
        Me.TransPage.Controls.Add(Me.WhQueryDataGridView)
        Me.TransPage.Controls.Add(Me.WhQueryRefreshBtn)
        Me.TransPage.Controls.Add(Me.WhQueryOpenBtn)
        Me.TransPage.Controls.Add(Me.WhQuerySearchBtn)
        Me.TransPage.Location = New System.Drawing.Point(4, 22)
        Me.TransPage.Name = "TransPage"
        Me.TransPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TransPage.Size = New System.Drawing.Size(1302, 779)
        Me.TransPage.TabIndex = 2
        Me.TransPage.Text = "Transaction History"
        Me.TransPage.UseVisualStyleBackColor = True
        '
        'WhQueryApproveAllBtn
        '
        Me.WhQueryApproveAllBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhQueryApproveAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhQueryApproveAllBtn.Image = Global.WindowsApplication1.My.Resources.Resources.folder_accept_icon
        Me.WhQueryApproveAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhQueryApproveAllBtn.Location = New System.Drawing.Point(1124, 18)
        Me.WhQueryApproveAllBtn.Name = "WhQueryApproveAllBtn"
        Me.WhQueryApproveAllBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhQueryApproveAllBtn.TabIndex = 11
        Me.WhQueryApproveAllBtn.Text = "Approve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " All"
        Me.WhQueryApproveAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhQueryApproveAllBtn.UseVisualStyleBackColor = True
        '
        'WhQueryApproveBtn
        '
        Me.WhQueryApproveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhQueryApproveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhQueryApproveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.folder_full_accept_icon
        Me.WhQueryApproveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhQueryApproveBtn.Location = New System.Drawing.Point(968, 18)
        Me.WhQueryApproveBtn.Name = "WhQueryApproveBtn"
        Me.WhQueryApproveBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhQueryApproveBtn.TabIndex = 10
        Me.WhQueryApproveBtn.Text = "Approve" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Change"
        Me.WhQueryApproveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhQueryApproveBtn.UseVisualStyleBackColor = True
        '
        'WhQueryEditBtn
        '
        Me.WhQueryEditBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhQueryEditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhQueryEditBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_document_edit_icon
        Me.WhQueryEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhQueryEditBtn.Location = New System.Drawing.Point(489, 18)
        Me.WhQueryEditBtn.Name = "WhQueryEditBtn"
        Me.WhQueryEditBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhQueryEditBtn.TabIndex = 9
        Me.WhQueryEditBtn.Text = "Edit"
        Me.WhQueryEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhQueryEditBtn.UseVisualStyleBackColor = True
        '
        'WhQueryDeleteBtn
        '
        Me.WhQueryDeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhQueryDeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhQueryDeleteBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Trash_icon
        Me.WhQueryDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhQueryDeleteBtn.Location = New System.Drawing.Point(645, 18)
        Me.WhQueryDeleteBtn.Name = "WhQueryDeleteBtn"
        Me.WhQueryDeleteBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhQueryDeleteBtn.TabIndex = 8
        Me.WhQueryDeleteBtn.Text = "Delete"
        Me.WhQueryDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhQueryDeleteBtn.UseVisualStyleBackColor = True
        '
        'WhQueryDataGridView
        '
        Me.WhQueryDataGridView.AllowUserToAddRows = False
        Me.WhQueryDataGridView.AllowUserToDeleteRows = False
        Me.WhQueryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhQueryDataGridView.AutoGenerateColumns = False
        Me.WhQueryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WhQueryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.WhQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WhQueryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WhTranTypeDataGridViewTextBoxColumn, Me.WhDevIDDataGridViewTextBoxColumn, Me.WhPoIDDataGridViewTextBoxColumn, Me.WhDevDateDataGridViewTextBoxColumn, Me.WhTypeDataGridViewTextBoxColumn, Me.WhNameDataGridViewTextBoxColumn, Me.WhAddDataGridViewTextBoxColumn, Me.WhCtcDataGridViewTextBoxColumn, Me.WhRecordCounterDataGridViewTextBoxColumn, Me.WhProByDataGridViewTextBoxColumn, Me.WhTimeStampDataGridViewTextBoxColumn, Me.WhLockUserDataGridViewTextBoxColumn, Me.WhLockDataGridViewCheckBoxColumn, Me.WhEdit})
        Me.WhQueryDataGridView.DataSource = Me.WhTblBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.WhQueryDataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.WhQueryDataGridView.Location = New System.Drawing.Point(26, 91)
        Me.WhQueryDataGridView.Name = "WhQueryDataGridView"
        Me.WhQueryDataGridView.ReadOnly = True
        Me.WhQueryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.WhQueryDataGridView.Size = New System.Drawing.Size(1253, 664)
        Me.WhQueryDataGridView.TabIndex = 4
        '
        'WhTblBindingSource
        '
        Me.WhTblBindingSource.DataMember = "WhTbl"
        Me.WhTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'WhQueryRefreshBtn
        '
        Me.WhQueryRefreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhQueryRefreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhQueryRefreshBtn.Image = Global.WindowsApplication1.My.Resources.Resources.refresh_icon
        Me.WhQueryRefreshBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhQueryRefreshBtn.Location = New System.Drawing.Point(333, 18)
        Me.WhQueryRefreshBtn.Name = "WhQueryRefreshBtn"
        Me.WhQueryRefreshBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhQueryRefreshBtn.TabIndex = 7
        Me.WhQueryRefreshBtn.Text = "Refresh"
        Me.WhQueryRefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhQueryRefreshBtn.UseVisualStyleBackColor = True
        '
        'WhQueryOpenBtn
        '
        Me.WhQueryOpenBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhQueryOpenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhQueryOpenBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Open_icon
        Me.WhQueryOpenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhQueryOpenBtn.Location = New System.Drawing.Point(177, 18)
        Me.WhQueryOpenBtn.Name = "WhQueryOpenBtn"
        Me.WhQueryOpenBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhQueryOpenBtn.TabIndex = 5
        Me.WhQueryOpenBtn.Text = "Open"
        Me.WhQueryOpenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhQueryOpenBtn.UseVisualStyleBackColor = True
        '
        'WhQuerySearchBtn
        '
        Me.WhQuerySearchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhQuerySearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhQuerySearchBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Document_search_icon
        Me.WhQuerySearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhQuerySearchBtn.Location = New System.Drawing.Point(21, 18)
        Me.WhQuerySearchBtn.Name = "WhQuerySearchBtn"
        Me.WhQuerySearchBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhQuerySearchBtn.TabIndex = 3
        Me.WhQuerySearchBtn.Text = "Search"
        Me.WhQuerySearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhQuerySearchBtn.UseVisualStyleBackColor = True
        '
        'TranOverviewPage
        '
        Me.TranOverviewPage.Controls.Add(Me.GroupBox1)
        Me.TranOverviewPage.Controls.Add(Me.WhOverviewDetailBtn)
        Me.TranOverviewPage.Controls.Add(Me.WhOverviewDataGridView)
        Me.TranOverviewPage.Controls.Add(Me.WhOverviewBtn)
        Me.TranOverviewPage.Controls.Add(Me.WhOverviewGroupBox)
        Me.TranOverviewPage.Location = New System.Drawing.Point(4, 22)
        Me.TranOverviewPage.Name = "TranOverviewPage"
        Me.TranOverviewPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TranOverviewPage.Size = New System.Drawing.Size(1302, 779)
        Me.TranOverviewPage.TabIndex = 3
        Me.TranOverviewPage.Text = "Product Summary"
        Me.TranOverviewPage.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.WhProdCatComboBox)
        Me.GroupBox1.Controls.Add(Me.WhProdLabel)
        Me.GroupBox1.Controls.Add(Me.WhTranTo)
        Me.GroupBox1.Controls.Add(Me.WhProdComboBox)
        Me.GroupBox1.Controls.Add(Me.WhTranBetween)
        Me.GroupBox1.Controls.Add(Me.WhProdCatLabel)
        Me.GroupBox1.Controls.Add(Me.WhTranEndDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.WhDurationLabel)
        Me.GroupBox1.Controls.Add(Me.WhTranStartDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.WhTranComboBox)
        Me.GroupBox1.Controls.Add(Me.WhTranLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1245, 97)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Filter"
        '
        'WhProdCatComboBox
        '
        Me.WhProdCatComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhProdCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhProdCatComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdCatComboBox.FormattingEnabled = True
        Me.WhProdCatComboBox.Location = New System.Drawing.Point(27, 50)
        Me.WhProdCatComboBox.Name = "WhProdCatComboBox"
        Me.WhProdCatComboBox.Size = New System.Drawing.Size(193, 28)
        Me.WhProdCatComboBox.TabIndex = 11
        '
        'WhProdLabel
        '
        Me.WhProdLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhProdLabel.AutoSize = True
        Me.WhProdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdLabel.Location = New System.Drawing.Point(289, 25)
        Me.WhProdLabel.Name = "WhProdLabel"
        Me.WhProdLabel.Size = New System.Drawing.Size(114, 20)
        Me.WhProdLabel.TabIndex = 14
        Me.WhProdLabel.Text = "Product (产品):"
        '
        'WhTranTo
        '
        Me.WhTranTo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhTranTo.AutoSize = True
        Me.WhTranTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranTo.Location = New System.Drawing.Point(1062, 51)
        Me.WhTranTo.Name = "WhTranTo"
        Me.WhTranTo.Size = New System.Drawing.Size(27, 20)
        Me.WhTranTo.TabIndex = 23
        Me.WhTranTo.Text = "To"
        '
        'WhProdComboBox
        '
        Me.WhProdComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhProdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhProdComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdComboBox.FormattingEnabled = True
        Me.WhProdComboBox.Location = New System.Drawing.Point(293, 50)
        Me.WhProdComboBox.Name = "WhProdComboBox"
        Me.WhProdComboBox.Size = New System.Drawing.Size(355, 28)
        Me.WhProdComboBox.TabIndex = 13
        '
        'WhTranBetween
        '
        Me.WhTranBetween.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhTranBetween.AutoSize = True
        Me.WhTranBetween.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranBetween.Location = New System.Drawing.Point(872, 51)
        Me.WhTranBetween.Name = "WhTranBetween"
        Me.WhTranBetween.Size = New System.Drawing.Size(72, 20)
        Me.WhTranBetween.TabIndex = 22
        Me.WhTranBetween.Text = "Between"
        '
        'WhProdCatLabel
        '
        Me.WhProdCatLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhProdCatLabel.AutoSize = True
        Me.WhProdCatLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdCatLabel.Location = New System.Drawing.Point(23, 23)
        Me.WhProdCatLabel.Name = "WhProdCatLabel"
        Me.WhProdCatLabel.Size = New System.Drawing.Size(155, 20)
        Me.WhProdCatLabel.TabIndex = 12
        Me.WhProdCatLabel.Text = "Category (产品类别):"
        '
        'WhTranEndDateTimePicker
        '
        Me.WhTranEndDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhTranEndDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranEndDateTimePicker.CustomFormat = ""
        Me.WhTranEndDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.WhTranEndDateTimePicker.Location = New System.Drawing.Point(1095, 48)
        Me.WhTranEndDateTimePicker.Name = "WhTranEndDateTimePicker"
        Me.WhTranEndDateTimePicker.Size = New System.Drawing.Size(106, 26)
        Me.WhTranEndDateTimePicker.TabIndex = 21
        '
        'WhDurationLabel
        '
        Me.WhDurationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhDurationLabel.AutoSize = True
        Me.WhDurationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhDurationLabel.Location = New System.Drawing.Point(872, 23)
        Me.WhDurationLabel.Name = "WhDurationLabel"
        Me.WhDurationLabel.Size = New System.Drawing.Size(120, 20)
        Me.WhDurationLabel.TabIndex = 17
        Me.WhDurationLabel.Text = "Duration (期间):"
        '
        'WhTranStartDateTimePicker
        '
        Me.WhTranStartDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhTranStartDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranStartDateTimePicker.CustomFormat = ""
        Me.WhTranStartDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.WhTranStartDateTimePicker.Location = New System.Drawing.Point(950, 48)
        Me.WhTranStartDateTimePicker.Name = "WhTranStartDateTimePicker"
        Me.WhTranStartDateTimePicker.Size = New System.Drawing.Size(106, 26)
        Me.WhTranStartDateTimePicker.TabIndex = 20
        '
        'WhTranComboBox
        '
        Me.WhTranComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhTranComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhTranComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranComboBox.FormattingEnabled = True
        Me.WhTranComboBox.Items.AddRange(New Object() {"Both", "In", "Out"})
        Me.WhTranComboBox.Location = New System.Drawing.Point(717, 50)
        Me.WhTranComboBox.Name = "WhTranComboBox"
        Me.WhTranComboBox.Size = New System.Drawing.Size(89, 28)
        Me.WhTranComboBox.TabIndex = 18
        '
        'WhTranLabel
        '
        Me.WhTranLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhTranLabel.AutoSize = True
        Me.WhTranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhTranLabel.Location = New System.Drawing.Point(713, 25)
        Me.WhTranLabel.Name = "WhTranLabel"
        Me.WhTranLabel.Size = New System.Drawing.Size(93, 20)
        Me.WhTranLabel.TabIndex = 19
        Me.WhTranLabel.Text = "Type (类型):"
        '
        'WhOverviewDetailBtn
        '
        Me.WhOverviewDetailBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhOverviewDetailBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhOverviewDetailBtn.Image = Global.WindowsApplication1.My.Resources.Resources.SEO_icon
        Me.WhOverviewDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhOverviewDetailBtn.Location = New System.Drawing.Point(21, 18)
        Me.WhOverviewDetailBtn.Name = "WhOverviewDetailBtn"
        Me.WhOverviewDetailBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhOverviewDetailBtn.TabIndex = 24
        Me.WhOverviewDetailBtn.Text = "Summary"
        Me.WhOverviewDetailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhOverviewDetailBtn.UseVisualStyleBackColor = True
        '
        'WhOverviewDataGridView
        '
        Me.WhOverviewDataGridView.AllowUserToAddRows = False
        Me.WhOverviewDataGridView.AllowUserToDeleteRows = False
        Me.WhOverviewDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhOverviewDataGridView.AutoGenerateColumns = False
        Me.WhOverviewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WhOverviewDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.WhOverviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WhOverviewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WhItemTranTypeDataGridViewTextBoxColumn2, Me.WhItemIDDataGridViewTextBoxColumn1, Me.WhItemDevIDDataGridViewTextBoxColumn2, Me.WhItemDevItemIDDataGridViewTextBoxColumn, Me.WhItemProdNameDataGridViewTextBoxColumn2, Me.WhItemQtyDataGridViewTextBoxColumn2, Me.WhItemDevDateDataGridViewTextBoxColumn2, Me.WhItemProdIDDataGridViewTextBoxColumn2, Me.WhItemProdCatDataGridViewTextBoxColumn2, Me.WhItemRemarkDataGridViewTextBoxColumn2, Me.WhItemUpdateDataGridViewCheckBoxColumn2, Me.WhItemSaveDataGridViewCheckBoxColumn2})
        Me.WhOverviewDataGridView.DataSource = Me.WhItemTblBindingSource1
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.WhOverviewDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.WhOverviewDataGridView.Location = New System.Drawing.Point(29, 177)
        Me.WhOverviewDataGridView.Name = "WhOverviewDataGridView"
        Me.WhOverviewDataGridView.ReadOnly = True
        Me.WhOverviewDataGridView.Size = New System.Drawing.Size(1245, 495)
        Me.WhOverviewDataGridView.TabIndex = 8
        '
        'WhItemTblBindingSource1
        '
        Me.WhItemTblBindingSource1.DataMember = "WhItemTbl"
        Me.WhItemTblBindingSource1.DataSource = Me.NewWorldDBDataSet
        '
        'WhOverviewBtn
        '
        Me.WhOverviewBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhOverviewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhOverviewBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Document_search_icon
        Me.WhOverviewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhOverviewBtn.Location = New System.Drawing.Point(177, 18)
        Me.WhOverviewBtn.Name = "WhOverviewBtn"
        Me.WhOverviewBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhOverviewBtn.TabIndex = 15
        Me.WhOverviewBtn.Text = "Search"
        Me.WhOverviewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhOverviewBtn.UseVisualStyleBackColor = True
        '
        'WhOverviewGroupBox
        '
        Me.WhOverviewGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.WhOverviewGroupBox.Controls.Add(Me.Label1)
        Me.WhOverviewGroupBox.Controls.Add(Me.WhProdOutTextBox)
        Me.WhOverviewGroupBox.Controls.Add(Me.WhProdBalancelTextBox)
        Me.WhOverviewGroupBox.Controls.Add(Me.WhProdSaleLabel)
        Me.WhOverviewGroupBox.Controls.Add(Me.WhProdBalanceLabel)
        Me.WhOverviewGroupBox.Controls.Add(Me.WhProdInTextBox)
        Me.WhOverviewGroupBox.Location = New System.Drawing.Point(52, 678)
        Me.WhOverviewGroupBox.Name = "WhOverviewGroupBox"
        Me.WhOverviewGroupBox.Size = New System.Drawing.Size(1200, 81)
        Me.WhOverviewGroupBox.TabIndex = 9
        Me.WhOverviewGroupBox.TabStop = False
        Me.WhOverviewGroupBox.Text = "ProductOverview"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(450, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Out (出量):"
        '
        'WhProdOutTextBox
        '
        Me.WhProdOutTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdOutTextBox.Location = New System.Drawing.Point(541, 33)
        Me.WhProdOutTextBox.Name = "WhProdOutTextBox"
        Me.WhProdOutTextBox.ReadOnly = True
        Me.WhProdOutTextBox.Size = New System.Drawing.Size(150, 26)
        Me.WhProdOutTextBox.TabIndex = 16
        '
        'WhProdBalancelTextBox
        '
        Me.WhProdBalancelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdBalancelTextBox.Location = New System.Drawing.Point(1001, 34)
        Me.WhProdBalancelTextBox.Name = "WhProdBalancelTextBox"
        Me.WhProdBalancelTextBox.ReadOnly = True
        Me.WhProdBalancelTextBox.Size = New System.Drawing.Size(150, 26)
        Me.WhProdBalancelTextBox.TabIndex = 14
        '
        'WhProdSaleLabel
        '
        Me.WhProdSaleLabel.AutoSize = True
        Me.WhProdSaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdSaleLabel.Location = New System.Drawing.Point(32, 31)
        Me.WhProdSaleLabel.Name = "WhProdSaleLabel"
        Me.WhProdSaleLabel.Size = New System.Drawing.Size(73, 20)
        Me.WhProdSaleLabel.TabIndex = 9
        Me.WhProdSaleLabel.Text = "In (进量):"
        '
        'WhProdBalanceLabel
        '
        Me.WhProdBalanceLabel.AutoSize = True
        Me.WhProdBalanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdBalanceLabel.Location = New System.Drawing.Point(870, 36)
        Me.WhProdBalanceLabel.Name = "WhProdBalanceLabel"
        Me.WhProdBalanceLabel.Size = New System.Drawing.Size(125, 20)
        Me.WhProdBalanceLabel.TabIndex = 13
        Me.WhProdBalanceLabel.Text = "Balances (存储):"
        '
        'WhProdInTextBox
        '
        Me.WhProdInTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhProdInTextBox.Location = New System.Drawing.Point(111, 30)
        Me.WhProdInTextBox.Name = "WhProdInTextBox"
        Me.WhProdInTextBox.ReadOnly = True
        Me.WhProdInTextBox.Size = New System.Drawing.Size(150, 26)
        Me.WhProdInTextBox.TabIndex = 11
        '
        'ProdManPage
        '
        Me.ProdManPage.Controls.Add(Me.WhProdManDataGridView)
        Me.ProdManPage.Controls.Add(Me.WhDisableBtn)
        Me.ProdManPage.Controls.Add(Me.WhEnableBtn)
        Me.ProdManPage.Location = New System.Drawing.Point(4, 22)
        Me.ProdManPage.Name = "ProdManPage"
        Me.ProdManPage.Size = New System.Drawing.Size(1302, 779)
        Me.ProdManPage.TabIndex = 4
        Me.ProdManPage.Text = "Product Management"
        Me.ProdManPage.UseVisualStyleBackColor = True
        '
        'WhProdManDataGridView
        '
        Me.WhProdManDataGridView.AllowUserToAddRows = False
        Me.WhProdManDataGridView.AllowUserToDeleteRows = False
        Me.WhProdManDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhProdManDataGridView.AutoGenerateColumns = False
        Me.WhProdManDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WhProdManDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WhProdIDDataGridViewTextBoxColumn, Me.WhProdCatDataGridViewTextBoxColumn, Me.WhProdNameDataGridViewTextBoxColumn, Me.WhProdLockUserDataGridViewTextBoxColumn, Me.WhProdLockDataGridViewCheckBoxColumn, Me.WhProdCurQtyDataGridViewTextBoxColumn, Me.WhProdNoDataGridViewTextBoxColumn, Me.WhProdEnableDataGridViewCheckBoxColumn})
        Me.WhProdManDataGridView.DataSource = Me.WhProdTblBindingSource
        Me.WhProdManDataGridView.Location = New System.Drawing.Point(29, 86)
        Me.WhProdManDataGridView.Name = "WhProdManDataGridView"
        Me.WhProdManDataGridView.ReadOnly = True
        Me.WhProdManDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.WhProdManDataGridView.Size = New System.Drawing.Size(1245, 667)
        Me.WhProdManDataGridView.TabIndex = 27
        '
        'WhProdIDDataGridViewTextBoxColumn
        '
        Me.WhProdIDDataGridViewTextBoxColumn.DataPropertyName = "WhProdID"
        Me.WhProdIDDataGridViewTextBoxColumn.HeaderText = "WhProdID"
        Me.WhProdIDDataGridViewTextBoxColumn.Name = "WhProdIDDataGridViewTextBoxColumn"
        Me.WhProdIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhProdIDDataGridViewTextBoxColumn.Visible = False
        '
        'WhProdCatDataGridViewTextBoxColumn
        '
        Me.WhProdCatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WhProdCatDataGridViewTextBoxColumn.DataPropertyName = "WhProdCat"
        Me.WhProdCatDataGridViewTextBoxColumn.HeaderText = "Product Category"
        Me.WhProdCatDataGridViewTextBoxColumn.Name = "WhProdCatDataGridViewTextBoxColumn"
        Me.WhProdCatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhProdNameDataGridViewTextBoxColumn
        '
        Me.WhProdNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WhProdNameDataGridViewTextBoxColumn.DataPropertyName = "WhProdName"
        Me.WhProdNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.WhProdNameDataGridViewTextBoxColumn.Name = "WhProdNameDataGridViewTextBoxColumn"
        Me.WhProdNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhProdLockUserDataGridViewTextBoxColumn
        '
        Me.WhProdLockUserDataGridViewTextBoxColumn.DataPropertyName = "WhProdLockUser"
        Me.WhProdLockUserDataGridViewTextBoxColumn.HeaderText = "WhProdLockUser"
        Me.WhProdLockUserDataGridViewTextBoxColumn.Name = "WhProdLockUserDataGridViewTextBoxColumn"
        Me.WhProdLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhProdLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'WhProdLockDataGridViewCheckBoxColumn
        '
        Me.WhProdLockDataGridViewCheckBoxColumn.DataPropertyName = "WhProdLock"
        Me.WhProdLockDataGridViewCheckBoxColumn.HeaderText = "WhProdLock"
        Me.WhProdLockDataGridViewCheckBoxColumn.Name = "WhProdLockDataGridViewCheckBoxColumn"
        Me.WhProdLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.WhProdLockDataGridViewCheckBoxColumn.Visible = False
        '
        'WhProdCurQtyDataGridViewTextBoxColumn
        '
        Me.WhProdCurQtyDataGridViewTextBoxColumn.DataPropertyName = "WhProdCurQty"
        Me.WhProdCurQtyDataGridViewTextBoxColumn.HeaderText = "WhProdCurQty"
        Me.WhProdCurQtyDataGridViewTextBoxColumn.Name = "WhProdCurQtyDataGridViewTextBoxColumn"
        Me.WhProdCurQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhProdCurQtyDataGridViewTextBoxColumn.Visible = False
        '
        'WhProdNoDataGridViewTextBoxColumn
        '
        Me.WhProdNoDataGridViewTextBoxColumn.DataPropertyName = "WhProdNo"
        Me.WhProdNoDataGridViewTextBoxColumn.HeaderText = "WhProdNo"
        Me.WhProdNoDataGridViewTextBoxColumn.Name = "WhProdNoDataGridViewTextBoxColumn"
        Me.WhProdNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhProdNoDataGridViewTextBoxColumn.Visible = False
        '
        'WhProdEnableDataGridViewCheckBoxColumn
        '
        Me.WhProdEnableDataGridViewCheckBoxColumn.DataPropertyName = "WhProdEnable"
        Me.WhProdEnableDataGridViewCheckBoxColumn.HeaderText = "Active"
        Me.WhProdEnableDataGridViewCheckBoxColumn.Name = "WhProdEnableDataGridViewCheckBoxColumn"
        Me.WhProdEnableDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'WhProdTblBindingSource
        '
        Me.WhProdTblBindingSource.DataMember = "WhProdTbl"
        Me.WhProdTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'WhDisableBtn
        '
        Me.WhDisableBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhDisableBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhDisableBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.WhDisableBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhDisableBtn.Location = New System.Drawing.Point(185, 17)
        Me.WhDisableBtn.Name = "WhDisableBtn"
        Me.WhDisableBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhDisableBtn.TabIndex = 26
        Me.WhDisableBtn.Text = "Disable"
        Me.WhDisableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhDisableBtn.UseVisualStyleBackColor = True
        '
        'WhEnableBtn
        '
        Me.WhEnableBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhEnableBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhEnableBtn.Image = Global.WindowsApplication1.My.Resources.Resources.check_icon
        Me.WhEnableBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhEnableBtn.Location = New System.Drawing.Point(21, 18)
        Me.WhEnableBtn.Name = "WhEnableBtn"
        Me.WhEnableBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhEnableBtn.TabIndex = 25
        Me.WhEnableBtn.Text = "Enable"
        Me.WhEnableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhEnableBtn.UseVisualStyleBackColor = True
        '
        'WhItemIDDataGridViewTextBoxColumn
        '
        Me.WhItemIDDataGridViewTextBoxColumn.DataPropertyName = "WhItemID"
        Me.WhItemIDDataGridViewTextBoxColumn.HeaderText = "Item ID"
        Me.WhItemIDDataGridViewTextBoxColumn.Name = "WhItemIDDataGridViewTextBoxColumn"
        Me.WhItemIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhItemProdNameDataGridViewTextBoxColumn1
        '
        Me.WhItemProdNameDataGridViewTextBoxColumn1.DataPropertyName = "WhItemProdName"
        Me.WhItemProdNameDataGridViewTextBoxColumn1.FillWeight = 200.0!
        Me.WhItemProdNameDataGridViewTextBoxColumn1.HeaderText = "Product Name"
        Me.WhItemProdNameDataGridViewTextBoxColumn1.Name = "WhItemProdNameDataGridViewTextBoxColumn1"
        Me.WhItemProdNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WhItemProdNameDataGridViewTextBoxColumn1.Width = 200
        '
        'WhItemQtyDataGridViewTextBoxColumn1
        '
        Me.WhItemQtyDataGridViewTextBoxColumn1.DataPropertyName = "WhItemQty"
        Me.WhItemQtyDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.WhItemQtyDataGridViewTextBoxColumn1.Name = "WhItemQtyDataGridViewTextBoxColumn1"
        Me.WhItemQtyDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'WhItemRemarkDataGridViewTextBoxColumn1
        '
        Me.WhItemRemarkDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WhItemRemarkDataGridViewTextBoxColumn1.DataPropertyName = "WhItemRemark"
        Me.WhItemRemarkDataGridViewTextBoxColumn1.HeaderText = "Remarks"
        Me.WhItemRemarkDataGridViewTextBoxColumn1.Name = "WhItemRemarkDataGridViewTextBoxColumn1"
        Me.WhItemRemarkDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'WhItemDevIDDataGridViewTextBoxColumn1
        '
        Me.WhItemDevIDDataGridViewTextBoxColumn1.DataPropertyName = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn1.HeaderText = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn1.Name = "WhItemDevIDDataGridViewTextBoxColumn1"
        Me.WhItemDevIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WhItemDevIDDataGridViewTextBoxColumn1.Visible = False
        '
        'WhItemProdIDDataGridViewTextBoxColumn1
        '
        Me.WhItemProdIDDataGridViewTextBoxColumn1.DataPropertyName = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn1.HeaderText = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn1.Name = "WhItemProdIDDataGridViewTextBoxColumn1"
        Me.WhItemProdIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WhItemProdIDDataGridViewTextBoxColumn1.Visible = False
        '
        'WhItemProdCatDataGridViewTextBoxColumn1
        '
        Me.WhItemProdCatDataGridViewTextBoxColumn1.DataPropertyName = "WhItemProdCat"
        Me.WhItemProdCatDataGridViewTextBoxColumn1.HeaderText = "WhItemProdCat"
        Me.WhItemProdCatDataGridViewTextBoxColumn1.Name = "WhItemProdCatDataGridViewTextBoxColumn1"
        Me.WhItemProdCatDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WhItemProdCatDataGridViewTextBoxColumn1.Visible = False
        '
        'WhItemSaveDataGridViewCheckBoxColumn1
        '
        Me.WhItemSaveDataGridViewCheckBoxColumn1.DataPropertyName = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn1.HeaderText = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn1.Name = "WhItemSaveDataGridViewCheckBoxColumn1"
        Me.WhItemSaveDataGridViewCheckBoxColumn1.ReadOnly = True
        Me.WhItemSaveDataGridViewCheckBoxColumn1.Visible = False
        '
        'WhItemUpdateDataGridViewCheckBoxColumn1
        '
        Me.WhItemUpdateDataGridViewCheckBoxColumn1.DataPropertyName = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn1.HeaderText = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn1.Name = "WhItemUpdateDataGridViewCheckBoxColumn1"
        Me.WhItemUpdateDataGridViewCheckBoxColumn1.ReadOnly = True
        Me.WhItemUpdateDataGridViewCheckBoxColumn1.Visible = False
        '
        'WhItemTranTypeDataGridViewTextBoxColumn1
        '
        Me.WhItemTranTypeDataGridViewTextBoxColumn1.DataPropertyName = "WhItemTranType"
        Me.WhItemTranTypeDataGridViewTextBoxColumn1.HeaderText = "WhItemTranType"
        Me.WhItemTranTypeDataGridViewTextBoxColumn1.Name = "WhItemTranTypeDataGridViewTextBoxColumn1"
        Me.WhItemTranTypeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WhItemTranTypeDataGridViewTextBoxColumn1.Visible = False
        '
        'WhItemDevDateDataGridViewTextBoxColumn1
        '
        Me.WhItemDevDateDataGridViewTextBoxColumn1.DataPropertyName = "WhItemDevDate"
        Me.WhItemDevDateDataGridViewTextBoxColumn1.HeaderText = "WhItemDevDate"
        Me.WhItemDevDateDataGridViewTextBoxColumn1.Name = "WhItemDevDateDataGridViewTextBoxColumn1"
        Me.WhItemDevDateDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WhItemDevDateDataGridViewTextBoxColumn1.Visible = False
        '
        'WhItemDevIDDataGridViewTextBoxColumn
        '
        Me.WhItemDevIDDataGridViewTextBoxColumn.DataPropertyName = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn.HeaderText = "Delivery ID"
        Me.WhItemDevIDDataGridViewTextBoxColumn.Name = "WhItemDevIDDataGridViewTextBoxColumn"
        Me.WhItemDevIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhItemTranTypeDataGridViewTextBoxColumn
        '
        Me.WhItemTranTypeDataGridViewTextBoxColumn.DataPropertyName = "WhItemTranType"
        Me.WhItemTranTypeDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.WhItemTranTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type"
        Me.WhItemTranTypeDataGridViewTextBoxColumn.Name = "WhItemTranTypeDataGridViewTextBoxColumn"
        Me.WhItemTranTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemTranTypeDataGridViewTextBoxColumn.Width = 150
        '
        'WhItemDevDateDataGridViewTextBoxColumn
        '
        Me.WhItemDevDateDataGridViewTextBoxColumn.DataPropertyName = "WhItemDevDate"
        Me.WhItemDevDateDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.WhItemDevDateDataGridViewTextBoxColumn.HeaderText = "Delivery Date"
        Me.WhItemDevDateDataGridViewTextBoxColumn.Name = "WhItemDevDateDataGridViewTextBoxColumn"
        Me.WhItemDevDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemDevDateDataGridViewTextBoxColumn.Width = 150
        '
        'WhItemProdNameDataGridViewTextBoxColumn
        '
        Me.WhItemProdNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WhItemProdNameDataGridViewTextBoxColumn.DataPropertyName = "WhItemProdName"
        Me.WhItemProdNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.WhItemProdNameDataGridViewTextBoxColumn.Name = "WhItemProdNameDataGridViewTextBoxColumn"
        Me.WhItemProdNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhItemQtyDataGridViewTextBoxColumn
        '
        Me.WhItemQtyDataGridViewTextBoxColumn.DataPropertyName = "WhItemQty"
        Me.WhItemQtyDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.WhItemQtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.WhItemQtyDataGridViewTextBoxColumn.Name = "WhItemQtyDataGridViewTextBoxColumn"
        Me.WhItemQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemQtyDataGridViewTextBoxColumn.Width = 150
        '
        'WhItemProdIDDataGridViewTextBoxColumn
        '
        Me.WhItemProdIDDataGridViewTextBoxColumn.DataPropertyName = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn.HeaderText = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn.Name = "WhItemProdIDDataGridViewTextBoxColumn"
        Me.WhItemProdIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemProdIDDataGridViewTextBoxColumn.Visible = False
        '
        'WhItemProdCatDataGridViewTextBoxColumn
        '
        Me.WhItemProdCatDataGridViewTextBoxColumn.DataPropertyName = "WhItemProdCat"
        Me.WhItemProdCatDataGridViewTextBoxColumn.HeaderText = "WhItemProdCat"
        Me.WhItemProdCatDataGridViewTextBoxColumn.Name = "WhItemProdCatDataGridViewTextBoxColumn"
        Me.WhItemProdCatDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemProdCatDataGridViewTextBoxColumn.Visible = False
        '
        'WhItemRemarkDataGridViewTextBoxColumn
        '
        Me.WhItemRemarkDataGridViewTextBoxColumn.DataPropertyName = "WhItemRemark"
        Me.WhItemRemarkDataGridViewTextBoxColumn.HeaderText = "WhItemRemark"
        Me.WhItemRemarkDataGridViewTextBoxColumn.Name = "WhItemRemarkDataGridViewTextBoxColumn"
        Me.WhItemRemarkDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemRemarkDataGridViewTextBoxColumn.Visible = False
        '
        'WhItemSaveDataGridViewCheckBoxColumn
        '
        Me.WhItemSaveDataGridViewCheckBoxColumn.DataPropertyName = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn.HeaderText = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn.Name = "WhItemSaveDataGridViewCheckBoxColumn"
        Me.WhItemSaveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.WhItemSaveDataGridViewCheckBoxColumn.Visible = False
        '
        'WhItemUpdateDataGridViewCheckBoxColumn
        '
        Me.WhItemUpdateDataGridViewCheckBoxColumn.DataPropertyName = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn.HeaderText = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn.Name = "WhItemUpdateDataGridViewCheckBoxColumn"
        Me.WhItemUpdateDataGridViewCheckBoxColumn.ReadOnly = True
        Me.WhItemUpdateDataGridViewCheckBoxColumn.Visible = False
        '
        'WhItemTblBindingSource
        '
        Me.WhItemTblBindingSource.DataMember = "WhItemTbl"
        Me.WhItemTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'WhItemTblTableAdapter
        '
        Me.WhItemTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClsTblTableAdapter = Nothing
        Me.TableAdapterManager.MemTblTableAdapter = Nothing
        Me.TableAdapterManager.MenuTblTableAdapter = Nothing
        Me.TableAdapterManager.ProdTblTableAdapter = Nothing
        Me.TableAdapterManager.PurTblTableAdapter = Nothing
        Me.TableAdapterManager.RootTblTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WhCusTblTableAdapter = Nothing
        Me.TableAdapterManager.WhItemTblTableAdapter = Me.WhItemTblTableAdapter
        Me.TableAdapterManager.WhProdTblTableAdapter = Nothing
        Me.TableAdapterManager.WhTblTableAdapter = Nothing
        '
        'WhTblTableAdapter
        '
        Me.WhTblTableAdapter.ClearBeforeFill = True
        '
        'WhTblBindingSource1
        '
        Me.WhTblBindingSource1.DataMember = "WhTbl"
        Me.WhTblBindingSource1.DataSource = Me.NewWorldDBDataSet
        '
        'WhProdTblTableAdapter
        '
        Me.WhProdTblTableAdapter.ClearBeforeFill = True
        '
        'WhTranTypeDataGridViewTextBoxColumn
        '
        Me.WhTranTypeDataGridViewTextBoxColumn.DataPropertyName = "WhTranType"
        Me.WhTranTypeDataGridViewTextBoxColumn.HeaderText = "Transaction Type"
        Me.WhTranTypeDataGridViewTextBoxColumn.Name = "WhTranTypeDataGridViewTextBoxColumn"
        Me.WhTranTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhDevIDDataGridViewTextBoxColumn
        '
        Me.WhDevIDDataGridViewTextBoxColumn.DataPropertyName = "WhDevID"
        Me.WhDevIDDataGridViewTextBoxColumn.HeaderText = "Delivery ID"
        Me.WhDevIDDataGridViewTextBoxColumn.Name = "WhDevIDDataGridViewTextBoxColumn"
        Me.WhDevIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhPoIDDataGridViewTextBoxColumn
        '
        Me.WhPoIDDataGridViewTextBoxColumn.DataPropertyName = "WhPoID"
        Me.WhPoIDDataGridViewTextBoxColumn.HeaderText = "PO Number"
        Me.WhPoIDDataGridViewTextBoxColumn.Name = "WhPoIDDataGridViewTextBoxColumn"
        Me.WhPoIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhDevDateDataGridViewTextBoxColumn
        '
        Me.WhDevDateDataGridViewTextBoxColumn.DataPropertyName = "WhDevDate"
        Me.WhDevDateDataGridViewTextBoxColumn.HeaderText = "Delivery Date"
        Me.WhDevDateDataGridViewTextBoxColumn.Name = "WhDevDateDataGridViewTextBoxColumn"
        Me.WhDevDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhTypeDataGridViewTextBoxColumn
        '
        Me.WhTypeDataGridViewTextBoxColumn.DataPropertyName = "WhType"
        Me.WhTypeDataGridViewTextBoxColumn.HeaderText = "Customer Type"
        Me.WhTypeDataGridViewTextBoxColumn.Name = "WhTypeDataGridViewTextBoxColumn"
        Me.WhTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhNameDataGridViewTextBoxColumn
        '
        Me.WhNameDataGridViewTextBoxColumn.DataPropertyName = "WhName"
        Me.WhNameDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.WhNameDataGridViewTextBoxColumn.HeaderText = "Delivery To"
        Me.WhNameDataGridViewTextBoxColumn.Name = "WhNameDataGridViewTextBoxColumn"
        Me.WhNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhAddDataGridViewTextBoxColumn
        '
        Me.WhAddDataGridViewTextBoxColumn.DataPropertyName = "WhAdd"
        Me.WhAddDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.WhAddDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.WhAddDataGridViewTextBoxColumn.Name = "WhAddDataGridViewTextBoxColumn"
        Me.WhAddDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhCtcDataGridViewTextBoxColumn
        '
        Me.WhCtcDataGridViewTextBoxColumn.DataPropertyName = "WhCtc"
        Me.WhCtcDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.WhCtcDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.WhCtcDataGridViewTextBoxColumn.Name = "WhCtcDataGridViewTextBoxColumn"
        Me.WhCtcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhRecordCounterDataGridViewTextBoxColumn
        '
        Me.WhRecordCounterDataGridViewTextBoxColumn.DataPropertyName = "WhRecordCounter"
        Me.WhRecordCounterDataGridViewTextBoxColumn.HeaderText = "WhRecordCounter"
        Me.WhRecordCounterDataGridViewTextBoxColumn.Name = "WhRecordCounterDataGridViewTextBoxColumn"
        Me.WhRecordCounterDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhRecordCounterDataGridViewTextBoxColumn.Visible = False
        '
        'WhProByDataGridViewTextBoxColumn
        '
        Me.WhProByDataGridViewTextBoxColumn.DataPropertyName = "WhProBy"
        Me.WhProByDataGridViewTextBoxColumn.HeaderText = "Process By"
        Me.WhProByDataGridViewTextBoxColumn.Name = "WhProByDataGridViewTextBoxColumn"
        Me.WhProByDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhTimeStampDataGridViewTextBoxColumn
        '
        Me.WhTimeStampDataGridViewTextBoxColumn.DataPropertyName = "WhTimeStamp"
        Me.WhTimeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp"
        Me.WhTimeStampDataGridViewTextBoxColumn.Name = "WhTimeStampDataGridViewTextBoxColumn"
        Me.WhTimeStampDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhLockUserDataGridViewTextBoxColumn
        '
        Me.WhLockUserDataGridViewTextBoxColumn.DataPropertyName = "WhLockUser"
        Me.WhLockUserDataGridViewTextBoxColumn.HeaderText = "WhLockUser"
        Me.WhLockUserDataGridViewTextBoxColumn.Name = "WhLockUserDataGridViewTextBoxColumn"
        Me.WhLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'WhLockDataGridViewCheckBoxColumn
        '
        Me.WhLockDataGridViewCheckBoxColumn.DataPropertyName = "WhLock"
        Me.WhLockDataGridViewCheckBoxColumn.HeaderText = "WhLock"
        Me.WhLockDataGridViewCheckBoxColumn.Name = "WhLockDataGridViewCheckBoxColumn"
        Me.WhLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.WhLockDataGridViewCheckBoxColumn.Visible = False
        '
        'WhEdit
        '
        Me.WhEdit.DataPropertyName = "WhEdit"
        Me.WhEdit.FillWeight = 60.0!
        Me.WhEdit.HeaderText = "Edited"
        Me.WhEdit.Name = "WhEdit"
        Me.WhEdit.ReadOnly = True
        '
        'WhItemTranTypeDataGridViewTextBoxColumn2
        '
        Me.WhItemTranTypeDataGridViewTextBoxColumn2.DataPropertyName = "WhItemTranType"
        Me.WhItemTranTypeDataGridViewTextBoxColumn2.FillWeight = 102.4958!
        Me.WhItemTranTypeDataGridViewTextBoxColumn2.HeaderText = "Transaction Type"
        Me.WhItemTranTypeDataGridViewTextBoxColumn2.Name = "WhItemTranTypeDataGridViewTextBoxColumn2"
        Me.WhItemTranTypeDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'WhItemIDDataGridViewTextBoxColumn1
        '
        Me.WhItemIDDataGridViewTextBoxColumn1.DataPropertyName = "WhItemID"
        Me.WhItemIDDataGridViewTextBoxColumn1.HeaderText = "WhItemID"
        Me.WhItemIDDataGridViewTextBoxColumn1.Name = "WhItemIDDataGridViewTextBoxColumn1"
        Me.WhItemIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.WhItemIDDataGridViewTextBoxColumn1.Visible = False
        '
        'WhItemDevIDDataGridViewTextBoxColumn2
        '
        Me.WhItemDevIDDataGridViewTextBoxColumn2.DataPropertyName = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn2.FillWeight = 100.115!
        Me.WhItemDevIDDataGridViewTextBoxColumn2.HeaderText = "Delivery ID"
        Me.WhItemDevIDDataGridViewTextBoxColumn2.Name = "WhItemDevIDDataGridViewTextBoxColumn2"
        Me.WhItemDevIDDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'WhItemDevItemIDDataGridViewTextBoxColumn
        '
        Me.WhItemDevItemIDDataGridViewTextBoxColumn.DataPropertyName = "WhItemDevItemID"
        Me.WhItemDevItemIDDataGridViewTextBoxColumn.FillWeight = 68.92415!
        Me.WhItemDevItemIDDataGridViewTextBoxColumn.HeaderText = "Item ID"
        Me.WhItemDevItemIDDataGridViewTextBoxColumn.Name = "WhItemDevItemIDDataGridViewTextBoxColumn"
        Me.WhItemDevItemIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhItemProdNameDataGridViewTextBoxColumn2
        '
        Me.WhItemProdNameDataGridViewTextBoxColumn2.DataPropertyName = "WhItemProdName"
        Me.WhItemProdNameDataGridViewTextBoxColumn2.FillWeight = 373.446!
        Me.WhItemProdNameDataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.WhItemProdNameDataGridViewTextBoxColumn2.Name = "WhItemProdNameDataGridViewTextBoxColumn2"
        Me.WhItemProdNameDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'WhItemQtyDataGridViewTextBoxColumn2
        '
        Me.WhItemQtyDataGridViewTextBoxColumn2.DataPropertyName = "WhItemQty"
        Me.WhItemQtyDataGridViewTextBoxColumn2.FillWeight = 46.13446!
        Me.WhItemQtyDataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.WhItemQtyDataGridViewTextBoxColumn2.Name = "WhItemQtyDataGridViewTextBoxColumn2"
        Me.WhItemQtyDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'WhItemDevDateDataGridViewTextBoxColumn2
        '
        Me.WhItemDevDateDataGridViewTextBoxColumn2.DataPropertyName = "WhItemDevDate"
        Me.WhItemDevDateDataGridViewTextBoxColumn2.FillWeight = 78.88464!
        Me.WhItemDevDateDataGridViewTextBoxColumn2.HeaderText = "Delivery Date"
        Me.WhItemDevDateDataGridViewTextBoxColumn2.Name = "WhItemDevDateDataGridViewTextBoxColumn2"
        Me.WhItemDevDateDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'WhItemProdIDDataGridViewTextBoxColumn2
        '
        Me.WhItemProdIDDataGridViewTextBoxColumn2.DataPropertyName = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn2.HeaderText = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn2.Name = "WhItemProdIDDataGridViewTextBoxColumn2"
        Me.WhItemProdIDDataGridViewTextBoxColumn2.ReadOnly = True
        Me.WhItemProdIDDataGridViewTextBoxColumn2.Visible = False
        '
        'WhItemProdCatDataGridViewTextBoxColumn2
        '
        Me.WhItemProdCatDataGridViewTextBoxColumn2.DataPropertyName = "WhItemProdCat"
        Me.WhItemProdCatDataGridViewTextBoxColumn2.HeaderText = "WhItemProdCat"
        Me.WhItemProdCatDataGridViewTextBoxColumn2.Name = "WhItemProdCatDataGridViewTextBoxColumn2"
        Me.WhItemProdCatDataGridViewTextBoxColumn2.ReadOnly = True
        Me.WhItemProdCatDataGridViewTextBoxColumn2.Visible = False
        '
        'WhItemRemarkDataGridViewTextBoxColumn2
        '
        Me.WhItemRemarkDataGridViewTextBoxColumn2.DataPropertyName = "WhItemRemark"
        Me.WhItemRemarkDataGridViewTextBoxColumn2.HeaderText = "WhItemRemark"
        Me.WhItemRemarkDataGridViewTextBoxColumn2.Name = "WhItemRemarkDataGridViewTextBoxColumn2"
        Me.WhItemRemarkDataGridViewTextBoxColumn2.ReadOnly = True
        Me.WhItemRemarkDataGridViewTextBoxColumn2.Visible = False
        '
        'WhItemUpdateDataGridViewCheckBoxColumn2
        '
        Me.WhItemUpdateDataGridViewCheckBoxColumn2.DataPropertyName = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn2.HeaderText = "WhItemUpdate"
        Me.WhItemUpdateDataGridViewCheckBoxColumn2.Name = "WhItemUpdateDataGridViewCheckBoxColumn2"
        Me.WhItemUpdateDataGridViewCheckBoxColumn2.ReadOnly = True
        Me.WhItemUpdateDataGridViewCheckBoxColumn2.Visible = False
        '
        'WhItemSaveDataGridViewCheckBoxColumn2
        '
        Me.WhItemSaveDataGridViewCheckBoxColumn2.DataPropertyName = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn2.HeaderText = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn2.Name = "WhItemSaveDataGridViewCheckBoxColumn2"
        Me.WhItemSaveDataGridViewCheckBoxColumn2.ReadOnly = True
        Me.WhItemSaveDataGridViewCheckBoxColumn2.Visible = False
        '
        'WhForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 805)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WhForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New World Inventory Management"
        Me.TabControl.ResumeLayout(False)
        Me.OutgoingPage.ResumeLayout(False)
        CType(Me.WhItemTblDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhItemTblBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OutgoingGroupBox.ResumeLayout(False)
        Me.OutgoingGroupBox.PerformLayout()
        Me.TransPage.ResumeLayout(False)
        CType(Me.WhQueryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TranOverviewPage.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.WhOverviewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhItemTblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WhOverviewGroupBox.ResumeLayout(False)
        Me.WhOverviewGroupBox.PerformLayout()
        Me.ProdManPage.ResumeLayout(False)
        CType(Me.WhProdManDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhProdTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhItemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhTblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents OutgoingPage As System.Windows.Forms.TabPage
    Friend WithEvents OutgoingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents WhDevIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhPoIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TransPage As System.Windows.Forms.TabPage
    Friend WithEvents WhCtcTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhAddTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WhTimeStampTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhProByTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhSaveBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddBtn As System.Windows.Forms.Button
    Friend WithEvents WhOpenProdBtn As System.Windows.Forms.Button
    Friend WithEvents WhRemoveProdBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddProdBtn As System.Windows.Forms.Button
    Friend WithEvents WhCancelBtn As System.Windows.Forms.Button
    Friend WithEvents WhTranTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents WhItemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WhItemTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.WhItemTblTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WhItemTblDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WhQuerySearchBtn As System.Windows.Forms.Button
    Friend WithEvents WhQueryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WhTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WhTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.WhTblTableAdapter
    Friend WithEvents WhQueryOpenBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddHistoryBtn As System.Windows.Forms.Button
    Friend WithEvents TranOverviewPage As System.Windows.Forms.TabPage
    Friend WithEvents WhOverviewDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WhOverviewGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents WhProdCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WhProdCatLabel As System.Windows.Forms.Label
    Friend WithEvents WhProdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WhProdLabel As System.Windows.Forms.Label
    Friend WithEvents WhOverviewBtn As System.Windows.Forms.Button
    Friend WithEvents WhDurationLabel As System.Windows.Forms.Label
    Friend WithEvents WhProdSaleLabel As System.Windows.Forms.Label
    Friend WithEvents WhProdInTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhItemTblBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents WhProdBalancelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhProdBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents WhQueryRefreshBtn As System.Windows.Forms.Button
    Friend WithEvents WhTranLabel As System.Windows.Forms.Label
    Friend WithEvents WhTranComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WhItemDevIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemTranTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdCatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemRemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemSaveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhItemUpdateDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhItemTblBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents WhItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemQtyDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemRemarkDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdCatDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemSaveDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhItemUpdateDataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhItemTranTypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevDateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhQueryDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents WhItemIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevItemIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevIDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdCatDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdNameDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemQtyDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemTranTypeDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevDateDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdIDDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemRemarkDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemUpdateDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhItemSaveDataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhQueryEditBtn As System.Windows.Forms.Button
    Friend WithEvents WhTranTo As System.Windows.Forms.Label
    Friend WithEvents WhTranBetween As System.Windows.Forms.Label
    Friend WithEvents WhTranEndDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents WhTranStartDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WhProdOutTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhOverviewDetailBtn As System.Windows.Forms.Button
    Friend WithEvents WhQueryApproveBtn As System.Windows.Forms.Button
    Friend WithEvents ProdManPage As System.Windows.Forms.TabPage
    Friend WithEvents WhEnableBtn As System.Windows.Forms.Button
    Friend WithEvents WhDisableBtn As System.Windows.Forms.Button
    Friend WithEvents WhProdManDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WhTblBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents WhProdTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WhProdTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.WhProdTblTableAdapter
    Friend WithEvents WhProdIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhProdCatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhProdLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhProdLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhProdCurQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhProdNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhProdEnableDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhQueryApproveAllBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WhTranTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhDevIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhPoIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhDevDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhAddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhCtcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhRecordCounterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhProByDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhTimeStampDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhEdit As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhItemTranTypeDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemQtyDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemDevDateDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdCatDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemRemarkDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemUpdateDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents WhItemSaveDataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
