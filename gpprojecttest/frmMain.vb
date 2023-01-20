Imports System.ComponentModel

Public Class frmMain
    'keep track of current user session
    Dim user As User

    Dim movieList As New ArrayList
    Dim ticketList As New ArrayList

    Dim currentMovie As Movie
    Dim currentTicket As PendingTicket


    Public Sub New(ByRef user As User)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.user = user
        'TODO: This line of code loads data into the 'CinemadbDataSet.auditoriums' table. You can move, or remove it, as needed.
        Me.AuditoriumsTableAdapter.Fill(Me.CinemadbDataSet.auditoriums)
        'TODO: This line of code loads data into the 'CinemadbDataSet.ticket_price' table. You can move, or remove it, as needed.
        Me.Ticket_priceTableAdapter.Fill(Me.CinemadbDataSet.ticket_price)
        'TODO: This line of code loads data into the 'CinemadbDataSet.showtimes' table. You can move, or remove it, as needed.
        Me.ShowtimesTableAdapter.Fill(Me.CinemadbDataSet.showtimes)


        'set minimum date to "current" day
        dtpDate.MinDate = New DateTime(2023, 1, 9)
        dtpDate.Value = dtpDate.MinDate
        'focus on control
        ActiveControl = cboMovie

        'should be disabled
    End Sub

    Private Sub btnSeatSelection_Click(sender As Object, e As EventArgs) Handles btnSeatSelection.Click
        'check all the input and see whether they're valid or not
        If currentMovie Is Nothing Then
            MessageBox.Show("Please pick a movie first.", "Sorry")
            cboMovie.Select()
            errorProvider.SetError(cboMovie, "Must be selected!")
            Return
        End If
        errorProvider.SetError(cboMovie, "")
        If currentTicket Is Nothing Then
            MessageBox.Show("Please pick a category first.", "Sorry")
            cboCategory.Select()
            errorProvider.SetError(cboCategory, "Must be selected!")
            Return
        End If
        errorProvider.SetError(cboCategory, "")

        Dim mySeat As New frmSeatSelection(currentTicket, currentMovie, ticketList)
        mySeat.ShowDialog()

        currentTicket.intSeatNumber = mySeat.getTicket().intSeatNumber

        If currentTicket.intSeatNumber <> -1 Then
            lblSeat.Text = "Seat Number: " & currentTicket.intSeatNumber.ToString
        End If
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'check for tickets
        If ticketList.Count() <= 0 Then
            'alert user
            If MessageBox.Show("Are you sure you want to proceed?", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                Return
            End If
        End If

        Dim myPayment As New frmPayment(ticketList, user)
        myPayment.setMain(Me)

        Me.Hide()
        myPayment.ShowDialog()
    End Sub

    Private Sub UpdateShowtimes()
        'clear
        flpMovie.Controls.Clear()
        cboMovie.Items.Clear()
        movieList.Clear()

        Dim dt As New cinemadbDataSet.showtimesDataTable
        ShowtimesTableAdapter.FillShowtimeInformation(dt, dtpDate.Value, dtpDate.Value.AddDays(1))

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No showtime on this date", "Sorry.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            btnProceed.Enabled = False
            btnSeatSelection.Enabled = False
            btnTicket.Enabled = False
            btnListOfTicket.Enabled = False
            Return
        End If

        For i = 0 To dt.Rows.Count() - 1
            Dim intShowtimeID, intMovieID, intAuditoriumID As Integer
            Dim strPic, strTitle, strGenre As String
            Dim decDuration As Decimal
            Dim strShowtime, strEndtime As DateTime
            Dim strDesc, strReleaseDate As String

            intShowtimeID = dt.Rows(i)("showtime_id")
            intMovieID = dt.Rows(i)("movie_id")
            intAuditoriumID = dt.Rows(i)("auditorium_id")
            strPic = dt.Rows(i)("movie_img")
            strTitle = dt.Rows(i)("movie_name")
            strGenre = dt.Rows(i)("genre")
            decDuration = dt.Rows(i)("duration")
            strShowtime = dt.Rows(i)("start_time")
            strEndtime = dt.Rows(i)("end_time")
            strDesc = dt.Rows(i)("movie_desc")
            strReleaseDate = dt.Rows(i)("release_date")

            Dim mov As New Movie(intShowtimeID, intMovieID, intAuditoriumID, strPic, strTitle, strGenre, decDuration, strShowtime, strEndtime,
                                strDesc, strReleaseDate)

            movieList.Add(mov)
            flpMovie.Controls.Add(mov.flowLayout)
            cboMovie.Items.Add(strTitle)

        Next

        btnProceed.Enabled = True
        btnSeatSelection.Enabled = True
        btnTicket.Enabled = True
        btnListOfTicket.Enabled = True
    End Sub

    'when add ticket is triggered
    Private Sub btnTicket_Click(sender As Object, e As EventArgs) Handles btnTicket.Click
        Validate()
        'check all the input and see whether they're valid or not
        If currentMovie Is Nothing Then
            MessageBox.Show("Please pick a movie first.", "Sorry")
            cboMovie.Select()
            errorProvider.SetError(cboMovie, "Must be selected!")
            Return
        End If
        errorProvider.SetError(cboMovie, "")
        If currentTicket Is Nothing Then
            MessageBox.Show("Please pick a category first.", "Sorry")
            cboCategory.Select()
            errorProvider.SetError(cboCategory, "Must be selected!")
            Return
        End If
        errorProvider.SetError(cboCategory, "")
        'check if no seat? 
        If currentTicket.intSeatNumber = -1 Then
            MessageBox.Show("Please pick a seat first!", "Cannot do that!")
            btnSeatSelection.Select()
            errorProvider.SetError(btnSeatSelection, "Must be selected!")
            Return
        End If
        errorProvider.SetError(btnSeatSelection, "")

        'add ticket to list
        ticketList.Add(currentTicket)

        'update label ticket count
        lblTicketCount.Text = "Ticket Count: " & ticketList.Count

        'reset form
        currentTicket = Nothing
        currentMovie = Nothing
        cboMovie.SelectedIndex = -1
        cboCategory.SelectedIndex = -1

        lblMovie.Text = "Movie: "
        lblPrice.Text = "Price: "
        lblSeat.Text = "Seat Number: "
        MessageBox.Show("Ticket added.")
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        UpdateShowtimes()
    End Sub

    Private Sub cboMovie_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboMovie.SelectionChangeCommitted
        'get movie

        For i = 0 To movieList.Count() - 1
            Dim mov As Movie = movieList.Item(i)
            If mov.strTitle = cboMovie.Text Then
                currentMovie = mov
                Exit For
            End If
        Next
        'change label
        lblMovie.Text = "Movie:" & currentMovie.strTitle

        'reset category
        cboCategory.SelectedIndex = -1
    End Sub

    Private Sub cboCategory_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboCategory.SelectionChangeCommitted
        If currentMovie Is Nothing Then
            cboMovie.Select()
            errorProvider.SetError(cboMovie, "Must be selected!")
            Return
        End If
        errorProvider.SetError(cboMovie, "")

        Dim dt As New cinemadbDataSet.showtimesDataTable
        ShowtimesTableAdapter.FillByShowtimeAndCategory(dt, currentMovie.intShowtimeID, cboCategory.Text)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Something went wrong.. Report this error.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        currentTicket = New PendingTicket
        currentTicket.age_category = dt.Rows(0)("age_category")
        currentTicket.decPrice = dt.Rows(0)("ticket_price")
        currentTicket.intShowtimeID = dt.Rows(0)("showtime_id")
        currentTicket.intPriceID = dt.Rows(0)("price_id")
        currentTicket.movie = currentMovie

        lblPrice.Text = "Price: " & currentTicket.decPrice.ToString("C")
    End Sub

    Private Sub btnListOfTicket_Click(sender As Object, e As EventArgs) Handles btnListOfTicket.Click
        Dim myList As New frmListTickets
        myList.setListOfTickets(ticketList)
        myList.ShowDialog()

        'update any
        lblTicketCount.Text = "Ticket Count: " & ticketList.Count
    End Sub

    Private Sub flpMovie_Paint(sender As Object, e As PaintEventArgs) Handles flpMovie.Paint

    End Sub

    'validation


End Class