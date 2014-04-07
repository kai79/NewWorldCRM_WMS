Public Class NewProdForm

    Private Sub ProdTblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.ProdTblBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.NewWorldDBDataSet)

    End Sub

    Private Sub NewProd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.ProdTbl' table. You can move, or remove it, as needed.
        'Me.ProdTblTableAdapter.Fill(Me.NewWorldDBDataSet.ProdTbl)

        If boolProductNew = True Then
            Me.ProdIDTextBox.Text = CStr(intProductID)
            Me.ProdNewLockBtn.Enabled = False
        End If

        ProdCatComboBox.SelectedIndex = 0
        ProdWarrantyNumericUpDown.Value = 12

    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Question("You will lose all unsaved data. Do you want to continue?") = True Then
            CancelForm()
        Else
            e.Cancel = True
            Exit Sub
        End If

    End Sub

    Private Sub NewProdSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewProdSaveBtn.Click
        Me.SaveForm()

    End Sub

    Private Sub ProdNewClearBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProdNewClearBtn.Click
        ClearForm()

    End Sub

    Private Sub ProdNewCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProdNewCancelBtn.Click
        CancelForm()

    End Sub

    Private Function SaveForm() As Boolean

        Dim boolReturn As Boolean

        If ProdNameTextBox.Text = "" Then
            FatalError("Product Name cannot be empty" & vbCrLf & "Product will not be saved.")
            boolReturn = False
            Me.ProdNameTextBox.BackColor = Color.OrangeRed
        Else
            intProductID = Me.ProdIDTextBox.Text()
            strProductName = Trim(UCase(Me.ProdNameTextBox.Text))
            decProductPrice = Me.ProdPriceNumericUpDown.Value
            intProductWarranty = Me.ProdWarrantyNumericUpDown.Value
            strProductCategory = Trim(Me.ProdCatComboBox.Text)
            intProductCredit = Me.ProdCreditNumericUpDown.Value

            If boolProductNew = True And CheckDuplicate("SELECT * FROM ProdTbl WHERE ProdName='" & strProductName & "'") = True Then
                FatalError("ProductName: " & strProductName & " already exists" & vbCrLf & "Product will not be saved.")
                boolReturn = False
            Else

                Dim DataSet As DataSet
                DataSet = FillDataSet("ProdTbl", True)

                Try
                    'Existing Records
                    Dim DataRow As DataRow
                    DataRow = DataSet.Tables("ProdTbl").Rows.Find(intProductID)
                    DataRow.BeginEdit()
                    DataRow("ProdName") = Trim(strProductName)
                    'DataRow("ProdPrice") = Math.Round(decProductPrice, 2)
                    DataRow("ProdPrice") = Trim(decProductPrice)
                    DataRow("ProdWarranty") = Trim(intProductWarranty)
                    DataRow("ProdCat") = Trim(strProductCategory)
                    DataRow("ProdCredit") = Trim(intProductCredit)
                    DataRow("ProdLock") = False
                    DataRow("ProdLockUser") = vbNull
                    DataRow.EndEdit()

                    If boolProductNameEdit = True Then
                        'Update all purchase records
                        Dim myConn As SqlClient.SqlConnection
                        Dim myCmd As SqlClient.SqlCommand
                        Dim myReader As SqlClient.SqlDataReader
                        Dim results As String = ""

                        myConn = New SqlClient.SqlConnection(strConnectionString)
                        myCmd = myConn.CreateCommand
                        myCmd.CommandText = "UPDATE dbo.PurTbl SET PurProdName = '" & strProductName & "', PurLock = 0, PurLockUser = NULL WHERE PurProdName = '" & strOldProductName & "'"

                        myConn.Open()

                        myReader = myCmd.ExecuteReader

                        myReader.Close()
                        myConn.Close()

                        boolProductNameEdit = False

                    End If

                    SaveDataSet(DataSet, "ProdTbl")
                    Confirmation("Record updated successfully")
                    boolReturn = True

                    If boolProductNew = True Then
                        boolProductNew = False
                    Else
                        If boolProductEdit = True Then
                            boolProductEdit = False
                            'boolProductRefresh = True
                        End If
                    End If
                    Me.Dispose()

                    intProductID = Nothing
                    strProductName = Nothing
                    decProductPrice = Nothing
                    intProductWarranty = Nothing
                    strProductCategory = Nothing
                    intProductCredit = Nothing
                    strOldProductName = Nothing
                    boolProductNameEdit = False

                Catch ex As Exception
                    FatalError("Record update failed")
                End Try

            End If
        End If

        SaveForm = boolReturn

    End Function

    Private Sub ClearForm()

        Me.ProdNameTextBox.Clear()
        Me.ProdPriceNumericUpDown.ResetText()
        Me.ProdWarrantyNumericUpDown.ResetText()
        Me.ProdCatComboBox.SelectedIndex = 0

    End Sub

    Private Sub CancelForm()

        intProductID = Me.ProdIDTextBox.Text()

        Dim DataSet As DataSet
        DataSet = FillDataSet("ProdTbl", True)
        Dim DataRow As DataRow

        If boolProductNew = True Then


            DataRow = DataSet.Tables("ProdTbl").Rows.Find(intProductID)
            DataRow.Delete()
            SaveDataSet(DataSet, "ProdTbl")

            boolProductNew = False
            Me.Dispose()
        Else
            If boolProductEdit = True Then

                DataRow = DataSet.Tables("ProdTbl").Rows.Find(intProductID)
                DataRow.BeginEdit()
                DataRow("ProdLock") = False
                DataRow("ProdLockUser") = vbNull
                DataRow.EndEdit()

                SaveDataSet(DataSet, "ProdTbl")

                boolProductEdit = False
                Me.Dispose()
            Else
                Me.Dispose()
            End If
        End If

    End Sub

    Private Sub ProdNewLockBtn_Click(sender As System.Object, e As System.EventArgs) Handles ProdNewLockBtn.Click

        strProductName = Trim(Me.ProdNameTextBox.Text)

        Dim myConn As SqlClient.SqlConnection
        Dim myCmd As SqlClient.SqlCommand
        Dim myReader As SqlClient.SqlDataReader
        Dim results As String = ""

        myConn = New SqlClient.SqlConnection(strConnectionString)
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT PurOrderNo, PurProdName, PurLockUser FROM dbo.PurTbl WHERE PurLock = 1 AND PurProdName = '" & Trim(strPurProdName) & "'"

        myConn.Open()

        myReader = myCmd.ExecuteReader

        Do While myReader.Read()
            results = results & "Order No: " & Trim(myReader.GetString(0)) & " with Product: " & Trim(myReader.GetString(1)) & " is current locked by user: " & Trim(myReader.GetString(2)) & vbLf
        Loop

        myReader.Close()
        myConn.Close()

        If results <> "" Then
            results = results & "Please close all locked record and try again"
            MsgBox(results)
        Else
            'lock all purchase that contains the selected product
            myCmd.CommandText = "UPDATE dbo.PurTbl SET PurLock = 1, PurLockUser = '" & strGlobalLogin & "' WHERE PurProdName = '" & strPurProdName & "'"

            myConn.Open()
            myReader = myCmd.ExecuteReader
            myReader.Close()
            myConn.Close()

            boolProductNameEdit = True
            strOldProductName = strProductName
            ProdNameTextBox.Enabled = True
            ProdNewLockBtn.Enabled = False

        End If

       

    End Sub
End Class