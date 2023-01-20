Public Class frmSignUpX

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'check if textBox are all valid
        Me.Validate()
        If txtFName.Text = String.Empty Then
            errorProvider.SetError(txtFName, "Must be filled")
            Return
        End If
        errorProvider.SetError(txtFName, "")

        If txtLName.Text = String.Empty Then
            errorProvider.SetError(txtLName, "Must be filled")
            Return
        End If
        errorProvider.SetError(txtLName, "")

        If txtEmail.Text = String.Empty Or Not (txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".com")) Then
            errorProvider.SetError(txtEmail, "Must be filled and valid")
            Return
        End If
        errorProvider.SetError(txtEmail, "")

        If txtUsername.Text = String.Empty Then
            errorProvider.SetError(txtUsername, "Must be filled")
            Return
        End If
        errorProvider.SetError(txtUsername, "")

        If txtPassword.Text = String.Empty Then
            errorProvider.SetError(txtPassword, "Must be filled")
            Return
        End If
        errorProvider.SetError(txtPassword, "")

        Try
            CustomersTableAdapter.InsertCustomer(txtFName.Text, txtLName.Text, txtEmail.Text,
                                            txtPhone.Text, txtAddress.Text, txtUsername.Text,
                                            txtPassword.Text)
            CustomersBindingSource.EndEdit()
            MessageBox.Show("Customer Account is Registered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearTextBox()

        Catch ex As Exception
            Dim strErrorMsg As String = vbTab & "Customer Account was Not Registered!" & vbNewLine & ex.ToString
            MessageBox.Show(strErrorMsg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearTextBox()
    End Sub

    Private Sub ClearTextBox()
        'just clears the textboxes
        txtFName.Clear()
        txtLName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub frmSignUpX_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class