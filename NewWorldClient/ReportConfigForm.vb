Public Class ReportConfigForm

    Private Sub CfgSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgSaveBtn.Click

        Dim sqlSelect As String
        Dim sqlFrom As String
        Dim sqlWhere As String
        Dim sqlOrder As String
        Dim sqlTmp As String

        Dim boolRefTotUnion As Boolean
        Dim sqlRefTotUnion As String
        Dim sqlRefTotUnionSwap As String

        Dim boolSpdTotUnion As Boolean
        Dim sqlSpdTotUnion As String
        Dim sqlSpdTotUnionSwap As String

        Dim boolSpdRefTotUnion As Boolean
        Dim sqlSpdRefTotUnion As String

        sqlSelect = " DISTINCT Mem.MemID AS 'Member ID',"
        sqlFrom = " MemTbl AS Mem,"
        'sqlFrom = " MemTbl as Mem, PurTbl as Pur, ClsTbl as Cls,"
        sqlWhere = " Mem.MemNRIC IS NOT NULL AND"
        'sqlWhere = " (Mem.MemID=Pur.PurMemID) AND (Mem.MemID=Cls.ClsMemID) AND"
        sqlOrder = ""

        sqlRefTotUnion = ""
        sqlRefTotUnionSwap = ""

        sqlSpdTotUnion = ""
        sqlSpdTotUnionSwap = ""

        sqlSpdRefTotUnion = ""

        sqlTmp = ""

        boolRptError = False

        If CfgMemNameChkBox.Checked = True And boolRptError = False Then
            sqlSelect = sqlSelect & " Mem.MemName AS 'Name',"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgMemAddressChkBox.Checked = True And boolRptError = False Then
            sqlSelect = sqlSelect & " Mem.MemAddress AS 'Address',"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgMemNRICChkBox.Checked = True And boolRptError = False Then
            sqlSelect = sqlSelect & " Mem.MemNRIC AS 'NRIC',"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgMemCtcHomeChkBox.Checked = True And boolRptError = False Then
            sqlSelect = sqlSelect & " Mem.MemCtcHome AS 'Contact(Home)',"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgMemCtcMobChkBox.Checked = True And boolRptError = False Then
            sqlSelect = sqlSelect & " Mem.MemCtcMob AS 'Contact(Mobile)',"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgMemEmail.Checked = True And boolRptError = False Then
            sqlSelect = sqlSelect & " Mem.MemEmail AS 'Email',"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgMemRankChkBox.Checked = True And boolRptError = False Then

            Dim MemRankOutput As New System.Text.StringBuilder
            Dim MemRankSelectedItems As ListBox.SelectedObjectCollection = CfgMemRankListBox.SelectedItems
            Dim MemRankSelectedValue As String

            For i As Integer = 0 To MemRankSelectedItems.Count - 1
                MemRankOutput.Append(MemRankSelectedItems(i))
                If i <> MemRankSelectedItems.Count - 1 Then
                    MemRankOutput.Append("|")
                End If
            Next

            MemRankSelectedValue = MemRankOutput.ToString

            Dim MemRankArray() As String

            If Len(MemRankSelectedValue) > 0 Then
                sqlTmp = " ("
                MemRankArray = Split(MemRankSelectedValue, "|")
                For i = 0 To UBound(MemRankArray)
                    sqlTmp = sqlTmp & " Mem.MemRank='" & MemRankArray(i) & "'" & " OR"
                Next
                sqlTmp = Microsoft.VisualBasic.Left(sqlTmp, (Len(sqlTmp) - 3))
                sqlTmp = sqlTmp & ")"

                If CfgMemRankComboBox.Text = "Not In" Then
                    sqlWhere = sqlWhere & " Mem.MemID NOT IN (SELECT Mem.MemID FROM MemTbl as Mem WHERE " & sqlTmp & ") AND"
                Else
                    sqlWhere = sqlWhere & sqlTmp & " AND"
                End If

            End If

            sqlSelect = sqlSelect & " Mem.MemRank,"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgMemZoneChkBox.Checked = True And boolRptError = False Then

            Dim MemZoneOutput As New System.Text.StringBuilder
            Dim MemZoneSelectedItems As ListBox.SelectedObjectCollection = CfgMemZoneListBox.SelectedItems
            Dim MemZoneSelectedValue As String

            For i As Integer = 0 To MemZoneSelectedItems.Count - 1
                MemZoneOutput.Append(MemZoneSelectedItems(i))
                If i <> MemZoneSelectedItems.Count - 1 Then
                    MemZoneOutput.Append("|")
                End If
            Next

            MemZoneSelectedValue = MemZoneOutput.ToString

            Dim MemZoneArray() As String

            If Len(MemZoneSelectedValue) > 0 Then
                sqlTmp = " ("
                MemZoneArray = Split(MemZoneSelectedValue, "|")
                For i = 0 To UBound(MemZoneArray)
                    sqlTmp = sqlTmp & " Mem.MemZone='" & MemZoneArray(i) & "'" & " OR"
                Next
                sqlTmp = Microsoft.VisualBasic.Left(sqlTmp, (Len(sqlTmp) - 3))
                sqlTmp = sqlTmp & ")"

                If CfgMemZoneComboBox.Text = "Not In" Then
                    sqlWhere = sqlWhere & " Mem.MemID NOT IN (SELECT Mem.MemID FROM MemTbl as Mem WHERE " & sqlTmp & ") AND"
                Else
                    sqlWhere = sqlWhere & sqlTmp & " AND"
                End If

            End If

            sqlSelect = sqlSelect & " Mem.MemZone,"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgJoinDateChkBox.Checked = True And boolRptError = False Then

            sqlSelect = sqlSelect & " Mem.MemDateJoin AS 'Join Date',"

            If InStr(sqlFrom, "AS Mem,") = 0 Then
                sqlFrom = sqlFrom & " MemTbl AS Mem,"
            End If

            If CfgJoinDateRangeChkBox.Checked = True Then

                Dim DatJoinDateLow As Date = CfgJoinDateFromDatePick.Text
                Dim DatJoinDateHigh As Date = CfgjoinDateToDatePick.Text

                If CfgJoinDateComboBox.SelectedIndex = 0 Then
                    'Within
                    sqlWhere = sqlWhere & " (Mem.MemDateJoin>='" & DatJoinDateLow & "' AND Mem.MemDateJoin<='" & DatJoinDateHigh & "') AND"
                Else
                    'Not Within
                    sqlWhere = sqlWhere & " Mem.MemID NOT IN (SELECT DISTINCT MemID FROM MemTbl WHERE (MemDateJoin>='" & DatJoinDateLow & "' AND MemDateJoin<='" & DatJoinDateHigh & "')) AND"
                End If

            End If

        End If

        If CfgTotRefChkBox.Checked = True And boolRptError = False Then

            If CfgTotRefRangeChkBox.Checked = True Then

                If CfgTotRefFromTextBox.Text = "" Or CfgTotRefToTextBox.Text = "" Then
                    FatalError("Please specify range for selection in Member Referred")
                    boolRptError = True
                Else

                    If Not IsNumeric(CfgTotRefFromTextBox.Text) Or Not IsNumeric(CfgTotRefToTextBox.Text) Then
                        FatalError("Please enter only numberic for Member Referred")
                        boolRptError = True
                    Else

                        Dim MemRefCntLow As Integer = CfgTotRefFromTextBox.Text
                        Dim MemRefCntHigh As Integer = CfgTotRefToTextBox.Text

                        sqlWhere = sqlWhere & " (TotRef.RefCount>=" & MemRefCntLow & " AND TotRef.RefCount<=" & MemRefCntHigh & ") AND"
                    End If
                End If

            End If

            If InStr(1, sqlSelect, "DISTINCT Mem.MemID") = 0 Then
                sqlSelect = sqlSelect.Replace("Mem.MemID", "DISTINCT Mem.MemID")
            End If

            sqlSelect = sqlSelect & " TotRef.RefCount AS 'Total Referred',"

            If InStr(sqlFrom, "AS TotRef,") = 0 Then
                sqlFrom = sqlFrom & " (SELECT Mem.MemRefID as 'RefMemID' ,COUNT(*) As 'RefCount' FROM MemTbl AS Mem GROUP BY Mem.MemRefID) AS TotRef,"
            End If

            sqlWhere = sqlWhere & " (Mem.MemID=TotRef.RefMemID) AND"

            boolRefTotUnion = True
            sqlRefTotUnionSwap = "(SELECT Mem.MemRefID as 'RefMemID' ,COUNT(*) As 'RefCount' FROM MemTbl AS Mem GROUP BY Mem.MemRefID) AS TotRef|(SELECT Mem.MemID AS 'RefMemID', 'RefCount'=0 FROM MemTbl AS Mem WHERE Mem.MemID NOT IN (SELECT Mem.MemRefID as 'RefMemID' FROM MemTbl AS Mem)) As TotRef"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgTotSpdChkBox.Checked = True And boolRptError = False Then

            If CfgTotSpdRangeChkBox.Checked = True Then

                If CfgTotSpdFromTextBox.Text = "" Or CfgTotSpdToTextBox.Text = "" Then
                    FatalError("Please specify range for selection in Member Total Spending")
                    boolRptError = True
                Else

                    If Not IsNumeric(CfgTotSpdFromTextBox.Text) Or Not IsNumeric(CfgTotSpdToTextBox.Text) Then
                        FatalError("Please enter only numeric for Member Total Spending selection fields")
                        boolRptError = True
                    Else

                        Dim MemTotAmtLow As Integer = CfgTotSpdFromTextBox.Text
                        Dim MemTotAmtHigh As Integer = CfgTotSpdToTextBox.Text

                        sqlWhere = sqlWhere & " (TotSpd.AmountSum>=" & MemTotAmtLow & " AND TotSpd.AmountSum<=" & MemTotAmtHigh & ") AND"

                    End If
                End If

            End If


            If InStr(1, sqlSelect, "DISTINCT Mem.MemID") = 0 Then
                sqlSelect = sqlSelect.Replace("Mem.MemID", "DISTINCT Mem.MemID")
            End If

            'sqlSelect = sqlSelect & " '$' + CONVERT(VARCHAR, TotSpd.AmountSum, 0) AS 'Total Spend',"
            sqlSelect = sqlSelect & " TotSpd.AmountSum AS 'Total Spend',"

            If InStr(sqlFrom, "AS TotSpd,") = 0 Then
                'sqlFrom = sqlFrom & " (SELECT Mem.MemID as SpdMemID, SUM(Pur.PurAmt) As 'AmountSum' FROM MemTbl AS Mem, PurTbl AS Pur WHERE Mem.MemID = Pur.PurMemID GROUP BY Mem.MemID) AS TotSpd,"
                sqlFrom = sqlFrom & " (SELECT Mem.MemID as SpdMemID, case when SUM(Pur.PurAmt) is NULL then '0' Else SUM(Pur.PurAmt) end As 'AmountSum' FROM MemTbl AS Mem left outer join PurTbl as Pur on Mem.MemID = Pur.PurMemID GROUP BY Mem.MemID) as TotSpd,"
            End If

            sqlWhere = sqlWhere & " (Mem.MemID=TotSpd.SpdMemID) AND"

            'boolSpdTotUnion = True
            'sqlSpdTotUnionSwap = "(SELECT Mem.MemID as SpdMemID, SUM(Pur.PurAmt) As 'AmountSum' FROM MemTbl AS Mem, PurTbl AS Pur WHERE Mem.MemID = Pur.PurMemID GROUP BY Mem.MemID) AS TotSpd|(SELECT Mem.MemID as SpdMemID, 'AmountSum'=0 FROM MemTbl AS Mem, PurTbl AS Pur WHERE Mem.MemID NOT IN (SELECT DISTINCT PurMemID FROM PurTbl)) AS TotSpd"

            If InStr(sqlOrder, "Mem.MemID") = 0 Then
                sqlOrder = sqlOrder & " Mem.MemID,"
            End If

        End If

        If CfgTotSpdChkBox.Checked = True And CfgTotRefChkBox.Checked = True And boolRptError = False Then
            boolSpdRefTotUnion = True
        End If

        If CfgCreditChkBox.Checked = True And boolRptError = False Then

            sqlSelect = sqlSelect & " Mem.MemCredit AS 'Class Credit',"

            If CfgCreditRangeChkBox.Checked = True Then

                Dim intCreditLow As Integer = CfgCreditFromTextBox.Text
                Dim intCreditHigh As Integer = CfgCreditToTextBox.Text

                sqlWhere = sqlWhere & " (Mem.MemCredit>='" & intCreditLow & "' AND Mem.MemCredit<='" & intCreditHigh & "') AND"

            End If

        End If

        If CfgProdNameChkBox.Checked = True And boolRptError = False Then

            If strRptSelectedProd = "" Then
                FatalError("Product not selected")
                boolRptError = True
            Else

                Dim arrSelectedProd() As String
                arrSelectedProd = Split(strRptSelectedProd, "|")

                sqlTmp = " ("

                For i = 0 To UBound(arrSelectedProd)
                    sqlTmp = sqlTmp & " Pur.PurProdName='" & arrSelectedProd(i) & "' OR"

                Next

                sqlTmp = Microsoft.VisualBasic.Left(sqlTmp, (Len(sqlTmp) - 3))

                sqlTmp = sqlTmp & ")"

                If CfgProdNameComboBox.SelectedIndex = 0 Then
                    'Had Purchased

                    If ProdShowInfoChkBox.Checked = True Then
                        sqlSelect = sqlSelect & " Pur.PurProdName AS 'Product Name',"

                    End If

                    If InStr(sqlFrom, "AS Pur,") = 0 Then
                        sqlFrom = sqlFrom & " PurTbl AS Pur,"
                    End If

                    sqlWhere = sqlWhere & sqlTmp & " AND"

                    If InStr(sqlWhere, "Mem.MemID=Pur.PurMemID") = 0 Then
                        sqlWhere = sqlWhere & " (Mem.MemID=Pur.PurMemID) AND"
                    End If
                Else
                    'Had not purchased
                    sqlWhere = sqlWhere & " Mem.MemID NOT IN (SELECT DISTINCT Pur.PurMemID FROM PurTbl AS Pur WHERE" & sqlTmp & ") AND"
                End If

            End If

        End If

        If CfgPurDateChkBox.Checked = True And boolRptError = False And CfgProdNameComboBox.SelectedIndex = 0 And CfgProdNameChkBox.Checked = True Then

            If CfgProdNameComboBox.SelectedIndex = 0 Then

                If ProdShowInfoChkBox.Checked = True Then
                    sqlSelect = sqlSelect & " Pur.PurDate AS 'Purchase Date',"

                End If

                If InStr(sqlFrom, "AS Pur,") = 0 Then
                    sqlFrom = sqlFrom & " PurTbl AS Pur,"
                End If

                If InStr(sqlWhere, "Mem.MemID=Pur.PurMemID") = 0 Then
                    sqlWhere = sqlWhere & " (Mem.MemID=Pur.PurMemID) AND"
                End If

                If CfgPurDateRangeChkBox.Checked = True Then

                    Dim PurDateLow As Date = CfgPurDateFromDatePick.Text
                    Dim PurDateHigh As Date = CfgPurDateToDatePick.Text

                    If CfgPurDateComboBox.SelectedIndex = 0 Then
                        sqlWhere = sqlWhere & " (Pur.PurDate>='" & PurDateLow & "' AND Pur.PurDate<='" & PurDateHigh & "') AND"
                    Else
                        sqlWhere = sqlWhere & " NOT (Pur.PurDate>='" & PurDateLow & "' AND Pur.PurDate<='" & PurDateHigh & "') AND"
                    End If
                End If

            End If
        End If


        If CfgDevStatChkBox.Checked = True And boolRptError = False And CfgProdNameComboBox.SelectedIndex = 0 And CfgProdNameChkBox.Checked = True Then

            If CfgProdNameComboBox.SelectedIndex = 0 Then
                If ProdShowInfoChkBox.Checked = True Then
                    sqlSelect = sqlSelect & " Pur.PurDevStatus AS 'Delivery Status',"

                    If InStr(sqlFrom, "AS Pur,") = 0 Then
                        sqlFrom = sqlFrom & " PurTbl AS Pur,"
                    End If

                    If InStr(sqlWhere, "Mem.MemID=Pur.PurMemID") = 0 Then
                        sqlWhere = sqlWhere & " (Mem.MemID=Pur.PurMemID) AND"
                    End If

                    If CfgDevStatComboBox.SelectedIndex = 1 Then
                        'Show only delivered
                        sqlWhere = sqlWhere & " (Pur.PurDevStatus='Delivered') AND"
                    End If

                    If CfgDevStatComboBox.SelectedIndex = 2 Then
                        'Show non delivered
                        sqlWhere = sqlWhere & " (Pur.PurDevStatus='Non Delivered') AND"
                    End If

                End If
            End If

        End If

        If CfgOrderNoChkBox.Checked = True And boolRptError = False And CfgProdNameComboBox.SelectedIndex = 0 And CfgProdNameChkBox.Checked = True Then

            If ProdShowInfoChkBox.Checked = True Then
                sqlSelect = sqlSelect & " Pur.PurOrderNo AS 'Order No',"

                If InStr(sqlFrom, "AS Pur,") = 0 Then
                    sqlFrom = sqlFrom & " PurTbl AS Pur,"
                End If
            End If

        End If


        If CfgMenuNameChkBox.Checked = True And boolRptError = False Then

            If strRptSelectedMenu = "" Then
                FatalError("Menu not selected")
                boolRptError = True
            Else

                Dim arrSelectedMenu() As String
                arrSelectedMenu = Split(strRptSelectedMenu, "|")

                sqlTmp = " ("

                For i = 0 To UBound(arrSelectedMenu)
                    sqlTmp = sqlTmp & " Cls.ClsMenuName='" & arrSelectedMenu(i) & "' OR"
                Next

                sqlTmp = Microsoft.VisualBasic.Left(sqlTmp, (Len(sqlTmp) - 2))

                sqlTmp = sqlTmp & ")"

                If CfgMenuNameComboBox.SelectedIndex = 0 Then
                    'Who had attended

                    If MenuShowInfoChkBox.Checked = True Then
                        sqlSelect = sqlSelect & " Cls.ClsMenuName AS 'Menu Name',"

                    End If

                    If InStr(sqlFrom, "AS Cls,") = 0 Then
                        sqlFrom = sqlFrom & " ClsTbl AS Cls,"
                    End If

                    sqlWhere = sqlWhere & sqlTmp & " AND"

                    If InStr(sqlWhere, "Mem.MemID=Cls.ClsMemID") = 0 Then
                        sqlWhere = sqlWhere & " (Mem.MemID=Cls.ClsMemID) AND"
                    End If
                Else
                    'Who had not attended
                    sqlWhere = sqlWhere & " Mem.MemID NOT IN (SELECT Cls.ClsMemID FROM ClsTbl AS Cls WHERE " & sqlTmp & " GROUP BY Cls.ClsMemID) AND"
                End If
            End If

        End If

        If CfgClsDateChkBox.Checked = True And boolRptError = False And CfgMenuNameComboBox.SelectedIndex = 0 And CfgMenuNameChkBox.Checked = True Then


            If MenuShowInfoChkBox.Checked = True Then
                sqlSelect = sqlSelect & " Cls.ClsDate as 'Attended Class Date',"

            End If

            If InStr(sqlFrom, "AS Cls,") = 0 Then
                sqlFrom = sqlFrom & " ClsTbl AS Cls,"
            End If

            If MenuShowInfoChkBox.Checked = True Then
                If InStr(sqlWhere, "Mem.MemID=Cls.ClsMemID") = 0 Then
                    sqlWhere = sqlWhere & " (Mem.MemID=Cls.ClsMemID) AND"
                End If
            End If

            If CfgClsDateRangeChkBox.Checked = True Then

                Dim ClsDateLow As Date = CfgClsDateFromDatePick.Text
                Dim ClsDateHigh As Date = CfgClsDateToDatePick.Text

                'Within
                If CfgClsDateComboBox.SelectedIndex = 0 Then
                    sqlWhere = sqlWhere & " (Cls.ClsDate>='" & ClsDateLow & "' AND Cls.ClsDate<='" & ClsDateHigh & "') AND"
                Else
                    sqlWhere = sqlWhere & " NOT (Cls.ClsDate>='" & ClsDateLow & "' AND Cls.ClsDate<='" & ClsDateHigh & "') AND"
                End If
            End If
        End If

        If boolRptError = False Then

            'Dim sqlQuery As String

            sqlSelect = Microsoft.VisualBasic.Left(sqlSelect, (Len(sqlSelect) - 1))
            sqlFrom = Microsoft.VisualBasic.Left(sqlFrom, (Len(sqlFrom) - 1))

            sqlQuery = "SELECT" & sqlSelect & " FROM" & sqlFrom

            If sqlWhere <> "" Then
                sqlWhere = Microsoft.VisualBasic.Left(sqlWhere, (Len(sqlWhere) - 4))
                sqlQuery = sqlQuery & " WHERE" & sqlWhere
            End If

            Dim arrUnion() As String

            If boolRefTotUnion = True Then

                arrUnion = Split(sqlRefTotUnionSwap, "|")
                sqlRefTotUnion = " SELECT" & sqlSelect & " FROM" & sqlFrom & " WHERE" & sqlWhere
                sqlRefTotUnion = sqlRefTotUnion.Replace(arrUnion(0), arrUnion(1))

                sqlQuery = sqlQuery & " UNION ALL" & sqlRefTotUnion

            End If

            If boolSpdTotUnion = True Then

                arrUnion = Split(sqlSpdTotUnionSwap, "|")
                sqlSpdTotUnion = " SELECT" & sqlSelect & " FROM" & sqlFrom & " WHERE" & sqlWhere
                sqlSpdTotUnion = sqlSpdTotUnion.Replace(arrUnion(0), arrUnion(1))

                sqlQuery = sqlQuery & " UNION ALL" & sqlSpdTotUnion

            End If

            If boolSpdRefTotUnion = True Then

                Dim arrSpdUnion() As String
                Dim arrRefUnion() As String

                arrSpdUnion = Split(sqlSpdTotUnionSwap, "|")
                arrRefUnion = Split(sqlRefTotUnionSwap, "|")

                sqlSpdRefTotUnion = " SELECT" & sqlSelect & " FROM" & sqlFrom & " WHERE" & sqlWhere
                sqlSpdRefTotUnion = sqlSpdRefTotUnion.Replace(arrSpdUnion(0), arrSpdUnion(1))
                sqlSpdRefTotUnion = sqlSpdRefTotUnion.Replace(arrRefUnion(0), arrRefUnion(1))

                sqlQuery = sqlQuery & " UNION ALL" & sqlSpdRefTotUnion

            End If

            If sqlOrder <> "" Then
                sqlOrder = Microsoft.VisualBasic.Left(sqlOrder, (Len(sqlOrder) - 1))
                sqlQuery = sqlQuery & " ORDER BY" & sqlOrder
            End If

            Dim myConn As New SqlClient.SqlConnection(strConnectionString)
            Dim myTable As New DataTable()
            Dim myCmd As New SqlClient.SqlCommand()
            myCmd.Connection = myConn
            myCmd.CommandText = sqlQuery

            Try
                Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
                myAdapter.Fill(myTable)

                Dim ReportForm As New ReportForm
                ReportForm.ReportDataGridView.DataSource = myTable
                ReportForm.ReportDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
                ReportForm.ReportToolStripStatusLabel.Text = "Count: " & ReportForm.ReportDataGridView.RowCount

                If CfgTotSpdChkBox.Checked = True Then
                    ReportForm.ReportDataGridView.Columns("Total Spend").DefaultCellStyle.Format = "c"
                End If

                ReportForm.Show()

            Catch ex As Exception
                FatalError("Syntax error in SQL, Please contact your IT support")
            End Try

        End If

    End Sub

    Private Sub ReportConfigForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CfgMemNameChkBox.CheckState = CheckState.Checked

        CfgMemRankComboBox.SelectedIndex = 0
        CfgMemRankListBox.SelectedIndex = 0

        CfgMemZoneComboBox.SelectedIndex = 0
        CfgMemZoneListBox.SelectedIndex = 0

        CfgJoinDateComboBox.SelectedIndex = 0
        CfgJoinDateComboBox.Enabled = False
        CfgJoinDateFromDatePick.Enabled = False
        CfgjoinDateToDatePick.Enabled = False

        CfgTotRefFromTextBox.Enabled = False
        CfgTotRefToTextBox.Enabled = False

        CfgTotSpdFromTextBox.Enabled = False
        CfgTotSpdToTextBox.Enabled = False

        CfgCreditFromTextBox.Enabled = False
        CfgCreditToTextBox.Enabled = False

        ProdShowInfoChkBox.Checked = True
        CfgProdNameComboBox.SelectedIndex = 0

        CfgPurDateComboBox.SelectedIndex = 0
        CfgPurDateComboBox.Enabled = False
        CfgPurDateFromDatePick.Enabled = False
        CfgPurDateToDatePick.Enabled = False

        CfgDevStatComboBox.SelectedIndex = 0

        MenuShowInfoChkBox.Checked = True
        CfgMenuNameComboBox.SelectedIndex = 0

        CfgClsDateComboBox.SelectedIndex = 0
        CfgClsDateComboBox.Enabled = False
        CfgClsDateFromDatePick.Enabled = False
        CfgClsDateToDatePick.Enabled = False

        strRptSelectedMenu = ""
        strRptSelectedProd = ""

    End Sub

    'Public Sub FillTotSpd()

    'Dim objConn As New SqlClient.SqlConnection(strConnectionString)

    'Dim selectCMD As SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT Mem.MemID, SUM(Pur.PurAmt) FROM MemTbl AS Mem, PurTbl AS Pur WHERE Mem.MemID = Pur.PurMemID GROUP BY Mem.MemID", objConn)
    'selectCMD.CommandTimeout = 30

    'Dim dynDA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter
    'dynDA.SelectCommand = selectCMD

    'objConn.Open()

    'Dim dyntotSpdDS As DataSet = New DataSet
    'dynDA.Fill(dyntotSpdDS, "DynTotSpdTbl")
    'objConn.Close()

    'End Sub

    Private Sub CfgFindProdBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgFindProdBtn.Click

        ReportAddProductForm.ShowDialog()

    End Sub

    Private Sub CfgFindMenuBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgFindMenuBtn.Click

        ReportAddMenuForm.ShowDialog()

    End Sub

    Private Sub CfgClsDateRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgClsDateRangeChkBox.CheckedChanged

        If CfgClsDateRangeChkBox.Checked = True Then
            CfgClsDateComboBox.Enabled = True
            CfgClsDateToDatePick.Enabled = True
            CfgClsDateFromDatePick.Enabled = True
        Else
            CfgClsDateComboBox.Enabled = False
            CfgClsDateToDatePick.Enabled = False
            CfgClsDateFromDatePick.Enabled = False
        End If

    End Sub

    Private Sub CfgPurDateRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgPurDateRangeChkBox.CheckedChanged

        If CfgPurDateRangeChkBox.Checked = True Then
            CfgPurDateComboBox.Enabled = True
            CfgPurDateFromDatePick.Enabled = True
            CfgPurDateToDatePick.Enabled = True
        Else
            CfgPurDateComboBox.Enabled = False
            CfgPurDateFromDatePick.Enabled = False
            CfgPurDateToDatePick.Enabled = False
        End If

    End Sub

    Private Sub CfgTotSpdRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgTotSpdRangeChkBox.CheckedChanged

        If CfgTotSpdRangeChkBox.Checked = True Then
            CfgTotSpdFromTextBox.Enabled = True
            CfgTotSpdToTextBox.Enabled = True
        Else
            CfgTotSpdFromTextBox.Enabled = False
            CfgTotSpdToTextBox.Enabled = False
        End If

    End Sub

    Private Sub CfgTotRefRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgTotRefRangeChkBox.CheckedChanged

        If CfgTotRefRangeChkBox.Checked = True Then
            CfgTotRefFromTextBox.Enabled = True
            CfgTotRefToTextBox.Enabled = True
        Else
            CfgTotRefFromTextBox.Enabled = False
            CfgTotRefToTextBox.Enabled = False
        End If

    End Sub

    Private Sub CfgCanelBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgCanelBtn.Click
        Me.Dispose()

    End Sub

    Private Sub ReportConfigForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub CfgJoinDateRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgJoinDateRangeChkBox.CheckedChanged

        If CfgJoinDateRangeChkBox.Checked = True Then
            CfgJoinDateComboBox.Enabled = True
            CfgJoinDateFromDatePick.Enabled = True
            CfgjoinDateToDatePick.Enabled = True
        Else
            CfgJoinDateComboBox.Enabled = False
            CfgJoinDateFromDatePick.Enabled = False
            CfgjoinDateToDatePick.Enabled = False
        End If

    End Sub

    Private Sub CfgCreditRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgCreditRangeChkBox.CheckedChanged

        If CfgCreditRangeChkBox.Checked = True Then
            CfgCreditFromTextBox.Enabled = True
            CfgCreditToTextBox.Enabled = True
        Else
            CfgCreditFromTextBox.Enabled = False
            CfgCreditToTextBox.Enabled = False
        End If

    End Sub

End Class