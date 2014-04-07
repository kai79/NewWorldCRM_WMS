Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        strGlobalLogin = UsernameTextBox.Text

        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim adapter As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet

        Try
            connection.ConnectionString = strConnectionString
            command.CommandText = "SELECT * FROM [RootTbl] WHERE RootName= '" & UsernameTextBox.Text & "';"
            connection.Open()

            command.Connection = connection

            adapter.SelectCommand = command
            adapter.Fill(dataset, "0")

            Dim count = dataset.Tables(0).Rows.Count

            If count > 0 Then

                intGlobalLoginID = dataset.Tables(0).Rows(0)("RootID")
                strGlobalLoginType = dataset.Tables(0).Rows(0)("RootType")

                If dataset.Tables(0).Rows(0)("RootFirstLog") = True Then
                    boolResetPassword = True
                    intResetLoginID = intGlobalLoginID
                    LoginSetPassword.ShowDialog()
                    If boolResetPassword = False Then
                        AccountSelection(dataset.Tables(0).Rows(0)("RootType"))
                    End If
                Else
                    If PasswordTextBox.Text = dataset.Tables(0).Rows(0)("RootPw") Then
                        AccountSelection(dataset.Tables(0).Rows(0)("RootType"))
                    Else
                        MsgBox("Incorrect password. Please check password", MsgBoxStyle.Critical)
                        PasswordTextBox.Clear()
                    End If
                End If
            Else
                MsgBox("Incorrect login ID. Please check username", MsgBoxStyle.Critical)
                PasswordTextBox.Clear()
            End If

        Catch ex As Exception
            FatalError("Error connecting to database. Please check your connection")
        End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Application.Exit()

    End Sub

    Private Sub AccountSelection(intType As String)

        Select Case intType
            Case "Admin" 'Admin
                Admin.Show()
                'If (dataset.Tables(0).Rows(0)("RootLock")) = 1 Then
                'MsgBox("Admin session is currently locked")
                'End If
            Case "CRM_User" 'User
                UsrForm.Show()
            Case "WH_User" 'Warehouse user
                WhForm.Show()
            Case "WH_Superuser" 'Warehouse superuser
                WhForm.Show()

        End Select

        Me.Hide()

    End Sub

End Class
