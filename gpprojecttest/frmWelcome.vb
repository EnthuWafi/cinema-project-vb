Public Class frmWelcome
    Dim myLogin As frmLoginX
    Dim mySignUp As frmSignUpX
    Dim myAbout As frmAbout
    Dim myStaff As frmStaffWelcome

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myLogin = New frmLoginX
        mySignUp = New frmSignUpX
        myStaff = New frmStaffWelcome()
        myStaff.setWelcome(Me)

        myLogin.mySignUp = mySignUp
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        myLogin.ShowDialog()

        Me.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        mySignUp.ShowDialog()

        Me.Show()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'closes previous about form
        If myAbout IsNot Nothing Then
            myAbout.Dispose()
        End If

        myAbout = New frmAbout

        myAbout.Show()
    End Sub

    Private Sub mnuFileStaff_Click(sender As Object, e As EventArgs) Handles mnuFileStaff.Click
        Me.Hide()
        myStaff.ShowDialog()
    End Sub
End Class
