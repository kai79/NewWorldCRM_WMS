<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.ReportMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveQueryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.ReportPrintDialog = New System.Windows.Forms.PrintDialog()
        Me.ReportSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ReportFormCancelBtn = New System.Windows.Forms.Button()
        Me.ReportStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ReportToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ReportMenuStrip.SuspendLayout()
        CType(Me.ReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReportStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportMenuStrip
        '
        Me.ReportMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.ReportMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.ReportMenuStrip.Name = "ReportMenuStrip"
        Me.ReportMenuStrip.Size = New System.Drawing.Size(964, 24)
        Me.ReportMenuStrip.TabIndex = 0
        Me.ReportMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ExportToolStripMenuItem, Me.SaveQueryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'SaveQueryToolStripMenuItem
        '
        Me.SaveQueryToolStripMenuItem.Name = "SaveQueryToolStripMenuItem"
        Me.SaveQueryToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SaveQueryToolStripMenuItem.Text = "Save Query"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReportDataGridView
        '
        Me.ReportDataGridView.AllowUserToAddRows = False
        Me.ReportDataGridView.AllowUserToDeleteRows = False
        Me.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.ReportDataGridView.Name = "ReportDataGridView"
        Me.ReportDataGridView.ReadOnly = True
        Me.ReportDataGridView.Size = New System.Drawing.Size(964, 554)
        Me.ReportDataGridView.TabIndex = 2
        '
        'ReportPrintDialog
        '
        Me.ReportPrintDialog.UseEXDialog = True
        '
        'ReportSaveFileDialog
        '
        Me.ReportSaveFileDialog.Filter = "Excel 97-2003 Worksheet(*.xls)|*.xls|Excel Worksheet(*.xlsx)|*.xlsx|All files(*.*" & _
    ")|*.*"
        '
        'ReportFormCancelBtn
        '
        Me.ReportFormCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ReportFormCancelBtn.Location = New System.Drawing.Point(865, 543)
        Me.ReportFormCancelBtn.Name = "ReportFormCancelBtn"
        Me.ReportFormCancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.ReportFormCancelBtn.TabIndex = 3
        Me.ReportFormCancelBtn.Text = "Cancel"
        Me.ReportFormCancelBtn.UseVisualStyleBackColor = True
        '
        'ReportStatusStrip
        '
        Me.ReportStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportToolStripStatusLabel})
        Me.ReportStatusStrip.Location = New System.Drawing.Point(0, 556)
        Me.ReportStatusStrip.Name = "ReportStatusStrip"
        Me.ReportStatusStrip.Size = New System.Drawing.Size(964, 22)
        Me.ReportStatusStrip.TabIndex = 4
        Me.ReportStatusStrip.Text = "test test test"
        '
        'ReportToolStripStatusLabel
        '
        Me.ReportToolStripStatusLabel.Name = "ReportToolStripStatusLabel"
        Me.ReportToolStripStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ReportFormCancelBtn
        Me.ClientSize = New System.Drawing.Size(964, 578)
        Me.Controls.Add(Me.ReportStatusStrip)
        Me.Controls.Add(Me.ReportDataGridView)
        Me.Controls.Add(Me.ReportFormCancelBtn)
        Me.Controls.Add(Me.ReportMenuStrip)
        Me.MainMenuStrip = Me.ReportMenuStrip
        Me.Name = "ReportForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Viewer"
        Me.ReportMenuStrip.ResumeLayout(False)
        Me.ReportMenuStrip.PerformLayout()
        CType(Me.ReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReportStatusStrip.ResumeLayout(False)
        Me.ReportStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReportPrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents ReportSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveQueryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportFormCancelBtn As System.Windows.Forms.Button
    Friend WithEvents ReportStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ReportToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
End Class
