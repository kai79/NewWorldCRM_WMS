<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhViewForm
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
        Dim WhViewDevIDLabel As System.Windows.Forms.Label
        Dim WhViewPoIDLabel As System.Windows.Forms.Label
        Dim WhViewProByLabel As System.Windows.Forms.Label
        Dim WhViewTimeStampLabel As System.Windows.Forms.Label
        Dim WhViewTypeLabel As System.Windows.Forms.Label
        Dim WhViewNameLabel As System.Windows.Forms.Label
        Dim WhViewAddLabel As System.Windows.Forms.Label
        Dim WhViewCtcLabel As System.Windows.Forms.Label
        Dim WhViewTranTypeLabel As System.Windows.Forms.Label
        Dim WhViewDevDateLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhViewForm))
        Me.WhViewTimeStampTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewProByTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewPONoTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewDevNoTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewCtcTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewAddTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewDevToTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewCusTypeTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewTranTypeTxtBox = New System.Windows.Forms.TextBox()
        Me.WhViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.WhItemDevIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemProdCatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemRemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WhItemSaveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WhItemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.WhItemTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.WhItemTblTableAdapter()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.WhViewClose = New System.Windows.Forms.Button()
        Me.WhViewDevDateTxtBox = New System.Windows.Forms.TextBox()
        WhViewDevIDLabel = New System.Windows.Forms.Label()
        WhViewPoIDLabel = New System.Windows.Forms.Label()
        WhViewProByLabel = New System.Windows.Forms.Label()
        WhViewTimeStampLabel = New System.Windows.Forms.Label()
        WhViewTypeLabel = New System.Windows.Forms.Label()
        WhViewNameLabel = New System.Windows.Forms.Label()
        WhViewAddLabel = New System.Windows.Forms.Label()
        WhViewCtcLabel = New System.Windows.Forms.Label()
        WhViewTranTypeLabel = New System.Windows.Forms.Label()
        WhViewDevDateLabel = New System.Windows.Forms.Label()
        CType(Me.WhViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WhItemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'WhViewDevIDLabel
        '
        WhViewDevIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewDevIDLabel.AutoSize = True
        WhViewDevIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewDevIDLabel.Location = New System.Drawing.Point(563, 36)
        WhViewDevIDLabel.Name = "WhViewDevIDLabel"
        WhViewDevIDLabel.Size = New System.Drawing.Size(167, 20)
        WhViewDevIDLabel.TabIndex = 1
        WhViewDevIDLabel.Text = "Delivery ID (交货号码):"
        '
        'WhViewPoIDLabel
        '
        WhViewPoIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewPoIDLabel.AutoSize = True
        WhViewPoIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewPoIDLabel.Location = New System.Drawing.Point(596, 65)
        WhViewPoIDLabel.Name = "WhViewPoIDLabel"
        WhViewPoIDLabel.Size = New System.Drawing.Size(137, 20)
        WhViewPoIDLabel.TabIndex = 3
        WhViewPoIDLabel.Text = "PO No (采购订单):"
        '
        'WhViewProByLabel
        '
        WhViewProByLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewProByLabel.AutoSize = True
        WhViewProByLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewProByLabel.Location = New System.Drawing.Point(576, 129)
        WhViewProByLabel.Name = "WhViewProByLabel"
        WhViewProByLabel.Size = New System.Drawing.Size(154, 20)
        WhViewProByLabel.TabIndex = 5
        WhViewProByLabel.Text = "Process By (处理员):"
        '
        'WhViewTimeStampLabel
        '
        WhViewTimeStampLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewTimeStampLabel.AutoSize = True
        WhViewTimeStampLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewTimeStampLabel.Location = New System.Drawing.Point(596, 158)
        WhViewTimeStampLabel.Name = "WhViewTimeStampLabel"
        WhViewTimeStampLabel.Size = New System.Drawing.Size(137, 20)
        WhViewTimeStampLabel.TabIndex = 7
        WhViewTimeStampLabel.Text = "Timestamp (时间):"
        '
        'WhViewTypeLabel
        '
        WhViewTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewTypeLabel.AutoSize = True
        WhViewTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewTypeLabel.Location = New System.Drawing.Point(12, 65)
        WhViewTypeLabel.Name = "WhViewTypeLabel"
        WhViewTypeLabel.Size = New System.Drawing.Size(194, 20)
        WhViewTypeLabel.TabIndex = 9
        WhViewTypeLabel.Text = "CustomerType (顾客类型):"
        '
        'WhViewNameLabel
        '
        WhViewNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewNameLabel.AutoSize = True
        WhViewNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewNameLabel.Location = New System.Drawing.Point(70, 93)
        WhViewNameLabel.Name = "WhViewNameLabel"
        WhViewNameLabel.Size = New System.Drawing.Size(136, 20)
        WhViewNameLabel.TabIndex = 11
        WhViewNameLabel.Text = "Delivery To (接收):"
        '
        'WhViewAddLabel
        '
        WhViewAddLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewAddLabel.AutoSize = True
        WhViewAddLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewAddLabel.Location = New System.Drawing.Point(88, 119)
        WhViewAddLabel.Name = "WhViewAddLabel"
        WhViewAddLabel.Size = New System.Drawing.Size(118, 20)
        WhViewAddLabel.TabIndex = 13
        WhViewAddLabel.Text = "Address (地址):"
        '
        'WhViewCtcLabel
        '
        WhViewCtcLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewCtcLabel.AutoSize = True
        WhViewCtcLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewCtcLabel.Location = New System.Drawing.Point(59, 210)
        WhViewCtcLabel.Name = "WhViewCtcLabel"
        WhViewCtcLabel.Size = New System.Drawing.Size(147, 20)
        WhViewCtcLabel.TabIndex = 15
        WhViewCtcLabel.Text = "Contact (联络号码):"
        '
        'WhViewTranTypeLabel
        '
        WhViewTranTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewTranTypeLabel.AutoSize = True
        WhViewTranTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewTranTypeLabel.Location = New System.Drawing.Point(26, 36)
        WhViewTranTypeLabel.Name = "WhViewTranTypeLabel"
        WhViewTranTypeLabel.Size = New System.Drawing.Size(180, 20)
        WhViewTranTypeLabel.TabIndex = 25
        WhViewTranTypeLabel.Text = "Transaction Type (类型):"
        '
        'WhViewDevDateLabel
        '
        WhViewDevDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        WhViewDevDateLabel.AutoSize = True
        WhViewDevDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhViewDevDateLabel.Location = New System.Drawing.Point(549, 97)
        WhViewDevDateLabel.Name = "WhViewDevDateLabel"
        WhViewDevDateLabel.Size = New System.Drawing.Size(185, 20)
        WhViewDevDateLabel.TabIndex = 36
        WhViewDevDateLabel.Text = "Delivery Date (交货日期):"
        '
        'WhViewTimeStampTxtBox
        '
        Me.WhViewTimeStampTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewTimeStampTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewTimeStampTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewTimeStampTxtBox.Location = New System.Drawing.Point(739, 155)
        Me.WhViewTimeStampTxtBox.Name = "WhViewTimeStampTxtBox"
        Me.WhViewTimeStampTxtBox.ReadOnly = True
        Me.WhViewTimeStampTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewTimeStampTxtBox.TabIndex = 34
        '
        'WhViewProByTxtBox
        '
        Me.WhViewProByTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewProByTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewProByTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewProByTxtBox.Location = New System.Drawing.Point(739, 126)
        Me.WhViewProByTxtBox.Name = "WhViewProByTxtBox"
        Me.WhViewProByTxtBox.ReadOnly = True
        Me.WhViewProByTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewProByTxtBox.TabIndex = 33
        '
        'WhViewPONoTxtBox
        '
        Me.WhViewPONoTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewPONoTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewPONoTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewPONoTxtBox.Location = New System.Drawing.Point(739, 62)
        Me.WhViewPONoTxtBox.Name = "WhViewPONoTxtBox"
        Me.WhViewPONoTxtBox.ReadOnly = True
        Me.WhViewPONoTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewPONoTxtBox.TabIndex = 32
        '
        'WhViewDevNoTxtBox
        '
        Me.WhViewDevNoTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewDevNoTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewDevNoTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewDevNoTxtBox.Location = New System.Drawing.Point(739, 30)
        Me.WhViewDevNoTxtBox.Name = "WhViewDevNoTxtBox"
        Me.WhViewDevNoTxtBox.ReadOnly = True
        Me.WhViewDevNoTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewDevNoTxtBox.TabIndex = 31
        '
        'WhViewCtcTxtBox
        '
        Me.WhViewCtcTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewCtcTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewCtcTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewCtcTxtBox.Location = New System.Drawing.Point(212, 204)
        Me.WhViewCtcTxtBox.Name = "WhViewCtcTxtBox"
        Me.WhViewCtcTxtBox.ReadOnly = True
        Me.WhViewCtcTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewCtcTxtBox.TabIndex = 30
        '
        'WhViewAddTxtBox
        '
        Me.WhViewAddTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewAddTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewAddTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewAddTxtBox.Location = New System.Drawing.Point(212, 121)
        Me.WhViewAddTxtBox.Multiline = True
        Me.WhViewAddTxtBox.Name = "WhViewAddTxtBox"
        Me.WhViewAddTxtBox.ReadOnly = True
        Me.WhViewAddTxtBox.Size = New System.Drawing.Size(300, 77)
        Me.WhViewAddTxtBox.TabIndex = 29
        '
        'WhViewDevToTxtBox
        '
        Me.WhViewDevToTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewDevToTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewDevToTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewDevToTxtBox.Location = New System.Drawing.Point(212, 89)
        Me.WhViewDevToTxtBox.Name = "WhViewDevToTxtBox"
        Me.WhViewDevToTxtBox.ReadOnly = True
        Me.WhViewDevToTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewDevToTxtBox.TabIndex = 28
        '
        'WhViewCusTypeTxtBox
        '
        Me.WhViewCusTypeTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewCusTypeTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewCusTypeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewCusTypeTxtBox.Location = New System.Drawing.Point(212, 59)
        Me.WhViewCusTypeTxtBox.Name = "WhViewCusTypeTxtBox"
        Me.WhViewCusTypeTxtBox.ReadOnly = True
        Me.WhViewCusTypeTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewCusTypeTxtBox.TabIndex = 27
        '
        'WhViewTranTypeTxtBox
        '
        Me.WhViewTranTypeTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewTranTypeTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewTranTypeTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewTranTypeTxtBox.Location = New System.Drawing.Point(212, 30)
        Me.WhViewTranTypeTxtBox.Name = "WhViewTranTypeTxtBox"
        Me.WhViewTranTypeTxtBox.ReadOnly = True
        Me.WhViewTranTypeTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewTranTypeTxtBox.TabIndex = 26
        '
        'WhViewDataGridView
        '
        Me.WhViewDataGridView.AllowUserToAddRows = False
        Me.WhViewDataGridView.AllowUserToDeleteRows = False
        Me.WhViewDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WhViewDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WhViewDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.WhViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WhViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WhItemDevIDDataGridViewTextBoxColumn, Me.WhItemIDDataGridViewTextBoxColumn, Me.WhItemProdIDDataGridViewTextBoxColumn, Me.WhItemProdNameDataGridViewTextBoxColumn, Me.WhItemQtyDataGridViewTextBoxColumn, Me.WhItemProdCatDataGridViewTextBoxColumn, Me.WhItemRemarkDataGridViewTextBoxColumn, Me.WhItemSaveDataGridViewCheckBoxColumn})
        Me.WhViewDataGridView.DataSource = Me.WhItemTblBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.WhViewDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.WhViewDataGridView.Location = New System.Drawing.Point(25, 258)
        Me.WhViewDataGridView.Name = "WhViewDataGridView"
        Me.WhViewDataGridView.ReadOnly = True
        Me.WhViewDataGridView.Size = New System.Drawing.Size(1002, 353)
        Me.WhViewDataGridView.TabIndex = 24
        '
        'WhItemDevIDDataGridViewTextBoxColumn
        '
        Me.WhItemDevIDDataGridViewTextBoxColumn.DataPropertyName = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn.HeaderText = "WhItemDevID"
        Me.WhItemDevIDDataGridViewTextBoxColumn.Name = "WhItemDevIDDataGridViewTextBoxColumn"
        Me.WhItemDevIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemDevIDDataGridViewTextBoxColumn.Visible = False
        '
        'WhItemIDDataGridViewTextBoxColumn
        '
        Me.WhItemIDDataGridViewTextBoxColumn.DataPropertyName = "WhItemDevItemID"
        Me.WhItemIDDataGridViewTextBoxColumn.HeaderText = "Item No"
        Me.WhItemIDDataGridViewTextBoxColumn.Name = "WhItemIDDataGridViewTextBoxColumn"
        Me.WhItemIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhItemProdIDDataGridViewTextBoxColumn
        '
        Me.WhItemProdIDDataGridViewTextBoxColumn.DataPropertyName = "WhItemProdID"
        Me.WhItemProdIDDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.WhItemProdIDDataGridViewTextBoxColumn.HeaderText = "Product Part No"
        Me.WhItemProdIDDataGridViewTextBoxColumn.Name = "WhItemProdIDDataGridViewTextBoxColumn"
        Me.WhItemProdIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemProdIDDataGridViewTextBoxColumn.Width = 150
        '
        'WhItemProdNameDataGridViewTextBoxColumn
        '
        Me.WhItemProdNameDataGridViewTextBoxColumn.DataPropertyName = "WhItemProdName"
        Me.WhItemProdNameDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.WhItemProdNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.WhItemProdNameDataGridViewTextBoxColumn.Name = "WhItemProdNameDataGridViewTextBoxColumn"
        Me.WhItemProdNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemProdNameDataGridViewTextBoxColumn.Width = 200
        '
        'WhItemQtyDataGridViewTextBoxColumn
        '
        Me.WhItemQtyDataGridViewTextBoxColumn.DataPropertyName = "WhItemQty"
        Me.WhItemQtyDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.WhItemQtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.WhItemQtyDataGridViewTextBoxColumn.Name = "WhItemQtyDataGridViewTextBoxColumn"
        Me.WhItemQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.WhItemQtyDataGridViewTextBoxColumn.Width = 80
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
        Me.WhItemRemarkDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WhItemRemarkDataGridViewTextBoxColumn.DataPropertyName = "WhItemRemark"
        Me.WhItemRemarkDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.WhItemRemarkDataGridViewTextBoxColumn.Name = "WhItemRemarkDataGridViewTextBoxColumn"
        Me.WhItemRemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WhItemSaveDataGridViewCheckBoxColumn
        '
        Me.WhItemSaveDataGridViewCheckBoxColumn.DataPropertyName = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn.HeaderText = "WhItemSave"
        Me.WhItemSaveDataGridViewCheckBoxColumn.Name = "WhItemSaveDataGridViewCheckBoxColumn"
        Me.WhItemSaveDataGridViewCheckBoxColumn.ReadOnly = True
        Me.WhItemSaveDataGridViewCheckBoxColumn.Visible = False
        '
        'WhItemTblBindingSource
        '
        Me.WhItemTblBindingSource.DataMember = "WhItemTbl"
        Me.WhItemTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WhItemTblTableAdapter
        '
        Me.WhItemTblTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1057, 24)
        Me.MenuStrip.TabIndex = 19
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.PrintToolStripMenuItem.Text = "Generate Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PrintForm
        '
        Me.PrintForm.DocumentName = "document"
        Me.PrintForm.Form = Me
        Me.PrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm.PrinterSettings = CType(resources.GetObject("PrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm.PrintFileName = Nothing
        '
        'WhViewClose
        '
        Me.WhViewClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.WhViewClose.Location = New System.Drawing.Point(925, 564)
        Me.WhViewClose.Name = "WhViewClose"
        Me.WhViewClose.Size = New System.Drawing.Size(75, 23)
        Me.WhViewClose.TabIndex = 35
        Me.WhViewClose.Text = "Close"
        Me.WhViewClose.UseVisualStyleBackColor = True
        '
        'WhViewDevDateTxtBox
        '
        Me.WhViewDevDateTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.WhViewDevDateTxtBox.BackColor = System.Drawing.SystemColors.Control
        Me.WhViewDevDateTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhViewDevDateTxtBox.Location = New System.Drawing.Point(739, 94)
        Me.WhViewDevDateTxtBox.Name = "WhViewDevDateTxtBox"
        Me.WhViewDevDateTxtBox.ReadOnly = True
        Me.WhViewDevDateTxtBox.Size = New System.Drawing.Size(300, 26)
        Me.WhViewDevDateTxtBox.TabIndex = 37
        '
        'WhViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.WhViewClose
        Me.ClientSize = New System.Drawing.Size(1057, 635)
        Me.Controls.Add(Me.WhViewDevDateTxtBox)
        Me.Controls.Add(WhViewDevDateLabel)
        Me.Controls.Add(Me.WhViewDataGridView)
        Me.Controls.Add(Me.WhViewClose)
        Me.Controls.Add(Me.WhViewTimeStampTxtBox)
        Me.Controls.Add(Me.WhViewProByTxtBox)
        Me.Controls.Add(Me.WhViewPONoTxtBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.WhViewDevNoTxtBox)
        Me.Controls.Add(Me.WhViewTranTypeTxtBox)
        Me.Controls.Add(WhViewAddLabel)
        Me.Controls.Add(WhViewTimeStampLabel)
        Me.Controls.Add(Me.WhViewCtcTxtBox)
        Me.Controls.Add(WhViewProByLabel)
        Me.Controls.Add(WhViewNameLabel)
        Me.Controls.Add(WhViewPoIDLabel)
        Me.Controls.Add(Me.WhViewAddTxtBox)
        Me.Controls.Add(WhViewDevIDLabel)
        Me.Controls.Add(WhViewCtcLabel)
        Me.Controls.Add(Me.WhViewDevToTxtBox)
        Me.Controls.Add(WhViewTypeLabel)
        Me.Controls.Add(Me.WhViewCusTypeTxtBox)
        Me.Controls.Add(WhViewTranTypeLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "WhViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Viewer"
        CType(Me.WhViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WhItemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WhViewDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WhViewTranTypeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewCusTypeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewDevNoTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewCtcTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewAddTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewDevToTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewTimeStampTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewProByTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents WhViewPONoTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents WhItemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WhItemTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.WhItemTblTableAdapter
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintForm As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents WhItemDevIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemProdCatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemRemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WhItemSaveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhViewClose As System.Windows.Forms.Button
    Friend WithEvents WhViewDevDateTxtBox As System.Windows.Forms.TextBox
End Class
