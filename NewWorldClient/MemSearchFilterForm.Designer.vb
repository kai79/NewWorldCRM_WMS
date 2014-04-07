<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MemSearchFilterForm
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
        Me.MemSearchFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.MemSearchFilterTextBox = New System.Windows.Forms.TextBox()
        Me.MemSearchFilterOKBtn = New System.Windows.Forms.Button()
        Me.MemSearchfilterCanBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MemSearchFilterComboBox
        '
        Me.MemSearchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MemSearchFilterComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemSearchFilterComboBox.FormattingEnabled = True
        Me.MemSearchFilterComboBox.Items.AddRange(New Object() {"Contains", "Does Not Contains", "Start With", "End With", "Equal", "Does Not Equal"})
        Me.MemSearchFilterComboBox.Location = New System.Drawing.Point(12, 12)
        Me.MemSearchFilterComboBox.Name = "MemSearchFilterComboBox"
        Me.MemSearchFilterComboBox.Size = New System.Drawing.Size(121, 24)
        Me.MemSearchFilterComboBox.TabIndex = 0
        '
        'MemSearchFilterTextBox
        '
        Me.MemSearchFilterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemSearchFilterTextBox.Location = New System.Drawing.Point(139, 12)
        Me.MemSearchFilterTextBox.Name = "MemSearchFilterTextBox"
        Me.MemSearchFilterTextBox.Size = New System.Drawing.Size(306, 22)
        Me.MemSearchFilterTextBox.TabIndex = 1
        '
        'MemSearchFilterOKBtn
        '
        Me.MemSearchFilterOKBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemSearchFilterOKBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_Filter_icon
        Me.MemSearchFilterOKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MemSearchFilterOKBtn.Location = New System.Drawing.Point(360, 49)
        Me.MemSearchFilterOKBtn.Name = "MemSearchFilterOKBtn"
        Me.MemSearchFilterOKBtn.Size = New System.Drawing.Size(85, 36)
        Me.MemSearchFilterOKBtn.TabIndex = 2
        Me.MemSearchFilterOKBtn.Text = "Filter"
        Me.MemSearchFilterOKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MemSearchFilterOKBtn.UseVisualStyleBackColor = True
        '
        'MemSearchfilterCanBtn
        '
        Me.MemSearchfilterCanBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.MemSearchfilterCanBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MemSearchfilterCanBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_Close_icon
        Me.MemSearchfilterCanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MemSearchfilterCanBtn.Location = New System.Drawing.Point(269, 49)
        Me.MemSearchfilterCanBtn.Name = "MemSearchfilterCanBtn"
        Me.MemSearchfilterCanBtn.Size = New System.Drawing.Size(85, 36)
        Me.MemSearchfilterCanBtn.TabIndex = 3
        Me.MemSearchfilterCanBtn.Text = "Cancel"
        Me.MemSearchfilterCanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MemSearchfilterCanBtn.UseVisualStyleBackColor = True
        '
        'MemSearchFilterForm
        '
        Me.AcceptButton = Me.MemSearchFilterOKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.MemSearchfilterCanBtn
        Me.ClientSize = New System.Drawing.Size(457, 97)
        Me.Controls.Add(Me.MemSearchfilterCanBtn)
        Me.Controls.Add(Me.MemSearchFilterOKBtn)
        Me.Controls.Add(Me.MemSearchFilterTextBox)
        Me.Controls.Add(Me.MemSearchFilterComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MemSearchFilterForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MemSearchFilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MemSearchFilterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MemSearchFilterOKBtn As System.Windows.Forms.Button
    Friend WithEvents MemSearchfilterCanBtn As System.Windows.Forms.Button
End Class
