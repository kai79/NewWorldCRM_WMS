Public Class AdminNewUser

    Public AdminNewUserRef As Form

    Private Sub CancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles CancelBtn.Click
        Me.Dispose()

    End Sub

    Private Sub CreateBtn_Click(sender As System.Object, e As System.EventArgs) Handles CreateBtn.Click

        If UserNameTxtBox.Text = "" Then
            FatalError("User ID field is empty")
        Else
            If Len(UserNameTxtBox.Text) > 10 Then
                FatalError("Username cannot be longer than 10 characters")
            Else
                If PwTxtBox.Text = "" Then
                    FatalError("Password field is empty")
                Else
                    If PwTxtBox.Text <> RePwTxtBox.Text Then
                        FatalError("Password does not match")
                    Else
                        If Len(PwTxtBox.Text) <= 7 Or Len(PwTxtBox.Text) >= 9 Then
                            FatalError("Password have contains 8 characters")
                        Else
                            Dim DataSet As DataSet
                            DataSet = FillDataSet("RootTbl", True)

                            If DataSet.Tables("RootTbl").Rows.Count > 0 Then
                                intRootID = DataSet.Tables("RootTbl")(DataSet.Tables("RootTbl").Rows.Count - 1)("RootID") + 1
                            Else
                                intRootID = 1
                            End If

                            strRootName = UserNameTxtBox.Text
                            strRootPw = PwTxtBox.Text
                            Select Case (UserTypeComboBox.Text)
                                Case "Admin"
                                    strRootType = "Admin"
                                Case "CRM_User"
                                    strRootType = "CRM_User"
                                Case "WH_User"
                                    strRootType = "WH_User"
                                Case "WH_Superuser"
                                    strRootType = "WH_Superuser"

                            End Select

                            If CheckDuplicate("SELECT RootName FROM RootTbl WHERE RootName='" & strRootName & "';") = True Then
                                FatalError("User ID " & strRootName & " already exists")
                            Else
                                Try
                                    Dim DataRow As DataRow = DataSet.Tables("RootTbl").NewRow
                                    DataRow("RootID") = intRootID
                                    DataRow("RootName") = strRootName
                                    DataRow("RootPw") = strRootPw
                                    DataRow("RootType") = strRootType
                                    DataRow("RootFirstLog") = 1
                                    DataRow("RootLock") = 0
                                    DataSet.Tables("RootTbl").Rows.Add(DataRow)

                                    SaveDataSet(DataSet, "RootTbl")

                                    CType(AdminNewUserRef, Admin).AdminDataGridView.DataSource = DataSet.Tables("RootTbl")
                                    'Confirmation("User ID created")
                                    Me.Dispose()

                                Catch ex As Exception
                                    FatalError("Error creating user")
                                End Try

                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub AdminNewUser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        UserTypeComboBox.SelectedIndex = 1

    End Sub
End Class