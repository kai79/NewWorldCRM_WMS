<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhAddProdForm
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
        Dim WhOutRecRemarkLabel As System.Windows.Forms.Label
        Dim WhOutRecQtyLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhAddProdForm))
        Me.WhAddProdLbl = New System.Windows.Forms.Label()
        Me.WhAddProdCatLbl = New System.Windows.Forms.Label()
        Me.WhOutRecRemarkTextBox = New System.Windows.Forms.TextBox()
        Me.WhAddProdCatComboBox = New System.Windows.Forms.ComboBox()
        Me.WhAddProdComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WhOutRecQtyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.WhAddProdNewBtn = New System.Windows.Forms.Button()
        Me.WhAddProdOKBtn = New System.Windows.Forms.Button()
        Me.WhAddProdCancelBtn = New System.Windows.Forms.Button()
        WhOutRecRemarkLabel = New System.Windows.Forms.Label()
        WhOutRecQtyLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.WhOutRecQtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WhOutRecRemarkLabel
        '
        WhOutRecRemarkLabel.AutoSize = True
        WhOutRecRemarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhOutRecRemarkLabel.Location = New System.Drawing.Point(169, 98)
        WhOutRecRemarkLabel.Name = "WhOutRecRemarkLabel"
        WhOutRecRemarkLabel.Size = New System.Drawing.Size(136, 20)
        WhOutRecRemarkLabel.TabIndex = 5
        WhOutRecRemarkLabel.Text = "Comments (说明):"
        '
        'WhOutRecQtyLabel
        '
        WhOutRecQtyLabel.AutoSize = True
        WhOutRecQtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WhOutRecQtyLabel.Location = New System.Drawing.Point(22, 98)
        WhOutRecQtyLabel.Name = "WhOutRecQtyLabel"
        WhOutRecQtyLabel.Size = New System.Drawing.Size(118, 20)
        WhOutRecQtyLabel.TabIndex = 6
        WhOutRecQtyLabel.Text = "Quantity (数量):"
        '
        'WhAddProdLbl
        '
        Me.WhAddProdLbl.AutoSize = True
        Me.WhAddProdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdLbl.Location = New System.Drawing.Point(246, 27)
        Me.WhAddProdLbl.Name = "WhAddProdLbl"
        Me.WhAddProdLbl.Size = New System.Drawing.Size(146, 20)
        Me.WhAddProdLbl.TabIndex = 3
        Me.WhAddProdLbl.Text = "Product (产品名称):"
        '
        'WhAddProdCatLbl
        '
        Me.WhAddProdCatLbl.AutoSize = True
        Me.WhAddProdCatLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdCatLbl.Location = New System.Drawing.Point(22, 27)
        Me.WhAddProdCatLbl.Name = "WhAddProdCatLbl"
        Me.WhAddProdCatLbl.Size = New System.Drawing.Size(214, 20)
        Me.WhAddProdCatLbl.TabIndex = 1
        Me.WhAddProdCatLbl.Text = "Product Category (产品类别):"
        '
        'WhOutRecRemarkTextBox
        '
        Me.WhOutRecRemarkTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhOutRecRemarkTextBox.Location = New System.Drawing.Point(172, 121)
        Me.WhOutRecRemarkTextBox.Multiline = True
        Me.WhOutRecRemarkTextBox.Name = "WhOutRecRemarkTextBox"
        Me.WhOutRecRemarkTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.WhOutRecRemarkTextBox.Size = New System.Drawing.Size(430, 168)
        Me.WhOutRecRemarkTextBox.TabIndex = 6
        '
        'WhAddProdCatComboBox
        '
        Me.WhAddProdCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhAddProdCatComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdCatComboBox.FormattingEnabled = True
        Me.WhAddProdCatComboBox.Location = New System.Drawing.Point(25, 50)
        Me.WhAddProdCatComboBox.Name = "WhAddProdCatComboBox"
        Me.WhAddProdCatComboBox.Size = New System.Drawing.Size(193, 28)
        Me.WhAddProdCatComboBox.TabIndex = 0
        '
        'WhAddProdComboBox
        '
        Me.WhAddProdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhAddProdComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdComboBox.FormattingEnabled = True
        Me.WhAddProdComboBox.Location = New System.Drawing.Point(250, 50)
        Me.WhAddProdComboBox.Name = "WhAddProdComboBox"
        Me.WhAddProdComboBox.Size = New System.Drawing.Size(352, 28)
        Me.WhAddProdComboBox.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WhOutRecQtyNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.WhAddProdCatComboBox)
        Me.GroupBox1.Controls.Add(Me.WhOutRecRemarkTextBox)
        Me.GroupBox1.Controls.Add(WhOutRecRemarkLabel)
        Me.GroupBox1.Controls.Add(Me.WhAddProdCatLbl)
        Me.GroupBox1.Controls.Add(Me.WhAddProdComboBox)
        Me.GroupBox1.Controls.Add(WhOutRecQtyLabel)
        Me.GroupBox1.Controls.Add(Me.WhAddProdLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 310)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Description"
        '
        'WhOutRecQtyNumericUpDown
        '
        Me.WhOutRecQtyNumericUpDown.BackColor = System.Drawing.Color.LightGreen
        Me.WhOutRecQtyNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhOutRecQtyNumericUpDown.Location = New System.Drawing.Point(26, 122)
        Me.WhOutRecQtyNumericUpDown.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.WhOutRecQtyNumericUpDown.Name = "WhOutRecQtyNumericUpDown"
        Me.WhOutRecQtyNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.WhOutRecQtyNumericUpDown.TabIndex = 8
        '
        'WhAddProdNewBtn
        '
        Me.WhAddProdNewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdNewBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Actions_bookmark_add_icon
        Me.WhAddProdNewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddProdNewBtn.Location = New System.Drawing.Point(17, 12)
        Me.WhAddProdNewBtn.Name = "WhAddProdNewBtn"
        Me.WhAddProdNewBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddProdNewBtn.TabIndex = 10
        Me.WhAddProdNewBtn.Text = "Add New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Product"
        Me.WhAddProdNewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddProdNewBtn.UseVisualStyleBackColor = True
        '
        'WhAddProdOKBtn
        '
        Me.WhAddProdOKBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdOKBtn.Image = Global.WindowsApplication1.My.Resources.Resources.check_icon
        Me.WhAddProdOKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddProdOKBtn.Location = New System.Drawing.Point(492, 12)
        Me.WhAddProdOKBtn.Name = "WhAddProdOKBtn"
        Me.WhAddProdOKBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddProdOKBtn.TabIndex = 7
        Me.WhAddProdOKBtn.Text = "OK"
        Me.WhAddProdOKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddProdOKBtn.UseVisualStyleBackColor = True
        '
        'WhAddProdCancelBtn
        '
        Me.WhAddProdCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.WhAddProdCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddProdCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.WhAddProdCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddProdCancelBtn.Location = New System.Drawing.Point(336, 12)
        Me.WhAddProdCancelBtn.Name = "WhAddProdCancelBtn"
        Me.WhAddProdCancelBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddProdCancelBtn.TabIndex = 8
        Me.WhAddProdCancelBtn.Text = "Cancel"
        Me.WhAddProdCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddProdCancelBtn.UseVisualStyleBackColor = True
        '
        'WhAddProdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.WhAddProdCancelBtn
        Me.ClientSize = New System.Drawing.Size(664, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WhAddProdNewBtn)
        Me.Controls.Add(Me.WhAddProdOKBtn)
        Me.Controls.Add(Me.WhAddProdCancelBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhAddProdForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product Description"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.WhOutRecQtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WhAddProdOKBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddProdCancelBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddProdNewBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddProdLbl As System.Windows.Forms.Label
    Friend WithEvents WhAddProdCatLbl As System.Windows.Forms.Label
    Friend WithEvents WhOutRecRemarkTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WhAddProdCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WhAddProdComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WhOutRecQtyNumericUpDown As System.Windows.Forms.NumericUpDown
End Class
