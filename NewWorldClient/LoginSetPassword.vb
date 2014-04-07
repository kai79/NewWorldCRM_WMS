Public Class LoginSetPassword

    Private Sub SetPWSaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SetPWSaveButton.Click

        If SetPwTxtBox.Text = "" Then
            FatalError("Password field is empty")
        Else

            If SetPwTxtBox.Text <> ReSetPwTxtBox.Text Then
                FatalError("Password does not match")
            Else
                If Len(SetPwTxtBox.Text) <= 7 Or Len(SetPwTxtBox.Text) >= 9 Then
                    FatalError("Password must contains 8 characters")
                Else

                    Dim DataSet As DataSet
                    DataSet = FillDataSet("RootTbl", True)

                    Dim DataRow As DataRow
                    DataRow = DataSet.Tables("RootTbl").Rows.Find(intResetLoginID)
                    DataRow.BeginEdit()
                    DataRow("RootPw") = SetPwTxtBox.Text
                    DataRow("RootFirstLog") = False
                    DataRow.EndEdit()

                    SaveDataSet(DataSet, "RootTbl")

                    boolResetPassword = False

                    Me.Dispose()

                End If
            End If
        End If
    End Sub

    Private Sub SetPwCancelButton_Click(sender As System.Object, e As System.EventArgs) Handles SetPWCancelButton.Click
        Me.Dispose()

    End Sub
End Class