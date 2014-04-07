Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms.SaveFileDialog

Public Class ReportForm

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Me.ReportPrintDialog.ShowDialog()

    End Sub

    Private Sub SaveQueryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveQueryToolStripMenuItem.Click

        Dim saveViewDialog As New SaveFileDialog
        saveViewDialog.Filter = "SQL (*.sql)|*.sql|ALL Files (*.*)|*.*"
        saveViewDialog.Title = "Save File"
        saveViewDialog.ShowDialog(Me)
        Try
            Dim StreamWriter As New IO.StreamWriter(saveViewDialog.FileName)
            StreamWriter.Write(sqlQuery)
            StreamWriter.Flush()
            StreamWriter.Close()

            sqlQuery = Nothing

        Catch ex As Exception
            FatalError("Error saving Report View")
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()

    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Me.ReportSaveFileDialog.ShowDialog()

    End Sub

    Private Sub ReportSaveFileDialog_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportSaveFileDialog.FileOk
        ExportExcel(ReportSaveFileDialog.FileName.ToString())

    End Sub

    Private Sub ExportExcel(SaveName As String)

        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        For Each Cols As DataGridViewColumn In Me.ReportDataGridView.Columns
            xlWorkSheet.Cells.Columns.CurrentRegion.Columns(Cols.Index + 1) = Cols.HeaderText
        Next

        For i = 0 To ReportDataGridView.RowCount - 1
            For j = 0 To ReportDataGridView.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1) = Trim(ReportDataGridView(j, i).Value.ToString())
            Next
        Next

        xlWorkSheet.SaveAs(SaveName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ReportFormCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles ReportFormCancelBtn.Click
        Me.Dispose()

    End Sub
End Class