Imports MySql.Data.MySqlClient

Module inventoryModule
    Public Sub createItem(ByVal sql As String, ByVal stringToCheck As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("ITEM NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("NEW ITEM HAS BEEN ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            If ex.Message.ToLower = "duplicate entry '" & stringToCheck.ToLower & "' for key 'BrandName'" Then
                MessageBox.Show("ITEM NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reloadItemDatagrid(ByVal sql As String, ByVal dtv As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtv.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub reloadItemCombobox(ByVal sql As String, ByVal cmbo As ComboBox)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            cmbo.DataSource = dt
            cmbo.DisplayMember = "BrandName"
            cmbo.ValueMember = "BrandID"
        Catch ex As Exception
            MessageBox.Show("Error   :" + ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updateItem(ByVal sql As String, ByVal stringToCheck As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("ITEM NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("ITEM HAS BEEN UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception

            If ex.Message.ToLower = "duplicate entry '" & stringToCheck.ToLower & "' for key 'menuname'" Then
                MessageBox.Show("ITEM NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub deleteItem(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Item cannot be deleted. This item is referred to by another object.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("ITEM HAS BEEN DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
End Module
