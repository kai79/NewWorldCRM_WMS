Module Common

    'New World DB
    'Public strConnectionString = "Data Source=SERVER\SQLNEWWORLD;Initial Catalog=NewWorldDB;Persist Security Info=True;User ID=sa;Password=Password0"

    'VM DB
    Public strConnectionString = "Data Source=LIPKAI-8817DDB2\SQLEXPRESS;Initial Catalog=NewWorldDB;Integrated Security=False;Persist Security Info=True;User ID=sa;Password=d3y8mjxy;Encrypt=False"

    'Laptop
    'Public strConnectionString = "Data Source=LIPKAI-LAPTOP\SQLEXPRESSLAPTOP;Initial Catalog=NewWorldDB;Persist Security Info=True;User ID=sa;Password=d3y8mjxy"

    'Warehouse DB
    'Public strConnectionString = "Data Source=NEWWORLDWH-PC\NEWWORLDWHSQL;Initial Catalog=NewWorldDB;Integrated Security=False;Persist Security Info=True;User ID=sa;Password=Password0"

    'Warehouse Report Path
    Public strWhReportPath = "C:\temp\ReportTemplate.dotx"

    'Global variables
    Public intGlobalLoginID As Integer
    Public strGlobalLogin As String
    Public strGlobalLoginType As String
    Public boolResetPassword As Boolean
    Public intResetLoginID As String

    'RootTable variables
    Public intRootID As Integer
    Public strRootName As String
    Public strRootPw As String
    Public strRootType As String

    'UserTable variables
    Public intMemID As Integer
    Public strMemZone As String
    Public strMemReferral As String
    Public intMemReferrralID As Integer
    Public strMemName As String
    Public strMemAddress As String
    Public strMemNRIC As String
    Public strMemContactHome As String
    Public strMemContactMobile As String
    Public strMemEmail As String
    Public strMemRank As String
    Public intMemTotAmt As Integer
    Public DatMemDateJoin As Date
    Public intMemCredit As Integer
    Public boolMemNew As Boolean
    Public boolMemEdit As Boolean
    Public boolMemLock As Boolean
    Public strMemLockUser As String
    'Public boolMemRefresh As Boolean
    Public strOpenMemNRIC As String

    'Member Search variables
    Public NewMemSearchForm As Object
    Public boolMemSearchOpen As Boolean
    Public boolMemFilter As Boolean
    Public MemSelectedColumn As Integer
    Public MemFilterWord As String
    Public MemFilterType As String

    'Purchase Search variables
    Public NewPurSearchForm As Object
    Public boolPurSearchOpen As Boolean
    Public boolPurFilter As Boolean
    Public PurSelectedColumn As Integer
    Public PurFilterWord As String
    Public PurFilterType As String

    'ProductTable variables
    Public intProductID As Integer
    Public strProductName As String
    Public decProductPrice As Decimal
    Public intProductWarranty As Integer
    Public strProductCategory As String
    Public intProductUnitSal As Integer
    Public intProductTotRev As Integer
    Public intProductCredit As Integer
    Public boolProductNew As Boolean
    Public boolProductEdit As Boolean
    Public boolProductLock As Boolean
    Public strProductLockUser As String
    'Public boolProductRefresh As Boolean

    Public boolProductNameEdit As Boolean
    Public strOldProductName As String

    'MenuTable variables
    Public intMenuID As Integer
    Public strMenuName As String
    Public strMenuDesc As String
    Public strMenuProdName As String
    Public intMenuCredit As Integer
    Public boolMenuNew As Boolean
    Public boolMenuEdit As Boolean
    Public boolMenuLock As Boolean
    Public strMenuLockUser As String
    'Public boolMenuRefresh As Boolean

    'Purchase HistoryTable variables
    Public intPurMemID As Integer
    Public intPurID As Integer
    Public strPurProdName As String
    Public intPurProdID As Integer
    Public datPurDate As Date
    Public datPurSDate As Date
    Public datPurEDate As Date
    Public datPurDepoDate As Date
    Public strPurRemark As String
    Public strPurHis As String
    Public strPurDevStatus As String
    Public strPurWarrNo As String
    Public strPurOrderNo As String
    Public decPurBasAmt As Decimal
    Public decPurAmt As Decimal
    Public intPurQty As Integer
    Public intPurCredit As Integer
    Public boolPurNew As Boolean
    Public boolPurEdit As Boolean

    'MenuHistoryTable variables
    Public intClsID As Integer
    Public intClsMemID As Integer
    Public intClsMenuID As Integer
    Public strClsMenuName As String
    Public intClsCredit As Integer
    Public datClsDate As Date
    Public boolClsNew As Boolean
    Public boolClsEdit As Boolean

    'Member Report variables
    Public strRptSelectedProd As String
    Public strRptSelectedMenu As String
    Public boolRptError As Boolean
    Public sqlQuery As String

    'Product Report variables
    Public strProdRptSelectedProd As String
    Public boolProdRptError As Boolean
    Public sqlQueryProd As String

    'Menu Report variables
    Public strMenuRptSelectedMenu As String
    Public boolMenuRptError
    Public sqlQueryMenu As String

    'Warehouse user
    Public strCurUser As String

    'Warehouse Form
    Public strWhName As String
    Public strWhAdd As String
    Public strWhCtc As String
    Public strWhCtcType As String
    Public intWhDevID As Integer
    Public strWhPoID As String
    Public datWhTime As Date
    Public strWhRemark As String
    Public strWhProBy As String
    Public datWhTimeStamp As Date
    Public strWhTranType As String
    Public intWhCounter As Integer
    Public boolWhLock As Boolean
    Public strWhLockUser As String

    Public strWhOverviewProdCat As String
    Public strWhOverviewProd As String
    Public strWhOverviewStartDuration As Date
    Public strWhOverViewEndDuration As Date
    Public strWhOverviewTran As String

    Public boolWhEdit As Boolean

    Public sqlCurrentView As String

    'Warehouse Item 
    Public longWhItemID As Long
    Public intWhItemDevItemID As Integer
    Public intWhItemDevID As Integer
    Public strWhItemProdCat As String
    Public strWhItemProdName As String
    Public strWhItemProdID As String
    Public strWhItemRemark As String
    Public intWhItemQty As String
    Public boolItemNew As Boolean
    Public boolItemEdit As Boolean

    'Warehouse Add Product
    Public intWhProdID As Integer
    Public strWhProdName As String
    Public strWhProdNo As String
    Public strWhProdCat As String

    'Warehouse customer
    Public intWhCusID As Integer
    Public strWhCusName As String
    Public strWhCusAdd As String
    Public strWhCusCtc As String
    Public strWhCusLockUser As String
    Public boolWhCusLock As Boolean

    'Warehouse Viewer
    Public strWhViewTranType As String
    Public strWhViewCusType As String
    Public strWhViewDevDate As String
    Public strWhViewName As String
    Public strWhViewAdd As String
    Public strWhViewCtc As String
    Public strWhViewDevID As String
    Public strWhViewPoID As String
    Public strWhViewProBy As String
    Public strWhViewTimeStamp As String

    Public strWhViewItemNo As String
    Public strWhViewProdName As String
    Public strWhViewQty As String
    Public strWhViewRemark As String


    Public Function FillDataSet(TableName As String, QueryAll As Boolean) As DataSet

        Dim _dsTable As New DataSet(TableName)
        Try
            Dim _objConn As New SqlClient.SqlConnection(strConnectionString)
            _objConn.Open()


            Dim _strQuery As String = ""

            If QueryAll = True Then
                _strQuery = "SELECT * FROM dbo." & TableName
            Else
                Select Case (TableName)
                    Case "MemTbl"
                        _strQuery = "SELECT * FROM dbo.MemTbl WHERE MemNRIC IS NOT NULL"
                    Case "ProdTbl"
                        _strQuery = "SELECT * FROM dbo.ProdTbl WHERE ProdName IS NOT NULL"
                    Case "MenuTbl"
                        _strQuery = "SELECT * FROM dbo.MenuTbl WHERE MenuName IS NOT NULL"
                    Case "WhTbl"
                        _strQuery = "SELECT * FROM dbo.WhTbl WHERE WhProBy IS NOT NULL"
                    Case Else
                        _strQuery = "SELECT * FROM dbo." & TableName
                End Select
            End If

            'Create instance of data adapter
            Dim _daTable As New SqlClient.SqlDataAdapter(_strQuery, _objConn)

            'Create instance of DataSet
            _daTable.FillSchema(_dsTable, SchemaType.Source, TableName)
            _daTable.Fill(_dsTable, TableName)

        Catch ex As Exception
            FatalError("Error connecting to database")
        End Try

        FillDataSet = _dsTable

    End Function

    Public Sub SaveDataSet(DataSetName As DataSet, TableName As String)

        Try
            Dim _objConn As New SqlClient.SqlConnection(strConnectionString)
            _objConn.Open()

            'Create instance of data adapter
            Dim _daTable As New SqlClient.SqlDataAdapter("SELECT * FROM dbo." & TableName, _objConn)
            Dim _objCommandBuilder As New SqlClient.SqlCommandBuilder(_daTable)
            _daTable.Update(DataSetName, TableName)
        Catch ex As Exception
            FatalError("Error connecting to database")
        End Try


    End Sub

    Public Function GetTableData(ID As Integer, IDName As String, TableName As String) As DataTable

        Dim rowCount As Integer
        Dim _DataSet As New DataSet
        _DataSet = FillDataSet(TableName, True)

        Dim _DataTable As DataTable
        Dim _DataTableCopy As DataTable

        _DataTable = _DataSet.Tables(TableName)
        _DataTableCopy = _DataTable.Clone

        rowCount = 0
        For Each DR As DataRow In _DataSet.Tables(TableName).Rows
            If DR(IDName) = ID Then
                _DataTableCopy.ImportRow(_DataTable.Rows(rowCount))
            End If
            rowCount = rowCount + 1
        Next

        GetTableData = _DataTableCopy

    End Function

    Public Function LoadQuery(FileName As String) As Boolean

        'Fill member total spending dataset
        'Dim TotSpdDataSet As DataSet = New DataSet
        'TotSpdDataSet = FillDynDataSet("SELECT Mem.MemID, SUM(Pur.PurAmt) As 'AmountSum' FROM MemTbl AS Mem, PurTbl AS Pur WHERE Mem.MemID = Pur.PurMemID GROUP BY Mem.MemID", "TotSpdTbl", TotSpdDataSet)

        'Fill member referral count dataset
        'Dim TotRefDataSet As DataSet = New DataSet
        'TotRefDataSet = FillDynDataSet("SELECT Mem.MemRefID,COUNT(*) As 'RefCount' FROM MemTbl AS Mem GROUP BY Mem.MemRefID", "TolRefTbl", TotRefDataSet)

        'Fill product total revenue dataset
        'Dim TotRevDataSet As DataSet = New DataSet
        'TotRevDataSet = FillDynDataSet("SELECT Prod.ProdID, SUM(Pur.PurAmt) As 'TotalRevenue' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) GROUP BY Prod.ProdID", "TotRevTbl", TotRevDataSet)
        'SaveDynDataSet("SELECT Prod.ProdID, SUM(Pur.PurAmt) As 'TotalRevenue' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) GROUP BY Prod.ProdID", "TotRevTbl", TotRevDataSet)

        'Fill product total unit sold dataset
        'Dim TotUnitDataSet As DataSet = New DataSet
        'TotUnitDataSet = FillDynDataSet("SELECT Prod.ProdID, SUM(Pur.PurQty) as 'TotalUnitSold' FROM PurTbl AS Pur, ProdTbl AS Prod WHERE(Pur.PurProdID = Prod.ProdID) GROUP BY Prod.ProdID", "TotUnitTbl", TotUnitDataSet)

        Dim sqlQuery As String = ""
        Dim objReader As New System.IO.StreamReader(FileName)

        Try
            sqlQuery = objReader.ReadToEnd()
            objReader.Close()

        Catch ex As Exception
            FatalError("Error opening SQL")
        End Try

        Dim sConnectionString As String

        sConnectionString = strConnectionString
        Dim myConn As New SqlClient.SqlConnection(sConnectionString)
        Dim myTable As New DataTable()
        Dim myCmd As New SqlClient.SqlCommand()
        myCmd.Connection = myConn
        myCmd.CommandText = sqlQuery

        Try
            Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
            myAdapter.Fill(myTable)

            Dim ReportForm As New ReportForm
            ReportForm.Show()

            ReportForm.ReportDataGridView.DataSource = myTable
            ReportForm.ReportDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

            LoadQuery = True
        Catch ex As Exception
            FatalError("Fatal error in SQL")
            LoadQuery = False
        End Try

    End Function
    Public Sub FatalError(Message As String)
        MessageBox.Show(Message, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub Confirmation(Message As String)
        MessageBox.Show(Message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub Warning(Message As String)
        MessageBox.Show(Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
    End Sub

    Public Function Question(Message As String) As Boolean
        Dim result = MessageBox.Show(Message, "Question", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Question = True
        Else
            Question = False
        End If
    End Function

    Public Function CheckDuplicate(Query As String) As Boolean

        Dim _connection As New SqlClient.SqlConnection
        Dim _command As New SqlClient.SqlCommand
        Dim _adapter As New SqlClient.SqlDataAdapter
        Dim _dataset As New DataSet
        Dim _count As Integer

        Try
            _connection.ConnectionString = strConnectionString
            _command.CommandText = Query
            _connection.Open()

            _command.Connection = _connection

            _adapter.SelectCommand = _command
            _adapter.Fill(_dataset, "0")

            _count = _dataset.Tables(0).Rows.Count

        Catch ex As Exception
            FatalError("Error connecting to database")
        End Try

        If _count > 0 Then
            CheckDuplicate = True
        Else
            CheckDuplicate = False
        End If

    End Function

    Public Function FillProdData(ProdCat As String) As DataSet

        Dim _dataSet As New DataSet("ProdTbl")

        Try
            Dim _objConnect As New SqlClient.SqlConnection(strConnectionString)
            _objConnect.Open()

            'Create instance of data adapter
            Dim _dataAdapter As New SqlClient.SqlDataAdapter("SELECT * FROM dbo.ProdTbl WHERE ProdCat='" & ProdCat & "'", _objConnect)

            'Create instance of DataSet

            _dataAdapter.FillSchema(_dataSet, SchemaType.Source, "ProdTbl")
            _dataAdapter.Fill(_dataSet, "ProdTbl")


        Catch ex As Exception
            FatalError("Error connecting to database")
        End Try

        FillProdData = _dataSet

    End Function

    Public Function FillCategoryCombo() As DataTable

        Dim _dataSet As New DataSet

        Try
            Using _connection As New SqlClient.SqlConnection(strConnectionString)
                Dim _adapter As New SqlClient.SqlDataAdapter
                _adapter.SelectCommand = New SqlClient.SqlCommand("SELECT WhProdCat FROM WhProdTbl WHERE WhProdEnable = 'True' GROUP BY WhProdCat", _connection)
                _adapter.Fill(_dataSet)

            End Using
        Catch ex As Exception

        End Try

        FillCategoryCombo = _dataSet.Tables(0)

    End Function

    Public Function GetSQLValue(sqlQuery As String) As Integer

        Dim _returnValue As Integer

        Try
            Dim _sqlConnection As New SqlClient.SqlConnection(strConnectionString)
            Dim _cmd As New SqlClient.SqlCommand


            _cmd.CommandText = sqlQuery
            _cmd.CommandType = CommandType.Text
            _cmd.Connection = _sqlConnection

            _sqlConnection.Open()
            If IsDBNull(_cmd.ExecuteScalar()) Then
                _returnValue = 0
            Else
                _returnValue = _cmd.ExecuteScalar()
            End If


            _sqlConnection.Close()
        Catch ex As Exception

        End Try

        GetSQLValue = _returnValue

    End Function

End Module
