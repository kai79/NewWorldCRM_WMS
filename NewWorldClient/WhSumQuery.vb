Public Class WhSumQuery

    Private Sub WhSumQuery_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim CurDate As Date
        Dim DateArr As Array

        CurDate = System.DateTime.Today
        DateArr = Split(CurDate, "-")

        'Date defaulting
        Me.WhSumQryYrComboBox.SelectedText = DateArr(0)
        Select Case DateArr(1)
            Case (1)
                Me.WhSumQryMoComboBox.SelectedIndex = 0
            Case (2)
                Me.WhSumQryMoComboBox.SelectedIndex = 1
            Case (3)
                Me.WhSumQryMoComboBox.SelectedIndex = 2
            Case (4)
                Me.WhSumQryMoComboBox.SelectedIndex = 3
            Case (5)
                Me.WhSumQryMoComboBox.SelectedIndex = 4
            Case (6)
                Me.WhSumQryMoComboBox.SelectedIndex = 5
            Case (7)
                Me.WhSumQryMoComboBox.SelectedIndex = 6
            Case (8)
                Me.WhSumQryMoComboBox.SelectedIndex = 7
            Case (9)
                Me.WhSumQryMoComboBox.SelectedIndex = 8
            Case (10)
                Me.WhSumQryMoComboBox.SelectedIndex = 9
            Case (11)
                Me.WhSumQryMoComboBox.SelectedIndex = 10
            Case Else
                Me.WhSumQryMoComboBox.SelectedIndex = 11
        End Select


    End Sub

    Private Sub WhSumSearchBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhSumSearchBtn.Click

        Dim strDate As String

        Select Case Me.WhSumQryMoComboBox.SelectedIndex
            Case (0)
                strDate = Me.WhSumQryYrComboBox.Text & "-01"
            Case (1)
                strDate = Me.WhSumQryYrComboBox.Text & "-02"
            Case (2)
                strDate = Me.WhSumQryYrComboBox.Text & "-03"
            Case (3)
                strDate = Me.WhSumQryYrComboBox.Text & "-04"
            Case (4)
                strDate = Me.WhSumQryYrComboBox.Text & "-05"
            Case (5)
                strDate = Me.WhSumQryYrComboBox.Text & "-06"
            Case (6)
                strDate = Me.WhSumQryYrComboBox.Text & "-07"
            Case (7)
                strDate = Me.WhSumQryYrComboBox.Text & "-08"
            Case (8)
                strDate = Me.WhSumQryYrComboBox.Text & "-09"
            Case (9)
                strDate = Me.WhSumQryYrComboBox.Text & "-10"
            Case (10)
                strDate = Me.WhSumQryYrComboBox.Text & "-11"
            Case Else
                strDate = Me.WhSumQryYrComboBox.Text & "-12"
        End Select

        strQueryDate = strDate
        strDate = strDate & "-%"

        Dim myConn As New SqlClient.SqlConnection(strConnectionString)
        Dim myTable As New DataTable()
        Dim myCmd As New SqlClient.SqlCommand()
        myCmd.Connection = myConn
        Dim myQuery As String = "Select Distinct T4.WhProdID as 'Ref ID', T4.WhProdCat as 'Product Category', T4.WhProdName as 'Product Name', Case When T2.SumIn IS NULL then '0' Else T2.SumIn End As 'In', Case When T3.SumOut IS NULL then '0' Else T3.SumOut End As 'Out', ((Case When T2.SumIn IS NULL then '0' else T2.SumIn End) - (Case When T3.SumOut IS NULL then '0' Else T3.SumOut End)) as 'Balance' from WhProdTbl As T4 left outer join (select SUM(WhItemQty) as 'SumOut', WhItemProdID from WhItemTbl Where WhItemTranType = 'Out' and WhItemDevDate like '" & strDate & "' group by WhItemProdID) as T3 On T4.WhProdID = T3.WhItemProdID left outer join (select SUM(WhItemQty) as 'SumIn', WhItemProdID from WhItemTbl Where WhItemTranType = 'In' and WhItemDevDate like '" & strDate & "' group by WhItemProdID) as T2 On T4.WhProdID = T2.WhItemProdID and T4.WhProdEnable = 1 order by T4.WhProdID"
        myCmd.CommandText = myQuery

        Try
            Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
            myAdapter.Fill(myTable)

        Catch ex As Exception

        End Try
        Dim NewWhSummary As New WhSummary
        NewWhSummary.WhSumDataGridView.DataSource = myTable
        NewWhSummary.WhSumDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        NewWhSummary.Show()

    End Sub

    Private Sub WhSumCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhSumCancelBtn.Click
        Me.Dispose()

    End Sub
End Class