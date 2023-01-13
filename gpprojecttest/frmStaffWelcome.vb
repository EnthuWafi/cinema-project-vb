Public Class frmStaffWelcome
    Dim myWelcome As frmWelcome
    Dim myHome As frmStaffHome


    Public Sub setWelcome(myWelcome As frmWelcome)
        Me.myWelcome = myWelcome
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Me.Hide()
        myHome.ShowDialog()
        Me.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
        myWelcome.Close()
    End Sub

    Private Sub mnuFileCustomer_Click(sender As Object, e As EventArgs) Handles mnuFileCustomer.Click
        Me.Hide()
        myWelcome.Show()
    End Sub

    Private Sub frmStaffWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myHome = New frmStaffHome
    End Sub

    Private Sub frmStaffWelcome_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        myWelcome.Close()
    End Sub
End Class