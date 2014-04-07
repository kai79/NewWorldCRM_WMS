Public Class AddRefFilterForm

    Public AddRefFilterRef As Form

    Private Sub AddRefFilterOKBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddRefFilterOKBtn.Click

        Dim selectedColumn As Integer = CType(AddRefFilterRef, AddRefForm).FindColumn()
        Dim FilterWord As String = Me.AddRefFilterTextBox.Text
        Dim FilterType As String = Me.AddRefFilterComboBox.Text


        Dim filterStatus As Boolean = CType(AddRefFilterRef, AddRefForm).ApplyFilter(selectedColumn, FilterWord, FilterType)

        If filterStatus = True Then
            Me.Dispose()
        End If

    End Sub

    Private Sub AddRefFilterCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddRefFilterCancelBtn.Click
        Me.Dispose()
    End Sub

    Private Sub AddRefFilterForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        AddRefFilterComboBox.SelectedIndex = 0

    End Sub
End Class