Public Class ClassLookupForm

    Public ClassLookupRef As Form

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenMenu()

    End Sub

    Private Sub ShowAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowAllToolStripMenuItem.Click
        QueryMenu("ShowAll", intClsMemID)
    End Sub

    Private Sub ShowAttandedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowAttandedToolStripMenuItem.Click
        QueryMenu("Attended", intClsMemID)
    End Sub

    Private Sub ShowUnattendedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowUnattendedToolStripMenuItem.Click
        QueryMenu("Unattended", intClsMemID)
    End Sub

    Private Sub ClassLookupDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ClassLookupDataGridView.CellMouseDoubleClick
        OpenMenu()

    End Sub

    Private Sub QueryMenu(QueryType As String, UserID As Integer)

        Dim myConn As New SqlClient.SqlConnection(strConnectionString)
        Dim myTable As New DataTable()
        Dim myCmd As New SqlClient.SqlCommand()
        myCmd.Connection = myConn

        Select Case (QueryType)
            Case "ShowAll"
                sqlQuery = "SELECT * FROM MenuTbl"
            Case "Attended"
                sqlQuery = "SELECT * FROM MenuTbl, (SELECT * FROM ClsTbl WHERE (ClsMenuName<>'NULL') and (ClsMemId = " & UserID & ")) AS ClsTmpTbl WHERE MenuTbl.MenuID = ClsTmpTbl.ClsMenuID"
            Case Else
                sqlQuery = "SELECT * FROM MenuTbl WHERE (MenuName NOT IN (SELECT ClsMenuName FROM ClsTbl WHERE (ClsMenuName<>'NULL') and (ClsMemID = " & UserID & ")))"
        End Select
        myCmd.CommandText = sqlQuery

        Try
            Dim myAdapter As New SqlClient.SqlDataAdapter(myCmd)
            myAdapter.Fill(myTable)

            Me.ClassLookupDataGridView.DataSource = myTable

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ClassLookupForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.MenuTbl' table. You can move, or remove it, as needed.
        'Me.MenuTblTableAdapter.Fill(Me.NewWorldDBDataSet.MenuTbl)

        QueryMenu("Unattend", intClsMemID)

    End Sub

    Private Sub OpenMenu()

        Dim i As Integer
        i = ClassLookupDataGridView.CurrentRow.Index

        intClsMenuID = Me.ClassLookupDataGridView.Item(0, i).Value
        strClsMenuName = Me.ClassLookupDataGridView.Item(1, i).Value
        intClsCredit = Me.ClassLookupDataGridView.Item(4, i).Value

        CType(ClassLookupRef, ClassHistoryForm).ClsMenuNameTextBox.Text = Trim(strClsMenuName)
        Me.Dispose()

    End Sub

End Class