Public Class WhQuerySearch

    Public WhQuerySearch_Ref As Form

    Private Sub WhQuerySearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        TransTypeComboBox.SelectedIndex = 0
        CusTypeComboBox.SelectedIndex = 0
        EditedComboBox.SelectedIndex = 0
        ProByComboBox.DataSource = FillProByCombo()
        ProByComboBox.DisplayMember = "RootName"
        ProByAllCheckBox.Checked = True
        ProBySelectCheckBox.Checked = False

    End Sub

    Private Function FillProByCombo() As DataTable

        Dim dataSet As New DataSet
        Using connection As New SqlClient.SqlConnection(strConnectionString)

            Dim adapter As New SqlClient.SqlDataAdapter
            adapter.SelectCommand = New SqlClient.SqlCommand("SELECT DISTINCT(RootName)FROM RootTbl", connection)
            adapter.Fill(dataSet)

        End Using

        FillProByCombo = dataSet.Tables(0)

    End Function

    Private Sub WhSearchBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhSearchBtn.Click

        Dim TransTypeQuery As String
        Dim DevDateQuery As String
        Dim CusTypeQuery As String
        Dim PONoQuery As String
        Dim RecQuery As String
        Dim ProByQuery As String
        Dim EditedQuery As String
        Dim myQuery As String

        If TransTypeComboBox.Text = "All" Then
            TransTypeQuery = "(Wh.WhTranType = 'In' OR Wh.WhTranType = 'Out')"
        Else
            TransTypeQuery = "Wh.WhTranType = '" & TransTypeComboBox.Text & "'"
        End If

        Dim DevDateLow As Date
        Dim DevDateHigh As Date
        DevDateLow = DevDateLowDatePicker.Text
        DevDateHigh = DevDateHighDatePicker.Text
        DevDateQuery = "Wh.WhDevDate >= '" & DevDateLow & "' AND Wh.WhDevDate <= '" & DevDateHigh & "'"

        If CusTypeComboBox.Text = "All" Then
            CusTypeQuery = "(Wh.WhType = 'Home' OR Wh.WhType = 'Company')"
        Else
            If CusTypeComboBox.Text = "Home" Then
                CusTypeQuery = "Wh.WhType = 'Home'"
            Else
                CusTypeQuery = "Wh.WhType = 'Company'"
            End If
        End If

        If PONumberTextBox.Text <> "" Then
            PONoQuery = "WhPoID LIKE '%" & PONumberTextBox.Text & "%'"
        Else
            PONoQuery = "WhPoID LIKE '%'"
        End If

        If RecipentTextBox.Text <> "" Then
            RecQuery = "WhName LIKE '%" & RecipentTextBox.Text & "%'"
        Else
            RecQuery = "WhName LIKE '%'"
        End If

        If EditedComboBox.Text = "Any" Then
            EditedQuery = "(Wh.WhEdit = 'True' OR Wh.WhEdit = 'False')"
        Else
            If EditedComboBox.Text = "Yes" Then
                EditedQuery = "(Wh.WhEdit = 'True')"
            Else
                EditedQuery = "(Wh.WhEdit = 'False')"
            End If
        End If

        If ProByAllCheckBox.Checked = False And ProBySelectCheckBox.Checked = False Then
            FatalError("Please Select either All or Selected User")
        Else

            If ProByAllCheckBox.Checked = True Then
                myQuery = "SELECT * FROM WhTbl AS Wh WHERE " & TransTypeQuery & " AND " & DevDateQuery & " AND " & CusTypeQuery & " AND " & PONoQuery & " AND " & RecQuery & " AND " & EditedQuery
            Else
                ProByQuery = "Wh.WhProBy = '" & ProByComboBox.Text & "'"
                myQuery = "SELECT * FROM WhTbl AS Wh WHERE " & TransTypeQuery & " AND " & DevDateQuery & " AND " & CusTypeQuery & " AND " & ProByQuery & " AND " & PONoQuery & " AND " & EditedQuery & "AND" & RecQuery
            End If

            Dim myConn As New SqlClient.SqlConnection(strConnectionString)
            Dim myTable As New DataTable()
            Dim myCmd As New SqlClient.SqlCommand()

            myCmd.Connection = myConn
            myCmd.CommandText = myQuery
            sqlCurrentView = myQuery

            Try
                Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
                myAdapter.Fill(myTable)

                CType(WhQuerySearch_Ref, WhForm).WhQueryDataGridView.DataSource = myTable
                CType(WhQuerySearch_Ref, WhForm).UpdateTransaction()

                'Dim HistoryView As New WhHistoryView
                'HistoryView.HistoryViewDataGridView.DataSource = myTable
                'HistoryView.ShowDialog()

            Catch ex As Exception
                FatalError("Error retriving data from Database")
            End Try
        End If

    End Sub

    Private Sub DevDateLowDatePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DevDateLowDatePicker.ValueChanged

        DevDateHighDatePicker.Text = DevDateLowDatePicker.Text

    End Sub

    Private Sub ProByAllCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ProByAllCheckBox.CheckedChanged

        If ProByAllCheckBox.Checked = True Then
            ProBySelectCheckBox.Checked = False
            ProByComboBox.SelectedIndex = 0
            ProByComboBox.Enabled = False
        End If

    End Sub

    Private Sub ProBySelectCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ProBySelectCheckBox.CheckedChanged

        If ProBySelectCheckBox.Checked = True Then
            ProByAllCheckBox.Checked = False
            ProByComboBox.SelectedIndex = 0
            ProByComboBox.Enabled = True
        End If

    End Sub

    Private Sub WhCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhCancelBtn.Click
        Me.Dispose()
    End Sub
End Class