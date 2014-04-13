Public Class ReportConfigProdForm

    Private Sub ReportConfigProdForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CfgNameComboBox.SelectedIndex = 0
        CfgSaleVolComboBox.SelectedIndex = 0

        CfgFindProdBtn.Enabled = False

        CfgTotRevFromTextBox.Enabled = False
        CfgTotRevToTextBox.Enabled = False

    End Sub

    Private Sub CfgFindProdBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgFindProdBtn.Click

        ReportProdAddProductForm.ShowDialog()

    End Sub

    Private Sub CfgSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgSaveBtn.Click

        Dim sqlSelect As String
        Dim sqlFrom As String
        Dim sqlWhere As String
        Dim sqlOrder As String
        Dim sqlTmp As String

        Dim boolSaleVolUnion As Boolean
        Dim sqlSaleVolUnion As String
        Dim sqlSaleVolUnionSwap As String

        Dim boolTotRevUnion As Boolean
        Dim sqlTotRevUnion As String
        Dim sqlTotRevUnionSwap As String

        Dim boolSaleRevUnion As Boolean
        Dim sqlSaleRevUnion As String

        sqlSelect = " DISTINCT Prod.ProdID AS 'Product ID',"
        sqlFrom = " ProdTbl AS Prod,"
        'sqlFrom = " MemTbl as Mem, PurTbl as Pur, ClsTbl as Cls,"
        sqlWhere = ""
        'sqlWhere = " (Mem.MemID=Pur.PurMemID) AND (Mem.MemID=Cls.ClsMemID) AND"
        sqlOrder = ""
        sqlTmp = ""

        sqlSaleVolUnion = ""
        sqlSaleVolUnionSwap = ""

        sqlTotRevUnion = ""
        sqlTotRevUnionSwap = ""

        sqlSaleRevUnion = ""

        boolRptError = False

        If Me.CfgNameChkBox.Checked = True And boolRptError = False Then

            sqlSelect = sqlSelect & " Prod.ProdName AS 'Product Name',"

            If Me.CfgNameComboBox.Text = "All" Then

            Else
                If strProdRptSelectedProd = "" Then
                    FatalError("Product not selected")
                    boolRptError = True

                Else

                    Dim arrSelectedProd() As String
                    arrSelectedProd = Split(strProdRptSelectedProd, "|")

                    sqlTmp = " ("

                    For i = 0 To UBound(arrSelectedProd)
                        sqlTmp = sqlTmp & " Prod.ProdName='" & arrSelectedProd(i) & "' OR"
                    Next

                    sqlTmp = Microsoft.VisualBasic.Left(sqlTmp, (Len(sqlTmp) - 2))

                    sqlTmp = sqlTmp & ")"


                    If Me.CfgNameChkBox.Text = "Not In" Then
                        sqlWhere = sqlWhere & " Not (" & sqlTmp & ") AND"
                    Else
                        sqlWhere = sqlWhere & sqlTmp & " AND"
                    End If

                    sqlTmp = Nothing

                End If

            End If
        End If

        If Me.CfgPriceChkBox.Checked = True And boolRptError = False Then

            sqlSelect = sqlSelect & " '$' + CONVERT(VARCHAR, Prod.ProdPrice, 0) AS 'Price',"

        End If

        If Me.CfgWarrChkBox.Checked = True And boolRptError = False Then

            sqlSelect = sqlSelect & " Prod.ProdWarranty AS 'Warranty Period',"

        End If

        If Me.CfgSaleVolChkBox.Checked = True And boolRptError = False Then

            Dim SaleVolDateLow As Date
            Dim SaleVolDateHigh As Date

            Dim dateToday = Today.Date

            sqlSelect = sqlSelect & " TotUnit.TotalUnitSold as 'Total Unit Sold',"

            If InStr(sqlFrom, "AS Prod,") = 0 Then
                sqlFrom = sqlFrom & " ProdTbl AS Prod,"
            End If

            If InStr(sqlWhere, "TotUnit.ProdID=Prod.ProdID") = 0 Then
                sqlWhere = sqlWhere & " (TotUnit.ProdID=Prod.ProdID) AND"
            End If

            If CfgSaleVolComboBox.Text = "From Start" Then
                If InStr(sqlFrom, "AS TotUnit,") = 0 Then
                    sqlFrom = sqlFrom & " (SELECT Prod.ProdID, SUM(Pur.PurQty) as 'TotalUnitSold' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) GROUP BY Prod.ProdID) AS TotUnit,"
                    boolSaleVolUnion = True
                    sqlSaleVolUnionSwap = "(SELECT Prod.ProdID, SUM(Pur.PurQty) as 'TotalUnitSold' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) GROUP BY Prod.ProdID) AS TotUnit|(SELECT Prod.ProdID, 'TotalUnitSold'=0 FROM ProdTbl AS Prod WHERE Prod.ProdID NOT IN (SELECT DISTINCT PurProdID FROM PurTbl)) AS TotUnit"
                End If
            Else
                Select Case CfgSaleVolComboBox.Text
                    Case "This Month"
                        SaleVolDateLow = dateToday
                        SaleVolDateHigh = dateToday.AddMonths(-1)
                    Case "Last 2 Months"
                        SaleVolDateLow = dateToday
                        SaleVolDateHigh = dateToday.AddMonths(-2)
                    Case "Last 3 Months"
                        SaleVolDateLow = dateToday
                        SaleVolDateHigh = dateToday.AddMonths(-3)
                    Case "Last 6 Months"
                        SaleVolDateLow = dateToday
                        SaleVolDateHigh = dateToday.AddMonths(-6)
                    Case "Last 1 Year"
                        SaleVolDateLow = dateToday
                        SaleVolDateHigh = dateToday.AddMonths(-12)
                End Select

                If InStr(sqlFrom, "AS TotUnit,") = 0 Then
                    sqlFrom = sqlFrom & " (SELECT Prod.ProdID, SUM(Pur.PurQty) as 'TotalUnitSold' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) AND (Pur.PurDate<='" & SaleVolDateLow & "' And Pur.PurDate>='" & SaleVolDateHigh & "') GROUP BY Prod.ProdID) AS TotUnit,"
                End If

                boolSaleVolUnion = True
                sqlSaleVolUnionSwap = "(SELECT Prod.ProdID, SUM(Pur.PurQty) as 'TotalUnitSold' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) AND (Pur.PurDate<='" & SaleVolDateLow & "' And Pur.PurDate>='" & SaleVolDateHigh & "') GROUP BY Prod.ProdID) AS TotUnit|(SELECT Prod.ProdID, 'TotalUnitSold'=0 FROM ProdTbl AS Prod WHERE Prod.ProdID NOT IN(SELECT Pur.PurProdID FROM PurTbl AS Pur WHERE Pur.PurDate<='" & SaleVolDateLow & "' And Pur.PurDate>='" & SaleVolDateHigh & "') GROUP BY Prod.ProdID) AS TotUnit"

            End If

            If InStr(sqlOrder, "Prod.ProdID") = 0 Then
                sqlOrder = sqlOrder & " Prod.ProdID,"
            End If

        End If

        If Me.CfgTotRevChkBox.Checked = True And boolRptError = False Then

            If CfgTotRevRangeChkBox.Checked = True Then

                If CfgTotRevFromTextBox.Text = "" Or CfgTotRevToTextBox.Text = "" Then
                    FatalError("Please specify range for selection in Product Total Revenue")
                    boolRptError = True
                Else

                    If Not IsNumeric(CfgTotRevFromTextBox.Text) Or Not IsNumeric(CfgTotRevToTextBox.Text) Then
                        FatalError("Please enter only numeric for Product Total Revenue")
                        boolRptError = True

                    Else

                        Dim ProdTotRevLow As Integer = CfgTotRevFromTextBox.Text
                        Dim ProdtotRevHigh As Integer = CfgTotRevToTextBox.Text

                        sqlWhere = sqlWhere & " (TotRev.TotalRevenue>=" & ProdTotRevLow & " AND TotRev.TotalRevenue<=" & ProdtotRevHigh & ") AND"

                    End If

                End If

            End If

            If InStr(1, sqlSelect, "DISTINCT Mem.MemID") = 0 Then
                sqlSelect = sqlSelect.Replace("Mem.MemID", "DISTINCT Mem.MemID")
            End If

            sqlSelect = sqlSelect & " '$' + CONVERT(VARCHAR, TotRev.TotalRevenue, 0) as 'Total Unit Revenue',"

            sqlWhere = sqlWhere & " (TotRev.ProdID=Prod.ProdID) AND"

            If InStr(sqlFrom, "AS TotRev,") = 0 Then
                sqlFrom = sqlFrom & " (SELECT Prod.ProdID, SUM(Pur.PurAmt) As 'TotalRevenue' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) GROUP BY Prod.ProdID) AS TotRev,"
            End If

            boolTotRevUnion = True
            sqlTotRevUnionSwap = "(SELECT Prod.ProdID, SUM(Pur.PurAmt) As 'TotalRevenue' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) GROUP BY Prod.ProdID) AS TotRev|(SELECT Prod.ProdID, 'TotalRevenue'='0.00' FROM ProdTbl AS Prod WHERE Prod.ProdID NOT IN (SELECT DISTINCT PurProdID FROM PurTbl)) AS TotRev"

        End If

        If Me.CfgSaleVolChkBox.Checked = True And Me.CfgTotRevChkBox.Checked = True And boolRptError = False Then
            boolSaleRevUnion = True
        End If

        If boolRptError = False Then

            Dim arrUnion() As String

            sqlSelect = Microsoft.VisualBasic.Left(sqlSelect, (Len(sqlSelect) - 1))
            sqlFrom = Microsoft.VisualBasic.Left(sqlFrom, (Len(sqlFrom) - 1))

            sqlQuery = "SELECT" & sqlSelect & " FROM" & sqlFrom

            If sqlWhere <> "" Then
                sqlWhere = Microsoft.VisualBasic.Left(sqlWhere, (Len(sqlWhere) - 4))
                sqlQuery = sqlQuery & " WHERE" & sqlWhere
            End If

            If boolSaleVolUnion = True Then

                arrUnion = Split(sqlSaleVolUnionSwap, "|")
                sqlSaleVolUnion = " SELECT" & sqlSelect & " FROM" & sqlFrom & " WHERE" & sqlWhere
                sqlSaleVolUnion = sqlSaleVolUnion.Replace(arrUnion(0), arrUnion(1))
                sqlQuery = sqlQuery & " UNION ALL" & sqlSaleVolUnion

            End If

            If boolTotRevUnion = True Then

                arrUnion = Split(sqlTotRevUnionSwap, "|")
                sqlTotRevUnion = " SELECT" & sqlSelect & " FROM" & sqlFrom & " WHERE" & sqlWhere
                sqlTotRevUnion = sqlTotRevUnion.Replace(arrUnion(0), arrUnion(1))
                sqlQuery = sqlQuery & " UNION ALL" & sqlTotRevUnion

            End If

            If boolSaleRevUnion = True Then

                Dim arrSaleUnion() As String
                Dim arrRevUnion() As String

                arrSaleUnion = Split(sqlSaleVolUnionSwap, "|")
                arrRevUnion = Split(sqlTotRevUnionSwap, "|")

                sqlSaleRevUnion = " SELECT" & sqlSelect & " FROM" & sqlFrom & " WHERE" & sqlWhere
                sqlSaleRevUnion = sqlSaleRevUnion.Replace(arrSaleUnion(0), arrSaleUnion(1))
                sqlSaleRevUnion = sqlSaleRevUnion.Replace(arrRevUnion(0), arrRevUnion(1))

                sqlQuery = sqlQuery & " UNION ALL" & sqlSaleRevUnion

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
                ReportForm.ShowDialog()

                'LoadQuery = True
            Catch ex As Exception
                FatalError("Syntax error in SQL, Please contact your IT support")
                'LoadQuery = False
            End Try
        End If

    End Sub

    Private Sub CfgNameComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CfgNameComboBox.SelectedIndexChanged

        If CfgNameComboBox.Text = "All" Then
            CfgFindProdBtn.Enabled = False
        Else
            CfgFindProdBtn.Enabled = True
        End If

    End Sub

    Private Sub CfgTotRevRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgTotRevRangeChkBox.CheckedChanged

        If CfgTotRevRangeChkBox.Checked = True Then
            CfgTotRevFromTextBox.Enabled = True
            CfgTotRevToTextBox.Enabled = True
        Else
            CfgTotRevFromTextBox.Enabled = False
            CfgTotRevToTextBox.Enabled = False
        End If

    End Sub

    Private Sub CfgCanelBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgCanelBtn.Click
        Me.Dispose()

    End Sub
End Class