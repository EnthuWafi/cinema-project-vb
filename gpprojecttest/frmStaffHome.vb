Public Class frmStaffHome

    Private Sub btnMovie_Click(sender As Object, e As EventArgs) Handles btnMovie.Click
        Dim myMovie As New frmStaffMovie
        myMovie.ShowDialog()

    End Sub

    Private Sub btnShowtimes_Click(sender As Object, e As EventArgs) Handles btnShowtimes.Click
        Dim myShowtime As New frmStaffShowtime
        myShowtime.ShowDialog()
    End Sub

    Private Sub btnInvoice_Click(sender As Object, e As EventArgs) Handles btnInvoice.Click
        Dim myInvoice As New frmStaffTransaction
        myInvoice.ShowDialog()
    End Sub
End Class