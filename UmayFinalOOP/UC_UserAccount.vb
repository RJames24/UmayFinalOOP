Public Class UC_UserAccount

    Private Sub EnableControls()
        btnAdd.Enabled = False
        btnEdit.Enabled = False
        btnArchive.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True

        txtUN.Enabled = True
        txtPW.Enabled = True
        txtCPW.Enabled = True
        txtLN.Enabled = True
        cboUT.Enabled = True
    End Sub

    Private Sub DisableControls()
        btnAdd.Enabled = True
        btnEdit.Enabled = True
        btnArchive.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False

        txtUN.Enabled = False
        txtPW.Enabled = False
        txtCPW.Enabled = False
        txtLN.Enabled = False
        cboUT.Enabled = False
    End Sub

    Private Sub textClear()
        txtUN.Clear()
        txtPW.Clear()
        txtCPW.Clear()
        cboUT.Items.Clear()
        txtLN.Clear()
    End Sub

    Private Sub refreshGrid()
        Me.UseraccounttbTableAdapter.Fill(Me.OhmysalondbDataSet.useraccounttb)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EnableControls()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'error trapping for required field
        If txtUN.Text = "" Or txtPW.Text = "" Or txtCPW.Text = "" Or txtLN.Text = "" Or cboUT.Text = "" Then
            MsgBox("Sorry all fields are required.", vbOKOnly + vbInformation, "SAVING ERROR")
            Exit Sub
        End If

        'error trapping for password not match 
        If txtPW.Text <> txtCPW.Text Then
            MsgBox("Sorry password do not match.", vbOKOnly + vbInformation, "SAVING ERROR")
            Exit Sub
        End If

        'error username is already exist
        If txtUN.Text <> txtDUN.Text Then
            OpenCon()
            cmd.CommandText = "Select * from useraccounttb where username = '" & txtUN.Text & "'"
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Username already exists.", vbOKOnly + vbInformation, "SAVING ERROR")
                con.Close()
                Exit Sub
            End If
            con.Close()
        End If

        'save code  bukas()
        OpenCon()
        cmd.CommandText = "insert into useraccounttb values(@un, @pw, @ut, @ln)"
        With cmd.Parameters
            .Clear()
            .AddWithValue("un", txtUN.Text)
            .AddWithValue("pw", txtPW.Text)
            .AddWithValue("ut", cboUT.Text)
            .AddWithValue("ln", txtLN.Text)
        End With
        cmd.ExecuteReader()
        con.Close()
        MsgBox("Record has been saved successfully.", vbOKOnly + vbInformation, "SAVING SUCCESS")
        DisableControls()
        txtUN.Text = ""
        txtPW.Text = ""
        txtCPW.Text = ""
        cboUT.Text = ""
        txtLN.Text = ""
        refreshGrid()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "EDIT" Then
            If txtUN.Text = "" Or txtPW.Text = "" Or txtCPW.Text = "" Or txtLN.Text = "" Or cboUT.Text = "" Then
                MsgBox("Select a record first.", vbOKOnly + vbInformation, "Error Editing")
            End If
            btnEdit.Text = "UPDATE"
            EnableControls()
            btnSave.Enabled = False
            btnEdit.Enabled = True
            txtUN.Enabled = False
            txtDUN.Text = txtUN.Text
            txtPW.Focus()


        ElseIf btnEdit.Text = "UPDATE" Then
            'error trapping for required field 
            If txtUN.Text = "" Or txtPW.Text = "" Or txtCPW.Text = "" Or txtLN.Text = "" Or cboUT.Text = "" Then
                MsgBox("All fields are required.", vbOKOnly + vbInformation, "Error Saving")
                Exit Sub
            End If

            'error trapping for incorrect password input 'username already exist
            If txtPW.Text <> txtCPW.Text Then
                MsgBox("Password do not match.", vbOKOnly + vbCritical, "Error Saving")
                Exit Sub
            End If

            'username already exist
            If txtPW.Text <> txtDUN.Text Then
                OpenCon()
                cmd.Connection = con
                cmd.CommandText = "select * from useraccounttb where username = '" & txtUN.Text & "'"
                cmd.ExecuteNonQuery()
                dr = cmd.ExecuteReader

                If dr.HasRows Then
                    MsgBox("Username already exists.", vbOKOnly + vbCritical, "Error Saving")
                    con.Close()
                    Exit Sub
                End If
                con.Close()
            End If

            'update code
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "update useraccounttb  set username = @un, password = @pw, usertype = @ut, loginname = @ln  where username = '" & txtUN.Text & "'"
            With cmd.Parameters
                .Clear()
                .AddWithValue("un", txtUN.Text)
                .AddWithValue("pw", txtPW.Text)
                .AddWithValue("ut", cboUT.Text)
                .AddWithValue("ln", txtLN.Text)
            End With
            cmd.ExecuteNonQuery()
            btnEdit.Text = "EDIT"
            DisableControls()
            refreshGrid()
            textClear()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnEdit.Text = "EDIT"
        DisableControls()
        'textClear()

    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        'Try To archive 
        OpenCon()
        cmd.CommandText = "Select * from useraccounttb where username = '" & txtUN.Text & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader

        If dr.HasRows Then

            If MsgBox("Do you want to remove this user account?", vbYesNo + vbCritical, "Remove User") = vbYes Then
                'Stores data of the selected row in variables that the next lines of code uses in order
                'to move it to the archive table
                dr.Read()
                Dim un = dr("username").ToString()
                Dim pw = dr("password").ToString()
                Dim ln = dr("loginname").ToString()
                Dim ut = dr("usertype").ToString()
                dr.Close()

                cmd.CommandText = "INSERT INTO user_archive VALUES (@un, @pw, @ut, @ln)"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@un", un)
                cmd.Parameters.AddWithValue("@pw", pw)
                cmd.Parameters.AddWithValue("@ut", ut)
                cmd.Parameters.AddWithValue("@ln", ln)
                cmd.ExecuteNonQuery()

                'Remove the selected row from the original source table
                cmd.CommandText = "DELETE FROM useraccounttb WHERE username = '" & txtUN.Text & "'"
                cmd.ExecuteNonQuery()
                con.Close()
                refreshGrid()
            End If

        End If
        con.Close()
    End Sub

    'If dr.HasRows Then
    '    MsgBox("Do you want to remove user?", vbYesNo + vbCritical, "Error Saving")
    '    If vbYes = True Then
    '        con.Close()
    '        OpenCon()
    '        cmd.CommandText = "insert into user_archive values(@un, @pw, @ut, @ln)"
    '        With cmd.Parameters
    '            .Clear()
    '            .AddWithValue("un", txtUN.Text)
    '            .AddWithValue("pw", txtPW.Text)
    '            .AddWithValue("ut", cboUT.Text)
    '            .AddWithValue("ln", txtLN.Text)
    '        End With
    '        cmd.ExecuteReader()
    '        con.Close()
    '        refreshGrid()

    '    End If
    '    con.Close()
    'End If

    Private Sub UC_UserAccount_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.UseraccounttbTableAdapter.Fill(Me.OhmysalondbDataSet.useraccounttb)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = DataGridView1.Rows(e.RowIndex)
            txtUN.Text = row.Cells(0).Value
            txtPW.Text = row.Cells(1).Value
            txtCPW.Text = row.Cells(1).Value
            cboUT.Text = row.Cells(3).Value
            txtLN.Text = row.Cells(2).Value
        End If
    End Sub
End Class
