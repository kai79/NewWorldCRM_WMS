<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WhSumQuery
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
        Me.WhSumCancelBtn = New System.Windows.Forms.Button()
        Me.WhSumSearchBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WhSumQryMoComboBox = New System.Windows.Forms.ComboBox()
        Me.WhSumQryYrComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WhSumCancelBtn
        '
        Me.WhSumCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhSumCancelBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Close_icon
        Me.WhSumCancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhSumCancelBtn.Location = New System.Drawing.Point(184, 12)
        Me.WhSumCancelBtn.Name = "WhSumCancelBtn"
        Me.WhSumCancelBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhSumCancelBtn.TabIndex = 23
        Me.WhSumCancelBtn.Text = "Cancel"
        Me.WhSumCancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhSumCancelBtn.UseVisualStyleBackColor = True
        '
        'WhSumSearchBtn
        '
        Me.WhSumSearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhSumSearchBtn.Image = Global.WindowsApplication1.My.Resources.Resources.Document_search_icon
        Me.WhSumSearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.WhSumSearchBtn.Location = New System.Drawing.Point(24, 12)
        Me.WhSumSearchBtn.Name = "WhSumSearchBtn"
        Me.WhSumSearchBtn.Size = New System.Drawing.Size(150, 50)
        Me.WhSumSearchBtn.TabIndex = 22
        Me.WhSumSearchBtn.Text = "Search"
        Me.WhSumSearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.WhSumSearchBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.WhSumQryYrComboBox)
        Me.GroupBox1.Controls.Add(Me.WhSumQryMoComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 90)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Filter"
        '
        'WhSumQryMoComboBox
        '
        Me.WhSumQryMoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhSumQryMoComboBox.FormattingEnabled = True
        Me.WhSumQryMoComboBox.Items.AddRange(New Object() {"一月 January ", "二月 February", "三月 March", "四月 April", "五月 May", "六月 June", "七月 July", "八月 August", "九月 September", "十月 October", "十一月 November", "十二月 December"})
        Me.WhSumQryMoComboBox.Location = New System.Drawing.Point(113, 33)
        Me.WhSumQryMoComboBox.Name = "WhSumQryMoComboBox"
        Me.WhSumQryMoComboBox.Size = New System.Drawing.Size(167, 28)
        Me.WhSumQryMoComboBox.TabIndex = 0
        '
        'WhSumQryYrComboBox
        '
        Me.WhSumQryYrComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhSumQryYrComboBox.FormattingEnabled = True
        Me.WhSumQryYrComboBox.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027"})
        Me.WhSumQryYrComboBox.Location = New System.Drawing.Point(306, 33)
        Me.WhSumQryYrComboBox.Name = "WhSumQryYrComboBox"
        Me.WhSumQryYrComboBox.Size = New System.Drawing.Size(121, 28)
        Me.WhSumQryYrComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "-"
        '
        'WhSumQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 184)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WhSumCancelBtn)
        Me.Controls.Add(Me.WhSumSearchBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WhSumQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Query"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WhSumCancelBtn As System.Windows.Forms.Button
    Friend WithEvents WhSumSearchBtn As System.Windows.Forms.Button
    Friend WithEvents WhSumQryYrComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WhSumQryMoComboBox As System.Windows.Forms.ComboBox
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
