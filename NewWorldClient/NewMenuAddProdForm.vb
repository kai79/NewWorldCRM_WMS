Public Class NewMenuAddProdForm

    Public NewMenuAddProdRef As Form

    Private Sub NewMenuAddProdForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim sqlConn As New SqlClient.SqlConnection(strConnectionString)
        Dim sqlCmd As SqlClient.SqlCommand
        Dim sqlQuery As String

        sqlQuery = "SELECT ProdName FROM dbo.ProdTbl WHERE ProdName IS NOT NULL"

        Try
            sqlConn.Open()
            sqlCmd = New SqlClient.SqlCommand(sqlQuery, sqlConn)
            Dim SqlReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader()
            While SqlReader.Read()
                AvailableListView.Items.Add(Trim(SqlReader.Item(0)))
            End While
            SqlReader.Close()
            sqlCmd.Dispose()
            sqlConn.Close()
        Catch ex As Exception

        End Try

        If strMenuProdName <> "" Then
            Dim tempLib As Array
            tempLib = Split(strMenuProdName, "|")

            For i = 0 To UBound(tempLib)
                SelectedListView.Items.Add(Trim(tempLib(i)))

                For Each item As ListViewItem In AvailableListView.Items
                    If item.Text = tempLib(i) Then
                        AvailableListView.Items.Remove(item)
                    End If
                Next

            Next

        End If

    End Sub

    Private Sub NewMenuAddProdAddBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuAddProdAddBtn.Click

        Dim itemName As String
        Dim itemList As New ArrayList

        If AvailableListView.SelectedItems.Count > 0 Then

            For j = 0 To AvailableListView.SelectedItems.Count - 1

                itemName = AvailableListView.SelectedItems(j).Text

                Dim blnFlag As Boolean

                blnFlag = False

                For i = 0 To SelectedListView.Items.Count - 1
                    If SelectedListView.Items(i).Text = itemName Then
                        blnFlag = True
                    End If
                Next

                If blnFlag = False Then
                    SelectedListView.Items.Add(itemName)
                    itemList.Add(itemName)
                End If

            Next j

            'Remove from available listview
            For i = 0 To itemList.Count - 1
                For Each item As ListViewItem In AvailableListView.Items
                    If item.Text = itemList(i).ToString Then
                        AvailableListView.Items.Remove(item)
                    End If
                Next
            Next

        End If
    End Sub

    Private Sub NewMenuAddProdRemoveBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuAddProdRemoveBtn.Click

        Dim itemName As String
        Dim itemList As New ArrayList

        If SelectedListView.SelectedItems.Count > 0 Then

            For i = 0 To SelectedListView.SelectedItems.Count - 1
                itemName = SelectedListView.SelectedItems(i).Text
                AvailableListView.Items.Add(itemName)
                itemList.Add(itemName)
            Next

        End If

        For i = 0 To itemList.Count - 1
            For Each item As ListViewItem In SelectedListView.Items
                If item.Text = itemList(i).ToString Then
                    SelectedListView.Items.Remove(item)
                End If
            Next
        Next

    End Sub

    Private Sub NewMenuAddProdSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuAddProdSaveBtn.Click

        Dim temp As String
        temp = ""
        CType(NewMenuAddProdRef, NewMenuForm).MenuAssocProdTxtBox.Text = ""

        For i = 0 To SelectedListView.Items.Count - 1
            If temp = "" Then
                temp = Trim(SelectedListView.Items(i).Text)
                CType(NewMenuAddProdRef, NewMenuForm).MenuAssocProdTxtBox.Text = Trim(SelectedListView.Items(i).Text)
            Else
                temp = temp & "|" & Trim(SelectedListView.Items(i).Text)
                CType(NewMenuAddProdRef, NewMenuForm).MenuAssocProdTxtBox.AppendText(Environment.NewLine & Trim(SelectedListView.Items(i).Text))
            End If
        Next i

        strMenuProdName = temp
        Me.Dispose()

    End Sub

    Private Sub NewMenuAddProdCancel_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuAddProdCancel.Click

        Me.Dispose()

    End Sub
End Class