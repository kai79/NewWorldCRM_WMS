Public Class NewMenuForm

    Public NewMenuFormRef As Form

    Private Sub MenuTblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.MenuTblBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.NewWorldDBDataSet)

    End Sub

    Private Sub NewMenuForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.MenuTbl' table. You can move, or remove it, as needed.
        'Me.MenuTblTableAdapter.Fill(Me.NewWorldDBDataSet.MenuTbl)

        If boolMenuNew = True Then
            Me.MenuIDTextBox.Text = CStr(intMenuID)
            Me.MenuCreditNumericUpDown.Value = 1
        End If

    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Question("You will lose all unsaved data. Do you want to continue?") = True Then
            CancelForm()
        Else
            e.Cancel = True
            Exit Sub
        End If

    End Sub

    Private Sub NewMenuSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuSaveBtn.Click
        SaveForm()
    End Sub

    Private Sub NewMenuClearBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuClearBtn.Click
        ClearForm()
    End Sub

    Private Sub NewMenuCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuCancelBtn.Click
        CancelForm()
    End Sub

    Private Function SaveForm() As Boolean

        Dim boolReturn As Boolean

        If MenuNameTextBox.Text = "" Then
            FatalError("Menu Name cannot be empty." & vbCrLf & "Menu will not be saved.")
            boolReturn = False
            Me.MenuNameTextBox.BackColor = Color.OrangeRed
        Else
            If strMenuProdName = "" Then
                FatalError("No Product(s) have been added to this menu.")
                boolReturn = False
            Else
                intMenuID = MenuIDTextBox.Text()
                strMenuName = UCase(Trim(Me.MenuNameTextBox.Text))
                strMenuDesc = Trim(Me.MenuDescTextBox.Text)
                intMenuCredit = Trim(Me.MenuCreditNumericUpDown.Value)

                If boolMenuNew = True And CheckDuplicate("SELECT * FROM MenuTbl WHERE MenuName='" & strMenuName & "'") = True Then
                    FatalError("MenuName: " & strMenuName & " already exists" & vbCrLf & "Menu will not be saved.")
                    boolReturn = False
                Else

                    Dim DataSet As DataSet
                    DataSet = FillDataSet("MenuTbl", True)

                    Try
                        'Existing Records
                        Dim DataRow As DataRow
                        DataRow = DataSet.Tables("MenuTbl").Rows.Find(intMenuID)
                        DataRow.BeginEdit()
                        DataRow("MenuName") = strMenuName
                        DataRow("MenuDesc") = strMenuDesc
                        DataRow("MenuProdName") = strMenuProdName
                        DataRow("MenuCredit") = intMenuCredit
                        DataRow("MenuLock") = False
                        DataRow("MenuLockUser") = vbNull
                        DataRow.EndEdit()

                        SaveDataSet(DataSet, "MenuTbl")
                        Confirmation("Record updated successfully")
                        boolReturn = True

                        If boolMenuNew = True Then
                            boolMenuNew = False
                        Else
                            If boolMenuEdit = True Then
                                boolMenuEdit = False
                                'boolMenuRefresh = True

                            End If
                        End If
                        Me.Dispose()
                        Me.ClearVariable()

                    Catch ex As Exception
                        FatalError("Record update failed")
                    End Try
                End If
            End If
        End If

        SaveForm = boolReturn

    End Function

    Private Sub ClearForm()

        Me.MenuNameTextBox.Clear()
        Me.MenuDescTextBox.Clear()

    End Sub

    Private Sub CancelForm()

        intMenuID = MenuIDTextBox.Text()

        Dim DataSet As DataSet
        DataSet = FillDataSet("MenuTbl", True)
        Dim DataRow As DataRow

        If boolMenuNew = True Then

            Try
                DataRow = DataSet.Tables("MenuTbl").Rows.Find(intMenuID)
                DataRow.Delete()
                SaveDataSet(DataSet, "MenuTbl")

                boolMenuNew = False
                Me.Dispose()
                Me.ClearVariable()

            Catch ex As Exception

            End Try
        Else
            If boolMenuEdit = True Then

                Try
                    DataRow = DataSet.Tables("MenuTbl").Rows.Find(intMenuID)
                    DataRow.BeginEdit()
                    DataRow("MenuLock") = False
                    DataRow("MenuLockUser") = vbNull
                    DataRow.EndEdit()

                    SaveDataSet(DataSet, "MenuTbl")

                    boolMenuEdit = False
                    Me.Dispose()
                    Me.ClearVariable()

                Catch ex As Exception

                End Try
            Else
                Me.Dispose()

            End If
        End If
    End Sub

    Private Sub NewMenuAddProdBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewMenuAddProdBtn.Click

        Dim NewMenuAddProd As New NewMenuAddProdForm
        NewMenuAddProd.NewMenuAddProdRef = Me
        NewMenuAddProd.ShowDialog()

    End Sub

    Private Sub ClearVariable()

        intMenuID = Nothing
        strMenuName = Nothing
        strMenuDesc = Nothing
        strMenuProdName = Nothing

    End Sub

End Class