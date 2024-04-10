Public Class AdminForm
    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OhmysalondbDataSet.useraccounttb' table. You can move, or remove it, as needed.
        Me.UseraccounttbTableAdapter.Fill(Me.OhmysalondbDataSet.useraccounttb)

        Dim userAccount As New UC_UserAccount
        userAccount.Parent = pnlMain
        userAccount.Show()
        userAccount.Dock = DockStyle.Fill



    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub


End Class