<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginSetPassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetPwTxtBox = New System.Windows.Forms.TextBox()
        Me.ReSetPwTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SetPWSaveButton = New System.Windows.Forms.Button()
        Me.SetPWCancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Password:"
        '
        'SetPwTxtBox
        '
        Me.SetPwTxtBox.Location = New System.Drawing.Point(123, 19)
        Me.SetPwTxtBox.Name = "SetPwTxtBox"
        Me.SetPwTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SetPwTxtBox.Size = New System.Drawing.Size(137, 20)
        Me.SetPwTxtBox.TabIndex = 1
        '
        'ReSetPwTxtBox
        '
        Me.ReSetPwTxtBox.Location = New System.Drawing.Point(123, 45)
        Me.ReSetPwTxtBox.Name = "ReSetPwTxtBox"
        Me.ReSetPwTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ReSetPwTxtBox.Size = New System.Drawing.Size(137, 20)
        Me.ReSetPwTxtBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Re-enter Password:"
        '
        'SetPWSaveButton
        '
        Me.SetPWSaveButton.Location = New System.Drawing.Point(68, 87)
        Me.SetPWSaveButton.Name = "SetPWSaveButton"
        Me.SetPWSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SetPWSaveButton.TabIndex = 4
        Me.SetPWSaveButton.Text = "Save"
        Me.SetPWSaveButton.UseVisualStyleBackColor = True
        '
        'SetPWCancelButton
        '
        Me.SetPWCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SetPWCancelButton.Location = New System.Drawing.Point(149, 87)
        Me.SetPWCancelButton.Name = "SetPWCancelButton"
        Me.SetPWCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.SetPWCancelButton.TabIndex = 5
        Me.SetPWCancelButton.Text = "Cancel"
        Me.SetPWCancelButton.UseVisualStyleBackColor = True
        '
        'LoginSetPassword
        '
        Me.AcceptButton = Me.SetPWSaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.SetPWCancelButton
        Me.ClientSize = New System.Drawing.Size(283, 122)
        Me.Controls.Add(Me.SetPWCancelButton)
        Me.Controls.Add(Me.SetPWSaveButton)
        Me.Controls.Add(Me.ReSetPwTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SetPwTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginSetPassword"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SetPwTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ReSetPwTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SetPWSaveButton As System.Windows.Forms.Button
    Friend WithEvents SetPWCancelButton As System.Windows.Forms.Button
End Class
