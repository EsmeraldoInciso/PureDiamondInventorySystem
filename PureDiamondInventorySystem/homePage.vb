Public Class homePage
    Private Sub btnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        brandPage.ShowDialog()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        inventoryPage.ShowDialog()
    End Sub

    Private Sub homePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'strcon.Open()
            'MsgBox("connected to db")
        Catch ex As Exception

        End Try
        RefreshDatagrid()
    End Sub



    Public Sub RefreshDatagrid()
        Try
            reloadBrandDatagrid("SELECT * FROM tbl_items", dgvHome)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
