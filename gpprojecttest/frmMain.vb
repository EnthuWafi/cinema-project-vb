Public Class frmMain
    'keep track of current session
    Dim userID As String


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 5
            Dim movieBox As Movie = New Movie("cinema_red", "MOVIE NAME", "SCIFI", "1:50 Hours", "DATE HERE")
            flpMovie.Controls.Add(movieBox.flowLayout)
        Next
    End Sub

    Private Sub cboMovie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMovie.SelectedIndexChanged

    End Sub

    Private Sub btnSeatSelection_Click(sender As Object, e As EventArgs) Handles btnSeatSelection.Click
        Dim mySeat As New frmSeatSelection
        mySeat.ShowDialog()

    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim myPayment As New frmPayment(Me)

        Me.Hide()
        myPayment.ShowDialog()
    End Sub
End Class