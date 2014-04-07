<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRefFilterForm
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
        Me.AddRefFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.AddRefFilterTextBox = New System.Windows.Forms.TextBox()
        Me.AddRefFilterOKBtn = New System.Windows.Forms.Button()
        Me.AddRefFilterCancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddRefFilterComboBox
        '
        Me.AddRefFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AddRefFilterComboBox.FormattingEnabled = True
        Me.AddRefFilterComboBox.Items.AddRange(New Object() {"Contains", "Does Not Contains", "Start With", "End With", "Equal", "Does Not Equal"})
        Me.AddRefFilterComboBox.Location = New System.Drawing.Point(12, 12)
        Me.AddRefFilterComboBox.Name = "AddRefFilterComboBox"
        Me.AddRefFilterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AddRefFilterComboBox.TabIndex = 0
        '
        'AddRefFilterTextBox
        '
        Me.AddRefFilterTextBox.Location = New System.Drawing.Point(139, 13)
        Me.AddRefFilterTextBox.Name = "AddRefFilterTextBox"
        Me.AddRefFilterTextBox.Size = New System.Drawing.Size(306, 20)
        Me.AddRefFilterTextBox.TabIndex = 1
        '
        'AddRefFilterOKBtn
        '
        Me.AddRefFilterOKBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_Filter_icon
        Me.AddRefFilterOKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddRefFilterOKBtn.Location = New System.Drawing.Point(360, 49)
        Me.AddRefFilterOKBtn.Name = "AddRefFilterOKBtn"
        Me.AddRefFilterOKBtn.Size = New System.Drawing.Size(85, 36)
        Me.AddRefFilterOKBtn.TabIndex = 2
        Me.AddRefFilterOKBtn.Text = "Filter"
        Me.AddRefFilterOKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddRefFilterOKBtn.UseVisualStyleBackColor = True
        '
        'AddRefFilterCancelBtn
        '
        Me.AddRefFilterCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AddRefFilterCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_Close_icon
        Me.AddRefFilterCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddRefFilterCancelBtn.Location = New System.Drawing.Point(269, 49)
        Me.AddRefFilterCancelBtn.Name = "AddRefFilterCancelBtn"
        Me.AddRefFilterCancelBtn.Size = New System.Drawing.Size(85, 36)
        Me.AddRefFilterCancelBtn.TabIndex = 3
        Me.AddRefFilterCancelBtn.Text = "Cancel"
        Me.AddRefFilterCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddRefFilterCancelBtn.UseVisualStyleBackColor = True
        '
        'AddRefFilterForm
        '
        Me.AcceptButton = Me.AddRefFilterOKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.AddRefFilterCancelBtn
        Me.ClientSize = New System.Drawing.Size(457, 97)
        Me.Controls.Add(Me.AddRefFilterCancelBtn)
        Me.Controls.Add(Me.AddRefFilterOKBtn)
        Me.Controls.Add(Me.AddRefFilterTextBox)
        Me.Controls.Add(Me.AddRefFilterComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddRefFilterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddRefFilterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddRefFilterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddRefFilterOKBtn As System.Windows.Forms.Button
    Friend WithEvents AddRefFilterCancelBtn As System.Windows.Forms.Button
End Class
