Public Class frmStaffTransaction
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'database
        Me.PurchasesTableAdapter.Fill(Me.CinemadbDataSet.purchases)

        Dim dt As New cinemadbDataSet.purchasesDataTable
        PurchasesTableAdapter.FillInvoiceIDAndCustomer(dt)

        If dt.Rows.Count <= 0 Then
            MessageBox.Show("Something went wrong.")
        End If

        For i = 0 To dt.Rows.Count - 1
            dgvInvoice.Rows.Add(dt.Rows(i)("purchase_id"), dt.Rows(i)("cust_fname") & " " & dt.Rows(i)("cust_lname"),
                                dt.Rows(i)("date_created"))
        Next
    End Sub

    Private Sub dgvInvoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoice.CellClick
        If e.RowIndex = -1 Then
            Return
        End If
        If dgvInvoice.SelectedCells.Count = 1 Then
            Dim index As Integer = dgvInvoice.CurrentCell.RowIndex
            Dim selectedRow = dgvInvoice.Rows(index)
            Dim id As Integer = selectedRow.Cells("invoiceID").Value

            'summon shenron
            Dim myInvoice As New frmStaffTransactionLine(id)
            myInvoice.ShowDialog()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class