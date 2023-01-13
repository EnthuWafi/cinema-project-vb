Imports System.IO
Public Class frmStaffMovie
    Private Sub btnAddMovie_Click(sender As Object, e As EventArgs) Handles btnAddMovie.Click
        If txtMovie.Text = String.Empty Then
            errorProvider.SetError(txtMovie, "Must be filled!")
            Return
        End If
        errorProvider.SetError(txtMovie, "")

        Dim movieRelease As DateTime
        If Not DateTime.TryParseExact(txtRelease.Text, "dd/MM/yyyy", Globalization.DateTimeFormatInfo.InvariantInfo,
    Globalization.DateTimeStyles.None, movieRelease) Then
            errorProvider.SetError(txtRelease, "Use dd/MM/yyyy format!")
            Return
        End If
        errorProvider.SetError(txtRelease, "")

        If txtGenre.Text = String.Empty Then
            errorProvider.SetError(txtGenre, "Must be filled!")
            Return
        End If
        errorProvider.SetError(txtGenre, "")

        If txtDuration.Text = String.Empty Or Not IsNumeric(txtDuration.Text) Then
            errorProvider.SetError(txtDuration, "Must be valid and filled!")
            Return
        End If
        errorProvider.SetError(txtDuration, "")
        Dim intDuration As Integer = Integer.Parse(txtDuration.Text)

        If txtDesc.Text = String.Empty Then
            errorProvider.SetError(txtDesc, "Must be filled!")
            Return
        End If
        errorProvider.SetError(txtDesc, "")

        'if all valid
        'add to database

        MoviesTableAdapter.InsertMovie(txtMovie.Text, movieRelease.ToShortDateString, txtGenre.Text,
        intDuration, txtDesc.Text, "image_placeholder")
        MessageBox.Show("Added to database.")
        'clear
        txtMovie.Text = String.Empty
        txtRelease.Text = String.Empty
        txtGenre.Text = String.Empty
        txtDuration.Text = String.Empty
        txtDesc.Text = String.Empty
        'update
        UpdateMovies()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
        Me.MoviesTableAdapter.Fill(Me.CinemadbDataSet.movies)

        'database display
        UpdateMovies()
    End Sub


    Private Sub UpdateMovies()
        dgvMovie.Rows.Clear()
        Dim dt As New cinemadbDataSet.moviesDataTable
        MoviesTableAdapter.Fill(dt)

        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Something went wrong.")
            Return
        End If


        For i = 0 To dt.Rows.Count() - 1
            Dim image = My.Resources.ResourceManager.GetObject(dt.Rows(i)("movie_img"))
            dgvMovie.Rows.Add(image, dt.Rows(i)("movie_name"), dt.Rows(i)("release_date"), dt.Rows(i)("genre"),
                        dt.Rows(i)("duration"), dt.Rows(i)("movie_desc"))
            dgvMovie.Rows(i).Height = 250
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear
        txtMovie.Text = String.Empty
        txtRelease.Text = String.Empty
        txtGenre.Text = String.Empty
        txtDuration.Text = String.Empty
        txtDesc.Text = String.Empty

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class