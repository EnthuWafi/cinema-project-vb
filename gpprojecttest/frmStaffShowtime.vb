Public Class frmStaffShowtime
    Dim movieID As ArrayList
    Dim auditoriumID As ArrayList

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dtpDate.MinDate = New DateTime(2023, 1, 9)
        movieID = New ArrayList
        auditoriumID = New ArrayList
        UpdateShowtime()
    End Sub
    Private Sub btnAddShowtime_Click(sender As Object, e As EventArgs) Handles btnAddShowtime.Click
        If cboMovie.SelectedIndex = -1 Then
            errorProvider.SetError(cboMovie, "Must be filled!")
            Return
        End If
        errorProvider.SetError(cboMovie, "")

        If cboAuditorium.SelectedIndex = -1 Then
            errorProvider.SetError(cboAuditorium, "Must be filled!")
            Return
        End If
        errorProvider.SetError(cboAuditorium, "")

        If txtAdult.Text = String.Empty Or Not IsNumeric(txtAdult.Text) Then
            errorProvider.SetError(txtAdult, "Must be valid and filled!")
            Return
        End If
        errorProvider.SetError(txtAdult, "")
        If txtChildren.Text = String.Empty Or Not IsNumeric(txtChildren.Text) Then
            errorProvider.SetError(txtChildren, "Must be valid and filled!")
            Return
        End If
        errorProvider.SetError(txtChildren, "")

        Dim currentDate = DateTime.Parse(dtpDate.Value)
        Dim time As DateTime

        If Not DateTime.TryParseExact(txtTime.Text, "hh:mm tt", Globalization.DateTimeFormatInfo.InvariantInfo,
    Globalization.DateTimeStyles.None, time) Then
            errorProvider.SetError(txtTime, "Use HH:mm AM/PM format!")
            Return
        End If
        errorProvider.SetError(txtTime, "")

        Dim startTime As New DateTime(currentDate.Year, currentDate.Month, currentDate.Day, time.Hour, time.Minute, time.Second)
        'add to database
        ShowtimesTableAdapter.InsertShowtime(movieID(cboMovie.SelectedIndex), auditoriumID(cboAuditorium.SelectedIndex), startTime)
        Dim id As Integer = ShowtimesTableAdapter.GetLastID

        Ticket_priceTableAdapter.InsertTicket("Adult", Decimal.Parse(txtAdult.Text), id)
        Ticket_priceTableAdapter.InsertTicket("Children", Decimal.Parse(txtChildren.Text), id)

        'clear
        dtpDate.Value = dtpDate.MinDate

        cboMovie.SelectedIndex = -1
        cboAuditorium.SelectedIndex = -1
        txtAdult.Text = String.Empty
        txtChildren.Text = String.Empty
        txtTime.Text = String.Empty
        UpdateShowtime()
    End Sub

    Private Sub UpdateShowtime()
        dgvShowtime.Rows.Clear()
        cboMovie.Items.Clear()
        movieID.Clear()
        cboAuditorium.Items.Clear()


        Dim dt As New cinemadbDataSet.showtimesDataTable
        ShowtimesTableAdapter.FillByJoin(dt)

        If (dt.Rows.Count <= 0) Then
            MessageBox.Show("Something went wrong.")
            Return
        End If

        For i = 0 To dt.Rows.Count - 1
            Dim dtTicket As New cinemadbDataSet.ticket_priceDataTable
            Ticket_priceTableAdapter.FillByShowtimeID(dtTicket, dt.Rows(i)("showtime_id"))

            Dim ticketPrice As String = String.Empty
            If dtTicket.Rows.Count <= 1 Then
                ticketPrice = "NULL"
            Else
                For j = 0 To dtTicket.Rows.Count - 1
                    ticketPrice &= dtTicket.Rows(j)("age_category") & "-" & (Decimal.Parse(dtTicket.Rows(j)("ticket_price"))).ToString("C") & " "
                Next
            End If

            dgvShowtime.Rows.Add(dt.Rows(i)("showtime_id"), dt.Rows(i)("movie_name"), dt.Rows(i)("auditorium_name"), dt.Rows(i)("start_time"),
                dt.Rows(i)("end_time"), ticketPrice)
            
        Next

        'auditorium
        Dim dtMovies As New cinemadbDataSet.moviesDataTable
        MoviesTableAdapter.Fill(dtMovies)
        For i = 0 To dtMovies.Rows.Count - 1
            'add to movie cbo
            cboMovie.Items.Add(dtMovies.Rows(i)("movie_name"))
            'add to array
            movieID.Add(dtMovies.Rows(i)("movie_id"))
        Next

        'auditorium
        Dim dtAuditorium As New cinemadbDataSet.auditoriumsDataTable
        AuditoriumsTableAdapter.Fill(dtAuditorium)
        For i = 0 To dtAuditorium.Rows.Count - 1
            cboAuditorium.Items.Add(dtAuditorium.Rows(i)("auditorium_name"))
            auditoriumID.Add(dtAuditorium.Rows(i)("auditorium_id"))
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear
        dtpDate.Value = dtpDate.MinDate

        cboMovie.SelectedIndex = -1
        cboAuditorium.SelectedIndex = -1
        txtAdult.Text = String.Empty
        txtChildren.Text = String.Empty
        txtTime.Text = String.Empty
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

End Class