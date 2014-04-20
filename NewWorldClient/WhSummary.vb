Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Windows.Forms.SaveFileDialog

Public Class WhSummary

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ReportSaveFileDialog.FileName = strQueryDate
        Me.ReportSaveFileDialog.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        strQueryDate = Nothing
        Me.Dispose()

    End Sub

    Private Sub WhSummary_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        strQueryDate = Nothing
        Me.Dispose()

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

        For Each Cols As DataGridViewColumn In Me.WhSumDataGridView.Columns
            xlWorkSheet.Cells.Columns.CurrentRegion.Columns(Cols.Index + 1) = Cols.HeaderText
        Next

        For i = 0 To WhSumDataGridView.RowCount - 1
            For j = 0 To WhSumDataGridView.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1) = Trim(WhSumDataGridView(j, i).Value.ToString())
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

End Class