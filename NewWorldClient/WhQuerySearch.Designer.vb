<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhQuerySearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhQuerySearch))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TransTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DevDateLowDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CusTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProByComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EditedComboBox = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RecipentTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PONumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProBySelectCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProByAllCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DevDateHighDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WhSearchBtn = New System.Windows.Forms.Button()
        Me.WhCancelBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction Type:"
        '
        'TransTypeComboBox
        '
        Me.TransTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TransTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransTypeComboBox.FormattingEnabled = True
        Me.TransTypeComboBox.Items.AddRange(New Object() {"All", "In", "Out"})
        Me.TransTypeComboBox.Location = New System.Drawing.Point(167, 35)
        Me.TransTypeComboBox.Name = "TransTypeComboBox"
        Me.TransTypeComboBox.Size = New System.Drawing.Size(97, 28)
        Me.TransTypeComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Delivery Date:"
        '
        'DevDateLowDatePicker
        '
        Me.DevDateLowDatePicker.CustomFormat = ""
        Me.DevDateLowDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevDateLowDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DevDateLowDatePicker.Location = New System.Drawing.Point(241, 69)
        Me.DevDateLowDatePicker.Name = "DevDateLowDatePicker"
        Me.DevDateLowDatePicker.Size = New System.Drawing.Size(104, 26)
        Me.DevDateLowDatePicker.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer Type:"
        '
        'CusTypeComboBox
        '
        Me.CusTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CusTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusTypeComboBox.FormattingEnabled = True
        Me.CusTypeComboBox.Items.AddRange(New Object() {"All", "Home", "Company"})
        Me.CusTypeComboBox.Location = New System.Drawing.Point(167, 104)
        Me.CusTypeComboBox.Name = "CusTypeComboBox"
        Me.CusTypeComboBox.Size = New System.Drawing.Size(143, 28)
        Me.CusTypeComboBox.TabIndex = 5
        '
        'ProByComboBox
        '
        Me.ProByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProByComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProByComboBox.FormattingEnabled = True
        Me.ProByComboBox.Location = New System.Drawing.Point(284, 264)
        Me.ProByComboBox.Name = "ProByComboBox"
        Me.ProByComboBox.Size = New System.Drawing.Size(97, 28)
        Me.ProByComboBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(69, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Process By:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.EditedComboBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.RecipentTextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.PONumberTextBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ProBySelectCheckBox)
        Me.GroupBox1.Controls.Add(Me.ProByAllCheckBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DevDateHighDatePicker)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TransTypeComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DevDateLowDatePicker)
        Me.GroupBox1.Controls.Add(Me.ProByComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CusTypeComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 318)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Filter"
        '
        'EditedComboBox
        '
        Me.EditedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EditedComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditedComboBox.FormattingEnabled = True
        Me.EditedComboBox.Items.AddRange(New Object() {"Any", "Yes", "No"})
        Me.EditedComboBox.Location = New System.Drawing.Point(167, 202)
        Me.EditedComboBox.Name = "EditedComboBox"
        Me.EditedComboBox.Size = New System.Drawing.Size(97, 28)
        Me.EditedComboBox.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(102, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Edited:"
        '
        'RecipentTextBox
        '
        Me.RecipentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecipentTextBox.Location = New System.Drawing.Point(167, 170)
        Me.RecipentTextBox.Name = "RecipentTextBox"
        Me.RecipentTextBox.Size = New System.Drawing.Size(321, 26)
        Me.RecipentTextBox.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Recipient:"
        '
        'PONumberTextBox
        '
        Me.PONumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PONumberTextBox.Location = New System.Drawing.Point(167, 138)
        Me.PONumberTextBox.Name = "PONumberTextBox"
        Me.PONumberTextBox.Size = New System.Drawing.Size(143, 26)
        Me.PONumberTextBox.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "PO Number:"
        '
        'ProBySelectCheckBox
        '
        Me.ProBySelectCheckBox.AutoSize = True
        Me.ProBySelectCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProBySelectCheckBox.Location = New System.Drawing.Point(167, 266)
        Me.ProBySelectCheckBox.Name = "ProBySelectCheckBox"
        Me.ProBySelectCheckBox.Size = New System.Drawing.Size(111, 24)
        Me.ProBySelectCheckBox.TabIndex = 14
        Me.ProBySelectCheckBox.Text = "Select User"
        Me.ProBySelectCheckBox.UseVisualStyleBackColor = True
        '
        'ProByAllCheckBox
        '
        Me.ProByAllCheckBox.AutoSize = True
        Me.ProByAllCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProByAllCheckBox.Location = New System.Drawing.Point(167, 236)
        Me.ProByAllCheckBox.Name = "ProByAllCheckBox"
        Me.ProByAllCheckBox.Size = New System.Drawing.Size(45, 24)
        Me.ProByAllCheckBox.TabIndex = 13
        Me.ProByAllCheckBox.Text = "All"
        Me.ProByAllCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(351, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "To"
        '
        'DevDateHighDatePicker
        '
        Me.DevDateHighDatePicker.CustomFormat = ""
        Me.DevDateHighDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevDateHighDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DevDateHighDatePicker.Location = New System.Drawing.Point(384, 69)
        Me.DevDateHighDatePicker.Name = "DevDateHighDatePicker"
        Me.DevDateHighDatePicker.Size = New System.Drawing.Size(104, 26)
        Me.DevDateHighDatePicker.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Between"
        '
        'WhSearchBtn
        '
        Me.WhSearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhSearchBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Document_search_icon
        Me.WhSearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhSearchBtn.Location = New System.Drawing.Point(27, 12)
        Me.WhSearchBtn.Name = "WhSearchBtn"
        Me.WhSearchBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhSearchBtn.TabIndex = 20
        Me.WhSearchBtn.Text = "Search"
        Me.WhSearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhSearchBtn.UseVisualStyleBackColor = True
        '
        'WhCancelBtn
        '
        Me.WhCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.WhCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhCancelBtn.Location = New System.Drawing.Point(187, 12)
        Me.WhCancelBtn.Name = "WhCancelBtn"
        Me.WhCancelBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhCancelBtn.TabIndex = 21
        Me.WhCancelBtn.Text = "Cancel"
        Me.WhCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhCancelBtn.UseVisualStyleBackColor = True
        '
        'WhQuerySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 420)
        Me.Controls.Add(Me.WhCancelBtn)
        Me.Controls.Add(Me.WhSearchBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhQuerySearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TransTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DevDateLowDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CusTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ProByComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WhSearchBtn As System.Windows.Forms.Button
    Friend WithEvents WhCancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DevDateHighDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProBySelectCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ProByAllCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PONumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RecipentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
