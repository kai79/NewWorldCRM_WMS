Public Class MemSearchFilterForm

    Public MemSearchFilterRef As Form

    Private Sub MemSearchFilterOKBtn_Click(sender As System.Object, e As System.EventArgs) Handles MemSearchFilterOKBtn.Click

        MemSelectedColumn = CType(MemSearchFilterRef, MemSearchForm).FindColumn()
        MemFilterWord = Me.MemSearchFilterTextBox.Text
        MemFilterType = Me.MemSearchFilterComboBox.Text


        Dim filterStatus As Boolean = CType(MemSearchFilterRef, MemSearchForm).ApplyFilter(MemSelectedColumn, MemFilterWord, MemFilterType)

        If filterStatus = True Then
            Me.Dispose()
        End If

    End Sub

    Private Sub MemSearchfilterCanBtn_Click(sender As System.Object, e As System.EventArgs) Handles MemSearchfilterCanBtn.Click
        Me.Dispose()

    End Sub

    Private Sub MemSearchFilterForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        MemSearchFilterComboBox.SelectedIndex = 0

    End Sub
End Class