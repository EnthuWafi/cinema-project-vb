Public Class frmWelcome
    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim myLogin As New frmLoginX

        Me.Hide()
        myLogin.ShowDialog()

        Me.Show()


    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim mySignUp As New frmSignUpX

        Me.Hide()
        mySignUp.ShowDialog()
        Me.Show()

    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim myAbout As New frmAbout()
        myAbout.Show()
    End Sub
End Class
