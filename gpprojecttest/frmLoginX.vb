Public Class frmLoginX
    Dim myMain As frmMain
    Public mySignUp As frmSignUpX

    Private Sub frmLoginX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CinemadbDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CinemadbDataSet.customers)

        'for convenience
        txtUsername.Text = "user"
        txtPassword.Text = "user"
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        'check username and password
        Me.Validate()

        'data table
        Dim dt As New cinemadbDataSet.customersDataTable

        Me.CustomersTableAdapter.SearchCustomer(dt, txtUsername.Text, txtPassword.Text)

        If dt.Rows.Count() <= 0 Then
            MessageBox.Show("Invalid Username or Password", "Error!", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            Return
        End If

        'success

        'make new user object
        Dim strUserID, strUsername, strFName, strLName As String
        strUserID = dt.Rows(0)("cust_id")
        strUsername = dt.Rows(0)("cust_username")
        strFName = dt.Rows(0)("cust_fname")
        strLName = dt.Rows(0)("cust_lname")

        Dim user As New User(strUserID, strUsername, strFName, strLName)
        'hide current form
        Me.Hide()

        'new main form
        myMain = New frmMain(user)
        'success msg
        MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        myMain.ShowDialog()
        myMain.Dispose()

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Me.Hide()
        mySignUp.ShowDialog()
        Me.Close()
    End Sub

    Private Sub frmLoginX_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class
