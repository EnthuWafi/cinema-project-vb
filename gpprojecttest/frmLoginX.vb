Public Class frmLoginX
    Dim myMain As frmMain
    Dim mySignUp As frmSignUpX

    Private Sub frmLoginX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CinemadbDataSet.customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CinemadbDataSet.customers)
        mySignUp = New frmSignUpX
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
        MessageBox.Show("Login Successful!", "Success!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Me.Hide()

        'new main forms
        myMain = New frmMain
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

    Private Sub frmLoginX_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

    End Sub


    Private Sub frmLoginX_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class
