Public Class frmSignUpX

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        'check if textBox are all valid
        Me.Validate()

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
End Class