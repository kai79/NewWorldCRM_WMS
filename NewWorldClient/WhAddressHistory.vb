Public Class WhAddressHistory

    Public WhAddHistoryRef As Form

    Private Sub WhAddressHistory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.WhCusTbl' table. You can move, or remove it, as needed.
        'Me.WhCusTblTableAdapter.Fill(Me.NewWorldDBDataSet.WhCusTbl)

        Me.RefreshContent()

    End Sub

    Private Sub RefreshContent()

        Dim DataSet As DataSet
        DataSet = FillDataSet("WhCusTbl", True)

        Me.AddHistoryDataGridView.DataSource = DataSet.Tables("WhCusTbl")
        Me.AddHistoryDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub WhAddHistoryNewBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddHistoryNewBtn.Click

        Dim strSearch As String
        strSearch = Me.WhAddHistoryTextBox.Text

        Dim objConn As New SqlClient.SqlConnection(strConnectionString)
        objConn.Open()

        'Create instance of data adapter
        Dim daTable As New SqlClient.SqlDataAdapter("SELECT * FROM dbo.WhCusTbl WHERE WhCusName LIKE '%" & strSearch & "%'", objConn)

        'Create instance of DataSet
        Dim dsTable As New DataSet("WhCusTbl")
        daTable.FillSchema(dsTable, SchemaType.Source, "WhCusTbl")
        daTable.Fill(dsTable, "WhCusTbl")

        Me.AddHistoryDataGridView.DataSource = dsTable.Tables("WhCusTbl")
        'Me.AddHistoryDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    Private Sub WhAddHistoryResetBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddHistoryResetBtn.Click
        Me.RefreshContent()

    End Sub

    Private Sub WhAddHistoryOKBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddHistoryOKBtn.Click
        OpenContent()

    End Sub

    Private Sub AddHistoryDataGridView_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles AddHistoryDataGridView.CellMouseDoubleClick
        Me.OpenContent()

    End Sub

    Private Sub OpenContent()

        Dim i As Integer
        i = Me.AddHistoryDataGridView.CurrentRow.Index

        Dim DataSet As DataSet
        DataSet = FillDataSet("WhCusTbl", True)

        intWhCusID = Me.AddHistoryDataGridView(0, i).Value
        strWhCusName = Me.AddHistoryDataGridView(1, i).Value
        strWhCusAdd = Me.AddHistoryDataGridView(2, i).Value
        strWhCusCtc = Me.AddHistoryDataGridView(3, i).Value
        'strWhCusLockUser = Me.AddHistoryDataGridView(4, i).Value
        boolWhCusLock = Me.AddHistoryDataGridView(5, i).Value

        CType(WhAddHistoryRef, WhForm).WhNameTextBox.Text = Trim(strWhCusName)
        CType(WhAddHistoryRef, WhForm).WhAddTextBox.Text = Trim(strWhCusAdd)
        CType(WhAddHistoryRef, WhForm).WhCtcTextBox.Text = Trim(strWhCusCtc)


        Me.Dispose()

    End Sub

    Private Sub WhAddhistoryCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddhistoryCancelBtn.Click
        Me.Dispose()
    End Sub
End Class