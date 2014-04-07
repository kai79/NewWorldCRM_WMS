Public Class MemPurchaseForm

    Private Sub MemPurchaseForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.PurTbl' table. You can move, or remove it, as needed.
        'Me.PurTblTableAdapter.Fill(Me.NewWorldDBDataSet.PurTbl)

        boolPurSearchOpen = True
        Me.RefreshContent()

    End Sub

    Private Sub RefreshContent()

        Dim DataSet As DataSet
        DataSet = FillDataSet("PurTbl", False)

        Me.PurSearchDataGridView.DataSource = DataSet.Tables("PurTbl")
        Me.PurSearchDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenContent()

    End Sub

    Private Sub PurSearchDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PurSearchDataGridView.CellMouseDoubleClick
        Me.OpenContent()

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
                i = PurSearchDataGridView.CurrentRow.Index

                Dim DataSet As DataSet
                'DataSet = FillDataSet("PurTbl", False)
                'Me.PurSearchDataGridView.DataSource = DataSet.Tables("PurTbl")

                intPurMemID = Trim(Me.PurSearchDataGridView.Item(1, i).Value)

                Dim DataRow As DataRow
                Dim DataRowCount As Integer = 0

                DataSet = FillDataSet("MemTbl", False)
                For Each DataRow In DataSet.Tables("MemTbl").Rows
                    If DataRow("MemID") = intPurMemID Then
                        intMemID = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemID")
                        strMemName = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemName")
                        strMemNRIC = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemNRIC")
                        strMemAddress = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemAddress")
                        strMemZone = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemZone")
                        strMemContactHome = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemCtcHome")
                        strMemContactMobile = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemCtcMob")
                        strMemEmail = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemEmail")
                        strMemRank = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemRank")
                        strMemReferral = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemRef")
                        intMemReferrralID = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemRefID")
                        DatMemDateJoin = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemDateJoin")
                        intMemCredit = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemCredit")
                        'boolMemLock = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemLock")
                        'strMemLockUser = DataSet.Tables("MemTbl").Rows.Item(DataRowCount).Item("MemLockUser")
                        Exit For
                    End If
                    DataRowCount = DataRowCount + 1
                Next

                'Existing Records
                DataRow = DataSet.Tables("MemTbl").Rows.Find(Trim(intMemID))

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

                    NewMemForm.MemIDTextBox.Text = Trim(CStr(intMemID))
                    NewMemForm.MemNameTextBox.Text = Trim(strMemName)
                    NewMemForm.MemAddressTextBox.Text = Trim(strMemAddress)
                    NewMemForm.MemNRICTextBox.Text = Trim(strMemNRIC)
                    NewMemForm.MemZoneComboBox.Text = Trim(strMemZone)
                    NewMemForm.MemCtcHomeTextBox.Text = Trim(strMemContactHome)
                    NewMemForm.MemCtcMobTextBox.Text = Trim(strMemContactMobile)

                    NewMemForm.MemEmailTextBox.Text = Trim(strMemEmail)
                    NewMemForm.MemRankComboBox.Text = Trim(strMemRank)
                    NewMemForm.MemRefTextBox.Text = Trim(strMemReferral)

                    NewMemForm.MemJoinDatePicker.Text = Trim(DatMemDateJoin)
                    NewMemForm.MemCreditNumericUpDown.Value = Trim(intMemCredit)

                    NewMemForm.PurchaseHistoryDataGridView.DataSource = GetTableData(intMemID, "PurMemID", "PurTbl")
                    NewMemForm.ClassHistoryDataGridView.DataSource = GetTableData(intMemID, "ClsMemId", "ClsTbl")

                    NewMemForm.MemNameTextBox.Enabled = False
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

            End If
        End If

    End Sub

    Private Sub FilterToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FilterToolStripMenuItem.Click

        Me.FilterContent()

    End Sub

    Private Sub FilterContent()

        Dim selectedColumn As Integer = FindColumn()

        If selectedColumn = 0 Then
            FatalError("Please highlight the column you wish to search")
        Else
            Dim PurSearchFilterForm As New PurSearchFilterForm
            PurSearchFilterForm.PurSearchFilterRef = Me
            PurSearchFilterForm.ShowDialog()
        End If

    End Sub

    Private Sub ExitContent()

        NewPurSearchForm = Nothing
        boolPurSearchOpen = False
        Me.Hide()

    End Sub


    Public Function FindColumn() As Integer

        Dim selectedColumnCount As Integer = PurSearchDataGridView.Columns.GetColumnCount(DataGridViewElementStates.Selected)
        Dim tmpCount As Integer

        If selectedColumnCount > 0 Then

            Dim i As Integer
            For i = 0 To selectedColumnCount - 1

                tmpCount = PurSearchDataGridView.SelectedColumns(i).Index

            Next i

        End If

        FindColumn = tmpCount

    End Function

    Public Function ApplyFilter(selectedColumn As Integer, filterWord As String, FilterType As String) As Boolean

        Dim matchFilter As Boolean
        Dim tmpString As String = ""
        Dim currentRow As Integer = 0
        Dim maxColumn As Integer = PurSearchDataGridView.ColumnCount - 1
        Dim maxRow As Integer = PurSearchDataGridView.RowCount - 2
        Dim arrDataSet(0) As String

        For Each row As DataGridViewRow In PurSearchDataGridView.Rows
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
            Me.PurSearchDataGridView.DataSource = FilterTableData(arrDataSet, "PurTbl")
            ApplyFilter = True
            boolPurFilter = True
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
                If DR("PurID") = dataArray(j) Then
                    DataTableCopy.ImportRow(DataTable.Rows(rowCount))
                End If
            Next j
            rowCount = rowCount + 1
        Next

        FilterTableData = DataTableCopy

    End Function

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.RefreshContent()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ExitContent()

    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem1.Click
        Me.OpenContent()

    End Sub

    Private Sub FilterToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FilterToolStripMenuItem1.Click
        Me.FilterContent()

    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        Me.RefreshContent()

    End Sub

    Private Sub MemPurchaseCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles MemPurchaseCancelBtn.Click
        ExitContent()

    End Sub

    Private Sub NewPurchaseForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ExitContent()

    End Sub

End Class