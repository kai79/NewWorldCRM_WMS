<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhAddNewProdForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhAddNewProdForm))
        Me.WhAddNewProdSaveBtn = New System.Windows.Forms.Button()
        Me.WhAddNewProdCancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WhAddNewProdNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WhAddNewProdTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WhAddNewProdExCatComboBox = New System.Windows.Forms.ComboBox()
        Me.WhAddNewProdNwCatTexBox = New System.Windows.Forms.TextBox()
        Me.WhAddNewProdNwCatRadioBtn = New System.Windows.Forms.RadioButton()
        Me.WhAddNewProdExCatRadioBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WhAddNewProdSaveBtn
        '
        Me.WhAddNewProdSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdSaveBtn.Image = Global.WindowsApplication1.My.Resources.Resources.save2_icon
        Me.WhAddNewProdSaveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddNewProdSaveBtn.Location = New System.Drawing.Point(401, 12)
        Me.WhAddNewProdSaveBtn.Name = "WhAddNewProdSaveBtn"
        Me.WhAddNewProdSaveBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddNewProdSaveBtn.TabIndex = 8
        Me.WhAddNewProdSaveBtn.Text = "Save"
        Me.WhAddNewProdSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddNewProdSaveBtn.UseVisualStyleBackColor = True
        '
        'WhAddNewProdCancelBtn
        '
        Me.WhAddNewProdCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.WhAddNewProdCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.WhAddNewProdCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhAddNewProdCancelBtn.Location = New System.Drawing.Point(245, 12)
        Me.WhAddNewProdCancelBtn.Name = "WhAddNewProdCancelBtn"
        Me.WhAddNewProdCancelBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhAddNewProdCancelBtn.TabIndex = 9
        Me.WhAddNewProdCancelBtn.Text = "Cancel"
        Me.WhAddNewProdCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhAddNewProdCancelBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WhAddNewProdNoTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.WhAddNewProdTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.WhAddNewProdExCatComboBox)
        Me.GroupBox1.Controls.Add(Me.WhAddNewProdNwCatTexBox)
        Me.GroupBox1.Controls.Add(Me.WhAddNewProdNwCatRadioBtn)
        Me.GroupBox1.Controls.Add(Me.WhAddNewProdExCatRadioBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 197)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'WhAddNewProdNoTextBox
        '
        Me.WhAddNewProdNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdNoTextBox.Location = New System.Drawing.Point(269, 143)
        Me.WhAddNewProdNoTextBox.Name = "WhAddNewProdNoTextBox"
        Me.WhAddNewProdNoTextBox.Size = New System.Drawing.Size(250, 26)
        Me.WhAddNewProdNoTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Product Number (产品编号):"
        '
        'WhAddNewProdTextBox
        '
        Me.WhAddNewProdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdTextBox.Location = New System.Drawing.Point(269, 105)
        Me.WhAddNewProdTextBox.Name = "WhAddNewProdTextBox"
        Me.WhAddNewProdTextBox.Size = New System.Drawing.Size(250, 26)
        Me.WhAddNewProdTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Product Name (产品名称):"
        '
        'WhAddNewProdExCatComboBox
        '
        Me.WhAddNewProdExCatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WhAddNewProdExCatComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdExCatComboBox.FormattingEnabled = True
        Me.WhAddNewProdExCatComboBox.Location = New System.Drawing.Point(269, 28)
        Me.WhAddNewProdExCatComboBox.Name = "WhAddNewProdExCatComboBox"
        Me.WhAddNewProdExCatComboBox.Size = New System.Drawing.Size(250, 28)
        Me.WhAddNewProdExCatComboBox.TabIndex = 3
        '
        'WhAddNewProdNwCatTexBox
        '
        Me.WhAddNewProdNwCatTexBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdNwCatTexBox.Location = New System.Drawing.Point(269, 65)
        Me.WhAddNewProdNwCatTexBox.Name = "WhAddNewProdNwCatTexBox"
        Me.WhAddNewProdNwCatTexBox.Size = New System.Drawing.Size(250, 26)
        Me.WhAddNewProdNwCatTexBox.TabIndex = 2
        '
        'WhAddNewProdNwCatRadioBtn
        '
        Me.WhAddNewProdNwCatRadioBtn.AutoSize = True
        Me.WhAddNewProdNwCatRadioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdNwCatRadioBtn.Location = New System.Drawing.Point(27, 65)
        Me.WhAddNewProdNwCatRadioBtn.Name = "WhAddNewProdNwCatRadioBtn"
        Me.WhAddNewProdNwCatRadioBtn.Size = New System.Drawing.Size(192, 24)
        Me.WhAddNewProdNwCatRadioBtn.TabIndex = 1
        Me.WhAddNewProdNwCatRadioBtn.TabStop = True
        Me.WhAddNewProdNwCatRadioBtn.Text = "New Category (新类别):"
        Me.WhAddNewProdNwCatRadioBtn.UseVisualStyleBackColor = True
        '
        'WhAddNewProdExCatRadioBtn
        '
        Me.WhAddNewProdExCatRadioBtn.AutoSize = True
        Me.WhAddNewProdExCatRadioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhAddNewProdExCatRadioBtn.Location = New System.Drawing.Point(27, 29)
        Me.WhAddNewProdExCatRadioBtn.Name = "WhAddNewProdExCatRadioBtn"
        Me.WhAddNewProdExCatRadioBtn.Size = New System.Drawing.Size(232, 24)
        Me.WhAddNewProdExCatRadioBtn.TabIndex = 0
        Me.WhAddNewProdExCatRadioBtn.TabStop = True
        Me.WhAddNewProdExCatRadioBtn.Text = "Existing Category (产品类别):"
        Me.WhAddNewProdExCatRadioBtn.UseVisualStyleBackColor = True
        '
        'WhAddNewProdForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.WhAddNewProdCancelBtn
        Me.ClientSize = New System.Drawing.Size(563, 291)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WhAddNewProdCancelBtn)
        Me.Controls.Add(Me.WhAddNewProdSaveBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhAddNewProdForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WhAddNewProdSaveBtn As System.Windows.Forms.Button
    Friend WithEvents WhAddNewProdCancelBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WhAddNewProdNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WhAddNewProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WhAddNewProdExCatComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WhAddNewProdNwCatTexBox As System.Windows.Forms.TextBox
    Friend WithEvents WhAddNewProdNwCatRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents WhAddNewProdExCatRadioBtn As System.Windows.Forms.RadioButton
End Class
