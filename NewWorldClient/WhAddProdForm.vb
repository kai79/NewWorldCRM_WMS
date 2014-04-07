Public Class WhAddProdForm

    Public WhAddProdFormRef As Form

    Private Sub WhAddProdForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        WhAddProdCatComboBox.DataSource = FillCategoryCombo()
        WhAddProdCatComboBox.DisplayMember = "WhProdCat"

    End Sub

    Private Sub WhAddProdCatComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles WhAddProdCatComboBox.SelectedIndexChanged

        strWhItemProdCat = WhAddProdCatComboBox.Text

        Dim dataSet As New DataSet
        Using connection As New SqlClient.SqlConnection(strConnectionString)

            Dim adapter As New SqlClient.SqlDataAdapter
            adapter.SelectCommand = New SqlClient.SqlCommand("SELECT WhProdName FROM WhProdTbl WHERE WhProdCat='" & strWhItemProdCat & "' AND WhProdEnable = 'True' ORDER BY WhProdName", connection)
            adapter.Fill(dataSet)

        End Using

        WhAddProdComboBox.DataSource = dataSet.Tables(0)
        WhAddProdComboBox.DisplayMember = "WhProdName"

    End Sub

    Private Sub WhOutAddProdOKBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddProdOKBtn.Click

        If boolItemNew = True Then

            Dim DataSet As DataSet
            DataSet = FillDataSet("WhItemTbl", True)

            If DataSet.Tables("WhItemTbl").Rows.Count > 0 Then
                longWhItemID = DataSet.Tables("WhItemTbl")(DataSet.Tables("WhItemTbl").Rows.Count - 1)("WhItemID") + 1
            Else
                longWhItemID = "1"
            End If

            intWhItemDevItemID = intWhCounter
        End If

        strWhItemProdCat = Me.WhAddProdCatComboBox.Text
        strWhItemProdName = Me.WhAddProdComboBox.Text
        strWhItemRemark = Me.WhOutRecRemarkTextBox.Text
        intWhItemQty = Me.WhOutRecQtyNumericUpDown.Value
        strWhItemProdID = GetValue(strWhItemProdCat, strWhItemProdName)

        If intWhItemQty = 0 Then
            FatalError("Please specific Quantity")
            WhOutRecQtyNumericUpDown.BackColor = Color.OrangeRed
        Else

            Dim DataSet As DataSet
            DataSet = FillDataSet("WhItemTbl", True)

            Try
                If boolItemNew = True Then

                    Dim DataRow As DataRow = DataSet.Tables("WhItemTbl").NewRow
                    DataRow("WhItemID") = Trim(longWhItemID)
                    DataRow("WhItemDevID") = Trim(intWhDevID)
                    DataRow("WhItemDevItemID") = Trim(intWhItemDevItemID)
                    DataRow("WhItemQty") = Trim(intWhItemQty)
                    DataRow("WhItemProdName") = Trim(strWhItemProdName)
                    DataRow("WhItemProdID") = Trim(strWhItemProdID)
                    DataRow("WhItemRemark") = Trim(strWhItemRemark)
                    DataRow("WhItemProdCat") = Trim(strWhItemProdCat)
                    DataRow("WhItemSave") = False
                    DataSet.Tables("WhItemTbl").Rows.Add(DataRow)

                    intWhCounter = intWhCounter + 1
                    boolItemNew = False

                Else
                    If boolItemEdit = True Then

                        Dim DataRow As DataRow
                        DataRow = DataSet.Tables("WhItemTbl").Rows.Find(longWhItemID)
                        DataRow.BeginEdit()
                        DataRow("WhItemQty") = Trim(intWhItemQty)
                        DataRow("WhItemProdName") = Trim(strWhItemProdName)
                        DataRow("WhItemProdID") = Trim(strWhItemProdID)
                        DataRow("WhItemRemark") = Trim(strWhItemRemark)
                        DataRow("WhItemProdCat") = Trim(strWhItemProdCat)
                        DataRow("WhItemSave") = False
                        DataRow.EndEdit()

                        boolItemEdit = False
                    End If

                End If

                SaveDataSet(DataSet, "WhItemTbl")

                CType(WhAddProdFormRef, WhForm).WhItemTblDataGridView.DataSource = GetTableData(intWhDevID, "WhItemDevID", "WhItemTbl")
                CType(WhAddProdFormRef, WhForm).WhItemTblDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

                Me.Dispose()

            Catch ex As Exception
                FatalError("Error saving record!")
            End Try

        End If

    End Sub

    Private Sub WhOutAddProdNewBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddProdNewBtn.Click

        Dim NewWhAddNewProdForm As New WhAddNewProdForm
        NewWhAddNewProdForm.WhAddNewProdFormRef = Me
        NewWhAddNewProdForm.ShowDialog()

    End Sub

    Private Sub WhOutAddProdCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddProdCancelBtn.Click

        Me.Dispose()

    End Sub

    Private Function GetValue(ProdCat As String, ProdName As String) As String

        Dim sqlConnection1 As New SqlClient.SqlConnection(strConnectionString)
        Dim cmd As New SqlClient.SqlCommand
        Dim returnValue As String

        cmd.CommandText = "SELECT whProdID FROM WhProdTbl WHERE WhProdName='" & ProdName & "' AND WhProdCat='" & ProdCat & "'"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        returnValue = cmd.ExecuteScalar()

        sqlConnection1.Close()

        GetValue = returnValue

    End Function
End Class