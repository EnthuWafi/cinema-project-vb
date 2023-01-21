Public Class frmListTickets
    Private listOfTickets As ArrayList


    Public Sub setListOfTickets(ByRef listOfTickets As ArrayList)
        Me.listOfTickets = listOfTickets
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmListTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTickets()
    End Sub

    Private Sub LoadTickets()
        dgvTicket.Rows.Clear()
        For i = 0 To listOfTickets.Count - 1
            Dim ticket As PendingTicket = listOfTickets(i)
            Dim decPrice = ticket.decPrice - (ticket.decPrice * ticket.decDiscount)
            dgvTicket.Rows.Add(ticket.movie.strTitle, ticket.intSeatNumber,
                                 ticket.age_category, decPrice.ToString("C"))
        Next
    End Sub



    Private Sub dgvTicket_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicket.CellClick
        'when ticket is clicked
        If e.RowIndex = -1 Then
            Return
        End If
        If MessageBox.Show("Discard this ticket?", "Option", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'if yes delete
            listOfTickets.RemoveAt(dgvTicket.CurrentCell.RowIndex)
        End If
        LoadTickets()
    End Sub
End Class