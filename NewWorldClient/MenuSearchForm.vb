Public Class MenuSearchForm

    Private Sub MenuSearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.MenuTbl' table. You can move, or remove it, as needed.
        'Me.MenuTblTableAdapter.Fill(Me.NewWorldDBDataSet.MenuTbl)

        'Dim DataSet As New DataSet
        'DataSet = FillDataSet("MenuTbl")
        'Me.MenuSearchDataGridView.DataSource = DataSet.Tables("MenuTbl")

        Me.RefreshContent()

    End Sub

    Private Sub OpenToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem1.Click
        Me.OpenContent()

    End Sub

    Private Sub RefreshToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        Me.RefreshContent()

    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Me.DeleteContent()

    End Sub

    Private Sub MenuSearchDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MenuSearchDataGridView.CellMouseDoubleClick
        Me.OpenContent()

    End Sub

    Private Sub OpenContent()

        If boolMenuNew = True Then
            Warning("Please cancel or save current record before proceed")
        Else
            If boolMenuEdit = True Then
                Warning("Please close existing record before continue")
            Else
                Dim NewMenuForm As New NewMenuForm
                NewMenuForm.MdiParent = Me.MdiParent

                Dim i As Integer
                i = MenuSearchDataGridView.CurrentRow.Index

                'If boolMenuRefresh = True Then
                'Me.RefreshContent()
                'boolMenuRefresh = False
                'End If

                Dim tmpArray As Array
                Dim DataSet As DataSet
                DataSet = FillDataSet("MenuTbl", False)
                Me.MenuSearchDataGridView.DataSource = DataSet.Tables("MenuTbl")

                intMenuID = MenuSearchDataGridView.Item(0, i).Value
                strMenuName = MenuSearchDataGridView.Item(1, i).Value
                If Not IsDBNull(MenuSearchDataGridView.Item(2, i).Value) Then
                    strMenuDesc = MenuSearchDataGridView.Item(2, i).Value
                End If
                If Not IsDBNull(MenuSearchDataGridView.Item(3, i).Value) Then
                    strMenuProdName = MenuSearchDataGridView.Item(3, i).Value
                End If
                intMenuCredit = MenuSearchDataGridView.Item(4, i).Value
                boolMenuLock = MenuSearchDataGridView.Item(5, i).Value
                strMenuLockUser = MenuSearchDataGridView.Item(6, i).Value.ToString

                Try
                    'Existing Records
                    Dim DataRow As DataRow
                    DataRow = DataSet.Tables("MenuTbl").Rows.Find(intMenuID)

                    If boolMenuLock = True And strMenuLockUser <> strGlobalLogin Then
                        FatalError("Record is currently locked by user:" & strMenuLockUser)
                        NewMenuForm.Dispose()
                    Else
                        DataRow.BeginEdit()
                        DataRow("MenuLock") = True
                        DataRow("MenuLockUser") = strGlobalLogin
                        DataRow.EndEdit()

                        SaveDataSet(DataSet, "MenuTbl")
                        RefreshContent()

                        boolMenuEdit = True

                        NewMenuForm.MenuIDTextBox.Text = CStr(intMenuID)
                        NewMenuForm.MenuNameTextBox.Text = strMenuName
                        NewMenuForm.MenuDescTextBox.Text = strMenuDesc
                        NewMenuForm.MenuCreditNumericUpDown.Value = intMenuCredit
                        tmpArray = Split(strMenuProdName, "|")
                        If UBound(tmpArray) >= 0 Then
                            NewMenuForm.MenuAssocProdTxtBox.Text = Trim(tmpArray(0))

                            For i = 1 To UBound(tmpArray)
                                NewMenuForm.MenuAssocProdTxtBox.AppendText(Environment.NewLine & Trim(tmpArray(i)))
                            Next

                        End If

                        NewMenuForm.NewMenuClearBtn.Enabled = False
                        NewMenuForm.MenuNameTextBox.Enabled = False

                        NewMenuForm.Show()

                        intMenuID = Nothing
                        strMenuName = Nothing
                        'strMenuProdName = Nothing
                        intMenuCredit = Nothing
                        boolMenuLock = Nothing
                        strMenuLockUser = Nothing

                        'Me.Dispose()
                    End If
                Catch ex As Exception
                    FatalError("Error opening record")
                End Try
            End If
        End If
    End Sub

    Private Sub DeleteContent()

        Dim i As Integer
        i = MenuSearchDataGridView.CurrentRow.Index
        intMenuID = MenuSearchDataGridView.Item(0, i).Value
        strMenuName = Trim(MenuSearchDataGridView.Item(1, i).Value)
        boolMenuLock = MenuSearchDataGridView.Item(5, i).Value
        strMenuLockUser = MenuSearchDataGridView.Item(6, i).Value.ToString

        If boolMenuLock = True Then
            FatalError("Record cannot be deleted as it is currently open by: " & strMenuLockUser)
        Else
            Dim DataSet As DataSet
            DataSet = FillDataSet("MenuTbl", True)

            Dim DataRow As DataRow
            DataRow = DataSet.Tables("MenuTbl").Rows.Find(intMenuID)

            If Question("Menu: " & strMenuName & " will be deleted. Are you sure?") = True Then
                DataRow.Delete()

                SaveDataSet(DataSet, "MenuTbl")
                Confirmation("Record Deleted")

                RefreshContent()

            End If
        End If

    End Sub

    Private Sub RefreshContent()

        Dim DataSet As DataSet
        DataSet = FillDataSet("MenuTbl", False)

        Me.MenuSearchDataGridView.DataSource = DataSet.Tables("MenuTbl")
        Me.MenuSearchDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub ExitContent()
        Me.Dispose()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenContent()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteContent()

    End Sub

    Private Sub ExiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExiToolStripMenuItem.Click
        Me.Dispose()

    End Sub

    Private Sub RefreshToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem2.Click
        RefreshContent()

    End Sub

    Private Sub MenuSearchCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles MenuSearchCancelBtn.Click
        Me.Dispose()

    End Sub
End Class