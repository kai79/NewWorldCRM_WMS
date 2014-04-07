Public Class InfoForm

    Private Sub InfomForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        InfoTotalTextBox.Text = GetSQLValue("SELECT COUNT(*) FROM dbo.MemTbl WHERE MemNRIC IS NOT NULL")
        InfoEliteTextBox.Text = GetSQLValue("SELECT COUNT(*) FROM dbo.MemTbl WHERE MemNRIC IS NOT NULL AND MemRank='Elite'")
        InfoVVIPTextBox.Text = GetSQLValue("SELECT COUNT(*) FROM dbo.MemTbl WHERE MemNRIC IS NOT NULL AND MemRank='VVIP'")
        InfoVIPTextBox.Text = GetSQLValue("SELECT COUNT(*) FROM dbo.MemTbl WHERE MemNRIC IS NOT NULL AND MemRank='VIP'")
        InfoNormTextBox.Text = GetSQLValue("SELECT COUNT(*) FROM dbo.MemTbl WHERE MemNRIC IS NOT NULL AND MemRank='Normal'")

    End Sub

End Class