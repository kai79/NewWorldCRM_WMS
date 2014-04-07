Public Class PurSearchFilterform

    Public PurSearchFilterRef As Form

    Private Sub PurSearchCancelFilterBtn_Click(sender As System.Object, e As System.EventArgs) Handles PurSearchCancelFilterBtn.Click
        Me.Dispose()

    End Sub

    Private Sub PurSearchFilterOKBtn_Click(sender As System.Object, e As System.EventArgs) Handles PurSearchFilterOKBtn.Click

        PurSelectedColumn = CType(PurSearchFilterRef, MemPurchaseForm).FindColumn()
        PurFilterWord = Me.PurSearchFilterTextBox.Text
        PurFilterType = Me.PurSearchFilterComboBox.Text


        Dim filterStatus As Boolean = CType(PurSearchFilterRef, MemPurchaseForm).ApplyFilter(PurSelectedColumn, PurFilterWord, PurFilterType)

        If filterStatus = True Then
            Me.Dispose()
        End If

    End Sub

    Private Sub PurSearchFilterform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        PurSearchFilterComboBox.SelectedIndex = 0

    End Sub
End Class