<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportAddProductForm
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
        Me.CfgAddProdCancel = New System.Windows.Forms.Button()
        Me.CfgAddProdSaveBtn = New System.Windows.Forms.Button()
        Me.ReportAddProdRemoveBtn = New System.Windows.Forms.Button()
        Me.ReportAddProdAddBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportAddProdSelectedListView = New System.Windows.Forms.ListView()
        Me.SelectedList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportAddProdAvailableListView = New System.Windows.Forms.ListView()
        Me.AvailableList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'CfgAddProdCancel
        '
        Me.CfgAddProdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CfgAddProdCancel.Location = New System.Drawing.Point(293, 322)
        Me.CfgAddProdCancel.Name = "CfgAddProdCancel"
        Me.CfgAddProdCancel.Size = New System.Drawing.Size(75, 23)
        Me.CfgAddProdCancel.TabIndex = 15
        Me.CfgAddProdCancel.Text = "Cancel"
        Me.CfgAddProdCancel.UseVisualStyleBackColor = True
        '
        'CfgAddProdSaveBtn
        '
        Me.CfgAddProdSaveBtn.Location = New System.Drawing.Point(376, 322)
        Me.CfgAddProdSaveBtn.Name = "CfgAddProdSaveBtn"
        Me.CfgAddProdSaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.CfgAddProdSaveBtn.TabIndex = 14
        Me.CfgAddProdSaveBtn.Text = "Save"
        Me.CfgAddProdSaveBtn.UseVisualStyleBackColor = True
        '
        'ReportAddProdRemoveBtn
        '
        Me.ReportAddProdRemoveBtn.Location = New System.Drawing.Point(195, 158)
        Me.ReportAddProdRemoveBtn.Name = "ReportAddProdRemoveBtn"
        Me.ReportAddProdRemoveBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReportAddProdRemoveBtn.TabIndex = 13
        Me.ReportAddProdRemoveBtn.Text = "Remove"
        Me.ReportAddProdRemoveBtn.UseVisualStyleBackColor = True
        '
        'ReportAddProdAddBtn
        '
        Me.ReportAddProdAddBtn.Location = New System.Drawing.Point(195, 111)
        Me.ReportAddProdAddBtn.Name = "ReportAddProdAddBtn"
        Me.ReportAddProdAddBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReportAddProdAddBtn.TabIndex = 12
        Me.ReportAddProdAddBtn.Text = "Add"
        Me.ReportAddProdAddBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Selected Product"
        '
        'ReportAddProdSelectedListView
        '
        Me.ReportAddProdSelectedListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SelectedList})
        Me.ReportAddProdSelectedListView.Location = New System.Drawing.Point(293, 23)
        Me.ReportAddProdSelectedListView.Name = "ReportAddProdSelectedListView"
        Me.ReportAddProdSelectedListView.Size = New System.Drawing.Size(158, 283)
        Me.ReportAddProdSelectedListView.TabIndex = 10
        Me.ReportAddProdSelectedListView.UseCompatibleStateImageBehavior = False
        Me.ReportAddProdSelectedListView.View = System.Windows.Forms.View.Details
        '
        'SelectedList
        '
        Me.SelectedList.Text = "Product Name"
        Me.SelectedList.Width = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Available Product"
        '
        'ReportAddProdAvailableListView
        '
        Me.ReportAddProdAvailableListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AvailableList})
        Me.ReportAddProdAvailableListView.Location = New System.Drawing.Point(7, 23)
        Me.ReportAddProdAvailableListView.Name = "ReportAddProdAvailableListView"
        Me.ReportAddProdAvailableListView.Size = New System.Drawing.Size(158, 283)
        Me.ReportAddProdAvailableListView.TabIndex = 8
        Me.ReportAddProdAvailableListView.UseCompatibleStateImageBehavior = False
        Me.ReportAddProdAvailableListView.View = System.Windows.Forms.View.Details
        '
        'AvailableList
        '
        Me.AvailableList.Text = "Product Name"
        Me.AvailableList.Width = 156
        '
        'ReportAddProductForm
        '
        Me.AcceptButton = Me.CfgAddProdSaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CfgAddProdCancel
        Me.ClientSize = New System.Drawing.Size(458, 353)
        Me.Controls.Add(Me.CfgAddProdCancel)
        Me.Controls.Add(Me.CfgAddProdSaveBtn)
        Me.Controls.Add(Me.ReportAddProdRemoveBtn)
        Me.Controls.Add(Me.ReportAddProdAddBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReportAddProdSelectedListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportAddProdAvailableListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportAddProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CfgAddProdCancel As System.Windows.Forms.Button
    Friend WithEvents CfgAddProdSaveBtn As System.Windows.Forms.Button
    Friend WithEvents ReportAddProdRemoveBtn As System.Windows.Forms.Button
    Friend WithEvents ReportAddProdAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReportAddProdSelectedListView As System.Windows.Forms.ListView
    Friend WithEvents SelectedList As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReportAddProdAvailableListView As System.Windows.Forms.ListView
    Friend WithEvents AvailableList As System.Windows.Forms.ColumnHeader
End Class
