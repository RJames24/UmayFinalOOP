Public Class LoginForm

    Dim admin As String = "Administrator"
    Dim cashier As String = "Cashier"

    Private Sub btblogin_Click(sender As Object, e As EventArgs) Handles btblogin.Click

        'Administrator Login
        OpenCon()
        cmd.CommandText = "Select * from useraccounttb where username = '" & txtun.Text & "' and password = '" & txtpw.Text & "'  and usertype = '" & admin & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            AdminForm.Show()
            Me.Close()
            con.Close()
            Exit Sub
        End If
        con.Close()

        'Cashier Login
        OpenCon()
        cmd.CommandText = "Select * from useraccounttb where username = '" & txtun.Text & "' and password = '" & txtpw.Text & "'  and usertype = '" & cashier & "'"
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            CashierForm.Show()
            Me.Close()
        Else
            If String.IsNullOrEmpty(txtpw.Text) And String.IsNullOrEmpty(txtun.Text) Then
                MsgBox("Please input valid username or password", vbOKOnly + vbCritical, "INVALID LOGIN")
                txtun.Text = ""
                txtpw.Text = ""
                txtun.Focus()
            Else
                MsgBox("Wrong Username or Password!", vbOKOnly + vbCritical, "LOGIN ERROR")
                txtun.Text = ""
                txtpw.Text = ""
                txtun.Focus()
            End If

        End If
        con.Close()
    End Sub



End Class
