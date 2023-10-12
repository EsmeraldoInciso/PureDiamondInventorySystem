Imports MySql.Data.MySqlClient

Module brandModule

    Public Sub createBrand(ByVal sql As String, ByVal stringToCheck As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("BRAND NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("NEW BRAND HAS BEEN ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            If ex.Message.ToLower = "duplicate entry '" & stringToCheck.ToLower & "' for key 'BrandName'" Then
                MessageBox.Show("BRAND NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub reloadBrandDatagrid(ByVal sql As String, ByVal dtv As Object)
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

    Public Sub reloadBrandCombobox(ByVal sql As String, ByVal cmbo As ComboBox)
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
            cmbo.DisplayMember = "CategoryName"
            cmbo.ValueMember = "CategoryID"
        Catch ex As Exception
            MessageBox.Show("Error   :" + ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub updateBrand(ByVal sql As String, ByVal stringToCheck As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("BRAND NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("BRAND HAS BEEN UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception

            If ex.Message.ToLower = "duplicate entry '" & stringToCheck.ToLower & "' for key 'menuname'" Then
                MessageBox.Show("BRAND NAME ALREADY EXISTS IN DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub deleteBrand(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Brand cannot be deleted. This item is referred to by another object.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("BRAND HAS BEEN DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

End Module
