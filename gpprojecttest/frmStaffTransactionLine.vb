Public Class frmStaffTransactionLine
    Dim purchaseID As Integer

    Public Sub New(id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Purchase_lineTableAdapter.Fill(Me.CinemadbDataSet.purchase_line)

        Dim dt As New cinemadbDataSet.purchase_lineDataTable
        Purchase_lineTableAdapter.FillByJoin(dt, id)

        If dt.Rows.Count <= 0 Then
            MessageBox.Show("This invoice is empty!")
            Return
        End If

        For i = 0 To dt.Rows.Count - 1
            Dim decPrice = Decimal.Parse(dt.Rows(i)("ticket_price")) - (Decimal.Parse(dt.Rows(i)("ticket_price")) * Decimal.Parse(dt.Rows(i)("discount")))
            dgvInvoiceLine.Rows.Add(dt.Rows(i)("movie_name"), dt.Rows(i)("auditorium_name"),
                                    dt.Rows(i)("seat_num"), decPrice.ToString("C"))
        Next

        dgvInvoiceLine.AllowUserToAddRows = False

        'get purchase info
        Me.purchaseID = id

        'title
        Me.Text = "Transaction: Purchase ID " & purchaseID
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'are you sure message
        If MessageBox.Show("Are you sure? This action is irreversible.", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            'clear everything
            Try
                PurchasesTableAdapter.DeleteID(purchaseID)

                MessageBox.Show("Transaction has been deleted!")
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("An error has occured!" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class