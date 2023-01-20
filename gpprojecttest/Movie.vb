Public Class Movie
    Public flowLayout As New FlowLayoutPanel
    Public intShowtimeID, intMovieID, intAuditoriumID As Integer
    Public strPic, strTitle, strGenre As String
    Public decDuration As Decimal
    Public dtShowtime, dtEndtime As DateTime

    'new window stuff
    Public strDesc, strReleaseDate As String

    Public Sub New(intShowtimeID As Integer, intMovieID As Integer, intAuditoriumID As Integer, strPic As String, strTitle As String, strGenre As String, decDuration As Decimal, dtShowtime As DateTime, dtEndTime As DateTime, strDesc As String, strReleaseDate As String)
        Me.intShowtimeID = intShowtimeID
        Me.intMovieID = intMovieID
        Me.intAuditoriumID = intAuditoriumID
        Me.strPic = strPic
        Me.strTitle = strTitle
        Me.strGenre = strGenre
        Me.decDuration = decDuration
        Me.dtShowtime = dtShowtime
        Me.dtEndtime = dtEndTime
        Me.strDesc = strDesc
        Me.strReleaseDate = strReleaseDate

        'anchors and direction
        flowLayout.Anchor = AnchorStyles.Top + AnchorStyles.Left
        flowLayout.FlowDirection = FlowDirection.TopDown
        flowLayout.Size = New Size(300, 350)
        flowLayout.Margin = New Padding(50, 10, 50, 20)

        Dim picBox As New PictureBox
        picBox.Image = My.Resources.ResourceManager.GetObject(Me.strPic)
        picBox.Size = New Size(175, 200)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
        picBox.Anchor = AnchorStyles.None

        'if image doesn't exist
        If My.Resources.ResourceManager.GetObject(Me.strPic) Is Nothing Then
            picBox.Image = My.Resources.image_placeholder
        End If

        flowLayout.Controls.Add(picBox)

        Dim lblTitle As New Label
        lblTitle.Text = Me.strTitle
        lblTitle.Font = New Font("Noto Sans", 12, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.AutoSize = True
        lblTitle.Anchor = AnchorStyles.None
        lblTitle.Margin = New Padding(0, 2, 0, 2)
        flowLayout.Controls.Add(lblTitle)

        Dim lblGenre As New Label
        lblGenre.Text = Me.strGenre
        lblGenre.AutoSize = True
        lblGenre.ForeColor = Color.White
        lblGenre.Anchor = AnchorStyles.None
        lblGenre.Margin = New Padding(5)
        flowLayout.Controls.Add(lblGenre)

        Dim lblDuration As New Label
        Dim ts As TimeSpan = TimeSpan.FromMinutes(Me.decDuration)
        lblDuration.Text = String.Format("{0:00}h {1:00}m", ts.TotalHours, ts.Minutes)
        lblDuration.AutoSize = True
        lblDuration.ForeColor = Color.White
        lblDuration.Anchor = AnchorStyles.None
        flowLayout.Controls.Add(lblDuration)

        Dim lblShowtime As New Label
        lblShowtime.Text = Me.dtShowtime.ToShortTimeString & " - " & Me.dtEndtime.ToShortTimeString
        lblShowtime.AutoSize = True
        lblShowtime.ForeColor = Color.White
        lblShowtime.Anchor = AnchorStyles.None
        lblShowtime.Margin = New Padding(3)
        flowLayout.Controls.Add(lblShowtime)

        Dim btnMore As New Button
        btnMore.Text = "MORE INFO"
        btnMore.BackColor = SystemColors.ButtonFace
        btnMore.Size = New Size(110, 30)
        btnMore.Anchor = AnchorStyles.Bottom
        btnMore.Margin = New Padding(0, 5, 0, 0)
        flowLayout.Controls.Add(btnMore)

        AddHandler btnMore.Click, AddressOf btnMore_Click

    End Sub

    'new windows form
    Public Sub btnMore_Click(sender As Object, e As EventArgs)
        Dim newWindow As New Form
        newWindow.Text = "Movie Info: " & strTitle
        newWindow.MaximizeBox = False
        newWindow.FormBorderStyle = FormBorderStyle.FixedToolWindow

        newWindow.Size = New Size(600, 450)
        newWindow.BackgroundImage = gpprojecttest.My.Resources.ResourceManager.GetObject("cinema_red")
        newWindow.Padding = New Padding(10)

        Dim tableLayout As New TableLayoutPanel
        Dim detailsLayout As New TableLayoutPanel

        'controls inside the form
        Dim picBox As New PictureBox
        picBox.Image = My.Resources.ResourceManager.GetObject(Me.strPic)
        picBox.Size = New Size(175, 200)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage

        'if image doesn't exist
        If My.Resources.ResourceManager.GetObject(Me.strPic) Is Nothing Then
            picBox.Image = My.Resources.image_placeholder
        End If


        Dim lblTitle As New Label
        lblTitle.Text = Me.strTitle
        lblTitle.Font = New Font("Noto Sans", 15, FontStyle.Bold)
        lblTitle.AutoSize = True
        lblTitle.Margin = New Padding(0, 5, 0, 5)


        Dim lblGenre As New Label
        lblGenre.Text = Me.strGenre
        lblGenre.AutoSize = True
        lblGenre.Margin = New Padding(5)


        Dim lblDuration As New Label
        Dim ts As TimeSpan = TimeSpan.FromMinutes(Me.decDuration)
        lblDuration.Text = String.Format("{0:00}h {1:00}m", ts.TotalHours, ts.Minutes)
        lblDuration.AutoSize = True

        Dim lblShowtime As New Label
        lblShowtime.Text = Me.dtShowtime.ToShortTimeString & " - " & Me.dtEndtime.ToShortTimeString
        lblShowtime.AutoSize = True
        lblShowtime.Margin = New Padding(3)

        Dim lblMovieDesc As New Label
        lblMovieDesc.AutoSize = True
        lblMovieDesc.Text = Me.strDesc
        lblMovieDesc.Margin = New Padding(0, 0, 10, 0)

        Dim lblReleaseDate As New Label
        lblReleaseDate.Text = "Release Date: " & Me.strReleaseDate
        lblReleaseDate.AutoSize = True
        lblReleaseDate.Margin = New Padding(3)
        'end

        tableLayout.Dock = DockStyle.Fill
        tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 190))
        tableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 375))
        tableLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 208))
        tableLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 40))
        tableLayout.BackColor = Color.LightGoldenrodYellow
        tableLayout.Size = newWindow.Size

        detailsLayout.ColumnCount = 1
        detailsLayout.RowCount = 4
        detailsLayout.Controls.Add(lblTitle, 0, 0)
        detailsLayout.Controls.Add(lblGenre, 0, 1)
        detailsLayout.Controls.Add(lblDuration, 0, 2)
        detailsLayout.Controls.Add(lblShowtime, 0, 3)
        detailsLayout.AutoSize = True

        tableLayout.Controls.Add(picBox, 0, 0)
        tableLayout.Controls.Add(detailsLayout, 1, 0)
        tableLayout.Controls.Add(lblReleaseDate, 0, 1)
        tableLayout.Controls.Add(lblMovieDesc, 1, 1)

        tableLayout.Padding = New Padding(10)

        newWindow.Controls.Add(tableLayout)
        newWindow.Show()

    End Sub


End Class
