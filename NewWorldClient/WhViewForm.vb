Public Class WhViewForm

    Private Sub WhOutTblBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub WhOutViewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewWorldDBDataSet.WhItemTbl' table. You can move, or remove it, as needed.
        'Me.WhItemTblTableAdapter.Fill(Me.NewWorldDBDataSet.WhItemTbl)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click

        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document

        oWord = CreateObject("Word.Application")
        oWord.Visible = True

        Dim DataSet As New DataSet("WhItemTbl")
        Dim intRowCount As Integer = 0
        Dim intMaxCount As Integer
        Dim intPageMaxCount As Integer
        Dim intCurrentPage As Integer = 1
        Dim intDataRowCount As Integer = 0

        Dim objConnect As New SqlClient.SqlConnection(strConnectionString)
        objConnect.Open()

        Dim dataAdapter As New SqlClient.SqlDataAdapter("SELECT * FROM dbo.WhItemTbl WHERE WhItemDEvID='" & strWhViewDevID & "'", objConnect)

        dataAdapter.FillSchema(dataSet, SchemaType.Source, "WhItemTbl")
        dataAdapter.Fill(dataSet, "WhItemTbl")

        If DataSet.Tables("WhItemTbl").Rows.Count >= 0 Then

            intMaxCount = DataSet.Tables("WhItemTbl").Rows.Count
            intPageMaxCount = CType(Math.Ceiling(intMaxCount / 25), Integer)

            For Each DataRow In DataSet.Tables("WhItemTbl").Rows

                If intRowCount = 0 Then

                    oDoc = oWord.Documents.Add(strWhReportPath)

                    oDoc.Bookmarks.Item("DeliveryTo").Range.Text = strWhViewName
                    oDoc.Bookmarks.Item("Address").Range.Text = strWhViewAdd
                    oDoc.Bookmarks.Item("Contact").Range.Text = strWhViewCtc

                    oDoc.Bookmarks.Item("DeliveryOrder").Range.Text = strWhViewDevID
                    oDoc.Bookmarks.Item("PONo").Range.Text = strWhViewPoID

                    oDoc.Bookmarks.Item("ProcessBy").Range.Text = strWhViewProBy
                    oDoc.Bookmarks.Item("TimeStamp").Range.Text = strWhViewDevDate

                    oDoc.Bookmarks.Item("PageCount").Range.Text = intCurrentPage
                    oDoc.Bookmarks.Item("PageTotal").Range.Text = intPageMaxCount

                End If

                strWhViewProdName = DataSet.Tables("WhItemTbl").Rows(intDataRowCount)("WhItemProdName")
                strWhViewQty = DataSet.Tables("WhItemTbl").Rows(intDataRowCount)("WhItemQty")
                strWhViewRemark = DataSet.Tables("WhItemTbl").Rows(intDataRowCount)("WhItemRemark")

                strWhViewRemark = strWhViewRemark.Replace(vbCr, "").Replace(vbLf, "")

                oDoc.Bookmarks.Item("ProductDesc" & intRowCount).Range.Text = strWhViewProdName
                oDoc.Bookmarks.Item("Quantity" & intRowCount).Range.Text = strWhViewQty
                oDoc.Bookmarks.Item("Remarks" & intRowCount).Range.Text = Mid(strWhViewRemark, 1, 50)

                intRowCount = intRowCount + 1
                intDataRowCount = intDataRowCount + 1

                If intRowCount > 25 Then
                    intRowCount = 0
                    intCurrentPage = intCurrentPage + 1
                End If

            Next
        End If


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()

    End Sub

    Private Sub WhViewClose_Click(sender As System.Object, e As System.EventArgs) Handles WhViewClose.Click
        Me.Dispose()

    End Sub

End Class