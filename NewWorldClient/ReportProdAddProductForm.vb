Public Class ReportProdAddProductForm

    Private Sub ReportProdAddProductForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim sqlConn As New SqlClient.SqlConnection(strConnectionString)
        Dim sqlCmd As SqlClient.SqlCommand
        Dim sqlQuery As String

        sqlQuery = "SELECT ProdName FROM dbo.ProdTbl WHERE ProdName IS NOT NULL"

        Try
            sqlConn.Open()
            sqlCmd = New SqlClient.SqlCommand(sqlQuery, sqlConn)
            Dim SqlReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader()
            While SqlReader.Read()
                ReportAddProdAvailableListView.Items.Add(Trim(SqlReader.Item(0)))
            End While
            SqlReader.Close()
            sqlCmd.Dispose()
            sqlConn.Close()
        Catch ex As Exception

        End Try

        If strProdRptSelectedProd <> "" Then
            Dim tempLib As Array
            tempLib = Split(strProdRptSelectedProd, "|")

            For i = 0 To UBound(tempLib)
                ReportAddProdSelectedListView.Items.Add(Trim(tempLib(i)))

                For Each item As ListViewItem In ReportAddProdAvailableListView.Items
                    If item.Text = tempLib(i) Then
                        ReportAddProdAvailableListView.Items.Remove(item)
                    End If
                Next
            Next

        End If

    End Sub

    Private Sub ReportAddProdAddBtn_Click(sender As System.Object, e As System.EventArgs) Handles ReportAddProdAddBtn.Click

        Dim itemName As String
        Dim itemList As New ArrayList

        If ReportAddProdAvailableListView.SelectedItems.Count > 0 Then

            For j = 0 To ReportAddProdAvailableListView.SelectedItems.Count - 1

                itemName = ReportAddProdAvailableListView.SelectedItems(j).Text

                Dim blnFlag As Boolean

                blnFlag = False

                For i = 0 To ReportAddProdSelectedListView.Items.Count - 1
                    If ReportAddProdSelectedListView.Items(i).Text = itemName Then
                        blnFlag = True
                    End If
                Next

                If blnFlag = False Then
                    ReportAddProdSelectedListView.Items.Add(itemName)
                    itemList.Add(itemName)
                End If
            Next j

            'Remove from available listview
            For i = 0 To itemList.Count - 1
                For Each item As ListViewItem In ReportAddProdAvailableListView.Items
                    If item.Text = itemList(i).ToString Then
                        ReportAddProdAvailableListView.Items.Remove(item)
                    End If
                Next
            Next

        End If

    End Sub

    Private Sub ReportAddProdRemoveBtn_Click(sender As System.Object, e As System.EventArgs) Handles ReportAddProdRemoveBtn.Click

        Dim itemName As String
        Dim itemList As New ArrayList

        If ReportAddProdSelectedListView.SelectedItems.Count > 0 Then

            For i = 0 To ReportAddProdSelectedListView.SelectedItems.Count - 1
                itemName = ReportAddProdSelectedListView.SelectedItems(i).Text
                ReportAddProdAvailableListView.Items.Add(itemName)
                itemList.Add(itemName)
            Next

        End If

        For i = 0 To itemList.Count - 1
            For Each item As ListViewItem In ReportAddProdSelectedListView.Items
                If item.Text = itemList(i).ToString Then
                    ReportAddProdSelectedListView.Items.Remove(item)
                End If
            Next
        Next

    End Sub

    Private Sub CfgAddProdSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgAddProdSaveBtn.Click

        Dim temp As String
        temp = ""

        For i = 0 To ReportAddProdSelectedListView.Items.Count - 1
            If temp = "" Then
                temp = Trim(ReportAddProdSelectedListView.Items(i).Text)
            Else
                temp = temp & "|" & Trim(ReportAddProdSelectedListView.Items(i).Text)
            End If
        Next

        strProdRptSelectedProd = temp

        Me.Dispose()

    End Sub

    Private Sub CfgAddProdCancel_Click(sender As System.Object, e As System.EventArgs) Handles CfgAddProdCancel.Click
        Me.Dispose()

    End Sub

    Private Sub ReportAddProductForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

End Class