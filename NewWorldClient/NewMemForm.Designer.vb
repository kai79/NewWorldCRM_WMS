<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMemForm
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
        Dim MemIDLabel As System.Windows.Forms.Label
        Dim MemNameLabel As System.Windows.Forms.Label
        Dim MemRankLabel As System.Windows.Forms.Label
        Dim MemAddressLabel As System.Windows.Forms.Label
        Dim MemZoneLabel As System.Windows.Forms.Label
        Dim MemCtcHomeLabel As System.Windows.Forms.Label
        Dim MemCtcMobLabel As System.Windows.Forms.Label
        Dim MemEmailLabel As System.Windows.Forms.Label
        Dim MemRefLabel As System.Windows.Forms.Label
        Dim MemNRICLabel As System.Windows.Forms.Label
        Dim MemDateJoinLabel As System.Windows.Forms.Label
        Dim MemJoinDateLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NewWorldDBDataSet = New WindowsApplication1.NewWorldDBDataSet()
        Me.MemTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.MemTblTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager()
        Me.MemIDTextBox = New System.Windows.Forms.TextBox()
        Me.MemNameTextBox = New System.Windows.Forms.TextBox()
        Me.MemRankComboBox = New System.Windows.Forms.ComboBox()
        Me.MemAddressTextBox = New System.Windows.Forms.TextBox()
        Me.MemZoneComboBox = New System.Windows.Forms.ComboBox()
        Me.MemCtcHomeTextBox = New System.Windows.Forms.TextBox()
        Me.MemCtcMobTextBox = New System.Windows.Forms.TextBox()
        Me.MemEmailTextBox = New System.Windows.Forms.TextBox()
        Me.MemRefTextBox = New System.Windows.Forms.TextBox()
        Me.NewMemSaveBtn = New System.Windows.Forms.Button()
        Me.NewMemAddRefBtn = New System.Windows.Forms.Button()
        Me.PurchaseHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.PurProdNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurSDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurEDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurMemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurHisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurOrderNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurWarrNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurDepoDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurDevStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PurTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.PurTblTableAdapter()
        Me.PurHisAddBtn = New System.Windows.Forms.Button()
        Me.PurHisDelBtn = New System.Windows.Forms.Button()
        Me.PurHisOpenBtn = New System.Windows.Forms.Button()
        Me.ClsHisOpenBtn = New System.Windows.Forms.Button()
        Me.ClsHisDelBtn = New System.Windows.Forms.Button()
        Me.ClsHisAddBtn = New System.Windows.Forms.Button()
        Me.ClassHistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClsMenuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsMemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsLockUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsLockDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClsTblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClsTblTableAdapter = New WindowsApplication1.NewWorldDBDataSetTableAdapters.ClsTblTableAdapter()
        Me.NewMemClrBtn = New System.Windows.Forms.Button()
        Me.NewMemCanBtn = New System.Windows.Forms.Button()
        Me.MemNRICTextBox = New System.Windows.Forms.TextBox()
        Me.NewMemTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ReferrerDataGridView = New System.Windows.Forms.DataGridView()
        Me.MemJoinDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.MemCreditNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MemTblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        MemIDLabel = New System.Windows.Forms.Label()
        MemNameLabel = New System.Windows.Forms.Label()
        MemRankLabel = New System.Windows.Forms.Label()
        MemAddressLabel = New System.Windows.Forms.Label()
        MemZoneLabel = New System.Windows.Forms.Label()
        MemCtcHomeLabel = New System.Windows.Forms.Label()
        MemCtcMobLabel = New System.Windows.Forms.Label()
        MemEmailLabel = New System.Windows.Forms.Label()
        MemRefLabel = New System.Windows.Forms.Label()
        MemNRICLabel = New System.Windows.Forms.Label()
        MemDateJoinLabel = New System.Windows.Forms.Label()
        MemJoinDateLabel = New System.Windows.Forms.Label()
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassHistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsTblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewMemTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.ReferrerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemCreditNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemTblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemIDLabel
        '
        MemIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemIDLabel.AutoSize = True
        MemIDLabel.Location = New System.Drawing.Point(592, 15)
        MemIDLabel.Name = "MemIDLabel"
        MemIDLabel.Size = New System.Drawing.Size(62, 13)
        MemIDLabel.TabIndex = 0
        MemIDLabel.Text = "Member ID:"
        '
        'MemNameLabel
        '
        MemNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemNameLabel.AutoSize = True
        MemNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemNameLabel.Location = New System.Drawing.Point(26, 65)
        MemNameLabel.Name = "MemNameLabel"
        MemNameLabel.Size = New System.Drawing.Size(48, 16)
        MemNameLabel.TabIndex = 2
        MemNameLabel.Text = "Name:"
        '
        'MemRankLabel
        '
        MemRankLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemRankLabel.AutoSize = True
        MemRankLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemRankLabel.Location = New System.Drawing.Point(601, 61)
        MemRankLabel.Name = "MemRankLabel"
        MemRankLabel.Size = New System.Drawing.Size(43, 16)
        MemRankLabel.TabIndex = 4
        MemRankLabel.Text = "Rank:"
        '
        'MemAddressLabel
        '
        MemAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemAddressLabel.AutoSize = True
        MemAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemAddressLabel.Location = New System.Drawing.Point(16, 93)
        MemAddressLabel.Name = "MemAddressLabel"
        MemAddressLabel.Size = New System.Drawing.Size(62, 16)
        MemAddressLabel.TabIndex = 6
        MemAddressLabel.Text = "Address:"
        '
        'MemZoneLabel
        '
        MemZoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemZoneLabel.AutoSize = True
        MemZoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemZoneLabel.Location = New System.Drawing.Point(595, 93)
        MemZoneLabel.Name = "MemZoneLabel"
        MemZoneLabel.Size = New System.Drawing.Size(55, 16)
        MemZoneLabel.TabIndex = 8
        MemZoneLabel.Text = "Region:"
        '
        'MemCtcHomeLabel
        '
        MemCtcHomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemCtcHomeLabel.AutoSize = True
        MemCtcHomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemCtcHomeLabel.Location = New System.Drawing.Point(507, 121)
        MemCtcHomeLabel.Name = "MemCtcHomeLabel"
        MemCtcHomeLabel.Size = New System.Drawing.Size(77, 16)
        MemCtcHomeLabel.TabIndex = 10
        MemCtcHomeLabel.Text = "Contact (H):"
        '
        'MemCtcMobLabel
        '
        MemCtcMobLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemCtcMobLabel.AutoSize = True
        MemCtcMobLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemCtcMobLabel.Location = New System.Drawing.Point(507, 149)
        MemCtcMobLabel.Name = "MemCtcMobLabel"
        MemCtcMobLabel.Size = New System.Drawing.Size(78, 16)
        MemCtcMobLabel.TabIndex = 12
        MemCtcMobLabel.Text = "Contact (M):"
        '
        'MemEmailLabel
        '
        MemEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemEmailLabel.AutoSize = True
        MemEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemEmailLabel.Location = New System.Drawing.Point(29, 121)
        MemEmailLabel.Name = "MemEmailLabel"
        MemEmailLabel.Size = New System.Drawing.Size(45, 16)
        MemEmailLabel.TabIndex = 14
        MemEmailLabel.Text = "Email:"
        '
        'MemRefLabel
        '
        MemRefLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemRefLabel.AutoSize = True
        MemRefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemRefLabel.Location = New System.Drawing.Point(12, 205)
        MemRefLabel.Name = "MemRefLabel"
        MemRefLabel.Size = New System.Drawing.Size(64, 16)
        MemRefLabel.TabIndex = 16
        MemRefLabel.Text = "Referree:"
        '
        'MemNRICLabel
        '
        MemNRICLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemNRICLabel.AutoSize = True
        MemNRICLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemNRICLabel.Location = New System.Drawing.Point(32, 149)
        MemNRICLabel.Name = "MemNRICLabel"
        MemNRICLabel.Size = New System.Drawing.Size(43, 16)
        MemNRICLabel.TabIndex = 32
        MemNRICLabel.Text = "NRIC:"
        '
        'MemDateJoinLabel
        '
        MemDateJoinLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemDateJoinLabel.AutoSize = True
        MemDateJoinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemDateJoinLabel.Location = New System.Drawing.Point(6, 177)
        MemDateJoinLabel.Name = "MemDateJoinLabel"
        MemDateJoinLabel.Size = New System.Drawing.Size(68, 16)
        MemDateJoinLabel.TabIndex = 37
        MemDateJoinLabel.Text = "Join Date:"
        '
        'MemJoinDateLabel
        '
        MemJoinDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        MemJoinDateLabel.AutoSize = True
        MemJoinDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemJoinDateLabel.Location = New System.Drawing.Point(504, 177)
        MemJoinDateLabel.Name = "MemJoinDateLabel"
        MemJoinDateLabel.Size = New System.Drawing.Size(80, 16)
        MemJoinDateLabel.TabIndex = 38
        MemJoinDateLabel.Text = "Class Credit"
        '
        'NewWorldDBDataSet
        '
        Me.NewWorldDBDataSet.DataSetName = "NewWorldDBDataSet"
        Me.NewWorldDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemTblBindingSource
        '
        Me.MemTblBindingSource.DataMember = "MemTbl"
        Me.MemTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'MemTblTableAdapter
        '
        Me.MemTblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClsTblTableAdapter = Nothing
        Me.TableAdapterManager.MemTblTableAdapter = Me.MemTblTableAdapter
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
        'MemIDTextBox
        '
        Me.MemIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.MemIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemID", True))
        Me.MemIDTextBox.Location = New System.Drawing.Point(660, 12)
        Me.MemIDTextBox.Name = "MemIDTextBox"
        Me.MemIDTextBox.ReadOnly = True
        Me.MemIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MemIDTextBox.TabIndex = 1
        '
        'MemNameTextBox
        '
        Me.MemNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MemNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemName", True))
        Me.MemNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemNameTextBox.Location = New System.Drawing.Point(80, 62)
        Me.MemNameTextBox.Name = "MemNameTextBox"
        Me.MemNameTextBox.Size = New System.Drawing.Size(505, 22)
        Me.MemNameTextBox.TabIndex = 1
        '
        'MemRankComboBox
        '
        Me.MemRankComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemRankComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemRank", True))
        Me.MemRankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MemRankComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemRankComboBox.FormattingEnabled = True
        Me.MemRankComboBox.Items.AddRange(New Object() {"Elite", "VVIP", "VIP", "Normal", "Staff"})
        Me.MemRankComboBox.Location = New System.Drawing.Point(650, 58)
        Me.MemRankComboBox.Name = "MemRankComboBox"
        Me.MemRankComboBox.Size = New System.Drawing.Size(121, 24)
        Me.MemRankComboBox.TabIndex = 2
        '
        'MemAddressTextBox
        '
        Me.MemAddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemAddress", True))
        Me.MemAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemAddressTextBox.Location = New System.Drawing.Point(81, 90)
        Me.MemAddressTextBox.Name = "MemAddressTextBox"
        Me.MemAddressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.MemAddressTextBox.Size = New System.Drawing.Size(504, 22)
        Me.MemAddressTextBox.TabIndex = 3
        '
        'MemZoneComboBox
        '
        Me.MemZoneComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemZoneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemZone", True))
        Me.MemZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MemZoneComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemZoneComboBox.FormattingEnabled = True
        Me.MemZoneComboBox.Items.AddRange(New Object() {"Central", "East", "North", "South", "West"})
        Me.MemZoneComboBox.Location = New System.Drawing.Point(650, 88)
        Me.MemZoneComboBox.Name = "MemZoneComboBox"
        Me.MemZoneComboBox.Size = New System.Drawing.Size(121, 24)
        Me.MemZoneComboBox.TabIndex = 4
        '
        'MemCtcHomeTextBox
        '
        Me.MemCtcHomeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemCtcHomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemCtcHome", True))
        Me.MemCtcHomeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemCtcHomeTextBox.Location = New System.Drawing.Point(590, 121)
        Me.MemCtcHomeTextBox.Name = "MemCtcHomeTextBox"
        Me.MemCtcHomeTextBox.Size = New System.Drawing.Size(181, 22)
        Me.MemCtcHomeTextBox.TabIndex = 6
        '
        'MemCtcMobTextBox
        '
        Me.MemCtcMobTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemCtcMobTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemCtcMob", True))
        Me.MemCtcMobTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemCtcMobTextBox.Location = New System.Drawing.Point(591, 149)
        Me.MemCtcMobTextBox.Name = "MemCtcMobTextBox"
        Me.MemCtcMobTextBox.Size = New System.Drawing.Size(180, 22)
        Me.MemCtcMobTextBox.TabIndex = 8
        '
        'MemEmailTextBox
        '
        Me.MemEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemEmail", True))
        Me.MemEmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemEmailTextBox.Location = New System.Drawing.Point(81, 118)
        Me.MemEmailTextBox.Name = "MemEmailTextBox"
        Me.MemEmailTextBox.Size = New System.Drawing.Size(413, 22)
        Me.MemEmailTextBox.TabIndex = 5
        '
        'MemRefTextBox
        '
        Me.MemRefTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemRefTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemRef", True))
        Me.MemRefTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemRefTextBox.Location = New System.Drawing.Point(80, 202)
        Me.MemRefTextBox.Name = "MemRefTextBox"
        Me.MemRefTextBox.ReadOnly = True
        Me.MemRefTextBox.Size = New System.Drawing.Size(332, 22)
        Me.MemRefTextBox.TabIndex = 33
        '
        'NewMemSaveBtn
        '
        Me.NewMemSaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMemSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMemSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.save2_icon
        Me.NewMemSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewMemSaveBtn.Location = New System.Drawing.Point(650, 622)
        Me.NewMemSaveBtn.Name = "NewMemSaveBtn"
        Me.NewMemSaveBtn.Size = New System.Drawing.Size(121, 45)
        Me.NewMemSaveBtn.TabIndex = 13
        Me.NewMemSaveBtn.Text = "Save"
        Me.NewMemSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewMemSaveBtn.UseVisualStyleBackColor = True
        '
        'NewMemAddRefBtn
        '
        Me.NewMemAddRefBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NewMemAddRefBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMemAddRefBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_addRound_icon
        Me.NewMemAddRefBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewMemAddRefBtn.Location = New System.Drawing.Point(418, 202)
        Me.NewMemAddRefBtn.Name = "NewMemAddRefBtn"
        Me.NewMemAddRefBtn.Size = New System.Drawing.Size(124, 24)
        Me.NewMemAddRefBtn.TabIndex = 11
        Me.NewMemAddRefBtn.Text = "Add Referral"
        Me.NewMemAddRefBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewMemAddRefBtn.UseVisualStyleBackColor = True
        '
        'PurchaseHistoryDataGridView
        '
        Me.PurchaseHistoryDataGridView.AllowUserToAddRows = False
        Me.PurchaseHistoryDataGridView.AllowUserToDeleteRows = False
        Me.PurchaseHistoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurchaseHistoryDataGridView.AutoGenerateColumns = False
        Me.PurchaseHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PurProdNameDataGridViewTextBoxColumn, Me.PurDateDataGridViewTextBoxColumn, Me.PurSDateDataGridViewTextBoxColumn, Me.PurEDateDataGridViewTextBoxColumn, Me.PurIDDataGridViewTextBoxColumn, Me.PurMemIDDataGridViewTextBoxColumn, Me.PurHisDataGridViewTextBoxColumn, Me.PurOrderNoDataGridViewTextBoxColumn, Me.PurWarrNoDataGridViewTextBoxColumn, Me.PurAmt, Me.PurQty, Me.PurCredit, Me.PurDepoDate, Me.PurDevStatus, Me.PurRemark})
        Me.PurchaseHistoryDataGridView.DataSource = Me.PurTblBindingSource
        Me.PurchaseHistoryDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.PurchaseHistoryDataGridView.Name = "PurchaseHistoryDataGridView"
        Me.PurchaseHistoryDataGridView.ReadOnly = True
        Me.PurchaseHistoryDataGridView.Size = New System.Drawing.Size(721, 292)
        Me.PurchaseHistoryDataGridView.TabIndex = 20
        '
        'PurProdNameDataGridViewTextBoxColumn
        '
        Me.PurProdNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PurProdNameDataGridViewTextBoxColumn.DataPropertyName = "PurProdName"
        Me.PurProdNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.PurProdNameDataGridViewTextBoxColumn.Name = "PurProdNameDataGridViewTextBoxColumn"
        Me.PurProdNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurDateDataGridViewTextBoxColumn
        '
        Me.PurDateDataGridViewTextBoxColumn.DataPropertyName = "PurDate"
        Me.PurDateDataGridViewTextBoxColumn.HeaderText = "Purchase Date"
        Me.PurDateDataGridViewTextBoxColumn.Name = "PurDateDataGridViewTextBoxColumn"
        Me.PurDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurDateDataGridViewTextBoxColumn.Width = 120
        '
        'PurSDateDataGridViewTextBoxColumn
        '
        Me.PurSDateDataGridViewTextBoxColumn.DataPropertyName = "PurSDate"
        Me.PurSDateDataGridViewTextBoxColumn.HeaderText = "Warranty Start"
        Me.PurSDateDataGridViewTextBoxColumn.Name = "PurSDateDataGridViewTextBoxColumn"
        Me.PurSDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurEDateDataGridViewTextBoxColumn
        '
        Me.PurEDateDataGridViewTextBoxColumn.DataPropertyName = "PurEDate"
        Me.PurEDateDataGridViewTextBoxColumn.HeaderText = "Warranty End"
        Me.PurEDateDataGridViewTextBoxColumn.Name = "PurEDateDataGridViewTextBoxColumn"
        Me.PurEDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurIDDataGridViewTextBoxColumn
        '
        Me.PurIDDataGridViewTextBoxColumn.DataPropertyName = "PurID"
        Me.PurIDDataGridViewTextBoxColumn.HeaderText = "PurID"
        Me.PurIDDataGridViewTextBoxColumn.Name = "PurIDDataGridViewTextBoxColumn"
        Me.PurIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurIDDataGridViewTextBoxColumn.Visible = False
        '
        'PurMemIDDataGridViewTextBoxColumn
        '
        Me.PurMemIDDataGridViewTextBoxColumn.DataPropertyName = "PurMemID"
        Me.PurMemIDDataGridViewTextBoxColumn.HeaderText = "PurMemID"
        Me.PurMemIDDataGridViewTextBoxColumn.Name = "PurMemIDDataGridViewTextBoxColumn"
        Me.PurMemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurMemIDDataGridViewTextBoxColumn.Visible = False
        '
        'PurHisDataGridViewTextBoxColumn
        '
        Me.PurHisDataGridViewTextBoxColumn.DataPropertyName = "PurHis"
        Me.PurHisDataGridViewTextBoxColumn.HeaderText = "PurHis"
        Me.PurHisDataGridViewTextBoxColumn.Name = "PurHisDataGridViewTextBoxColumn"
        Me.PurHisDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurHisDataGridViewTextBoxColumn.Visible = False
        '
        'PurOrderNoDataGridViewTextBoxColumn
        '
        Me.PurOrderNoDataGridViewTextBoxColumn.DataPropertyName = "PurOrderNo"
        Me.PurOrderNoDataGridViewTextBoxColumn.HeaderText = "PurOrderNo"
        Me.PurOrderNoDataGridViewTextBoxColumn.Name = "PurOrderNoDataGridViewTextBoxColumn"
        Me.PurOrderNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurOrderNoDataGridViewTextBoxColumn.Visible = False
        '
        'PurWarrNoDataGridViewTextBoxColumn
        '
        Me.PurWarrNoDataGridViewTextBoxColumn.DataPropertyName = "PurWarrNo"
        Me.PurWarrNoDataGridViewTextBoxColumn.HeaderText = "PurWarrNo"
        Me.PurWarrNoDataGridViewTextBoxColumn.Name = "PurWarrNoDataGridViewTextBoxColumn"
        Me.PurWarrNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurWarrNoDataGridViewTextBoxColumn.Visible = False
        '
        'PurAmt
        '
        Me.PurAmt.DataPropertyName = "PurAmt"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PurAmt.DefaultCellStyle = DataGridViewCellStyle1
        Me.PurAmt.HeaderText = "PurAmt"
        Me.PurAmt.Name = "PurAmt"
        Me.PurAmt.ReadOnly = True
        Me.PurAmt.Visible = False
        '
        'PurQty
        '
        Me.PurQty.DataPropertyName = "PurQty"
        Me.PurQty.HeaderText = "PurQty"
        Me.PurQty.Name = "PurQty"
        Me.PurQty.ReadOnly = True
        Me.PurQty.Visible = False
        '
        'PurCredit
        '
        Me.PurCredit.DataPropertyName = "PurCredit"
        Me.PurCredit.HeaderText = "PurCredit"
        Me.PurCredit.Name = "PurCredit"
        Me.PurCredit.ReadOnly = True
        Me.PurCredit.Visible = False
        '
        'PurDepoDate
        '
        Me.PurDepoDate.DataPropertyName = "PurDepoDate"
        Me.PurDepoDate.HeaderText = "PurDepoDate"
        Me.PurDepoDate.Name = "PurDepoDate"
        Me.PurDepoDate.ReadOnly = True
        Me.PurDepoDate.Visible = False
        '
        'PurDevStatus
        '
        Me.PurDevStatus.DataPropertyName = "PurDevStatus"
        Me.PurDevStatus.HeaderText = "PurDevStatus"
        Me.PurDevStatus.Name = "PurDevStatus"
        Me.PurDevStatus.ReadOnly = True
        Me.PurDevStatus.Visible = False
        '
        'PurRemark
        '
        Me.PurRemark.DataPropertyName = "PurRemark"
        Me.PurRemark.HeaderText = "PurRemark"
        Me.PurRemark.Name = "PurRemark"
        Me.PurRemark.ReadOnly = True
        Me.PurRemark.Visible = False
        '
        'PurTblBindingSource
        '
        Me.PurTblBindingSource.DataMember = "PurTbl"
        Me.PurTblBindingSource.DataSource = Me.NewWorldDBDataSet
        '
        'PurTblTableAdapter
        '
        Me.PurTblTableAdapter.ClearBeforeFill = True
        '
        'PurHisAddBtn
        '
        Me.PurHisAddBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurHisAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurHisAddBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Small_add_icon
        Me.PurHisAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurHisAddBtn.Location = New System.Drawing.Point(645, 304)
        Me.PurHisAddBtn.Name = "PurHisAddBtn"
        Me.PurHisAddBtn.Size = New System.Drawing.Size(85, 36)
        Me.PurHisAddBtn.TabIndex = 22
        Me.PurHisAddBtn.Text = "Add"
        Me.PurHisAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PurHisAddBtn.UseVisualStyleBackColor = True
        '
        'PurHisDelBtn
        '
        Me.PurHisDelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurHisDelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurHisDelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_delete_icon
        Me.PurHisDelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurHisDelBtn.Location = New System.Drawing.Point(554, 304)
        Me.PurHisDelBtn.Name = "PurHisDelBtn"
        Me.PurHisDelBtn.Size = New System.Drawing.Size(85, 36)
        Me.PurHisDelBtn.TabIndex = 23
        Me.PurHisDelBtn.Text = "Delete"
        Me.PurHisDelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PurHisDelBtn.UseVisualStyleBackColor = True
        '
        'PurHisOpenBtn
        '
        Me.PurHisOpenBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PurHisOpenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurHisOpenBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_open_icon
        Me.PurHisOpenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurHisOpenBtn.Location = New System.Drawing.Point(463, 304)
        Me.PurHisOpenBtn.Name = "PurHisOpenBtn"
        Me.PurHisOpenBtn.Size = New System.Drawing.Size(85, 36)
        Me.PurHisOpenBtn.TabIndex = 24
        Me.PurHisOpenBtn.Text = "Open"
        Me.PurHisOpenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PurHisOpenBtn.UseVisualStyleBackColor = True
        '
        'ClsHisOpenBtn
        '
        Me.ClsHisOpenBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsHisOpenBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsHisOpenBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_open_icon
        Me.ClsHisOpenBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClsHisOpenBtn.Location = New System.Drawing.Point(463, 304)
        Me.ClsHisOpenBtn.Name = "ClsHisOpenBtn"
        Me.ClsHisOpenBtn.Size = New System.Drawing.Size(85, 36)
        Me.ClsHisOpenBtn.TabIndex = 29
        Me.ClsHisOpenBtn.Text = "Open"
        Me.ClsHisOpenBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClsHisOpenBtn.UseVisualStyleBackColor = True
        '
        'ClsHisDelBtn
        '
        Me.ClsHisDelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsHisDelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsHisDelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_delete_icon
        Me.ClsHisDelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClsHisDelBtn.Location = New System.Drawing.Point(554, 304)
        Me.ClsHisDelBtn.Name = "ClsHisDelBtn"
        Me.ClsHisDelBtn.Size = New System.Drawing.Size(85, 36)
        Me.ClsHisDelBtn.TabIndex = 28
        Me.ClsHisDelBtn.Text = "Delete"
        Me.ClsHisDelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClsHisDelBtn.UseVisualStyleBackColor = True
        '
        'ClsHisAddBtn
        '
        Me.ClsHisAddBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClsHisAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClsHisAddBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Small_add_icon
        Me.ClsHisAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClsHisAddBtn.Location = New System.Drawing.Point(645, 304)
        Me.ClsHisAddBtn.Name = "ClsHisAddBtn"
        Me.ClsHisAddBtn.Size = New System.Drawing.Size(85, 36)
        Me.ClsHisAddBtn.TabIndex = 27
        Me.ClsHisAddBtn.Text = "Add"
        Me.ClsHisAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ClsHisAddBtn.UseVisualStyleBackColor = True
        '
        'ClassHistoryDataGridView
        '
        Me.ClassHistoryDataGridView.AllowUserToAddRows = False
        Me.ClassHistoryDataGridView.AllowUserToDeleteRows = False
        Me.ClassHistoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassHistoryDataGridView.AutoGenerateColumns = False
        Me.ClassHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClassHistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClsMenuNameDataGridViewTextBoxColumn, Me.ClsDateDataGridViewTextBoxColumn, Me.ClsIDDataGridViewTextBoxColumn, Me.ClsMemIDDataGridViewTextBoxColumn, Me.ClsLockUserDataGridViewTextBoxColumn, Me.ClsLockDataGridViewCheckBoxColumn})
        Me.ClassHistoryDataGridView.DataSource = Me.ClsTblBindingSource
        Me.ClassHistoryDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.ClassHistoryDataGridView.Name = "ClassHistoryDataGridView"
        Me.ClassHistoryDataGridView.ReadOnly = True
        Me.ClassHistoryDataGridView.Size = New System.Drawing.Size(721, 292)
        Me.ClassHistoryDataGridView.TabIndex = 25
        '
        'ClsMenuNameDataGridViewTextBoxColumn
        '
        Me.ClsMenuNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ClsMenuNameDataGridViewTextBoxColumn.DataPropertyName = "ClsMenuName"
        Me.ClsMenuNameDataGridViewTextBoxColumn.HeaderText = "Menu Name"
        Me.ClsMenuNameDataGridViewTextBoxColumn.Name = "ClsMenuNameDataGridViewTextBoxColumn"
        Me.ClsMenuNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClsDateDataGridViewTextBoxColumn
        '
        Me.ClsDateDataGridViewTextBoxColumn.DataPropertyName = "ClsDate"
        Me.ClsDateDataGridViewTextBoxColumn.HeaderText = "Date Attended"
        Me.ClsDateDataGridViewTextBoxColumn.Name = "ClsDateDataGridViewTextBoxColumn"
        Me.ClsDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClsIDDataGridViewTextBoxColumn
        '
        Me.ClsIDDataGridViewTextBoxColumn.DataPropertyName = "ClsID"
        Me.ClsIDDataGridViewTextBoxColumn.HeaderText = "ClsID"
        Me.ClsIDDataGridViewTextBoxColumn.Name = "ClsIDDataGridViewTextBoxColumn"
        Me.ClsIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClsIDDataGridViewTextBoxColumn.Visible = False
        '
        'ClsMemIDDataGridViewTextBoxColumn
        '
        Me.ClsMemIDDataGridViewTextBoxColumn.DataPropertyName = "ClsMemID"
        Me.ClsMemIDDataGridViewTextBoxColumn.HeaderText = "ClsMemID"
        Me.ClsMemIDDataGridViewTextBoxColumn.Name = "ClsMemIDDataGridViewTextBoxColumn"
        Me.ClsMemIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClsMemIDDataGridViewTextBoxColumn.Visible = False
        '
        'ClsLockUserDataGridViewTextBoxColumn
        '
        Me.ClsLockUserDataGridViewTextBoxColumn.DataPropertyName = "ClsLockUser"
        Me.ClsLockUserDataGridViewTextBoxColumn.HeaderText = "ClsLockUser"
        Me.ClsLockUserDataGridViewTextBoxColumn.Name = "ClsLockUserDataGridViewTextBoxColumn"
        Me.ClsLockUserDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClsLockUserDataGridViewTextBoxColumn.Visible = False
        '
        'ClsLockDataGridViewCheckBoxColumn
        '
        Me.ClsLockDataGridViewCheckBoxColumn.DataPropertyName = "ClsLock"
        Me.ClsLockDataGridViewCheckBoxColumn.HeaderText = "ClsLock"
        Me.ClsLockDataGridViewCheckBoxColumn.Name = "ClsLockDataGridViewCheckBoxColumn"
        Me.ClsLockDataGridViewCheckBoxColumn.ReadOnly = True
        Me.ClsLockDataGridViewCheckBoxColumn.Visible = False
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
        'NewMemClrBtn
        '
        Me.NewMemClrBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMemClrBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMemClrBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_edit_clear_icon
        Me.NewMemClrBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewMemClrBtn.Location = New System.Drawing.Point(523, 622)
        Me.NewMemClrBtn.Name = "NewMemClrBtn"
        Me.NewMemClrBtn.Size = New System.Drawing.Size(121, 45)
        Me.NewMemClrBtn.TabIndex = 14
        Me.NewMemClrBtn.Text = "Clear"
        Me.NewMemClrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewMemClrBtn.UseVisualStyleBackColor = True
        '
        'NewMemCanBtn
        '
        Me.NewMemCanBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMemCanBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewMemCanBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewMemCanBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.NewMemCanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewMemCanBtn.Location = New System.Drawing.Point(396, 622)
        Me.NewMemCanBtn.Name = "NewMemCanBtn"
        Me.NewMemCanBtn.Size = New System.Drawing.Size(121, 45)
        Me.NewMemCanBtn.TabIndex = 15
        Me.NewMemCanBtn.Text = "Cancel"
        Me.NewMemCanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewMemCanBtn.UseVisualStyleBackColor = True
        '
        'MemNRICTextBox
        '
        Me.MemNRICTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemNRICTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MemNRICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemTblBindingSource, "MemNRIC", True))
        Me.MemNRICTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemNRICTextBox.Location = New System.Drawing.Point(81, 146)
        Me.MemNRICTextBox.Name = "MemNRICTextBox"
        Me.MemNRICTextBox.Size = New System.Drawing.Size(413, 22)
        Me.MemNRICTextBox.TabIndex = 7
        '
        'NewMemTabControl
        '
        Me.NewMemTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewMemTabControl.Controls.Add(Me.TabPage1)
        Me.NewMemTabControl.Controls.Add(Me.TabPage2)
        Me.NewMemTabControl.Controls.Add(Me.TabPage3)
        Me.NewMemTabControl.Location = New System.Drawing.Point(19, 242)
        Me.NewMemTabControl.Name = "NewMemTabControl"
        Me.NewMemTabControl.SelectedIndex = 0
        Me.NewMemTabControl.Size = New System.Drawing.Size(741, 374)
        Me.NewMemTabControl.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.PurchaseHistoryDataGridView)
        Me.TabPage1.Controls.Add(Me.PurHisAddBtn)
        Me.TabPage1.Controls.Add(Me.PurHisDelBtn)
        Me.TabPage1.Controls.Add(Me.PurHisOpenBtn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(733, 348)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Purchase History"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.ClassHistoryDataGridView)
        Me.TabPage2.Controls.Add(Me.ClsHisAddBtn)
        Me.TabPage2.Controls.Add(Me.ClsHisDelBtn)
        Me.TabPage2.Controls.Add(Me.ClsHisOpenBtn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(733, 348)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Class History"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ReferrerDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(733, 348)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Referrer Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ReferrerDataGridView
        '
        Me.ReferrerDataGridView.AllowUserToAddRows = False
        Me.ReferrerDataGridView.AllowUserToDeleteRows = False
        Me.ReferrerDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReferrerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReferrerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReferrerDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.ReferrerDataGridView.Name = "ReferrerDataGridView"
        Me.ReferrerDataGridView.ReadOnly = True
        Me.ReferrerDataGridView.Size = New System.Drawing.Size(721, 339)
        Me.ReferrerDataGridView.TabIndex = 0
        '
        'MemJoinDatePicker
        '
        Me.MemJoinDatePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemJoinDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemJoinDatePicker.Location = New System.Drawing.Point(80, 174)
        Me.MemJoinDatePicker.Name = "MemJoinDatePicker"
        Me.MemJoinDatePicker.Size = New System.Drawing.Size(414, 22)
        Me.MemJoinDatePicker.TabIndex = 9
        '
        'MemCreditNumericUpDown
        '
        Me.MemCreditNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MemCreditNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemCreditNumericUpDown.Location = New System.Drawing.Point(590, 177)
        Me.MemCreditNumericUpDown.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.MemCreditNumericUpDown.Name = "MemCreditNumericUpDown"
        Me.MemCreditNumericUpDown.Size = New System.Drawing.Size(181, 22)
        Me.MemCreditNumericUpDown.TabIndex = 10
        '
        'MemTblBindingSource1
        '
        Me.MemTblBindingSource1.DataMember = "MemTbl"
        Me.MemTblBindingSource1.DataSource = Me.NewWorldDBDataSet
        '
        'NewMemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NewMemCanBtn
        Me.ClientSize = New System.Drawing.Size(783, 683)
        Me.Controls.Add(MemJoinDateLabel)
        Me.Controls.Add(Me.MemCreditNumericUpDown)
        Me.Controls.Add(MemDateJoinLabel)
        Me.Controls.Add(Me.MemJoinDatePicker)
        Me.Controls.Add(Me.NewMemTabControl)
        Me.Controls.Add(MemNRICLabel)
        Me.Controls.Add(Me.MemNRICTextBox)
        Me.Controls.Add(Me.NewMemCanBtn)
        Me.Controls.Add(Me.NewMemClrBtn)
        Me.Controls.Add(Me.NewMemAddRefBtn)
        Me.Controls.Add(Me.NewMemSaveBtn)
        Me.Controls.Add(MemRefLabel)
        Me.Controls.Add(Me.MemRefTextBox)
        Me.Controls.Add(MemEmailLabel)
        Me.Controls.Add(Me.MemEmailTextBox)
        Me.Controls.Add(MemCtcMobLabel)
        Me.Controls.Add(Me.MemCtcMobTextBox)
        Me.Controls.Add(MemCtcHomeLabel)
        Me.Controls.Add(Me.MemCtcHomeTextBox)
        Me.Controls.Add(MemZoneLabel)
        Me.Controls.Add(Me.MemZoneComboBox)
        Me.Controls.Add(MemAddressLabel)
        Me.Controls.Add(Me.MemAddressTextBox)
        Me.Controls.Add(MemRankLabel)
        Me.Controls.Add(Me.MemRankComboBox)
        Me.Controls.Add(MemNameLabel)
        Me.Controls.Add(Me.MemNameTextBox)
        Me.Controls.Add(MemIDLabel)
        Me.Controls.Add(Me.MemIDTextBox)
        Me.Name = "NewMemForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Form"
        CType(Me.NewWorldDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassHistoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsTblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewMemTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.ReferrerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemCreditNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemTblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewWorldDBDataSet As WindowsApplication1.NewWorldDBDataSet
    Friend WithEvents MemTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.MemTblTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.NewWorldDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MemIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemRankComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MemAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemZoneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MemCtcHomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemCtcMobTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemRefTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewMemSaveBtn As System.Windows.Forms.Button
    Friend WithEvents NewMemAddRefBtn As System.Windows.Forms.Button
    Friend WithEvents PurchaseHistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PurTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.PurTblTableAdapter
    Friend WithEvents PurHisAddBtn As System.Windows.Forms.Button
    Friend WithEvents PurHisDelBtn As System.Windows.Forms.Button
    Friend WithEvents PurHisOpenBtn As System.Windows.Forms.Button
    Friend WithEvents ClsHisOpenBtn As System.Windows.Forms.Button
    Friend WithEvents ClsHisDelBtn As System.Windows.Forms.Button
    Friend WithEvents ClsHisAddBtn As System.Windows.Forms.Button
    Friend WithEvents ClassHistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClsTblBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClsTblTableAdapter As WindowsApplication1.NewWorldDBDataSetTableAdapters.ClsTblTableAdapter
    Friend WithEvents ClsMenuNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClsDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClsIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClsMemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClsLockUserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClsLockDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents NewMemClrBtn As System.Windows.Forms.Button
    Friend WithEvents NewMemCanBtn As System.Windows.Forms.Button
    Friend WithEvents MemNRICTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewMemTabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MemJoinDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MemCreditNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ReferrerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PurProdNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurSDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurEDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurMemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurHisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurOrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurWarrNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurDepoDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurDevStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PurRemark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemTblBindingSource1 As System.Windows.Forms.BindingSource
End Class
