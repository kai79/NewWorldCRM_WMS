Public Class MemSearchForm

    Private Sub MemSearchForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'NewWorldDBDataSet.MemTbl' table. You can move, or remove it, as needed.
        'Me.MemTblTableAdapter.Fill(Me.NewWorldDBDataSet.MemTbl)

        boolMemSearchOpen = True
        Me.RefreshContent()

    End Sub

    Private Sub MemSearchDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MemSearchDataGridView.CellMouseDoubleClick
        Me.OpenContent()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenContent()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.DeleteContent()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.ExitContent()
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem1.Click
        Me.OpenContent()

    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Me.DeleteContent()

    End Sub

    Private Sub FilterToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FilterToolStripMenuItem1.Click
        FilterContent()

    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        RefreshContent()

    End Sub

    Private Sub FilterToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles FilterToolStripMenuItem2.Click
        FilterContent()

    End Sub

    Private Sub RefreshToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem2.Click
        RefreshContent()

    End Sub

    Private Sub NewSearchForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ExitContent()

    End Sub

    Private Sub OpenContent()

        If boolMemNew = True Then
            Warning("Please cancel or save current record before proceed")
        Else
            If boolMemEdit = True Then
                Warning("Please close existing record before continue")
            Else
                Dim NewMemForm As New NewMemForm
                NewMemForm.MdiParent = Me.MdiParent

                Dim i As Integer
                i = MemSearchDataGridView.CurrentRow.Index

                'If boolMemRefresh = True Then
                'Me.RefreshContent()
                'boolMemRefresh = False
                'End If

                intMemID = Trim(Me.MemSearchDataGridView.Item(0, i).Value)
                strMemName = Trim(Me.MemSearchDataGridView(1, i).Value)
                strMemNRIC = Trim(Me.MemSearchDataGridView(2, i).Value)
                strMemAddress = Trim(Me.MemSearchDataGridView(3, i).Value)
                strMemZone = Trim(Me.MemSearchDataGridView(4, i).Value)
                strMemContactHome = Trim(Me.MemSearchDataGridView(5, i).Value)
                strMemContactMobile = Trim(Me.MemSearchDataGridView(6, i).Value)
                strMemEmail = Trim(Me.MemSearchDataGridView(7, i).Value)
                strMemRank = Trim(Me.MemSearchDataGridView(8, i).Value)
                strMemReferral = Trim(Me.MemSearchDataGridView(9, i).Value)
                intMemReferrralID = Trim(Me.MemSearchDataGridView(10, i).Value)
                DatMemDateJoin = Trim(Me.MemSearchDataGridView(11, i).Value)
                intMemCredit = Trim(Me.MemSearchDataGridView(12, i).Value)
                boolMemLock = Me.MemSearchDataGridView(13, i).Value
                strMemLockUser = Me.MemSearchDataGridView(14, i).Value.ToString

                strOpenMemNRIC = strMemNRIC

                Try
                    Dim DataSet As DataSet
                    DataSet = FillDataSet("MemTbl", False)
                    'Me.MemSearchDataGridView.DataSource = DataSet.Tables("MemTbl")

                    'Existing Records
                    Dim DataRow As DataRow
                    DataRow = DataSet.Tables("MemTbl").Rows.Find(intMemID)

                    If boolMemLock = True And strMemLockUser <> strGlobalLogin Then
                        FatalError("Record is currently locked by user:" & strMemLockUser)
                        NewMemForm.Dispose()
                    Else
                        DataRow.BeginEdit()
                        DataRow("MemLock") = True
                        DataRow("MemLockUser") = strGlobalLogin
                        DataRow.EndEdit()

                        SaveDataSet(DataSet, "MemTbl")
                        'RefreshContent()

                        boolMemEdit = True

                        NewMemForm.MemIDTextBox.Text = CStr(intMemID)
                        NewMemForm.MemNameTextBox.Text = strMemName
                        NewMemForm.MemAddressTextBox.Text = strMemAddress
                        NewMemForm.MemNRICTextBox.Text = strMemNRIC
                        NewMemForm.MemZoneComboBox.Text = strMemZone
                        NewMemForm.MemCtcHomeTextBox.Text = strMemContactHome
                        NewMemForm.MemCtcMobTextBox.Text = strMemContactMobile

                        NewMemForm.MemEmailTextBox.Text = strMemEmail
                        NewMemForm.MemRankComboBox.Text = strMemRank
                        NewMemForm.MemRefTextBox.Text = strMemReferral

                        NewMemForm.MemJoinDatePicker.Text = DatMemDateJoin
                        NewMemForm.MemCreditNumericUpDown.Value = intMemCredit

                        NewMemForm.PurchaseHistoryDataGridView.DataSource = GetTableData(intMemID, "PurMemID", "PurTbl")
                        NewMemForm.ClassHistoryDataGridView.DataSource = GetTableData(intMemID, "ClsMemId", "ClsTbl")

                        'NewMemForm.MemNameTextBox.Enabled = False
                        NewMemForm.NewMemClrBtn.Enabled = False
                        'NewMemForm.MemNRICTextBox.Enabled = False
                        NewMemForm.MemJoinDatePicker.Enabled = False
                        'NewMemForm.NewMemAddRefBtn.Enabled = False

                        NewMemForm.Show()

                        intMemID = Nothing
                        strMemName = Nothing
                        strMemNRIC = Nothing
                        strMemAddress = Nothing
                        strMemZone = Nothing
                        strMemContactHome = Nothing
                        strMemContactMobile = Nothing
                        strMemEmail = Nothing
                        strMemRank = Nothing
                        strMemReferral = Nothing
                        intMemReferrralID = Nothing
                        DatMemDateJoin = Nothing
                        intMemCredit = Nothing
                        boolMemLock = Nothing
                        strMemLockUser = Nothing

                        'Me.Dispose()
                    End If

                Catch ex As Exception
                    FatalError("Error opening record")
                End Try
            End If

        End If

    End Sub

    Private Sub RefreshContent()

        boolMemFilter = False
        MemSelectedColumn = Nothing
        MemFilterWord = Nothing
        MemFilterType = Nothing

        Dim DataSet As DataSet
        DataSet = FillDataSet("MemTbl", False)

        Me.MemSearchDataGridView.DataSource = DataSet.Tables("MemTbl")
        Me.MemSearchDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub FilterContent()

        Dim selectedColumn As Integer = FindColumn()

        'If selectedColumn = 0 Then
        'FatalError("Please highlight the column you wish to search")
        'Else
        Dim MemSearchFilterForm As New MemSearchFilterForm
        MemSearchFilterForm.MemSearchFilterRef = Me
        MemSearchFilterForm.ShowDialog()
        'End If

    End Sub

    Private Sub ExitContent()

        NewMemSearchForm = Nothing
        boolMemSearchOpen = False
        Me.Hide()

    End Sub

    Private Sub DeleteContent()

        Dim i As Integer
        i = Me.MemSearchDataGridView.CurrentRow.Index
        intMemID = Trim(Me.MemSearchDataGridView.Item(0, i).Value)
        strMemName = Trim(Me.MemSearchDataGridView.Item(1, i).Value)
        boolMemLock = Me.MemSearchDataGridView.Item(13, i).Value
        strMemLockUser = Me.MemSearchDataGridView.Item(14, i).Value.ToString

        If boolMemLock = True Then
            FatalError("Record cannot be deleted as it is currently open by: " & strMemLockUser)
        Else
            Dim DataSet As DataSet
            DataSet = FillDataSet("MemTbl", True)

            Dim DataRow As DataRow
            DataRow = DataSet.Tables("MemTbl").Rows.Find(intMemID)
            If Question("Member Name: " & strMemName & " will be deleted. Are you sure?") = True Then
                DataRow.Delete()
                SaveDataSet(DataSet, "MemTbl")

                'Delete purchase history
                DataSet = FillDataSet("PurTbl", True)
                For Each DataRow In DataSet.Tables("PurTbl").Rows
                    If DataRow("PurMemID") = intMemID Then
                        DataRow.Delete()
                    End If
                Next
                SaveDataSet(DataSet, "PurTbl")

                'Delete class history
                DataSet = FillDataSet("ClsTbl", True)
                For Each DataRow In DataSet.Tables("ClsTbl").Rows
                    If DataRow("ClsMemID") = intMemID Then
                        DataRow.Delete()
                    End If
                Next
                SaveDataSet(DataSet, "ClsTbl")

                Confirmation("Record Deleted")
                RefreshContent()

                If boolMemFilter = True Then
                    ApplyFilter(MemSelectedColumn, MemFilterWord, MemFilterType)
                End If

            End If
        End If

    End Sub

    Public Function FindColumn() As Integer

        Dim selectedColumnCount As Integer = MemSearchDataGridView.Columns.GetColumnCount(DataGridViewElementStates.Selected)
        Dim tmpCount As Integer

        If selectedColumnCount > 0 Then

            Dim i As Integer
            For i = 0 To selectedColumnCount - 1

                tmpCount = MemSearchDataGridView.SelectedColumns(i).Index

            Next i

        End If

        FindColumn = tmpCount

    End Function

    Public Function ApplyFilter(selectedColumn As Integer, filterWord As String, FilterType As String) As Boolean

        Dim matchFilter As Boolean
        Dim tmpString As String = ""
        Dim currentRow As Integer = 0
        'Dim maxColumn As Integer = MemSearchDataGridView.ColumnCount - 1
        Dim maxColumn As Integer = 0
        For Each col As DataGridViewColumn In MemSearchDataGridView.Columns
            If col.Visible = True Then
                maxColumn += 1
            End If
        Next

        Dim maxRow As Integer = MemSearchDataGridView.RowCount - 2
        Dim arrDataSet(0) As String

        For Each row As DataGridViewRow In MemSearchDataGridView.Rows
            If Not row.IsNewRow Then
                matchFilter = False
                For i = 0 To maxColumn - 1

                    'If i = selectedColumn Then
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
                    'End If

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
            Me.MemSearchDataGridView.DataSource = FilterTableData(arrDataSet, "MemTbl")
            ApplyFilter = True
            boolMemFilter = True
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

    Private Sub MemSearchCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles MemSearchCancelBtn.Click
        ExitContent()

    End Sub

    Private Sub StatisticToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StatisticToolStripMenuItem.Click

        Dim NewInfoForm As New InfoForm
        NewInfoForm.ShowDialog()

    End Sub
End Class