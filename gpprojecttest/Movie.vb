Public Class Movie
    Public flowLayout As New FlowLayoutPanel
    Public strPic, strTitle, strGenre, strDuration, strShowtime As String
    'new window stuff
    Public strDesc, strReleaseDate As String

    Public Sub New(strPic As String, strTitle As String, strGenre As String, strDuration As String, strShowtime As String)
        Me.strPic = strPic
        Me.strTitle = strTitle
        Me.strGenre = strGenre
        Me.strDuration = strDuration
        Me.strShowtime = strShowtime

        'anchors and direction
        flowLayout.Anchor = AnchorStyles.Top + AnchorStyles.Left
        flowLayout.FlowDirection = FlowDirection.TopDown
        flowLayout.AutoSize = True
        flowLayout.Padding = New Padding(50, 20, 50, 50)


        Dim picBox As New PictureBox
        picBox.Image = gpprojecttest.My.Resources.ResourceManager.GetObject(Me.strPic)
        picBox.Size = New Size(150, 150)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
        picBox.Anchor = AnchorStyles.None
        flowLayout.Controls.Add(picBox)

        Dim lblTitle As New Label
        lblTitle.Text = Me.strTitle
        lblTitle.Anchor = AnchorStyles.None
        flowLayout.Controls.Add(lblTitle)

        Dim lblGenre As New Label
        lblGenre.Text = Me.strGenre
        lblGenre.Anchor = AnchorStyles.None
        flowLayout.Controls.Add(lblGenre)

        Dim lblDuration As New Label
        lblDuration.Text = Me.strDuration
        lblDuration.Anchor = AnchorStyles.None
        flowLayout.Controls.Add(lblDuration)

        Dim lblShowtime As New Label
        lblShowtime.Text = Me.strShowtime
        lblShowtime.Anchor = AnchorStyles.None
        flowLayout.Controls.Add(lblShowtime)

        Dim btnMore As New Button
        btnMore.Text = "MORE INFO"
        btnMore.BackColor = SystemColors.ButtonFace
        btnMore.Size = New Size(110, 30)
        btnMore.Anchor = AnchorStyles.Bottom
        flowLayout.Controls.Add(btnMore)
        AddHandler btnMore.Click, AddressOf btnMore_Click

    End Sub

    Public Sub btnMore_Click(sender As Object, e As EventArgs)
        Dim newWindow As New Form
        newWindow.Text = "Movie Info: " & strTitle
        newWindow.MaximizeBox = False
        newWindow.Size = New Size(600, 400)
        newWindow.BackgroundImage = gpprojecttest.My.Resources.ResourceManager.GetObject("cinema_red")
        newWindow.Padding = New Padding(10)

        Dim tableLayout As New TableLayoutPanel
        Dim detailsLayout As New TableLayoutPanel
        Dim picBox As New PictureBox
        Dim lblTitle, lblGenre, lblDuration, lblShowtime As New Label

        picBox.Image = gpprojecttest.My.Resources.ResourceManager.GetObject(strPic)
        picBox.Size = New Size(250, 250)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage

        lblTitle.Text = strTitle
        lblGenre.Text = strGenre
        lblDuration.Text = strDuration
        lblShowtime.Text = strShowtime

        tableLayout.Dock = DockStyle.Fill
        tableLayout.ColumnCount = 2
        tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 150%))
        tableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100%))
        tableLayout.BackColor = Color.LightGoldenrodYellow

        detailsLayout.ColumnCount = 1
        detailsLayout.RowCount = 3
        detailsLayout.Controls.Add(lblTitle, 0, 0)
        detailsLayout.Controls.Add(lblGenre, 0, 1)
        detailsLayout.Controls.Add(lblDuration, 0, 2)

        tableLayout.Controls.Add(picBox, 0, 0)
        tableLayout.Controls.Add(detailsLayout, 1, 0)
        tableLayout.Controls.Add(lblShowtime, 1, 1)
        tableLayout.Padding = New Padding(10)

        newWindow.Controls.Add(tableLayout)
        newWindow.Show()

    End Sub


End Class
