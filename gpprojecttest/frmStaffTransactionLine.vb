Public Class frmStaffTransactionLine
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
            dgvInvoiceLine.Rows.Add(dt.Rows(i)("movie_name"), dt.Rows(i)("auditorium_name"),
                                    dt.Rows(i)("seat_num"), Decimal.Parse(dt.Rows(i)("ticket_price")).ToString("C"))
        Next

        dgvInvoiceLine.AllowUserToAddRows = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class