Public Class PurchaseHistoryForm

    Public PurchaseHistoryRef As Form

    Private Sub PurTblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.PurTblBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.NewWorldDBDataSet)

    End Sub

    Private Sub AddPurHisForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.ProdTbl' table. You can move, or remove it, as needed.
        'Me.ProdTblTableAdapter.Fill(Me.NewWorldDBDataSet.ProdTbl)
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.PurTbl' table. You can move, or remove it, as needed.
        'Me.PurTblTableAdapter.Fill(Me.NewWorldDBDataSet.PurTbl)

        If boolPurNew = True Then
            Me.PurIDTextBox.Text = CStr(intPurID)
            Me.PurDevStatusComboBox.SelectedIndex = 1

            Me.PurCreditNumericUpDown.Enabled = False
            Me.PurQtyNumericUpDown.Enabled = False
            Me.PurAmtNumericUpDown.Enabled = False
            Me.PurWarrNoTextBox.Enabled = False
            Me.PurSDateDateTimePicker.Enabled = False
            Me.PurEDateDateTimePicker.Enabled = False

        End If

        Me.PurCreditNumericUpDown.Enabled = False

    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.CancelForm()

    End Sub

    Private Sub AddPurHisSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddPurHisSaveBtn.Click
        Me.SaveForm()

    End Sub

    Private Sub AddPurHisCnlBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddPurHisCnlBtn.Click
        Me.CancelForm()

    End Sub

    Private Sub SaveForm()

        If PurOrderNoTextBox.Text = "" Then
            FatalError("Order No is empty")
            PurOrderNoTextBox.BackColor = Color.OrangeRed
        Else
            If PurProdNameTextBox.Text = "" Then
                FatalError("Product name is empty")
            Else
                intPurID = CInt(Me.PurIDTextBox.Text)
                strPurOrderNo = UCase(Me.PurOrderNoTextBox.Text)
                strPurWarrNo = UCase(Me.PurWarrNoTextBox.Text)
                strPurProdName = Me.PurProdNameTextBox.Text
                datPurDate = Me.PurDateDateTimePicker.Text
                datPurSDate = Me.PurSDateDateTimePicker.Text
                datPurEDate = Me.PurEDateDateTimePicker.Text
                datPurDepoDate = Me.PurDepoDateTimePicker.Text
                decPurAmt = CDec(Me.PurAmtNumericUpDown.Value)
                intPurQty = CInt(Me.PurQtyNumericUpDown.Value)
                intPurCredit = CInt(Me.PurCreditNumericUpDown.Value)
                strPurDevStatus = Me.PurDevStatusComboBox.Text
                strPurHis = Me.PurHisTextBox.Text
                strPurRemark = Me.PurRemarkTextBox.Text

                Dim DataSet As DataSet
                DataSet = FillDataSet("PurTbl", True)

                Try
                    'Existing Records
                    Dim DataRow As DataRow
                    DataRow = DataSet.Tables("PurTbl").Rows.Find(intPurID)
                    DataRow.BeginEdit()
                    DataRow("PurOrderNo") = Trim(strPurOrderNo)
                    DataRow("PurWarrNo") = Trim(strPurWarrNo)
                    DataRow("PurProdName") = Trim(strPurProdName)
                    DataRow("PurProdID") = Trim(intPurProdID)
                    DataRow("PurDate") = Trim(datPurDate)
                    DataRow("PurSDate") = Trim(datPurSDate)
                    DataRow("PurEDate") = Trim(datPurEDate)
                    DataRow("PurDepoDate") = Trim(datPurDepoDate)
                    DataRow("PurAmt") = Trim(decPurAmt)
                    DataRow("PurQty") = Trim(intPurQty)
                    DataRow("PurCredit") = Trim(intPurCredit)
                    DataRow("PurDevStatus") = Trim(strPurDevStatus)
                    DataRow("PurHis") = Trim(strPurHis)
                    DataRow("PurRemark") = Trim(strPurRemark)
                    DataRow("PurSave") = False
                    DataRow("PurLock") = False
                    DataRow.EndEdit()

                    SaveDataSet(DataSet, "PurTbl")

                    CType(PurchaseHistoryRef, NewMemForm).PurchaseHistoryDataGridView.DataSource = GetTableData(intPurMemID, "PurMemID", "PurTbl")

                    If boolPurNew = True Then
                        boolPurNew = False
                    Else
                        If boolPurEdit = True Then
                            boolPurEdit = False
                        End If
                    End If
                    Me.Dispose()

                    strPurOrderNo = Nothing
                    strPurWarrNo = Nothing
                    strPurProdName = Nothing
                    intPurProdID = Nothing
                    datPurDate = Nothing
                    datPurDate = Nothing
                    datPurEDate = Nothing
                    datPurDepoDate = Nothing
                    decPurAmt = Nothing
                    intPurQty = Nothing
                    strPurHis = Nothing
                    strPurRemark = Nothing
                    intPurCredit = Nothing

                Catch ex As Exception
                    FatalError("Record update failed")

                End Try
            End If
        End If

    End Sub

    Private Sub CancelForm()

        Dim DataSet As DataSet
        DataSet = FillDataSet("PurTbl", True)
        Dim DataRow As DataRow

        If boolPurNew = True Then

            intPurID = CInt(Me.PurIDTextBox.Text)

            Try
                DataRow = DataSet.Tables("PurTbl").Rows.Find(intPurID)
                DataRow.Delete()
                SaveDataSet(DataSet, "PurTbl")

                boolPurNew = False
                Me.Dispose()
            Catch ex As Exception

            End Try
        Else
            If boolPurEdit = True Then

                intPurID = CInt(Me.PurIDTextBox.Text)

                Try
                    DataRow = DataSet.Tables("PurTbl").Rows.Find(intPurID)
                    DataRow.BeginEdit()
                    DataRow("PurLock") = False
                    DataRow.EndEdit()

                    SaveDataSet(DataSet, "PurTbl")

                    boolPurEdit = False
                    Me.Dispose()

                Catch ex As Exception
                    FatalError("Error")
                End Try
            Else
                Me.Dispose()
            End If
        End If

    End Sub

    Private Sub PurSDateDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles PurSDateDateTimePicker.ValueChanged

        Dim DataSet As DataSet
        DataSet = FillDataSet("ProdTbl", True)

        If Me.PurSDateDateTimePicker.Text <> "" Then
            datPurSDate = Me.PurSDateDateTimePicker.Text

            For Each DR As DataRow In DataSet.Tables("ProdTbl").Rows
                If DR("ProdID") = intPurProdID Then
                    datPurEDate = datPurSDate.AddMonths(DR("ProdWarranty"))
                End If
            Next

            PurEDateDateTimePicker.Text = datPurEDate
        End If

    End Sub

    Private Sub AddPurProLookupBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddPurProLookupBtn.Click

        Dim LookupForm As New ProdLookupform
        LookupForm.ProdLookupRef = Me
        LookupForm.ShowDialog()

    End Sub

    Private Sub PurDateDateTimePicker_ValueChanged(sender As System.Object, e As System.EventArgs) Handles PurDateDateTimePicker.ValueChanged

        If boolPurNew = True Then
            Me.PurSDateDateTimePicker.Text = Me.PurDateDateTimePicker.Text
            Me.PurDepoDateTimePicker.Text = Me.PurDateDateTimePicker.Text
        End If

    End Sub

    Private Sub PurQtyNumericUpDown_ValueChanged(sender As System.Object, e As System.EventArgs) Handles PurQtyNumericUpDown.ValueChanged

        intPurQty = Trim(PurQtyNumericUpDown.Value)
        Me.PurAmtNumericUpDown.Text = decPurAmt * intPurQty
        Me.PurCreditNumericUpDown.Value = intPurCredit * intPurQty



    End Sub


End Class