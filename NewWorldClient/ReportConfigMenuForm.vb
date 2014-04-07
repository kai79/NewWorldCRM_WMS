Public Class ReportConfigMenuForm

    Private Sub ReportConfigClassForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        CfgMenuNameComboBox.SelectedIndex = 0
        CfgClsDateComboBox.SelectedIndex = 0

        CfgFindMenuBtn.Enabled = False

        CfgClsDateComboBox.Enabled = False
        CfgClsDateFromDatePick.Enabled = False
        CfgClsDateToDatePick.Enabled = False

    End Sub

    Private Sub CfgSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgSaveBtn.Click

        Dim sqlSelect As String
        Dim sqlFrom As String
        Dim sqlWhere As String
        Dim sqlOrder As String
        Dim sqlTmp As String

        sqlSelect = " DISTINCT Menu.MenuID AS 'Menu ID',"
        sqlFrom = " MenuTbl as Menu,"
        'sqlFrom = " MemTbl as Mem, PurTbl as Pur, ClsTbl as Cls,"
        sqlWhere = ""
        'sqlWhere = " (Mem.MemID=Pur.PurMemID) AND (Mem.MemID=Cls.ClsMemID) AND"
        sqlOrder = ""
        sqlTmp = ""

        boolRptError = False

        If CfgNameChkBox.Checked = True And boolMenuRptError = False Then

            If CfgMenuNameComboBox.Text = "All" Then
                sqlSelect = sqlSelect & " Menu.MenuName AS 'Menu Name',"
            Else

                If strMenuRptSelectedMenu = "" Then
                    FatalError("Menu not selected")
                    boolMenuRptError = True

                Else

                    Dim arrSelectedMenu() As String
                    arrSelectedMenu = Split(strMenuRptSelectedMenu, "|")

                    sqlTmp = " ("

                    For i = 0 To UBound(arrSelectedMenu)
                        sqlTmp = sqlTmp & " Menu.MenuName='" & arrSelectedMenu(i) & "' OR"
                    Next

                    sqlTmp = Microsoft.VisualBasic.Left(sqlTmp, (Len(sqlTmp) - 2))

                    sqlTmp = sqlTmp & ")"

                    sqlSelect = sqlSelect & " Menu.MenuName AS 'Menu Name',"

                    If CfgMenuNameComboBox.Text = "Not In" Then
                        sqlWhere = sqlWhere & " NOT(" & sqlTmp & ") AND"
                    Else
                        sqlWhere = sqlWhere & sqlTmp & " AND"
                    End If

                End If

            End If

        End If

        If CfgClsDateChkBox.Checked = True And boolMenuRptError = False Then

            If CfgClsDateRangeChkBox.Checked = True Then

                Dim ClsDateLow As Date = CfgClsDateFromDatePick.Text
                Dim ClsDateHigh As Date = CfgClsDateToDatePick.Text

                sqlWhere = sqlWhere & " (Cls.ClsDate>='" & ClsDateLow & "' AND Cls.ClsDate<='" & ClsDateHigh & "') AND"

            End If

            sqlSelect = sqlSelect & " Cls.ClsDate as 'Class Date',"

            If InStr(sqlFrom, "AS Cls,") = 0 Then
                sqlFrom = sqlFrom & " ClsTbl AS Cls,"
            End If

            If InStr(sqlWhere, "Menu.MenuID=Cls.ClsMenuID") = 0 Then
                sqlWhere = sqlWhere & " (Menu.MenuID=Cls.ClsMenuID) AND"
            End If

            If CfgClsDateComboBox.Text = "Not In" Then
                sqlWhere = "NOT " & sqlWhere
            End If

        End If

        If CfgClsPartChkBox.Checked = True And boolMenuRptError = False Then

            sqlSelect = sqlSelect & "ClsPart.ClassPart as 'Class Participants',"

            If InStr(sqlFrom, "AS ClsPart,") = 0 Then
                sqlFrom = sqlFrom & " (select Distinct ClsMenuID, ClsDate, COUNT(Distinct  ClsMemID) as 'ClassPart' from ClsTbl group by ClsDate, ClsMenuID) as ClsPart,"
            End If

            If InStr(sqlFrom, "AS Cls,") = 0 Then
                sqlFrom = sqlFrom & " ClsTbl AS Cls,"
            End If

            If InStr(sqlWhere, "Menu.MenuID = ClsPart.ClsMenuID") = 0 Then
                sqlWhere = sqlWhere & " (Menu.MenuID = ClsPart.ClsMenuID) AND"
            End If

            If InStr(sqlWhere, "Menu.MenuID=Cls.ClsMenuID") = 0 Then
                sqlWhere = sqlWhere & " (Menu.MenuID=Cls.ClsMenuID) AND"
            End If

            If InStr(sqlWhere, "Cls.ClsDate = ClsPart.ClsDate") = 0 Then
                sqlWhere = sqlWhere & " (Cls.ClsDate = ClsPart.ClsDate) AND"
            End If

        End If


        If CfgTotPartChkBox.Checked = True And boolMenuRptError = False Then

            sqlSelect = sqlSelect & " PartTot.Participants as 'Total Participants',"

            If InStr(sqlFrom, "AS PartTot,") = 0 Then
                sqlFrom = sqlFrom & " (select Class.ClsMenuID, COUNT(Class.ClsMenuName) as 'Participants' from ClsTbl AS Class group by Class.ClsMenuID) as PartTot,"
            End If

            If InStr(sqlWhere, "PartTot.ClsMenuID = Menu.MenuID") = 0 Then
                sqlWhere = sqlWhere & " (PartTot.ClsMenuID = Menu.MenuID) AND"
            End If

        End If

        If CfgClsTotCntChkBox.Checked = True And boolMenuRptError = False Then

            sqlSelect = sqlSelect & " ClsTot.Conducted as 'Session Conducted',"

            If InStr(sqlFrom, "AS ClsTot,") = 0 Then
                sqlFrom = sqlFrom & " (select Distinct ClsMenuID, count(Distinct ClsDate) as 'Conducted' from ClsTbl group by ClsMenuID) as ClsTot,"
            End If

            If InStr(sqlWhere, "ClsTot.ClsMenuID = Menu.MenuID") = 0 Then
                sqlWhere = sqlWhere & " (ClsTot.ClsMenuID = Menu.MenuID) AND"
            End If

        End If

        If boolRptError = False Then

            sqlSelect = Microsoft.VisualBasic.Left(sqlSelect, (Len(sqlSelect) - 1))
            sqlFrom = Microsoft.VisualBasic.Left(sqlFrom, (Len(sqlFrom) - 1))

            sqlQuery = "SELECT" & sqlSelect & " FROM" & sqlFrom

            If sqlWhere <> "" Then
                sqlWhere = Microsoft.VisualBasic.Left(sqlWhere, (Len(sqlWhere) - 4))
                sqlQuery = sqlQuery & " WHERE" & sqlWhere
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
                ReportForm.ShowDialog()

                'LoadQuery = True
            Catch ex As Exception
                FatalError("Syntax error in SQL, Please contact your IT support")
                'LoadQuery = False
            End Try
        End If


    End Sub

    Private Sub CfgFindMenuBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgFindMenuBtn.Click
        ReportMenuAddMenuForm.ShowDialog()

    End Sub

    Private Sub CfgMenuNameComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CfgMenuNameComboBox.SelectedIndexChanged

        If CfgMenuNameComboBox.Text = "All" Then
            CfgFindMenuBtn.Enabled = False
        Else
            CfgFindMenuBtn.Enabled = True
        End If

    End Sub

    Private Sub CfgClsDateRangeChkBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CfgClsDateRangeChkBox.CheckedChanged

        If CfgClsDateRangeChkBox.Checked = True Then
            Me.CfgClsDateComboBox.Enabled = True
            Me.CfgClsDateFromDatePick.Enabled = True
            Me.CfgClsDateToDatePick.Enabled = True
        Else
            Me.CfgClsDateComboBox.Enabled = False
            Me.CfgClsDateFromDatePick.Enabled = False
            Me.CfgClsDateToDatePick.Enabled = False
        End If

    End Sub

    Private Sub CfgCanelBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgCanelBtn.Click
        Me.Dispose()

    End Sub
End Class