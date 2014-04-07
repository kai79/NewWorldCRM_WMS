Public Class AddRefForm

    Public NewMemAddRef_Ref As Form

    Private Sub NewMemAddRefForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.MemTbl' table. You can move, or remove it, as needed.
        'Me.MemTblTableAdapter.Fill(Me.NewWorldDBDataSet.MemTbl)

        RefreshContent()

    End Sub

    Private Sub NewMemAddRefDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles NewMemAddRefDataGridView.CellMouseDoubleClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

            Dim i As Integer
            i = NewMemAddRefDataGridView.CurrentRow.Index

            intMemReferrralID = CInt(NewMemAddRefDataGridView.Item(0, i).Value)
            strMemReferral = NewMemAddRefDataGridView.Item(2, i).Value

            CType(NewMemAddRef_Ref, NewMemForm).MemRefTextBox.Text = Trim(strMemReferral)

            Me.Close()

        End If

    End Sub

    Private Sub FilterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FilterToolStripMenuItem.Click

        Dim selectedColumn As Integer = FindColumn()

        If selectedColumn = 0 Then
            FatalError("Please highlight the column you wish to search")
        Else
            Dim AddRefFilterForm As New AddRefFilterForm
            AddRefFilterForm.AddRefFilterRef = Me
            AddRefFilterForm.ShowDialog()
        End If

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click

        RefreshContent()

    End Sub

    Public Function FindColumn() As Integer

        Dim selectedColumnCount As Integer = NewMemAddRefDataGridView.Columns.GetColumnCount(DataGridViewElementStates.Selected)
        Dim tmpCount As Integer

        If selectedColumnCount > 0 Then

            Dim i As Integer
            For i = 0 To selectedColumnCount - 1

                tmpCount = NewMemAddRefDataGridView.SelectedColumns(i).Index

            Next i

        End If

        FindColumn = tmpCount

    End Function

    Public Function ApplyFilter(selectedColumn As Integer, filterWord As String, FilterType As String) As Boolean

        Dim matchFilter As Boolean
        Dim tmpString As String = ""
        Dim currentRow As Integer = 0
        Dim maxColumn As Integer = NewMemAddRefDataGridView.ColumnCount - 1
        Dim maxRow As Integer = NewMemAddRefDataGridView.RowCount - 2
        Dim arrDataSet(0) As String

        For Each row As DataGridViewRow In NewMemAddRefDataGridView.Rows
            If Not row.IsNewRow Then
                matchFilter = False
                For i = 0 To maxColumn

                    If i = selectedColumn Then
                        Select Case (FilterType)
                            Case "Contains"
                                If InStr(Trim(UCase(row.Cells(i).Value.ToString)), UCase(filterWord)) > 0 Then
                                    matchFilter = True
                                End If

                            Case "Does Not Contains"
                                If InStr(Trim(UCase(row.Cells(i).Value.ToString)), UCase(filterWord)) = 0 Then
                                    matchFilter = True
                                End If

                            Case "Start With"
                                If Microsoft.VisualBasic.Left(Trim(UCase(row.Cells(i).Value.ToString)), Len(filterWord)) = UCase(filterWord) Then
                                    matchFilter = True
                                End If

                            Case "End With"
                                If Microsoft.VisualBasic.Right(Trim(UCase(row.Cells(i).Value.ToString)), Len(filterWord)) = UCase(filterWord) Then
                                    matchFilter = True
                                End If

                            Case "Equal"
                                If (Trim(UCase(row.Cells(i).Value.ToString)) = UCase(filterWord)) Then
                                    matchFilter = True
                                End If

                            Case "Does Not equal"
                                If (Trim(UCase(row.Cells(i).Value.ToString)) <> UCase(filterWord)) Then
                                    matchFilter = True
                                End If

                        End Select
                    End If

                Next

                If matchFilter = True Then
                    ReDim Preserve arrDataSet(currentRow)
                    arrDataSet(currentRow) = Trim(row.Cells(0).Value.ToString)
                End If

                currentRow = currentRow + 1
            End If
        Next

        If arrDataSet Is Nothing Then
            MsgBox("Keyword not found")
            ApplyFilter = False
        Else
            Me.NewMemAddRefDataGridView.DataSource = FilterTableData(arrDataSet, "MemTbl")
            ApplyFilter = True
        End If

    End Function

    Public Function FilterTableData(ByVal dataArray() As String, TableName As String) As DataTable

        Dim rowCount As Integer
        Dim DataSet As New DataSet
        DataSet = FillDataSet(TableName, True)

        Dim DataTable As DataTable
        Dim DataTableCopy As DataTable

        DataTable = DataSet.Tables(TableName)
        DataTableCopy = DataTable.Clone

        rowCount = 0
        For Each DR As DataRow In DataSet.Tables(TableName).Rows
            For j = 0 To UBound(dataArray)
                If DR("MemID") = dataArray(j) Then
                    DataTableCopy.ImportRow(DataTable.Rows(rowCount))
                End If
            Next j
            rowCount = rowCount + 1
        Next

        FilterTableData = DataTableCopy

    End Function

    Private Sub RefreshContent()

        Dim ObjConn As New SqlClient.SqlConnection(strConnectionString)
        ObjConn.Open()

        'Create instance of data adapter
        Dim DataAdapter As New SqlClient.SqlDataAdapter("SELECT * FROM MemTbl WHERE MemLock = 0", ObjConn)

        'Create instance of DataSet
        Dim DataSet As New DataSet("MemTbl")
        DataAdapter.FillSchema(DataSet, SchemaType.Source, "MemTbl")
        DataAdapter.Fill(DataSet, "MemTbl")

        Me.NewMemAddRefDataGridView.DataSource = DataSet.Tables("MemTbl")
        Me.NewMemAddRefDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()

    End Sub

    Private Sub AddRefForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub AddRefCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddRefCancelBtn.Click
        Me.Dispose()

    End Sub
End Class