Public Class ProdLookupform

    Public ProdLookupRef As Form

    Private Sub addPurProdLookupform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.ProdTbl' table. You can move, or remove it, as needed.
        'Me.ProdTblTableAdapter.Fill(Me.NewWorldDBDataSet.ProdTbl)

        RefreshContent()

    End Sub

    Private Sub AddPurProdLookupDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        OpenContent()

    End Sub

    Private Sub RefreshContent()

        Dim DataSet As DataSet
        DataSet = FillDataSet("ProdTbl", False)

        Me.ProdLookupDataGridView.DataSource = DataSet.Tables("ProdTbl")
        Me.ProdLookupDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenContent()

    End Sub

    Private Sub OpenContent()

        Dim i As Integer
        i = ProdLookupDataGridView.CurrentRow.Index
        intPurProdID = ProdLookupDataGridView.Item(0, i).Value
        strPurProdName = Trim(ProdLookupDataGridView.Item(1, i).Value)
        decPurAmt = ProdLookupDataGridView.Item(2, i).Value
        decPurBasAmt = ProdLookupDataGridView.Item(2, i).Value
        intPurCredit = ProdLookupDataGridView.Item(6, i).Value

        CType(ProdLookupRef, PurchaseHistoryForm).PurProdNameTextBox.Text = strPurProdName
        'CType(ProdLookupRef, PurchaseHistoryForm).PurAmtNumericUpDown.Text = Math.Round(decPurAmt, 2)
        'CType(ProdLookupRef, PurchaseHistoryForm).PurAmtNumericUpDown.Text = decPurAmt
        'CType(ProdLookupRef, PurchaseHistoryForm).PurQtyNumericUpDown.Text = 1
        'CType(ProdLookupRef, PurchaseHistoryForm).PurCreditNumericUpDown.Value = intPurCredit

        CType(ProdLookupRef, PurchaseHistoryForm).PurAmtNumericUpDown.Enabled = True
        CType(ProdLookupRef, PurchaseHistoryForm).PurQtyNumericUpDown.Enabled = True
        CType(ProdLookupRef, PurchaseHistoryForm).PurCreditNumericUpDown.Enabled = True

        CType(ProdLookupRef, PurchaseHistoryForm).PurWarrNoTextBox.Enabled = True
        CType(ProdLookupRef, PurchaseHistoryForm).PurSDateDateTimePicker.Enabled = True
        CType(ProdLookupRef, PurchaseHistoryForm).PurEDateDateTimePicker.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub CookingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CookingToolStripMenuItem.Click

        Dim DataSet As DataSet
        DataSet = FillProdData("Cooking")

        Me.ProdLookupDataGridView.DataSource = DataSet.Tables("ProdTbl")

    End Sub

    Private Sub ElectricToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ElectricToolStripMenuItem.Click

        Dim DataSet As DataSet
        DataSet = FillProdData("Electric")

        Me.ProdLookupDataGridView.DataSource = DataSet.Tables("ProdTbl")

    End Sub

    Private Sub NutritionToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NutritionToolStripMenuItem.Click

        Dim DataSet As DataSet
        DataSet = FillProdData("Nutrition")

        Me.ProdLookupDataGridView.DataSource = DataSet.Tables("ProdTbl")

    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshContent()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()

    End Sub

    Private Sub ProdLookupDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ProdLookupDataGridView.CellMouseDoubleClick
        Me.OpenContent()

    End Sub

    Private Sub ProdLookupFormCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProdLookupFormCancelBtn.Click
        Me.Dispose()

    End Sub
End Class