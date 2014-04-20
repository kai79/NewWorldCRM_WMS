Public Class WhForm

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.WhProdTbl' table. You can move, or remove it, as needed.
        'Me.WhProdTblTableAdapter.Fill(Me.NewWorldDBDataSet.WhProdTbl)

        'strGlobalLogin = "warehouse"
        'strGlobalLoginType = "Admin"

        Me.WindowState = FormWindowState.Maximized

        ResetTransactionFrom()
        DisplayTransaction()
        UpdateProductManager()
        'UpdateProdCat()

    End Sub

    Private Sub WhForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If WhCancelBtn.Enabled = True Then
            If Question("You will lose all unsaved data. Do you want to continue?") = True Then
                CancelTransaction()
                Application.Exit()
            Else
                e.Cancel = True
                Exit Sub
            End If
        Else
            Application.Exit()
        End If

    End Sub

    Private Sub UpdateProductManager()

        Dim dsTable As New DataSet("WhProdTbl")

        Dim objConn As New SqlClient.SqlConnection(strConnectionString)
        objConn.Open()

        Dim strQuery As String = "SELECT * FROM dbo.WhProdTbl order by WhProdEnable DESC, WhProdCat, WhProdName"

        'Create instance of data adapter
        Dim daTable As New SqlClient.SqlDataAdapter(strQuery, objConn)

        'Create instance of DataSet
        daTable.FillSchema(dsTable, SchemaType.Source, "WhProdTbl")
        daTable.Fill(dsTable, "WhProdTbl")

        Me.WhProdManDataGridView.DataSource = dsTable.Tables("WhProdTbl")
        Me.WhProdManDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Public Sub UpdateTransaction()

        For i = 0 To (WhQueryDataGridView.Rows.Count - 1)
            If WhQueryDataGridView.Rows(i).Cells(13).Value = True Then
                WhQueryDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.LightSkyBlue
            End If
        Next

    End Sub

    Private Sub DisplayTransaction()

        Dim DevIDHigh As Integer
        Dim DevIDLow As Integer
        Dim DataSet As DataSet
        DataSet = FillDataSet("WhTbl", True)

        If DataSet.Tables("WhTbl").Rows.Count > 0 Then
            DevIDHigh = DataSet.Tables("WhTbl")(DataSet.Tables("WhTbl").Rows.Count - 1)("WhDevID") + 1
            If DevIDHigh >= 25 Then
                DevIDLow = DevIDHigh - 25
            Else
                DevIDLow = 0
            End If
        Else
            DevIDHigh = 0
            DevIDLow = 0
        End If

        Dim myConn As New SqlClient.SqlConnection(strConnectionString)
        Dim myTable As New DataTable()
        Dim myCmd As New SqlClient.SqlCommand()
        myCmd.Connection = myConn
        If DevIDLow <> 0 Then
            myCmd.CommandText = "SELECT * FROM WhTbl WHERE WhDevID <= '" & DevIDHigh & "' AND WhDevID >= '" & DevIDLow & "' AND WhProBy IS NOT NULL"
            sqlCurrentView = "SELECT * FROM WhTbl WHERE WhDevID <= '" & DevIDHigh & "' AND WhDevID >= '" & DevIDLow & "' AND WhProBy IS NOT NULL"
        Else
            myCmd.CommandText = "SELECT * FROM WhTbl WHERE WhProBy IS NOT NULL"
            sqlCurrentView = "SELECT * FROM WhTbl WHERE WhProBy IS NOT NULL"
        End If

        Try
            Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
            myAdapter.Fill(myTable)

            WhQueryDataGridView.DataSource = myTable
            WhQueryDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        Catch ex As Exception

        End Try

        'UpdateTransaction()

    End Sub

    Private Sub ResetTransactionFrom()

        WhDevIDTextBox.Text = ""
        WhProByTextBox.Text = ""
        WhTimeStampTextBox.Text = ""

        WhTranTypeComboBox.Enabled = False
        WhTranTypeComboBox.SelectedIndex = 0
        WhPoIDTextBox.Enabled = False
        WhPoIDTextBox.Text = ""
        WhDateDateTimePicker.Enabled = False
        WhDateDateTimePicker.ResetText()
        WhTypeComboBox.Enabled = False
        WhTypeComboBox.SelectedIndex = 0
        WhNameTextBox.Enabled = False
        WhNameTextBox.Text = ""
        WhAddTextBox.Enabled = False
        WhAddTextBox.Text = ""
        WhCtcTextBox.Enabled = False
        WhCtcTextBox.Text = ""

        Me.WhItemTblDataGridView.DataSource = Nothing

        WhAddBtn.Enabled = True
        WhCancelBtn.Enabled = False
        WhSaveBtn.Enabled = False
        WhAddProdBtn.Enabled = False
        WhRemoveProdBtn.Enabled = False
        WhOpenProdBtn.Enabled = False
        WhAddHistoryBtn.Enabled = False

        If strGlobalLoginType = "WH_Superuser" Then
            WhQueryDeleteBtn.Enabled = True
            WhQueryApproveBtn.Enabled = True
            WhQueryApproveAllBtn.Enabled = True
        Else
            WhQueryDeleteBtn.Enabled = False
            WhQueryApproveBtn.Enabled = False
            WhQueryApproveAllBtn.Enabled = False
        End If

        WhQueryEditBtn.Enabled = True

        WhTranComboBox.SelectedIndex = 0

        WhPoIDTextBox.BackColor = SystemColors.Window
        WhNameTextBox.BackColor = SystemColors.Window

    End Sub

    Private Sub WhOutSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhSaveBtn.Click

        Dim boolOverwritePO As Boolean = False
        Dim boolAns As Boolean = False

        WhPoIDTextBox.BackColor = Color.LightGreen
        WhNameTextBox.BackColor = Color.LightGreen

        If Me.WhPoIDTextBox.Text = "" Then
            FatalError("Please specify PO number")
            WhPoIDTextBox.BackColor = Color.OrangeRed
        Else
            If Me.WhNameTextBox.Text = "" Then
                FatalError("Please specify Recipient")
                WhNameTextBox.BackColor = Color.OrangeRed
            Else
                strWhPoID = Me.WhPoIDTextBox.Text

                If boolWhEdit = False And CheckDuplicate("SELECT * FROM WhTbl WHERE WhPoID='" & strWhPoID & "'") = True Then
                    If Question("The PO number """ & strWhPoID & """ is already used. Do you want to continue?") = True Then
                        boolOverwritePO = True
                    End If
                Else
                    If Question("Comfirm Order?") = True Then
                        boolAns = True
                    End If
                End If

                If boolOverwritePO = True Or boolAns = True Then

                    Me.WhTimeStampTextBox.Text = Date.Now.ToString

                    strWhName = Me.WhNameTextBox.Text
                    strWhAdd = Me.WhAddTextBox.Text
                    strWhCtc = Me.WhCtcTextBox.Text
                    strWhCtcType = Me.WhTypeComboBox.Text

                    datWhTime = Me.WhDateDateTimePicker.Text
                    strWhPoID = Me.WhPoIDTextBox.Text

                    strWhProBy = Me.WhProByTextBox.Text
                    datWhTimeStamp = Me.WhTimeStampTextBox.Text

                    strWhTranType = Me.WhTranTypeComboBox.Text

                    'Update Member Records
                    Dim DataSet As DataSet

                    DataSet = FillDataSet("WhTbl", True)

                    Try
                        Dim DataRow As DataRow
                        DataRow = DataSet.Tables("WhTbl").Rows.Find(intWhDevID)
                        DataRow.BeginEdit()
                        DataRow("WhTranType") = Trim(strWhTranType)
                        DataRow("WhName") = Trim(UCase(strWhName))
                        DataRow("WhAdd") = Trim(UCase(strWhAdd))
                        DataRow("WhCtc") = Trim(strWhCtc)
                        DataRow("WhType") = Trim(strWhCtcType)
                        DataRow("WhPoID") = Trim(strWhPoID)
                        DataRow("WhDevDate") = Trim(datWhTime)
                        'DataRow("WhDevDate") = DateTime.Now
                        DataRow("WhProBy") = Trim(strWhProBy)
                        DataRow("WhTimeStamp") = Trim(datWhTimeStamp)
                        DataRow("WhRecordCounter") = intWhCounter
                        DataRow("WhLock") = False
                        If boolWhEdit = True Then
                            DataRow("WhEdit") = True
                        Else
                            DataRow("WhEdit") = False
                        End If
                        DataRow.EndEdit()

                        SaveDataSet(DataSet, "WhTbl")

                        'Update Item History
                        DataSet = FillDataSet("WhItemTbl", True)

                        For Each DataRow In DataSet.Tables("WhItemTbl").Rows
                            If DataRow("WhItemDevID") = intWhDevID Then
                                DataRow.BeginEdit()
                                DataRow("WhItemTranType") = Trim(strWhTranType)
                                DataRow("WhItemDevDate") = Trim(datWhTime)
                                DataRow("WhItemSave") = True
                                DataRow.EndEdit()
                            End If
                        Next

                        SaveDataSet(DataSet, "WhItemTbl")

                        'Update Customer table history
                        'If CheckDuplicate("SELECT * FROM WhCusTbl WHERE WhCusName='" & Trim(UCase(strWhName)) & "'") = False And strWhCtcType = "Company" Then
                        If strWhCtcType = "Company" Then

                            DataSet = FillDataSet("WhCusTbl", True)

                            If CheckDuplicate("SELECT * FROM WhCusTbl WHERE WhCusName='" & Trim(UCase(strWhName)) & "'") = False Then
                                'New customer records
                                If DataSet.Tables("WhCusTbl").Rows.Count > 0 Then
                                    intWhCusID = DataSet.Tables("WhCusTbl")(DataSet.Tables("WhCusTbl").Rows.Count - 1)("WhCusID") + 1
                                Else
                                    intWhCusID = 1
                                End If

                                DataRow = DataSet.Tables("WhCusTbl").NewRow
                                DataRow("WhCusID") = intWhCusID
                                DataRow("WhCusName") = Trim(UCase(strWhName))
                                DataRow("WhCusAdd") = Trim(UCase(strWhAdd))
                                DataRow("WhCusCtc") = Trim(strWhCtc)
                                DataRow("WhCusLock") = False
                                DataSet.Tables("WhCusTbl").Rows.Add(DataRow)
                            Else
                                'Existing customer records
                                intWhCusID = GetSQLValue("SELECT WhCusID FROM WhCusTbl WHERE WhCusName='" & Trim(UCase(strWhName)) & "'")

                                DataRow = DataSet.Tables("WhCusTbl").Rows.Find(intWhCusID)
                                DataRow.BeginEdit()
                                DataRow("WhCusID") = intWhCusID
                                DataRow("WhCusName") = Trim(UCase(strWhName))
                                DataRow("WhCusAdd") = Trim(UCase(strWhAdd))
                                DataRow("WhCusCtc") = Trim(strWhCtc)
                                DataRow("WhCusLock") = False
                                DataRow.EndEdit()

                                intWhCusID = Nothing

                            End If

                            SaveDataSet(DataSet, "WhCusTbl")

                        End If

                        Confirmation("Order Saved")

                        boolWhEdit = False

                        ResetTransactionFrom()
                        DisplayTransaction()

                    Catch ex As Exception
                        FatalError("Failed to save record!")
                    End Try
                Else
                    Me.WhTimeStampTextBox.Text = ""
                End If
            End If
        End If

        strWhName = Nothing
        strWhAdd = Nothing
        strWhCtc = Nothing
        strWhCtcType = Nothing
        datWhTime = Nothing
        strWhPoID = Nothing
        strWhProBy = Nothing
        datWhTimeStamp = Nothing
        strWhTranType = Nothing

    End Sub

    Private Sub WhOutCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhCancelBtn.Click
        CancelTransaction()

    End Sub

    Private Sub CancelTransaction()

        Dim DataSet As DataSet

        If boolWhEdit = False Then
            'New Entry
            CancelTransactionItem()
        Else
            'Edit Entry
            DataSet = FillDataSet("WhTbl", True)
            For Each DataRow As DataRow In DataSet.Tables("WhTbl").Rows
                If DataRow("WhDevID") = intWhDevID Then
                    DataRow("WhLock") = False
                End If
            Next
            SaveDataSet(DataSet, "WhTbl")
            boolWhEdit = False
        End If

        ResetTransactionFrom()

    End Sub


    Private Sub CancelTransactionItem()

        Dim DataSet As DataSet
        Dim DataRow As DataRow

        Try
            DataSet = FillDataSet("WhTbl", True)
            DataRow = DataSet.Tables("WhTbl").Rows.Find(intWhDevID)
            DataRow.Delete()
            SaveDataSet(DataSet, "WhTbl")


            DataSet = FillDataSet("WhItemTbl", True)
            For Each DataRow In DataSet.Tables("WhItemTbl").Rows
                If DataRow("WhItemDevID") = intWhDevID Then
                    If DataRow("WhItemSave") = False Then
                        DataRow.Delete()
                    End If
                End If
            Next

            SaveDataSet(DataSet, "WhItemTbl")

        Catch ex As Exception
            FatalError("Error deleting orders. Please contract your IT support")
        End Try

    End Sub

    Private Sub WhOutAddBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddBtn.Click

        'Dim CurYear = DateTime.Now.ToString("yy")

        'Me.WhDevDateTextBox.Text = CurYear
        intWhCounter = 0
        boolWhEdit = False

        Dim DataSet As DataSet
        DataSet = FillDataSet("WhTbl", True)

        'Dim strCurDevID As String
        'Dim intTmp As Integer

        If DataSet.Tables("WhTbl").Rows.Count > 0 Then
            intWhDevID = DataSet.Tables("WhTbl")(DataSet.Tables("WhTbl").Rows.Count - 1)("WhDevID") + 1
            'intWhDevID = intWhDevID.ToString.PadLeft(10, "0")

            'If strCurDevID.Substring(0, 2) < CurYear Then
            'strCurDevID = "1"
            'strCurDevID = strCurDevID.PadLeft(5, "0")
            'Else
            'intTmp = CInt(strCurDevID.Substring(2, 5)) + 1
            'strCurDevID = CStr(intTmp)
            'strCurDevID = strCurDevID.PadLeft(5, "0")
            'End If
        Else
            intWhDevID = "1"
            'intWhDevID = intWhDevID.ToString.PadLeft(10, "0")

        End If

        'intWhDevID = strCurDevID

        Dim DataRow As DataRow = DataSet.Tables("WhTbl").NewRow
        DataRow("WhDevID") = intWhDevID
        DataRow("WhLock") = True
        DataSet.Tables("WhTbl").Rows.Add(DataRow)

        SaveDataSet(DataSet, "WhTbl")

        Me.WhDevIDTextBox.Text = intWhDevID
        Me.WhProByTextBox.Text = strGlobalLogin

        WhTranTypeComboBox.Enabled = True
        WhTranTypeComboBox.SelectedIndex = 0
        WhPoIDTextBox.Enabled = True
        WhDateDateTimePicker.Enabled = True
        WhTypeComboBox.Enabled = True
        WhTypeComboBox.SelectedIndex = 0
        WhNameTextBox.Enabled = True
        WhAddTextBox.Enabled = True
        WhCtcTextBox.Enabled = True

        WhAddBtn.Enabled = False
        WhCancelBtn.Enabled = True
        WhSaveBtn.Enabled = True
        WhAddProdBtn.Enabled = True
        WhRemoveProdBtn.Enabled = True
        WhOpenProdBtn.Enabled = True
        WhAddHistoryBtn.Enabled = False

        WhQueryEditBtn.Enabled = False

        WhPoIDTextBox.BackColor = Color.LightGreen
        WhNameTextBox.BackColor = Color.LightGreen

    End Sub

    Private Sub WhOutAddProdBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddProdBtn.Click

        boolItemNew = True

        Dim NewWhAddProdForm As New WhAddProdForm
        NewWhAddProdForm.WhAddProdFormRef = Me
        NewWhAddProdForm.ShowDialog()

    End Sub

    Private Sub WhRemoveProdBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhRemoveProdBtn.Click

        If WhItemTblDataGridView.CurrentRow Is Nothing Then

        Else

            If Question("Selected record will be deleted. Are you sure?") = True Then


                Dim i As Integer
                i = Me.WhItemTblDataGridView.CurrentRow.Index
                longWhItemID = Me.WhItemTblDataGridView.Item(0, i).Value

                Dim DataSet As DataSet
                DataSet = FillDataSet("WhItemTbl", True)

                Dim DataRow As DataRow
                DataRow = DataSet.Tables("WhItemTbl").Rows.Find(longWhItemID)
                DataRow.Delete()

                SaveDataSet(DataSet, "WhItemTbl")

                DataSet = FillDataSet("WhItemTbl", True)

                Me.WhItemTblDataGridView.DataSource = GetTableData(intWhDevID, "WhItemDevID", "WhItemTbl")

            End If
        End If

    End Sub

    Private Sub WhOutOpenProdBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhOpenProdBtn.Click

        If WhItemTblDataGridView.CurrentRow Is Nothing Then

        Else
            Dim NewWhAddProdForm As New WhAddProdForm
            NewWhAddProdForm.WhAddProdFormRef = Me

            Try
                Dim i As Integer
                i = WhItemTblDataGridView.CurrentRow.Index

                longWhItemID = WhItemTblDataGridView.Item(0, i).Value
                intWhItemDevItemID = WhItemTblDataGridView.Item(1, i).Value
                intWhItemDevID = WhItemTblDataGridView.Item(2, i).Value
                strWhItemProdCat = WhItemTblDataGridView.Item(3, i).Value
                strWhItemProdName = WhItemTblDataGridView.Item(4, i).Value
                intWhItemQty = WhItemTblDataGridView.Item(5, i).Value
                strWhItemProdID = WhItemTblDataGridView.Item(8, i).Value
                strWhItemRemark = WhItemTblDataGridView.Item(9, i).Value

                NewWhAddProdForm.WhAddProdCatComboBox.Text = Trim(strWhItemProdCat)
                NewWhAddProdForm.WhAddProdComboBox.Text = Trim(strWhItemProdName)
                NewWhAddProdForm.WhOutRecRemarkTextBox.Text = Trim(strWhItemRemark)
                NewWhAddProdForm.WhOutRecQtyNumericUpDown.Value = Trim(intWhItemQty)

                boolItemEdit = True

                NewWhAddProdForm.ShowDialog()

            Catch ex As Exception
                FatalError("No item selected")
            End Try
        End If

    End Sub

    Private Sub QuerySearchBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhQuerySearchBtn.Click

        Dim NewWhQuerySearch As New WhQuerySearch
        NewWhQuerySearch.WhQuerySearch_Ref = Me
        NewWhQuerySearch.ShowDialog()

    End Sub

    Private Sub QueryOpenBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhQueryOpenBtn.Click
        Me.OpenQuery()

    End Sub

    Private Sub WhQueryDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles WhQueryDataGridView.CellMouseDoubleClick
        Me.OpenQuery()

    End Sub

    Private Sub OpenQuery()

        Dim WhView As New WhViewForm
        Try
            Dim i As Integer
            i = WhQueryDataGridView.CurrentRow.Index

            strWhViewTranType = WhQueryDataGridView.Item(0, i).Value
            strWhViewDevID = WhQueryDataGridView.Item(1, i).Value
            strWhViewPoID = WhQueryDataGridView.Item(2, i).Value
            strWhViewDevDate = WhQueryDataGridView.Item(3, i).Value
            strWhViewCusType = WhQueryDataGridView.Item(4, i).Value
            strWhViewName = WhQueryDataGridView.Item(5, i).Value
            strWhViewAdd = WhQueryDataGridView.Item(6, i).Value
            strWhViewCtc = WhQueryDataGridView.Item(7, i).Value
            strWhViewProBy = WhQueryDataGridView.Item(9, i).Value
            strWhViewTimeStamp = WhQueryDataGridView.Item(10, i).Value

            WhView.WhViewTranTypeTxtBox.Text = strWhViewTranType
            WhView.WhViewCusTypeTxtBox.Text = strWhViewCusType
            WhView.WhViewDevToTxtBox.Text = strWhViewDevID
            WhView.WhViewAddTxtBox.Text = strWhViewAdd
            WhView.WhViewCtcTxtBox.Text = strWhViewCtc
            WhView.WhViewDevNoTxtBox.Text = strWhViewDevID
            WhView.WhViewPONoTxtBox.Text = strWhViewPoID
            WhView.WhViewDevDateTxtBox.Text = strWhViewDevDate
            WhView.WhViewProByTxtBox.Text = strWhViewProBy
            WhView.WhViewTimeStampTxtBox.Text = strWhViewTimeStamp

            WhView.WhViewDataGridView.DataSource = GetTableData(strWhViewDevID, "WhItemDevID", "WhItemTbl")
            WhView.WhViewDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            WhView.ShowDialog()

        Catch ex As Exception
            FatalError("No item selected")
        End Try

    End Sub

    Private Function GetWhItemTable(intDevID As Integer) As DataSet

        Dim objConn As New SqlClient.SqlConnection(strConnectionString)
        objConn.Open()

        'Create instance of data adapter
        Dim daTable As New SqlClient.SqlDataAdapter("SELECT * FROM WhItemTbl WHERE WhItemDevID=" & intDevID, objConn)

        'Create instance of DataSet
        Dim dsTable As New DataSet("WhItemTbl")
        daTable.FillSchema(dsTable, SchemaType.Source, "WhItemTbl")
        daTable.Fill(dsTable, "WhItemTbl")

        GetWhItemTable = dsTable

    End Function

    Private Sub WhAddHistoryBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddHistoryBtn.Click

        Dim NewWhAddHistoryForm As New WhAddressHistory
        NewWhAddHistoryForm.WhAddHistoryRef = Me
        NewWhAddHistoryForm.ShowDialog()

    End Sub

    Private Sub WhTypeComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles WhTypeComboBox.SelectedIndexChanged

        If WhTypeComboBox.SelectedIndex = 0 Then
            WhAddHistoryBtn.Enabled = False
        Else
            WhAddHistoryBtn.Enabled = True
        End If

    End Sub

    Private Sub WhProdCatComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles WhProdCatComboBox.SelectedIndexChanged

        UpdateProdName()

    End Sub

    Private Sub UpdateProdCat()

        Dim dataSet As New DataSet
        Using connection As New SqlClient.SqlConnection(strConnectionString)

            Dim adapter As New SqlClient.SqlDataAdapter
            adapter.SelectCommand = New SqlClient.SqlCommand("SELECT WhProdCat FROM WhProdTbl WHERE WhProdEnable = 'True' GROUP BY WhProdCat", connection)
            adapter.Fill(dataSet)

            WhProdCatComboBox.DataSource = dataSet.Tables(0)
            WhProdCatComboBox.DisplayMember = "WhProdCat"

        End Using

    End Sub

    Private Sub UpdateProdName()

        strWhOverviewProdCat = WhProdCatComboBox.Text

        Dim dataSet As New DataSet
        Using connection As New SqlClient.SqlConnection(strConnectionString)

            Dim adapter As New SqlClient.SqlDataAdapter

            adapter.SelectCommand = New SqlClient.SqlCommand("SELECT WhProdName FROM WhProdTbl WHERE WhProdCat='" & Trim(strWhOverviewProdCat) & "' AND WhProdEnable = 'True' ORDER BY WhProdName", connection)
            adapter.Fill(dataSet)

            WhProdComboBox.DataSource = dataSet.Tables(0)
            WhProdComboBox.DisplayMember = "WhProdName"

        End Using

    End Sub

    Private Sub TabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged

        Dim intLastSelectedCatIndex As Integer
        Dim intLastSelectedProdIndex As Integer

        If WhProdCatComboBox.SelectedIndex > 0 Then
            intLastSelectedCatIndex = WhProdCatComboBox.SelectedIndex
        End If

        If WhProdComboBox.SelectedIndex > 0 Then
            intLastSelectedProdIndex = WhProdComboBox.SelectedIndex
        End If

        UpdateProdCat()
        UpdateTransaction()
        UpdateProductManager()

        If intLastSelectedCatIndex <> 0 Then
            WhProdCatComboBox.SelectedIndex = intLastSelectedCatIndex
        End If

        If intLastSelectedProdIndex <> 0 Then
            WhProdComboBox.SelectedIndex = intLastSelectedProdIndex
        End If

    End Sub

    Private Sub WhOverviewBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhOverviewBtn.Click

        strWhOverviewProdCat = Me.WhProdCatComboBox.Text
        strWhOverviewProd = Me.WhProdComboBox.Text
        strWhOverviewStartDuration = Me.WhTranStartDateTimePicker.Text
        strWhOverViewEndDuration = Me.WhTranEndDateTimePicker.Text
        strWhOverviewTran = Me.WhTranComboBox.Text

        Dim sqlDateSelect As String

        'Select Case strWhOverviewDuration
        '   Case "This Month"
        'sqlDateSelect = "WhItemDevDate > DateAdd(Month, -1, GETDATE())"
        '    Case "Last Month"
        'sqlDateSelect = "WhItemDevDate > DateAdd(Month, -2, GETDATE())"
        '    Case "Last 3 Months"
        'sqlDateSelect = "WhItemDevDate > DateAdd(Month, -3, GETDATE())"
        '    Case "Last 6 Months"
        'sqlDateSelect = "WhItemDevDate > DateAdd(Month, -6, GETDATE())"
        '    Case "This Year"
        'sqlDateSelect = "WhItemDevDate > DateAdd(Year, -1, GETDATE())"
        '    Case "Last Year"
        'sqlDateSelect = "(WhItemDevDate > DateAdd(Year, -2, GETDATE()) AND WhItemDevDate < DateAdd(Year, -1, GETDATE()))"
        '    Case Else
        'sqlDateSelect = "WhItemDevDate > DateAdd(Year, -10, GETDATE())"
        'End Select

        sqlDateSelect = "(WhItemDevDate >= '" & strWhOverviewStartDuration & "' AND WhItemDevDate <= '" & strWhOverViewEndDuration & "')"

        Dim sqlTranSelect As String

        Select Case strWhOverviewTran
            Case "In"
                sqlTranSelect = "WhItemTranType = 'In'"
            Case "Out"
                sqlTranSelect = "WhItemTranType = 'Out'"
            Case Else
                sqlTranSelect = "(WhItemTranType = 'In' OR WhItemTranType = 'Out')"
        End Select

        Dim myConn As New SqlClient.SqlConnection(strConnectionString)
        Dim myTable As New DataTable()
        Dim myCmd As New SqlClient.SqlCommand()
        myCmd.Connection = myConn
        Dim myQuery As String = "SELECT * FROM WhItemTbl WHERE WhItemProdName = '" & strWhOverviewProd & "' AND " & sqlDateSelect & " AND " & sqlTranSelect
        myCmd.CommandText = myQuery

        Try
            Dim mySearchAdapter As New SqlClient.SqlDataAdapter(myCmd)
            mySearchAdapter.Fill(myTable)

            WhOverviewDataGridView.DataSource = myTable
            WhOverviewDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        Catch ex As Exception

        End Try

        'Calculate volume
        Dim intIn As Integer
        Dim intOut As Integer
        Dim intBalance As Integer

        intIn = GetSQLValue("SELECT SUM(WhItemQty) FROM WhItemTbl WHERE WhItemProdName = '" & strWhOverviewProd & "' AND " & sqlDateSelect & " AND WhItemTranType = 'In'")
        intOut = GetSQLValue("SELECT SUM(WhItemQty) FROM WhItemTbl WHERE WhItemProdName = '" & strWhOverviewProd & "' AND " & sqlDateSelect & " AND WhItemTranType = 'Out'")
        intBalance = intIn - intOut


        WhProdInTextBox.Text = intIn
        WhProdOutTextBox.Text = intOut
        WhProdBalancelTextBox.Text = intBalance

    End Sub

    Private Sub WhOverviewDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles WhOverviewDataGridView.CellMouseDoubleClick
        'Me.OpenContent()

    End Sub

    Private Sub OpenOverView()

        Dim WhView As New WhViewForm
        Try
            Dim i As Integer
            Dim strDevID As String
            i = WhOverviewDataGridView.CurrentRow.Index

            strDevID = WhOverviewDataGridView.Item(0, i).Value

            WhView.WhViewTranTypeTxtBox.Text = strWhViewTranType
            WhView.WhViewCusTypeTxtBox.Text = strWhViewCusType
            WhView.WhViewDevToTxtBox.Text = strWhViewDevID
            WhView.WhViewAddTxtBox.Text = strWhViewAdd
            'WhView.WhViewCtcTxtBox.Text = strWhViewCtcType
            WhView.WhViewDevNoTxtBox.Text = strWhViewDevID
            WhView.WhViewPONoTxtBox.Text = strWhViewPoID
            WhView.WhViewProByTxtBox.Text = strWhViewProBy
            WhView.WhViewTimeStampTxtBox.Text = strWhViewTimeStamp

            WhView.WhViewDataGridView.DataSource = GetTableData(strWhViewDevID, "WhItemDevID", "WhItemTbl")

            WhView.ShowDialog()

        Catch ex As Exception
            FatalError("No item selected")
        End Try

    End Sub

    Private Sub WhQueryRefreshBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhQueryRefreshBtn.Click
        DisplayTransaction()
        UpdateTransaction()

    End Sub

    Private Sub WhQueryDeleteBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhQueryDeleteBtn.Click

        Dim i As Integer
        Dim boolOverwriteLock As Boolean = False
        Dim boolCheckDel As Boolean = False

        If WhQueryDataGridView.CurrentRow Is Nothing Then

        Else
            i = WhQueryDataGridView.CurrentRow.Index
            intWhDevID = WhQueryDataGridView.Item(1, i).Value
            boolWhLock = WhQueryDataGridView.Item(12, i).Value
            strWhLockUser = WhQueryDataGridView.Item(11, i).Value.ToString

            If boolWhLock = True Then
                If Question("Record is currently open by: " & strWhLockUser & ". Do you want to continue delete this record?") = True Then
                    boolOverwriteLock = True
                End If
            Else
                If Question("Record will be deleted. Are you sure?") = True Then
                    boolCheckDel = True
                End If
            End If

            If boolOverwriteLock = True Or boolCheckDel = True Then

                Dim DataSet As DataSet
                DataSet = FillDataSet("WhTbl", True)

                Dim DataRow As DataRow
                DataRow = DataSet.Tables("WhTbl").Rows.Find(intWhDevID)


                DataRow.Delete()

                SaveDataSet(DataSet, "WhTbl")

                'Update Item History
                DataSet = FillDataSet("WhItemTbl", True)

                For Each DataRow In DataSet.Tables("WhItemTbl").Rows
                    If DataRow("WhItemDevID") = intWhDevID Then
                        DataRow.Delete()
                    End If
                Next

                SaveDataSet(DataSet, "WhItemTbl")

                Confirmation("Record Deleted")

                DisplayTransaction()

            End If
        End If

    End Sub

    Private Sub WhQueryEditBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhQueryEditBtn.Click

        Dim i As Integer

        If WhQueryDataGridView.CurrentRow Is Nothing Then

        Else
            TabControl.SelectedTab = OutgoingPage

            i = WhQueryDataGridView.CurrentRow.Index
            strWhTranType = WhQueryDataGridView.Item(0, i).Value
            intWhDevID = WhQueryDataGridView.Item(1, i).Value
            strWhPoID = WhQueryDataGridView.Item(2, i).Value
            datWhTime = WhQueryDataGridView.Item(3, i).Value
            strWhCtcType = WhQueryDataGridView.Item(4, i).Value
            strWhName = WhQueryDataGridView.Item(5, i).Value
            strWhAdd = WhQueryDataGridView.Item(6, i).Value
            strWhCtc = WhQueryDataGridView.Item(7, i).Value
            intWhCounter = WhQueryDataGridView.Item(8, i).Value

            'Lock Records
            Dim DataSet As DataSet
            DataSet = FillDataSet("WhTbl", True)

            Dim DataRow As DataRow
            DataRow = DataSet.Tables("WhTbl").Rows.Find(intWhDevID)
            DataRow.BeginEdit()
            DataRow("WhLock") = True
            DataRow.EndEdit()

            SaveDataSet(DataSet, "WhTbl")

            Me.WhProByTextBox.Text = strGlobalLogin

            WhTranTypeComboBox.Enabled = True
            WhPoIDTextBox.Enabled = True
            WhDateDateTimePicker.Enabled = True
            WhTypeComboBox.Enabled = True
            WhNameTextBox.Enabled = True
            WhAddTextBox.Enabled = True
            WhCtcTextBox.Enabled = True

            WhAddBtn.Enabled = False
            WhCancelBtn.Enabled = True
            WhSaveBtn.Enabled = True
            WhAddProdBtn.Enabled = True
            WhRemoveProdBtn.Enabled = True
            WhOpenProdBtn.Enabled = True
            WhAddHistoryBtn.Enabled = False

            boolWhEdit = True

            WhQueryEditBtn.Enabled = False

            WhTranComboBox.Text = strWhTranType
            WhDevIDTextBox.Text = intWhDevID
            WhPoIDTextBox.Text = strWhPoID
            WhDateDateTimePicker.Value = datWhTime
            WhTypeComboBox.Text = strWhCtcType
            WhNameTextBox.Text = strWhName
            WhAddTextBox.Text = strWhAdd
            WhCtcTextBox.Text = strWhCtc

            WhPoIDTextBox.BackColor = Color.LightGreen
            WhNameTextBox.BackColor = Color.LightGreen

            WhItemTblDataGridView.DataSource = GetTableData(intWhDevID, "WhItemDevID", "WhItemTbl")
            WhItemTblDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

        End If

    End Sub

    Private Sub WhTranStartDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles WhTranStartDateTimePicker.ValueChanged

        WhTranEndDateTimePicker.Value = WhTranStartDateTimePicker.Value

    End Sub

    Private Sub WhOverviewDetailBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhOverviewDetailBtn.Click

        Dim NewWhSumQuery As New WhSumQuery
        NewWhSumQuery.ShowDialog()

    End Sub

    Private Sub WhQueryApproveBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhQueryApproveBtn.Click

        If WhQueryDataGridView.CurrentRow Is Nothing Then

        Else
            Dim intDeliveryID As Integer

            Dim DataSet As DataSet
            DataSet = FillDataSet("WhTbl", True)

            For i As Integer = 0 To WhQueryDataGridView.Rows.Count - 1
                If WhQueryDataGridView.Rows(i).Selected = True Then
                    If WhQueryDataGridView.Rows(i).Cells(13).Value = True Then

                        intDeliveryID = WhQueryDataGridView.Rows(i).Cells(1).Value

                        For Each DataRow In DataSet.Tables("WhTbl").Rows
                            If DataRow("WhDevID") = intDeliveryID Then
                                DataRow.BeginEdit()
                                DataRow("WhEdit") = False
                                DataRow.EndEdit()
                            End If
                        Next

                        SaveDataSet(DataSet, "WhTbl")

                        intDeliveryID = Nothing

                    End If
                End If
            Next

            Dim myConn As New SqlClient.SqlConnection(strConnectionString)
            Dim myTable As New DataTable()
            Dim myCmd As New SqlClient.SqlCommand()

            myCmd.Connection = myConn
            myCmd.CommandText = sqlCurrentView

            Try
                Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
                myAdapter.Fill(myTable)
                WhQueryDataGridView.DataSource = myTable

            Catch ex As Exception
                FatalError("Error retriving data from Database")
            End Try

            UpdateTransaction()

        End If
 

    End Sub

    Private Sub WhEnableBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhEnableBtn.Click

        If WhProdManDataGridView.CurrentRow Is Nothing Then

        Else
            Dim intProdID As Integer

            Dim DataSet As DataSet
            DataSet = FillDataSet("WhProdTbl", True)

            For i As Integer = 0 To WhProdManDataGridView.Rows.Count - 1
                If WhProdManDataGridView.Rows(i).Selected = True Then

                    If WhProdManDataGridView.Rows(i).Cells(7).Value = False Then

                        intProdID = WhProdManDataGridView.Rows(i).Cells(0).Value

                        For Each DataRow In DataSet.Tables("WhProdTbl").Rows
                            If DataRow("WhProdID") = intProdID Then
                                DataRow.BeginEdit()
                                DataRow("WhProdEnable") = True
                                DataRow.EndEdit()
                            End If
                        Next

                    End If
                End If
            Next

            SaveDataSet(DataSet, "WhProdTbl")

        End If

        UpdateProductManager()

    End Sub

    Private Sub WhDisableBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhDisableBtn.Click

        If WhProdManDataGridView.CurrentRow Is Nothing Then

        Else
            Dim intProdID As Integer

            Dim DataSet As DataSet
            DataSet = FillDataSet("WhProdTbl", True)

            For i As Integer = 0 To WhProdManDataGridView.Rows.Count - 1
                If WhProdManDataGridView.Rows(i).Selected = True Then

                    If WhProdManDataGridView.Rows(i).Cells(7).Value = True Then

                        intProdID = WhProdManDataGridView.Rows(i).Cells(0).Value

                        For Each DataRow In DataSet.Tables("WhProdTbl").Rows
                            If DataRow("WhProdID") = intProdID Then
                                DataRow.BeginEdit()
                                DataRow("WhProdEnable") = False
                                DataRow.EndEdit()
                            End If
                        Next

                    End If
                End If
            Next

            SaveDataSet(DataSet, "WhProdTbl")

        End If

        UpdateProductManager()

    End Sub

    Private Sub WhQueryApproveAllBtn_Click(sender As System.Object, e As System.EventArgs)

        Dim intDeliveryID As Integer

        Dim DataSet As DataSet
        DataSet = FillDataSet("WhTbl", True)

        For i As Integer = 0 To WhQueryDataGridView.Rows.Count - 1
            If WhQueryDataGridView.Rows(i).Cells(13).Value = True Then

                intDeliveryID = WhQueryDataGridView.Rows(i).Cells(1).Value

                For Each DataRow In DataSet.Tables("WhTbl").Rows
                    If DataRow("WhDevID") = intDeliveryID Then
                        DataRow.BeginEdit()
                        DataRow("WhEdit") = False
                        DataRow.EndEdit()
                    End If
                Next

            End If
        Next

        SaveDataSet(DataSet, "WhTbl")

        Dim myConn As New SqlClient.SqlConnection(strConnectionString)
        Dim myTable As New DataTable()
        Dim myCmd As New SqlClient.SqlCommand()

        myCmd.Connection = myConn
        myCmd.CommandText = sqlCurrentView

        Try
            Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
            myAdapter.Fill(myTable)
            WhQueryDataGridView.DataSource = myTable

        Catch ex As Exception
            FatalError("Error retriving data from Database")
        End Try

        UpdateTransaction()

    End Sub
End Class