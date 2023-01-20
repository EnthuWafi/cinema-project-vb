Public Class frmPayment
    Dim myMain As frmMain
    Dim myUser As User

    Dim ticketList As ArrayList
    Dim discount As Decimal

    Dim decTotal As Decimal

    Public Sub New(ticketList As ArrayList, user As User)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ticketList = ticketList
        Me.myUser = user

        dgvTickets.Rows.Clear()
        decTotal = 0
        'display information in data grid view
        For i = 0 To ticketList.Count - 1
            'ticket
            Dim ticket As PendingTicket = ticketList.Item(i)
            'movie
            Dim movie As Movie = ticket.movie

            'select from table for auditorium name
            Dim dt As New cinemadbDataSet.auditoriumsDataTable
            AuditoriumsTableAdapter.FillAuditoriumByID(dt, movie.intAuditoriumID)

            'add to data grid view!
            dgvTickets.Rows.Add(My.Resources.ResourceManager.GetObject(movie.strPic),
                                movie.strTitle, dt.Rows(0)("auditorium_name"),
                                ticket.intSeatNumber, ticket.age_category, ticket.decPrice.ToString("C"),
                                "More Info")
            dgvTickets.Rows(i).Height = 200
            'add dectotal
            decTotal += ticket.decPrice
        Next
        lblPrice.Text = "Total Price: " & decTotal.ToString("C")
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'final check
        If MessageBox.Show("Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
            Return
        End If

        'add to database
        Me.PurchasesTableAdapter.InsertPurchase(Integer.Parse(myUser.strUserID))
        Dim purchaseID As Integer = PurchasesTableAdapter.GetLastID()

        For i = 0 To ticketList.Count - 1
            Dim ticket As PendingTicket = ticketList(i)
            Purchase_lineTableAdapter.InsertTicket(purchaseID, ticket.intSeatNumber, ticket.intShowtimeID, ticket.intPriceID)
        Next

        MessageBox.Show("Transaction Complete!")
        'receipt
        Dim myReceipt As New frmReceipt(discount, myUser, ticketList, purchaseID)
        Me.Hide()
        myReceipt.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        myMain.Show()
    End Sub

    'set my main
    Public Sub setMain(ByRef myMain As frmMain)
        Me.myMain = myMain
    End Sub

    Private Sub dgvTickets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTickets.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        If e.ColumnIndex = dgvTickets.Columns("movieInfo").Index Then
            Dim ticket As PendingTicket = ticketList(e.RowIndex)
            ticket.movie.btnMore_Click(sender, e)
        End If
    End Sub

    'not really important tbh
    'cash
    Private Sub radCash_CheckedChanged(sender As Object, e As EventArgs) Handles radCash.CheckedChanged
        btnProceed.Enabled = True

        lblTop.Text = "Pay upfront."
        txtTop.Visible = False
        lblBottom.Visible = False
        cboBottom.Visible = False

        discount = 0
    End Sub

    Private Sub radOnline_CheckedChanged(sender As Object, e As EventArgs) Handles radOnline.CheckedChanged
        btnProceed.Enabled = False

        txtTop.Text = String.Empty
        cboBottom.SelectedIndex = -1

        txtTop.Visible = True
        lblTop.Text = "Enter your PIN NUMBER: "
        txtTop.UseSystemPasswordChar = True

        lblBottom.Visible = True
        cboBottom.Visible = True

        lblBottom.Text = "BANK NAME: "
        cboBottom.Items.Clear()
        cboBottom.Items.Add("BANK ISLAM")
        cboBottom.Items.Add("BANK MUAMALAT")
        cboBottom.Items.Add("CIMB")
        cboBottom.Items.Add("MAYBANK")

        discount = 0
    End Sub

    Private Sub radTNG_CheckedChanged(sender As Object, e As EventArgs) Handles radTNG.CheckedChanged
        btnProceed.Enabled = False

        txtTop.Text = String.Empty
        cboBottom.SelectedIndex = -1

        txtTop.Visible = True
        lblTop.Text = "Enter your PIN NUMBER: "
        txtTop.UseSystemPasswordChar = True

        lblBottom.Visible = False
        cboBottom.Visible = False

        cboBottom.SelectedIndex = -1

        discount = 0.05
    End Sub

    Private Sub txtTop_TextChanged(sender As Object, e As EventArgs) Handles txtTop.TextChanged
        'if tng
        If Not cboBottom.Visible Then
            btnProceed.Enabled = True
            Return
        End If

        'if online
        If cboBottom.SelectedIndex <> -1 Then
            btnProceed.Enabled = True
        End If
    End Sub


    Private Sub cboBottom_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBottom.SelectionChangeCommitted
        'if online
        If cboBottom.SelectedIndex <> -1 Then
            btnProceed.Enabled = True
        End If
    End Sub

    Private Sub txtTop_Leave(sender As Object, e As EventArgs) Handles txtTop.Leave
        If txtTop.Text = String.Empty Then
            btnProceed.Enabled = False
        End If
    End Sub
End Class