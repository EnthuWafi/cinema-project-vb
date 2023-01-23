Public Class frmStaffTransaction
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'database
        Me.PurchasesTableAdapter.Fill(Me.CinemadbDataSet.purchases)

        UpdateInvoice()
    End Sub

    Private Sub UpdateInvoice()
        dgvInvoice.Rows.Clear()
        Dim dt As New cinemadbDataSet.purchasesDataTable
        PurchasesTableAdapter.FillInvoiceIDAndCustomer(dt)

        If dt.Rows.Count <= 0 Then
            Return
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

            UpdateInvoice()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnClearTable_Click(sender As Object, e As EventArgs) Handles btnClearTable.Click
        'are you sure message
        If MessageBox.Show("Are you sure? This action is irreversible.", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            'clear everything
            Try
                PurchasesTableAdapter.DeleteAll()

                UpdateInvoice()
                MessageBox.Show("All Transaction has been cleared!")
            Catch ex As Exception
                MessageBox.Show("An error has occured!" & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class