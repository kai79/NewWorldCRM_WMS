Public Class UsrForm

    Private Sub UsrForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        strGlobalLogin = "user"

    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddNewToolStripMenuItem.Click

        If boolMemNew = True Then
            Warning("Please cancel or save current record before proceed")
        Else
            If boolMemEdit = True Then
                Warning("Please close existing record before continue")
            Else
                Dim DataSet As DataSet
                DataSet = FillDataSet("MemTbl", True)

                If DataSet.Tables("MemTbl").Rows.Count > 0 Then
                    intMemID = DataSet.Tables("MemTbl")(DataSet.Tables("MemTbl").Rows.Count - 1)("MemID") + 1
                Else
                    intMemID = 1
                End If

                Dim DataRow As DataRow = DataSet.Tables("MemTbl").NewRow
                DataRow("MemID") = intMemID
                DataRow("MemLock") = True
                DataRow("MemLockUser") = strGlobalLogin
                DataSet.Tables("MemTbl").Rows.Add(DataRow)

                SaveDataSet(DataSet, "MemTbl")
                boolMemNew = True

                Dim MainForm As New NewMemForm
                MainForm.MdiParent = Me
                MainForm.Show()

                'boolMemRefresh = False
            End If
        End If

    End Sub

    Private Sub AddNewToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AddNewToolStripMenuItem1.Click

        If boolProductNew = True Then
            Warning("Please cancel or save current record before proceed")
        Else
            If boolProductEdit = True Then
                Warning("Please close existing record before continue")
            Else
                Dim DataSet As DataSet
                DataSet = FillDataSet("ProdTbl", True)

                If DataSet.Tables("ProdTbl").Rows.Count > 0 Then
                    intProductID = DataSet.Tables("ProdTbl")(DataSet.Tables("ProdTbl").Rows.Count - 1)("ProdID") + 1
                Else
                    intProductID = 1
                End If

                Dim DataRow As DataRow = DataSet.Tables("ProdTbl").NewRow
                DataRow("ProdID") = intProductID
                DataRow("ProdLock") = True
                DataRow("ProdLockUser") = strGlobalLogin
                DataSet.Tables("ProdTbl").Rows.Add(DataRow)

                SaveDataSet(DataSet, "ProdTbl")
                boolProductNew = True

                Dim NewProdForm As New NewProdForm
                NewProdForm.MdiParent = Me
                NewProdForm.Show()

                'boolProductRefresh = False

            End If
        End If

    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripMenuItem1.Click

        Dim ProdSearchForm As New ProdSearchForm
        ProdSearchForm.MdiParent = Me
        ProdSearchForm.Show()

        'boolProductRefresh = False

    End Sub

    Private Sub AddNewToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles AddNewToolStripMenuItem2.Click

        If boolMenuNew = True Then
            Warning("Please cancel or save current record before proceed")
        Else
            If boolMenuEdit = True Then
                Warning("Please close existing record before continue")
            Else
                Dim DataSet As DataSet
                DataSet = FillDataSet("MenuTbl", True)

                If DataSet.Tables("MenuTbl").Rows.Count > 0 Then
                    intMenuID = DataSet.Tables("MenuTbl")(DataSet.Tables("MenuTbl").Rows.Count - 1)("MenuID") + 1
                Else
                    intMenuID = 1
                End If

                Dim DataRow As DataRow = DataSet.Tables("MenuTbl").NewRow
                DataRow("MenuID") = intMenuID
                DataRow("MenuLock") = True
                DataRow("MenuLockUser") = strGlobalLogin
                DataSet.Tables("MenuTbl").Rows.Add(DataRow)

                SaveDataSet(DataSet, "MenuTbl")
                boolMenuNew = True

                Dim NewMenuForm As New NewMenuForm
                NewMenuForm.MdiParent = Me
                NewMenuForm.Show()

                'boolMenuRefresh = False
            End If

        End If

    End Sub

    Private Sub SearchToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripMenuItem2.Click

        Dim MenuSearchForm As New MenuSearchForm
        MenuSearchForm.MdiParent = Me
        MenuSearchForm.Show()

        'boolMenuRefresh = False

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripMenuItem.Click

        If NewMemSearchForm Is Nothing Then
            NewMemSearchForm = New MemSearchForm
            NewMemSearchForm.MdiParent = Me
        End If

        If boolMemSearchOpen <> True Then
            NewMemSearchForm.Show()
        Else
            NewMemSearchForm.BringToFront()
        End If

    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem.Click

        Dim LoadFileDialog As New OpenFileDialog
        LoadFileDialog.Filter = "SQL (*.sql)|*.sql"
        If (LoadFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            LoadQuery(LoadFileDialog.FileName)
        End If

    End Sub

    Private Sub MemberToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MemberToolStripMenuItem1.Click

        Dim ReportConfigForm As New ReportConfigForm
        ReportConfigForm.MdiParent = Me
        ReportConfigForm.Show()

    End Sub

    Private Sub ProductToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ProductToolStripMenuItem1.Click

        Dim ReportConfigProdForm As New ReportConfigProdForm
        ReportConfigProdForm.MdiParent = Me
        ReportConfigProdForm.Show()

    End Sub

    Private Sub ClassToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClassToolStripMenuItem.Click

        Dim ReportConfigMenuForm As New ReportConfigMenuForm
        ReportConfigMenuForm.MdiParent = Me
        ReportConfigMenuForm.Show()

    End Sub

    Private Sub UsrForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()

    End Sub

    Private Sub SearchPurchaseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchPurchaseToolStripMenuItem.Click

        If NewPurSearchForm Is Nothing Then
            NewPurSearchForm = New MemPurchaseForm
            NewPurSearchForm.MdiParent = Me
        End If

        If boolPurSearchOpen <> True Then
            NewPurSearchForm.Show()
        Else
            NewPurSearchForm.BringToFront()
        End If

    End Sub
End Class
