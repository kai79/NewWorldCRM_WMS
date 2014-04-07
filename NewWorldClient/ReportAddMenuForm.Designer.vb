<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportAddMenuForm
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
        Me.CfgAddMenuCancel = New System.Windows.Forms.Button()
        Me.CfgAddMenuSaveBtn = New System.Windows.Forms.Button()
        Me.ReportAddMenuRemoveBtn = New System.Windows.Forms.Button()
        Me.ReportAddMenuAddBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportAddMenuSelectedListView = New System.Windows.Forms.ListView()
        Me.SelectedList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportAddMenuAvailableListView = New System.Windows.Forms.ListView()
        Me.AvailableList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'CfgAddMenuCancel
        '
        Me.CfgAddMenuCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CfgAddMenuCancel.Location = New System.Drawing.Point(293, 322)
        Me.CfgAddMenuCancel.Name = "CfgAddMenuCancel"
        Me.CfgAddMenuCancel.Size = New System.Drawing.Size(75, 23)
        Me.CfgAddMenuCancel.TabIndex = 23
        Me.CfgAddMenuCancel.Text = "Cancel"
        Me.CfgAddMenuCancel.UseVisualStyleBackColor = True
        '
        'CfgAddMenuSaveBtn
        '
        Me.CfgAddMenuSaveBtn.Location = New System.Drawing.Point(376, 322)
        Me.CfgAddMenuSaveBtn.Name = "CfgAddMenuSaveBtn"
        Me.CfgAddMenuSaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.CfgAddMenuSaveBtn.TabIndex = 22
        Me.CfgAddMenuSaveBtn.Text = "Save"
        Me.CfgAddMenuSaveBtn.UseVisualStyleBackColor = True
        '
        'ReportAddMenuRemoveBtn
        '
        Me.ReportAddMenuRemoveBtn.Location = New System.Drawing.Point(195, 158)
        Me.ReportAddMenuRemoveBtn.Name = "ReportAddMenuRemoveBtn"
        Me.ReportAddMenuRemoveBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReportAddMenuRemoveBtn.TabIndex = 21
        Me.ReportAddMenuRemoveBtn.Text = "Remove"
        Me.ReportAddMenuRemoveBtn.UseVisualStyleBackColor = True
        '
        'ReportAddMenuAddBtn
        '
        Me.ReportAddMenuAddBtn.Location = New System.Drawing.Point(195, 111)
        Me.ReportAddMenuAddBtn.Name = "ReportAddMenuAddBtn"
        Me.ReportAddMenuAddBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReportAddMenuAddBtn.TabIndex = 20
        Me.ReportAddMenuAddBtn.Text = "Add"
        Me.ReportAddMenuAddBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Selected Menu"
        '
        'ReportAddMenuSelectedListView
        '
        Me.ReportAddMenuSelectedListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SelectedList})
        Me.ReportAddMenuSelectedListView.Location = New System.Drawing.Point(293, 23)
        Me.ReportAddMenuSelectedListView.Name = "ReportAddMenuSelectedListView"
        Me.ReportAddMenuSelectedListView.Size = New System.Drawing.Size(158, 283)
        Me.ReportAddMenuSelectedListView.TabIndex = 18
        Me.ReportAddMenuSelectedListView.UseCompatibleStateImageBehavior = False
        Me.ReportAddMenuSelectedListView.View = System.Windows.Forms.View.Details
        '
        'SelectedList
        '
        Me.SelectedList.Text = "Menu Name"
        Me.SelectedList.Width = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Available Menu"
        '
        'ReportAddMenuAvailableListView
        '
        Me.ReportAddMenuAvailableListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AvailableList})
        Me.ReportAddMenuAvailableListView.Location = New System.Drawing.Point(7, 23)
        Me.ReportAddMenuAvailableListView.Name = "ReportAddMenuAvailableListView"
        Me.ReportAddMenuAvailableListView.Size = New System.Drawing.Size(158, 283)
        Me.ReportAddMenuAvailableListView.TabIndex = 16
        Me.ReportAddMenuAvailableListView.UseCompatibleStateImageBehavior = False
        Me.ReportAddMenuAvailableListView.View = System.Windows.Forms.View.Details
        '
        'AvailableList
        '
        Me.AvailableList.Text = "Menu Name"
        Me.AvailableList.Width = 156
        '
        'ReportAddMenuForm
        '
        Me.AcceptButton = Me.CfgAddMenuSaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CfgAddMenuCancel
        Me.ClientSize = New System.Drawing.Size(458, 353)
        Me.Controls.Add(Me.CfgAddMenuCancel)
        Me.Controls.Add(Me.CfgAddMenuSaveBtn)
        Me.Controls.Add(Me.ReportAddMenuRemoveBtn)
        Me.Controls.Add(Me.ReportAddMenuAddBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReportAddMenuSelectedListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportAddMenuAvailableListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportAddMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CfgAddMenuCancel As System.Windows.Forms.Button
    Friend WithEvents CfgAddMenuSaveBtn As System.Windows.Forms.Button
    Friend WithEvents ReportAddMenuRemoveBtn As System.Windows.Forms.Button
    Friend WithEvents ReportAddMenuAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReportAddMenuSelectedListView As System.Windows.Forms.ListView
    Friend WithEvents SelectedList As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportAddMenuAvailableListView As System.Windows.Forms.ListView
    Friend WithEvents AvailableList As System.Windows.Forms.ColumnHeader
End Class
