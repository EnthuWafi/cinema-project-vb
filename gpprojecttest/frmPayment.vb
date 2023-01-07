Public Class frmPayment
    Dim myMain As frmMain

    Public Sub New(ByRef myMain As frmMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.myMain = myMain
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Dim myReceipt As New frmReceipt

        Me.Hide()
        myReceipt.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        myMain.Show()
    End Sub
End Class