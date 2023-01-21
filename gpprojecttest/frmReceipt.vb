Public Class frmReceipt
    Dim decTotal As Decimal
    Dim decDiscount As Decimal
    Dim decTax As Decimal
    Dim decNet As Decimal


    Dim ticketList As ArrayList

    'shared https://stackoverflow.com/questions/613998/what-is-the-use-of-a-shared-variable-in-vb-net
    Shared intStart As Integer = 0

    Public Sub New(discount As Decimal, user As User, ticketList As ArrayList, purchaseID As Integer)

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        Me.PurchasesTableAdapter.Fill(Me.CinemadbDataSet.purchases)
        'Time to get cookin
        lblName.Text = String.Format("Name: {0} {1}", user.strFName, user.strLName)
        lblPurchaseID.Text = "Purchase ID: " & purchaseID
        Me.ticketList = ticketList

        Dim dt As New cinemadbDataSet.purchasesDataTable
        PurchasesTableAdapter.FillByCustomerIDAndPurchaseID(dt, purchaseID, user.strUserID)

        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Something went wrong...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lblDate.Text = "Date: " & dt.Rows(0)("date_created")

        'tickets
        decTotal = 0
        For i = 0 To Me.ticketList.Count() - 1
            Dim ticket As PendingTicket = Me.ticketList.Item(i)
            dgvReceipt.Rows.Add(ticket.movie.strTitle, ticket.decPrice.ToString("C"))
            decTotal += ticket.decPrice
        Next
        decDiscount = decTotal * discount
        decTax = decTotal * 0.05
        decNet = (decTotal - decDiscount) + decTax

        lblPrice.Text = decTotal.ToString("C")
        lblDiscount.Text = decDiscount.ToString("C")
        lblTax.Text = decTax.ToString("C")
        lblNet.Text = decNet.ToString("C")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog.PrinterSettings = PrintDoc.PrinterSettings
        'reset to zero
        intStart = 0

        If PrintDialog.ShowDialog() = DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDialog.PrinterSettings
            Dim PageSetup As New Printing.PageSettings
            PageSetup.Margins.Left = 25
            PageSetup.Margins.Top = 50
            PageSetup.Margins.Right = 25
            PageSetup.Margins.Bottom = 50

            PrintDoc.DefaultPageSettings = PageSetup
        End If

        'display
        PrintPreview.Document = PrintDoc
        PrintPreview.ShowDialog()
    End Sub


    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim fntText As Font = New Font("MS Sans Serif", 12, FontStyle.Regular)
        Dim txtHeight As Integer
        Dim leftMargins = PrintDoc.DefaultPageSettings.Margins.Left
        Dim topMargins = PrintDoc.DefaultPageSettings.Margins.Top
        txtHeight = PrintDoc.DefaultPageSettings.PaperSize.Height - PrintDoc.DefaultPageSettings.Margins.Top -
            PrintDoc.DefaultPageSettings.Margins.Bottom

        Dim fntTitle = New Font("MS Sans Serif", 22, FontStyle.Italic)
        Dim fntBolded = New Font("MS Sans Serif", 16, FontStyle.Bold)

        Dim rectMain As New Rectangle(leftMargins, topMargins, e.MarginBounds.Width - leftMargins, 300)
        Dim rectTicket As New Rectangle(leftMargins, topMargins, e.MarginBounds.Width - leftMargins - 200, 260)
        Dim rectSeat As New Rectangle(leftMargins + rectTicket.Width, topMargins, e.MarginBounds.Width - rectTicket.Width - leftMargins, 260)

        'print tickets
        While intStart <= ticketList.Count() - 1
            Dim ticket As PendingTicket = ticketList(intStart)
            'get auditorium
            Dim dt As New cinemadbDataSet.auditoriumsDataTable
            AuditoriumsTableAdapter.FillAuditoriumByID(dt, ticket.movie.intAuditoriumID)
            If dt.Rows.Count <= 0 Then
                MessageBox.Show("Something went wrong. Auditorium not found!")
                Return
            End If
            'draw rectangle
            e.Graphics.DrawRectangle(Pens.Black, rectMain)
            e.Graphics.DrawRectangle(Pens.Black, rectTicket)
            e.Graphics.DrawRectangle(Pens.Black, rectSeat)
            'write inside
            e.Graphics.DrawImage(My.Resources.GTAlogo, leftMargins + 40, fntText.Height * 1 + topMargins, 400, 70)

            e.Graphics.DrawString("Seat No: ", fntText, Brushes.Black, leftMargins + 600, fntText.Height * 5 + topMargins)
            e.Graphics.DrawString(ticket.intSeatNumber, fntBolded, Brushes.Black, leftMargins + 725, fntText.Height * 5 + topMargins)
            e.Graphics.DrawString("Auditorium: ", fntText, Brushes.Black, leftMargins + 600, fntText.Height * 7 + topMargins)
            e.Graphics.DrawString(dt.Rows(0)("auditorium_name"), fntBolded, Brushes.Black, leftMargins + 725, fntText.Height * 7 + topMargins)

            e.Graphics.DrawString("Ticket ID: " & ticket.intShowtimeID, fntText, Brushes.Black, leftMargins + 20, fntText.Height * 5 + topMargins)
            e.Graphics.DrawString("Category: " & ticket.age_category.ToUpper, fntText, Brushes.Black, leftMargins + 200, fntText.Height * 5 + topMargins)
            e.Graphics.DrawString("Movie Title: ", fntText, Brushes.Black, leftMargins + 20, fntText.Height * 7 + topMargins)
            e.Graphics.DrawString(ticket.movie.strTitle, fntBolded, Brushes.Black, leftMargins + 20, fntText.Height * 8 + topMargins)

            e.Graphics.DrawString("Date: ", fntText, Brushes.Black, leftMargins + 20, fntText.Height * 11 + topMargins)
            e.Graphics.DrawString(ticket.movie.dtShowtime.ToString("g"), fntBolded, Brushes.Black, leftMargins + 20, fntText.Height * 12 + topMargins)
            e.Graphics.DrawString("Price: ", fntText, Brushes.Black, leftMargins + 450, fntText.Height * 11 + topMargins)
            e.Graphics.DrawString(ticket.decPrice.ToString("c"), fntBolded, Brushes.Black, leftMargins + 450, fntText.Height * 12 + topMargins)
            'print more tickets
            intStart += 1
            e.HasMorePages = True
            Return
        End While

        'print receipt
        e.Graphics.DrawString("WELCOME TO GTA CINEMA!", fntTitle, Brushes.Black, leftMargins + 150, fntTitle.Height * 0 + topMargins)
        e.Graphics.DrawString(lblPurchaseID.Text, fntText, Brushes.Black, leftMargins, fntText.Height * 2 + topMargins)
        e.Graphics.DrawString(lblDate.Text, fntText, Brushes.Black, leftMargins + 450, fntText.Height * 2 + topMargins)
        e.Graphics.DrawString("==============================================================================", fntText, Brushes.Black, leftMargins, fntText.Height * 3 + topMargins)
        e.Graphics.DrawString("Movie Name", fntText, Brushes.Black, leftMargins, fntText.Height * 4 + topMargins)
        e.Graphics.DrawString("Price (RM)", fntText, Brushes.Black, leftMargins + 500, fntText.Height * 4 + topMargins)
        For i = 0 To ticketList.Count() - 1
            Dim ticket As PendingTicket = ticketList.Item(i)
            e.Graphics.DrawString(ticket.movie.strTitle, fntText, Brushes.Black, leftMargins, fntText.Height * (5 + i) + topMargins)
            e.Graphics.DrawString(ticket.decPrice.ToString("C"), fntText, Brushes.Black, leftMargins + 500, fntText.Height * (5 + i) + topMargins)
        Next
        e.Graphics.DrawString("==============================================================================", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 6) + topMargins)
        e.Graphics.DrawString("Total Price (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 7) + topMargins)
        e.Graphics.DrawString(lblPrice.Text, fntText, Brushes.Black, leftMargins + 500, fntText.Height * (ticketList.Count + 7) + topMargins)

        e.Graphics.DrawString("Discount (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 8) + topMargins)
        e.Graphics.DrawString(lblDiscount.Text, fntText, Brushes.Black, leftMargins + 500, fntText.Height * (ticketList.Count + 8) + topMargins)

        e.Graphics.DrawString("Tax (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 9) + topMargins)
        e.Graphics.DrawString(lblTax.Text, fntText, Brushes.Black, leftMargins + 500, fntText.Height * (ticketList.Count + 9) + topMargins)

        e.Graphics.DrawString("Net Price (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 10) + topMargins)
        e.Graphics.DrawString(lblNet.Text, fntText, Brushes.Black, leftMargins + 500, fntText.Height * (ticketList.Count + 10) + topMargins)

        e.Graphics.DrawString("THANK YOU & PLEASE COME AGAIN", fntTitle, Brushes.Black, leftMargins + 100, fntText.Height * (ticketList.Count + 12) + topMargins)

    End Sub
End Class