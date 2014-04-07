Public Class ClassHistoryForm

    Public ClassHistoryRef As Form

    Private Sub ClsTblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.ClsTblBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.NewWorldDBDataSet)

    End Sub

    Private Sub ClassHistoryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.ClsTbl' table. You can move, or remove it, as needed.
        'Me.ClsTblTableAdapter.Fill(Me.NewWorldDBDataSet.ClsTbl)

        If boolClsNew = True Then
            Me.ClsIDTextBox.Text = CStr(intClsID)
        End If

    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.CancelForm()
    End Sub

    Private Sub ClsHisLookupBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClsHisLookupBtn.Click

        Dim ClassLookupForm As New ClassLookupForm
        ClassLookupForm.ClassLookupRef = Me
        ClassLookupForm.ShowDialog()

    End Sub

    Private Sub ClsHisSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClsHisSaveBtn.Click
        SaveForm()

    End Sub

    Private Sub ClsHisCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClsHisCancelBtn.Click
        CancelForm()

    End Sub

    Private Sub SaveForm()

        If ClsMenuNameTextBox.Text = "" Then
            FatalError("Menu name is empty")
        Else

            intClsID = CInt(Me.ClsIDTextBox.Text)
            strClsMenuName = Me.ClsMenuNameTextBox.Text
            datClsDate = Me.ClsDateDateTimePicker.Text

            Dim DataSet As DataSet

            'Find Menu ID
            'DataSet = FillDataSet("MenuTbl")
            'Dim FoundRow() As DataRow
            'FoundRow = DataSet.Tables("MenuTbl").Select("MenuName Like '" & strClsMenuName & "'")
            'If (Not FoundRow Is Nothing) Then
            'intClsMenuID = FoundRow(0).Item("MenuID")
            'intClsCredit = FoundRow(0).Item("MenuCredit")
            'End If

            DataSet = FillDataSet("ClsTbl", True)

            Try
                'Existing Records
                Dim DataRow As DataRow
                DataRow = DataSet.Tables("ClsTbl").Rows.Find(intClsID)
                DataRow.BeginEdit()
                DataRow("ClsID") = Trim(intClsID)
                DataRow("ClsMemID") = Trim(intClsMemID)
                DataRow("ClsMenuID") = Trim(intClsMenuID)
                DataRow("ClsMenuName") = Trim(strClsMenuName)
                DataRow("ClsCredit") = Trim(intClsCredit)
                DataRow("ClsDate") = Trim(datClsDate)
                DataRow("ClsSave") = False
                DataRow("ClsLock") = False
                DataRow.EndEdit()

                SaveDataSet(DataSet, "ClsTbl")

                If boolClsNew = True Then
                    boolClsNew = False
                Else
                    If boolClsEdit = True Then
                        boolClsEdit = False
                    End If
                End If

                CType(ClassHistoryRef, NewMemForm).ClassHistoryDataGridView.DataSource = GetTableData(intClsMemID, "ClsMemID", "ClsTbl")

                Me.Dispose()

                intClsID = Nothing
                intClsMemID = Nothing
                strClsMenuName = Nothing
                intClsCredit = Nothing
                datClsDate = Nothing

            Catch ex As Exception
                FatalError("Record update failed")

            End Try
        End If

    End Sub

    Private Sub CancelForm()

        Dim DataSet As DataSet
        DataSet = FillDataSet("ClsTbl", True)
        Dim DataRow As DataRow

        If boolClsNew = True Then
            intClsID = Me.ClsIDTextBox.Text()
            Try
                DataRow = DataSet.Tables("ClsTbl").Rows.Find(intClsID)
                DataRow.Delete()
                SaveDataSet(DataSet, "ClsTbl")

                boolClsNew = False
                Me.Dispose()
            Catch ex As Exception

            End Try
        Else
            If boolClsEdit = True Then
                intClsID = Me.ClsIDTextBox.Text()
                Try
                    DataRow = DataSet.Tables("ClsTbl").Rows.Find(intClsID)
                    DataRow.BeginEdit()
                    DataRow("ClsLock") = False
                    DataRow.EndEdit()

                    SaveDataSet(DataSet, "ClsTbl")

                    boolClsEdit = False
                    Me.Dispose()

                Catch ex As Exception
                    FatalError("Error")
                End Try
            Else
                Me.Dispose()
            End If
        End If

    End Sub

End Class