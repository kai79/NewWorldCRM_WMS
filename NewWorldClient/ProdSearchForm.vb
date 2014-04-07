Public Class ProdSearchForm

    Private Sub ProdSearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.ProdTbl' table. You can move, or remove it, as needed.
        'Me.ProdTblTableAdapter.Fill(Me.NewWorldDBDataSet.ProdTbl)

        Me.RefreshContent()

    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem1.Click
        Me.OpenContent()

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Me.RefreshContent()

    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Me.DeleteContent()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenContent()

    End Sub

    Private Sub RefreshToolStripMenuItem1_Click_1(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem1.Click
        Me.RefreshContent()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.ExitContent()

    End Sub

    Private Sub ProdSearchDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ProdSearchDataGridView.CellMouseDoubleClick
        Me.OpenContent()

    End Sub

    Private Sub OpenContent()

        If boolProductNew = True Then
            Warning("Please cancel or save current record before proceed")
        Else
            If boolProductEdit = True Then
                Warning("Please close existing record before continue")
            Else
                Dim NewProdForm As New NewProdForm
                NewProdForm.MdiParent = Me.MdiParent

                Dim i As Integer
                i = ProdSearchDataGridView.CurrentRow.Index

                'If boolProductRefresh = True Then
                'Me.RefreshContent()
                'boolProductRefresh = False
                'End If

                Dim DataSet As DataSet
                DataSet = FillDataSet("ProdTbl", False)
                Me.ProdSearchDataGridView.DataSource = DataSet.Tables("ProdTbl")

                intProductID = ProdSearchDataGridView.Item(0, i).Value
                strProductName = ProdSearchDataGridView.Item(1, i).Value
                decProductPrice = ProdSearchDataGridView.Item(2, i).Value
                intProductWarranty = ProdSearchDataGridView.Item(3, i).Value
                strProductCategory = ProdSearchDataGridView.Item(4, i).Value
                intProductCredit = ProdSearchDataGridView.Item(5, i).Value
                boolProductLock = ProdSearchDataGridView.Item(6, i).Value
                strProductLockUser = ProdSearchDataGridView.Item(7, i).Value.ToString

                Try
                    'Existing Records
                    Dim DataRow As DataRow
                    DataRow = DataSet.Tables("ProdTbl").Rows.Find(intProductID)
                    If boolProductLock = True And strProductLockUser <> strGlobalLogin Then
                        FatalError("Record is currently locked by user:" & strProductLockUser)
                        NewProdForm.Dispose()
                    Else
                        DataRow.BeginEdit()
                        DataRow("ProdLock") = True
                        DataRow("ProdLockUser") = strGlobalLogin
                        DataRow.EndEdit()

                        SaveDataSet(DataSet, "ProdTbl")
                        RefreshContent()

                        boolProductEdit = True

                        NewProdForm.ProdIDTextBox.Text = CStr(intProductID)
                        NewProdForm.ProdNameTextBox.Text = Trim(strProductName)
                        NewProdForm.ProdPriceNumericUpDown.Value = CStr(Math.Round(decProductPrice, 2))
                        NewProdForm.ProdWarrantyNumericUpDown.Value = intProductWarranty
                        NewProdForm.ProdCatComboBox.Text = Trim(strProductCategory)
                        NewProdForm.ProdCreditNumericUpDown.Value = intProductCredit

                        NewProdForm.ProdNewClearBtn.Enabled = False
                        NewProdForm.ProdNameTextBox.Enabled = False

                        NewProdForm.Show()

                        intProductID = Nothing
                        strProductName = Nothing
                        decProductPrice = Nothing
                        intProductWarranty = Nothing
                        strProductCategory = Nothing
                        intProductCredit = Nothing
                        boolProductLock = Nothing
                        strProductLockUser = Nothing

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
        i = ProdSearchDataGridView.CurrentRow.Index
        intProductID = ProdSearchDataGridView.Item(0, i).Value
        strProductName = Trim(ProdSearchDataGridView.Item(1, i).Value)
        boolProductLock = ProdSearchDataGridView.Item(6, i).Value
        strProductLockUser = ProdSearchDataGridView.Item(7, i).Value.ToString

        If boolProductLock = True Then
            FatalError("Record cannot be deleted as it is currently open by: " & strProductLockUser)
        Else
            Dim DataSet As DataSet
            DataSet = FillDataSet("ProdTbl", True)

            Dim DataRow As DataRow
            DataRow = DataSet.Tables("ProdTbl").Rows.Find(intProductID)
            If Question("Product: " & strProductName & " will be deleted. Are you sure?") = True Then
                DataRow.Delete()

                SaveDataSet(DataSet, "ProdTbl")
                Confirmation("Record Deleted")

                RefreshContent()

            End If
        End If

    End Sub

    Private Sub RefreshContent()

        Dim DataSet As DataSet
        DataSet = FillDataSet("ProdTbl", False)

        Me.ProdSearchDataGridView.DataSource = DataSet.Tables("ProdTbl")
        Me.ProdSearchDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub ExitContent()
        Me.Dispose()

    End Sub

    Private Sub CookingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CookingToolStripMenuItem.Click

        Dim DataSet As DataSet
        DataSet = FillProdData("Cooking")

        Me.ProdSearchDataGridView.DataSource = DataSet.Tables("ProdTbl")

    End Sub

    Private Sub ElectricToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ElectricToolStripMenuItem.Click

        Dim DataSet As DataSet
        DataSet = FillProdData("Electric")

        Me.ProdSearchDataGridView.DataSource = DataSet.Tables("ProdTbl")

    End Sub

    Private Sub NutritionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NutritionToolStripMenuItem.Click

        Dim DataSet As DataSet
        DataSet = FillProdData("Nutrition")

        Me.ProdSearchDataGridView.DataSource = DataSet.Tables("ProdTbl")

    End Sub

    Private Sub ProdSearchFormCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProdSearchFormCancelBtn.Click
        ExitContent()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        DeleteContent()

    End Sub
End Class