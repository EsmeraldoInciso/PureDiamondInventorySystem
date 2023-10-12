Public Class inventoryPage
    Private temporaryItemName As String = ""
    Private temporaryItemPrice As String = ""
    Private temporaryItemUOM As String = ""
    Private temporaryBrandID As String = ""
    Private temporaryMinStock As String = ""
    Private temporaryReorderQty As String = ""
    Private temporaryIsActive As String = ""

    Private Sub inventoryPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
        RefreshDatagrid()
        RefreshCombobox()
    End Sub

    Private Sub reset()
        txtItemID.Text = ""
        txtItemName.Text = ""
        txtItemPrice.Text = "0.00"
        txtItemUOM.Text = "Pc"
        txtMinStock.Text = "0"
        txtReorderQTY.Text = "0"
        cmbStatus.Text = "Yes"
        txtSearch.Text = ""

        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub isViewing()
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnAdd.Enabled = False
    End Sub

    Private Sub txtItemPrice_Enter(sender As Object, e As EventArgs) Handles txtItemPrice.Enter, txtItemUOM.Enter, txtMinStock.Enter, txtReorderQTY.Enter
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        If textBox Is txtItemPrice And textBox.Text = "0.00" Then
            txtItemPrice.Text = ""
        ElseIf textBox Is txtItemUOM And textBox.Text = "Pc" Then
            txtItemUOM.Text = ""
        ElseIf textBox Is txtMinStock And textBox.Text = "0" Then
            txtMinStock.Text = ""
        ElseIf textBox Is txtReorderQTY And textBox.Text = "0" Then
            txtReorderQTY.Text = ""
        End If
    End Sub

    Private Sub txtItemPrice_Leave(sender As Object, e As EventArgs) Handles txtItemPrice.Leave, txtItemUOM.Leave, txtMinStock.Leave, txtReorderQTY.Leave
        If txtItemPrice.Text.Trim = "" And sender.GetHashCode.ToString.Equals(txtItemPrice.GetHashCode.ToString) Then
            txtItemPrice.Text = "0.00"
        ElseIf txtItemUOM.Text.Trim = "" And sender.GetHashCode.ToString.Equals(txtItemUOM.GetHashCode.ToString) Then
            txtItemUOM.Text = "Pc"
        ElseIf txtMinStock.Text.Trim = "" And sender.GetHashCode.ToString.Equals(txtMinStock.GetHashCode.ToString) Then
            txtMinStock.Text = "0"
        ElseIf txtReorderQTY.Text.Trim = "" And sender.GetHashCode.ToString.Equals(txtReorderQTY.GetHashCode.ToString) Then
            txtReorderQTY.Text = "0"
        End If
    End Sub





    Private Sub RefreshDatagrid()
        Try
            reloadItemDatagrid("SELECT * FROM tbl_items", dgvInventoryModule)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        homePage.RefreshDatagrid()
    End Sub

    Private Sub RefreshCombobox()
        Try
            reloadItemCombobox("SELECT * FROM tbl_brand", cmbBrandID)
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub

    Private Sub dgvInventoryModule_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventoryModule.CellClick
        txtItemID.Text = dgvInventoryModule.CurrentRow.Cells(0).Value
        txtItemName.Text = dgvInventoryModule.CurrentRow.Cells(1).Value
        temporaryItemName = dgvInventoryModule.CurrentRow.Cells(1).Value
        txtItemPrice.Text = dgvInventoryModule.CurrentRow.Cells(2).Value
        temporaryItemPrice = dgvInventoryModule.CurrentRow.Cells(2).Value
        txtItemUOM.Text = dgvInventoryModule.CurrentRow.Cells(3).Value
        temporaryItemUOM = dgvInventoryModule.CurrentRow.Cells(3).Value
        cmbBrandID.SelectedValue = dgvInventoryModule.CurrentRow.Cells(4).Value
        temporaryBrandID = dgvInventoryModule.CurrentRow.Cells(4).Value
        txtMinStock.Text = dgvInventoryModule.CurrentRow.Cells(5).Value
        temporaryMinStock = dgvInventoryModule.CurrentRow.Cells(5).Value
        txtReorderQTY.Text = dgvInventoryModule.CurrentRow.Cells(6).Value
        temporaryReorderQty = dgvInventoryModule.CurrentRow.Cells(6).Value
        cmbStatus.Text = dgvInventoryModule.CurrentRow.Cells(7).Value
        temporaryIsActive = dgvInventoryModule.CurrentRow.Cells(7).Value

        isViewing()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If txtItemName.Text = "" Then
                MessageBox.Show("ALL FIELDS ARE REQUIRED. PLEASE ENSURE ALL FILEDS ARE COMPLETED.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                createItem("INSERT INTO tbl_items (ItemName, ItemPrice, ItemUOM, BrandID, MinStock, ReorderQty, IsActive) VALUES ('" & txtItemName.Text & "', '" & txtItemPrice.Text & "', '" & txtItemUOM.Text & "', '" & cmbBrandID.SelectedValue & "', '" & txtMinStock.Text & "', '" & txtReorderQTY.Text & "', '" & cmbStatus.SelectedItem & "')", txtItemName.Text)
                reset()
                RefreshDatagrid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtItemName.Text <> temporaryItemName Or txtItemPrice.Text <> temporaryItemPrice Or txtItemUOM.Text <> temporaryItemUOM Or cmbBrandID.SelectedValue <> temporaryBrandID Or txtMinStock.Text <> temporaryMinStock Or txtReorderQTY.Text <> temporaryReorderQty Or cmbStatus.SelectedItem <> temporaryIsActive Then
                updateItem("UPDATE tbl_items SET ItemName = '" & txtItemName.Text & "', ItemPrice = '" & txtItemPrice.Text & "', ItemUOM = '" & txtItemUOM.Text & "', BrandID = '" & cmbBrandID.SelectedValue & "', MinStock = '" & txtMinStock.Text & "', ReorderQty = '" & txtReorderQTY.Text & "', IsActive = '" & cmbStatus.SelectedItem & "' WHERE ItemID = '" & txtItemID.Text & "'", txtItemName.Text)
            Else
                MessageBox.Show("SAME VALUE. NO CHANGES IN DATABASE", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        reset()
        RefreshDatagrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            deleteItem("DELETE FROM tbl_items WHERE ItemID = '" & txtItemID.Text & "'")
            reset()
            RefreshDatagrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        reset()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            reloadItemDatagrid("SELECT * FROM tbl_items WHERE ItemID LIKE'%" & txtSearch.Text & "%' OR ItemName LIKE '%" & txtSearch.Text & "%' OR IsActive LIKE '%" & txtSearch.Text & "%'", dgvInventoryModule)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class