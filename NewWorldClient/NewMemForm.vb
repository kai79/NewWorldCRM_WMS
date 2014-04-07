Public Class NewMemForm

    Private Sub MemTblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.MemTblBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.NewWorldDBDataSet)

    End Sub

    Private Sub MemNewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.ClsTbl' table. You can move, or remove it, as needed.
        'Me.ClsTblTableAdapter.Fill(Me.NewWorldDBDataSet.ClsTbl)
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.MemTbl' table. You can move, or remove it, as needed.
        'Me.MemTblTableAdapter.Fill(Me.NewWorldDBDataSet.MemTbl)

        Me.PurchaseHistoryDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        Me.ClassHistoryDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        Me.ReferrerDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        If boolMemNew = True Then
            Me.MemIDTextBox.Text = CStr(intMemID)
            Me.MemRankComboBox.SelectedIndex = 3
            Me.MemZoneComboBox.SelectedIndex = 0
        Else
            LoadReferrerView()
        End If

    End Sub

    Private Sub LoadReferrerView()

        Dim myConn As New SqlClient.SqlConnection(strConnectionString)
        Dim myTable As New DataTable()
        Dim myCmd As New SqlClient.SqlCommand()
        myCmd.Connection = myConn
        Dim myQuery As String = "SELECT DISTINCT Mem.MemRank AS 'Member Rank', Mem.MemName AS 'Member Name', Mem.MemNRIC AS 'NRIC', Mem.MemCtcHome AS 'Contact(Home)', Mem.MemCtcMob AS 'Contact(Mobile)', Mem.MemDateJoin AS 'Join Date', '$' + CONVERT(VARCHAR, TotSpd.AmountSum, 0) AS 'Total Spending' FROM MemTbl as Mem, (SELECT Mem.MemID as SpdMemID, SUM(Pur.PurAmt) As 'AmountSum' FROM MemTbl AS Mem, PurTbl AS Pur WHERE Mem.MemID = Pur.PurMemID GROUP BY Mem.MemID) AS TotSpd WHERE (Mem.MemID=TotSpd.SpdMemID) AND Mem.MemRefID = '" & intMemID & "' UNION ALL SELECT DISTINCT Mem.MemRank AS 'Member Rank', Mem.MemName AS 'Member Name', Mem.MemNRIC AS 'NRIC', Mem.MemCtcHome AS 'Contact(Home)', Mem.MemCtcMob AS 'Contact(Mobile)', Mem.MemDateJoin AS 'Join Date', '$0' AS 'Total Spending' FROM MemTbl As Mem WHERE NOT EXISTS (SELECT * FROM PurTbl AS Pur WHERE Pur.PurMemID=Mem.MemID) AND Mem.MemRefID = '" & intMemID & "'"
        myCmd.CommandText = myQuery

        Try
            Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
            myAdapter.Fill(myTable)

            Me.ReferrerDataGridView.DataSource = myTable

        Catch ex As Exception

        End Try

    End Sub

    Private Sub NewMemForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Question("You will lose all unsaved data. Do you want to continue?") = True Then
            CancelForm()
        Else
            e.Cancel = True
            Exit Sub
        End If

    End Sub

    Private Sub NewMemSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMemSaveBtn.Click
        SaveForm()

    End Sub

    Private Sub NewMemCanBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMemCanBtn.Click
        CancelForm()

    End Sub

    Private Sub NewMemClrBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMemClrBtn.Click
        ClearForm()

    End Sub

    Private Function SaveForm() As Boolean

        Dim boolReturn As Boolean
        Dim boolProceedSave As Boolean = True

        If Me.MemNameTextBox.Text = "" Then
            FatalError("Member Name cannot be empty")
            MemNameTextBox.BackColor = Color.OrangeRed
            boolReturn = False
        Else
            intMemID = CInt(Me.MemIDTextBox.Text)
            strMemName = UCase(Me.MemNameTextBox.Text)
            strMemRank = Me.MemRankComboBox.Text
            strMemAddress = UCase(Me.MemAddressTextBox.Text)
            strMemNRIC = Trim(UCase(Me.MemNRICTextBox.Text))
            intMemCredit = Me.MemCreditNumericUpDown.Value
            strMemZone = Me.MemZoneComboBox.Text
            strMemContactHome = Me.MemCtcHomeTextBox.Text
            strMemContactMobile = Me.MemCtcMobTextBox.Text
            DatMemDateJoin = Me.MemJoinDatePicker.Text
            strMemEmail = UCase(Me.MemEmailTextBox.Text)
            strMemReferral = UCase(Me.MemRefTextBox.Text)

            If Me.MemNRICTextBox.Text = "" Then
                If Question("NRIC is not filled." & vbCrLf & "Do you want to continue?") = True Then
                    strMemNRIC = "NOT FILLED"
                Else
                    boolProceedSave = False
                    'FatalError("Member's NRIC cannot be empty" & vbCrLf & "Member will not be saved.")
                    'boolReturn = False
                End If
            Else
                If strMemNRIC <> "NOT FILLED" And strMemNRIC.Length <> 9 Then
                    FatalError("Member's NRIC should contains 9 characters and in the format of Sxxxxxxxx.")
                    boolProceedSave = False
                End If
            End If

            If strMemNRIC <> strOpenMemNRIC And strMemNRIC <> "NOT FILLED" And CheckDuplicate("SELECT * FROM MemTbl WHERE MemNRIC='" & strMemNRIC & "'") = True Then
                If Question("NRIC: " & strMemNRIC & " is already in used." & vbCrLf & "Do you want to continue?") = True Then

                Else
                    boolProceedSave = False
                    'FatalError("NRIC: " & strMemNRIC & " already exists" & vbCrLf & "Member will not be saved.")
                    'boolReturn = False
                End If
            End If

            If boolProceedSave = False Then
                boolReturn = False
            Else
                'Update Member Records
                Dim DataSet As DataSet
                Dim DataRow As DataRow

                Try
                    'Update Purchase History
                    DataSet = FillDataSet("PurTbl", True)
                    intMemTotAmt = 0

                    Dim intNewCredit As Integer = 0
                    Dim DataRowCount As Integer

                    DataRowCount = 0
                    For Each DataRow In DataSet.Tables("PurTbl").Rows
                        If DataRow("PurMemID") = intMemID Then
                            If DataRow("PurSave") = False Then
                                intNewCredit = intNewCredit + DataSet.Tables("PurTbl").Rows.Item(DataRowCount).Item("PurCredit")
                                DataRow.BeginEdit()
                                DataRow("PurSave") = True
                                DataRow.EndEdit()
                            End If
                        End If
                        DataRowCount = DataRowCount + 1
                    Next
                    SaveDataSet(DataSet, "PurTbl")

                    'Update Class History
                    DataSet = FillDataSet("ClsTbl", True)

                    Dim intDeductCredit As Integer = 0

                    DataRowCount = 0
                    For Each DataRow In DataSet.Tables("ClsTbl").Rows
                        If DataRow("ClsMemID") = intMemID Then
                            If DataRow("ClsSave") = False Then
                                intDeductCredit = intDeductCredit + DataSet.Tables("ClsTbl").Rows.Item(DataRowCount).Item("ClsCredit")
                                DataRow.BeginEdit()
                                DataRow("ClsSave") = True
                                DataRow.EndEdit()
                            End If
                        End If
                        DataRowCount = DataRowCount + 1
                    Next
                    SaveDataSet(DataSet, "ClsTbl")

                    intMemCredit = intMemCredit + intNewCredit - intDeductCredit

                    'Update Member table
                    DataSet = FillDataSet("MemTbl", True)

                    DataRow = DataSet.Tables("MemTbl").Rows.Find(intMemID)
                    DataRow.BeginEdit()
                    DataRow("MemName") = Trim(strMemName)
                    DataRow("MemRank") = Trim(strMemRank)
                    DataRow("MemAddress") = Trim(strMemAddress)
                    DataRow("MemNRIC") = Trim(strMemNRIC)
                    DataRow("MemZone") = Trim(strMemZone)
                    DataRow("MemCtcHome") = Trim(strMemContactHome)
                    DataRow("MemCtcMob") = Trim(strMemContactMobile)
                    DataRow("MemEmail") = Trim(strMemEmail)
                    DataRow("MemRank") = Trim(strMemRank)
                    DataRow("MemRef") = Trim(strMemReferral)
                    DataRow("MemRefID") = Trim(intMemReferrralID)
                    DataRow("MemDateJoin") = Trim(DatMemDateJoin)
                    DataRow("MemCredit") = Trim(intMemCredit)
                    DataRow("MemLock") = False
                    DataRow("MemLockUser") = vbNull
                    DataRow.EndEdit()

                    SaveDataSet(DataSet, "MemTbl")

                    If boolMemNew = True Then
                        boolMemNew = False
                    Else
                        If boolMemEdit = True Then
                            boolMemEdit = False
                            'boolMemRefresh = True
                        End If
                    End If

                    Confirmation("Record updated successfully")
                    boolReturn = True

                    Me.Dispose()

                Catch ex As Exception
                    FatalError("Record update failed")
                End Try

                intMemID = Nothing
                strMemName = Nothing
                strMemRank = Nothing
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

                strOpenMemNRIC = Nothing
            End If
        End If

        SaveForm = boolReturn

    End Function

    Private Sub ClearForm()

        Me.MemNameTextBox.Text = ""
        Me.MemRankComboBox.SelectedIndex = 3
        Me.MemAddressTextBox.Text = ""
        Me.MemZoneComboBox.SelectedIndex = 0
        Me.MemCtcHomeTextBox.Text = ""
        Me.MemCtcMobTextBox.Text = ""
        Me.MemEmailTextBox.Text = ""
        Me.MemNRICTextBox.Text = ""
        Me.MemRefTextBox.Text = ""
        Me.MemJoinDatePicker.Text = Today
        Me.MemCreditNumericUpDown.Value = 0


    End Sub

    Private Sub CancelForm()

        intMemID = Me.MemIDTextBox.Text()

        Dim DataSet As DataSet
        DataSet = FillDataSet("MemTbl", True)
        Dim DataRow As DataRow

        If boolMemNew = True Then

            DataRow = DataSet.Tables("MemTbl").Rows.Find(intMemID)
            DataRow.Delete()
            SaveDataSet(DataSet, "MemTbl")

            'Delete records in Purchase history
            DelPurHisRecord(intMemID)

            'Delete records in Class history
            DelClsHisRecord(intMemID)

            boolMemNew = False
            Me.Dispose()
 
        Else
            If boolMemEdit = True Then

                DataRow = DataSet.Tables("MemTbl").Rows.Find(intMemID)
                DataRow.BeginEdit()
                DataRow("MemLock") = False
                DataRow("MemLockUser") = vbNull
                DataRow.EndEdit()

                SaveDataSet(DataSet, "MemTbl")

                'Delete records in Purchase history
                DelPurHisRecord(intMemID)

                'Delete records in Class history
                DelClsHisRecord(intMemID)

                boolMemEdit = False
                Me.Dispose()

            Else
                Me.Dispose()
            End If
        End If

    End Sub

    Private Sub NewMemAddRefBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMemAddRefBtn.Click

        Dim NewMemAddRefForm As New AddRefForm
        NewMemAddRefForm.NewMemAddRef_Ref = Me
        NewMemAddRefForm.ShowDialog()

    End Sub

    Private Sub PurHisAddBtn_Click(sender As System.Object, e As System.EventArgs) Handles PurHisAddBtn.Click

        If boolPurNew = True Then
            FatalError("Please cancel or save current purchase record before proceed")
        Else
            If boolPurEdit = True Then
                FatalError("Please close existing purchase record before continue")
            Else

                Dim DataSet As DataSet
                DataSet = FillDataSet("PurTbl", True)

                If DataSet.Tables("PurTbl").Rows.Count > 0 Then
                    intPurID = DataSet.Tables("PurTbl")(DataSet.Tables("PurTbl").Rows.Count - 1)("PurID") + 1
                Else
                    intPurID = 1
                End If

                intPurMemID = Me.MemIDTextBox.Text

                Dim DataRow As DataRow = DataSet.Tables("PurTbl").NewRow
                DataRow("PurID") = intPurID
                DataRow("PurMemID") = intPurMemID
                DataRow("PurLock") = True
                DataSet.Tables("PurTbl").Rows.Add(DataRow)

                SaveDataSet(DataSet, "PurTbl")
                boolPurNew = True

                Dim PurchaseHistoryForm As New PurchaseHistoryForm
                PurchaseHistoryForm.PurchaseHistoryRef = Me
                PurchaseHistoryForm.ShowDialog()

            End If
        End If

    End Sub

    Private Sub PurHisOpenBtn_Click(sender As System.Object, e As System.EventArgs) Handles PurHisOpenBtn.Click
        Me.OpenPurchaseHistory()

    End Sub

    Private Sub PurchaseHistoryDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PurchaseHistoryDataGridView.CellMouseDoubleClick
        Me.OpenPurchaseHistory()

    End Sub

    Private Sub PurHisDelBtn_Click(sender As System.Object, e As System.EventArgs) Handles PurHisDelBtn.Click

        If PurchaseHistoryDataGridView.CurrentRow Is Nothing Then

        Else
            If boolPurNew = True Then
                FatalError("Please cancel or save current purchase record before proceed")
            Else
                If boolPurEdit = True Then
                    FatalError("Please close existing purchase record before continue")
                Else

                    If Question("Record will be deleted. Are you sure?") = True Then

                        Try

                            intMemID = Me.MemIDTextBox.Text

                            Dim i As Integer
                            i = Me.PurchaseHistoryDataGridView.CurrentRow.Index
                            intPurID = Me.PurchaseHistoryDataGridView.Item(4, i).Value

                            Dim DataSet As DataSet
                            DataSet = FillDataSet("PurTbl", True)

                            Dim DataRow As DataRow
                            DataRow = DataSet.Tables("PurTbl").Rows.Find(intPurID)
                            DataRow.Delete()

                            SaveDataSet(DataSet, "PurTbl")
                            Confirmation("Record Deleted")

                            DataSet = FillDataSet("PurTbl", True)

                            Me.PurchaseHistoryDataGridView.DataSource = GetTableData(intMemID, "PurMemID", "PurTbl")

                        Catch ex As Exception

                        End Try

                    End If
                End If
            End If
        End If

    End Sub

    Private Sub DelPurHisRecord(UserID As Integer)

        Dim DataSet As DataSet
        DataSet = FillDataSet("PurTbl", True)

        For Each DataRow As DataRow In DataSet.Tables("PurTbl").Rows
            If DataRow("PurMemID") = UserID Then
                If DataRow("PurSave") = False Then
                    DataRow.Delete()
                End If
            End If
        Next

        SaveDataSet(DataSet, "PurTbl")

        DataSet = FillDataSet("PurTbl", True)

        Me.PurchaseHistoryDataGridView.DataSource = ""

    End Sub

    Private Sub ClsHisAddBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClsHisAddBtn.Click

        If boolPurNew = True Then
            FatalError("Please cancel or save current class record before proceed")

        Else
            If boolPurEdit = True Then
                FatalError("Please close existing class record before continue")

            Else
                Dim DataSet As DataSet
                DataSet = FillDataSet("ClsTbl", True)

                If DataSet.Tables("ClsTbl").Rows.Count > 0 Then
                    intClsID = DataSet.Tables("ClsTbl")(DataSet.Tables("ClsTbl").Rows.Count - 1)("ClsID") + 1
                Else
                    intClsID = 1
                End If

                intClsMemID = Me.MemIDTextBox.Text

                Dim DataRow As DataRow = DataSet.Tables("ClsTbl").NewRow
                DataRow("ClsID") = intClsID
                DataRow("ClsMemID") = intClsMemID
                DataRow("ClsLock") = True
                DataSet.Tables("ClsTbl").Rows.Add(DataRow)

                SaveDataSet(DataSet, "ClsTbl")
                boolClsNew = True

                Dim ClassHistoryForm As New ClassHistoryForm
                ClassHistoryForm.ClassHistoryRef = Me
                ClassHistoryForm.ShowDialog()

            End If
        End If

    End Sub

    Private Sub ClsHisDelBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClsHisDelBtn.Click

        If PurchaseHistoryDataGridView.CurrentRow Is Nothing Then

        Else
            If boolClsNew = True Then
                FatalError("Please cancel or save current class record before proceed")

            Else
                If boolClsEdit = True Then
                    FatalError("Please close existing class record before continue")

                Else

                    If Question("Record will be deleted. Are you sure?") = True Then

                        Try
                            intMemID = Me.MemIDTextBox.Text

                            Dim i As Integer
                            i = Me.ClassHistoryDataGridView.CurrentRow.Index
                            intClsID = Me.ClassHistoryDataGridView.Item(2, i).Value

                            Dim DataSet As DataSet
                            DataSet = FillDataSet("ClsTbl", True)

                            Dim DataRow As DataRow
                            DataRow = DataSet.Tables("ClsTbl").Rows.Find(intClsID)
                            DataRow.Delete()

                            SaveDataSet(DataSet, "ClsTbl")
                            Confirmation("Record Deleted")

                            DataSet = FillDataSet("ClsTbl", True)

                            Me.ClassHistoryDataGridView.DataSource = GetTableData(intMemID, "ClsMemID", "ClsTbl")

                        Catch ex As Exception

                        End Try
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub ClsHisOpenBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClsHisOpenBtn.Click
        Me.OpenClassHistory()

    End Sub

    Private Sub ClassHistoryDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ClassHistoryDataGridView.CellMouseDoubleClick
        Me.OpenClassHistory()

    End Sub

    Private Sub DelClsHisRecord(UserID As Integer)

        Dim DataSet As DataSet
        DataSet = FillDataSet("ClsTbl", True)

        For Each DataRow As DataRow In DataSet.Tables("ClsTbl").Rows
            If DataRow("ClsMemID") = UserID Then
                If DataRow("ClsSave") = False Then
                    DataRow.Delete()
                End If
            End If
        Next

        SaveDataSet(DataSet, "ClsTbl")

        DataSet = FillDataSet("ClsTbl", True)

        Me.ClassHistoryDataGridView.DataSource = ""

    End Sub

    Private Sub OpenPurchaseHistory()

        If PurchaseHistoryDataGridView.CurrentRow Is Nothing Then

        Else
            If boolPurNew = True Then
                FatalError("Please cancel or save current purchase record before proceed")
            Else
                If boolPurEdit = True Then
                    FatalError("Please close existing purchase record before continue")
                Else

                    Dim PurchaseHistoryForm As New PurchaseHistoryForm
                    PurchaseHistoryForm.PurchaseHistoryRef = Me

                    Dim i As Integer
                    i = PurchaseHistoryDataGridView.CurrentRow.Index

                    strPurProdName = PurchaseHistoryDataGridView.Item(0, i).Value
                    datPurDate = PurchaseHistoryDataGridView.Item(1, i).Value
                    datPurSDate = PurchaseHistoryDataGridView.Item(2, i).Value
                    datPurEDate = PurchaseHistoryDataGridView.Item(3, i).Value
                    intPurID = PurchaseHistoryDataGridView.Item(4, i).Value
                    intPurMemID = PurchaseHistoryDataGridView.Item(5, i).Value
                    strPurHis = PurchaseHistoryDataGridView.Item(6, i).Value
                    strPurOrderNo = PurchaseHistoryDataGridView.Item(7, i).Value
                    strPurWarrNo = PurchaseHistoryDataGridView.Item(8, i).Value
                    decPurAmt = PurchaseHistoryDataGridView.Item(9, i).Value
                    intPurQty = PurchaseHistoryDataGridView.Item(10, i).Value
                    intPurCredit = PurchaseHistoryDataGridView.Item(11, i).Value
                    datPurDepoDate = PurchaseHistoryDataGridView.Item(12, i).Value
                    strPurDevStatus = PurchaseHistoryDataGridView.Item(13, i).Value
                    strPurRemark = PurchaseHistoryDataGridView.Item(14, i).Value

                    boolPurEdit = True

                    PurchaseHistoryForm.PurProdNameTextBox.Text = strPurProdName
                    PurchaseHistoryForm.PurDateDateTimePicker.Text = CStr(datPurDate)
                    PurchaseHistoryForm.PurSDateDateTimePicker.Text = CStr(datPurSDate)
                    PurchaseHistoryForm.PurEDateDateTimePicker.Text = CStr(datPurEDate)
                    PurchaseHistoryForm.PurIDTextBox.Text = intPurID
                    PurchaseHistoryForm.PurHisTextBox.Text = strPurHis
                    PurchaseHistoryForm.PurOrderNoTextBox.Text = Trim(strPurOrderNo)
                    PurchaseHistoryForm.PurWarrNoTextBox.Text = Trim(strPurWarrNo)
                    'PurchaseHistoryForm.PurAmtNumericUpDown.Text = Math.Round(decPurAmt, 2)
                    PurchaseHistoryForm.PurAmtNumericUpDown.Text = decPurAmt
                    PurchaseHistoryForm.PurQtyNumericUpDown.Text = intPurQty
                    PurchaseHistoryForm.PurCreditNumericUpDown.Value = intPurCredit
                    PurchaseHistoryForm.PurDepoDateTimePicker.Text = CStr(datPurDepoDate)
                    PurchaseHistoryForm.PurDevStatusComboBox.Text = Trim(strPurDevStatus)
                    PurchaseHistoryForm.PurRemarkTextBox.Text = strPurRemark

                    PurchaseHistoryForm.PurOrderNoTextBox.Enabled = False
                    PurchaseHistoryForm.PurWarrNoTextBox.Enabled = False
                    PurchaseHistoryForm.AddPurProLookupBtn.Enabled = False
                    PurchaseHistoryForm.PurDateDateTimePicker.Enabled = False
                    PurchaseHistoryForm.PurAmtNumericUpDown.Enabled = False
                    PurchaseHistoryForm.PurDepoDateTimePicker.Enabled = False
                    PurchaseHistoryForm.PurQtyNumericUpDown.Enabled = False

                    PurchaseHistoryForm.ShowDialog()

                    strPurProdName = Nothing
                    datPurDate = Nothing
                    datPurSDate = Nothing
                    datPurEDate = Nothing
                    intPurID = Nothing
                    intPurMemID = Nothing
                    strPurHis = Nothing
                    strPurOrderNo = Nothing
                    strPurWarrNo = Nothing
                    decPurAmt = Nothing
                    intPurQty = Nothing
                    intPurCredit = Nothing
                    datPurDepoDate = Nothing
                    strPurDevStatus = Nothing
                    strPurRemark = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub OpenClassHistory()

        If ClassHistoryDataGridView.CurrentRow Is Nothing Then

        Else
            If boolClsNew = True Then
                FatalError("Please cancel or save current class record before proceed")
            Else
                If boolClsEdit = True Then
                    FatalError("Please close existing class record before continue")
                Else

                    Dim ClassHistoryForm As New ClassHistoryForm
                    ClassHistoryForm.ClassHistoryRef = Me

                    Dim i As Integer
                    i = ClassHistoryDataGridView.CurrentRow.Index

                    intClsMemID = Me.MemIDTextBox.Text
                    strClsMenuName = Me.ClassHistoryDataGridView.Item(0, i).Value
                    datClsDate = Me.ClassHistoryDataGridView.Item(1, i).Value
                    intClsID = Me.ClassHistoryDataGridView.Item(2, i).Value
                    intClsMemID = Me.ClassHistoryDataGridView.Item(3, i).Value

                    ClassHistoryForm.ClsIDTextBox.Text = intClsID
                    ClassHistoryForm.ClsMenuNameTextBox.Text = strClsMenuName
                    ClassHistoryForm.ClsDateDateTimePicker.Text = datClsDate

                    boolClsEdit = True

                    ClassHistoryForm.ShowDialog()

                    intClsMemID = Nothing
                    strClsMenuName = Nothing
                    datClsDate = Nothing
                    intClsID = Nothing
                    intClsMemID = Nothing

                End If
            End If
        End If
    End Sub

End Class