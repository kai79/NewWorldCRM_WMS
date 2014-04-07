<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminNewUser
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
        Me.UserNameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.PwTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RePwTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login ID:"
        '
        'UserNameTxtBox
        '
        Me.UserNameTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.UserNameTxtBox.Location = New System.Drawing.Point(124, 17)
        Me.UserNameTxtBox.MaxLength = 10
        Me.UserNameTxtBox.Name = "UserNameTxtBox"
        Me.UserNameTxtBox.Size = New System.Drawing.Size(127, 20)
        Me.UserNameTxtBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Login ID must be no more than 8 characters"
        '
        'CreateBtn
        '
        Me.CreateBtn.Location = New System.Drawing.Point(158, 187)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(75, 23)
        Me.CreateBtn.TabIndex = 5
        Me.CreateBtn.Text = "Create"
        Me.CreateBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Location = New System.Drawing.Point(77, 187)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User Type:"
        '
        'UserTypeComboBox
        '
        Me.UserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserTypeComboBox.FormattingEnabled = True
        Me.UserTypeComboBox.Items.AddRange(New Object() {"Admin", "CRM_User", "WH_User", "WH_Superuser"})
        Me.UserTypeComboBox.Location = New System.Drawing.Point(124, 149)
        Me.UserTypeComboBox.Name = "UserTypeComboBox"
        Me.UserTypeComboBox.Size = New System.Drawing.Size(127, 21)
        Me.UserTypeComboBox.TabIndex = 4
        '
        'PwTxtBox
        '
        Me.PwTxtBox.Location = New System.Drawing.Point(124, 82)
        Me.PwTxtBox.Name = "PwTxtBox"
        Me.PwTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PwTxtBox.Size = New System.Drawing.Size(127, 20)
        Me.PwTxtBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password:"
        '
        'RePwTxtBox
        '
        Me.RePwTxtBox.Location = New System.Drawing.Point(124, 108)
        Me.RePwTxtBox.Name = "RePwTxtBox"
        Me.RePwTxtBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RePwTxtBox.Size = New System.Drawing.Size(127, 20)
        Me.RePwTxtBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ReType Password:"
        '
        'AdminNewUser
        '
        Me.AcceptButton = Me.CreateBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(298, 230)
        Me.Controls.Add(Me.RePwTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PwTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UserTypeComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserNameTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminNewUser"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserNameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CreateBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UserTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PwTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RePwTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
