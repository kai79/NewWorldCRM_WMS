<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewMenuAddProdForm
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
        Me.AvailableListView = New System.Windows.Forms.ListView()
        Me.AvailableList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelectedListView = New System.Windows.Forms.ListView()
        Me.SelectedList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NewMenuAddProdAddBtn = New System.Windows.Forms.Button()
        Me.NewMenuAddProdRemoveBtn = New System.Windows.Forms.Button()
        Me.NewMenuAddProdSaveBtn = New System.Windows.Forms.Button()
        Me.NewMenuAddProdCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AvailableListView
        '
        Me.AvailableListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.AvailableList})
        Me.AvailableListView.Location = New System.Drawing.Point(12, 29)
        Me.AvailableListView.Name = "AvailableListView"
        Me.AvailableListView.Size = New System.Drawing.Size(158, 283)
        Me.AvailableListView.TabIndex = 0
        Me.AvailableListView.UseCompatibleStateImageBehavior = False
        Me.AvailableListView.View = System.Windows.Forms.View.Details
        '
        'AvailableList
        '
        Me.AvailableList.Text = "Product Name"
        Me.AvailableList.Width = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Available Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Selected Product"
        '
        'SelectedListView
        '
        Me.SelectedListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SelectedList})
        Me.SelectedListView.Location = New System.Drawing.Point(298, 29)
        Me.SelectedListView.Name = "SelectedListView"
        Me.SelectedListView.Size = New System.Drawing.Size(158, 283)
        Me.SelectedListView.TabIndex = 2
        Me.SelectedListView.UseCompatibleStateImageBehavior = False
        Me.SelectedListView.View = System.Windows.Forms.View.Details
        '
        'SelectedList
        '
        Me.SelectedList.Text = "Product Name"
        Me.SelectedList.Width = 156
        '
        'NewMenuAddProdAddBtn
        '
        Me.NewMenuAddProdAddBtn.Location = New System.Drawing.Point(200, 117)
        Me.NewMenuAddProdAddBtn.Name = "NewMenuAddProdAddBtn"
        Me.NewMenuAddProdAddBtn.Size = New System.Drawing.Size(75, 23)
        Me.NewMenuAddProdAddBtn.TabIndex = 4
        Me.NewMenuAddProdAddBtn.Text = "Add"
        Me.NewMenuAddProdAddBtn.UseVisualStyleBackColor = True
        '
        'NewMenuAddProdRemoveBtn
        '
        Me.NewMenuAddProdRemoveBtn.Location = New System.Drawing.Point(200, 164)
        Me.NewMenuAddProdRemoveBtn.Name = "NewMenuAddProdRemoveBtn"
        Me.NewMenuAddProdRemoveBtn.Size = New System.Drawing.Size(75, 23)
        Me.NewMenuAddProdRemoveBtn.TabIndex = 5
        Me.NewMenuAddProdRemoveBtn.Text = "Remove"
        Me.NewMenuAddProdRemoveBtn.UseVisualStyleBackColor = True
        '
        'NewMenuAddProdSaveBtn
        '
        Me.NewMenuAddProdSaveBtn.Location = New System.Drawing.Point(381, 328)
        Me.NewMenuAddProdSaveBtn.Name = "NewMenuAddProdSaveBtn"
        Me.NewMenuAddProdSaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.NewMenuAddProdSaveBtn.TabIndex = 6
        Me.NewMenuAddProdSaveBtn.Text = "Save"
        Me.NewMenuAddProdSaveBtn.UseVisualStyleBackColor = True
        '
        'NewMenuAddProdCancel
        '
        Me.NewMenuAddProdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NewMenuAddProdCancel.Location = New System.Drawing.Point(298, 328)
        Me.NewMenuAddProdCancel.Name = "NewMenuAddProdCancel"
        Me.NewMenuAddProdCancel.Size = New System.Drawing.Size(75, 23)
        Me.NewMenuAddProdCancel.TabIndex = 7
        Me.NewMenuAddProdCancel.Text = "Cancel"
        Me.NewMenuAddProdCancel.UseVisualStyleBackColor = True
        '
        'NewMenuAddProdForm
        '
        Me.AcceptButton = Me.NewMenuAddProdSaveBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NewMenuAddProdCancel
        Me.ClientSize = New System.Drawing.Size(468, 363)
        Me.Controls.Add(Me.NewMenuAddProdCancel)
        Me.Controls.Add(Me.NewMenuAddProdSaveBtn)
        Me.Controls.Add(Me.NewMenuAddProdRemoveBtn)
        Me.Controls.Add(Me.NewMenuAddProdAddBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SelectedListView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AvailableListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewMenuAddProdForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AvailableListView As System.Windows.Forms.ListView
    Friend WithEvents AvailableList As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelectedListView As System.Windows.Forms.ListView
    Friend WithEvents SelectedList As System.Windows.Forms.ColumnHeader
    Friend WithEvents NewMenuAddProdAddBtn As System.Windows.Forms.Button
    Friend WithEvents NewMenuAddProdRemoveBtn As System.Windows.Forms.Button
    Friend WithEvents NewMenuAddProdSaveBtn As System.Windows.Forms.Button
    Friend WithEvents NewMenuAddProdCancel As System.Windows.Forms.Button
End Class
