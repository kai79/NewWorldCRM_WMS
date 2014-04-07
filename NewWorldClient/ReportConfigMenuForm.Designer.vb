<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportConfigMenuForm
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
        Me.CfgNameChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgFindMenuBtn = New System.Windows.Forms.Button()
        Me.CfgMenuNameComboBox = New System.Windows.Forms.ComboBox()
        Me.CfgClsDateToDatePick = New System.Windows.Forms.DateTimePicker()
        Me.CfgClsDateFromDatePick = New System.Windows.Forms.DateTimePicker()
        Me.CfgClsDateRangeChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgClsDateComboBox = New System.Windows.Forms.ComboBox()
        Me.CfgClsDateToLabel = New System.Windows.Forms.Label()
        Me.CfgClsDateFromLabel = New System.Windows.Forms.Label()
        Me.CfgClsDateChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgTotPartChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgClsTotCntChkBox = New System.Windows.Forms.CheckBox()
        Me.CfgCanelBtn = New System.Windows.Forms.Button()
        Me.CfgSaveBtn = New System.Windows.Forms.Button()
        Me.CfgClsPartChkBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CfgNameChkBox
        '
        Me.CfgNameChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgNameChkBox.AutoSize = True
        Me.CfgNameChkBox.Checked = True
        Me.CfgNameChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CfgNameChkBox.Enabled = False
        Me.CfgNameChkBox.Location = New System.Drawing.Point(15, 37)
        Me.CfgNameChkBox.Name = "CfgNameChkBox"
        Me.CfgNameChkBox.Size = New System.Drawing.Size(84, 17)
        Me.CfgNameChkBox.TabIndex = 1
        Me.CfgNameChkBox.Text = "Menu Name"
        Me.CfgNameChkBox.UseVisualStyleBackColor = True
        '
        'CfgFindMenuBtn
        '
        Me.CfgFindMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgFindMenuBtn.Location = New System.Drawing.Point(240, 35)
        Me.CfgFindMenuBtn.Name = "CfgFindMenuBtn"
        Me.CfgFindMenuBtn.Size = New System.Drawing.Size(98, 23)
        Me.CfgFindMenuBtn.TabIndex = 62
        Me.CfgFindMenuBtn.Text = "Find Menu"
        Me.CfgFindMenuBtn.UseVisualStyleBackColor = True
        '
        'CfgMenuNameComboBox
        '
        Me.CfgMenuNameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgMenuNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CfgMenuNameComboBox.FormattingEnabled = True
        Me.CfgMenuNameComboBox.Items.AddRange(New Object() {"All", "In", "Not In"})
        Me.CfgMenuNameComboBox.Location = New System.Drawing.Point(168, 37)
        Me.CfgMenuNameComboBox.Name = "CfgMenuNameComboBox"
        Me.CfgMenuNameComboBox.Size = New System.Drawing.Size(66, 21)
        Me.CfgMenuNameComboBox.TabIndex = 61
        '
        'CfgClsDateToDatePick
        '
        Me.CfgClsDateToDatePick.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsDateToDatePick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CfgClsDateToDatePick.Location = New System.Drawing.Point(500, 88)
        Me.CfgClsDateToDatePick.Name = "CfgClsDateToDatePick"
        Me.CfgClsDateToDatePick.Size = New System.Drawing.Size(98, 20)
        Me.CfgClsDateToDatePick.TabIndex = 83
        '
        'CfgClsDateFromDatePick
        '
        Me.CfgClsDateFromDatePick.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsDateFromDatePick.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CfgClsDateFromDatePick.Location = New System.Drawing.Point(373, 88)
        Me.CfgClsDateFromDatePick.Name = "CfgClsDateFromDatePick"
        Me.CfgClsDateFromDatePick.Size = New System.Drawing.Size(98, 20)
        Me.CfgClsDateFromDatePick.TabIndex = 82
        '
        'CfgClsDateRangeChkBox
        '
        Me.CfgClsDateRangeChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsDateRangeChkBox.AutoSize = True
        Me.CfgClsDateRangeChkBox.Location = New System.Drawing.Point(168, 64)
        Me.CfgClsDateRangeChkBox.Name = "CfgClsDateRangeChkBox"
        Me.CfgClsDateRangeChkBox.Size = New System.Drawing.Size(141, 17)
        Me.CfgClsDateRangeChkBox.TabIndex = 81
        Me.CfgClsDateRangeChkBox.Text = "Enable Range Selection"
        Me.CfgClsDateRangeChkBox.UseVisualStyleBackColor = True
        '
        'CfgClsDateComboBox
        '
        Me.CfgClsDateComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CfgClsDateComboBox.FormattingEnabled = True
        Me.CfgClsDateComboBox.Items.AddRange(New Object() {"Between", "Not Between"})
        Me.CfgClsDateComboBox.Location = New System.Drawing.Point(168, 87)
        Me.CfgClsDateComboBox.Name = "CfgClsDateComboBox"
        Me.CfgClsDateComboBox.Size = New System.Drawing.Size(128, 21)
        Me.CfgClsDateComboBox.TabIndex = 80
        '
        'CfgClsDateToLabel
        '
        Me.CfgClsDateToLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsDateToLabel.AutoSize = True
        Me.CfgClsDateToLabel.Location = New System.Drawing.Point(474, 90)
        Me.CfgClsDateToLabel.Name = "CfgClsDateToLabel"
        Me.CfgClsDateToLabel.Size = New System.Drawing.Size(20, 13)
        Me.CfgClsDateToLabel.TabIndex = 79
        Me.CfgClsDateToLabel.Text = "To"
        '
        'CfgClsDateFromLabel
        '
        Me.CfgClsDateFromLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsDateFromLabel.AutoSize = True
        Me.CfgClsDateFromLabel.Location = New System.Drawing.Point(302, 90)
        Me.CfgClsDateFromLabel.Name = "CfgClsDateFromLabel"
        Me.CfgClsDateFromLabel.Size = New System.Drawing.Size(65, 13)
        Me.CfgClsDateFromLabel.TabIndex = 78
        Me.CfgClsDateFromLabel.Text = "Range From"
        '
        'CfgClsDateChkBox
        '
        Me.CfgClsDateChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsDateChkBox.AutoSize = True
        Me.CfgClsDateChkBox.Checked = True
        Me.CfgClsDateChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CfgClsDateChkBox.Enabled = False
        Me.CfgClsDateChkBox.Location = New System.Drawing.Point(15, 62)
        Me.CfgClsDateChkBox.Name = "CfgClsDateChkBox"
        Me.CfgClsDateChkBox.Size = New System.Drawing.Size(77, 17)
        Me.CfgClsDateChkBox.TabIndex = 77
        Me.CfgClsDateChkBox.Text = "Class Date"
        Me.CfgClsDateChkBox.UseVisualStyleBackColor = True
        '
        'CfgTotPartChkBox
        '
        Me.CfgTotPartChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgTotPartChkBox.AutoSize = True
        Me.CfgTotPartChkBox.Location = New System.Drawing.Point(15, 136)
        Me.CfgTotPartChkBox.Name = "CfgTotPartChkBox"
        Me.CfgTotPartChkBox.Size = New System.Drawing.Size(108, 17)
        Me.CfgTotPartChkBox.TabIndex = 84
        Me.CfgTotPartChkBox.Text = "Total Participants"
        Me.CfgTotPartChkBox.UseVisualStyleBackColor = True
        '
        'CfgClsTotCntChkBox
        '
        Me.CfgClsTotCntChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsTotCntChkBox.AutoSize = True
        Me.CfgClsTotCntChkBox.Location = New System.Drawing.Point(15, 159)
        Me.CfgClsTotCntChkBox.Name = "CfgClsTotCntChkBox"
        Me.CfgClsTotCntChkBox.Size = New System.Drawing.Size(123, 17)
        Me.CfgClsTotCntChkBox.TabIndex = 85
        Me.CfgClsTotCntChkBox.Text = "Sessions Conducted"
        Me.CfgClsTotCntChkBox.UseVisualStyleBackColor = True
        '
        'CfgCanelBtn
        '
        Me.CfgCanelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CfgCanelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CfgCanelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CfgCanelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.CfgCanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CfgCanelBtn.Location = New System.Drawing.Point(375, 243)
        Me.CfgCanelBtn.Name = "CfgCanelBtn"
        Me.CfgCanelBtn.Size = New System.Drawing.Size(121, 45)
        Me.CfgCanelBtn.TabIndex = 87
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
        Me.CfgSaveBtn.Location = New System.Drawing.Point(502, 243)
        Me.CfgSaveBtn.Name = "CfgSaveBtn"
        Me.CfgSaveBtn.Size = New System.Drawing.Size(121, 45)
        Me.CfgSaveBtn.TabIndex = 86
        Me.CfgSaveBtn.Text = "Generate"
        Me.CfgSaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CfgSaveBtn.UseVisualStyleBackColor = True
        '
        'CfgClsPartChkBox
        '
        Me.CfgClsPartChkBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CfgClsPartChkBox.AutoSize = True
        Me.CfgClsPartChkBox.Location = New System.Drawing.Point(15, 113)
        Me.CfgClsPartChkBox.Name = "CfgClsPartChkBox"
        Me.CfgClsPartChkBox.Size = New System.Drawing.Size(109, 17)
        Me.CfgClsPartChkBox.TabIndex = 89
        Me.CfgClsPartChkBox.Text = "Class Participants"
        Me.CfgClsPartChkBox.UseVisualStyleBackColor = True
        '
        'ReportConfigMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CfgCanelBtn
        Me.ClientSize = New System.Drawing.Size(635, 300)
        Me.Controls.Add(Me.CfgClsPartChkBox)
        Me.Controls.Add(Me.CfgCanelBtn)
        Me.Controls.Add(Me.CfgSaveBtn)
        Me.Controls.Add(Me.CfgClsTotCntChkBox)
        Me.Controls.Add(Me.CfgTotPartChkBox)
        Me.Controls.Add(Me.CfgClsDateToDatePick)
        Me.Controls.Add(Me.CfgClsDateFromDatePick)
        Me.Controls.Add(Me.CfgClsDateRangeChkBox)
        Me.Controls.Add(Me.CfgClsDateComboBox)
        Me.Controls.Add(Me.CfgClsDateToLabel)
        Me.Controls.Add(Me.CfgClsDateFromLabel)
        Me.Controls.Add(Me.CfgClsDateChkBox)
        Me.Controls.Add(Me.CfgFindMenuBtn)
        Me.Controls.Add(Me.CfgMenuNameComboBox)
        Me.Controls.Add(Me.CfgNameChkBox)
        Me.Name = "ReportConfigMenuForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Configuration - Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CfgNameChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgFindMenuBtn As System.Windows.Forms.Button
    Friend WithEvents CfgMenuNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CfgClsDateToDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents CfgClsDateFromDatePick As System.Windows.Forms.DateTimePicker
    Friend WithEvents CfgClsDateRangeChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgClsDateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CfgClsDateToLabel As System.Windows.Forms.Label
    Friend WithEvents CfgClsDateFromLabel As System.Windows.Forms.Label
    Friend WithEvents CfgClsDateChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgTotPartChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgClsTotCntChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents CfgCanelBtn As System.Windows.Forms.Button
    Friend WithEvents CfgSaveBtn As System.Windows.Forms.Button
    Friend WithEvents CfgClsPartChkBox As System.Windows.Forms.CheckBox
End Class
