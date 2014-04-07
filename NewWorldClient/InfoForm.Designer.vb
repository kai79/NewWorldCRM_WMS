<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
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
        Me.InfoCancelBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InfoTotalTextBox = New System.Windows.Forms.TextBox()
        Me.InfoEliteTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InfoVVIPTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InfoVIPTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InfoNormTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InfoCancelBtn
        '
        Me.InfoCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.InfoCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.InfoCancelBtn.Location = New System.Drawing.Point(300, 188)
        Me.InfoCancelBtn.Name = "InfoCancelBtn"
        Me.InfoCancelBtn.Size = New System.Drawing.Size(85, 36)
        Me.InfoCancelBtn.TabIndex = 0
        Me.InfoCancelBtn.Text = "Close"
        Me.InfoCancelBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Member Count: "
        '
        'InfoTotalTextBox
        '
        Me.InfoTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoTotalTextBox.Location = New System.Drawing.Point(192, 32)
        Me.InfoTotalTextBox.Name = "InfoTotalTextBox"
        Me.InfoTotalTextBox.ReadOnly = True
        Me.InfoTotalTextBox.Size = New System.Drawing.Size(167, 21)
        Me.InfoTotalTextBox.TabIndex = 2
        '
        'InfoEliteTextBox
        '
        Me.InfoEliteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoEliteTextBox.Location = New System.Drawing.Point(192, 59)
        Me.InfoEliteTextBox.Name = "InfoEliteTextBox"
        Me.InfoEliteTextBox.ReadOnly = True
        Me.InfoEliteTextBox.Size = New System.Drawing.Size(167, 21)
        Me.InfoEliteTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Elite Member Count: "
        '
        'InfoVVIPTextBox
        '
        Me.InfoVVIPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoVVIPTextBox.Location = New System.Drawing.Point(192, 86)
        Me.InfoVVIPTextBox.Name = "InfoVVIPTextBox"
        Me.InfoVVIPTextBox.ReadOnly = True
        Me.InfoVVIPTextBox.Size = New System.Drawing.Size(167, 21)
        Me.InfoVVIPTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "VVVIP Member Count: "
        '
        'InfoVIPTextBox
        '
        Me.InfoVIPTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoVIPTextBox.Location = New System.Drawing.Point(192, 113)
        Me.InfoVIPTextBox.Name = "InfoVIPTextBox"
        Me.InfoVIPTextBox.ReadOnly = True
        Me.InfoVIPTextBox.Size = New System.Drawing.Size(167, 21)
        Me.InfoVIPTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "VIP Member Count: "
        '
        'InfoNormTextBox
        '
        Me.InfoNormTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoNormTextBox.Location = New System.Drawing.Point(192, 140)
        Me.InfoNormTextBox.Name = "InfoNormTextBox"
        Me.InfoNormTextBox.ReadOnly = True
        Me.InfoNormTextBox.Size = New System.Drawing.Size(167, 21)
        Me.InfoNormTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Normal Member Count: "
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.InfoCancelBtn
        Me.ClientSize = New System.Drawing.Size(397, 239)
        Me.Controls.Add(Me.InfoNormTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InfoVIPTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InfoVVIPTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InfoEliteTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InfoTotalTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InfoCancelBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InfoForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InfoCancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents InfoTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InfoEliteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InfoVVIPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InfoVIPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InfoNormTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
