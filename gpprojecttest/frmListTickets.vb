Public Class frmListTickets
    Private listOfTickets As ArrayList


    Public Sub setListOfTickets(ByRef listOfTickets As ArrayList)
        Me.listOfTickets = listOfTickets
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lboTickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboTickets.SelectedIndexChanged
        'when ticket is clicked
        If lboTickets.SelectedIndex <= 0 Then
            Return
        End If
        If MessageBox.Show("Discard this ticket?", "Option", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'if yes delete
            listOfTickets.RemoveAt(lboTickets.SelectedIndex - 1)
        End If
        LoadTickets()
    End Sub

    Private Sub frmListTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTickets()
    End Sub

    Private Sub LoadTickets()
        lboTickets.Items.Clear()

        lboTickets.Items.Add(String.Format("{0, -30}{1, -30}{2, -30}{3, -30}", "Movie Name", "Seat Number", "Age Category", "Ticket Price"))
        For i = 0 To listOfTickets.Count - 1
            Dim ticket As PendingTicket = listOfTickets(i)
            lboTickets.Items.Add(String.Format("{0, -35}{1, -38}{2, -37}{3, -30}", ticket.movie.strTitle, ticket.intSeatNumber,
                                 ticket.age_category, ticket.decPrice.ToString("C")))
        Next
    End Sub
End Class