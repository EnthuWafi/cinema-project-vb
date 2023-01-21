Public Class frmSeatSelection
    Private ticket As PendingTicket

    Public Sub New(ticket As PendingTicket, movie As Movie, ticketList As ArrayList)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'TODO: This line of code loads data into the 'CinemadbDataSet.purchase_line' table. You can move, or remove it, as needed.
        Me.Purchase_lineTableAdapter.Fill(Me.CinemadbDataSet.purchase_line)

        Dim dtSeat As New cinemadbDataSet.purchase_lineDataTable
        Purchase_lineTableAdapter.FillByShowtimeID(dtSeat, movie.intShowtimeID)

        Dim dtAuditorium As New cinemadbDataSet.auditoriumsDataTable
        AuditoriumsTableAdapter.FillAuditoriumByID(dtAuditorium, movie.intAuditoriumID)

        'code to disable occupied seats 
        'check if theres any
        If dtSeat.Rows.Count > 0 Then
            For i = 0 To dtSeat.Rows.Count - 1
                Dim strSeatNum = dtSeat.Rows(i)("seat_num")
                Dim rButton As RadioButton = grpSeatSelection.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Text = strSeatNum)

                rButton.Enabled = False
                rButton.FlatStyle = FlatStyle.Flat
            Next
        End If

        'check using pending ticketList
        For i = 0 To ticketList.Count - 1
            Dim temp As PendingTicket = ticketList(i)
            If (temp.intShowtimeID = ticket.intShowtimeID) Then
                Dim rButton As RadioButton = grpSeatSelection.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Text = temp.intSeatNumber.ToString)

                rButton.Enabled = False
                rButton.FlatStyle = FlatStyle.Flat
            End If

        Next

        lblAuditorium.Text = "Auditorium " & dtAuditorium.Rows(0)("auditorium_name")
        lblMovie.Text = movie.strTitle
        lblPrice.Text = ticket.decPrice.ToString("C")
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'find checked radio button
        Dim checkedRButton As RadioButton = grpSeatSelection.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        If checkedRButton Is Nothing Then
            Dim errorMsg As String = "Please check a Radio Button" & vbNewLine & "If all Radio Buttons are pre-occupied, we are sorry, but please pick another movie!"
            MessageBox.Show(errorMsg, "Unable to proceed.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If


        'radio button is found
        Dim intSeatNumber As Integer = Integer.Parse(checkedRButton.Text)

        ticket.intSeatNumber = intSeatNumber

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'by reference
    Public Sub setTicket(ByRef ticket As PendingTicket)
        Me.ticket = ticket
    End Sub

    Private Sub chkOKU_CheckedChanged(sender As Object, e As EventArgs) Handles chkOKU.CheckedChanged
        'discount
        If chkOKU.Checked Then
            ticket.decDiscount = 0.5D
            ticket.isOKU = True
        Else
            ticket.decDiscount = 0D
            ticket.isOKU = False
        End If

        Dim decPrice = ticket.decPrice - (ticket.decPrice * ticket.decDiscount)
        lblPrice.Text = decPrice.ToString("C")
    End Sub
End Class