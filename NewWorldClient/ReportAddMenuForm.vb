Public Class ReportAddMenuForm

    Private Sub ReportAddMenuForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Dim sqlConn As New SqlClient.SqlConnection(strConnectionString)
        Dim sqlCmd As SqlClient.SqlCommand
        Dim sqlQuery As String

        sqlQuery = "SELECT MenuName FROM dbo.MenuTbl WHERE MenuName IS NOT NULL"

        Try
            sqlConn.Open()
            sqlCmd = New SqlClient.SqlCommand(sqlQuery, sqlConn)
            Dim SqlReader As SqlClient.SqlDataReader = sqlCmd.ExecuteReader()
            While SqlReader.Read()
                ReportAddMenuAvailableListView.Items.Add(Trim(SqlReader.Item(0)))
            End While
            SqlReader.Close()
            sqlCmd.Dispose()
            sqlConn.Close()
        Catch ex As Exception

        End Try

        If strRptSelectedMenu <> "" Then
            Dim tempLib As Array
            tempLib = Split(strRptSelectedMenu, "|")

            For i = 0 To UBound(tempLib)
                ReportAddMenuSelectedListView.Items.Add(Trim(tempLib(i)))

                For Each item As ListViewItem In ReportAddMenuAvailableListView.Items
                    If item.Text = tempLib(i) Then
                        ReportAddMenuAvailableListView.Items.Remove(item)
                    End If
                Next
            Next

        End If

    End Sub

    Private Sub ReportAddMenuForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub ReportAddMenuAddBtn_Click(sender As System.Object, e As System.EventArgs) Handles ReportAddMenuAddBtn.Click

        Dim itemName As String
        Dim itemList As New ArrayList

        If ReportAddMenuAvailableListView.SelectedItems.Count > 0 Then

            For j = 0 To ReportAddMenuAvailableListView.SelectedItems.Count - 1

                itemName = ReportAddMenuAvailableListView.SelectedItems(j).Text

                Dim blnFlag As Boolean

                blnFlag = False

                For i = 0 To ReportAddMenuSelectedListView.Items.Count - 1
                    If ReportAddMenuSelectedListView.Items(i).Text = itemName Then
                        blnFlag = True
                    End If
                Next

                If blnFlag = False Then
                    ReportAddMenuSelectedListView.Items.Add(itemName)
                    itemList.Add(itemName)
                End If

            Next j

            'Remove from available listview
            For i = 0 To itemList.Count - 1
                For Each item As ListViewItem In ReportAddMenuAvailableListView.Items
                    If item.Text = itemList(i).ToString Then
                        ReportAddMenuAvailableListView.Items.Remove(item)
                    End If
                Next
            Next

        End If

    End Sub

    Private Sub ReportAddMenuRemoveBtn_Click(sender As System.Object, e As System.EventArgs) Handles ReportAddMenuRemoveBtn.Click

        Dim itemName As String
        Dim itemList As New ArrayList

        If ReportAddMenuSelectedListView.SelectedItems.Count > 0 Then

            For i = 0 To ReportAddMenuSelectedListView.SelectedItems.Count - 1
                itemName = ReportAddMenuSelectedListView.SelectedItems(i).Text
                ReportAddMenuAvailableListView.Items.Add(itemName)
                itemList.Add(itemName)
            Next
        End If

        For i = 0 To itemList.Count - 1
            For Each item As ListViewItem In ReportAddMenuSelectedListView.Items
                If item.Text = itemList(i).ToString Then
                    ReportAddMenuSelectedListView.Items.Remove(item)
                End If
            Next
        Next

    End Sub

    Private Sub CfgAddMenuSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles CfgAddMenuSaveBtn.Click

        Dim temp As String
        temp = ""

        For i = 0 To ReportAddMenuSelectedListView.Items.Count - 1
            If temp = "" Then
                temp = Trim(ReportAddMenuSelectedListView.Items(i).Text)
            Else
                temp = temp & "|" & Trim(ReportAddMenuSelectedListView.Items(i).Text)
            End If
        Next

        strRptSelectedMenu = temp

        Me.Dispose()

    End Sub

    Private Sub CfgAddMenuCancel_Click(sender As System.Object, e As System.EventArgs) Handles CfgAddMenuCancel.Click

        Me.Dispose()

    End Sub
End Class