Public Class frmReceipt
    Dim decTotal As Decimal
    Dim decDiscount As Decimal
    Dim decTax As Decimal
    Dim decNet As Decimal

    Dim ticketList As ArrayList

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
        'print
        e.Graphics.DrawString("WELCOME TO GTA CINEMA!", fntTitle, Brushes.Black, leftMargins + 150, fntTitle.Height * 0 + topMargins)
        e.Graphics.DrawString(lblPurchaseID.Text, fntText, Brushes.Black, leftMargins, fntText.Height * 2 + topMargins)
        e.Graphics.DrawString(lblDate.Text, fntText, Brushes.Black, leftMargins + 200, fntText.Height * 2 + topMargins)
        e.Graphics.DrawString("==============================================================================", fntText, Brushes.Black, leftMargins, fntText.Height * 3 + topMargins)
        e.Graphics.DrawString("Movie Name", fntText, Brushes.Black, leftMargins, fntText.Height * 4 + topMargins)
        e.Graphics.DrawString("Price (RM)", fntText, Brushes.Black, leftMargins + 300, fntText.Height * 4 + topMargins)
        For i = 0 To ticketList.Count() - 1
            Dim ticket As PendingTicket = ticketList.Item(i)
            e.Graphics.DrawString(ticket.movie.strTitle, fntText, Brushes.Black, leftMargins, fntText.Height * (5 + i) + topMargins)
            e.Graphics.DrawString(ticket.decPrice.ToString("C"), fntText, Brushes.Black, leftMargins + 300, fntText.Height * (5 + i) + topMargins)
        Next
        e.Graphics.DrawString("==============================================================================", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 6) + topMargins)
        e.Graphics.DrawString("Total Price (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 7) + topMargins)
        e.Graphics.DrawString(lblPrice.Text, fntText, Brushes.Black, leftMargins + 300, fntText.Height * (ticketList.Count + 7) + topMargins)

        e.Graphics.DrawString("Discount (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 8) + topMargins)
        e.Graphics.DrawString(lblDiscount.Text, fntText, Brushes.Black, leftMargins + 300, fntText.Height * (ticketList.Count + 8) + topMargins)

        e.Graphics.DrawString("Tax (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 9) + topMargins)
        e.Graphics.DrawString(lblTax.Text, fntText, Brushes.Black, leftMargins + 300, fntText.Height * (ticketList.Count + 9) + topMargins)

        e.Graphics.DrawString("Net Price (RM)", fntText, Brushes.Black, leftMargins, fntText.Height * (ticketList.Count + 10) + topMargins)
        e.Graphics.DrawString(lblNet.Text, fntText, Brushes.Black, leftMargins + 300, fntText.Height * (ticketList.Count + 10) + topMargins)

        e.Graphics.DrawString("THANK YOU & PLEASE COME AGAIN", fntTitle, Brushes.Black, leftMargins + 100, fntText.Height * (ticketList.Count + 12) + topMargins)

    End Sub
End Class