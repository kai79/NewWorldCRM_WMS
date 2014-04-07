Public Class Admin

    Private Sub Admin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.RootTbl' table. You can move, or remove it, as needed.
        'Me.RootTblTableAdapter.Fill(Me.NewWorldDBDataSet.RootTbl)

        RefreshRoot()

    End Sub

    Private Sub RefreshRoot()

        Dim DataSet As DataSet
        DataSet = FillDataSet("RootTbl", True)

        Me.AdminDataGridView.DataSource = DataSet.Tables("RootTbl")

    End Sub

    Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
        Application.Exit()

    End Sub

    Private Sub NewUserBtn_Click(sender As System.Object, e As System.EventArgs) Handles NewUserBtn.Click

        Dim AdminNewUser As New AdminNewUser
        AdminNewUser.AdminNewUserRef = Me
        AdminNewUser.ShowDialog()

    End Sub

    Private Sub ResetPwBtn_Click(sender As System.Object, e As System.EventArgs) Handles ResetPwBtn.Click

        Dim i As Integer
        i = AdminDataGridView.CurrentRow.Index

        Dim DataSet As DataSet
        DataSet = FillDataSet("RootTbl", True)

        intRootID = AdminDataGridView.Item(0, i).Value
        strRootName = AdminDataGridView.Item(1, i).Value

        If Question("Are you sure you want to reset password for User: " & strRootName) = True Then

            intResetLoginID = intRootID
            boolResetPassword = True
            LoginSetPassword.ShowDialog()

            If boolResetPassword = False Then
                If strRootName <> "ADMIN" Then
                    Dim DataRow As DataRow
                    DataRow = DataSet.Tables("RootTbl").Rows.Find(intRootID)
                    DataRow.BeginEdit()
                    DataRow("RootFirstLog") = True
                    DataRow.EndEdit()

                    SaveDataSet(DataSet, "RootTbl")
                End If
                'Confirmation("Password reset successful")
            End If

        End If

    End Sub

    Private Sub DelBtn_Click(sender As System.Object, e As System.EventArgs) Handles DelBtn.Click

        Dim i As Integer
        i = AdminDataGridView.CurrentRow.Index

        intRootID = AdminDataGridView.Item(0, i).Value
        strRootName = AdminDataGridView.Item(1, i).Value

        If strRootName <> "admin" Then
            Dim DataSet As DataSet
            DataSet = FillDataSet("RootTbl", True)

            Dim DataRow As DataRow
            DataRow = DataSet.Tables("RootTbl").Rows.Find(intRootID)
            DataRow.Delete()

            SaveDataSet(DataSet, "RootTbl")
            RefreshRoot()
        Else
            FatalError("Cannot delete system account")
        End If

    End Sub

End Class