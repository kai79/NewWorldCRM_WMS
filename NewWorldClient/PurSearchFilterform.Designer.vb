<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurSearchFilterform
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
        Me.PurSearchFilterTextBox = New System.Windows.Forms.TextBox()
        Me.PurSearchFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.PurSearchCancelFilterBtn = New System.Windows.Forms.Button()
        Me.PurSearchFilterOKBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PurSearchFilterTextBox
        '
        Me.PurSearchFilterTextBox.Location = New System.Drawing.Point(134, 8)
        Me.PurSearchFilterTextBox.Name = "PurSearchFilterTextBox"
        Me.PurSearchFilterTextBox.Size = New System.Drawing.Size(306, 20)
        Me.PurSearchFilterTextBox.TabIndex = 5
        '
        'PurSearchFilterComboBox
        '
        Me.PurSearchFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PurSearchFilterComboBox.FormattingEnabled = True
        Me.PurSearchFilterComboBox.Items.AddRange(New Object() {"Contains", "Does Not Contains", "Start With", "End With", "Equal", "Does Not Equal"})
        Me.PurSearchFilterComboBox.Location = New System.Drawing.Point(7, 7)
        Me.PurSearchFilterComboBox.Name = "PurSearchFilterComboBox"
        Me.PurSearchFilterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PurSearchFilterComboBox.TabIndex = 4
        '
        'PurSearchCancelFilterBtn
        '
        Me.PurSearchCancelFilterBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.PurSearchCancelFilterBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_Close_icon
        Me.PurSearchCancelFilterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurSearchCancelFilterBtn.Location = New System.Drawing.Point(264, 44)
        Me.PurSearchCancelFilterBtn.Name = "PurSearchCancelFilterBtn"
        Me.PurSearchCancelFilterBtn.Size = New System.Drawing.Size(85, 36)
        Me.PurSearchCancelFilterBtn.TabIndex = 7
        Me.PurSearchCancelFilterBtn.Text = "Cancel"
        Me.PurSearchCancelFilterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PurSearchCancelFilterBtn.UseVisualStyleBackColor = True
        '
        'PurSearchFilterOKBtn
        '
        Me.PurSearchFilterOKBtn.Image = Global.WindowsApplication1.My.Resources.Resources.small_Filter_icon
        Me.PurSearchFilterOKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PurSearchFilterOKBtn.Location = New System.Drawing.Point(355, 44)
        Me.PurSearchFilterOKBtn.Name = "PurSearchFilterOKBtn"
        Me.PurSearchFilterOKBtn.Size = New System.Drawing.Size(85, 36)
        Me.PurSearchFilterOKBtn.TabIndex = 6
        Me.PurSearchFilterOKBtn.Text = "Filter"
        Me.PurSearchFilterOKBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PurSearchFilterOKBtn.UseVisualStyleBackColor = True
        '
        'PurSearchFilterform
        '
        Me.AcceptButton = Me.PurSearchFilterOKBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.PurSearchCancelFilterBtn
        Me.ClientSize = New System.Drawing.Size(447, 87)
        Me.Controls.Add(Me.PurSearchCancelFilterBtn)
        Me.Controls.Add(Me.PurSearchFilterOKBtn)
        Me.Controls.Add(Me.PurSearchFilterTextBox)
        Me.Controls.Add(Me.PurSearchFilterComboBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PurSearchFilterform"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PurSearchCancelFilterBtn As System.Windows.Forms.Button
    Friend WithEvents PurSearchFilterOKBtn As System.Windows.Forms.Button
    Friend WithEvents PurSearchFilterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurSearchFilterComboBox As System.Windows.Forms.ComboBox
End Class
