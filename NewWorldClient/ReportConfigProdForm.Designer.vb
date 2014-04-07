<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportConfigProdForm
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
        Me.CfgWarrChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgPriceChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgNameChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgFindProdBtn = New System.Windows.Forms.Button()
        Me.CfgNameComboBox = New System.Windows.Forms.ComboBox()
        Me.CfgTotRevRangeChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgTotRevToTextBox = New System.Windows.Forms.TextBox()
        Me.CfgTotRevFromTextBox = New System.Windows.Forms.TextBox()
        Me.CfgTotRevToLabel = New System.Windows.Forms.Label()
        Me.CfgTotRevFromLabel = New System.Windows.Forms.Label()
        Me.CfgTotRevChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgSaleVolChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgSaleVolComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CfgCanelBtn = New System.Windows.Forms.Button()
        Me.CfgSaveBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CfgWarrChkBox
        '
        Me.CfgWarrChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgWarrChkBox.AutoSize = True
        Me.CfgWarrChkBox.Location = New System.Drawing.Point(14, 97)
        Me.CfgWarrChkBox.Name = "CfgWarrChkBox"
        Me.CfgWarrChkBox.Size = New System.Drawing.Size(142, 17)
        Me.CfgWarrChkBox.TabIndex = 5
        Me.CfgWarrChkBox.Text = "Product Warranty Period"
        Me.CfgWarrChkBox.UseVisualStyleBackColor = True
        '
        'CfgPriceChkBox
        '
        Me.CfgPriceChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgPriceChkBox.AutoSize = True
        Me.CfgPriceChkBox.Location = New System.Drawing.Point(14, 74)
        Me.CfgPriceChkBox.Name = "CfgPriceChkBox"
        Me.CfgPriceChkBox.Size = New System.Drawing.Size(90, 17)
        Me.CfgPriceChkBox.TabIndex = 4
        Me.CfgPriceChkBox.Text = "Product Price"
        Me.CfgPriceChkBox.UseVisualStyleBackColor = True
        '
        'CfgNameChkBox
        '
        Me.CfgNameChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgNameChkBox.AutoSize = True
        Me.CfgNameChkBox.Checked = True
        Me.CfgNameChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CfgNameChkBox.Enabled = False
        Me.CfgNameChkBox.Location = New System.Drawing.Point(14, 51)
        Me.CfgNameChkBox.Name = "CfgNameChkBox"
        Me.CfgNameChkBox.Size = New System.Drawing.Size(94, 17)
        Me.CfgNameChkBox.TabIndex = 3
        Me.CfgNameChkBox.Text = "Product Name"
        Me.CfgNameChkBox.UseVisualStyleBackColor = True
        '
        'CfgFindProdBtn
        '
        Me.CfgFindProdBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgFindProdBtn.Location = New System.Drawing.Point(233, 49)
        Me.CfgFindProdBtn.Name = "CfgFindProdBtn"
        Me.CfgFindProdBtn.Size = New System.Drawing.Size(98, 23)
        Me.CfgFindProdBtn.TabIndex = 60
        Me.CfgFindProdBtn.Text = "Find Product"
        Me.CfgFindProdBtn.UseVisualStyleBackColor = True
        '
        'CfgNameComboBox
        '
        Me.CfgNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CfgNameComboBox.FormattingEnabled = True
        Me.CfgNameComboBox.Items.AddRange(New Object() {"All", "In", "Not In"})
        Me.CfgNameComboBox.Location = New System.Drawing.Point(161, 51)
        Me.CfgNameComboBox.Name = "CfgNameComboBox"
        Me.CfgNameComboBox.Size = New System.Drawing.Size(66, 21)
        Me.CfgNameComboBox.TabIndex = 59
        '
        'CfgTotRevRangeChkBox
        '
        Me.CfgTotRevRangeChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgTotRevRangeChkBox.AutoSize = True
        Me.CfgTotRevRangeChkBox.Location = New System.Drawing.Point(161, 145)
        Me.CfgTotRevRangeChkBox.Name = "CfgTotRevRangeChkBox"
        Me.CfgTotRevRangeChkBox.Size = New System.Drawing.Size(141, 17)
        Me.CfgTotRevRangeChkBox.TabIndex = 75
        Me.CfgTotRevRangeChkBox.Text = "Enable Range Selection"
        Me.CfgTotRevRangeChkBox.UseVisualStyleBackColor = True
        '
        'CfgTotRevToTextBox
        '
        Me.CfgTotRevToTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgTotRevToTextBox.Location = New System.Drawing.Point(511, 143)
        Me.CfgTotRevToTextBox.Name = "CfgTotRevToTextBox"
        Me.CfgTotRevToTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CfgTotRevToTextBox.TabIndex = 68
        Me.CfgTotRevToTextBox.Text = "0"
        '
        'CfgTotRevFromTextBox
        '
        Me.CfgTotRevFromTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgTotRevFromTextBox.Location = New System.Drawing.Point(379, 143)
        Me.CfgTotRevFromTextBox.Name = "CfgTotRevFromTextBox"
        Me.CfgTotRevFromTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CfgTotRevFromTextBox.TabIndex = 67
        Me.CfgTotRevFromTextBox.Text = "0"
        '
        'CfgTotRevToLabel
        '
        Me.CfgTotRevToLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgTotRevToLabel.AutoSize = True
        Me.CfgTotRevToLabel.Location = New System.Drawing.Point(485, 146)
        Me.CfgTotRevToLabel.Name = "CfgTotRevToLabel"
        Me.CfgTotRevToLabel.Size = New System.Drawing.Size(20, 13)
        Me.CfgTotRevToLabel.TabIndex = 66
        Me.CfgTotRevToLabel.Text = "To"
        '
        'CfgTotRevFromLabel
        '
        Me.CfgTotRevFromLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgTotRevFromLabel.AutoSize = True
        Me.CfgTotRevFromLabel.Location = New System.Drawing.Point(308, 146)
        Me.CfgTotRevFromLabel.Name = "CfgTotRevFromLabel"
        Me.CfgTotRevFromLabel.Size = New System.Drawing.Size(65, 13)
        Me.CfgTotRevFromLabel.TabIndex = 65
        Me.CfgTotRevFromLabel.Text = "Range From"
        '
        'CfgTotRevChkBox
        '
        Me.CfgTotRevChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgTotRevChkBox.AutoSize = True
        Me.CfgTotRevChkBox.Location = New System.Drawing.Point(14, 145)
        Me.CfgTotRevChkBox.Name = "CfgTotRevChkBox"
        Me.CfgTotRevChkBox.Size = New System.Drawing.Size(137, 17)
        Me.CfgTotRevChkBox.TabIndex = 64
        Me.CfgTotRevChkBox.Text = "Product Total Revenue"
        Me.CfgTotRevChkBox.UseVisualStyleBackColor = True
        '
        'CfgSaleVolChkBox
        '
        Me.CfgSaleVolChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgSaleVolChkBox.AutoSize = True
        Me.CfgSaleVolChkBox.Location = New System.Drawing.Point(14, 120)
        Me.CfgSaleVolChkBox.Name = "CfgSaleVolChkBox"
        Me.CfgSaleVolChkBox.Size = New System.Drawing.Size(130, 17)
        Me.CfgSaleVolChkBox.TabIndex = 76
        Me.CfgSaleVolChkBox.Text = "Product Sales Volume"
        Me.CfgSaleVolChkBox.UseVisualStyleBackColor = True
        '
        'CfgSaleVolComboBox
        '
        Me.CfgSaleVolComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgSaleVolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CfgSaleVolComboBox.FormattingEnabled = True
        Me.CfgSaleVolComboBox.Items.AddRange(New Object() {"This Month", "Last 2 Months", "Last 3 Months", "Last 6 Months", "Last 1 Year", "From Start"})
        Me.CfgSaleVolComboBox.Location = New System.Drawing.Point(198, 118)
        Me.CfgSaleVolComboBox.Name = "CfgSaleVolComboBox"
        Me.CfgSaleVolComboBox.Size = New System.Drawing.Size(133, 21)
        Me.CfgSaleVolComboBox.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Since"
        '
        'CfgCanelBtn
        '
        Me.CfgCanelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CfgCanelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CfgCanelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CfgCanelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.CfgCanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CfgCanelBtn.Location = New System.Drawing.Point(363, 238)
        Me.CfgCanelBtn.Name = "CfgCanelBtn"
        Me.CfgCanelBtn.Size = New System.Drawing.Size(121, 45)
        Me.CfgCanelBtn.TabIndex = 79
        Me.CfgCanelBtn.Text = "Cancel"
        Me.CfgCanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CfgCanelBtn.UseVisualStyleBackColor = True
        '
        'CfgSaveBtn
        '
        Me.CfgSaveBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CfgSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CfgSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Generate_icon
        Me.CfgSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CfgSaveBtn.Location = New System.Drawing.Point(490, 238)
        Me.CfgSaveBtn.Name = "CfgSaveBtn"
        Me.CfgSaveBtn.Size = New System.Drawing.Size(121, 45)
        Me.CfgSaveBtn.TabIndex = 80
        Me.CfgSaveBtn.Text = "Generate"
        Me.CfgSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CfgSaveBtn.UseVisualStyleBackColor = True
        '
        'ReportConfigProdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CfgCanelBtn
        Me.ClientSize = New System.Drawing.Size(623, 295)
        Me.Controls.Add(Me.CfgSaveBtn)
        Me.Controls.Add(Me.CfgCanelBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CfgSaleVolComboBox)
        Me.Controls.Add(Me.CfgSaleVolChkBox)
        Me.Controls.Add(Me.CfgTotRevRangeChkBox)
        Me.Controls.Add(Me.CfgTotRevToTextBox)
        Me.Controls.Add(Me.CfgTotRevFromTextBox)
        Me.Controls.Add(Me.CfgTotRevToLabel)
        Me.Controls.Add(Me.CfgTotRevFromLabel)
        Me.Controls.Add(Me.CfgTotRevChkBox)
        Me.Controls.Add(Me.CfgFindProdBtn)
        Me.Controls.Add(Me.CfgNameComboBox)
        Me.Controls.Add(Me.CfgWarrChkBox)
        Me.Controls.Add(Me.CfgPriceChkBox)
        Me.Controls.Add(Me.CfgNameChkBox)
        Me.Name = "ReportConfigProdForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Configuration - Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CfgWarrChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgPriceChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgNameChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgFindProdBtn As System.Windows.Forms.Button
    Friend WithEvents CfgNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CfgTotRevRangeChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgTotRevToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CfgTotRevFromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CfgTotRevToLabel As System.Windows.Forms.Label
    Friend WithEvents CfgTotRevFromLabel As System.Windows.Forms.Label
    Friend WithEvents CfgTotRevChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgSaleVolChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgSaleVolComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CfgCanelBtn As System.Windows.Forms.Button
    Friend WithEvents CfgSaveBtn As System.Windows.Forms.Button
End Class
