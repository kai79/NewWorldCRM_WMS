Public Class WhAddNewProdForm

    Public WhAddNewProdFormRef As Form

    Private Sub WhAddNewProdForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.WhAddNewProdExCatRadioBtn.Checked = True
        Me.WhAddNewProdNwCatRadioBtn.Checked = False

        WhAddNewProdExCatComboBox.DataSource = FillCategoryCombo()
        WhAddNewProdExCatComboBox.DisplayMember = "WhProdCat"

        Me.WhAddNewProdExCatComboBox.Enabled = True
        Me.WhAddNewProdNwCatTexBox.Enabled = False

    End Sub

    Private Sub WhAddNewProdExCatRadioBtn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles WhAddNewProdExCatRadioBtn.MouseClick

        Me.WhAddNewProdExCatRadioBtn.Checked = True
        Me.WhAddNewProdNwCatRadioBtn.Checked = False

        WhAddNewProdExCatComboBox.DataSource = FillCategoryCombo()
        WhAddNewProdExCatComboBox.DisplayMember = "WhProdCat"

        Me.WhAddNewProdExCatComboBox.Enabled = True
        Me.WhAddNewProdNwCatTexBox.Enabled = False

    End Sub

    Private Sub WhAddNewProdNwCatRadioBtn_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles WhAddNewProdNwCatRadioBtn.MouseClick

        Me.WhAddNewProdExCatRadioBtn.Checked = False
        Me.WhAddNewProdNwCatRadioBtn.Checked = True

        Me.WhAddNewProdExCatComboBox.Enabled = False
        Me.WhAddNewProdNwCatTexBox.Enabled = True

    End Sub

    Private Sub WhAddNewProdSaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddNewProdSaveBtn.Click

        WhAddNewProdTextBox.BackColor = SystemColors.Window
        WhAddNewProdNoTextBox.BackColor = SystemColors.Window
        WhAddNewProdNwCatTexBox.BackColor = SystemColors.Window

        Dim boolDupProdCat As Boolean = False

        If Me.WhAddNewProdExCatRadioBtn.Checked = True Then
            strWhProdCat = UCase(Me.WhAddNewProdExCatComboBox.Text)
        Else
            strWhProdCat = UCase(Me.WhAddNewProdNwCatTexBox.Text)

            If CheckDuplicate("SELECT * FROM WhProdTbl WHERE WhProdCat='" & strWhProdCat & "'") = True Then
                FatalError("Product Category: " & strWhProdCat & " already exists" & vbCrLf & "Please check Product Category.")
                boolDupProdCat = True
            End If
        End If

        If boolDupProdCat = False Then
            strWhProdName = UCase(Me.WhAddNewProdTextBox.Text)

            If Me.WhAddNewProdTextBox.Text = "" Then
                FatalError("Product Name cannot be empty")
                WhAddNewProdTextBox.BackColor = Color.OrangeRed
            Else
                If Me.WhAddNewProdNoTextBox.Text = "" Then
                    FatalError("Product Number cannot be empty")
                    WhAddNewProdNoTextBox.BackColor = Color.OrangeRed
                Else
                    If Me.WhAddNewProdNwCatRadioBtn.Checked = True And Me.WhAddNewProdNwCatTexBox.Text = "" Then
                        FatalError("New Product Category cannot be empty")
                        WhAddNewProdNwCatTexBox.BackColor = Color.OrangeRed
                    Else
                        If CheckDuplicate("SELECT * FROM WhProdTbl WHERE WhProdName='" & strWhProdName & "'") = True Then
                            FatalError("Product Name: " & strWhProdName & " already exists" & vbCrLf & "Please check Product Name.")
                        Else

                            strWhProdNo = Me.WhAddNewProdNoTextBox.Text

                            Dim DataSet As DataSet
                            DataSet = FillDataSet("WhProdTbl", True)

                            If DataSet.Tables("WhProdTbl").Rows.Count > 0 Then
                                intWhProdID = DataSet.Tables("WhProdTbl")(DataSet.Tables("WhProdTbl").Rows.Count - 1)("WhProdID") + 1
                            Else
                                intWhProdID = 1
                            End If

                            Dim DataRow As DataRow = DataSet.Tables("WhProdTbl").NewRow
                            DataRow("WhProdID") = intWhProdID
                            DataRow("WhProdName") = UCase(strWhProdName)
                            DataRow("WhProdNo") = strWhProdNo
                            DataRow("WhProdCat") = UCase(strWhProdCat)
                            DataRow("WhProdCurQty") = 0
                            DataRow("WhProdEnable") = True
                            DataSet.Tables("WhProdTbl").Rows.Add(DataRow)

                            SaveDataSet(DataSet, "WhProdTbl")


                            CType(WhAddNewProdFormRef, WhAddProdForm).WhAddProdCatComboBox.DataSource = FillCategoryCombo()
                            CType(WhAddNewProdFormRef, WhAddProdForm).WhAddProdCatComboBox.DisplayMember = "WhProdCat"

                            CType(WhAddNewProdFormRef, WhAddProdForm).WhAddProdCatComboBox.Text = strWhProdCat
                            CType(WhAddNewProdFormRef, WhAddProdForm).WhAddProdComboBox.Text = strWhProdName

                            Me.Dispose()

                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Function FillCategoryCombo() As DataTable

        Dim dataSet As New DataSet
        Using connection As New SqlClient.SqlConnection(strConnectionString)

            Dim adapter As New SqlClient.SqlDataAdapter
            adapter.SelectCommand = New SqlClient.SqlCommand("SELECT DISTINCT(WhProdCat) FROM WhProdTbl", connection)
            adapter.Fill(dataSet)

        End Using

        FillCategoryCombo = dataSet.Tables(0)

    End Function

    Private Sub WhAddNewProdCancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles WhAddNewProdCancelBtn.Click

        Me.Dispose()

    End Sub
End Class