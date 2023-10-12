Public Class brandPage
    Private temporaryBrandName As String = ""
    Private temporaryBrandStatus As String = ""


    Private Sub brandPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
        RefreshDatagrid()
    End Sub

    Public Sub reset()
        txtBrandID.Text = ""
        txtBrandName.Text = ""
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

    Private Sub RefreshDatagrid()
        Try
            reloadBrandDatagrid("SELECT * FROM tbl_brand", dgvBrandModule)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvBrandModule_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBrandModule.CellClick
        txtBrandID.Text = dgvBrandModule.CurrentRow.Cells(0).Value
        txtBrandName.Text = dgvBrandModule.CurrentRow.Cells(1).Value
        temporaryBrandName = dgvBrandModule.CurrentRow.Cells(1).Value
        cmbStatus.Text = dgvBrandModule.CurrentRow.Cells(2).Value
        temporaryBrandStatus = dgvBrandModule.CurrentRow.Cells(2).Value

        isViewing()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            If txtBrandName.Text = "" Then
                MessageBox.Show("BRAND NAME IS REQUIRED. PLEASE ENSURE TO ADD BRAND NAME.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                createBrand("INSERT INTO tbl_brand (BrandName, IsActive) VALUES ('" & txtBrandName.Text & "', '" & cmbStatus.SelectedItem & "')", txtBrandName.Text)
                reset()
                RefreshDatagrid()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If txtBrandName.Text <> temporaryBrandName Or cmbStatus.SelectedItem <> temporaryBrandStatus Then
                updateBrand("UPDATE tbl_brand SET BrandName = '" & txtBrandName.Text & "', IsActive = '" & cmbStatus.SelectedItem & "' WHERE BrandID = '" & txtBrandID.Text & "'", txtBrandName.Text)
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
            deleteBrand("DELETE FROM tbl_brand WHERE BrandID = '" & txtBrandID.Text & "'")
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
            reloadBrandDatagrid("SELECT * FROM tbl_brand WHERE BrandID LIKE'%" & txtSearch.Text & "%' OR BrandName LIKE '%" & txtSearch.Text & "%' OR IsActive LIKE '%" & txtSearch.Text & "%'", dgvBrandModule)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class